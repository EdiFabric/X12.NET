using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.X12;
using EdiFabric.Templates.X12;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Sdk.X12.T824
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Application Advice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\ApplicationAdvice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.TrialTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS824>();

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
        /// Write Application Advice
        /// </summary>
        static void Write()
        {
            var transaction = BuildApplicationAdvice("2");

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
        /// Builds Application Advice.
        /// Original from https://ps.nafta.extra.fcagroup.com/sites/itb-ebus/Shared%20Documents/824FreightConsolidatorApplicationAdvice.pdf
        /// </summary>
        static TS824 BuildApplicationAdvice(string controlNumber)
        {
            var result = new TS824();

            //  Transaction Set Identifier Code
            //  = “824” (Application Acknowlegment Advice)
            //  Transaction Set Control Number = 0002
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "824";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Transaction Set Purpose Code
            //  = “11” (Response)
            //  Reference Number = 3
            //  Date = 09 / 02 / 2012
            //  Time = 4:21 PM
            result.BGN = new BGN();
            result.BGN.TransactionSetPurposeCode_01 = "11";
            result.BGN.ReferenceIdentification_02 = "3";
            result.BGN.Date_03 = "120902";
            result.BGN.Time_04 = "1621";

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_824>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_824();

            //  Entity Identifier Code
            //  = “SU” (Supplier / Manufacturer)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer)
            //  Identification Code = 42332AB
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SU";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop1.N1.IdentificationCode_04 = "42332AB";

            //  End N1 Loop 1
            result.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_824();

            //  Entity Identifier Code = “SF” (Ship From)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer)
            //  Identification Code = 42332AF
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "SF";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop2.N1.IdentificationCode_04 = "42332A";

            //  End N1 Loop 2
            result.N1Loop.Add(n1Loop2);

            //  Begin N1 Loop 3
            var n1Loop3 = new Loop_N1_824();

            //  Entity Identifier Code = “ST” (Ship To)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer)
            //  Identification Code = 04025
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "ST";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop3.N1.IdentificationCode_04 = "04025";

            //  End N1 Loop 3
            result.N1Loop.Add(n1Loop3);

            //  Begin N1 Loop 4
            var n1Loop4 = new Loop_N1_824();

            //  Entity Identifier Code = “MA”
            //  (Party for whom Item is Ultimately Intended)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer)
            //  Identification Code = 04025
            n1Loop4.N1 = new N1();
            n1Loop4.N1.EntityIdentifierCode_01 = "MA";
            n1Loop4.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop4.N1.IdentificationCode_04 = "04025";

            //  End N1 Loop 4
            result.N1Loop.Add(n1Loop4);

            //  Begin N1 Loop 5
            var n1Loop5= new Loop_N1_824();

            //  Entity Identifier Code = “CS” (Consolidator)
            //  Identification Code Qualifier
            //  = “92” (Assigned by Buyer)
            //  Identification Code = 01123
            n1Loop5.N1 = new N1();
            n1Loop5.N1.EntityIdentifierCode_01 = "CS";
            n1Loop5.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop5.N1.IdentificationCode_04 = "01123";

            //  End N1 Loop 5
            result.N1Loop.Add(n1Loop5);

            //  Repeating OTI Loops
            result.OTILoop = new List<Loop_OTI_824>();

            //  Begin OTI Loop
            var otiLoop1 = new Loop_OTI_824();

            //  Application Acknowledgment Code
            //  = “IR” (Line item rejected)
            //  Reference Number Qualifier = “SI” (Shipper's
            //  Identifying Number for Shipment<SID>)
            //  Reference Number = 62001
            //  Transaction Set Identifier Code
            //  = “856” (X12.10 Ship Notice/ Manifest) 
            otiLoop1.OTI = new OTI();
            otiLoop1.OTI.ApplicationAcknowledgmentCode_01 = "IR";
            otiLoop1.OTI.ReferenceIdentificationQualifier_02 = "SI";
            otiLoop1.OTI.ReferenceIdentification_03 = "62001";
            otiLoop1.OTI.TransactionSetIdentifierCode_10 = "856";

            //  Repeating REF
            otiLoop1.REF = new List<REF>();

            //  Reference Number Qualifier
            //  = “BM” (Bill of Lading Number)
            //  Reference Number = 62001
            var ref1 = new REF();
            ref1.ReferenceIdentificationQualifier_01 = "BM";
            ref1.ReferenceIdentification_02 = "62001";
            otiLoop1.REF.Add(ref1);

            //  Reference Number Qualifier
            //  = “PK” (Packing List Number)
            //  Reference Number = 87115
            var ref2 = new REF();
            ref2.ReferenceIdentificationQualifier_01 = "PK";
            ref2.ReferenceIdentification_02 = "87115";
            otiLoop1.REF.Add(ref2);

            //  Reference Number Qualifier = “CN”
            //  (Carrier's Reference Number <PRO/Invoice>)
            //  Reference Number = 506013
            var ref3 = new REF();
            ref3.ReferenceIdentificationQualifier_01 = "CN";
            ref3.ReferenceIdentification_02 = "506013";
            otiLoop1.REF.Add(ref3);

            //  Reference Number Qualifier
            //  = “TB” (Trucker's Bill of Lading)
            //  Reference Number = 01178
            var ref4 = new REF();
            ref4.ReferenceIdentificationQualifier_01 = "TB";
            ref4.ReferenceIdentification_02 = "01178";
            otiLoop1.REF.Add(ref4);

            //  Reference Number Qualifier
            //  = “PM” (Part Number)
            //  Reference Number = 05440113AA
            var ref5 = new REF();
            ref5.ReferenceIdentificationQualifier_01 = "PM";
            ref5.ReferenceIdentification_02 = "05440113AA";
            otiLoop1.REF.Add(ref5);

            //  Repeating DTM
            otiLoop1.DTM = new List<DTM>();

            //  Date/Time Qualifier = “009” (Process)
            //  Date = 09 / 01 / 2012
            //  Time = 4:21 PM
            //  Time Code = “ET” (Eastern Time) 
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "009";
            dtm1.Date_02 = "120901";
            dtm1.Time_03 = "1621";
            dtm1.TimeCode_04 = "ET";
            otiLoop1.DTM.Add(dtm1);

            //  Date/Time Qualifier = “011” (Shipped)
            //  Date = 09 / 01 / 2012
            var dtm2 = new DTM();
            dtm2.DateTimeQualifier_01 = "011";
            dtm2.Date_02 = "120901";
            otiLoop1.DTM.Add(dtm2);

            //  Repeating TED Loops
            otiLoop1.TEDLoop = new List<Loop_TED_824>();

            //  Begin TED Loop
            var tedLoop1 = new Loop_TED_824();

            //  Application Error Condition = 201
            //  Free Form Message
            //  = ASN - PART / PLANT / SUPLR
            //  Copy of Bad Data Element
            //  = 05440113AA0622137052
            tedLoop1.TED = new TED();
            tedLoop1.TED.ApplicationErrorConditionCode_01 = "201";
            tedLoop1.TED.FreeFormMessage_02 = "ASN-PART/PLANT/SUPLR";
            tedLoop1.TED.CopyofBadDataElement_07 = "05440113AA0622137052";

            //  Repeating NTE
            tedLoop1.NTE = new List<NTE>();

            //  Note Reference Code = “LIN” (Line Item)
            //  Free Form Message = INVALID PART / PLANT
            //  SUPPLIER COMBINATIO
            var nte1 = new NTE();
            nte1.NoteReferenceCode_01 = "LIN";
            nte1.Description_02 = "INVALID PART/PLANT SUPPLIER COMBINATIO";
            tedLoop1.NTE.Add(nte1);

            //  End TED Loop
            otiLoop1.TEDLoop.Add(tedLoop1);

            //  End OTI Loop
            result.OTILoop.Add(otiLoop1);

            return result;
        }
    }
}
