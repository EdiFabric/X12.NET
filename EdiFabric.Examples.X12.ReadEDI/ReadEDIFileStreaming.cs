using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileStreaming
    {
        /// <summary>
        /// Reads one item at a time from the EDI stream.
        /// Use for interchanges containing multiple transactions.
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() 
            //  brings back either a control segment (ISA, GS, GE or IEA) or a transaction
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
            {
                while (ediReader.Read())
                {
                    //  3. Check if current item is purchase order
                    var po = ediReader.Item as TS850;
                    if (po != null)
                    {
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);
                    }
                }
            }
        }

        private static void ProcessPurchaseOrder(ISA isa, GS gs, TS850 purchaseOrder)
        {
            //  Do something with the purchase order
        }
    }
}
