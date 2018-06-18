namespace EdiFabric.Rules.X12_004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    [Serializable()]
    [Message("X12", "004010", "810")]
    public class TS810 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BIG BIG { get; set; }
        [ListCount(100)]
        [Pos(3)]
        public List<NTE> NTE { get; set; }
        [Pos(4)]
        public CUR CUR { get; set; }
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        [ListCount(10)]
        [Pos(6)]
        public List<YNQ> YNQ { get; set; }
        [ListCount(3)]
        [Pos(7)]
        public List<PER> PER { get; set; }
        [ListCount(200)]
        [Pos(8)]
        public List<TS810_N1Loop1> N1Loop1 { get; set; }
        [Pos(9)]
        public List<ITD> ITD { get; set; }
        [ListCount(10)]
        [Pos(10)]
        public List<DTM> DTM { get; set; }
        [Pos(11)]
        public FOB FOB { get; set; }
        [ListCount(200)]
        [Pos(12)]
        public List<PID> PID { get; set; }
        [ListCount(40)]
        [Pos(13)]
        public List<MEA> MEA { get; set; }
        [ListCount(25)]
        [Pos(14)]
        public List<PWK> PWK { get; set; }
        [ListCount(25)]
        [Pos(15)]
        public List<PKG> PKG { get; set; }
        [Pos(16)]
        public L7 L7 { get; set; }
        [Pos(17)]
        public List<BAL> BAL { get; set; }
        [Pos(18)]
        public INC INC { get; set; }
        [Pos(19)]
        public List<PAM> PAM { get; set; }
        [ListCount(10)]
        [Pos(20)]
        public List<TS810_LMLoop1> LMLoop1 { get; set; }
        [Pos(21)]
        public TS810_N9Loop1 N9Loop1 { get; set; }
        [Pos(22)]
        public List<TS810_V1Loop1> V1Loop1 { get; set; }
        [Pos(23)]
        public List<TS810_FA1Loop1> FA1Loop1 { get; set; }
        [ListCount(200000)]
        [Pos(24)]
        public List<TS810_IT1Loop1> IT1Loop1 { get; set; }
        [Required]
        [Pos(25)]
        public TDS TDS { get; set; }
        [ListCount(10)]
        [Pos(26)]
        public List<TXI> TXI { get; set; }
        [Pos(27)]
        public CAD CAD { get; set; }
        [Pos(28)]
        public List<AMT> AMT { get; set; }
        [ListCount(25)]
        [Pos(29)]
        public List<TS810_SACLoop2> SACLoop2 { get; set; }
        [Pos(30)]
        public List<TS810_ISSLoop1> ISSLoop1 { get; set; }
        [Pos(31)]
        public CTT CTT { get; set; }
        [Pos(32)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(ISS))]
    public class TS810_ISSLoop1
    {
        
        [Required]
        [Pos(1)]
        public ISS ISS { get; set; }
        [Pos(2)]
        public PID PID { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SAC))]
    public class TS810_SACLoop2
    {
        
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(IT1))]
    public class TS810_IT1Loop1
    {
        
        [Required]
        [Pos(1)]
        public IT1 IT1 { get; set; }
        [Pos(2)]
        public CRC CRC { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        [Pos(4)]
        public CUR CUR { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<IT3> IT3 { get; set; }
        [ListCount(10)]
        [Pos(6)]
        public List<TXI> TXI { get; set; }
        [ListCount(25)]
        [Pos(7)]
        public List<CTP> CTP { get; set; }
        [ListCount(10)]
        [Pos(8)]
        public List<PAM> PAM { get; set; }
        [ListCount(40)]
        [Pos(9)]
        public List<MEA> MEA { get; set; }
        [ListCount(1000)]
        [Pos(10)]
        public List<TS810_PIDLoop1> PIDLoop1 { get; set; }
        [ListCount(25)]
        [Pos(11)]
        public List<PWK> PWK { get; set; }
        [ListCount(25)]
        [Pos(12)]
        public List<PKG> PKG { get; set; }
        [Pos(13)]
        public PO4 PO4 { get; set; }
        [ListCount(2)]
        [Pos(14)]
        public List<ITD> ITD { get; set; }
        [Pos(15)]
        public List<REF> REF { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<YNQ> YNQ { get; set; }
        [ListCount(5)]
        [Pos(17)]
        public List<PER> PER { get; set; }
        [ListCount(500)]
        [Pos(18)]
        public List<SDQ> SDQ { get; set; }
        [ListCount(10)]
        [Pos(19)]
        public List<DTM> DTM { get; set; }
        [Pos(20)]
        public List<CAD> CAD { get; set; }
        [Pos(21)]
        public List<L7> L7 { get; set; }
        [Pos(22)]
        public SR SR { get; set; }
        [ListCount(25)]
        [Pos(23)]
        public List<TS810_SACLoop1> SACLoop1 { get; set; }
        [ListCount(1000)]
        [Pos(24)]
        public List<TS810_SLNLoop1> SLNLoop1 { get; set; }
        [ListCount(200)]
        [Pos(25)]
        public List<TS810_N1Loop2> N1Loop2 { get; set; }
        [ListCount(10)]
        [Pos(26)]
        public List<TS810_LMLoop2> LMLoop2 { get; set; }
        [Pos(27)]
        public List<TS810_V1Loop2> V1Loop2 { get; set; }
        [Pos(28)]
        public List<TS810_FA1Loop2> FA1Loop2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(FA1))]
    public class TS810_FA1Loop2
    {
        
        [Required]
        [Pos(1)]
        public FA1 FA1 { get; set; }
        [Required]
        [Pos(2)]
        public List<FA2> FA2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(V1))]
    public class TS810_V1Loop2
    {
        
        [Required]
        [Pos(1)]
        public V1 V1 { get; set; }
        [Pos(2)]
        public List<R4> R4 { get; set; }
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LM))]
    public class TS810_LMLoop2
    {
        
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS810_N1Loop2
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
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(6)]
        public List<PER> PER { get; set; }
        [Pos(7)]
        public DMG DMG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SLN))]
    public class TS810_SLNLoop1
    {
        
        [Required]
        [Pos(1)]
        public SLN SLN { get; set; }
        [Pos(2)]
        public DTM DTM { get; set; }
        [Pos(3)]
        public List<REF> REF { get; set; }
        [ListCount(1000)]
        [Pos(4)]
        public List<PID> PID { get; set; }
        [ListCount(25)]
        [Pos(5)]
        public List<SAC> SAC { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<TC2> TC2 { get; set; }
        [ListCount(10)]
        [Pos(7)]
        public List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(SAC))]
    public class TS810_SACLoop1
    {
        
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(PID))]
    public class TS810_PIDLoop1
    {
        
        [Required]
        [Pos(1)]
        public PID PID { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(FA1))]
    public class TS810_FA1Loop1
    {
        
        [Required]
        [Pos(1)]
        public FA1 FA1 { get; set; }
        [Required]
        [Pos(2)]
        public List<FA2> FA2 { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(V1))]
    public class TS810_V1Loop1
    {
        
        [Required]
        [Pos(1)]
        public V1 V1 { get; set; }
        [Pos(2)]
        public List<R4> R4 { get; set; }
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N9))]
    public class TS810_N9Loop1
    {
        
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public List<MSG> MSG { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(LM))]
    public class TS810_LMLoop1
    {
        
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(N1))]
    public class TS810_N1Loop1
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
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(6)]
        public List<PER> PER { get; set; }
        [Pos(7)]
        public DMG DMG { get; set; }
    }
}
