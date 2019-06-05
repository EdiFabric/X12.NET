namespace EdiFabric.Templates.X12004010.PartnerC
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    using EdiFabric.Templates.X12004010.PartnerB;

    /// <summary>
    /// Custom version of the purchase order template for trading partner with id CUSTOM2
    /// </summary>
    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850PartnerC : TS850
    {
        [ListCount(200)]
        [Pos(34)]
        public new List<TS850_N1Loop1PartnerC> N1Loop { get; set; }
    }

    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop1PartnerC : Loop_N1_850
    {
        //  Swap the positions of N2 and N3
        [ListCount(2)]
        [Pos(3)]
        public new List<N2PartnerC> N2 { get; set; }

        [ListCount(2)]
        [Pos(2)]
        public new List<N3> N3 { get; set; }
    }

    [Serializable()]
    [Segment("N2")]
    public class N2PartnerC : N2
    {
        //  Change the validation attribute and data element type at position 1
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_ID_706))]
        [Pos(1)]
        public new string Name_01 { get; set; }

        //  Add extra field
        [StringLength(1, 60)]
        [DataElement("94", typeof(X12_AN))]
        [Pos(3)]
        public string ExtraName_03 { get; set; }
    }
}
