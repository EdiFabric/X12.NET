using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T214
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Shipment Status
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\ShipmentStatus.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS214>();

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
        /// Write Shipment Status
        /// </summary>
        static void Write()
        {
            var transaction = BuildShipmentStatus("6");

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
        /// Builds Shipment Status.
        /// Original from https://ps.nafta.extra.fcagroup.com/sites/itb-ebus/Shared%20Documents/214STARSShipmentStatus.pdf
        /// </summary>
        static TS214 BuildShipmentStatus(string controlNumber)
        {
            var result = new TS214();

            //  Start Transaction Set 214
            //  Control number = 0006
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "214";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Reference Number = 123456
            //  Carrier SCAC = BAWC
            //  Route Code = ROUTE1
            result.B10 = new B10();
            result.B10.ReferenceIdentification_01 = "123456";
            result.B10.StandardCarrierAlphaCode_03 = "BAWC";
            result.B10.ReferenceIdentificationQualifier_05 = "RU";
            result.B10.ReferenceIdentification_06 = "ROUTE1";

            //  Repeating L11
            result.L11 = new List<L11>();

            //  Power unit = 55555555 
            var l11 = new L11();
            l11.ReferenceIdentification_01 = "55555555";
            l11.ReferenceIdentificationQualifier_02 = "EQ";
            result.L11.Add(l11);

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_214>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_214();

            //  Pick-up location = 23083C 
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "SF";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop1.N1.IdentificationCode_04 = "23083C";

            //  Pick-up city and state = Decorah, IA
            //  Pick - up country = US(United States)
            n1Loop1.N4 = new N4();
            n1Loop1.N4.CityName_01 = "DECORAH";
            n1Loop1.N4.StateorProvinceCode_02 = "IA";
            n1Loop1.N4.CountryCode_04 = "US";

            //  End N1 Loop 1
            result.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_214();

            //  Delivery location = 00073 
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "ST";
            n1Loop2.N1.IdentificationCodeQualifier_03 = "92";
            n1Loop2.N1.IdentificationCode_04 = "00073";

            //  Delivery city and state = Summit, IL
            //  Delivery country = US(United States)
            n1Loop2.N4 = new N4();
            n1Loop2.N4.CityName_01 = "SUMMIT";
            n1Loop2.N4.StateorProvinceCode_02 = "IL";
            n1Loop2.N4.CountryCode_04 = "US";

            //  End N1 Loop 2
            result.N1Loop.Add(n1Loop2);

            //  Repeating MS3
            result.MS3 = new List<MS3>();

            //  Power SCAC code = BAWC
            //  Origin / Delivery Carrier Transportation Mode
            //  = GG(Geographic Shipping and Receiving)
            var ms3 = new MS3();
            ms3.StandardCarrierAlphaCode_01 = "BAWC";
            ms3.RoutingSequenceCode_02 = "B";
            ms3.TransportationMethodTypeCode_04 = "GG";
            result.MS3.Add(ms3);

            //  Repeating LX Loops
            result.LXLoop = new List<Loop_LX_214>();

            //  Begin LX Loop
            var lxLoop1 = new Loop_LX_214();

            //  Assigned number = 1 
            lxLoop1.LX = new LX();
            lxLoop1.LX.AssignedNumber_01 = "1";

            //  Repeating At7 Loops
            lxLoop1.AT7Loop = new List<Loop_AT7_214>();

            //  Begin AT7 Loop
            var at7loop1 = new Loop_AT7_214();

            //  Arrival at Pick-Up Location
            //  Arrival date = 09 / 25 / 1997
            //  Arrival time = 08:30AM
            //  Time Zone = Central Time
            at7loop1.AT7 = new AT7();
            at7loop1.AT7.ShipmentStatusCode_01 = "X3";
            at7loop1.AT7.ShipmentStatusorAppointmentReasonCode_02 = "NS";
            at7loop1.AT7.Date_05 = "19970925";
            at7loop1.AT7.Time_06 = "0830";
            at7loop1.AT7.TimeCode_07 = "CT";

            //  Latitude
            //  = 043 Degrees, 18 Minutes, 36 Seconds North
            //  Longitude
            //  = 091 Degrees, 47 Minutes, 26 Seconds West
            at7loop1.MS1 = new MS1();
            at7loop1.MS1.LongitudeCode_04 = "0914726";
            at7loop1.MS1.LatitudeCode_05 = "0431836";
            at7loop1.MS1.DirectionIdentifierCode_06 = "W";
            at7loop1.MS1.DirectionIdentifierCode_07 = "N";

            //  End AT7 Loop
            lxLoop1.AT7Loop.Add(at7loop1);

            //  End LX Loop
            result.LXLoop.Add(lxLoop1);

            return result;
        }
    }
}
