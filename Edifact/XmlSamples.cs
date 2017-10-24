using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D96A;


namespace EdiFabric.Sdk.Edifact
{
    class XmlSamples
    {
        /// <summary>
        /// Runs all read samples
        /// Check Output windows for debug data
        /// </summary>
        public static void Run()
        {
            SerializeToXml();
            DeserializeFromXml();
        }

        /// <summary>
        /// Serialize an EDI object to XML
        /// </summary>
        public static void SerializeToXml()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrder.txt");

            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var purchaseOrders = ediItems.OfType<TSORDERS>();
            foreach (var po in purchaseOrders)
            {
                var xml = Serialize(po);
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

            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrder.xml");

            var xml = XElement.Load(purchaseOrderStream);
            var po = Deserialize<TSORDERS>(xml);
        }

        public static XDocument Serialize(EdiMessage instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var serializer = new XmlSerializer(instance.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static T Deserialize<T>(XElement xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(xml.CreateReader());
        }
    }
}

