using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using System.Diagnostics;
using System.Reflection;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateEDITransationsBeforeWrite
    {
        /// <summary>
        /// Validate EDI transactions before writing them out, skipping the trailer validation because trailers hadn't been set just yet
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_X12_004010_810_Builder.BuildInvoice("1");
            
            //  Then validate it
            MessageErrorContext errorContext;
            if (!invoice.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
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
