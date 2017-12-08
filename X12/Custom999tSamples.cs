using System.Diagnostics;
using System.Reflection;
using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Rules.X12_005010X231A1;
using System.Collections.Generic;

namespace EdiFabric.Sdk.X12
{
    class Custom999Samples
    {
        /// <summary>
        /// Runs all custom 999 acknowledgment samples
        /// Check Output windows for debug data
        /// </summary>
        public static void Run()
        {
            GenerateCustom999();
        }

        /// <summary>
        /// Generates custom 999.
        /// </summary>
        public static void GenerateCustom999()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrdersMultipleGroups.txt");
            var custom999 = new Custom999 { AK1Loops = new List<TS999_AK1Loop>() };
            ISA currentIsa = null;
            GS currentGs = null;
            int isaCounter = 0;
            int gsCounter = 0;
           
            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    if(a.AckType == AckType.Technical)
                    {
                        //  Raise 999 acknowledgment at the end of every interchange 
                        var currentAck = Helpers.BuildAck(currentIsa, currentGs, custom999, AckVersion.Hipaa_999, ++isaCounter, ++gsCounter);
                        Debug.Write(currentAck);
                        custom999 = null;
                    }

                    if (a.AckType == AckType.Implementation)
                    {
                        currentIsa = a.InterchangeHeader;
                        currentGs = a.GroupHeader;

                        if (custom999 == null)
                            custom999 = new Custom999 { AK1Loops = new List<TS999_AK1Loop>() };

                        var ak1Loop = new TS999_AK1Loop();
                        var current999 = a.Message as TS999;
                        if (current999 != null)
                        {
                            if (custom999.ST == null)
                                custom999.ST = current999.ST;

                            ak1Loop.AK1 = current999.AK1;
                            ak1Loop.AK2Loop1 = current999.AK2Loop1;
                            ak1Loop.AK9 = current999.AK9;

                            custom999.AK1Loops.Add(ak1Loop);
                        }
                    }
                },
                AckVersion = AckVersion.Hipaa_999,
                TechnicalAck = TechnicalAck.Enforce
            };

            var ackMan = new Plugins.Acknowledgments.X12.AckMan(settings);
            using (var ediReader = new X12Reader(edi, "EdiFabric.Sdk.X12"))
            {
                while (ediReader.Read())
                    ackMan.Publish(ediReader.Item);
            }
            ackMan.Complete();
        }
    }
}
