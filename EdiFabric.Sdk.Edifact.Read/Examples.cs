using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D96A;
using EdiFabric.Sdk.TemplateFactories;

namespace EdiFabric.Sdk.Edifact.Read
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
            var purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");
            
            //  2.  Read all the contents
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TSORDERS>();
            
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
            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() 
            //  brings back either a control segment (UNB, UNG, UNE or UNZ) or a transaction
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
            {
                while (ediReader.Read())
                {
                    var po = ediReader.Item as TSORDERS;
                    if (po != null)
                    {
                        //  3.  Validate it
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
        /// Dynamically resolve the type to parse to.
        /// </summary>
        public static void ReadWithTypeResolution()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            //  Use TypeFactory instead of AssemblyFactory
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.TypeFactory))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
            }
        }        

        /// <summary>
        /// Read with custom encoding, UTF8 is used by default.
        /// </summary>
        public static void ReadWithEncoding()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrder.txt");

            //  Use UTF8
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory, Encoding.UTF8))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
            }
        }

        /// <summary>
        /// The reader automatically resolves the delimiters if UNA is present.
        /// </summary>
        public static void ReadWithUna()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderWithUna.txt");

            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
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

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderLINSplit.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            //  See EF_EDIFACT_D96A_TSORDERS_Split.cs in project EdiFabric.Sdk.Edifact.Templates.D96A.Split.
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Find all LIN loops, they are all separate ediItems\EdiMessages
            var linLoop = ediItems.OfType<TSORDERSSplit>().Where(m => m.LINLoop1 != null).SelectMany(m => m.LINLoop1);
            Debug.WriteLine(string.Format("LIN parts {0}", linLoop.Count()));
        }

        /// <summary>
        /// Apply custom validation.
        /// </summary>
        public static void CrossSegmentValidation()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderCustomValidation.txt");

            // The custom validation logic is applied in the template by implementing IEdiValidator.
            // See EF_EDIFACT_D96A_TSORDERS_Validation.cs in project EdiFabric.Sdk.Edifact.Templates.D96A.Validation.
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Get the purchase order
            var po = ediItems.OfType<TSORDERSValidation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Value == "DTM segment is missing.");
                Debug.WriteLine(customValidation.Value);
            }
        }

        /// <summary>
        /// Validate control segments.
        /// </summary>
        public static void ValidateControlSegments()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\PurchaseOrderWithUng.txt");

            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
            {
                while(ediReader.Read())
                {
                    var unb = ediReader.Item as UNB;
                    if(unb != null)
                    {
                        //  Validate 
                        var unbErrors = unb.Validate();
                        //  Pull the sender id from UNB
                        var senderId = unb.INTERCHANGESENDER_2.InterchangeSenderIdentification_1;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }

                    var ung = ediReader.Item as UNG;
                    if (ung != null)
                    {
                        //  Validate 
                        var ungErrors = ung.Validate();
                        //  Pull the sender id from UNG
                        var senderId = ung.APPLICATIONSENDERIDENTIFICATION_2.ApplicationSenderIdentification_1;
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
            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\MixedTransactions.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
            {
                while (ediReader.Read())
                {
                    //  Process purchase orders if no parsing errors
                    var po = ediReader.Item as TSORDERS;
                    if (po != null && !po.HasErrors)
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);

                    //  Process invoices if no parsing errors
                    var invoice = ediReader.Item as TSINVOIC;
                    if (invoice != null && !invoice.HasErrors)
                        ProcessInvoice(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, invoice);
                }
            }
        }

        private static void ProcessPurchaseOrder(UNB unb, UNG ung, TSORDERS purchaseOrder)
        {
            //  Do something with the purchase order
        }

        private static void ProcessInvoice(UNB unb, UNG ung, TSINVOIC invoice)
        {
            //  Do something with the invoice
        }

        /// <summary>
        /// Reads file with corrupt UNB.
        /// </summary>
        public static void ReadCorruptUnb()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\CorruptUnb.txt");

            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory))
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

            Stream purchaseOrderStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Edifact\CorruptUnh.txt");

            //  Set the continue on error flag to true
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, EdifactFactories.AssemblyFactory, Encoding.UTF8, true))
                ediItems = ediReader.ReadToEnd().ToList();

            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var purchaseOrders = ediItems.OfType<TSORDERS>();
            foreach (var po in purchaseOrders)
            {
                //  All valid purchase orders were extracted
            }
        }
    }
}
