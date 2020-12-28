using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileWithErrors
    {
        /// <summary>
        /// Reads file with a corrupt ST and a valid ST
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\CorruptSt.txt");

            //  Set the continue on error flag to true
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12", new X12ReaderSettings() { ContinueOnError = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var purchaseOrders = ediItems.OfType<TS850>();
            foreach (var po in purchaseOrders)
            {
                //  All valid purchase orders were extracted
            }
        }
    }
}
