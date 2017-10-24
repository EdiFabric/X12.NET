using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.Vda;
using EdiFabric.Framework.Readers;
using EdiFabric.Core.Model.Edi;
using System.Linq;

namespace EdiFabric.Sdk.Vda
{
    /// <summary>
    /// Runs all write samples
    /// Check Output windows for debug data
    /// </summary>
    class WriteSamples
    {
        public static void Run()
        {
            Write4905();            
        }

        /// <summary>
        /// Generate and write EDI document to a stream
        /// </summary>
        static void Write4905()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the 4905 message with data from database, service or domain objects\logic.
            var vda4905 = Create4905();

            using (var stream = new MemoryStream())
            {
                //  2.  Use CRLF(new line) as segment postfix for clarity
                //  Always agree postfixes and separators with the trading partner
                var writer = new VdaWriter(stream, Environment.NewLine, Encoding.UTF8);
                //  3.  Write all transactions
                writer.Write(vda4905);
                //  4.  Always flush at the end to release the cache
                writer.Flush();
            }
        }

        static TS4905 Create4905()
        {
            Stream vda4905Stream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Vda.Edi.Vda_4905_02.txt");

            List<EdiItem> ediItems = new List<EdiItem>();
            using (var ediReader = new VdaReader(vda4905Stream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            return ediItems.OfType<TS4905>().SingleOrDefault();
        }

        private static MessageContext MessageContextFactory(string segment)
        {
            var id = segment.Substring(0, 5);
            switch (id)
            {
                case "51102":
                    var newControlNumber = segment.Substring(29, 5);
                    var sender = segment.Substring(15, 9);
                    var receiver = segment.Substring(6, 9);

                    return new MessageContext("4905", newControlNumber, "1", "VDA", sender, "", receiver, "",
                        mc => Assembly.Load(new AssemblyName("EdiFabric.Sdk.Vda")));
            }

            return null;
        }

        static string LoadString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
