namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [Segment("ALC")]
    public class ALC : IALC<C552, C214>
    {
        
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Additional information
    /// </summary>
    [Serializable()]
    [Segment("ALI")]
    public class ALI : IALI
    {
        
        /// <summary>
        /// Country of origin name code
        /// </summary>
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        /// <summary>
        /// Duty regime type code
        /// </summary>
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional price information
    /// </summary>
    [Serializable()]
    [Segment("APR")]
    public class APR : IAPR<C138, C960>
    {
        
        /// <summary>
        /// Trade class code
        /// </summary>
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
        /// <summary>
        /// PRICE MULTIPLIER INFORMATION
        /// </summary>
        [Pos(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [Segment("BGM")]
    public class BGM : IBGM<C002, C106>
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [Segment("CNT")]
    public class CNT : ICNT<C270>
    {
        
        /// <summary>
        /// CONTROL
        /// </summary>
        [Required]
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
    /// </summary>
    [Serializable()]
    [Segment("COM")]
    public class COM : ICOM<C076>
    {
        
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [Required]
        [Pos(1)]
        public C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [Segment("CTA")]
    public class CTA : ICTA<C056>
    {
        
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Currencies
    /// </summary>
    [Serializable()]
    [Segment("CUX")]
    public class CUX : ICUX<C504, C504>
    {
        
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// Currency exchange rate
        /// </summary>
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [Segment("DTM")]
    public class DTM : IDTM<C507>
    {
        
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Required]
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [Segment("FII")]
    public class FII : IFII<C078, C088>
    {
        
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [Segment("FTX")]
    public class FTX : IFTX<C107, C108>
    {
        
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        /// <summary>
        /// TEXT REFERENCE
        /// </summary>
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        /// <summary>
        /// TEXT LITERAL
        /// </summary>
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [Segment("GIN")]
    public class GIN : IGIN<C208, C208, C208, C208, C208>
    {
        
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Required]
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [Segment("IMD")]
    public class IMD : IIMD<C272, C273>
    {
        
        /// <summary>
        /// Description format code
        /// </summary>
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [Pos(2)]
        public C272 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Line item
    /// </summary>
    [Serializable()]
    [Segment("LIN")]
    public class LIN : ILIN<C212, C829>
    {
        
        /// <summary>
        /// Line item identifier
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// SUB-LINE INFORMATION
        /// </summary>
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        /// <summary>
        /// Configuration level number
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [Segment("LOC")]
    public class LOC : ILOC<C517, C519, C553>
    {
        
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// LOCATION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// Relation code
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [Segment("MEA")]
    public class MEA : IMEA<C502, C174>
    {
        
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [Segment("MOA")]
    public class MOA : IMOA<C516>
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Required]
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [Segment("NAD")]
    public class NAD : INAD<C082, C058, C080, C059, C819>
    {
        
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }
        /// <summary>
        /// STREET
        /// </summary>
        [Pos(5)]
        public C059 STREET_05 { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [Pos(7)]
        public C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [Segment("PAC")]
    public class PAC : IPAC<C531, C202, C402, C532>
    {
        
        /// <summary>
        /// Package quantity
        /// </summary>
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        /// <summary>
        /// PACKAGING DETAILS
        /// </summary>
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        /// <summary>
        /// PACKAGE TYPE IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// RETURNABLE PACKAGE DETAILS
        /// </summary>
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [Segment("PAI")]
    public class PAI : IPAI<C534>
    {
        
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [Segment("PAT")]
    public class PAT : IPAT<C110, C112>
    {
        
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [Segment("PCD")]
    public class PCD : IPCD<C501>
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [Segment("PCI")]
    public class PCI : IPCI<C210, C827>
    {
        
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Additional product id
    /// </summary>
    [Serializable()]
    [Segment("PIA")]
    public class PIA : IPIA<C212, C212, C212, C212, C212>
    {
        
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Required]
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [Segment("PRI")]
    public class PRI : IPRI<C509>
    {
        
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY")]
    public class QTY : IQTY<C186>
    {
        
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [Segment("QVR")]
    public class QVR : IQVR<C279, C960>
    {
        
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [Segment("RFF")]
    public class RFF : IRFF<C506>
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Required]
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Rate details
    /// </summary>
    [Serializable()]
    [Segment("RTE")]
    public class RTE : IRTE<C128>
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [Segment("TAX")]
    public class TAX : ITAX<C241, C533, C243>
    {
        
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [Segment("TDT")]
    public class TDT : ITDT<C220, C228, C040, C401, C222>
    {
        
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
        /// <summary>
        /// EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        /// <summary>
        /// TRANSPORT IDENTIFICATION
        /// </summary>
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        /// <summary>
        /// Transport means ownership indicator code
        /// </summary>
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [Segment("TOD")]
    public class TOD : ITOD<C100>
    {
        
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Section control
    /// </summary>
    [Serializable()]
    [Segment("UNS")]
    public class UNS : IUNS
    {
        
        /// <summary>
        /// Section identification
        /// </summary>
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
