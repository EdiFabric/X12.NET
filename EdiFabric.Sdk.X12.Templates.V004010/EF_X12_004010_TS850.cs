namespace EdiFabric.Rules.X12_004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BEG BEG { get; set; }
        [Pos(3)]
        public CUR CUR { get; set; }
        [Pos(4)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(5)]
        public List<PER> PER { get; set; }
        [Pos(6)]
        public List<TAX> TAX { get; set; }
        [Pos(7)]
        public List<FOB> FOB { get; set; }
        [Pos(8)]
        public List<CTP> CTP { get; set; }
        [ListCount(10)]
        [Pos(9)]
        public List<PAM> PAM { get; set; }
        [ListCount(5)]
        [Pos(10)]
        public List<CSH> CSH { get; set; }
        [Pos(11)]
        public List<TC2> TC2 { get; set; }
        [ListCount(25)]
        [Pos(12)]
        public List<TS850_SACLoop1> SACLoop1 { get; set; }
        [Pos(13)]
        public List<ITD> ITD { get; set; }
        [ListCount(20)]
        [Pos(14)]
        public List<DIS> DIS { get; set; }
        [Pos(15)]
        public INC INC { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<DTM> DTM { get; set; }
        [ListCount(12)]
        [Pos(17)]
        public List<LDT> LDT { get; set; }
        [ListCount(5)]
        [Pos(18)]
        public List<LIN> LIN { get; set; }
        [Pos(19)]
        public List<SI> SI { get; set; }
        [ListCount(200)]
        [Pos(20)]
        public List<PID> PID { get; set; }
        [ListCount(40)]
        [Pos(21)]
        public List<MEA> MEA { get; set; }
        [ListCount(25)]
        [Pos(22)]
        public List<PWK> PWK { get; set; }
        [ListCount(200)]
        [Pos(23)]
        public List<PKG> PKG { get; set; }
        [ListCount(2)]
        [Pos(24)]
        public List<TD1> TD1 { get; set; }
        [ListCount(12)]
        [Pos(25)]
        public List<TD5> TD5 { get; set; }
        [ListCount(12)]
        [Pos(26)]
        public List<TD3> TD3 { get; set; }
        [ListCount(5)]
        [Pos(27)]
        public List<TD4> TD4 { get; set; }
        [ListCount(10)]
        [Pos(28)]
        public List<MAN> MAN { get; set; }
        [Pos(29)]
        public List<PCT> PCT { get; set; }
        [ListCount(5)]
        [Pos(30)]
        public List<CTB> CTB { get; set; }
        [Pos(31)]
        public List<TXI> TXI { get; set; }
        [Pos(32)]
        public List<TS850_AMTLoop1> AMTLoop1 { get; set; }
        [ListCount(1000)]
        [Pos(33)]
        public List<TS850_N9Loop1> N9Loop1 { get; set; }
        [ListCount(200)]
        [Pos(34)]
        public List<TS850_N1Loop1> N1Loop1 { get; set; }
        [Pos(35)]
        public List<TS850_LMLoop1> LMLoop1 { get; set; }
        [Pos(36)]
        public List<TS850_SPILoop1> SPILoop1 { get; set; }
        [Pos(37)]
        public List<TS850_ADVLoop1> ADVLoop1 { get; set; }
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public List<TS850_PO1Loop1> PO1Loop1 { get; set; }
        [Pos(39)]
        public TS850_CTTLoop1 CTTLoop1 { get; set; }
        [Pos(40)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CTT))]
    public class TS850_CTTLoop1
    {
        
        [Required]
        [Pos(1)]
        public CTT CTT { get; set; }
        [Pos(2)]
        public AMT AMT { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PO1))]
    public class TS850_PO1Loop1
    {
        
        [Required]
        [Pos(1)]
        public PO1 PO1 { get; set; }
        [Pos(2)]
        public List<LIN> LIN { get; set; }
        [Pos(3)]
        public List<SI> SI { get; set; }
        [Pos(4)]
        public CUR CUR { get; set; }
        [Pos(5)]
        public CN1 CN1 { get; set; }
        [ListCount(25)]
        [Pos(6)]
        public List<PO3> PO3 { get; set; }
        [Pos(7)]
        public List<TS850_CTPLoop1> CTPLoop1 { get; set; }
        [ListCount(10)]
        [Pos(8)]
        public List<PAM> PAM { get; set; }
        [ListCount(40)]
        [Pos(9)]
        public List<MEA> MEA { get; set; }
        [ListCount(1000)]
        [Pos(10)]
        public List<TS850_PIDLoop1> PIDLoop1 { get; set; }
        [ListCount(25)]
        [Pos(11)]
        public List<PWK> PWK { get; set; }
        [Pos(12)]
        public List<PO4> PO4 { get; set; }
        [Pos(13)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(14)]
        public List<PER> PER { get; set; }
        [ListCount(25)]
        [Pos(15)]
        public List<TS850_SACLoop2> SACLoop2 { get; set; }
        [Pos(16)]
        public IT8 IT8 { get; set; }
        [Pos(17)]
        public List<CSH> CSH { get; set; }
        [ListCount(2)]
        [Pos(18)]
        public List<ITD> ITD { get; set; }
        [ListCount(20)]
        [Pos(19)]
        public List<DIS> DIS { get; set; }
        [Pos(20)]
        public INC INC { get; set; }
        [Pos(21)]
        public List<TAX> TAX { get; set; }
        [Pos(22)]
        public List<FOB> FOB { get; set; }
        [ListCount(500)]
        [Pos(23)]
        public List<SDQ> SDQ { get; set; }
        [ListCount(5)]
        [Pos(24)]
        public List<IT3> IT3 { get; set; }
        [ListCount(10)]
        [Pos(25)]
        public List<DTM> DTM { get; set; }
        [Pos(26)]
        public List<TC2> TC2 { get; set; }
        [Pos(27)]
        public TD1 TD1 { get; set; }
        [ListCount(12)]
        [Pos(28)]
        public List<TD5> TD5 { get; set; }
        [ListCount(12)]
        [Pos(29)]
        public List<TD3> TD3 { get; set; }
        [ListCount(5)]
        [Pos(30)]
        public List<TD4> TD4 { get; set; }
        [Pos(31)]
        public List<PCT> PCT { get; set; }
        [ListCount(10)]
        [Pos(32)]
        public List<MAN> MAN { get; set; }
        [Pos(33)]
        public List<MSG> MSG { get; set; }
        [Pos(34)]
        public List<SPI> SPI { get; set; }
        [Pos(35)]
        public List<TXI> TXI { get; set; }
        [Pos(36)]
        public List<CTB> CTB { get; set; }
        [Pos(37)]
        public List<TS850_QTYLoop1> QTYLoop1 { get; set; }
        [ListCount(200)]
        [Pos(38)]
        public List<TS850_SCHLoop1> SCHLoop1 { get; set; }
        [ListCount(200)]
        [Pos(39)]
        public List<TS850_PKGLoop1> PKGLoop1 { get; set; }
        [Pos(40)]
        public TS850_LSLoop1 LSLoop1 { get; set; }
        [ListCount(1000)]
        [Pos(41)]
        public List<TS850_N9Loop2> N9Loop2 { get; set; }
        [ListCount(200)]
        [Pos(42)]
        public List<TS850_N1Loop3> N1Loop3 { get; set; }
        [ListCount(1000)]
        [Pos(43)]
        public List<TS850_SLNLoop1> SLNLoop1 { get; set; }
        [Pos(44)]
        public List<TS850_AMTLoop2> AMTLoop2 { get; set; }
        [Pos(45)]
        public List<TS850_LMLoop3> LMLoop3 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LM))]
    public class TS850_LMLoop3
    {
        
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        [Required]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(AMT))]
    public class TS850_AMTLoop2
    {
        
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        [Pos(2)]
        public REF REF { get; set; }
        [Pos(3)]
        public List<PCT> PCT { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SLN))]
    public class TS850_SLNLoop1
    {
        
        [Required]
        [Pos(1)]
        public SLN SLN { get; set; }
        [Pos(2)]
        public List<MSG> MSG { get; set; }
        [Pos(3)]
        public List<SI> SI { get; set; }
        [ListCount(1000)]
        [Pos(4)]
        public List<PID> PID { get; set; }
        [ListCount(104)]
        [Pos(5)]
        public List<PO3> PO3 { get; set; }
        [Pos(6)]
        public List<TC2> TC2 { get; set; }
        [Pos(7)]
        public List<ADV> ADV { get; set; }
        [ListCount(10)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        [ListCount(25)]
        [Pos(9)]
        public List<CTP> CTP { get; set; }
        [ListCount(10)]
        [Pos(10)]
        public List<PAM> PAM { get; set; }
        [Pos(11)]
        public PO4 PO4 { get; set; }
        [ListCount(3)]
        [Pos(12)]
        public List<TAX> TAX { get; set; }
        [Pos(13)]
        public List<TS850_N9Loop3> N9Loop3 { get; set; }
        [ListCount(25)]
        [Pos(14)]
        public List<TS850_SACLoop3> SACLoop3 { get; set; }
        [Pos(15)]
        public List<TS850_QTYLoop2> QTYLoop2 { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<TS850_N1Loop4> N1Loop4 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop4
    {
        
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public N4 N4 { get; set; }
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(7)]
        public List<PER> PER { get; set; }
        [Pos(8)]
        public List<SI> SI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TS850_QTYLoop2
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public List<SI> SI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SAC))]
    public class TS850_SACLoop3
    {
        
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        [Pos(2)]
        public CUR CUR { get; set; }
        [Pos(3)]
        public CTP CTP { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N9))]
    public class TS850_N9Loop3
    {
        
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop3
    {
        
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public N4 N4 { get; set; }
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        [Pos(6)]
        public List<NX2> NX2 { get; set; }
        [ListCount(12)]
        [Pos(7)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(8)]
        public List<PER> PER { get; set; }
        [Pos(9)]
        public List<SI> SI { get; set; }
        [Pos(10)]
        public DTM DTM { get; set; }
        [Pos(11)]
        public FOB FOB { get; set; }
        [ListCount(200)]
        [Pos(12)]
        public List<SCH> SCH { get; set; }
        [ListCount(2)]
        [Pos(13)]
        public List<TD1> TD1 { get; set; }
        [ListCount(12)]
        [Pos(14)]
        public List<TD5> TD5 { get; set; }
        [ListCount(12)]
        [Pos(15)]
        public List<TD3> TD3 { get; set; }
        [ListCount(5)]
        [Pos(16)]
        public List<TD4> TD4 { get; set; }
        [ListCount(200)]
        [Pos(17)]
        public List<PKG> PKG { get; set; }
        [Pos(18)]
        public List<TS850_LDTLoop2> LDTLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LDT))]
    public class TS850_LDTLoop2
    {
        
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<MAN> MAN { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        [Pos(4)]
        public MSG MSG { get; set; }
        [ListCount(3)]
        [Pos(5)]
        public List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N9))]
    public class TS850_N9Loop2
    {
        
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [ListCount(40)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        [ListCount(1000)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LS))]
    public class TS850_LSLoop1
    {
        
        [Required]
        [Pos(1)]
        public LS LS { get; set; }
        [Pos(2)]
        public List<TS850_LDTLoop1> LDTLoop1 { get; set; }
        [Required]
        [Pos(3)]
        public LE LE { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LDT))]
    public class TS850_LDTLoop1
    {
        
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        [Pos(3)]
        public MSG MSG { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF> REF { get; set; }
        [Pos(5)]
        public List<TS850_LMLoop2> LMLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LM))]
    public class TS850_LMLoop2
    {
        
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        [Required]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PKG))]
    public class TS850_PKGLoop1
    {
        
        [Required]
        [Pos(1)]
        public PKG PKG { get; set; }
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SCH))]
    public class TS850_SCHLoop1
    {
        
        [Required]
        [Pos(1)]
        public SCH SCH { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<TD1> TD1 { get; set; }
        [ListCount(12)]
        [Pos(3)]
        public List<TD5> TD5 { get; set; }
        [ListCount(12)]
        [Pos(4)]
        public List<TD3> TD3 { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TD4> TD4 { get; set; }
        [Pos(6)]
        public List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(QTY))]
    public class TS850_QTYLoop1
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public List<SI> SI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SAC))]
    public class TS850_SACLoop2
    {
        
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        [Pos(2)]
        public CUR CUR { get; set; }
        [Pos(3)]
        public CTP CTP { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PID))]
    public class TS850_PIDLoop1
    {
        
        [Required]
        [Pos(1)]
        public PID PID { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CTP))]
    public class TS850_CTPLoop1
    {
        
        [Required]
        [Pos(1)]
        public CTP CTP { get; set; }
        [Pos(2)]
        public CUR CUR { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(ADV))]
    public class TS850_ADVLoop1
    {
        
        [Required]
        [Pos(1)]
        public ADV ADV { get; set; }
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public List<MTX> MTX { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SPI))]
    public class TS850_SPILoop1
    {
        
        [Required]
        [Pos(1)]
        public SPI SPI { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(50)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
        [ListCount(20)]
        [Pos(5)]
        public List<TS850_N1Loop2> N1Loop2 { get; set; }
        [Pos(6)]
        public List<TS850_CB1Loop1> CB1Loop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(CB1))]
    public class TS850_CB1Loop1
    {
        
        [Required]
        [Pos(1)]
        public CB1 CB1 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public LDT LDT { get; set; }
        [ListCount(50)]
        [Pos(5)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop2
    {
        
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public N4 N4 { get; set; }
        [ListCount(20)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        [Pos(6)]
        public G61 G61 { get; set; }
        [ListCount(50)]
        [Pos(7)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LM))]
    public class TS850_LMLoop1
    {
        
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        [Required]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop1
    {
        
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public List<N4> N4 { get; set; }
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        [Pos(7)]
        public List<PER> PER { get; set; }
        [Pos(8)]
        public List<SI> SI { get; set; }
        [Pos(9)]
        public FOB FOB { get; set; }
        [ListCount(2)]
        [Pos(10)]
        public List<TD1> TD1 { get; set; }
        [ListCount(12)]
        [Pos(11)]
        public List<TD5> TD5 { get; set; }
        [ListCount(12)]
        [Pos(12)]
        public List<TD3> TD3 { get; set; }
        [ListCount(5)]
        [Pos(13)]
        public List<TD4> TD4 { get; set; }
        [ListCount(200)]
        [Pos(14)]
        public List<PKG> PKG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N9))]
    public class TS850_N9Loop1
    {
        
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [ListCount(1000)]
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(AMT))]
    public class TS850_AMTLoop1
    {
        
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        [Pos(2)]
        public List<REF> REF { get; set; }
        [Pos(3)]
        public DTM DTM { get; set; }
        [Pos(4)]
        public List<PCT> PCT { get; set; }
        [Pos(5)]
        public List<TS850_FA1Loop1> FA1Loop1 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(FA1))]
    public class TS850_FA1Loop1
    {
        
        [Required]
        [Pos(1)]
        public FA1 FA1 { get; set; }
        [Required]
        [Pos(2)]
        public List<FA2> FA2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SAC))]
    public class TS850_SACLoop1
    {
        
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        [Pos(2)]
        public CUR CUR { get; set; }
    }
}
