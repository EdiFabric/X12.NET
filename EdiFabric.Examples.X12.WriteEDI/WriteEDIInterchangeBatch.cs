using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework.Writers;
namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIInterchangeBatch
    {
        /// <summary>
        /// Batch multiple interchanges in the same EDI stream
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
                    //  1.  Write the first interchange
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("1"));

                    //  2.  Write the second interchange
                    //  No need to close the previous interchange with a IEA
                    writer.Write(SegmentBuilders.BuildIsa("2"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
