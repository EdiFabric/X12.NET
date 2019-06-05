namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    /// <summary>
    /// Number of Included Segments
    /// </summary>
    [Serializable()]
    public class @string
    {
    }
    
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
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL" +
        ",CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032
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
    [EdiCodes(",N,")]
    public class X12_ID_1073_2
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_3
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,W,Y,")]
    public class X12_ID_1073_4
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_5
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,")]
    public class X12_ID_1073_6
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_7
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
    [EdiCodes(",75,")]
    public class X12_ID_1136_10
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",76,")]
    public class X12_ID_1136_11
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",77,")]
    public class X12_ID_1136_12
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_13
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
    [EdiCodes(",07,")]
    public class X12_ID_1136_6
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",08,")]
    public class X12_ID_1136_7
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",09,")]
    public class X12_ID_1136_8
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,")]
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
    /// Disability Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1146
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
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,ECH,ESP,FAM,IND,SPC,SPO,")]
    public class X12_ID_1207
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",CHD,DEP,ECH,EMP,ESP,FAM,IND,SPC,SPO,")]
    public class X12_ID_1207_2
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
    /// Identification Card Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",D,H,P,")]
    public class X12_ID_1215
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
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",TM,")]
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
    [EdiCodes(",D8,DT,")]
    public class X12_ID_1250_4
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_5
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_6
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_7
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
    [EdiCodes(",ABF,ABJ,APR,BF,BJ,DR,LOI,PR,")]
    public class X12_ID_1270_10
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABK,BK,TQ,")]
    public class X12_ID_1270_11
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABJ,BJ,")]
    public class X12_ID_1270_12
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1270_13
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",GR,NI,ZZ,")]
    public class X12_ID_1270_14
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,BF,TQ,")]
    public class X12_ID_1270_15
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",APR,PR,")]
    public class X12_ID_1270_16
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BP,")]
    public class X12_ID_1270_17
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",LOI,")]
    public class X12_ID_1270_18
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABN,BN,")]
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
    [EdiCodes(",BO,")]
    public class X12_ID_1270_20
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DR,")]
    public class X12_ID_1270_21
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AS,UT,")]
    public class X12_ID_1270_22
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BBR,BR,CAH,")]
    public class X12_ID_1270_23
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BBQ,BQ,")]
    public class X12_ID_1270_24
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HE,RX,")]
    public class X12_ID_1270_25
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
    public class X12_ID_1270_26
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,ABK,APR,BF,BJ,BK,DR,PR,")]
    public class X12_ID_1270_27
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,ABJ,APR,BF,BJ,DR,PR,")]
    public class X12_ID_1270_28
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",JP,")]
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
    [EdiCodes(",ABF,ABJ,ABK,APR,BF,BJ,BK,DR,LOI,PR,")]
    public class X12_ID_1270_7
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",JP,")]
    public class X12_ID_1270_8
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABF,BF,")]
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
    [EdiCodes(",EI,SY,")]
    public class X12_ID_128_20
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EI,")]
    public class X12_ID_128_21
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,G2,LU,")]
    public class X12_ID_128_22
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",G4,")]
    public class X12_ID_128_23
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,G2,LU,")]
    public class X12_ID_128_24
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",T4,")]
    public class X12_ID_128_25
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",6R,")]
    public class X12_ID_128_26
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1J,")]
    public class X12_ID_128_27
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,G2,LU,")]
    public class X12_ID_128_28
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1W,SY,")]
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
    [EdiCodes(",9B,")]
    public class X12_ID_128_30
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9D,")]
    public class X12_ID_128_31
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",VY,XZ,")]
    public class X12_ID_128_32
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128_33
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BLT,")]
    public class X12_ID_128_34
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1K,")]
    public class X12_ID_128_35
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,1L,CT,IK,")]
    public class X12_ID_128_36
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0F,")]
    public class X12_ID_128_37
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F2,")]
    public class X12_ID_128_38
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",F4,")]
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
    [EdiCodes(",BT,")]
    public class X12_ID_128_40
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,3H,6P,CT,EA,EJ,F6,GH,HJ,IG,N6,NQ,SY,Y4,")]
    public class X12_ID_128_41
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,3H,49,6P,CE,CT,EA,EJ,F6,GH,HJ,IF,IG,N6,NQ,Q4,SY,Y4,")]
    public class X12_ID_128_42
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,")]
    public class X12_ID_128_43
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,3L,6P,DP,EJ,F6,HJ,IG,N6,NQ,SY,")]
    public class X12_ID_128_44
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,17,18,2F,38,E9,LB,LU,ZZ,")]
    public class X12_ID_128_45
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,")]
    public class X12_ID_128_46
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,EO,HI,NF,")]
    public class X12_ID_128_47
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,")]
    public class X12_ID_128_48
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,FY,NF,")]
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
    [EdiCodes(",9K,D3,EI,HPI,PXC,SY,TJ,")]
    public class X12_ID_128_50
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,49,6P,9F,ALS,CLI,F6,FO,G1,IG,M7,N6,NQ,")]
    public class X12_ID_128_51
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",6P,")]
    public class X12_ID_128_52
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",XZ,")]
    public class X12_ID_128_53
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,SY,")]
    public class X12_ID_128_54
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",11,9J,AZ,B7,CT,ID,IG,IK,KW,")]
    public class X12_ID_128_55
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",17,23,3H,4A,6O,ABB,D3,DX,F6,P5,Q4,QQ,ZZ,")]
    public class X12_ID_128_56
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,D3,PQ,TJ,")]
    public class X12_ID_128_57
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",SY,")]
    public class X12_ID_128_58
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",9F,G1,")]
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
    [EdiCodes(",18,1L,1W,49,6P,CE,CT,EA,EJ,F6,GH,HJ,IF,IG,MRC,N6,NQ,Q4,SY,Y4,")]
    public class X12_ID_128_60
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",VV,")]
    public class X12_ID_128_61
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",FJ,")]
    public class X12_ID_128_62
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",NT,")]
    public class X12_ID_128_63
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,18,2F,38,E9,LU,ZZ,")]
    public class X12_ID_128_64
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",17,1L,9V,CE,E8,M7,PID,RB,X9,XM,XX1,XX2,ZX,ZZ,")]
    public class X12_ID_128_65
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,1W,28,6P,9A,9C,BB,CE,EA,F8,G1,G3,IG,SY,")]
    public class X12_ID_128_66
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_67
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,6P,CT,EA,EJ,F6,GH,HJ,IF,IG,MRC,N6,SY,Y4,")]
    public class X12_ID_128_68
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",18,1L,1W,49,6P,9F,ALS,CLI,F6,FO,G1,IG,N6,NQ,")]
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
    [EdiCodes(",BB,")]
    public class X12_ID_128_70
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",QQ,")]
    public class X12_ID_128_71
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,1J,D3,G2,LU,")]
    public class X12_ID_128_72
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",2U,EI,FY,NF,")]
    public class X12_ID_128_73
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,1J,EI,N5,N7,SY,ZH,")]
    public class X12_ID_128_74
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",60,6P,SY,ZZ,")]
    public class X12_ID_128_75
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1S,APC,BB,E9,G1,G3,LU,RB,")]
    public class X12_ID_128_76
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_77
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,17,18,19,26,3L,6M,9V,9X,GE,LU,PID,XX1,XX2,YY,ZZ,")]
    public class X12_ID_128_78
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",0B,1C,1D,1J,4A,CT,EL,EO,HPI,JD,N5,N7,Q4,SY,TJ,")]
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
    [EdiCodes(",0B,1G,G2,LU,SY,TJ,")]
    public class X12_ID_128_80
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_81
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",14,17,18,2F,38,72,LB,")]
    public class X12_ID_128_82
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",38,")]
    public class X12_ID_128_83
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EV,")]
    public class X12_ID_128_84
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128_85
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1L,3L,6P,DP,EJ,F6,HJ,IG,N6,NQ,SY,")]
    public class X12_ID_128_86
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EJ,SY,")]
    public class X12_ID_128_87
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",BB,")]
    public class X12_ID_128_88
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",NT,")]
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
    [EdiCodes(",0B,1G,1J,EI,N5,N7,SY,ZH,")]
    public class X12_ID_128_90
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_91
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",1G,1J,EI,G5,N5,N7,SY,ZH,")]
    public class X12_ID_128_92
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
    [EdiCodes(",1,2,3,4,I,N,R,S,")]
    public class X12_ID_1322_2
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322_3
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,I,N,R,S,")]
    public class X12_ID_1322_4
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,I,N,R,S,")]
    public class X12_ID_1322_5
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
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365
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
    /// Claim Submission Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
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
    /// Eligibility or Benefit Information Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,CB,D,E,F,G,H,I,J,K,L,M,MC,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_1390
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
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HS,SC,")]
    public class X12_ID_1525
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,HS,IN,SC,")]
    public class X12_ID_1525_2
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",HS,SC,")]
    public class X12_ID_1525_3
    {
    }
    
    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AR,HS,IN,SC,")]
    public class X12_ID_1525_4
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,IV,N4,WK,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,N4,NU,WK,")]
    public class X12_ID_235_10
    {
    }
    
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,NU,WK,")]
    public class X12_ID_235_11
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,ER,HC,HP,IV,N4,N6,NU,UI,WK,")]
    public class X12_ID_235_12
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,IV,N4,WK,")]
    public class X12_ID_235_13
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,ID,IV,N4,WK,ZZ,")]
    public class X12_ID_235_14
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,")]
    public class X12_ID_235_15
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,")]
    public class X12_ID_235_2
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ER,HC,HP,IV,WK,")]
    public class X12_ID_235_3
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ER,HC,IV,WK,")]
    public class X12_ID_235_4
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,ID,IV,N4,WK,ZZ,")]
    public class X12_ID_235_5
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",N4,")]
    public class X12_ID_235_6
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",HC,")]
    public class X12_ID_235_7
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",EN,EO,HI,N4,ON,UK,UP,")]
    public class X12_ID_235_8
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AD,CJ,HC,ID,IV,N4,ZZ,")]
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
    [EdiCodes(",A1,A3,A4,A6,C,CT,NA,")]
    public class X12_ID_306
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_306_2
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",A1,A2,A3,A4,A6,C,CT,NA,")]
    public class X12_ID_306_3
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
    [EdiCodes(",LB,")]
    public class X12_ID_355_2
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DA,")]
    public class X12_ID_355_3
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",MO,")]
    public class X12_ID_355_4
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",KG,LB,")]
    public class X12_ID_355_5
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
    [EdiCodes(",007,090,091,303,382,388,")]
    public class X12_ID_374_51
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",484,")]
    public class X12_ID_374_52
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",ABC,")]
    public class X12_ID_374_53
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_54
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",AAH,")]
    public class X12_ID_374_55
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",435,")]
    public class X12_ID_374_56
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",096,")]
    public class X12_ID_374_57
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",598,")]
    public class X12_ID_374_58
    {
    }
    
    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",472,")]
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
    [EdiCodes(",439,")]
    public class X12_ID_374_60
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
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",20,52,53,AA,AX,H1,H6,IA,J3,")]
    public class X12_ID_426
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",52,53,80,81,86,BJ,H1,H6,RU,WO,")]
    public class X12_ID_426_2
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",52,53,80,81,86,BJ,H1,H6,RU,WO,WW,")]
    public class X12_ID_426_3
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
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AE,AO,AS,AT,AU,CC,DD,HD,IR,LX,PE,RE,RM,RR,RU,")]
    public class X12_ID_584
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
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",LD,LE,")]
    public class X12_ID_66
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
    [EdiCodes(",PT,")]
    public class X12_ID_673_10
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DY,FL,HS,MN,VS,")]
    public class X12_ID_673_11
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
    [EdiCodes(",90,")]
    public class X12_ID_673_7
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",DT,ET,TO,")]
    public class X12_ID_673_8
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [EdiCodes(",CA,CD,LA,LE,NE,NR,OU,PS,VS,ZK,ZL,ZM,ZN,ZO,")]
    public class X12_ID_673_9
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
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",001,002,021,024,025,026,030,032,")]
    public class X12_ID_875
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
    /// Prognosis Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_923_2
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
    [EdiCodes(",1P,2B,36,80,FA,GP,P5,PR,")]
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
    [EdiCodes(",41,")]
    public class X12_ID_98_20
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,FA,")]
    public class X12_ID_98_21
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_98_22
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IN,")]
    public class X12_ID_98_23
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",40,")]
    public class X12_ID_98_24
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_25
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_26
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",BO,TV,")]
    public class X12_ID_98_27
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",85,")]
    public class X12_ID_98_28
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",03,")]
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
    [EdiCodes(",13,1I,1P,2B,36,73,FA,GP,GW,I3,IL,LR,OC,P3,P4,P5,PR,PRP,SEP,TTP,VER,VN,VY,X3,Y2,")]
    public class X12_ID_98_30
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",04,0B,8W,AK,BE,BK,C1,C2,IAT,MJ,RB,Z6,ZB,ZL,")]
    public class X12_ID_98_31
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",74,IL,")]
    public class X12_ID_98_32
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",87,")]
    public class X12_ID_98_33
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,72,73,77,AAJ,DD,DK,DN,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_34
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2L,AG,NH,RGA,UN,")]
    public class X12_ID_98_35
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_98_36
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",74,")]
    public class X12_ID_98_37
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",L5,")]
    public class X12_ID_98_38
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2J,")]
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
    [EdiCodes(",31,")]
    public class X12_ID_98_40
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",45,FS,ND,PW,R3,")]
    public class X12_ID_98_41
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DO,EY,IL,QE,")]
    public class X12_ID_98_42
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",36,")]
    public class X12_ID_98_43
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",TT,")]
    public class X12_ID_98_44
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",72,73,77,DD,DK,DQ,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_45
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",M8,")]
    public class X12_ID_98_46
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",GB,")]
    public class X12_ID_98_47
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_48
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,")]
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
    [EdiCodes(",2B,36,GP,P5,PR,")]
    public class X12_ID_98_50
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",AY,PR,")]
    public class X12_ID_98_51
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,36,PR,X3,")]
    public class X12_ID_98_52
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,PR,")]
    public class X12_ID_98_53
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",P5,")]
    public class X12_ID_98_54
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1P,2B,36,FA,PR,")]
    public class X12_ID_98_55
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_56
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_57
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",71,72,73,77,AAJ,DD,DK,DN,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_58
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",45,FS,ND,PW,R3,")]
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
    [EdiCodes(",00,CA,GG,")]
    public class X12_ID_98_60
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",1T,72,73,77,DD,DK,DQ,FA,G3,P3,QB,QV,SJ,")]
    public class X12_ID_98_61
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [EdiCodes(",2B,36,PR,X3,")]
    public class X12_ID_98_62
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
    public class X12_R
    {
    }
}
