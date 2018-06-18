using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.X12_004010;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.TemplateFactories;

namespace EdiFabric.Sdk.X12.Export.Xml
{
    class Examples
    {
        /// <summary>
        /// Serialize an EDI object to XML
        /// </summary>
        public static void SerializeToXml()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, X12Factories.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var xml = XmlHelpers.Serialize(transaction);
                Debug.WriteLine(xml.Root.ToString());
            }
        }

        /// <summary>
        /// De-serialize to an EDI object from XML
        /// </summary>
        public static void DeserializeFromXml()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\X12.Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = XmlHelpers.Deserialize<TS850>(xml);
        }
    }
}

