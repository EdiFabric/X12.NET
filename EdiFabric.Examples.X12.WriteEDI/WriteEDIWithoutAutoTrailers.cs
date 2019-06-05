using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIWithoutAutoTrailers
    {
        /// <summary>
        /// Write without auto trailers
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set AutoTrailers to false
                using (var writer = new X12Writer(stream, new X12WriterSettings { AutoTrailers = false }))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("1"));
                    //  trailers need to be manually written                    
                }

                using (var writer = new StreamWriter(stream))
                {
                    var ge = new GE();
                    ge.NumberOfIncludedSets_1 = "1";
                    ge.GroupControlNumber_2 = "000000001";
                    writer.Write(ge.ToEdi(Separators.X12));

                    var iea = new IEA();
                    iea.NumberOfIncludedGroups_1 = "1";
                    iea.InterchangeControlNumber_2 = "000000001";
                    writer.Write(iea.ToEdi(Separators.X12));

                    writer.Flush();

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
