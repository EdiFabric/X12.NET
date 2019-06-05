using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010.PartnerB;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileWithCustomTemplate
    {
        /// <summary>
        /// Reads EDI file into a custom, partner-specific template. 
        /// Compare the files in EdiFabric.Examples.X12.Templates.V4010.PartnerB to the standard template in EdiFabric.Examples.X12.Templates.V4010
        /// for changes.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrderCustom1.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010.PartnerB"))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TS850>();
        }
    }
}
