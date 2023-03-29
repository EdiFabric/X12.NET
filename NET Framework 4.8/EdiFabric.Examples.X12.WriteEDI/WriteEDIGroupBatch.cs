using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIGroupBatch
    {
        /// <summary>
        /// Batch multiple transactions under multiple functional groups in the same EDI stream
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));

                    //  1.  Write the first group               
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    //  Write the transactions...
                    writer.Write(SegmentBuilders.BuildInvoice("1"));

                    //  2.  Write the second group
                    //  No need to close the previous group with a GE
                    writer.Write(SegmentBuilders.BuildGs("2"));
                    //  Write the transactions...
                    writer.Write(SegmentBuilders.BuildInvoice("2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
