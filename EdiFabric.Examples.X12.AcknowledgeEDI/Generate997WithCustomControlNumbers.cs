using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Generate997WithCustomControlNumbers
    {
        /// <summary>
        /// Auto increment custom control numbers.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrder.txt");

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
                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997, ++isaControlNumber, ++gsControlNumber);
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
                AckVersion = AckVersion.X12_997
            };

            using (var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings))
            {
                using (var ediReader = new X12Reader(edi, "EdiFabric.Examples.X12.Templates.V4010"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }

            Debug.WriteLine("Last interchange control number: {0}", isaControlNumber);
            Debug.WriteLine("Last group control number: {0}", gsControlNumber);
        }
    }
}
