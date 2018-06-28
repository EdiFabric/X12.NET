namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// Loop for INVOIC:0:0410
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC
    {
        
        /// <summary>
        /// Allowance or charge
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0430
        /// </summary>
        [Pos(2)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0450
        /// </summary>
        [Pos(3)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0470
        /// </summary>
        [ListCount(2)]
        [Pos(4)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0490
        /// </summary>
        [Pos(5)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0510
        /// </summary>
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0950
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_2
    {
        
        /// <summary>
        /// Allowance or charge
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0990
        /// </summary>
        [Pos(4)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1010
        /// </summary>
        [Pos(5)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1030
        /// </summary>
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1050
        /// </summary>
        [Pos(7)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1070
        /// </summary>
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1250
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_3
    {
        
        /// <summary>
        /// Allowance or charge
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [Pos(2)]
        public ALI ALI { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0150
    /// </summary>
    [Serializable()]
    [Group(typeof(CTA))]
    public class Loop_CTA_INVOIC
    {
        
        /// <summary>
        /// Contact information
        /// </summary>
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// Communication contact
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0210
    /// </summary>
    [Serializable()]
    [Group(typeof(CUX))]
    public class Loop_CUX_INVOIC
    {
        
        /// <summary>
        /// Currencies
        /// </summary>
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0540
    /// </summary>
    [Serializable()]
    [Group(typeof(LIN))]
    public class Loop_LIN_INVOIC
    {
        
        /// <summary>
        /// Line item
        /// </summary>
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        /// <summary>
        /// Additional product id
        /// </summary>
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [ListCount(99)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [ListCount(5)]
        [Pos(6)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(35)]
        [Pos(7)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Goods identity number
        /// </summary>
        [ListCount(1000)]
        [Pos(8)]
        public List<GIN> GIN { get; set; }
        /// <summary>
        /// Quantity variances
        /// </summary>
        [Pos(9)]
        public QVR QVR { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [ListCount(99)]
        [Pos(10)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0650
        /// </summary>
        [ListCount(99)]
        [Pos(11)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0670
        /// </summary>
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_PAT_INVOIC_2> PATLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0720
        /// </summary>
        [ListCount(25)]
        [Pos(13)]
        public List<Loop_PRI_INVOIC> PRILoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0750
        /// </summary>
        [ListCount(10)]
        [Pos(14)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0780
        /// </summary>
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_PAC_INVOIC_2> PACLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0840
        /// </summary>
        [ListCount(9999)]
        [Pos(16)]
        public List<Loop_LOC_INVOIC_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0880
        /// </summary>
        [ListCount(99)]
        [Pos(17)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0910
        /// </summary>
        [ListCount(99)]
        [Pos(18)]
        public List<Loop_NAD_INVOIC_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0950
        /// </summary>
        [ListCount(30)]
        [Pos(19)]
        public List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1100
        /// </summary>
        [ListCount(10)]
        [Pos(20)]
        public List<Loop_TDT_INVOIC_2> TDTLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1120
        /// </summary>
        [ListCount(5)]
        [Pos(21)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0330
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC
    {
        
        /// <summary>
        /// Place/location identification
        /// </summary>
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0840
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC_2
    {
        
        /// <summary>
        /// Place/location identification
        /// </summary>
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [ListCount(100)]
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0470
    /// </summary>
    [Serializable()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC
    {
        
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1170
    /// </summary>
    [Serializable()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_2
    {
        
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1190
        /// </summary>
        [Pos(2)]
        public Loop_RFF_INVOIC RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0100
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC
    {
        
        /// <summary>
        /// Name and address
        /// </summary>
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// Financial institution information
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<FII> FII { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0130
        /// </summary>
        [ListCount(9999)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0150
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0910
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC_2
    {
        
        /// <summary>
        /// Name and address
        /// </summary>
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0930
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0390
    /// </summary>
    [Serializable()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC
    {
        
        /// <summary>
        /// Package
        /// </summary>
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0780
    /// </summary>
    [Serializable()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC_2
    {
        
        /// <summary>
        /// Package
        /// </summary>
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0810
        /// </summary>
        [ListCount(10)]
        [Pos(3)]
        public List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0240
    /// </summary>
    [Serializable()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC
    {
        
        /// <summary>
        /// Payment terms basis
        /// </summary>
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Percentage details
        /// </summary>
        [Pos(3)]
        public PCD PCD { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Pos(4)]
        public MOA MOA { get; set; }
        /// <summary>
        /// Payment instructions
        /// </summary>
        [Pos(5)]
        public PAI PAI { get; set; }
        /// <summary>
        /// Financial institution information
        /// </summary>
        [Pos(6)]
        public FII FII { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0670
    /// </summary>
    [Serializable()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC_2
    {
        
        /// <summary>
        /// Payment terms basis
        /// </summary>
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Percentage details
        /// </summary>
        [ListCount(99)]
        [Pos(3)]
        public List<PCD> PCD { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0450
    /// </summary>
    [Serializable()]
    [Group(typeof(PCD))]
    public class Loop_PCD_INVOIC
    {
        
        /// <summary>
        /// Percentage details
        /// </summary>
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0810
    /// </summary>
    [Serializable()]
    [Group(typeof(PCI))]
    public class Loop_PCI_INVOIC
    {
        
        /// <summary>
        /// Package identification
        /// </summary>
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        /// <summary>
        /// Goods identity number
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0720
    /// </summary>
    [Serializable()]
    [Group(typeof(PRI))]
    public class Loop_PRI_INVOIC
    {
        
        /// <summary>
        /// Price details
        /// </summary>
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
        /// <summary>
        /// Additional price information
        /// </summary>
        [Pos(2)]
        public APR APR { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0430
    /// </summary>
    [Serializable()]
    [Group(typeof(QTY))]
    public class Loop_QTY_INVOIC
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0070
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC
    {
        
        /// <summary>
        /// Reference
        /// </summary>
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0130
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC_2
    {
        
        /// <summary>
        /// Reference
        /// </summary>
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0490
    /// </summary>
    [Serializable()]
    [Group(typeof(RTE))]
    public class Loop_RTE_INVOIC
    {
        
        /// <summary>
        /// Rate details
        /// </summary>
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0180
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC
    {
        
        /// <summary>
        /// Duty/tax/fee details
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0880
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_2
    {
        
        /// <summary>
        /// Duty/tax/fee details
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1220
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_3
    {
        
        /// <summary>
        /// Duty/tax/fee details
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [ListCount(9)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0310
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC
    {
        
        /// <summary>
        /// Details of transport
        /// </summary>
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0330
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1100
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC_2
    {
        
        /// <summary>
        /// Details of transport
        /// </summary>
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0360
    /// </summary>
    [Serializable()]
    [Group(typeof(TOD))]
    public class Loop_TOD_INVOIC
    {
        
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        /// <summary>
        /// Place/location identification
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D01B", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        
        /// <summary>
        /// Message Header
        /// </summary>
        [Pos(1)]
        public UNH UNH { get; set; }
        /// <summary>
        /// Beginning of message
        /// </summary>
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Payment instructions
        /// </summary>
        [Pos(4)]
        public PAI PAI { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [ListCount(99)]
        [Pos(6)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0070
        /// </summary>
        [ListCount(99999)]
        [Pos(7)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0100
        /// </summary>
        [ListCount(99)]
        [Pos(8)]
        public List<Loop_NAD_INVOIC> NADLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0180
        /// </summary>
        [ListCount(5)]
        [Pos(9)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0210
        /// </summary>
        [ListCount(99)]
        [Pos(10)]
        public List<Loop_CUX_INVOIC> CUXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0240
        /// </summary>
        [ListCount(10)]
        [Pos(11)]
        public List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0310
        /// </summary>
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_TDT_INVOIC> TDTLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0360
        /// </summary>
        [ListCount(5)]
        [Pos(13)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0390
        /// </summary>
        [ListCount(1000)]
        [Pos(14)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0410
        /// </summary>
        [ListCount(9999)]
        [Pos(15)]
        public List<Loop_ALC_INVOIC> ALCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0540
        /// </summary>
        [ListCount(9999999)]
        [Pos(16)]
        public List<Loop_LIN_INVOIC> LINLoop { get; set; }
        /// <summary>
        /// Section control
        /// </summary>
        [Required]
        [Pos(17)]
        public UNS UNS { get; set; }
        /// <summary>
        /// Control total
        /// </summary>
        [ListCount(10)]
        [Pos(18)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1170
        /// </summary>
        [Required]
        [ListCount(100)]
        [Pos(19)]
        public List<Loop_MOA_INVOIC_2> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1220
        /// </summary>
        [ListCount(10)]
        [Pos(20)]
        public List<Loop_TAX_INVOIC_3> TAXLoop2 { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1250
        /// </summary>
        [ListCount(15)]
        [Pos(21)]
        public List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [Pos(22)]
        public UNT UNT { get; set; }
    }
}
