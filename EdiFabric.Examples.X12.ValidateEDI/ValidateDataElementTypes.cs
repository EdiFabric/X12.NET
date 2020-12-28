using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateDataElementTypes
    {
        /// <summary>
        /// Validate data element data type using the basic X12 code set. These aren't validated by default and need to be explicitly requested.
        /// </summary>
        public static void Basic()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { SyntaxSet = new Basic() }))
                {
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
        /// Validate data element data type using the extended X12 code set. These aren't validated by default and need to be explicitly requested.
        /// </summary>
        public static void Extended()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { SyntaxSet = new Extended() }))
                {
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
}
