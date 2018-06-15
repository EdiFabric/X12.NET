namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;

    /// <summary>
    /// Custom version of the purchase order template for trading partner with id CUSTOM2
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSCustom2 : TSORDERSCustom1
    {
        //  Swap the positions of DTM and PAI
        [Required]
        [ListCount(35)]
        [Pos(4)]
        public new List<DTM> DTM { get; set; }

        [Pos(3)]
        public new PAIInherited2 PAI { get; set; }
    }

    [Serializable()]
    [Segment("PAI")]
    public class PAIInherited2 : PAI
    {
        [Required]
        [Pos(1)]
        public new C534Inherited2 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }

        //  Add extra field
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(2)]
        public string ExtraField_02 { get; set; }
    }

    [Serializable()]
    [Composite("C534")]
    public class C534Inherited2 : C534
    {
        //  Change the validation attribute and data element type at position 3
        [StringLength(1, 5)]
        [DataElement("4444", typeof(EDIFACT_AN))]
        [Pos(3)]
        public new string Paymentmeanscoded_03 { get; set; }

    }
}