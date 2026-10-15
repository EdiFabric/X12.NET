using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace EdiFabric.Examples.X12.JSON
{
    class SerializeToJson
    {
        /// <summary>
        /// Serialize an EDI object to Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var options = new JsonSerializerOptions
                {
                    //TypeInfoResolver = new DefaultJsonTypeInfoResolver
                    //{
                    //    Modifiers =
                    //    {
                    //        typeInfo =>
                    //        {
                    //            if (typeInfo.Kind != JsonTypeInfoKind.Object)
                    //                return;

                    //            foreach (var property in typeInfo.Properties)
                    //            {
                    //                if (property.Name == "Id" )
                    //                {
                    //                    property.ShouldSerialize = (obj, value) => false;
                    //                }
                    //            }
                    //        }
                    //    }
                    //},
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                var json = JsonSerializer.Serialize(transaction, options);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
