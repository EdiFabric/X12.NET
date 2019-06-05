using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileToEnd
    {
        /// <summary>
        /// Reads the EDI stream from start to end.
        /// This method loads the file into memory. Do not use for large files. 
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TS850>();           
        }
    }
}
