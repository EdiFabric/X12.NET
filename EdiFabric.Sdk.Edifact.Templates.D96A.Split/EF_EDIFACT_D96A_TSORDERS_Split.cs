namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [Message("EDIFACT", "DSPL", "ORDERS")]
    public class TSORDERSSplit : EdiMessage
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
        public List<TSORDERS_LINLoop1Split> LINLoop1 { get; set; }
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
    [Group(typeof(LIN))]
    public class TSORDERS_LINLoop1Split : EdiItem
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
}
