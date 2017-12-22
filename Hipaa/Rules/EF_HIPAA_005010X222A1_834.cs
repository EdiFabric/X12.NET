namespace EdiFabric.Rules.HIPAA_005010X222A1_834
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
        public BGN BGN { get; set; }

        [Required]
        [Pos(3)]
        public SE SE { get; set; }

    }

    [Serializable()]
    [EdiCodes(",00,15,22")]
    public class X12_ID_353
    {
    }

    [Serializable()]
    [EdiCodes(",AD,AS,AT,CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,MD,MS,MT,PD,PS,PT,UT")]
    public class X12_ID_623
    {
    }

    [Serializable()]
    public class X12_ID_640
    {
    }

    [Serializable()]
    [EdiCodes(",2,4,RX")]
    public class X12_ID_306
    {
    }

    [Serializable()]
    [Segment("BGN")]
    public class BGN
    {
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }

        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetReferenceNumber_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string TransactionSetCreationDate_03 { get; set; }

        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string TransactionSetCreationTime_04 { get; set; }

        [DataElement("623", typeof(X12_ID_623))]
        [Pos(5)]
        public string TimeZoneCode_05 { get; set; }

        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }

        [DataElement("306", typeof(X12_ID_306))]
        [Pos(7)]
        public string ActionCode_07 { get; set; }
    }
}
