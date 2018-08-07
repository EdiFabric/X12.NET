using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Sdk.Helpers.Edifact;
using System.Web.Script.Serialization;

namespace EdiFabric.Sdk.Edifact.Export.Json
{
    class Examples
    {
        /// <summary>
        /// Serialize an EDI object to Json using Json.NET
        /// </summary>
        public static void SerializeToJsonDotNet()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(transaction);
                Debug.WriteLine(json.ToString());
            }
        }

        /// <summary>
        /// Serialize an EDI object to Json using JavaScriptSerializer
        /// </summary>
        public static void SerializeToJsonJsSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                var json = new JavaScriptSerializer().Serialize(transaction);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}

