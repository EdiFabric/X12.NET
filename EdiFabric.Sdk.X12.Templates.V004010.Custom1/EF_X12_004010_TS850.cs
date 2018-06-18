namespace EdiFabric.Rules.X12_004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;

    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850Custom1 : TS850
    {
        [Splitter]
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public new List<TS850_PO1Loop1> PO1Loop1 { get; set; }       
    }
}
