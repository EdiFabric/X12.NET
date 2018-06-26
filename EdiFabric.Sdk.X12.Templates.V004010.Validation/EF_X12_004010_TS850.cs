namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Reflection;
    using EdiFabric.Core.ErrorCodes;

    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850Validation : TS850
    {
        [ListCount(200)]
        [Pos(34)]
        public new List<TS850_N1Loop1Validation> N1Loop { get; set; }
    }

    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop1Validation : Loop_N1_850, IEdiValidator
    {
        public List<SegmentErrorContext> ValidateEdi(ValidationContext validationContext)
        {
            var result = new List<SegmentErrorContext>();

            if (N1 != null && N2 == null)
                result.Add(new SegmentErrorContext("N2", validationContext.SegmentIndex + 2, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                    "N2 segment is missing."));

            return result;
        }
    }
}
