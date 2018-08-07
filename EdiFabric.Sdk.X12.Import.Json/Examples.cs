using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Templates.X12004010;
using EdiFabric.Sdk.Helpers;
using System.Web.Script.Serialization;

namespace EdiFabric.Sdk.X12.Import.Json
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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderNs.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TS850>(ediStream.LoadToString());
        }

        /// <summary>
        /// De-serialize to an EDI object from Json using JavaScriptSerializer
        /// </summary>
        public static void DeserializeFromJsonJsSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderMs.json");
            var transaction = new JavaScriptSerializer().Deserialize<TS850>(ediStream.LoadToString());
        }
    }
}

