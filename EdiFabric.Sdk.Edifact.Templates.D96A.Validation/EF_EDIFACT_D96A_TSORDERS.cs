namespace EdiFabric.Rules.EDIFACT_D96A
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
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSValidation : TSORDERS
    {
        [ListCount(200000)]
        [Pos(21)]
        public new List<TSORDERS_LINLoop1Validation> LINLoop1 { get; set; }       
    }
    
    [Serializable()]
    [Group(typeof(LIN))]
    public class TSORDERS_LINLoop1Validation : TSORDERS_LINLoop1, IEdiValidator
    {
        public List<SegmentErrorContext> ValidateEdi(ValidationContext validationContext)
        {
            var result = new List<SegmentErrorContext>();

            var position = validationContext.SegmentIndex + 1;
            if (PIA != null)
                position += PIA.Count;
            if (IMD != null)
                position += IMD.Count;
            if (MEA != null)
                position += MEA.Count;
            if (QTY != null)
                position += QTY.Count;
            if (PCD != null)
                position += PCD.Count;
            if (ALI != null)
                position += ALI.Count;

            if (QTY != null && DTM == null)
                result.Add(new SegmentErrorContext("DTM", position + 1, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                    "DTM segment is missing."));

            return result;
        }
    }
}
