using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T855
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);
            Read();
            Write();
        }

        /// <summary>
        /// Read Purchase Orders Acknowledgement
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\PurchaseOrdersAcknowledgement.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS855>();

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
        /// Write Purchase Orders Acknowledgement
        /// </summary>
        static void Write()
        {
            var transaction = BuildPurchaseOrdersAcknowledgement("5");

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
        /// Builds Purchase Orders Acknowledgement.
        /// Original from http://www.jobisez.com/edi/tp/guide.aspx?doc=/edi-igs/Kohls/edi_855.pdf
        /// </summary>
        static TS855 BuildPurchaseOrdersAcknowledgement(string controlNumber)
        {
            var result = new TS855();

            //  855 is the Transaction Set Identifier Code for the Purchase Orders Acknowledgement
            //  0001 is the Transaction Set Control Number
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "855";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');


            //  Purchase Order Number 1234567
            //  Purchase Order Date 01 / 02 / 05            
            result.BAK = new BAK();
            result.BAK.TransactionSetPurposeCode_01 = "16";
            result.BAK.AcknowledgmentType_02 = "AP";
            result.BAK.PurchaseOrderNumber_03 = "1234567";
            result.BAK.Date_04 = "20050102";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Scheduled Ship Date 02 / 03 / 05
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "068";
            dtm1.Date_02 = "20050203";
            result.DTM.Add(dtm1);

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_855>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_855();

            //  Vendor Name XYZ MANUFACTURING CO
            //  Vendor DUNS 987654321
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SF";
            n1Loop1.N1.Name_02 = "XYZ MANUFACTURING CO";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "01";
            n1Loop1.N1.IdentificationCode_04 = "987654321";

            //  End N1 Loop 1
            result.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_855();

            //  Ship to Distribution Center 0085 in Menomonee Falls WI
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "ST";
            n1Loop2.N1.Name_02 = "KOHLS DEPARTMENT STORES";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop2.N1.IdentificationCode_04 = "0085";

            //  End N1 Loop 2
            result.N1Loop.Add(n1Loop2);

            //  Repeating PO1 Loops
            result.PO1Loop = new List<Loop_PO1_855>();

            //  Begin PO1 Loop 1
            var po1Loop1 = new Loop_PO1_855();

            //  UPC 1-23456-78901-2
            //  Quantity Ordered 3(Each)
            //  Kohl’s SKU NONE
            //  Vendor Style BLU89Z012
            //  NRMA Color Code(CM) 123
            //  Vendor Color(VE) BLUESKY
            //  NRMA Size Code(SM) 12345
            //  Vendor Size(SZ) W32XL34
            po1Loop1.PO1 = new PO1();
            po1Loop1.PO1.AssignedIdentification_01 = "000001";
            po1Loop1.PO1.QuantityOrdered_02 = "3";
            po1Loop1.PO1.UnitorBasisforMeasurementCode_03 = "EA";
            po1Loop1.PO1.ProductServiceIDQualifier_06 = "UP";
            po1Loop1.PO1.ProductServiceID_07 = "123456789012";
            po1Loop1.PO1.ProductServiceIDQualifier_08 = "VA";
            po1Loop1.PO1.ProductServiceID_09 = "BLU89Z012";
            po1Loop1.PO1.ProductServiceIDQualifier_10 = "CM";
            po1Loop1.PO1.ProductServiceID_11 = "123";
            po1Loop1.PO1.ProductServiceIDQualifier_12 = "SM";
            po1Loop1.PO1.ProductServiceID_13 = "12345";

            //  End PO1 Loop 1
            result.PO1Loop.Add(po1Loop1);

            //  Begin PO1 Loop 2
            var po1Loop2 = new Loop_PO1_855();

            //   UPC 1-23456-79812-3
            //   Quantity Ordered 5(Each)
            //   Kohl’s SKU NONE
            //   Vendor Style BLK98A023
            //   NRMA Color Code(CM) 321
            //   Vendor Color(VE) BLACK - COAL
            //   NRMA Size Code(SM) 12345
            //   Vendor Size(SZ) W32XL34
            po1Loop2.PO1 = new PO1();
            po1Loop2.PO1.AssignedIdentification_01 = "000002";
            po1Loop2.PO1.QuantityOrdered_02 = "5";
            po1Loop2.PO1.UnitorBasisforMeasurementCode_03 = "EA";
            po1Loop2.PO1.ProductServiceIDQualifier_06 = "UP";
            po1Loop2.PO1.ProductServiceID_07 = "123456798123";
            po1Loop2.PO1.ProductServiceIDQualifier_08 = "VA";
            po1Loop2.PO1.ProductServiceID_09 = "BLK98A023";
            po1Loop2.PO1.ProductServiceIDQualifier_10 = "CM";
            po1Loop2.PO1.ProductServiceID_11 = "321";
            po1Loop2.PO1.ProductServiceIDQualifier_12 = "SM";
            po1Loop2.PO1.ProductServiceID_13 = "12345";

            //  End PO1 Loop 2
            result.PO1Loop.Add(po1Loop2);

            //  Begin PO1 Loop 3
            var po1Loop3 = new Loop_PO1_855();

            //  UPC 9-99988-88800-1
            //  Quantity Ordered 1(Each)
            //  Kohl’s SKU NONE
            //  Vendor Style 981RACK
            //  NRMA Color Code(CM) NONE
            //  Vendor Color(VE) NONE
            //  NRMA Size Code(SM) NONE
            //  Vendor Size(SZ) NONE
            po1Loop3.PO1 = new PO1();
            po1Loop3.PO1.AssignedIdentification_01 = "000003";
            po1Loop3.PO1.QuantityOrdered_02 = "1";
            po1Loop3.PO1.UnitorBasisforMeasurementCode_03 = "EA";
            po1Loop3.PO1.ProductServiceIDQualifier_06 = "UP";
            po1Loop3.PO1.ProductServiceID_07 = "999988888001";
            po1Loop3.PO1.ProductServiceIDQualifier_08 = "VA";
            po1Loop3.PO1.ProductServiceID_09 = "981RACK";

            //  End PO1 Loop 3
            result.PO1Loop.Add(po1Loop3);

            //  3 is the Number of Items
            result.CTTLoop = new Loop_CTT_855();
            result.CTTLoop.CTT = new CTT();
            result.CTTLoop.CTT.NumberofLineItems_01 = "3";

            return result;
        }
    }
}
