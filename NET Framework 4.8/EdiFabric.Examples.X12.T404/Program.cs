using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T404
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
        /// Read Rail Carrier Shipment
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\RailCarrierShipment.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS404>();

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
        /// Write Rail Carrier Shipment
        /// </summary>
        static void Write()
        {
            var transaction = BuildRailCarrierShipment("1");

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
        /// Builds Rail Carrier Shipment.
        /// Original from https://ps.nafta.extra.fcagroup.com/sites/itb-ebus/shared%20Documents/404RailCarrierShipmentInformation.pdf
        /// </summary>
        static TS404 BuildRailCarrierShipment(string controlNumber)
        {
            var result = new TS404();

            //  Transaction Set Identifier Code
            //  = “404” (Rail Carrier Shipment Information)
            //  Transaction Set Control Number = 0001
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "404";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Transaction Set Purpose Code = “00” (Original)
            //  Transportation Method/ Type Code = “R” (Rail)
            //  Shipment Method of Payment
            //  = “11” (Rule 11 Shipment)
            //  Standard Carrier Alpha Code = NS
            //  Weight Unit Code = ”L” (Pounds)
            //  Shipment Qualifier
            //  = “B” (Bill of Lading for Individual Shipment)
            //  Section Seven Code = “N” (Not in Effect)
            result.BX = new BX();
            result.BX.TransactionSetPurposeCode_01 = "00";
            result.BX.TransportationMethodTypeCode_02 = "R";
            result.BX.ShipmentMethodofPayment_03 = "11";
            result.BX.StandardCarrierAlphaCode_05 = "NS";
            result.BX.WeightUnitCode_06 = "L";
            result.BX.ShipmentQualifier_07 = "B";
            result.BX.SectionSevenCode_08 = "N";

            //  Shipment Weight Code
            //  = “A” (Shipper's Weight Agreement)
            //  Billing Code = “S” (Single Shipment Billing) 
            result.BNX = new BNX();
            result.BNX.ShipmentWeightCode_01 = "A";
            result.BNX.BillingCode_03 = "S";

            //  Release Code = “R” (Released with Billing Data)
            //  Date = 03 / 01 / 2000
            //  Time = 11:16
            //  Time Code = “LT” (Local Time)
            result.M3 = new M3();
            result.M3.ReleaseCode_01 = "R";
            result.M3.Date_02 = "20000301";
            result.M3.Time_03 = "1116";
            result.M3.TimeCode_04 = "LT";

            //  Repeating N9
            result.N9 = new List<N9>();

            //  Reference Identification Qualifier
            //  = “BM” (Bill of Lading Number)
            //  Reference Identification = 2041247
            //  Date = 03 / 01 / 2000
            //  Time = 11:16
            //  Time Code = “LT” (Local Time)
            var n9 = new N9();
            n9.ReferenceIdentificationQualifier_01 = "BM";
            n9.ReferenceIdentification_02 = "2041247";
            n9.Date_04 = "20000301";
            n9.Time_05 = "1116";
            n9.TimeCode_06 = "LT";
            result.N9.Add(n9);

            //  Repeating N7 Loops
            result.N7Loop = new List<Loop_N7_404>();

            //  Begin N7 Loop
            var n7Loop1 = new Loop_N7_404();

            //  Equipment Initial = CR
            //  Equipment Number = 237522
            //  Weight = 80,503
            //  Weight Qualifier = “N” (Actual Net Weight)
            //  Equipment Description Code = “RR” (Rail Car) 
            n7Loop1.N7 = new N7();
            n7Loop1.N7.EquipmentInitial_01 = "CR";
            n7Loop1.N7.EquipmentNumber_02 = "237522";
            n7Loop1.N7.Weight_03 = "80503";
            n7Loop1.N7.WeightQualifier_04 = "N";
            n7Loop1.N7.EquipmentDescriptionCode_11 = "RR";

            //  Repeating M7
            n7Loop1.M7 = new List<M7>();

            //  Seal Number = 582127
            //  Seal Number = 582128
            var m7 = new M7();
            m7.SealNumber_01 = "582127";
            m7.SealNumber_02 = "582128";
            n7Loop1.M7.Add(m7);

            //  End N7 Loop
            result.N7Loop.Add(n7Loop1);

            //  City Name = WARREN
            //  State or Province Code = MI
            result.F9 = new F9();
            result.F9.CityName_02 = "WARREN";
            result.F9.StateorProvinceCode_03 = "MI";

            //  City Name = VALLEY PARK
            //  State or Province Code = MO
            result.D9 = new D9();
            result.D9.CityName_02 = "VALLEY PARK";
            result.D9.StateorProvinceCode_03 = "MO";

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_404_3>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_404_3();

            //  Entity Identifier Code = “11”
            //  (Party to be billed < AAR Accounting Rule 11 >)
            //  Name = CORPAY SOLUTIONS
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "11";
            n1Loop1.N1.Name_02 = "CORPAY SOLUTIONS";

            //  Repeating N3
            n1Loop1.N3 = new List<N3>();

            //  Address Information
            //  = PO BOX 195199 / 2065 S CENTER RD
            var n31 = new N3();
            n31.AddressInformation_01 = "PO BOX 195199/2065 S CENTER RD";
            n1Loop1.N3.Add(n31);

            //  City Name = BURTON
            //  State or Province Code = MI
            //  Postal Code = 48519
            n1Loop1.N4 = new N4();
            n1Loop1.N4.CityName_01 = "BURTON";
            n1Loop1.N4.StateorProvinceCode_02 = "MI";
            n1Loop1.N4.PostalCode_03 = "48519";

            //  End N1 Loop 1
            result.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_404_3();

            //  Entity Identifier Code = “CN” (Consignee)
            //  Name = ST LOUIS ASSEMBLY I
            //  Identification Code Qualifier
            //  = “93” (Code assigned by the organization
            //  originating the transaction set)
            //  Identification Code = 04087
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "CN";
            n1Loop2.N1.Name_02 = "ST LOUIS ASSEMBLY I";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "93";
            n1Loop2.N1.IdentificationCode_04 = "04087";

            //  Repeating N3
            n1Loop2.N3 = new List<N3>();

            //  Address Information
            //  = 1001 N HIGHWAY DRIVE
            var n32 = new N3();
            n32.AddressInformation_01 = "1001 N HIGHWAY DRIVE";
            n1Loop2.N3.Add(n32);

            //  City Name = FENTON
            //  State or Province Code = MO
            //  Postal Code = 63026
            n1Loop2.N4 = new N4();
            n1Loop2.N4.CityName_01 = "FENTON";
            n1Loop2.N4.StateorProvinceCode_02 = "MO";
            n1Loop2.N4.PostalCode_03 = "63026";

            //  End N1 Loop 2
            result.N1Loop.Add(n1Loop2);

            //  Begin N1 Loop 3
            var n1Loop3 = new Loop_N1_404_3();

            //  Entity Identifier Code
            //  = “UC” (Ultimate Consignee)
            //  Name = ST LOUIS ASSEMBLY I
            //  Identification Code Qualifier
            //  = “93” (Code assigned by the organization
            //  originating the transaction set)
            //  Identification Code = 04087
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "UC";
            n1Loop3.N1.Name_02 = "ST LOUIS ASSEMBLY I";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "93";
            n1Loop3.N1.IdentificationCode_04 = "04087";

            //  Repeating N3
            n1Loop3.N3 = new List<N3>();

            //  Address Information
            //  = 1001 N HIGHWAY DRIVE
            var n33 = new N3();
            n33.AddressInformation_01 = "1001 N HIGHWAY DRIVE";
            n1Loop3.N3.Add(n33);

            //  City Name = FENTON
            //  State or Province Code = MO
            //  Postal Code = 63026
            n1Loop3.N4 = new N4();
            n1Loop3.N4.CityName_01 = "FENTON";
            n1Loop3.N4.StateorProvinceCode_02 = "MO";
            n1Loop3.N4.PostalCode_03 = "63026";

            //  End N1 Loop 3
            result.N1Loop.Add(n1Loop3);

            //  Begin N1 Loop 4
            var n1Loop4 = new Loop_N1_404_3();

            //  Entity Identifier Code = “SH” (Shipper)
            //  Name = STERLING STAMPING
            //  Identification Code Qualifier
            //  = “93” (Code assigned by the organization
            //  originating the transaction set)
            //  Identification Code = 06215
            n1Loop4.N1 = new N1();
            n1Loop4.N1.EntityIdentifierCode_01 = "SH";
            n1Loop4.N1.Name_02 = "STERLING STAMPING";
            n1Loop4.N1.IdentificationCodeQualifier_03 = "93";
            n1Loop4.N1.IdentificationCode_04 = "06215";

            //  Repeating N3
            n1Loop4.N3 = new List<N3>();

            //  Address = 35777 VAN DYKE RD 
            var n34 = new N3();
            n34.AddressInformation_01 = "35777 VAN DYKE RD";
            n1Loop4.N3.Add(n34);

            //  City Name = STERLING HEIGHTS
            //  State or Province Code = MI
            //  Postal Code = 48312
            n1Loop4.N4 = new N4();
            n1Loop4.N4.CityName_01 = "STERLING HEIGHTS";
            n1Loop4.N4.StateorProvinceCode_02 = "MI";
            n1Loop4.N4.PostalCode_03 = "48312";

            //  End N1 Loop 4
            result.N1Loop.Add(n1Loop4);

            //  Repeating R2
            result.R2 = new List<R2>();

            //  Standard Carrier Alpha Code = NS
            //  Routing Sequence Code
            //  = “R” (Origin Carrier, Rule 11 Shipment)
            //  City Name = ESTL
            var r21 = new R2();
            r21.StandardCarrierAlphaCode_01 = "NS";
            r21.RoutingSequenceCode_02 = "R";
            r21.CityName_03 = "ESTL";
            result.R2.Add(r21);

            //  Standard Carrier Alpha Code = BNSF
            //  Routing Sequence Code
            //  = “1” (1st Carrier after Origin Carrier) 
            var r22 = new R2();
            r22.StandardCarrierAlphaCode_01 = "BNSF";
            r22.RoutingSequenceCode_02 = "1";
            result.R2.Add(r22);

            //  Repeating LX Loops
            result.LXLoop = new List<Loop_LX_404>();

            //  Begin LX Loop
            var lxLoop1 = new Loop_LX_404();

            //  Assigned Number = 1 
            lxLoop1.LX = new LX();
            lxLoop1.LX.AssignedNumber_01 = "1";

            //  Repeating L5
            lxLoop1.L5 = new List<L5>();

            //  Lading Line Item Number = 1
            //  Lading Description = AUTO PARTS
            //  Commodity Code = 3714993
            //  Commodity Code Qualifier
            //  = “T” (Standard Transportation Commodity
            //  Code<STCC>) 
            var l5 = new L5();
            l5.LadingLineItemNumber_01 = "1";
            l5.LadingDescription_02 = "AUTO PARTS";
            l5.CommodityCode_03 = "3714993";
            l5.CommodityCodeQualifier_04 = "T";
            lxLoop1.L5.Add(l5);

            //  Repeating L0 Loops
            lxLoop1.L0Loop = new List<Loop_L0_404>();

            //  Begin L0 Loop
            var l0Loop1 = new Loop_L0_404();

            //  Lading Line Item Number = 1
            //  Weight = 80,503
            //  Weight Qualifier = “N” (Actual Net Weight)
            //  Lading Quantity = 42
            //  Packaging Form Code = “RCK” (Rack)
            l0Loop1.L0 = new L0();
            l0Loop1.L0.LadingLineItemNumber_01 = "1";
            l0Loop1.L0.Weight_04 = "80503";
            l0Loop1.L0.WeightQualifier_05 = "N";
            l0Loop1.L0.LadingQuantity_08 = "42";
            l0Loop1.L0.PackagingFormCode_09 = "RCK";

            //  End L0 Loop
            lxLoop1.L0Loop.Add(l0Loop1);

            //  End LX Loop
            result.LXLoop.Add(lxLoop1);

            return result;
        }
    }
}
