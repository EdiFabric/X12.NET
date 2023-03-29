using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIWithObfuscation
    {
        /// <summary>
        /// Write with obfuscated values for all data elements of type X12_AN.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = SegmentBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, new X12WriterSettings() { Postfix = Environment.NewLine, Obfuscate = true }))
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
