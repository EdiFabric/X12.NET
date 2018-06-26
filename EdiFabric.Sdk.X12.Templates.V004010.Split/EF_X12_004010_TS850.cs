namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;

    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850Split : TS850
    {
        [Splitter]
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public new List<Loop_PO1_850> PO1Loop { get; set; }       
    }
}
