using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T837P
{
    class EVVExample
    {
        /// <summary>
        /// Read Claim
        /// </summary>
        public static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\ClaimPaymentEVV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V5010.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS837P>();

            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();                

                if (transaction.HasErrors)
                {
                    //  partially parsed
                    var errors = transaction.ErrorContext.Flatten();
                }
            }
        }

        /// <summary>
        /// Write Claim
        /// </summary>
        public static void Write()
        {
            var transaction = BuildClaim("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, new X12WriterSettings { Postfix = Environment.NewLine }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }


        /// <summary>
        /// Build claim with EVV.
        /// Original from https://www.dmas.virginia.gov/files/links/685/AD%20Services%20837P%20with%20EVV%20Information%20Example%20(01.29.2019).pdf
        /// </summary>
        public static TS837P BuildClaim(string controlNumber)
        {
            var result = new TS837P();

            //  Indicates the start of a claim transaction set and assigns a control number.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "837";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X222A1";

            //  Indicates the claim was created on October 15, 2006 and submitter is identified with 244579. 
            result.BHT_BeginningofHierarchicalTransaction = new BHT_BeginningofHierarchicalTransaction_7();
            result.BHT_BeginningofHierarchicalTransaction.HierarchicalStructureCode_01 = "0019";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetPurposeCode_02 = "00";
            result.BHT_BeginningofHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "244579";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationDate_04 = "20061015";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationTime_05 = "1023";
            result.BHT_BeginningofHierarchicalTransaction.TransactionTypeCode_06 = "CH";

            //  Occurrence of NM1 Loops in any order
            result.AllNM1 = new All_NM1_837P_6();

            //  Begin 1000A Loop SUBMITTER
            result.AllNM1.Loop1000A = new Loop_1000A_837P();

            //  Premier Billing Service with EDI# TGJ23
            result.AllNM1.Loop1000A.NM1_SubmitterName = new NM1_InformationReceiverName_2();
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityIdentifierCode_01 = "41";
            result.AllNM1.Loop1000A.NM1_SubmitterName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactLastorOrganizationName_03 = "PREMIER BILLING SERVICE";
            result.AllNM1.Loop1000A.NM1_SubmitterName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000A.NM1_SubmitterName.ResponseContactIdentifier_09 = "TGJ23";

            //  Repeating PER
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation = new List<PER_AdditionalPatientInformationContactInformation>();

            //  CONTACT PERSON AND PHONE NUMBER: JERRY, 305-555-2222 ext. 231
            var perLoop1000A = new PER_AdditionalPatientInformationContactInformation();
            perLoop1000A.ContactFunctionCode_01 = "IC";
            perLoop1000A.ResponseContactName_02 = "JERRY";
            perLoop1000A.CommunicationNumberQualifier_03 = "TE";
            perLoop1000A.ResponseContactCommunicationNumber_04 = "3055552222";
            perLoop1000A.CommunicationNumberQualifier_05 = "EX";
            perLoop1000A.ResponseContactCommunicationNumber_06 = "231";
            result.AllNM1.Loop1000A.PER_SubmitterEDIContactInformation.Add(perLoop1000A);

            //  End 1000A Loop SUBMITTER

            //  Begin 1000B Loop RECEIVER
            result.AllNM1.Loop1000B = new Loop_1000B_837P();

            //  Key Insurance Company with EDI #:66783JJT
            result.AllNM1.Loop1000B.NM1_ReceiverName = new NM1_ReceiverName();
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityIdentifierCode_01 = "40";
            result.AllNM1.Loop1000B.NM1_ReceiverName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactLastorOrganizationName_03 = "KEY INSURANCE COMPANY";
            result.AllNM1.Loop1000B.NM1_ReceiverName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000B.NM1_ReceiverName.ResponseContactIdentifier_09 = "66783JJT";

            //  End 1000B Loop RECEIVER

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_837P>();

            //  Begin 2000A Loop BILLING PROVIDER Hierarchy
            var loop2000A = new Loop_2000A_837P();

            //  Hierarchical Number 1
            loop2000A.HL_BillingProviderHierarchicalLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_BillingProviderHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  Taxonomy Code: 203BF0100Y
            loop2000A.PRV_BillingProviderSpecialtyInformation = new PRV_BillingProviderSpecialtyInformation();
            loop2000A.PRV_BillingProviderSpecialtyInformation.ProviderCode_01 = "BI";
            loop2000A.PRV_BillingProviderSpecialtyInformation.ReferenceIdentificationQualifier_02 = "PXC";
            loop2000A.PRV_BillingProviderSpecialtyInformation.ProviderTaxonomyCode_03 = "203BF0100Y";

            //  Occurrence of NM1 Loops in any order
            loop2000A.AllNM1 = new All_NM1_837P();

            //  Begin 2010AA Loop BILLING PROVIDER
            loop2000A.AllNM1.Loop2010AA = new Loop_2010AA_837P();

            //  Name is BEN KILDARE SERVICE with NPI: 9876543210
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName = new NM1_BillingProviderName();
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityIdentifierCode_01 = "85";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactLastorOrganizationName_03 = "BEN KILDARE SERVICE";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2000A.AllNM1.Loop2010AA.NM1_BillingProviderName.ResponseContactIdentifier_09 = "9876543210";

            //  ADDRESS: 234 Seaway St
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AA.N3_BillingProviderAddress.ResponseContactAddressLine_01 = "234 SEAWAY ST";

            //  LOCATION: Miami, FL, 33111
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000A.AllNM1.Loop2010AA.N4_BillingProviderCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33111";

            //  Occurrence of REF Loops in any order
            loop2000A.AllNM1.Loop2010AA.AllREF = new All_REF_837P_8();

            //  TIN: 587654321
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification = new REF_BillingProviderTaxIdentification();
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification.ReferenceIdentificationQualifier_01 = "EI";
            loop2000A.AllNM1.Loop2010AA.AllREF.REF_BillingProviderTaxIdentification.MemberGrouporPolicyNumber_02 = "587654321";

            //  End 2010AA Loop BILLING PROVIDER

            //  Begin 2010AB Loop PAY-TO PROVIDER
            loop2000A.AllNM1.Loop2010AB = new Loop_2010AB_837P();

            //  PAY-TO PROVIDER Name is Kildare Associates
            loop2000A.AllNM1.Loop2010AB.NM1_Pay_AddressName = new NM1_Pay();
            loop2000A.AllNM1.Loop2010AB.NM1_Pay_AddressName.EntityIdentifierCode_01 = "87";
            loop2000A.AllNM1.Loop2010AB.NM1_Pay_AddressName.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AB.NM1_Pay_AddressName.ResponseContactLastorOrganizationName_03 = "Kildare Associates";

            //  PROVIDER ADDRESS: 2345 Ocean Blvd
            loop2000A.AllNM1.Loop2010AB.N3_Pay_ToAddress_ADDRESS = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AB.N3_Pay_ToAddress_ADDRESS.ResponseContactAddressLine_01 = "2345 OCEAN BLVD";

            //  PROVIDER LOCATION: Miami, Fl 33111
            loop2000A.AllNM1.Loop2010AB.N4_Pay_AddressCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AB.N4_Pay_AddressCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000A.AllNM1.Loop2010AB.N4_Pay_AddressCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000A.AllNM1.Loop2010AB.N4_Pay_AddressCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33111";

            //  End 2010AB Loop PAY-TO PROVIDER

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_837P>();

            //  Begin 2000B Loop SUBSCRIBER Hierarchy
            var loop2000B = new Loop_2000B_837P();

            //  Hierarchical Number 2
            loop2000B.HL_SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B.HL_SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  SUBSCRIBER GROUP #: 2222-SJ
            loop2000B.SBR_SubscriberInformation = new SBR_SubscriberInformation();
            loop2000B.SBR_SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B.SBR_SubscriberInformation.InsuredGrouporPolicyNumber_03 = "2222-SJ";
            loop2000B.SBR_SubscriberInformation.ClaimFilingIndicatorCode_09 = "CI";

            //  Occurrence of NM1 Loops in any order
            loop2000B.AllNM1 = new All_NM1_837P_2();

            //  Begin 2010BA Loop SUBSCRIBER 
            loop2000B.AllNM1.Loop2010BA = new Loop_2010BA_837P();

            //  1)EVV- The Individual Receiving the Service(s), Medicaid ID
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName = new NM1_InsuredName();
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SOLO";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactFirstName_04 = "HANS";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactMiddleName_05 = "RYAN";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B.AllNM1.Loop2010BA.NM1_SubscriberName.ResponseContactIdentifier_09 = "123456789012";

            //  SUBSCRIBER SEX: F and DOB: 05 / 01 / 43
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation = new DMG_DependentDemographicInformation();
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DependentBirthDate_02 = "19430501";
            loop2000B.AllNM1.Loop2010BA.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "F";

            //  End 2010BA Loop SUBSCRIBER 

            //  Begin 2010BB Loop PAYER 
            loop2000B.AllNM1.Loop2010BB = new Loop_2010BB_837P();

            //  Payer name is Key Insurance Company with PAYER ID: 999996666
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName = new NM1_CorrectedPriorityPayerName();
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactLastorOrganizationName_03 = "KEY INSURANCE COMPANY";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B.AllNM1.Loop2010BB.NM1_PayerName.ResponseContactIdentifier_09 = "999996666";

            //  Occurrence of REF in any order
            loop2000B.AllNM1.Loop2010BB.AllREF = new All_REF_837P_5();

            //  Repeating REF
            loop2000B.AllNM1.Loop2010BB.AllREF.REF_BillingProviderSecondaryIdentification = new List<REF_BillingProviderSecondaryIdentification>();

            //  KEY INSURANCE COMPANY PROVIDER ID #: KA6663
            var refLoop2000B = new REF_BillingProviderSecondaryIdentification();
            refLoop2000B.ReferenceIdentificationQualifier_01 = "G2";
            refLoop2000B.MemberGrouporPolicyNumber_02 = "KA6663";
            loop2000B.AllNM1.Loop2010BB.AllREF.REF_BillingProviderSecondaryIdentification.Add(refLoop2000B);

            //  End 2010BB Loop PAYER 

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_837P>();

            //  Begin 2000C Loop PATIENT Hierarchy
            var loop2000C = new Loop_2000C_837P();

            //  Hierarchical Number 3
            loop2000C.HL_PatientHierarchicalLevel = new HL_DependentLevel();
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalIDNumber_01 = "3";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalLevelCode_03 = "23";
            loop2000C.HL_PatientHierarchicalLevel.HierarchicalChildCode_04 = "0";

            loop2000C.PAT_PatientInformation = new PAT_PatientInformation();
            loop2000C.PAT_PatientInformation.IndividualRelationshipCode_01 = "19";

            //  Begin 2010CA Loop PATIENT
            loop2000C.Loop2010CA = new Loop_2010CA_837P();

            //  PATIENT name is Ted Smith
            loop2000C.Loop2010CA.NM1_PatientName = new NM1_DependentName_2();
            loop2000C.Loop2010CA.NM1_PatientName.EntityIdentifierCode_01 = "QC";
            loop2000C.Loop2010CA.NM1_PatientName.EntityTypeQualifier_02 = "1";
            loop2000C.Loop2010CA.NM1_PatientName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000C.Loop2010CA.NM1_PatientName.ResponseContactFirstName_04 = "TED";

            //  PATIENT ADDRESS: 236 N. Main St.
            loop2000C.Loop2010CA.N3_PatientAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000C.Loop2010CA.N3_PatientAddress.ResponseContactAddressLine_01 = "236 N MAIN ST";

            //  PATIENT LOCATION: Miami, Fl, 33413
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000C.Loop2010CA.N4_PatientCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33413";

            //  PATIENT SEX: M and DOB: 05 / 01 / 73
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation = new DMG_DependentDemographicInformation();
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DependentBirthDate_02 = "19730501";
            loop2000C.Loop2010CA.DMG_PatientDemographicInformation.DependentGenderCode_03 = "M";

            //  End 2010CA Loop PATIENT

            //  Repeating 2300 Loops
            loop2000C.Loop2300 = new List<Loop_2300_837P>();

            //  Begin 2300 Loop CLAIM
            var loop2300 = new Loop_2300_837P();

            //  PATIENT ACCOUNT NUMBER: 2-646-3774 
            loop2300.CLM_ClaimInformation = new CLM_ClaimInformation();
            loop2300.CLM_ClaimInformation.PatientControlNumber_01 = "26463774";
            loop2300.CLM_ClaimInformation.TotalClaimChargeAmount_02 = "100";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation();
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityTypeCode_01 = "11";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityCodeQualifier_02 = "B";
            loop2300.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.ClaimFrequencyTypeCode_03 = "1";
            loop2300.CLM_ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop2300.CLM_ClaimInformation.AssignmentorPlanParticipationCode_07 = "A";
            loop2300.CLM_ClaimInformation.BenefitsAssignmentCertificationIndicator_08 = "Y";
            loop2300.CLM_ClaimInformation.ReleaseofInformationCode_09 = "I";

            //  Occurrence of REF in any order
            loop2300.AllREF = new All_REF_837P_6();

            //  ELECTRONIC ROUTE: Billing provider (sender), to VAN to Key Insurance Company (receiver). VAN claim identification number = 17312345600006351.
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries = new REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries();
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries.ReferenceIdentificationQualifier_01 = "D9";
            loop2300.AllREF.REF_ClaimIdentifierForTransmissionIntermediaries.MemberGrouporPolicyNumber_02 = "17312345600006351";

            //  Occurrence of HI in any order
            loop2300.AllHI = new All_HI_837P();

            //  CASE: Patient has sore throat.
            loop2300.AllHI.HI_HealthCareDiagnosisCode = new HI_DependentHealthCareDiagnosisCode();
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation();
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BK";
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.IndustryCode_02 = "0340";
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_02 = new C022_HealthCareCodeInformation();
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_02.CodeListQualifierCode_01 = "BF";
            loop2300.AllHI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_02.IndustryCode_02 = "V7389";

            //  Repeating 2400 Loops
            loop2300.Loop2400 = new List<Loop_2400_837P>();

            //  Begin 2400 Loop SERVICE LINE 1
            var loop24001 = new Loop_2400_837P();

            loop24001.LX_ServiceLineNumber = new LX_HeaderNumber();
            loop24001.LX_ServiceLineNumber.AssignedNumber_01 = "1";

            //  2)EVV- The Type of Service Performed, Service Line Procedure Code SV101-1
            //  3)EVV - The Time the Services Begins and Ends, Service Line Description SV101-7
            loop24001.SV1_ProfessionalService = new SV1_ProfessionalService();
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier();
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "S5135";
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductServiceID_08 = "1230-1630";
            loop24001.SV1_ProfessionalService.LineItemChargeAmount_02 = "50";
            loop24001.SV1_ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24001.SV1_ProfessionalService.ServiceUnitCount_04 = "2";
            loop24001.SV1_ProfessionalService.PlaceofServiceCode_05 = "11";
            loop24001.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24001.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "1";

            //  Occurrence of DTP in any order
            loop24001.AllDTP = new All_DTP_837P();

            //  4)EVV- The Date(s) of Service Performed, Service Line Dates of Service 
            loop24001.AllDTP.DTP_Date_ServiceDate = new DTP_ClaimLevelServiceDate();
            loop24001.AllDTP.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop24001.AllDTP.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "RD8";
            loop24001.AllDTP.DTP_Date_ServiceDate.AccidentDate_03 = "20160302-20160302";

            //  5)EVV- The Individual Providing the Services (2 Segments)
            loop24001.AllNM1 = new All_NM1_837P_5();

            loop24001.AllNM1.Loop2420D = new Loop_2420D_837P();

            //  Attendant's Name
            loop24001.AllNM1.Loop2420D.NM1_SupervisingProviderName = new NM1_OtherPayerSupervisingProvider();
            loop24001.AllNM1.Loop2420D.NM1_SupervisingProviderName.EntityIdentifierCode_01 = "DQ";
            loop24001.AllNM1.Loop2420D.NM1_SupervisingProviderName.EntityTypeQualifier_02 = "1";
            loop24001.AllNM1.Loop2420D.NM1_SupervisingProviderName.ResponseContactLastorOrganizationName_03 = "JONES";
            loop24001.AllNM1.Loop2420D.NM1_SupervisingProviderName.ResponseContactFirstName_04 = "DEVIL";

            loop24001.AllNM1.Loop2420D.REF_SupervisingProviderSecondaryIdentification = new List<REF_AssistantSurgeonSecondaryIdentification>();

            //  Attendant's ID 
            var refAssistantSurgeonSecondaryIdentification = new REF_AssistantSurgeonSecondaryIdentification();
            refAssistantSurgeonSecondaryIdentification.ReferenceIdentificationQualifier_01 = "LU";
            refAssistantSurgeonSecondaryIdentification.MemberGrouporPolicyNumber_02 = "1234567890";
            loop24001.AllNM1.Loop2420D.REF_SupervisingProviderSecondaryIdentification.Add(refAssistantSurgeonSecondaryIdentification);

            //  6)EVV- The Beginning/Ending Location of the Service Delivery (3 Address Segments each)

            //  Beginning Location of Service
            loop24001.AllNM1.Loop2420G = new Loop_2420G_837P();

            loop24001.AllNM1.Loop2420G.NM1_AmbulancePick_Location = new NM1_AmbulancePick();
            loop24001.AllNM1.Loop2420G.NM1_AmbulancePick_Location.EntityIdentifierCode_01 = "PW";
            loop24001.AllNM1.Loop2420G.NM1_AmbulancePick_Location.EntityTypeQualifier_02 = "2";

            loop24001.AllNM1.Loop2420G.N3_AmbulancePick_LocationAddress = new N3_AdditionalPatientInformationContactAddress();
            loop24001.AllNM1.Loop2420G.N3_AmbulancePick_LocationAddress.ResponseContactAddressLine_01 = "2777 HOOCH LANE";
            loop24001.AllNM1.Loop2420G.N3_AmbulancePick_LocationAddress.ResponseContactAddressLine_02 = "APT 2005";

            loop24001.AllNM1.Loop2420G.N4_AmbulancePick_LocationCity_State_ZipCode = new N4_AdditionalPatientInformationContactCity();
            loop24001.AllNM1.Loop2420G.N4_AmbulancePick_LocationCity_State_ZipCode.AdditionalPatientInformationContactCityName_01 = "CLARICE";
            loop24001.AllNM1.Loop2420G.N4_AmbulancePick_LocationCity_State_ZipCode.AdditionalPatientInformationContactStateCode_02 = "VA";
            loop24001.AllNM1.Loop2420G.N4_AmbulancePick_LocationCity_State_ZipCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "22554";

            //  Ending Location of Service (may be same or different from Beginning Location of Service) 
            loop24001.AllNM1.Loop2420H = new Loop_2420H_837P();

            loop24001.AllNM1.Loop2420H.NM1_AmbulanceDrop_Location = new NM1_AmbulanceDrop();
            loop24001.AllNM1.Loop2420H.NM1_AmbulanceDrop_Location.EntityIdentifierCode_01 = "45";
            loop24001.AllNM1.Loop2420H.NM1_AmbulanceDrop_Location.EntityTypeQualifier_02 = "2";

            loop24001.AllNM1.Loop2420H.N3_AmbulanceDrop_LocationAddress = new N3_AdditionalPatientInformationContactAddress();
            loop24001.AllNM1.Loop2420H.N3_AmbulanceDrop_LocationAddress.ResponseContactAddressLine_01 = "4545 RETURN ST";

            loop24001.AllNM1.Loop2420H.N4_AmbulanceDrop_LocationCity_State_ZipCode = new N4_AdditionalPatientInformationContactCity();
            loop24001.AllNM1.Loop2420H.N4_AmbulanceDrop_LocationCity_State_ZipCode.AdditionalPatientInformationContactCityName_01 = "NUCHOL";
            loop24001.AllNM1.Loop2420H.N4_AmbulanceDrop_LocationCity_State_ZipCode.AdditionalPatientInformationContactStateCode_02 = "VA";
            loop24001.AllNM1.Loop2420H.N4_AmbulanceDrop_LocationCity_State_ZipCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "22554";

            //  End 2400 Loop SERVICE LINE 1
            loop2300.Loop2400.Add(loop24001);

            //  End 2300 Loop CLAIM
            loop2000C.Loop2300.Add(loop2300);

            //  End 2000C Loop PATIENT Hierarchy
            loop2000B.Loop2000C.Add(loop2000C);

            //  End 2000B Loop SUBSCRIBER Hierarchy
            loop2000A.Loop2000B.Add(loop2000B);

            //  End 2000A Loop BILLING PROVIDER Hierarchy
            result.Loop2000A.Add(loop2000A);

            return result;
        }
    }
}
