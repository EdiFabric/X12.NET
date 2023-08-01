using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T837D
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);
            Read();
            Write();
        }

        /// <summary>
        /// Read Dental Claim
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Hipaa\DentalClaim.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS837D>();

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
        /// Write Dental Claim
        /// </summary>
        static void Write()
        {
            var transaction = BuildDentalClaim("3456");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X224A2"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build dental claim.
        /// Original from http://www.x12.org/examples/005010X224/commercial-health-insurance/
        /// The patient is a different person than the subscriber. The payer is a commercial health insurance company.
        /// Scenario:
        /// SUBSCRIBER: Jane Smith
        /// KEY INSURANCE COMPANY ID #: SSN
        /// SSN: 111-22-3333
        /// PATIENT: Ted Smith
        /// PATIENT ADDRESS: 236 N.Main St., Miami, Fl, 33413
        /// SEX: M
        /// DOB: 05/01/1992
        /// PATIENT RELATIONSHIP: Child
        /// DESTINATION PAYER: Insurance Company XYZ
        /// RECEIVER: Insurance Company XYZ
        /// ETIN#: 66783JJT
        /// SUBMITTER: Premier Billing Service
        /// ETIN#: TGJ23
        /// BILLING PROVIDER: Dental Associates
        /// NPI: 1234567890
        /// TIN: 587654321
        /// ADDRESS: 234 Seaway St., Miami, FL, 33111
        /// RENDERING PROVIDER: Dr.Ben Kildare
        /// NPI: 9876543210
        /// PATIENT ACCOUNT NUMBER: 2-640-3774
        /// DOS: 20061029
        /// POS= Office
        /// SERVICES RENDERED: Two surface amalgam on tooth #12 (mesial and occlusal surfaces) and prophy.
        /// CHARGES: amalgam = $100.00, prophy = $50.00.
        /// ELECTRONIC ROUTE: VAN submits claim on behalf of billing provider (submitter) to Insurance Company XYZ (receiver).
        /// VAN CLAIM IDENTIFICATION NUMBER: 17312345600006351.
        /// </summary>
        static TS837D BuildDentalClaim(string controlNumber)
        {
            var result = new TS837D();

            //  ST TRANSACTION SET HEADER
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "837";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X224A2";

            //  BHT TRANSACTION SET HIERARCHY AND CONTROL INFORMATION
            result.BHT_BeginningOfHierarchicalTransaction = new BHT_BeginningOfHierarchicalTransaction_8();
            result.BHT_BeginningOfHierarchicalTransaction.HierarchicalStructureCode_01 = "0019";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetPurposeCode_02 = "00";
            result.BHT_BeginningOfHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "0123";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationDate_04 = "20061123";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationTime_05 = "1023";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionTypeCode_06 = "CH";

            //  Occurrence of NM1 Loops in any order
            result.AllNM1 = new All_NM1_837D_6();

            //  Begin 1000A Loop SUBMITTER NAME
            result.AllNM1.Loop1000A = new Loop_1000A_837D();

            //  NM1 SUBMITTER
            result.AllNM1.Loop1000A.NM1_SubmitterName = new NM1_InformationReceiverName_4();
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityIdentifierCode_01 = "41";
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactLastorOrganizationName_03 = "PREMIER BILLING SERVICE";
            result.AllNM1.Loop1000A.NM1_SubmitterName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactIdentifier_09 = "TGJ23";

            //  Repeating PER Patient information
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation = new List<PER_BillingProviderContactInformation>();

            //  PER SUBMITTER EDI CONTACT INFORMATION
            var per1 = new PER_BillingProviderContactInformation();
            per1.ContactFunctionCode_01 = "IC";
            per1.ResponseContactName_02 = "JERRY";
            per1.CommunicationNumberQualifier_03 = "TE";
            per1.ResponseContactCommunicationNumber_04 = "7176149999";
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation.Add(per1);

            //  End 1000A Loop

            //  Begin 1000B Loop RECEIVER NAME
            result.AllNM1.Loop1000B = new Loop_1000B_837D();

            //  NM1 RECEIVER
            result.AllNM1.Loop1000B.NM1_ReceiverName = new NM1_ReceiverName();
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityIdentifierCode_01 = "40";
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactLastorOrganizationName_03 = "INSURANCE COMPANY XYZ";
            result.AllNM1.Loop1000B.NM1_ReceiverName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactIdentifier_09 = "66783JJT";

            //  End 1000B Loop

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_837D>();

            //  Begin 2000A Loop BILLING PROVIDER
            var loop2000A = new Loop_2000A_837D();

            //  HIERARCHAL LEVEL 1
            loop2000A.HL_BillingProviderHierarchicalLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  Occurrence of NM1 Loops in any order
            loop2000A.AllNM1 = new All_NM1_837D();

            //  Begin 2010AA Loop BILLING PROVIDER NAME
            loop2000A.AllNM1.Loop2010AA = new Loop_2010AA_837D();

            //  NM1 BILLING PROVIDER NAME
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName = new NM1_BillingProviderName_2();
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityIdentifierCode_01 = "85";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactLastorOrganizationName_03 = "DENTAL ASSOCIATES";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactIdentifier_09 = "1234567890";

            //  N3 BILLING PROVIDER ADDRESS
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress.ResponseContactAddressLine_01 = "234 SEAWAY ST";

            //  N4 BILLING PROVIDER LOCATION
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33111";

            //  Occurrence of REF Segments in any order
            loop2000A.AllNM1.Loop2010AA.AllREF = new All_REF_837D_8();

            //  REF BILLING PROVIDER'S TAX IDENTIFICATION
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification = new REF_BillingProviderTaxIdentification();
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification.ReferenceIdentificationQualifier_01 = "EI";
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification.MemberGrouporPolicyNumber_02 = "587654321";

            //  Repeating PER billing provider contact information
            loop2000A.AllNM1.Loop2010AA.PER_BillingProviderContactInformation = new List<PER_BillingProviderContactInformation>();

            //  End 2010AA Loop

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_837D>();

            //  Begin 2000B Loop SUBSCRIBER HL LOOP
            var loop2000B = new Loop_2000B_837D();

            //  HIERARCHAL LEVEL 2
            loop2000B.HL_SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  SBR SUBSCRIBER INFORMATION
            loop2000B.SBR_SubscriberInformation = new SBR_SubscriberInformation();
            loop2000B.SBR_SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B.SBR_SubscriberInformation.ClaimFilingIndicatorCode_09 = "CI";

            //  Occurrence of NM1 Loops in any order
            loop2000B.AllNM1 = new All_NM1_837D_2();

            //  Begin 2010BA Loop SUBSCRIBER NAME LOOP
            loop2000B.AllNM1.Loop2010BA = new Loop_2010BA_837D();

            //  NM1 SUBSCRIBER'S NAME
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName = new NM1_SubscriberName_5();
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactFirstName_04 = "JANE";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactIdentifier_09 = "111223333";

            //  End 2010BA Loop

            //  Begin 2010BB Loop PAYER NAME LOOP
            loop2000B.AllNM1.Loop2010BB = new Loop_2010BB_837D();

            //  NM1 PAYER'S NAME
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName = new NM1_OtherPayerName();
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactLastorOrganizationName_03 = "INSURANCE COMPANY XYZ";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactIdentifier_09 = "66783JJT";

            //  End 2010BB Loop

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_837D>();

            //  Begin 2000C Loop PATIENT'S HL LOOP
            var loop2000C = new Loop_2000C_837D();

            //  HIERARCHAL LEVEL 3
            loop2000C.HL_PatientHierarchicalLevel = new HL_DependentLevel();
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalIDNumber_01 = "3";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalLevelCode_03 = "23";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalChildCode_04 = "0";

            //  PAT PATIENT INFORMATION
            loop2000C.PAT_PatientInformation = new PAT_PatientInformation_2();
            loop2000C.PAT_PatientInformation.IndividualRelationshipCode_01 = "19";

            //  Begin 2010CA Loop PATIENT
            loop2000C.Loop2010CA = new Loop_2010CA_837D();

            //  NM1 PATIENT'S NAME
            loop2000C.Loop2010CA.NM1_PatientName = new NM1_PatientName_3();
            loop2000C.Loop2010CA.NM1_PatientName.EntityIdentifierCode_01 = "QC";
            loop2000C.Loop2010CA.NM1_PatientName.EntityTypeQualifier_02 = "1";
            loop2000C.Loop2010CA.NM1_PatientName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000C.Loop2010CA.NM1_PatientName.ResponseContactFirstName_04 = "TED";

            //  N3 PATIENT'S ADDRESS
            loop2000C.Loop2010CA.N3_PatientAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000C.Loop2010CA.N3_PatientAddress.ResponseContactAddressLine_01 = "236 N MAIN ST";

            //  N4 PATIENT'S CITY
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33413";

            //  DMG PATIENT DEMOGRAPHIC INFORMATION
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation = new DMG_PatientDemographicInformation();
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DependentBirthDate_02 = "19920501";
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DependentGenderCode_03 = "M";

            //  End 2010CA Loop

            //  Repeating 2300 Loops
            loop2000C.Loop2300 = new List<Loop_2300_837D>();

            //  Begin 2300 Loop CLAIM
            var loop2300 = new Loop_2300_837D();

            //  CLM HEALTH CLAIM INFORMATION
            loop2300.CLM_ClaimInformation = new CLM_ClaimInformation();
            loop2300.CLM_ClaimInformation.PatientControlNumber_01 = "26403774";
            loop2300.CLM_ClaimInformation.TotalClaimChargeAmount_02 = "150";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation_2();
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityTypeCode_01 = "11";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityCodeQualifier_02 = "B";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.ClaimFrequencyTypeCode_03 = "1";
            loop2300.CLM_ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop2300.CLM_ClaimInformation.AssignmentorPlanParticipationCode_07 = "A";
            loop2300.CLM_ClaimInformation.BenefitsAssignmentCertificationIndicator_08 = "Y";
            loop2300.CLM_ClaimInformation.ReleaseofInformationCode_09 = "I";

            //  Occurrence of DTP Segments in any order
            loop2300.AllDTP = new All_DTP_837D_2();

            //  DTP DATE - SERVICE DATE
            loop2300.AllDTP.DTP_Date_ServiceDate = new DTP_ClaimLevelServiceDate();
            loop2300.AllDTP.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop2300.AllDTP.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop2300.AllDTP.DTP_Date_ServiceDate.DateTimePeriod_03 = "20061029";

            //  Occurrence of REF Segments in any order
            loop2300.AllREF = new All_REF_837D_6();

            //  REF VAN CLAIM NUMBER
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries = new REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries();
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries.ReferenceIdentificationQualifier_01 = "D9";
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries.MemberGrouporPolicyNumber_02 = "17312345600006351";

            //  Occurrence of NM1 Loops in any order
            loop2300.AllNM1 = new All_NM1_837D_3();

            //  Begin 2310B Loop RENDERING PROVIDER
            loop2300.AllNM1.Loop2310B = new Loop_2310B_837D();

            //  NM1 RENDERING PROVIDER’S NAME
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName = new NM1_RenderingProviderName();
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.EntityIdentifierCode_01 = "82";
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.EntityTypeQualifier_02 = "1";
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.ResponseContactLastorOrganizationName_03 = "KILDARE";
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.ResponseContactFirstName_04 = "BEN";
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2300.AllNM1.Loop2310B.NM1_RenderingProviderName.ResponseContactIdentifier_09 = "9876543210";

            loop2300.AllNM1.Loop2310B.PRV_RenderingProviderSpecialtyInformation = new PRV_RenderingProviderSpecialtyInformation();
            loop2300.AllNM1.Loop2310B.PRV_RenderingProviderSpecialtyInformation.ProviderCode_01 = "PE";
            loop2300.AllNM1.Loop2310B.PRV_RenderingProviderSpecialtyInformation.ReferenceIdentificationQualifier_02 = "PXC";
            loop2300.AllNM1.Loop2310B.PRV_RenderingProviderSpecialtyInformation.ProviderTaxonomyCode_03 = "1223G0001X";

            //  End 2310B Loop

            //  Repeating 2400 Loops
            loop2300.Loop2400 = new List<Loop_2400_837D>();

            //  Begin 2400 Loop 1 SERVICE LINE
            var loop24001 = new Loop_2400_837D();

            //  LX SERVICE LINE NUMBER
            loop24001.LX_ServiceLineNumber = new LX_HeaderNumber();
            loop24001.LX_ServiceLineNumber.AssignedNumber_01 = "1";

            //  SV3 DENTAL SERVICE
            loop24001.SV3_DentalService = new SV3_DentalService();
            loop24001.SV3_DentalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_11();
            loop24001.SV3_DentalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "AD";
            loop24001.SV3_DentalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "D2150";
            loop24001.SV3_DentalService.LineItemChargeAmount_02 = "100";
            loop24001.SV3_DentalService.ProcedureCount_06 = "1";

            //  Repeating TOO
            loop24001.TOO_ToothInformation = new List<TOO_ToothInformation>();

            //  TOO TOOTH NUMBER/SURFACES
            var too = new TOO_ToothInformation();
            too.CodeListQualifierCode_01 = "JP";
            too.ToothCode_02 = "12";
            too.ToothSurface_03 = new C005_ToothSurface();
            too.ToothSurface_03.ToothSurfaceCode_01 = "M";
            too.ToothSurface_03.ToothSurfaceCode_02 = "O";
            loop24001.TOO_ToothInformation.Add(too);

            //  End 2400 Loop 1
            loop2300.Loop2400.Add(loop24001);

            //  Begin 2400 Loop 2 SERVICE LINE
            var loop24002 = new Loop_2400_837D();

            //  LX SERVICE LINE NUMBER
            loop24002.LX_ServiceLineNumber = new LX_HeaderNumber();
            loop24002.LX_ServiceLineNumber.AssignedNumber_01 = "2";

            //  SV3 DENTAL SERVICE
            loop24002.SV3_DentalService = new SV3_DentalService();
            loop24002.SV3_DentalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_11();
            loop24002.SV3_DentalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "AD";
            loop24002.SV3_DentalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "D1110";
            loop24002.SV3_DentalService.LineItemChargeAmount_02 = "50";
            loop24002.SV3_DentalService.ProcedureCount_06 = "1";            

            //  End 2400 Loop 2
            loop2300.Loop2400.Add(loop24002);

            //  End 2300 Loop
            loop2000C.Loop2300.Add(loop2300);

            //  End 2000C Loop
            loop2000B.Loop2000C.Add(loop2000C);

            //  End 2000B Loop
            loop2000A.Loop2000B.Add(loop2000B);

            //  End 2000A Loop
            result.Loop2000A.Add(loop2000A);

            return result;
        }
    }
}

