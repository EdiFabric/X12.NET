using EdiFabric.Core.Model.Ack;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.Edifact.Model;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.TemplateFactories;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Sdk.Edifact.Acknowledge
{
    class Examples
    {
        /// <summary>
        /// Generate CONTRL for a valid message.
        /// </summary>
        public static void GenerateContrlForValid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.Message is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
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
                // Turn on UCM for valid messages
                GenerateForValidMessages = true
            };

            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Generate CONTRL for an invalid message.
        /// </summary>
        public static void GenerateContrlForInvalid()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderInvalid.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.AckInterchange is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is invalid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true
            };

            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate messages.
        /// </summary>
        public static void GenerateContrlWithDuplicateMessage()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\DuplicateMessage.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.AckInterchange is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors && a.ErrorContext.Codes.Any(c => c == Core.ErrorCodes.MessageErrorCode.DuplicateMessageControlNumber))
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is duplicate.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true,
                TransactionSetDuplicates = true,
                TechnicalAck = TechnicalAck.Enforce
            };

            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate groups.
        /// </summary>
        public static void GenerateContrlWithDuplicateGroup()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\DuplicateGroup.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.AckInterchange is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        if (a.InDuplicateGroup)
                        {
                            Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlReference_5));
                            Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupReferenceNumber_5));
                            Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetTransactionContext().HeaderControlNumber);
                            Debug.WriteLine("Is in duplicate group: {0}", a.InDuplicateGroup);
                            // reject message
                        }
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true,
                GroupDuplicates = true
            };

            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Detects duplicate interchanges with external method.
        /// </summary>
        public static void GenerateContrlWithDuplicateInterchange()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\DuplicateInterchange.txt");

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.AckInterchange is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        if (a.InDuplicateInterchange)
                        {
                            Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlReference_5));
                            Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.GetTransactionContext().HeaderControlNumber);
                            Debug.WriteLine("Is in duplicate interchange: {0}", a.InDuplicateInterchange);
                            // reject message
                        }
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true,
                InterchangeDuplicates = IsDuplicate
            };

            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }

        /// <summary>
        /// Auto increments non default control numbers.
        /// </summary>
        public static void GenerateContrlWithControlNumbers()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");
            int unbControlNumber = 28;
            int ungControlNumber = 35;
            Debug.WriteLine("Start interchange control number: {0}", unbControlNumber);
            Debug.WriteLine("Start group control number: {0}", ungControlNumber);

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Technical)
                    {
                        // a.AckInterchange is technical acknowledgment 
                    }

                    if (a.Message.Name == "CONTRL" && a.AckType == AckType.Functional)
                    {
                        var ack = EdifactHelpers.BuildAck(a.InterchangeHeader, a.GroupHeader, a.Message, ++unbControlNumber, ++ungControlNumber);
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
            };
          
            var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings);
            using (var ediReader = new EdifactReader(edi, EdifactFactories.FullTemplateFactory))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();

            Debug.WriteLine("Last interchange control number: {0}", unbControlNumber);
            Debug.WriteLine("Last group control number: {0}", ungControlNumber);
        }        

        private static bool IsDuplicate(string key)
        {
            if (key == "131")
                return true;

            return false;
        }
    }
}
