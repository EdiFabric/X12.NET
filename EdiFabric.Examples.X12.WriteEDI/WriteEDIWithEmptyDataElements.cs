using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIWithEmptyDataElements
    {
        /// <summary>
        /// Write transactions with whitespace.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_X12_004010_810_Builder.BuildInvoice("1");

            //  Initialize some properties with blanks
            invoice.BIG.ReleaseNumber_05 = "";
            invoice.BIG.ChangeOrderSequenceNumber_06 = "";

            using (var stream = new MemoryStream())
            {
                //  Set the PreserveWhitespace flag to true
                using (var writer = new X12Writer(stream, new X12WriterSettings() { PreserveWhitespace = true }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
