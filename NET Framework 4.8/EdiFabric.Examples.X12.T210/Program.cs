using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T210
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
        /// Read Freight Invoice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\FreightInvoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS210>();

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
        /// Write Freight Invoice
        /// </summary>
        static void Write()
        {
            var transaction = BuildFreightInvoice("1");

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
        /// Builds freight invoice.
        /// Original from https://ps.extra.chrysler.com/sites/itb-ebus/Documents/210FreightPaymentInvoice.pdf
        /// </summary>
        static TS210 BuildFreightInvoice(string controlNumber)
        {
            var result = new TS210();

            //  Transaction Set Identifier Code = “210”
            //  (Motor Carrier Freight Details and Invoice)
            //  Transaction Set Control Number = 00000001
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "210";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Invoice Number = 3410889
            //  Shipment Identification Number = 545930791T
            //  Shipment Method of Payment
            //  = “TP” (Third Party)
            //  Weight Unit Code = “L” (Pounds)
            //  Date = 10 / 31 / 2007
            //  Net Amount Due = 51.65
            //  Delivery Date = 10 / 29 / 2007
            //  Date / Time Qualifier = “035” (Delivered)
            //  Standard Carrier Alpha Code = NLMI
            result.B3 = new B3();
            result.B3.InvoiceNumber_02 = "3410889";
            result.B3.ShipmentIdentificationNumber_03 = "545930791T";
            result.B3.ShipmentMethodofPayment_04 = "TP";
            result.B3.WeightUnitCode_05 = "L";
            result.B3.Date_06 = "20071031";
            result.B3.NetAmountDue_07 = "5165";
            result.B3.DeliveryDate_09 = "20071029";
            result.B3.DateTimeQualifier_10 = "035";
            result.B3.StandardCarrierAlphaCode_11 = "NLMI";

            //  Currency Code = USD (U.S.) 
            result.C3 = new C3();
            result.C3.CurrencyCode_01 = "USD";

            //  Repeating N9
            result.N9 = new List<N9>();

            //  Reference Identification Qualifier = “AE”
            //  (Authorization for Expense<AFE> Number)
            //  Reference Identification = 260451
            var n91 = new N9();
            n91.ReferenceIdentificationQualifier_01 = "AE";
            n91.ReferenceIdentification_02 = "260451";
            result.N9.Add(n91);

            //  Reference Identification Qualifier
            //  = “OP” (Original Purchase Order)
            //  Reference Identification = 3410889
            var n92 = new N9();
            n92.ReferenceIdentificationQualifier_01 = "OP";
            n92.ReferenceIdentification_02 = "3410889";
            result.N9.Add(n92);

            //  Repeating G62
            result.G62 = new List<G62>();

            //  Date Qualifier = “86” (Actual Pickup Date)
            //  Date = 10 / 31 / 2007
            var g62 = new G62();
            g62.DateQualifier_01 = "86";
            g62.Date_02 = "20071031";
            result.G62.Add(g62);

            //  Repeating R3
            result.R3 = new List<R3>();

            //  Standard Carrier Alpha Code = EXEM
            //  Routing Sequence Code
            //  = “B” (Origin / Delivery Carrier < Any Mode >)
            //  Transportation Method/ Type Code
            //  = “AE” (Air Express)
            //  Date = 10 / 31 / 2007
            //  Amount = 379.05
            var r3 = new R3();
            r3.StandardCarrierAlphaCode_01 = "EXEM";
            r3.RoutingSequenceCode_02 = "B";
            r3.TransportationMethodTypeCode_04 = "AE";
            r3.Date_07 = "20071031";
            r3.Amount_08 = "37905";
            result.R3.Add(r3);

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_210>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_210();

            //  Entity Identifier Code = “SH” (Shipper)
            //  Name = SIEMENS VDO S A DE C V –
            //  SIEMENS AUTOMOTIVE
            //  Identification Code Qualifier
            //  = “94” (Code assigned by the organization that is
            //  the ultimate destination of the transaction set)
            //  Identification Code = 99999
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SH";
            n1Loop1.N1.Name_02 = "SIEMENS VDO S A DE C V - SIEMENS AUTOMOTIVE";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "94";
            n1Loop1.N1.IdentificationCode_04 = "99999";

            //  Repeating N3
            n1Loop1.N3 = new List<N3>();

            //  Address Information
            //  = PERIFERICO SUR 7999D COMPLEJO IND
            var n31 = new N3();
            n31.AddressInformation_01 = "PERIFERICO SUR 7999D COMPLEJO IND";
            n1Loop1.N3.Add(n31);

            //  City Name = TLAQUEPAQUE
            //  State or Province Code = MX
            //  Postal Code = 99999
            //  Country Code = MX
            n1Loop1.N4 = new N4();
            n1Loop1.N4.CityName_01 = "TLAQUEPAQUE";
            n1Loop1.N4.StateorProvinceCode_02 = "MX";
            n1Loop1.N4.PostalCode_03 = "99999";
            n1Loop1.N4.CountryCode_04 = "MX";

            //  End N1 Loop 1
            result.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_210();

            //  Entity Identifier Code = “CN” (Consignee)
            //  Name = BRAMPTON ASSEMBLY – COLLINS
            //  AND AIKMAN
            //  Identification Code Qualifier
            //  = “94” (Code assigned by the organization that is
            //  the ultimate destination of the transaction set)
            //  Identification Code = 09126B
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "CN";
            n1Loop2.N1.Name_02 = "BRAMPTON ASSEMBLY - COLLINS AND AIKMAN";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "94";
            n1Loop2.N1.IdentificationCode_04 = "09126B";

            //  Repeating N3
            n1Loop2.N3 = new List<N3>();

            //  Address Information
            // = 500 LAIRD ROAD~GUELPH PRODUCTS
            var n32 = new N3();
            n32.AddressInformation_01 = "500 LAIRD ROAD";
            n32.AddressInformation_02 = "GUELPH PRODUCTS";
            n1Loop2.N3.Add(n32);

            //  City Name = GUELPH
            //  State or Province Code = ON
            //  Postal Code = 99999
            //  Country Code = CA
            n1Loop2.N4 = new N4();
            n1Loop2.N4.CityName_01 = "GUELPH";
            n1Loop2.N4.StateorProvinceCode_02 = "ON";
            n1Loop2.N4.PostalCode_03 = "99999";
            n1Loop2.N4.CountryCode_04 = "CA";

            //  End N1 Loop 2
            result.N1Loop.Add(n1Loop2);

            //  Begin N1 Loop 3
            var n1Loop3 = new Loop_N1_210();

            //  Entity Identifier Code = “BT” (Bill-to-Party)
            //  Name = BRAMPTON ASSEMBLY - MAIN
            //  Identification Code Qualifier
            //  = “94” (Code assigned by the organization that is
            //  the ultimate destination of the transaction set)
            //  Identification Code = 09126
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "BT";
            n1Loop3.N1.Name_02 = "BRAMPTON ASSEMBLY - MAIN";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "94";
            n1Loop3.N1.IdentificationCode_04 = "09126";

            //  Repeating N3
            n1Loop3.N3 = new List<N3>();

            //  Address Information
            //  = 2000 WILLIAMS PARKWAY EAST
            var n33 = new N3();
            n33.AddressInformation_01 = "2000 WILLIAMS PARKWAY EAST";
            n1Loop3.N3.Add(n33);

            //  City Name = BRAMPTON
            //  State or Province Code = ON
            //  Postal Code = 99999
            //  Country Code = CA
            n1Loop3.N4 = new N4();
            n1Loop3.N4.CityName_01 = "BRAMPTON";
            n1Loop3.N4.StateorProvinceCode_02 = "ON";
            n1Loop3.N4.PostalCode_03 = "99999";
            n1Loop3.N4.CountryCode_04 = "CA";

            //  End N1 Loop 3
            result.N1Loop.Add(n1Loop3);

            //  Begin N1 Loop 4
            var n1Loop4 = new Loop_N1_210();

            //  Entity Identifier Code = “CA” (Carrier)
            //  Name
            //  = NATIONAL LOGISTICS MANAGEMENT
            //  Identification Code Qualifier
            //  = “94” (Code assigned by the organization that is
            //  the ultimate destination of the transaction set)
            //  Identification Code = 45795
            n1Loop4.N1 = new N1();
            n1Loop4.N1.EntityIdentifierCode_01 = "CA";
            n1Loop4.N1.Name_02 = "NATIONAL LOGISTICS MANAGEMENT";
            n1Loop4.N1.IdentificationCodeQualifier_03 = "94";
            n1Loop4.N1.IdentificationCode_04 = "45795";

            //  Repeating N3
            n1Loop4.N3 = new List<N3>();

            //  Address Information = 14320 JOY RD. 
            var n34 = new N3();
            n34.AddressInformation_01 = "14320 JOY RD.";
            n1Loop4.N3.Add(n34);

            //  City Name = DETROIT
            //  State or Province Code = MI
            //  Postal Code = 48228
            //  Country Code = US
            n1Loop4.N4 = new N4();
            n1Loop4.N4.CityName_01 = "DETROIT";
            n1Loop4.N4.StateorProvinceCode_02 = "MI";
            n1Loop4.N4.PostalCode_03 = "48228";
            n1Loop4.N4.CountryCode_04 = "US";

            //  End N1 Loop 4
            result.N1Loop.Add(n1Loop4);

            //  Begin N1 Loop 5
            var n1Loop5 = new Loop_N1_210();

            //  Entity Identifier Code = “ZZ” (Mutually Defined)
            //  Name = EXPEDITORS / EMERY WORLDWIDE
            //  Identification Code Qualifier
            //  = “94” (Code assigned by the organization that is
            //  the ultimate destination of the transaction set)
            //  Identification Code = 37905
            n1Loop5.N1 = new N1();
            n1Loop5.N1.EntityIdentifierCode_01 = "ZZ";
            n1Loop5.N1.Name_02 = "EXPEDITORS/EMERY WORLDWIDE";
            n1Loop5.N1.IdentificationCodeQualifier_03 = "94";
            n1Loop5.N1.IdentificationCode_04 = "37905";

            //  Repeating N3
            n1Loop5.N3 = new List<N3>();

            //  Address Information = 10881 LOWELL AVENUE 
            var n35 = new N3();
            n35.AddressInformation_01 = "10881 LOWELL AVENUE";
            n1Loop5.N3.Add(n35);

            //  City Name = OVERLANDPARK
            //  State or Province Code = KS
            //  Postal Code = 66201
            //  Country Code = US
            n1Loop5.N4 = new N4();
            n1Loop5.N4.CityName_01 = "OVERLANDPARK";
            n1Loop5.N4.StateorProvinceCode_02 = "KS";
            n1Loop5.N4.PostalCode_03 = "66201";
            n1Loop5.N4.CountryCode_04 = "US";

            //  Repeating N9
            n1Loop5.N9 = new List<N9>();

            //  Reference Identification Qualifier
            //  = “IK” (Invoice Number)
            //  Reference Identification = 545930791T
            var n9 = new N9();
            n9.ReferenceIdentificationQualifier_01 = "IK";
            n9.ReferenceIdentification_02 = "545930791T";
            n1Loop5.N9.Add(n9);

            //  End N1 Loop 5
            result.N1Loop.Add(n1Loop5);

            //  Repeating N7 Loops
            result.N7Loop = new List<Loop_N7_210>();

            //  Begin N7 Loop
            var n7Loop1 = new Loop_N7_210();

            //  Equipment Number = 53456
            //  Equipment Description Code
            //  = “TL” (Trailer < not otherwise specified>)
            //  Equipment Length = 53 Feet
            //  Equipment Type
            //  = “53ST” (53 Foot Standard Trailer) 
            n7Loop1.N7 = new N7();
            n7Loop1.N7.EquipmentNumber_02 = "53456";
            n7Loop1.N7.EquipmentDescriptionCode_11 = "TL";
            n7Loop1.N7.EquipmentLength_15 = "5300";
            n7Loop1.N7.EquipmentType_22 = "53ST";

            //  End N7 Loop
            result.N7Loop.Add(n7Loop1);

            //  Repeating LX Loops
            result.LXLoop = new List<Loop_LX_210>();

            //  Begin LX Loop
            var lxLoop1 = new Loop_LX_210();

            //  Assigned Number = 1 
            lxLoop1.LX = new LX();
            lxLoop1.LX.AssignedNumber_01 = "1";

            //  Repeating L5
            lxLoop1.L5 = new List<L5>();

            //  Lading Line Item Number= 1
            //  Commodity Code = “2” (Auto Parts)
            //  Commodity Code Qualifier
            //  = “Z” (Mutually defined) 
            var l5 = new L5();
            l5.LadingLineItemNumber_01 = "1";
            l5.CommodityCode_03 = "2";
            l5.CommodityCodeQualifier_04 = "Z";
            lxLoop1.L5.Add(l5);

            //  Repeating L0
            lxLoop1.L0 = new List<L0>();

            //  Lading Line Item Number = 1
            //  Billed / Rated -as Quantity = 1499
            //  Billed / Rated -as Qualifier = “FR” (Flat Rate)
            //  Weight = 1499
            //  Weight Qualifier = “G” (Gross)
            //  Weight Unit Code = “L” (Pounds)
            var l0 = new L0();
            l0.LadingLineItemNumber_01 = "1";
            l0.BilledRatedasQuantity_02 = "1499";
            l0.BilledRatedasQualifier_03 = "FR";
            l0.Weight_04 = "1499";
            l0.WeightQualifier_05 = "G";
            l0.WeightUnitCode_11 = "L";
            lxLoop1.L0.Add(l0);

            //  Repeating L0
            lxLoop1.L1 = new List<L1>();

            //  Lading Line Item Number = 1
            //  Freight Rate = 51.65
            //  Rate / Value Qualifier = “FR” (Flat Rate)
            //  Charge = 51.65
            //  Special Charge or Allowance Code
            //  = “400” (Freight)
            var l1 = new L1();
            l1.LadingLineItemNumber_01 = "1";
            l1.FreightRate_02 = "51.65";
            l1.RateValueQualifier_03 = "FR";
            l1.Charge_04 = "5165";
            l1.SpecialChargeorAllowanceCode_08 = "400";
            lxLoop1.L1.Add(l1);

            //  End LX Loop
            result.LXLoop.Add(lxLoop1);

            //  Weight = 2619
            //  Weight Qualifier = “G” (Gross Weight)
            //  Charge = 51.65
            result.L3 = new L3();
            result.L3.Weight_01 = "2619";
            result.L3.WeightQualifier_02 = "G";
            result.L3.Charge_05 = "5165";

            return result;
        }
    }
}
