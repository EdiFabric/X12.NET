using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.EDIFACT_D96A;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.TemplateFactories;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Sdk.Edifact.ORDERS
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOrders();
            WriteOrders();
        }

        static void ReadOrders()
        {
            var purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            //  2.  Read all the contents
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.TrialAssembliesFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }

        static void WriteOrders()
        {
            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(EdifactHelpers.CreateUnb("1"));
                    writer.Write(EdifactHelpers.CreateOrders("1"));
                }

                var ediString = StreamHelpers.LoadString(stream);
            }
        }
    }
}
