using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.X12;
using EdiFabric.Templates.X12;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Sdk.X12.T861
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Receiving Advice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\ReceivingAdvice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.TrialTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS861>();

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
        /// Write Receiving Advice
        /// </summary>
        static void Write()
        {
            var transaction = BuildReceivingAdvice("2");

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
        /// Builds receiving advice.
        /// Original from https://ps.extra.chrysler.com/sites/itb-ebus/Documents/861GlobalCoreReturnSystemReceivingAdvice.pdf
        /// </summary>
        static TS861 BuildReceivingAdvice(string controlNumber)
        {
            var result = new TS861();

            //  Transaction Set Identifier Code = “861”
            //  (Receiving Advice / Acceptance Certificate)
            //  Transaction Set Control Number = 0002
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "861";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Reference Identification = C000548241
            //  Date = 02 / 24 / 2009
            //  Transaction Set Purpose Code = “00” (Original)
            //  Receiving Advice or Acceptance Certificate
            //  = “3” (Disposition Advice) 
            result.BRA = new BRA();
            result.BRA.ReferenceIdentification_01 = "C000548241";
            result.BRA.Date_02 = "20090224";
            result.BRA.TransactionSetPurposeCode_03 = "00";
            result.BRA.ReceivingAdviceorAcceptanceCertificateTypeCode_04 = "3";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Date/Time Qualifier = “050” (Received)
            //  Date = 01 / 02 / 2009
            //  Time = 8:55 AM
            //  Time Code = “ET” (Eastern Time) 
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "050";
            dtm1.Date_02 = "20090102";
            dtm1.Time_03 = "0855";
            dtm1.TimeCode_04 = "ET";
            result.DTM.Add(dtm1);

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_861>();

            //  Begin N1 Loop
            var n1Loop1 = new Loop_N1_861();

            //  Entity Identifier Code
            //  = “SU” (Supplier / Manufacturer)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer or Buyer's Agent)
            //  Identification Code = 43677
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SU";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop1.N1.IdentificationCode_04 = "43677";

            //  End N1 Loop
            result.N1Loop.Add(n1Loop1);

            //  Repeating RCD Loops
            result.RCDLoop = new List<Loop_RCD_861>();

            //  Begin RCD Loop
            var rcdLoop = new Loop_RCD_861();

            //  Quantity in Question = 1
            //  Unit or Basis for Measurement Code
            //  = “EA” (Each)
            //  Receiving Condition Code = 09
            rcdLoop.RCD = new RCD();
            rcdLoop.RCD.QuantityinQuestion_06 = "1";
            rcdLoop.RCD.CompositeUnitofMeasure_07 = new C001();
            rcdLoop.RCD.CompositeUnitofMeasure_07.UnitorBasisforMeasurementCode_01 = "EA";
            rcdLoop.RCD.ReceivingConditionCode_08 = "09";

            //  Repeating LIN
            rcdLoop.LIN = new List<LIN>();

            //  Product/Service ID Qualifier
            //  = “BP” (Buyer's Part Number)
            //  Product / Service ID = U0070062
            var lin1 = new LIN();
            lin1.ProductServiceIDQualifier_02 = "BP";
            lin1.ProductServiceID_03 = "U0070062";
            rcdLoop.LIN.Add(lin1);

            //  Repeating REF
            rcdLoop.REF = new List<REF>();

            //  Reference Identification Qualifier
            //  = “ACC” (Status)
            //  Reference Identification = A
            var ref1 = new REF();
            ref1.ReferenceIdentificationQualifier_01 = "ACC";
            ref1.ReferenceIdentification_02 = "A";
            rcdLoop.REF.Add(ref1);

            //  Repeating DTM
            rcdLoop.DTM = new List<DTM>();

            //  Date/Time Qualifier = “945” (Activity)
            //  Date = 01 / 02 / 2009
            //  Time = 8:55 AM
            //  Time Code = “ET” (Eastern Time) 
            var dtm2 = new DTM();
            dtm2.DateTimeQualifier_01 = "945";
            dtm2.Date_02 = "20090102";
            dtm2.Time_03 = "0855";
            dtm2.TimeCode_04 = "ET";
            rcdLoop.DTM.Add(dtm2);

            //  End RCD Loop
            result.RCDLoop.Add(rcdLoop);

            return result;
        }
    }
}
