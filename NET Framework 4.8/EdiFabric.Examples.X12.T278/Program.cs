using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T278
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
        /// Read Services Review
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\Hipaa\ServicesReview.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS278>();

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
        /// Write Services Review
        /// </summary>
        static void Write()
        {
            var transaction = BuildServicesReview("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X217"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Builds services review.
        /// Original from http://www.x12.org/examples/005010X217/referral/X217-referral-request-for-review/
        /// </summary>
        static TS278 BuildServicesReview(string controlNumber)
        {
            var result = new TS278();

            //  Begin transaction set 278, control #0001, and implementation convention reference is 005010X217.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "278";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X217";

            //  Begin Loop BHT
            result.LoopBHT = new Loop_BHT_278();

            //  This transaction is a request using hierarchical structure 0007 (information source, information receiver, subscriber, dependent, event, services). 
            //  The originating system has assigned the Submitter Transaction Identifier “A12345" along with the transaction set creation date and time.
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction = new BHT_BeginningOfHierarchicalTransaction_6();
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction.HierarchicalStructureCode_01 = "0007";
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction.TransactionSetPurposeCode_02 = "13";
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "A12345";
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationDate_04 = "20050502";
            result.LoopBHT.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationTime_05 = "1101";

            //  Begin 2000A Loop hierarchical level identifies the Insurance Company.
            result.LoopBHT.Loop2000A = new Loop_2000A_278();

            //  HL count is 1. There is no higher, or parent, HL. This HL code is 20, identifying the information source or the insurance company. 
            //  This HL has subordinate levels, or children.
            result.LoopBHT.Loop2000A.HL_UtilizationManagementOrganization_UMO_Level = new HL_UtilizationManagementOrganization();
            result.LoopBHT.Loop2000A.HL_UtilizationManagementOrganization_UMO_Level.HierarchicalIDNumber_01 = "1";
            result.LoopBHT.Loop2000A.HL_UtilizationManagementOrganization_UMO_Level.HierarchicalLevelCode_03 = "20";
            result.LoopBHT.Loop2000A.HL_UtilizationManagementOrganization_UMO_Level.HierarchicalChildCode_04 = "1";

            //  Begin 2010A Loop 
            result.LoopBHT.Loop2000A.Loop2010A = new Loop_2010A_278();

            //  The request for a referral is being made to Maryland Capital Insurance Company. Their electronic transmitter identification number is 789312.
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name = new NM1_UtilizationManagementOrganization();
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name.EntityIdentifierCode_01 = "X3";
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name.EntityTypeQualifier_02 = "2";
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name.ResponseContactLastorOrganizationName_03 = "MARYLAND CAPITAL INSURANCE COMPANY";
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name.IdentificationCodeQualifier_08 = "46";
            result.LoopBHT.Loop2000A.Loop2010A.NM1_UtilizationManagementOrganization_UMO_Name.ResponseContactIdentifier_09 = "789312";

            //  End 2010A Loop

            //  Begin 2000B Loop hierarchical level identifies the submitting provider.
            result.LoopBHT.Loop2000A.Loop2000B = new Loop_2000B_278();

            //  HL count is 2. This HL is subordinate to HL*1, the parent HL. This HL code is 21, identifying the information receiver or the referring provider. 
            //  This HL has subordinate levels, or children.
            result.LoopBHT.Loop2000A.Loop2000B.HL_RequesterLevel = new HL_RequesterLevel();
            result.LoopBHT.Loop2000A.Loop2000B.HL_RequesterLevel.HierarchicalIDNumber_01 = "2";
            result.LoopBHT.Loop2000A.Loop2000B.HL_RequesterLevel.HierarchicalParentIDNumber_02 = "1";
            result.LoopBHT.Loop2000A.Loop2000B.HL_RequesterLevel.HierarchicalLevelCode_03 = "21";
            result.LoopBHT.Loop2000A.Loop2000B.HL_RequesterLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2010B Loop 
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B = new Loop_2010B_278();

            //  The request is being made by James Gardener whose Electronic Transmitter Identification Number is 8189991234.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName = new NM1_RequesterName();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.EntityIdentifierCode_01 = "1P";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.EntityTypeQualifier_02 = "1";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.ResponseContactLastorOrganizationName_03 = "GARDENER";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.ResponseContactFirstName_04 = "JAMES";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.IdentificationCodeQualifier_08 = "46";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2010B.NM1_RequesterName.ResponseContactIdentifier_09 = "8189991234";

            //  End 2010B Loop    

            //  Begin 2000C Loop hierarchical level identifies the subscriber, who in this case is also the patient.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C = new Loop_2000C_278();

            //  HL count is 3. This HL is subordinate to HL*2, the parent HL. This HL code is 22, identifying the subscriber. This HL has subordinate levels, or children.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.HL_SubscriberLevel = new HL_SubscriberLevel();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.HL_SubscriberLevel.HierarchicalIDNumber_01 = "3";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "2";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.HL_SubscriberLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2010C 
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C = new Loop_2010C_278();

            //  The patient’s name is Joe Smith; his Member Identification Number is 12345678901.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName = new NM1_SubscriberName_3();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.ResponseContactFirstName_04 = "JOE";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2010C.NM1_SubscriberName.ResponseContactIdentifier_09 = "12345678901";

            //  End 2010C Loop

            //  Begin 2000E Loop hierarchical level identifies the patient event.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E = new Loop_2000E_278();

            //  HL count is 4. This HL is subordinate to HL*3, the parent HL. This HL code is EV, identifying the patient event. 
            //  This HL has no subordinate levels, or children.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HL_PatientEventLevel = new HL_PatientEventLevel();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HL_PatientEventLevel.HierarchicalIDNumber_01 = "4";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HL_PatientEventLevel.HierarchicalParentIDNumber_02 = "3";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HL_PatientEventLevel.HierarchicalLevelCode_03 = "EV";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HL_PatientEventLevel.HierarchicalChildCode_04 = "0";

            //  Repeating TRN
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.TRN_PatientEventTrackingNumber = new List<TRN_PatientEventTrackingNumber>();

            //  The provider assigned the trace number 111099 to this service request. 
            //  The requester has included the user-assigned identifier of 012345678 to this trace number.
            var trn = new TRN_PatientEventTrackingNumber();
            trn.TraceTypeCode_01 = "1";
            trn.CurrentTransactionTraceNumber_02 = "111099";
            trn.OriginatingCompanyIdentifier_03 = "9012345678";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.TRN_PatientEventTrackingNumber.Add(trn);

            //  Dr. Gardener is requesting an initial consultation for the patient.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation = new UM_HealthCareServicesReviewInformation_3();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.RequestCategoryCode_01 = "SC";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.CertificationTypeCode_02 = "I";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.ServiceTypeCode_03 = "3";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.ValuesEntered_04 = new C023_HealthCareServiceLocationInformation_4();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.ValuesEntered_04.FacilityTypeCode_01 = "11";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.ValuesEntered_04.FacilityCodeQualifier_02 = "B";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.UM_HealthCareServicesReviewInformation.ReleaseofInformationCode_09 = "Y";

            //  The patient has been diagnosed with acute myocardial infarction; unspecified site.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis = new HI_PatientDiagnosis();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis.HealthCareCodeInformation_01 = new C022_HealthCareCodeInformation_24();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis.HealthCareCodeInformation_01.CodeListQualifierCode_01 = "BF";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis.HealthCareCodeInformation_01.IndustryCode_02 = "41090";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis.HealthCareCodeInformation_01.DateTimePeriodFormatQualifier_03 = "D8";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HI_PatientDiagnosis.HealthCareCodeInformation_01.DateTimePeriod_04 = "20050430";

            //  Dr. Gardener is requesting a single visit.
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HSD_HealthCareServicesDelivery = new HSD_HealthCareServicesDelivery_2();
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HSD_HealthCareServicesDelivery.QuantityQualifier_01 = "VS";
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.HSD_HealthCareServicesDelivery.BenefitQuantity_02 = "1";

            //  Occurrence of NM1 Loops in any order
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.AllNM1 = new All_NM1_278_2();

            //  Repeating 2010EA Loops
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.AllNM1.Loop2010EA = new List<Loop_2010EA_278>();

            //  Begin 2010EA Loop
            var loop2010Ea = new Loop_2010EA_278();

            //  The patient event provider is identified as Susan Watson. Her Social Security Number is 987654321.
            loop2010Ea.NM1_PatientEventProviderName = new NM1_PatientEventProviderName();
            loop2010Ea.NM1_PatientEventProviderName.EntityIdentifierCode_01 = "SJ";
            loop2010Ea.NM1_PatientEventProviderName.EntityTypeQualifier_02 = "1";
            loop2010Ea.NM1_PatientEventProviderName.ResponseContactLastorOrganizationName_03 = "WATSON";
            loop2010Ea.NM1_PatientEventProviderName.ResponseContactFirstName_04 = "SUSAN";
            loop2010Ea.NM1_PatientEventProviderName.IdentificationCodeQualifier_08 = "34";
            loop2010Ea.NM1_PatientEventProviderName.ResponseContactIdentifier_09 = "987654321";

            //  Dr. Watson can be contacted by telephone at (402)999-3456.
            loop2010Ea.PER_PatientEventProviderContactInformation = new PER_PatientEventProviderContactInformation();
            loop2010Ea.PER_PatientEventProviderContactInformation.ContactFunctionCode_01 = "IC";
            loop2010Ea.PER_PatientEventProviderContactInformation.CommunicationNumberQualifier_03 = "TE";
            loop2010Ea.PER_PatientEventProviderContactInformation.ResponseContactCommunicationNumber_04 = "4029993456";

            //  End 2010EA Loop
            result.LoopBHT.Loop2000A.Loop2000B.Loop2000C.Loop2000E.AllNM1.Loop2010EA.Add(loop2010Ea);

            //  End 2000E Loop

            //  End 2000C Loop

            //  End 2000B Loop

            //  End 2000A Loop

            //  End Loop BHT

            return result;
        }
    }
}

