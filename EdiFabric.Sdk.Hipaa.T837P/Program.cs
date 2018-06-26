using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.X12;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EdiFabric.Sdk.Hipaa.T837P
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Claim
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Hipaa\ClaimPayment.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TS837P>();

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
        /// Write Claim
        /// </summary>
        static void Write()
        {
            using (var stream = new MemoryStream())
            {
                var transaction = HipaaTransactionBuilders.BuildClaim("1");

                MessageErrorContext mec;
                if (transaction.IsValid(out mec, true))
                {
                    var separators = new Separators(Separators.X12.Segment, ':', Separators.X12.DataElement, Separators.X12.RepetitionDataElement, Separators.X12.Escape);

                    //  valid
                    using (var writer = new X12Writer(stream, Encoding.UTF8, Environment.NewLine))
                    {
                        writer.Write(SegmentBuilders.BuildIsa("1"), separators);
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
