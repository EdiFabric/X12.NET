using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D96A;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.TemplateFactories;

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

            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, EdifactFactories.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = XmlHelpers.Deserialize<TSORDERS>(xml);
        }       
    }
}

