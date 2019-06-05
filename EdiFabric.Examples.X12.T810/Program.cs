using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T810
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Invoices
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\Invoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS810>();

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
        /// Write Invoices
        /// </summary>
        static void Write()
        {
            var transaction = BuildInvoice("1");

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
        /// Build invoice.
        /// Original example from http://www.x12.org/examples/004010X348/basic-invoice/
        /// </summary>
        public static TS810 BuildInvoice(string controlNumber)
        {
            var result = new TS810();

            //  Indicates the start of an invoice transaction set and assigns a control number.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "810";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Indicates the invoice was created on May 13, 2000 and assigned invoice number SG427254. 
            //  The invoice is in response to a purchase order sent on May 6, 2000 with purchase order number 508517 and release number 1001.
            result.BIG = new BIG();
            result.BIG.Date_01 = "20000513";
            result.BIG.InvoiceNumber_02 = "SG427254";
            result.BIG.Date_03 = "20000506";
            result.BIG.PurchaseOrderNumber_04 = "508517";
            result.BIG.ReleaseNumber_05 = "1001";

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_810>();

            //  Begin N1 Loop
            var n1Loop = new Loop_N1_810();

            //  Indicates that the ship to party is ABC Aerospace Corporation. ABC's D-U-N-S+4 number is 123456789-0101.
            n1Loop.N1 = new N1();
            n1Loop.N1.EntityIdentifierCode_01 = "ST";
            n1Loop.N1.Name_02 = "ABC AEROSPACE CORPORATION";
            n1Loop.N1.IdentificationCodeQualifier_03 = "9";
            n1Loop.N1.IdentificationCode_04 = "123456789-0101";

            //  Repeating N3
            n1Loop.N3 = new List<N3>();

            //  The ship to party's street address is 1000 Boardwalk Drive.
            var n3 = new N3();
            n3.AddressInformation_01 = "1000 BOARDWALK DRIVE";
            n1Loop.N3.Add(n3);

            //  The ship to party's city, state, and ZIP is Somewhere, CA 98898.
            n1Loop.N4 = new N4();
            n1Loop.N4.CityName_01 = "SOMEWHERE";
            n1Loop.N4.StateorProvinceCode_02 = "CA";
            n1Loop.N4.PostalCode_03 = "98898";

            //  End N1 Loop
            result.N1Loop.Add(n1Loop);

            //  Repeating ITD
            result.ITD = new List<ITD>();

            //  Indicates that discounts are not applicable, the terms period is the invoice date, and the net days due is 30 days using an electronic payment system.
            var itd = new ITD();
            itd.TermsTypeCode_01 = "05";
            itd.TermsBasisDateCode_02 = "3";
            itd.TermsNetDays_07 = "30";
            itd.PaymentMethodCode_14 = "E";
            result.ITD.Add(itd);

            //  Repeating IT1 Loops
            result.IT1Loop = new List<Loop_IT1_810>();

            //  Begin IT1 Loop
            var it1Loop = new Loop_IT1_810();

            //  Indicates that the purchase order's line number was 1. The invoice is for 48 units costing $3.00 each for manufacturer's part number R5656-2.
            it1Loop.IT1 = new IT1();
            it1Loop.IT1.AssignedIdentification_01 = "1";
            it1Loop.IT1.QuantityInvoiced_02 = "48";
            it1Loop.IT1.UnitorBasisforMeasurementCode_03 = "EA";
            it1Loop.IT1.UnitPrice_04 = "3";
            it1Loop.IT1.ProductServiceIDQualifier_06 = "MG";
            it1Loop.IT1.ProductServiceID_07 = "R5656-2";

            //  End IT1 Loop
            result.IT1Loop.Add(it1Loop);

            //  Indicates that the total invoice amount is $144.00.
            result.TDS = new TDS();
            result.TDS.Amount_01 = "14400";

            //  Indicates that the invoice contained 1 line item.
            result.CTT = new CTT();
            result.CTT.NumberofLineItems_01 = "1";

            return result;
        }
    }
}
