using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T277
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Response Transmission
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\ResponseTransmission.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V5010.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS277>();

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
        /// Write Response Transmission
        /// </summary>
        static void Write()
        {
            var transaction = BuildResponseTransmission("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Builds response transmission.
        /// Original from http://www.x12.org/examples/005010X212/claim-level-status/x212-277-claim-response/
        /// Claim 1
        /// Response: ABC Insurance assigned a payer claim control number of 05347006051 to Mr. Smith's claim. 
        /// The claim was pending waiting on additional information that had already been requested.
        /// Claim 2
        /// Response: ABC Insurance assigned a payer claim control number of 0529675341 to Mrs. Jones' claim. 
        /// The claim completed adjudication and is awaiting the payment cycle.
        /// Claim 3
        /// Response: ABC Insurance assigned a payer internal control number of 051681010827 to Joseph Mann's claim.
        /// The service was denied because the dependent was not eligible for benefits at the time of service.
        /// </summary>
        static TS277 BuildResponseTransmission(string controlNumber)
        {
            var result = new TS277();

            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "277";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X212";

            result.BHT_BeginningOfHierarchicalTransaction = new BHT_BeginningOfHierarchicalTransaction_4();
            result.BHT_BeginningOfHierarchicalTransaction.HierarchicalStructureCode_01 = "0010";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetPurposeCode_02 = "08";
            result.BHT_BeginningOfHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "277X212";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationDate_04 = "20050916";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationTime_05 = "0810";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionTypeCode_06 = "DG";

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_277>();

            //  Begin 2000A Loop
            var loop2000A = new Loop_2000A_277();

            loop2000A.HL_InformationSourceLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_InformationSourceLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_InformationSourceLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_InformationSourceLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100A Loop
            loop2000A.Loop2100A = new Loop_2100A_277();

            loop2000A.Loop2100A.NM1_PayerName = new NM1_OtherPayerName();
            loop2000A.Loop2100A.NM1_PayerName.EntityIdentifierCode_01 = "PR";
            loop2000A.Loop2100A.NM1_PayerName.EntityTypeQualifier_02 = "2";
            loop2000A.Loop2100A.NM1_PayerName.ResponseContactLastorOrganizationName_03 = "ABC INSURANCE";
            loop2000A.Loop2100A.NM1_PayerName.IdentificationCodeQualifier_08 = "PI";
            loop2000A.Loop2100A.NM1_PayerName.ResponseContactIdentifier_09 = "12345";

            //  End 2100A Loop

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_277>();

            //  Begin 2000B Loop
            var loop2000B = new Loop_2000B_277();

            loop2000B.HL_InformationReceiverLevel = new HL_InformationReceiverLevel_2();
            loop2000B.HL_InformationReceiverLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_InformationReceiverLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_InformationReceiverLevel.HierarchicalLevelCode_03 = "21";
            loop2000B.HL_InformationReceiverLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100B Loop
            loop2000B.Loop2100B = new Loop_2100B_277();

            loop2000B.Loop2100B.NM1_InformationReceiverName = new NM1_InformationReceiverName_3();
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityIdentifierCode_01 = "41";
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityTypeQualifier_02 = "2";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactLastorOrganizationName_03 = "XYZ SERVICE";
            loop2000B.Loop2100B.NM1_InformationReceiverName.IdentificationCodeQualifier_08 = "46";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactIdentifier_09 = "X67E";

            //  End 2100B Loop

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_277>();

            //  Begin 2000C Loop 1
            var loop2000C1 = new Loop_2000C_277();

            loop2000C1.HL_ServiceProviderLevel = new HL_BillingProviderOfServiceLevel();
            loop2000C1.HL_ServiceProviderLevel.HierarchicalIDNumber_01 = "3";
            loop2000C1.HL_ServiceProviderLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C1.HL_ServiceProviderLevel.HierarchicalLevelCode_03 = "19";
            loop2000C1.HL_ServiceProviderLevel.HierarchicalChildCode_04 = "1";

            //  Repeating 2100C Loops
            loop2000C1.Loop2100C = new List<Loop_2100C_277>();

            //  Begin 2100C Loop
            var loop2100C = new Loop_2100C_277();

            loop2100C.NM1_ProviderName = new NM1_ProviderName();
            loop2100C.NM1_ProviderName.EntityIdentifierCode_01 = "1P";
            loop2100C.NM1_ProviderName.EntityTypeQualifier_02 = "2";
            loop2100C.NM1_ProviderName.ResponseContactLastorOrganizationName_03 = "HOME HOSPITAL";
            loop2100C.NM1_ProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2100C.NM1_ProviderName.ResponseContactIdentifier_09 = "1666666661";

            //  End 2100C Loop
            loop2000C1.Loop2100C.Add(loop2100C);

            //  Repeating 2000D Loops
            loop2000C1.Loop2000D = new List<Loop_2000D_277>();

            //  Begin 2000D Loop 1
            var loop2000D1 = new Loop_2000D_277();

            loop2000D1.HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
            loop2000D1.HL_SubscriberLevel.HierarchicalIDNumber_01 = "4";
            loop2000D1.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "3";
            loop2000D1.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            loop2000D1.HL_SubscriberLevel.HierarchicalChildCode_04 = "0";

            //  Begin 2100D Loop
            loop2000D1.Loop2100D = new Loop_2100D_277();

            loop2000D1.Loop2100D.NM1_SubscriberName = new NM1_SubscriberName_2();
            loop2000D1.Loop2100D.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000D1.Loop2100D.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000D1.Loop2100D.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000D1.Loop2100D.NM1_SubscriberName.ResponseContactFirstName_04 = "FRED";
            loop2000D1.Loop2100D.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000D1.Loop2100D.NM1_SubscriberName.ResponseContactIdentifier_09 = "123456789A";

            //  End 2100D Loop

            //  Repeating 2200D Loops
            loop2000D1.Loop2200D = new List<Loop_2200D_277>();

            //  Begin 2200D Loop
            var loop2200D = new Loop_2200D_277();

            loop2200D.TRN_ClaimStatusTrackingNumber = new TRN_ClaimStatusTrackingNumber_2();
            loop2200D.TRN_ClaimStatusTrackingNumber.TraceTypeCode_01 = "2";
            loop2200D.TRN_ClaimStatusTrackingNumber.CurrentTransactionTraceNumber_02 = "ABCXYZ1";

            //  Repeating STC
            loop2200D.STC_ClaimLevelStatusInformation = new List<STC_ClaimLevelStatusInformation>();

            var stc1 = new STC_ClaimLevelStatusInformation();
            stc1.HealthCareClaimStatus_01 = new C043_HealthCareClaimStatus();
            stc1.HealthCareClaimStatus_01.HealthCareClaimStatusCategoryCode_01 = "P3";
            stc1.HealthCareClaimStatus_01.StatusCode_02 = "317";
            stc1.Date_02 = "20050913";
            stc1.TotalSubmittedChargesForUnitWork_04 = "8513.88";
            loop2200D.STC_ClaimLevelStatusInformation.Add(stc1);

            //  Occurrence of REF Segments in any order
            loop2200D.AllREF = new All_REF_277();

            loop2200D.AllREF.REF_PayerClaimControlNumber = new REF_PayerClaimControlNumber();
            loop2200D.AllREF.REF_PayerClaimControlNumber.ReferenceIdentificationQualifier_01 = "1K";
            loop2200D.AllREF.REF_PayerClaimControlNumber.MemberGrouporPolicyNumber_02 = "05347006051";

            loop2200D.AllREF.REF_InstitutionalBillTypeIdentification = new REF_InstitutionalBillTypeIdentification();
            loop2200D.AllREF.REF_InstitutionalBillTypeIdentification.ReferenceIdentificationQualifier_01 = "BLT";
            loop2200D.AllREF.REF_InstitutionalBillTypeIdentification.MemberGrouporPolicyNumber_02 = "111";

            loop2200D.AllREF.REF_PatientControlNumber = new REF_PatientControlNumber();
            loop2200D.AllREF.REF_PatientControlNumber.ReferenceIdentificationQualifier_01 = "EJ";
            loop2200D.AllREF.REF_PatientControlNumber.MemberGrouporPolicyNumber_02 = "SM123456";

            loop2200D.DTP_ClaimServiceDate = new DTP_ClaimLevelServiceDate();
            loop2200D.DTP_ClaimServiceDate.DateTimeQualifier_01 = "472";
            loop2200D.DTP_ClaimServiceDate.DateTimePeriodFormatQualifier_02 = "RD8";
            loop2200D.DTP_ClaimServiceDate.DateTimePeriod_03 = "20050831-20050906";

            //  End 2200D Loop
            loop2000D1.Loop2200D.Add(loop2200D);

            //  End 2000D Loop 1
            loop2000C1.Loop2000D.Add(loop2000D1);

            //  Begin 2000D Loop 2
            var loop2000D2 = new Loop_2000D_277();

            loop2000D2.HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
            loop2000D2.HL_SubscriberLevel.HierarchicalIDNumber_01 = "5";
            loop2000D2.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "3";
            loop2000D2.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            loop2000D2.HL_SubscriberLevel.HierarchicalChildCode_04 = "0";

            //  Begin 2100D Loop
            loop2000D2.Loop2100D = new Loop_2100D_277();

            loop2000D2.Loop2100D.NM1_SubscriberName = new NM1_SubscriberName_2();
            loop2000D2.Loop2100D.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000D2.Loop2100D.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000D2.Loop2100D.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "JONES";
            loop2000D2.Loop2100D.NM1_SubscriberName.ResponseContactFirstName_04 = "MARY";
            loop2000D2.Loop2100D.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000D2.Loop2100D.NM1_SubscriberName.ResponseContactIdentifier_09 = "234567890A";

            //  End 2100D Loop

            //  Repeating 2200D Loops
            loop2000D2.Loop2200D = new List<Loop_2200D_277>();

            //  Begin 2200D Loop
            var loop2200D2 = new Loop_2200D_277();

            loop2200D2.TRN_ClaimStatusTrackingNumber = new TRN_ClaimStatusTrackingNumber_2();
            loop2200D2.TRN_ClaimStatusTrackingNumber.TraceTypeCode_01 = "2";
            loop2200D2.TRN_ClaimStatusTrackingNumber.CurrentTransactionTraceNumber_02 = "ABCXYZ2";

            //  Repeating STC
            loop2200D2.STC_ClaimLevelStatusInformation = new List<STC_ClaimLevelStatusInformation>();

            var stc2 = new STC_ClaimLevelStatusInformation();
            stc2.HealthCareClaimStatus_01 = new C043_HealthCareClaimStatus();
            stc2.HealthCareClaimStatus_01.HealthCareClaimStatusCategoryCode_01 = "F0";
            stc2.HealthCareClaimStatus_01.StatusCode_02 = "3";
            stc2.Date_02 = "20050915";
            stc2.TotalSubmittedChargesForUnitWork_04 = "7599";
            stc2.MonetaryAmount_05 = "7599";
            loop2200D2.STC_ClaimLevelStatusInformation.Add(stc2);

            //  Occurrence of REF Segments in any order
            loop2200D2.AllREF = new All_REF_277();

            loop2200D2.AllREF.REF_PayerClaimControlNumber = new REF_PayerClaimControlNumber();
            loop2200D2.AllREF.REF_PayerClaimControlNumber.ReferenceIdentificationQualifier_01 = "1K";
            loop2200D2.AllREF.REF_PayerClaimControlNumber.MemberGrouporPolicyNumber_02 = "0529675341";

            loop2200D2.AllREF.REF_InstitutionalBillTypeIdentification = new REF_InstitutionalBillTypeIdentification();
            loop2200D2.AllREF.REF_InstitutionalBillTypeIdentification.ReferenceIdentificationQualifier_01 = "BLT";
            loop2200D2.AllREF.REF_InstitutionalBillTypeIdentification.MemberGrouporPolicyNumber_02 = "111";

            loop2200D2.AllREF.REF_PatientControlNumber = new REF_PatientControlNumber();
            loop2200D2.AllREF.REF_PatientControlNumber.ReferenceIdentificationQualifier_01 = "EJ";
            loop2200D2.AllREF.REF_PatientControlNumber.MemberGrouporPolicyNumber_02 = "JO234567";

            loop2200D2.DTP_ClaimServiceDate = new DTP_ClaimLevelServiceDate();
            loop2200D2.DTP_ClaimServiceDate.DateTimeQualifier_01 = "472";
            loop2200D2.DTP_ClaimServiceDate.DateTimePeriodFormatQualifier_02 = "RD8";
            loop2200D2.DTP_ClaimServiceDate.DateTimePeriod_03 = "20050731-20050809";

            //  End 2200D Loop
            loop2000D2.Loop2200D.Add(loop2200D2);

            //  End 2000D Loop 2
            loop2000C1.Loop2000D.Add(loop2000D2);

            //  End 2000C Loop 1
            loop2000B.Loop2000C.Add(loop2000C1);

            //  Begin 2000C Loop 2
            var loop2000C2 = new Loop_2000C_277();

            loop2000C2.HL_ServiceProviderLevel = new HL_BillingProviderOfServiceLevel();
            loop2000C2.HL_ServiceProviderLevel.HierarchicalIDNumber_01 = "6";
            loop2000C2.HL_ServiceProviderLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C2.HL_ServiceProviderLevel.HierarchicalLevelCode_03 = "19";
            loop2000C2.HL_ServiceProviderLevel.HierarchicalChildCode_04 = "1";

            //  Repeating 2100C Loops
            loop2000C2.Loop2100C = new List<Loop_2100C_277>();

            //  Begin 2100C Loop
            var loop2100C2 = new Loop_2100C_277();

            loop2100C2.NM1_ProviderName = new NM1_ProviderName();
            loop2100C2.NM1_ProviderName.EntityIdentifierCode_01 = "1P";
            loop2100C2.NM1_ProviderName.EntityTypeQualifier_02 = "2";
            loop2100C2.NM1_ProviderName.ResponseContactLastorOrganizationName_03 = "HOME HOSPITAL PHYSICIANS";
            loop2100C2.NM1_ProviderName.IdentificationCodeQualifier_08 = "XX";
            loop2100C2.NM1_ProviderName.ResponseContactIdentifier_09 = "1666666666";

            //  End 2100C Loop
            loop2000C2.Loop2100C.Add(loop2100C2);

            //  Repeating 2000D Loops
            loop2000C2.Loop2000D = new List<Loop_2000D_277>();

            //  Begin 2000D Loop 1
            var loop2000D3 = new Loop_2000D_277();

            loop2000D3.HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
            loop2000D3.HL_SubscriberLevel.HierarchicalIDNumber_01 = "7";
            loop2000D3.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "6";
            loop2000D3.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            loop2000D3.HL_SubscriberLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100D Loop
            loop2000D3.Loop2100D = new Loop_2100D_277();

            loop2000D3.Loop2100D.NM1_SubscriberName = new NM1_SubscriberName_2();
            loop2000D3.Loop2100D.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000D3.Loop2100D.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000D3.Loop2100D.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "MANN";
            loop2000D3.Loop2100D.NM1_SubscriberName.ResponseContactFirstName_04 = "JOHN";
            loop2000D3.Loop2100D.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000D3.Loop2100D.NM1_SubscriberName.ResponseContactIdentifier_09 = "345678901";

            //  End 2100D Loop   

            //  Repeating 2000E Loops
            loop2000D3.Loop2000E = new List<Loop_2000E_277>();

            //  Begin 2000E Loop
            var loop2000E = new Loop_2000E_277();

            loop2000E.HL_DependentLevel = new HL_DependentLevel_2();
            loop2000E.HL_DependentLevel.HierarchicalIDNumber_01 = "8";
            loop2000E.HL_DependentLevel.HierarchicalParentIDNumber_02 = "7";
            loop2000E.HL_DependentLevel.HierarchicalLevelCode_03 = "23";

            //  Begin 2100E Loop
            loop2000E.Loop2100E = new Loop_2100E_277();

            loop2000E.Loop2100E.NM1_DependentName = new NM1_DependentName_2();
            loop2000E.Loop2100E.NM1_DependentName.EntityIdentifierCode_01 = "QC";
            loop2000E.Loop2100E.NM1_DependentName.EntityTypeQualifier_02 = "1";
            loop2000E.Loop2100E.NM1_DependentName.ResponseContactLastorOrganizationName_03 = "MANN";
            loop2000E.Loop2100E.NM1_DependentName.ResponseContactFirstName_04 = "JOSEPH";

            //  End 2100E Loop

            //  Repeating 2200E Loops
            loop2000E.Loop2200E = new List<Loop_2200E_277>();

            //  Begin 2200E Loop
            var loop2200E = new Loop_2200E_277();

            loop2200E.TRN_ClaimStatusTrackingNumber = new TRN_ClaimStatusTrackingNumber_2();
            loop2200E.TRN_ClaimStatusTrackingNumber.TraceTypeCode_01 = "2";
            loop2200E.TRN_ClaimStatusTrackingNumber.CurrentTransactionTraceNumber_02 = "ABCXYC3";

            //  Repeating STC
            loop2200E.STC_ClaimLevelStatusInformation = new List<STC_ClaimLevelStatusInformation>();

            var stc3 = new STC_ClaimLevelStatusInformation();
            stc3.HealthCareClaimStatus_01 = new C043_HealthCareClaimStatus();
            stc3.HealthCareClaimStatus_01.HealthCareClaimStatusCategoryCode_01 = "F2";
            stc3.HealthCareClaimStatus_01.StatusCode_02 = "88";
            stc3.HealthCareClaimStatus_01.EntityIdentifierCode_03 = "QC";
            stc3.Date_02 = "20050612";
            stc3.TotalSubmittedChargesForUnitWork_04 = "150";
            stc3.MonetaryAmount_05 = "0";
            loop2200E.STC_ClaimLevelStatusInformation.Add(stc3);

            //  Occurrence of REF Segments in any order
            loop2200E.AllREF = new All_REF_277();

            loop2200E.AllREF.REF_PayerClaimControlNumber = new REF_PayerClaimControlNumber();
            loop2200E.AllREF.REF_PayerClaimControlNumber.ReferenceIdentificationQualifier_01 = "1K";
            loop2200E.AllREF.REF_PayerClaimControlNumber.MemberGrouporPolicyNumber_02 = "051681010827";

            loop2200E.AllREF.REF_PatientControlNumber = new REF_PatientControlNumber();
            loop2200E.AllREF.REF_PatientControlNumber.ReferenceIdentificationQualifier_01 = "EJ";
            loop2200E.AllREF.REF_PatientControlNumber.MemberGrouporPolicyNumber_02 = "MA345678";

            //  Repeating 2220E Loops
            loop2200E.Loop2220E = new List<Loop_2220E_277>();

            //  Begin 2220E Loop
            var loop2220E = new Loop_2220E_277();

            loop2220E.SVC_ServiceLineInformation = new SVC_ServiceLineInformation_2();
            loop2220E.SVC_ServiceLineInformation.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_6();
            loop2220E.SVC_ServiceLineInformation.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop2220E.SVC_ServiceLineInformation.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "99203";
            loop2220E.SVC_ServiceLineInformation.LineItemChargeAmount_02 = "150";
            loop2220E.SVC_ServiceLineInformation.MonetaryAmount_03 = "0";
            loop2220E.SVC_ServiceLineInformation.UnitsofServiceCount_07 = "1";

            //  Repeating STC
            loop2220E.STC_ServiceLineStatusInformation = new List<STC_ClaimLevelStatusInformation>();

            var stc = new STC_ClaimLevelStatusInformation();
            stc.HealthCareClaimStatus_01 = new C043_HealthCareClaimStatus();
            stc.HealthCareClaimStatus_01.HealthCareClaimStatusCategoryCode_01 = "F2";
            stc.HealthCareClaimStatus_01.StatusCode_02 = "88";
            stc.HealthCareClaimStatus_01.EntityIdentifierCode_03 = "QC";
            stc.Date_02 = "20050612";
            loop2220E.STC_ServiceLineStatusInformation.Add(stc);

            loop2220E.DTP_ServiceLineDate = new DTP_ClaimLevelServiceDate();
            loop2220E.DTP_ServiceLineDate.DateTimeQualifier_01 = "472";
            loop2220E.DTP_ServiceLineDate.DateTimePeriodFormatQualifier_02 = "D8";
            loop2220E.DTP_ServiceLineDate.DateTimePeriod_03 = "20050501";

            //  End 2220E Loop
            loop2200E.Loop2220E.Add(loop2220E);

            //  End 2200E Loop
            loop2000E.Loop2200E.Add(loop2200E);

            //  End 2000E Loop
            loop2000D3.Loop2000E.Add(loop2000E);

            //  End 2000D Loop 2
            loop2000C2.Loop2000D.Add(loop2000D3);

            //  End 2000C Loop 2
            loop2000B.Loop2000C.Add(loop2000C2);

            //  End 2000B Loop
            loop2000A.Loop2000B.Add(loop2000B);

            //  End 2000A Loop
            result.Loop2000A.Add(loop2000A);

            return result;
        }
    }
}

