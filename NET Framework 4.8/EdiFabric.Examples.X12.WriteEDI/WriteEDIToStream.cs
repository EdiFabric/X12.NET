using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIToStream
    {
        /// <summary>
        /// Generate and write EDI document to a stream
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = SegmentBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    //  2.  Begin with ISA segment
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    //  3.  Follow up with GS segment
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    //  4.  Then write the invoice(s)
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
