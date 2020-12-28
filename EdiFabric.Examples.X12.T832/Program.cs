using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.T832
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());
            Read();
            Write();
        }

        /// <summary>
        /// Read Price Catalog
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PriceCatalog.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS832>();

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
        /// Write Price Catalog
        /// </summary>
        static void Write()
        {
            var transaction = BuildPriceCatalog("2001");

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
        /// Builds Price Catalog.
        /// Original from http://www.bergware.net/bisacwww/832_3060.htm
        /// </summary>
        static TS832 BuildPriceCatalog(string controlNumber)
        {
            var result = new TS832();

            //  Transaction Type is 832 
            //  Control number is 2001
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "832";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  This is a Resale catalog 
            //  The catalog name is BISG
            //  The revision is 1 / 12 / 98
            //  This is the original file
            result.BCT = new BCT();
            result.BCT.CatalogPurposeCode_01 = "RC";
            result.BCT.CatalogNumber_02 = "BISG";
            result.BCT.CatalogVersionNumber_03 = "980112";
            result.BCT.TransactionSetPurposeCode_10 = "00";

            //  Repeating LIN Loops
            result.LINLoop = new List<Loop_LIN_832>();

            //  Begin LIN Loop
            var linLoop1 = new Loop_LIN_832();

            //  The first book in the catalog 
            //  ISBN 0940016699
            //  Publisher code is Book Industry Study Group
            linLoop1.LIN = new LIN();
            linLoop1.LIN.AssignedIdentification_01 = "1";
            linLoop1.LIN.ProductServiceIDQualifier_02 = "IB";
            linLoop1.LIN.ProductServiceID_03 = "0940016699";
            linLoop1.LIN.ProductServiceIDQualifier_04 = "B7";
            linLoop1.LIN.ProductServiceID_05 = "Book Industry Study Group";

            //  Repeating DTM Loops
            linLoop1.DTM = new List<DTM>();

            //  Publication date is 12 / 30 / 97
            //  Century designation of 19
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "043";
            dtm1.Date_02 = "971230";
            dtm1.DateTimePeriodFormatQualifier_05 = "19";
            linLoop1.DTM.Add(dtm1);

            //  Repeating PID Loops
            linLoop1.PID = new List<PID>();

            //  Structured code description 
            //  BISAC code list
            //  Edition # 4
            var pid1 = new PID();
            pid1.ItemDescriptionType_01 = "S";
            pid1.AgencyQualifierCode_03 = "BI";
            pid1.ProductDescriptionCode_04 = "EN";
            pid1.Description_05 = "4";
            linLoop1.PID.Add(pid1);

            //  Structured code description 
            //  BISAC code list
            //  Binding Code
            //  Ringbound
            var pid2 = new PID();
            pid2.ItemDescriptionType_01 = "S";
            pid2.AgencyQualifierCode_03 = "BI";
            pid2.ProductDescriptionCode_04 = "FBP";
            pid2.Description_05 = "RB";
            linLoop1.PID.Add(pid2);

            //  Structured code description 
            //  BISAC code list
            //  Edition description
            //  Revised
            var pid3 = new PID();
            pid3.ItemDescriptionType_01 = "S";
            pid3.AgencyQualifierCode_03 = "BI";
            pid3.ProductDescriptionCode_04 = "ED";
            pid3.Description_05 = "REV";
            linLoop1.PID.Add(pid3);

            //  Structured code description 
            //  BISAC code list
            //  Status code
            //  Active
            var pid4 = new PID();
            pid4.ItemDescriptionType_01 = "S";
            pid4.AgencyQualifierCode_03 = "BI";
            pid4.ProductDescriptionCode_04 = "SA";
            pid4.Description_05 = "ACT";
            linLoop1.PID.Add(pid4);

            //  Structured code description 
            //  BISAC code list
            //  Author / Contributor function
            //  Editor was Ted Berg
            var pid5 = new PID();
            pid5.ItemDescriptionType_01 = "S";
            pid5.AgencyQualifierCode_03 = "BI";
            pid5.ProductDescriptionCode_04 = "E01";
            pid5.Description_05 = "Ted Berg";
            linLoop1.PID.Add(pid5);

            //  Structured code description 
            //  BISAC code list
            //  Title line 1
            //  Implementation Guidelines... 
            var pid6 = new PID();
            pid6.ItemDescriptionType_01 = "S";
            pid6.AgencyQualifierCode_03 = "BI";
            pid6.ProductDescriptionCode_04 = "TI";
            pid6.Description_05 = "Implementation Guidelines for Electronic Data Interchange";
            linLoop1.PID.Add(pid6);

            //  Structured code description 
            //  BISAC code list
            //  Sub - title line 1
            //  Based on ANSI X12...
            var pid7 = new PID();
            pid7.ItemDescriptionType_01 = "S";
            pid7.AgencyQualifierCode_03 = "BI";
            pid7.ProductDescriptionCode_04 = "ST";
            pid7.Description_05 = "Based on ANSI X12 Version 3.6";
            linLoop1.PID.Add(pid7);

            //  Structured code description 
            //  BISAC code list
            //  Subject code
            //  COM020010
            var pid8 = new PID();
            pid8.ItemDescriptionType_01 = "S";
            pid8.AgencyQualifierCode_03 = "BI";
            pid8.ProductDescriptionCode_04 = "SU";
            pid8.Description_05 = "COM020010";
            linLoop1.PID.Add(pid8);

            //  Repeating CTP LIN Loops
            linLoop1.CTPLoop = new List<Loop_CTP_832>();

            //  Begin CTP LIN Loop
            var ctpLoop1 = new Loop_CTP_832();

            //  Class of trade is RESALE 
            //  The Suggested list price is
            //  $100.00
            //  Quantity is 1
            //  Unit
            ctpLoop1.CTP = new CTP();
            ctpLoop1.CTP.ClassofTradeCode_01 = "RS";
            ctpLoop1.CTP.PriceIdentifierCode_02 = "SLP";
            ctpLoop1.CTP.UnitPrice_03 = "100.00";
            ctpLoop1.CTP.Quantity_04 = "1";
            ctpLoop1.CTP.CompositeUnitofMeasure_05 = new C001();
            ctpLoop1.CTP.CompositeUnitofMeasure_05.UnitorBasisforMeasurementCode_01 = "UN";

            //  Repeating CUR 
            ctpLoop1.CUR = new List<CUR>();

            //  The selling party currency is 
            //  US Dollars
            var cur1 = new CUR();
            cur1.EntityIdentifierCode_01 = "SE";
            cur1.CurrencyCode_02 = "USD";
            ctpLoop1.CUR.Add(cur1);

            //  End CTP LIN Loop
            linLoop1.CTPLoop.Add(ctpLoop1);

            //  Repeating N1 LIN Loops
            linLoop1.N1Loop = new List<Loop_N1_832_2>();

            //  Begin N1 LIN Loop
            var n1Loop1 = new Loop_N1_832_2();

            //  The agent is 
            //  Book Industry Study Group
            //  SAN is
            //  216793X
            //  Product line is
            //  Retail sales
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "AG";
            n1Loop1.N1.Name_02 = "Book Industry Study Group";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "15";
            n1Loop1.N1.IdentificationCode_04 = "216793X";
            n1Loop1.N1.EntityRelationshipCode_05 = "17";
            n1Loop1.N1.EntityIdentifierCode_06 = "Q3";

            //  End N1 LIN Loop
            linLoop1.N1Loop.Add(n1Loop1);

            //  End LIN Loop
            result.LINLoop.Add(linLoop1);

            //  1 title 
            result.CTT = new CTT();
            result.CTT.NumberofLineItems_01 = "1";

            return result;
        }
    }
}
