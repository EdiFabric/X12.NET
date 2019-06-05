using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDITransactionBatch
    {
        /// <summary>
        /// Batch multiple transactions in the same functional group\EDI stream.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, new X12WriterSettings() { Postfix = Environment.NewLine }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));

                    //  1.  Write the first invoice
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("1"));

                    //  2.  Write the second invoice
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("2"));

                    //  3.  Write any subsequent invoices...
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
