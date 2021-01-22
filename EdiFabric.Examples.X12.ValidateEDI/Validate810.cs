using EdiFabric.Core.Model.Edi;
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
    class Validate810
    {
        /// <summary>
        /// Validate 810
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\Invoice.txt");
            
            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = reader.ReadToEnd().ToList();

            var invoices = ediItems.OfType<TS810>();

            foreach (var invoice in invoices)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!invoice.IsValid(out errorContext))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  invoice is valid, handle it downstream
                }
            }
        }
    }
}
