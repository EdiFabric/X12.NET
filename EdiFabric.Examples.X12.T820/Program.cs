using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T820
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Payment Order
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\PaymentOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa", new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS820>();           

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
            var transaction = BuildPaymentOrder("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, new X12WriterSettings { SerialNumber = TrialLicense.SerialNumber }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X218"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build payment order.
        /// Original from http://www.x12.org/examples/005010X218/summary-bill-payment/
        /// </summary>
        static TS820 BuildPaymentOrder(string controlNumber)
        {
            var result = new TS820();

            //  Beginning of an 820 transaction set, Control number = 0001.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "820";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');
            result.ST.ImplementationConventionPreference_03 = "005010X218";

            //  Financial institution to include the remittance information with the payment of $19000 using a credit ACH CTX formatted payment. 
            //  The premium payer's bank transit routing number is 999999992 and their bank account is 12345678. 
            //  The premium payer's Tax ID with a leading 1 is 1030449999. 
            //  The premium receiver's bank transit routing number is 199999999 and their bank account is 98765. 
            //  The payment effective date is May 16, 2007.
            result.BPR_FinancialInformation = new BPR_FinancialInformation();
            result.BPR_FinancialInformation.TransactionHandlingCode_01 = "C";
            result.BPR_FinancialInformation.TotalPremiumPaymentAmount_02 = "19000";
            result.BPR_FinancialInformation.CreditorDebitFlagCode_03 = "C";
            result.BPR_FinancialInformation.PaymentMethodCode_04 = "ACH";
            result.BPR_FinancialInformation.PaymentFormatCode_05 = "CTX";
            result.BPR_FinancialInformation.DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 = "01";
            result.BPR_FinancialInformation.OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 = "999999992";
            result.BPR_FinancialInformation.AccountNumberQualifier_08 = "DA";
            result.BPR_FinancialInformation.SenderBankAccountNumber_09 = "12345678";
            result.BPR_FinancialInformation.PayerIdentifier_10 = "1030449999";
            result.BPR_FinancialInformation.DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 = "01";
            result.BPR_FinancialInformation.ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 = "199999999";
            result.BPR_FinancialInformation.AccountNumberQualifier_14 = "DA";
            result.BPR_FinancialInformation.ReceiverBankAccountNumber_15 = "98765";
            result.BPR_FinancialInformation.CheckIssueorEFTEffectiveDate_16 = "20070516";

            //  Reassociation Key provides a sender unique trace number "12345", and the sender's Tax ID number preceded by a 1. 
            //  This Key is included in case the sending trace number is duplicated by another sender.
            result.TRN_ReassociationTraceNumber = new TRN_ReassociationTraceNumber();
            result.TRN_ReassociationTraceNumber.TraceTypeCode_01 = "1";
            result.TRN_ReassociationTraceNumber.CurrentTransactionTraceNumber_02 = "12345";
            result.TRN_ReassociationTraceNumber.OriginatingCompanyIdentifier_03 = "1030449999";

            //  Repeating REF
            result.REF_PremiumReceiversIdentificationKey = new List<REF_PremiumReceiversIdentificationKey>();

            //  The master account number is 12345.
            var ref1 = new REF_PremiumReceiversIdentificationKey();
            ref1.ReferenceIdentificationQualifier_01 = "14";
            ref1.MemberGrouporPolicyNumber_02 = "12345";
            result.REF_PremiumReceiversIdentificationKey.Add(ref1);

            //  Occurrence of N1 Loops in any order
            result.AllN1 = new All_N1_820();

            //  Begin 1000A Loop
            result.AllN1.Loop1000A = new Loop_1000A_820();

            //  The premium receiver's name (DEF HEALTH CARE INC) and federal Tax ID number (012222222).
            result.AllN1.Loop1000A.N1_PremiumReceiver_Name = new N1_PremiumReceiver();
            result.AllN1.Loop1000A.N1_PremiumReceiver_Name.EntityIdentifierCode_01 = "PE";
            result.AllN1.Loop1000A.N1_PremiumReceiver_Name.PremiumPayerName_02 = "DEF HEALTH CARE INC.";
            result.AllN1.Loop1000A.N1_PremiumReceiver_Name.IdentificationCodeQualifier_03 = "FI";
            result.AllN1.Loop1000A.N1_PremiumReceiver_Name.IntermediaryBankIdentifier_04 = "012222222";

            //  End 1000A Loop

            //  Begin 1000B Loop
            result.AllN1.Loop1000B = new Loop_1000B_820();

            //  The premium payer's name (ABC PLASTICS) and federal tax ID number (123456789).
            result.AllN1.Loop1000B.N1_PremiumPayer_Name = new N1_PremiumPayer();
            result.AllN1.Loop1000B.N1_PremiumPayer_Name.EntityIdentifierCode_01 = "PR";
            result.AllN1.Loop1000B.N1_PremiumPayer_Name.PremiumPayerName_02 = "ABC PLASTICS";
            result.AllN1.Loop1000B.N1_PremiumPayer_Name.IdentificationCodeQualifier_03 = "FI";
            result.AllN1.Loop1000B.N1_PremiumPayer_Name.IntermediaryBankIdentifier_04 = "123456789";

            //  End 1000B Loop

            //  Occurrence of ENT Loops in any order
            result.AllENT = new All_ENT_820();

            //  Begin 2000A Loop
            result.AllENT.Loop2000A = new Loop_2000A_820();

            //  Start of detail loop. Identifies this is a corporate entity item (summary bill payment). 
            //  The premium payer's federal tax ID number (123456789).
            result.AllENT.Loop2000A.ENT_OrganizationSummaryRemittance = new ENT_OrganizationSummaryRemittance();
            result.AllENT.Loop2000A.ENT_OrganizationSummaryRemittance.AssignedNumber_01 = "1";
            result.AllENT.Loop2000A.ENT_OrganizationSummaryRemittance.EntityIdentifierCode_02 = "2L";
            result.AllENT.Loop2000A.ENT_OrganizationSummaryRemittance.IdentificationCodeQualifier_03 = "FI";
            result.AllENT.Loop2000A.ENT_OrganizationSummaryRemittance.ReceiversIndividualIdentifier_04 = "123456789";

            //  Repeating 2300 Loops
            result.AllENT.Loop2000A.Loop2300A = new List<Loop_2300A_820>();

            //  Begin 2300A Loop 1
            var loop23001 = new Loop_2300A_820();

            //  The invoice being paid 970501001 (major medical).The amount being paid to this invoice ($16500).
            loop23001.RMR_OrganizationSummaryRemittanceDetail = new RMR_OrganizationSummaryRemittanceDetail();
            loop23001.RMR_OrganizationSummaryRemittanceDetail.ReferenceIdentificationQualifier_01 = "IK";
            loop23001.RMR_OrganizationSummaryRemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "970501001";
            loop23001.RMR_OrganizationSummaryRemittanceDetail.PaymentActionCode_03 = "PI";
            loop23001.RMR_OrganizationSummaryRemittanceDetail.DetailPremiumPaymentAmount_04 = "16500";

            //  Begin 2310A Loop
            loop23001.Loop2310A = new Loop_2310A_820();

            //  Start of required member counts under a summary RMR item.
            loop23001.Loop2310A.IT1_SummaryLineItem = new IT1_SummaryLineItem();
            loop23001.Loop2310A.IT1_SummaryLineItem.LineItemControlNumber_01 = "1";

            //  Repeating 2315A Loop
            loop23001.Loop2310A.Loop2315A = new List<Loop_2315A_820>();

            //  Begin 2315A Loop 1
            var loop2315a1 = new Loop_2315A_820();

            //  Five of the 80 employees have individual coverage.
            loop2315a1.SLN_MemberCount = new SLN_MemberCount();
            loop2315a1.SLN_MemberCount.LineItemControlNumber_01 = "1";
            loop2315a1.SLN_MemberCount.InformationOnlyIndicator_03 = "O";
            loop2315a1.SLN_MemberCount.HeadCount_04 = "5";
            loop2315a1.SLN_MemberCount.CompositeUnitOfMeasure_05 = new C001_CompositeUnitOfMeasure_4();
            loop2315a1.SLN_MemberCount.CompositeUnitOfMeasure_05.UnitorBasisforMeasurementCode_01 = "IE";

            //  End 2315A Loop 1
            loop23001.Loop2310A.Loop2315A.Add(loop2315a1);

            //  Begin 2315A Loop 2
            var loop2315a2 = new Loop_2315A_820();

            //  Seventy-five of the 80 employees have family coverage.
            loop2315a2.SLN_MemberCount = new SLN_MemberCount();
            loop2315a2.SLN_MemberCount.LineItemControlNumber_01 = "2";
            loop2315a2.SLN_MemberCount.InformationOnlyIndicator_03 = "O";
            loop2315a2.SLN_MemberCount.HeadCount_04 = "75";
            loop2315a2.SLN_MemberCount.CompositeUnitOfMeasure_05 = new C001_CompositeUnitOfMeasure_4();
            loop2315a2.SLN_MemberCount.CompositeUnitOfMeasure_05.UnitorBasisforMeasurementCode_01 = "10";

            //  End 2315A Loop 2
            loop23001.Loop2310A.Loop2315A.Add(loop2315a2);

            //  End 2310A Loop

            //  End 2300A Loop 1
            result.AllENT.Loop2000A.Loop2300A.Add(loop23001);

            //  Begin 2300A Loop 2
            var loop23002 = new Loop_2300A_820();

            //  The invoice being paid 970501002 (disability). The amount being paid to this invoice ($2500).
            loop23002.RMR_OrganizationSummaryRemittanceDetail = new RMR_OrganizationSummaryRemittanceDetail();
            loop23002.RMR_OrganizationSummaryRemittanceDetail.ReferenceIdentificationQualifier_01 = "IK";
            loop23002.RMR_OrganizationSummaryRemittanceDetail.InsuranceRemittanceReferenceNumber_02 = "970501002";
            loop23002.RMR_OrganizationSummaryRemittanceDetail.PaymentActionCode_03 = "PI";
            loop23002.RMR_OrganizationSummaryRemittanceDetail.DetailPremiumPaymentAmount_04 = "250";

            //  Begin 2310A Loop
            loop23002.Loop2310A = new Loop_2310A_820();

            //  Start of required member counts under a summary RMR item.
            loop23002.Loop2310A.IT1_SummaryLineItem = new IT1_SummaryLineItem();
            loop23002.Loop2310A.IT1_SummaryLineItem.LineItemControlNumber_01 = "1";

            //  Repeating 2315A Loop
            loop23002.Loop2310A.Loop2315A = new List<Loop_2315A_820>();

            //  Begin 2315A Loop 1
            var loop2315a3 = new Loop_2315A_820();

            //  Twenty-five employees have disability coverage.
            loop2315a3.SLN_MemberCount = new SLN_MemberCount();
            loop2315a3.SLN_MemberCount.LineItemControlNumber_01 = "1";
            loop2315a3.SLN_MemberCount.InformationOnlyIndicator_03 = "O";
            loop2315a3.SLN_MemberCount.HeadCount_04 = "25";
            loop2315a3.SLN_MemberCount.CompositeUnitOfMeasure_05 = new C001_CompositeUnitOfMeasure_4();
            loop2315a3.SLN_MemberCount.CompositeUnitOfMeasure_05.UnitorBasisforMeasurementCode_01 = "IE";

            //  End 2315A Loop 1
            loop23002.Loop2310A.Loop2315A.Add(loop2315a3);            

            //  End 2310A Loop

            //  End 2300A Loop 2
            result.AllENT.Loop2000A.Loop2300A.Add(loop23002);

            //  End 2000A Loop

            return result;
        }
    }
}

