using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D96A;

namespace EdiFabric.Sdk.Edifact
{
    class ReadSamples
    {
        /// <summary>
        /// Runs all read samples
        /// Check Output window for debug data
        /// </summary>
        public static void Run()
        {
            ReadAllPurchaseOrders();
            ReadPurchaseOrdersOneAtATime();
            ReadWithAssemblyResolution();
            ReadWithEncoding();
            ReadWithUna();
            ReadWithSplitting();
            CrossSegmentValidation();
            ValidateControlSegments();
        }

        /// <summary>
        /// Reads the EDI stream from start to end
        /// The interchange contains two purchase orders:
        /// The first one is valid
        /// The second one is invalid
        /// </summary>
        static void ReadAllPurchaseOrders()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
            Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrders.txt");

            //  2.  Read all the contents at once
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  3. Check that the stream contains a well formed UNB header
            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
                foreach (var readerError in readerErrors)
                {
                    //  Respond with the error context, which contains the standard EDI error code and fault reason
                    var error = readerError.MessageErrorContext.Flatten();
                }
            }

            //  4.  Pull the transactions that are needed (multiple functional groups contain different transaction types, 
            //  e.g. the same document can contain invoices and dispatch advice notes)
            var purchaseOrders = ediItems.OfType<TSORDERS>();
            
            //  5.  Validate all purchase orders.
            //  Validation uses the validation attributes in the rule file as well as invokes all custom validators.
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
                    //  Report it back to the sender, log, etc.

                    //  Inspect MessageErrorContext for the validation errors
                    var errors = errorContext.Flatten();

                    //  List all error messages
                    Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", errorContext.Name,
                        errorContext.ControlNumber);
                    foreach (var error in errors)
                    {
                        Debug.WriteLine(error);
                    }
                }
            }
        }

        /// <summary>
        /// Reads one item at a time from the EDI stream
        /// The interchange contains two purchase orders:
        /// The first is valid
        /// The second is invalid
        /// </summary>
        static void ReadPurchaseOrdersOneAtATime()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() brings back either a control segment (UNB, UNG, UNE or UNZ) or a transaction
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact"))
            {
                //  Call Read() instead of ReadToEnd()
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
                            //  Report it back to the sender, log, etc.

                            //  Inspect MessageErrorContext for the validation errors
                            var errors = errorContext.Flatten();

                            //  List all error messages
                            Debug.WriteLine("Message {0} with control number {1} is invalid with errors:", errorContext.Name,
                                errorContext.ControlNumber);
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
        /// Dynamically resolve the rules assembly
        /// </summary>
        static void ReadWithAssemblyResolution()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrder.txt");

            //  Read the contents, pass in a delegate to resolve the correct assembly containing the rules files
            //  Use this to split the partner specific rules in their own projects or to split the specs by version
            using (var ediReader = new EdifactReader(purchaseOrderStream, AssemblyLoadFactory))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
            }
        }

        /// <summary>
        /// Sample factory to load the correct rules assembly
        /// It is invoked for each transaction\message read from the EDI stream
        /// </summary>
        /// <param name="messageContext">The message context which contains the message version, the sender id and many more</param>
        /// <returns>The assembly containing the rule file for that message</returns>
        private static Assembly AssemblyLoadFactory(MessageContext messageContext)
        {
            //  Resolve by sender
            if (messageContext.SenderId == "PartnerA")
                return Assembly.Load("EdiFabric.Rules.PartnerA");

            //  Resolve by version
            //  Use the C# rules instead of the NuGet packages
            if (messageContext.Version == "D96A")
                return Assembly.GetExecutingAssembly();

            throw new System.Exception(string.Format("Unsupported version {0}", messageContext.Version));
        }

        /// <summary>
        /// Read with custom encoding, it always uses UTF8 by default
        /// </summary>
        static void ReadWithEncoding()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrder.txt");

            //  Use UTF8
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact", Encoding.UTF8))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
            }
        }

        /// <summary>
        /// The reader automatically processes UNA segments and no additional configuration is required
        /// </summary>
        static void ReadWithUna()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrderWithUna.txt");

            //  Read the contents as usual
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact"))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                foreach (var ediItem in ediItems)
                    Debug.WriteLine(ediItem.GetType().Name);
            }
        }

        /// <summary>
        /// Split a message to parts (blocks of segments) and read each part individually
        /// This is used for processing very large transactions
        /// </summary>
        static void ReadWithSplitting()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrderLINSplit.txt");

            //  Read the contents as usual
            //  The split is driven by the rule file
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, a => Assembly.GetExecutingAssembly()))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  Find all LIN loops, they are all different ediItems
            var linLoop = ediItems.OfType<TSORDERSSplit>().Where(m => m.LINLoop1 != null).SelectMany(m => m.LINLoop1);
            Debug.WriteLine(string.Format("LIN parts {0}", linLoop.Count()));
        }

        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// The custom validation logic is in the rule
        /// </summary>
        static void CrossSegmentValidation()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrderCustomValidation.txt");

            //  Read the contents as usual
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, a => Assembly.GetExecutingAssembly()))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

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
        /// Validate the typed control segments
        /// </summary>
        private static void ValidateControlSegments()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Edifact.Edi.PurchaseOrderLINSplit.txt");

            //  Read the contents
            List<EdiItem> ediItems;
            using (var ediReader = new EdifactReader(purchaseOrderStream, "EdiFabric.Sdk.Edifact"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  Find any control segment
            var unb = ediItems.OfType<UNB>().Single();
            
            //  Validate it
            var unbErrors = unb.Validate();

            //  Pull the sender id from UNB
            var senderId = ediItems.OfType<UNB>().Single().INTERCHANGESENDER_2.InterchangeSenderIdentification_1;
            Debug.WriteLine("Sender ID:");
            Debug.WriteLine(senderId);
        }
    }
}
