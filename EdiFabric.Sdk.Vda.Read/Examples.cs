using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Vda;
using EdiFabric.Sdk.Helpers.Vda;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EdiFabric.Sdk.Vda.Read
{
    class Examples
    {
        /// <summary>
        /// Reads the EDI stream from start to end
        /// The 4905 message is postfixed for clarity. Remove the CR\LF to test a real message if needed.
        /// </summary>
        public static void Read4905()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample 4905 to a stream
            var vdaStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Vda\Vda_4905_02.txt");
           
            //  2.  Read all the contents at once
            //  Remove the last parameter Environment.NewLine when reading messages without postfix
            List<IEdiItem> ediItems;
            using (var ediReader = new VdaReader(vdaStream, TemplateFactory.FullTemplateFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  3. Check that the stream contains a recognizable message and the contents can be parsed
            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
                foreach (var readerError in readerErrors)
                {
                    //  Respond with the error context, which contains the standard EDI error code and fault reason
                    var error = readerError.MessageErrorContext.Flatten();
                }
            }

            //  4.  Pull the transactions that are needed
            var vda4905s = ediItems.OfType<TS4905>();
        }
    }
}
