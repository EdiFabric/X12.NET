namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;    
    
    [Serializable()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSSplit : TSORDERS
    {
        [Splitter]
        [ListCount(200000)]
        [Pos(21)]
        public new List<TSORDERS_LINLoop1> LINLoop1 { get; set; }       
    }
}
