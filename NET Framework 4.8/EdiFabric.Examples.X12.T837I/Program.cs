using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T837I
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());
            Read();
            Write();
        }

        /// <summary>
        /// Read Institutional Claim
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\Hipaa\InstitutionalClaim.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS837I>();

            foreach (var transaction in transactions)
            {
                if (transaction.HasErrors)
                {
                    //  partially parsed
                    var errors = transaction.ErrorContext.Flatten();
                }
            }
        }

        /// <summary>
        /// Write Institutional Claim
        /// </summary>
        static void Write()
        {
            var transaction = BuildInstitutionalClaim("987654");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X223A2"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build institutional claim.
        /// Original from http://www.x12.org/examples/005010X223/institutional/837-institutional-claim/
        /// The patient is a different person than the subscriber. The payer is a commercial health insurance company.
        /// Scenario:
        /// PRIMARY PAYER SUBSCRIBER: John T Doe
        /// SUBSCRIBER ADDRESS: 125 City Avenue, Centerville, PA 17111
        /// SEX: M
        /// DOB: 11/11/1926
        /// MEDICARE INSURANCE ID#: 030005074A
        /// PAYER ID #: 00435
        /// PATIENT: Same as Primary Subscriber
        /// DESTINATION PAYER: Medicare B
        /// SUBMITTER: Jones Hospital
        /// EDI#: 12345
        /// RECEIVER: Medicare
        /// EDI#: 00120
        /// BILLING PROVIDER: Jones Hospital
        /// NPI: 9876540809
        /// TIN: 567891234
        /// MEDICARE PROVIDER: #330127
        /// ADDRESS: 225 Main Street Barkley Building, Centerville, PA 17111
        /// ATTENDING PHYSICIAN: John J Jones
        /// UPIN #: B99937
        /// PATIENT ACCOUNT NUMBER: 756048Q
        /// DATE OF ADMISSION: 09/11/96
        /// STATEMENT PERIOD DATE: 09/11/96 - 09/11/96
        /// PLACE OF SERVICE: Inpatient Hospital
        /// Occurrence Codes and Dates:
        /// A1 11/11/26
        /// A2 11/01/91
        /// B1 11/11/26
        /// B2 01/01/87
        /// Condition Codes: 09
        /// Value Codes: A2 $15.31
        /// PRINCIPAL DIAGNOSIS CODE: 366.9
        /// SECONDARY DIAGNOSIS CODES:
        /// 401.9
        /// 794.31
        /// NUMBER OF COVERED DAYS: 1
        /// SERVICES:
        /// INSTITUTIONAL SERVICES RENDERED:
        /// REVENUE CODE: 0305 HCPCS Procedure Code: 85025 Unit: 1 Price $13.39
        /// REVENUE CODE: 0730 HCPCS Procedure Code: 93005 Unit: 1 Price: $76.54
        /// TOTAL CHARGES: $89.93
        /// SECONDARY PAYER SUBSCRIBER: Jane S Doe(wife)
        /// SUBSCRIBER ADDRESS: 125 City Avenue, Centerville, PA 17111
        /// SEX: F
        /// DOB: 12/11/1927
        /// STATE TEACHERS ID#: 222004433
        /// PAYER ID #: 1135
        /// </summary>
        static TS837I BuildInstitutionalClaim(string controlNumber)
        {
            var result = new TS837I();

            //  ST TRANSACTION SET HEADER
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "837";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X223A2";

            //  BHT BEGINNING OF HIERARCHICAL TRANSACTION
            result.BHT_BeginningOfHierarchicalTransaction = new BHT_BeginningOfHierarchicalTransaction_8();
            result.BHT_BeginningOfHierarchicalTransaction.HierarchicalStructureCode_01 = "0019";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetPurposeCode_02 = "00";
            result.BHT_BeginningOfHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "0123";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationDate_04 = "19960918";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationTime_05 = "0932";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionTypeCode_06 = "CH";

            //  Occurrence of NM1 Loops in any order
            result.AllNM1 = new All_NM1_837I_6();

            //  Begin 1000A Loop SUBMITTER NAME
            result.AllNM1.Loop1000A = new Loop_1000A_837I();

            //  NM1 SUBMITTER NAME
            result.AllNM1.Loop1000A.NM1_SubmitterName = new NM1_InformationReceiverName_4();
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityIdentifierCode_01 = "41";
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactLastorOrganizationName_03 = "JONES HOSPITAL";
            result.AllNM1.Loop1000A.NM1_SubmitterName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactIdentifier_09 = "12345";

            //  Repeating PER Patient information
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation = new List<PER_BillingProviderContactInformation>();

            //  PER SUBMITTER EDI CONTACT INFORMATION
            var per1 = new PER_BillingProviderContactInformation();
            per1.ContactFunctionCode_01 = "IC";
            per1.ResponseContactName_02 = "JANE DOE";
            per1.CommunicationNumberQualifier_03 = "TE";
            per1.ResponseContactCommunicationNumber_04 = "9005555555";
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation.Add(per1);

            //  End 1000A Loop

            //  Begin 1000B Loop RECEIVER NAME
            result.AllNM1.Loop1000B = new Loop_1000B_837I();

            //  NM1 RECEIVER NAME
            result.AllNM1.Loop1000B.NM1_ReceiverName = new NM1_ReceiverName();
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityIdentifierCode_01 = "40";
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactLastorOrganizationName_03 = "MEDICARE";
            result.AllNM1.Loop1000B.NM1_ReceiverName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactIdentifier_09 = "00120";

            //  End 1000B Loop

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_837I>();

            //  Begin 2000A Loop BILLING PROVIDER
            var loop2000A = new Loop_2000A_837I();

            //  HL BILLING PROVIDER HIERARCHICAL LEVEL
            loop2000A.HL_BillingProviderHierarchicalLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  PRV BILLING PROVIDER SPECIALTY
            loop2000A.PRV_BillingProviderSpecialtyInformation = new PRV_BillingProviderSpecialtyInformation();
            loop2000A.PRV_BillingProviderSpecialtyInformation.ProviderCode_01 = "BI";
            loop2000A.PRV_BillingProviderSpecialtyInformation.ReferenceIdentificationQualifier_02 = "PXC";
            loop2000A.PRV_BillingProviderSpecialtyInformation.ProviderTaxonomyCode_03 = "203BA0200N";

            //  Occurrence of NM1 Loops in any order
            loop2000A.AllNM1 = new All_NM1_837I();

            //  Begin 2010AA Loop BILLING PROVIDER NAME
            loop2000A.AllNM1.Loop2010AA = new Loop_2010AA_837I();

            //  NM1 BILLING PROVIDER NAME INCLUDING NATIONAL PROVIDER ID
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName = new NM1_BillingProviderName_3();
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityIdentifierCode_01 = "85";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactLastorOrganizationName_03 = "JONES HOSPITAL";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactIdentifier_09 = "9876540809";

            //  N3 BILLING PROVIDER ADDRESS
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress.ResponseContactAddressLine_01 = "225 MAIN STREET BARKLEY BUILDING";

            //  N4 BILLING PROVIDER LOCATION
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "CENTERVILLE";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "PA";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "17111";

            //  REF BILLING PROVIDER TAX IDENTIFICATION NUMBER
            loop2000A.AllNM1.Loop2010AA.REF_BillingProviderTaxIdentification = new REF_BillingProviderTaxIdentification_2();
            loop2000A.AllNM1.Loop2010AA.REF_BillingProviderTaxIdentification.ReferenceIdentificationQualifier_01 = "EI";
            loop2000A.AllNM1.Loop2010AA.REF_BillingProviderTaxIdentification.MemberGrouporPolicyNumber_02 = "567891234";

            //  Repeating PER billing provider contact information
            loop2000A.AllNM1.Loop2010AA.PER_BillingProviderContactInformation = new List<PER_BillingProviderContactInformation>();

            //  PER BILLING PROVIDER CONTACT INFORMATION
            var per2 = new PER_BillingProviderContactInformation();
            per2.ContactFunctionCode_01 = "IC";
            per2.ResponseContactName_02 = "CONNIE";
            per2.CommunicationNumberQualifier_03 = "TE";
            per2.ResponseContactCommunicationNumber_04 = "3055551234";
            loop2000A.AllNM1.Loop2010AA.PER_BillingProviderContactInformation.Add(per2);

            //  End 2010AA Loop

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_837I>();

            //  Begin 2000B Loop SUBSCRIBER HL LOOP
            var loop2000B = new Loop_2000B_837I();

            //  HL SUBSCRIBER HIERARCHICAL LEVEL
            loop2000B.HL_SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "0";

            //  SBR SUBSCRIBER INFORMATION
            loop2000B.SBR_SubscriberInformation = new SBR_SubscriberInformation_2();
            loop2000B.SBR_SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B.SBR_SubscriberInformation.IndividualRelationshipCode_02 = "18";
            loop2000B.SBR_SubscriberInformation.ClaimFilingIndicatorCode_09 = "MB";

            //  Occurrence of NM1 Loops in any order
            loop2000B.AllNM1 = new All_NM1_837I_2();

            //  Begin 2010BA Loop SUBSCRIBER NAME LOOP
            loop2000B.AllNM1.Loop2010BA = new Loop_2010BA_837I();

            //  NM1 SUBSCRIBER NAME
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName = new NM1_SubscriberName_5();
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "DOE";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactFirstName_04 = "JOHN";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactMiddleName_05 = "T";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactIdentifier_09 = "030005074A";

            //  N3 SUBSCRIBER ADDRESS
            loop2000B.AllNM1.Loop2010BA.N3_SubscriberAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000B.AllNM1.Loop2010BA.N3_SubscriberAddress.ResponseContactAddressLine_01 = "125 CITY AVENUE";

            //  N4 SUBSCRIBER LOCATION
            loop2000B.AllNM1.Loop2010BA.N4_SubscriberCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000B.AllNM1.Loop2010BA.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "CENTERVILLE";
            loop2000B.AllNM1.Loop2010BA.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "PA";
            loop2000B.AllNM1.Loop2010BA.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "17111";

            //  DMG SUBSCRIBER DEMOGRAPHIC INFORMATION
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation = new DMG_PatientDemographicInformation();
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DependentBirthDate_02 = "19261111";
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "M";

            //  End 2010BA Loop

            //  Begin 2010BB Loop PAYER NAME LOOP
            loop2000B.AllNM1.Loop2010BB = new Loop_2010BB_837I();

            //  NM1 PAYER NAME
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName = new NM1_OtherPayerName();
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactLastorOrganizationName_03 = "MEDICARE B";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactIdentifier_09 = "00435";

            //  Occurrence of REF Segments in any order
            loop2000B.AllNM1.Loop2010BB.AllREF = new All_REF_837I_3();

            //  REF BILLING PROVIDER SECONDARY IDENTIFICATION
            loop2000B.AllNM1.Loop2010BB.AllREF.REF_BillingProviderSecondaryIdentification = new REF_BillingProviderSecondaryIdentification();
            loop2000B.AllNM1.Loop2010BB.AllREF.REF_BillingProviderSecondaryIdentification.ReferenceIdentificationQualifier_01 = "G2";
            loop2000B.AllNM1.Loop2010BB.AllREF.REF_BillingProviderSecondaryIdentification.MemberGrouporPolicyNumber_02 = "330127";

            //  End 2010BB Loop

            //  Repeating 2300 Loops
            loop2000B.Loop2300 = new List<Loop_2300_837I>();

            //  Begin 2300 Loop CLAIM INFORMATION
            var loop2300 = new Loop_2300_837I();

            //  CLM CLAIM LEVEL INFORMATION
            loop2300.CLM_ClaimInformation = new CLM_ClaimInformation_2();
            loop2300.CLM_ClaimInformation.PatientControlNumber_01 = "756048Q";
            loop2300.CLM_ClaimInformation.TotalClaimChargeAmount_02 = "89.93";
            loop2300.CLM_ClaimInformation.NonInstitutionalClaimTypeCode_04 = "14:A:1";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation_3();
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityTypeCode_01 = "A";
            loop2300.CLM_ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop2300.CLM_ClaimInformation.AssignmentorPlanParticipationCode_07 = "Y";

            //  Occurrence of DTP Segments in any order
            loop2300.AllDTP = new All_DTP_837I();

            //  DTP STATEMENT DATES
            loop2300.AllDTP.DTP_StatementDates = new DTP_StatementDates();
            loop2300.AllDTP.DTP_StatementDates.DateTimeQualifier_01 = "434";
            loop2300.AllDTP.DTP_StatementDates.DateTimePeriodFormatQualifier_02 = "RD8";
            loop2300.AllDTP.DTP_StatementDates.DateTimePeriod_03 = "19960911";

            //  CL1 INSTITUTIONAL CLAIM CODE
            loop2300.CL1_InstitutionalClaimCode = new CL1_InstitutionalClaimCode();
            loop2300.CL1_InstitutionalClaimCode.AdmissionTypeCode_01 = "3";
            loop2300.CL1_InstitutionalClaimCode.PatientStatusCode_03 = "01";

            //  Occurrence of HI Segments in any order
            loop2300.AllHI = new All_HI_837I();

            //  HI PRINCIPAL DIAGNOSIS CODES
            loop2300.AllHI.HI_PrincipalDiagnosis = new HI_PrincipalDiagnosis();
            loop2300.AllHI.HI_PrincipalDiagnosis.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_8();
            loop2300.AllHI.HI_PrincipalDiagnosis.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BK";
            loop2300.AllHI.HI_PrincipalDiagnosis.HealthCareCodeInformation_01.IndustryCode_02 = "3669";

            //  Repeatable HI Other Diagnostics
            loop2300.AllHI.HI_OtherDiagnosisInformation = new List<HI_OtherDiagnosisInformation>();

            //  HI OTHER DIAGNOSIS INFORMATION
            var hi1 = new HI_OtherDiagnosisInformation();
            hi1.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_4();
            hi1.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BF";
            hi1.HealthCareCodeInformation_01.IndustryCode_02 = "4019";
            hi1.HealthCareCodeInformation_02 = new C022_HealthCareCodeInformation_4();
            hi1.HealthCareCodeInformation_02.CodeListQualifierCode_01 = "BF";
            hi1.HealthCareCodeInformation_02.IndustryCode_02 = "79431";
            loop2300.AllHI.HI_OtherDiagnosisInformation.Add(hi1);

            //  Repeatable HI Occurrence Information
            loop2300.AllHI.HI_OccurrenceInformation = new List<HI_OccurrenceInformation>();

            //  HI OCCURRENCE INFORMATION
            var hi3 = new HI_OccurrenceInformation();
            hi3.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_6();
            hi3.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BH";
            hi3.HealthCareCodeInformation_01.IndustryCode_02 = "A1";
            hi3.HealthCareCodeInformation_01.DateTimePeriodFormatQualifier_03 = "D8";
            hi3.HealthCareCodeInformation_01.DateTimePeriod_04 = "19261111";
            hi3.HealthCareCodeInformation_02 = new C022_HealthCareCodeInformation_6();
            hi3.HealthCareCodeInformation_02.CodeListQualifierCode_01 = "BH";
            hi3.HealthCareCodeInformation_02.IndustryCode_02 = "A2";
            hi3.HealthCareCodeInformation_02.DateTimePeriodFormatQualifier_03 = "D8";
            hi3.HealthCareCodeInformation_02.DateTimePeriod_04 = "19911101";
            hi3.HealthCareCodeInformation_03 = new C022_HealthCareCodeInformation_6();
            hi3.HealthCareCodeInformation_03 = new C022_HealthCareCodeInformation_6();
            hi3.HealthCareCodeInformation_03.CodeListQualifierCode_01 = "BH";
            hi3.HealthCareCodeInformation_03.IndustryCode_02 = "B1";
            hi3.HealthCareCodeInformation_03.DateTimePeriodFormatQualifier_03 = "D8";
            hi3.HealthCareCodeInformation_03.DateTimePeriod_04 = "19261111";
            hi3.HealthCareCodeInformation_04 = new C022_HealthCareCodeInformation_6();
            hi3.HealthCareCodeInformation_04.CodeListQualifierCode_01 = "BH";
            hi3.HealthCareCodeInformation_04.IndustryCode_02 = "B2";
            hi3.HealthCareCodeInformation_04.DateTimePeriodFormatQualifier_03 = "D8";
            hi3.HealthCareCodeInformation_04.DateTimePeriod_04 = "19870101";
            loop2300.AllHI.HI_OccurrenceInformation.Add(hi3);     

            //  Repeatable HI Value Information
            loop2300.AllHI.HI_ValueInformation = new List<HI_ValueInformation>();

            //  HI VALUE INFORMATION
            var hi7 = new HI_ValueInformation();
            hi7.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_7();
            hi7.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BE";
            hi7.HealthCareCodeInformation_01.IndustryCode_02 = "A2";
            hi7.HealthCareCodeInformation_01.MonetaryAmount_05 = "15.31";
            loop2300.AllHI.HI_ValueInformation.Add(hi7);

            //  Repeatable HI Condition Information
            loop2300.AllHI.HI_ConditionInformation = new List<HI_ConditionInformation>();

            //  HI CONDITION INFORMATION
            var hi8 = new HI_ConditionInformation();
            hi8.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_13();
            hi8.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BG";
            hi8.HealthCareCodeInformation_01.IndustryCode_02 = "09";
            loop2300.AllHI.HI_ConditionInformation.Add(hi8);

            //  Occurrence of NM1 Loops in any order
            loop2300.AllNM1 = new All_NM1_837I_3();

            //  Begin 2310A Loop ATTENDING PROVIDER NAME
            loop2300.AllNM1.Loop2310A = new Loop_2310A_837I();

            //  NM1 ATTENDING PROVIDER
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName = new NM1_AttendingProviderName();
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName.EntityIdentifierCode_01 = "71";
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName.EntityTypeQualifier_02 = "1";
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName.ResponseContactLastorOrganizationName_03 = "JONES";
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName.ResponseContactFirstName_04 = "JOHN";
            loop2300.AllNM1.Loop2310A.NM1_AttendingProviderName.ResponseContactMiddleName_05 = "J";

            //  Repeating REF Secondary Identification
            loop2300.AllNM1.Loop2310A.REF_AttendingProviderSecondaryIdentification = new List<REF_AssistantSurgeonSecondaryIdentification>();

            //  REF ATTENDING PROVIDER SECONDARY IDENTIFICATION
            var ref1 = new REF_AssistantSurgeonSecondaryIdentification();
            ref1.ReferenceIdentificationQualifier_01 = "1G";
            ref1.MemberGrouporPolicyNumber_02 = "B99937";
            loop2300.AllNM1.Loop2310A.REF_AttendingProviderSecondaryIdentification.Add(ref1);

            //  End 2310A Loop

            //  Repeating 2320 Loops
            loop2300.Loop2320 = new List<Loop_2320_837I>();

            //  Begin 2320 Loop OTHER SUBSCRIBER INFORMATION
            var loop2320 = new Loop_2320_837I();

            //  SBR OTHER SUBSCRIBER INFORMATION
            loop2320.SBR_OtherSubscriberInformation = new SBR_OtherSubscriberInformation_2();
            loop2320.SBR_OtherSubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "S";
            loop2320.SBR_OtherSubscriberInformation.IndividualRelationshipCode_02 = "01";
            loop2320.SBR_OtherSubscriberInformation.InsuredGrouporPolicyNumber_03 = "351630";
            loop2320.SBR_OtherSubscriberInformation.OtherInsuredGroupName_04 = "STATE TEACHERS";
            loop2320.SBR_OtherSubscriberInformation.ClaimFilingIndicatorCode_09 = "CI";

            //  OI OTHER INSURANCE COVERAGE INFORMATION
            loop2320.OI_OtherInsuranceCoverageInformation = new OI_OtherInsuranceCoverageInformation_2();
            loop2320.OI_OtherInsuranceCoverageInformation.BenefitsAssignmentCertificationIndicator_03 = "Y";
            loop2320.OI_OtherInsuranceCoverageInformation.ReleaseofInformationCode_06 = "Y";

            //  Occurrence of NM1 Loops in any order
            loop2320.AllNM1 = new All_NM1_837I_4();

            //  Begin 2330A Loop OTHER SUBSCRIBER NAME
            loop2320.AllNM1.Loop2330A = new Loop_2330A_837I();

            //  NM1 OTHER SUBSCRIBER NAME
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName = new NM1_OtherSubscriberName();
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.EntityIdentifierCode_01 = "IL";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.EntityTypeQualifier_02 = "1";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.ResponseContactLastorOrganizationName_03 = "DOE";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.ResponseContactFirstName_04 = "JANE";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.ResponseContactMiddleName_05 = "S";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2320.AllNM1.Loop2330A.NM1_OtherSubscriberName.ResponseContactIdentifier_09 = "222004433";

            //  N3 OTHER SUBSCRIBER ADDRESS
            loop2320.AllNM1.Loop2330A.N3_OtherSubscriberAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2320.AllNM1.Loop2330A.N3_OtherSubscriberAddress.ResponseContactAddressLine_01 = "125 CITY AVENUE";

            //  N4 OTHER SUBSCRIBER CITY, STATE, ZIP CODE
            loop2320.AllNM1.Loop2330A.N4_OtherSubscriberCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2320.AllNM1.Loop2330A.N4_OtherSubscriberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "CENTERVILLE";
            loop2320.AllNM1.Loop2330A.N4_OtherSubscriberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "PA";
            loop2320.AllNM1.Loop2330A.N4_OtherSubscriberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "17111";

            //  End 2330A Loop

            //  Begin 2330B Loop OTHER PAYER NAME
            loop2320.AllNM1.Loop2330B = new Loop_2330B_837I();

            //  NM1 OTHER PAYER NAME
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName = new NM1_OtherPayerName();
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName.EntityIdentifierCode_01 = "PR";
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName.EntityTypeQualifier_02 = "2";
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName.ResponseContactLastorOrganizationName_03 = "STATE TEACHERS";
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName.IdentificationCodeQualifier_08 = "PI";
            loop2320.AllNM1.Loop2330B.NM1_OtherPayerName.ResponseContactIdentifier_09 = "1135";

            //  End 2330B Loop

            //  End 2320 Loop
            loop2300.Loop2320.Add(loop2320);

            //  Repeating 2400 Loops
            loop2300.Loop2400 = new List<Loop_2400_837I>();

            //  Begin 2400 Loop 1 SERVICE LINE
            var loop24001 = new Loop_2400_837I();

            //  LX SERVICE LINE COUNTER
            loop24001.LX_ServiceLineNumber = new LX_HeaderNumber();
            loop24001.LX_ServiceLineNumber.AssignedNumber_01 = "1";

            //  SV2 INSTITUTIONAL SERVICE
            loop24001.SV2_InstitutionalServiceLine = new SV2_InstitutionalServiceLine();
            loop24001.SV2_InstitutionalServiceLine.ServiceLineRevenueCode_01 = "0305";
            loop24001.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02 = new C003_CompositeMedicalProcedureIdentifier_8();
            loop24001.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02.ProductorServiceIDQualifier_01 = "HC";
            loop24001.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02.ProcedureCode_02 = "85025";
            loop24001.SV2_InstitutionalServiceLine.LineItemChargeAmount_03 = "13.39";
            loop24001.SV2_InstitutionalServiceLine.UnitorBasisforMeasurementCode_04 = "UN";
            loop24001.SV2_InstitutionalServiceLine.ServiceUnitCount_05 = "1";

            //  DTP DATE - SERVICE DATES
            loop24001.DTP_Date_ServiceDate = new DTP_ClaimLevelServiceDate();
            loop24001.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop24001.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop24001.DTP_Date_ServiceDate.DateTimePeriod_03 = "19960911";

            //  End 2400 Loop 1
            loop2300.Loop2400.Add(loop24001);

            //  Begin 2400 Loop 2 SERVICE LINE
            var loop24002 = new Loop_2400_837I();

            //  LX SERVICE LINE COUNTER
            loop24002.LX_ServiceLineNumber = new LX_HeaderNumber();
            loop24002.LX_ServiceLineNumber.AssignedNumber_01 = "2";

            //  SV2 INSTITUTIONAL SERVICE
            loop24002.SV2_InstitutionalServiceLine = new SV2_InstitutionalServiceLine();
            loop24002.SV2_InstitutionalServiceLine.ServiceLineRevenueCode_01 = "0730";
            loop24002.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02 = new C003_CompositeMedicalProcedureIdentifier_8();
            loop24002.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02.ProductorServiceIDQualifier_01 = "HC";
            loop24002.SV2_InstitutionalServiceLine.CompositeMedicalProcedureIdentifier_02.ProcedureCode_02 = "93005";
            loop24002.SV2_InstitutionalServiceLine.LineItemChargeAmount_03 = "76.54";
            loop24002.SV2_InstitutionalServiceLine.UnitorBasisforMeasurementCode_04 = "UN";
            loop24002.SV2_InstitutionalServiceLine.ServiceUnitCount_05 = "3";

            //  DTP DATE - SERVICE DATES
            loop24002.DTP_Date_ServiceDate = new DTP_ClaimLevelServiceDate();
            loop24002.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop24002.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop24002.DTP_Date_ServiceDate.DateTimePeriod_03 = "19960911";

            //  End 2400 Loop 2
            loop2300.Loop2400.Add(loop24002);

            //  End 2300 Loop
            loop2000B.Loop2300.Add(loop2300);

            //  End 2000B Loop
            loop2000A.Loop2000B.Add(loop2000B);

            //  End 2000A Loop
            result.Loop2000A.Add(loop2000A);

            return result;
        }
    }
}

