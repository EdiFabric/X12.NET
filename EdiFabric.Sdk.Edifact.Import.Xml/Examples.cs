using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Sdk.Helpers;

namespace EdiFabric.Sdk.Edifact.Import.Xml
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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSORDERS>();
        }

        /// <summary>
        /// De-serialize to an EDI object from XML using DataContractSerializer
        /// </summary>
        public static void DeserializeFromXmlWithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TSORDERS>();
        }
    }
}

