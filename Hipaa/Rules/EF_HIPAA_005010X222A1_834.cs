namespace EdiFabric.Rules.HIPAA_005010X222A1_834
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;


    [Serializable()]
    [Message("X12", "005010X220A1", "834")]
    public class TS834 : EdiMessage
    {
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BGN BGN { get; set; }
        [Pos(3)]
        public REF REF_TransactionSetPolicyNumber { get; set; }
        [Pos(4)]
        public DTP DTP_FileEffectiveDate { get; set; }
        [Pos(5)]
        public QTY QTY_TransactionSetControlTotals { get; set; }
        [Required]
        [Pos(6)]
        public All_NM1 All_NM1 { get; set; }
        [Required]
        [Pos(7)]
        public List<Loop_2000> Loop_2000 { get; set; }
        [Required]
        [Pos(8)]
        public List<Loop_2100A> Loop_2100A { get; set; }
        [Required]
        [Pos(8)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [Pos(9)]
        public List<Loop_2310> Loop_2310 { get; set; }
        [Pos(10)]
        public List<Loop_2320> Loop_2320 { get; set; }
        [Pos(11)]
        public Loop_2330 Loop_2330 { get; set; }
        [Pos(12)]
        public Loop_2700 Loop_2700 { get; set; }
        [Required]
        [Pos(12)]
        public SE SE { get; set; }
    }

    [Serializable()]
    [EdiCodes(",00,15,22")]
    public class X12_ID_353
    {
    }

    [Serializable()]
    [EdiCodes(",AD,AS,AT,CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,MD,MS,MT,PD,PS,PT,UT")]
    public class X12_ID_623
    {
    }

    [Serializable()]
    public class X12_ID_640
    {
    }

    [Serializable()]
    [EdiCodes(",2,4,RX")]
    public class X12_ID_306
    {
    }

    [Serializable()]
    [EdiCodes(",38,0F,17,1L,23,3H,4A,6O,ABB,D3,DX,F6,P5,Q4,QQ,ZZ,")]
    public class X12_ID_128
    {
    }

    [Serializable()]
    [EdiCodes(",38,")]
    public class X12_ID_127
    {
    }

    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250
    {
    }

    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020," +
    "021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040," +
    "041,042,043,044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060," +
    "061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080," +
    "081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100," +
    "101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,118,119,120,121," +
    "122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142," +
    "143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162," +
    "163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182," +
    "183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202," +
    "203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222," +
    "223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242," +
    "243,244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262," +
    "263,264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,281,282," +
    "283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302," +
    "303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322," +
    "323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342," +
    "343,344,345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362," +
    "363,364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,382," +
    "383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402," +
    "403,404,405,406,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423," +
    "424,425,426,427,428,429,430,431,432,433,434,435,436,437,438,439,440,441,442,443," +
    "444,445,446,447,448,449,450,451,452,453,454,455,456,457,458,459,460,461,462,463," +
    "464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483," +
    "484,485,486,487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503," +
    "504,505,506,507,508,509,510,511,512,513,514,515,516,517,518,519,520,521,522,523," +
    "524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,541,542,543," +
    "544,545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563," +
    "564,565,566,567,568,569,570,571,572,573,574,575,576,577,578,579,580,581,582,583," +
    "584,585,586,587,589,590,591,592,593,594,595,596,597,598,599,600,601,602,603,604," +
    "606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,622,623,624,625," +
    "626,627,629,630,631,632,633,634,635,636,637,638,640,641,642,643,644,646,647,648," +
    "649,650,651,652,653,655,656,657,658,659,660,661,662,663,664,665,666,667,668,669," +
    "670,671,672,673,674,675,681,682,683,684,685,686,687,688,689,690,691,692,693,694," +
    "695,696,697,699,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715," +
    "716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,736," +
    "737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756," +
    "757,758,759,760,761,762,764,765,766,769,770,771,772,773,774,775,776,777,778,779," +
    "780,781,782,783,784,785,786,787,788,789,790,791,792,793,794,795,796,797,798,799," +
    "800,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,816,817,818,819," +
    "820,821,822,823,824,825,826,827,828,830,831,832,840,841,842,843,844,845,846,847," +
    "848,849,850,851,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868," +
    "869,870,871,872,873,874,875,876,877,878,879,880,881,882,883,884,885,900,901,903," +
    "904,905,906,907,908,909,910,911,912,913,914,915,916,917,918,919,920,921,922,923," +
    "924,925,926,927,928,930,931,932,933,934,935,936,937,938,939,940,941,942,943,944," +
    "945,946,947,948,949,950,951,952,953,954,955,956,957,960,961,962,963,964,965,966," +
    "967,968,969,970,971,972,973,974,975,976,977,978,979,980,981,982,983,984,985,986," +
    "987,988,989,990,992,993,994,995,996,997,998,999,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8," +
    "AA9,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS," +
    "AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABA,ABB,ABC,ABD," +
    "ABE,ABF,ABG,ABH,ABI,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY," +
    "ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT," +
    "ACU,ACV,ACW,ACX,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADR," +
    "ADS,ADT,ADU,ADV,ADW,ADX,ADY,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEK,AEL,AEM,AEN," +
    "AEO,AEP,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,ARD,AWH,BAA,BAB,BAC,BAD,BAE,BAF,BAG," +
    "BAH,BAI,BAJ,BAK,BAL,BAM,BAN,BAO,BAP,BAQ,BAR,BIP,CAD,CCR,CDD,CDT,CEA,CEB,CEC,CED," +
    "CEE,CEF,CEH,CEJ,CEK,CEL,CEM,CEN,CEO,CLO,CLU,COM,CON,CRV,CUR,DAF,DDO,DEE,DEL,DET," +
    "DFF,DFS,DIL,DIP,DIS,DLC,DOA,DOD,DOI,DOR,DSP,DTC,DTQ,E01,E02,E03,E04,E05,E06,E07," +
    "ECD,ECF,ECS,ECT,EDA,EDB,EDC,EDD,EDE,EDF,EDG,EDH,EDI,EDJ,EDK,EDL,EDM,EDN,EDO,EDP," +
    "EKD,EPP,ESC,ESF,ESS,EST,ETP,EXO,EXP,FFI,FFO,FIA,FPE,FPS,GRD,ICF,IDG,IFH,III,IMP," +
    "INC,INT,IPS,IVA,KEV,KEW,LAM,LAS,LCC,LEA,LEL,LIQ,LLP,LOG,LPC,LSC,LTP,MRR,MSD,NAM," +
    "NFD,NOD,NRG,NSD,ORG,PBC,PCP,PCS,PDE,PDR,PDV,PLS,PPC,PPD,PPP,PRD,PRR,PSA,PSC,PSF," +
    "PTD,PTO,RAP,RES,RFD,RFF,RFO,RNT,RRM,RRT,RSD,RSS,RTO,SCV,SDD,SFH,STN,SVA,TSR,TSS," +
    "TST,VAT,VLU,W01,W02,W03,W05,W06,W07,W08,W09,W10,W11,W12,W13,WAA,WAY,YXX,YXY,ZZZ," +
    "")]
    public class X12_ID_374
    {
    }

    [Serializable()]
    [EdiCodes(",DT,ET,TO")]
    public class X12_ID_673
    {
    }

    [Serializable()]
    public class X12_R
    {
    }

    [Serializable()]
    [EdiCodes(",P5,IN,BO,TV,")]
    public class X12_ID_98
    {
    }

    [Serializable()]
    [EdiCodes(",24,FI,XV,")]
    public class X12_ID_66
    {
    }

    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073
    {
    }

    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069
    {
    }

    [Serializable()]
    [EdiCodes(@",001,021,024,030,")]
    public class X12_ID_875
    {
    }

    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203
    {
    }

    [Serializable()]
    [EdiCodes(",A,C,I,S,T,V,")]
    public class X12_ID_1216
    {
    }

    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_1219
    {
    }

    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AO,AP,AU,CA,CO,CT,DC,DD,DI,DQ,DR,DS,FA,FB,FC,FO,FT,HD,IA" +
    ",IR,L1,LA,LE,LF,LM,LS,LU,LW,LX,NE,OS,OT,PA,PE,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,R" +
    "T,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TP,TR,UK,VO,ZZ,")]
    public class X12_ID_584
    {
    }

    [Serializable()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }

    [Serializable()]
    [EdiCodes(",IP,")]
    public class X12_ID_366
    {
    }

    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,FX,HP,TE,WP,")]
    public class X12_ID_365
    {
    }

    [Serializable()]
    public class X12_ID
    {
    }

    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309
    {
    }

    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068
    {
    }

    [Serializable()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }

    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z,")]
    public class X12_ID_1109
    {
    }

    [Serializable()]
    [EdiCodes(",0,1,10,100,101,102,103,104,105,106,107,108,109,11,12,13,14,15,16,17,18,19,20,21," +
    "22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,4" +
    "7,48,49,5,50,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,7,71,72,73,74,75" +
    ",78,79,8,80,81,82,83,84,85,87,88,89,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4," +
    "A5,A6,A7,A8,A9,AA,AAA,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AA" +
    "R,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AB,ABF,ABJ,ABK,ABN,ABR,ABS,ABU,ABV,AC,ACR,AD,ADD,A" +
    "DJ,AE,AF,AG,AH,AI,AJ,AJT,AK,AL,ALM,ALP,AM,AN,AO,APE,APR,AQ,AR,ARI,AS,ASD,AT,ATD," +
    "ATT,AU,AV,AW,AX,AY,AZ,B,BA,BB,BBQ,BBR,BC,BCC,BCR,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BN,B" +
    "O,BP,BPL,BQ,BR,BRL,BS,BSL,BSP,BT,BTC,BU,BUI,BV,BW,BX,BY,BZ,C,C1,C2,C3,CA,CAH,CB," +
    "CC,CD,CE,CF,CFI,CG,CH,CHG,CI,CIE,CJ,CK,CL,CLP,CM,CML,CN,CNC,CO,COG,CP,CPS,CQ,CR," +
    "CRC,CS,CSD,CSF,CT,CU,CV,CW,CZ,D,D1,D2,D3,D4,D5,DA,DAC,DB,DBS,DC,DD,DE,DF,DG,DGO," +
    "DH,DI,DJ,DK,DL,DLO,DLP,DM,DN,DO,DOF,DP,DPE,DPL,DQ,DR,DRL,DS,DSR,DSS,DT,DU,DW,DX," +
    "DY,DZ,E,EA,EAA,EAB,EAC,EAD,EAE,EAF,EAG,EAH,EAI,EAJ,EAK,EAL,EAM,EAN,EAO,EAP,EAQ,E" +
    "AR,EAS,EAT,EAU,EAV,EAW,EAX,EAY,EAZ,EB,EBA,EBB,EBC,EBD,EBE,EBF,EBG,EBH,EBI,EBJ,EB" +
    "K,EBL,EBM,EBN,EBO,EBP,EBQ,EBR,EBS,EBT,EBU,EBV,EBW,EBX,EBY,EBZ,EC,ECA,ECB,ECC,ECD" +
    ",ECE,ECF,ECG,ECH,ECI,ECJ,ECK,ECL,ECM,ECN,ECO,ECP,ECQ,ECR,ECS,ECT,ECU,ECV,ECW,ECX" +
    ",ECY,ECZ,ED,EDA,EDB,EDC,EDD,EDE,EDF,EDG,EDH,EDI,EDJ,EDK,EDL,EDM,EDN,EDO,EDP,EDQ," +
    "EDR,EDS,EDT,EDU,EDV,EDW,EDX,EDY,EDZ,EE,EEA,EEB,EEC,EED,EEE,EEF,EEG,EEH,EEI,EEJ,E" +
    "EK,EEL,EEM,EEN,EEO,EEP,EEQ,EER,EES,EF,EG,EH,EI,EJ,EK,EL,EM,EMC,EN,EO,EQ,EQR,ER,E" +
    "S,ESC,ESL,ET,ETL,EU,EV,EW,EWC,EWR,EX,EXD,EY,EZ,F,FA,FAP,FB,FC,FC1,FD,FE,FF,FF1,F" +
    "G,FH,FH1,FI,FIR,FJ,FK,FL,FL1,FM,FMO,FMS,FN,FO,FP,FP1,FQ,FR,FRP,FS,FT,FT1,FU,FV,F" +
    "W,FX,FZ,G,G1,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H,HA,HB" +
    ",HC,HD,HE,HF,HG,HI,HJ,HK,HL,HM,HO,HRC,HS,HZR,I,IBP,IC,ID,IF,IMC,IMP,IND,IPA,IQ,I" +
    "RR,IRT,IT,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCL,JD,JE,JF,JG,JH,JI,JK,JL,J" +
    "M,JN,JO,JOL,JP,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KS,KT,KU,KW,KYL" +
    ",KZ,L,LA,LB,LC,LD,LE,LF,LG,LH,LIN,LJ,LK,LM,LN,LO,LOC,LOI,LP,LQ,LR,LS,LSC,LT,LZ,M" +
    ",MA,MAC,MB,MC,MCC,MCD,ME,MEC,MI,MJ,MK,ML,MN,MOC,MOE,MRI,MS,MT,N,NA,NAC,NAF,NAN,N" +
    "AS,NB,NC,ND,NDC,NE,NF,NH,NI,NIR,NJ,NK,NP,NPC,NR,NS,NT,NUB,O,O1,O2,O3,O4,OC,P,PA," +
    "PB,PC,PCR,PD,PDA,PGS,PHC,PI,PIT,PL,PLC,PLS,POB,PPD,PPP,PPS,PPV,PQA,PR,PRA,PRC,PR" +
    "I,PRR,PRT,PS,PT,PWA,PWI,PWR,PWS,PWT,Q,QA,QB,QC,QDR,QE,QF,QG,QH,QI,QJ,QK,QS,QT,R," +
    "R1,R2,R3,R4,RA,RAS,RC,RCA,RD,RE,REC,RED,REN,RET,RFC,RI,RJC,RQ,RSS,RT,RTC,RUM,RVC" +
    ",RX,S,SA,SAT,SB,SBA,SC,SCI,SD,SE,SEC,SET,SF,SG,SH,SHL,SHM,SHN,SHO,SHP,SHQ,SHR,SH" +
    "S,SHT,SHU,SHV,SHW,SHX,SHY,SHZ,SI,SIA,SIB,SIC,SID,SIE,SIF,SIG,SIH,SII,SIJ,SIK,SIL" +
    ",SIM,SIN,SIO,SIP,SIQ,SIR,SIS,SIT,SIU,SIV,SIW,SIX,SIY,SIZ,SJ,SJA,SJB,SJC,SJD,SJE," +
    "SJF,SJG,SJH,SJI,SJJ,SJK,SJL,SJM,SJN,SJO,SJP,SJQ,SJR,SJS,SJT,SJU,SJV,SJW,SJX,SJY," +
    "SJZ,SKA,SKB,SKC,SKD,SKE,SKF,SKG,SKH,SKI,SKJ,SKK,SKL,SKM,SKN,SKO,SKP,SKQ,SKR,SKS," +
    "SKT,SKU,SKV,SKW,SKX,SKY,SKZ,SL,SLA,SLS,SMB,SMC,SMD,SMI,SMT,SO,SP,SPE,SR,SRL,SRR," +
    "SRT,SS,SSC,ST,STC,STF,SUI,SVC,SWR,T,T00,T01,T02,T03,T04,T05,T06,T07,T08,T09,T10," +
    "T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28,T29,T30," +
    "T31,T32,T33,T34,T35,TB,TC,TCD,TCL,TD,TE,TF,TFR,TG,TL,TOL,TP,TQ,TR,TT,TTL,TX,TY,U" +
    ",UER,UJC,UNP,UPC,UPT,UR,US,UT,UTC,UU,V,VAL,VP,W,WDL,WRC,WSD,X,XD,Y,Z,ZZ,")]
    public class X12_ID_1270
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,")]
    public class X12_ID_1066
    {
    }

    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
    ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,53,54,5" +
    "5,56,57,58,ZZ,")]
    public class X12_ID_1176
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,B,C,H,Q,S,U,Z,")]
    public class X12_ID_594
    {
    }

    [Serializable()]
    [EdiCodes(",403,AC,ADD,AF,AG,AH,AI,AJ,AK,AP,AR,BC,BE,BH,BK,CHU,CLF,CV,DCP,DEN,EMP,EPO,FAC,FS" +
    "A,GDC,HE,HLT,HMO,IRA,IRC,LL,LTC,LTD,MM,MOD,NGD,NQ,PDG,POS,PPO,PRA,PSP,QDA,QDC,ST" +
    "D,UL,UR,VIS,ZZZ,")]
    public class X12_ID_1205
    {
    }

    [Serializable()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,SPC,SPO,TWO,")]
    public class X12_ID_1207
    {
    }

    [Serializable()]
    [EdiCodes(",A,B,C,D,I,N,S,")]
    public class X12_ID_1209
    {
    }

    [Serializable()]
    [EdiCodes(",AM,BAX,FLR,HCS,NP,PCS,THR,ZZ,")]
    public class X12_ID_1211
    {
    }

    [Serializable()]
    [EdiCodes(",1X,3D,80,FA,OD,P3,QA,QN,Y2")]
    public class X12_ID_98_9
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065
    {
    }

    [Serializable()]
    [EdiCodes(",SV,XX,")]
    public class X12_ID_66_2
    {
    }

    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,CP,OP,PI,")]
    public class X12_ID_706
    {
    }

    [Serializable()]
    [EdiCodes(",00,001,002,003,004,005,006,007,008,01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G," +
    "0H,0I,0J,0P,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M" +
    ",1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2" +
    "D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33," +
    "34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U" +
    ",3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4" +
    "L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B," +
    "5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62" +
    ",63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6" +
    "T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J," +
    "7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A" +
    ",8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,90,91,9" +
    "2,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9N,9O,9P,9Q,9R,9S,9T," +
    "9U,9V,9W,9X,9Y,9Z,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8," +
    "AA9,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAS,AAT," +
    "AAU,AAV,AAW,AB,AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABB,ABC,ABD,ABE,ABF,ABG,ABH,A" +
    "BI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,AC,AC1,AC2,AC3,AC" +
    "B,ACC,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,AC" +
    "W,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADH,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR" +
    ",ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AE,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEI,AEJ,AEK,AEL," +
    "AF,AG,AH,AHM,AI,AJ,AK,AL,ALA,ALO,AM,AN,AO,AP,APR,AQ,AR,AS,AT,ATA,AU,AUO,AV,AW,AX" +
    ",AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAL,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BKR,BL,BL" +
    "D,BLT,BM,BN,BO,BOW,BP,BQ,BR,BRN,BS,BT,BU,BUS,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C4A,C" +
    "5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CHA,CI,CJ,CK,CL,CLT,CM,CMW,CN,CNP,CNR,CNS," +
    "CO,COD,COL,COM,COR,CP,CQ,CR,CRW,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8," +
    "D9,DA,DAM,DB,DC,DCC,DD,DE,DF,DG,DH,DI,DIR,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV" +
    ",DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EAA,EAB,EAD,EAE,EAF,EAG,EAH,EAI,EA" +
    "J,EAK,EAL,EAM,EAN,EAO,EAP,EAQ,EAR,EAS,EAT,EAU,EAV,EAW,EAX,EAY,EAZ,EB,EBA,EBB,EBC" +
    ",EBD,EBE,EBF,EBG,EBH,EBI,EBJ,EBK,EBL,EBM,EBN,EBO,EBP,EBQ,EBR,EBS,EC,ED,EE,EF,EG," +
    "EH,EI,EJ,EK,EL,EM,EN,ENR,EO,EP,EQ,ER,ET,EU,EV,EW,EX,EXS,EY,EZ,F1,F2,F3,F4,F5,F6," +
    "F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FGT,FH,FI,FJ,FL,FM,FN,FO,FP,FQ,FR,FRL,FS,FSI,FSR,F" +
    "T,FU,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G5,G6,G7,G8,G9,GA,GB,GBA,GBO,GBP,GC,GD,GE,GF,GG," +
    "GH,GI,GIR,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H5,H6,H7,H" +
    "9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HMI,HN,HO,HOM,HON,HP,HQ,HR,HS,HT,HU,HV," +
    "HW,HX,HY,HZ,I1,I3,I4,I9,IA,IAA,IAC,IAD,IAE,IAF,IAG,IAH,IAI,IAK,IAL,IAM,IAN,IAO,I" +
    "AP,IAQ,IAR,IAS,IAT,IAU,IAV,IAW,IAY,IAZ,IB,IC,ICP,ID,IE,IF,IG,II,IJ,IK,IL,IM,IMM," +
    "IN,INT,INV,IO,IP,IQ,IR,IS,IT,IU,IV,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF," +
    "JG,JH,JI,JJ,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K1,K2,K3,K4,K5,K6,K7" +
    ",K8,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,K" +
    "Y,KZ,L1,L2,L3,L5,L8,L9,LA,LB,LC,LCN,LD,LE,LF,LG,LGS,LH,LI,LJ,LK,LL,LM,LN,LO,LP,L" +
    "Q,LR,LS,LT,LU,LV,LW,LY,LYM,LYN,LYO,LYP,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD" +
    ",ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MSC,MT,MTR,MU,MV,MW,MX,MY,MZ,N1,N2" +
    ",N3,N4,N5,N6,N7,N8,N9,NB,NC,NCT,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NP,NPC,NQ,NR,NS" +
    ",NT,NU,NV,NW,NX,NY,NZ,O1,O2,O3,O4,O5,O6,O7,O8,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,OM,O" +
    "N,OO,OP,OR,ORI,OS,OSH,OT,OU,OUC,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA," +
    "PB,PC,PD,PE,PF,PG,PH,PI,PIC,PJ,PK,PL,PLC,PLR,PM,PMC,PMF,PMG,PN,PO,PP,PPC,PPS,PQ," +
    "PR,PRE,PRO,PRP,PS,PT,PU,PUR,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,Q" +
    "D,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R0,R1,R2,R3," +
    "R4,R5,R6,R7,R8,R9,RA,RB,RC,RCR,RD,REC,RF,RG,RGA,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR" +
    ",RR2,RR3,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SE" +
    "P,SF,SG,SH,SI,SIC,SIP,SJ,SK,SL,SM,SN,SNP,SO,SP,SQ,SR,SS,ST,STC,SU,SUS,SV,SW,SX,S" +
    "Y,SZ,T1,T2,T3,T4,T6,T8,T9,TA,TB,TC,TD,TE,TEC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOW,T" +
    "P,TPM,TQ,TR,TS,TSD,TSE,TSR,TT,TTP,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U4,U5,U6,U7,U8,U9,U" +
    "A,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UW,UX,UY,UZ,V1,V2," +
    "V3,V4,V5,V6,V8,V9,VA,VB,VC,VD,VE,VER,VF,VG,VH,VI,VIC,VJ,VK,VL,VM,VN,VO,VP,VQ,VR," +
    "VS,VT,VU,VV,VW,VX,VY,W1,W2,W3,W4,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WL,WN,WO,WP" +
    ",WR,WS,WT,WU,WV,WW,WX,WY,WZ,X1,X2,X3,X4,X5,X6,X7,X8,XA,XC,XD,XE,XF,XG,XH,XI,XJ,X" +
    "K,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y2,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ," +
    "YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT,YU,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB" +
    ",ZC,ZD,ZE,ZF,ZG,ZH,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_98_2
    {
    }

    [Serializable()]
    [EdiCodes(",N,O,P,S,T,U,")]
    public class X12_ID_1138
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143
    {
    }

    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365
    {
    }

    [Serializable()]
    [Segment("BGN")]
    public class BGN
    {
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }

        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetReferenceNumber_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string TransactionSetCreationDate_03 { get; set; }

        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string TransactionSetCreationTime_04 { get; set; }

        [DataElement("623", typeof(X12_ID_623))]
        [Pos(5)]
        public string TimeZoneCode_05 { get; set; }

        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }

        [DataElement("306", typeof(X12_ID_306))]
        [Pos(7)]
        public string ActionCode_07 { get; set; }
    }

    [Serializable()]
    [Segment("REF")]
    public class REF
    {
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
    }

    [Serializable()]
    [Segment("DTP")]
    public class DTP
    {

        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string DateTimePeriod_03 { get; set; }
    }

    [Serializable()]
    [Segment("QTY")]
    public class QTY
    {

        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
    }

    [Serializable()]
    [All()]
    public class All_NM1
    {
        [Required]
        [Pos(1)]
        public Loop_1000A Loop_1000A { get; set; }
        [Required]
        [Pos(2)]
        public Loop_1000B Loop_1000B { get; set; }
        [Pos(3)]
        public Loop_1000C Loop_1000C { get; set; }
    }

    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98))]
    public class NM1
    {
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [StringLength(1, 2)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
    }

    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_ReferringProviderName
    {

        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }

    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_InsuranceProviderName
    {

        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
    }

    [Serializable()]
    [Group(typeof(NM1))]
    public class Loop_1000A
    {
        [Required]
        [Pos(1)]
        public NM1 NM1_SponsorName { get; set; }
    }

    [Serializable()]
    [Group(typeof(NM1))]
    public class Loop_1000B
    {
        [Required]
        [Pos(1)]
        public NM1 NM1_PayerName { get; set; }
    }

    [Serializable()]
    [Group(typeof(NM1))]
    public class Loop_1000C
    {
        [Required]
        [Pos(1)]
        public NM1 NM1_BrokerName { get; set; }
    }

    [Serializable()]
    [Segment("INS")]
    public class INS
    {

        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(1)]
        public string YesNoConditionorResponseCode_01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [DataElement("875", typeof(X12_ID_875))]
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        [DataElement("1203", typeof(X12_ID_1203))]
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        [DataElement("1216", typeof(X12_ID_1216))]
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        [DataElement("1218", typeof(X12_ID_1218))]
        [Pos(6)]
        public string MedicarePlanCode_06 { get; set; }
        [DataElement("1219", typeof(X12_ID_1219))]
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        [DataElement("1165", typeof(X12_AN))]
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(14)]
        public string CityName_14 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]//TODO: Add applicable country codes.
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1470", typeof(X12_N0))]
        [Pos(17)]
        public string Number_17 { get; set; }
    }

    [Serializable()]
    [Segment("PER")]
    public class PER
    {

        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }

    [Serializable()]
    [Segment("COB")]
    public class COB
    {

        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(3)]
        public string CoordinationofBenefitsCode_03 { get; set; }
        [DataElement("1365", typeof(X12_ID_1365))]
        [Pos(4)]
        public string ServiceTypeCode_04 { get; set; }
    }

    [Serializable()]
    [Segment("N3")]
    public class N3_MemberResidenceStreetAddress
    {
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string Address_Information_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string Address_Information_02 { get; set; }
    }

    [Serializable()]
    [Segment("N4")]
    public class N4_OtherSubscriberCity_State_ZIPCode
    {

        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OtherSubscriberCityName_01 { get; set; }
        [Exclusion(7)]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [Conditional(4)]
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }

    [Serializable()]
    [Segment("PER")]
    public class EC_EmploymentClass
    {

        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(1)]
        public string EmpoymentClassCode_01 { get; set; }
        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(2)]
        public string EmpoymentClassCode_02 { get; set; }
        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(3)]
        public string EmpoymentClassCode_03 { get; set; }
    }

    [Serializable()]
    [Segment("ICM")]
    public class ICM
    {

        [Required]
        [DataElement("594", typeof(X12_ID_594))]
        [Pos(1)]
        public string FrequencyCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(4)]
        public string LocationIdentifier_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1214", typeof(X12_AN))]
        [Pos(5)]
        public string SalaryGrade_05 { get; set; }
    }

    [Serializable()]
    [Composite("C056_CompositeRaceorEthnicityInformation_2")]
    public class C056_CompositeRaceorEthnicityInformation
    {

        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public string RaceorEthnicityCode_01 { get; set; }
        [Paired(3)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public string CodeListQualifierCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public string IndustryCode_03 { get; set; }
    }

    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250))]
    public class DMG_MemberDemographicInformation
    {

        [Paired(2)]
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string SubscriberGenderCode_03 { get; set; }
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        [ListCount(10)]
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        public string Quantity_09 { get; set; }
        [Paired(11)]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
    }

    [Serializable()]
    [Segment("HD")]
    public class HD
    {

        [Required]
        [DataElement("875", typeof(X12_ID_875))]
        [Pos(1)]
        public string MaintenanceTypeCode_01 { get; set; }
        [DataElement("1203", typeof(X12_ID_1203))]
        [Pos(2)]
        public string MaintenanceReasonCode_02 { get; set; }
        [DataElement("1205", typeof(X12_ID_1205))]
        [Pos(3)]
        public string InsuranceLineCode_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("1204", typeof(X12_AN))]
        [Pos(4)]
        public string PlanCoverageDescription_04 { get; set; }
        [DataElement("1207", typeof(X12_ID_1207))]
        [Pos(5)]
        public string CoverageLevelCode_05 { get; set; }
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(6)]
        public string Count_06 { get; set; }
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(7)]
        public string Count_07 { get; set; }
        [DataElement("1209", typeof(X12_ID_1209))]
        [Pos(8)]
        public string UnderwritingDecisionCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [DataElement("1211", typeof(X12_ID_1211))]
        [Pos(10)]
        public string DrugHouseCode_10 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(11)]
        public string YesNoConditionorResponseCode_11 { get; set; }
    }

    [Serializable()]
    [Segment("LX")]
    public class LX
    {

        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }

    [Serializable()]
    [All()]
    public class All_DTP
    {

        [ListCount(6)]
        [Pos(1)]
        public List<DTP> DTP_HealthCoverageDates { get; set; }
    }

    [Serializable()]
    public class Loop_2000
    {
        [Required]
        [Pos(1)]
        public INS INS { get; set; }
        [Required]
        [Pos(2)]
        public REF Ref_SubscriberIdentifier { get; set; }
        [Pos(3)]
        public REF Ref_MemberSupplementalIdentifier { get; set; }//This may need to be a list?
        [Pos(4)]
        public List<DTP> DTP_MemberLevelDates { get; set; }
    }

    [Serializable()]
    public class Loop_2100A
    {
        [Required]
        [Pos(1)]
        public NM1 NM1_MemberName { get; set; }
        [Required]
        [Pos(2)]
        public PER Per_MemberCommunicationNumbers { get; set; }
        [Required]
        [Pos(2)]
        public N3_MemberResidenceStreetAddress N3_MemberResidenceStreetAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_OtherSubscriberCity_State_ZIPCode N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        [Required]
        [Pos(3)]
        public DMG_MemberDemographicInformation DMG_MemberDemographicInformation { get; set; }
        [Pos(4)]
        public EC_EmploymentClass EC_EmploymentClass { get; set; }
        [Pos(5)]
        public ICM ICM_MemberIncome { get; set; }
    }

    [Serializable()]
    //[Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300
    {

        [Required]
        [Pos(1)]
        public HD HD_HealthCoverage { get; set; }
        [ListCount(6)]
        [Pos(2)]
        public List<DTP> DTP_HealthCoverageDates { get; set; }
        [ListCount(14)]
        [Pos(3)]
        public List<REF> REF_HealthCoveragePolicyNumbers { get; set; }
    }

    [Serializable]
    public class Loop_2310
    {
        [Pos(1)]
        public LX LX_ProviderInformation { get; set; }
        [Pos(2)]
        public NM1_ReferringProviderName NM1_ReferingProviderName { get; set; }
    }

    [Serializable]
    public class Loop_2320
    {
        [Pos(1)]
        public COB COB_CoordinationOfBenefits { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<REF> REF_AdditionalCoordinationOfBenefitsIdentifiers { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<DTP> DTP_CoordinationOfBenefitsEleigibilityDates { get; set; }
    }

    [Serializable]
    public class Loop_2330
    {
        [Pos(1)]
        public NM1_InsuranceProviderName NM1_CoordinationOfBenefitsRelatedEntity { get; set; }
    }

    [Serializable]
    public class Loop_2700
    {
        [Pos(1)]
        public LX LX_MemberReportingCategories { get; set; }
    }



}
