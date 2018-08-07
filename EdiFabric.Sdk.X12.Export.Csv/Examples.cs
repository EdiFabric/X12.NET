using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using EdiFabric.Sdk.Helpers.X12;
using System.Text;

namespace EdiFabric.Sdk.X12.Export.Csv
{
    class Examples
    {
        /// <summary>
        /// Export an EDI object to CSV
        /// </summary>
        public static void ExportToCsv()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var csv = ExportToCsv(transaction);
                Debug.WriteLine(csv);
            }
        }

        private static string ExportToCsv(TS850 po)
        {
            var result = new StringBuilder();
            result.AppendLine("LINE_NUMBER,UPC_NUMBER,QUANTITY,PRICE,UOM,PO_NUMBER,PO_DATE,CUSTOMER_NAME,CUSTOMER_NUMBER,ADDRESS,CITY,STATE,POSTAL_CODE");

            var n1Loop = po.N1Loop.Where(n1 => n1.N1.EntityIdentifierCode_01 == "ST").FirstOrDefault();
            N3 n3 = null;
            N4 n4 = null;
            if (n1Loop != null)
            {
                n3 = n1Loop.N3.FirstOrDefault();
                n4 = n1Loop.N4.FirstOrDefault();
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
                
                if (n1Loop != null)
                {
                    //  Add customer name
                    line += n1Loop.N1.Name_02 + ",";
                    //  Add customer number
                    line += n1Loop.N1.IdentificationCode_04 + ",";
                    if (n3 != null)
                    {
                        //  Add address line 1
                        line += n3.AddressInformation_01 + ",";
                    }
                    if (n4 != null)
                    {
                        //  Add city
                        line += n4.CityName_01 + ",";
                        //  Add state
                        line += n4.StateorProvinceCode_02 + ",";
                        //  Add postal code
                        line += n4.PostalCode_03 + ",";
                    }
                }

                result.AppendLine(line.TrimEnd(new[] { ',' }));
            }

            return result.ToString();
        }
    }
}

