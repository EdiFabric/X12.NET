﻿using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class Validate850
    {
        /// <summary>
        /// Validate 850
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }
    }
}
