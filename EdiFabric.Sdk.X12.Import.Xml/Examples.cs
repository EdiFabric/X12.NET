using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Templates.X12004010;
using EdiFabric.Sdk.Helpers;

namespace EdiFabric.Sdk.X12.Import.Xml
{
    class Examples
    {
        /// <summary>
        /// De-serialize to an EDI object from XML using XmlSerializer
        /// </summary>
        public static void DeserializeFromXmlWithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TS850>();
        }

        /// <summary>
        /// De-serialize to an EDI object from XML using DataContractSerializer
        /// </summary>
        public static void DeserializeFromXmlWithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TS850>();
        }
    }
}

