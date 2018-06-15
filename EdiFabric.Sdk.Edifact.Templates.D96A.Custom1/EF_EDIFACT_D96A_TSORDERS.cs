namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;

    /// <summary>
    /// Custom version of the purchase order template for trading partner with id CUSTOM1
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSCustom1 : TSORDERS
    {
        [Required]
        [Pos(2)]
        public new BGMCustom1 BGM { get; set; }
    }

    [Serializable()]
    [Segment("BGM")]
    public class BGMCustom1 : BGM
    {
        //  Mark as mandatory
        [Required]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public new string Responsetypecoded_04 { get; set; }

        //  Add new field
        [Pos(5)]
        public string NewField_05 { get; set; }
    }
}