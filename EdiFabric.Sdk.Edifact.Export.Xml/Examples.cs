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

            var purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.TrialFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var purchaseOrders = ediItems.OfType<TSORDERS>();
            foreach (var po in purchaseOrders)
            {
                var xml = XmlHelpers.Serialize(po);
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

            var purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(purchaseOrderStream);
            var po = XmlHelpers.Deserialize<TSORDERS>(xml);
        }       
    }
}

