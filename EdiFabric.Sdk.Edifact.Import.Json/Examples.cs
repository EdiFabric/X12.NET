using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Sdk.Helpers;
using System.Web.Script.Serialization;

namespace EdiFabric.Sdk.Edifact.Import.Json
{
    class Examples
    {
        /// <summary>
        /// De-serialize to an EDI object from Json using Json.NET
        /// </summary>
        public static void DeserializeFromJsonDotNet()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderNs.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TSORDERS>(ediStream.LoadToString());
        }

        /// <summary>
        /// De-serialize to an EDI object from Json using JavaScriptSerializer
        /// </summary>
        public static void DeserializeFromJsonJsSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderMs.json");
            var transaction = new JavaScriptSerializer().Deserialize<TSORDERS>(ediStream.LoadToString());
        }
    }
}

