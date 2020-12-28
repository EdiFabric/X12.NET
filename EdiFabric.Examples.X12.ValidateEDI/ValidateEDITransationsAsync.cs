using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateEDITransationsAsync
    {
        /// <summary>
        /// Validate EDI transactions async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate
                Tuple<bool, MessageErrorContext> result = await purchaseOrder.IsValidAsync();
                if (!result.Item1)
                {
                    //  Report it back to the sender, log, etc.
                    var errors = result.Item2.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }
    }
}
