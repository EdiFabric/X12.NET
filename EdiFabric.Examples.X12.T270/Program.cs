using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T270
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(TrialLicense.SerialKey);
            Read();
            Write();
        }

        /// <summary>
        /// Read Generic Request
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\GenericRequest.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS270>();

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
        /// Write Generic Request
        /// </summary>
        static void Write()
        {
            var transaction = BuildGenericRequest("1234");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X279A1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Builds generic request.
        /// Original from http://www.x12.org/examples/005010X279/subscriber-who-is-also-the-patient/generic-request-by-clinic-for-patient-(subscriber)-eligibility/
        /// </summary>
        static TS270 BuildGenericRequest(string controlNumber)
        {
            var result = new TS270();

            //  Transaction Set ID Code = 270 (Eligibility, Coverage or Benefit Inquiry)
            //  Transaction Set Control Number = 1234
            //  Implementation Convention Reference = 005010X279A1
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "270";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X279A1";

            //  Hierarchical Structure Code = 0022 (Information Source, Information Receiver, Subscriber, Dependent)
            //  Transaction Set Purpose Code = 13(Request) Identification
            //  Reference Identification = 10001234
            //  Date = 20060501(May 1, 2006)
            //  Time = 1:19 PM
            result.BHT_BeginningOfHierarchicalTransaction = new BHT_BeginningOfHierarchicalTransaction();
            result.BHT_BeginningOfHierarchicalTransaction.HierarchicalStructureCode_01 = "0022";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetPurposeCode_02 = "13";
            result.BHT_BeginningOfHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "10001234";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationDate_04 = "20060501";
            result.BHT_BeginningOfHierarchicalTransaction.TransactionSetCreationTime_05 = "1319";

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_270>();

            //  Begin 2000A Loop
            var loop2000A = new Loop_2000A_270();

            //  Hierarchical ID Number = 1
            //  Hierarchical Parent ID Number = *not used
            //  Hierarchical Level Code = 20(Information Source)
            //  Hierarchical Child Code = 1
            loop2000A.HL_InformationSourceLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_InformationSourceLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_InformationSourceLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_InformationSourceLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100A Loop
            loop2000A.Loop2100A = new Loop_2100A_270();

            //  Entity Identifier Code = PR (Payer)
            //  Entity Type Qualifier = 2(Non - person)
            //  Last Name = ABC Company
            //  First Name = *not used
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = PI(Payer Identification)
            //  Identification Code = 842610001
            loop2000A.Loop2100A.NM1_InformationSourceName = new NM1_InformationSourceName();
            loop2000A.Loop2100A.NM1_InformationSourceName.EntityIdentifierCode_01 = "PR";
            loop2000A.Loop2100A.NM1_InformationSourceName.EntityTypeQualifier_02 = "2";
            loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactLastorOrganizationName_03 = "ABC COMPANY";
            loop2000A.Loop2100A.NM1_InformationSourceName.IdentificationCodeQualifier_08 = "PI";
            loop2000A.Loop2100A.NM1_InformationSourceName.ResponseContactIdentifier_09 = "842610001";

            //  End 2100A Loop

            //  Repeating 2000B Loops
            loop2000A.Loop2000B = new List<Loop_2000B_270>();

            //  Begin 2000B Loop
            var loop2000B = new Loop_2000B_270();

            //  Hierarchical ID Number = 2
            //  Hierarchical Parent ID Number = 1
            //  Hierarchical Level Code = 21
            //  Hierarchical Child Code = 1
            loop2000B.HL_InformationReceiverLevel = new HL_InformationReceiverLevel();
            loop2000B.HL_InformationReceiverLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_InformationReceiverLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_InformationReceiverLevel.HierarchicalLevelCode_03 = "21";
            loop2000B.HL_InformationReceiverLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100B Loop
            loop2000B.Loop2100B = new Loop_2100B_270();

            //  Entity Identifier Code = 1P (Provider)
            //  Entity Type Qualifier = 2(Non - person)
            //  Last Name = Bone and Joint Clinic
            //  First Name = *not used
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = SV Service Provider Number
            //  Identification Code = 2000035
            loop2000B.Loop2100B.NM1_InformationReceiverName = new NM1_InformationReceiverName();
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityIdentifierCode_01 = "1P";
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityTypeQualifier_02 = "2";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactLastorOrganizationName_03 = "BONE AND JOINT CLINIC";
            loop2000B.Loop2100B.NM1_InformationReceiverName.IdentificationCodeQualifier_08 = "SV";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactIdentifier_09 = "2000035";

            //  End 2100B Loop

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_270>();

            //  Begin 2000C Loop 1
            var loop2000C1 = new Loop_2000C_270();

            //  Hierarchical ID Number = 3
            //  Hierarchical Parent ID Number = 2
            //  Hierarchical Level Code = 22
            //  Hierarchical Child Code = 0
            loop2000C1.HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
            loop2000C1.HL_SubscriberLevel.HierarchicalIDNumber_01 = "3";
            loop2000C1.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C1.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            loop2000C1.HL_SubscriberLevel.HierarchicalChildCode_04 = "0";

            //  Repeating TRN
            loop2000C1.TRN_SubscriberTraceNumber = new List<TRN_DependentTraceNumber>();

            //  Trace Type Code = 1 (Current Transaction Trace Number)
            //  Reference Identification = 93175 - 012547
            //  Originating Company Identifier = 9877281234
            //  Reference Identification = *not used
            var trn = new TRN_DependentTraceNumber();
            trn.TraceTypeCode_01 = "1";
            trn.CurrentTransactionTraceNumber_02 = "93175-012547";
            trn.OriginatingCompanyIdentifier_03 = "9877281234";
            loop2000C1.TRN_SubscriberTraceNumber.Add(trn);

            //  Begin 2100C Loop
            loop2000C1.Loop2100C = new Loop_2100C_270();

            //  Entity Identifier Code = IL (Insured or Subscriber)
            //  Entity Type Qualifier = 1(Person)
            //  Last Name = Smith
            //  First Name = Robert
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = MI(Member Identification Number)
            //  Identification Code = 11122333301
            loop2000C1.Loop2100C.NM1_SubscriberName = new NM1_SubscriberName();
            loop2000C1.Loop2100C.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000C1.Loop2100C.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactFirstName_04 = "ROBERT";
            loop2000C1.Loop2100C.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactIdentifier_09 = "11122333301";

            //  Date Time Period Format = D8 (Date Expressed in Format CCYYMMDD)
            //  Date Time Period = 19430519
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation = new DMG_DependentDemographicInformation();
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation.DependentBirthDate_02 = "19430519";

            //  Repeating DTP
            loop2000C1.Loop2100C.DTP_SubscriberDate = new List<DTP_SubscriberOrDependentDate>();

            //  Date/Time Qualifier = 291 (Plan)
            //  Date Time Period Format Qualifier D8(Dates Expressed in Format CCYYMMDD)
            //  Date Time Period = 20060501(May 1, 2006)
            var dtp = new DTP_SubscriberOrDependentDate();
            dtp.DateTimeQualifier_01 = "291";
            dtp.DateTimePeriodFormatQualifier_02 = "D8";
            dtp.DateTimePeriod_03 = "20060501";
            loop2000C1.Loop2100C.DTP_SubscriberDate.Add(dtp);

            //  Repeating 2110C Loops
            loop2000C1.Loop2100C.Loop2110C = new List<Loop_2110C_270>();

            //  Begin 2110C Loop  
            var loop2110C = new Loop_2110C_270();

            //  Service Type Code = 30 (Health Benefit Plan Coverage
            loop2110C.EQ_SubscriberEligibilityorBenefitInquiry = new EQ_SubscriberEligibilityorBenefitInquiry();
            loop2110C.EQ_SubscriberEligibilityorBenefitInquiry.ServiceTypeCode_01 = new List<string> { "30" };

            //  End 2110C Loop  
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C);

            //  End 2100C Loop            

            //  End 2000C Loop 1
            loop2000B.Loop2000C.Add(loop2000C1);            

            //  End 2000B Loop
            loop2000A.Loop2000B.Add(loop2000B);

            //  End 2000A Loop
            result.Loop2000A.Add(loop2000A);

            return result;
        }
    }
}

