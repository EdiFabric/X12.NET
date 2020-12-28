using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.X12.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Translator Demo 

            //  Supported versions/transactions are:
            //  X12 004010, all classes that begin with TS in namespace EdiFabric.Templates.X12004010
            //  HIPAA 005010, all classes that begin with TS in namespace EdiFabric.Templates.Hipaa5010

            //  If you need a different X12 version or transaction, please contact us at https://support.edifabric.com/hc/en-us/requests/new, EdiFabric supports all versions and transaction for X12/HIPAA.

            SerialKey.Set(TrialLicense.SerialKey);

            Translate_HIPAA_5010();
            Translate_X12_4010();
        }   

        public static void Translate_X12_4010()
        {
            //  Change the path to point to your own file to test with
            var path = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrders.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(path, "EdiFabric.Templates.X12", new X12ReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            foreach (var message in ediItems.OfType<EdiMessage>())
            {
                if (!message.HasErrors)
                {
                    //  Message was successfully parsed

                    MessageErrorContext mec;
                    if (message.IsValid(out mec))
                    {
                        //  Message was successfully validated
                    }
                    else
                    {
                        //  Message failed validation with the following validation issues:
                        var validationIssues = mec.Flatten();
                    }
                }
                else
                {
                    //  Message was partially parsed with errors
                }
            }

        }   //  Add a breakpoint here, run in debug mode and inspect ediItems

        public static void Translate_HIPAA_5010()
        {
            //  Change the path to point to your own file to test with
            var path = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\HIPAA\ClaimPayment.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(path, "EdiFabric.Templates.Hipaa", new X12ReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            foreach (var message in ediItems.OfType<EdiMessage>())
            {
                if (!message.HasErrors)
                {
                    //  Message was successfully parsed

                    MessageErrorContext mec;
                    if (message.IsValid(out mec))
                    {
                        //  Message was successfully validated
                    }
                    else
                    {
                        //  Message failed validation with the following validation issues:
                        var validationIssues = mec.Flatten();
                    }
                }
                else
                {
                    //  Message was partially parsed with errors
                }
            }

        }   //  Add a breakpoint here, run in debug mode and inspect ediItems
    }
}
