using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T856
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
        /// Read Ship Notice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\ShipNotice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS856>();

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
        /// Write Ship Notice
        /// </summary>
        static void Write()
        {
            var transaction = BuildShipNotice("1");

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
        /// Builds ship notice.
        /// Original from http://www.jobisez.com/edi/tp/guide.aspx?doc=/edi-igs/Walmart/856ASNDSDC5010.pdf
        /// </summary>
        static TS856 BuildShipNotice(string controlNumber)
        {
            var result = new TS856();

            //  856 is the Transaction Set Identifier Code for the Advance Ship Notice
            //  0001 is the Transaction Set Control Number
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "856";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  00 is the Transaction Set Purpose Code "00" indicates Original.
            //  01140824 is the Shipment Identification Number.
            //  20051015 is the Document Creation Date.
            //  1345 is the Time.
            //  0001 is the Hierarchical Structure. "0001" indicates "Pick and Pack Structure". 
            result.BSN = new BSN();
            result.BSN.TransactionSetPurposeCode_01 = "00";
            result.BSN.ShipmentIdentification_02 = "01140824";
            result.BSN.Date_03 = "20051015";
            result.BSN.Time_04 = "1345";
            result.BSN.HierarchicalStructureCode_05 = "0001";

            //  Repeating HL Loops
            result.HLLoop = new List<Loop_HL_856>();

            //  Begin HL Loop 1
            var hlLoop1 = new Loop_HL_856();

            //  1 is Hierarchical ID Number.
            //  S is the Hierarchical Level Code. “S” indicates "Shipment".
            //  This HL is the first HL used, and has no parent to identify.
            hlLoop1.HL = new HL();
            hlLoop1.HL.HierarchicalIDNumber_01 = "1";
            hlLoop1.HL.HierarchicalLevelCode_03 = "S";

            //  Repeating TD1
            hlLoop1.TD1 = new List<TD1>();

            //  CTN25 is Packaging Code. “CTN” indicates “Carton”, and “25” indicates “Corrugated or Solid”.
            //  2 is the Lading Quantity.
            //  G is the Weight Qualifier. “G” indicates "Gross Weight".
            //  45582 is the Weight (Gross).
            //  LB is the Unit or Basis for Measurement Code. “LB” indicates “Pound”.
            //  1000 is the Volume (Gross).
            //  CF is the Unit or Basis for Measurement Code. “CF” indicates “Cubic Feet”. 
            var td11 = new TD1();
            td11.PackagingCode_01 = "CTN25";
            td11.LadingQuantity_02 = "2";
            td11.WeightQualifier_06 = "G";
            td11.Weight_07 = "45582";
            td11.UnitorBasisforMeasurementCode_08 = "LB";
            td11.Volume_09 = "1000";
            td11.UnitorBasisforMeasurementCode_10 = "CF";
            hlLoop1.TD1.Add(td11);

            //  Repeating TD5
            hlLoop1.TD5 = new List<TD5>();

            //  B is the Routing Sequence Code. “B” indicates "Origin/Delivery Carrier (Any Mode)".
            //  2 is the Identification Code Qualifier. “2” indicates “Standard Carrier Alpha Code(SCAC)”.
            //  JBHT is the Identification Code(SCAC).Indicates the carrier JB Hunt.
            //  M is the Transportation Method / Type Code. “M” indicates “Motor(Common Carrier)”. 
            var td51 = new TD5();
            td51.RoutingSequenceCode_01 = "B";
            td51.IdentificationCodeQualifier_02 = "2";
            td51.IdentificationCode_03 = "JBHT";
            td51.TransportationMethodTypeCode_04 = "M";
            hlLoop1.TD5.Add(td51);

            //  Repeating TD3
            hlLoop1.TD3 = new List<TD3>();

            //  TL is the Equipment Description Code. “TL” indicates Trailer.
            //  ABCD is the Equipment Initial
            //  07213567 is the Equipment Number
            //  30394938483234 is the Seal Number.This is a unique number on seal used to close a shipment. 
            var td31 = new TD3();
            td31.EquipmentDescriptionCode_01 = "TL";
            td31.EquipmentInitial_02 = "ABCD";
            td31.EquipmentNumber_03 = "07213567";
            td31.SealNumber_09 = "30394938483234";
            hlLoop1.TD3.Add(td31);

            //  Repeating REF
            hlLoop1.REF = new List<REF>();

            //  BM is the Reference Identification Qualifier. “BM” indicates “Bill of Lading Number”.
            //  01140824 is the Reference Identification
            var ref1 = new REF();
            ref1.ReferenceIdentificationQualifier_01 = "BM";
            ref1.ReferenceIdentification_02 = "01140824";
            hlLoop1.REF.Add(ref1);

            //  CN is the Reference Identification Qualifier “CN” indicates the Carrier PRO Tracking Number.
            //  082131 is the Reference Identification
            var ref2 = new REF();
            ref2.ReferenceIdentificationQualifier_01 = "CN";
            ref2.ReferenceIdentification_02 = "082131";
            hlLoop1.REF.Add(ref2);

            //  CR is the Reference Identification Qualifier “CR” indicates the Customer Reference Number(Wal - Mart Load Number).
            //  01082131 is the Reference Identification
            var ref3 = new REF();
            ref3.ReferenceIdentificationQualifier_01 = "CR";
            ref3.ReferenceIdentification_02 = "01082131";
            hlLoop1.REF.Add(ref3);

            //  Repeating DTM
            hlLoop1.DTM = new List<DTM>();

            //  011 is the Date/Time Qualifier “011” indicates the “Date Shipped”
            //  20051015 is the Date (Shipped)
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "011";
            dtm1.Date_02 = "200";
            hlLoop1.DTM.Add(dtm1);

            //  Repeating N1 Loops
            hlLoop1.N1Loop = new List<Loop_N1_856>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_856();

            //  ST is the Entity Identifier Code. “ST” indicates “Ship To”.
            //  WAL - MART DC 6094J - JIT is the Name (Ship To).
            //  UL is the Identification Code Qualifier. “UL” indicates
            //  “Global Location Number(GLN)”.
            //  0078742035260 is the Identification Code(GLN).
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "ST";
            n1Loop1.N1.Name_02 = "WAL-MART DC 6094J-JIT";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "UL";
            n1Loop1.N1.IdentificationCode_04 = "0078742035260";

            //  End N1 Loop 1
            hlLoop1.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_856();

            //  SF is the Entity Identifier Code (Ship From)
            //  SUPPLIER NAME is the Name. 
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "SF";
            n1Loop2.N1.Name_02 = "SUPPLIER NAME";

            //  End N1 Loop 2
            hlLoop1.N1Loop.Add(n1Loop2);

            //  End HL Loop 1
            result.HLLoop.Add(hlLoop1);

            //  Begin HL Loop 2
            var hlLoop2 = new Loop_HL_856();

            //  2 is the Hierarchical ID Number.
            //  1 is the Hierarchical Parent ID Number. (Shipment)
            //  O is the Hierarchical Level Code. “O” indicates “Order”
            hlLoop2.HL = new HL();
            hlLoop2.HL.HierarchicalIDNumber_01 = "2";
            hlLoop2.HL.HierarchicalParentIDNumber_02 = "1";
            hlLoop2.HL.HierarchicalLevelCode_03 = "O";

            //  9988776655 the Purchase Order Number.
            //  20051015 is the Date (Purchase Order Date). 
            hlLoop2.PRF = new PRF();
            hlLoop2.PRF.PurchaseOrderNumber_01 = "9988776655";
            hlLoop2.PRF.Date_04 = "20051015";

            //  Repeating REF
            hlLoop2.REF = new List<REF>();

            //  IA is the Reference Identification Qualifier. “IA” indicates
            //  “Internal Vendor Number”.
            //  211555050 is the Reference Identification
            var ref4 = new REF();
            ref4.ReferenceIdentificationQualifier_01 = "IA";
            ref4.ReferenceIdentification_02 = "211555050";
            hlLoop2.REF.Add(ref4);

            //  DP is the Reference Identification Qualifier. “DP” indicates
            //  “Department Number”.
            //  00005 is the Reference Identification(Wal - Mart Department
            //  Number).
            var ref5 = new REF();
            ref5.ReferenceIdentificationQualifier_01 = "DP";
            ref5.ReferenceIdentification_02 = "00005";
            hlLoop2.REF.Add(ref5);

            //  MR is the Reference Identification Qualifier. “MR” indicates
            //  “Merchandise Type Code”.
            //  0073 is the Reference Identification
            var ref6 = new REF();
            ref6.ReferenceIdentificationQualifier_01 = "MR";
            ref6.ReferenceIdentification_02 = "0073";
            hlLoop2.REF.Add(ref6);

            //  IV is the Reference Identification Qualifier. “IV” indicates
            //  “Seller’s Invoice Number”.
            //  01140824 is the Reference Identification
            var ref7 = new REF();
            ref7.ReferenceIdentificationQualifier_01 = "IV";
            ref7.ReferenceIdentification_02 = "01140824";
            hlLoop2.REF.Add(ref7);

            //  Repeating N1 Loops
            hlLoop2.N1Loop = new List<Loop_N1_856>();

            //  Begin N1 Loop 1
            var n1Loop3 = new Loop_N1_856();

            //  BY is the Entity Identifier Code. “BY” indicates “Buying
            //  Party(Purchaser)”.
            //  WAL - MART STORES, INC. is the Name.
            //  UL is the Identification Code Qualifier. “UL” indicates
            //  “Global Location Number(GLN)”.
            //  0078742000992 is the Identification Code(GLN).
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "BY";
            n1Loop3.N1.Name_02 = "WAL-MART STORES,INC.";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "UL";
            n1Loop3.N1.IdentificationCode_04 = "0078742000992";

            //  End N1 Loop 1
            hlLoop2.N1Loop.Add(n1Loop3);

            //  End HL Loop 2
            result.HLLoop.Add(hlLoop2);

            //  Begin HL Loop 3
            var hlLoop3 = new Loop_HL_856();

            //  3 is the Hierarchical ID Number.
            //  2 is the Hierarchical Parent ID Number. (Order)
            //  P is the Hierarchical Level Code. “P” indicates “Pack”. 
            hlLoop3.HL = new HL();
            hlLoop3.HL.HierarchicalIDNumber_01 = "3";
            hlLoop3.HL.HierarchicalParentIDNumber_02 = "2";
            hlLoop3.HL.HierarchicalLevelCode_03 = "P";

            //  Repeating MAN
            hlLoop3.MAN = new List<MAN>();

            //  GM is the Marks and Numbers Qualifier. “GM” indicates
            //  “EAN.UCC Serial Shipping Container Code(SSCC) and
            //  Application Identifier.”
            //  00000010012345614785 is the Marks and Numbers(SCC-18). 
            var man1 = new MAN();
            man1.MarksandNumbersQualifier_01 = "GM";
            man1.MarksandNumbers_02 = "00000010012345614785";
            hlLoop3.MAN.Add(man1);

            //  End HL Loop 3
            result.HLLoop.Add(hlLoop3);

            //  Begin HL Loop 4
            var hlLoop4 = new Loop_HL_856();

            //  4 is the Hierarchical ID Number.
            //  3 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”
            hlLoop4.HL = new HL();
            hlLoop4.HL.HierarchicalIDNumber_01 = "4";
            hlLoop4.HL.HierarchicalParentIDNumber_02 = "3";
            hlLoop4.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC12"
            //  008815509183 is the Product / Service ID
            hlLoop4.LIN = new LIN();
            hlLoop4.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop4.LIN.ProductServiceID_03 = "008815509183";

            //  4 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA” indicates
            //  “Each”. 

            hlLoop4.SN1 = new SN1();
            hlLoop4.SN1.NumberofUnitsShipped_02 = "4";
            hlLoop4.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 4
            result.HLLoop.Add(hlLoop4);

            //  Begin HL Loop 5
            var hlLoop5 = new Loop_HL_856();

            //  5 is the Hierarchical ID Number.
            //  3 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”. 
            hlLoop5.HL = new HL();
            hlLoop5.HL.HierarchicalIDNumber_01 = "5";
            hlLoop5.HL.HierarchicalParentIDNumber_02 = "3";
            hlLoop5.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC
            //  -12”.
            //  008815547321 is the Product / Service ID.
            hlLoop5.LIN = new LIN();
            hlLoop5.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop5.LIN.ProductServiceID_03 = "008815547321";

            //  9 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA”
            //  indicates “Each”.

            hlLoop5.SN1 = new SN1();
            hlLoop5.SN1.NumberofUnitsShipped_02 = "9";
            hlLoop5.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 5
            result.HLLoop.Add(hlLoop5);

            //  Begin HL Loop 6
            var hlLoop6 = new Loop_HL_856();

            //  6 is the Hierarchical ID Number.
            //  1 is the Hierarchical Parent ID Number. (Shipment)
            //  O is the Hierarchical Level Code. “O” indicates “Order”. 
            hlLoop6.HL = new HL();
            hlLoop6.HL.HierarchicalIDNumber_01 = "6";
            hlLoop6.HL.HierarchicalParentIDNumber_02 = "1";
            hlLoop6.HL.HierarchicalLevelCode_03 = "O";

            //  2288115555 the Purchase Order Number.
            //  20051015 is the Date (Purchase Order Date). 
            hlLoop6.PRF = new PRF();
            hlLoop6.PRF.PurchaseOrderNumber_01 = "2288115555";
            hlLoop6.PRF.Date_04 = "20051015";

            //  Repeating REF
            hlLoop6.REF = new List<REF>();

            //  IA is the Reference Identification Qualifier. “IA” indicates
            //  “Internal Vendor Number”.
            //  211555050 is the Reference Identification
            var ref8 = new REF();
            ref8.ReferenceIdentificationQualifier_01 = "IA";
            ref8.ReferenceIdentification_02 = "211555050";
            hlLoop6.REF.Add(ref8);

            //  DP is the Reference Identification Qualifier. “DP” indicates
            //  “Department Number”.
            //  00005 is the Reference Identification(Wal - Mart Department
            //  Number).
            var ref9 = new REF();
            ref9.ReferenceIdentificationQualifier_01 = "DP";
            ref9.ReferenceIdentification_02 = "00005";
            hlLoop6.REF.Add(ref9);

            //  MR is the Reference Identification Qualifier. “MR” indicates
            //  “Merchandise Type Code”.
            //  0073 is the Reference Identification
            var ref10 = new REF();
            ref10.ReferenceIdentificationQualifier_01 = "MR";
            ref10.ReferenceIdentification_02 = "0073";
            hlLoop6.REF.Add(ref10);

            //  IV is the Reference Identification Qualifier. “IV” indicates
            //  “Seller’s Invoice Number”.
            //  01140824 is the Reference Identification
            var ref11 = new REF();
            ref11.ReferenceIdentificationQualifier_01 = "IV";
            ref11.ReferenceIdentification_02 = "01140824";
            hlLoop6.REF.Add(ref11);

            //  Repeating N1 Loops
            hlLoop6.N1Loop = new List<Loop_N1_856>();

            //  Begin N1 Loop 1
            var n1Loop4 = new Loop_N1_856();

            //  BY is the Entity Identifier Code. “BY” indicates “Buying
            //  Party(Purchaser)”.
            //  WAL - MART STORES, INC. is the Name.
            //  UL is the Identification Code Qualifier. “UL” indicates
            //  “Global Location Number(GLN)”.
            //  0078742000015 is the Identification Code(GLN).
            n1Loop4.N1 = new N1();
            n1Loop4.N1.EntityIdentifierCode_01 = "BY";
            n1Loop4.N1.Name_02 = "WAL-MART STORES,INC.";
            n1Loop4.N1.IdentificationCodeQualifier_03 = "UL";
            n1Loop4.N1.IdentificationCode_04 = "0078742000015";

            //  End N1 Loop 1
            hlLoop6.N1Loop.Add(n1Loop4);

            //  End HL Loop 6
            result.HLLoop.Add(hlLoop6);

            //  Begin HL Loop 7
            var hlLoop7 = new Loop_HL_856();

            //  7 is the Hierarchical ID Number.
            //  6 is the Hierarchical Parent ID Number. (Order)
            //  P is the Hierarchical Level Code. “P” indicates “Pack”. 
            hlLoop7.HL = new HL();
            hlLoop7.HL.HierarchicalIDNumber_01 = "7";
            hlLoop7.HL.HierarchicalParentIDNumber_02 = "6";
            hlLoop7.HL.HierarchicalLevelCode_03 = "P";

            //  Repeating MAN
            hlLoop7.MAN = new List<MAN>();

            //  GM is the Marks and Numbers Qualifier. “GM” indicates
            //  “EAN.UCC Serial Shipping Container Code(SSCC) and
            //  Application Identifier”.
            //  00000010012378945698 is the Marks and Numbers(SCC-14). 
            var man2 = new MAN();
            man2.MarksandNumbersQualifier_01 = "GM";
            man2.MarksandNumbers_02 = "00000010012378945698";
            hlLoop7.MAN.Add(man2);

            //  End HL Loop 7
            result.HLLoop.Add(hlLoop7);

            //  Begin HL Loop 8
            var hlLoop8 = new Loop_HL_856();

            //  8 is the Hierarchical ID Number.
            //  7 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”
            hlLoop8.HL = new HL();
            hlLoop8.HL.HierarchicalIDNumber_01 = "8";
            hlLoop8.HL.HierarchicalParentIDNumber_02 = "7";
            hlLoop8.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC
            //  -12”.
            //  008815509183 is the Product / Service ID.
            hlLoop8.LIN = new LIN();
            hlLoop8.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop8.LIN.ProductServiceID_03 = "008815509183";

            //  4 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA”
            //  indicates “Each”. 

            hlLoop8.SN1 = new SN1();
            hlLoop8.SN1.NumberofUnitsShipped_02 = "4";
            hlLoop8.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 8
            result.HLLoop.Add(hlLoop8);

            //  Begin HL Loop 9
            var hlLoop9 = new Loop_HL_856();

            //  9 is the Hierarchical ID Number.
            //  7 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”. 
            hlLoop9.HL = new HL();
            hlLoop9.HL.HierarchicalIDNumber_01 = "9";
            hlLoop9.HL.HierarchicalParentIDNumber_02 = "7";
            hlLoop9.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC
            //  -12”.
            //  008815547321 is the Product / Service ID.
            hlLoop9.LIN = new LIN();
            hlLoop9.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop9.LIN.ProductServiceID_03 = "008815547321";

            //  9 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA”
            //  indicates “Each”.

            hlLoop9.SN1 = new SN1();
            hlLoop9.SN1.NumberofUnitsShipped_02 = "9";
            hlLoop9.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 9
            result.HLLoop.Add(hlLoop9);

            //  9 is the Number of Line Items (number of HL segments in the
            //  document). 
            result.CTT = new CTT();
            result.CTT.NumberofLineItems_01 = "9";

            return result;
        }
    }
}
