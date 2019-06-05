using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileBatch
    {
        /// <summary>
        /// Reads purchase orders and invoices batched up in the same interchange.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
            {
                while (ediReader.Read())
                {
                    //  Process purchase orders if no parsing errors
                    var po = ediReader.Item as TS850;
                    if (po != null && !po.HasErrors)
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);

                    //  Process invoices if no parsing errors
                    var invoice = ediReader.Item as TS810;
                    if (invoice != null && !invoice.HasErrors)
                        ProcessInvoice(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, invoice);
                }
            }
        }

        private static void ProcessPurchaseOrder(ISA isa, GS gs, TS850 purchaseOrder)
        {
            //  Do something with the purchase order
        }

        private static void ProcessInvoice(ISA isa, GS gs, TS810 invoice)
        {
            //  Do something with the invoice
        }
    }
}
