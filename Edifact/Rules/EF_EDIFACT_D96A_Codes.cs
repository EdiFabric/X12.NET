namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ALC,ALL,ARR,AUT,BLC,BLR,CCI,CEX,CHG,CIP,CLP,CLR,COI,CUR,CUS,DAR,DCL,DEL,DIN,DOC,DUT,EUR,FBC,GBL,GEN,GS7,HAN,HAZ,ICN,IIN,IMI,IND,INS,INV,IRP,ITR,ITS,LIN,LOI,MCO,MKS,ORI,OSI,PAC,PAI,PAY,PKG,PKT,PMD,PMT,PRD,PRF,PRI,PUR,QIN,QQD,QUT,RAH,REG,RET,REV,RQR,RQT,SAF,SIC,SIN,SLR,SPA,SPG,SPH,SPP,SPT,SRN,SSR,SUR,TCA,TDT,TRA,TRR,TXD,WHI,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_4453
    {
    }
    
    [Serializable()]
    public class EDIFACT_AN
    {
    }
    
    [Serializable()]
    [EdiCodes(@",100,101,102,103,104,105,106,107,108,109,110,112,113,114,115,116,117,118,119,12,120,121,122,123,125,126,127,128,129,130,131,132,133,134,135,136,137,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,16,160,161,162,163,164,165,166,167,168,169,170,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,23,25,35,36,37,38,39,42,43,44,52,53,54,55,56,57,58,59,60,61,62,63,64,65,67,68,69,70,71,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,181,182,183,184,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,8,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAG,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAS,AAT,AAU,AAV,AAY,AAZ," +
        "ABA,ABB,ABC,ABD,ABE,ABG,ABH,ABI,ABJ,ABK,ABL,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABW,ABX," +
        "ABY,ABZ,AC,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,A" +
        "CS,ACT,ACU,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADP,ADQ,A" +
        "DR,ADS,ADT,ADU,ADV,ADW,ADY,ADZ,AE,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AE" +
        "L,AEM,AEN,AEO,AEP,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,AEZ,AF,AFA,AFB,AFC,AFD,AFE" +
        ",AFF,AFG,AFI,AFJ,AFK,AFL,AFM,AFN,AFO,AFP,AFQ,AFR,AFS,AFT,AFU,AFV,AFW,AFX,AFY,AFZ" +
        ",AGA,AGB,AGC,AGD,AGE,AGF,AGG,AGH,AGI,AGJ,AGK,AGL,AGM,AGN,AGO,AGP,AGQ,AGR,AGS,AGT" +
        ",AGU,AGV,AGW,AGX,AGY,AGZ,AHA,AHB,AHC,AHD,AHE,AHF,AHG,AHH,AHI,AHJ,AHK,AHL,AHM,AHN" +
        ",AHO,AHP,AHQ,AHR,AHS,AHT,AHU,AHV,AHW,AHX,AHY,AHZ,AIA,AIB,AIC,AID,AIE,AIF,AIG,AIH" +
        ",AII,AIJ,AIK,AIL,AIM,AIN,AIO,AIP,AIQ,AIR,AIS,AIT,AIU,AIV,AIW,AIX,AIY,ALA,ALB,ALC" +
        ",ALD,ALE,ALF,ALG,ALH,ALI,ALJ,ALK,ALL,ALM,ALN,ALO,ALP,ALQ,ALR,ALS,ALT,ALU,ALV,ALW" +
        ",ALX,ALY,ALZ,AMA,AMB,AMC,AP,ASC,AU,AV,AWB,BA,BC,BD,BE,BH,BM,BN,BO,BR,BT,BW,CAS,C" +
        "D,CEC,CFE,CFO,CG,CH,CK,CKN,CM,CMR,CN,CNO,CO,COF,CP,CR,CRN,CS,CST,CT,CU,CV,CW,CZ," +
        "DA,DAN,DB,DI,DL,DM,DQ,DR,EA,EB,ED,EE,EI,EN,EP,EQ,ER,ERN,ET,EX,FC,FF,FI,FLW,FN,FO" +
        ",FS,FT,FV,FX,GA,GC,GD,GDN,GN,HS,HWB,IA,IB,ICA,ICE,ICO,II,IL,INB,INN,INO,IP,IS,IT" +
        ",IV,JB,JE,LA,LAN,LAR,LB,LC,LI,LO,LS,MA,MB,MF,MG,MH,MR,MRN,MS,MSS,MWB,NA,OH,OI,ON" +
        ",OP,OR,PB,PC,PD,PE,PF,PI,PK,PL,POR,PP,PQ,PR,PS,PW,PY,RA,RC,RCN,RE,REN,RF,RR,RT,S" +
        "A,SB,SD,SE,SF,SH,SI,SM,SN,SP,SQ,SRN,SS,STA,SW,SZ,TB,TE,TF,TI,TL,TN,TP,UAR,UC,UCN" +
        ",UN,UO,VA,VC,VM,VN,VON,VP,VR,VS,VT,VV,WE,WM,WN,WR,WS,WY,XA,XC,XP,ZZZ,")]
    public class EDIFACT_ID_1153
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,CA,EI,EM,EX,FT,FX,GM,IE,IM,MA,PB,PS,SW,TE,TG,TL,TM,TT,TX,XF,")]
    public class EDIFACT_ID_3155
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,BU,CA,CB,CC,CD,CE,CF,CG,CN,CO,CP,CR,CW,DE,DI,DL,EB,EC,ED,EX,GR,HE,HG,HM,IC,IN,LB,LO,MC,MD,MH,MR,MS,NT,OC,PA,PD,PE,PM,QA,QC,RD,SA,SC,SD,SR,SU,TA,TD,TI,TR,WH,ZZZ,")]
    public class EDIFACT_ID_3139
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AA,AB,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AT,AU,AV,AW,AX,AZ,B1,B2,BA,BB,BC,BD,BE,BF,BG,BH,BI,BK,BL,BM,BN,BO,BP,BQ,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,COP,CP,CPD,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DCP,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,FH,FJ,FK,FL,FM,FN,FO,FP,FR,FT,FW,FX,FY,FZ,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,I1,I2,IB,IC,ID,IE,IF,IG,IH,II,IJ,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,LA,LB,LN,LP,MA,MF,MG,MI,MP,MR,MS,MT,N1,N2,NI,OA,OB,OF,OI,OO,OP,OR,OS,OT,OV,OY,P1,P2,P3,P4,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PQ,PR,PS,PT,PW,PX,PY,PZ,RA,RB,RE,RF,RH,RI,RL,RM,RP,RS,RV,RW,SB,SE,SF,SG,SI,SK,SN,SO,SR,SS,ST,SU,SX,SY,SZ,TC,TCP,TD,TR,TS,TT,UC,UD,UHP,UP,VN,WD,WH,WM,WPA,WS,XX,ZZZ,")]
    public class EDIFACT_ID_3035
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3045
    {
    }
    
    [Serializable()]
    [EdiCodes(@",10,101,107,108,109,11,110,111,113,114,115,117,119,12,123,124,125,126,128,129,13,131,132,133,134,135,136,137,138,14,140,141,143,144,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,218,219,22,221,222,223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,242,243,244,245,246,247,248,249,250,251,252,253,254,255,257,258,259,260,261,262,263,264,265,266,267,268,270,271,272,273,274,275,276,277,278,279,280,281,282,283,284,285,286,287,288,290,291,292,293,294,295,296,297,298,299,3,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,346,347,348,349,35,350,351,352,353,354,355,356,357,358,359,36,360,361,362,363,364,365,366,367,368,369,37,370,371,372,373,374,375,376,377,378,379,38,39,4,42,44,45,46,47,48,49,50,51,52,53,54,55,58,59,60,61,63,64,65,67,69,7,71,72,74,75,76,79,8,81,84,85,89,9,90,91,92,93,94,95,96,97,ZZZ,")]
    public class EDIFACT_ID_2005
    {
    }
    
    [Serializable()]
    [EdiCodes(@",101,102,103,105,106,107,108,109,110,2,201,202,203,204,3,301,302,303,304,305,306,401,402,404,405,501,502,503,600,601,602,603,604,608,609,610,613,614,615,616,701,702,703,704,705,706,707,708,709,710,711,713,715,716,717,718,801,802,803,804,805,806,807,808,809,810,811,812,813,814,")]
    public class EDIFACT_ID_2379
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,4,5,6,7," +
        "8,9,")]
    public class EDIFACT_ID_6069
    {
    }
    
    [Serializable()]
    public class EDIFACT_N
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,6,7,8,9,")]
    public class EDIFACT_ID_1225
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AF,AG,AI,AP,CA,CO,NA,RE,")]
    public class EDIFACT_ID_4343
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,105,11,110,12,120,13,130,14,140,15,150,16,17,18,19,190,2,20,201,202,203,204,205,206,207,208,209,21,210,211,212,215,22,220,221,222,223,224,225,226,227,228,229,23,230,231,232,233,24,240,241,242,245,25,26,27,270,271,28,29,3,30,31,310,311,315,32,320,325,326,327,328,33,330,335,34,340,341,343,345,35,350,351,36,37,370,38,380,381,382,383,384,385,386,387,388,389,39,390,393,394,395,396,4,40,409,41,412,42,425,426,427,428,429,43,430,431,435,447,448,450,451,452,454,455,456,457,458,460,465,466,467,468,469,481,485,490,491,492,493,5,520,530,550,575,580,59,6,60,61,610,62,621,622,623,624,63,630,631,632,633,635,64,640,65,650,655,66,67,68,69,7,70,700,701,702,703,704,705,706,707,708,709,71,710,711,712,713,714,715,716,72,720,722,723,724,73,730,74,740,741,743,744,745,746,75,750,76,760,761,763,764,765,766,77,770,775,78,780,781,782,783,784,785,786,787,788,789,79,790,791,792,793,794,795,796,797,798,799,8,80,81,810,811,812,82,820,821,822,823,824,825,83,830,833,84,840,841,85,850,851,852,853,855,856,86,860,861,862,863,864,865,87,870,88,89,890,895,896,9,90,901,91,910,911,913,914,915,916,917,92,925,926,927,929,93,930,931,932,933,934,935,936,937,938,94,940,941,95,950,951,952,953,954,955,96,960,961,962,963,964,965,966,97,98,99,990,991,995,996,998,")]
    public class EDIFACT_ID_1001
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,CA,EI,EM,EX,FT,FX,GM,IE,IM,MA,PB,PS,SW,TE,TG,TL,TM,TT,TX,XF,")]
    public class EDIFACT_ID_3153
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1373
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,229,23,230,231,232,233,234,235,236,237,238,239,24,240,241,242,243,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,266,267,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284,285,286,287,288,289,29,290,291,292,293,294,295,296,297,298,299,3,30,300,301,302,303,304,305,306,307,308,309,31,310,311,312,313,314,315,316,317,318,319,32,320,321,322,323,324,325,326,327,328,329,33,330,331,332,333,334,335,336,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_5025
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6343
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4405
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,7,8,9,ZZZ,")]
    public class EDIFACT_ID_7365
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7187
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1245
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_1159
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1229
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,D,I,")]
    public class EDIFACT_ID_7083
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5495
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AT,AU,BO,BP,CC,CG,CL,CR,CV,DR,DW" +
        ",EC,EF,EN,GB,GN,GS,HS,IB,IN,IS,IT,IZ,MA,MF,MN,MP,NB,ON,PD,PL,PO,PV,QS,RC,RN,RU,R" +
        "Y,SA,SG,SK,SN,SRS,SS,ST,TG,UA,UP,VN,VP,VS,VX,ZZZ,")]
    public class EDIFACT_ID_7143
    {
    }
    
    [Serializable()]
    [EdiCodes(",DO,DR,EA,IN,IR,")]
    public class EDIFACT_ID_3279
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,4,5,6,7,8,")]
    public class EDIFACT_ID_4487
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4463
    {
    }
    
    [Serializable()]
    [EdiCodes(",ABX,BEX,BGI,BKD,BKI,CAL,CHG,CHI,CHN,CLR,COL,COM,CON,CPP,CUX,DDT,DEP,FEX,FGI,INT," +
        "LOC,LOK,MSC,PAC,PGI,POS,REC,RET,RGI,RTR,SEC,STO,TCK,TRF,UGI,VDA,WDL,ZZZ,")]
    public class EDIFACT_ID_4383
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4027
    {
    }
    
    [Serializable()]
    [EdiCodes(",ADV,AGT,AMY,BEC,BEN,BON,CAS,CBF,CDT,COC,COM,COS,CPY,DIV,FEX,GDS,GVT,IHP,INS,INT," +
        "LIF,LOA,LOR,NET,PEN,REF,REN,ROY,SAL,SCV,SEC,SSB,SUB,TAX,VAT,ZZZ,")]
    public class EDIFACT_ID_4025
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,5,6,7,8,9,")]
    public class EDIFACT_ID_5245
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5249
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,AMS,ARG,AST,AUS,BEL,CAN,CAR,CIE,DEN,ECR,FIN,FRA,IMF,LNF,LNS,MIL,NOR,NYC,PHI," +
        "SRE,SWE,ZUR,")]
    public class EDIFACT_ID_6341
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_6347
    {
    }
    
    [Serializable()]
    [EdiCodes(",ADR,CFR,ICA,IMD,RID,TEC,UI,")]
    public class EDIFACT_ID_8273
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8339
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_8325
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AD,AE,BL,BPN,BPY,BR,BX,CH,CN,DPA,EFP,EYP,FPN,FPR,FSU,LAR,LU,MPA,PA,PBP,PFP" +
        ",PL,PPA,PST,RF,RG,RGF,RO,RR,SCA,SCB,SCC,SFA,SPP,STR,SW,TE,TP,TS,TSU,UL,")]
    public class EDIFACT_ID_8053
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8077
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_8249
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_8169
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,5,6,7,8,9,")]
    public class EDIFACT_ID_8155
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,113,114,115,116,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,17,18,19,2,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,60,61,62,64,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3227
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6167
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_6245
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6145
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ASW,CH,CHW,CN,CS,CT,DEN,DR,DT,DV,DX,EGW,EN,EVO,FO,IV,LAO,LC,LGL,LL,LMT,NAX,PAL,PC,PD,PL,PLL,RL,RN,SE,SH,SM,SO,SPG,SR,ST,SU,SV,TE,TL,TR,TX,VO,VOL,VT,WT,WX,")]
    public class EDIFACT_ID_6311
    {
    }
    
    [Serializable()]
    [EdiCodes(",1S,2S,AA,AB,AC,BC,BS,BT,DF,FR,IN,LE,OA,OS,OT,RI,RR,ST,TB,TP,TS,UC,")]
    public class EDIFACT_ID_7383
    {
    }
    
    [Serializable()]
    [EdiCodes(@",A,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABQ,ABR,ABS,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AF,B,BL,BND,BR,BRA,BRE,BS,BSW,BW,CHN,CM,CT,CV,CZ,D,DI,DL,DN,DP,DR,DS,DW,E,EA,F,FI,FL,FN,FV,G,GG,GW,HF,HM,HT,IB,ID,L,LM,LN,LND,M,MO,MW,N,OD,PRS,PTN,RA,RF,RJ,RMW,RP,RUN,RY,SQ,T,TC,TH,TN,TT,U,VH,VW,WA,WD,WM,WT,WU,XH,XQ,XZ,YS,ZAL,ZAS,ZB,ZBI,ZC,ZCA,ZCB,ZCE,ZCL,ZCO,ZCR,ZCU,ZFE,ZFS,ZGE,ZH,ZK,ZMG,ZMN,ZMO,ZN,ZNA,ZNB,ZNI,ZO,ZP,ZPB,ZS,ZSB,ZSE,ZSI,ZSL,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZWA,ZZN,ZZR,ZZZ,")]
    public class EDIFACT_ID_6313
    {
    }
    
    [Serializable()]
    [EdiCodes(",10,11,12,13,15,3,4,5,6,7,8,")]
    public class EDIFACT_ID_6321
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,29,3,32,33,34,35,36,37" +
        ",38,39,4,40,41,42,43,44,45,5,6,7,8,9,")]
    public class EDIFACT_ID_6155
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7085
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,2,20,21,22,23,24,25,30,")]
    public class EDIFACT_ID_8051
    {
    }
    
    [Serializable()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ZZZ,")]
    public class EDIFACT_ID_8101
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8281
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,R,T,U,V,W,X,Y,ZZZ,")]
    public class EDIFACT_ID_8457
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,S,X,ZZZ,")]
    public class EDIFACT_ID_8459
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,12,13,2,21,22,23,24,25,3,31,32,33,35,36,37,38,4,5,6,7,9,")]
    public class EDIFACT_ID_8179
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_6353
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,I,S,")]
    public class EDIFACT_ID_5213
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAF,CAL,INF,INV,")]
    public class EDIFACT_ID_5125
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AI,AQ,CA,CT,CU,DI,EC,NW,PC,PE,PK,PL,PT,PU,PV,PW,QT,SR,TB,TU,TW,WH" +
        ",")]
    public class EDIFACT_ID_5375
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,AI,ALT,AP,BR,CAT,CDV,CON,CP,CU,CUP,CUS,DAP,DIS,DPR,DR,DSC,EC,ES,EUP,FCR,GRP,INV,LBL,MAX,MIN,MNR,MSR,MXR,NE,NQT,NTP,NW,OCR,OFR,PAQ,PBQ,PPD,PPR,PRO,PRP,PW,QTE,RES,RTP,SHD,SRP,SW,TB,TRF,TU,TW,WH,")]
    public class EDIFACT_ID_5387
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,2,20,200,21,22,23,24,25,26,27,28,29,3,30,31,32,33,35,36,40,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_6063
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7297
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA" +
        ",BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BN,BX,CN,EE,EM,IL,ML,PN,SC,VV,")]
    public class EDIFACT_ID_7405
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7293
    {
    }
    
    [Serializable()]
    public class EDIFACT_A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_7493
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_4347
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4517
    {
    }
    
    [Serializable()]
    [EdiCodes(",CA,CU,SH,TO,")]
    public class EDIFACT_ID_9303
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8341
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,12,13,2,21,22,23,3,31,32,33,4,41,42,43,44,5,")]
    public class EDIFACT_ID_8335
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8323
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_9415
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9411
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_9417
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_9353
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4465
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_1073
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4403
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AP,AT,CO,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DN" +
        ",DO,DP,EI,EM,EX,QC,QE,RL,SW,")]
    public class EDIFACT_ID_4401
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_3301
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_3285
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,9,")]
    public class EDIFACT_ID_5283
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,E,G,H,O,S,Z,")]
    public class EDIFACT_ID_5305
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,AAB,AAC,ADD,BOL,CAP,CAR,COC,CST,CUD,CVD,ENV,EXC,EXP,FET,FRE,GCN,GST,ILL,IMP," +
        "IND,LAC,LCN,LDP,LOC,LST,MCA,MCD,OTH,PDB,PDC,PRF,SCN,SSS,STT,SUP,SUR,SWT,TAC,TOT," +
        "TOX,TTA,VAD,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,4,5,7,8,9,")]
    public class EDIFACT_ID_5007
    {
    }
    
    [Serializable()]
    [EdiCodes(",AG,BG,BR,CN,DE,DI,JB,MF,OE,RS,RT,ST,WH,WS,")]
    public class EDIFACT_ID_4043
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,BD,BQ,DC,EV,GU" +
        ",GW,LD,MC,PC,PD,PQ,PS,PW,PZ,QO,QP,QT,SC,UM,UP,WD,WO,ZZZ,")]
    public class EDIFACT_ID_4295
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,CSD,CSR,DIS,SEL,")]
    public class EDIFACT_ID_5393
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35" +
        ",4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4279
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,12,13,14,2,21,22,23,24,25,26,27,28,29,3,31,32,33,4,41,42,43,44,45,46,47,48," +
        "5,52,53,54,55,56,57,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78" +
        ",79,8,80,81,9,ZZZ,")]
    public class EDIFACT_ID_2475
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_2009
    {
    }
    
    [Serializable()]
    [EdiCodes(",3M,6M,AA,AD,CD,CW,D,DC,DW,F,H,HM,M,MN,P,S,SD,SI,W,WD,WW,Y,ZZZ,")]
    public class EDIFACT_ID_2151
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_4277
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,5,6,61,62,63,64,69,7,70,71,8,9,ZZZ,")]
    public class EDIFACT_ID_4439
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,20,21,23,24,41,44,45,ZZZ,")]
    public class EDIFACT_ID_4431
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,25,26,27,28,29,3,30,31,32,33,34,35" +
        ",36,37,38,39,4,40,41,42,43,5,50,6,60,61,62,63,64,65,66,67,7,70,74,75,76,77,78,8," +
        "9,91,92,93,94,95,96,97,ZZZ,")]
    public class EDIFACT_ID_4461
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4435
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7429
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5039
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5013
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_5027
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,S,X,")]
    public class EDIFACT_ID_7077
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,12,13,14,15,17,18,19,2,21,22,23,24,25,26,28,3,30,32,35,38,4,43,5,54,56,58,5" +
        "9,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,8" +
        "6,87,88,89,9,90,91,92,93,94,95,96,97,98,")]
    public class EDIFACT_ID_7081
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7431
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_7433
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_1501
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_1503
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class EDIFACT_ID_5463
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4471
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,AG,AJ,AL,AM,AU,CA,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ,CAK,CB,CD,CG,CK,CL,CO,CP,CS,CT,CW,DA,DAA,DAB,DAD,DAE,DI,DL,DM,EAA,EAB,EG,EP,ER,EX,FA,FAA,FAB,FAC,FC,FG,FH,FI,FN,FR,GAA,HAA,HD,HH,IA,IAA,IAB,ID,IF,IN,IR,IS,KO,L1,LA,LAA,LAB,LAC,LF,LS,MA,MAA,MAB,MAC,MAD,MAE,MC,MI,ML,NAA,OA,OAA,PA,PAA,PAB,PAC,PAD,PAE,PC,PD,PI,PL,PN,PO,QAA,QD,RAA,RAB,RAC,RAD,RAE,RAF,RAG,RAH,RE,RF,RH,RO,RP,RV,SA,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SC,SD,SF,SG,SH,SM,ST,SU,SZ,TAA,TAB,TAC,TAD,TAE,TD,TS,TT,TV,TX,TZ,UM,V1,V2,VAA,VAB,VL,WH,XAA,YY,ZZZ,")]
    public class EDIFACT_ID_7161
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,6,7,8,9,")]
    public class EDIFACT_ID_5189
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5419
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,8,9,")]
    public class EDIFACT_ID_9213
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_4183
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_4219
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7273
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4065
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",ZZZ,")]
    public class EDIFACT_ID_4233
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_8275
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,ZZZ,")]
    public class EDIFACT_ID_8395
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_8393
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7075
    {
    }
    
    [Serializable()]
    [EdiCodes(",34,35,36,37,38,39,40,41,42,43,44,45,50,51,52,53,54,60,61,62,63,66,67,68,69,")]
    public class EDIFACT_ID_7233
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7073
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,P,")]
    public class EDIFACT_ID_4237
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,CA,CC,CF,DF,FO,IC,MX,NC,NS,PA,PB,PC,PE,PO,PP,PU,RC,RF,RS,TP,WC,ZZZ,")]
    public class EDIFACT_ID_4215
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5237
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AN,AS,BK,BP,CA,CC,CE,CI,CK,CM,CN,CO,CP,CS,IC,IS,LS,NF,NN,NS" +
        ",OF,OM,OP,OS,OW,PA,PD,PI,PK,PN,PO,PP,PS,RA,SL,SP,SS,TW,UR,ZZZ,")]
    public class EDIFACT_ID_4221
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_4055
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,5,6,7,8,9,")]
    public class EDIFACT_ID_1049
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,3,4,5,9,")]
    public class EDIFACT_ID_4017
    {
    }
    
    [Serializable()]
    [EdiCodes(",BK,CD,DA,DB,DD,IS,P1,P2,SC,SF,SP,")]
    public class EDIFACT_ID_4493
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,J,M,Q,S,T,W,Y,ZZZ,")]
    public class EDIFACT_ID_2013
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,6,7,ZZZ,")]
    public class EDIFACT_ID_2015
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,Y,ZZZ,")]
    public class EDIFACT_ID_2017
    {
    }
    
    [Serializable()]
    [EdiCodes(",B,F,N,W,Y,ZZZ,")]
    public class EDIFACT_ID_4455
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,ZZZ,")]
    public class EDIFACT_ID_4457
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_4513
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_1507
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_9153
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9155
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9161
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7299
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7495
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9141
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_9017
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7497
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,7,8,9,")]
    public class EDIFACT_ID_9013
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,102,103,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_9011
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9015
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_1505
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,K,M,N,Q,R,S,")]
    public class EDIFACT_ID_5243
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4501
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7491
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4499
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_4503
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5315
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_3455
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_4035
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_9003
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9035
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_3479
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_3493
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_3477
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_3299
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_3131
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,4,5,")]
    public class EDIFACT_ID_3475
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,7,8,")]
    public class EDIFACT_ID_3403
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,5,6,")]
    public class EDIFACT_ID_3397
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,5,6,7,8,9,")]
    public class EDIFACT_ID_3405
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_3401
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3295
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3289
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7059
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5379
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,ZZZ,")]
    public class EDIFACT_ID_4419
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_3077
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6331
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_6173
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6071
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4407
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7039
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_7045
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_7047
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_3237
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4511
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7001
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7007
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_4505
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4507
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4509
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,ZZZ,")]
    public class EDIFACT_ID_7449
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7455
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7451
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_5047
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_5049
    {
    }
}
