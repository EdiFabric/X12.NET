namespace EdiFabric.Templates.X12
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;

    /// <summary>
    /// Purchase Order
    /// </summary>
    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850 : EdiMessage
    {

        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Purchase Order
        /// </summary>
        [Required]
        [Pos(2)]
        public BEG BEG { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(3)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(5)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [Pos(6)]
        public List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [Pos(7)]
        public List<FOB> FOB { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [Pos(8)]
        public List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [ListCount(10)]
        [Pos(9)]
        public List<PAM> PAM { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [ListCount(5)]
        [Pos(10)]
        public List<CSH> CSH { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [Pos(11)]
        public List<TC2> TC2 { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(12)]
        public List<Loop_SAC_850> SACLoop { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [Pos(13)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [ListCount(20)]
        [Pos(14)]
        public List<DIS> DIS { get; set; }
        /// <summary>
        /// Installment Information
        /// </summary>
        [Pos(15)]
        public INC INC { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(10)]
        [Pos(16)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [ListCount(12)]
        [Pos(17)]
        public List<LDT> LDT { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [ListCount(5)]
        [Pos(18)]
        public List<LIN> LIN { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(19)]
        public List<SI> SI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [ListCount(200)]
        [Pos(20)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(40)]
        [Pos(21)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [ListCount(25)]
        [Pos(22)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [ListCount(200)]
        [Pos(23)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [ListCount(2)]
        [Pos(24)]
        public List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [ListCount(12)]
        [Pos(25)]
        public List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [ListCount(12)]
        [Pos(26)]
        public List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [ListCount(5)]
        [Pos(27)]
        public List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [ListCount(10)]
        [Pos(28)]
        public List<MAN> MAN { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [Pos(29)]
        public List<PCT> PCT { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [ListCount(5)]
        [Pos(30)]
        public List<CTB> CTB { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [Pos(31)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Loop for Monetary Amount
        /// </summary>
        [Pos(32)]
        public List<Loop_AMT_850> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [ListCount(1000)]
        [Pos(33)]
        public List<Loop_N9_850> N9Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(200)]
        [Pos(34)]
        public List<Loop_N1_850> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [Pos(35)]
        public List<Loop_LM_850> LMLoop { get; set; }
        /// <summary>
        /// Loop for Specification Identifier
        /// </summary>
        [Pos(36)]
        public List<Loop_SPI_850> SPILoop { get; set; }
        /// <summary>
        /// Loop for Advertising Demographic Information
        /// </summary>
        [Pos(37)]
        public List<Loop_ADV_850> ADVLoop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data
        /// </summary>
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public List<Loop_PO1_850> PO1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Totals
        /// </summary>
        [Pos(39)]
        public Loop_CTT_850 CTTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(40)]
        public SE SE { get; set; }
    }

    /// <summary>
    /// Loop for Advertising Demographic Information
    /// </summary>
    [Serializable()]
    [Group(typeof(ADV))]
    public class Loop_ADV_850
    {
        
        /// <summary>
        /// Advertising Demographic Information
        /// </summary>
        [Required]
        [Pos(1)]
        public ADV ADV { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [Pos(3)]
        public List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount
    /// </summary>
    [Serializable()]
    [Group(typeof(AMT))]
    public class Loop_AMT_850
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(3)]
        public DTM DTM { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [Pos(4)]
        public List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [Pos(5)]
        public List<Loop_FA1_850> FA1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount
    /// </summary>
    [Serializable()]
    [Group(typeof(AMT))]
    public class Loop_AMT_850_2
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public REF REF { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [Pos(3)]
        public List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Contract and Cost Accounting Standards Data
    /// </summary>
    [Serializable()]
    [Group(typeof(CB1))]
    public class Loop_CB1_850
    {
        
        /// <summary>
        /// Contract and Cost Accounting Standards Data
        /// </summary>
        [Required]
        [Pos(1)]
        public CB1 CB1 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(20)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [Pos(4)]
        public LDT LDT { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [ListCount(50)]
        [Pos(5)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CTP))]
    public class Loop_CTP_850
    {
        
        /// <summary>
        /// Pricing Information
        /// </summary>
        [Required]
        [Pos(1)]
        public CTP CTP { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(2)]
        public CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Totals
    /// </summary>
    [Serializable()]
    [Group(typeof(CTT))]
    public class Loop_CTT_850
    {
        
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [Required]
        [Pos(1)]
        public CTT CTT { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public AMT AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [Group(typeof(FA1))]
    public class Loop_FA1_850
    {
        
        /// <summary>
        /// Type of Financial Accounting Data
        /// </summary>
        [Required]
        [Pos(1)]
        public FA1 FA1 { get; set; }
        /// <summary>
        /// Accounting Data
        /// </summary>
        [Required]
        [Pos(2)]
        public List<FA2> FA2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [Group(typeof(LDT))]
    public class Loop_LDT_850
    {
        
        /// <summary>
        /// Lead Time
        /// </summary>
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(3)]
        public MSG MSG { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(3)]
        [Pos(4)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [Pos(5)]
        public List<Loop_LM_850> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [Group(typeof(LDT))]
    public class Loop_LDT_850_2
    {
        
        /// <summary>
        /// Lead Time
        /// </summary>
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<MAN> MAN { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(4)]
        public MSG MSG { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(3)]
        [Pos(5)]
        public List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [Group(typeof(LM))]
    public class Loop_LM_850
    {
        
        /// <summary>
        /// Code Source Information
        /// </summary>
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Required]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [Group(typeof(LS))]
    public class Loop_LS_850
    {
        
        /// <summary>
        /// Loop Header
        /// </summary>
        [Required]
        [Pos(1)]
        public LS LS { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [Pos(2)]
        public List<Loop_LDT_850> LDTLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [Required]
        [Pos(3)]
        public LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1))]
    public class Loop_N1_850
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [Pos(4)]
        public List<N4> N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [Pos(7)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(8)]
        public List<SI> SI { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [Pos(9)]
        public FOB FOB { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [ListCount(2)]
        [Pos(10)]
        public List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [ListCount(12)]
        [Pos(11)]
        public List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [ListCount(12)]
        [Pos(12)]
        public List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [ListCount(5)]
        [Pos(13)]
        public List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [ListCount(200)]
        [Pos(14)]
        public List<PKG> PKG { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1))]
    public class Loop_N1_850_2
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [Pos(4)]
        public N4 N4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(20)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [Pos(6)]
        public G61 G61 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [ListCount(50)]
        [Pos(7)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1))]
    public class Loop_N1_850_3
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [Pos(4)]
        public N4 N4 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [Pos(6)]
        public List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(12)]
        [Pos(7)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(8)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(9)]
        public List<SI> SI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(10)]
        public DTM DTM { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [Pos(11)]
        public FOB FOB { get; set; }
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [ListCount(200)]
        [Pos(12)]
        public List<SCH> SCH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [ListCount(2)]
        [Pos(13)]
        public List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [ListCount(12)]
        [Pos(14)]
        public List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [ListCount(12)]
        [Pos(15)]
        public List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [ListCount(5)]
        [Pos(16)]
        public List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [ListCount(200)]
        [Pos(17)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [Pos(18)]
        public List<Loop_LDT_850_2> LDTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1))]
    public class Loop_N1_850_4
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [Pos(4)]
        public N4 N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(7)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(8)]
        public List<SI> SI { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(N9))]
    public class Loop_N9_850
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [ListCount(1000)]
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(N9))]
    public class Loop_N9_850_2
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(40)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [ListCount(1000)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(N9))]
    public class Loop_N9_850_3
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [Group(typeof(PID))]
    public class Loop_PID_850
    {
        
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [Required]
        [Pos(1)]
        public PID PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Marking, Packaging, Loading
    /// </summary>
    [Serializable()]
    [Group(typeof(PKG))]
    public class Loop_PKG_850
    {
        
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [Required]
        [Pos(1)]
        public PKG PKG { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Baseline Item Data
    /// </summary>
    [Serializable()]
    [Group(typeof(PO1))]
    public class Loop_PO1_850
    {
        
        /// <summary>
        /// Baseline Item Data
        /// </summary>
        [Required]
        [Pos(1)]
        public PO1 PO1 { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [Pos(2)]
        public List<LIN> LIN { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(3)]
        public List<SI> SI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(4)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(5)]
        public CN1 CN1 { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [ListCount(25)]
        [Pos(6)]
        public List<PO3> PO3 { get; set; }
        /// <summary>
        /// Loop for Pricing Information
        /// </summary>
        [Pos(7)]
        public List<Loop_CTP_850> CTPLoop { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [ListCount(10)]
        [Pos(8)]
        public List<PAM> PAM { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(40)]
        [Pos(9)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [ListCount(1000)]
        [Pos(10)]
        public List<Loop_PID_850> PIDLoop { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [ListCount(25)]
        [Pos(11)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [Pos(12)]
        public List<PO4> PO4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(13)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(14)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(15)]
        public List<Loop_SAC_850_2> SACLoop { get; set; }
        /// <summary>
        /// Conditions of Sale
        /// </summary>
        [Pos(16)]
        public IT8 IT8 { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [Pos(17)]
        public List<CSH> CSH { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [ListCount(2)]
        [Pos(18)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [ListCount(20)]
        [Pos(19)]
        public List<DIS> DIS { get; set; }
        /// <summary>
        /// Installment Information
        /// </summary>
        [Pos(20)]
        public INC INC { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [Pos(21)]
        public List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [Pos(22)]
        public List<FOB> FOB { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [ListCount(500)]
        [Pos(23)]
        public List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Additional Item Data
        /// </summary>
        [ListCount(5)]
        [Pos(24)]
        public List<IT3> IT3 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(10)]
        [Pos(25)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [Pos(26)]
        public List<TC2> TC2 { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [Pos(27)]
        public TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [ListCount(12)]
        [Pos(28)]
        public List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [ListCount(12)]
        [Pos(29)]
        public List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [ListCount(5)]
        [Pos(30)]
        public List<TD4> TD4 { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [Pos(31)]
        public List<PCT> PCT { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [ListCount(10)]
        [Pos(32)]
        public List<MAN> MAN { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(33)]
        public List<MSG> MSG { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [Pos(34)]
        public List<SPI> SPI { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [Pos(35)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [Pos(36)]
        public List<CTB> CTB { get; set; }
        /// <summary>
        /// Loop for Quantity
        /// </summary>
        [Pos(37)]
        public List<Loop_QTY_850> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Line Item Schedule
        /// </summary>
        [ListCount(200)]
        [Pos(38)]
        public List<Loop_SCH_850> SCHLoop { get; set; }
        /// <summary>
        /// Loop for Marking, Packaging, Loading
        /// </summary>
        [ListCount(200)]
        [Pos(39)]
        public List<Loop_PKG_850> PKGLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [Pos(40)]
        public Loop_LS_850 LSLoop { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [ListCount(1000)]
        [Pos(41)]
        public List<Loop_N9_850_2> N9Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(200)]
        [Pos(42)]
        public List<Loop_N1_850_3> N1Loop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [ListCount(1000)]
        [Pos(43)]
        public List<Loop_SLN_850> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount
        /// </summary>
        [Pos(44)]
        public List<Loop_AMT_850_2> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [Pos(45)]
        public List<Loop_LM_850> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity
    /// </summary>
    [Serializable()]
    [Group(typeof(QTY))]
    public class Loop_QTY_850
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(2)]
        public List<SI> SI { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SAC))]
    public class Loop_SAC_850
    {
        
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(2)]
        public CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SAC))]
    public class Loop_SAC_850_2
    {
        
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(2)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [Pos(3)]
        public CTP CTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item Schedule
    /// </summary>
    [Serializable()]
    [Group(typeof(SCH))]
    public class Loop_SCH_850
    {
        
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [Required]
        [Pos(1)]
        public SCH SCH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [ListCount(12)]
        [Pos(3)]
        public List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [ListCount(12)]
        [Pos(4)]
        public List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<TD4> TD4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [Group(typeof(SLN))]
    public class Loop_SLN_850
    {
        
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [Required]
        [Pos(1)]
        public SLN SLN { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(2)]
        public List<MSG> MSG { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [Pos(3)]
        public List<SI> SI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [ListCount(1000)]
        [Pos(4)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [ListCount(104)]
        [Pos(5)]
        public List<PO3> PO3 { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [Pos(6)]
        public List<TC2> TC2 { get; set; }
        /// <summary>
        /// Advertising Demographic Information
        /// </summary>
        [Pos(7)]
        public List<ADV> ADV { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(10)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [ListCount(25)]
        [Pos(9)]
        public List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [ListCount(10)]
        [Pos(10)]
        public List<PAM> PAM { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [Pos(11)]
        public PO4 PO4 { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [ListCount(3)]
        [Pos(12)]
        public List<TAX> TAX { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [Pos(13)]
        public List<Loop_N9_850_3> N9Loop { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(14)]
        public List<Loop_SAC_850_2> SACLoop { get; set; }
        /// <summary>
        /// Loop for Quantity
        /// </summary>
        [Pos(15)]
        public List<Loop_QTY_850> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(10)]
        [Pos(16)]
        public List<Loop_N1_850_4> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Specification Identifier
    /// </summary>
    [Serializable()]
    [Group(typeof(SPI))]
    public class Loop_SPI_850
    {
        
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [Required]
        [Pos(1)]
        public SPI SPI { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [ListCount(50)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(20)]
        [Pos(5)]
        public List<Loop_N1_850_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Contract and Cost Accounting Standards Data
        /// </summary>
        [Pos(6)]
        public List<Loop_CB1_850> CB1Loop { get; set; }
    }
}
