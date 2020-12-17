using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T834
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Benefit Enrollment
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\BenefitEnrollment.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa", new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS834>();

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
        /// Write Benefit Enrollment
        /// </summary>
        static void Write()
        {
            var transaction = BuildBenefitEnrollment("12345");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, new X12WriterSettings { SerialNumber = TrialLicense.SerialNumber }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X220A1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build benefit enrollment.
        /// Original from http://www.x12.org/examples/005010X220/enroll-employee-in-multiple-health-care-insurance-products/
        /// </summary>
        static TS834 BuildBenefitEnrollment(string controlNumber)
        {
            var result = new TS834();

            //  Used to indicate the start of a transaction set and to specify a transaction set control number.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "834";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  This is an original transaction uniquely identified by the sender with reference #12456. The transaction was created on 5/20/1998 at 12:00 Noon.
            result.BGN_BeginningSegment = new BGN_BeginningSegment();
            result.BGN_BeginningSegment.TransactionSetPurposeCode_01 = "00";
            result.BGN_BeginningSegment.TransactionSetReferenceNumber_02 = "12456";
            result.BGN_BeginningSegment.TransactionSetCreationDate_03 = "19980520";
            result.BGN_BeginningSegment.TransactionSetCreationTime_04 = "1200";
            result.BGN_BeginningSegment.ActionCode_08 = "2";

            //  Occurrence of N1 Loops in any order
            result.AllN1 = new All_N1_834();

            //  Begin 1000A Loop
            result.AllN1.Loop1000A = new Loop_1000A_834();

            //  Specifies the sponsor/sender's tax ID number.
            result.AllN1.Loop1000A.N1_SponsorName = new N1_SponsorName();
            result.AllN1.Loop1000A.N1_SponsorName.EntityIdentifierCode_01 = "P5";
            result.AllN1.Loop1000A.N1_SponsorName.IdentificationCodeQualifier_03 = "FI";
            result.AllN1.Loop1000A.N1_SponsorName.IntermediaryBankIdentifier_04 = "999888777";

            //  End 1000A Loop

            //  Begin 1000B Loop
            result.AllN1.Loop1000B = new Loop_1000B_834();

            //  Specifies the insurance company/receiver's tax ID number.
            result.AllN1.Loop1000B.N1_Payer = new N1_Payer();
            result.AllN1.Loop1000B.N1_Payer.EntityIdentifierCode_01 = "IN";
            result.AllN1.Loop1000B.N1_Payer.IdentificationCodeQualifier_03 = "FI";
            result.AllN1.Loop1000B.N1_Payer.IntermediaryBankIdentifier_04 = "654456654";

            //  End 1000B Loop

            //  Repeating 2000 Loops
            result.Loop2000 = new List<Loop_2000_834>();

            //  Begin 2000 Loop 
            var loop2000 = new Loop_2000_834();

            //  Beginning of Table 2. Indicates that the subscriber (John Doe) is adding coverage as an active employee.
            loop2000.INS_MemberLevelDetail = new INS_MemberLevelDetail();
            loop2000.INS_MemberLevelDetail.InsuredIndicator_01 = "Y";
            loop2000.INS_MemberLevelDetail.IndividualRelationshipCode_02 = "18";
            loop2000.INS_MemberLevelDetail.MaintenanceTypeCode_03 = "021";
            loop2000.INS_MemberLevelDetail.MaintenanceReasonCode_04 = "20";
            loop2000.INS_MemberLevelDetail.BenefitStatusCode_05 = "A";
            loop2000.INS_MemberLevelDetail.EmploymentStatusCode_08 = "FT";

            //  Occurrence of REF segments in any order
            loop2000.AllREF = new All_REF_834_2();

            //  John's subscriber ID number.
            loop2000.AllREF.REF_SubscriberIdentifier = new REF_SubscriberIdentifier();
            loop2000.AllREF.REF_SubscriberIdentifier.ReferenceIdentificationQualifier_01 = "0F";
            loop2000.AllREF.REF_SubscriberIdentifier.MemberGrouporPolicyNumber_02 = "123456789";

            //  This is the group number assigned by the carrier.
            loop2000.AllREF.REF_MemberPolicyNumber = new REF_MemberPolicyNumber();
            loop2000.AllREF.REF_MemberPolicyNumber.ReferenceIdentificationQualifier_01 = "1L";
            loop2000.AllREF.REF_MemberPolicyNumber.MemberGrouporPolicyNumber_02 = "123456001";

            //  Repeating DTP
            loop2000.DTP_MemberLevelDates = new List<DTP_MemberLevelDates>();

            //  The eligibility date for this transaction is 5/23/1996.
            var dtp1 = new DTP_MemberLevelDates();
            dtp1.DateTimeQualifier_01 = "356";
            dtp1.DateTimePeriodFormatQualifier_02 = "D8";
            dtp1.DateTimePeriod_03 = "19960523";
            loop2000.DTP_MemberLevelDates.Add(dtp1);

            //  Occurrence of N1 Loops in any order
            loop2000.AllNM1 = new All_NM1_834();

            //  Begin 2100A Loop
            loop2000.AllNM1.Loop2100A = new Loop_2100A_834();

            //  Subscriber's name.
            loop2000.AllNM1.Loop2100A.NM1_MemberName = new NM1_MemberName();
            loop2000.AllNM1.Loop2100A.NM1_MemberName.EntityIdentifierCode_01 = "IL";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.EntityTypeQualifier_02 = "1";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.ResponseContactLastorOrganizationName_03 = "DOE";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.ResponseContactFirstName_04 = "JOHN";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.ResponseContactMiddleName_05 = "P";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.IdentificationCodeQualifier_08 = "34";
            loop2000.AllNM1.Loop2100A.NM1_MemberName.ResponseContactIdentifier_09 = "123456789";

            //  John's home phone number is (717)234-3334 and his work number is (717) 234-1240.
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers = new PER_MemberCommunicationsNumbers();
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers.ContactFunctionCode_01 = "IP";
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers.CommunicationNumberQualifier_03 = "HP";
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers.ResponseContactCommunicationNumber_04 = "7172343334";
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers.CommunicationNumberQualifier_05 = "WP";
            loop2000.AllNM1.Loop2100A.PER_MemberCommunicationsNumbers.ResponseContactCommunicationNumber_06 = "7172341240";

            //  This is John's street address.
            loop2000.AllNM1.Loop2100A.N3_MemberResidenceStreetAddress = new N3_AdditionalPatientInformationContactAddress();
            loop2000.AllNM1.Loop2100A.N3_MemberResidenceStreetAddress.ResponseContactAddressLine_01 = "100 MARKET ST";
            loop2000.AllNM1.Loop2100A.N3_MemberResidenceStreetAddress.ResponseContactAddressLine_02 = "APT 3G";

            //  This is John's city, state zip code and county.
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode = new N4_MemberCity();
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "CAMP HILL";
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "PA";
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "17011";
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode.LocationQualifier_05 = "CY";
            loop2000.AllNM1.Loop2100A.N4_MemberCity_State_ZIPCode.LocationIdentifier_06 = "CUMBERLAND";

            //  This is John's date of birth and gender.
            loop2000.AllNM1.Loop2100A.DMG_MemberDemographics = new DMG_MemberDemographics();
            loop2000.AllNM1.Loop2100A.DMG_MemberDemographics.DateTimePeriodFormatQualifier_01 = "D8";
            loop2000.AllNM1.Loop2100A.DMG_MemberDemographics.DependentBirthDate_02 = "19400816";
            loop2000.AllNM1.Loop2100A.DMG_MemberDemographics.DependentGenderCode_03 = "M";

            //  End 2100A Loop

            //  Repeating 2300 Loops
            loop2000.Loop2300 = new List<Loop_2300_834>();

            //  Begin 2300 Loop 1
            var loop23001 = new Loop_2300_834();

            //  John is enrolling in a health benefit.
            loop23001.HD_HealthCoverage = new HD_HealthCoverage();
            loop23001.HD_HealthCoverage.MaintenanceTypeCode_01 = "021";
            loop23001.HD_HealthCoverage.InsuranceLineCode_03 = "HLT";

            //  Repeating DTP
            loop23001.DTP_HealthCoverageDates = new List<DTP_HealthCoverageDates>();

            //  The benefits under this plan begin 6/01/1996.
            var dtp2 = new DTP_HealthCoverageDates();
            dtp2.DateTimeQualifier_01 = "348";
            dtp2.DateTimePeriodFormatQualifier_02 = "D8";
            dtp2.DateTimePeriod_03 = "19960601";
            loop23001.DTP_HealthCoverageDates.Add(dtp2);

            //  Repeating 2320 Loops
            loop23001.Loop2320 = new List<Loop_2320_834>();

            //  Begin 2320 Loop
            var loop23201 = new Loop_2320_834();

            //  This lets the carrier know that John has COB with another company.
            loop23201.COB_CoordinationofBenefits = new COB_CoordinationofBenefits();
            loop23201.COB_CoordinationofBenefits.PayerResponsibilitySequenceNumberCode_01 = "P";
            loop23201.COB_CoordinationofBenefits.MemberGrouporPolicyNumber_02 = "890111";
            loop23201.COB_CoordinationofBenefits.CoordinationofBenefitsCode_03 = "5";

            //  End 2320 Loop
            loop23001.Loop2320.Add(loop23201);

            //  End 2300 Loop 1
            loop2000.Loop2300.Add(loop23001);

            //  Begin 2300 Loop 2
            var loop23002 = new Loop_2300_834();

            //  John is enrolling in the Dental benefit.
            loop23002.HD_HealthCoverage = new HD_HealthCoverage();
            loop23002.HD_HealthCoverage.MaintenanceTypeCode_01 = "021";
            loop23002.HD_HealthCoverage.InsuranceLineCode_03 = "DEN";

            //  Repeating DTP
            loop23002.DTP_HealthCoverageDates = new List<DTP_HealthCoverageDates>();

            //  The benefits under this plan begin 6/01/1996.
            var dtp3 = new DTP_HealthCoverageDates();
            dtp3.DateTimeQualifier_01 = "348";
            dtp3.DateTimePeriodFormatQualifier_02 = "D8";
            dtp3.DateTimePeriod_03 = "19960601";
            loop23002.DTP_HealthCoverageDates.Add(dtp3);            

            //  End 2300 Loop 2
            loop2000.Loop2300.Add(loop23002);

            //  Begin 2300 Loop 3
            var loop23003 = new Loop_2300_834();

            //  John is enrolling in the Vision benefit.
            loop23003.HD_HealthCoverage = new HD_HealthCoverage();
            loop23003.HD_HealthCoverage.MaintenanceTypeCode_01 = "021";
            loop23003.HD_HealthCoverage.InsuranceLineCode_03 = "VIS";

            //  Repeating DTP
            loop23003.DTP_HealthCoverageDates = new List<DTP_HealthCoverageDates>();

            //  The benefits under this plan begin 6/01/1996.
            var dtp4 = new DTP_HealthCoverageDates();
            dtp4.DateTimeQualifier_01 = "348";
            dtp4.DateTimePeriodFormatQualifier_02 = "D8";
            dtp4.DateTimePeriod_03 = "19960601";
            loop23003.DTP_HealthCoverageDates.Add(dtp4);

            //  End 2300 Loop 3
            loop2000.Loop2300.Add(loop23003);

            //  End 2000 Loop 
            result.Loop2000.Add(loop2000);

            return result;
        }
    }
}

