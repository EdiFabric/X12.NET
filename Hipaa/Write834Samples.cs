using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.HIPAA_005010X222A1_834;

namespace EdiFabric.Sdk.Hipaa
{
    class Write834Samples
    {
        public static void Run()
        {
            WriteSingleMemberToStream();
        }

        /// <summary>
        /// Generate and write claim to a stream
        /// </summary>
        static void WriteSingleMemberToStream()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");
        }


        /// <summary>
        /// Sample claim
        /// </summary>
        static TS834 CreateClaim(string controlNumber)
        {
            string CurrentDate = DateTime.Now.ToString("yyyyMMdd");
            var result = new TS834();

            //Heading
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "834";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X222A1";
            result.BGN = new BGN();
            result.BGN.TransactionSetPurposeCode_01 = "00";
            result.BGN.TransactionSetReferenceNumber_02 = "WSU-WEY-20050221-1";
            result.BGN.TransactionSetCreationDate_03 = CurrentDate;
            result.BGN.TransactionSetCreationTime_04 = DateTime.Now.ToString("hhmmss");
            result.BGN.TimeZoneCode_05 = "PT"; //Optional but most Carriers use
            //result.BGN.ReferenceIdentification_06 = ""; //Not usually sent
            result.BGN.ActionCode_07 = "4"; //2 = Change, 4 = Verify, RX = replace
            //Optional REF
            result.REF_TransactionSetPolicyNumber = new REF_TransactionSetPolicyNumber();
            result.REF_TransactionSetPolicyNumber.ReferenceIdentificationQualifier_01 = "38";
            result.REF_TransactionSetPolicyNumber.ReferenceIdentification_02 = "01-23456";//Carrier/Vendor specific

            //Optional DTP
            result.DTP_FileEffectiveDate.DateTimeQualifier_01 = "007";
            result.DTP_FileEffectiveDate.DateTimePeriodFormatQualifier_02 = "D8";
            result.DTP_FileEffectiveDate.DateTimePeriod_03 = CurrentDate;

            //Optional QTY
            result.QTY_TransactionSetControlTotals = new QTY();
            result.QTY_TransactionSetControlTotals.QuantityQualifier_01 = "TO";
            result.QTY_TransactionSetControlTotals.Quantity_02 = "1";//Only one record for this example.

            //Loop 1000
            result.All_NM1 = new All_NM1();

            //Loop 1000A
            result.All_NM1.Loop_1000A = new Loop_1000A();
            result.All_NM1.Loop_1000A.NM1_SponsorName.EntityIdentifierCode_01 = "P5";
            result.All_NM1.Loop_1000A.NM1_SponsorName.Name_02 = "Sponsor Name";
            result.All_NM1.Loop_1000A.NM1_SponsorName.IdentificationCodeQualifier_03 = "FI";
            result.All_NM1.Loop_1000A.NM1_SponsorName.IdentificationCode_04 = "1223456";

            //Loop 1000B
            result.All_NM1.Loop_1000B = new Loop_1000B();
            result.All_NM1.Loop_1000B.NM1_PayerName.EntityIdentifierCode_01 = "IN";
            result.All_NM1.Loop_1000B.NM1_PayerName.Name_02 = "ABC PAYER";
            result.All_NM1.Loop_1000B.NM1_PayerName.IdentificationCodeQualifier_03 = "FI";
            result.All_NM1.Loop_1000B.NM1_PayerName.IdentificationCode_04 = "11-111111";

            //result.All_NM1.Loop_1000C = new Loop_1000C();
            //Usually brokers are optional fields

            /*
            //Example 837, use as reference
            result.All_NM1 = new All_NM1();
            result.All_NM1.Loop_1000A = new Loop_1000A();

            result.All_NM1.Loop_1000A.NM1_SubmitterName = new NM1_SubmitterName();
            result.All_NM1.Loop_1000A.NM1_SubmitterName.EntityIdentifierCode_01 = "41";
            result.All_NM1.Loop_1000A.NM1_SubmitterName.EntityTypeQualifier_02 = "2";
            result.All_NM1.Loop_1000A.NM1_SubmitterName.SubmitterLastorOrganizationName_03 = "SUBMITTER";
            result.All_NM1.Loop_1000A.NM1_SubmitterName.IdentificationCodeQualifier_08 = "46";
            result.All_NM1.Loop_1000A.NM1_SubmitterName.SubmitterIdentifier_09 = "ABC123";


            result.All_NM1.Loop_1000A.PER_SubmitterEDIContactInformation = new List<PER_SubmitterEDIContactInformation>();
            var per1 = new PER_SubmitterEDIContactInformation();
            per1.ContactFunctionCode_01 = "IC";
            per1.SubmitterContactName_02 = "BOB SMITH";
            per1.CommunicationNumberQualifier_03 = "TE";
            per1.CommunicationNumber_04 = "4805551212";
            result.All_NM1.Loop_1000A.PER_SubmitterEDIContactInformation.Add(per1);

            result.All_NM1.Loop_1000B = new Loop_1000B();

            result.All_NM1.Loop_1000B.NM1_ReceiverName = new NM1_ReceiverName();
            result.All_NM1.Loop_1000B.NM1_ReceiverName.EntityIdentifierCode_01 = "40";
            result.All_NM1.Loop_1000B.NM1_ReceiverName.EntityTypeQualifier_02 = "2";
            result.All_NM1.Loop_1000B.NM1_ReceiverName.ReceiverName_03 = "RECEIVER";
            result.All_NM1.Loop_1000B.NM1_ReceiverName.IdentificationCodeQualifier_08 = "46";
            result.All_NM1.Loop_1000B.NM1_ReceiverName.ReceiverPrimaryIdentifier_09 = "44556";

            result.Loop_2000A = new List<Loop_2000A>();
            var loop2000A1 = new Loop_2000A();

            loop2000A1.HL_BillingProviderHierarchicalLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A1.HL_BillingProviderHierarchicalLevel.HierarchicalIDNumber_01 = "1";
            loop2000A1.HL_BillingProviderHierarchicalLevel.HierarchicalLevelCode_03 = "20";
            loop2000A1.HL_BillingProviderHierarchicalLevel.HierarchicalChildCode_04 = "1";

            loop2000A1.All_NM1_2 = new All_NM1_2();
            loop2000A1.All_NM1_2.Loop_2010AA = new Loop_2010AA();
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName = new NM1_BillingProviderName();
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName.EntityIdentifierCode_01 = "85";
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName.EntityTypeQualifier_02 = "2";
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName.BillingProviderLastorOrganizationalName_03 = "BILLING PROVIDER";
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2000A1.All_NM1_2.Loop_2010AA.NM1_BillingProviderName.BillingProviderIdentifier_09 = "1122334455";

            loop2000A1.All_NM1_2.Loop_2010AA.N3_BillingProviderAddress = new N3_BillingProviderAddress();
            loop2000A1.All_NM1_2.Loop_2010AA.N3_BillingProviderAddress.BillingProviderAddressLine_01 = "1234 SOME ROAD";

            loop2000A1.All_NM1_2.Loop_2010AA.N4_BillingProviderCity_State_ZIPCode = new N4_BillingProviderCity_State_ZIPCode();
            loop2000A1.All_NM1_2.Loop_2010AA.N4_BillingProviderCity_State_ZIPCode.BillingProviderCityName_01 = "CHICAGO";
            loop2000A1.All_NM1_2.Loop_2010AA.N4_BillingProviderCity_State_ZIPCode.BillingProviderStateorProvinceCode_02 = "IL";
            loop2000A1.All_NM1_2.Loop_2010AA.N4_BillingProviderCity_State_ZIPCode.BillingProviderPostalZoneorZIPCode_03 = "606739999";

            loop2000A1.All_NM1_2.Loop_2010AA.All_REF = new All_REF();
            loop2000A1.All_NM1_2.Loop_2010AA.All_REF.REF_BillingProviderTaxIdentification = new REF_BillingProviderTaxIdentification();
            loop2000A1.All_NM1_2.Loop_2010AA.All_REF.REF_BillingProviderTaxIdentification
                .ReferenceIdentificationQualifier_01 = "EI";
            loop2000A1.All_NM1_2.Loop_2010AA.All_REF.REF_BillingProviderTaxIdentification
                .BillingProviderTaxIdentificationNumber_02 = "999999999";

            loop2000A1.Loop_2000B = new List<Loop_2000B>();

            var loop2000B1 = new Loop_2000B();
            loop2000B1.HL_SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B1.HL_SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "2";
            loop2000B1.HL_SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B1.HL_SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B1.HL_SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "0";

            loop2000B1.SBR_SubscriberInformation = new SBR_SubscriberInformation();
            loop2000B1.SBR_SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B1.SBR_SubscriberInformation.IndividualRelationshipCode_02 = "18";
            loop2000B1.SBR_SubscriberInformation.ClaimFilingIndicatorCode_09 = "12";

            loop2000B1.All_NM1_3 = new All_NM1_3();
            loop2000B1.All_NM1_3.Loop_2010BA = new Loop_2010BA();
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName = new NM1_SubscriberName();
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberLastName_03 = "BLOGGS";
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberFirstName_04 = "JOE";
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B1.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberPrimaryIdentifier_09 = "1234567890";

            loop2000B1.All_NM1_3.Loop_2010BA.N3_SubscriberAddress = new N3_SubscriberAddress();
            loop2000B1.All_NM1_3.Loop_2010BA.N3_SubscriberAddress.SubscriberAddressLine_01 = "1 SOME BLVD";

            loop2000B1.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode = new N4_SubscriberCity_State_ZIPCode();
            loop2000B1.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberCityName_01 = "CHICAGO";
            loop2000B1.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberStateCode_02 = "IL";
            loop2000B1.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberPostalZoneorZIPCode_03 = "606129998";

            loop2000B1.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation = new DMG_SubscriberDemographicInformation();
            loop2000B1.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000B1.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.SubscriberBirthDate_02 = "19570111";
            loop2000B1.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.SubscriberGenderCode_03 = "M";

            loop2000B1.All_NM1_3.Loop_2010BB = new Loop_2010BB();
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName = new NM1_PayerName();
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName.PayerName_03 = "PAYER";
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B1.All_NM1_3.Loop_2010BB.NM1_PayerName.PayerIdentifier_09 = "12345";

            loop2000B1.All_NM1_3.Loop_2010BB.N3_PayerAddress = new N3_PayerAddress();
            loop2000B1.All_NM1_3.Loop_2010BB.N3_PayerAddress.PayerAddressLine_01 = "1 PAYER WAY";

            loop2000B1.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode = new N4_PayerCity_State_ZIPCode();
            loop2000B1.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerCityName_01 = "ST LOUIS";
            loop2000B1.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerStateorProvinceCode_02 = "MO";
            loop2000B1.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerPostalZoneorZIPCode_03 = "212441850";

            loop2000B1.All_NM1_3.Loop_2010BB.All_REF_4 = new All_REF_4();
            loop2000B1.All_NM1_3.Loop_2010BB.All_REF_4.REF_PayerSecondaryIdentification = new List<REF_PayerSecondaryIdentification>();
            var refPayer1 = new REF_PayerSecondaryIdentification();
            refPayer1.ReferenceIdentificationQualifier_01 = "2U";
            refPayer1.PayerSecondaryIdentifier_02 = "W1014";

            loop2000B1.All_NM1_3.Loop_2010BB.All_REF_4.REF_PayerSecondaryIdentification.Add(refPayer1);

            loop2000B1.Loop_2300 = new List<Loop_2300>();
            var loop23001 = new Loop_2300();
            loop23001.CLM_ClaimInformation = new CLM_ClaimInformation();
            loop23001.CLM_ClaimInformation.PatientControlNumber_01 = "1000A";
            loop23001.CLM_ClaimInformation.TotalClaimChargeAmount_02 = "140";
            loop23001.CLM_ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation();
            loop23001.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.PlaceofServiceCode_01 = "19";
            loop23001.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityCodeQualifier_02 = "B";
            loop23001.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.ClaimFrequencyCode_03 = "1";
            loop23001.CLM_ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop23001.CLM_ClaimInformation.AssignmentorPlanParticipationCode_07 = "A";
            loop23001.CLM_ClaimInformation.BenefitsAssignmentCertificationIndicator_08 = "Y";
            loop23001.CLM_ClaimInformation.ReleaseofInformationCode_09 = "Y";

            loop23001.All_HI = new All_HI();
            loop23001.All_HI.HI_HealthCareDiagnosisCode = new HI_HealthCareDiagnosisCode();
            loop23001.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation();
            loop23001.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.DiagnosisTypeCode_01 = "ABK";
            loop23001.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.DiagnosisCode_02 = "I10";

            loop23001.Loop_2400 = new List<Loop_2400>();
            var loop24001 = new Loop_2400();

            loop24001.LX_ServiceLineNumber = new LX_ServiceLineNumber();
            loop24001.LX_ServiceLineNumber.AssignedNumber_01 = "1";

            loop24001.SV1_ProfessionalService = new SV1_ProfessionalService();
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier();
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24001.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "99213";
            loop24001.SV1_ProfessionalService.LineItemChargeAmount_02 = "140";
            loop24001.SV1_ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24001.SV1_ProfessionalService.ServiceUnitCount_04 = "1";
            loop24001.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24001.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "1";

            loop24001.All_DTP_2 = new All_DTP_2();
            loop24001.All_DTP_2.DTP_Date_ServiceDate = new DTP_Date_ServiceDate();
            loop24001.All_DTP_2.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop24001.All_DTP_2.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop24001.All_DTP_2.DTP_Date_ServiceDate.ServiceDate_03 = "20151124";

            loop23001.Loop_2400.Add(loop24001);
            loop2000B1.Loop_2300.Add(loop23001);
            loop2000A1.Loop_2000B.Add(loop2000B1);

            // from here

            var loop2000B2 = new Loop_2000B();
            loop2000B2.HL_SubscriberHierarchicalLevel = new HL_SubscriberHierarchicalLevel();
            loop2000B2.HL_SubscriberHierarchicalLevel.HierarchicalIDNumber_01 = "3";
            loop2000B2.HL_SubscriberHierarchicalLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B2.HL_SubscriberHierarchicalLevel.HierarchicalLevelCode_03 = "22";
            loop2000B2.HL_SubscriberHierarchicalLevel.HierarchicalChildCode_04 = "0";

            loop2000B2.SBR_SubscriberInformation = new SBR_SubscriberInformation();
            loop2000B2.SBR_SubscriberInformation.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop2000B2.SBR_SubscriberInformation.IndividualRelationshipCode_02 = "18";
            loop2000B2.SBR_SubscriberInformation.ClaimFilingIndicatorCode_09 = "12";

            loop2000B2.All_NM1_3 = new All_NM1_3();
            loop2000B2.All_NM1_3.Loop_2010BA = new Loop_2010BA();
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName = new NM1_SubscriberName();
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberLastName_03 = "BLOGGS";
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberFirstName_04 = "FRED";
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000B2.All_NM1_3.Loop_2010BA.NM1_SubscriberName.SubscriberPrimaryIdentifier_09 = "9876543201";

            loop2000B2.All_NM1_3.Loop_2010BA.N3_SubscriberAddress = new N3_SubscriberAddress();
            loop2000B2.All_NM1_3.Loop_2010BA.N3_SubscriberAddress.SubscriberAddressLine_01 = "1 ANOTHER STR";

            loop2000B2.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode = new N4_SubscriberCity_State_ZIPCode();
            loop2000B2.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberCityName_01 = "CHICAGO";
            loop2000B2.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberStateCode_02 = "IL";
            loop2000B2.All_NM1_3.Loop_2010BA.N4_SubscriberCity_State_ZIPCode.SubscriberPostalZoneorZIPCode_03 = "606129998";

            loop2000B2.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation = new DMG_SubscriberDemographicInformation();
            loop2000B2.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000B2.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.SubscriberBirthDate_02 = "19700601";
            loop2000B2.All_NM1_3.Loop_2010BA.DMG_SubscriberDemographicInformation.SubscriberGenderCode_03 = "M";

            loop2000B2.All_NM1_3.Loop_2010BB = new Loop_2010BB();
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName = new NM1_PayerName();
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName.PayerName_03 = "PAYER";
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000B2.All_NM1_3.Loop_2010BB.NM1_PayerName.PayerIdentifier_09 = "12345";

            loop2000B2.All_NM1_3.Loop_2010BB.N3_PayerAddress = new N3_PayerAddress();
            loop2000B2.All_NM1_3.Loop_2010BB.N3_PayerAddress.PayerAddressLine_01 = "1 PAYER WAY";

            loop2000B2.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode = new N4_PayerCity_State_ZIPCode();
            loop2000B2.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerCityName_01 = "ST LOUIS";
            loop2000B2.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerStateorProvinceCode_02 = "MO";
            loop2000B2.All_NM1_3.Loop_2010BB.N4_PayerCity_State_ZIPCode.PayerPostalZoneorZIPCode_03 = "212441850";

            loop2000B2.All_NM1_3.Loop_2010BB.All_REF_4 = new All_REF_4();
            loop2000B2.All_NM1_3.Loop_2010BB.All_REF_4.REF_PayerSecondaryIdentification = new List<REF_PayerSecondaryIdentification>();
            var refPayer2 = new REF_PayerSecondaryIdentification();
            refPayer2.ReferenceIdentificationQualifier_01 = "2U";
            refPayer2.PayerSecondaryIdentifier_02 = "W1014";

            loop2000B2.All_NM1_3.Loop_2010BB.All_REF_4.REF_PayerSecondaryIdentification.Add(refPayer2);

            loop2000B2.Loop_2300 = new List<Loop_2300>();
            var loop23002 = new Loop_2300();
            loop23002.CLM_ClaimInformation = new CLM_ClaimInformation();
            loop23002.CLM_ClaimInformation.PatientControlNumber_01 = "1001A";
            loop23002.CLM_ClaimInformation.TotalClaimChargeAmount_02 = "140";
            loop23002.CLM_ClaimInformation.HealthCareServiceLocationInformation_05 = new C023_HealthCareServiceLocationInformation();
            loop23002.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.PlaceofServiceCode_01 = "19";
            loop23002.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.FacilityCodeQualifier_02 = "B";
            loop23002.CLM_ClaimInformation.HealthCareServiceLocationInformation_05.ClaimFrequencyCode_03 = "1";
            loop23002.CLM_ClaimInformation.ProviderorSupplierSignatureIndicator_06 = "Y";
            loop23002.CLM_ClaimInformation.AssignmentorPlanParticipationCode_07 = "A";
            loop23002.CLM_ClaimInformation.BenefitsAssignmentCertificationIndicator_08 = "Y";
            loop23002.CLM_ClaimInformation.ReleaseofInformationCode_09 = "Y";

            loop23002.All_HI = new All_HI();
            loop23002.All_HI.HI_HealthCareDiagnosisCode = new HI_HealthCareDiagnosisCode();
            loop23002.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation();
            loop23002.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.DiagnosisTypeCode_01 = "ABK";
            loop23002.All_HI.HI_HealthCareDiagnosisCode.HealthCareCodeInformation_01.DiagnosisCode_02 = "I10";

            loop23002.Loop_2400 = new List<Loop_2400>();
            var loop24002 = new Loop_2400();

            loop24002.LX_ServiceLineNumber = new LX_ServiceLineNumber();
            loop24002.LX_ServiceLineNumber.AssignedNumber_01 = "1";

            loop24002.SV1_ProfessionalService = new SV1_ProfessionalService();
            loop24002.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier();
            loop24002.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop24002.SV1_ProfessionalService.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "99213";
            loop24002.SV1_ProfessionalService.LineItemChargeAmount_02 = "140";
            loop24002.SV1_ProfessionalService.UnitorBasisforMeasurementCode_03 = "UN";
            loop24002.SV1_ProfessionalService.ServiceUnitCount_04 = "1";
            loop24002.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07 = new C004_CompositeDiagnosisCodePointer();
            loop24002.SV1_ProfessionalService.CompositeDiagnosisCodePointer_07.DiagnosisCodePointer_01 = "1";

            loop24002.All_DTP_2 = new All_DTP_2();
            loop24002.All_DTP_2.DTP_Date_ServiceDate = new DTP_Date_ServiceDate();
            loop24002.All_DTP_2.DTP_Date_ServiceDate.DateTimeQualifier_01 = "472";
            loop24002.All_DTP_2.DTP_Date_ServiceDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop24002.All_DTP_2.DTP_Date_ServiceDate.ServiceDate_03 = "20151124";

            loop23002.Loop_2400.Add(loop24002);
            loop2000B2.Loop_2300.Add(loop23002);
            loop2000A1.Loop_2000B.Add(loop2000B2);

            result.Loop_2000A.Add(loop2000A1);
            */
            return result;
        }

    }
}
