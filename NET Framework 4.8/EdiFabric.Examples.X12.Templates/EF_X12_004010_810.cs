namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;

    /// <summary>
    /// Invoice
    /// </summary>
    [Serializable()]
    [Message("X12", "004010", "810")]
    public class TS810 : EdiMessage
    {

        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Invoice
        /// </summary>
        [Required]
        [Pos(2)]
        public BIG BIG { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [ListCount(100)]
        [Pos(3)]
        public List<NTE> NTE { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(4)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [ListCount(10)]
        [Pos(6)]
        public List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(7)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(200)]
        [Pos(8)]
        public List<Loop_N1_810> N1Loop { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [Pos(9)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(10)]
        [Pos(10)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [Pos(11)]
        public FOB FOB { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [ListCount(200)]
        [Pos(12)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(40)]
        [Pos(13)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [ListCount(25)]
        [Pos(14)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [ListCount(25)]
        [Pos(15)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [Pos(16)]
        public L7 L7 { get; set; }
        /// <summary>
        /// Balance Detail
        /// </summary>
        [Pos(17)]
        public List<BAL> BAL { get; set; }
        /// <summary>
        /// Installment Information
        /// </summary>
        [Pos(18)]
        public INC INC { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [Pos(19)]
        public List<PAM> PAM { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [ListCount(10)]
        [Pos(20)]
        public List<Loop_LM_810> LMLoop { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [Pos(21)]
        public Loop_N9_810 N9Loop { get; set; }
        /// <summary>
        /// Loop for Vessel Identification
        /// </summary>
        [Pos(22)]
        public List<Loop_V1_810> V1Loop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [Pos(23)]
        public List<Loop_FA1_810> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data (Invoice)
        /// </summary>
        [ListCount(200000)]
        [Pos(24)]
        public List<Loop_IT1_810> IT1Loop { get; set; }
        /// <summary>
        /// Total Monetary Value Summary
        /// </summary>
        [Required]
        [Pos(25)]
        public TDS TDS { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [ListCount(10)]
        [Pos(26)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Carrier Detail
        /// </summary>
        [Pos(27)]
        public CAD CAD { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(28)]
        public List<AMT> AMT { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(29)]
        public List<Loop_SAC_810> SACLoop { get; set; }
        /// <summary>
        /// Loop for Invoice Shipment Summary
        /// </summary>
        [Pos(30)]
        public List<Loop_ISS_810> ISSLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [Pos(31)]
        public CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(32)]
        public SE SE { get; set; }
    }

    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [Group(typeof(FA1))]
    public class Loop_FA1_810
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
    /// Loop for Invoice Shipment Summary
    /// </summary>
    [Serializable()]
    [Group(typeof(ISS))]
    public class Loop_ISS_810
    {
        
        /// <summary>
        /// Invoice Shipment Summary
        /// </summary>
        [Required]
        [Pos(1)]
        public ISS ISS { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [Pos(2)]
        public PID PID { get; set; }
    }
    
    /// <summary>
    /// Loop for Baseline Item Data (Invoice)
    /// </summary>
    [Serializable()]
    [Group(typeof(IT1))]
    public class Loop_IT1_810
    {
        
        /// <summary>
        /// Baseline Item Data (Invoice)
        /// </summary>
        [Required]
        [Pos(1)]
        public IT1 IT1 { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [Pos(2)]
        public CRC CRC { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [Pos(4)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Additional Item Data
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<IT3> IT3 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [ListCount(10)]
        [Pos(6)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [ListCount(25)]
        [Pos(7)]
        public List<CTP> CTP { get; set; }
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
        public List<Loop_PID_810> PIDLoop { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [ListCount(25)]
        [Pos(11)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [ListCount(25)]
        [Pos(12)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [Pos(13)]
        public PO4 PO4 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [ListCount(2)]
        [Pos(14)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(15)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [ListCount(10)]
        [Pos(16)]
        public List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(5)]
        [Pos(17)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [ListCount(500)]
        [Pos(18)]
        public List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [ListCount(10)]
        [Pos(19)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Carrier Detail
        /// </summary>
        [Pos(20)]
        public List<CAD> CAD { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [Pos(21)]
        public List<L7> L7 { get; set; }
        /// <summary>
        /// Requested Service Schedule
        /// </summary>
        [Pos(22)]
        public SR SR { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(23)]
        public List<Loop_SAC_810> SACLoop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [ListCount(1000)]
        [Pos(24)]
        public List<Loop_SLN_810> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [ListCount(200)]
        [Pos(25)]
        public List<Loop_N1_810> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [ListCount(10)]
        [Pos(26)]
        public List<Loop_LM_810> LMLoop { get; set; }
        /// <summary>
        /// Loop for Vessel Identification
        /// </summary>
        [Pos(27)]
        public List<Loop_V1_810> V1Loop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [Pos(28)]
        public List<Loop_FA1_810> FA1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [Group(typeof(LM))]
    public class Loop_LM_810
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
        [ListCount(100)]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1))]
    public class Loop_N1_810
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
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [ListCount(3)]
        [Pos(6)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [Pos(7)]
        public DMG DMG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(N9))]
    public class Loop_N9_810
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [Group(typeof(PID))]
    public class Loop_PID_810
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
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SAC))]
    public class Loop_SAC_810
    {
        
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<TXI> TXI { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [Group(typeof(SLN))]
    public class Loop_SLN_810
    {
        
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [Required]
        [Pos(1)]
        public SLN SLN { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(2)]
        public DTM DTM { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [ListCount(1000)]
        [Pos(4)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [ListCount(25)]
        [Pos(5)]
        public List<SAC> SAC { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [ListCount(2)]
        [Pos(6)]
        public List<TC2> TC2 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [ListCount(10)]
        [Pos(7)]
        public List<TXI> TXI { get; set; }
    }
    
    /// <summary>
    /// Loop for Vessel Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(V1))]
    public class Loop_V1_810
    {
        
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [Required]
        [Pos(1)]
        public V1 V1 { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [Pos(2)]
        public List<R4> R4 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
}
