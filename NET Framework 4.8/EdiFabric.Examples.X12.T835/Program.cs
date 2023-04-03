using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.T835
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
        /// Read Payment
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\Hipaa\Payment.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS835>();

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
        /// Write Payment
        /// </summary>
        static void Write()
        {
            var transaction = BuildPayment("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1", "SENDER1", "RECEIVER1", "005010X221A1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build payment.
        /// Original from http://www.x12.org/examples/005010X221/payments/secondary-payment-with-higher-fee-schedule/
        /// </summary>
        static TS835 BuildPayment(string controlNumber)
        {
            //  In this claim, the primary payer received a claim for $541.00. They allowed $400 and paid $375.00 of the submitted charges. 
            //  The primary payer applied $141.00 as a contractual adjustment that was part of the provider's fee schedule. The patient, Raymond Burck owed a co-pay of $25.00.

            //  YTDAW as the secondary payer allowed $550.00 for the service submitted. This amount is $9.00 more than charged.
            //  The secondary payer paid $34.00.The impact of the primary payer's payment on the secondary payer is $516.00 ($141.00 contractual adjustment and $375.00 payment).
            
            var result = new TS835();

            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "835";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            result.BPR_FinancialInformation = new BPR_FinancialInformation_2();
            result.BPR_FinancialInformation.TransactionHandlingCode_01 = "I";
            result.BPR_FinancialInformation.TotalPremiumPaymentAmount_02 = "34.00";
            result.BPR_FinancialInformation.CreditorDebitFlagCode_03 = "C";
            result.BPR_FinancialInformation.PaymentMethodCode_04 = "CHK";
            result.BPR_FinancialInformation.CheckIssueorEFTEffectiveDate_16 = "20050318";

            result.TRN_ReassociationTraceNumber = new TRN_DependentTraceNumber();
            result.TRN_ReassociationTraceNumber.TraceTypeCode_01 = "1";
            result.TRN_ReassociationTraceNumber.CurrentTransactionTraceNumber_02 = "0063158ABC";
            result.TRN_ReassociationTraceNumber.OriginatingCompanyIdentifier_03 = "1566339911";

            //  Occurrence of REF Segments in any order
            result.AllREF = new All_REF_835_3();

            result.AllREF.REF_ReceiverIdentification = new REF_ReceiverIdentification();
            result.AllREF.REF_ReceiverIdentification.ReferenceIdentificationQualifier_01 = "EV";
            result.AllREF.REF_ReceiverIdentification.MemberGrouporPolicyNumber_02 = "030240928";

            result.DTM_ProductionDate = new DTM_ProductionDate();
            result.DTM_ProductionDate.DateTimeQualifier_01 = "405";
            result.DTM_ProductionDate.Date_02 = "20050318";

            //  Occurrence of N1 Loops in any order
            result.AllN1 = new All_N1_835();

            //  Begin 1000A Loop
            result.AllN1.Loop1000A = new Loop_1000A_835();

            result.AllN1.Loop1000A.N1_PayerIdentification = new N1_PayerIdentification();
            result.AllN1.Loop1000A.N1_PayerIdentification.EntityIdentifierCode_01 = "PR";
            result.AllN1.Loop1000A.N1_PayerIdentification.PremiumPayerName_02 = "YOUR TAX DOLLARS AT WORK";

            result.AllN1.Loop1000A.N3_PayerAddress = new N3_AdditionalPatientInformationContactAddress();
            result.AllN1.Loop1000A.N3_PayerAddress.ResponseContactAddressLine_01 = "481A00 DEER RUN ROAD";

            result.AllN1.Loop1000A.N4_PayerCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            result.AllN1.Loop1000A.N4_PayerCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "WEST PALM BCH";
            result.AllN1.Loop1000A.N4_PayerCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            result.AllN1.Loop1000A.N4_PayerCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "11114";

            //  Occurrence of PER Segments in any order
            result.AllN1.Loop1000A.AllPER = new All_PER_835();

            //  Repeating PER Contact Information
            result.AllN1.Loop1000A.AllPER.PER_PayerTechnicalContactInformation = new List<PER_PayerTechnicalContactInformation>();

            var per1 = new PER_PayerTechnicalContactInformation();
            per1.ContactFunctionCode_01 = "BL";
            per1.ResponseContactName_02 = "JOHN WAYNE";
            per1.CommunicationNumberQualifier_03 = "TE";
            per1.ResponseContactCommunicationNumber_04 = "8005551212";
            per1.CommunicationNumberQualifier_05 = "EX";
            per1.ResponseContactCommunicationNumber_06 = "123";
            result.AllN1.Loop1000A.AllPER.PER_PayerTechnicalContactInformation.Add(per1);

            //  End 1000A Loop

            //  Begin 1000B Loop
            result.AllN1.Loop1000B = new Loop_1000B_835();

            result.AllN1.Loop1000B.N1_PayeeIdentification = new N1_PayeeIdentification();
            result.AllN1.Loop1000B.N1_PayeeIdentification.EntityIdentifierCode_01 = "PE";
            result.AllN1.Loop1000B.N1_PayeeIdentification.PremiumPayerName_02 = "ATONEWITHHEALTH";
            result.AllN1.Loop1000B.N1_PayeeIdentification.IdentificationCodeQualifier_03 = "FI";
            result.AllN1.Loop1000B.N1_PayeeIdentification.IntermediaryBankIdentifier_04 = "3UR334563";

            result.AllN1.Loop1000B.N3_PayeeAddress = new N3_AdditionalPatientInformationContactAddress();
            result.AllN1.Loop1000B.N3_PayeeAddress.ResponseContactAddressLine_01 = "3501 JOHNSON STREET";

            result.AllN1.Loop1000B.N4_PayeeCity_State_ZIPCode = new N4_AdditionalPatientInformationContactCity();
            result.AllN1.Loop1000B.N4_PayeeCity_State_ZIPCode.AdditionalPatientInformationContactCityName_01 = "SUNSHINE";
            result.AllN1.Loop1000B.N4_PayeeCity_State_ZIPCode.AdditionalPatientInformationContactStateCode_02 = "FL";
            result.AllN1.Loop1000B.N4_PayeeCity_State_ZIPCode.AdditionalPatientInformationContactPostalZoneorZIPCode_03 = "12345";

            //  Repeating REF Identification
            result.AllN1.Loop1000B.REF_PayeeAdditionalIdentification = new List<REF_PayeeAdditionalIdentification>();

            var ref1 = new REF_PayeeAdditionalIdentification();
            ref1.ReferenceIdentificationQualifier_01 = "PQ";
            ref1.MemberGrouporPolicyNumber_02 = "11861";
            result.AllN1.Loop1000B.REF_PayeeAdditionalIdentification.Add(ref1);

            //  End 1000B Loop

            //  Repeating Loop 2000 Groups
            result.Loop2000 = new List<Loop_2000_835>();

            //  Begin Loop 2000
            var loop2000 = new Loop_2000_835();

            loop2000.LX_HeaderNumber = new LX_HeaderNumber();
            loop2000.LX_HeaderNumber.AssignedNumber_01 = "1";

            //  Repeating Loop 2100 Groups
            loop2000.Loop2100 = new List<Loop_2100_835>();

            //  Begin Loop 2100
            var loop2100 = new Loop_2100_835();

            loop2100.CLP_ClaimPaymentInformation = new CLP_ClaimPaymentInformation();
            loop2100.CLP_ClaimPaymentInformation.PatientControlNumber_01 = "0001000055";
            loop2100.CLP_ClaimPaymentInformation.ClaimStatusCode_02 = "2";
            loop2100.CLP_ClaimPaymentInformation.TotalClaimChargeAmount_03 = "541";
            loop2100.CLP_ClaimPaymentInformation.ClaimPaymentAmount_04 = "34";
            loop2100.CLP_ClaimPaymentInformation.ClaimFilingIndicatorCode_06 = "12";
            loop2100.CLP_ClaimPaymentInformation.PayerClaimControlNumber_07 = "50650619501";

            //  Occurrence of NM1 Segments in any order
            loop2100.AllNM1 = new All_NM1_835();

            loop2100.AllNM1.NM1_PatientName = new NM1_PatientName_2();
            loop2100.AllNM1.NM1_PatientName.EntityIdentifierCode_01 = "QC";
            loop2100.AllNM1.NM1_PatientName.EntityTypeQualifier_02 = "1";
            loop2100.AllNM1.NM1_PatientName.ResponseContactLastorOrganizationName_03 = "BURCK";
            loop2100.AllNM1.NM1_PatientName.ResponseContactFirstName_04 = "RAYMOND";
            loop2100.AllNM1.NM1_PatientName.ResponseContactMiddleName_05 = "W";
            loop2100.AllNM1.NM1_PatientName.IdentificationCodeQualifier_08 = "MI";
            loop2100.AllNM1.NM1_PatientName.ResponseContactIdentifier_09 = "987654321";

            loop2100.AllNM1.NM1_ServiceProviderName = new NM1_ServiceProviderName_3();
            loop2100.AllNM1.NM1_ServiceProviderName.EntityIdentifierCode_01 = "82";
            loop2100.AllNM1.NM1_ServiceProviderName.EntityTypeQualifier_02 = "2";
            loop2100.AllNM1.NM1_ServiceProviderName.ResponseContactLastorOrganizationName_03 = "PROFESSIONAL TEST 1";
            loop2100.AllNM1.NM1_ServiceProviderName.IdentificationCodeQualifier_08 = "BS";
            loop2100.AllNM1.NM1_ServiceProviderName.ResponseContactIdentifier_09 = "34426";

            //  Occurrence of DTM Segments in any order
            loop2100.AllDTM = new All_DTM_835();

            //  Repeating DTM statement
            loop2100.AllDTM.DTM_StatementFromorToDate = new List<DTM_StatementFromorToDate>();

            var dtm1 = new DTM_StatementFromorToDate();
            dtm1.DateTimeQualifier_01 = "232";
            dtm1.Date_02 = "20050202";
            loop2100.AllDTM.DTM_StatementFromorToDate.Add(dtm1);

            var dtm2 = new DTM_StatementFromorToDate();
            dtm2.DateTimeQualifier_01 = "233";
            dtm2.Date_02 = "20050202";
            loop2100.AllDTM.DTM_StatementFromorToDate.Add(dtm2);

            //  Repeating 2110 Loops
            loop2100.Loop2110 = new List<Loop_2110_835>();

            //  Begin 2110 Loop
            var loop2110 = new Loop_2110_835();

            loop2110.SVC_ServicePaymentInformation = new SVC_ServicePaymentInformation();
            loop2110.SVC_ServicePaymentInformation.CompositeMedicalProcedureIdentifier_01 = new C003_CompositeMedicalProcedureIdentifier_16();
            loop2110.SVC_ServicePaymentInformation.CompositeMedicalProcedureIdentifier_01.ProductorServiceIDQualifier_01 = "HC";
            loop2110.SVC_ServicePaymentInformation.CompositeMedicalProcedureIdentifier_01.ProcedureCode_02 = "55669";
            loop2110.SVC_ServicePaymentInformation.LineItemChargeAmount_02 = "541";
            loop2110.SVC_ServicePaymentInformation.MonetaryAmount_03 = "34";
            loop2110.SVC_ServicePaymentInformation.RevenueCode_04 = "1";

            //  Repeating DT service date
            loop2110.DTM_ServiceDate = new List<DTM_ServiceDate>();

            var dtm3 = new DTM_ServiceDate();
            dtm3.DateTimeQualifier_01 = "472";
            dtm3.Date_02 = "20050202";
            loop2110.DTM_ServiceDate.Add(dtm3);

            //  Repeating CAS
            loop2110.CAS_ServiceAdjustment = new List<CAS_ClaimsAdjustment>();

            var cas1 = new CAS_ClaimsAdjustment();
            cas1.ClaimAdjustmentGroupCode_01 = "OA";
            cas1.AdjustmentReasonCode_02 = "23";
            cas1.AdjustmentAmount_03 = "516";
            loop2110.CAS_ServiceAdjustment.Add(cas1);

            var cas2 = new CAS_ClaimsAdjustment();
            cas2.ClaimAdjustmentGroupCode_01 = "OA";
            cas2.AdjustmentReasonCode_02 = "94";
            cas2.AdjustmentAmount_03 = "-9";
            loop2110.CAS_ServiceAdjustment.Add(cas2);

            //  Occurrence of DTM Segments in any order
            loop2110.AllREF = new All_REF_835_2();

            //  Repeating REF provider information
            loop2110.AllREF.REF_RenderingProviderInformation = new List<REF_RenderingProviderInformation>();

            var ref2 = new REF_RenderingProviderInformation();
            ref2.ReferenceIdentificationQualifier_01 = "1B";
            ref2.MemberGrouporPolicyNumber_02 = "44280";
            loop2110.AllREF.REF_RenderingProviderInformation.Add(ref2);

            //  Repeating AMT service amount
            loop2110.AMT_ServiceSupplementalAmount = new List<AMT_ServiceSupplementalAmount>();

            var amt = new AMT_ServiceSupplementalAmount();
            amt.AmountQualifierCode_01 = "B6";
            amt.TotalClaimChargeAmount_02 = "550";
            loop2110.AMT_ServiceSupplementalAmount.Add(amt);

            //  End 2110 Loop
            loop2100.Loop2110.Add(loop2110);

            //  End Loop 2100
            loop2000.Loop2100.Add(loop2100);

            //  End Loop 2000
            result.Loop2000.Add(loop2000);

            return result;
        }
    }
}

