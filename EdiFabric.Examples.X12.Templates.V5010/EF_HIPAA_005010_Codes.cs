namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    [Serializable()]
    public class X12_AN
    {
    }
    
    [Serializable()]
    public class X12_DT
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0022,")]
    public class X12_ID_1005
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0010,")]
    public class X12_ID_1005_2
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0085,")]
    public class X12_ID_1005_3
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0007,")]
    public class X12_ID_1005_4
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0019,")]
    public class X12_ID_1005_5
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0007,")]
    public class X12_ID_1005_6
    {
    }
    
    /// <summary>
    /// Claim Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,19,2,20,21,22,23,25,3,4,")]
    public class X12_ID_1029
    {
    }
    
    /// <summary>
    /// Claim Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",AD,AP,CC,CL,CP,I,RA,RB,RC,RD,RO,")]
    public class X12_ID_1029_2
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL" +
        ",CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,17,AM,CH,DS,HM,LM,MA,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032_2
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,12,13,14,15,16,17,AM,BL,CH,CI,DS,FI,HM,LM,MA,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032_3
    {
    }
    
    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CO,OA,PI,PR,")]
    public class X12_ID_1033
    {
    }
    
    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_2
    {
    }
    
    /// <summary>
    /// Business Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",COL,CON,DBT,PCS,PEN,PRL,RYL,TAX,VEN,")]
    public class X12_ID_1048
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_2
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_3
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_4
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_5
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_6
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,")]
    public class X12_ID_1066
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1066_2
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,")]
    public class X12_ID_1066_3
    {
    }
    
    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }
    
    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B,D,I,M,R,S,U,W,X,")]
    public class X12_ID_1067_2
    {
    }
    
    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067_3
    {
    }
    
    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F,M,")]
    public class X12_ID_1068
    {
    }
    
    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_2
    {
    }
    
    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_3
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,19,34,")]
    public class X12_ID_1069
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_2
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,19,G8,")]
    public class X12_ID_1069_3
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,18,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_4
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069_5
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,")]
    public class X12_ID_1069_6
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,23,24,25,26,31,38,53,60,D2" +
        ",G8,G9,")]
    public class X12_ID_1069_7
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,19,G8,")]
    public class X12_ID_1069_8
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,")]
    public class X12_ID_1069_9
    {
    }
    
    /// <summary>
    /// Payment Method Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,8,A,AA,AB,AC,AD,AE,AF,AG,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y" +
        ",")]
    public class X12_ID_107
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_10
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",W,")]
    public class X12_ID_1073_11
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073_12
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073_2
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,")]
    public class X12_ID_1073_3
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_4
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,W,Y,")]
    public class X12_ID_1073_5
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,U,Y,")]
    public class X12_ID_1073_6
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",W,")]
    public class X12_ID_1073_7
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_8
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,")]
    public class X12_ID_1073_9
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z,")]
    public class X12_ID_1109
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Z,")]
    public class X12_ID_1109_2
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z,")]
    public class X12_ID_1109_3
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",E1,E2,E3,")]
    public class X12_ID_1136
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",09,")]
    public class X12_ID_1136_10
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,")]
    public class X12_ID_1136_11
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_1136_12
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",76,")]
    public class X12_ID_1136_13
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",77,")]
    public class X12_ID_1136_14
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_15
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_1136_2
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1136_3
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_1136_4
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",09,")]
    public class X12_ID_1136_5
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(@",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DR,DV,E1,E2,E3,E4,E5,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,ER,ET,FA,FC,FH,FI,FL,FP,FR,FT,GD,GS,GU,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HY,HZ,IC,ID,IH,IM,IN,LA,LC,LE,LI,LL,LR,LS,LT,LZ,MA,MI,ML,MN,MO,MP,MS,MT,NC,NL,NS,NW,OA,OC,OF,OI,ON,OP,OT,OU,PA,PB,PC,PD,PE,PF,PG,PI,PJ,PN,PO,PR,PS,PT,PX,R1,R2,R3,R4,R5,RC,RE,RI,RL,RM,RN,RP,RR,RS,RT,RU,RV,S1,S2,S3,S4,S5,SA,SD,SE,SI,SJ,SL,SN,SP,SR,SS,ST,SU,SW,SZ,TB,TE,TF,TH,TI,TM,TN,TP,TR,TW,TX,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,VA,VD,VO,WA,WB,WD,WE,WF,WG,WH,WI,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,X1,X2,X3,X4,X5,X6,X7,X8,YR,YT,ZZ,")]
    public class X12_ID_1136_6
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",44,")]
    public class X12_ID_1136_7
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_8
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",08,")]
    public class X12_ID_1136_9
    {
    }
    
    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",P,S,T,U,")]
    public class X12_ID_1138
    {
    }
    
    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,P,S,T,U,")]
    public class X12_ID_1138_2
    {
    }
    
    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,5,6,")]
    public class X12_ID_1143
    {
    }
    
    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143_2
    {
    }
    
    /// <summary>
    /// Disability Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1146
    {
    }
    
    /// <summary>
    /// Work Intensity Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",H,L,M,R,")]
    public class X12_ID_1154
    {
    }
    
    /// <summary>
    /// Product Option Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,2,28,29,3,30,31,4,5,6,7,8,9,A,B,BA,C,D,GA,N,NC,O,PD,S,")]
    public class X12_ID_1161
    {
    }
    
    /// <summary>
    /// Confidentiality Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",O,R,U,")]
    public class X12_ID_1165
    {
    }
    
    /// <summary>
    /// Confidentiality Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",R,U,")]
    public class X12_ID_1165_2
    {
    }
    
    /// <summary>
    /// Confidentiality Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",O,R,U,")]
    public class X12_ID_1165_3
    {
    }
    
    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",02,03,04,05,06,09,")]
    public class X12_ID_1166
    {
    }
    
    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166_2
    {
    }
    
    /// <summary>
    /// Employment Class Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,17,18,19,20,21,22,23,")]
    public class X12_ID_1176
    {
    }
    
    /// <summary>
    /// Information Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,L,O,P,S,T,")]
    public class X12_ID_1201
    {
    }
    
    /// <summary>
    /// Information Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,L,O,P,S,T,")]
    public class X12_ID_1201_2
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,22,46,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,")]
    public class X12_ID_1203_2
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",25,")]
    public class X12_ID_1203_3
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,14,15,16,17,18,20,21,22,25,26,27,28,29,31,32,33" +
        ",37,38,39,40,41,43,59,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XN,XT,")]
    public class X12_ID_1203_4
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203_5
    {
    }
    
    /// <summary>
    /// Insurance Line Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AG,AH,AJ,AK,DCP,DEN,EPO,FAC,HE,HLT,HMO,LTC,LTD,MM,MOD,PDG,POS,PPO,PRA,STD,UR,VIS" +
        ",")]
    public class X12_ID_1205
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,S1C,S5C,S6C,SPC,SPO," +
        "SS1,SS5,SS6,SSP,TWO,")]
    public class X12_ID_1207
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,ECH,ESP,FAM,IND,SPC,SPO,")]
    public class X12_ID_1207_2
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",FAM,")]
    public class X12_ID_1207_3
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,ECH,EMP,ESP,FAM,IND,SPC,SPO,")]
    public class X12_ID_1207_4
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,SPC,SPO,TWO,")]
    public class X12_ID_1207_5
    {
    }
    
    /// <summary>
    /// Underwriting Decision Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,I,N,S,")]
    public class X12_ID_1209
    {
    }
    
    /// <summary>
    /// Drug House Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AM,BAX,FLR,HCS,NP,PCS,THR,ZZ,")]
    public class X12_ID_1211
    {
    }
    
    /// <summary>
    /// Health-Related Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,S,T,U,X,")]
    public class X12_ID_1212
    {
    }
    
    /// <summary>
    /// Current Health Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,E,F,G,P,")]
    public class X12_ID_1213
    {
    }
    
    /// <summary>
    /// Current Health Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,E,F,G,P,")]
    public class X12_ID_1213_2
    {
    }
    
    /// <summary>
    /// Identification Card Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",D,H,P,")]
    public class X12_ID_1215
    {
    }
    
    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,S,T,")]
    public class X12_ID_1216
    {
    }
    
    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,I,S,T,V,")]
    public class X12_ID_1216_2
    {
    }
    
    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,I,S,T,V,")]
    public class X12_ID_1216_3
    {
    }
    
    /// <summary>
    /// Medicare Plan Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218
    {
    }
    
    /// <summary>
    /// Medicare Plan Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218_2
    {
    }
    
    /// <summary>
    /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,ZZ,")]
    public class X12_ID_1219
    {
    }
    
    /// <summary>
    /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,ZZ,")]
    public class X12_ID_1219_2
    {
    }
    
    /// <summary>
    /// Student Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }
    
    /// <summary>
    /// Student Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220_2
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AT,BI,CO,CV,H,HH,LA,OT,P1,P2,PC,PE,R,RF,SK,SU,")]
    public class X12_ID_1221
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BI,")]
    public class X12_ID_1221_10
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AS,AT,OP,OR,OT,PC,PE,RF,")]
    public class X12_ID_1221_11
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AS,OP,OR,OT,PC,PE,")]
    public class X12_ID_1221_12
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AS,AT,CO,CV,OP,OR,OT,PC,PE,RF,")]
    public class X12_ID_1221_13
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AS,AT,OP,OR,OT,PC,PE,RF,")]
    public class X12_ID_1221_2
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RF,")]
    public class X12_ID_1221_3
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AT,")]
    public class X12_ID_1221_4
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_1221_5
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AS,OP,OR,OT,PC,PE,")]
    public class X12_ID_1221_6
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AS,")]
    public class X12_ID_1221_7
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AT,BI,CO,CV,H,HH,LA,OT,P1,P2,PC,PE,R,RF,SB,SK,SU,")]
    public class X12_ID_1221_8
    {
    }
    
    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,AS,AT,CO,CV,OP,OR,OT,PC,PE,RF,")]
    public class X12_ID_1221_9
    {
    }
    
    /// <summary>
    /// Provider Specialty Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DEN,DGP,END,IHG,OPY,ORT,OSY,PDT,PED,PHD,PST,")]
    public class X12_ID_1222
    {
    }
    
    /// <summary>
    /// Provider Specialty Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DEN,DGP,END,IHG,OPY,ORT,OSY,PDT,PED,PHD,PST,")]
    public class X12_ID_1222_2
    {
    }
    
    /// <summary>
    /// Provider Organization Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,")]
    public class X12_ID_1223
    {
    }
    
    /// <summary>
    /// Provider Organization Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,")]
    public class X12_ID_1223_2
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DDT,DT,DTD,DTS,EH,KA,MCY,MD,MM,RD,RD2,RD4,RD5,RD6," +
        "RD8,RDM,RDT,RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_10
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_2
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",RD8,")]
    public class X12_ID_1250_3
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",TM,")]
    public class X12_ID_1250_4
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,DT,")]
    public class X12_ID_1250_5
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_6
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DDT,DT,DTD,DTS,EH,KA,MCY,MD,MM,RD,RD2,RD4,RD5,RD6," +
        "RD8,RDM,RDT,RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250_7
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_8
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",RD8,")]
    public class X12_ID_1250_9
    {
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_127
    {
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_127_2
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BI,")]
    public class X12_ID_1270
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",JP,")]
    public class X12_ID_1270_10
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,BF,")]
    public class X12_ID_1270_11
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,APR,BF,BJ,DR,LOI,PR,")]
    public class X12_ID_1270_12
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABK,BK,TQ,")]
    public class X12_ID_1270_13
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABJ,BJ,")]
    public class X12_ID_1270_14
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1270_15
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",GR,NI,ZZ,")]
    public class X12_ID_1270_16
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,APR,BF,DR,LOI,PR,")]
    public class X12_ID_1270_17
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,BF,TQ,")]
    public class X12_ID_1270_18
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",APR,PR,")]
    public class X12_ID_1270_19
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BH,")]
    public class X12_ID_1270_2
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BP,")]
    public class X12_ID_1270_20
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",LOI,")]
    public class X12_ID_1270_21
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABN,BN,")]
    public class X12_ID_1270_22
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BO,")]
    public class X12_ID_1270_23
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DR,")]
    public class X12_ID_1270_24
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AS,UT,")]
    public class X12_ID_1270_25
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BBR,BR,CAH,")]
    public class X12_ID_1270_26
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BBQ,BQ,")]
    public class X12_ID_1270_27
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
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
    public class X12_ID_1270_28
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RET,")]
    public class X12_ID_1270_29
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BE,")]
    public class X12_ID_1270_3
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HE,RX,")]
    public class X12_ID_1270_30
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,ABK,APR,BF,BJ,BK,DR,PR,")]
    public class X12_ID_1270_31
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,APR,BF,BJ,DR,PR,")]
    public class X12_ID_1270_32
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,APR,BF,DR,PR,")]
    public class X12_ID_1270_33
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",JP,")]
    public class X12_ID_1270_34
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
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
    public class X12_ID_1270_35
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BG,")]
    public class X12_ID_1270_4
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",TC,")]
    public class X12_ID_1270_5
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABK,BK,")]
    public class X12_ID_1270_6
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RX,")]
    public class X12_ID_1270_7
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,ABK,APR,BF,BJ,BK,DR,LOI,PR,")]
    public class X12_ID_1270_8
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",REC,")]
    public class X12_ID_1270_9
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,1J,D3,G2,HPI,SY,TJ,")]
    public class X12_ID_128
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9A,")]
    public class X12_ID_128_10
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EW,")]
    public class X12_ID_128_11
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9C,")]
    public class X12_ID_128_12
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",LX,")]
    public class X12_ID_128_13
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D9,")]
    public class X12_ID_128_14
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",LU,")]
    public class X12_ID_128_15
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",X4,")]
    public class X12_ID_128_16
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EA,")]
    public class X12_ID_128_17
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,G2,")]
    public class X12_ID_128_18
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",P4,")]
    public class X12_ID_128_19
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",G2,LU,")]
    public class X12_ID_128_2
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",EI,SY,")]
    public class X12_ID_128_21
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EI,")]
    public class X12_ID_128_22
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,G2,LU,")]
    public class X12_ID_128_23
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",G4,")]
    public class X12_ID_128_24
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,G2,LU,")]
    public class X12_ID_128_25
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",T4,")]
    public class X12_ID_128_26
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,")]
    public class X12_ID_128_27
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",6R,")]
    public class X12_ID_128_28
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1J,")]
    public class X12_ID_128_29
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9F,")]
    public class X12_ID_128_3
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,G2,LU,")]
    public class X12_ID_128_30
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1W,SY,")]
    public class X12_ID_128_31
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9B,")]
    public class X12_ID_128_32
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9D,")]
    public class X12_ID_128_33
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",VY,XZ,")]
    public class X12_ID_128_34
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128_35
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BLT,")]
    public class X12_ID_128_36
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1K,")]
    public class X12_ID_128_37
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,1L,CT,IK,")]
    public class X12_ID_128_38
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0F,")]
    public class X12_ID_128_39
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0K,")]
    public class X12_ID_128_4
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F2,")]
    public class X12_ID_128_40
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_128_41
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BT,")]
    public class X12_ID_128_42
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,3H,6P,CT,EA,EJ,F6,GH,HJ,IG,N6,NQ,SY,Y4,")]
    public class X12_ID_128_43
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,3H,49,6P,CE,CT,EA,EJ,F6,GH,HJ,IF,IG,N6,NQ,Q4,SY,Y4,")]
    public class X12_ID_128_44
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,")]
    public class X12_ID_128_45
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,3L,6P,DP,EJ,F6,HJ,IG,N6,NQ,SY,")]
    public class X12_ID_128_46
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,17,18,2F,38,E9,LB,LU,ZZ,")]
    public class X12_ID_128_47
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,")]
    public class X12_ID_128_48
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,EO,HI,NF,")]
    public class X12_ID_128_49
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",G3,")]
    public class X12_ID_128_5
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,")]
    public class X12_ID_128_50
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,FY,NF,")]
    public class X12_ID_128_51
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9K,D3,EI,HPI,PXC,SY,TJ,")]
    public class X12_ID_128_52
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,49,6P,9F,ALS,CLI,F6,FO,G1,IG,M7,N6,NQ,")]
    public class X12_ID_128_53
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",6P,")]
    public class X12_ID_128_54
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",XZ,")]
    public class X12_ID_128_55
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,SY,")]
    public class X12_ID_128_56
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,9J,AZ,B7,CT,ID,IG,IK,KW,")]
    public class X12_ID_128_57
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",17,23,3H,4A,6O,ABB,D3,DX,F6,P5,Q4,QQ,ZZ,")]
    public class X12_ID_128_58
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,D3,PQ,TJ,")]
    public class X12_ID_128_59
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",G1,")]
    public class X12_ID_128_6
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",SY,")]
    public class X12_ID_128_60
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9F,G1,")]
    public class X12_ID_128_61
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,49,6P,CE,CT,EA,EJ,F6,GH,HJ,IF,IG,MRC,N6,NQ,Q4,SY,Y4,")]
    public class X12_ID_128_62
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",VV,")]
    public class X12_ID_128_63
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FJ,")]
    public class X12_ID_128_64
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",NT,")]
    public class X12_ID_128_65
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,18,2F,38,E9,LU,ZZ,")]
    public class X12_ID_128_66
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",17,1L,9V,CE,E8,M7,PID,RB,X9,XM,XX1,XX2,ZX,ZZ,")]
    public class X12_ID_128_67
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,1W,28,6P,9A,9C,BB,CE,EA,F8,G1,G3,IG,SY,")]
    public class X12_ID_128_68
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_69
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",4N,")]
    public class X12_ID_128_7
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,6P,CT,EA,EJ,F6,GH,HJ,IF,IG,MRC,N6,SY,Y4,")]
    public class X12_ID_128_70
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,49,6P,9F,ALS,CLI,F6,FO,G1,IG,N6,NQ,")]
    public class X12_ID_128_71
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BB,")]
    public class X12_ID_128_72
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",QQ,")]
    public class X12_ID_128_73
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,1J,D3,G2,LU,")]
    public class X12_ID_128_74
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,EI,FY,NF,")]
    public class X12_ID_128_75
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,1J,EI,N5,N7,SY,ZH,")]
    public class X12_ID_128_76
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",60,6P,SY,ZZ,")]
    public class X12_ID_128_77
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1S,APC,BB,E9,G1,G3,LU,RB,")]
    public class X12_ID_128_78
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_79
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F8,")]
    public class X12_ID_128_8
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,17,18,19,26,3L,6M,9V,9X,GE,LU,PID,XX1,XX2,YY,ZZ,")]
    public class X12_ID_128_80
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1C,1D,1J,4A,CT,EL,EO,HPI,JD,N5,N7,Q4,SY,TJ,")]
    public class X12_ID_128_81
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,G2,LU,SY,TJ,")]
    public class X12_ID_128_82
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_83
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,17,18,2F,38,72,LB,")]
    public class X12_ID_128_84
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",38,")]
    public class X12_ID_128_85
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EV,")]
    public class X12_ID_128_86
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
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
    public class X12_ID_128_87
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128_88
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,3L,6P,DP,EJ,F6,HJ,IG,N6,NQ,SY,")]
    public class X12_ID_128_89
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_128_9
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,SY,")]
    public class X12_ID_128_90
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BB,")]
    public class X12_ID_128_91
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",NT,")]
    public class X12_ID_128_92
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,1J,EI,N5,N7,SY,ZH,")]
    public class X12_ID_128_93
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_94
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_95
    {
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A172,B680,D940,G740,")]
    public class X12_ID_1300
    {
    }
    
    /// <summary>
    /// Use of Language Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",5,6,7,8,")]
    public class X12_ID_1303
    {
    }
    
    /// <summary>
    /// Ambulance Transport Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316
    {
    }
    
    /// <summary>
    /// Ambulance Transport Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316_2
    {
    }
    
    /// <summary>
    /// Ambulance Transport Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,")]
    public class X12_ID_1317
    {
    }
    
    /// <summary>
    /// Ambulance Transport Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317_2
    {
    }
    
    /// <summary>
    /// Ambulance Transport Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,")]
    public class X12_ID_1317_3
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",06,16,17,25,33,37,39,5A,9J,9K,DY,")]
    public class X12_ID_1321_10
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",02,03,04,05,06,11,12,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,30,31,32,35,37" +
        ",39,40,41,42,43,44,45,46,5A,68,69,9E,9F,9H,AA,AL,BL,BPD,BTD,CA,CB,CNJ,CO,DY,EL,E" +
        "P,HL,LB,LE,OL,PA,PW,SL,TNJ,WA,WR,")]
    public class X12_ID_1321_11
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",10,13,19,21,22,27,31,40,BR,CA,CB,CR,EL,EP,IH,NR,PA,PW,TR,UT,WA,WR,")]
    public class X12_ID_1321_12
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,05,07,13,20,22,23,26,33,34,5A,68,69,9E,9F,9J,9K,AG,BPD,BTD,CB,CM,DI,DP,FO,HO," +
        "LE,MC,OT,UN,")]
    public class X12_ID_1321_13
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,41,43,5A,60,9D,")]
    public class X12_ID_1321_14
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",L1,L2,L3,L4,L5,")]
    public class X12_ID_1321_2
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",IH,")]
    public class X12_ID_1321_3
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",AV,NU,S2,ST,")]
    public class X12_ID_1321_4
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",65,")]
    public class X12_ID_1321_5
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",38,ZV,")]
    public class X12_ID_1321_6
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,04,05,06,07,08,09,12,")]
    public class X12_ID_1321_7
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,12,14,24,25,27,30,")]
    public class X12_ID_1321_8
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",29,30,31,32,33,35,37,38,40,41,42,43,44,45,46,58,59,60,9D,9H,9J,9K,IH,LB,SL,")]
    public class X12_ID_1321_9
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,I,N,R,S,")]
    public class X12_ID_1322
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,I,R,S,")]
    public class X12_ID_1322_2
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,I,N,R,S,")]
    public class X12_ID_1322_3
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322_4
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,I,N,R,S,")]
    public class X12_ID_1322_5
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,6,I,R,S,")]
    public class X12_ID_1322_6
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,I,N,R,S,")]
    public class X12_ID_1322_7
    {
    }
    
    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1327
    {
    }
    
    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_1327_2
    {
    }
    
    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1327_3
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,")]
    public class X12_ID_1332
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",B,")]
    public class X12_ID_1332_2
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,")]
    public class X12_ID_1332_3
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,")]
    public class X12_ID_1332_4
    {
    }
    
    /// <summary>
    /// Record Format Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,D,E,F,P,S,")]
    public class X12_ID_1333
    {
    }
    
    /// <summary>
    /// Insulin Dependent Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,N,")]
    public class X12_ID_1335
    {
    }
    
    /// <summary>
    /// Insurance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,AP,C1,CO,CP,D,DB,E,EP,FF,GP,HM,HN,HS,IN,IP,LC,LD,LI,L" +
        "T,MA,MB,MC,MH,MI,MP,OT,PE,PL,PP,PR,PS,QM,RP,SP,TF,U,WC,WU,")]
    public class X12_ID_1336
    {
    }
    
    /// <summary>
    /// Insurance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,AP,C1,CO,CP,D,DB,EP,FF,GP,HM,HN,HS,IN,IP,LC,LD,LI,LT," +
        "MA,MB,MC,MH,MI,MP,OT,PE,PL,PP,PR,PS,QM,RP,SP,TF,WC,WU,")]
    public class X12_ID_1336_2
    {
    }
    
    /// <summary>
    /// Insurance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,")]
    public class X12_ID_1336_3
    {
    }
    
    /// <summary>
    /// Level of Care Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1337
    {
    }
    
    /// <summary>
    /// Level of Care Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1337_2
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,E,F1,F2,I,L,NBC,R,U,")]
    public class X12_ID_1338
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,E,U,")]
    public class X12_ID_1338_2
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,E,F1,F2,I,L,NBC,R,U,")]
    public class X12_ID_1338_3
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,E,U,")]
    public class X12_ID_1338_4
    {
    }
    
    /// <summary>
    /// Multiple Procedure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1340
    {
    }
    
    /// <summary>
    /// Multiple Procedure Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1340_2
    {
    }
    
    /// <summary>
    /// Nature of Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342
    {
    }
    
    /// <summary>
    /// Nature of Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342_2
    {
    }
    
    /// <summary>
    /// Non-Institutional Claim Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,AA,AM,AN,CF,CH,CS,DA,DD,DM,DN,ER,HH,HS,IF,IL,L,LT,MD,MF,MH,MI,MO,MS,NM,NP,NS,O" +
        ",OC,OP,OT,OX,P,PA,PD,PE,PF,PS,PT,RX,S,SC,SN,ST,T,TX,V,")]
    public class X12_ID_1343
    {
    }
    
    /// <summary>
    /// Nursing Home Residential Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1345
    {
    }
    
    /// <summary>
    /// Nursing Home Residential Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1345_2
    {
    }
    
    /// <summary>
    /// Oxygen Equipment Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,O,")]
    public class X12_ID_1348
    {
    }
    
    /// <summary>
    /// Oxygen Equipment Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,O,")]
    public class X12_ID_1348_2
    {
    }
    
    /// <summary>
    /// Oxygen Test Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",E,N,O,R,S,W,X,")]
    public class X12_ID_1349
    {
    }
    
    /// <summary>
    /// Oxygen Test Condition Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",E,N,O,R,S,W,X,")]
    public class X12_ID_1349_2
    {
    }
    
    /// <summary>
    /// Oxygen Test Findings Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1350
    {
    }
    
    /// <summary>
    /// Oxygen Test Findings Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1350_2
    {
    }
    
    /// <summary>
    /// Patient Signature Source Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",P,")]
    public class X12_ID_1351
    {
    }
    
    /// <summary>
    /// Patient Signature Source Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B,C,M,P,S,")]
    public class X12_ID_1351_2
    {
    }
    
    /// <summary>
    /// Prosthesis, Crown or Inlay Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,")]
    public class X12_ID_1358
    {
    }
    
    /// <summary>
    /// Prosthesis, Crown or Inlay Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,")]
    public class X12_ID_1358_2
    {
    }
    
    /// <summary>
    /// Provider Accept Assignment Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,C,")]
    public class X12_ID_1359
    {
    }
    
    /// <summary>
    /// Provider Accept Assignment Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,")]
    public class X12_ID_1359_2
    {
    }
    
    /// <summary>
    /// Provider Agreement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",D,E,H,I,N,P,Y,")]
    public class X12_ID_1360
    {
    }
    
    /// <summary>
    /// Provider Agreement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",D,E,H,I,N,P,Y,")]
    public class X12_ID_1360_2
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AB,AP,EM,OA,ZZ,")]
    public class X12_ID_1362
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,EM,OA,")]
    public class X12_ID_1362_2
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AP,EM,")]
    public class X12_ID_1362_3
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AP,")]
    public class X12_ID_1362_4
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AB,AP,EM,OA,ZZ,")]
    public class X12_ID_1362_5
    {
    }
    
    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AP,EM,")]
    public class X12_ID_1362_6
    {
    }
    
    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363
    {
    }
    
    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,Y,")]
    public class X12_ID_1363_2
    {
    }
    
    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363_3
    {
    }
    
    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",M,Y,")]
    public class X12_ID_1363_4
    {
    }
    
    /// <summary>
    /// Review Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,L,N,")]
    public class X12_ID_1364
    {
    }
    
    /// <summary>
    /// Review Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,L,N,")]
    public class X12_ID_1364_2
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,11,12,14,15,16,17,18,2,20,21,23,24,25,26,27,28,3,33,35,36,37,38,39,4,40,42,44,45,46,5,54,56,6,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,82,83,84,85,86,87,88,93,A4,A6,A9,AD,AE,AF,AG,AI,AJ,AK,AL,AR,B1,BB,BC,BD,BE,BF,BG,BL,BN,BP,BQ,BS,BY,BZ,C1,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,")]
    public class X12_ID_1365
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365_2
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365_3
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,11,12,14,15,16,17,18,2,20,21,23,24,25,26,27,28,3,33,35,36,37,38,39,4,40,42,44,45,46,5,54,56,6,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,82,83,84,85,86,87,88,93,A4,A6,A9,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AR,B1,BB,BC,BD,BE,BF,BG,BL,BN,BP,BQ,BS,BY,BZ,C1,CQ,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,")]
    public class X12_ID_1365_4
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,35,48,50,54,89,90,A4,AG,AL,BB,")]
    public class X12_ID_1365_5
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,11,12,14,15,16,17,18,2,20,21,23,24,25,26,27,28,3,33,35,36,37,38,39,4,40,42,44,45,46,5,54,56,6,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,82,83,84,85,86,87,88,93,A4,A6,A9,AD,AE,AF,AG,AI,AJ,AK,AL,AR,B1,BB,BC,BD,BE,BF,BG,BL,BN,BP,BQ,BS,BY,BZ,C1,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,")]
    public class X12_ID_1365_6
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365_7
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,11,12,14,15,16,17,18,2,20,21,23,24,25,26,27,28,3,33,35,36,37,38,39,4,40,42,44,45,46,5,54,56,6,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,82,83,84,85,86,87,88,93,A4,A6,A9,AD,AE,AF,AG,AI,AJ,AK,AL,AR,B1,BB,BC,BD,BE,BF,BG,BL,BN,BP,BQ,BS,BY,BZ,C1,CQ,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,")]
    public class X12_ID_1365_8
    {
    }
    
    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,05,")]
    public class X12_ID_1366
    {
    }
    
    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,")]
    public class X12_ID_1366_2
    {
    }
    
    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",02,03,05,09,")]
    public class X12_ID_1366_3
    {
    }
    
    /// <summary>
    /// Subluxation Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7" +
        ",T8,T9,")]
    public class X12_ID_1367
    {
    }
    
    /// <summary>
    /// Subluxation Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7" +
        ",T8,T9,")]
    public class X12_ID_1367_2
    {
    }
    
    /// <summary>
    /// Tooth Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",E,M,")]
    public class X12_ID_1368
    {
    }
    
    /// <summary>
    /// Tooth Surface Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B,D,F,I,L,M,O,")]
    public class X12_ID_1369
    {
    }
    
    /// <summary>
    /// Tooth Surface Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B,D,F,I,L,M,O,")]
    public class X12_ID_1369_2
    {
    }
    
    /// <summary>
    /// Measurement Method or Device
    /// </summary>
    [Serializable()]
    [EdiCodes(",BM,BO,DM,FT,HN,MA,MM,OM,OU,PT,TM,VA,VB,VC,")]
    public class X12_ID_1373
    {
    }
    
    /// <summary>
    /// Oxygen Delivery System Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1382
    {
    }
    
    /// <summary>
    /// Claim Submission Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
    {
    }
    
    /// <summary>
    /// Claim Submission Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PB,")]
    public class X12_ID_1383_2
    {
    }
    
    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }
    
    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384_2
    {
    }
    
    /// <summary>
    /// Eligibility or Benefit Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,CB,D,E,F,G,H,I,J,K,L,M,MC,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_1390
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",270,")]
    public class X12_ID_143
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",271,")]
    public class X12_ID_143_2
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",276,")]
    public class X12_ID_143_3
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",277,")]
    public class X12_ID_143_4
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",820,")]
    public class X12_ID_143_5
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",834,")]
    public class X12_ID_143_6
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",835,")]
    public class X12_ID_143_7
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",837,")]
    public class X12_ID_143_8
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",278,")]
    public class X12_ID_143_9
    {
    }
    
    /// <summary>
    /// Pricing Methodology
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473
    {
    }
    
    /// <summary>
    /// Pricing Methodology
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_2
    {
    }
    
    /// <summary>
    /// Language Proficiency Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,")]
    public class X12_ID_1476
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,15,16,17,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,15,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514_2
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,15,16,17,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514_3
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,10,11,15,16,17,2,3,4,7,8,")]
    public class X12_ID_1514_4
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HS,SC,")]
    public class X12_ID_1525_2
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,HS,IN,SC,")]
    public class X12_ID_1525_3
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525_4
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HS,SC,")]
    public class X12_ID_1525_5
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,HS,IN,SC,")]
    public class X12_ID_1525_6
    {
    }
    
    /// <summary>
    /// Policy Compliance Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526
    {
    }
    
    /// <summary>
    /// Exception Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527
    {
    }
    
    /// <summary>
    /// Government Service Affiliation Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,Q,R,S,U,W,")]
    public class X12_ID_1595
    {
    }
    
    /// <summary>
    /// Military Service Rank Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A1,A2,A3,B1,B2,C1,C2,C3,C4,C5,C6,C7,C8,C9,E1,F1,F2,F3,F4,G1,G4,L1,L2,L3,L4,L5,L6" +
        ",M1,M2,M3,M4,M5,M6,P1,P2,P3,P4,P5,R1,R2,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,T1,V" +
        "1,W1,")]
    public class X12_ID_1596
    {
    }
    
    /// <summary>
    /// Eligibility Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,2,")]
    public class X12_ID_1701
    {
    }
    
    /// <summary>
    /// Eligibility Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,2,")]
    public class X12_ID_1701_2
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X279A1,")]
    public class X12_ID_1705
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X212,")]
    public class X12_ID_1705_2
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X214,")]
    public class X12_ID_1705_3
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X218,")]
    public class X12_ID_1705_4
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X220A1,")]
    public class X12_ID_1705_5
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X224A2,")]
    public class X12_ID_1705_6
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X223A2,")]
    public class X12_ID_1705_7
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X222A1,")]
    public class X12_ID_1705_8
    {
    }
    
    /// <summary>
    /// Implementation Convention Reference
    /// </summary>
    [Serializable()]
    [EdiCodes(",005010X217,")]
    public class X12_ID_1705_9
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",HC,")]
    public class X12_ID_235_10
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EN,EO,HI,N4,ON,UK,UP,")]
    public class X12_ID_235_11
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,CJ,HC,ID,IV,N4,ZZ,")]
    public class X12_ID_235_12
    {
    }
    
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,NU,WK,")]
    public class X12_ID_235_13
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DX,ZZ,")]
    public class X12_ID_235_14
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,N4,N6,NU,UI,WK,")]
    public class X12_ID_235_15
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,IV,N4,WK,")]
    public class X12_ID_235_16
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,ID,IV,N4,WK,ZZ,")]
    public class X12_ID_235_17
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,")]
    public class X12_ID_235_18
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,ID,")]
    public class X12_ID_235_19
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,IV,N4,WK,")]
    public class X12_ID_235_2
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,N4,NU,WK,")]
    public class X12_ID_235_3
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,")]
    public class X12_ID_235_4
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ER,HC,HP,IV,WK,")]
    public class X12_ID_235_5
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ER,HC,IV,WK,")]
    public class X12_ID_235_6
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,ID,IV,N4,WK,ZZ,")]
    public class X12_ID_235_7
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,ER,")]
    public class X12_ID_235_8
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",N4,")]
    public class X12_ID_235_9
    {
    }
    
    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BBP,BCH,BID,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FOR,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LCP,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,SSP,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,")]
    public class X12_ID_248
    {
    }
    
    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,D,I,P,U,X,")]
    public class X12_ID_305
    {
    }
    
    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,D,H,I,P,U,X,")]
    public class X12_ID_305_2
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",U,")]
    public class X12_ID_306
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A1,A3,A4,A6,C,CT,NA,")]
    public class X12_ID_306_2
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,RX,")]
    public class X12_ID_306_3
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_306_4
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",0,00,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AP,AQ,AR,AS,AT,AV,AW,AX,B,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,C,C1,C2,CA,CB,CC,CD,CE,CF,CG,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CX,D,D1,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DP,DR,DS,DT,DX,E,EA,EB,EC,ED,EE,EN,EP,ER,EV,EX,EZ,F,F1,FA,FC,FI,FO,FR,G,GR,H,HM,HR,I,I1,IA,IM,IN,IS,IT,J,JA,JO,JU,K,KA,L,LC,LQ,M,ME,MO,N,NA,NC,ND,NP,NS,O,OD,OP,OR,OT,P,P1,PA,PB,PC,PD,PF,PI,PJ,PO,PP,PR,PS,PT,PU,PV,Q,R,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RZ,S,S1,S2,SA,SB,SC,SD,SE,SL,SR,SS,SU,SV,SZ,T,TD,TE,TG,TN,TP,TR,TS,TU,U,V,VA,W,W1,WD,WI,WQ,WV,X,Y,Z,")]
    public class X12_ID_306_5
    {
    }
    
    /// <summary>
    /// Status Information Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",U,WQ,")]
    public class X12_ID_306_6
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A1,A2,A3,A4,A6,C,CT,NA,")]
    public class X12_ID_306_7
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,4,RX,")]
    public class X12_ID_306_8
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",RJ,")]
    public class X12_ID_309
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309_2
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",60,CY,RJ,")]
    public class X12_ID_309_3
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",60,CY,")]
    public class X12_ID_309_4
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309_5
    {
    }
    
    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,15,18,20,21,25,CA,CC,PP,ZZ,")]
    public class X12_ID_331
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,13,")]
    public class X12_ID_353
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",06,11,")]
    public class X12_ID_353_2
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",13,")]
    public class X12_ID_353_3
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",08,")]
    public class X12_ID_353_4
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,")]
    public class X12_ID_353_5
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,15,22,")]
    public class X12_ID_353_6
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,18,")]
    public class X12_ID_353_7
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,13,36,")]
    public class X12_ID_353_8
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",DA,F2,UN,")]
    public class X12_ID_355_10
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",MJ,UN,")]
    public class X12_ID_355_11
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,")]
    public class X12_ID_355_12
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",MO,")]
    public class X12_ID_355_13
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,MO,VS,WK,YR,")]
    public class X12_ID_355_14
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,MO,WK,")]
    public class X12_ID_355_15
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,")]
    public class X12_ID_355_16
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",KG,LB,")]
    public class X12_ID_355_17
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DH,DK,")]
    public class X12_ID_355_18
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
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
    public class X12_ID_355_19
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",10,IE,PR,")]
    public class X12_ID_355_2
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F2,MJ,UN,")]
    public class X12_ID_355_20
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,F2,UN,")]
    public class X12_ID_355_21
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,MO,WK,")]
    public class X12_ID_355_22
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",UN,")]
    public class X12_ID_355_3
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,UN,")]
    public class X12_ID_355_4
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DH,DK,")]
    public class X12_ID_355_5
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F2,GR,ME,ML,UN,")]
    public class X12_ID_355_6
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",LB,")]
    public class X12_ID_355_7
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F2,MJ,UN,")]
    public class X12_ID_355_8
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DH,")]
    public class X12_ID_355_9
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ADD,")]
    public class X12_ID_363
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ADD,DCP,")]
    public class X12_ID_363_2
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",TPO,")]
    public class X12_ID_363_3
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ALG,DCP,DGN,DME,MED,NTR,ODT,RHB,RLH,RNH,SET,SFM,SPT,UPI,")]
    public class X12_ID_363_4
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ADD,CER,DCP,DGN,TPO,")]
    public class X12_ID_363_5
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,EX,FX,TE,UR,")]
    public class X12_ID_365
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,HP,TE,WP,")]
    public class X12_ID_365_10
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,TE,UR,")]
    public class X12_ID_365_11
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AP,AS,AU,BN,BT,CA,CP,DN,EA,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT" +
        ",PA,PC,PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365_12
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,EX,FX,UR,")]
    public class X12_ID_365_13
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",UR,")]
    public class X12_ID_365_14
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,FX,TE,UR,")]
    public class X12_ID_365_15
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,FX,TE,")]
    public class X12_ID_365_16
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,FX,TE,UR,")]
    public class X12_ID_365_17
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,FX,TE,")]
    public class X12_ID_365_18
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,FX,HP,TE,WP,")]
    public class X12_ID_365_19
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,EX,FX,TE,")]
    public class X12_ID_365_2
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,EX,FX,TE,UR,")]
    public class X12_ID_365_20
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,FX,TE,UR,")]
    public class X12_ID_365_21
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,EX,FX,TE,UR,")]
    public class X12_ID_365_3
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EM,EX,FX,TE,")]
    public class X12_ID_365_4
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,FX,TE,")]
    public class X12_ID_365_5
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,FX,TE,UR,WP,")]
    public class X12_ID_365_6
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EX,")]
    public class X12_ID_365_7
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",TE,")]
    public class X12_ID_365_8
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ED,EM,EX,FX,TE,UR,WP,")]
    public class X12_ID_365_9
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",EP,")]
    public class X12_ID_366
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_10
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BL,")]
    public class X12_ID_366_2
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",SK,")]
    public class X12_ID_366_3
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_4
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PQ,")]
    public class X12_ID_366_5
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RP,")]
    public class X12_ID_366_6
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CN,")]
    public class X12_ID_366_7
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IP,")]
    public class X12_ID_366_8
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CX,")]
    public class X12_ID_366_9
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",007,")]
    public class X12_ID_374
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",444,")]
    public class X12_ID_374_10
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",050,")]
    public class X12_ID_374_11
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",573,")]
    public class X12_ID_374_12
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",291,")]
    public class X12_ID_374_13
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",096,193,194,198,290,291,292,295,304,307,318,346,348,349,356,357,435,472,636,771," +
        "")]
    public class X12_ID_374_14
    {
    }
    
    /// <summary>
    /// Date Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",009,")]
    public class X12_ID_374_15
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",484,")]
    public class X12_ID_374_16
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",050,286,296,297,300,301,303,336,337,338,339,340,341,350,351,356,357,383,385,386," +
        "393,394,473,474,")]
    public class X12_ID_374_17
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",405,")]
    public class X12_ID_374_18
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",439,")]
    public class X12_ID_374_19
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",198,")]
    public class X12_ID_374_2
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_20
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",607,")]
    public class X12_ID_374_21
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",463,")]
    public class X12_ID_374_22
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",461,")]
    public class X12_ID_374_23
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",738,739,")]
    public class X12_ID_374_24
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",011,")]
    public class X12_ID_374_25
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABC,")]
    public class X12_ID_374_26
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",035,")]
    public class X12_ID_374_27
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",360,361,")]
    public class X12_ID_374_28
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",232,233,")]
    public class X12_ID_374_29
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",314,360,361,")]
    public class X12_ID_374_3
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",452,")]
    public class X12_ID_374_30
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",434,")]
    public class X12_ID_374_31
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",454,")]
    public class X12_ID_374_32
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",582,")]
    public class X12_ID_374_33
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",300,303,343,348,349,543,695,")]
    public class X12_ID_374_34
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",036,")]
    public class X12_ID_374_35
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",304,")]
    public class X12_ID_374_36
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AAH,")]
    public class X12_ID_374_37
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",097,")]
    public class X12_ID_374_38
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",344,345,")]
    public class X12_ID_374_39
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",472,")]
    public class X12_ID_374_4
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",453,")]
    public class X12_ID_374_40
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",582,AAG,")]
    public class X12_ID_374_41
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",150,151,472,")]
    public class X12_ID_374_42
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",139,441,")]
    public class X12_ID_374_43
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",102,")]
    public class X12_ID_374_44
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",446,")]
    public class X12_ID_374_45
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",455,")]
    public class X12_ID_374_46
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",196,")]
    public class X12_ID_374_47
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",471,")]
    public class X12_ID_374_48
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",102,291,")]
    public class X12_ID_374_49
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",297,")]
    public class X12_ID_374_5
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",096,102,152,291,307,318,340,341,342,343,346,347,356,357,382,435,442,458,472,539," +
        "540,636,771,")]
    public class X12_ID_374_50
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
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
    public class X12_ID_374_51
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",007,090,091,303,382,388,")]
    public class X12_ID_374_52
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",484,")]
    public class X12_ID_374_53
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABC,")]
    public class X12_ID_374_54
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_55
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AAH,")]
    public class X12_ID_374_56
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",435,")]
    public class X12_ID_374_57
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",096,")]
    public class X12_ID_374_58
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",598,")]
    public class X12_ID_374_59
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",296,")]
    public class X12_ID_374_6
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",472,")]
    public class X12_ID_374_60
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",439,")]
    public class X12_ID_374_61
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",435,")]
    public class X12_ID_374_7
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",096,")]
    public class X12_ID_374_8
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",090,091,")]
    public class X12_ID_374_9
    {
    }
    
    /// <summary>
    /// Allowance/Charge Percent Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,D,H,Z,")]
    public class X12_ID_378
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BR,BS,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CE,CK,CM,CO,CP,CQ,CR,CS,CT,CU,CV,CW,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DO,DP,DR,DS,DT,DU,DV,DW,DX,DY,E1,E2,E3,E4,E5,E6,E7,E8,E9,EE,EP,ER,EX,F1,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FI,FR,FT,FU,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GJ,GK,GL,GM,GN,GO,GR,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HI,HM,IA,IC,IE,IF,IL,IN,IP,IR,IS,J1,J2,J3,J4,J5,J6,J7,J8,J9,JE,K1,K2,K3,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LE,LF,LO,LP,LS,M1,M2,M3,M4,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MV,N1,N2,N3,N4,N5,N6,N7,NA,NB,NC,ND,NL,NO,NP,NR,OA,OB,OC,OL,OP,OT,P1,P2,P3,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R1,R2,R3,R4,R5,R6,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,SA,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SR,SS,ST,SU,SV,SW,SX,SY,TA,TD,TI,TL,UB,UL,VC,VD,VO,W6,W8,W9,WA,WB,WC,WE,WH,WO,WR,WS,WT,WU,WW,WX,WY,WZ,XA,XB,XC,XD,XE,XF,ZZ,")]
    public class X12_ID_426
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",20,52,53,AA,AX,H1,H6,IA,J3,")]
    public class X12_ID_426_2
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",52,53,80,81,86,BJ,H1,H6,RU,WO,")]
    public class X12_ID_426_3
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",52,53,80,81,86,BJ,H1,H6,RU,WO,WW,")]
    public class X12_ID_426_4
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",50,51,72,90,AH,AM,AP,B2,B3,BD,BN,C5,CR,CS,CT,CV,CW,DM,E3,FB,FC,GO,HM,IP,IR,IS,J1" +
        ",L3,L6,LE,LS,OA,OB,PI,PL,RA,RE,SL,TL,WO,WU,")]
    public class X12_ID_426_5
    {
    }
    
    /// <summary>
    /// Credit/Debit Flag Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,D,")]
    public class X12_ID_478
    {
    }
    
    /// <summary>
    /// Credit/Debit Flag Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,")]
    public class X12_ID_478_2
    {
    }
    
    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_481
    {
    }
    
    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_481_2
    {
    }
    
    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_481_3
    {
    }
    
    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,3,")]
    public class X12_ID_481_4
    {
    }
    
    /// <summary>
    /// Payment Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AJ,ER,FL,NS,PA,PI,PO,PP,PR,")]
    public class X12_ID_482
    {
    }
    
    /// <summary>
    /// Payment Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PA,PI,PO,PP,")]
    public class X12_ID_482_2
    {
    }
    
    /// <summary>
    /// (DFI) ID Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,ZZ,")]
    public class X12_ID_506
    {
    }
    
    /// <summary>
    /// (DFI) ID Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,04,")]
    public class X12_ID_506_2
    {
    }
    
    /// <summary>
    /// (DFI) ID Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,04,")]
    public class X12_ID_506_3
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PB,")]
    public class X12_ID_522
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_522_10
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",R,")]
    public class X12_ID_522_11
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",T3,")]
    public class X12_ID_522_12
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",YU,")]
    public class X12_ID_522_13
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B9,C1,D2,EBA,FK,P3,R,")]
    public class X12_ID_522_14
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AU,D8,DY,F5,I,NL,T,T2,ZK,ZL,ZM,ZN,ZO,")]
    public class X12_ID_522_15
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_522_16
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",F3,")]
    public class X12_ID_522_17
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",YY,")]
    public class X12_ID_522_2
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B6,KH,T,T2,ZK,ZL,ZM,ZN,ZO,")]
    public class X12_ID_522_3
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",D,")]
    public class X12_ID_522_4
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",EAF,")]
    public class X12_ID_522_5
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A8,")]
    public class X12_ID_522_6
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",T,")]
    public class X12_ID_522_7
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",GT,")]
    public class X12_ID_522_8
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N8,")]
    public class X12_ID_522_9
    {
    }
    
    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,64,65,66,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AL,AM,AP,AQ,AR,AS,AT,AW,AX,AY,BA,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CP,CR,CS,CU,CX,DA,DD,DE,DF,DH,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GI,GS,GU,HC,HF,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NP,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,PI,RN,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UA,UC,UI,UL,UN,UT,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }
    
    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,64,65,66,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AL,AM,AP,AQ,AR,AS,AT,AW,AX,AY,BA,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CP,CR,CS,CU,CX,DA,DD,DE,DF,DH,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GI,GS,GU,HC,HF,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NP,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,PI,RN,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UA,UC,UI,UL,UN,UT,VI,WH,ZZ,")]
    public class X12_ID_559_2
    {
    }
    
    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,SG,")]
    public class X12_ID_569
    {
    }
    
    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,03,05,06,07,08,1,10,11,12,13,14,2,3,4,5,6,7,8,9,AG,ALC,ANN,AP,BA,CB,CC,CDM,CD" +
        "S,CM,CRU,DA,DC,EC,EPC,GL,LN,LTD,MUT,PRI,RD,REL,RS,SG,SKA,Z,ZB1,ZB2,")]
    public class X12_ID_569_2
    {
    }
    
    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ALC,DA,")]
    public class X12_ID_569_3
    {
    }
    
    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,")]
    public class X12_ID_569_4
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AE,AO,AS,AT,AU,CC,DD,HD,IR,LX,PE,RE,RM,RR,RU,")]
    public class X12_ID_584
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",00,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AS,AT,AU,CA,CC,CO,CT,DC,DD,DI,DQ,DR,DS,EO,FA,FB,FC,FO,FT,HD,IA,IR,L1,L2,L3,L4,L5,L6,L7,LA,LE,LF,LM,LO,LS,LU,LW,LX,NE,OS,OT,PA,PC,PE,PM,PN,PR,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,RR,RT,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TN,TP,TR,UK,VO,XD,ZZ,")]
    public class X12_ID_584_2
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AO,AU,DI,PV,RU,")]
    public class X12_ID_584_3
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AC,AO,AU,FT,L1,PT,RT,TE,")]
    public class X12_ID_584_4
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",00,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AS,AT,AU,CA,CC,CO,CT,DC,DD,DI,DQ,DR,DS,EO,FA,FB,FC,FO,FT,HD,IA,IR,L1,L2,L3,L4,L5,L6,L7,LA,LE,LF,LM,LO,LS,LU,LW,LX,NE,OS,OT,PA,PC,PE,PM,PN,PR,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,RR,RT,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TN,TP,TR,UK,VO,XD,ZZ,")]
    public class X12_ID_584_5
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AO,AU,DI,PV,RU,")]
    public class X12_ID_584_6
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ACH,BKW,BOP,CAS,CCC,CCF,CCH,CDA,CHK,CLH,CPC,CWT,DCC,DCD,DDP,DEB,DLC,DLD,DXC,DXD," +
        "DYC,DYD,DZC,DZD,EBX,EXC,FEW,FWT,FXP,IWT,NON,PAC,PBD,PDC,PDD,PDE,PRO,QDR,QIR,REV," +
        "SCC,SCD,SDC,SDD,SWT,SXC,SXD,SYC,SZC,SZD,TRA,VIS,X12,ZZZ,")]
    public class X12_ID_591
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ACH,BOP,CHK,FWT,NON,SWT,")]
    public class X12_ID_591_2
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ACH,BOP,CHK,FWT,NON,")]
    public class X12_ID_591_3
    {
    }
    
    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,6,7,8,9,B,C,H,Q,S,U,")]
    public class X12_ID_594
    {
    }
    
    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,4,6,")]
    public class X12_ID_594_2
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,6,7,")]
    public class X12_ID_615
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,26,27,29,34,35,6,7,")]
    public class X12_ID_615_2
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",13,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,6,7,")]
    public class X12_ID_615_3
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,26,27,34,35,6,7,")]
    public class X12_ID_615_4
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,26,27,34,35,6,7,")]
    public class X12_ID_615_5
    {
    }
    
    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT" +
        ",CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,ND,NS,NT,PD,PS,PT,TD,TS,TT,UT,")]
    public class X12_ID_623
    {
    }
    
    /// <summary>
    /// Basis of Unit Price Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",AA,AB,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,EH,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RT,")]
    public class X12_ID_640
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,20,21,22,23,24,25" +
        ",26,27,28,30,31,33,34,35,36,37,38,39,3M,40,41,42,43,44,45,46,47,48,49,50,51,52,5" +
        "4,55,56,57,58,60,62,63,64,65,66,67,68,69,6A,6C,6N,6R,6S,70,71,72,73,74,75,76,77," +
        "78,79,80,81,82,83,85,87,88,89,91,94,95,97,98,99,A0,A1,A3,A4,A5,A6,A7,AA,AB,AC,AD" +
        ",AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS,AT,AV,AW,AZ,BA,BB,BD,BF,BG,BH,BJ,BK,B" +
        "L,BM,BN,BO,BP,BR,BS,BT,BU,BV,BW,BX,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD," +
        "CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D4,DA,DB,DC,DD" +
        ",DE,DF,DG,DH,DI,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,E1,EA,EB,EC,ED,EF,EI,EM,EP,ER,E" +
        "X,F1,F4,F5,F6,F7,F8,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FR,FS,FT,G1,G2,G3,GA,GI," +
        "GR,GS,GT,GU,GV,GW,GX,GY,HA,HB,HC,HD,HE,HF,HG,HP,HX,I1,IA,IB,IC,ID,IE,IF,II,IM,IN" +
        ",IO,IR,IU,IW,IX,IZ,JM,JO,JR,JS,JU,JX,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KS,K" +
        "T,LC,LD,LE,LF,LN,LO,LP,LR,LV,M1,MA,MB,MC,MD,ME,MF,MI,ML,MM,MP,MR,MS,MU,N1,N2,N3," +
        "N4,N5,N6,N7,N8,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NP,NQ,NR,NS,NT,NU,OC,OF" +
        ",OP,OR,P1,PA,PB,PC,PD,PE,PF,PG,PH,PI,PL,PM,PO,PP,PR,PS,PT,PU,PV,PW,PX,PZ,Q1,Q2,Q" +
        "A,QB,QC,QD,QE,QF,QG,QH,QJ,QK,QL,QP,QR,R1,R2,R3,R4,R5,R6,R7,R8,RA,RB,RC,RD,RE,RF," +
        "RG,RH,RI,RJ,RK,RM,RP,RQ,RS,RT,RU,RZ,S1,S2,S3,S4,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SO" +
        ",SP,SQ,SR,SS,ST,SU,SV,T1,T2,T3,T4,T5,T6,T7,T8,T9,TD,TF,TG,TH,TI,TJ,TK,TL,TP,TR,T" +
        "S,TT,TX,U1,U2,U4,U5,U9,UA,UC,UD,UF,UI,UM,UO,UP,UR,UT,V1,V2,V3,V4,VH,VJ,VL,VM,VN," +
        "VO,VP,VQ,VR,W1,W4,W5,WA,WC,WD,WH,WO,WS,WT,X1,XA,XB,XC,XD,XX,XY,XZ,YI,YR,Z1,Z2,Z3" +
        ",Z4,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,Z" +
        "Z,")]
    public class X12_ID_640_2
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DG,")]
    public class X12_ID_640_3
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",TH,")]
    public class X12_ID_640_4
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,19,AT,RU,")]
    public class X12_ID_640_5
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",31,CH,RP,")]
    public class X12_ID_640_6
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",RU,")]
    public class X12_ID_640_7
    {
    }
    
    /// <summary>
    /// Price Multiplier Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",CSD,CSR,DIS,ILP,PSP,SEL,")]
    public class X12_ID_648
    {
    }
    
    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659
    {
    }
    
    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659_2
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,FI,PI,PP,SV,XV,XX,")]
    public class X12_ID_66
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FI,XX,")]
    public class X12_ID_66_10
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",31,57,94,A3,A4,A6,CF,G,PA,")]
    public class X12_ID_66_11
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(@",0,1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,81,82,83,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AI,AL,AP,BC,BD,BE,BG,BN,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CP,CR,CS,CT,D,DG,DL,DN,DO,DP,DR,DS,E,EC,EH,EI,EL,EP,EQ,ER,ES,ET,F,FA,FB,FC,FD,FE,FI,FJ,FL,FN,G,GA,GC,HC,HN,HS,I,ID,II,IP,J,K,L,LC,LD,LE,LI,LN,M,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MO,MP,MR,N,NA,ND,NI,NO,NR,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RI,RP,RT,S,SA,SB,SD,SF,SI,SJ,SK,SL,SP,ST,SV,SW,TA,TC,TL,TS,TZ,UC,UI,UL,UP,UR,US,UT,WR,WS,X1,XV,XX,XY,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66_12
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",34,HN,II,MI,MR,")]
    public class X12_ID_66_13
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,FA,FI,II,MI,NI,PI,PP,SV,XV,XX,")]
    public class X12_ID_66_14
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,II,MI,")]
    public class X12_ID_66_15
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AC,")]
    public class X12_ID_66_16
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,24,9,FI,")]
    public class X12_ID_66_17
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",34,ZZ,")]
    public class X12_ID_66_18
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FI,II,MI,")]
    public class X12_ID_66_19
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",46,")]
    public class X12_ID_66_2
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_20
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",MI,ZZ,")]
    public class X12_ID_66_21
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,PI,XV,XX,")]
    public class X12_ID_66_22
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",LD,LE,")]
    public class X12_ID_66_23
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,")]
    public class X12_ID_66_24
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",34,EI,II,")]
    public class X12_ID_66_25
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,")]
    public class X12_ID_66_26
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BD,BS,FI,MC,PC,SL,UP,XX,")]
    public class X12_ID_66_27
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",34,EI,N,")]
    public class X12_ID_66_28
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",34,FI,SV,XX,")]
    public class X12_ID_66_29
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,XX,")]
    public class X12_ID_66_3
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,FI,NI,PI,PP,XV,")]
    public class X12_ID_66_30
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FI,NI,XV,")]
    public class X12_ID_66_31
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,46,FI,NI,PI,XV,XX,")]
    public class X12_ID_66_32
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",46,FI,PI,XV,")]
    public class X12_ID_66_33
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,PI,XV,")]
    public class X12_ID_66_34
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,9,EQ,FI,XV,")]
    public class X12_ID_66_35
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,94,FI,")]
    public class X12_ID_66_36
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",XV,")]
    public class X12_ID_66_37
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,XV,XX,")]
    public class X12_ID_66_38
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",II,MI,")]
    public class X12_ID_66_39
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,24,75,9,EQ,FI,PI,")]
    public class X12_ID_66_4
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(@",0,1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,81,82,83,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AI,AL,AP,BC,BD,BE,BG,BN,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CP,CR,CS,CT,D,DG,DL,DN,DO,DP,DR,DS,E,EC,EH,EI,EL,EP,EQ,ER,ES,ET,F,FA,FB,FC,FD,FE,FI,FJ,FL,FN,G,GA,GC,HC,HN,HS,I,ID,II,IP,J,K,L,LC,LD,LE,LI,LN,M,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MO,MP,MR,N,NA,ND,NI,NO,NR,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RI,RP,RT,S,SA,SB,SD,SF,SI,SJ,SK,SL,SP,ST,SV,SW,TA,TC,TL,TS,TZ,UC,UI,UL,UP,UR,US,UT,WR,WS,X1,XV,XX,XY,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66_40
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AC,")]
    public class X12_ID_66_41
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,XX,")]
    public class X12_ID_66_42
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",24,34,46,PI,XV,")]
    public class X12_ID_66_43
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",94,FI,XV,")]
    public class X12_ID_66_5
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FI,XV,XX,")]
    public class X12_ID_66_6
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",XX,")]
    public class X12_ID_66_7
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",II,MI,")]
    public class X12_ID_66_8
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FI,SV,XX,")]
    public class X12_ID_66_9
    {
    }
    
    /// <summary>
    /// Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,D,I,O,S,")]
    public class X12_ID_662
    {
    }
    
    /// <summary>
    /// Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",O,")]
    public class X12_ID_662_2
    {
    }
    
    /// <summary>
    /// Currency Market/Exchange Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class X12_ID_669
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DY,FL,HS,MN,VS,")]
    public class X12_ID_673
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",CA,CD,LA,LE,NE,NR,OU,PS,VS,ZK,ZL,ZM,ZN,ZO,")]
    public class X12_ID_673_10
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PT,")]
    public class X12_ID_673_11
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DY,FL,HS,MN,VS,")]
    public class X12_ID_673_12
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,")]
    public class X12_ID_673_2
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZK,ZL,ZM,ZN,ZO,")]
    public class X12_ID_673_3
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FL,")]
    public class X12_ID_673_4
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",QA,")]
    public class X12_ID_673_5
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_673_6
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",8H,99,CA,CE,D3,DB,DY,HS,LA,LE,M2,MN,P6,QA,S7,S8,VS,YY,")]
    public class X12_ID_673_7
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",90,")]
    public class X12_ID_673_8
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DT,ET,TO,")]
    public class X12_ID_673_9
    {
    }
    
    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SA,SB,SC,SD,SG,SL,SP,SX,SY" +
        ",SZ,T,U,V,W,X,Y,")]
    public class X12_ID_678
    {
    }
    
    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SG,SL,SP,SX,SY,SZ,T,U,V,W," +
        "X,Y,")]
    public class X12_ID_678_2
    {
    }
    
    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SA,SB,SC,SD,SG,SL,SP,SX,SY" +
        ",SZ,T,U,V,W,WE,X,Y,")]
    public class X12_ID_678_3
    {
    }
    
    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SA,SB,SC,SD,SG,SL,SP,SX,SY" +
        ",SZ,T,U,V,W,X,Y,")]
    public class X12_ID_678_4
    {
    }
    
    /// <summary>
    /// Ship/Delivery Pattern Time Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,Y,")]
    public class X12_ID_679
    {
    }
    
    /// <summary>
    /// Ship/Delivery Pattern Time Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,Y,")]
    public class X12_ID_679_2
    {
    }
    
    /// <summary>
    /// Class of Trade Code
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704
    {
    }
    
    /// <summary>
    /// Paperwork/Report Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704_2
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,27,41,48,65,72,")]
    public class X12_ID_706
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",25,26,72,")]
    public class X12_ID_706_2
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,CP,OP,PI,")]
    public class X12_ID_706_3
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,CP,OP,PI,")]
    public class X12_ID_706_4
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,")]
    public class X12_ID_735
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",22,")]
    public class X12_ID_735_10
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",23,")]
    public class X12_ID_735_11
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",EV,")]
    public class X12_ID_735_12
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",SS,")]
    public class X12_ID_735_13
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",20,")]
    public class X12_ID_735_14
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",22,")]
    public class X12_ID_735_2
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",19,")]
    public class X12_ID_735_3
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",23,")]
    public class X12_ID_735_4
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PT,")]
    public class X12_ID_735_5
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",EV,")]
    public class X12_ID_735_6
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",SS,")]
    public class X12_ID_735_7
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",20,")]
    public class X12_ID_735_8
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",21,")]
    public class X12_ID_735_9
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_736_2
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_736_3
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736_4
    {
    }
    
    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_736_5
    {
    }
    
    /// <summary>
    /// Measurement Reference ID Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",OG,TR,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HT,R1,R2,R3,R4,")]
    public class X12_ID_738
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1S,2S,A1,A2,A3,A4,A5,A6,A7,A8,A9,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF,")]
    public class X12_ID_752
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",CT,")]
    public class X12_ID_755_2
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,48,55,59,77,A3,A4,AM,AS,AT,B2,B3,BR,BS,BT,CB" +
        ",CK,D2,DA,DB,DG,DJ,DS,FM,HC,HR,I5,IR,LA,M1,NN,OB,OC,OD,OE,OX,P4,P5,P6,P7,PE,PN,P" +
        "O,PQ,PY,PZ,QC,QR,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_3
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",B4,DA,DG,EB,OZ,P6,RB,RR,")]
    public class X12_ID_755_4
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,77,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2" +
        ",DA,DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,P" +
        "Y,PZ,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_5
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,48,55,59,77,A3,A4,AM,AS,AT,B2,B3,BR,BS,BT,CB" +
        ",CK,D2,DA,DB,DG,DJ,DS,FM,HC,HR,I5,IR,LA,M1,NN,OB,OC,OD,OE,OX,P4,P5,P6,P7,PE,PN,P" +
        "O,PQ,PY,PZ,QC,QR,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_6
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BM,EL,EM,FX,VO,")]
    public class X12_ID_756_2
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BM,EM,FT,FX,IA,OL,")]
    public class X12_ID_756_3
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BM,EM,FT,OL,")]
    public class X12_ID_756_4
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,BM,EL,EM,FT,FX,")]
    public class X12_ID_756_5
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,BM,EL,EM,FX,VO,")]
    public class X12_ID_756_6
    {
    }
    
    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,ZZ,")]
    public class X12_ID_786
    {
    }
    
    /// <summary>
    /// Payment Format Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CCP,CTX,")]
    public class X12_ID_812
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,002,021,024,025,026,030,032,")]
    public class X12_ID_875
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,028,029,030,031,032,033,050,051,052,053,054,055,056,057,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,100,101,102,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,CEP,PRI,TBV,ZZZ,")]
    public class X12_ID_875_2
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,")]
    public class X12_ID_875_3
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,021,024,025,030,")]
    public class X12_ID_875_4
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,028,029,030,031,032,033,050,051,052,053,054,055,056,057,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,100,101,102,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,CEP,PRI,TBV,ZZZ,")]
    public class X12_ID_875_5
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,P,R,S,W,X,Y,")]
    public class X12_ID_889
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,P,Y,")]
    public class X12_ID_889_2
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,R,S,W,X,Y,")]
    public class X12_ID_889_3
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,R,")]
    public class X12_ID_889_4
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,R,W,X,Y,")]
    public class X12_ID_889_5
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,")]
    public class X12_ID_889_6
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,P,R,S,Y,")]
    public class X12_ID_889_7
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",C,N,P,Y,")]
    public class X12_ID_889_8
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",04,41,42,79,80,T4,")]
    public class X12_ID_901
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,52,56,57,60,61,62,AA,AF,AH,AI,AJ,AK,AM,AN,T5,")]
    public class X12_ID_901_10
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,35,41,43,44,45,46,47,49,51,52,79,97,IP,")]
    public class X12_ID_901_11
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,47,97,")]
    public class X12_ID_901_12
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,52,57,60,61,62,AA,AG,T5,")]
    public class X12_ID_901_13
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",04,41,42,79,")]
    public class X12_ID_901_14
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",T1,T2,T3,T4,T5,T6,")]
    public class X12_ID_901_15
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",42,79,80,T4,")]
    public class X12_ID_901_2
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,41,43,44,45,46,47,48,50,51,79,97,T4,")]
    public class X12_ID_901_3
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,35,41,43,44,45,46,47,49,51,79,97,")]
    public class X12_ID_901_4
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,35,42,43,45,47,48,49,51,52,56,57,58,60,61,62,63,71,72,73,74,75,76,78,")]
    public class X12_ID_901_5
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",58,64,65,66,67,68,71,72,73,74,75,76,77,78,79,95,")]
    public class X12_ID_901_6
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,52,53,54,55,56,57,60,61,62,63,69,70,98,AA,AE,AF,AG,AO,CI,E8,IA,MA,")]
    public class X12_ID_901_7
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,33,58,64,65,66,67,68,71,77,95,")]
    public class X12_ID_901_8
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",15,35,42,43,45,47,48,49,51,52,56,57,58,60,61,62,63,64,65,66,67,68,71,77,")]
    public class X12_ID_901_9
    {
    }
    
    /// <summary>
    /// Prognosis Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_923
    {
    }
    
    /// <summary>
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AT,DS,LC,NP,NS,SS,")]
    public class X12_ID_934
    {
    }
    
    /// <summary>
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AA,AT,DS,LC,NP,NS,SS,")]
    public class X12_ID_934_2
    {
    }
    
    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,ZZ,")]
    public class X12_ID_935
    {
    }
    
    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
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
    [EdiCodes(",S3,")]
    public class X12_ID_98
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1X,3D,80,FA,OD,P3,QA,QN,Y2,")]
    public class X12_ID_98_10
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PW,")]
    public class X12_ID_98_11
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,")]
    public class X12_ID_98_12
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_13
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DN,")]
    public class X12_ID_98_14
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",36,GW,IN,")]
    public class X12_ID_98_15
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_16
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_98_17
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DK,")]
    public class X12_ID_98_18
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
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
    public class X12_ID_98_19
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",82,")]
    public class X12_ID_98_2
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,2B,36,80,FA,GP,P5,PR,")]
    public class X12_ID_98_20
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",41,")]
    public class X12_ID_98_21
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,FA,")]
    public class X12_ID_98_22
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_98_23
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IN,")]
    public class X12_ID_98_24
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",40,")]
    public class X12_ID_98_25
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_26
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",41,AY,PR,")]
    public class X12_ID_98_27
    {
    }
    
    [Serializable()]
    [EdiCodes(",36,40,41,AY,PR,")]
    public class X12_ID_98_28
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_29
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",72,")]
    public class X12_ID_98_3
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BO,TV,")]
    public class X12_ID_98_30
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",85,")]
    public class X12_ID_98_31
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,")]
    public class X12_ID_98_32
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",13,1I,1P,2B,36,73,FA,GP,GW,I3,IL,LR,OC,P3,P4,P5,PR,PRP,SEP,TTP,VER,VN,VY,X3,Y2,")]
    public class X12_ID_98_33
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",04,0B,8W,AK,BE,BK,C1,C2,IAT,MJ,RB,Z6,ZB,ZL,")]
    public class X12_ID_98_34
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",74,IL,")]
    public class X12_ID_98_35
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",87,")]
    public class X12_ID_98_36
    {
    }
    
    [Serializable()]
    [EdiCodes(",36,40,41,77,82,85,87,AY,PR,")]
    public class X12_ID_98_37
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,72,73,77,AAJ,DD,DK,DN,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_38
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2L,AG,NH,RGA,UN,")]
    public class X12_ID_98_39
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",6Y,9K,E1,EI,EXS,GB,GD,J6,LR,QD,S1,TZ,X4,")]
    public class X12_ID_98_4
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_98_40
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",74,")]
    public class X12_ID_98_41
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,77,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X4,X5,ZZ,")]
    public class X12_ID_98_42
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",L5,")]
    public class X12_ID_98_43
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2J,")]
    public class X12_ID_98_44
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",31,")]
    public class X12_ID_98_45
    {
    }
    
    [Serializable()]
    [EdiCodes(",03,1P,1Z,40,41,71,72,73,77,82,85,87,DK,DN,DQ,FA,GB,HK,IL,LI,MSC,PR,PRP,QB,QC,QD," +
        "SEP,TL,TTP,TU,")]
    public class X12_ID_98_46
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",45,FS,ND,PW,R3,")]
    public class X12_ID_98_47
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DO,EY,IL,QE,")]
    public class X12_ID_98_48
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",36,")]
    public class X12_ID_98_49
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",77,")]
    public class X12_ID_98_5
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",TT,")]
    public class X12_ID_98_50
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",72,73,77,DD,DK,DQ,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_51
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",M8,")]
    public class X12_ID_98_52
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",GB,")]
    public class X12_ID_98_53
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_54
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,")]
    public class X12_ID_98_55
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,36,GP,P5,PR,")]
    public class X12_ID_98_56
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AY,PR,")]
    public class X12_ID_98_57
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,36,PR,X3,")]
    public class X12_ID_98_58
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,PR,")]
    public class X12_ID_98_59
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_98_6
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",P5,")]
    public class X12_ID_98_60
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
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
    public class X12_ID_98_61
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,2B,36,FA,PR,")]
    public class X12_ID_98_62
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_63
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_64
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,72,73,77,AAJ,DD,DK,DN,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_65
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",45,FS,ND,PW,R3,")]
    public class X12_ID_98_66
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,CA,GG,")]
    public class X12_ID_98_67
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1T,72,73,77,DD,DK,DQ,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_68
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,36,PR,X3,")]
    public class X12_ID_98_69
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",45,")]
    public class X12_ID_98_7
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DD,")]
    public class X12_ID_98_8
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_9
    {
    }
    
    [Serializable()]
    public class X12_N0
    {
    }
    
    [Serializable()]
    public class X12_N2
    {
    }
    
    [Serializable()]
    public class X12_R
    {
    }
    
    [Serializable()]
    public class X12_TM
    {
    }
}
