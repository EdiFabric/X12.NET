using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Rules.HIPAA_5010;
using System.Collections.Generic;

namespace EdiFabric.Sdk.Helpers.X12
{
    public static class HipaaTransactionBuilders
    {
        /// <summary>
        /// Build claim.
        /// Original from http://www.x12.org/examples/005010X222/commercial-health-insurance/
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
            result.BeginningofHierarchicalTransaction = new BHT_BeginningofHierarchicalTransaction_7();
            result.BeginningofHierarchicalTransaction.HierarchicalStructureCode_01 = "0019";
            result.BeginningofHierarchicalTransaction.TransactionSetPurposeCode_02 = "00";
            result.BeginningofHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "244579";
            result.BeginningofHierarchicalTransaction.TransactionSetCreationDate_04 = "20061015";
            result.BeginningofHierarchicalTransaction.TransactionSetCreationTime_05 = "1023";
            result.BeginningofHierarchicalTransaction.TransactionTypeCode_06 = "CH";

            //  Occurrence of NM1 Loops in any order
            result.AllNM1 = new All_NM1_TS837P();

            //  Begin 1000A Loop SUBMITTER
            result.AllNM1.Loop1000A = new Loop_1000A_TS837P();

            //  Premier Billing Service with EDI# TGJ23
            result.AllNM1.Loop1000A.SubmitterName = new NM1_InformationReceiverName_4();
            result.AllNM1.Loop1000A.SubmitterName.EntityIdentifierCode_01 = "41";
            result.AllNM1.Loop1000A.SubmitterName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000A.SubmitterName.ResponseContactLastorOrganizationName_03 = "PREMIER BILLING SERVICE";
            result.AllNM1.Loop1000A.SubmitterName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000A.SubmitterName.ResponseContactIdentifier_09 = "TGJ23";

            //  Repeating PER
            result.AllNM1.Loop1000A.SubmitterEDIContactInformation = new List<PER_BillingProviderContactInformation>();

            //  CONTACT PERSON AND PHONE NUMBER: JERRY, 305-555-2222 ext. 231
            var perLoop1000A = new PER_BillingProviderContactInformation();
            perLoop1000A.ContactFunctionCode_01 = "IC";
            perLoop1000A.ResponseContactName_02 = "JERRY";
            perLoop1000A.CommunicationNumberQualifier_03 = "TE";
            perLoop1000A.ResponseContactCommunicationNumber_04 = "3055552222";
            perLoop1000A.CommunicationNumberQualifier_05 = "EX";
            perLoop1000A.ResponseContactCommunicationNumber_06 = "231";
            result.AllNM1.Loop1000A.SubmitterEDIContactInformation.Add(perLoop1000A);

            //  End 1000A Loop SUBMITTER

            //  Begin 1000B Loop RECEIVER
            result.AllNM1.Loop1000B = new Loop_1000B_TS837P();

            //  Key Insurance Company with EDI #:66783JJT
            result.AllNM1.Loop1000B.ReceiverName = new NM1_ReceiverName();
            result.AllNM1.Loop1000B.ReceiverName.EntityIdentifierCode_01 = "40";
            result.AllNM1.Loop1000B.ReceiverName.EntityTypeQualifier_02 = "2";
            result.AllNM1.Loop1000B.ReceiverName.ResponseContactLastorOrganizationName_03 = "KEY INSURANCE COMPANY";
            result.AllNM1.Loop1000B.ReceiverName.IdentificationCodeQualifier_08 = "46";
            result.AllNM1.Loop1000B.ReceiverName.ResponseContactIdentifier_09 = "66783JJT";

            //  End 1000B Loop RECEIVER

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_TS837P>();

            //  Begin 2000A Loop BILLING PROVIDER Hierarchy
            var loop2000A = new Loop_2000A_TS837P();

            //  Hierarchical Number 1
            loop2000A.BillingProviderHierarchicalLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.BillingProviderHierarchicalLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.BillingProviderHierarchicalLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.BillingProviderHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  Taxonomy Code: 203BF0100Y
            loop2000A.BillingProviderSpecialtyInformation = new PRV_BillingProviderSpecialtyInformation();
            loop2000A.BillingProviderSpecialtyInformation.ProviderCode_01 = "BI";
            loop2000A.BillingProviderSpecialtyInformation.ReferenceIdentificationQualifier_02 = "PXC";
            loop2000A.BillingProviderSpecialtyInformation.ProviderTaxonomyCode_03 = "203BF0100Y";

            //  Occurrence of NM1 Loops in any order
            loop2000A.AllNM1 = new All_NM1_2_TS837P();

            //  Begin 2010AA Loop BILLING PROVIDER
            loop2000A.AllNM1.Loop2010AA = new Loop_2010AA_TS837P();

            //  Name is BEN KILDARE SERVICE with NPI: 9876543210
            loop2000A.AllNM1.Loop2010AA.BillingProviderName = new NM1_BillingProviderName_2();
            loop2000A.AllNM1.Loop2010AA.BillingProviderName.EntityIdentifierCode_01 = "85";
            loop2000A.AllNM1.Loop2010AA.BillingProviderName.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AA.BillingProviderName.ResponseContactLastorOrganizationName_03 = "BEN KILDARE SERVICE";
            loop2000A.AllNM1.Loop2010AA.BillingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2000A.AllNM1.Loop2010AA.BillingProviderName.ResponseContactIdentifier_09 = "9876543210";

            //  ADDRESS: 234 Seaway St
            loop2000A.AllNM1.Loop2010AA.BillingProviderAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AA.BillingProviderAddress.ResponseContactAddressLine_01 = "234 SEAWAY ST";

            //  LOCATION: Miami, FL, 33111
            loop2000A.AllNM1.Loop2010AA.BillingProviderCity = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AA.BillingProviderCity.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000A.AllNM1.Loop2010AA.BillingProviderCity.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000A.AllNM1.Loop2010AA.BillingProviderCity.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33111";

            //  Occurrence of REF Loops in any order
            loop2000A.AllNM1.Loop2010AA.AllREF = new All_REF_TS837P();

            //  TIN: 587654321
            loop2000A.AllNM1.Loop2010AA.AllREF.BillingProviderTaxIdentification = new REF_BillingProviderTaxIdentification();
            loop2000A.AllNM1.Loop2010AA.AllREF.BillingProviderTaxIdentification.ReferenceIdentificationQualifier_01 = "EI";
            loop2000A.AllNM1.Loop2010AA.AllREF.BillingProviderTaxIdentification.MemberGrouporPolicyNumber_02 = "587654321";

            //  End 2010AA Loop BILLING PROVIDER

            //  Begin 2010AB Loop PAY-TO PROVIDER
            loop2000A.AllNM1.Loop2010AB = new Loop_2010AB_TS837P();

            //  PAY-TO PROVIDER Name is Kildare Associates
            loop2000A.AllNM1.Loop2010AB.Pay = new NM1_Pay();
            loop2000A.AllNM1.Loop2010AB.Pay.EntityIdentifierCode_01 = "87";
            loop2000A.AllNM1.Loop2010AB.Pay.EntityTypeQualifier_02 = "2";
            loop2000A.AllNM1.Loop2010AB.Pay.ResponseContactLastorOrganizationName_03 = "Kildare Associates";

            //  PROVIDER ADDRESS: 2345 Ocean Blvd
            loop2000A.AllNM1.Loop2010AB.Pay_02 = new N3_AdditionalPatientInformationContactAddress();
            loop2000A.AllNM1.Loop2010AB.Pay_02.ResponseContactAddressLine_01 = "2345 OCEAN BLVD";

            //  PROVIDER LOCATION: Miami, Fl 33111
            loop2000A.AllNM1.Loop2010AB.Pay_03 = new N4_AdditionalPatientInformationContactCity();
            loop2000A.AllNM1.Loop2010AB.Pay_03.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000A.AllNM1.Loop2010AB.Pay_03.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000A.AllNM1.Loop2010AB.Pay_03.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33111";

            //  End 2010AB Loop PAY-TO PROVIDER

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_TS837P>();

            //  Begin 2000B Loop SUBSCRIBER Hierarchy
            var loop2000B = new Loop_2000B_TS837P();

            //  Hierarchical Number 2
            loop2000B.SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B.SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B.SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "1";

            //  SUBSCRIBER GROUP #: 2222-SJ
            loop2000B.SubscriberInformation = new SBR_SubscriberInformation();
            loop2000B.SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B.SubscriberInformation.InsuredGrouporPolicyNumber_03 = "2222-SJ";
            loop2000B.SubscriberInformation.ClaimFilingIndicatorCode_09 = "CI";

            //  Occurrence of NM1 Loops in any order
            loop2000B.AllNM1 = new All_NM1_3_TS837P();

            //  Begin 2010BA Loop SUBSCRIBER 
            loop2000B.AllNM1.Loop2010BA = new Loop_2010BA_TS837P();

            //  SUBSCRIBER name is Jane Smith
            loop2000B.AllNM1.Loop2010BA.SubscriberName = new NM1_SubscriberName_5();
            loop2000B.AllNM1.Loop2010BA.SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B.AllNM1.Loop2010BA.SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B.AllNM1.Loop2010BA.SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000B.AllNM1.Loop2010BA.SubscriberName.ResponseContactFirstName_04 = "JANE";
            loop2000B.AllNM1.Loop2010BA.SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B.AllNM1.Loop2010BA.SubscriberName.ResponseContactIdentifier_09 = "JS00111223333";

            //  SUBSCRIBER SEX: F and DOB: 05 / 01 / 43
            loop2000B.AllNM1.Loop2010BA.SubscriberDemographicInformation = new DMG_PatientDemographicInformation();
            loop2000B.AllNM1.Loop2010BA.SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000B.AllNM1.Loop2010BA.SubscriberDemographicInformation.DependentBirthDate_02 = "19430501";
            loop2000B.AllNM1.Loop2010BA.SubscriberDemographicInformation.DependentGenderCode_03 = "F";

            //  End 2010BA Loop SUBSCRIBER 

            //  Begin 2010BB Loop PAYER 
            loop2000B.AllNM1.Loop2010BB = new Loop_2010BB_TS837P();

            //  Payer name is Key Insurance Company with PAYER ID: 999996666
            loop2000B.AllNM1.Loop2010BB.PayerName = new NM1_OtherPayerName();
            loop2000B.AllNM1.Loop2010BB.PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B.AllNM1.Loop2010BB.PayerName.EntityTypeQualifier_02 = "2";
            loop2000B.AllNM1.Loop2010BB.PayerName.ResponseContactLastorOrganizationName_03 = "KEY INSURANCE COMPANY";
            loop2000B.AllNM1.Loop2010BB.PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B.AllNM1.Loop2010BB.PayerName.ResponseContactIdentifier_09 = "999996666";

            //  Occurrence of REF in any order
            loop2000B.AllNM1.Loop2010BB.AllREF = new All_REF_4_TS837P();

            //  Repeating REF
            loop2000B.AllNM1.Loop2010BB.AllREF.BillingProviderSecondaryIdentification = new List<REF_BillingProviderSecondaryIdentification>();

            //  KEY INSURANCE COMPANY PROVIDER ID #: KA6663
            var refLoop2000B = new REF_BillingProviderSecondaryIdentification();
            refLoop2000B.ReferenceIdentificationQualifier_01 = "G2";
            refLoop2000B.MemberGrouporPolicyNumber_02 = "KA6663";
            loop2000B.AllNM1.Loop2010BB.AllREF.BillingProviderSecondaryIdentification.Add(refLoop2000B);

            //  End 2010BB Loop PAYER 

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_TS837P>();

            //  Begin 2000C Loop PATIENT Hierarchy
            var loop2000C = new Loop_2000C_TS837P();

            //  Hierarchical Number 3
            loop2000C.PatientHierarchicalLevel = new HL_DependentLevel();
            loop2000C.PatientHierarchicalLevel.HierarchicalIDNumber_01 = "3";
            loop2000C.PatientHierarchicalLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C.PatientHierarchicalLevel.HierarchicalLevelCode_03 = "23";
            loop2000C.PatientHierarchicalLevel.HierarchicalChildCode_04 = "0";

            loop2000C.PatientInformation = new PAT_PatientInformation();
            loop2000C.PatientInformation.IndividualRelationshipCode_01 = "19";

            //  Begin 2010CA Loop PATIENT
            loop2000C.Loop2010CA = new Loop_2010CA_TS837P();

            //  PATIENT name is Ted Smith
            loop2000C.Loop2010CA.PatientName = new NM1_PatientName_3();
            loop2000C.Loop2010CA.PatientName.EntityIdentifierCode_01 = "QC";
            loop2000C.Loop2010CA.PatientName.EntityTypeQualifier_02 = "1";
            loop2000C.Loop2010CA.PatientName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000C.Loop2010CA.PatientName.ResponseContactFirstName_04 = "TED";

            //  PATIENT ADDRESS: 236 N. Main St.
            loop2000C.Loop2010CA.PatientAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000C.Loop2010CA.PatientAddress.ResponseContactAddressLine_01 = "236 N MAIN ST";

            //  PATIENT LOCATION: Miami, Fl, 33413
            loop2000C.Loop2010CA.PatientCity = new N4_AdditionalPatientInformationContactCity();
            loop2000C.Loop2010CA.PatientCity.AdditionalPatientInformationContactCityName_01 = "MIAMI";
            loop2000C.Loop2010CA.PatientCity.AdditionalPatientInformationContactStateCode_02 = "FL";
            loop2000C.Loop2010CA.PatientCity.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "33413";

            //  PATIENT SEX: M and DOB: 05 / 01 / 73
            loop2000C.Loop2010CA.PatientDemographicInformation = new DMG_PatientDemographicInformation();
            loop2000C.Loop2010CA.PatientDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000C.Loop2010CA.PatientDemographicInformation.DependentBirthDate_02 = "19730501";
            loop2000C.Loop2010CA.PatientDemographicInformation.DependentGenderCode_03 = "M";

            //  End 2010CA Loop PATIENT

            //  Repeating 2300 Loops
            loop2000C.Loop2300 = new List<Loop_2300_2_TS837P>();

            //  Begin 2300 Loop CLAIM
            var loop2300 = new Loop_2300_2_TS837P();

            //  PATIENT ACCOUNT NUMBER: 2-646-3774 
            loop2300.ClaimInformation = new CLM_ClaimInformation_2();
            loop2300.ClaimInformation.PatientControlNumber_01 = "26463774";
            loop2300.ClaimInformation.TotalClaimChargeAmount_02 = "100";
            loop2300.ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation_2();
            loop2300.ClaimInformation.HealthCareServiceLocationInformation_05.FacilityTypeCode_01 = "11";
            loop2300.ClaimInformation.HealthCareServiceLocationInformation_05.FacilityCodeQualifier_02 = "B";
            loop2300.ClaimInformation.HealthCareServiceLocationInformation_05.ClaimFrequencyTypeCode_03 = "1";
            loop2300.ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop2300.ClaimInformation.AssignmentorPlanParticipationCode_07 = "A";
            loop2300.ClaimInformation.BenefitsAssignmentCertificationIndicator_08 = "Y";
            loop2300.ClaimInformation.ReleaseofInformationCode_09 = "I";

            //  Occurrence of REF in any order
            loop2300.AllREF = new All_REF_5_TS837P();

            //  ELECTRONIC ROUTE: Billing provider (sender), to VAN to Key Insurance Company (receiver). VAN claim identification number = 17312345600006351.
            loop2300.AllREF.ClaimIdentifierForTransmissionIntermediaries = new REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries();
            loop2300.AllREF.ClaimIdentifierForTransmissionIntermediaries.ReferenceIdentificationQualifier_01 = "D9";
            loop2300.AllREF.ClaimIdentifierForTransmissionIntermediaries.MemberGrouporPolicyNumber_02 = "17312345600006351";

            //  Occurrence of HI in any order
            loop2300.AllHI = new All_HI_2_TS837P();

            //  CASE: Patient has sore throat.
            loop2300.AllHI.HealthCareDiagnosisCode = new HI_DependentHealthCareDiagnosisCode();
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_8();
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BK";
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_01.IndustryCode_02 = "0340";
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_02 = new C022_HealthCareCodeInformation_4();
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_02.CodeListQualifierCode_01 = "BF";
            loop2300.AllHI.HealthCareDiagnosisCode.HealthCareCodeInformation_02.IndustryCode_02 = "V7389";

            //  Repeating 2400 Loops
            loop2300.Loop2400 = new List<Loop_2400_2_TS837P>();

            //  Begin 2400 Loop SERVICE LINE 1
            var loop24001 = new Loop_2400_2_TS837P();

            loop24001.ServiceLineNumber = new LX_HeaderNumber();
            loop24001.ServiceLineNumber.AssignedNumber_01 = "1";

            //  SERVICES: Office visit, intermediate service, established patient, throat culture.
            //  CHARGES: Office first visit = $40.00
            loop24001.ProfessionalService = new SV1_ProfessionalService();
            loop24001.ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_12();
            loop24001.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24001.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "99213";
            loop24001.ProfessionalService.LineItemChargeAmount_02 = "40";
            loop24001.ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24001.ProfessionalService.ServiceUnitCount_04 = "1";
            loop24001.ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24001.ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "1";

            //  Occurrence of DTP in any order
            loop24001.AllDTP = new All_DTP_2_TS837P();

            //  INITIAL VISIT: DOS=10/03/06. POS=Office
            loop24001.AllDTP.Date = new DTP_ClaimLevelServiceDate();
            loop24001.AllDTP.Date.DateTimeQualifier_01 = "472";
            loop24001.AllDTP.Date.DateTimePeriodFormatQualifier_02 = "D8";
            loop24001.AllDTP.Date.AccidentDate_03 = "20061003";

            //  End 2400 Loop SERVICE LINE 1
            loop2300.Loop2400.Add(loop24001);

            //  Begin 2400 Loop SERVICE LINE 2
            var loop24002 = new Loop_2400_2_TS837P();

            loop24002.ServiceLineNumber = new LX_HeaderNumber();
            loop24002.ServiceLineNumber.AssignedNumber_01 = "2";

            //  SERVICES: Office visit, intermediate service, established patient, throat culture.
            //  CHARGES: Lab test for strep = $15.00
            loop24002.ProfessionalService = new SV1_ProfessionalService();
            loop24002.ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_12();
            loop24002.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24002.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "87070";
            loop24002.ProfessionalService.LineItemChargeAmount_02 = "15";
            loop24002.ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24002.ProfessionalService.ServiceUnitCount_04 = "1";
            loop24002.ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24002.ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "1";

            //  Occurrence of DTP in any order
            loop24002.AllDTP = new All_DTP_2_TS837P();

            //  INITIAL VISIT: DOS=10/03/06. POS=Office
            loop24002.AllDTP.Date = new DTP_ClaimLevelServiceDate();
            loop24002.AllDTP.Date.DateTimeQualifier_01 = "472";
            loop24002.AllDTP.Date.DateTimePeriodFormatQualifier_02 = "D8";
            loop24002.AllDTP.Date.AccidentDate_03 = "20061003";

            //  End 2400 Loop SERVICE LINE 2
            loop2300.Loop2400.Add(loop24002);

            //  Begin 2400 Loop SERVICE LINE 3
            var loop24003 = new Loop_2400_2_TS837P();

            loop24003.ServiceLineNumber = new LX_HeaderNumber();
            loop24003.ServiceLineNumber.AssignedNumber_01 = "3";

            //  SERVICES: Office visit, intermediate service, established patient, mono screening.
            //  CHARGES: Follow-up visit = $35.00
            loop24003.ProfessionalService = new SV1_ProfessionalService();
            loop24003.ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_12();
            loop24003.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24003.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "99214";
            loop24003.ProfessionalService.LineItemChargeAmount_02 = "35";
            loop24003.ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24003.ProfessionalService.ServiceUnitCount_04 = "1";
            loop24003.ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24003.ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "2";

            //  Occurrence of DTP in any order
            loop24003.AllDTP = new All_DTP_2_TS837P();

            //  FOLLOW-UP VISIT: DOS=10/10/06 POS=Office
            loop24003.AllDTP.Date = new DTP_ClaimLevelServiceDate();
            loop24003.AllDTP.Date.DateTimeQualifier_01 = "472";
            loop24003.AllDTP.Date.DateTimePeriodFormatQualifier_02 = "D8";
            loop24003.AllDTP.Date.AccidentDate_03 = "20061010";

            //  End 2400 Loop SERVICE LINE 3
            loop2300.Loop2400.Add(loop24003);

            //  Begin 2400 Loop SERVICE LINE 4
            var loop24004 = new Loop_2400_2_TS837P();

            loop24004.ServiceLineNumber = new LX_HeaderNumber();
            loop24004.ServiceLineNumber.AssignedNumber_01 = "4";

            //  SERVICES: Office visit, intermediate service, established patient, mono screening.
            //  CHARGES: Lab test for mono = $10.00
            loop24004.ProfessionalService = new SV1_ProfessionalService();
            loop24004.ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_12();
            loop24004.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24004.ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "86663";
            loop24004.ProfessionalService.LineItemChargeAmount_02 = "10";
            loop24004.ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24004.ProfessionalService.ServiceUnitCount_04 = "1";
            loop24004.ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24004.ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "2";

            //  Occurrence of DTP in any order
            loop24004.AllDTP = new All_DTP_2_TS837P();

            //  FOLLOW-UP VISIT: DOS=10/10/06 POS=Office
            loop24004.AllDTP.Date = new DTP_ClaimLevelServiceDate();
            loop24004.AllDTP.Date.DateTimeQualifier_01 = "472";
            loop24004.AllDTP.Date.DateTimePeriodFormatQualifier_02 = "D8";
            loop24004.AllDTP.Date.AccidentDate_03 = "20061010";

            //  End 2400 Loop SERVICE LINE 4
            loop2300.Loop2400.Add(loop24004);

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
