﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Generate997ForDuplicateInterchange
    {
        /// <summary>
        /// Detect duplicate interchanges.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\DuplicateInterchange.txt");

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
                    if (a.InDuplicateInterchange)
                    {
                        Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlNumber_13));
                        Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupControlNumber_6));
                        Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.ErrorContext.ControlNumber);
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
                using (var ediReader = new X12Reader(edi, "EdiFabric.Templates.X12"))
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
