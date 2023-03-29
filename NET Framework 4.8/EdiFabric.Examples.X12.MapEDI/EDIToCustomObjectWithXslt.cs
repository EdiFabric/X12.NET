using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using EdiFabric.Examples.X12.Common;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Xsl;

namespace EdiFabric.Examples.X12.MapEDI
{
    class EDIToCustomObjectWithXslt
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                //  Serialize each transaction
                var xml = transaction.Serialize();

                //  Transform each XML
                XDocument outputXml = new XDocument();
                using (XmlWriter writer = outputXml.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\Template850ToPurchaseOrderMap.xslt")));
                    xslt.Transform(xml.CreateReader(), writer);
                }

                //  Deserialize into the destination type
                PurchaseOrder customTransaction = outputXml.Root.Deserialize<PurchaseOrder>();
            }
        }
    }
}
