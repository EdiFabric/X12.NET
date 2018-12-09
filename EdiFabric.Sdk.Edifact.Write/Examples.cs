using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.Edifact;

namespace EdiFabric.Sdk.Edifact.Write
{
    class Examples
    {
        /// <summary>
        /// Generate and write EDI document to a stream.
        /// </summary>
        public static void WriteSingleInvoiceToStream()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (invoice.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name, errorContext.ControlNumber);

                using (var stream = new MemoryStream())
                {
                    using (var writer = new EdifactWriter(stream))
                    {
                        //  3.  Begin with UNB segment
                        writer.Write(SegmentBuilders.BuildUnb("1"));
                        //  4.  Then write the invoice(s)
                        writer.Write(invoice);
                    }

                    Debug.Write(stream.LoadToString());
                }
            }
            else
            {
                //  The invoice is invalid
                Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", errorContext.Name,
                    errorContext.ControlNumber);

                //  List all error messages
                var errors = errorContext.Flatten();
                foreach (var error in errors)
                {
                    Debug.WriteLine(error);
                }
            }
        }

        /// <summary>
        /// Generate and write EDI document to a stream async.
        /// </summary>
        public static async void WriteSingleInvoiceToStreamAsync()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (invoice.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name, errorContext.ControlNumber);

                using (var stream = new MemoryStream())
                {
                    using (var writer = new EdifactWriter(stream))
                    {
                        //  3.  Begin with UNB segment
                        await writer.WriteAsync(SegmentBuilders.BuildUnb("1"));
                        //  4.  Then write the invoice(s)
                        await writer.WriteAsync(invoice);
                    }

                    Debug.Write(stream.LoadToString());
                }
            }
            else
            {
                //  The invoice is invalid
                Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", errorContext.Name,
                    errorContext.ControlNumber);

                //  List all error messages
                var errors = errorContext.Flatten();
                foreach (var error in errors)
                {
                    Debug.WriteLine(error);
                }
            }
        }

        /// <summary>
        /// Generate and write EDI document to a file.
        /// </summary>
        public static void WriteSingleInvoiceToFile()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (invoice.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name,
                    errorContext.ControlNumber);

                //  3.  Write directly to a file
                using (var writer = new EdifactWriter(@"C:\Test\Output.txt", false))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(invoice);
                }

                Debug.WriteLine("Written to file.");
            }
            else
            {
                //  The invoice is invalid
            }
        }

        /// <summary>
        /// Write with custom separators, by default it uses the standard separators.
        /// UNA segment is automatically applied if any of the custom separators is different than the default.
        /// </summary>
        public static void WriteWithCustomSeparators()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    //  Set a custom segment separator
                    var separators = new Separators('|', Separators.Edifact.ComponentDataElement,
                        Separators.Edifact.DataElement, Separators.Edifact.RepetitionDataElement, Separators.Edifact.Escape);

                    //  Write the UNB with the custom separator set
                    writer.Write(SegmentBuilders.BuildUnb("1"), separators);
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Write with segment postfix.
        /// </summary>
        public static void WriteWithSegmetPostfix()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { Postfix = Environment.NewLine }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple transactions in the same functional group\EDI stream.
        /// </summary>
        public static void WriteMultipleInvoices()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));

                    //  1.  Write the first invoice
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second invoice
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("2"));

                    //  3.  Write any subsequent invoices...
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple transactions under multiple functional groups in the same EDI stream.
        /// </summary>
        public static void WriteMultipleGroups()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));

                    //  1.  Write the first group      
                    writer.Write(SegmentBuilders.BuildUng("1", "INVOIC"));
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second group
                    //  No need to close the previous group with a UNE
                    writer.Write(SegmentBuilders.BuildUng("2", "ORDERS"));
                    writer.Write(EdifactTransactionBuilders.BuildPurchaseOrder("1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple interchanges in the same EDI stream.
        /// </summary>
        public static void WriteMultipleInterchanges()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    //  1.  Write the first interchange
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second interchange
                    //  No need to close the previous interchange with a IEA
                    writer.Write(SegmentBuilders.BuildUnb("2"));
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Write transactions with whitespace.
        /// </summary>
        public static void WriteSegmentWithWhitespace()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EdifactTransactionBuilders.BuildInvoice("1");

            //  Initialize a blank property
            invoice.BGM.Responsetypecoded_04 = "";
            
            using (var stream = new MemoryStream())
            {
                //  Set PreserveWhitespace flag to true
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { PreserveWhitespace = true }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Generate and write EDI document to a stream.
        /// </summary>
        public static void WriteSinglePurchaseOrderToStream()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the purchase order
            var po = EdifactTransactionBuilders.BuildPurchaseOrder("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (po.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name, errorContext.ControlNumber);

                using (var stream = new MemoryStream())
                {
                    using (var writer = new EdifactWriter(stream))
                    {
                        //  3.  Begin with UNB segment
                        writer.Write(SegmentBuilders.BuildUnb("1"));
                        //  4.  Then write the purchase order(s)
                        writer.Write(po);
                    }

                    Debug.Write(stream.LoadToString());
                }
            }
            else
            {
                //  The purchase order is invalid
                Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", errorContext.Name,
                    errorContext.ControlNumber);

                //  List all error messages
                var errors = errorContext.Flatten();
                foreach (var error in errors)
                {
                    Debug.WriteLine(error);
                }
            }
        }

        /// <summary>
        /// Write to stream without envelopes - no UNB, UNG, UNE or UNZ.
        /// </summary>
        public static void WriteWithoutEnvelopes()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set the separators 
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { Separators = Separators.Edifact }))
                {                    
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));                    
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Write without auto trailers
        /// </summary>
        public static void WriteWithoutAutoTrailers()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set AutoTrailers to false
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings { AutoTrailers = false }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(EdifactTransactionBuilders.BuildInvoice("1"));
                    //  trailers need to be manually written   
                }

                using (var writer = new StreamWriter(stream))
                {
                    var unz = new UNZ();
                    unz.InterchangeControlCount_1 = "1";
                    unz.InterchangeControlReference_2 = "000000001";
                    writer.Write(unz.ToEdi(Separators.Edifact));

                    writer.Flush();

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
