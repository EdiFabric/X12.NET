using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Generate997ForDuplicateGroup
    {
        /// <summary>
        /// Detect duplicate groups.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\DuplicateGroup.txt");

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
                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
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
                using (var ediReader = new X12Reader(edi, "EdiFabric.Examples.X12.Templates.V4010"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }
    }
}
