namespace EdiFabric.Templates.EdifactD96A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_A
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_AN
    {
    }
    
    /// <summary>
    /// Document/message name, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",130,325,380,381,382,383,384,385,386,389,390,393,82,83,84,")]
    public class EDIFACT_ID_1001
    {
    }
    
    /// <summary>
    /// Code list qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_1131
    {
    }
    
    /// <summary>
    /// Reference qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAB,AAJ,AAK,AFO,ALL,CD,CIN,COE,CR,DL,DQ,IV,ON,PL,RF,VN,")]
    public class EDIFACT_ID_1153
    {
    }
    
    /// <summary>
    /// MESSAGE FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,31,43,5,7,9,")]
    public class EDIFACT_ID_1225
    {
    }
    
    /// <summary>
    /// CALCULATION SEQUENCE INDICATOR, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    /// <summary>
    /// ACTION REQUEST/NOTIFICATION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_1229
    {
    }
    
    /// <summary>
    /// Date/time/period qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,137,263,325,35,50,")]
    public class EDIFACT_ID_2005
    {
    }
    
    /// <summary>
    /// Time relation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,")]
    public class EDIFACT_ID_2009
    {
    }
    
    /// <summary>
    /// Type of period, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,M,WD,Y,")]
    public class EDIFACT_ID_2151
    {
    }
    
    /// <summary>
    /// Date/time/period format qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",102,203,718,")]
    public class EDIFACT_ID_2379
    {
    }
    
    /// <summary>
    /// Payment time reference, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,")]
    public class EDIFACT_ID_2475
    {
    }
    
    /// <summary>
    /// PARTY QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BO,BS,BY,CN,CS,DP,II,IV,PE,RE,SE,SN,SR,ST,SU,")]
    public class EDIFACT_ID_3035
    {
    }
    
    /// <summary>
    /// Party name format, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3045
    {
    }
    
    /// <summary>
    /// Code list responsible agency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_3055
    {
    }
    
    /// <summary>
    /// CONTACT FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AP,AR,GR,PD,")]
    public class EDIFACT_ID_3139
    {
    }
    
    /// <summary>
    /// Communication channel qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EM,FX,TE,TL,XF,")]
    public class EDIFACT_ID_3155
    {
    }
    
    /// <summary>
    /// COUNTRY, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AD,AE,AF,AG,AL,AM,AO,AR,AT,AU,AZ,BA,BB,BD,BE,BG,BH,BI,BJ,BM,BO,BR,BS,BW,BY,BZ,CA,CF,CG,CH,CI,CL,CM,CN,CO,CR,CU,CY,CZ,DE,DK,DO,DZ,EC,EE,EG,ES,ET,FI,FJ,FR,GA,GB,GE,GH,GI,GM,GR,GT,GY,HK,HN,HR,HT,HU,ID,IE,IL,IN,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KP,KR,KW,KZ,LB,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MK,MT,MX,MY,MZ,NA,NG,NI,NL,NO,NZ,OM,PA,PE,PG,PH,PK,PL,PR,PT,PY,QA,RO,RU,RW,SA,SD,SE,SG,SI,SK,SM,SV,SY,SZ,TH,TJ,TM,TN,TR,TW,UA,UG,US,UY,UZ,VE,VN,YU,ZA,ZM,ZR,ZW,")]
    public class EDIFACT_ID_3207
    {
    }
    
    /// <summary>
    /// PLACE/LOCATION QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,5,7,")]
    public class EDIFACT_ID_3227
    {
    }
    
    /// <summary>
    /// Institution name identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BK,PO,")]
    public class EDIFACT_ID_3433
    {
    }
    
    /// <summary>
    /// LANGUAGE, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AF,AM,AR,AS,AY,AZ,BA,BE,BG,BH,BI,BN,BO,BR,CA,CO,CS,CY,DA,DE,DZ,EL,EN,EO,ES,ET,EU,FA,FI,FJ,FO,FR,FY,GA,GD,GL,GN,GU,HA,HE,HI,HR,HU,HY,IA,ID,IE,IK,IS,IT,IU,JA,JW,KA,KL,KM,KN,KO,KS,KU,KY,LA,LN,LO,LT,LV,MG,MI,MK,ML,MN,MO,MR,MS,MT,NA,NE,NL,NO,OC,OM,OR,PA,PL,PS,PT,QU,RM,RN,RO,RU,RW,SA,SD,SG,SH,SI,SK,SL,SM,SN,SO,SQ,SR,SS,ST,SU,SV,SW,TA,TE,TG,TH,TI,TK,TL,TN,TO,TR,TS,TT,TW,UG,UK,UR,UZ,VI,VO,WO,YI,YO,ZA,ZH,ZU,")]
    public class EDIFACT_ID_3453
    {
    }
    
    /// <summary>
    /// Terms of delivery or transport, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01E,02E,03E,04E,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,EXW,FAS,FCA,FOA,FOB,FOR,")]
    public class EDIFACT_ID_4053
    {
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,6,")]
    public class EDIFACT_ID_4055
    {
    }
    
    /// <summary>
    /// SPECIAL CONDITIONS, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",15,6,65E,76E,78E,79E,80E,")]
    public class EDIFACT_ID_4183
    {
    }
    
    /// <summary>
    /// TRANSPORT CHARGES METHOD OF PAYMENT, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DF,PC,")]
    public class EDIFACT_ID_4215
    {
    }
    
    /// <summary>
    /// DISCREPANCY, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,CP,OW,TW,")]
    public class EDIFACT_ID_4221
    {
    }
    
    /// <summary>
    /// MARKING INSTRUCTIONS, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",33E,")]
    public class EDIFACT_ID_4233
    {
    }
    
    /// <summary>
    /// Terms of payment identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_4277
    {
    }
    
    /// <summary>
    /// PAYMENT TERMS TYPE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10E,20,22,3,7,")]
    public class EDIFACT_ID_4279
    {
    }
    
    /// <summary>
    /// Change reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AJT,")]
    public class EDIFACT_ID_4295
    {
    }
    
    /// <summary>
    /// RESPONSE TYPE, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_4343
    {
    }
    
    /// <summary>
    /// PRODUCT ID. FUNCTION QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,4,5,")]
    public class EDIFACT_ID_4347
    {
    }
    
    /// <summary>
    /// Status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_4405
    {
    }
    
    /// <summary>
    /// Payment guarantee, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",20,")]
    public class EDIFACT_ID_4431
    {
    }
    
    /// <summary>
    /// Payment channel, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4435
    {
    }
    
    /// <summary>
    /// Payment conditions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,OA,")]
    public class EDIFACT_ID_4439
    {
    }
    
    /// <summary>
    /// Free text, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,")]
    public class EDIFACT_ID_4441
    {
    }
    
    /// <summary>
    /// TEXT SUBJECT QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PUR,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    /// <summary>
    /// TEXT FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4453
    {
    }
    
    /// <summary>
    /// Payment means, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10E,13E,42,60,70,")]
    public class EDIFACT_ID_4461
    {
    }
    
    /// <summary>
    /// SETTLEMENT, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,5,6,")]
    public class EDIFACT_ID_4471
    {
    }
    
    /// <summary>
    /// Monetary amount type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",124,125,")]
    public class EDIFACT_ID_5025
    {
    }
    
    /// <summary>
    /// Price qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAE,AAF,")]
    public class EDIFACT_ID_5125
    {
    }
    
    /// <summary>
    /// Duty/tax/fee type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",GST,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    /// <summary>
    /// Charge/allowance description, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",64E,")]
    public class EDIFACT_ID_5189
    {
    }
    
    /// <summary>
    /// SUB-LINE PRICE CHANGE, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_5213
    {
    }
    
    /// <summary>
    /// Percentage qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",12,15,16,7,")]
    public class EDIFACT_ID_5245
    {
    }
    
    /// <summary>
    /// Percentage basis, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",13,")]
    public class EDIFACT_ID_5249
    {
    }
    
    /// <summary>
    /// Duty/tax/fee rate basis identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    /// <summary>
    /// DUTY/TAX/FEE FUNCTION QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,7,")]
    public class EDIFACT_ID_5283
    {
    }
    
    /// <summary>
    /// DUTY/TAX/FEE CATEGORY, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,S,")]
    public class EDIFACT_ID_5305
    {
    }
    
    /// <summary>
    /// Price type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CT,")]
    public class EDIFACT_ID_5375
    {
    }
    
    /// <summary>
    /// Price type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DPR,PPR,PRP,RTP,SRP,")]
    public class EDIFACT_ID_5387
    {
    }
    
    /// <summary>
    /// Rate type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_5419
    {
    }
    
    /// <summary>
    /// ALLOWANCE OR CHARGE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,")]
    public class EDIFACT_ID_5463
    {
    }
    
    /// <summary>
    /// Sub-line indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5495
    {
    }
    
    /// <summary>
    /// Quantity qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6063
    {
    }
    
    /// <summary>
    /// Control qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,11,15,2,26,7,")]
    public class EDIFACT_ID_6069
    {
    }
    
    /// <summary>
    /// Measurement attribute, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_6155
    {
    }
    
    /// <summary>
    /// RANGE TYPE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_6167
    {
    }
    
    /// <summary>
    /// MEASUREMENT APPLICATION QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PD,SO,TL,")]
    public class EDIFACT_ID_6311
    {
    }
    
    /// <summary>
    /// Measurement dimension, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAF,HT,LN,WD,")]
    public class EDIFACT_ID_6313
    {
    }
    
    /// <summary>
    /// Measurement significance, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,4,")]
    public class EDIFACT_ID_6321
    {
    }
    
    /// <summary>
    /// CURRENCY MARKET EXCHANGE, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_6341
    {
    }
    
    /// <summary>
    /// Currency qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_6343
    {
    }
    
    /// <summary>
    /// Currency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ARS,ATS,AUD,BEF,BGL,BRL,CAD,CHF,CLP,CNY,COP,CRC,CUP,CYP,CZK,DEM,DKK,DZD,ECS,EEK,EGP,ESP,EUR,FIM,FRF,GBP,GRD,GTQ,HKD,HNL,HRD,HUF,IDR,IEP,ILS,INR,IQD,IRR,ISK,ITL,JOD,JPY,KPW,KWD,LKR,LTL,LUF,LVL,MAD,MTL,MXN,MYR,NAD,NIO,NLG,NOK,NZD,PAB,PEN,PHP,PKR,PLZ,PTE,PYG,ROL,RUR,SAR,SEK,SGD,SIT,SKK,SVC,THB,TND,TRL,TWD,USD,UYU,VEB,XEU,YUN,ZAR,")]
    public class EDIFACT_ID_6345
    {
    }
    
    /// <summary>
    /// Currency details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,")]
    public class EDIFACT_ID_6347
    {
    }
    
    /// <summary>
    /// Measure unit qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",KGM,LTR,")]
    public class EDIFACT_ID_6411
    {
    }
    
    /// <summary>
    /// Item description identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CU,DU,RC,SER,TU,VQ,")]
    public class EDIFACT_ID_7009
    {
    }
    
    /// <summary>
    /// Type of packages identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,CR,CX,")]
    public class EDIFACT_ID_7065
    {
    }
    
    /// <summary>
    /// Packaging terms and conditions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_7073
    {
    }
    
    /// <summary>
    /// Packaging level, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_7075
    {
    }
    
    /// <summary>
    /// Item description type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_7077
    {
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",13,3,33,35,38,4,61,75,76,77,78,79,80,81,82,83,84,85,86,98,ANM,AVI,BPD,BRN,BVP,CE" +
        "R,DSC,EDS,FIC,GDC,HAN,HAZ,IDC,IRC,ISC,ISY,KEY,MD,MNF,NAV,RLI,SDS,STE,TDS,TPE,U01" +
        ",U02,U03,U04,U05,U06,U07,WVL,")]
    public class EDIFACT_ID_7081
    {
    }
    
    /// <summary>
    /// CONFIGURATION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,")]
    public class EDIFACT_ID_7083
    {
    }
    
    /// <summary>
    /// Item number type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_7143
    {
    }
    
    /// <summary>
    /// Special services, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AJ,CAC,COD,EAB,FC,FI,HD,QD,")]
    public class EDIFACT_ID_7161
    {
    }
    
    /// <summary>
    /// Packaging related information, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",50,51,52,53,54,BDM,BNM,INM,PNM,PRM,RCM,RNM,")]
    public class EDIFACT_ID_7233
    {
    }
    
    /// <summary>
    /// SURFACE/LAYER INDICATOR, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_7383
    {
    }
    
    /// <summary>
    /// IDENTITY NUMBER QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BJ,")]
    public class EDIFACT_ID_7405
    {
    }
    
    /// <summary>
    /// TRANSPORT STAGE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",20,")]
    public class EDIFACT_ID_8051
    {
    }
    
    /// <summary>
    /// Mode of transport, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,20,30,40,")]
    public class EDIFACT_ID_8067
    {
    }
    
    /// <summary>
    /// TRANSIT DIRECTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,")]
    public class EDIFACT_ID_8101
    {
    }
    
    /// <summary>
    /// Type of means of transport identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",23,25,31,")]
    public class EDIFACT_ID_8179
    {
    }
    
    /// <summary>
    /// CONTAINER/PACKAGE STATUS, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_8275
    {
    }
    
    /// <summary>
    /// TRANSPORT OWNERSHIP, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_8281
    {
    }
    
    /// <summary>
    /// Returnable package load contents, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_8393
    {
    }
    
    /// <summary>
    /// Returnable package freight payment responsibility, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,")]
    public class EDIFACT_ID_8395
    {
    }
    
    /// <summary>
    /// Excess transportation reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_8457
    {
    }
    
    /// <summary>
    /// Excess transportation responsibility, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class EDIFACT_ID_8459
    {
    }
    
    /// <summary>
    /// TYPE OF DUTY REGIME, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,8,9,")]
    public class EDIFACT_ID_9213
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_N
    {
    }
}
