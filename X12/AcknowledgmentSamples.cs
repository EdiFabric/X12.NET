using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using System.Collections.Concurrent;

namespace EdiFabric.Sdk.X12
{
    class AcknowledgmentSamples
    {
        /// <summary>
        /// Runs all acknowledgment samples
        /// Check Output windows for debug data
        /// </summary>
        public static void Run()
        {
            Generate999ForValid();
            Generate997ForValid();
            Generate999ForInvalid();
            Generate997WithDuplicateMessage();
            Generate997WithDuplicateGroup();
            Generate997WithDuplicateInterchange();
            Generate997WithControlNumbers();            
        }

        /// <summary>
        /// Generates 999 for a valid purchase order.
        /// </summary>
        public static void Generate999ForValid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "999")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                AckVersion = AckVersion.Hipaa_999,
                // Turn on AK2 for valid messages
                GenerateForValidMessages = true
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Generate a 997 for a valid purchase order.
        /// </summary>
        public static void Generate997ForValid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "997")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Generate a 997 for an invalid purchase order.
        /// </summary>
        public static void Generate999ForInvalid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrderInvalid.txt");
            var processedMessages = new ConcurrentBag<string>();

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "999")
                    {
                        var ack999 = a.Message as TS999;
                        var allFailed = ack999.AK2Loop1.Where(f => f.IK5.TransactionSetAcknowledgmentCode_01 == "R").ToList();
                        var allAccepted = ack999.AK2Loop1.Where(f => f.IK5.TransactionSetAcknowledgmentCode_01 == "A").ToList();

                        foreach (var failedMessage in allFailed)
                        {
                            if (processedMessages.Contains(failedMessage.AK2.TransactionSetControlNumber_02))
                            {
                                failedMessage.IK5.TransactionSetAcknowledgmentCode_01 = "E";
                            }
                        }

                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },                
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        //  In case we decide to process the message anyway, preserve the control number
                        processedMessages.Add(a.Message.GetControlNumber());
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
                AckVersion = AckVersion.Hipaa_999,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate messages.
        /// </summary>
        public static void Generate997WithDuplicateMessage()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.DuplicateMessage.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "997")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
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

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate groups.
        /// </summary>
        public static void Generate997WithDuplicateGroup()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.DetectDuplicateGroup.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "997")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        if (a.InDuplicateGroup)
                        {
                            Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlNumber_13));
                            Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupControlNumber_6));
                            Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetControlNumber());
                            Debug.WriteLine("Is in duplicate group: {0}", a.InDuplicateGroup);
                            // reject message
                        }
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false,
                // Check for group duplicates
                GroupDuplicates = true
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate interchanges with external method.
        /// </summary>
        public static void Generate997WithDuplicateInterchange()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.DetectDuplicateInterchange.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "997")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        if (a.InDuplicateInterchange)
                        {
                            Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlNumber_13));
                            Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupControlNumber_6));
                            Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetControlNumber());
                            Debug.WriteLine("Is in duplicate interchange: {0}", a.InDuplicateInterchange);
                            // reject message
                        }
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false,
                // Check for interchange duplicates
                InterchangeDuplicates = IsDuplicate
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Auto increments non default control numbers.
        /// </summary>
        public static void Generate997WithControlNumbers()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "TA1")
                    {
                        // a.AckInterchange is TA1 
                    }

                    if (a.Message.Name == "997")
                    {
                        var ack = BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                AckVersion = AckVersion.X12_997,
                Incrementers = new ControlIncrementers(23, 15, 5)
            };
            Debug.WriteLine("Start interchange control number: {0}", settings.Incrementers.LatestInterchange);
            Debug.WriteLine("Start group control number: {0}", settings.Incrementers.LatestGroup);
            Debug.WriteLine("Start transaction control number: {0}", settings.Incrementers.LatestMessage);

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();

            Debug.WriteLine("Last interchange control number: {0}", settings.Incrementers.LatestInterchange);
            Debug.WriteLine("Last group control number: {0}", settings.Incrementers.LatestGroup);
            Debug.WriteLine("Last transaction control number: {0}", settings.Incrementers.LatestMessage);
        }

        private static string BuildAck(ISA isa, GS gs, EdiMessage ack)
        {
            var memoryStream = new MemoryStream();
            var writer = new X12Writer(memoryStream, Encoding.Default, Environment.NewLine);
            writer.Write(isa);
            writer.Write(gs);
            writer.Write(ack);
            writer.Flush();
            memoryStream.Position = 0;
            using (var reader = new StreamReader(memoryStream))
                return reader.ReadToEnd();
        }

        private static bool IsDuplicate(string key)
        {
            if (key == "810000264")
                return true;

            return false;
        }
    }
}
