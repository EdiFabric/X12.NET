using EdiFabric.Framework.Writers;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.Vda;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace EdiFabric.Sdk.Vda.Write
{
    class Examples
    {
        /// <summary>
        /// Generate and write EDI document to a stream
        /// </summary>
        static void Write4905()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the 4905 message with data from database, service or domain objects\logic.
            var vda4905 = TransactionBuilders.BuildDeliveryInstruction();

            using (var stream = new MemoryStream())
            {
                //  2.  Use CRLF(new line) as segment postfix for clarity
                //  Always agree postfixes and separators with the trading partner
                using (var writer = new VdaWriter(stream, Environment.NewLine, Encoding.UTF8))
                {
                    //  3.  Write all transactions
                    writer.Write(vda4905);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
