using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.X12_004010;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.X12;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Sdk.X12.T810
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Invoices
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\Invoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS810>();

            foreach (var transaction in transactions)
            {
                MessageErrorContext mec;
                if (transaction.IsValid(out mec))
                {
                    //  valid
                }
                else
                {
                    //  invalid
                    var errors = mec.Flatten();
                }
            }
        }

        /// <summary>
        /// Write Invoices
        /// </summary>
        static void Write()
        {
            using (var stream = new MemoryStream())
            {
                var transaction = X12TransactionBuilders.BuildInvoice("1");

                MessageErrorContext mec;
                if (transaction.IsValid(out mec, true))
                {
                    //  valid
                    using (var writer = new X12Writer(stream))
                    {
                        writer.Write(SegmentBuilders.BuildIsa("1"));
                        writer.Write(SegmentBuilders.BuildGs("1"));
                        writer.Write(transaction);
                    }

                    var ediString = stream.LoadToString();
                }
                else
                {
                    //  invalid
                    var errors = mec.Flatten();
                }
            }
        }
    }
}
