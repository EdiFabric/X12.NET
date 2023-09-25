using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T857
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }
            Read();
            Write();
        }

        /// <summary>
        /// Read Ship Bill Notice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\ShipBillNotice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS857>();

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
        /// Write Ship Bill Notice
        /// </summary>
        static void Write()
        {
            var transaction = BuildShipBillNotice("000012103");

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
        /// Builds ship bill notice.
        /// Original from http://www.bergware.net/bisacwww/857_3060.htm
        /// </summary>
        static TS857 BuildShipBillNotice(string controlNumber)
        {
            var result = new TS857();

            //  Transaction 857 
            //  Set control number 12103
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "857";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Hierarchical structure code 0001 
            //  Original transaction set
            //  Ship date of 01 / 10 / 98
            result.BHT = new BHT();
            result.BHT.HierarchicalStructureCode_01 = "0001";
            result.BHT.TransactionSetPurposeCode_02 = "00";
            result.BHT.Date_04 = "980110";

            //  Repeating HL Loops
            result.HLLoop = new List<Loop_HL_857>();

            //  Begin HL Loop 1
            var hlLoop1 = new Loop_HL_857();

            //  Hierarchical level 1 shipment
            hlLoop1.HL = new HL();
            hlLoop1.HL.HierarchicalIDNumber_01 = "1";
            hlLoop1.HL.HierarchicalLevelCode_03 = "S";

            //  Begin G05 Loop 1
            hlLoop1.G05Loop = new Loop_G05_857();

            //  3 shipped units
            hlLoop1.G05Loop.G05 = new G05();
            hlLoop1.G05Loop.G05.NumberofUnitsShipped_01 = "3";
            hlLoop1.G05Loop.G05.UnitorBasisforMeasurementCode_02 = "UN";

            //  Repeating DTM
            hlLoop1.G05Loop.DTM = new List<DTM>();

            //  Ship date of 
            //  01 / 10 / 98
            //  Century designation of 19
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "011";
            dtm1.Date_02 = "980110";
            dtm1.DateTimePeriodFormatQualifier_05 = "19";
            hlLoop1.G05Loop.DTM.Add(dtm1);

            //  Repeating N1 G05 Loops
            hlLoop1.G05Loop.N1Loop = new List<Loop_N1_857>();

            //  Begin N1 G05 Loop 1
            var n1Loop1 = new Loop_N1_857();

            //  Ship from 
            //  SAN
            //  216793X
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SF";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "15";
            n1Loop1.N1.IdentificationCode_04 = "216793X";

            //  End N1 G05 Loop 1
            hlLoop1.G05Loop.N1Loop.Add(n1Loop1);

            //  Begin N1 G05 Loop 2
            var n1Loop2 = new Loop_N1_857();

            //  Ship to 
            //  SAN
            //  6678157
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "ST";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "15";
            n1Loop2.N1.IdentificationCode_04 = "6678157";

            //  End N1 G05 Loop 2
            hlLoop1.G05Loop.N1Loop.Add(n1Loop2);

            //  Begin N1 G05 Loop 3
            var n1Loop3 = new Loop_N1_857();

            //  Bill to 
            //  SAN
            //  1135309
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "BT";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "15";
            n1Loop3.N1.IdentificationCode_04 = "1135309";

            //  End N1 G05 Loop 3
            hlLoop1.G05Loop.N1Loop.Add(n1Loop3);

            //  Begin N1 G05 Loop 4
            var n1Loop4 = new Loop_N1_857();

            //  Vendor 
            //  SAN
            //  2002450
            n1Loop4.N1 = new N1();
            n1Loop4.N1.EntityIdentifierCode_01 = "VN";
            n1Loop4.N1.IdentificationCodeQualifier_03 = "15";
            n1Loop4.N1.IdentificationCode_04 = "2002450";

            //  End N1 G05 Loop 4
            hlLoop1.G05Loop.N1Loop.Add(n1Loop4);

            //  End G05 Loop 1

            //  End HL Loop 1
            result.HLLoop.Add(hlLoop1);

            //  Begin HL Loop 2
            var hlLoop2 = new Loop_HL_857();

            //  Hierarchical level 2 order
            hlLoop2.HL = new HL();
            hlLoop2.HL.HierarchicalIDNumber_01 = "2";
            hlLoop2.HL.HierarchicalLevelCode_03 = "O";

            //  Begin TDS Loop
            hlLoop2.TDSLoop = new Loop_TDS_857();

            //  Total invoice before discount
            //  is applied is $3,837.50
            //  Amount subject to Terms
            //  discount is $3,837.50
            //  Discounted amount due
            //  is $2,187.36
            hlLoop2.TDSLoop.TDS = new TDS();
            hlLoop2.TDSLoop.TDS.Amount_01 = "383750";
            hlLoop2.TDSLoop.TDS.Amount_02 = "383750";
            hlLoop2.TDSLoop.TDS.Amount_03 = "218736";

            //  Purchase order number 
            //  012323456789123
            //  Purchase order date
            //  of 01 / 06 / 98
            hlLoop2.TDSLoop.PRF = new PRF();
            hlLoop2.TDSLoop.PRF.PurchaseOrderNumber_01 = "0123456789123";
            hlLoop2.TDSLoop.PRF.ChangeOrderSequenceNumber_03 = "980106";

            //  End TDS Loop

            //  End HL Loop 2
            result.HLLoop.Add(hlLoop2);

            //  Begin HL Loop 3
            var hlLoop3 = new Loop_HL_857();

            //  Hierarchical level 3 pack
            hlLoop3.HL = new HL();
            hlLoop3.HL.HierarchicalIDNumber_01 = "3";
            hlLoop3.HL.HierarchicalLevelCode_03 = "P";

            //  Begin LX Loop
            hlLoop3.LXLoop = new Loop_LX_857();

            //  Loop start. Mandatory segment 
            hlLoop3.LXLoop.LX = new LX();
            hlLoop3.LXLoop.LX.AssignedNumber_01 = "1";

            //  Repeating MAN
            hlLoop3.LXLoop.MAN = new List<MAN>();

            //  UCC/EAN-128 Serial shipping 
            //  container code format.
            //  Marks and numbers used to
            //  identify the carton
            //  00097800006400000012
            var man1 = new MAN();
            man1.MarksandNumbersQualifier_01 = "GM";
            man1.MarksandNumbers_02 = "00097800006400000012";
            hlLoop3.LXLoop.MAN.Add(man1);

            //  End LX Loop

            //  End HL Loop 3
            result.HLLoop.Add(hlLoop3);

            //  Begin HL Loop 4
            var hlLoop4 = new Loop_HL_857();

            //  Hierarchical level 4 item
            hlLoop4.HL = new HL();
            hlLoop4.HL.HierarchicalIDNumber_01 = "4";
            hlLoop4.HL.HierarchicalLevelCode_03 = "I";

            //  Begin IT1 Loop
            hlLoop4.IT1Loop = new Loop_IT1_857();

            //  Line item 1 
            //  Shipped 2
            //  units
            //  at $8.40
            //  for each unit
            //  ISBN
            //  0835201031
            hlLoop4.IT1Loop.IT1 = new IT1();
            hlLoop4.IT1Loop.IT1.AssignedIdentification_01 = "1";
            hlLoop4.IT1Loop.IT1.QuantityInvoiced_02 = "2";
            hlLoop4.IT1Loop.IT1.UnitorBasisforMeasurementCode_03 = "UN";
            hlLoop4.IT1Loop.IT1.UnitPrice_04 = "8.4";
            hlLoop4.IT1Loop.IT1.BasisofUnitPriceCode_05 = "PE";
            hlLoop4.IT1Loop.IT1.ProductServiceIDQualifier_06 = "IB";
            hlLoop4.IT1Loop.IT1.ProductServiceID_07 = "0835201031";

            //  Repeating CTP
            hlLoop4.IT1Loop.CTP = new List<CTP>();

            //  Suggested list price of 
            //  $10.50
            //  Discount
            //  multiplier of .8
            //  (100 % -80 % = 20 % discount)
            var ctp1 = new CTP();
            ctp1.PriceIdentifierCode_02 = "SLP";
            ctp1.UnitPrice_03 = "10.5";
            ctp1.PriceMultiplierQualifier_06 = "DIS";
            ctp1.Multiplier_07 = ".8";
            hlLoop4.IT1Loop.CTP.Add(ctp1);

            //  End IT1 Loop

            //  End HL Loop 4
            result.HLLoop.Add(hlLoop4);

            //  Begin HL Loop 5
            var hlLoop5 = new Loop_HL_857();

            //  Hierarchical level 5 item
            hlLoop5.HL = new HL();
            hlLoop5.HL.HierarchicalIDNumber_01 = "5";
            hlLoop5.HL.HierarchicalLevelCode_03 = "I";

            //  Begin IT1 Loop
            hlLoop5.IT1Loop = new Loop_IT1_857();

            //  Line item 2 
            //  Shipped 1
            //  unit
            //  at $24.00
            //  per each unit
            //  ISBN
            //  0835208338
            hlLoop5.IT1Loop.IT1 = new IT1();
            hlLoop5.IT1Loop.IT1.AssignedIdentification_01 = "2";
            hlLoop5.IT1Loop.IT1.QuantityInvoiced_02 = "1";
            hlLoop5.IT1Loop.IT1.UnitorBasisforMeasurementCode_03 = "UN";
            hlLoop5.IT1Loop.IT1.UnitPrice_04 = "24";
            hlLoop5.IT1Loop.IT1.BasisofUnitPriceCode_05 = "PE";
            hlLoop5.IT1Loop.IT1.ProductServiceIDQualifier_06 = "IB";
            hlLoop5.IT1Loop.IT1.ProductServiceID_07 = "0835208338";

            //  Repeating CTP
            hlLoop5.IT1Loop.CTP = new List<CTP>();

            //  Suggested list price of 
            //  $30.00
            //  Discount
            //  multiplier of .8
            //  (100 % -80 % = 20 % discount)
            var ctp2 = new CTP();
            ctp2.PriceIdentifierCode_02 = "SLP";
            ctp2.UnitPrice_03 = "30";
            ctp2.PriceMultiplierQualifier_06 = "DIS";
            ctp2.Multiplier_07 = ".8";
            hlLoop5.IT1Loop.CTP.Add(ctp2);

            //  End IT1 Loop

            //  End HL Loop 5
            result.HLLoop.Add(hlLoop5);

            return result;
        }
    }
}
