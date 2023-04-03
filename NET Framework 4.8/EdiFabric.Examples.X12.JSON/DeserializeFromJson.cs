using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.JSON
{
    class DeserializeFromJson
    {
        /// <summary>
        /// De-serialize to an EDI object from Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrderNs.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TS850>(ediStream.LoadToString());
        }
    }
}
