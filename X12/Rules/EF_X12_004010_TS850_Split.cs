namespace EdiFabric.Rules.X12_004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    [Serializable()]
    [Message("X12", "004SPL", "850")]
    public class TS850Split : EdiMessage
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
        public List<TS850_N1Loop1Split> N1Loop1 { get; set; }
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
    [Group(typeof(N1))]
    public class TS850_N1Loop1Split : EdiItem
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
}
