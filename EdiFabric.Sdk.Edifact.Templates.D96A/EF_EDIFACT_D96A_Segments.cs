namespace EdiFabric.Templates.EdifactD96A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC : I_ALC<C552, C214>
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string ALLOWANCEORCHARGEQUALIFIER_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// SETTLEMENT, CODED
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string SETTLEMENTCODED_03 { get; set; }
        /// <summary>
        /// CALCULATION SEQUENCE INDICATOR, CODED
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string CALCULATIONSEQUENCEINDICATORCODED_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALI")]
    public class ALI : I_ALI
    {
        
        /// <summary>
        /// COUNTRY OF ORIGIN, CODED
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string COUNTRYOFORIGINCODED_01 { get; set; }
        /// <summary>
        /// TYPE OF DUTY REGIME, CODED
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string TYPEOFDUTYREGIMECODED_02 { get; set; }
        /// <summary>
        /// SPECIAL CONDITIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string SPECIALCONDITIONSCODED_03 { get; set; }
        /// <summary>
        /// SPECIAL CONDITIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string SPECIALCONDITIONSCODED_04 { get; set; }
        /// <summary>
        /// SPECIAL CONDITIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string SPECIALCONDITIONSCODED_05 { get; set; }
        /// <summary>
        /// SPECIAL CONDITIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string SPECIALCONDITIONSCODED_06 { get; set; }
        /// <summary>
        /// SPECIAL CONDITIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string SPECIALCONDITIONSCODED_07 { get; set; }
    }
    
    /// <summary>
    /// BEGINNING OF MESSAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM : I_BGM<C002>
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NUMBER
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DOCUMENTMESSAGENUMBER_02 { get; set; }
        /// <summary>
        /// MESSAGE FUNCTION, CODED
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string MESSAGEFUNCTIONCODED_03 { get; set; }
        /// <summary>
        /// RESPONSE TYPE, CODED
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string RESPONSETYPECODED_04 { get; set; }
    }
    
    /// <summary>
    /// CONTROL TOTAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT : I_CNT<C270>
    {
        
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM : I_COM<C076>
    {
        
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA : I_CTA<C056>
    {
        
        /// <summary>
        /// CONTACT FUNCTION, CODED
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string CONTACTFUNCTIONCODED_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// CURRENCIES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX : I_CUX<C504, C504>
    {
        
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// RATE OF EXCHANGE
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string RATEOFEXCHANGE_03 { get; set; }
        /// <summary>
        /// CURRENCY MARKET EXCHANGE, CODED
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string CURRENCYMARKETEXCHANGECODED_04 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM : I_DTM<C507>
    {
        
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// FINANCIAL INSTITUTION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII : I_FII<C078, C088>
    {
        
        /// <summary>
        /// PARTY QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PARTYQUALIFIER_01 { get; set; }
        /// <summary>
        /// ACCOUNT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C078 ACCOUNTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// COUNTRY, CODED
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string COUNTRYCODED_04 { get; set; }
    }
    
    /// <summary>
    /// FREE TEXT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX : I_FTX<C107, C108>
    {
        
        /// <summary>
        /// TEXT SUBJECT QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string TEXTSUBJECTQUALIFIER_01 { get; set; }
        /// <summary>
        /// TEXT FUNCTION, CODED
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string TEXTFUNCTIONCODED_02 { get; set; }
        /// <summary>
        /// TEXT REFERENCE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        /// <summary>
        /// TEXT LITERAL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        /// <summary>
        /// LANGUAGE, CODED
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string LANGUAGECODED_05 { get; set; }
    }
    
    /// <summary>
    /// GOODS IDENTITY NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN : I_GIN<C208, C208, C208, C208, C208>
    {
        
        /// <summary>
        /// IDENTITY NUMBER QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string IDENTITYNUMBERQUALIFIER_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD : I_IMD<C273>
    {
        
        /// <summary>
        /// ITEM DESCRIPTION TYPE, CODED
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string ITEMDESCRIPTIONTYPECODED_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC, CODED
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public string ITEMCHARACTERISTICCODED_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// SURFACE/LAYER INDICATOR, CODED
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string SURFACELAYERINDICATORCODED_04 { get; set; }
    }
    
    /// <summary>
    /// LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN : I_LIN<C212, C829>
    {
        
        /// <summary>
        /// LINE ITEM NUMBER
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public string LINEITEMNUMBER_01 { get; set; }
        /// <summary>
        /// ACTION REQUEST/NOTIFICATION, CODED
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string ACTIONREQUESTNOTIFICATIONCODED_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// SUB-LINE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        /// <summary>
        /// CONFIGURATION LEVEL
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string CONFIGURATIONLEVEL_05 { get; set; }
        /// <summary>
        /// CONFIGURATION, CODED
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string CONFIGURATIONCODED_06 { get; set; }
    }
    
    /// <summary>
    /// PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC : I_LOC<C517, C519, C553>
    {
        
        /// <summary>
        /// PLACE/LOCATION QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string PLACELOCATIONQUALIFIER_01 { get; set; }
        /// <summary>
        /// LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// RELATION, CODED
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string RELATIONCODED_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA : I_MEA<C502, C174>
    {
        
        /// <summary>
        /// MEASUREMENT APPLICATION QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string MEASUREMENTAPPLICATIONQUALIFIER_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// SURFACE/LAYER INDICATOR, CODED
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string SURFACELAYERINDICATORCODED_04 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA : I_MOA<C516>
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD : I_NAD<C082, C058, C080, C059>
    {
        
        /// <summary>
        /// PARTY QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PARTYQUALIFIER_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }
        /// <summary>
        /// STREET
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C059 STREET_05 { get; set; }
        /// <summary>
        /// CITY NAME
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CITYNAME_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY IDENTIFICATION
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string COUNTRYSUBENTITYIDENTIFICATION_07 { get; set; }
        /// <summary>
        /// POSTCODE IDENTIFICATION
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string POSTCODEIDENTIFICATION_08 { get; set; }
        /// <summary>
        /// COUNTRY, CODED
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string COUNTRYCODED_09 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC : I_PAC<C531, C202, C402, C532>
    {
        
        /// <summary>
        /// NUMBER OF PACKAGES
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string NUMBEROFPACKAGES_01 { get; set; }
        /// <summary>
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        /// <summary>
        /// PACKAGE TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// RETURNABLE PACKAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI : I_PAI<C534>
    {
        
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT : I_PAT<C110, C112>
    {
        
        /// <summary>
        /// PAYMENT TERMS TYPE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string PAYMENTTERMSTYPEQUALIFIER_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD : I_PCD<C501>
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI : I_PCI<C210, C827>
    {
        
        /// <summary>
        /// MARKING INSTRUCTIONS, CODED
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string MARKINGINSTRUCTIONSCODED_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// CONTAINER/PACKAGE STATUS, CODED
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string CONTAINERPACKAGESTATUSCODED_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL PRODUCT ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA : I_PIA<C212, C212, C212, C212, C212>
    {
        
        /// <summary>
        /// PRODUCT ID. FUNCTION QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string PRODUCTIDFUNCTIONQUALIFIER_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI : I_PRI<C509>
    {
        
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// SUB-LINE PRICE CHANGE, CODED
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string SUBLINEPRICECHANGECODED_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY : I_QTY<C186>
    {
        
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY VARIANCES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR : I_QVR<C279, C960>
    {
        
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// DISCREPANCY, CODED
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string DISCREPANCYCODED_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF : I_RFF<C506>
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// RANGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG : I_RNG<C280>
    {
        
        /// <summary>
        /// RANGE TYPE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string RANGETYPEQUALIFIER_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTE")]
    public class RTE : I_RTE<C128>
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX : I_TAX<C241, C533, C243>
    {
        
        /// <summary>
        /// DUTY/TAX/FEE FUNCTION QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string DUTYTAXFEEFUNCTIONQUALIFIER_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ASSESSMENT BASIS
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DUTYTAXFEEASSESSMENTBASIS_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE CATEGORY, CODED
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string DUTYTAXFEECATEGORYCODED_06 { get; set; }
        /// <summary>
        /// PARTY TAX IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string PARTYTAXIDENTIFICATIONNUMBER_07 { get; set; }
    }
    
    /// <summary>
    /// DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT : I_TDT<C220, C228, C040, C401, C222>
    {
        
        /// <summary>
        /// TRANSPORT STAGE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string TRANSPORTSTAGEQUALIFIER_01 { get; set; }
        /// <summary>
        /// CONVEYANCE REFERENCE NUMBER
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string CONVEYANCEREFERENCENUMBER_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        /// <summary>
        /// TRANSIT DIRECTION, CODED
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string TRANSITDIRECTIONCODED_06 { get; set; }
        /// <summary>
        /// EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        /// <summary>
        /// TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        /// <summary>
        /// TRANSPORT OWNERSHIP, CODED
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string TRANSPORTOWNERSHIPCODED_09 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD : I_TOD<C100>
    {
        
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT FUNCTION, CODED
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string TERMSOFDELIVERYORTRANSPORTFUNCTIONCODED_01 { get; set; }
        /// <summary>
        /// TRANSPORT CHARGES METHOD OF PAYMENT, CODED
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string TRANSPORTCHARGESMETHODOFPAYMENTCODED_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// SECTION CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UNS")]
    public class UNS : I_UNS
    {
        
        /// <summary>
        /// SECTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string SECTIONIDENTIFICATION_01 { get; set; }
    }
}
