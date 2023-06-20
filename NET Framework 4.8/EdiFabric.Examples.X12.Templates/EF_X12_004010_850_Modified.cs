using System;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;

namespace EdiFabric.Templates.X12
{
    /// <summary>
    /// Modified Purchase Order
    /// The changes are:
    /// 1. Modified BEG segment
    /// </summary>
    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850Modified : TS850
    {
        /// <summary>
        /// Modified BEG Segment
        /// </summary>
        [Required]
        [Pos(2)]
        public new BEGModified BEG { get; set; }       
    }

    /// <summary>
    /// Modified BEG
    /// The changes are:
    /// 1. Pos 4 - data element is changed from Optional to Mandatory
    /// 2. Pos 12 - data element code set is changed from X12_ID_640 to X12_ID_640_Modified
    /// 3. An extra data element is added at position 13
    /// </summary>
    [Serializable()]
    [Segment("BEG")]
    public class BEGModified : BEG
    {        
        /// <summary>
        /// Modified Release Number - set to madatory
        /// </summary>
        [Required]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(4)]
        public new string ReleaseNumber_04 { get; set; }
        
        /// <summary>
        /// Modified Transaction Type Code - new data element code set
        /// </summary>
        [DataElement("640", typeof(X12_ID_640_Modified))]
        [Pos(12)]
        public new string TransactionTypeCode_12 { get; set; }

        /// <summary>
        /// Extra element
        /// </summary>
        [DataElement("Extra", typeof(X12_AN))]
        [Pos(13)]
        public string ExtraElement_13 { get; set; }
    }

    /// <summary>
    /// Modified Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",NEWCODE1,NEWCODE2,")]
    public class X12_ID_640_Modified
    {
    }
}
