using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;
using EdiFabric.Sdk.Helpers.X12;

namespace EdiFabric.Sdk.X12.Read
{
    class Examples
    {
        /// <summary>
        /// Reads the EDI stream from start to end.
        /// This method loads the file into memory. Do not use for large files. 
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void ReadAllPurchaseOrders()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TS850>();

            //  4.  Validate each purchase order
            foreach (var po in purchaseOrders)
            {
                MessageErrorContext errorContext;
                if (po.IsValid(out errorContext))
                {
                    //  The purchase order is valid, process it downstream
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

        /// <summary>
        /// Reads one item at a time from the EDI stream.
        /// Use for interchanges containing multiple transactions.
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void ReadPurchaseOrdersOneAtATime()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() 
            //  brings back either a control segment (ISA, GS, GE or IEA) or a transaction
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                while (ediReader.Read())
                {
                    //  3. Check if current item is purchase order
                    var po = ediReader.Item as TS850;
                    if (po != null)
                    {
                        //  4.  Validate it
                        MessageErrorContext errorContext;
                        if (po.IsValid(out errorContext))
                        {
                            //  The purchase order is valid, process it downstream
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
        }

        /// <summary>
        /// Parsing partner specific message by custom template (added an extra field to BGM segment).
        /// </summary>
        public static void ReadCustomTemplate1()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderCustom1.txt");

            //  Resolve custom template by partner ID in the FullTemplateFactory
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                {
                    var msg = ediItem as TS850Custom1;
                    if (msg != null)
                    {
                        MessageErrorContext errorContext;
                        if (msg.IsValid(out errorContext))
                        {
                            //  The purchase order is valid, process it downstream
                        }
                    }

                    Debug.WriteLine(ediItem.GetType().Name);
                }
            }
        }

        /// <summary>
        /// Parsing partner specific message by custom template (added an extra field to BGM segment).
        /// </summary>
        public static void ReadCustomTemplate2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderCustom2.txt");

            //  Resolve custom template by partner ID in the FullTemplateFactory
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                {
                    var msg = ediItem as TS850Custom2;
                    if (msg != null)
                    {
                        MessageErrorContext errorContext;
                        if (msg.IsValid(out errorContext))
                        {
                            //  The purchase order is valid, process it downstream
                        }
                    }

                    Debug.WriteLine(ediItem.GetType().Name);
                }
            }
        }

        /// <summary>
        /// Split a message into parts (blocks of segments) and read each part individually.
        /// Use to process large transactions with repeating groups.
        /// </summary>
        public static void ReadWithSplitting()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderMultiLine.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            //  See
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Find all N1 loops, they are all different ediItems
            var poLoop = ediItems.OfType<TS850Split>().Where(m => m.PO1Loop != null).SelectMany(m => m.PO1Loop);
            Debug.WriteLine(string.Format("PO parts {0}", poLoop.Count()));
        }

        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// The custom validation logic is in the rule
        /// </summary>
        public static void CrossSegmentValidation()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\PurchaseOrderInvalid.txt");

            // The custom validation logic is applied in the template by implementing IEdiValidator.
            // See
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Get the purchase order
            var po = ediItems.OfType<TS850Validation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Value == "N2 segment is missing.");
                Debug.WriteLine(customValidation.Value);
            }
        }

        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void ValidateControlSegments()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\Invoice.txt");

            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                while (ediReader.Read())
                {
                    var isa = ediReader.Item as ISA;
                    if (isa != null)
                    {
                        //  Validate 
                        var isaErrors = isa.Validate();
                        //  Pull the sender id from ISA
                        var senderId = isa.InterchangeSenderID_6;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }

                    var gs = ediReader.Item as GS;
                    if (gs != null)
                    {
                        //  Validate 
                        var gsErrors = gs.Validate();
                        //  Pull the sender id from GS
                        var senderId = gs.SenderIDCode_2;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }

        /// <summary>
        /// Reads purchase orders and invoices batched up in the same interchange.
        /// </summary>
        public static void ReadMixedTransactions()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\MixedTransactions.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
            {
                while (ediReader.Read())
                {
                    //  Process purchase orders if no parsing errors
                    var po = ediReader.Item as TS850;
                    if (po != null && !po.HasErrors)
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);

                    //  Process invoices if no parsing errors
                    var invoice = ediReader.Item as TS810;
                    if (invoice != null && !invoice.HasErrors)
                        ProcessInvoice(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, invoice);
                }
            }
        }

        private static void ProcessPurchaseOrder(ISA isa, GS gs, TS850 purchaseOrder)
        {
            //  Do something with the purchase order
        }

        private static void ProcessInvoice(ISA isa, GS gs, TS810 invoice)
        {
            //  Do something with the invoice
        }

        /// <summary>
        /// Reads file with corrupt ISA.
        /// </summary>
        public static void ReadCorruptIsa()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\CorruptIsa.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
            }
        }

        /// <summary>
        /// Reads file with corrupt UNH and valid UNH
        /// </summary>
        public static void ReadWithContinueOnError()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\CorruptSt.txt");

            //  Set the continue on error flag to true
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory, new X12ReaderSettings() { ContinueOnError = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var purchaseOrders = ediItems.OfType<TS850>();
            foreach (var po in purchaseOrders)
            {
                //  All valid purchase orders were extracted
            }
        }

        /// <summary>
        /// Reads file without envelopes - no ISA, GS, GE or IEA
        /// </summary>
        public static void ReadWithoutEnvelopes()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.X12\MixedTransactionsNoEnvelopes.txt");

            //  Set the NoEnvelope flag to true
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TemplateFactory.FullTemplateFactory, new X12ReaderSettings() { NoEnvelope = true }))
                ediItems = ediReader.ReadToEnd().ToList();            

            var items = ediItems.OfType<EdiMessage>();
            foreach (var item in items)
            {
            }
        }
    }
}
