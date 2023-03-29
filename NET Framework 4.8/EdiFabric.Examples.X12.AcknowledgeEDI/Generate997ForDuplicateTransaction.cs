using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Generate997ForDuplicateTransaction
    {
        /// <summary>
        /// Detect duplicate messages.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\DuplicateMessage.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var tsTa1 = a.Message as TSTA1;
                    var ts997 = a.Message as TS997;

                    if (tsTa1 != null)
                    {
                        // a.Message is TA1 
                    }

                    if (ts997 != null)
                    {
                        //  Inspect the acknowledgment
                        var ackCode = ts997.AK9.FunctionalGroupAcknowledgeCode_01;

                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        Debug.WriteLine("Message {0} with control number {1} is invalid: {2}.", a.ErrorContext.Name,
                            a.ErrorContext.ControlNumber, a.ErrorContext.Codes.FirstOrDefault());
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false,
                // Check for message duplicates
                TransactionSetDuplicates = true
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, "EdiFabric.Templates.X12"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }
    }
}
