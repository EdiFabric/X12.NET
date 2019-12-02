namespace EdiFabric.Templates.Hipaa5010_999
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Runtime.Serialization;

    [Serializable()]
    [Message("X12", "005010X231A1", "999")]
    public class TS999 : EdiMessage
    {

        [DataMember()]
        [Pos(1)]
        public ST ST { get; set; }
        [DataMember()]
        [Pos(2)]
        public AK1 AK1 { get; set; }
        [DataMember()]
        [Pos(3)]
        public List<Loop_2000> Loop_2000 { get; set; }
        [DataMember()]
        [Pos(4)]
        public AK9 AK9 { get; set; }
        [DataMember()]
        [Pos(5)]
        public SE SE { get; set; }
    }
    
    [DataContract()]
    [Serializable()]
    public class X12_ID
    {
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",A,E,M,P,R,W,X,")]
    public class X12_ID_715
    {
    }
    
    [DataContract()]
    [Serializable()]
    public class X12_N0
    {
    }

    [DataContract()]
    [Serializable()]
    [Segment("AK9", typeof(X12_ID_715))]
    public class AK9
    {

        [DataMember()]
        [Pos(1)]
        public string FunctionalGroupAcknowledgeCode_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string NumberofTransactionSetsIncluded_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string NumberofReceivedTransactionSets_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string NumberofAcceptedTransactionSets_04 { get; set; }
        [DataMember()]
        [Pos(5)]
        public string FunctionalGroupSyntaxErrorCode_05 { get; set; }
        [DataMember()]
        [Pos(6)]
        public string FunctionalGroupSyntaxErrorCode_06 { get; set; }
        [DataMember()]
        [Pos(7)]
        public string FunctionalGroupSyntaxErrorCode_07 { get; set; }
        [DataMember()]
        [Pos(8)]
        public string FunctionalGroupSyntaxErrorCode_08 { get; set; }
        [DataMember()]
        [Pos(9)]
        public string FunctionalGroupSyntaxErrorCode_09 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(AK2))]
    public class Loop_2000
    {

        [DataMember()]
        [Pos(1)]
        public AK2 AK2 { get; set; }
        [DataMember()]
        [Pos(2)]
        public List<Loop_2100> Loop_2100 { get; set; }
        [DataMember()]
        [Pos(3)]
        public IK5 IK5 { get; set; }
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",A,E,M,R,W,X,")]
    public class X12_ID_717
    {
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,12,13,15,16,17,18,19,23,24,25,26,27,I5,I6,")]
    public class X12_ID_618
    {
    }

    [DataContract()]
    [Serializable()]
    [Segment("IK5", typeof(X12_ID_717), typeof(X12_ID_618))]
    public class IK5
    {

        [DataMember()]
        [Pos(1)]
        public string TransactionSetAcknowledgmentCode_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string ImplementationTransactionSetSyntaxErrorCode_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string ImplementationTransactionSetSyntaxErrorCode_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string ImplementationTransactionSetSyntaxErrorCode_04 { get; set; }
        [DataMember()]
        [Pos(5)]
        public string ImplementationTransactionSetSyntaxErrorCode_05 { get; set; }
        [DataMember()]
        [Pos(6)]
        public string ImplementationTransactionSetSyntaxErrorCode_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(IK3))]
    public class Loop_2100
    {

        [DataMember()]
        [Pos(1)]
        public IK3 IK3 { get; set; }
        [DataMember()]
        [Pos(2)]
        public List<CTX_Seg> CTX_Seg { get; set; }
        [DataMember()]
        [Pos(3)]
        public CTX_BU CTX_BU { get; set; }
        [DataMember()]
        [Pos(4)]
        public List<Loop_2110> Loop_2110 { get; set; }
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",SITUATIONAL TRIGGER,")]
    public class X12_ID_9999
    {
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",AAA,ACD,ACK,ACS,ACT,AD1,ADI,ADJ,ADT,ADV,ADX,AEI,AES,AIN,AK1,AK2,AK3,AK4,AK5,AK9," +
        "AM1,AMT,ANI,AOC,AOI,AOL,AOR,AP1,APE,API,APR,ARC,ARS,ASI,ASL,ASM,ASO,AST,AT1,AT2," +
        "AT3,AT4,AT5,AT6,AT7,AT8,AT9,ATA,ATH,ATN,ATR,ATV,AVA,AWD,AXL,B1,B2,B3,B4,B9,B10,B" +
        "11,B12,B13,B2A,B3A,B3B,B9A,BA1,BA2,BAA,BAK,BAL,BAT,BAU,BAX,BBC,BC,BCA,BCD,BCH,BC" +
        "I,BCM,BCO,BCP,BCQ,BCS,BCT,BCU,BDD,BDS,BEG,BEN,BEP,BFR,BFS,BGF,BGN,BGP,BHT,BIA,BI" +
        "G,BIN,BIX,BJF,BL,BLI,BLN,BLR,BLS,BMA,BMG,BMM,BMP,BMS,BNR,BNX,BOL,BOR,BOS,BOX,BPA" +
        ",BPP,BPR,BPT,BQR,BQT,BR,BRA,BRC,BRR,BSC,BSD,BSF,BSI,BSN,BSR,BSS,BSW,BT1,BTA,BTC," +
        "BTI,BTP,BTR,BTS,BUY,BVA,BVB,BVP,BVS,BW,BX,C2,C3,C4,C8,C8C,CA1,CAD,CAI,CAL,CAS,CA" +
        "T,CB1,CBS,CCI,CD,CD1,CD2,CD3,CDA,CDD,CDI,CDS,CED,CF1,CF2,CFI,CFT,CGS,CHB,CHR,CI," +
        "CIC,CID,CII,CIV,CL1,CLD,CLI,CLM,CLP,CLR,CM,CMA,CMC,CN1,COB,COM,CON,CPR,CQ,CR1,CR" +
        "2,CR3,CR4,CR5,CR6,CR7,CR8,CRC,CRD,CRI,CRO,CRS,CRT,CRV,CS,CSB,CSC,CSD,CSE,CSF,CSH" +
        ",CSI,CSM,CSS,CST,CSU,CT,CTB,CTC,CTP,CTT,CTX,CUR,CV,CYC,D9,DAD,DAI,DAM,DB,DD,DDI," +
        "DED,DEF,DEG,DEL,DEP,DEX,DFI,DH,DIS,DK,DL,DLV,DM,DMA,DMG,DMI,DN,DN1,DN2,DOS,DP,DP" +
        "N,DR,DRT,DSB,DTM,DTP,DVI,E1,E4,E5,E6,E8,E01,E03,E10,E13,E20,E22,E24,E26,E30,E34," +
        "E40,E41,EA,EB,EC,ED,EDF,EFI,EI,EIA,ELV,EM,EMP,EMS,EMT,ENE,ENM,ENR,ENT,EQ,EQD,ER," +
        "ERI,ERP,ES,ESI,ETD,EXI,F9,F01,F02,F04,F05,F07,F09,F10,F11,F12,F13,F14,F6X,FA1,FA" +
        "2,FAA,FAC,FBB,FC,FCL,FDA,FG,FGS,FH,FIR,FIS,FK,FNA,FOB,FOS,FPT,FRM,FSA,FST,FTH,G1" +
        ",G2,G3,G4,G5,G01,G05,G07,G08,G11,G12,G13,G14,G15,G17,G18,G19,G20,G21,G22,G23,G24" +
        ",G25,G26,G28,G29,G30,G31,G32,G33,G35,G36,G37,G38,G39,G40,G42,G43,G45,G46,G47,G48" +
        ",G49,G50,G51,G53,G54,G55,G61,G62,G63,G66,G68,G69,G70,G72,G73,G76,G82,G83,G84,G85" +
        ",G86,G87,G88,G89,G91,G92,G93,G94,G95,GA,GDP,GE,GF,GH,GID,GR,GR2,GR4,GR5,GRI,GRP," +
        "GS,GY,H1,H2,H3,H5,H6,HAD,HC,HCP,HCR,HD,HI,HL,HLH,HPL,HS,HSD,IA,IC,ICH,ICM,ID,ID1" +
        ",ID2,ID3,ID4,IDB,IDC,IEA,IGI,IH,III,IIS,IK3,IK4,IK5,IM,IMA,IMC,IMM,IMP,IN1,IN2,I" +
        "NC,IND,INI,INQ,INR,INS,INT,INV,INX,IRA,IRP,IS1,IS2,ISA,ISB,ISC,ISD,ISE,ISI,ISR,I" +
        "SS,IT,IT1,IT3,IT8,ITA,ITC,ITD,IV1,JCT,JID,JIL,JIT,JL,JS,K1,K2,K3,L0,L1,L3,L4,L5," +
        "L7,L8,L9,L10,L11,L12,L13,L1A,LAD,LC,LC1,LCD,LCT,LDT,LE,LEP,LEQ,LET,LFG,LFH,LFI,L" +
        "H,LH1,LH2,LH3,LH4,LH6,LHE,LHR,LHT,LIC,LID,LIE,LIN,LM,LN,LN1,LN2,LOC,LOD,LP,LQ,LR" +
        "Q,LS,LS1,LT,LTE,LTR,LUC,LUI,LV,LX,M0,M1,M2,M3,M7,M10,M11,M12,M13,M14,M15,M20,M21" +
        ",M7A,MAN,MBL,MC,MCD,MCT,MEA,MI,MI1,MIA,MIC,MII,MIN,MIR,MIS,MIT,MKS,MLA,MLS,MNC,M" +
        "OA,MPI,MPP,MRC,MS,MS1,MS2,MS3,MS4,MS5,MS6,MSG,MSI,MSS,MTX,N1,N2,N3,N4,N5,N7,N8,N" +
        "9,N10,N11,N12,N7A,N7B,N8A,NA,NCA,NCD,NM1,NTE,NX1,NX2,OBI,OD,OI,OID,OOI,OP,OPS,OP" +
        "X,OQS,ORI,OTI,P1,P2,P4,P5,PAD,PAI,PAL,PAM,PAS,PAT,PAY,PBI,PCL,PCR,PCS,PCT,PD,PDD" +
        ",PDE,PDI,PDL,PDP,PDR,PDS,PEN,PER,PEX,PI,PID,PIN,PKD,PKG,PKL,PL,PLA,PLB,PLC,PLD,P" +
        "LI,PM,PO1,PO3,PO4,POC,POD,PPA,PPD,PPL,PPY,PR,PR1,PR2,PRC,PRD,PRF,PRI,PRJ,PRM,PRR" +
        ",PRS,PRT,PRV,PS,PS1,PSA,PSC,PSD,PT,PTD,PTF,PTS,PUN,PWK,PYD,PYM,PYT,Q2,Q3,Q5,Q6,Q" +
        "7,Q8,QTY,R1,R2,R3,R4,R9,R11,R12,R13,R2A,R2B,R2C,R2D,RA,RAB,RAP,RAT,RB,RC,RCD,RCR" +
        ",RD,RDD,RDI,RDM,RDR,RDT,RE,REA,REC,RED,REF,REL,REN,REP,REQ,RES,RET,RH,RIC,RLD,RL" +
        "T,RMR,RMT,RO,RP,RPA,RQS,RRA,RS,RSC,RSD,RST,RT,RT1,RTE,RTS,RTT,RU1,RU2,RU3,RYL,S1" +
        ",S2,S5,S9,S3A,S3E,S3S,S4A,S4E,S4S,SA,SAC,SAD,SAL,SB,SBR,SBT,SC,SCA,SCD,SCH,SCL,S" +
        "CM,SCN,SCP,SCR,SCS,SCT,SD1,SDP,SDQ,SE,SER,SES,SFC,SG,SHD,SHI,SHP,SHR,SI,SID,SII," +
        "SIN,SL1,SLA,SLI,SLN,SMA,SMB,SMD,SMO,SMR,SMS,SN1,SOI,SOM,SP,SPA,SPE,SPI,SPK,SPR,S" +
        "PS,SPY,SR,SRA,SRD,SRE,SRM,SRT,SS,SSC,SSD,SSE,SSS,SST,ST,STA,STC,STP,STS,SUM,SUP," +
        "SV,SV1,SV2,SV3,SV4,SV5,SV6,SV7,SVA,SVC,SVD,SW,SWC,SWD,SWR,T1,T2,T3,T6,T8,TA,TA1," +
        "TA3,TAX,TBA,TBI,TC2,TCD,TD1,TD3,TD4,TD5,TDS,TDT,TED,TEM,TER,TF,TFA,TFD,TFM,TFR,T" +
        "FS,THE,TI,TIA,TID,TII,TIS,TLN,TMD,TOA,TOO,TOV,TPB,TPD,TRF,TRL,TRN,TRS,TS,TS2,TS3" +
        ",TSD,TSI,TSP,TST,TSU,TT,TUD,TXI,TXN,TXP,UC,UCS,UD,UDA,UIT,UM,UQS,UR,USD,USI,UWI," +
        "V1,V2,V3,V4,V5,V9,VAD,VAR,VAT,VC,VC1,VDI,VEH,VID,VR,VRC,W1,W2,W3,W4,W5,W6,W01,W0" +
        "3,W04,W05,W06,W07,W08,W09,W10,W12,W13,W14,W15,W17,W18,W19,W20,W27,W28,W66,W76,WG" +
        "P,WLD,WS,X1,X2,X4,X7,X01,X02,XD,XH,XPO,XQ,Y1,Y2,Y3,Y4,Y5,Y6,Y7,YNQ,ZA,ZC1,ZD,ZR," +
        "ZT,")]
    public class X12_ID_721
    {
    }
    
    [DataContract()]
    [Serializable()]
    [EdiCodes(",TRN02,NM109,PATIENT NAME NM109,SUBSCRIBER NAME NM109,ENT01,SUBSCRIBER NUMBER REF" +
        "02,CLM01,")]
    public class X12_ID_9999_2
    {
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(IK4))]
    public class Loop_2110
    {

        [DataMember()]
        [Pos(1)]
        public IK4 IK4 { get; set; }
        [DataMember()]
        [Pos(2)]
        public List<CTX_Ele> CTX_Ele { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("CTX", typeof(X12_ID_9999), typeof(X12_ID_721))]
    public class CTX_Ele
    {

        [DataMember()]
        [Pos(1)]
        public List<CTX_Ele1> Ele_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Ele_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string Ele_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string Ele_04 { get; set; }
        [DataMember()]
        [Pos(5)]
        public CTX_Ele5 Ele_05 { get; set; }
        [DataMember()]
        [Pos(6)]
        public CTX_Ele6 Ele_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Ele6")]
    public class CTX_Ele6
    {

        [DataMember()]
        [Pos(1)]
        public string Ele_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Ele_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Ele5")]
    public class CTX_Ele5
    {

        [DataMember()]
        [Pos(1)]
        public string Ele_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Ele_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string Ele_03 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Ele1")]
    public class CTX_Ele1
    {

        [DataMember()]
        [Pos(1)]
        public string Ele_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Ele_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("IK4")]
    public class IK4
    {

        [DataMember()]
        [Pos(1)]
        public C030_PositionInSegment PositionInSegment_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string ImplementationDataElementSyntaxErrorCode_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string CopyofBadDataElement_04 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("C030_PositionInSegment")]
    public class C030_PositionInSegment
    {

        [DataMember()]
        [Pos(1)]
        public string ElementPositionInSegment_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string ComponentDataElementPositionInComposite_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string RepeatingDataElementPosition_03 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("CTX", typeof(X12_ID_9999_2), typeof(X12_ID_721))]
    public class CTX_BU
    {

        [DataMember()]
        [Pos(1)]
        public List<CTX_BU1> BU_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string BU_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string BU_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string BU_04 { get; set; }
        [DataMember()]
        [Pos(5)]
        public CTX_BU5 BU_05 { get; set; }
        [DataMember()]
        [Pos(6)]
        public CTX_BU6 BU_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_BU6")]
    public class CTX_BU6
    {

        [DataMember()]
        [Pos(1)]
        public string BU_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string BU_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_BU5")]
    public class CTX_BU5
    {

        [DataMember()]
        [Pos(1)]
        public string BU_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string BU_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string BU_03 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_BU1")]
    public class CTX_BU1
    {

        [DataMember()]
        [Pos(1)]
        public string BU_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string BU_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("CTX", typeof(X12_ID_9999), typeof(X12_ID_721))]
    public class CTX_Seg
    {

        [DataMember()]
        [Pos(1)]
        public List<CTX_Seg1> Seg_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Seg_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string Seg_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string Seg_04 { get; set; }
        [DataMember()]
        [Pos(5)]
        public CTX_Seg5 Seg_05 { get; set; }
        [DataMember()]
        [Pos(6)]
        public CTX_Seg6 Seg_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Seg6")]
    public class CTX_Seg6
    {

        [DataMember()]
        [Pos(1)]
        public string Seg_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Seg_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Seg5")]
    public class CTX_Seg5
    {

        [DataMember()]
        [Pos(1)]
        public string Seg_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Seg_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string Seg_03 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Composite("CTX_Seg1")]
    public class CTX_Seg1
    {

        [DataMember()]
        [Pos(1)]
        public string Seg_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string Seg_02 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("IK3")]
    public class IK3
    {

        [DataMember()]
        [Pos(1)]
        public string SegmentIDCode_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string SegmentPositioninTransactionSet_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string LoopIdentifierCode_03 { get; set; }
        [DataMember()]
        [Pos(4)]
        public string ImplementationSegmentSyntaxErrorCode_04 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("AK2")]
    public class AK2
    {

        [DataMember()]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string ImplementationConventionReference_03 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("AK1")]
    public class AK1
    {

        [DataMember()]
        [Pos(1)]
        public string FunctionalIdentifierCode_01 { get; set; }
        [DataMember()]
        [Pos(2)]
        public string GroupControlNumber_02 { get; set; }
        [DataMember()]
        [Pos(3)]
        public string VersionReleaseorIndustryIdentifierCode_03 { get; set; }
    }
}
