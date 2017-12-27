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
    [Message("X12", "005010X222A1", "834")]
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
        [Pos(7)]
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
        [Pos(1)]
        public PER Per_MemberCommunicationNumbers { get; set; }
    }

}
