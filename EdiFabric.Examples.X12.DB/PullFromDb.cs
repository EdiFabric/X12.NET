using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.DB
{
    class PullFromDb
    {
        /// <summary>
        /// Pull the last purchase order from DB
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var db = new X12Context())
            {
                var po = db.TS850.OrderByDescending(o => o.Id).FirstOrDefault();

                using (var stream = new MemoryStream())
                {
                    using (var writer = new X12Writer(stream, new X12WriterSettings { SerialNumber = TrialLicense.SerialNumber }))
                    {
                        writer.Write(SegmentBuilders.BuildIsa("1"));
                        writer.Write(SegmentBuilders.BuildGs("1"));
                        writer.Write(po);
                    }

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
