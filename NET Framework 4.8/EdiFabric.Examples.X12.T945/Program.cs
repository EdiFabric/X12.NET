using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T945
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();
            Read();
            Write();
        }

        /// <summary>
        /// Read Warehouse Shipping Advice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\WarehouseShippingAdvice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS945>();

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
        /// Write Warehouse Shipping Advice
        /// </summary>
        static void Write()
        {
            var transaction = BuildWarehouseShippingAdvice("2");

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
        /// Builds warehouse shipping advice.
        /// Original from http://techsheets.simplot.com/EDI/945_FG_4010.pdf
        /// </summary>
        static TS945 BuildWarehouseShippingAdvice(string controlNumber)
        {
            var result = new TS945();

            //  Transaction Set Identifier Code = "945"
            //  (Receiving Advice / Acceptance Certificate)
            //  Transaction Set Control Number = 0002
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "945";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Warehouse Shipment Identification
            //  X = Reporting Code
            //  F = Full Detail
            //  12345 = Mfg.Order No.
            //  CCYYMMDD = Shipment Date
            //  123456 = PRO No.
            //  1234 = Bill of Lading No.
            //  01 = Stop Number
            //  9999 = Mfg.Master Order Number
            //  Z = Action Code
            //  1 = Add
            //  2 = Change
            result.W06 = new W06();
            result.W06.ReportingCode_01 = "X";
            result.W06.DepositorOrderNumber_02 = "12345";
            result.W06.Date_03 = "CCYYMMDD";
            result.W06.ShipmentIdentificationNumber_04 = "123456";
            result.W06.AgentShipmentIDNumber_05 = "1234";
            result.W06.MasterReferenceLinkNumber_07 = "01";
            result.W06.LinkSequenceNumber_08 = "9999";
            result.W06.ActionCode_12 = "Z";

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_945>();

            //  Begin N1 Loop
            var n1Loop1 = new Loop_N1_945();

            //  Name
            //  WH = Warehouse
            //  Warehouse Name = Actual Name
            //  XX = Warehouse Code Qualifier
            //  9 = DUNS + 4
            //  91 = Code assigned by Manufacturer
            //  123456 = Actual DUNS # or Code
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "WH";
            n1Loop1.N1.Name_02 = "Warehouse Name";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "9";
            n1Loop1.N1.IdentificationCode_04 = "123456";

            //  End N1 Loop
            result.N1Loop.Add(n1Loop1);

            //  Begin N2 Loop
            var n1Loop2 = new Loop_N1_945();

            //  Name
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "DE";
            n1Loop2.N1.Name_02 = "Depositor Name";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "9";
            n1Loop2.N1.IdentificationCode_04 = "0123456789000";

            //  End N1 Loop
            result.N1Loop.Add(n1Loop2);

            //  Repeating N9
            result.N9 = new List<N9>();

            //  Reference Identification 1
            //  SN = Reference Number Qualifier
            //  Seal Number = actual id number
            var n91 = new N9();
            n91.ReferenceIdentificationQualifier_01 = "SN";
            n91.ReferenceIdentification_02 = "Seal Number";
            result.N9.Add(n91);

            //  Reference Identification 2
            var n92 = new N9();
            n92.ReferenceIdentificationQualifier_01 = "ZZ";
            n92.ReferenceIdentification_02 = "Temperature Recording Device Number";
            result.N9.Add(n92);

            //  Carrier detail
            result.W27 = new W27();
            result.W27.TransportationMethodTypeCode_01 = "H";
            result.W27.StandardCarrierAlphaCode_02 = "TRUK";
            result.W27.Routing_03 = "TRUCKING";
            result.W27.ShipmentMethodofPayment_04 = "CC";
            result.W27.EquipmentNumber_07 = "Equipment ID";

            //  Details
            result.LXLoop = new List<Loop_LX_945>();

            //  Begin LX Loop 1
            var lxLoop1 = new Loop_LX_945();

            //  Line number 1
            lxLoop1.LX = new LX();
            lxLoop1.LX.AssignedNumber_01 = "1";

            //  Repeating W12 Loops
            lxLoop1.W12Loop = new List<Loop_W12_945>();

            //  Begin W12 Loop 
            var w12Loop1 = new Loop_W12_945();

            //  Item detail
            w12Loop1.W12 = new W12();
            w12Loop1.W12.ShipmentOrderStatusCode_01 = "CC";
            w12Loop1.W12.QuantityOrdered_02 = "72";
            w12Loop1.W12.NumberofUnitsShipped_03 = "72";
            w12Loop1.W12.UnitorBasisforMeasurementCode_05 = "CA";
            w12Loop1.W12.UPCCaseCode_06 = "007117901645";
            w12Loop1.W12.ProductServiceIDQualifier_07 = "UK";
            w12Loop1.W12.ProductServiceID_08 = "10071179016458";
            w12Loop1.W12.WarehouseLotNumber_09 = "40550";
            w12Loop1.W12.Weight_10 = "799";
            w12Loop1.W12.WeightQualifier_11 = "G";
            w12Loop1.W12.WeightUnitCode_12 = "L";

            //  Repeating G69
            w12Loop1.G69 = new List<G69>();

            //  Line item 1 detail description
            var g691 = new G69();
            g691.FreeformDescription_01 = "Some description";
            w12Loop1.G69.Add(g691);

            //  Repeating N9
            w12Loop1.N9 = new List<N9>();

            //  Reference Identification 1
            var n93 = new N9();
            n93.ReferenceIdentificationQualifier_01 = "LI";
            n93.ReferenceIdentification_02 = "1000";
            w12Loop1.N9.Add(n93);

            //  Reference Identification 2
            var n94 = new N9();
            n94.ReferenceIdentificationQualifier_01 = "PC";
            n94.ReferenceIdentification_02 = "989JAN281301";
            w12Loop1.N9.Add(n94);

            //  Reference Identification 3
            var n95 = new N9();
            n95.ReferenceIdentificationQualifier_01 = "LV";
            n95.ReferenceIdentification_02 = "00100752782101847618";
            n95.FreeformDescription_03 = "36";
            w12Loop1.N9.Add(n95);

            //  Reference Identification 4
            var n96 = new N9();
            n96.ReferenceIdentificationQualifier_01 = "LV";
            n96.ReferenceIdentification_02 = "00100752782101847619";
            n96.FreeformDescription_03 = "36";
            w12Loop1.N9.Add(n96);

            //  End W12 Loop
            lxLoop1.W12Loop.Add(w12Loop1);

            //  End LX Loop 1
            result.LXLoop.Add(lxLoop1);

            //  Begin LX Loop 2
            var lxLoop2 = new Loop_LX_945();

            //  Line number 1
            lxLoop2.LX = new LX();
            lxLoop2.LX.AssignedNumber_01 = "2";

            //  Repeating W12 Loops
            lxLoop2.W12Loop = new List<Loop_W12_945>();

            //  Begin W12 Loop 
            var w12Loop2 = new Loop_W12_945();

            //  Item detail
            w12Loop2.W12 = new W12();
            w12Loop2.W12.ShipmentOrderStatusCode_01 = "CC";
            w12Loop2.W12.QuantityOrdered_02 = "72";
            w12Loop2.W12.NumberofUnitsShipped_03 = "72";
            w12Loop2.W12.UnitorBasisforMeasurementCode_05 = "CA";
            w12Loop2.W12.UPCCaseCode_06 = "007117901645";
            w12Loop2.W12.ProductServiceIDQualifier_07 = "UK";
            w12Loop2.W12.ProductServiceID_08 = "10071179016458";
            w12Loop2.W12.WarehouseLotNumber_09 = "40551";
            w12Loop2.W12.Weight_10 = "884";
            w12Loop2.W12.WeightQualifier_11 = "G";
            w12Loop2.W12.WeightUnitCode_12 = "L";

            //  Repeating G69
            w12Loop2.G69 = new List<G69>();

            //  Line item 1 detail description
            var g697 = new G69();
            g697.FreeformDescription_01 = "Some description";
            w12Loop2.G69.Add(g697);

            //  Repeating N9
            w12Loop2.N9 = new List<N9>();

            //  Reference Identification 1
            var n98 = new N9();
            n98.ReferenceIdentificationQualifier_01 = "LI";
            n98.ReferenceIdentification_02 = "1000";
            w12Loop2.N9.Add(n98);

            //  Reference Identification 2
            var n99 = new N9();
            n99.ReferenceIdentificationQualifier_01 = "PC";
            n99.ReferenceIdentification_02 = "989JAN291301";
            w12Loop2.N9.Add(n99);

            //  Reference Identification 3
            var n910 = new N9();
            n910.ReferenceIdentificationQualifier_01 = "LV";
            n910.ReferenceIdentification_02 = "00100752782101847620";
            n910.FreeformDescription_03 = "72";
            w12Loop2.N9.Add(n910);

            //  End W12 Loop
            lxLoop2.W12Loop.Add(w12Loop2);

            //  End LX Loop 2
            result.LXLoop.Add(lxLoop2);

            //  Total shipment information
            result.W03 = new W03();
            result.W03.NumberofUnitsShipped_01 = "240"; //   Number of Units Shipped
            result.W03.Weight_02 = "15360"; //   Total Weight
            result.W03.UnitorBasisforMeasurementCode_03 = "LB"; //  Weight Unit of Measure

            return result;
        }
    }
}
