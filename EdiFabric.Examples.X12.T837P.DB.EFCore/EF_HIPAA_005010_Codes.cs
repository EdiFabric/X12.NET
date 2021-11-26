namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0019,")]
    public class X12_ID_1005_5
    {
    }
    
    /// <summary>
    /// Claim Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",AD,AP,CC,CL,CP,I,RA,RB,RC,RD,RO,")]
    public class X12_ID_1029_2
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL" +
        ",CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,12,13,14,15,16,17,AM,BL,CH,CI,DS,FI,HM,LM,MA,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032_3
    {
    }
    
    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_2
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class X12_ID_1065
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_2
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_3
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,")]
    public class X12_ID_1066
    {
    }
    
    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }
    
    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_2
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_2
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,18,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_4
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069_5
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",18,")]
    public class X12_ID_1069_6
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073_2
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_4
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,W,Y,")]
    public class X12_ID_1073_5
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z,")]
    public class X12_ID_1109
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E1,E2,E3,")]
    public class X12_ID_1136
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",75,")]
    public class X12_ID_1136_2
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1136_3
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",70,")]
    public class X12_ID_1136_4
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",09,")]
    public class X12_ID_1136_5
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_8
    {
    }
    
    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,P,S,T,U,")]
    public class X12_ID_1138_2
    {
    }
    
    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143_2
    {
    }
    
    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166_2
    {
    }
    
    /// <summary>
    /// Student Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BI,")]
    public class X12_ID_1221_10
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PE,")]
    public class X12_ID_1221_5
    {
    }
    
    /// <summary>
    /// Provider Specialty Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DEN,DGP,END,IHG,OPY,ORT,OSY,PDT,PED,PHD,PST,")]
    public class X12_ID_1222
    {
    }
    
    /// <summary>
    /// Provider Organization Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,")]
    public class X12_ID_1223
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DDT,DT,DTD,DTS,EH,KA,MCY,MD,MM,RD,RD2,RD4,RD5,RD6," +
        "RD8,RDM,RDT,RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_2
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_6
    {
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_127
    {
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_127_2
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABF,BF,")]
    public class X12_ID_1270_11
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,")]
    public class X12_ID_1270_20
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BO,")]
    public class X12_ID_1270_23
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AS,UT,")]
    public class X12_ID_1270_25
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
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
    public class X12_ID_1270_28
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BG,")]
    public class X12_ID_1270_4
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABK,BK,")]
    public class X12_ID_1270_6
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9A,")]
    public class X12_ID_128_10
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EW,")]
    public class X12_ID_128_11
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9C,")]
    public class X12_ID_128_12
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LX,")]
    public class X12_ID_128_13
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D9,")]
    public class X12_ID_128_14
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",X4,")]
    public class X12_ID_128_16
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EA,")]
    public class X12_ID_128_17
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0B,1G,G2,")]
    public class X12_ID_128_18
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P4,")]
    public class X12_ID_128_19
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G2,LU,")]
    public class X12_ID_128_2
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,01A,01B,01C,01D,01E,01G,01H,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G,0H,0" +
        "I,0J,0K,0L,0M,0N,0P,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J," +
        "1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A" +
        ",2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,3" +
        "1,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R," +
        "3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I" +
        ",4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,5" +
        "9,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z," +
        "60,61,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R" +
        ",6S,6T,6U,6V,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7" +
        "J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A," +
        "8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8U,8V,8W,8X,8Y,8Z,90,91,92" +
        ",93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9P,9Q,9R,9S,9T,9" +
        "U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3,A4,A5,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,A" +
        "AI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB,ABA,AB" +
        "B,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,AB" +
        "V,ABW,ABX,ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO" +
        ",ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH," +
        "ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AE,AEA,A" +
        "EB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AEN,AEO,AEP,AEQ,AER,AES,AET,AEU,A" +
        "EV,AEX,AEY,AEZ,AF,AFA,AFB,AFC,AFD,AFE,AFF,AFG,AFH,AFI,AFJ,AFK,AFL,AFM,AFN,AFO,AF" +
        "P,AFQ,AFR,AFS,AFT,AFU,AFV,AFW,AFX,AFY,AFZ,AG,AGA,AGB,AGC,AGD,AGH,AGI,AGJ,AGK,AGL" +
        ",AGM,AGN,AGO,AGP,AGQ,AH,AHC,AI,AJ,AK,AL,ALC,ALG,ALH,ALI,ALJ,ALR,ALS,ALT,AM,AN,AO" +
        ",AP,APC,API,AQ,AR,AS,ASL,ASP,AST,AT,ATC,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B" +
        "8,B9,BA,BAA,BAB,BAC,BAD,BAE,BAF,BAG,BAH,BAI,BAJ,BAK,BB,BC,BCI,BCN,BCP,BD,BDG,BDN" +
        ",BE,BEN,BF,BG,BH,BI,BJ,BK,BKT,BL,BLT,BM,BMM,BN,BO,BOI,BP,BQ,BR,BS,BT,BU,BV,BW,BX" +
        ",BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ," +
        "CAK,CAL,CAM,CAT,CB,CBG,CC,CD,CDN,CDT,CE,CF,CFR,CG,CH,CHR,CI,CID,CIR,CIT,CJ,CK,CL" +
        ",CLI,CM,CMN,CMP,CMT,CN,CNA,CNO,CNS,CO,COL,COT,CP,CPA,CPD,CPR,CPT,CQ,CR,CRN,CRS,C" +
        "S,CSC,CSG,CST,CT,CTS,CU,CUB,CV,CVS,CW,CX,CY,CYC,CZ,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9" +
        ",DA,DAI,DAN,DB,DC,DD,DE,DF,DG,DH,DHH,DI,DIS,DJ,DK,DL,DM,DN,DNR,DNS,DO,DOA,DOC,DO" +
        "E,DOI,DOJ,DOL,DON,DOS,DOT,DP,DQ,DR,DRN,DS,DSC,DSI,DST,DT,DTS,DU,DUN,DV,DW,DX,DY," +
        "DZ,E00,E01,E02,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ECA,ECB,ECC,ECD,ECE,ECF,ECJ,E" +
        "D,EDA,EE,EF,EG,EH,EI,EII,EJ,EK,EL,EM,EMM,EN,END,EO,EP,EPA,EPB,EPC,EQ,ER,ES,ESN,E" +
        "T,EU,EV,EVI,EW,EX,EXP,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FAN,FB,FC,FCN,FD,FE,FE" +
        "N,FF,FG,FH,FHC,FHO,FI,FJ,FK,FL,FLZ,FM,FMG,FMP,FN,FND,FO,FP,FQ,FR,FRN,FS,FSC,FSN," +
        "FT,FTN,FTP,FTZ,FU,FV,FW,FWC,FX,FY,FZ,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,G" +
        "F,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GWS,GX,GY,GZ,H1,H2,H3,H5,H6" +
        ",H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HHT,HI,HJ,HK,HL,HM,HMB,HN,HO,HP,HPI,HQ,HR,HS,H" +
        "T,HU,HUD,HV,HW,HX,HY,HZ,I1,I2,I3,I4,I5,I7,I9,IA,IB,IC,ICD,ID,IE,IF,IFC,IFT,IG,IH" +
        ",II,IID,IJ,IK,IL,IM,IMP,IMS,IN,IND,IO,IP,IQ,IR,IRN,IRP,IS,ISC,ISN,ISS,IT,ITI,IU," +
        "IV,IW,IX,IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCS,JD,JE,JF,JH,JI,JK,JL,JM,J" +
        "N,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KAS,KB,KC" +
        ",KCS,KD,KE,KG,KH,KI,KII,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KRL,KRP,KS,KSR,KT,KU,KV,KW,KX" +
        ",KY,KZ,L0,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LAA,LAN,LB,LC,LD,LE,LEN,LF,LG,LH,LI,LIC," +
        "LJ,LK,LL,LM,LMI,LN,LO,LOI,LOS,LP,LPK,LQ,LR,LS,LSD,LT,LU,LV,LVO,LW,LX,LY,LZ,M0,M1" +
        ",M2,M3,M5,M6,M7,M8,M9,MA,MB,MBS,MBX,MC,MCC,MCI,MCN,MD,MDN,ME,MF,MG,MH,MI,MII,MIN" +
        ",MJ,MK,ML,MM,MN,MO,MP,MPN,MQ,MR,MRC,MRN,MS,MSL,MT,MU,MUI,MV,MW,MX,MY,MZ,MZO,N0,N" +
        "1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NAS,NB,NC,ND,NDA,NDB,NE,NF,NFC,NFD,NFM,NFN,NFS,NG,N" +
        "H,NI,NJ,NK,NL,NM,NMT,NN,NO,NP,NQ,NR,NS,NT,NTP,NU,NW,NX,NY,NZ,O1,O2,O5,O7,O8,O9,O" +
        "A,OB,OC,OD,OE,OF,OFF,OG,OH,OI,OIC,OJ,OK,OL,OM,ON,OOS,OP,OPE,OPF,OQ,OR,OS,OT,OU,O" +
        "V,OW,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PAC,PAN,PAP,PB,PC,PCC,PCN,PD,PDI,PDL,PD" +
        "R,PE,PF,PG,PGC,PGD,PGN,PGS,PH,PHC,PHY,PI,PID,PIN,PJ,PJC,PK,PKG,PKU,PL,PLA,PLN,PM" +
        ",PMN,PN,PNN,PO,POL,POS,PP,PPJ,PPK,PPL,PPM,PPN,PQ,PR,PRS,PRT,PS,PSI,PSL,PSM,PSN,P" +
        "T,PTC,PU,PUA,PV,PVC,PW,PWC,PWS,PX,PXC,PY,PYA,PYR,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q" +
        "A,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R0," +
        "R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RAA,RAN,RB,RC,RD,RE,REC,RF,RG,RGI,RH,RI,RIG,RJ,RK," +
        "RL,RLI,RM,RN,RO,RP,RPP,RPS,RPT,RQ,RR,RRC,RRS,RS,RSN,RSS,RT,RU,RV,RW,RWK,RX,RY,RZ" +
        ",S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SAL,SB,SBN,SC,SCA,SCN,SD,SDT,SE,SEK,SES,SF,SG," +
        "SH,SHL,SI,SII,SJ,SK,SL,SM,SMC,SMT,SN,SNH,SNP,SNV,SO,SP,SPL,SPN,SQ,SR,SS,SST,ST,S" +
        "TB,STR,STS,SU,SUB,SUC,SUO,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC," +
        "TD,TDT,TE,TF,TFC,TG,TH,TI,TIP,TJ,TK,TL,TM,TN,TO,TOC,TP,TPN,TQ,TR,TS,TSN,TT,TU,TV" +
        ",TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U8,U9,UA,UB,UC,UCB,UCM,UD,UE,UF,UG,UH,UI,UIC,U" +
        "J,UK,UL,UM,UN,UO,UP,UQ,UR,URL,URP,URQ,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4,V5," +
        "V6,V7,V8,V9,VA,VAO,VB,VC,VD,VE,VF,VG,VGS,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT," +
        "VU,VV,VW,VX,VY,VZ,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WCS,WD,WDR,WE,WF,WG,WH,WI," +
        "WJ,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9" +
        ",XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XX1,XX2" +
        ",XX3,XX4,XX5,XX6,XX7,XX8,XY,XZ,Y0,Y1,Y2,Y3,Y4,Y5,Y6,Y8,Y9,YA,YB,YC,YD,YE,YF,YH,Y" +
        "I,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA," +
        "ZB,ZC,ZD,ZE,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZTS,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_128_20
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EI,SY,")]
    public class X12_ID_128_21
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EI,")]
    public class X12_ID_128_22
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0B,1G,G2,LU,")]
    public class X12_ID_128_23
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0B,G2,LU,")]
    public class X12_ID_128_25
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T4,")]
    public class X12_ID_128_26
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2U,")]
    public class X12_ID_128_27
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6R,")]
    public class X12_ID_128_28
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1J,")]
    public class X12_ID_128_29
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9F,")]
    public class X12_ID_128_3
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1W,SY,")]
    public class X12_ID_128_31
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9B,")]
    public class X12_ID_128_32
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9D,")]
    public class X12_ID_128_33
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",VY,XZ,")]
    public class X12_ID_128_34
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128_35
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F4,")]
    public class X12_ID_128_41
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BT,")]
    public class X12_ID_128_42
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0B,1G,")]
    public class X12_ID_128_50
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2U,FY,NF,")]
    public class X12_ID_128_51
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G1,")]
    public class X12_ID_128_6
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",SY,")]
    public class X12_ID_128_60
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_69
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4N,")]
    public class X12_ID_128_7
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2U,EI,FY,NF,")]
    public class X12_ID_128_75
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F8,")]
    public class X12_ID_128_8
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F5,")]
    public class X12_ID_128_9
    {
    }
    
    /// <summary>
    /// Ambulance Transport Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316
    {
    }
    
    /// <summary>
    /// Ambulance Transport Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317_2
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,000,01,02,03,04,05,06,07,08,09,0A,0B,0C,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0O,0" +
        "P,0Q,0R,0S,0T,0U,0V,0W,0X,0Y,0Z,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F," +
        "1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26" +
        ",27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2" +
        "X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N," +
        "3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E" +
        ",4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,5" +
        "5,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V," +
        "5W,5X,5Y,5Z,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M" +
        ",6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7" +
        "D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83," +
        "84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U" +
        ",8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9" +
        "L,9M,9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB," +
        "AC,AD,AE,AF,AFM,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B" +
        "1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BPD,BQ" +
        ",BR,BS,BT,BTD,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF," +
        "CFD,CG,CH,CI,CJ,CK,CL,CM,CN,CNJ,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D0,D1,D2,D3," +
        "D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DFR,DG,DH,DI,DJ,DK,DL,DM,DN,DNR,DO,DP,DQ,DR," +
        "DS,DT,DU,DV,DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI" +
        ",EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,F0,F1,F2,F3,F4,F5,F6,F7,F8,F" +
        "9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ," +
        "G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ" +
        ",GR,GS,GT,GU,GV,GW,GX,GY,GZ,H0,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,H" +
        "H,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I0,I1,I2,I3,I4,I5,I6,I7," +
        "I8,I9,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,IX,IY" +
        ",IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCA,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM,JN," +
        "JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE" +
        ",KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L0,L1,L2,L3,L4,L" +
        "5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LSD,LT,LU" +
        ",LV,LW,LX,LY,LZ,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,M" +
        "L,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NB," +
        "NC,ND,NDP,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,NX,NY,NZ,O0,O" +
        "1,O2,O3,O4,O5,O6,O7,O8,O9,OA,OB,OC,OD,ODZ,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO,OP,OQ" +
        ",OR,OS,OT,OU,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PFB," +
        "PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PRD,PS,PT,PU,PV,PW,PX,PY,PZ,Q0,Q1,Q2,Q3,Q4,Q" +
        "5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV," +
        "QW,QX,QY,QZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RCA,RD,RE,RF,RG,RH,RI,RJ,RK,R" +
        "L,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB," +
        "SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SPP,SPS,SQ,SR,SS,ST,SU,SUB,SV,SW,SX,SY" +
        ",SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TNJ," +
        "TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD,UE" +
        ",UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4,V" +
        "5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VTL,VU" +
        ",VV,VW,VX,VY,VZ,W0,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WK,W" +
        "L,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB," +
        "XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y0,Y1,Y2" +
        ",Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,Y" +
        "T,YU,YV,YW,YX,YY,YZ,Z0,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ," +
        "ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_1321
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L1,L2,L3,L4,L5,")]
    public class X12_ID_1321_2
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IH,")]
    public class X12_ID_1321_3
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AV,NU,S2,ST,")]
    public class X12_ID_1321_4
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",65,")]
    public class X12_ID_1321_5
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",38,ZV,")]
    public class X12_ID_1321_6
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,04,05,06,07,08,09,12,")]
    public class X12_ID_1321_7
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322_4
    {
    }
    
    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,")]
    public class X12_ID_1327_2
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,")]
    public class X12_ID_1332_2
    {
    }
    
    /// <summary>
    /// Record Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,P,S,")]
    public class X12_ID_1333
    {
    }
    
    /// <summary>
    /// Insulin Dependent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,N,")]
    public class X12_ID_1335
    {
    }
    
    /// <summary>
    /// Insurance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,")]
    public class X12_ID_1336_3
    {
    }
    
    /// <summary>
    /// Level of Care Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1337
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,E,F1,F2,I,L,NBC,R,U,")]
    public class X12_ID_1338
    {
    }
    
    /// <summary>
    /// Multiple Procedure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1340
    {
    }
    
    /// <summary>
    /// Nature of Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342
    {
    }
    
    /// <summary>
    /// Non-Institutional Claim Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AM,AN,CF,CH,CS,DA,DD,DM,DN,ER,HH,HS,IF,IL,L,LT,MD,MF,MH,MI,MO,MS,NM,NP,NS,O" +
        ",OC,OP,OT,OX,P,PA,PD,PE,PF,PS,PT,RX,S,SC,SN,ST,T,TX,V,")]
    public class X12_ID_1343
    {
    }
    
    /// <summary>
    /// Patient Signature Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,")]
    public class X12_ID_1351
    {
    }
    
    /// <summary>
    /// Provider Accept Assignment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,")]
    public class X12_ID_1359_2
    {
    }
    
    /// <summary>
    /// Provider Agreement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,E,H,I,N,P,Y,")]
    public class X12_ID_1360
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AP,EM,OA,ZZ,")]
    public class X12_ID_1362
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,EM,OA,")]
    public class X12_ID_1362_2
    {
    }
    
    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,Y,")]
    public class X12_ID_1363_2
    {
    }
    
    /// <summary>
    /// Review Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,L,N,")]
    public class X12_ID_1364
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365_2
    {
    }
    
    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",02,03,05,09,")]
    public class X12_ID_1366_3
    {
    }
    
    /// <summary>
    /// Subluxation Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7" +
        ",T8,T9,")]
    public class X12_ID_1367
    {
    }
    
    /// <summary>
    /// Measurement Method or Device
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BM,BO,DM,FT,HN,MA,MM,OM,OU,PT,TM,VA,VB,VC,")]
    public class X12_ID_1373
    {
    }
    
    /// <summary>
    /// Claim Submission Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
    {
    }
    
    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }
    
    /// <summary>
    /// Pricing Methodology
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473
    {
    }
    
    /// <summary>
    /// Pricing Methodology
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_2
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,15,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514_2
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525
    {
    }
    
    /// <summary>
    /// Policy Compliance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526
    {
    }
    
    /// <summary>
    /// Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,A1,A2,A3,A4,A5,A6,A7,A8,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS" +
        ",AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,B" +
        "K,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB," +
        "CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3" +
        ",D4,D5,D6,D7,D8,DA,DD,DE,DF,DG,DH,DI,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,D" +
        "Z,E1,E2,E3,E4,E5,E6,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,EU," +
        "EX,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FP,FQ" +
        ",FR,FS,FT,FU,FV,FW,FX,GA,GC,GD,GE,GI,GK,GM,GN,GQ,GR,GS,GU,HC,HD,HI,HN,HP,IA,IB,I" +
        "C,ID,IE,IF,IG,II,IM,IN,IQ,IR,IS,IT,IV,IW,IZ,JA,JB,JC,JD,JN,JP,JS,KA,KB,KD,KE,KF," +
        "KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,L4,L5,L6,LA,LB,LC,LD,LG,LM,LN,LP,LR,LS,LT,LU,MA" +
        ",MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,N1,N2,N3,N4,N" +
        "5,N6,ND,NE,NG,NH,NM,NR,NU,NW,NZ,O0,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO," +
        "OP,OR,OT,OU,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN" +
        ",PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,R" +
        "E,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RY,RZ,S1,S2,S3,S4,S5,S6," +
        "S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY" +
        ",SZ,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TM,TN,TP,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U" +
        "2,U3,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,UX,VA," +
        "VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,W6,W7,WA,WB,WC,WD,WE,WF,WG,WJ,WK" +
        ",WL,WR,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",HC,")]
    public class X12_ID_235_10
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EN,EO,HI,N4,ON,UK,UP,")]
    public class X12_ID_235_11
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ER,HC,IV,WK,")]
    public class X12_ID_235_6
    {
    }
    
    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BBP,BCH,BID,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FOR,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LCP,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,SSP,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309_2
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,18,")]
    public class X12_ID_353_7
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1T,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2" +
        "F,2G,2H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38," +
        "39,3B,3C,3E,3F,3G,3H,3I,40,41,43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4I,4J,4K,4L" +
        ",4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,50,51,52,53,54,56,57,58,59,5A,5B,5C,5D,5E,5" +
        "F,5G,5H,5I,5J,5K,5P,5Q,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79," +
        "80,81,82,83,84,85,86,87,89,8C,8D,8P,8R,8S,8U,90,91,92,93,94,95,96,97,98,99,A8,AA" +
        ",AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B" +
        "1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR," +
        "BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI" +
        ",CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D5,D8,D9,DA,DB,DC,D" +
        "D,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E1,E3,E4,E5,E7," +
        "E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EJ,EM,EP,EQ,EV,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F9,FA,FB" +
        ",FD,FE,FF,FG,FH,FJ,FK,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,G" +
        "D,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H4," +
        "H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV" +
        ",HW,HY,HZ,IA,IB,IC,IE,IF,IG,IH,II,IK,IL,IM,IN,IP,IS,IT,IU,IV,IW,J1,J2,J3,J4,J5,J" +
        "6,J7,J8,J9,JA,JB,JC,JE,JG,JK,JL,JM,JN,JO,JP,JR,JS,JT,JU,JV,JX,K1,K2,K3,K4,K5,K6," +
        "K7,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KR,KT,KU,KV,KW,KX,L1,L2,LA" +
        ",LB,LC,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M" +
        "6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW," +
        "MX,MY,MZ,N1,N2,N3,N4,N6,N7,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NQ,NR,NS" +
        ",NT,NU,NV,NW,NX,NY,OA,OC,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,P" +
        "E,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5," +
        "Q6,Q7,QA,QB,QC,QD,QE,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE" +
        ",RG,RH,RK,RL,RM,RN,RO,RP,RS,RT,RU,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,S" +
        "G,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7," +
        "T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY" +
        ",TZ,U1,U2,U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V" +
        "1,V2,VA,VC,VI,VP,VR,VS,W2,WA,WB,WD,WE,WG,WH,WI,WK,WM,WP,WR,WW,X1,X2,X3,X4,X5,X6," +
        "X7,X8,X9,XP,Y1,Y2,Y3,Y4,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF" +
        ",ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_355
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",MJ,UN,")]
    public class X12_ID_355_11
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DA,")]
    public class X12_ID_355_12
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",MO,")]
    public class X12_ID_355_13
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,")]
    public class X12_ID_355_16
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F2,GR,ME,ML,UN,")]
    public class X12_ID_355_6
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LB,")]
    public class X12_ID_355_7
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DH,")]
    public class X12_ID_355_9
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADD,DCP,")]
    public class X12_ID_363_2
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",TPO,")]
    public class X12_ID_363_3
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADD,CER,DCP,DGN,TPO,")]
    public class X12_ID_363_5
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AP,AS,AU,BN,BT,CA,CP,DN,EA,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT" +
        ",PA,PC,PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365_12
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EM,FX,TE,")]
    public class X12_ID_365_18
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EM,EX,FX,TE,")]
    public class X12_ID_365_4
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EX,")]
    public class X12_ID_365_7
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",TE,")]
    public class X12_ID_365_8
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_4
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",444,")]
    public class X12_ID_374_10
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",050,")]
    public class X12_ID_374_11
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",573,")]
    public class X12_ID_374_12
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",484,")]
    public class X12_ID_374_16
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",439,")]
    public class X12_ID_374_19
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",431,")]
    public class X12_ID_374_20
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",607,")]
    public class X12_ID_374_21
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",463,")]
    public class X12_ID_374_22
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",461,")]
    public class X12_ID_374_23
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",738,739,")]
    public class X12_ID_374_24
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",011,")]
    public class X12_ID_374_25
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",314,360,361,")]
    public class X12_ID_374_3
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",454,")]
    public class X12_ID_374_32
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",304,")]
    public class X12_ID_374_36
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",472,")]
    public class X12_ID_374_4
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",453,")]
    public class X12_ID_374_40
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",455,")]
    public class X12_ID_374_46
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",471,")]
    public class X12_ID_374_48
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",297,")]
    public class X12_ID_374_5
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
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
    public class X12_ID_374_51
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",296,")]
    public class X12_ID_374_6
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",435,")]
    public class X12_ID_374_7
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",096,")]
    public class X12_ID_374_8
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",090,091,")]
    public class X12_ID_374_9
    {
    }
    
    /// <summary>
    /// Credit/Debit Flag Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,")]
    public class X12_ID_478
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F4,")]
    public class X12_ID_522_10
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F5,")]
    public class X12_ID_522_16
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,")]
    public class X12_ID_522_4
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EAF,")]
    public class X12_ID_522_5
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A8,")]
    public class X12_ID_522_6
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T,")]
    public class X12_ID_522_7
    {
    }
    
    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,64,65,66,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AL,AM,AP,AQ,AR,AS,AT,AW,AX,AY,BA,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CP,CR,CS,CU,CX,DA,DD,DE,DF,DH,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GI,GS,GU,HC,HF,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NP,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,PI,RN,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UA,UC,UI,UL,UN,UT,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",00,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AS,AT,AU,CA,CC,CO,CT,DC,DD,DI,DQ,DR,DS,EO,FA,FB,FC,FO,FT,HD,IA,IR,L1,L2,L3,L4,L5,L6,L7,LA,LE,LF,LM,LO,LS,LU,LW,LX,NE,OS,OT,PA,PC,PE,PM,PN,PR,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,RR,RT,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TN,TP,TR,UK,VO,XD,ZZ,")]
    public class X12_ID_584_2
    {
    }
    
    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,4,6,")]
    public class X12_ID_594_2
    {
    }
    
    /// <summary>
    /// Basis of Unit Price Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,EH,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",31,CH,RP,")]
    public class X12_ID_640_6
    {
    }
    
    /// <summary>
    /// Price Multiplier Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CSD,CSR,DIS,ILP,PSP,SEL,")]
    public class X12_ID_648
    {
    }
    
    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,81,82,83,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AI,AL,AP,BC,BD,BE,BG,BN,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CP,CR,CS,CT,D,DG,DL,DN,DO,DP,DR,DS,E,EC,EH,EI,EL,EP,EQ,ER,ES,ET,F,FA,FB,FC,FD,FE,FI,FJ,FL,FN,G,GA,GC,HC,HN,HS,I,ID,II,IP,J,K,L,LC,LD,LE,LI,LN,M,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MO,MP,MR,N,NA,ND,NI,NO,NR,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RI,RP,RT,S,SA,SB,SD,SF,SI,SJ,SK,SL,SP,ST,SV,SW,TA,TC,TL,TS,TZ,UC,UI,UL,UP,UR,US,UT,WR,WS,X1,XV,XX,XY,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66_12
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,")]
    public class X12_ID_66_16
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",46,")]
    public class X12_ID_66_2
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_20
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",XX,")]
    public class X12_ID_66_7
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",II,MI,")]
    public class X12_ID_66_8
    {
    }
    
    /// <summary>
    /// Currency Market/Exchange Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class X12_ID_669
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PT,")]
    public class X12_ID_673_11
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FL,")]
    public class X12_ID_673_4
    {
    }
    
    /// <summary>
    /// Class of Trade Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AQ,AR,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE" +
        ",DF,DI,DR,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,S" +
        "A,SB,SE,ST,TR,WA,WC,WH,WS,")]
    public class X12_ID_687
    {
    }
    
    /// <summary>
    /// Paperwork/Report Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,CP,OP,PI,")]
    public class X12_ID_706_3
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",22,")]
    public class X12_ID_735_2
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",23,")]
    public class X12_ID_735_4
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",20,")]
    public class X12_ID_735_8
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,")]
    public class X12_ID_736_2
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class X12_ID_736_3
    {
    }
    
    /// <summary>
    /// Measurement Reference ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",OG,TR,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",HT,R1,R2,R3,R4,")]
    public class X12_ID_738
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1S,2S,A1,A2,A3,A4,A5,A6,A7,A8,A9,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF,")]
    public class X12_ID_752
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2,DA" +
        ",DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,PY,P" +
        "Z,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CT,")]
    public class X12_ID_755_2
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,77,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2" +
        ",DA,DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,P" +
        "Y,PZ,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_5
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,BM,EL,EM,FT,FX,")]
    public class X12_ID_756_5
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T1,T2,T3,T4,T5,T6,")]
    public class X12_ID_901_15
    {
    }
    
    /// <summary>
    /// Prognosis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_923
    {
    }
    
    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,ZZ,")]
    public class X12_ID_935
    {
    }
    
    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,40,41,42,44,45,46,48,49,50,51,52,53,54,56,BA,FL,NA,ND,NS,PR,Q" +
        "1,Q2,TA,TB,WS,ZZ,")]
    public class X12_ID_936
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PW,")]
    public class X12_ID_98_11
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_13
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_16
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DK,")]
    public class X12_ID_98_18
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
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
    public class X12_ID_98_19
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",82,")]
    public class X12_ID_98_2
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",41,")]
    public class X12_ID_98_21
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PE,")]
    public class X12_ID_98_23
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",40,")]
    public class X12_ID_98_25
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_26
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_29
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",85,")]
    public class X12_ID_98_31
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",87,")]
    public class X12_ID_98_36
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",77,")]
    public class X12_ID_98_5
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_54
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",45,")]
    public class X12_ID_98_7
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_9
    {
    }
}
