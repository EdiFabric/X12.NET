using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.X12_004010;

namespace EdiFabric.Sdk.X12
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
        private static void ReadAllPurchaseOrders()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrders.txt");

            //  2.  Read all the contents at once
            List<EdiItem> ediItems;
            using (var ediReader = new X12Reader(purchaseOrderStream, "EdiFabric.Sdk.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  3. Check that the stream contains a well formed ISA header and the contents can be parsed
            var readerErrors = ediItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
                foreach(var readerError in readerErrors)
                {
                    //  Respond with the error context, which contains the standard EDI error code and fault reason
                    var error = readerError.MessageErrorContext.Flatten();
                }
            }

            //  4.  Pull the transactions that are needed (multiple functional groups contain different transaction types, 
            //  e.g. the same document can contain invoices and dispatch advice notes)
            var purchaseOrders = ediItems.OfType<TS850>();

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
        private static void ReadPurchaseOrdersOneAtATime()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() brings back either a control segment (ISA, GS, GE or IEA) or a transaction
            using (var ediReader = new X12Reader(purchaseOrderStream, "EdiFabric.Sdk.X12"))
            {
                //  Call Read() instead of ReadToEnd()
                while (ediReader.Read())
                {
                    var po = ediReader.Item as TS850;
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
        private static void ReadWithAssemblyResolution()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            //  Read the contents, pass in a delegate to resolve the correct assembly containing the rules files
            //  Use this to split the partner specific specs in their own projects or to split the rules by version
            using (var ediReader = new X12Reader(purchaseOrderStream, AssemblyLoadFactory))
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
            if (messageContext.Version == "004010")
                return Assembly.GetExecutingAssembly();

            throw new System.Exception(string.Format("Unsupported version {0}", messageContext.Version));
        }

        /// <summary>
        /// Read with custom encoding, it always uses UTF8 by default
        /// </summary>
        private static void ReadWithEncoding()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            //  Use UTF8
            using (var ediReader = new X12Reader(purchaseOrderStream, "EdiFabric.Sdk.X12", Encoding.UTF8))
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
        private static void ReadWithSplitting()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrderN1Split.txt");

            //  Read the contents as usual
            //  The split is driven by the rule file
            List<EdiItem> ediItems;
            using (var ediReader = new X12Reader(purchaseOrderStream, a => Assembly.GetExecutingAssembly()))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  Find all N1 loops, they are all different ediItems
            var n1Loop = ediItems.OfType<TS850Split>().Where(m => m.N1Loop1 != null).SelectMany(m => m.N1Loop1);
            Debug.WriteLine(string.Format("N1 parts {0}", n1Loop.Count()));
        }

        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// The custom validation logic is in the rule
        /// </summary>
        private static void CrossSegmentValidation()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrderCustomValidation.txt");

            //  Read the contents as usual
            List<EdiItem> ediItems;
            using (var ediReader = new X12Reader(purchaseOrderStream, a => Assembly.GetExecutingAssembly()))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  Get the purchase order
            var po = ediItems.OfType<TS850Validation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Value == "N2 segment is missing.");
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

            //  Load the sample purchase order to a stream 
            Stream purchaseOrderStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.X12.Edi.PurchaseOrder.txt");

            //  Read the contents as usual
            List<EdiItem> ediItems;
            using (var ediReader = new X12Reader(purchaseOrderStream, "EdiFabric.Sdk.X12"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  Find any control segment
            var isa = ediItems.OfType<ISA>().Single();
            
            //  Validate it
            var isaErrors = isa.Validate();
            foreach (var isaError in isaErrors)
                Debug.WriteLine(isaError.Value);

            // Pull the sender id from ISA
            var senderId = ediItems.OfType<ISA>().Single().InterchangeSenderID_6;
            Debug.WriteLine("Sender ID:");
            Debug.WriteLine(senderId);
        }
    }
}
