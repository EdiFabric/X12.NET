using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Templates.X12004010;
using EdiFabric.Sdk.Helpers;
using System.Linq;
using System.Collections.Generic;

namespace EdiFabric.Sdk.X12.Import.Csv
{
    class Examples
    {
        /// <summary>
        /// Import to an EDI object from CSV
        /// Original from https://www.ibm.com/developerworks/community/wikis/home?lang=en#!/wiki/Mapping%20and%20Translation/page/EDI%20to%20CSV%20mapping
        /// </summary>
        public static void ImportFromCsv()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.csv");
            var csv = ediStream.LoadToString();
            var lines = csv.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var transaction = ImportFromCsv(lines);
        }

        private static TS850 ImportFromCsv(string[] lines)
        {
            var result = new TS850();

            if(lines.Length < 2)
                throw new Exception("Insufficient number of lines");

            //  line[0] is the header
            var firstLine = lines[1];

            //  ST
            result.ST = new Core.Model.Edi.X12.ST();
            result.ST.TransactionSetIdentifierCode_01 = "850";
            result.ST.TransactionSetControlNumber_02 = "000000001";

            var firstLineItems = firstLine.Split(new[] { ',' });
            if (firstLineItems.Count() < 13)
                throw new Exception("Insufficient number of columns");

            //  BEG
            result.BEG = new BEG();
            result.BEG.TransactionSetPurposeCode_01 = "01";
            result.BEG.PurchaseOrderTypeCode_02 = "02";
            result.BEG.PurchaseOrderNumber_03 = firstLineItems[5];
            result.BEG.Date_05 = firstLineItems[6];

            //  Repeating N1 Loops
            result.N1Loop = new List<Loop_N1_850>();

            //  Begin N1 Loop
            var n1Loop = new Loop_N1_850();

            //  N1
            n1Loop.N1 = new N1();
            n1Loop.N1.EntityIdentifierCode_01 = "ST";
            n1Loop.N1.Name_02 = firstLineItems[7];
            n1Loop.N1.IdentificationCodeQualifier_03 = "ZZ";
            n1Loop.N1.IdentificationCode_04 = firstLineItems[8];

            //  Repeating N3
            n1Loop.N3 = new List<N3>();

            //  N3
            var n3 = new N3();
            n3.AddressInformation_01 = firstLineItems[9];
            n1Loop.N3.Add(n3);

            //  Repeating N4
            n1Loop.N4 = new List<N4>();

            //  N4
            var n4 = new N4();
            n4.CityName_01 = firstLineItems[10];
            n4.StateorProvinceCode_02 = firstLineItems[11];
            n4.PostalCode_03 = firstLineItems[12];
            n1Loop.N4.Add(n4);

            //  End N1 Loop
            result.N1Loop.Add(n1Loop);

            //  Repeating PO1 Loops
            result.PO1Loop = new List<Loop_PO1_850>();

            foreach (var line in lines.Skip(1))
            {
                var lineItems = line.Split(new[] { ',' });
                if (lineItems.Count() < 13)
                    throw new Exception("Insufficient number of columns");
                
                //  Begin PO1 Loop
                var po1Loop = new Loop_PO1_850();

                //  PO1
                po1Loop.PO1 = new PO1();
                po1Loop.PO1.AssignedIdentification_01 = lineItems[0];
                po1Loop.PO1.QuantityOrdered_02 = lineItems[2];
                po1Loop.PO1.UnitorBasisforMeasurementCode_03 = lineItems[4];
                po1Loop.PO1.UnitPrice_04 = lineItems[3];
                po1Loop.PO1.ProductServiceIDQualifier_06 = "UP";
                po1Loop.PO1.ProductServiceID_07 = lineItems[1];

                //  End PO1 Loop
                result.PO1Loop.Add(po1Loop);
            }

            return result;
        }
    }
}

