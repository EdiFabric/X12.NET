namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERS : EdiMessage
    {
        
        [Pos(1)]
        public UNH UNH { get; set; }
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public PAI PAI { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        [Pos(6)]
        public IMD IMD { get; set; }
        [ListCount(99)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }
        [ListCount(10)]
        [Pos(8)]
        public List<TSORDERS_RFFLoop1> RFFLoop1 { get; set; }
        [ListCount(99)]
        [Pos(9)]
        public List<TSORDERS_NADLoop1> NADLoop1 { get; set; }
        [ListCount(5)]
        [Pos(10)]
        public List<TSORDERS_TAXLoop1> TAXLoop1 { get; set; }
        [ListCount(5)]
        [Pos(11)]
        public List<TSORDERS_CUXLoop1> CUXLoop1 { get; set; }
        [ListCount(10)]
        [Pos(12)]
        public List<TSORDERS_PATLoop1> PATLoop1 { get; set; }
        [ListCount(10)]
        [Pos(13)]
        public List<TSORDERS_TDTLoop1> TDTLoop1 { get; set; }
        [ListCount(5)]
        [Pos(14)]
        public List<TSORDERS_TODLoop1> TODLoop1 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        public List<TSORDERS_PACLoop1> PACLoop1 { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<TSORDERS_EQDLoop1> EQDLoop1 { get; set; }
        [ListCount(10)]
        [Pos(17)]
        public List<TSORDERS_SCCLoop1> SCCLoop1 { get; set; }
        [ListCount(25)]
        [Pos(18)]
        public List<TSORDERS_APRLoop1> APRLoop1 { get; set; }
        [ListCount(15)]
        [Pos(19)]
        public List<TSORDERS_ALCLoop1> ALCLoop1 { get; set; }
        [ListCount(100)]
        [Pos(20)]
        public List<TSORDERS_RCSLoop1> RCSLoop1 { get; set; }
        [ListCount(200000)]
        [Pos(21)]
        public List<TSORDERS_LINLoop1> LINLoop1 { get; set; }
        [Required]
        [Pos(22)]
        public UNS UNS { get; set; }
        [ListCount(12)]
        [Pos(23)]
        public List<MOA> MOA { get; set; }
        [ListCount(10)]
        [Pos(24)]
        public List<CNT> CNT { get; set; }
        [ListCount(10)]
        [Pos(25)]
        public List<TSORDERS_ALCLoop3> ALCLoop3 { get; set; }
        [Pos(26)]
        public UNT UNT { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(ALC))]
    public class TSORDERS_ALCLoop3
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [Pos(2)]
        public ALI ALI { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LIN))]
    public class TSORDERS_LINLoop1
    {
        
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        [ListCount(10)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<PCD> PCD { get; set; }
        [ListCount(5)]
        [Pos(7)]
        public List<ALI> ALI { get; set; }
        [ListCount(35)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        [ListCount(10)]
        [Pos(9)]
        public List<MOA> MOA { get; set; }
        [ListCount(1000)]
        [Pos(10)]
        public List<GIN> GIN { get; set; }
        [ListCount(1000)]
        [Pos(11)]
        public List<GIR> GIR { get; set; }
        [Pos(12)]
        public QVR QVR { get; set; }
        [ListCount(5)]
        [Pos(13)]
        public List<DOC> DOC { get; set; }
        [Pos(14)]
        public PAI PAI { get; set; }
        [ListCount(99)]
        [Pos(15)]
        public List<FTX> FTX { get; set; }
        [ListCount(999)]
        [Pos(16)]
        public List<TSORDERS_CCILoop1> CCILoop1 { get; set; }
        [ListCount(10)]
        [Pos(17)]
        public List<TSORDERS_PATLoop2> PATLoop2 { get; set; }
        [ListCount(25)]
        [Pos(18)]
        public List<TSORDERS_PRILoop1> PRILoop1 { get; set; }
        [ListCount(10)]
        [Pos(19)]
        public List<TSORDERS_RFFLoop3> RFFLoop3 { get; set; }
        [ListCount(10)]
        [Pos(20)]
        public List<TSORDERS_PACLoop2> PACLoop2 { get; set; }
        [ListCount(9999)]
        [Pos(21)]
        public List<TSORDERS_LOCLoop2> LOCLoop2 { get; set; }
        [ListCount(10)]
        [Pos(22)]
        public List<TSORDERS_TAXLoop3> TAXLoop3 { get; set; }
        [ListCount(99)]
        [Pos(23)]
        public List<TSORDERS_NADLoop2> NADLoop2 { get; set; }
        [ListCount(99)]
        [Pos(24)]
        public List<TSORDERS_ALCLoop2> ALCLoop2 { get; set; }
        [ListCount(10)]
        [Pos(25)]
        public List<TSORDERS_TDTLoop2> TDTLoop2 { get; set; }
        [ListCount(5)]
        [Pos(26)]
        public List<TSORDERS_TODLoop2> TODLoop2 { get; set; }
        [ListCount(10)]
        [Pos(27)]
        public List<TSORDERS_EQDLoop2> EQDLoop2 { get; set; }
        [ListCount(100)]
        [Pos(28)]
        public List<TSORDERS_SCCLoop2> SCCLoop2 { get; set; }
        [ListCount(100)]
        [Pos(29)]
        public List<TSORDERS_RCSLoop2> RCSLoop2 { get; set; }
        [ListCount(10)]
        [Pos(30)]
        public List<TSORDERS_STGLoop1> STGLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(STG))]
    public class TSORDERS_STGLoop1
    {
        
        [Required]
        [Pos(1)]
        public STG STG { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<TSORDERS_QTYLoop5> QTYLoop5 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TSORDERS_QTYLoop5
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RCS))]
    public class TSORDERS_RCSLoop2
    {
        
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SCC))]
    public class TSORDERS_SCCLoop2
    {
        
        [Required]
        [Pos(1)]
        public SCC SCC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<RFF> RFF { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<TSORDERS_QTYLoop4> QTYLoop4 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TSORDERS_QTYLoop4
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(EQD))]
    public class TSORDERS_EQDLoop2
    {
        
        [Required]
        [Pos(1)]
        public EQD EQD { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<HAN> HAN { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TOD))]
    public class TSORDERS_TODLoop2
    {
        
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TDT))]
    public class TSORDERS_TDTLoop2
    {
        
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSORDERS_LOCLoop3> LOCLoop3 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LOC))]
    public class TSORDERS_LOCLoop3
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(ALC))]
    public class TSORDERS_ALCLoop2
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public TSORDERS_QTYLoop3 QTYLoop3 { get; set; }
        [Pos(5)]
        public TSORDERS_PCDLoop2 PCDLoop2 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<TSORDERS_MOALoop2> MOALoop2 { get; set; }
        [Pos(7)]
        public TSORDERS_RTELoop2 RTELoop2 { get; set; }
        [ListCount(5)]
        [Pos(8)]
        public List<TSORDERS_TAXLoop4> TAXLoop4 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TAX))]
    public class TSORDERS_TAXLoop4
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RTE))]
    public class TSORDERS_RTELoop2
    {
        
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(MOA))]
    public class TSORDERS_MOALoop2
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PCD))]
    public class TSORDERS_PCDLoop2
    {
        
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TSORDERS_QTYLoop3
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(NAD))]
    public class TSORDERS_NADLoop2
    {
        
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<TSORDERS_RFFLoop5> RFFLoop5 { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSORDERS_DOCLoop2> DOCLoop2 { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TSORDERS_CTALoop2> CTALoop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CTA))]
    public class TSORDERS_CTALoop2
    {
        
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(DOC))]
    public class TSORDERS_DOCLoop2
    {
        
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RFF))]
    public class TSORDERS_RFFLoop5
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TAX))]
    public class TSORDERS_TAXLoop3
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LOC))]
    public class TSORDERS_LOCLoop2
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [Pos(2)]
        public QTY QTY { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PAC))]
    public class TSORDERS_PACLoop2
    {
        
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<DTM> DTM { get; set; }
        [Pos(5)]
        public TSORDERS_RFFLoop4 RFFLoop4 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSORDERS_PCILoop2> PCILoop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PCI))]
    public class TSORDERS_PCILoop2
    {
        
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        [Pos(2)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RFF))]
    public class TSORDERS_RFFLoop4
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RFF))]
    public class TSORDERS_RFFLoop3
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PRI))]
    public class TSORDERS_PRILoop1
    {
        
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
        [Pos(2)]
        public CUX CUX { get; set; }
        [Pos(3)]
        public APR APR { get; set; }
        [Pos(4)]
        public RNG RNG { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PAT))]
    public class TSORDERS_PATLoop2
    {
        
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public PCD PCD { get; set; }
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CCI))]
    public class TSORDERS_CCILoop1
    {
        
        [Required]
        [Pos(1)]
        public CCI CCI { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<CAV> CAV { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RCS))]
    public class TSORDERS_RCSLoop1
    {
        
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(ALC))]
    public class TSORDERS_ALCLoop1
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public TSORDERS_QTYLoop2 QTYLoop2 { get; set; }
        [Pos(5)]
        public TSORDERS_PCDLoop1 PCDLoop1 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<TSORDERS_MOALoop1> MOALoop1 { get; set; }
        [Pos(7)]
        public TSORDERS_RTELoop1 RTELoop1 { get; set; }
        [ListCount(5)]
        [Pos(8)]
        public List<TSORDERS_TAXLoop2> TAXLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TAX))]
    public class TSORDERS_TAXLoop2
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RTE))]
    public class TSORDERS_RTELoop1
    {
        
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(MOA))]
    public class TSORDERS_MOALoop1
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PCD))]
    public class TSORDERS_PCDLoop1
    {
        
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TSORDERS_QTYLoop2
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(APR))]
    public class TSORDERS_APRLoop1
    {
        
        [Required]
        [Pos(1)]
        public APR APR { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SCC))]
    public class TSORDERS_SCCLoop1
    {
        
        [Required]
        [Pos(1)]
        public SCC SCC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<RFF> RFF { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<TSORDERS_QTYLoop1> QTYLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TSORDERS_QTYLoop1
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(EQD))]
    public class TSORDERS_EQDLoop1
    {
        
        [Required]
        [Pos(1)]
        public EQD EQD { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<HAN> HAN { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PAC))]
    public class TSORDERS_PACLoop1
    {
        
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<TSORDERS_PCILoop1> PCILoop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PCI))]
    public class TSORDERS_PCILoop1
    {
        
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        [Pos(2)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TOD))]
    public class TSORDERS_TODLoop1
    {
        
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TDT))]
    public class TSORDERS_TDTLoop1
    {
        
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSORDERS_LOCLoop1> LOCLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LOC))]
    public class TSORDERS_LOCLoop1
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PAT))]
    public class TSORDERS_PATLoop1
    {
        
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public PCD PCD { get; set; }
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CUX))]
    public class TSORDERS_CUXLoop1
    {
        
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<PCD> PCD { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(TAX))]
    public class TSORDERS_TAXLoop1
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(NAD))]
    public class TSORDERS_NADLoop1
    {
        
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        [ListCount(25)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<FII> FII { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<TSORDERS_RFFLoop2> RFFLoop2 { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TSORDERS_DOCLoop1> DOCLoop1 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSORDERS_CTALoop1> CTALoop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CTA))]
    public class TSORDERS_CTALoop1
    {
        
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(DOC))]
    public class TSORDERS_DOCLoop1
    {
        
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RFF))]
    public class TSORDERS_RFFLoop2
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(RFF))]
    public class TSORDERS_RFFLoop1
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
}
