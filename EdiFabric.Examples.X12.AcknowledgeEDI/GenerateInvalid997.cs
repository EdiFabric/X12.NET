using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using System.Collections.Concurrent;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class GenerateInvalid997
    {
        /// <summary>
        /// Generate 997 for an invalid message.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrderInvalid.txt");
            var processedMessages = new ConcurrentBag<string>();

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
                        var allFailed = ts997.AK2Loop1.Where(f => f.AK5.TransactionSetAcknowledgmentCode_01 == "R").ToList();
                        var allAccepted = ts997.AK2Loop1.Where(f => f.AK5.TransactionSetAcknowledgmentCode_01 == "A").ToList();

                        foreach (var failedMessage in allFailed)
                        {
                            if (processedMessages.Contains(failedMessage.AK2.TransactionSetControlNumber_02))
                            {
                                failedMessage.AK5.TransactionSetAcknowledgmentCode_01 = "E";
                            }
                        }

                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        //  In case we decide to process the message anyway, preserve the control number
                        processedMessages.Add(a.Message.ErrorContext.ControlNumber);
                        //  Process the invalid message

                        // Reject message
                        // Log/report it
                        // Inspect MessageErrorContext for the validation errors
                        var errors = a.ErrorContext.Flatten();

                        Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                        foreach (var error in errors)
                        {
                            Debug.WriteLine(error);
                        }
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, "EdiFabric.Examples.X12.Templates.V4010"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }
    }
}
