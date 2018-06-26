namespace EdiFabric.Templates.EdifactD96A
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
        public new List<Loop_LIN_ORDERS> LINLoop { get; set; }       
    }
}
