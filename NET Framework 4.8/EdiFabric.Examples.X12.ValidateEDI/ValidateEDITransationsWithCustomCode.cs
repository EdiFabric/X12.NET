using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateEDITransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrderInvalid.txt");

            //  The custom validation logic is applied in the template by implementing IEdiValidator.
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, (ISA isa, GS gs, ST st) => typeof(TS850CustomValidation).GetTypeInfo()))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Get the purchase order
            var po = ediItems.OfType<TS850CustomValidation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Message == "N2 segment is missing.");
                Debug.WriteLine(customValidation.Message);
            }
        }
    }

    /// <summary>
    /// New validation attribute to apply to N1 loops
    /// Validates that if N1 segment exists, then N2 segment must also exists, otherwise throws an exception
    /// Preserves the position of the missing segment within the loop, to allow the correct index to be applied in the acknowledgment
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class N1LoopValidationAttribute : ValidationAttribute
    {
        public N1LoopValidationAttribute() : base(10, ValidationLevel.InterSegment_SNIP4)
        {
        }

        public override SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            var position = validationContext.SegmentIndex + 1;

            var n1Loops = validationContext.InstanceContext.Instance as IList<Loop_N1_850>;
            if (n1Loops != null)
            {
                foreach (var n1Loop in n1Loops)
                {
                    //  Check if N1 exists and N2 also exist
                    if (n1Loop.N1 != null && n1Loop.N2 == null)
                        return new SegmentErrorContext("N2", validationContext.SegmentIndex + 2, null, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                            "N2 segment is missing.");

                    return null;
                }
            }

            return null;
        }
    }

    /// <summary>
    /// New purchase order message to apply validation to
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "004010", "850")]
    public class TS850CustomValidation : TS850
    {
        /// <summary>
        /// New loop for N1
        /// The new validation attribute is applied to this loop
        /// </summary>
        [N1LoopValidation]
        [DataMember]
        [ListCount(200)]
        [Pos(34)]
        public new List<Loop_N1_850> N1Loop { get; set; }
    }
}
