namespace EdiFabric.Templates.X12004010
{
    using Microsoft.EntityFrameworkCore;
    using EdiFabric.Core.Model.Edi.X12;
    public class X12Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=X12_4010_850;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<ADV> ADV { get; set; }
        public DbSet<AMT> AMT { get; set; }       
        public DbSet<BAL> BAL { get; set; }       
        public DbSet<BEG> BEG { get; set; }
        public DbSet<BIG> BIG { get; set; }
        public DbSet<CAD> CAD { get; set; }
        public DbSet<CB1> CB1 { get; set; }
        public DbSet<CN1> CN1 { get; set; }
        public DbSet<CRC> CRC { get; set; }
        public DbSet<CSH> CSH { get; set; }
        public DbSet<CTB> CTB { get; set; }
        public DbSet<CTP> CTP { get; set; }
        public DbSet<CTT> CTT { get; set; }
        public DbSet<CUR> CUR { get; set; }
        public DbSet<DIS> DIS { get; set; }
        public DbSet<DMG> DMG { get; set; }
        public DbSet<DTM> DTM { get; set; }
        public DbSet<FA1> FA1 { get; set; }
        public DbSet<FA2> FA2 { get; set; }
        public DbSet<FOB> FOB { get; set; }
        public DbSet<G61> G61 { get; set; }
        public DbSet<INC> INC { get; set; }
        public DbSet<ISS> ISS { get; set; }
        public DbSet<IT1> IT1 { get; set; }
        public DbSet<IT3> IT3 { get; set; }
        public DbSet<IT8> IT8 { get; set; }
        public DbSet<ITD> ITD { get; set; }
        public DbSet<L7> L7 { get; set; }
        public DbSet<LDT> LDT { get; set; }
        public DbSet<LE> LE { get; set; }
        public DbSet<LIN> LIN { get; set; }
        public DbSet<LM> LM { get; set; }
        public DbSet<LQ> LQ { get; set; }
        public DbSet<LS> LS { get; set; }
        public DbSet<MAN> MAN { get; set; }
        public DbSet<MEA> MEA { get; set; }
        public DbSet<MSG> MSG { get; set; }
        public DbSet<MTX> MTX { get; set; }
        public DbSet<N1> N1 { get; set; }
        public DbSet<N2> N2 { get; set; }
        public DbSet<N3> N3 { get; set; }
        public DbSet<N4> N4 { get; set; }
        public DbSet<N9> N9 { get; set; }
        public DbSet<NTE> NTE { get; set; }
        public DbSet<NX2> NX2 { get; set; }
        public DbSet<PAM> PAM { get; set; }
        public DbSet<PCT> PCT { get; set; }
        public DbSet<PER> PER { get; set; }
        public DbSet<PID> PID { get; set; }
        public DbSet<PKG> PKG { get; set; }
        public DbSet<PO1> PO1 { get; set; }
        public DbSet<PO3> PO3 { get; set; }
        public DbSet<PO4> PO4 { get; set; }
        public DbSet<PWK> PWK { get; set; }
        public DbSet<QTY> QTY { get; set; }
        public DbSet<R4> R4 { get; set; }
        public DbSet<REF> REF { get; set; }
        public DbSet<SAC> SAC { get; set; }
        public DbSet<SCH> SCH { get; set; }
        public DbSet<SDQ> SDQ { get; set; }
        public DbSet<SI> SI { get; set; }
        public DbSet<SLN> SLN { get; set; }
        public DbSet<SPI> SPI { get; set; }
        public DbSet<SR> SR { get; set; }
        public DbSet<TAX> TAX { get; set; }
        public DbSet<TC2> TC2 { get; set; }
        public DbSet<TD1> TD1 { get; set; }
        public DbSet<TD3> TD3 { get; set; }
        public DbSet<TD4> TD4 { get; set; }
        public DbSet<TD5> TD5 { get; set; }
        public DbSet<TDS> TDS { get; set; }
        public DbSet<TXI> TXI { get; set; }
        public DbSet<V1> V1 { get; set; }
        public DbSet<YNQ> YNQ { get; set; }
        public DbSet<ST> ST { get; set; }
        public DbSet<SE> SE { get; set; }
        public DbSet<C001> C001 { get; set; }
        public DbSet<C002> C002 { get; set; }
        public DbSet<C040> C040 { get; set; }
        public DbSet<Loop_ADV_850> Loop_ADV_850 { get; set; }
        public DbSet<Loop_AMT_850> Loop_AMT_850 { get; set; }
        public DbSet<Loop_AMT_850_2> Loop_AMT_850_2 { get; set; }
        public DbSet<Loop_CB1_850> Loop_CB1_850 { get; set; }
        public DbSet<Loop_CTP_850> Loop_CTP_850 { get; set; }
        public DbSet<Loop_CTT_850> Loop_CTT_850 { get; set; }
        public DbSet<Loop_FA1_850> Loop_FA1_850 { get; set; }
        public DbSet<Loop_LDT_850> Loop_LDT_850 { get; set; }
        public DbSet<Loop_LDT_850_2> Loop_LDT_850_2 { get; set; }
        public DbSet<Loop_LM_850> Loop_LM_850 { get; set; }
        public DbSet<Loop_LS_850> Loop_LS_850 { get; set; }
        public DbSet<Loop_N1_850> Loop_N1_850 { get; set; }
        public DbSet<Loop_N1_850_2> Loop_N1_850_2 { get; set; }
        public DbSet<Loop_N1_850_3> Loop_N1_850_3 { get; set; }
        public DbSet<Loop_N1_850_4> Loop_N1_850_4 { get; set; }
        public DbSet<Loop_N9_850> Loop_N9_850 { get; set; }
        public DbSet<Loop_N9_850_2> Loop_N9_850_2 { get; set; }
        public DbSet<Loop_PID_850> Loop_PID_850 { get; set; }
        public DbSet<Loop_PKG_850> Loop_PKG_850 { get; set; }
        public DbSet<Loop_PO1_850> Loop_PO1_850 { get; set; }
        public DbSet<Loop_QTY_850> Loop_QTY_850 { get; set; }
        public DbSet<Loop_SAC_850> Loop_SAC_850 { get; set; }
        public DbSet<Loop_SAC_850_2> Loop_SAC_850_2 { get; set; }
        public DbSet<Loop_SCH_850> Loop_SCH_850 { get; set; }
        public DbSet<Loop_SLN_850> Loop_SLN_850 { get; set; }
        public DbSet<Loop_SPI_850> Loop_SPI_850 { get; set; }
        public DbSet<TS850> TS850 { get; set; }
        
    }
}
