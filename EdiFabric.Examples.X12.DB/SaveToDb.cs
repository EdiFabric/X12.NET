using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.DB
{
    class SaveToDb
    {
        /// <summary>
        /// Save to DB with code first - this will create a new database the first time
        /// Edit the connection string in app.config, by default it looks for a local SQL Server instance
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var db = new X12Context())
            {
                Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrder.txt");

                List<IEdiItem> ediItems;
                using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010.NoValidation"))
                    ediItems = ediReader.ReadToEnd().ToList();

                var purchaseOrders = ediItems.OfType<TS850>();

                db.TS850.AddRange(purchaseOrders);

                db.SaveChanges();
            }
        }
    }
}
