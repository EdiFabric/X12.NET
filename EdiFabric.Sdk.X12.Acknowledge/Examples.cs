using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using System.Collections.Concurrent;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.TemplateFactories;
using EdiFabric.Rules.X12_005010X231A1;
using System.Collections.Generic;
using EdiFabric.Core.Model.Ack;

namespace EdiFabric.Sdk.X12.Acknowledge
{
    class Examples
    {
        /// <summary>
        /// Generate 999 for a valid message.
        /// </summary>
        public static void Generate999ForValid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var tsTa1 = a.Message as TSTA1;
                    var ts999 = a.Message as TS999;

                    if (tsTa1 != null)
                    {
                        // a.Message is TA1 
                    }

                    if (ts999 != null)
                    {
                        //  Inspect the acknowledgment
                        var ackCode = ts999.AK9.FunctionalGroupAcknowledgeCode_01;

                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts999, AckVersion.Hipaa_999);
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

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Generate a 997 for a valid message.
        /// </summary>
        public static void Generate997ForValid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.txt");

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

                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
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

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Generate 999 for an invalid message.
        /// </summary>
        public static void Generate999ForInvalid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderInvalid.txt");
            var processedMessages = new ConcurrentBag<string>();

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var tsTa1 = a.Message as TSTA1;
                    var ts999 = a.Message as TS999;

                    if (tsTa1 != null)
                    {
                        // a.Message is TA1 
                    }

                    if (ts999 != null)
                    {
                        var allFailed = ts999.AK2Loop1.Where(f => f.IK5.TransactionSetAcknowledgmentCode_01 == "R").ToList();
                        var allAccepted = ts999.AK2Loop1.Where(f => f.IK5.TransactionSetAcknowledgmentCode_01 == "A").ToList();

                        foreach (var failedMessage in allFailed)
                        {
                            if (processedMessages.Contains(failedMessage.AK2.TransactionSetControlNumber_02))
                            {
                                failedMessage.IK5.TransactionSetAcknowledgmentCode_01 = "E";
                            }
                        }

                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts999, AckVersion.Hipaa_999);
                        Debug.Write(ack);
                    }
                },                
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        //  In case we decide to process the message anyway, preserve the control number
                        processedMessages.Add(a.Message.GetTransactionContext().HeaderControlNumber);
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

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Detect duplicate messages.
        /// </summary>
        public static void Generate997WithDuplicateMessage()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\DuplicateMessage.txt");

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

                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
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
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Detect duplicate groups.
        /// </summary>
        public static void Generate997WithDuplicateGroup()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\DuplicateGroup.txt");

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
                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.InDuplicateGroup)
                    {
                        Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlNumber_13));
                        Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupControlNumber_6));
                        Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetTransactionContext().HeaderControlNumber);
                        Debug.WriteLine("Is in duplicate group: {0}", a.InDuplicateGroup);
                        // reject message
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false,
                // Check for group duplicates
                GroupDuplicates = true
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Detect duplicate interchanges.
        /// </summary>
        public static void Generate997WithDuplicateInterchange()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\DuplicateInterchange.txt");

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
                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.InDuplicateInterchange)
                    {
                        Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlNumber_13));
                        Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupControlNumber_6));
                        Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetTransactionContext().HeaderControlNumber);
                        Debug.WriteLine("Is in duplicate interchange: {0}", a.InDuplicateInterchange);
                        // reject message
                    }
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false,
                // Check for interchange duplicates
                InterchangeDuplicates = IsDuplicate
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        /// <summary>
        /// Auto increment custom control numbers.
        /// </summary>
        public static void Generate997WithControlNumbers()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrder.txt");

            int isaControlNumber = 28;
            int gsControlNumber = 35;
            Debug.WriteLine("Start interchange control number: {0}", isaControlNumber);
            Debug.WriteLine("Start group control number: {0}", gsControlNumber);

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
                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997, ++isaControlNumber, ++gsControlNumber);
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
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }

            Debug.WriteLine("Last interchange control number: {0}", isaControlNumber);
            Debug.WriteLine("Last group control number: {0}", gsControlNumber);
        }

        /// <summary>
        /// Generate custom 999.
        /// </summary>
        public static void GenerateCustom999()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\MixedTransactions.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var ts999 = a.Message as TS999;

                    if (a.AckType == AckType.Technical)
                    {
                        // a.Message is TA1 
                    }

                    if (ts999 != null)
                    {
                        var custom999 = new TS999Custom1 { AK1Loops = new List<TS999_AK1Loop>() };

                        var ak1Loop = new TS999_AK1Loop();

                        custom999.ST = ts999.ST;

                        ak1Loop.AK1 = ts999.AK1;
                        ak1Loop.AK2Loop1 = ts999.AK2Loop1;
                        ak1Loop.AK9 = ts999.AK9;

                        custom999.AK1Loops.Add(ak1Loop);

                        var ack = X12Helpers.BuildAck(a.InterchangeHeader, a.GroupHeader, custom999, AckVersion.Hipaa_999);
                        Debug.Write(ack);

                    }
                },
                AckVersion = AckVersion.Hipaa_999,
                TechnicalAck = TechnicalAck.Enforce
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, X12Factories.FullTemplateFactory))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }

        private static bool IsDuplicate(string key)
        {
            if (key == "000000263")
                return true;

            return false;
        }
    }
}
