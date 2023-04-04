using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using System.Text;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.CSV
{
    class ExportToCsv
    {
        /// <summary>
        /// Export an EDI object to CSV
        /// Original from https://www.ibm.com/developerworks/community/wikis/home?lang=en#!/wiki/Mapping%20and%20Translation/page/EDI%20to%20CSV%20mapping
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var csv = Export(transaction);
                Debug.WriteLine(csv);
            }
        }

        static string Export(TS850 po)
        {
            var result = new StringBuilder();
            result.AppendLine("LINE_NUMBER,UPC_NUMBER,QUANTITY,PRICE,UOM,PO_NUMBER,PO_DATE,CUSTOMER_NAME,CUSTOMER_NUMBER,ADDRESS,CITY,STATE,POSTAL_CODE");

            string customer = "";
            string customerNr = "";
            string address = "";
            string city = "";
            string state = "";
            string postCode = "";

            var n1Loop = po.N1Loop.Where(n1 => n1.N1.EntityIdentifierCode_01 == "ST").FirstOrDefault();
            if (n1Loop != null)
            {
                customer = n1Loop.N1.Name_02;
                customerNr = n1Loop.N1.IdentificationCode_04;
                var n3 = n1Loop.N3.FirstOrDefault();
                if (n3 != null)
                    address = n3.AddressInformation_01;
                var n4 = n1Loop.N4.FirstOrDefault();
                if (n4 != null)
                {
                    city = n4.CityName_01;
                    state = n4.StateorProvinceCode_02;
                    postCode = n4.PostalCode_03;
                }
            }

            foreach (var po1Loop in po.PO1Loop)
            {
                //  Add line number
                var line = po1Loop.PO1.AssignedIdentification_01 + ",";
                //  Add upc number
                line += po1Loop.PO1.ProductServiceID_07 + ",";
                //  Add quantity
                line += po1Loop.PO1.QuantityOrdered_02 + ",";
                //  Add price
                line += po1Loop.PO1.UnitPrice_04 + ",";
                //  Add uom
                line += po1Loop.PO1.UnitorBasisforMeasurementCode_03 + ",";
                //  Add po number
                line += po.BEG.PurchaseOrderNumber_03 + ",";
                //  Add po date
                line += po.BEG.Date_05 + ",";
                //  Add customer name
                line += customer + ",";
                //  Add customer number
                line += customerNr + ",";
                //  Add address line 1
                line += address + ",";
                //  Add city
                line += city + ",";
                //  Add state
                line += state + ",";
                //  Add postal code
                line += postCode + ",";

                result.AppendLine(line.TrimEnd(new[] { ',' }));
            }

            return result.ToString();
        }
    }
}
