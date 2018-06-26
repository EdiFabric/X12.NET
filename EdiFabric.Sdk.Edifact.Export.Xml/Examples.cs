using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.Edifact;

namespace EdiFabric.Sdk.Edifact.Export.Xml
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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();
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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSORDERS>();
        }       
    }
}

