namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    /// <summary>
    /// Car Hire Detail/Summary Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,9,")]
    public class X12_ID_1002
    {
    }
    
    /// <summary>
    /// Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,05,06,07,08,09,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AR,AT,B,BA,BB,BC,BD,BE,BF,BG,BH,BP,BS,BU,C,CA,CB,CH,CJ,CN,CO,CP,CR,CS,CU,D,DF,DY,E,EA,EF,EP,F,FT,FV,GA,IA,IN,KA,KB,LM,M,MA,MN,MS,MX,N,NA,NH,O,OC,OF,OH,OP,P,PA,PC,PD,PF,PH,PM,PN,PP,PR,PT,PV,R,RA,RB,RC,RD,RF,RG,RI,RL,RO,RP,RQ,RR,RS,S,SA,SC,SD,SE,SF,SG,T,TP,W,WI,WK,X,X1,XT,")]
    public class X12_ID_1004
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0001,0002,0003,0004,0010,0011,0012,0013,0014,0015,0016,0017,0018,0019,0020,0021,0022,0023,0035,0036,0055,0056,0057,0058,0059,0060,0061,0062,0063,0064,0065,0066,0067,0068,0069,0070,0071,0072,0073,0074,0075,0076,0077,0078,0079,0080,0081,0082,0083,0200,0201,0202,0203,0204,0205,0206,0207,0208,0209,0210,ZZZZ,")]
    public class X12_ID_1005
    {
    }
    
    /// <summary>
    /// Account Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,6,7,8,9,AA,")]
    public class X12_ID_1006
    {
    }
    
    /// <summary>
    /// Rate Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,T,U,")]
    public class X12_ID_1007
    {
    }
    
    /// <summary>
    /// Case Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,12,13,30,6,7,9,AA,AG,AP,AR,CR,CV,DO,FB,JV,LC,MS,NT,OT,PC,SR,SV,TR,XX,ZZ,")]
    public class X12_ID_1008
    {
    }
    
    /// <summary>
    /// Administration of Justice Organization Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AB,AD,AG,AJ,AL,AM,AS,B,C,CA,CB,CH,CI,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CV,CY,D,DA,DI," +
        "DJ,DM,DO,DS,F,FC,GS,HO,HP,HU,I,IC,J,JC,JP,JU,LA,LE,M,M1,M2,M3,MA,MC,MP,MU,MY,OR," +
        "OT,P,PC,PK,PL,PO,PP,PR,PS,S,SA,SB,SC,SD,SH,SJ,SO,SP,SR,SS,ST,SU,T,TA,TB,TJ,TO,TR" +
        ",U,V,WA,X,ZZ,")]
    public class X12_ID_1009
    {
    }
    
    /// <summary>
    /// Administration of Justice Event Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AC,AS,C,CL,D,DO,H,I,M,N,O,OP,OR,OT,P,PA,PD,PE,PY,S,SJ,SU,TR,W,ZZZ,")]
    public class X12_ID_1012
    {
    }
    
    /// <summary>
    /// Notice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,101,11B,11I,12B,12I,12N,12Y,13B,13I,13N,13P,13Y,18J,18O,2,23A,23B,24B,25,26,27,28,3,305,306,308,309,310,311,315,4,417,5,603,610,611,612,616,619,621,623,625,628,629,630,631,638,642,70,700,701,7BA,7IA,9A,9B,9C,9D,9E,9F,9G,9H,9I,AB,CJ,CP,DEF,DIS,DJ,DOT,FAM,FCL,FFS,FJ,ITB,JC,JN,NOA,OCP,ODC,OFR,POC,SCH,SJ,YJ,ZZZ,")]
    public class X12_ID_1013
    {
    }
    
    /// <summary>
    /// Mileage Settlement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,7,9,")]
    public class X12_ID_1015
    {
    }
    
    /// <summary>
    /// Penalty Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,")]
    public class X12_ID_1016
    {
    }
    
    /// <summary>
    /// Claim Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AL,AR,BG,BM,BO,BP,BR,BS,BT,BW,C,CH,CM,DA,DB,EB,EU,GC,HL,I,JL,MG,ML,NF,OL,OP,P," +
        "PA,PB,PC,PD,PE,PF,PK,PO,PP,PT,PW,PZ,R,SM,SO,SR,SS,T,TC,TL,TR,TX,U,VT,WP,")]
    public class X12_ID_1017
    {
    }
    
    /// <summary>
    /// Invoice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IBM,IEL,INR,")]
    public class X12_ID_1019
    {
    }
    
    /// <summary>
    /// Ownership Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,R,S,T,")]
    public class X12_ID_102
    {
    }
    
    /// <summary>
    /// Sampling Sequence Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",GC,SU,UP,")]
    public class X12_ID_1020
    {
    }
    
    /// <summary>
    /// Hazard Zone Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class X12_ID_1023
    {
    }
    
    /// <summary>
    /// Loading or Discharge Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,R,")]
    public class X12_ID_1025
    {
    }
    
    /// <summary>
    /// Vessel Material Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,ALU,CST,FBG,NIK,SST,TTN,")]
    public class X12_ID_1026
    {
    }
    
    /// <summary>
    /// Claim Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",AD,AP,CC,CL,CP,I,RA,RB,RC,RD,RO,")]
    public class X12_ID_1029
    {
    }
    
    /// <summary>
    /// Gasket Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,ASB,BUN,BUT,EPD,FDA,HYP,KAL,LEA,NAT,NEO,SAN,TEF,VIT,")]
    public class X12_ID_1030
    {
    }
    
    /// <summary>
    /// Trailer Lining Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,BUT,CER,CHL,DER,HAL,HER,KYN,NAT,NIC,POL,TEF,VIT,")]
    public class X12_ID_1031
    {
    }
    
    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,AM,BL,CH,CI,CN" +
        ",DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032
    {
    }
    
    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CR,DE,MA,NC,OA,PI,PR,")]
    public class X12_ID_1033
    {
    }
    
    /// <summary>
    /// Type of Bankruptcy Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_104
    {
    }
    
    /// <summary>
    /// Load or Device Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,BL,BS,PS,PU,")]
    public class X12_ID_1042
    {
    }
    
    /// <summary>
    /// Hose Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAM,ACD,CEM,CRO,FDA,GAL,HOT,LIQ,NIR,NIT,PUR,SST,TEF,VIT,")]
    public class X12_ID_1044
    {
    }
    
    /// <summary>
    /// Inlet or Outlet Material Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,BR,IR,NS,SS,")]
    public class X12_ID_1045
    {
    }
    
    /// <summary>
    /// Inlet or Outlet Fitting Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,DF,DM,QF,QM,TH,TM,")]
    public class X12_ID_1046
    {
    }
    
    /// <summary>
    /// Miscellaneous Equipment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AF,AI,CY,DB,DR,ME,ND,NO,PR,SC,SE,VI,")]
    public class X12_ID_1047
    {
    }
    
    /// <summary>
    /// Business Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",COL,CON,DBT,PCS,PEN,PRL,TAX,VEN,")]
    public class X12_ID_1048
    {
    }
    
    /// <summary>
    /// Market Exchange Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LX1,LX2,")]
    public class X12_ID_1053
    {
    }
    
    /// <summary>
    /// Commodity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AG,AU,PT,")]
    public class X12_ID_1054
    {
    }
    
    /// <summary>
    /// Vehicle Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AF,BK,CB,CC,CL,CS,DP,LD,LS,MM,PH,PL,RL,RP,RS,SH,SW,UL,WH,WW,")]
    public class X12_ID_1062
    {
    }
    
    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,C,D,E,G,L,")]
    public class X12_ID_1065
    {
    }
    
    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,")]
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
    [EdiCodes(",A,B,F,M,N,U,X,")]
    public class X12_ID_1068
    {
    }
    
    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,8,A,AA,AB,AC,AD,AE,AF,AG,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y" +
        ",")]
    public class X12_ID_107
    {
    }
    
    /// <summary>
    /// Type of Residence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,9,A,B,C,D,F,H,I,L,N,")]
    public class X12_ID_1070
    {
    }
    
    /// <summary>
    /// General Expense Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,65,66,67,91,92,93,94,95,96,97,98,")]
    public class X12_ID_1071
    {
    }
    
    /// <summary>
    /// Rounding System Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,D,T,U,")]
    public class X12_ID_1072
    {
    }
    
    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073
    {
    }
    
    /// <summary>
    /// Type of Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28" +
        ",29,30,31,32,33,34,35,36,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,5" +
        "7,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,UN,ZZ,")]
    public class X12_ID_1074
    {
    }
    
    /// <summary>
    /// Status of Plans for Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,P,R,S,T,")]
    public class X12_ID_1075
    {
    }
    
    /// <summary>
    /// Real Estate Loan Security Instrument Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,L,M,")]
    public class X12_ID_1076
    {
    }
    
    /// <summary>
    /// Property Value Estimate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,R,")]
    public class X12_ID_1077
    {
    }
    
    /// <summary>
    /// Property Ownership Rights Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,F,G,H,L,O,R,S,T,U,X,")]
    public class X12_ID_1078
    {
    }
    
    /// <summary>
    /// Contact Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,F,M,T,")]
    public class X12_ID_1079
    {
    }
    
    /// <summary>
    /// Pick-up or Delivery Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AT,BC,CA,CB,CC,CP,CR,CS,CT,DB,DT,H,IB,IR,J,LD,LL,M,O,OC,OT,P,PB,RB,RC,RD,RG,RR,S" +
        ",SD,U,V,")]
    public class X12_ID_108
    {
    }
    
    /// <summary>
    /// Assumption Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,4,5,")]
    public class X12_ID_1080
    {
    }
    
    /// <summary>
    /// Loan Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,30,31,AL,AR,AU,BO,CC,CO,CT,FM,MH,PE,RE,RV,SL,SM,SO,")]
    public class X12_ID_1081
    {
    }
    
    /// <summary>
    /// Use of Proceeds Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,04,05,06,07,08,09,11,12,13,14,16,17,18,20,21,22,23,24,25,ZZ,")]
    public class X12_ID_1082
    {
    }
    
    /// <summary>
    /// Type of Downpayment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,09,10,11,12,13,14,27,28,29,30,31,32,33,34,35,36,37,38,41,42" +
        ",43,44,ZZ,")]
    public class X12_ID_1083
    {
    }
    
    /// <summary>
    /// Loan Buydown Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,T,")]
    public class X12_ID_1084
    {
    }
    
    /// <summary>
    /// Loan Payment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,")]
    public class X12_ID_1085
    {
    }
    
    /// <summary>
    /// Loan Rate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1086
    {
    }
    
    /// <summary>
    /// Negative Amortization Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1087
    {
    }
    
    /// <summary>
    /// Rate Life Cap Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1088
    {
    }
    
    /// <summary>
    /// Index Identity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,ZZ,")]
    public class X12_ID_1089
    {
    }
    
    /// <summary>
    /// Improvement Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,I,P,")]
    public class X12_ID_1090
    {
    }
    
    /// <summary>
    /// Buydown Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,")]
    public class X12_ID_1091
    {
    }
    
    /// <summary>
    /// Negative Amortization Cap Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1092
    {
    }
    
    /// <summary>
    /// Real Estate Loan Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,F,G,I,J,Z,")]
    public class X12_ID_1093
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Application Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1097
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Premium Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,F,")]
    public class X12_ID_1098
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Certificate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,N,O,P,")]
    public class X12_ID_1099
    {
    }
    
    /// <summary>
    /// Billing Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,M,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_11
    {
    }
    
    /// <summary>
    /// Application Acknowledgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BA,BC,BE,BP,BR,GA,GC,GE,GP,GR,IA,IC,IE,IP,IR,TA,TC,TE,TP,TR,")]
    public class X12_ID_110
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Coverage Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,Z,")]
    public class X12_ID_1100
    {
    }
    
    /// <summary>
    /// Lien Priority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,W,Z,")]
    public class X12_ID_1101
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Renewal Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,N,")]
    public class X12_ID_1102
    {
    }
    
    /// <summary>
    /// Loan Documentation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,R,")]
    public class X12_ID_1103
    {
    }
    
    /// <summary>
    /// Name Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,")]
    public class X12_ID_1104
    {
    }
    
    /// <summary>
    /// Mortgage Insurance Duration Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1105
    {
    }
    
    /// <summary>
    /// Address Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,51,52,53,54,56,57,58,59,60,61,62,63,6" +
        "4,65,66,67,68,69,71,74,79,80,90,91,92,93,94,96,97,")]
    public class X12_ID_1106
    {
    }
    
    /// <summary>
    /// Name Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,11,12,13,17,18,19,20,21,")]
    public class X12_ID_1107
    {
    }
    
    /// <summary>
    /// Month of the Year Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class X12_ID_1108
    {
    }
    
    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Z,")]
    public class X12_ID_1109
    {
    }
    
    /// <summary>
    /// Coupon Distribution Media Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,DH,DM,EC,FS,HO,HS,IL,IP,MO,MR,NC,OP,RI,SP,TM,")]
    public class X12_ID_1113
    {
    }
    
    /// <summary>
    /// Vent Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,Z,")]
    public class X12_ID_1122
    {
    }
    
    /// <summary>
    /// Offer Basis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,AA,AB,AC,AD,AE,AF,AG,EX,FE,MA,NS,NT,PF,SD,SM,TO,TR,ZZ,")]
    public class X12_ID_1123
    {
    }
    
    /// <summary>
    /// Interline Settlement System Status Action or Dispute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CC,CD,CH,CO,CP,CT,DA,DG,DO,DR,DT,GD,LT,NP,NR,OP,OR,PS,PT,RT,SA,SC,SF,SN,SS,ST" +
        ",T1,TD,TR,UT,")]
    public class X12_ID_1127
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code Characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,5,57,58,6,60,61,62,63,64,65,66,67,69,7,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C6,C7,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,F1,F2,F3,F4,F5,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H2,H3,")]
    public class X12_ID_1129
    {
    }
    
    /// <summary>
    /// Primary or Contingent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_1130
    {
    }
    
    /// <summary>
    /// Level of Individual, Test, or Course Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0K,10,11,12,20,21,22,23,24,25,26,27,28,29,30,31,32,33" +
        ",AD,AS,BD,C2,DD,EL,EM,HG,HS,IF,IN,MD,MS,NO,P0,P1,P2,P3,P4,P5,PC,PD,PF,PK,PS,SS,U" +
        "N,VR,VS,")]
    public class X12_ID_1131
    {
    }
    
    /// <summary>
    /// Instructional Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",")]
    public class X12_ID_1132
    {
    }
    
    /// <summary>
    /// Program Participation and Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,8,9,")]
    public class X12_ID_1133
    {
    }
    
    /// <summary>
    /// Program and Services Funding Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1134
    {
    }
    
    /// <summary>
    /// Placement Criteria Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1135
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DD,DE,DF,DG,DH,DI,DP,DR,DV,E1,E2,E3,E4,E5,EB,EC,ED,EE,EF,EG,EH,EI,EJ,FA,FC,FH,FI,FP,FR,FT,GD,GS,GU,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HY,HZ,IC,ID,IH,IM,IN,LA,LE,LL,LR,LS,LT,LZ,MA,MI,MN,MO,MP,MS,MT,NC,NS,NW,OA,OC,OF,ON,OP,OT,OU,PA,PB,PC,PD,PE,PF,PG,PI,PN,PO,PR,PS,PT,R1,R2,R3,R4,R5,RC,RE,RI,RL,RM,RN,RR,RS,RT,RU,RV,SA,SD,SE,SI,SJ,SL,SN,SP,SR,SS,ST,SU,SW,SZ,TB,TE,TF,TH,TI,TM,TN,TP,TR,TW,UP,VA,VC,VD,VO,WA,WM,ZZ,")]
    public class X12_ID_1136
    {
    }
    
    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,O,P,S,T,U,")]
    public class X12_ID_1138
    {
    }
    
    /// <summary>
    /// Session Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1139
    {
    }
    
    /// <summary>
    /// Floor Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,F,S,W,")]
    public class X12_ID_1140
    {
    }
    
    /// <summary>
    /// Academic Credit Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,G,N,Q,S,U,V,X,")]
    public class X12_ID_1141
    {
    }
    
    /// <summary>
    /// Academic Grade or Course Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,3,4,5,6,7,8,9,A,AR,B,D,DL,E,F,G,H,I,L,M,P,R,T," +
        "U,V,")]
    public class X12_ID_1142
    {
    }
    
    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143
    {
    }
    
    /// <summary>
    /// Disability Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,Z,")]
    public class X12_ID_1146
    {
    }
    
    /// <summary>
    /// Basis for Academic Credit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,M,N,P,R,T,V,W,X,Z,")]
    public class X12_ID_1147
    {
    }
    
    /// <summary>
    /// Port or Terminal Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,V,W,Y,")]
    public class X12_ID_115
    {
    }
    
    /// <summary>
    /// Course Repeat or No Count Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,X,")]
    public class X12_ID_1150
    {
    }
    
    /// <summary>
    /// Override Academic Course Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IA,MC,TC,")]
    public class X12_ID_1152
    {
    }
    
    /// <summary>
    /// Academic Field of Study Level or Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,G,L,M,N,S,T,V,W,X,Z,")]
    public class X12_ID_1153
    {
    }
    
    /// <summary>
    /// Work Intensity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,L,M,R,")]
    public class X12_ID_1154
    {
    }
    
    /// <summary>
    /// Test Norm Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_1156
    {
    }
    
    /// <summary>
    /// Test Norming Period Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1157
    {
    }
    
    /// <summary>
    /// Test Score Interpretation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,H,I,J,K,L,M,N,O,P,Q,R,S,T,")]
    public class X12_ID_1159
    {
    }
    
    /// <summary>
    /// Test Score Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,Z,")]
    public class X12_ID_1160
    {
    }
    
    /// <summary>
    /// Product Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,28,29,3,30,31,4,5,6,7,8,9,A,B,BA,C,D,GA,N,NC,O,PD,S,")]
    public class X12_ID_1161
    {
    }
    
    /// <summary>
    /// Show Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EV,FS,LA,LN,LS,MA,NR,SP,")]
    public class X12_ID_1162
    {
    }
    
    /// <summary>
    /// Ticket Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,CH,EX,GR,NR,RR,SP,ST,")]
    public class X12_ID_1163
    {
    }
    
    /// <summary>
    /// Network or Schedule Data Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,ZZ,")]
    public class X12_ID_1164
    {
    }
    
    /// <summary>
    /// Confidentiality Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",O,R,U,")]
    public class X12_ID_1165
    {
    }
    
    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,09,AB,AC,AD,AE,AF,AG,AH,AI,AJ,CA,CB,CH,CP,CS,CW,CX,CY,DI,EA,ER" +
        ",FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FR,FX,LA,LE,LH,OC,PR,SP,TM,ZZ,")]
    public class X12_ID_1166
    {
    }
    
    /// <summary>
    /// Door Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,A6,A7,AO,B1,B2,B3,B4,B5,B6,B7,BO,")]
    public class X12_ID_1168
    {
    }
    
    /// <summary>
    /// Claim Response Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CDR,CMP,DC,ELH,ELR,EPC,EW,FRS,FWC,IIS,IRS,IWS,MAP,NCR,NEW,NOP,NRI,NSB,NWR,PNP,PW" +
        "A,RDP,SUB,UPR,UR,URF,WBS,")]
    public class X12_ID_1172
    {
    }
    
    /// <summary>
    /// Task ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,20,21,22,PI,PM,SM,ZZ,")]
    public class X12_ID_1173
    {
    }
    
    /// <summary>
    /// Employment Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,53,54,5" +
        "5,56,57,58,ZZ,")]
    public class X12_ID_1176
    {
    }
    
    /// <summary>
    /// Customs Entry Type Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,W,")]
    public class X12_ID_1179
    {
    }
    
    /// <summary>
    /// Resource Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,EA,EF,EP,EU,FR,LA,LD,LE,LO,LP,LS,MA,MC,MN,OT,SC,")]
    public class X12_ID_1181
    {
    }
    
    /// <summary>
    /// Public Record or Obligation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,ZZ,")]
    public class X12_ID_1185
    {
    }
    
    /// <summary>
    /// Type of Income Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,38,39,40,41,42,43,44,45,46,47,48,49,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,91,92,93,94,AI,BG,EI,HR,K1,PD,PS,SA,SB,SC,SP,VP,ZZ,")]
    public class X12_ID_1186
    {
    }
    
    /// <summary>
    /// Type of Account Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,")]
    public class X12_ID_1187
    {
    }
    
    /// <summary>
    /// Type of Personal or Business Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,ZZ,")]
    public class X12_ID_1188
    {
    }
    
    /// <summary>
    /// Type of Credit Account Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,I,M,O,R,")]
    public class X12_ID_1189
    {
    }
    
    /// <summary>
    /// Program Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,11,13,14,15,20,21,22,23,24,25,AQ,AR,AZ,BD,CL,CS,GA,GD,GP" +
        ",GT,MH,PL,PN,SF,SN,SP,")]
    public class X12_ID_1193
    {
    }
    
    /// <summary>
    /// Breakdown Structure Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,70,71,72,73,74,75,77,78,79,80,81,82,83,84,85,86,87,88,A1,A2,A3,A4,A5,A6,A7,A8,A9,AT,B1,B2,B3,B4,B5,BL,BY,C1,C2,C3,C4,CM,CY,D1,D2,D3,D4,D5,D6,D7,E1,E2,E3,E4,EH,ES,EX,F1,F2,F3,F4,FE,FP,FR,G1,G2,G3,G4,G5,H1,H2,H3,H4,H5,I1,IN,J1,J2,K6,L1,LM,M1,MD,MR,N1,NP,P1,P2,P3,P4,P5,P6,RL,SC,TA,TC,TD,TR,TU,UB,ZZ,")]
    public class X12_ID_1196
    {
    }
    
    /// <summary>
    /// Financial Transaction Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AV,BA,BM,BP,BV,C,D,M,NA,O,P,R,RD,RE,RI,RN,S,TR,")]
    public class X12_ID_1197
    {
    }
    
    /// <summary>
    /// Contracting Funding Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_1198
    {
    }
    
    /// <summary>
    /// Appropriation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,ZZ,")]
    public class X12_ID_1199
    {
    }
    
    /// <summary>
    /// Information Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,L,O,P,S,T,")]
    public class X12_ID_1201
    {
    }
    
    /// <summary>
    /// Flexible Spending Account Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,E,H,L,Z,")]
    public class X12_ID_1202
    {
    }
    
    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203
    {
    }
    
    /// <summary>
    /// Insurance Line Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",403,AC,ADD,AF,AG,AH,AI,AJ,AK,AP,AR,BC,BE,BH,BK,CHU,CLF,CV,DCP,DEN,EMP,EPO,FAC,FS" +
        "A,GDC,HE,HLT,HMO,IRA,IRC,LL,LTC,LTD,MM,MOD,NGD,NQ,PDG,POS,PPO,PRA,PSP,QDA,QDC,ST" +
        "D,UL,UR,VIS,ZZZ,")]
    public class X12_ID_1205
    {
    }
    
    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,SPC,SPO,TWO,")]
    public class X12_ID_1207
    {
    }
    
    /// <summary>
    /// Underwriting Decision Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,I,N,S,")]
    public class X12_ID_1209
    {
    }
    
    /// <summary>
    /// Rate Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,BHR,C,CTR,DMA,DMB,DMC,E,ECR,F,H,I,L,M,N,O,Q,QUO,R,S,T,U,V,X,Y,")]
    public class X12_ID_121
    {
    }
    
    /// <summary>
    /// Drug House Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,BAX,FLR,HCS,NP,PCS,THR,ZZ,")]
    public class X12_ID_1211
    {
    }
    
    /// <summary>
    /// Health-Related Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,S,T,U,X,")]
    public class X12_ID_1212
    {
    }
    
    /// <summary>
    /// Current Health Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,E,F,G,P,")]
    public class X12_ID_1213
    {
    }
    
    /// <summary>
    /// Identification Card Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,H,P,")]
    public class X12_ID_1215
    {
    }
    
    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,I,S,T,V,")]
    public class X12_ID_1216
    {
    }
    
    /// <summary>
    /// Medicare Plan Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218
    {
    }
    
    /// <summary>
    /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_1219
    {
    }
    
    /// <summary>
    /// Rate/Value Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AV,B0,B1,BF,BL,BR,C5,CE,CF,CM,CO,CP,CS,CT,CW,DD,DE,DI,DP,DR,DS,DV,EI,ER,FA,FB,FC,FF,FI,FL,FN,FR,FT,FV,GT,HD,HM,HN,HX,HY,IA,IM,IN,KG,KL,KP,KT,LA,LB,LF,LI,LL,LP,LR,LS,LT,LV,MA,MB,MC,MD,ME,MF,MG,MH,MI,MM,MN,MO,MP,MR,MS,MT,MU,MV,MW,MX,NA,NB,ND,NE,NM,NP,NV,OP,OS,OT,P0,P1,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QY,RA,RB,RC,RL,RP,RT,S0,S1,SA,SB,SC,SD,SE,SF,SG,SH,SP,ST,SU,SY,TB,TC,TD,TN,TP,TR,VA,VH,VM,VP,VR,VS,VT,VU,VV,WK,WM,XP,YR,")]
    public class X12_ID_122
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
    [EdiCodes(",AD,AS,AT,BI,BS,CO,CV,H,HH,LA,ON,OP,OR,OT,P1,P2,PC,PE,PT,PU,R,RF,RP,SB,SK,SU,")]
    public class X12_ID_1221
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
    /// Contribution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,EA,EB,EC,ED,EI,EM,EP,ER,ES,ET,EU,IC,MB,MS,MT,MU,NC,NQ,PB,PS,PT,QC,QE,QM,QP,RA" +
        ",RK,RO,RP,RS,RT,SD,SP,ZZ,")]
    public class X12_ID_1224
    {
    }
    
    /// <summary>
    /// Type of Product Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AF,CA,CB,CC,CG,CP,CR,CS,CW,DD,DW,EC,ED,EE,EF,EM,EW,FC,FW,GC,GM,GR,IO,LF,LL,LO,LP" +
        ",LW,MB,MC,MG,MI,MR,MS,NE,OW,PD,PG,PL,PO,PW,QP,RC,RD,RN,RP,RR,RS,RT,SB,SC,SD,SP,S" +
        "S,ST,SW,TC,TP,UE,WC,")]
    public class X12_ID_1230
    {
    }
    
    /// <summary>
    /// Purchase Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,CN,DR,ER,HW,IR,MD,OV,RD,RE,SB,SP,SU,SV,TE,UT,")]
    public class X12_ID_1232
    {
    }
    
    /// <summary>
    /// Payment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6A,9A,9B,9C,")]
    public class X12_ID_1236
    {
    }
    
    /// <summary>
    /// Move Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,J,P,R,T,")]
    public class X12_ID_1237
    {
    }
    
    /// <summary>
    /// Bay Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1238
    {
    }
    
    /// <summary>
    /// Capacity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,AA,")]
    public class X12_ID_1239
    {
    }
    
    /// <summary>
    /// Facility Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1G,2G,A,AX,BC,BW,C,CL,CX,D,DA,FX,G,GA,GX,J,K,L,LK,M,N,NF,NH,OF,RH,RR,TP,TR,U,Y,")]
    public class X12_ID_1240
    {
    }
    
    /// <summary>
    /// Facility Characteristic Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,H,L,P,S,X,")]
    public class X12_ID_1241
    {
    }
    
    /// <summary>
    /// Special Rate Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BH,RT,TA,")]
    public class X12_ID_1246
    {
    }
    
    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DT,DTS,EH,KA,MD,MM,RD,RD2,RD4,RD5,RD6,RD8,RDM,RDT," +
        "RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250
    {
    }
    
    /// <summary>
    /// Immunization Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1254
    {
    }
    
    /// <summary>
    /// Special Program Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,27,28,3,4,5,6,7,8,9,99,")]
    public class X12_ID_1257
    {
    }
    
    /// <summary>
    /// Loan Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,7,8,9,90,91,92,93,")]
    public class X12_ID_1262
    {
    }
    
    /// <summary>
    /// Delayed Repayment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,11,12,13,14,15,16,17,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37" +
        ",4,5,6,9,")]
    public class X12_ID_1264
    {
    }
    
    /// <summary>
    /// Interest Payment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1265
    {
    }
    
    /// <summary>
    /// Major Course of Study
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1266
    {
    }
    
    /// <summary>
    /// Dependency Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1267
    {
    }
    
    /// <summary>
    /// Applicant Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1268
    {
    }
    
    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,100,101,102,103,104,105,106,107,108,109,11,12,13,14,16,17,19,2,20,21,22,2" +
        "3,24,25,26,27,28,29,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49" +
        ",5,52,53,54,55,56,57,58,59,6,60,61,62,63,66,67,69,7,71,74,75,78,79,8,80,81,82,83" +
        ",84,85,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA," +
        "AAA,AB,ABR,ABS,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,ALP,AM,AN,AO,AP,APE,AQ,AR,AS,AT,AU," +
        "AW,AX,B,BA,BB,BC,BCC,BCR,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BPL,BQ,BR,BRL,BS" +
        ",BSL,BU,BV,BY,BZ,C,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CLP,CM,CML,CN,CO" +
        ",COG,CPS,CRC,CS,CSF,CT,CU,CV,CW,CZ,D,D1,D2,D3,D4,D5,DA,DB,DBS,DC,DD,DE,DF,DG,DGO" +
        ",DH,DI,DJ,DK,DL,DLO,DLP,DM,DN,DO,DPE,DPL,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E,EA,EB,EC,E" +
        "D,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EQ,ER,ES,ESL,ET,ETL,EU,EV,EW,EWC,EWR,EX,EY,EZ" +
        ",F,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FZ,G," +
        "G1,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,GQ,GR,GS,GT,GU,GV,GW,H,HA,HB,HD,HE,HI,HRC,HS,HZ" +
        "R,I,IC,ID,IF,IMC,IMP,IPA,IQ,IT,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCL,JD,J" +
        "E,JF,JG,JH,JI,JK,JL,JM,JN,JO,JOL,JP,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO," +
        "KP,KQ,KS,KT,KU,KW,KYL,KZ,L,LA,LB,LC,LD,LE,LF,LG,LH,LIN,LJ,LK,LM,LN,LO,LOI,LP,LQ," +
        "LR,LS,LSC,LT,LZ,M,MB,MC,MCC,MCD,ME,MI,MJ,MK,ML,MN,MOC,N,NA,NAC,NAF,NAS,NB,NC,ND," +
        "NDC,NE,NF,NH,NI,NJ,NK,NL,NP,NR,NS,NT,O,O1,O2,O3,O4,OC,P,PB,PC,PD,PGS,PI,PIT,PL,P" +
        "LC,PLS,PPD,PPP,PPS,PPV,PRA,PRC,PRR,PRT,PS,PWA,PWI,PWR,PWS,PWT,Q,QA,QB,QC,QE,QF,Q" +
        "G,QH,QI,QJ,QK,QS,R,RA,RC,RCA,RD,RE,REN,RF,RI,RQ,RR,RT,RTC,RUM,RX,S,SA,SB,SBA,SC," +
        "SD,SE,SEC,SF,SG,SH,SHL,SI,SJ,SL,SM,SMI,SO,SP,SPE,SR,SRL,SS,ST,STC,T,T00,T01,T02," +
        "T03,T04,T05,T06,T07,T08,T09,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,TB,T" +
        "C,TCL,TD,TE,TF,TG,TOL,TR,TTL,TX,TY,U,UP,UR,US,UU,V,W,WDL,X,Y,Z,ZZ,")]
    public class X12_ID_1270
    {
    }
    
    /// <summary>
    /// Direction Facing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,F,U,")]
    public class X12_ID_1273
    {
    }
    
    /// <summary>
    /// Fumigated/Cleaned Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,F,N,")]
    public class X12_ID_1275
    {
    }
    
    /// <summary>
    /// Canadian Wheat Board (CWB) Marketing Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,4,5,")]
    public class X12_ID_1277
    {
    }
    
    /// <summary>
    /// Canadian Wheat Board (CWB) Marketing Class Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,S,")]
    public class X12_ID_1278
    {
    }
    
    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0P,10,11,12,13" +
        ",14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1" +
        "U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K," +
        "2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B" +
        ",3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,4" +
        "2,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S," +
        "4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J" +
        ",5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,63,64,65,66,67,68,69,6A,6" +
        "B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71," +
        "72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S" +
        ",7T,7U,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8" +
        "K,8L,8M,8N,8O,8P,8Q,8R,8S,8U,8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B," +
        "9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3" +
        ",A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AA" +
        "O,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH" +
        ",ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABY,AC,ACA,ACB,ACC,ACD,ACE," +
        "ACF,ACG,ACH,ACI,ACJ,ACK,ACR,ACS,ACT,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADM,A" +
        "E,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AF,AG,AH,AHC,AI,AJ,AK,AL,A" +
        "LC,ALG,ALH,ALI,ALJ,ALT,AM,AN,AO,AP,API,AQ,AR,AS,ASL,ASP,AST,AT,ATC,AU,AV,AW,AX,A" +
        "Y,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAA,BAB,BAC,BAD,BAE,BAF,BAG,BAH,BAI,BB,BC,BCI" +
        ",BD,BE,BF,BG,BH,BI,BJ,BK,BKT,BL,BLT,BM,BMM,BN,BO,BOI,BP,BQ,BR,BS,BT,BU,BV,BW,BX," +
        "BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CBG,CC,CD,CDN,CE,CF,CG,CH,CI,CIR,CIT,C" +
        "J,CK,CL,CM,CMN,CMP,CMT,CN,CNO,CO,COL,COT,CP,CPA,CPT,CQ,CR,CRN,CRS,CS,CSC,CSG,CST" +
        ",CT,CTS,CU,CV,CW,CX,CY,CYC,CZ,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG" +
        ",DH,DHH,DI,DIS,DJ,DK,DL,DM,DN,DNR,DNS,DO,DOA,DOC,DOE,DOI,DOJ,DOL,DON,DOS,DOT,DP," +
        "DQ,DR,DRN,DS,DSC,DSI,DST,DT,DTS,DU,DUN,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,E7,E8,E9" +
        ",EA,EB,EC,ED,EDA,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EMM,EN,END,EO,EP,EPA,EPB,EQ,ER,ES,ES" +
        "N,ET,EU,EV,EW,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FCN,FD,FE,FF,FG,FH,FI" +
        ",FJ,FK,FL,FLZ,FM,FMP,FN,FND,FO,FP,FQ,FR,FS,FSN,FT,FTN,FU,FV,FW,FWC,FX,FY,FZ,G1,G" +
        "2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS," +
        "GT,GU,GV,GW,GWS,GX,GY,GZ,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HHT," +
        "HI,HJ,HK,HL,HM,HMB,HN,HO,HP,HPI,HQ,HR,HS,HT,HU,HUD,HV,HW,HX,HY,HZ,I1,I2,I3,I4,I5" +
        ",I7,I8,I9,IA,IB,IC,ICD,ID,IE,IF,IFT,IG,IH,II,IID,IJ,IK,IL,IM,IMP,IMS,IN,IND,IO,I" +
        "P,IQ,IR,IRN,IRP,IS,ISC,ISN,ISS,IT,IU,IV,IW,IX,IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,J" +
        "A,JB,JC,JD,JE,JF,JH,JI,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2," +
        "K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU" +
        ",KV,KW,KX,KY,KZ,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LEN,LF,LG,LH,LI,LIC,LJ" +
        ",LK,LL,LM,LN,LO,LOI,LP,LQ,LR,LS,LSD,LT,LU,LV,LVO,LW,LX,LY,LZ,M1,M2,M3,M5,M6,M7,M" +
        "8,M9,MA,MB,MBX,MC,MCI,MD,MDN,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MSL,MT" +
        ",MU,MV,MW,MX,MY,MZ,MZO,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NAS,NB,NC,ND,NDA,NDB,NE," +
        "NF,NFC,NFD,NFM,NFN,NFS,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NW,NX,NY,NZ," +
        "O1,O2,O5,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OP,OQ,OR,OS,OT,OU,OV" +
        ",OW,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PAC,PAN,PAP,PB,PC,PCC,PCN,PD,PDL,PE,PF,P" +
        "G,PGC,PGN,PGS,PH,PHC,PI,PID,PIN,PJ,PK,PL,PLA,PLN,PM,PMN,PN,PNN,PO,POL,PP,PQ,PR,P" +
        "RS,PRT,PS,PSI,PSL,PSM,PSN,PT,PTC,PU,PV,PW,PWC,PWS,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7," +
        "Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY" +
        ",QZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RAA,RAN,RB,RC,RD,RE,REC,RF,RG,RGI,RH,RI,RIG" +
        ",RJ,RK,RL,RM,RN,RO,RP,RPP,RPT,RQ,RR,RRS,RS,RSN,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3," +
        "S4,S5,S6,S7,S8,S9,SA,SB,SBN,SC,SCA,SD,SE,SEK,SES,SF,SG,SH,SHL,SI,SJ,SK,SL,SM,SN," +
        "SNH,SNV,SO,SP,SPL,SPN,SQ,SR,SS,ST,STB,STR,SU,SUB,SUO,SV,SW,SX,SY,SZ,T0,T1,T2,T3," +
        "T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TDT,TE,TF,TG,TH,TI,TIP,TJ,TK,TL,TM,TN,TO,TOC,TP,TP" +
        "N,TQ,TR,TS,TSN,TT,TU,TV,TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U8,U9,UA,UB,UC,UD,UE,UF" +
        ",UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,URL,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4," +
        "V5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VU,VV" +
        ",VW,VX,VY,VZ,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WCS,WD,WDR,WE,WF,WG,WH,WI,WJ,WK" +
        ",WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,X" +
        "B,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y0,Y1," +
        "Y2,Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT" +
        ",YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,Z" +
        "M,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_128
    {
    }
    
    /// <summary>
    /// Direction Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,S,W,")]
    public class X12_ID_1280
    {
    }
    
    /// <summary>
    /// Returns Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CR,DI,KA,KR,MW,PA,RA,RD,RF,RN,RP,RT,SC,SD,")]
    public class X12_ID_1292
    {
    }
    
    /// <summary>
    /// Return Request Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,CO,CV,DA,DI,DM,DP,DR,DT,EI,EO,EW,LP,MD,NA,OP,PE,PF,PR,PS,PW,RE,SD,SM,SP,SR,ST" +
        ",TE,WG,")]
    public class X12_ID_1293
    {
    }
    
    /// <summary>
    /// Return Response Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EW,FR,IN,IO,MI,NR,OS,PC,PR,QD,RR,RT,SR,UI,")]
    public class X12_ID_1294
    {
    }
    
    /// <summary>
    /// Participant Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AN,AV,C,CD,D,DB,DN,DP,DR,DV,EL,GA,KP,N,PD,PF,R,RT,S,S1,S2,TD,TN,TR,TS,TV,US,")]
    public class X12_ID_1295
    {
    }
    
    /// <summary>
    /// Work Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CL,CO,NS,RE,ST,VO,")]
    public class X12_ID_1297
    {
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A010,A020,A030,A040,A050,A060,A070,A080,A090,A100,A110,A112,A120,A121,A122,A130," +
        "A140,A150,A160,A170,A172,A180,A190,A200,A210,A220,A230,A240,A250,A260,A270,A280," +
        "A290,A300,A310,A320,A330,A340,A350,A360,A370,A380,A390,A400,A410,A420,A430,A440," +
        "A445,A450,A460,A470,A480,A485,A490,A500,A510,A520,A530,A540,A550,A555,A560,A570," +
        "A580,A590,A600,A610,A620,A630,A640,A650,A658,A660,A670,A680,A690,A691,A700,A710," +
        "A720,A721,A730,A740,A750,A760,A770,A780,A790,A800,A810,A820,A830,A840,A850,A860," +
        "A870,A880,A890,A900,A910,A920,A930,A940,A950,A960,A970,A980,A990,ADOW,ADRW,AFEE," +
        "ALPT,B000,B010,B015,B020,B030,B040,B050,B060,B070,B080,B090,B091,B100,B110,B120," +
        "B130,B140,B150,B160,B170,B180,B190,B200,B210,B220,B230,B240,B250,B260,B270,B280," +
        "B290,B300,B310,B320,B330,B340,B350,B360,B370,B380,B390,B400,B500,B510,B520,B530," +
        "B540,B550,B551,B560,B570,B580,B581,B590,B600,B610,B620,B630,B650,B660,B670,B680," +
        "B690,B700,B720,B730,B740,B742,B750,B760,B770,B775,B780,B785,B787,B790,B791,B800," +
        "B810,B820,B830,B840,B850,B860,B870,B872,B880,B881,B890,B900,B910,B911,B920,B930," +
        "B940,B950,B960,B970,B980,B990,B992,B994,B996,B998,BU2T,BU4T,BUAT,BURD,C000,C010," +
        "C020,C030,C040,C050,C060,C070,C080,C090,C100,C110,C120,C130,C140,C150,C160,C170," +
        "C180,C190,C200,C210,C220,C230,C231,C240,C250,C260,C270,C280,C290,C300,C310,C320," +
        "C330,C340,C350,C360,C370,C380,C390,C400,C401,C402,C410,C420,C430,C440,C450,C460," +
        "C470,C480,C490,C500,C510,C520,C530,C531,C540,C550,C560,C570,C580,C590,C600,C610," +
        "C630,C640,C650,C660,C670,C675,C680,C690,C700,C710,C720,C730,C740,C750,C760,C770," +
        "C780,C790,C800,C810,C820,C830,C840,C850,C860,C870,C880,C890,C900,C910,C920,C930," +
        "C940,C950,C960,C970,C980,C990,CA2T,CA4T,CFCT,CFLT,CGTT,CLDT,COMM,CRLT,CTLT,CUFT," +
        "D000,D010,D015,D020,D025,D030,D040,D050,D060,D070,D080,D100,D101,D103,D110,D120," +
        "D130,D140,D141,D142,D143,D144,D150,D160,D170,D180,D190,D200,D210,D220,D230,D240," +
        "D242,D244,D246,D250,D260,D270,D280,D290,D292,D300,D301,D310,D320,D330,D340,D350," +
        "D360,D370,D380,D390,D400,D410,D420,D430,D440,D450,D460,D470,D480,D490,D500,D501," +
        "D502,D510,D520,D530,D540,D550,D560,D570,D580,D590,D600,D610,D620,D630,D640,D650," +
        "D655,D660,D670,D680,D690,D700,D701,D710,D711,D720,D730,D740,D750,D760,D770,D780," +
        "D790,D800,D810,D820,D830,D840,D850,D860,D870,D880,D890,D900,D910,D920,D930,D940," +
        "D950,D960,D970,D980,D990,D995,DCET,DCVT,DDZT,DEZT,DFDT,DGET,DOVT,DPDT,DPET,E000," +
        "E010,E020,E022,E030,E040,E050,E060,E063,E065,E067,E068,E069,E070,E080,E090,E100," +
        "E110,E120,E130,E140,E150,E160,E170,E180,E190,E191,E192,E193,E200,E210,E220,E230," +
        "E240,E250,E260,E270,E280,E290,E300,E310,E320,E330,E340,E350,E360,E370,E380,E381," +
        "E382,E384,E386,E388,E389,E390,E400,E410,E420,E430,E440,E450,E460,E470,E480,E485," +
        "E490,E500,E510,E520,E530,E540,E550,E560,E570,E580,E585,E590,E600,E610,E620,E630," +
        "E640,E650,E660,E670,E680,E690,E695,E700,E710,E720,E730,E740,E750,E760,E770,E780," +
        "E790,E800,E805,E810,E820,E830,E840,E850,E860,E870,E880,E890,E900,E910,E920,E930," +
        "E940,E950,E960,E970,E980,E990,ENGA,EXLT,F000,F010,F020,F030,F040,F050,F060,F061," +
        "F062,F063,F065,F067,F070,F080,F090,F100,F110,F120,F130,F140,F150,F155,F160,F170," +
        "F180,F190,F200,F210,F220,F225,F230,F240,F250,F260,F270,F271,F272,F280,F290,F300," +
        "F310,F320,F330,F340,F350,F360,F370,F380,F390,F400,F401,F410,F420,F430,F440,F445," +
        "F450,F460,F465,F470,F480,F490,F500,F510,F520,F530,F540,F550,F560,F570,F580,F590," +
        "F600,F610,F620,F630,F640,F650,F660,F670,F680,F690,F700,F710,F720,F730,F740,F750," +
        "F760,F770,F780,F790,F800,F810,F820,F830,F840,F850,F860,F870,F880,F890,F900,F910," +
        "F920,F930,F940,F950,F960,F970,F980,F990,F991,FAKT,FLST,G000,G010,G020,G025,G030," +
        "G040,G050,G060,G070,G080,G090,G100,G110,G120,G130,G140,G150,G160,G170,G180,G190," +
        "G200,G210,G220,G230,G240,G250,G260,G270,G280,G290,G300,G310,G320,G322,G324,G326," +
        "G328,G329,G330,G340,G350,G360,G370,G380,G390,G400,G410,G420,G430,G440,G450,G460," +
        "G470,G480,G490,G500,G510,G520,G530,G540,G550,G560,G570,G580,G590,G600,G610,G620," +
        "G630,G640,G650,G660,G670,G680,G690,G700,G710,G720,G730,G740,G750,G760,G770,G775," +
        "G780,G790,G800,G810,G820,G821,G830,G840,G850,G860,G870,G880,G890,G900,G910,G920," +
        "G930,G940,G950,G960,G970,G980,G990,GMST,H000,H010,H020,H030,H040,H050,H060,H070," +
        "H080,H090,H100,H110,H120,H130,H140,H150,H151,H160,H170,H180,H190,H200,H210,H215," +
        "H220,H230,H240,H250,H260,H270,H280,H290,H300,H310,H320,H330,H340,H350,H360,H370," +
        "H380,H390,H400,H410,H420,H430,H440,H450,H460,H470,H480,H490,H500,H505,H507,H510," +
        "H520,H530,H535,H540,H550,H551,H560,H570,H580,H590,H600,H605,H610,H620,H625,H630," +
        "H640,H650,H660,H670,H680,H690,H700,H710,H720,H730,H740,H750,H760,H770,H780,H790," +
        "H800,H806,H810,H820,H830,H840,H850,H855,H860,H870,H880,H890,H900,H910,H920,H930," +
        "H935,H940,H950,H960,H970,H980,H990,HZDT,I000,I010,I020,I030,I040,I050,I060,I070," +
        "I080,I090,I100,I110,I120,I130,I131,I132,I133,I134,I136,I138,I140,I150,I160,I170," +
        "I180,I190,I200,I210,I220,I230,I240,I250,I260,I270,I280,I290,I300,I310,I320,I330," +
        "I340,I350,I360,I370,I380,I390,I400,I410,I411,I420,I430,I431,I432,I440,I450,I460," +
        "I470,I480,I490,I495,I500,I510,I520,I530,I540,I550,I560,I570,I580,I590,I595,I600," +
        "I610,I620,I630,I640,I650,I660,I670,I680,I690,I700,I710,I720,I730,I740,I750,I760," +
        "IDCT,LC2T,LC4T,LCLT,LECT,LFDT,LMDT,LNDT,LPDT,LQDT,LTET,MATT,OCNT,OFFA,OODT,OTHR," +
        "OWCT,PRST,PTAX,PVPT,R020,R030,R040,R060,R080,RDHT,RFMT,RPDT,RSTT,SFBT,SFDT,SFET," +
        "SSCT,SSUT,STDT,STFT,STOT,TERT,VCLT,WBBT,WCFT,WFTT,WRBT,WRIT,ZZZZ,")]
    public class X12_ID_1300
    {
    }
    
    /// <summary>
    /// Use of Language Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1303
    {
    }
    
    /// <summary>
    /// Mark Code Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1304
    {
    }
    
    /// <summary>
    /// Loan Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,1L,1M,1N,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2S,2U,2V,2W,2X,2Y,2Z,3,30,31,32,33,34,35,36,37,38,39,3A,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,AA,ZA,ZZ,")]
    public class X12_ID_1307
    {
    }
    
    /// <summary>
    /// Contract Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,KA,KB,KC,KD,KE,KF,KG,PE,RP,ZZ,")]
    public class X12_ID_1308
    {
    }
    
    /// <summary>
    /// Acquisition Data Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,K1,K2,K3,K4,K5,K6,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L2,")]
    public class X12_ID_1309
    {
    }
    
    /// <summary>
    /// Financing Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,G,P,")]
    public class X12_ID_1310
    {
    }
    
    /// <summary>
    /// Calculation Operation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,F,M,N,Q,R,S,")]
    public class X12_ID_1311
    {
    }
    
    /// <summary>
    /// Test Period or Interval Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",TF,TI,TO,")]
    public class X12_ID_1312
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
    public class X12_ID_1317
    {
    }
    
    /// <summary>
    /// Basis of Cost Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1319
    {
    }
    
    /// <summary>
    /// Release Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,H,R,S,T,U,")]
    public class X12_ID_132
    {
    }
    
    /// <summary>
    /// Basis of Days Supply Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1320
    {
    }
    
    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,2" +
        "8,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y," +
        "2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P" +
        ",3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4" +
        "G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56," +
        "57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X" +
        ",5Y,5Z,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6" +
        "O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E," +
        "7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85" +
        ",86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8" +
        "W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M," +
        "9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF" +
        ",AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B" +
        "7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX," +
        "BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP" +
        ",CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,D" +
        "H,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7," +
        "E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY" +
        ",EZ,F0,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,F" +
        "P,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF," +
        "GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H0,H1,H2,H3,H4,H5,H6" +
        ",H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,H" +
        "X,HY,HZ,I1,I2,I3,I4,I5,I6,I7,I8,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IM,IN,IO,IP,IQ," +
        "IR,IS,IT,IU,IV,IW,IX,IY,IZ,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JH,JI,JJ" +
        ",JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,K" +
        "B,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2," +
        "L3,L4,L5,L6,L7,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LO,LP,LR,LS,LT,LU,LV,LW,M1" +
        ",M2,MA,MB,MC,MD,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N" +
        "A,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NN,NP,NR,NU,OL,OO,OP,OR,OT,OV,P1,P2,P3,P4,P5," +
        "P6,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PK,PM,PO,PP,PR,PS,PT,PV,PW,PY,PZ,Q1,Q2,Q3,Q4,Q5" +
        ",Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,R1,R" +
        "2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS," +
        "RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S5,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SN,SO,SP,SQ,SR,ST" +
        ",SU,SV,SW,SX,SY,SZ,T1,T2,T3,T4,T5,T6,TA,TB,TC,TD,TE,TF,TM,TP,TR,TV,U1,U2,U3,U4,U" +
        "5,U6,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UV," +
        "UW,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V7,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VT" +
        ",VU,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WK,WL,WM,WN,WO,WP,WR,W" +
        "S,WT,WU,WV,WW,WX,WY,WZ,XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS," +
        "XT,XU,XV,XW,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZK,ZL" +
        ",ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZW,ZY,ZZ,")]
    public class X12_ID_1321
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,I,R,S,")]
    public class X12_ID_1322
    {
    }
    
    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1327
    {
    }
    
    /// <summary>
    /// Dispense as Written Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1329
    {
    }
    
    /// <summary>
    /// Routing Sequence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,H,I,JD,JO,M,O,R,S,V,X,Z,")]
    public class X12_ID_133
    {
    }
    
    /// <summary>
    /// Dosage Form Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,10,11,12,13,14,15,16,20,21,22,23,24,25,30,31,32,33,34,40,41" +
        ",42,43,50,51,52,53,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8" +
        "0,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,")]
    public class X12_ID_1330
    {
    }
    
    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,")]
    public class X12_ID_1332
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
    [EdiCodes(",12,13,14,15,16,41,42,43,47,AP,C1,CO,CP,D,DB,EP,FF,GP,HM,HN,HS,IN,IP,LC,LD,LI,LT," +
        "MA,MB,MC,MH,MI,MP,OT,PE,PL,PP,PR,PS,QM,RP,SP,TF,WC,WU,")]
    public class X12_ID_1336
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
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,F1,F2,I,L,NBC,R,U,")]
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
    /// Non-Visit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,O,")]
    public class X12_ID_1344
    {
    }
    
    /// <summary>
    /// Nursing Home Residential Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1345
    {
    }
    
    /// <summary>
    /// Nutrient Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,P,S,")]
    public class X12_ID_1346
    {
    }
    
    /// <summary>
    /// Nutrient Administration Technique Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,J,N,O,")]
    public class X12_ID_1347
    {
    }
    
    /// <summary>
    /// Oxygen Equipment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,O,")]
    public class X12_ID_1348
    {
    }
    
    /// <summary>
    /// Oxygen Test Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,N,O,R,S,W,X,")]
    public class X12_ID_1349
    {
    }
    
    /// <summary>
    /// Oxygen Test Findings Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1350
    {
    }
    
    /// <summary>
    /// Patient Signature Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,M,P,S,")]
    public class X12_ID_1351
    {
    }
    
    /// <summary>
    /// Prescription Denial Override Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,")]
    public class X12_ID_1355
    {
    }
    
    /// <summary>
    /// Prescription Origin Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1356
    {
    }
    
    /// <summary>
    /// Prior Authorization Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,")]
    public class X12_ID_1357
    {
    }
    
    /// <summary>
    /// Prosthesis, Crown or Inlay Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,")]
    public class X12_ID_1358
    {
    }
    
    /// <summary>
    /// Provider Accept Assignment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,P,")]
    public class X12_ID_1359
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
    /// Oral Cavity Designation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,20,30,40,L,R,")]
    public class X12_ID_1361
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
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363
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
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,")]
    public class X12_ID_1365
    {
    }
    
    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,")]
    public class X12_ID_1366
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
    /// Tooth Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,I,M,X,")]
    public class X12_ID_1368
    {
    }
    
    /// <summary>
    /// Tooth Surface Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,D,F,I,L,M,O,")]
    public class X12_ID_1369
    {
    }
    
    /// <summary>
    /// Unit Dose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,Z,")]
    public class X12_ID_1370
    {
    }
    
    /// <summary>
    /// Measurement Method or Device
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BM,BO,DM,FT,MA,MM,OM,PT,TM,VA,VB,VC,")]
    public class X12_ID_1373
    {
    }
    
    /// <summary>
    /// Payment Adjustment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1374
    {
    }
    
    /// <summary>
    /// Investor Reporting Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,IL,")]
    public class X12_ID_1376
    {
    }
    
    /// <summary>
    /// Waybill Cross-Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",W1,W2,W3,W4,W5,W6,W7,W8,W9,")]
    public class X12_ID_1378
    {
    }
    
    /// <summary>
    /// Loan Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,")]
    public class X12_ID_1379
    {
    }
    
    /// <summary>
    /// Oxygen Delivery System Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1382
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
    /// Rate Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,2A,3,4,5,6,7,8,9,BA,CF,CM,CR,CX,DA,DI,DR,DS,IR,NB,NC,PB,PF" +
        ",RR,SR,ST,UF,")]
    public class X12_ID_1387
    {
    }
    
    /// <summary>
    /// Sales Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CH,DD,GA,IF,LC,MB,NC,OA,SA,SB,SD,ST,ZZ,")]
    public class X12_ID_139
    {
    }
    
    /// <summary>
    /// Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,CB,D,E,F,G,H,I,J,K,L,M,MC,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_1390
    {
    }
    
    /// <summary>
    /// Media Type Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",MI,NE,RD,TV,")]
    public class X12_ID_1393
    {
    }
    
    /// <summary>
    /// Configuration Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,B,C,S,")]
    public class X12_ID_1395
    {
    }
    
    /// <summary>
    /// Equipment Use Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,G,R,")]
    public class X12_ID_1396
    {
    }
    
    /// <summary>
    /// Inquiry Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,")]
    public class X12_ID_1398
    {
    }
    
    /// <summary>
    /// Proposal Data Detail Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,")]
    public class X12_ID_1401
    {
    }
    
    /// <summary>
    /// Equipment Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ATM,C02,CLE,DHT,DWI,FAP,GEN,LIN,MCP,MOI,N2,NDO,NOI,ODF,PCO,PRE,PSE,RAD,RUS,SLI,S" +
        "MO,STE,SUB,SUR,TBT,TEC,VOD,VOS,YEA,")]
    public class X12_ID_1402
    {
    }
    
    /// <summary>
    /// Implant Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1403
    {
    }
    
    /// <summary>
    /// Implant Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1404
    {
    }
    
    /// <summary>
    /// Investor Ownership Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1407
    {
    }
    
    /// <summary>
    /// Remittance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_1408
    {
    }
    
    /// <summary>
    /// Usage Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,P,R,")]
    public class X12_ID_1413
    {
    }
    
    /// <summary>
    /// Title Insurance Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,CL,CP,ES,MP,PP,SE,SP,SV,TC,TD,TI,TP,ZZ,")]
    public class X12_ID_1420
    {
    }
    
    /// <summary>
    /// Damage Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NW,PE,RP,UK,ZZ,")]
    public class X12_ID_1422
    {
    }
    
    /// <summary>
    /// License Plate Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,AP,AQ,AR,AT,BU,CC,CI,CO,CU,DA,DB,DD,DL,DP,DU,DV,DX,EX,FD,FG,FM,IP,IT,JJ,LE,LF" +
        ",LS,MC,MD,MF,ML,MP,MV,NG,OB,OL,PC,PE,PH,PX,RE,RI,RP,RV,S1,SC,SN,ST,SV,TK,TL,TM,T" +
        "P,TR,TX,US,UV,VF,VN,")]
    public class X12_ID_1423
    {
    }
    
    /// <summary>
    /// Recovery Classification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1425
    {
    }
    
    /// <summary>
    /// Recovery Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,2,3,4,5,6,7,8,9,A,B,C,D,E,F,Z,")]
    public class X12_ID_1426
    {
    }
    
    /// <summary>
    /// Master In-bond Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_1428
    {
    }
    
    /// <summary>
    /// Construction Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,B,C,D,E,F,G,H,I,J,K,L,M,N" +
        ",O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_1429
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",100,101,104,105,106,107,108,109,110,112,120,121,124,125,126,127,128,129,130,131,135,138,139,140,141,142,143,144,146,147,148,149,150,151,152,153,154,155,157,159,160,161,163,170,175,176,180,185,186,188,189,190,191,194,195,196,197,198,199,200,201,202,203,204,205,206,210,211,212,213,214,215,216,217,218,219,220,222,223,224,225,242,244,248,249,250,251,252,255,256,260,261,262,263,264,265,266,267,268,270,271,272,273,275,276,277,278,280,285,286,288,290,300,301,303,304,306,309,310,311,312,313,315,317,319,321,322,323,324,325,326,350,352,353,354,355,356,357,358,361,362,404,410,411,414,417,418,419,420,421,422,423,425,426,429,431,432,433,434,435,436,437,440,451,452,453,455,456,460,463,466,468,470,475,485,486,490,492,494,500,501,503,504,511,517,521,527,536,540,561,567,568,601,602,620,622,625,650,715,805,806,810,811,812,813,814,815,816,818,819,820,821,822,823,824,826,827,828,829,830,831,832,833,834,835,836,837,838,839,840,841,842,843,844,845,846,847,848,849,850,851,852,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,871,872,875,876,877,878,879,880,881,882,883,884,885,886,887,888,889,891,893,894,895,896,920,924,925,926,928,940,943,944,945,947,980,990,994,996,997,998,")]
    public class X12_ID_143
    {
    }
    
    /// <summary>
    /// Preference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,D,N,O,")]
    public class X12_ID_1431
    {
    }
    
    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,BP,CA,CC,CD,CF,DE,DF,FO,HP,MX,NC,NR,PA,PB,PC,PD,PE,PL,PO,PP,PS,PU,RC,RF,RS,TP" +
        ",WC,")]
    public class X12_ID_146
    {
    }
    
    /// <summary>
    /// Proximity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BL,BO,EB,EO,FO,IN,LO,NB,NE,NL,NO,NW,RO,SB,SE,SO,SW,WB,WO,ZZ,")]
    public class X12_ID_1465
    {
    }
    
    /// <summary>
    /// Location Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AL,AT,FC,LL,PL,RC,RL,TT,VL,WB,WE,WK,WL,WS,WX,ZZ,")]
    public class X12_ID_1466
    {
    }
    
    /// <summary>
    /// Reason Stopped Work Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,14,15,16,17,18,19,D1,D2,F1,F2,L1,L2,L3,L4,M1,M2,M3,M4,M5,O1,O2,O3,O4" +
        ",O5,O6,O7,Q1,R1,V1,V2,V3,V4,V5,")]
    public class X12_ID_1468
    {
    }
    
    /// <summary>
    /// Affected Area or Section Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1469
    {
    }
    
    /// <summary>
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_147
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
    /// Language Proficiency Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,")]
    public class X12_ID_1476
    {
    }
    
    /// <summary>
    /// Problem Log Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ES,MC,ME,MP,PE,RP,SH,SP,TC,TD,")]
    public class X12_ID_1484
    {
    }
    
    /// <summary>
    /// Service Commitment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,R,")]
    public class X12_ID_1485
    {
    }
    
    /// <summary>
    /// Retrip Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BO,CI,CU,DE,ET,HL,HR,HW,ID,MS,MV,OK,OP,RR,SI,SK,SL,SO,TA,TC,TD,TM,TR,WA,WC,WD,WE" +
        ",WI,WT,")]
    public class X12_ID_1487
    {
    }
    
    /// <summary>
    /// Bad Order Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,")]
    public class X12_ID_1488
    {
    }
    
    /// <summary>
    /// Hold Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CW,DE,EM,HI,LI,MI,MS,NB,OC,OI,WG,")]
    public class X12_ID_1489
    {
    }
    
    /// <summary>
    /// Parameter Trace Registration Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1491
    {
    }
    
    /// <summary>
    /// Parameter Trace Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,4,6,8,A,B,C,P,R,")]
    public class X12_ID_1492
    {
    }
    
    /// <summary>
    /// Output Event Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,E,F,G,H,L,P,")]
    public class X12_ID_1493
    {
    }
    
    /// <summary>
    /// Property Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,28,29" +
        ",30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,5" +
        "6,")]
    public class X12_ID_1496
    {
    }
    
    /// <summary>
    /// Rate Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DE,OR,")]
    public class X12_ID_1499
    {
    }
    
    /// <summary>
    /// Special Charge or Allowance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",002,003,004,005,006,007,008,009,010,011,012,015,016,017,020,025,026,027,028,029," +
        "030,031,032,035,040,045,050,055,060,065,070,075,080,085,090,095,100,105,110,115," +
        "120,135,140,145,150,155,160,165,170,175,180,185,186,190,205,210,215,220,225,230," +
        "235,240,245,250,255,260,265,270,275,280,285,290,295,297,300,310,315,320,325,335," +
        "340,345,350,355,360,365,370,375,380,385,390,392,393,395,400,405,410,415,416,420," +
        "425,426,430,435,440,445,450,455,460,462,465,470,475,480,485,490,495,500,505,510," +
        "515,520,525,535,540,545,550,555,560,565,570,580,585,586,590,593,595,600,605,610," +
        "615,620,625,635,640,641,645,650,665,670,675,680,685,690,695,696,697,700,705,706," +
        "720,725,730,731,732,735,736,740,745,750,760,761,762,999,AAA,AAJ,AAM,AAN,AAO,AAS," +
        "AAT,ABC,ABL,ACD,ACF,ACH,ACL,ACS,ADH,ADL,ADV,AFB,AFC,AGS,AIB,AIC,AIR,ALC,ALP,AMB," +
        "AMC,AMP,ANB,ANC,ANS,APL,APT,ARB,ARC,ARG,ARR,ASC,AUX,AVA,BAA,BAB,BAC,BAD,BAF,BAP," +
        "BAS,BBK,BDX,BEY,BFD,BKA,BLA,BLC,BLD,BLK,BLW,BND,BOB,BOP,BRA,BRD,BRG,BSC,BSS,BTC," +
        "BU2,BU4,BUA,BUR,BYD,CA1,CA2,CA4,CAA,CAC,CAD,CAE,CAF,CAG,CAH,CAJ,CAK,CAL,CAO,CAP," +
        "CAQ,CAR,CAS,CAV,CAW,CAZ,CBL,CBO,CBP,CBR,CBW,CBX,CCA,CCH,CCP,CCR,CCS,CDA,CDD,CDF," +
        "CDR,CER,CFC,CFL,CGC,CGL,CGR,CGT,CHE,CHG,CHN,CIR,CIS,CLC,CLD,CLN,CLS,CMC,CMF,CMI," +
        "CMP,CNS,CNV,COA,COC,COD,COF,COL,COM,CON,COP,COR,COU,CPA,CPC,CPE,CPP,CRA,CRF,CRP," +
        "CRR,CRS,CSA,CSC,CSE,CSF,CSP,CSR,CST,CTA,CTC,CTD,CTE,CTF,CTG,CTL,CTO,CTR,CTX,CUA," +
        "CUD,CUF,CUP,CUS,DAA,DAB,DAC,DAD,DAM,DBD,DBL,DBP,DCE,DCS,DCT,DCV,DDA,DDC,DDD,DDF," +
        "DDN,DDP,DDS,DDZ,DEA,DED,DEL,DEM,DEP,DER,DES,DET,DEV,DEW,DEZ,DFD,DFM,DFS,DFW,DGE," +
        "DGS,DIC,DIR,DIS,DIV,DLH,DLP,DMC,DMD,DNA,DOC,DON,DOV,DPB,DPD,DPE,DPL,DPR,DPT,DPU," +
        "DRC,DRP,DRV,DRY,DSC,DSF,DSM,DSR,DST,DTA,DTB,DTC,DTD,DTF,DTL,DTP,DTU,DTV,DWC,DWP," +
        "EAC,EAX,EBD,EBP,ECC,ECR,ECS,EDD,EDO,EEA,EEB,EEC,EEF,EEG,EEH,EEP,EEX,EIC,ELS,EMR," +
        "EMS,EMT,ENC,ENS,EPC,EPS,ERS,ERT,ESA,ESC,ESD,ESE,ETR,EUC,EVC,EXC,EXD,EXL,EXM,EXP," +
        "EXS,EXW,EXZ,FAB,FAC,FAD,FAE,FAF,FAG,FAH,FAK,FBD,FCB,FCD,FCI,FCS,FDL,FDS,FFC,FFI," +
        "FFL,FFN,FFP,FFR,FFS,FIR,FLS,FLT,FMR,FMS,FRC,FTC,FTR,FUE,FWA,FWC,FXE,GAR,GAT,GDR," +
        "GGA,GGF,GKT,GMS,GOC,GPD,GRD,GRS,GSP,GSS,GST,HAN,HAZ,HBD,HDF,HDG,HDH,HDW,HET,HFA," +
        "HHA,HHB,HHG,HIC,HLF,HMA,HMI,HOC,HOL,HOS,HOX,HRS,HSC,HUL,HZC,HZD,HZS,IAA,IAB,IAC," +
        "ICE,IDC,IDD,IDL,IDP,IFC,IHT,IIA,IIH,IIP,IIU,ILD,ILF,ILP,IMP,IMS,INC,INP,INR,INS," +
        "INT,IPC,IPU,IRA,ISD,ISO,IST,ITC,ITS,JST,KIT,LAA,LAB,LAC,LAD,LAE,LAL,LAT,LAY,LBR," +
        "LC2,LC4,LCG,LCL,LCR,LDA,LDG,LDL,LDS,LEC,LFC,LFD,LFT,LGD,LHS,LID,LIE,LLB,LLC,LLD," +
        "LLF,LLS,LMC,LMD,LME,LNT,LOA,LOC,LPC,LPD,LPF,LQD,LSC,LSH,LSS,LTC,LTE,LUB,LUP,LUS," +
        "LYC,MAA,MAB,MAC,MAD,MAE,MAR,MAT,MCC,MDG,MDM,MEA,MEN,MES,MET,MFC,MFG,MGA,MGC,MIC," +
        "MIL,MIN,MKU,MLB,MLS,MMC,MMF,MMS,MMT,MNC,MNS,MPC,MRK,MRP,MSC,MSG,MTR,MUS,MVR,MVS," +
        "MVT,NAA,NAB,NAL,NCH,NDS,NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,OCH,OCN,ODF,OFR,OFU," +
        "ONC,OOC,OOD,OOF,OPC,ORC,ORM,OSC,OSO,OSS,OUT,OVR,OWC,PAA,PAC,PAD,PAE,PAF,PAG,PAH," +
        "PAI,PAJ,PAK,PAL,PAR,PAT,PAV,PBA,PBE,PBL,PCH,PCT,PDB,PDC,PDS,PDY,PEC,PEN,PER,PFA," +
        "PHC,PHG,PIR,PKS,PLC,PLT,PMC,PMR,PMS,PMT,PMU,PMX,PNA,POC,POD,POL,POS,PPC,PPD,PPH," +
        "PPI,PPM,PPN,PPO,PPR,PPS,PPT,PPU,PRB,PRC,PRE,PRK,PRL,PRM,PRP,PRS,PRV,PSC,PSD,PSG," +
        "PSH,PSS,PST,PTC,PTS,PUC,PUD,PUK,PVB,PVD,PVI,PVL,PVP,PVS,PVT,PWH,PWT,PYS,QAA,QQD," +
        "RAA,RAB,RAC,RAD,RAE,RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCC,RCD,RCE,RCG,RCL," +
        "RCP,RCS,RDC,RDF,RDH,REC,REE,REF,REG,REL,REP,REQ,RES,RET,RFD,RFM,RGA,RGC,RHM,RID," +
        "RIE,RLA,RLC,RLQ,RLS,RMB,RMC,RMD,RMP,RMS,ROC,RPC,RPD,RRC,RRD,RRF,RRN,RRP,RRR,RSM," +
        "RSP,RSS,RST,RSV,RTC,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SAK,SAM,SAN,SAP,SAS," +
        "SAT,SBC,SBL,SCC,SCD,SCG,SCL,SCU,SDC,SDL,SDS,SEC,SEE,SEG,SEL,SEQ,SER,SEV,SFB,SFC," +
        "SFD,SFE,SFT,SGL,SHH,SHL,SHS,SHW,SKT,SLC,SLP,SMS,SNS,SNT,SOC,SOP,SPA,SPB,SPC,SPD," +
        "SPL,SPP,SPS,SPT,SPU,SRG,SRS,SSA,SSB,SSC,SSF,SSL,SSO,SSP,SSS,SST,SSU,SSX,STA,STC," +
        "STD,STF,STL,STM,STO,STP,STQ,STR,STW,SUC,SUF,SUP,SUR,SVA,SVL,SVS,SWC,TAA,TAB,TAC," +
        "TAD,TAE,TAF,TAG,TAH,TAI,TAJ,TAK,TAL,TAR,TAX,TAY,TCB,TCM,TDT,TER,TLC,TMS,TMV,TOA," +
        "TOC,TPA,TPC,TPS,TRA,TRC,TRE,TRF,TRM,TRN,TRP,TRS,TRU,TSC,TSS,TST,TTA,TTB,TTD,TTL," +
        "TTM,TTP,TTR,TTS,TTT,TTU,TTV,TUR,TWO,UFC,UND,UNL,UPD,UPK,URC,USF,USV,USW,UTL,UTP," +
        "UUC,UUM,UUT,VAA,VAB,VCL,VCR,VEX,VFN,VIS,VIT,VOR,VSO,VTS,VVL,VVP,WAR,WAT,WBB,WCT," +
        "WDS,WEA,WEI,WFG,WFH,WFT,WHC,WRB,WRC,WRE,WRI,WSA,WTG,WTM,WTV,WWC,Z01,Z02,Z03,Z04," +
        "Z05,Z06,Z07,Z08,Z09,Z10,Z11,Z12,Z13,Z14,Z15,Z16,Z17,Z18,Z19,Z20,Z21,Z22,Z23,Z24," +
        "Z25,Z26,Z27,Z28,Z29,Z30,Z31,Z32,Z33,Z34,Z35,ZFF,ZZZ,")]
    public class X12_ID_150
    {
    }
    
    /// <summary>
    /// Type of Deduction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CS,II,IO,IT,RI,RO,RT,")]
    public class X12_ID_1511
    {
    }
    
    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,15,16,17,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514
    {
    }
    
    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",045,15,170,25,35,45,510,520,550,555,565,570,585,665,670,675,761,A1M,A3M,A5M,AAS," +
        "AB,ADL,AFN,AGG,AGS,AIB,AK,ALP,ALT,AMM,ANC,APD,APL,ARC,ARG,ARR,ART,ASY,AT,AUX,AV," +
        "AW,BA,BCP,BKA,BL,BLK,BLS,BN,BNS,BOX,BU2,BU4,BUA,BW,CA2,CA4,CAR,CC,CCB,CCH,CCS,CD" +
        ",CDD,CE,CF,CFC,CFL,CGC,CGR,CGT,CH,CHN,CI,CIP,CIS,CLN,CLS,CM,CMD,CNL,CNS,CO,CON,C" +
        "OR,COU,COV,CPC,CPM,CR,CRL,CSD,CSP,CTL,CTM,CTR,CUF,CW,CX,CY,DA,DBL,DBP,DCS,DDN,DD" +
        "P,DDS,DDZ,DE,DEL,DEP,DET,DEZ,DFD,DFM,DFS,DIS,DLP,DLR,DM,DN,DNC,DNF,DNT,DOC,DOV,D" +
        "PB,DPD,DPE,DPL,DPT,DPU,DR,DRO,DRU,DS,DSK,DSM,DSR,DSV,DT,DTB,DTP,DTV,DU,DV,DW,DWP" +
        ",EAX,ECR,ECS,ED,EDD,EDO,EE,EED,EL,ELS,EMR,EMT,END,EP,ER,ERS,ERT,EV,EW,EX,EXC,EXD" +
        ",EXL,EXO,EXP,EXQ,EXT,EXU,EXZ,EZE,FA,FAK,FAS,FB,FC,FCS,FD,FFC,FFS,FG,FL,FLS,FP,FP" +
        "T,FR,FRZ,FS,FST,FTR,GI,GMS,GOC,GSP,GSS,HAL,HAN,HBR,HDH,HDW,HE,HEA,HES,HET,HH,HM," +
        "HMA,HMI,HO,HOL,HOR,HOS,HOX,HP,HQT,HR,HRS,HT,HTI,HV,HW,HZC,HZD,IB,IC,ID,IDC,IDL,I" +
        "IH,IM,IMP,IMS,INT,IP,IPU,IR,IS,ITS,JIT,JLX,JS,KEG,KMD,LAB,LAY,LB,LBL,LBR,LBT,LC," +
        "LC2,LC4,LCL,LD,LEC,LF,LFD,LHS,LIE,LMD,LME,LN,LP,LPD,LR,LS,LT,LTE,LTT,LYC,MAT,MC," +
        "MEN,MES,MET,MF,MIN,MNS,MOT,MP,MR,MRF,MSS,MTE,MVS,NC,ND,NE,NH,NHC,NHL,NI,NP,NPR,N" +
        "S,NSV,NT,NW,NX,OAH,OBL,OCA,OCL,OCN,OCS,OCV,ODI,OEH,OFH,OFU,OHC,OIL,ONC,ONS,OOB,O" +
        "OD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTH,OTO,OTS,OUC,OUW,OV,OVR,OWC,OWR,PAJ,PAV,PB," +
        "PD,PDS,PDY,PER,PFH,PG,PHR,PI,PIR,PMM,PMR,PMS,PMT,POC,PPD,PRL,PRT,PS,PSG,PSS,PTS," +
        "PUC,PUD,PUK,PUP,PVB,PVD,PVI,PVL,PVP,PVS,PVT,PW,PYS,RA,RB,RC,RCC,RCL,RDH,RDR,REP," +
        "RES,RFM,RIE,RLS,RM,RMC,RMP,RMS,RO,RPD,RR,RRR,RS,RSP,RSS,RSV,RT,RWR,SAS,SAT,SB,SC" +
        ",SCC,SCL,SD,SDL,SDS,SE,SEC,SED,SEE,SER,SEV,SFB,SFD,SFE,SFT,SGL,SH,SHH,SHL,SHW,SI" +
        ",SK,SKT,SLC,SM,SMP,SMS,SNM,SNS,SNT,SOC,SOL,SP,SPC,SPR,SPT,SPU,SR,SRG,SRS,SSC,SSN" +
        ",SSU,ST,STA,STD,STO,STP,STR,SUA,SUB,SUP,SVS,SW,TA,TC,TDC,TDP,TER,TF,TLS,TMS,TMV," +
        "TN,TOF,TPS,TRA,TRK,TRL,TRM,TRN,TRP,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UFC,UI,UL,UN," +
        "UP,UPK,UR,URC,US,UTL,VAC,VAN,VCL,VFN,VIS,VN,VSO,VT,VTS,WB,WBB,WCT,WD,WDS,WE,WFG," +
        "WH,WI,WM,WO,WRB,WRI,WTV,WW,XP,XT,ZZZ,")]
    public class X12_ID_152
    {
    }
    
    /// <summary>
    /// Display Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,")]
    public class X12_ID_1520
    {
    }
    
    /// <summary>
    /// Marketing Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,")]
    public class X12_ID_1521
    {
    }
    
    /// <summary>
    /// Coupon Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,")]
    public class X12_ID_1522
    {
    }
    
    /// <summary>
    /// Labor Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,")]
    public class X12_ID_1523
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
    /// Net Cost Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1540
    {
    }
    
    /// <summary>
    /// Equipment Orientation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,")]
    public class X12_ID_1543
    {
    }
    
    /// <summary>
    /// Preferential Duty Criteria Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1546
    {
    }
    
    /// <summary>
    /// Convertibility Rate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,ZZ,")]
    public class X12_ID_1549
    {
    }
    
    /// <summary>
    /// Index Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1550
    {
    }
    
    /// <summary>
    /// Option Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,ZZ,")]
    public class X12_ID_1552
    {
    }
    
    /// <summary>
    /// License Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,C1,C2,C3,F1,MV,P1,R1,S1,U1,U2,U3,U4,")]
    public class X12_ID_1553
    {
    }
    
    /// <summary>
    /// Tag Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,R,S,U,W,")]
    public class X12_ID_1554
    {
    }
    
    /// <summary>
    /// Automatic Equipment Identification Consist Confidence Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,G,M,")]
    public class X12_ID_1555
    {
    }
    
    /// <summary>
    /// Train Termination Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,O,T,")]
    public class X12_ID_1556
    {
    }
    
    /// <summary>
    /// Movement Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1557
    {
    }
    
    /// <summary>
    /// Academic Summary Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class X12_ID_1558
    {
    }
    
    /// <summary>
    /// Automatic Equipment Identification Site Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,O,Q,R,S,T,U,V,X,Y,Z,")]
    public class X12_ID_1559
    {
    }
    
    /// <summary>
    /// Interchange Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,I,N,O,P,R,S,T,V,W,")]
    public class X12_ID_1560
    {
    }
    
    /// <summary>
    /// Rail Junction Settlement Role Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,S,")]
    public class X12_ID_1561
    {
    }
    
    /// <summary>
    /// Shipment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",2,3,A,A1,A2,A3,A4,AA,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AR,AV,AW,B,BA,BC,BD,BE,BF,BR,C,C1,C2,CA,CB,CC,CD,CI,CO,CR,CS,CT,CU,CV,D,DA,DC,DN,DP,DR,DS,DT,E,EA,ED,EE,EI,EP,ER,F,FP,FT,G,GI,GO,H,HA,HE,HF,HG,HH,HI,HR,I,IB,IR,J,K,L,LD,LP,MT,N,NC,ND,NF,NH,NO,NP,NR,NS,NT,NU,O,OA,OB,OF,OH,ON,P,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,R,RA,RB,RC,RD,RI,RL,RN,S,SA,SB,SC,SD,SI,SN,T,TC,TM,TO,U,UA,UB,UC,UD,UE,UP,UR,UV,UW,V,VA,VD,W,WH,WR,X,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB,Y,Z,ZZ,")]
    public class X12_ID_157
    {
    }
    
    /// <summary>
    /// Filter ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ASB,ASC,HDC,R64,UUE,ZZZ,")]
    public class X12_ID_1570
    {
    }
    
    /// <summary>
    /// Security Value Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ASV,CRT,PUB,")]
    public class X12_ID_1572
    {
    }
    
    /// <summary>
    /// Inspected/Weighed Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IB,II,IW,")]
    public class X12_ID_1576
    {
    }
    
    /// <summary>
    /// Hazardous Material Regulations Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1577
    {
    }
    
    /// <summary>
    /// Export Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CN,DP,GS,HH,HR,MS,PP,UP,UR,")]
    public class X12_ID_1578
    {
    }
    
    /// <summary>
    /// Accrual Rate Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",S,W,X,")]
    public class X12_ID_1579
    {
    }
    
    /// <summary>
    /// Shape Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CN,CY,OV,RL,SQ,TR,")]
    public class X12_ID_1585
    {
    }
    
    /// <summary>
    /// Political Party Affiliation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,CM,CN,DM,FR,GN,GR,IN,LL,LR,LT,NP,OT,PF,RL,RP,SC,SL,TX,ZZ,")]
    public class X12_ID_1588
    {
    }
    
    /// <summary>
    /// Asset Liability Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A5,A6,A7,A8,B1,B2,B3,B4,B5,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,D1,D2,D3,D4,D5,D6,E1,E2,E3,E4,E5,E6,F1,G1,G2,G3,G4,G5,G6,H1,H2,H3,I1,I2,I3,I4,I5,I6,I7,J1,L1,L2,L3,L4,M1,M2,M3,M4,M5,M6,N1,N2,N3,N4,N5,O1,O2,O3,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,R1,R2,R3,R4,R5,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,U1,U2,U3,W1,ZZ,")]
    public class X12_ID_1590
    {
    }
    
    /// <summary>
    /// Type of Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",24,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF,AH,AI,B1,B2,B3,B4,B5,B6,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,D1,D2,DR,E1,E2,F1,F2,F3,F4,F5,G1,G2,G3,H1,H2,H3,H4,I1,I2,I3,I4,I5,I6,J1,J2,K1,K2,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,N1,O1,O2,O3,O4,O5,O6,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,R1,R2,R3,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,T1,T2,U1,U2,U3,U4,W1,W2,W3,W4,")]
    public class X12_ID_1591
    {
    }
    
    /// <summary>
    /// Type of Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,B1,D1,D2,D3,D4,D5,F1,F2,F3,G1,I1,I2,I3,I4,I5,L1,M1,M2,N1,N2,P1,R1" +
        ",S1,S2,S3,S4,U1,V1,")]
    public class X12_ID_1592
    {
    }
    
    /// <summary>
    /// Controlled Substance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,B1,B2,B3,C1,C2,C3,C4,C5,C6,C7,C8,D1,H1,H2,H3,H4,H5,L1,M1,M2,M3,N1,N2,N3,O1" +
        ",O2,P1,P2,P3,P4,P5,S1,S2,S3,S4,S5,S6,T1,T2,W1,")]
    public class X12_ID_1594
    {
    }
    
    /// <summary>
    /// Government Service Affiliation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,")]
    public class X12_ID_1595
    {
    }
    
    /// <summary>
    /// Military Service Rank Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,B1,B2,C1,C2,C3,C4,C5,C6,C7,C8,C9,E1,F1,F2,F3,F4,G1,G4,L1,L2,L3,L4,L5,L6" +
        ",M1,M2,M3,M4,M5,M6,P1,P2,P3,P4,P5,R1,R2,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,T1,V" +
        "1,W1,")]
    public class X12_ID_1596
    {
    }
    
    /// <summary>
    /// Hazardous Vehicle Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,B1,B2,B3,B4,B5,B6,C1,C2,C3,C4,C5,C6,C7,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,E1,E2,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,G1,G2,G3,G4,G5,H1,H2,H3,H4,H5,H6,I1,I2,I3,J1,J2,J3,J4,K1,L1,L2,L3,L4,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,O1,O2,O3,O4,P1,P2,P3,P4,P5,P6,R1,R2,R3,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,T1,T2,T3,T4,U1,U2,U3,U4,V1,V2,V3,W1,")]
    public class X12_ID_1599
    {
    }
    
    /// <summary>
    /// Charge Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,P,")]
    public class X12_ID_16
    {
    }
    
    /// <summary>
    /// Status Report Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,R,S,")]
    public class X12_ID_160
    {
    }
    
    /// <summary>
    /// Freight Rate Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CW,FR,PE,PF,PG,PM,PR,PT,SY,")]
    public class X12_ID_1600
    {
    }
    
    /// <summary>
    /// Rated-as Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AS,BW,CF,DW,FR,GA,HR,HW,MI,SY,TR,UN,")]
    public class X12_ID_1601
    {
    }
    
    /// <summary>
    /// Bill of Lading Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADF,ADV,BLK,COD,COL,DEL,DEP,DET,DIB,DSC,EIC,EXC,FLT,FSC,IDL,IPU,LDA,LDL,MIL,MIN," +
        "MRK,MSG,ONC,PLA,PWH,REP,RES,SOC,SPU,SRG,SUF,ZZZ,")]
    public class X12_ID_1602
    {
    }
    
    /// <summary>
    /// Animal Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,ZY,ZZ,")]
    public class X12_ID_1606
    {
    }
    
    /// <summary>
    /// Test Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,ZZ,")]
    public class X12_ID_1607
    {
    }
    
    /// <summary>
    /// Related Data Identification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AN,DFI,DT,EI,ES,IN,LI,MA,MV,PO,PR,PS,QY,RP,RS,RT,TT,TX,UP,")]
    public class X12_ID_1609
    {
    }
    
    /// <summary>
    /// International Dutiable Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DO,LT,ND,ZZ,")]
    public class X12_ID_1610
    {
    }
    
    /// <summary>
    /// Observation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,ZZ,")]
    public class X12_ID_1611
    {
    }
    
    /// <summary>
    /// Tissue or Specimen Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,I,M,N,U,")]
    public class X12_ID_1612
    {
    }
    
    /// <summary>
    /// Neoplasm Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,M,S,U,")]
    public class X12_ID_1617
    {
    }
    
    /// <summary>
    /// Parturition Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,")]
    public class X12_ID_1619
    {
    }
    
    /// <summary>
    /// Offspring Count Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,ZZ,")]
    public class X12_ID_1620
    {
    }
    
    /// <summary>
    /// Offspring/Fetus Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,ZY,ZZ,")]
    public class X12_ID_1622
    {
    }
    
    /// <summary>
    /// Interest Rate Calculation Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1626
    {
    }
    
    /// <summary>
    /// Underwriting Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,T,")]
    public class X12_ID_1627
    {
    }
    
    /// <summary>
    /// Information Request Result Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,Z,")]
    public class X12_ID_1629
    {
    }
    
    /// <summary>
    /// Stop Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,CL,CN,CU,DR,DT,HT,IN,LD,LE,PA,PL,PU,RT,SL,SU,TL,UL,WL,")]
    public class X12_ID_163
    {
    }
    
    /// <summary>
    /// Thoroughfare Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,B,C,D,E,F,G,H,I,J,M,S,V,W,Z,")]
    public class X12_ID_1630
    {
    }
    
    /// <summary>
    /// Thoroughfare Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,H,L,R,S,Z,")]
    public class X12_ID_1631
    {
    }
    
    /// <summary>
    /// General Territory Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_1632
    {
    }
    
    /// <summary>
    /// Financial Statement Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,G,H,Z,")]
    public class X12_ID_1633
    {
    }
    
    /// <summary>
    /// Business Professional Title Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,2,2" +
        "A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,3,4,5,6,7" +
        ",8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_1634
    {
    }
    
    /// <summary>
    /// General Property Ownership Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,J,L,M,S,U,Z,")]
    public class X12_ID_1635
    {
    }
    
    /// <summary>
    /// Account Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,F,G,H,I,J,L,M,N,O,P,Q,R,S,T,U,Z,")]
    public class X12_ID_1636
    {
    }
    
    /// <summary>
    /// Net/Gross Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,N,")]
    public class X12_ID_1637
    {
    }
    
    /// <summary>
    /// Value Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,Z,")]
    public class X12_ID_1638
    {
    }
    
    /// <summary>
    /// Cryptographic Management Purpose
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CCP,CER,CEX,CRQ,CRT,CRV,CSR,PUB,")]
    public class X12_ID_1642
    {
    }
    
    /// <summary>
    /// Service Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CS,CT,FA,FP,RE,ST,")]
    public class X12_ID_1644
    {
    }
    
    /// <summary>
    /// Shipment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A3,A7,A9,AF,AG,AH,AI,AJ,AM,AN,AP,AR,AV,B6,BA,BC,C1,CA,CD,CL,CP,D1,I1,J1,K1,L1,OA" +
        ",OO,P1,PR,R1,RL,S1,SD,X1,X2,X3,X4,X5,X6,X8,XB,")]
    public class X12_ID_1650
    {
    }
    
    /// <summary>
    /// Shipment Status or Appointment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A5,A6,AA,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B4,B5,B8,B9,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,D1,D2,F1,F2,HB,NA,NS,P1,P2,P3,P4,RC,S1,T1,T2,T3,T4,T5,T6,T7,")]
    public class X12_ID_1651
    {
    }
    
    /// <summary>
    /// Shipment Appointment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,ED,EP,LD,LP,X9,XA,")]
    public class X12_ID_1652
    {
    }
    
    /// <summary>
    /// Premium Rate Pattern Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class X12_ID_1656
    {
    }
    
    /// <summary>
    /// Premium Source Entity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,")]
    public class X12_ID_1657
    {
    }
    
    /// <summary>
    /// Shipment or Work Assignment Decline Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CPT,CPU,EQT,EQU,LNH,PRM,WGT,")]
    public class X12_ID_1658
    {
    }
    
    /// <summary>
    /// Look-up Value Protocol Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,ZZ,")]
    public class X12_ID_1675
    {
    }
    
    /// <summary>
    /// Insurer Guarantor Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,F,N,P,S,Z,")]
    public class X12_ID_1678
    {
    }
    
    /// <summary>
    /// Insurer Coverage Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,L,")]
    public class X12_ID_1679
    {
    }
    
    /// <summary>
    /// Refinance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,")]
    public class X12_ID_1680
    {
    }
    
    /// <summary>
    /// Primary Source of Index Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,")]
    public class X12_ID_1681
    {
    }
    
    /// <summary>
    /// Tax Treatment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,N,")]
    public class X12_ID_1685
    {
    }
    
    /// <summary>
    /// Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,CB,CE,D,E,ED,EP,F,G,H,I,J,K,L,LD,LP,M,N,O,P,Q,R,S,T,U," +
        "V,W,X,Y,Z,")]
    public class X12_ID_176
    {
    }
    
    /// <summary>
    /// Quantity or Status Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",03,04,05,06,07,51,52,53,54,55,56,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AN,AP,AR,AS" +
        ",AT,AU,AV,AW,AX,AY,BA,BD,BK,BM,BN,BR,BS,BT,CD,CO,CR,CS,PC,TC,UD,")]
    public class X12_ID_181
    {
    }
    
    /// <summary>
    /// Volume Unit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,H,L,M,N,R,S,T,U,V,X,")]
    public class X12_ID_184
    {
    }
    
    /// <summary>
    /// Weight Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,A1,A2,A3,A4,B,C,CD,CE,D,DR,E,F,FR,G,H,I,J,K,L,LC,M,N,ND,NI,NR,NT,O,P,PA,Q,R,RG" +
        ",RN,RT,S,SF,SI,SK,SO,T,U,V,W,WA,WB,WG,WJ,X,Y,Z,")]
    public class X12_ID_187
    {
    }
    
    /// <summary>
    /// Weight Unit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,G,K,L,M,O,S,T,")]
    public class X12_ID_188
    {
    }
    
    /// <summary>
    /// Accomplish Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,P,")]
    public class X12_ID_190
    {
    }
    
    /// <summary>
    /// Agent/Shipper Routing Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,R,S,")]
    public class X12_ID_192
    {
    }
    
    /// <summary>
    /// Capacity Load Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,G,M,T,V,")]
    public class X12_ID_195
    {
    }
    
    /// <summary>
    /// Mortgagee Information Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AH,AS,BH,BS,NC,NH,NS,")]
    public class X12_ID_197
    {
    }
    
    /// <summary>
    /// Confidential Billing Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,M,N,R,")]
    public class X12_ID_199
    {
    }
    
    /// <summary>
    /// Business Transaction Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BNR,DCP,DNP,DPP,FCP,FNP,FPP,LGR,OBR,TCR,TNR,TPR,")]
    public class X12_ID_201
    {
    }
    
    /// <summary>
    /// Correction Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AI,AR,B1,BA,BD,BE,BO,CA,CM,CO,CP,CS,CT,CU,D1,DC,DE,DP,DS,EM,MB,MD,MR,NC,ND,PD" +
        ",RB,RC,RD,RE,RL,SC,SP,TL,WC,")]
    public class X12_ID_202
    {
    }
    
    /// <summary>
    /// Hazardous Material Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4,6,9,A,C,D,E,F,I,R,T,U,X,")]
    public class X12_ID_208
    {
    }
    
    /// <summary>
    /// International/Domestic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,I,")]
    public class X12_ID_210
    {
    }
    
    /// <summary>
    /// Packaging Form Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AMM,BAG,BAL,BBL,BDL,BEM,BIC,BIN,BKG,BLK,BOB,BOT,BOX,BRG,BSK,BXI,BXT,CAB,CAG,CAN,CAR,CAS,CBC,CBY,CCS,CHE,CHS,CLD,CNA,CNB,CNC,CND,CNE,CNF,CNT,CNX,COL,CON,COR,CRD,CRT,CSK,CTN,CUB,CYL,DBK,DRK,DRM,DSK,DTB,DUF,ENV,FIR,FLO,FLX,FRM,FSK,FWR,GOH,HED,HGH,HPR,HPT,HRB,HRK,HTB,JAR,JUG,KEG,KIT,KRK,KTB,LBK,LIF,LOG,LSE,LUG,LVN,MLV,MRP,MSV,MXD,NOL,OVW,PAL,PCK,PCS,PIR,PKG,PLF,PLN,PLT,POV,PRK,QTR,RAL,RCK,REL,ROL,RVR,SAK,SBC,SCS,SHK,SHT,SID,SKD,SKE,SLP,SLV,SPI,SPL,SVN,TBE,TBN,TKR,TKT,TLD,TNK,TRC,TRI,TRK,TRU,TRY,TSS,TTC,TUB,UNP,UNT,VEH,VPK,WHE,WLC,WRP,")]
    public class X12_ID_211
    {
    }
    
    /// <summary>
    /// Waybill Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,H,P,")]
    public class X12_ID_214
    {
    }
    
    /// <summary>
    /// Metric Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,")]
    public class X12_ID_216
    {
    }
    
    /// <summary>
    /// Billed/Rated-as Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AR,BA,BX,CC,CF,CM,DK,DM,DR,EA,FR,FT,GC,GL,KG,LB,LC,LH,LR,MR,MT,MV,NB,NC,ND,NG,NL" +
        ",NN,NP,NR,NT,NU,NV,OR,PK,PR,RV,SP,ST,SY,TD,TH,TN,TR,VA,VC,VM,")]
    public class X12_ID_221
    {
    }
    
    /// <summary>
    /// Section Seven Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,S,")]
    public class X12_ID_226
    {
    }
    
    /// <summary>
    /// Commodity Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,Q,S,T,U,V,Z,")]
    public class X12_ID_23
    {
    }
    
    /// <summary>
    /// Cross Reference Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,F,G,H,K,L,M,N,R,S,T,X,")]
    public class X12_ID_231
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,DD,DE,DF,DG,DI,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EP,EQ,ER,ES,EU,EX,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FS,FT,FW,GA,GC,GD,GE,GI,GK,GN,GQ,GR,GS,GU,HC,HD,HI,HN,IA,IB,IC,ID,IE,IF,IG,IM,IN,IP,IQ,IR,IS,IT,IV,IW,IZ,JA,JB,JC,JD,JN,JP,JS,KA,KB,KD,KE,KF,KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,L4,L5,LA,LB,LC,LD,LG,LP,LR,LS,LT,LU,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,N1,N2,N3,N4,N5,N6,NC,ND,NE,NH,NM,NR,NU,NW,NZ,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,OR,OT,P1,P2,P3,P4,P5,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R1,R2,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,RZ,S2,S3,S4,S5,S6,S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TM,TN,TP,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U2,U3,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,UX,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,W6,W7,WA,WC,WL,WR,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BBP,BCH,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    /// <summary>
    /// Car Service Order Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",145,145A,145S,145X,150,150X,155,155A,155S,34617,34618,34619,435,435A,435S,439,CM" +
        "D1A,CMD1S,CSR5,")]
    public class X12_ID_240
    {
    }
    
    /// <summary>
    /// Protective Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BC,D,HDN,HDNC,HSC,M,MN,MNU,")]
    public class X12_ID_241
    {
    }
    
    /// <summary>
    /// Vent Instruction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",V40,VC,VD40,VDOI,VO,VOI,VS,VS10,")]
    public class X12_ID_242
    {
    }
    
    /// <summary>
    /// Certification/Clause Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,AM,CB,CC,CP,DC,DV,EE,E" +
        "R,GS,HD,HN,IS,NF,")]
    public class X12_ID_246
    {
    }
    
    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,N,P,Q,R,S,")]
    public class X12_ID_248
    {
    }
    
    /// <summary>
    /// Vessel Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,O,R,S,")]
    public class X12_ID_249
    {
    }
    
    /// <summary>
    /// Automobile Ramp Facility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,N,P,T,")]
    public class X12_ID_253
    {
    }
    
    /// <summary>
    /// Manifest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,P,S,T,V,W,X,Y,Z,")]
    public class X12_ID_256
    {
    }
    
    /// <summary>
    /// Tariff Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,I,N,R,S,")]
    public class X12_ID_257
    {
    }
    
    /// <summary>
    /// Change Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,T,W,X,")]
    public class X12_ID_259
    {
    }
    
    /// <summary>
    /// Source of Disclosure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,")]
    public class X12_ID_261
    {
    }
    
    /// <summary>
    /// Geography Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,I,L,O,P,T,U,")]
    public class X12_ID_262
    {
    }
    
    /// <summary>
    /// Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,15,16,17,18,19,20,")]
    public class X12_ID_263
    {
    }
    
    /// <summary>
    /// Subsidiary Risk Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,")]
    public class X12_ID_271
    {
    }
    
    /// <summary>
    /// Hazardous Certification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_272
    {
    }
    
    /// <summary>
    /// Terms Due Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_283
    {
    }
    
    /// <summary>
    /// Service Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,09,3D,9A,AC,AE,AM,BC,CB,CE,CG,CX,D1,D2,D3,DC,DF,DR,DS,DT,ES,ET,FC,G2,GP,GT,IA" +
        ",IE,IX,ME,MW,ND,NF,NH,NM,NS,ON,PA,PB,PC,PI,PM,PN,PO,PR,PS,R1,R2,R3,R4,R5,R6,R7,R" +
        "8,RS,SA,SC,SD,SE,SG,SH,SI,SM,SP,ST,ZZ,")]
    public class X12_ID_284
    {
    }
    
    /// <summary>
    /// Product/Service Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,ZZ,")]
    public class X12_ID_286
    {
    }
    
    /// <summary>
    /// Authorize/ De-Authorize Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,")]
    public class X12_ID_287
    {
    }
    
    /// <summary>
    /// Prepriced Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,N,Y,Z,")]
    public class X12_ID_288
    {
    }
    
    /// <summary>
    /// Price Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class X12_ID_290
    {
    }
    
    /// <summary>
    /// Price Condition Applies Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,")]
    public class X12_ID_291
    {
    }
    
    /// <summary>
    /// Quantity Basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,")]
    public class X12_ID_292
    {
    }
    
    /// <summary>
    /// Promotion Condition Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,99,")]
    public class X12_ID_293
    {
    }
    
    /// <summary>
    /// Distance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,K,L,M,T,X,")]
    public class X12_ID_295
    {
    }
    
    /// <summary>
    /// Event Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAD,ACA,ACC,ADR,ALR,ALV,ANO,APU,ARD,ARI,ARR,ASO,BAD,BFR,BHV,BLG,BOH,CCT,CG1,COC,CRD,CSL,CTU,DDL,DEC,DEL,DEP,DFL,DRM,DSI,EAD,EDD,EFT,ERD,ETA,EWI,EWL,FOL,FTE,HAR,HMI,HRE,IBD,ICH,ICR,IGT,INC,INV,IRD,IRI,ITS,MAL,MWY,NOB,NOT,OCA,OGT,OID,OIR,ORI,OSI,OTS,PAC,PCO,PEN,PFP,POS,PRB,RAM,REC,REJ,REP,RET,RLO,RMT,RYD,SAD,SAT,SDD,SLD,SPD,SPT,STA,STI,STN,STP,STS,STU,SUS,TDL,TMA,TMD,TOD,TPL,TRN,TRP,UNS,WAI,WGH,WIT,WYB,ZZX,ZZY,ZZZ,")]
    public class X12_ID_304
    {
    }
    
    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,X,Z,")]
    public class X12_ID_305
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AP,AQ,AR,AS,AT,AV,AW,AX,B,BD,BI,BO,C,C1,C2,CA,CB,CC,CD,CE,CF,CG,CL,CM,CN,CO,CP,CS,CT,CU,CV,CX,D,D1,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DP,DR,DS,DT,DX,E,EA,EB,EC,ED,EE,EN,EP,ER,EV,EX,F,F1,FA,FC,FI,FO,FR,G,GR,H,HR,I,I1,IA,IM,IN,IS,IT,J,JA,JO,JU,K,KA,L,LC,LQ,M,ME,MO,N,NA,ND,NP,NS,O,OD,OP,OR,OT,P,P1,PA,PB,PC,PD,PF,PI,PJ,PO,PP,PR,PS,PT,PU,PV,Q,R,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,S,S1,S2,SA,SB,SC,SD,SE,SL,SR,SS,SU,SV,SZ,T,TD,TE,TG,TN,TP,TR,TS,TU,U,V,VA,W,W1,WD,WI,WQ,WV,X,Y,Z,")]
    public class X12_ID_306
    {
    }
    
    /// <summary>
    /// Damage Exception Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_308
    {
    }
    
    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CI,CL,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,GL,H,I,IA,IB,IM,IP,IS,IT,K,KE,KL,KP,L,LO,M,MI,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PO,PP,PQ,PR,PS,PT,PU,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,ZN,ZZ,")]
    public class X12_ID_309
    {
    }
    
    /// <summary>
    /// Shipment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,CS,RJ,ST,")]
    public class X12_ID_311
    {
    }
    
    /// <summary>
    /// Special Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,L,N,O,T,")]
    public class X12_ID_312
    {
    }
    
    /// <summary>
    /// Authority Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,CA,FN,LO,NR,PP,RC,RV,SH,SO,")]
    public class X12_ID_313
    {
    }
    
    /// <summary>
    /// Intermodal Facility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,")]
    public class X12_ID_321
    {
    }
    
    /// <summary>
    /// Load/Empty Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,L,T,")]
    public class X12_ID_322
    {
    }
    
    /// <summary>
    /// Lading Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,E,O,P,W,")]
    public class X12_ID_33
    {
    }
    
    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,15,18,20,21,25,CA,CC,PP,ZZ,")]
    public class X12_ID_331
    {
    }
    
    /// <summary>
    /// Terms Basis Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",09,1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_333
    {
    }
    
    /// <summary>
    /// Transportation Terms Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,ZZ,")]
    public class X12_ID_334
    {
    }
    
    /// <summary>
    /// Transportation Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CAF,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,DOM,DUP,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,FOB," +
        "FOR,FOT,NPF,PPF,ZZZ,")]
    public class X12_ID_335
    {
    }
    
    /// <summary>
    /// Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,52,54,55,5" +
        "6,57,58,61,63,64,65,CA,CO,NC,PP,ZZ,")]
    public class X12_ID_336
    {
    }
    
    /// <summary>
    /// Allowance or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,105,106,107,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,4,40,41,42,43,44,45,46,47,48,490,491,499,5,50,501,502,503,504,505,506,507,508,509,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524,525,526,527,53,537,54,55,550,560,561,562,565,566,57,58,6,60,61,62,63,64,65,66,67,68,70,80,81,88,90,91,92,93,94,95,96,97,990,999,")]
    public class X12_ID_340
    {
    }
    
    /// <summary>
    /// Unit of Time Period or Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AD,AM,AN,AP,AY,BD,BM,BW,CC,CY,DA,DW,DY,EL,F1,F2,FY,HR,ID,KK,KL,LN,LT,MD,MI,MO" +
        ",MS,MT,NX,PA,PD,PM,PR,Q1,Q2,Q3,Q4,QY,SA,SD,SH,SM,SP,TY,WK,WW,WY,YD,ZZ,")]
    public class X12_ID_344
    {
    }
    
    /// <summary>
    /// Lead Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AP,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD" +
        ",BE,BF,BG,")]
    public class X12_ID_345
    {
    }
    
    /// <summary>
    /// Application Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47" +
        ",48,AN,AT,BD,BG,BH,BL,BN,BR,BT,CD,CF,CI,CL,CO,DL,DO,DT,EP,FA,FR,HR,IS,LB,LS,LT,M" +
        "F,PC,PI,PL,PP,PS,R1,R2,R3,R4,RD,RO,RP,RQ,RR,RS,S1,S2,SI,SL,SP,SS,T1,T2,T3,T4,TF," +
        "TG,TM,TQ,ZZ,")]
    public class X12_ID_346
    {
    }
    
    /// <summary>
    /// Item Description Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,S,X,")]
    public class X12_ID_349
    {
    }
    
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28" +
        ",30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,5" +
        "6,5C,77,CN,CO,EX,GR,PR,RH,RV,SU,ZZ,")]
    public class X12_ID_353
    {
    }
    
    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2F,2G,2" +
        "H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3B," +
        "3C,3E,3F,3G,3H,3I,40,41,43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M" +
        ",4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,50,51,52,53,54,56,57,58,59,5A,5B,5C,5E,5F,5G,5" +
        "H,5I,5J,5K,5P,5Q,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81," +
        "82,83,84,85,86,87,89,8C,8D,8P,8R,8S,8U,90,91,92,93,94,95,96,97,98,99,A8,AA,AB,AC" +
        ",AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B1,B2,B" +
        "3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT," +
        "BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK" +
        ",CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D2,D3,D5,D8,D9,DA,DB,DC,DD,DE,DF,D" +
        "G,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E1,E3,E4,E5,E7,E8,E9,EA," +
        "EB,EC,ED,EE,EF,EG,EH,EJ,EM,EP,EQ,EV,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F9,FA,FB,FC,FD,FE" +
        ",FF,FG,FH,FJ,FK,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G7,GA,GB,GC,GD,GE,GF,GG,GH,G" +
        "I,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H4,HA,HB,HC,HD,HE,HF," +
        "HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HY,HZ,IA,IB,IC,IE,IF,IH,II,IK" +
        ",IL,IM,IN,IP,IT,IU,IV,IW,J2,JA,JB,JE,JG,JK,JM,JO,JR,JU,K1,K2,K3,K4,K5,K6,K7,K9,K" +
        "A,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,L2,LA,LB,LC," +
        "LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8" +
        ",M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,M" +
        "Z,N1,N2,N3,N4,N6,N7,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NL,NM,NN,NQ,NR,NS,NT,NU,NV," +
        "NW,NX,NY,OA,OC,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH" +
        ",PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,QA,Q" +
        "B,QC,QD,QE,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RG,RH,RK," +
        "RL,RM,RN,RO,RP,RS,RT,RU,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ" +
        ",SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,T" +
        "B,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U1,U2," +
        "U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V1,V2,VA,VC" +
        ",VI,VP,VR,VS,W2,WA,WB,WD,WE,WG,WH,WI,WK,WM,WP,WR,WW,X1,X2,X3,X4,X5,X6,X7,X8,X9,X" +
        "P,Y1,Y2,Y3,Y4,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z8,ZA,ZB,ZC,ZP,ZZ,")]
    public class X12_ID_355
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,ABN,ACC,ACI,ACN,ACS,ACT,ADD,AES,AET,ALG,ALL,ALT,AMN,AOO,APN,APS,BBD,BBF,BBH,BBN,BBO,BBT,BFD,BOL,BUR,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ,CAK,CAL,CAM,CAN,CAO,CAP,CAQ,CAR,CAS,CAT,CAU,CAV,CAW,CAX,CAZ,CBA,CBB,CBC,CBH,CBI,CCA,CCB,CCC,CCD,CCE,CCF,CCG,CCN,CDD,CER,CHG,CIG,CLN,CLR,CMP,CMT,COD,COM,CON,CRA,CRK,CRN,CUS,DCP,DEE,DEL,DEP,DFR,DFS,DGN,DME,DOD,DOI,ECD,ECM,ECN,ECT,EED,EFD,ELE,EMC,EMD,ENR,ERN,EVL,EXE,EXR,EXT,FEE,FUT,GEN,GPI,GSI,HHI,ICN,IDT,IID,IIE,IIR,IMP,INS,INT,INV,IVC,JVD,LAB,LBD,LBS,LEN,LIN,LIQ,LLA,LLB,LLC,LOC,LOI,LSD,MCD,MDO,MED,MFG,MKN,MMD,MSD,NCD,NPD,NTR,OBI,OBL,OCA,OCC,OCL,OCP,OCR,ODT,OLS,OPO,ORA,ORE,ORI,OTH,OTN,OTS,PAY,PCS,PDS,PED,PEN,PES,PID,PKG,PMT,POB,POC,POL,PPC,PRI,PRN,PRO,PRR,PSY,PUR,QUL,QUT,RDI,REC,REG,REP,REV,RFL,RHB,RLA,RLH,RNH,RNI,ROU,RPT,RST,RVC,SAN,SCN,SDD,SET,SFM,SMD,SOB,SOW,SPH,SPT,SPV,SSA,SSC,SSD,SSE,SSG,SSH,SSI,SSS,SST,TAF,TCF,TDA,TES,TIL,TLF,TLR,TPO,TRA,TRE,TRF,TRS,TSD,TSF,TST,UPI,VEC,VNN,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AP,AS,AU,BN,BT,CA,CP,DN,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT,PA,PC" +
        ",PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1A,1B,1C,1D,1E,1F,1G,1H,3A,A1,A2,A3,A4,A5,AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AM,AN,AP,AR,AS,AT,AU,AV,BA,BB,BC,BD,BI,BJ,BK,BL,BM,BP,BS,BU,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DC,DD,DE,DF,DI,DM,DN,DV,E1,E2,EA,EB,EC,ED,EF,EG,EM,EN,EO,EP,ES,EV,EX,FA,FB,FC,FD,FF,FL,FM,FN,FO,FP,FQ,FR,GA,GB,GC,GE,GR,HM,HR,IC,IO,IP,IS,KA,KB,KC,KP,KT,LD,MA,MB,MC,MD,ME,MG,MK,ML,MM,NA,NC,NP,NT,OA,OC,OD,OS,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QA,QC,QI,QM,QP,QR,QY,RA,RB,RC,RD,RE,RF,RG,RP,RQ,RS,RZ,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SY,TA,TB,TC,TD,TE,TH,TM,TN,TP,TR,TY,UG,UP,UQ,UR,VM,VP,WH,WI,WR,ZZ,")]
    public class X12_ID_366
    {
    }
    
    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AN,AP,AS,AU,AV,BK,BM,BO,BP,BT,BW,CA,CB,CC,CD,CE,CF,CI,CK,CL,CM,CN,CO,CP,CS,CT,CU,DA,DD,DE,DI,DO,DP,DR,DS,EC,ED,EW,EX,FS,HQ,IC,ID,IN,IP,IS,LM,LS,LW,MC,NF,NN,NS,NY,OB,OF,OP,OR,PA,PC,PD,PH,PI,PK,PL,PN,PO,PP,PR,PS,PT,QN,QP,RC,RD,RI,RT,RW,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SP,SQ,SS,ST,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }
    
    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,C1,C2,C3,C4,C5,C6,DC,EV,FE,GU,GW,LD,MC,MP,PC,PQ,PS,QH,QO,QP,QT,SC,UM,UP" +
        ",WD,WO,ZZ,")]
    public class X12_ID_371
    {
    }
    
    /// <summary>
    /// Lading Liability Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,L,")]
    public class X12_ID_372
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
        "737,738,739,740,741,742,743,744,745,746,750,751,752,753,754,755,756,757,758,760," +
        "770,771,773,774,776,778,779,780,781,782,783,784,785,786,789,800,801,802,803,804," +
        "805,806,807,808,809,810,811,812,813,814,815,816,817,818,820,821,822,823,824,825," +
        "826,827,828,830,831,832,840,841,842,843,844,845,846,847,848,849,850,851,853,854," +
        "855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,871,872,873,874," +
        "875,876,877,878,879,880,881,882,883,884,885,900,901,903,904,905,906,907,908,909," +
        "910,911,912,913,914,915,916,917,918,919,920,921,922,923,924,925,926,927,928,929," +
        "930,931,932,933,934,935,936,937,938,939,940,941,942,943,944,945,946,947,948,949," +
        "950,951,952,953,954,955,956,957,960,961,962,963,964,965,966,967,968,969,970,971," +
        "972,973,974,975,976,977,978,979,980,981,982,983,984,985,986,987,988,989,992,993," +
        "994,995,996,997,998,999,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8,AA9,AAA,AAB,AAD,AAE,AAF," +
        "AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ," +
        "AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABA,ABB,ABC,ABD,ABE,ABG,ABH,ABI,ABK,ABL,ABM," +
        "ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ACA,ACB,ACK,ADB,ADC,ADD,ADL,ADM," +
        "ADR,ARD,CAD,CCR,CDT,CEA,CEB,CEC,CED,CEE,CEF,CEH,CEJ,CEK,CEL,CEM,CEN,CEO,CLO,CLU," +
        "COM,CON,CUR,DDO,DEE,DET,DFF,DFS,DIS,DOI,DSP,ECD,ECF,ECS,ECT,EPP,ESC,ESF,ESS,EST," +
        "ETP,EXO,EXP,FFI,GRD,ICF,IDG,III,IMP,INC,INT,KEV,KEW,LAS,LCC,LEA,LEL,LIQ,LLP,LOG," +
        "LPC,LSC,LTP,MRR,MSD,NAM,NFD,NRG,NSD,ORG,PBC,PDV,PLS,PPP,PRD,PRR,PTD,RAP,RES,RFD," +
        "RFF,RFO,RNT,RRM,RRT,RSD,RSS,RTO,SCV,SDD,STN,TSR,TSS,TST,VAT,VLU,W01,W02,W03,W05," +
        "W06,W07,W08,W09,W10,W11,W12,W13,WAY,YXX,YXY,ZZZ,")]
    public class X12_ID_374
    {
    }
    
    /// <summary>
    /// Tariff Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1A,1B,2A,2B,B1,B2,B3,B4,B5,BA,BB,BC,BD,BE,BF,BG,BH,BK,BL,BM,BN,BO,BP,BR,BW,BX,BY" +
        ",DB,DD,DM,DO,DP,DR,EC,H1,H2,HA,HB,HC,HD,HE,HF,HG,HH,HK,HL,HM,HN,HP,HR,HW,HX,HY,M" +
        "B,MD,ML,MM,MO,MP,MR,ND,OC,OD,OM,OR,OT,OV,PB,PD,PH,PM,PP,PR,RB,RD,RM,RO,RP,RR,")]
    public class X12_ID_375
    {
    }
    
    /// <summary>
    /// Rounding Rule Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,M,N,")]
    public class X12_ID_377
    {
    }
    
    /// <summary>
    /// Allowance/Charge Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_378
    {
    }
    
    /// <summary>
    /// Bid Type Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BF,BI,BW,DQ,OM,RE,RT,UQ,")]
    public class X12_ID_379
    {
    }
    
    /// <summary>
    /// Price Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,P,Q,S,T,X,")]
    public class X12_ID_381
    {
    }
    
    /// <summary>
    /// Entitlement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,I,S,Z,")]
    public class X12_ID_39
    {
    }
    
    /// <summary>
    /// Bill of Lading Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_392
    {
    }
    
    /// <summary>
    /// Amendment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_393
    {
    }
    
    /// <summary>
    /// Pallet Exchange Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_399
    {
    }
    
    /// <summary>
    /// Equipment Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",20,2B,2D,2E,2F,2G,40,4B,AC,AF,AL,AP,AT,BC,BE,BF,BG,BH,BJ,BK,BO,BR,BX,CA,CB,CC,CD,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CZ,DD,DF,DT,DX,ET,FF,FH,FN,FP,FR,FS,FT,FX,GS,HB,HC,HO,HP,HT,HV,HY,ID,IX,LO,LS,LU,NX,OB,OT,OV,PL,PP,PT,PU,RA,RC,RD,RE,RF,RG,RI,RO,RR,RS,RT,SA,SC,SD,SK,SL,SR,SS,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UA,UB,UC,UD,UE,UL,UP,VA,VE,VL,VR,VS,VT,WR,WY,")]
    public class X12_ID_40
    {
    }
    
    /// <summary>
    /// Unit Load Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,ZZ,")]
    public class X12_ID_400
    {
    }
    
    /// <summary>
    /// Seal Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_407
    {
    }
    
    /// <summary>
    /// Receiving Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,16,")]
    public class X12_ID_412
    {
    }
    
    /// <summary>
    /// Promotion Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,26,28,32,33,34" +
        ",35,36,37,39,40,41,42,44,45,46,49,51,59,60,61,62,63,64,69,70,71,72,79,81,82,83,8" +
        "4,88,99,A1,A2,A3,A4,A5,B1,B2,B3,C1,C2,C3,C4,WR,ZZ,")]
    public class X12_ID_422
    {
    }
    
    /// <summary>
    /// Promotion Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,")]
    public class X12_ID_423
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AE,AF,AG,AH,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BR,BS,C1,C2,C3,C4,C5,C6,C7,C8,C9,CB,CE,CK,CM,CO,CP,CQ,CR,CS,CT,CU,CV,CW,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DO,DP,DR,DS,DT,DV,DW,DX,E1,E2,E3,E4,E5,E6,E7,E8,E9,EE,ER,EX,F1,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FI,FR,FT,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GJ,GK,GL,GM,GN,GO,GR,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HI,IA,IC,IE,IF,IL,IP,IR,IS,J1,J2,J3,J4,J5,J6,J7,J8,J9,JE,K1,K2,K3,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LE,LF,LO,LP,LS,M1,M2,M3,M4,MA,MC,ML,NA,NB,NC,ND,NR,OA,OB,OL,PA,PD,PF,PI,PL,PM,PO,PP,PR,PT,R1,R2,R3,RA,RD,RE,RM,SC,SD,SF,SL,SP,TA,TD,TL,UB,UL,VC,VD,VO,W6,W8,W9,WA,WB,WC,WH,WO,WR,WS,WT,WU,WW,ZZ,")]
    public class X12_ID_426
    {
    }
    
    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,CB,CE,CL,EP,KA,LA,LC,LD,LP,PE,SE,TA,TR,")]
    public class X12_ID_432
    {
    }
    
    /// <summary>
    /// F.O.B. Point Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_433
    {
    }
    
    /// <summary>
    /// Primary Publication Authority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BR,DR,GR,OP,RR,TP,")]
    public class X12_ID_436
    {
    }
    
    /// <summary>
    /// Rate Maintenance Authority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,")]
    public class X12_ID_437
    {
    }
    
    /// <summary>
    /// Tax Exempt Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,")]
    public class X12_ID_441
    {
    }
    
    /// <summary>
    /// Purchase Order Instruction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BO,BX,NS,SA,SX,")]
    public class X12_ID_444
    {
    }
    
    /// <summary>
    /// Terms Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DF,DG,DN,EB,GS,IP,NI,PS,SP,ZZ,")]
    public class X12_ID_445
    {
    }
    
    /// <summary>
    /// Property Damage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,")]
    public class X12_ID_448
    {
    }
    
    /// <summary>
    /// Responsible Agency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T,X,")]
    public class X12_ID_455
    {
    }
    
    /// <summary>
    /// Temperature Probe Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_456
    {
    }
    
    /// <summary>
    /// Shipment Weight Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,F,G,H,M,N,O,R,S,T,")]
    public class X12_ID_460
    {
    }
    
    /// <summary>
    /// Transit Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",X,XX,XXX,")]
    public class X12_ID_461
    {
    }
    
    /// <summary>
    /// Container Terms Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,")]
    public class X12_ID_465
    {
    }
    
    /// <summary>
    /// Export Filing Key Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,")]
    public class X12_ID_47
    {
    }
    
    /// <summary>
    /// Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,L,N,R,S,T,X,")]
    public class X12_ID_473
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
    /// Functional Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AD,AF,AG,AH,AI,AK,AL,AN,AO,AR,AS,AT,AW,BC,BE,BF,BL,BS,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CM,CN,CO,CP,CR,CS,CT,CV,D3,D4,D5,DA,DD,DF,DI,DM,DS,DX,EC,ED,EI,ER,ES,EV,EX,FA,FB,FC,FG,FH,FR,FT,GB,GC,GE,GF,GL,GP,GR,GT,HB,HC,HI,HN,HP,HR,HS,IA,IB,IC,ID,IE,IG,II,IJ,IM,IN,IO,IP,IR,IS,KM,LA,LB,LI,LN,LR,LS,LT,MA,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MV,MW,MX,MY,NC,NL,NP,NT,OC,OG,OR,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PN,PO,PQ,PR,PS,PT,PU,PV,PY,QG,QM,QO,RA,RB,RC,RD,RE,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,TA,TC,TD,TF,TI,TM,TN,TO,TP,TR,TS,TT,TX,UA,UB,UC,UD,UI,UP,UW,VA,VB,VC,VD,VE,VH,VI,VS,WA,WB,WG,WI,WL,WR,WT,")]
    public class X12_ID_479
    {
    }
    
    /// <summary>
    /// Export License Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_48
    {
    }
    
    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_481
    {
    }
    
    /// <summary>
    /// Payment Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AJ,ER,FL,NS,PA,PI,PO,PP,PR,")]
    public class X12_ID_482
    {
    }
    
    /// <summary>
    /// Counseling Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,S,T,U,V,")]
    public class X12_ID_483
    {
    }
    
    /// <summary>
    /// Evaluation Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,N,P,")]
    public class X12_ID_484
    {
    }
    
    /// <summary>
    /// Results Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class X12_ID_485
    {
    }
    
    /// <summary>
    /// Product Transfer Movement Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AO,CD,DC,DM,MD,TI,TO,")]
    public class X12_ID_486
    {
    }
    
    /// <summary>
    /// Maintenance Operation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,F,I,R,")]
    public class X12_ID_487
    {
    }
    
    /// <summary>
    /// Data Element Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,C,S,")]
    public class X12_ID_491
    {
    }
    
    /// <summary>
    /// Customs Documentation Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,14,15,16,17,20,24,25,26,27,30,34,35,36,37,90,")]
    public class X12_ID_501
    {
    }
    
    /// <summary>
    /// Block 20 Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_503
    {
    }
    
    /// <summary>
    /// (DFI) ID Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,ZZ,")]
    public class X12_ID_506
    {
    }
    
    /// <summary>
    /// Export License Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_51
    {
    }
    
    /// <summary>
    /// Rail Car Plate Size Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,H,I,X,")]
    public class X12_ID_511
    {
    }
    
    /// <summary>
    /// Import/Export Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,E,I,N,")]
    public class X12_ID_512
    {
    }
    
    /// <summary>
    /// Reporting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,J,K,N,O,P,R,S,X,Y,")]
    public class X12_ID_514
    {
    }
    
    /// <summary>
    /// Total Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_516
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,D,H,O,")]
    public class X12_ID_519
    {
    }
    
    /// <summary>
    /// Export License Symbol Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,G,V,")]
    public class X12_ID_52
    {
    }
    
    /// <summary>
    /// Product Transfer Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,CC,CO,CS,DL,DS,FG,GD,GP,GR" +
        ",IA,IB,OF,ON,OT,PA,PB,PL,PM,PO,PP,RA,RB,RC,RP,RT,RU,RV,SA,SC,SD,SH,SM,SS,SU,TD,W" +
        "L,")]
    public class X12_ID_521
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0A,0B,0C,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0P,0Q,0R,0S" +
        ",0T,0U,1,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,1L,1M,1N,1P" +
        ",1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F" +
        ",2G,2H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,3,30,31,32,33,34,35,36" +
        ",37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3" +
        "X,3Y,3Z,4,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4" +
        "N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,5,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5" +
        "D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,6,60,61,62,6" +
        "3,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T," +
        "6U,6V,6W,6X,6Y,6Z,7,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J," +
        "7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,8,80,81,82,83,84,85,86,87,88,89," +
        "8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,8Z,9," +
        "90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9O,9P,9Q" +
        ",9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,A" +
        "AE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,A" +
        "AY,AAZ,AB,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,AB" +
        "R,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK" +
        ",ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD," +
        "ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADW,ADX,ADY,ADZ," +
        "AE,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP," +
        "AQ,AR,AS,AT,AU,AV,AVE,AW,AX,AY,AZ,B,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAA,BAB,BAC" +
        ",BAD,BAE,BAF,BAG,BAH,BAI,BAJ,BAK,BAL,BAM,BAN,BAO,BAP,BAQ,BAR,BAS,BAT,BAU,BAV,BAW" +
        ",BAX,BAY,BAZ,BB,BBA,BBB,BBC,BBD,BBE,BBF,BBG,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN," +
        "BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD," +
        "CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D,D0,D1,D2,D3," +
        "D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU" +
        ",DV,DW,DX,DY,DZ,E,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK" +
        ",EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,F,F0,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA" +
        ",FB,FBA,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ," +
        "G,G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP," +
        "GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H,H0,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF," +
        "HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I,I0,I1,I2,I3,I4,I5," +
        "I6,I7,I8,I9,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW" +
        ",IX,IY,IZ,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM" +
        ",JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC" +
        ",KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L,L0,L1,L2" +
        ",L3,L4,L5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LOW,LP,LQ,LR," +
        "LS,LT,LU,LV,LW,LX,LY,LZ,M,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH," +
        "MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N,N0,N1,N2,N3,N4,N5,N6,N7," +
        "N8,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,NX,NY" +
        ",NZ,O,O0,O1,O2,O3,O4,O5,O6,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO" +
        ",OP,OQ,OR,OS,OT,OU,OV,OW,OX,OY,OZ,P,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PCC,P" +
        "CS,PCV,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q,Q0" +
        ",Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,Q" +
        "R,QS,QT,QU,QV,QW,QX,QY,QZ,R,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,R" +
        "H,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S,S0,S1,S2,S3,S4,S5,S6,S" +
        "7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SOF,SP,SQ,SR,SS,ST,SU,SV,SW" +
        ",SX,SY,SZ,T,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM" +
        ",TN,TO,TP,TQ,TR,TS,TT,TU,TW,TX,TY,TZ,U,U0,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD" +
        ",UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UPF,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V,V0,V1,V" +
        "2,V3,V4,V5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VES,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR" +
        ",VS,VT,VU,VV,VW,VX,VY,VZ,W,W0,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH" +
        ",WI,WJ,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X,X0,X1,X2,X3,X4,X5,X6,X7" +
        ",X8,X9,XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,X" +
        "Y,XZ,Y,Y1,Y2,Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,Y" +
        "Q,YR,YS,YT,YU,YV,YW,YX,YY,YZ,Z,Z0,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,Z" +
        "G,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_522
    {
    }
    
    /// <summary>
    /// Inventory Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AJ,BO,CM,DM,DP,DU,IT,PA,QU,RC,RD,RE,RT,SA,WH,")]
    public class X12_ID_529
    {
    }
    
    /// <summary>
    /// Water Movement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,N,P,S,")]
    public class X12_ID_533
    {
    }
    
    /// <summary>
    /// Inland Transportation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,IC,IP,ML,RO,SD,SU,")]
    public class X12_ID_534
    {
    }
    
    /// <summary>
    /// Rail Retirement Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,S,T,")]
    public class X12_ID_535
    {
    }
    
    /// <summary>
    /// Nature of Claim Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",99,CA,CN,DE,FR,HT,PO,RD,RO,SH,TH,VS,WA,")]
    public class X12_ID_536
    {
    }
    
    /// <summary>
    /// Employment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,")]
    public class X12_ID_537
    {
    }
    
    /// <summary>
    /// Charge/Allowance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DS,LA,MA,PR,RC,RE,RL,SA,TR,")]
    public class X12_ID_538
    {
    }
    
    /// <summary>
    /// Risk of Loss Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BY,FE,IM,IR,LR,PP,SE,SR,ZZ,")]
    public class X12_ID_54
    {
    }
    
    /// <summary>
    /// Supporting Evidence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,N,")]
    public class X12_ID_544
    {
    }
    
    /// <summary>
    /// Unemployed Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_545
    {
    }
    
    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,44,45,46,47,48,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,AA,AB,AC,AD,AR,C1,C2,C3,CC,CD,CE,CF,CH,CI,CL,CO,CR,CT,DC,DN,DS,EF,ES,EW,EX,F0,F1,F2,F3,F4,F5,F6,F7,F8,F9,FL,FP,FT,FX,IA,LA,MT,NA,NP,NR,NT,OF,OH,PD,PF,PM,PP,PR,PW,RA,RC,RE,RQ,RS,RV,SP,SR,SS,SU,UT,WD,WI,WP,")]
    public class X12_ID_546
    {
    }
    
    /// <summary>
    /// Interest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,P,Q,S,W,X,")]
    public class X12_ID_547
    {
    }
    
    /// <summary>
    /// Decline/Amend Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AOG,CAC,CCD,CDC,CDI,CFO,CFT,CIB,CIC,CNG,CNL,CSD,CSO,CSR,CTA,DAM,DDO,DMN,DNH,DNI," +
        "DNR,DNS,DOA,DPS,DSA,DUP,FIS,GSA,GWL,IAW,ICC,INC,INF,MAN,MDD,NCA,NCR,NDI,NFT,NLI," +
        "NNI,NRC,OCC,OTH,RAC,RAD,RUC,RUD,SMA,SNA,SRD,SRE,VDC,VDD,VDI,VDQ,VDS,VIS,VRP,")]
    public class X12_ID_548
    {
    }
    
    /// <summary>
    /// Reservation Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,N,R,U,")]
    public class X12_ID_558
    {
    }
    
    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AG,AH,AI,AJ,AL,AM,AP,AQ,AS,AT,AW,AX,AY,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CR,CS,CU,CX,DA,DD,DE,DF,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GS,GU,HC,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UC,UN,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }
    
    /// <summary>
    /// Type of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,BB,CS,CY,DD,DR,HA,HH,HL,HP,MC,MD,NC,PH,PP,RD,RE,RR,")]
    public class X12_ID_56
    {
    }
    
    /// <summary>
    /// Special Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A0010,A0020,A0030,AC,AD,AF,AG,AM,AO,B0020,B0040,BH,BI,BOP,C0012,C0032,C0036,C0038,C1,C2,CA,CC,CD,CH,CI,CM,CN,CO,CS,CT,CU,CY,CZ,D0020,D0024,D0031,D0032,D1,D2,DA,DE,DH,DI,DL,DS,DV,E0030,EG,EM,EN,ER,EU,EX,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,KO,L1,LA,LL,LS,M0010,M0042,MI,ML,MNTAN,MNTMN,MNTON,N0020,N0021,N0032,NC,OA,ON,OP,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,PLI,PM,PO,PP,PSF,R0072,R0076,R0077,R0110,RD,RE,RM,RP,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SLP,SPI,SR,SS,ST,SU,SV,SW,T0070,T1,TC,TE,TH,TM,TO,UN,US,V1,V2,W0010,WC,WH,X0010,XP,XX,YY,ZZ,")]
    public class X12_ID_560
    {
    }
    
    /// <summary>
    /// Rate or Value Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,AB,AC,AD,AE,AR,B,BL,BO,CB,CR,D,DR,DT,E,ES,F,G,I,IN,O,OI,OT,P,P" +
        "A,PO,RF,RR,RS,SA,SP,SR,T,TR,UA,UT,VA,W,")]
    public class X12_ID_562
    {
    }
    
    /// <summary>
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8A,AI,AS,B,BC,BK,C,D,E,EI,F,FT,GS,IP,IS,K,LS,MY,N,NS,O,P,P2,P3,P4,Q,QB,QE,QI,QM," +
        "QP,R,S,SC,SE,SF,SG,SI,SP,SQ,SS,ST,SU,SV,SW,T,UC,UL,UP,W,WY,Y,YI,Z,")]
    public class X12_ID_563
    {
    }
    
    /// <summary>
    /// Product/Service Substitution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B0,B1,B2,B3,B4,X,Y,ZZ,")]
    public class X12_ID_566
    {
    }
    
    /// <summary>
    /// Electronic Form Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABS,DMR,IND,NON,PUR,SCP,STD,")]
    public class X12_ID_568
    {
    }
    
    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,03,05,06,07,08,1,10,11,12,13,14,2,3,AG,ALC,ANN,AP,BA,CB,CC,CDM,CDS,CM,CRU,DA," +
        "DC,EC,EPC,LTD,MUT,PRI,RD,REL,RS,SG,SKA,Z,ZB1,ZB2,")]
    public class X12_ID_569
    {
    }
    
    /// <summary>
    /// Scale Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,R,")]
    public class X12_ID_570
    {
    }
    
    /// <summary>
    /// Tare Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,")]
    public class X12_ID_571
    {
    }
    
    /// <summary>
    /// Weight Allowance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,F,I,S,W,")]
    public class X12_ID_572
    {
    }
    
    /// <summary>
    /// City Name Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",S,")]
    public class X12_ID_575
    {
    }
    
    /// <summary>
    /// Equipment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AG,AH,AI,AJ,AK,AL,D,E,L,O,W,")]
    public class X12_ID_578
    {
    }
    
    /// <summary>
    /// Type of Consist Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,J,L,P,R,S,T,Y,")]
    public class X12_ID_579
    {
    }
    
    /// <summary>
    /// Amendment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,N,R,S,")]
    public class X12_ID_580
    {
    }
    
    /// <summary>
    /// Bill of Lading Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,10,11,12,13,14,15,16,17,18,19,20,")]
    public class X12_ID_582
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AO,AP,AU,CA,CO,CT,DC,DD,DI,DQ,DR,DS,FA,FB,FC,FO,FT,HD,IA" +
        ",IR,L1,LA,LE,LF,LM,LS,LU,LW,LX,NE,OS,OT,PA,PE,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,R" +
        "T,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TP,TR,UK,VO,ZZ,")]
    public class X12_ID_584
    {
    }
    
    /// <summary>
    /// Payroll Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AL,CL,DH,GU,HO,JD,LO,MC,ML,MO,OP,PD,RD,RF,SD,SU,VC,WK,")]
    public class X12_ID_585
    {
    }
    
    /// <summary>
    /// Acknowledgment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AD,AE,AH,AK,AP,AT,NA,RD,RF,RJ,RN,RO,RV,ZZ,")]
    public class X12_ID_587
    {
    }
    
    /// <summary>
    /// Wages Paid Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class X12_ID_590
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACH,BKW,BOP,CAS,CCC,CCF,CCH,CDA,CHK,CLH,CPC,CWT,DCC,DCD,DDP,DEB,DLC,DLD,DPC,DPD," +
        "DXC,DXD,DYC,DYD,DZC,DZD,EBX,EXC,FEW,FWT,NON,PAC,PBD,PDC,PDD,PDE,PRO,REV,SCC,SCD," +
        "SDC,SDD,SPC,SPD,SWT,SXC,SXD,SYC,SZC,SZD,TRA,VIS,X12,ZZZ,")]
    public class X12_ID_591
    {
    }
    
    /// <summary>
    /// Lading Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,I,L,P,")]
    public class X12_ID_592
    {
    }
    
    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,B,C,H,Q,S,U,Z,")]
    public class X12_ID_594
    {
    }
    
    /// <summary>
    /// Compartment ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_595
    {
    }
    
    /// <summary>
    /// Manifest Unit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BAG,BBL,BDL,BIC,BIN,BKT,BLE,BOX,BSK,CAN,CAR,CAS,CBC,CBY,CCS,CHS,CNT,COL,COR,CRT," +
        "CSK,CTN,CYL,DBK,DRM,GAL,HED,HMP,KEG,LBK,LOG,LUG,LVN,PAL,PCL,PCS,PKG,PLT,POV,QTR," +
        "REL,ROL,SAK,SHT,SID,SKD,TBE,TBN,TIN,TNK,UNT,VPK,WDC,")]
    public class X12_ID_599
    {
    }
    
    /// <summary>
    /// Consolidation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,N,W,")]
    public class X12_ID_604
    {
    }
    
    /// <summary>
    /// Deficiency Judgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_605
    {
    }
    
    /// <summary>
    /// Credit File Variation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,ZZ,")]
    public class X12_ID_608
    {
    }
    
    /// <summary>
    /// Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,ZZ,")]
    public class X12_ID_611
    {
    }
    
    /// <summary>
    /// Credit Report Merge Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,Z,")]
    public class X12_ID_612
    {
    }
    
    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,4,5,6,7,8,Z,")]
    public class X12_ID_615
    {
    }
    
    /// <summary>
    /// Switch Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,BE,BO,CR,DC,HF,HT,IP,NO,NU,OS,PL,PU,RE,SB,TR,TS,WG,")]
    public class X12_ID_617
    {
    }
    
    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT" +
        ",CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,ND,NS,NT,PD,PS,PT,TD,TS,TT,UT,")]
    public class X12_ID_623
    {
    }
    
    /// <summary>
    /// COD Method of Payment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_625
    {
    }
    
    /// <summary>
    /// Excess Transportation Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,R,T,U,V,W,X,Y,ZZ,")]
    public class X12_ID_626
    {
    }
    
    /// <summary>
    /// Excess Transportation Responsibility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,S,X,Z,")]
    public class X12_ID_627
    {
    }
    
    /// <summary>
    /// Alternation Precedence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,L,N,P,S,")]
    public class X12_ID_629
    {
    }
    
    /// <summary>
    /// Rate Application Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,L,M,N,P,R,S,T,")]
    public class X12_ID_632
    {
    }
    
    /// <summary>
    /// Rate Request/Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,9,A,C,D,F,G,H,I,P,Q,S,T,W,")]
    public class X12_ID_635
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,33,34,35,36,37,38,39,3M,40,41,60,62,63,64,65,66,67,68,69,6A,6C,6N,6R,6S,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,87,88,91,94,95,97,98,99,A0,A1,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AG,AI,AM,AN,AP,AQ,AR,AS,AT,AV,AW,AZ,BA,BB,BD,BF,BH,BJ,BK,BL,BM,BN,BO,BP,BR,BS,BT,BU,BV,BW,C0,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DK,DL,DN,DO,DP,DQ,DR,DS,DT,DU,EA,EB,EF,EI,EM,EP,ER,EX,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FR,FS,FT,GA,GI,GR,HP,I1,IA,IB,IC,ID,IE,IF,II,IM,IN,IO,IR,IU,IW,IX,IZ,JM,JO,JR,JS,JU,JX,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KS,KT,LC,LD,LE,LF,LN,LO,LP,LR,LV,M1,MA,MB,MC,MD,ME,MF,MI,ML,MM,MP,MR,MS,MU,N1,N2,N3,N4,N5,N6,N7,N8,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NP,NQ,NR,NT,NU,OC,OF,OP,OR,P1,PA,PB,PC,PD,PE,PF,PG,PI,PL,PM,PO,PP,PR,PS,PT,PU,PV,PW,PX,PZ,QA,QB,QC,QD,QE,QF,QG,QH,QJ,QK,QL,QP,QR,R1,R2,R3,R4,R5,R6,R7,R8,RA,RB,RC,RD,RE,RF,RG,RH,RK,RM,RP,RQ,RS,RT,RU,RZ,S1,S2,S3,S4,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SO,SP,SQ,SR,SS,ST,SU,SV,TD,TG,TH,TI,TJ,TK,TP,TR,TS,TT,TX,U1,U2,U4,U5,U9,UA,UC,UD,UF,UI,UM,UO,UP,UR,UT,V1,VH,VJ,VL,VM,VN,VO,VP,VQ,VR,W1,W4,W5,WA,WC,WD,WH,WO,WS,WT,X1,XA,XB,XC,XD,XX,XY,XZ,YI,YR,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZW,ZZ,")]
    public class X12_ID_640
    {
    }
    
    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020," +
        "021,022,023,024,025,026,027,028,029,030,031,035,036,037,038,039,040,041,042,043," +
        "044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060,061,062,063," +
        "064,A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19," +
        "A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40," +
        "A41,A42,A43,A45,A46,A49,A50,A51,A52,A53,A55,A58,A59,A61,A63,A64,A65,A73,A74,A75," +
        "A76,A77,A78,A79,A80,A81,A82,A83,A84,A85,A91,A95,A96,A98,A99,ABN,ACC,ACD,AFR,AGC," +
        "AGD,ANA,ANL,API,B01,B02,B03,B04,B05,B06,B07,B08,B09,B10,B11,B12,B13,B14,B15,B16," +
        "B17,B18,B19,B20,B21,B22,B23,B24,B25,B26,B27,B28,B29,B30,B31,B32,B33,B34,B35,B36," +
        "B37,B38,B39,B40,B41,B42,B43,B44,B45,B46,B47,B48,B49,B50,B51,B52,B53,B54,B55,B56," +
        "B57,BPR,BW2,BWL,BWT,BWW,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14," +
        "C15,C16,C17,C18,C19,C20,CBD,CDE,CHA,CIE,CIM,CLA,CLP,CLR,COS,D01,D02,D03,D04,D05," +
        "D06,D07,D08,D09,D10,D11,D12,D13,D14,D15,D16,D17,D18,D19,D20,D21,D22,D23,D24,D25," +
        "D26,D27,D28,D29,D30,D31,D32,D33,D34,D50,D51,D52,D53,D54,D55,D56,D57,D58,D59,D60," +
        "D61,D62,D63,DEF,EB1,EB2,EB3,EB4,EB5,EB6,EB7,EB8,EB9,EBA,ENR,ERR,EXD,F73,F74,FCS," +
        "FRB,FZD,HIT,HZM,IBF,INC,INF,INP,INS,IOC,IRS,IV1,IV2,JOW,JVP,LIQ,LSH,MAS,MIN,MP2," +
        "MPL,MPT,MPW,MTC,NGP,NNM,NOR,NWD,P01,P02,P03,P04,P05,P06,P07,PAA,PAL,POA,REJ,RFM," +
        "RFR,RUN,S01,SCH,SFR,SGR,SOW,STM,T01,T02,T03,T04,T05,T06,T07,TDR,THT,TIL,TP2,TPL," +
        "TPT,TPW,UCD,UND,VAN,W01,W02,W03,W04,W05,W06,W07,W08,W09,W10,W11,W12,W13,W14,W15," +
        "W16,WAD,WLC,WLT,WLW,WTP,ZZZ,")]
    public class X12_ID_641
    {
    }
    
    /// <summary>
    /// Lading Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,O,S,")]
    public class X12_ID_644
    {
    }
    
    /// <summary>
    /// Related Company Indication Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_645
    {
    }
    
    /// <summary>
    /// Application Error Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,024,026,027,028,029,036,500,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,817,818,819,820,821,822,823,824,825,826,827,828,829,830,831,832,833,834,847,848,849,A,ASA,ASV,AVE,B,C,CAL,CHK,COV,CUR,D,DBL,DDT,DRC,DTE,DUP,E,F,G,H,HUG,HUL,I,ICA,ICG,IDC,IDN,IID,IMD,INC,INF,IPR,IQT,IWT,J,K,L,LOC,M,MA,MB,MBL,MC,MD,MDN,ME,MF,MG,MH,MI,MID,MJ,MK,ML,MM,MN,MP,MQ,MQT,MWT,N,NAU,NCL,NCR,NDP,NDT,NIF,NOC,NOD,NRA,O,OTH,P,PND,POI,PPD,PRM,Q,QTY,R,RAT,RTE,RTN,RU,S,SCA,SCD,SEV,SPL,STA,STP,STR,T,TRN,TYP,U,UAU,UCN,UKN,UNP,UNV,V,VIN,VND,VOS,ZDS,ZZZ,")]
    public class X12_ID_647
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
    /// Rating Remarks Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,33" +
        ",35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,6" +
        "1,62,63,64,65,66,67,68,69,70,71,72,ZZ,")]
    public class X12_ID_650
    {
    }
    
    /// <summary>
    /// Discount Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AMT,CSH,DOR,DPU,DSH,DSV,POR,PPU,PSH,PSV,UNT,ZZZ,")]
    public class X12_ID_653
    {
    }
    
    /// <summary>
    /// Discount Base Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,PC,UN,ZZ,")]
    public class X12_ID_654
    {
    }
    
    /// <summary>
    /// Discount Control Limit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DAT,DOF,")]
    public class X12_ID_656
    {
    }
    
    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,")]
    public class X12_ID_659
    {
    }
    
    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,8,81,82,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AL,AP,BC,BD,BE,BG,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CP,CR,CS,CT,D,DG,DL,DN,DP,DS,E,EC,EH,EI,EP,EQ,ER,ES,F,FA,FB,FC,FD,FI,FJ,FN,G,GA,GC,HC,HN,I,J,K,L,LC,LD,LE,LI,LN,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MP,MR,N,NA,ND,NI,NO,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RT,S,SA,SB,SD,SF,SI,SJ,SL,SP,ST,SV,SW,TA,TC,TZ,UC,UL,UM,UP,UR,US,WR,XV,XX,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66
    {
    }
    
    /// <summary>
    /// Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,O,S,")]
    public class X12_ID_662
    {
    }
    
    /// <summary>
    /// Residue Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,R,")]
    public class X12_ID_665
    {
    }
    
    /// <summary>
    /// Division Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,H,M,N,P,R,")]
    public class X12_ID_666
    {
    }
    
    /// <summary>
    /// Line Item Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AC,AR,BP,DR,IA,IB,IC,ID,IE,IF,IH,IP,IQ,IR,IS,IW,R1,R2,R3,R4,R5,R6,R7,R8,SP,")]
    public class X12_ID_668
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
    /// Change or Response Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,CA,CB,CC,CE,CF,CG,CH,CI,CT,DI,MU,NC,OA,OC,PC,PQ,PR,QD,QI,RA,RB,RC,RE,RM,RQ,RS" +
        ",RZ,TI,")]
    public class X12_ID_670
    {
    }
    
    /// <summary>
    /// Resource Authorization Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FI,GS,LB,LM,MT,PQ,PR,ZZ,")]
    public class X12_ID_672
    {
    }
    
    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,2" +
        "8,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y," +
        "2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3P,3Q" +
        ",3R,3S,3T,3U,3V,3W,3X,3Y,40,41,42,43,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4" +
        "J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,50,51,52,53,54,55,56,57,58,5A,5B,5C,5D,5E,5F," +
        "5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62,63,64,65,66" +
        ",67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6" +
        "X,6Z,70,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P," +
        "7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G" +
        ",8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,90,91,92,93,94,95,96,97,98,99,9A,9C,9D,9E,9" +
        "F,9H,9J,9K,9L,9M,9N,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK," +
        "AL,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,BA,BB,BC,BD,BE" +
        ",BF,BG,BH,BI,BJ,BK,BQ,BR,BW,C0,CA,CB,CC,CD,CE,CF,CG,CH,CI,CL,CN,CO,CP,CR,CS,CW,C" +
        "Y,CZ,D1,D3,DA,DB,DC,DD,DE,DF,DG,DI,DN,DO,DP,DR,DS,DT,DY,E1,E2,E3,E4,E5,EA,EB,EC," +
        "ED,EE,EM,EP,EQ,ER,ES,ET,EW,F1,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FR,FS,FT,GA" +
        ",GB,GC,GE,GF,GI,GL,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GZ,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,H" +
        "K,HL,HM,HN,HO,HP,HR,HS,II,IN,IP,IQ,IS,IT,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM," +
        "JN,JO,JP,JQ,JR,JS,JT,K6,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS" +
        ",KU,KV,KW,KX,KY,KZ,L2,L3,L4,L5,L6,L7,LA,LB,LC,LE,LG,LH,LI,LK,LL,LM,LN,LO,LP,LQ,L" +
        "R,LS,LT,LV,LW,LX,LY,M1,M2,MA,MD,ME,MF,MI,MM,MN,MO,MQ,MX,N1,N2,N3,N4,N5,N6,NA,NB," +
        "NC,ND,NE,NF,NG,NL,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,OC,OD,OF,OG,OH,OI,OL,ON,OO,OR,OT" +
        ",OU,OV,OW,P1,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PK,PL,PO,PP,PQ,PR,PS,PT,P" +
        "W,PX,Q1,Q2,Q3,Q4,QA,QB,QC,QD,QE,QF,QH,QI,QJ,QL,QM,QN,QO,QP,QQ,QR,QS,QU,QV,QW,QX," +
        "R3,R5,R6,R9,RA,RB,RC,RD,RE,RF,RG,RH,RJ,RL,RM,RN,RQ,RS,RT,RW,RY,S1,S2,S3,S4,S5,S6" +
        ",S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,S" +
        "X,SY,T1,T2,T3,T4,T5,T6,T7,TA,TB,TC,TD,TE,TG,TH,TI,TJ,TK,TM,TN,TO,TP,TR,TS,TT,TU," +
        "TV,TW,TX,TY,UA,UG,UL,UO,US,UU,V1,V2,V3,V4,V5,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL" +
        ",VM,VN,VP,VR,VS,VT,VV,VY,WA,WB,WC,WD,WE,WG,WL,WO,WP,WR,WT,WV,WW,WX,WY,X1,XA,XB,X" +
        "C,XD,XE,XG,XI,XJ,XL,XN,XO,XT,XU,XV,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK,YL,YM," +
        "YN,YP,YQ,YR,YS,YT,YW,YX,YY,Z1,Z2,Z3,Z4,Z6,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM" +
        ",ZN,ZO,ZP,ZR,ZS,")]
    public class X12_ID_673
    {
    }
    
    /// <summary>
    /// Reciprocal Switch Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,L,O,P,Y,")]
    public class X12_ID_674
    {
    }
    
    /// <summary>
    /// Schedule Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AS,BB,DL,JS,KB,PD,PR,PS,SH,ZZ,")]
    public class X12_ID_675
    {
    }
    
    /// <summary>
    /// Schedule Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,R,")]
    public class X12_ID_676
    {
    }
    
    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SA,SB,SC,SD,SG,SL,SP,SX,SY" +
        ",SZ,T,U,V,W,X,Y,Z,")]
    public class X12_ID_678
    {
    }
    
    /// <summary>
    /// Ship/Delivery Pattern Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,Y,Z,")]
    public class X12_ID_679
    {
    }
    
    /// <summary>
    /// Forecast Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,K,L,M,N,P,Q,S,T,U,V,W,X,Z,")]
    public class X12_ID_680
    {
    }
    
    /// <summary>
    /// Forecast Timing Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,F,M,Q,S,T,W,X,Z,")]
    public class X12_ID_681
    {
    }
    
    /// <summary>
    /// Part Release Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,E,F,G,H,I,J,K,L,M,N,P,Q,R,S,T,U,W,X,Y,")]
    public class X12_ID_682
    {
    }
    
    /// <summary>
    /// Catalog Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CP,PC,PS,RC,SC,")]
    public class X12_ID_683
    {
    }
    
    /// <summary>
    /// Class of Trade Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AG,AI,AP,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE,DF,DI,DR,EX,FS,GA,GM,GR,GV,HS" +
        ",ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,SA,SB,SE,ST,TR,WA,WC,WH,WS,")]
    public class X12_ID_687
    {
    }
    
    /// <summary>
    /// Restrictions/Conditions Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,DO,DW,NR,NS,OR,SP,SR,WO,")]
    public class X12_ID_688
    {
    }
    
    /// <summary>
    /// Occupancy Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_689
    {
    }
    
    /// <summary>
    /// Conveyance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,Y,Z,")]
    public class X12_ID_692
    {
    }
    
    /// <summary>
    /// Docket Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,G,M,P,S,T,")]
    public class X12_ID_693
    {
    }
    
    /// <summary>
    /// Independence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,L,M,N,")]
    public class X12_ID_695
    {
    }
    
    /// <summary>
    /// Rate Distribution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,S,U,")]
    public class X12_ID_698
    {
    }
    
    /// <summary>
    /// Commodity/Geographic Logical Connector Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,P,")]
    public class X12_ID_699
    {
    }
    
    /// <summary>
    /// Information Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80," +
        "81,82,83,")]
    public class X12_ID_701
    {
    }
    
    /// <summary>
    /// Financial Information Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,")]
    public class X12_ID_703
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
    /// Trade Union Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_705
    {
    }
    
    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,")]
    public class X12_ID_706
    {
    }
    
    /// <summary>
    /// Rating Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AS,BA,BC,BE,C2,CH,CL,CO" +
        ",CP,CR,CT,DP,DQ,DS,EA,EC,EE,EI,FA,IF,IN,LT,PA,PC,PD,PF,PK,PR,PS,PT,PU,PY,RC,RO,R" +
        "S,RT,SD,SE,SF,SN,SP,SS,ST,TC,TR,TS,TT,UT,WR,WT,")]
    public class X12_ID_707
    {
    }
    
    /// <summary>
    /// Rating Summary Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,2" +
        "6,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50," +
        "6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_708
    {
    }
    
    /// <summary>
    /// Communications Environment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PP,SC,")]
    public class X12_ID_709
    {
    }
    
    /// <summary>
    /// Goods and Services Tax Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_714
    {
    }
    
    /// <summary>
    /// Functional Group Acknowledge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,M,P,R,W,X,")]
    public class X12_ID_715
    {
    }
    
    /// <summary>
    /// Functional Group Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,3,4,5,6,")]
    public class X12_ID_716
    {
    }
    
    /// <summary>
    /// Transaction Set Acknowledgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,M,R,W,X,")]
    public class X12_ID_717
    {
    }
    
    /// <summary>
    /// Transaction Set Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,3,4,5,6,7,8,9,")]
    public class X12_ID_718
    {
    }
    
    /// <summary>
    /// Type of Service Offered Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,I,N,")]
    public class X12_ID_72
    {
    }
    
    /// <summary>
    /// Segment Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_720
    {
    }
    
    /// <summary>
    /// Data Element Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class X12_ID_723
    {
    }
    
    /// <summary>
    /// Real Estate Property Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,20,")]
    public class X12_ID_726
    {
    }
    
    /// <summary>
    /// Returnable Container Load Make-Up Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,D,E,L,M,O,P,R,S,U,ZZ,")]
    public class X12_ID_728
    {
    }
    
    /// <summary>
    /// Compensation Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,")]
    public class X12_ID_73
    {
    }
    
    /// <summary>
    /// Transit Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ZZ,")]
    public class X12_ID_731
    {
    }
    
    /// <summary>
    /// Transit Time Direction Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AD,CD,CW,HO,SD,SH,WD,WW,ZZ,")]
    public class X12_ID_732
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,19,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,7,8,9,A,AD,AG,AL,AP,AS,B,BD,BE,BP,C,CB,CC,CE,CH,CI,CL,CN,CO,CT,D,DG,DP,E,ED,EL,EM,EV,EX,F,FC,FG,FI,FL,FR,G,GC,GP,GW,H,I,IA,IB,IC,IN,J,JU,K,L,M,ML,NI,NS,O,OS,P,PA,PB,PC,PD,PH,PL,PP,PR,PS,PT,PY,Q,R,RA,RB,RC,RD,RE,RF,RM,RP,S,SA,SB,SC,SD,SE,SH,SI,SL,SP,SR,SS,SY,T,TI,TS,U,UT,V,W,WB,WC,WL,WP,WR,X,Y,ZZ,")]
    public class X12_ID_735
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
    /// Measurement Reference ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",9L,AA,AB,AC,AE,AF,AG,AH,AI,AJ,AK,AM,AN,AO,AP,AQ,AR,AV,BA,BB,BC,BD,BL,BM,BN,BO,BP,BR,BT,BZ,C1,CA,CB,CC,CF,CG,CH,CJ,CK,CL,CM,CN,CO,CP,CQ,CS,CT,CU,CV,CW,CY,DE,DN,DT,EA,EE,EF,EL,EN,FC,FD,FH,FJ,FV,FZ,GC,GL,GO,GP,HC,HR,ID,IN,IR,LC,LD,LG,LL,LM,LP,LS,LT,MP,MR,NC,NE,NX,OD,OG,OL,OP,P1,PA,PB,PC,PD,PI,PJ,PK,PL,PM,PO,PR,PS,PT,PU,PY,QR,QV,R1,R2,RA,RG,RL,RN,RO,RP,RQ,RS,RT,SA,SB,SC,SD,SE,SF,SH,SJ,SK,SL,SM,SP,SR,ST,SU,SZ,TA,TD,TE,TI,TL,TO,TP,TR,TS,TT,VT,WA,WR,WT,ZA,ZP,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,1F,2,20,21,22,23,24,25,26,27,28,29,2F,3,30,31,32,33" +
        ",34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,4,40,41,42,43,44,4F,5,5F,6,6F,7" +
        ",8,8F,A,A1,A2,A3,A4,A5,A6,A7,A9,AA,AAP,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,ADM,AE,AF,AG" +
        ",AGE,AGI,AH,AI,AJ,AK,AL,ALK,ALN,ALP,AM,AMI,AMW,AN,AOX,AP,API,APP,AS,ASH,ASY,AT,A" +
        "U,AV,AVT,AW,AX,AY,AZ,B,B1,B2,B3,B4,B5,B6,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF,BHS,BIC" +
        ",BJ,BK,BL,BN,BND,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,BX,C,C0,C1,C2,C3,C4,CA,CAU" +
        ",CC,CCF,CCG,CD,CE,CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CLB,CLN,CM,CN" +
        ",CO,COH,COL,CON,COR,COS,COT,CP,CPF,CPS,CQ,CR,CRF,CRL,CRN,CRT,CS,CSC,CSR,CST,CT,C" +
        "TG,CTT,CU,CUT,CW,CWT,CX,CY,CYB,D,D1,D2,D3,D4,D5,D7,DA,DAT,DB,DC,DCT,DD,DE,DEM,DF" +
        ",DG,DH,DI,DIR,DIS,DJ,DL,DM,DME,DMF,DN,DP,DPM,DR,DRY,DS,DT,DU,DW,DWP,DY,E,E0,E1,E" +
        "A,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EL,ELC,ELE,ELI,ELL,ELO,ELP,ELS,ELT,ELV,ELW,ELX,EM,E" +
        "N,EP,EPL,ES,EVL,EVR,EW,EX,EXH,EXT,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FBP,FC,FD,F" +
        "E,FF,FG,FH,FI,FIL,FIN,FIT,FJ,FK,FL,FLD,FLN,FLP,FLV,FML,FMZ,FN,FNL,FNS,FOA,FOH,FO" +
        "I,FOR,FP,FPV,FQ,FR,FS,FSI,FT,FU,FUD,FV,FW,FX,FY,FZ,G,G1,G2,G3,G4,GA,GB,GC,GD,GE," +
        "GEL,GF,GG,GGR,GH,GI,GIR,GJ,GK,GL,GLE,GM,GN,GO,GOR,GP,GQ,GR,GRA,GRI,GS,GT,GW,H1,H" +
        "2O,H8,H9,HA,HAR,HAZ,HB,HC,HCG,HD,HE,HF,HG,HH,HHW,HI,HIB,HJ,HK,HL,HM,HO,HOC,HP,HR" +
        ",HT,HTE,HVM,HWS,HYD,HZ,HZC,I,IA,IB,IC,ID,IDE,IE,IF,IG,IGA,IGR,IH,IHV,II,IJ,IK,IL" +
        ",IM,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IRA,IS,IT,IU,IV,IW,IX,IY,IZ,JA,JOM,KA,KB,KN,L" +
        ",L0,L1,LA,LAI,LB,LC,LC5,LCG,LD,LD5,LDH,LE,LEF,LF,LG,LIR,LIV,LL,LLD,LM,LN,LO,LOI," +
        "LOS,LOW,LP,LPG,LPL,LPR,LS,LSK,LSS,LT,LTD,LW,M,M1,M2,M3,M4,M5,M6,MA,MAT,MB,MC,MCN" +
        ",MD,ME,MEF,MEL,MER,MF,MG,MH,MHI,MI,MIC,MJ,MK,MM,MN,MO,MOI,MOR,MP,MPR,MQ,MR,MS,MT" +
        ",MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,NIL,NJ,NK,NL,NM,NNW,NO,NOC" +
        ",NON,NOR,NOX,NP,NS,NU,NV,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI,OIL" +
        ",OJ,OK,OL,OLE,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTE,OTH,OTT,OV,OW,OX,OXI,OXS,OY,P1,PA," +
        "PAR,PB,PBD,PC,PD,PDE,PDG,PE,PER,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,PO" +
        "C,POD,POP,PP,PPS,PQ,PR,PRE,PRF,PRI,PRL,PRO,PRQ,PRY,PS,PSA,PSP,PSW,PT,PU,PV,PW,PW" +
        "A,PWE,PWF,PX,PY,PZ,Q,QA,QB,QC,QD,QE,QF,QL,QUR,R,R1,R10,R18,R2,R3,R4,R7,R8,RA,RAD" +
        ",RAF,RB,RC,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,ROH,ROX,R" +
        "P,RQ,RR,RS,RSZ,RT,RTB,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7," +
        "S8,S9,SA,SAP,SB,SC,SCH,SD,SE,SEV,SF,SG,SH,SHA,SI,SIL,SJ,SK,SL,SLD,SLI,SM,SMB,SMD" +
        ",SN,SO,SOD,SOF,SP,SPG,SPR,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUR,SUT,SV,SVL,SW,SX,SX" +
        "X,SY,SZ,T,T1,T2,T3,T4,T5,T50,T90,TA,TAS,TB,TC,TCL,TD,TDP,TE,TEE,TES,TEX,TF,TG,TH" +
        ",TI,TJ,TK,TL,TM,TN,TO,TOA,TOR,TOX,TP,TPF,TPL,TPQ,TPS,TQ,TR,TRA,TRC,TRD,TRN,TS,TS" +
        "Z,TT,TTL,TU,TUR,TV,TVD,TW,TWD,TX,TY,U,UA,UCB,UG,UNI,UNK,VAD,VAP,VCG,VH,VIN,VIS,V" +
        "O,VOC,VOL,VOT,VOV,VOW,VSO,VW,VWT,WA,WB,WC,WD,WDE,WE,WEL,WF,WH,WI,WL,WM,WOD,WPF,W" +
        "PL,WPS,WR,WRA,WSK,WT,WTB,WU,WX,X,XA,XH,XP,XQ,XZ,YA,YB,YC,YD,ZA,ZAL,ZAS,ZB,ZBI,ZB" +
        "T,ZBZ,ZC,ZCA,ZCB,ZCD,ZCE,ZCO,ZCR,ZCU,ZD,ZET,ZF,ZFE,ZFL,ZFS,ZG,ZGE,ZH,ZHP,ZHS,ZHX" +
        ",ZIB,ZIP,ZMG,ZMN,ZMO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP,ZPT,ZR,ZS,ZSB,ZSE,ZSI," +
        "ZSN,ZTA,ZTB,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
    public class X12_ID_738
    {
    }
    
    /// <summary>
    /// Returnable Container Freight Payment Responsibility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,S,Z,")]
    public class X12_ID_743
    {
    }
    
    /// <summary>
    /// Print Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CN,DI,EN,MV,PN,RN,SN,TN,UF,VN,WN,XY,")]
    public class X12_ID_744
    {
    }
    
    /// <summary>
    /// Pre-Cooled (Rule 710) Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_745
    {
    }
    
    /// <summary>
    /// Rebill Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",RB,RC,RD,")]
    public class X12_ID_747
    {
    }
    
    /// <summary>
    /// Movement Authority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,DS,E,G,HM,I,L,M,N,NC,NU,O,OA,OS,P,R,RB,S,T,W,X,")]
    public class X12_ID_748
    {
    }
    
    /// <summary>
    /// Supplementary Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BLC,CIR,COA,COM,CON,CTP,CUS,DOM,EXP,FUM,INS,IPI,LOC,MSD,OBV,ONR,ORI,PAK,QAL,SAN," +
        "SED,SPI,SWB,")]
    public class X12_ID_749
    {
    }
    
    /// <summary>
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,99,9A,9B,9C,9D,AF,AG,AGE,AT,B8,BC,BCC,BES,BEV,BLM,BND,BPI,BRG,BW,C2,C3,C4,C5,C6,CCN,CD,CFC,CH,CHF,CL,CLT,CM,CMS,CO,CP,CS,CU,CW,DAC,DAF,DE,DF,DIR,DM,EC,EN,FA,FC,FCD,FDD,FL,FLV,FMR,FQ,GD,GEN,GM,GS,HB,HY,HZ,HZR,ING,INJ,KI,LC,LO,MA,MAC,MB,MBU,MS,MSG,NH,OC,OD,ODR,OR,OT,P6,PD,PF,PFA,PFC,PFG,PFI,PFK,PFL,PFM,PFN,PFP,PFS,PFT,PG,PP,PR,PRI,PRO,PSC,PUB,PUR,QAS,R3,RA,RCC,RM,RR,RSD,RSE,RX,SC,SE,SEC,SF,SIZ,SLM,SOL,ST,STL,SYN,TC,TE,TF,THR,TIF,TIR,TP,TR,TRN,TWF,TZ,VA,VC,VI,WD,WF,WLC,WT,WTT,ZZ,")]
    public class X12_ID_750
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1S,2S,A1,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF,")]
    public class X12_ID_752
    {
    }
    
    /// <summary>
    /// Packaging Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,10,11,12,13,34,35,36,37,38,39,40,42,43,44,45,60,61,62,63,65,66,67,68,CB,CC,CD" +
        ",CS,CT,CUD,HM,IC,IP,LP,OPI,PK,PM,PML,PN,SMK,UC,UCL,UP,WM,")]
    public class X12_ID_753
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80," +
        "81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF" +
        ",AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,BA,BB,B" +
        "C,BE,BF,BL,BM,BN,BO,BR,BS,BT,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF," +
        "CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CW,CX,CY,CZ,D2,DA,DB,DC,DD,DE,DF,DG" +
        ",DH,DI,DJ,DK,DL,DM,DN,DQ,DR,DS,DT,DU,DV,DW,E1,EA,EB,EC,ED,EL,EP,ER,EX,EY,F1,F2,F" +
        "3,F4,F5,F6,F7,F8,F9,FB,FC,FD,FE,FH,FI,FM,FS,GP,GT,HC,HR,HW,I2,I3,I4,I5,I6,IA,IC," +
        "IM,IN,IP,IR,IS,IT,IU,IV,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT" +
        ",JV,JW,JX,JY,JZ,KA,KC,KD,KE,KF,KG,KH,KI,KJ,KY,KZ,LA,LB,LC,LD,LE,LG,LI,LO,LP,LR,L" +
        "S,LT,LW,M1,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MV,MZ,NA," +
        "NC,ND,NI,NL,NM,NN,NO,NQ,NR,NT,OB,OC,OD,OE,OL,OP,OR,OS,OT,OX,OZ,P1,P2,P3,P4,P5,P6" +
        ",P7,P8,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PV,PW,PX,PY,P" +
        "Z,QC,QD,QE,QM,QR,QS,QT,R1,R2,R3,R4,R5,R6,RA,RB,RC,RD,RE,RF,RG,RM,RN,RO,RR,RT,RV," +
        "RX,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SL,SM,SN,SO,SP,SQ,SR,SS" +
        ",ST,SU,SV,SW,SX,SY,T1,T2,T3,T4,T5,T6,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,T" +
        "O,TP,TQ,TR,TS,TT,TX,U1,UA,UB,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT," +
        "UU,UV,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V7,VA,VC,VD,VM,W1,W2,WA,WB,WC,WD,WE,WF,WG,WH,WI" +
        ",WP,WT,X1,X2,X3,X4,X5,XE,XP,Y1,Y2,Y3,ZA,ZB,ZZ,")]
    public class X12_ID_755
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,AA,AC,AE,AM,AS,AT,AU,BE,BM,BW,CD,CF,CP,CT,DA,EL,EM,FT,FX,GS,HL" +
        ",IA,IE,IM,MB,MD,MN,MP,MT,NS,OL,PO,SE,SM,SN,SW,TA,TE,TM,TX,VO,WS,")]
    public class X12_ID_756
    {
    }
    
    /// <summary>
    /// Reportable Quantity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",RQ,")]
    public class X12_ID_759
    {
    }
    
    /// <summary>
    /// Limited Quantity Indication Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_760
    {
    }
    
    /// <summary>
    /// Waybill Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,H,M,N,O,R,S,T,U,W,")]
    public class X12_ID_762
    {
    }
    
    /// <summary>
    /// Market Area Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,")]
    public class X12_ID_771
    {
    }
    
    /// <summary>
    /// Interchange Agreement Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,H,N,")]
    public class X12_ID_772
    {
    }
    
    /// <summary>
    /// Container Type Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,R,S,W,")]
    public class X12_ID_78
    {
    }
    
    /// <summary>
    /// Planning Schedule Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,MM,MN,MP,OS,OT,PM,PS,SO,ST,TO,TS,TT,XA,XF,")]
    public class X12_ID_783
    {
    }
    
    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,ZZ,")]
    public class X12_ID_786
    {
    }
    
    /// <summary>
    /// Entity Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,P,Z,")]
    public class X12_ID_792
    {
    }
    
    /// <summary>
    /// Revision Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,Z,")]
    public class X12_ID_795
    {
    }
    
    /// <summary>
    /// Security Technique Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9A,9E,9N,OC,ZZ,")]
    public class X12_ID_797
    {
    }
    
    /// <summary>
    /// Bank Client Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,R,")]
    public class X12_ID_8
    {
    }
    
    /// <summary>
    /// Hazardous Material Shipment Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADI,CAO,D13,DRC,DWW,EMS,HOT,HZC,INH,LQY,MFA,MOS,MPI,PIH,POI,RAM,TEC,TNM,WST,")]
    public class X12_ID_808
    {
    }
    
    /// <summary>
    /// Obligation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AL,AY,BL,CC,ED,FC,FD,FR,HR,ML,OO,PI,RC,RX,SL,UT,ZZ,")]
    public class X12_ID_811
    {
    }
    
    /// <summary>
    /// Payment Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BPT,CBC,CCD,CCP,CTP,CTX,PBC,PPD,PPP,PRD,")]
    public class X12_ID_812
    {
    }
    
    /// <summary>
    /// Station Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,H,I,J,L,M,N,O,R,S,T,W,")]
    public class X12_ID_813
    {
    }
    
    /// <summary>
    /// Nesting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,T,")]
    public class X12_ID_814
    {
    }
    
    /// <summary>
    /// Property Inspection Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DE,DR,EX,GR,HT,IN,LO,NB,PL,SH,SP,WI,ZZ,")]
    public class X12_ID_815
    {
    }
    
    /// <summary>
    /// Occupancy Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DI,JU,NB,NM,OM,RE,TE,TN,VI,ZZ,")]
    public class X12_ID_816
    {
    }
    
    /// <summary>
    /// Report Section Name Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,AP,CA,CI,CM,CO,DI,DM,DS,EI,EN,EO,EP,FA,FE,HH,HI,IA,KY,MI,MS,PD,PM,PR,RE,RG,SH" +
        ",SL,ST,TS,TX,")]
    public class X12_ID_820
    {
    }
    
    /// <summary>
    /// Safety Characteristic/Hazard Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AM2,AP2,CAR,CI2,CO2,CON,CTD,DCL,DEC,DEH,DI2,DIS,DM2,EDD,EFA,EFB,EFX,EIM,EN2,ENA,ENB,ENG,ENO,ENS,EO2,EP2,EPA,ESD,EVP,EXC,EXG,EXI,EXL,EYA,EYC,EYF,EYZ,FA2,FAA,FAL,FAS,FAT,FAZ,FE2,FEH,FEZ,FLC,FLP,GCA,GMA,GPI,HAI,HCA,HCP,HH2,HHA,HI2,HZC,HZR,IA2,IGA,IGC,IGZ,IHA,IHC,IHZ,INC,INS,INX,IRR,KY2,LAB,LKI,MAT,MCE,MUT,NOT,NTE,NTR,NTS,NTZ,OPH,OPR,ORC,PD2,PM2,POL,PPA,PPB,PPC,PPD,PPE,PPF,PPG,PPR,PPS,PPZ,PR2,PRE,PRF,PRG,PRH,PRI,PRJ,PRK,PRL,PRM,PRO,PRQ,PRS,PRT,PRU,PRZ,RE2,REA,REC,REP,RG2,RLI,RTK,SAP,SBY,SCE,SGW,SH2,SHI,SKA,SKC,SKS,SKT,SKZ,SL2,SNS,SPF,SPI,SPJ,SPL,SPP,ST2,STA,SUB,SYP,SYS,TER,TOC,TOG,TRH,TS2,TX2,VRZ,WAR,WDI,")]
    public class X12_ID_821
    {
    }
    
    /// <summary>
    /// Fuel Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,K,L,N,O,P,S,Z,")]
    public class X12_ID_829
    {
    }
    
    /// <summary>
    /// Licensing Agency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,G,I,J,M,N,P,S,T,")]
    public class X12_ID_83
    {
    }
    
    /// <summary>
    /// Inspection Location Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,90,96,97,98,99,")]
    public class X12_ID_831
    {
    }
    
    /// <summary>
    /// Supplemental Inspection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_835
    {
    }
    
    /// <summary>
    /// Vehicle Deck Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,A6,A7,B1,B2,B3,B4,B5,B6,B7,C1,C2,C3,C4,C5,C6,C7,")]
    public class X12_ID_836
    {
    }
    
    /// <summary>
    /// Vehicle Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,C,I,M,T,V,X,")]
    public class X12_ID_837
    {
    }
    
    /// <summary>
    /// Inbound Condition Hold Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_844
    {
    }
    
    /// <summary>
    /// Chassis Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8P,DF,FB,GN,SF,SL,TX,")]
    public class X12_ID_845
    {
    }
    
    /// <summary>
    /// Contract Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AN,AW,CA,CB,CC,CL,CM,CR,CX,DA,DE,DL,EX,FL,GS,HO,IA,IE,IN,MA,NB,NT,OC,PA,PB,PC" +
        ",PD,PP,PR,RA,RB,RC,RO,SC,SU,TA,TR,VA,")]
    public class X12_ID_846
    {
    }
    
    /// <summary>
    /// Order/Item Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AO,CA,CI,CO,PA,PI,PO,PP,")]
    public class X12_ID_847
    {
    }
    
    /// <summary>
    /// Product/Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PD,SD,SP,")]
    public class X12_ID_848
    {
    }
    
    /// <summary>
    /// Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",SB,SL,SS,")]
    public class X12_ID_849
    {
    }
    
    /// <summary>
    /// Status Report Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,")]
    public class X12_ID_850
    {
    }
    
    /// <summary>
    /// Address Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,M,T,")]
    public class X12_ID_852
    {
    }
    
    /// <summary>
    /// Damage Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BD,CC,CD,DL,DP,FL,HD,ID,IL,IU,LD,LS,NO,NR,PP,PS,SF,TE,UE,VI,WC,")]
    public class X12_ID_853
    {
    }
    
    /// <summary>
    /// Vessel Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,BD,BI,BK,BL,BO,CB,CT,DG,DP,FH,GC,GT,MT,PC,PS,RR,SP,TG,VH,")]
    public class X12_ID_854
    {
    }
    
    /// <summary>
    /// Peg Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,T,")]
    public class X12_ID_855
    {
    }
    
    /// <summary>
    /// Rate Level Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,E,I,Z,")]
    public class X12_ID_856
    {
    }
    
    /// <summary>
    /// Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,BT,DG,HL,LS,MS,OF,OH,OP,OQ,PA,PO,Q1,Q2,Q3,QA,QB,QC,QD,QE,QF,QH,QI,QK,QL,QM,QN" +
        ",QO,QP,QR,QS,QT,QU,QW,QX,QZ,RE,TS,WQ,")]
    public class X12_ID_859
    {
    }
    
    /// <summary>
    /// Initiator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",R,S,")]
    public class X12_ID_868
    {
    }
    
    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,028,029,030,031,032,033,050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,100,101,102,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,CEP,PRI,ZZZ,")]
    public class X12_ID_875
    {
    }
    
    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AI,CA,CP,DZ,GM,L,MC,PB,R,S,SI,SM,SR,SS,UC,UP,W,X,ZZ,")]
    public class X12_ID_88
    {
    }
    
    /// <summary>
    /// Pallet Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_883
    {
    }
    
    /// <summary>
    /// Nonconformance Report Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CL,FI,OC,OD,OI,OS,OT,RE,RV,")]
    public class X12_ID_886
    {
    }
    
    /// <summary>
    /// Nonconformance Resultant Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,FR,HE,IN,P,RE,RJ,RP,RQ,RS,RT,RW,SC,UA,UC,")]
    public class X12_ID_887
    {
    }
    
    /// <summary>
    /// Nonconformance Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,N,Y,")]
    public class X12_ID_888
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,N,P,R,S,W,X,Y,")]
    public class X12_ID_889
    {
    }
    
    /// <summary>
    /// Carrier/Route Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,ZZ,")]
    public class X12_ID_890
    {
    }
    
    /// <summary>
    /// Shipping Date Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,ZZ,")]
    public class X12_ID_891
    {
    }
    
    /// <summary>
    /// Line Item Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,20,21,22,23,24,25,26,ZZ,")]
    public class X12_ID_892
    {
    }
    
    /// <summary>
    /// Warehouse Detail Adjustment Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_893
    {
    }
    
    /// <summary>
    /// Batch Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,09,10,11,12,13,")]
    public class X12_ID_894
    {
    }
    
    /// <summary>
    /// Vessel Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,L,Z,")]
    public class X12_ID_897
    {
    }
    
    /// <summary>
    /// Late Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C1,D1,D2,D3,D4,D5,D6,E1,E2,E3,E4,E5,E6,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,")]
    public class X12_ID_9
    {
    }
    
    /// <summary>
    /// Measurement Unit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,N,X,")]
    public class X12_ID_90
    {
    }
    
    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,95,96,97,98,AB,AD,AR,BA,BC,BD,BG,BL,BP,BR,BS,BV,BW,CA,CB,CL,CM,CP,CS,CT,CU,DD,DG,DM,DP,DR,DV,E1,E2,E3,E4,E5,E6,E7,E8,EA,ER,ET,FR,GS,HB,HH,HX,ID,II,IN,KR,LK,LS,LW,MO,OG,OI,OR,OV,PF,PM,PN,RB,RD,RF,RH,RK,RL,RN,RP,RS,RT,SC,ST,SU,SW,T1,T2,T3,T4,T5,T6,TC,TD,TH,TL,TR,UC,UF,UG,WA,WK,ZZ,")]
    public class X12_ID_901
    {
    }
    
    /// <summary>
    /// Section Designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,H,N,S,")]
    public class X12_ID_902
    {
    }
    
    /// <summary>
    /// Envelope Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,N,T,")]
    public class X12_ID_903
    {
    }
    
    /// <summary>
    /// Requirement Designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,M,N,O,R,")]
    public class X12_ID_904
    {
    }
    
    /// <summary>
    /// Level Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_906
    {
    }
    
    /// <summary>
    /// Transportation Method/Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6,7,A,AC,AE,AF,AH,AR,B,BP,BU,C,CE,D,DA,DW,E,ED,F,FA,FL,GG,GR,GS,H,HH,I,J,K,L,LA," +
        "LT,M,MB,MP,N,O,P,PA,PG,PL,PP,PR,PT,Q,R,RC,RR,S,SB,SC,SD,SE,SR,SS,ST,T,TA,TC,TT,U" +
        ",VA,VE,VL,W,WP,X,Y,Y1,Y2,ZZ,")]
    public class X12_ID_91
    {
    }
    
    /// <summary>
    /// Relation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,L,P,R,")]
    public class X12_ID_912
    {
    }
    
    /// <summary>
    /// Data Element Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AN,B,DT,ID,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,R,TM,")]
    public class X12_ID_913
    {
    }
    
    /// <summary>
    /// Purchase Order Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AC,AO,BD,BE,BH,BK,BL,BQ,BY,CA,CC,CF,CN,CO,CP,CR,DR,DS,EO,FH,IN,JL,KA,KB,KC,KD" +
        ",KE,KG,KI,KN,KO,KP,KQ,KR,KS,KT,LB,LS,NE,NO,NP,NS,OS,PR,RA,RC,RE,RL,RN,RO,RR,RT,R" +
        "U,RW,SA,SO,SP,SS,ST,SW,TC,TM,TR,UD,UE,US,WO,ZZ,")]
    public class X12_ID_92
    {
    }
    
    /// <summary>
    /// Discipline Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,MS,OT,PT,SN,ST,")]
    public class X12_ID_921
    {
    }
    
    /// <summary>
    /// Electronic Form Standards Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,T,X,")]
    public class X12_ID_922
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
    /// Full or Partial Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,P,")]
    public class X12_ID_924
    {
    }
    
    /// <summary>
    /// Damage Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,")]
    public class X12_ID_927
    {
    }
    
    /// <summary>
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AT,DS,LC,NP,NS,SS,")]
    public class X12_ID_934
    {
    }
    
    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,ZZ,")]
    public class X12_ID_935
    {
    }
    
    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,40,41,42,44,45,46,48,49,50,51,52,Q1,Q2,TA,TB,ZZ,")]
    public class X12_ID_936
    {
    }
    
    /// <summary>
    /// Test Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,11,12,AG,CT,FL,MA,ME,PC,PO,SB,SP,")]
    public class X12_ID_937
    {
    }
    
    /// <summary>
    /// Test Medium Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,")]
    public class X12_ID_938
    {
    }
    
    /// <summary>
    /// Sample Process Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class X12_ID_939
    {
    }
    
    /// <summary>
    /// Sample Selection Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_940
    {
    }
    
    /// <summary>
    /// Sample Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,")]
    public class X12_ID_943
    {
    }
    
    /// <summary>
    /// Sample Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,")]
    public class X12_ID_944
    {
    }
    
    /// <summary>
    /// Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,30,31,32" +
        ",33,34,")]
    public class X12_ID_945
    {
    }
    
    /// <summary>
    /// Statistic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,40,41,42,43,44,53,AD,CF,CS,HG,KS,SK,SW,ZZ,")]
    public class X12_ID_950
    {
    }
    
    /// <summary>
    /// Balance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AM,C,CD,M,N,P,Q,Y,")]
    public class X12_ID_951
    {
    }
    
    /// <summary>
    /// Adjustment Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,L,S,")]
    public class X12_ID_952
    {
    }
    
    /// <summary>
    /// Tax Jurisdiction Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CD,VD,VE,")]
    public class X12_ID_955
    {
    }
    
    /// <summary>
    /// Payment Cancellation Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CAN,IND,")]
    public class X12_ID_959
    {
    }
    
    /// <summary>
    /// Request for Quote Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,BF,CB,")]
    public class X12_ID_960
    {
    }
    
    /// <summary>
    /// Receiving Advice or Acceptance Certificate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,R,")]
    public class X12_ID_962
    {
    }
    
    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AT,BP,CA,CB,CG,CI,CP,CR,CS,CT,CV,DL,EQ,ET,EV,F1,F2,F3,FD,FF,FI,FL,FR,FS,FT" +
        ",GR,GS,HS,HT,HZ,LB,LO,LS,LT,LU,LV,MA,MN,MP,MS,MT,OH,OT,PG,PS,SA,SB,SC,SE,SF,SL,S" +
        "P,SR,SS,ST,SU,SX,T1,T2,TD,TT,TX,UL,UT,VA,WS,ZA,ZB,ZC,ZD,ZE,ZZ,")]
    public class X12_ID_963
    {
    }
    
    /// <summary>
    /// Cost Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FNC,HAN,LAB,MTL,OCT,OTH,OVR,PKG,RMP,RMU,SET,TDI,TGA,TLN,TML,TMP,TOL,TPU,TTL,")]
    public class X12_ID_964
    {
    }
    
    /// <summary>
    /// Rate Basis Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,H,M,T,X,Y,")]
    public class X12_ID_969
    {
    }
    
    /// <summary>
    /// Tariff Reference Flag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",R,")]
    public class X12_ID_974
    {
    }
    
    /// <summary>
    /// Tariff Restriction ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_976
    {
    }
    
    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0H,10,11,1" +
        "2,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S," +
        "1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J" +
        ",2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3" +
        "A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40," +
        "41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R" +
        ",4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5" +
        "I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62,63,64,65,66,67,68," +
        "69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z" +
        ",70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7" +
        "Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G," +
        "8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97" +
        ",98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9" +
        "Z,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL," +
        "AAM,AAN,AAO,AAP,AAQ,AAS,AAT,AAU,AAV,AB,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,A" +
        "BL,ABM,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,ALA,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY," +
        "AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAL,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BKR,BL,BM,BN," +
        "BO,BP,BQ,BR,BRN,BS,BT,BU,BUS,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC," +
        "CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CMW,CN,CO,COL,COR,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ" +
        ",D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DCC,DD,DE,DF,DG,DH,DI,DIR,DJ,DK,DL,DM,DN,DO" +
        ",DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,E" +
        "G,EH,EI,EJ,EK,EL,EM,EN,ENR,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EXS,EY,EZ,F1,F2,F3,F4,F" +
        "5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FL,FM,FN,FO,FP,FQ,FR,FRL,FS,FSR,FT,F" +
        "U,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GIR,GJ,GK" +
        ",GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H5,H6,H7,H8,H9,HA,HB,HC,H" +
        "D,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HMI,HN,HO,HOM,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I1,I" +
        "3,I4,I9,IA,IAA,IAC,IAD,IAE,IAF,IAG,IAH,IAI,IAK,IAL,IAM,IAN,IAO,IAP,IAQ,IAR,IAS,I" +
        "AT,IAU,IAV,IAW,IAY,IAZ,IB,IC,ID,IE,IF,II,IJ,IK,IL,IM,IN,INV,IO,IP,IQ,IR,IS,IT,IU" +
        ",IV,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM,JN,JO,JP,J" +
        "Q,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE,KF,KG,KH," +
        "KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2,L3,L5,L8,L9,LA,LB,LC" +
        ",LD,LE,LF,LG,LGS,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LU,LV,LW,LY,LYM,LYN,LYO," +
        "LYP,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,M" +
        "P,MQ,MR,MS,MSC,MT,MU,MV,MW,MX,MY,MZ,N1,N2,N3,N4,N5,N6,N7,N8,N9,NB,NC,NCT,ND,NE,N" +
        "F,NG,NH,NI,NJ,NK,NL,NM,NN,NP,NPC,NQ,NR,NS,NT,NU,NV,NW,NX,NY,NZ,O1,O2,O3,O4,O5,O6" +
        ",O7,O8,OA,OB,OC,OD,OE,OF,OG,OH,OI,OK,OL,OM,ON,OO,OP,OR,ORI,OS,OT,OU,OV,OW,OX,OY," +
        "OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PLR,PM,PMF," +
        "PN,PO,PP,PPS,PQ,PR,PRE,PRP,PS,PT,PU,PUR,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q" +
        "9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ," +
        "R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RCR,RD,RE,REC,RF,RG,RGA,RH,RI,RJ,RK,RL,RM" +
        ",RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,S" +
        "D,SE,SEP,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T1,T2,T3" +
        ",T4,T6,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TPM,TQ,TR,TS,TSE,TS" +
        "R,TT,TTP,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI" +
        ",UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UW,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V8,V9,VA,VB,V" +
        "C,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VU,VV,VW,VX,VY,VZ,W1,W2,W3," +
        "W4,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WL,WN,WO,WP,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X1" +
        ",X2,X3,X4,X5,X6,X7,X8,XA,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,X" +
        "U,XV,XW,XX,XY,XZ,Y2,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT," +
        "YU,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZJ,ZK,ZL,ZM" +
        ",ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_98
    {
    }
    
    /// <summary>
    /// Tariff Section ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AT,BF,BS,CA,SR,ZA,ZB,")]
    public class X12_ID_980
    {
    }
    
    /// <summary>
    /// Tariff Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AM,CH,HA,HR,HU,II,MA,MH,MI,MN,NO,PA,RB,SE,SH,ST,TN,VE,")]
    public class X12_ID_981
    {
    }
    
    /// <summary>
    /// Data Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,03,05,07,09,")]
    public class X12_ID_982
    {
    }
    
    /// <summary>
    /// Hazardous Class Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,S,")]
    public class X12_ID_983
    {
    }
    
    /// <summary>
    /// Hazardous Material Shipping Name Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,I,")]
    public class X12_ID_984
    {
    }
    
    /// <summary>
    /// N.O.S. Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NOS,")]
    public class X12_ID_985
    {
    }
    
    /// <summary>
    /// Special Commodity Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",S,")]
    public class X12_ID_986
    {
    }
    
    /// <summary>
    /// Cryptographic Service Message (CSM) Message Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DSM,ERS,ESM,KSM,PKS,RFS,RSI,RSM,RTR,")]
    public class X12_ID_987
    {
    }
    
    /// <summary>
    /// Cryptographic Service Message (CSM) Field Tag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CTA,CTB,CTP,CTR,EDC,ERF,IDA,IDC,IDD,IDU,KD,KDU,KK,KKU,MAC,NOS,PKK,PKKU,SUBF,SVR," +
        "TID,")]
    public class X12_ID_988
    {
    }
    
    /// <summary>
    /// Delayed Repayment Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_998
    {
    }
    
    /// <summary>
    /// Scope of Power of Attorney Identification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AL,AU,ES,FG,FN,TA,UC,UH,UT,WR,WW,")]
    public class X12_ID_999
    {
    }
    
    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AK,BH,DL,PU,RD,RF,RJ,RT,TR,")]
    public class X12_ID_I40
    {
    }
    
    /// <summary>
    /// Error Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019," +
        "020,021,022,023,024,025,026,027,028,029,030,031,032,033,")]
    public class X12_ID_I43
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,Z,")]
    public class X12_ID_I58
    {
    }
    
    /// <summary>
    /// Report Incremental Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_I60
    {
    }
    
    /// <summary>
    /// Message Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_I61
    {
    }
    
    /// <summary>
    /// Report Status Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,Z,")]
    public class X12_ID_I62
    {
    }
    
    /// <summary>
    /// Report Level of Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_I63
    {
    }
}
