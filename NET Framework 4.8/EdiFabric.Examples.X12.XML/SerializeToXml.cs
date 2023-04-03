using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.XML
{
    class SerializeToXml
    {
        /// <summary>
        /// Serialize an EDI object to XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();
                Debug.WriteLine(xml.Root.ToString());
            }
        }

        /// <summary>
        /// Serialize an EDI object to XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var xml = transaction.SerializeDataContract();
                Debug.WriteLine(xml.Root.ToString());
            }
        }
    }
}
