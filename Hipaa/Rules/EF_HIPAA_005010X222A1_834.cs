namespace EdiFabric.Sdk.Hipaa.Rules
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;


    [Serializable()]
    [Message("X12", "005010X222A1", "834")]
    public class TS834 : EdiMessage
    {

        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public SE SE { get; set; }

    }
}
