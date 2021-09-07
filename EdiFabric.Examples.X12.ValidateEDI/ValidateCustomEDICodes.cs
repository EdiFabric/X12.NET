using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateCustomEDICodes
    {
        /// <summary>
        /// Validate with custom EDI codes, different than the standard EDI codes
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set EDI codes map where the original code type will be substituted with the partner-specific code type
            Dictionary<Type, Type> codeSetMap = new Dictionary<Type, Type>();
            codeSetMap.Add(typeof(X12_ID_353), typeof(X12_ID_353_PartnerA));

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { DataElementTypeMap = codeSetMap }))
                {
                    //  Invalid code value
                    var customCodeError = errorContext.Errors.SingleOrDefault(e => e.Errors.Any(de => de.Code == DataElementErrorCode.InvalidCodeValue));

                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }

        /// <summary>
        /// Validate with custom EDI codes, different than the standard EDI codes. Load the code dynamically at runtime.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set EDI codes map where the original code type will be substituted with the partner-specific code type
            var codeSetMap = new Dictionary<string, List<string>>();
            codeSetMap.Add("X12_ID_128", new List<string> { "A", "B", "C", "D", "E" });

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Templates.X12", new X12ReaderSettings { DataElementCodesMap = codeSetMap }))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { DataElementCodesMap = codeSetMap }))
                {
                    //  Invalid code value
                    var customCodeError = errorContext.Errors.SingleOrDefault(e => e.Errors.Any(de => de.Code == DataElementErrorCode.InvalidCodeValue));

                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",PA,PB,")]
    public class X12_ID_353_PartnerA
    {
    }
}
