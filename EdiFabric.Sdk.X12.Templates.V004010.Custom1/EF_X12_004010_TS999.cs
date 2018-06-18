namespace EdiFabric.Rules.X12_005010X231A1
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    [Serializable()]
    [Message("X12", "005010X231A1", "999")]
    public class Custom999 : EdiMessage
    {

        [Pos(1)]
        public ST ST { get; set; }
        [Pos(2)]
        public List<TS999_AK1Loop> AK1Loops { get; set; }        
        [Pos(3)]
        public SE SE { get; set; }
    }

    [Serializable()]
    [Group(typeof(AK1))]
    public class TS999_AK1Loop
    {

        [Pos(1)]
        public AK1 AK1 { get; set; }
        [Pos(2)]
        public List<TS999_AK2Loop1> AK2Loop1 { get; set; }
        [Pos(3)]
        public AK9 AK9 { get; set; }
    }

}
