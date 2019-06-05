namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Reflection;
    using EdiFabric.Core.ErrorCodes;

    public partial class Loop_N1_850 : IEdiValidator
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
