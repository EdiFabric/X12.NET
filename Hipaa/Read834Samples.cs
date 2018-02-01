using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.HIPAA_005010X222A1_834;

namespace EdiFabric.Sdk.Hipaa
{
    class Read834Samples
    {
        /// <summary>
        /// Runs all read samples
        /// Check Output window for debug data
        /// </summary>
        public static void Run()
        {
            ReadSingleBenefit();
        }

        /// <summary>
        /// Reads the EDI stream from start to end
        /// For full usage and features please refer to the X12 SDK
        /// </summary>
        static void ReadSingleBenefit()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");
            //  1.  Load the sample benefit to a stream
            Stream benefitStream =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("EdiFabric.Sdk.Hipaa.Edi.BenefitEnrollment.txt");

            //  2.  Read all the contents at once
            List<EdiItem> ediItems;
            using (var ediReader = new X12Reader(benefitStream, AssemblyLoadFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            //  3. Check that the stream contains a well formed ISA header
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
            var members = ediItems.OfType<TS834>();

            //  5.  Validate all claims.
            foreach (var member in members)
            {
                MessageErrorContext errorContext;
                if (member.IsValid(out errorContext))
                {
                    //  The claim is valid, process it downstream
                }
                else
                {
                    //  The claim is invalid
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
        /// Sample factory to load the correct rules assembly
        /// It is invoked for each transaction\message read from the EDI stream
        /// </summary>
        /// <param name="messageContext">The message context which contains the message version, the sender id and many more</param>
        /// <returns>The assembly containing the rule file for that message</returns>
        private static Assembly AssemblyLoadFactory(MessageContext messageContext)
        {
            //  Resolve by sender
            if (messageContext.ReceiverId.TrimEnd() == "PartnerA")
                return Assembly.Load("EdiFabric.Sdk.Hipaa.Rules.PartnerA");

            //  Resolve by version
            if (messageContext.Version == "005010X220A1")
                return Assembly.Load("EdiFabric.Sdk.Hipaa");

            throw new System.Exception(string.Format("Unsupported version {0}", messageContext.Version));
        }
    }
}
