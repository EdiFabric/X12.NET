using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using System;
using EdiFabric.Rules.Vda;

namespace EdiFabric.Sdk.Vda
{
    class ReadSamples
    {
        /// <summary>
        /// Runs all read samples
        /// Check Output window for debug data
        /// </summary>
        public static void Run()
        {
            Read4905();
        }

        /// <summary>
        /// Reads the EDI stream from start to end
        /// The 4905 message is postfixed for clarity. Remove the CR\LF to test a real message if needed.
        /// </summary>
        private static void Read4905()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample 4905 to a stream 
            Stream vda4905Stream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Vda.Edi.Vda_4905_02.txt");

            //  2.  Read all the contents at once
            //  Remove the last parameter Environment.NewLine when reading messages without postfix
            List<EdiItem> ediItems;
            using (var ediReader = new VdaReader(vda4905Stream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  3. Check that the stream contains a recognizable message and the contents can be parsed
            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
                foreach(var readerError in readerErrors)
                {
                    //  Respond with the error context, which contains the standard EDI error code and fault reason
                    var error = readerError.MessageErrorContext.Flatten();
                }
            }

            //  4.  Pull the transactions that are needed
            var vda4905s = ediItems.OfType<TS4905>();            
        }

        /// <summary>
        /// Sample factory to load the correct message context
        /// It is invoked for each transaction\message read from the EDI stream
        /// </summary>
        /// <param name="segment">The next 128 bytes</param>
        /// <returns>The message context</returns>
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
                        mc => Assembly.GetExecutingAssembly());
            }

            return null;
        }
    }
}
