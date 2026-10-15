namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTP))]
    public class Loop_CTP_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Bracket Price
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<G40> G40 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Price List Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G36 G36 { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<CUR> CUR { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(10)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Pricing Conditions
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(12)]
        public virtual List<G26> G26 { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Characteristics - Vendor's Selling Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G39))]
    public class Loop_G39_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Characteristics - Vendor's Selling Unit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G39 G39 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CTP CTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Information, Finished Goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LFG))]
    public class Loop_LFG_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Information, Finished Goods
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LFG LFG { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_CRC_832> CRCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PO1 PO1 { get; set; }
        /// <summary>
        /// Maintenance Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G53 G53 { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Content Reporting Detail
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<CRD> CRD { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(11)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(12)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(13)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(19)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual AAA AAA { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(24)]
        public virtual List<TC2> TC2 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Item Characteristics - Consumer Unit
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual G55 G55 { get; set; }
        /// <summary>
        /// Module Description
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual G54 G54 { get; set; }
        /// <summary>
        /// Loop for Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(28)]
        public virtual List<Loop_CTP_832> CTPLoop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual List<Loop_N1_832_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Item Characteristics - Vendor's Selling Unit
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual List<Loop_G39_832> G39Loop { get; set; }
        /// <summary>
        /// Loop for Multi-Pack Configuration
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(31)]
        public virtual List<Loop_PKL_832> PKLLoop { get; set; }
        /// <summary>
        /// Loop for Hazardous Information, Finished Goods
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual Loop_LFG_832 LFGLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual List<Loop_LM_832> LMLoop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual List<Loop_SLN_832> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual List<Loop_N9_832> N9Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_832_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PKG> PKG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Multi-Pack Configuration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PKL))]
    public class Loop_PKL_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Multi-Pack Configuration
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PKL PKL { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<PKG> PKG { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_832
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PO4> PO4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_LM_832> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Price/Sales Catalog
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "832")]
    public class TS832 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Price/Sales Catalog
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BCT BCT { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(8)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<CUR> CUR { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<LDT> LDT { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Price Bracket Identification
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(19)]
        public virtual List<G93> G93 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual AAA AAA { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<Loop_N1_832> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual List<Loop_LM_832> LMLoop { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual List<Loop_N9_832> N9Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual List<Loop_LIN_832> LINLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual SE SE { get; set; }
    }
}
