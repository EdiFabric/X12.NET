using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Templates.X12004010;
using EdiFabric.Examples.X12.Common;
using System.Xml.Linq;

namespace EdiFabric.Examples.X12.XML
{
    class DeserializeFromXml
    {
        /// <summary>
        /// De-serialize to an EDI object from XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TS850>();
        }

        /// <summary>
        /// De-serialize to an EDI object from XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrder2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TS850>();
        }
    }
}
