using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIToStreamAsync
    {
        /// <summary>
        /// Generate and write EDI document to a stream async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EF_X12_004010_810_Builder.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    //  2.  Begin with ISA segment
                    await writer.WriteAsync(SegmentBuilders.BuildIsa("1"));
                    //  3.  Follow up with GS segment
                    await writer.WriteAsync(SegmentBuilders.BuildGs("1"));
                    //  4.  Then write the invoice(s)
                    await writer.WriteAsync(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
