using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T271
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Generic Response
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\GenericResponse.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V5010.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS271>();

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
        /// Write Generic Response
        /// </summary>
        static void Write()
        {
            var transaction = BuildGenericResponse("4321");

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
        /// Builds generic response.
        /// Original from http://www.x12.org/examples/005010X279/subscriber-who-is-also-the-patient/response-to-generic-request-by-clinic-for-patient-(subscriber)-eligibility/
        /// </summary>
        static TS271 BuildGenericResponse(string controlNumber)
        {
            var result = new TS271();

            //  Transaction Set ID Code = 271 (Eligibility, Coverage or Benefit Information)
            //  Transaction Set Control Number = 4321
            //  Implementation Convention Reference = 005010X279A1
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "271";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X279A1";

            //  Hierarchical Structure Code = 0022 (Information Source, Information Receiver, Subscriber, Dependent)
            //  Transaction Set Purpose Code = 11(Response) Identification
            //  Reference Identification = 10001234
            //  Date = 20060501(May 1, 2006)
            //  Time = 1:19 PM
            result.BHT_BeginningofHierarchicalTransaction = new BHT_BeginningofHierarchicalTransaction_2();
            result.BHT_BeginningofHierarchicalTransaction.HierarchicalStructureCode_01 = "0022";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetPurposeCode_02 = "11";
            result.BHT_BeginningofHierarchicalTransaction.SubmitterTransactionIdentifier_03 = "10001234";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationDate_04 = "20060501";
            result.BHT_BeginningofHierarchicalTransaction.TransactionSetCreationTime_05 = "1319";

            //  Repeating 2000A Loops
            result.Loop2000A = new List<Loop_2000A_271>();

            //  Begin 2000A Loop
            var loop2000A = new Loop_2000A_271();

            //  Hierarchical ID Number = 1
            //  Hierarchical Parent ID Number = *not used
            //  Hierarchical Level Code = 20(Information Source)
            //  Hierarchical Child Code = 1
            loop2000A.HL_InformationSourceLevel = new HL_BillingProviderHierarchicalLevel();
            loop2000A.HL_InformationSourceLevel.HierarchicalIDNumber_01 = "1";
            loop2000A.HL_InformationSourceLevel.HierarchicalLevelCode_03 = "20";
            loop2000A.HL_InformationSourceLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100A Loop
            loop2000A.Loop2100A = new Loop_2100A_271();

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
            loop2000A.Loop2000B = new List<Loop_2000B_271>();

            //  Begin 2000B Loop
            var loop2000B = new Loop_2000B_271();

            //  Hierarchical ID Number = 2
            //  Hierarchical Parent ID Number = 1
            //  Hierarchical Level Code = 21(Information Receiver)
            //  Hierarchical Child Code = 1
            loop2000B.HL_InformationReceiverLevel = new HL_InformationReceiverLevel();
            loop2000B.HL_InformationReceiverLevel.HierarchicalIDNumber_01 = "2";
            loop2000B.HL_InformationReceiverLevel.HierarchicalParentIDNumber_02 = "1";
            loop2000B.HL_InformationReceiverLevel.HierarchicalLevelCode_03 = "21";
            loop2000B.HL_InformationReceiverLevel.HierarchicalChildCode_04 = "1";

            //  Begin 2100B Loop
            loop2000B.Loop2100B = new Loop_2100B_271();

            //  Entity Identifier Code = 1P (Provider)
            //  Entity Type Qualifier = 2(Non - Person Entity)
            //  Last Name = Bone and Joint Clinic
            //  First Name = *not used
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = SV(Service Provider Number)
            //  Identification Code = 2000035
            loop2000B.Loop2100B.NM1_InformationReceiverName = new NM1_InformationReceiverName();
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityIdentifierCode_01 = "1P";
            loop2000B.Loop2100B.NM1_InformationReceiverName.EntityTypeQualifier_02 = "2";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactLastorOrganizationName_03 = "BONE AND JOINT CLINIC";
            loop2000B.Loop2100B.NM1_InformationReceiverName.IdentificationCodeQualifier_08 = "SV";
            loop2000B.Loop2100B.NM1_InformationReceiverName.ResponseContactIdentifier_09 = "2000035";

            //  End 2100B Loop

            //  Repeating 2000C Loops
            loop2000B.Loop2000C = new List<Loop_2000C_271>();

            //  Begin 2000C Loop 1
            var loop2000C1 = new Loop_2000C_271();

            //  Hierarchical ID Number = 3
            //  Hierarchical Parent ID Number = 2
            //  Hierarchical Level Code = 22(Subscriber)
            //  Hierarchical Child Code = 0
            loop2000C1.HL_SubscriberLevel = new HL_SubscriberHierarchicalLevel();
            loop2000C1.HL_SubscriberLevel.HierarchicalIDNumber_01 = "3";
            loop2000C1.HL_SubscriberLevel.HierarchicalParentIDNumber_02 = "2";
            loop2000C1.HL_SubscriberLevel.HierarchicalLevelCode_03 = "22";
            loop2000C1.HL_SubscriberLevel.HierarchicalChildCode_04 = "0";

            //  Repeating TRN
            loop2000C1.TRN_SubscriberTraceNumber = new List<TRN_DependentTraceNumber>();

            //  Trace Type Code = 2 (Referenced Transaction Trace Number)
            //  Reference Identification = 93175 - 012547
            //  Originating Company Identifier = 9877281234
            //  Reference Identification = *not used
            var trn = new TRN_DependentTraceNumber();
            trn.TraceTypeCode_01 = "2";
            trn.CurrentTransactionTraceNumber_02 = "93175-012547";
            trn.OriginatingCompanyIdentifier_03 = "9877281234";
            loop2000C1.TRN_SubscriberTraceNumber.Add(trn);

            //  Begin 2100C Loop
            loop2000C1.Loop2100C = new Loop_2100C_271();

            //  Entity Identifier Code = IL (Insured or Subscriber)
            //  Entity Type Qualifier = 1(Person)
            //  Last Name = Smith
            //  First Name = John
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = MI(Member Identification)
            //  Identification Code = 123456789
            loop2000C1.Loop2100C.NM1_SubscriberName = new NM1_InsuredName();
            loop2000C1.Loop2100C.NM1_SubscriberName.EntityIdentifierCode_01 = "IL";
            loop2000C1.Loop2100C.NM1_SubscriberName.EntityTypeQualifier_02 = "1";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactLastorOrganizationName_03 = "SMITH";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactFirstName_04 = "JOHN";
            loop2000C1.Loop2100C.NM1_SubscriberName.IdentificationCodeQualifier_08 = "MI";
            loop2000C1.Loop2100C.NM1_SubscriberName.ResponseContactIdentifier_09 = "123456789";

            //  Address Information = 15197 BROADWAY AVENUE
            //  Address Information = APT 215
            loop2000C1.Loop2100C.N3_SubscriberAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000C1.Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_01 = "15197 BROADWAY AVENUE";
            loop2000C1.Loop2100C.N3_SubscriberAddress.ResponseContactAddressLine_02 = "APT 215";

            //  City = KANSAS CITY
            //  State or Prov Code = MO
            //  Postal Code = 64108
            loop2000C1.Loop2100C.N4_SubscriberCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            loop2000C1.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "KANSAS CITY";
            loop2000C1.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "MO";
            loop2000C1.Loop2100C.N4_SubscriberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "64108";

            //  Date Time Period Format = D8 (Date Expressed in Format CCYYMMDD)
            //  Date Time Period = 19630519
            //  Gender Code = M(Male)
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation = new DMG_DependentDemographicInformation();
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation.DependentBirthDate_02 = "19630519";
            loop2000C1.Loop2100C.DMG_SubscriberDemographicInformation.DependentGenderCode_03 = "M";

            //  Repeating DTP
            loop2000C1.Loop2100C.DTP_SubscriberDate = new List<DTP_DependentDate_2>();

            //  Date/Time Qualifier = 346 (Plan Begin)
            //  Date Time Period Format Qualifier D8(Dates Expressed in Format CCYYMMDD)
            //  Date Time Period = 20060101(January 1, 2006)
            var dtp = new DTP_DependentDate_2();
            dtp.DateTimeQualifier_01 = "346";
            dtp.DateTimePeriodFormatQualifier_02 = "D8";
            dtp.AccidentDate_03 = "20060101";
            loop2000C1.Loop2100C.DTP_SubscriberDate.Add(dtp);

            //  Repeating 2110C Loops
            loop2000C1.Loop2100C.Loop2110C = new List<Loop_2110C_271>();

            //  Begin 2110C Loop 1
            var loop2110C1 = new Loop_2110C_271();

            //  Eligibility or Benefit Information Code = 1 (Active Coverage)
            //  Coverage Level Code = *not used
            //  Service Type Code = 30(Health Benefit Plan Coverage)
            //  Insurance Type Code = *not used
            //  Plan Coverage Description = Gold 123 Plan
            loop2110C1.EB_SubscriberEligibilityorBenefitInformation = new EB_SubscriberEligibilityorBenefitInformation();
            loop2110C1.EB_SubscriberEligibilityorBenefitInformation.EligibilityorBenefitInformation_01 = "1";
            loop2110C1.EB_SubscriberEligibilityorBenefitInformation.ServiceTypeCode_03 = new List<string> { "30" };
            loop2110C1.EB_SubscriberEligibilityorBenefitInformation.PlanCoverageDescription_05 = "GOLD 123 PLAN";

            //  End 2110C Loop 1
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C1);

            //  Begin 2110C Loop 2
            var loop2110C2 = new Loop_2110C_271();

            //  Eligibility or Benefit Information Code = L (Primary Care Provider)
            loop2110C2.EB_SubscriberEligibilityorBenefitInformation = new EB_SubscriberEligibilityorBenefitInformation();
            loop2110C2.EB_SubscriberEligibilityorBenefitInformation.EligibilityorBenefitInformation_01 = "L";

            //  End 2110C Loop 2
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C2);

            //  Begin 2110C Loop 3
            var loop2110C3 = new Loop_2110C_271();

            //  Eligibility or Benefit Information Code = 1 (Active Coverage)
            //  Coverage Level Code = *not used
            //  Service Type Code = 1(Medical Care)
            //  Service Type Code = 33(Chiropractic)
            //  Service Type Code = 35(Dental Care)
            //  Service Type Code = 47(Hospital)
            //  Service Type Code = 86(Emergency Services)
            //  Service Type Code = 88(Pharmacy)
            //  Service Type Code = 98(Professional(Physician) Visit - Office)
            //  Service Type Code = AL(Vision(Optometry))
            //  Service Type Code = MH(Mental Health)
            //  Service Type Code = UC(Urgent Care)
            loop2110C3.EB_SubscriberEligibilityorBenefitInformation = new EB_SubscriberEligibilityorBenefitInformation();
            loop2110C3.EB_SubscriberEligibilityorBenefitInformation.EligibilityorBenefitInformation_01 = "1";
            loop2110C3.EB_SubscriberEligibilityorBenefitInformation.ServiceTypeCode_03 = new List<string> { "1", "33", "35", "47", "86", "88", "98", "AL", "MH", "UC" };

            //  End 2110C Loop 3
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C3);

            //  Begin 2110C Loop 4
            var loop2110C4 = new Loop_2110C_271();

            //  Eligibility or Benefit Information Code = B (Co-Payment)
            //  Coverage Level Code = *not used
            //  Service Type Code = 1(Medical Care)
            //  Service Type Code = 33(Chiropractic)
            //  Service Type Code = 35(Dental Care)
            //  Service Type Code = 47(Hospital)
            //  Service Type Code = 86(Emergency Services)
            //  Service Type Code = 88(Pharmacy)
            //  Service Type Code = 98(Professional(Physician) Visit - Office)
            //  Service Type Code = AL(Vision(Optometry))
            //  Service Type Code = MH(Mental Health)
            //  Service Type Code = UC(Urgent Care)
            //  Insurance Type Code = HM (Health Management Organization (HMO))
            //  Plan Coverage Description = GOLD 123 PLAN
            //  Time Period Qualifier = 27(Visit)
            //  Monetary Value = 10(Dollar)
            //  Percent = *not used
            //  Quantity Qualifier = *not used
            //  Quantity = *not used
            //  Yes / No Condition Or Response Code(Certification/ Authorization Indicator) = *not used
            //  Yes / No Condition Or Response Code(In Plan Network Indicator) = Y(Yes – In Network)
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation = new EB_SubscriberEligibilityorBenefitInformation();
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.EligibilityorBenefitInformation_01 = "B";
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.ServiceTypeCode_03 = new List<string> { "1", "33", "35", "47", "86", "88", "98", "AL", "MH", "UC" };
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.InsuranceTypeCode_04 = "HM";
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.PlanCoverageDescription_05 = "GOLD 123 PLAN";
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.TimePeriodQualifier_06 = "27";
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.BenefitAmount_07 = "10";
            loop2110C4.EB_SubscriberEligibilityorBenefitInformation.InPlanNetworkIndicator_12 = "Y";

            //  End 2110C Loop 4
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C4);

            //  Begin 2110C Loop 5
            var loop2110C5 = new Loop_2110C_271();

            //  Eligibility or Benefit Information Code = B (Co-Payment)
            //  Coverage Level Code = *not used
            //  Service Type Code = 1(Medical Care)
            //  Service Type Code = 33(Chiropractic)
            //  Service Type Code = 35(Dental Care)
            //  Service Type Code = 47(Hospital)
            //  Service Type Code = 86(Emergency Services)
            //  Service Type Code = 88(Pharmacy)
            //  Service Type Code = 98(Professional(Physician) Visit - Office)
            //  Service Type Code = AL(Vision(Optometry))
            //  Service Type Code = MH(Mental Health)
            //  Service Type Code = UC(Urgent Care)
            //  Insurance Type Code = HM (Health Management Organization (HMO))
            //  Plan Coverage Description = GOLD 123 PLAN
            //  Time Period Qualifier = 27(Visit)
            //  Monetary Value = 30(Dollar)
            //  Percent = *not used
            //  Quantity Qualifier = *not used
            //  Quantity = *not used
            //  Yes/No Condition Or Response Code (Certification/Authorization Indicator) = * not used
            //  Yes / No Condition Or Response Code(In Plan Network Indicator) = N(No – Out of Network)
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation = new EB_SubscriberEligibilityorBenefitInformation();
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.EligibilityorBenefitInformation_01 = "B";
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.ServiceTypeCode_03 = new List<string> { "1", "33", "35", "47", "86", "88", "98", "AL", "MH", "UC" };
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.InsuranceTypeCode_04 = "HM";
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.PlanCoverageDescription_05 = "GOLD 123 PLAN";
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.TimePeriodQualifier_06 = "27";
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.BenefitAmount_07 = "30";
            loop2110C5.EB_SubscriberEligibilityorBenefitInformation.InPlanNetworkIndicator_12 = "N";

            //  Begin LS Loop
            loop2110C5.LoopLS = new Loop_LS_271_2();

            //  Loop Identifier Code = 2120
            loop2110C5.LoopLS.LS_Header = new LS_AdditionalReportingCategories();
            loop2110C5.LoopLS.LS_Header.LoopIdentifierCode_01 = "2120";

            //  Repeating 2120C Loops
            loop2110C5.LoopLS.Loop2120C = new List<Loop_2120C_271>();

            //  Begin 2110C Loop
            var loop2120C = new Loop_2120C_271();

            //  Entity Identifier Code = P3 (Primary Care Provider)
            //  Entity Type Qualifier = 1(Person)
            //  Last Name = Jones
            //  First Name = Marcus
            //  Middle Name = *not used
            //  Name Prefix = *not used
            //  Name Suffix = *not used
            //  Identification Code Qualifier = SV Service Provider Number
            //  Identification Code = 0202034
            loop2120C.NM1_SubscriberBenefitRelatedEntityName = new NM1_DependentBenefitRelatedEntityName();
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.EntityIdentifierCode_01 = "P3";
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.EntityTypeQualifier_02 = "1";
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.ResponseContactLastorOrganizationName_03 = "JONES";
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.ResponseContactFirstName_04 = "MARCUS";
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.IdentificationCodeQualifier_08 = "SV";
            loop2120C.NM1_SubscriberBenefitRelatedEntityName.ResponseContactIdentifier_09 = "0202034";

            //  End 2110C Loop
            loop2110C5.LoopLS.Loop2120C.Add(loop2120C);

            //  Loop Identifier Code = 2120
            loop2110C5.LoopLS.LE_Trailer = new LE_AdditionalReportingCategoriesTermination();
            loop2110C5.LoopLS.LE_Trailer.LoopIdentifierCode_01 = "2120";

            //  End LS Loop

            //  End 2110C Loop 5
            loop2000C1.Loop2100C.Loop2110C.Add(loop2110C5);

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

