using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using EdiFabric.Sdk.Helpers;
using EdiFabric.Sdk.Helpers.X12;

namespace EdiFabric.Sdk.X12.Write
{
    class Examples
    {
        /// <summary>
        /// Generate and write EDI document to a stream
        /// </summary>
        public static void WriteSingleInvoiceToStream()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = TransactionBuilders.BuildInvoice("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (invoice.IsValid(out errorContext, true))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name, errorContext.ControlNumber);

                using (var stream = new MemoryStream())
                {
                    using (var writer = new X12Writer(stream))
                    {
                        //  3.  Begin with ISA segment
                        writer.Write(SegmentBuilders.BuildIsa("1"));
                        //  4.  Follow up with GS segment
                        writer.Write(SegmentBuilders.BuildGs("1"));
                        //  5.  Then write the invoice(s)
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
        /// Generate and write EDI document to a file
        /// </summary>
        public static void WriteSingleInvoiceToFile()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = TransactionBuilders.BuildInvoice("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (invoice.IsValid(out errorContext, true))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name,
                    errorContext.ControlNumber);

                //  3.  Write directly to a file
                using (var writer = new X12Writer(@"C:\Test\Output.txt", false))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
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
        /// </summary>
        public static void WriteWithCustomSeparators()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = TransactionBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    //  Set a custom segment separator.
                    var separators = new Separators('|', Separators.X12.ComponentDataElement,
                        Separators.X12.DataElement, Separators.X12.RepetitionDataElement, Separators.X12.Escape);

                    //  Write the ISA with the custom separator set
                    writer.Write(SegmentBuilders.BuildIsa("1"), separators);
                    writer.Write(SegmentBuilders.BuildGs("1"));
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

            var invoice = TransactionBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream, Encoding.UTF8, Environment.NewLine))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
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
                using (var writer = new X12Writer(stream, Encoding.Default, Environment.NewLine))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));

                    //  1.  Write the first invoice
                    writer.Write(TransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second invoice
                    writer.Write(TransactionBuilders.BuildInvoice("2"));

                    //  3.  Write any subsequent invoices...
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple transactions under multiple functional groups in the same EDI stream
        /// </summary>
        public static void WriteMultipleGroups()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));

                    //  1.  Write the first group               
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    //  Write the transactions...
                    writer.Write(TransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second group
                    //  No need to close the previous group with a GE
                    writer.Write(SegmentBuilders.BuildGs("2"));
                    //  Write the transactions...
                    writer.Write(TransactionBuilders.BuildInvoice("2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple interchanges in the same EDI stream
        /// </summary>
        public static void WriteMultipleInterchanges()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    //  1.  Write the first interchange
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(TransactionBuilders.BuildInvoice("1"));

                    //  2.  Write the second interchange
                    //  No need to close the previous interchange with a IEA
                    writer.Write(SegmentBuilders.BuildIsa("2"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(TransactionBuilders.BuildInvoice("1"));
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

            var invoice = TransactionBuilders.BuildInvoice("1");

            //  Initialize some properties with blanks
            invoice.BIG.ReleaseNumber_05 = "";
            invoice.BIG.ChangeOrderSequenceNumber_06 = "";

            using (var stream = new MemoryStream())
            {
                //  Set the PreserveWhitespace flag to true
                using (var writer = new X12Writer(stream, null, "", true))
                {
                    writer.Write(SegmentBuilders.BuildIsa("1"));
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Generate and write EDI document to a stream
        /// </summary>
        public static void WriteSinglePurchaseOrderToStream()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the purchase order
            var po = TransactionBuilders.BuildPurchaseOrder("1");

            //  2.  Validate it by skipping trailer validation
            MessageErrorContext errorContext;
            if (po.IsValid(out errorContext, true))
            {
                Debug.WriteLine("Message {0} with control number {1} is valid.", errorContext.Name, errorContext.ControlNumber);

                using (var stream = new MemoryStream())
                {
                    using (var writer = new X12Writer(stream))
                    {
                        //  3.  Begin with ISA segment
                        writer.Write(SegmentBuilders.BuildIsa("1"));
                        //  4.  Follow up with GS segment
                        writer.Write(SegmentBuilders.BuildGs("1"));
                        //  5.  Then write the purchase order(s)
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
    }
}
