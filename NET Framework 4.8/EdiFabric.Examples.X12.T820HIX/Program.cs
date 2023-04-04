using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T820HIX
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
        /// Read Payment Order
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Hipaa\PaymentOrderRemittanceAdvice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS820HIX>();

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
        /// Write Payment Order
        /// </summary>
        static void Write()
        {
            var transaction = PaymentOrderRemittanceAdvice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X306"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build payment order remittance advice.
        /// Original from http://www.x12.org/
        /// </summary>
        static TS820HIX PaymentOrderRemittanceAdvice(string controlNumber)
        {
            var result = new TS820HIX();

            //  Beginning of an 820 transaction set, Control number = 0001.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "820";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X306";

            //  Total Payment Amount is $220. The payee’s bank transit routing number is 199999999 and their bank account is 98765. The Check Issue or EFT effective date is June 4, 2014.
            result.BPR_FinancialInformation = new BPR_FinancialInformation_3();
            result.BPR_FinancialInformation.TransactionHandlingCode_01 = "T";
            result.BPR_FinancialInformation.TotalPremiumPaymentAmount_02 = "220";
            result.BPR_FinancialInformation.CreditorDebitFlagCode_03 = "C";
            result.BPR_FinancialInformation.PaymentMethodCode_04 = "ACH";
            result.BPR_FinancialInformation.PaymentFormatCode_05 = "CCP";
            result.BPR_FinancialInformation.DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 = "01";
            result.BPR_FinancialInformation.ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 = "199999999";
            result.BPR_FinancialInformation.AccountNumberQualifier_14 = "DA";
            result.BPR_FinancialInformation.ReceiverBankAccountNumber_15 = "98765";
            result.BPR_FinancialInformation.CheckIssueorEFTEffectiveDate_16 = "20140604";

            //  Reassociation Key provides a sender unique Check or EFT trace number “78905”.
            result.TRN_ReassociationTraceNumber = new TRN_ReassociationTraceNumber_2();
            result.TRN_ReassociationTraceNumber.TraceTypeCode_01 = "3";
            result.TRN_ReassociationTraceNumber.CurrentTransactionTraceNumber_02 = "78905";

            //  The Exchanged assigned QHP Identifier is 123456.
            result.REF_ExchangeAssignedQualifiedHealthPlanIdentifier = new REF_ExchangeAssignedQualifiedHealthPlanIdentifier();
            result.REF_ExchangeAssignedQualifiedHealthPlanIdentifier.ReferenceIdentificationQualifier_01 = "38";
            result.REF_ExchangeAssignedQualifiedHealthPlanIdentifier.MemberGrouporPolicyNumber_02 = "123456";

            //  The Issuer assigned QHP identifier is 12565496.
            result.REF_IssuerAssignedQualifiedHealthPlanIdentifier = new REF_IssuerAssignedQualifiedHealthPlanIdentifier();
            result.REF_IssuerAssignedQualifiedHealthPlanIdentifier.ReferenceIdentificationQualifier_01 = "TV";
            result.REF_IssuerAssignedQualifiedHealthPlanIdentifier.MemberGrouporPolicyNumber_02 = "12565496";

            //  Begin 1000A Loop
            result.Loop1000A = new Loop_1000A_820HIX();

            //  The payee’s name (BATA INSURANCE CO.) and Federal Tax ID number (012222222).
            result.Loop1000A.N1_PayeeName = new N1_PayeeName();
            result.Loop1000A.N1_PayeeName.EntityIdentifierCode_01 = "PE";
            result.Loop1000A.N1_PayeeName.PremiumPayerName_02 = "BATA INSURANCE CO.";
            result.Loop1000A.N1_PayeeName.IdentificationCodeQualifier_03 = "FI";
            result.Loop1000A.N1_PayeeName.IntermediaryBankIdentifier_04 = "012222222";

            //  End 1000A Loop

            //  Begin 1000B Loop
            result.Loop1000B = new Loop_1000B_820HIX();

            //  The payer’s name is Government Agency with an identifier of 123ABC.
            result.Loop1000B.N1_PayersName = new N1_PayersName();
            result.Loop1000B.N1_PayersName.EntityIdentifierCode_01 = "RM";
            result.Loop1000B.N1_PayersName.PremiumPayerName_02 = "GOVERNMENT AGENCY";
            result.Loop1000B.N1_PayersName.IdentificationCodeQualifier_03 = "58";
            result.Loop1000B.N1_PayersName.IntermediaryBankIdentifier_04 = "123ABC";

            //  End 1000B Loop

            //  Repeating 2000 Loops
            result.Loop2000 = new List<Loop_2000_820HIX>();

            //  Begin 2000 Loop 1
            var loop20001 = new Loop_2000_820HIX();

            //  Start of detail loop for first detailed payment record.
            loop20001.ENT_RemittanceInformation = new ENT_RemittanceInformation();
            loop20001.ENT_RemittanceInformation.AssignedNumber_01 = "1";

            //  Begin 2100 Loop
            loop20001.Loop2100 = new Loop_2100_820HIX();

            //  The subscriber’s name (JOHN DOE) and Exchange Assigned Subscriber Number is 777222.
            loop20001.Loop2100.NM1_IndividualName = new NM1_IndividualName_2();
            loop20001.Loop2100.NM1_IndividualName.EntityIdentifierCode_01 = "IL";
            loop20001.Loop2100.NM1_IndividualName.EntityTypeQualifier_02 = "1";
            loop20001.Loop2100.NM1_IndividualName.ResponseContactLastorOrganizationName_03 = "DOE";
            loop20001.Loop2100.NM1_IndividualName.ResponseContactFirstName_04 = "JOHN";
            loop20001.Loop2100.NM1_IndividualName.IdentificationCodeQualifier_08 = "C1";
            loop20001.Loop2100.NM1_IndividualName.ResponseContactIdentifier_09 = "777222";

            //  The Exchange Assigned Policy Identifier is 12565456.
            loop20001.Loop2100.REF_ExchangeAssignedPolicyIdentifier = new REF_ExchangeAssignedPolicyIdentifier();
            loop20001.Loop2100.REF_ExchangeAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "POL";
            loop20001.Loop2100.REF_ExchangeAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "1232456";

            //  The Issuer Assigned Policy Identifier is 12565496.
            loop20001.Loop2100.REF_IssuerAssignedPolicyIdentifier = new REF_IssuerAssignedPolicyIdentifier();
            loop20001.Loop2100.REF_IssuerAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "AZ";
            loop20001.Loop2100.REF_IssuerAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "12565496";

            //  The issuer assigned identifier (555666) for subscriber JOHN DOE.
            loop20001.Loop2100.REF_IssuerAssignedSubscriberIdentifier = new REF_IssuerAssignedSubscriberIdentifier();
            loop20001.Loop2100.REF_IssuerAssignedSubscriberIdentifier.ReferenceIdentificationQualifier_01 = "0F";
            loop20001.Loop2100.REF_IssuerAssignedSubscriberIdentifier.MemberGrouporPolicyNumber_02 = "555666";

            //  End 2100 Loop

            //  Begin 2300 Loops
            loop20001.Loop2300 = new List<Loop_2300_820HIX>();

            //  Begin 2300 Loop 1
            var loop23001 = new Loop_2300_820HIX();

            //  Identification Qualifier ZZ = Exchange Payment Type RMR02 refers to a code list published and maintained by CMS representing the payment types. 
            //  The July 8, 2014 draft version of the Payment Type Codes are used for the purposes of this exercise, APTC = Advance payment of the Premium Tax Credit (APTC) Payment. The APTC amount being paid for this individual is $35.
            loop23001.RMR_RemittanceDetail = new RMR_RemittanceDetail();
            loop23001.RMR_RemittanceDetail.ReferenceIdentificationQualifier_01 = "ZZ";
            loop23001.RMR_RemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "APTC";
            loop23001.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04 = "35";

            //  This DTM demonstrates the specified date range for which the APTC payment amount applies.
            loop23001.DTM_IndividualCoveragePeriod = new DTM_IndividualCoveragePeriod_2();
            loop23001.DTM_IndividualCoveragePeriod.DateTimeQualifier_01 = "582";
            loop23001.DTM_IndividualCoveragePeriod.DateTimePeriodFormatQualifier_05 = "RD8";
            loop23001.DTM_IndividualCoveragePeriod.DateTimePeriod_06 = "20120501-20140531";

            //  End 2300 Loop 1
            loop20001.Loop2300.Add(loop23001);

            //  End 2300 Loops

            //  End 2000 Loop 1
            result.Loop2000.Add(loop20001);

            //  Begin 2000 Loop 2
            var loop20002 = new Loop_2000_820HIX();

            //  Start of detail loop for second detailed payment record.
            loop20002.ENT_RemittanceInformation = new ENT_RemittanceInformation();
            loop20002.ENT_RemittanceInformation.AssignedNumber_01 = "2";

            //  Begin 2100 Loop
            loop20002.Loop2100 = new Loop_2100_820HIX();

            //  The subscriber’s name (EMILY FIRSTONE) and exchange assigned identification number (777333).
            loop20002.Loop2100.NM1_IndividualName = new NM1_IndividualName_2();
            loop20002.Loop2100.NM1_IndividualName.EntityIdentifierCode_01 = "IL";
            loop20002.Loop2100.NM1_IndividualName.EntityTypeQualifier_02 = "1";
            loop20002.Loop2100.NM1_IndividualName.ResponseContactLastorOrganizationName_03 = "FIRSTONE";
            loop20002.Loop2100.NM1_IndividualName.ResponseContactFirstName_04 = "EMILY";
            loop20002.Loop2100.NM1_IndividualName.IdentificationCodeQualifier_08 = "C1";
            loop20002.Loop2100.NM1_IndividualName.ResponseContactIdentifier_09 = "777333";

            //  The Exchange Assigned Policy Identifier is 12565457.
            loop20002.Loop2100.REF_ExchangeAssignedPolicyIdentifier = new REF_ExchangeAssignedPolicyIdentifier();
            loop20002.Loop2100.REF_ExchangeAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "POL";
            loop20002.Loop2100.REF_ExchangeAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "1232457";

            //  The Issuer Assigned Policy Identifier is 12565497.
            loop20002.Loop2100.REF_IssuerAssignedPolicyIdentifier = new REF_IssuerAssignedPolicyIdentifier();
            loop20002.Loop2100.REF_IssuerAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "AZ";
            loop20002.Loop2100.REF_IssuerAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "12565497";

            //  The issuer assigned identifier (555666) for subscriber EMILY FIRSTONE.
            loop20002.Loop2100.REF_IssuerAssignedSubscriberIdentifier = new REF_IssuerAssignedSubscriberIdentifier();
            loop20002.Loop2100.REF_IssuerAssignedSubscriberIdentifier.ReferenceIdentificationQualifier_01 = "0F";
            loop20002.Loop2100.REF_IssuerAssignedSubscriberIdentifier.MemberGrouporPolicyNumber_02 = "555777";

            //  End 2100 Loop

            //  Begin 2300 Loops
            loop20002.Loop2300 = new List<Loop_2300_820HIX>();

            //  Begin 2300 Loop 1
            var loop23002 = new Loop_2300_820HIX();

            //  Identification Qualifier ZZ = Exchange Payment Type RMR02 refers to a code list published and maintained by CMS representing the payment types. 
            //  The July 8, 2014 draft version of the Payment Type Codes are used for the purposes of this exercise, APTC = Advance payment of the Premium Tax Credit (APTC) Payment. The APTC amount being paid for this individual is $35.
            loop23002.RMR_RemittanceDetail = new RMR_RemittanceDetail();
            loop23002.RMR_RemittanceDetail.ReferenceIdentificationQualifier_01 = "ZZ";
            loop23002.RMR_RemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "APTC";
            loop23002.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04 = "35";

            //  This DTM demonstrates the specified date range for which the APTC payment amount applies.
            loop23002.DTM_IndividualCoveragePeriod = new DTM_IndividualCoveragePeriod_2();
            loop23002.DTM_IndividualCoveragePeriod.DateTimeQualifier_01 = "582";
            loop23002.DTM_IndividualCoveragePeriod.DateTimePeriodFormatQualifier_05 = "RD8";
            loop23002.DTM_IndividualCoveragePeriod.DateTimePeriod_06 = "20120501-20140531";

            //  End 2300 Loop 1
            loop20002.Loop2300.Add(loop23002);

            //  End 2300 Loops

            //  End 2000 Loop 2
            result.Loop2000.Add(loop20002);

            //  Begin 2000 Loop 3
            var loop20003 = new Loop_2000_820HIX();

            //  Start of detail loop for the third detailed payment record.
            loop20003.ENT_RemittanceInformation = new ENT_RemittanceInformation();
            loop20003.ENT_RemittanceInformation.AssignedNumber_01 = "3";

            //  Begin 2100 Loop
            loop20003.Loop2100 = new Loop_2100_820HIX();

            //  The subscriber’s name (Julie Middleone) and exchange assigned identification number (777444).
            loop20003.Loop2100.NM1_IndividualName = new NM1_IndividualName_2();
            loop20003.Loop2100.NM1_IndividualName.EntityIdentifierCode_01 = "IL";
            loop20003.Loop2100.NM1_IndividualName.EntityTypeQualifier_02 = "1";
            loop20003.Loop2100.NM1_IndividualName.ResponseContactLastorOrganizationName_03 = "MIDDLEONE";
            loop20003.Loop2100.NM1_IndividualName.ResponseContactFirstName_04 = "JULIE";
            loop20003.Loop2100.NM1_IndividualName.IdentificationCodeQualifier_08 = "C1";
            loop20003.Loop2100.NM1_IndividualName.ResponseContactIdentifier_09 = "777444";

            //  The Exchange Assigned Policy Identifier is 12565458.
            loop20003.Loop2100.REF_ExchangeAssignedPolicyIdentifier = new REF_ExchangeAssignedPolicyIdentifier();
            loop20003.Loop2100.REF_ExchangeAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "POL";
            loop20003.Loop2100.REF_ExchangeAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "1232458";

            //  The Issuer Assigned Policy Identifier is 12565498.
            loop20003.Loop2100.REF_IssuerAssignedPolicyIdentifier = new REF_IssuerAssignedPolicyIdentifier();
            loop20003.Loop2100.REF_IssuerAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "AZ";
            loop20003.Loop2100.REF_IssuerAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "12565498";

            //  The issuer assigned identifier (544477) for subscriber JULIE MIDDLEONE.
            loop20003.Loop2100.REF_IssuerAssignedSubscriberIdentifier = new REF_IssuerAssignedSubscriberIdentifier();
            loop20003.Loop2100.REF_IssuerAssignedSubscriberIdentifier.ReferenceIdentificationQualifier_01 = "0F";
            loop20003.Loop2100.REF_IssuerAssignedSubscriberIdentifier.MemberGrouporPolicyNumber_02 = "544477";

            //  End 2100 Loop

            //  Begin 2300 Loops
            loop20003.Loop2300 = new List<Loop_2300_820HIX>();

            //  Begin 2300 Loop 1
            var loop23003 = new Loop_2300_820HIX();

            //  RMR02 refers to a code list published and maintained by CMS representing the payment types. 
            //  The July 8, 2014 draft version of the Payment Type Codes are used for the purposes of this exercise, APTC = Advance payment of the Premium Tax Credit (APTC) Payment. 
            //  The APTC amount being paid for this individual is $-350. Because this is a negative amount, it reduces the overall BPR02 payment and represents a recovery or retroactive reduction in the individual’s APTC amount.
            loop23003.RMR_RemittanceDetail = new RMR_RemittanceDetail();
            loop23003.RMR_RemittanceDetail.ReferenceIdentificationQualifier_01 = "ZZ";
            loop23003.RMR_RemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "APTC";
            loop23003.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04 = "-350";

            //  This DTM demonstrates the recovered APTC amounts apply to the time period ranging from 1/1/2014 thru 3/31/2014. This date supersedes the effective dates reported at the header level.
            loop23003.DTM_IndividualCoveragePeriod = new DTM_IndividualCoveragePeriod_2();
            loop23003.DTM_IndividualCoveragePeriod.DateTimeQualifier_01 = "582";
            loop23003.DTM_IndividualCoveragePeriod.DateTimePeriodFormatQualifier_05 = "RD8";
            loop23003.DTM_IndividualCoveragePeriod.DateTimePeriod_06 = "20140101-20140331";

            //  End 2300 Loop 1
            loop20003.Loop2300.Add(loop23003);

            //  End 2300 Loops

            //  End 2000 Loop 3
            result.Loop2000.Add(loop20003);

            //  Begin 2000 Loop 4
            var loop20004 = new Loop_2000_820HIX();

            //  Start of detail loop for the fourth detailed payment record.
            loop20004.ENT_RemittanceInformation = new ENT_RemittanceInformation();
            loop20004.ENT_RemittanceInformation.AssignedNumber_01 = "4";

            //  Begin 2100 Loop
            loop20004.Loop2100 = new Loop_2100_820HIX();

            //  The individual’s name (KELLY NEWONE) and exchange assigned identification number (777111).
            //  NOTE: The REF containing the Issuer Assigned Identifier is not present because the payer does not have the identifier available. The exchange assigned identifier is the only identifier received in this instance.
            loop20004.Loop2100.NM1_IndividualName = new NM1_IndividualName_2();
            loop20004.Loop2100.NM1_IndividualName.EntityIdentifierCode_01 = "IL";
            loop20004.Loop2100.NM1_IndividualName.EntityTypeQualifier_02 = "1";
            loop20004.Loop2100.NM1_IndividualName.ResponseContactLastorOrganizationName_03 = "NEWONE";
            loop20004.Loop2100.NM1_IndividualName.ResponseContactFirstName_04 = "KELLY";
            loop20004.Loop2100.NM1_IndividualName.IdentificationCodeQualifier_08 = "C1";
            loop20004.Loop2100.NM1_IndividualName.ResponseContactIdentifier_09 = "777111";

            //  The Exchange Assigned Policy Identifier is 12565459.
            loop20004.Loop2100.REF_ExchangeAssignedPolicyIdentifier = new REF_ExchangeAssignedPolicyIdentifier();
            loop20004.Loop2100.REF_ExchangeAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "POL";
            loop20004.Loop2100.REF_ExchangeAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "1232459";

            //  The Issuer Assigned Policy Identifier is 12565499.
            loop20004.Loop2100.REF_IssuerAssignedPolicyIdentifier = new REF_IssuerAssignedPolicyIdentifier();
            loop20004.Loop2100.REF_IssuerAssignedPolicyIdentifier.ReferenceIdentificationQualifier_01 = "AZ";
            loop20004.Loop2100.REF_IssuerAssignedPolicyIdentifier.MemberGrouporPolicyNumber_02 = "12565499";

            //  End 2100 Loop

            //  Begin 2300 Loops
            loop20004.Loop2300 = new List<Loop_2300_820HIX>();

            //  Begin 2300 Loop 1
            var loop23004 = new Loop_2300_820HIX();

            //  RMR02 refers to a code list published and maintained by CMS representing the payment types. 
            //  The July 8, 2014 draft version of the Payment Type Codes are used for the purposes of this exercise, APTC = Advance payment of the Premium Tax Credit (APTC) Payment. 
            //  The APTC amount being paid for this individual is $450.
            loop23004.RMR_RemittanceDetail = new RMR_RemittanceDetail();
            loop23004.RMR_RemittanceDetail.ReferenceIdentificationQualifier_01 = "ZZ";
            loop23004.RMR_RemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "APTC";
            loop23004.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04 = "450";

            //  This DTM demonstrates the specified date range for which the APTC payment amount applies.
            loop23004.DTM_IndividualCoveragePeriod = new DTM_IndividualCoveragePeriod_2();
            loop23004.DTM_IndividualCoveragePeriod.DateTimeQualifier_01 = "582";
            loop23004.DTM_IndividualCoveragePeriod.DateTimePeriodFormatQualifier_05 = "RD8";
            loop23004.DTM_IndividualCoveragePeriod.DateTimePeriod_06 = "20140501-20140531";

            //  End 2300 Loop 1
            loop20004.Loop2300.Add(loop23004);

            //  Begin 2300 Loop 2
            var loop23005 = new Loop_2300_820HIX();

            //  RMR02 refers to a code list published and maintained by CMS representing the payment types. 
            //  The July 8, 2014 draft version of the Payment Type Codes are used for the purposes of this exercise, CSR = Cost-Sharing Reduction (CSR) Payment. 
            //  The amount being paid for this individual is $50.
            loop23005.RMR_RemittanceDetail = new RMR_RemittanceDetail();
            loop23005.RMR_RemittanceDetail.ReferenceIdentificationQualifier_01 = "ZZ";
            loop23005.RMR_RemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "CSR";
            loop23005.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04 = "50";

            //  This DTM demonstrates the specified date range for which the CSR payment amount applies.
            loop23005.DTM_IndividualCoveragePeriod = new DTM_IndividualCoveragePeriod_2();
            loop23005.DTM_IndividualCoveragePeriod.DateTimeQualifier_01 = "582";
            loop23005.DTM_IndividualCoveragePeriod.DateTimePeriodFormatQualifier_05 = "RD8";
            loop23005.DTM_IndividualCoveragePeriod.DateTimePeriod_06 = "20140501-20140531";

            //  End 2300 Loop 2
            loop20004.Loop2300.Add(loop23005);

            //  End 2300 Loops

            //  End 2000 Loop 3
            result.Loop2000.Add(loop20004);

            return result;
        }
    }
}
