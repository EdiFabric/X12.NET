namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002 : IC002
    {
        
        /// <summary>
        /// Document name code
        /// </summary>
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// CARRIER
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040 : IC040
    {
        
        /// <summary>
        /// Carrier identifier
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// <summary>
    /// DEPARTMENT OR EMPLOYEE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056 : IC056
    {
        
        /// <summary>
        /// Department or employee name code
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeenamecode_01 { get; set; }
        /// <summary>
        /// Department or employee name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployeename_02 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Composite("C058")]
    public class C058 : IC058
    {
        
        /// <summary>
        /// Name and address description
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    /// <summary>
    /// STREET
    /// </summary>
    [Serializable()]
    [Composite("C059")]
    public class C059 : IC059
    {
        
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [Composite("C076")]
    public class C076 : IC076
    {
        
        /// <summary>
        /// Communication address identifier
        /// </summary>
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication address code qualifier
        /// </summary>
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// ACCOUNT HOLDER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C078")]
    public class C078 : IC078
    {
        
        /// <summary>
        /// Account holder identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholderidentifier_01 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string Currencyidentificationcode_04 { get; set; }
    }
    
    /// <summary>
    /// PARTY NAME
    /// </summary>
    [Serializable()]
    [Composite("C080")]
    public class C080 : IC080
    {
        
        /// <summary>
        /// Party name
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format code
        /// </summary>
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C082")]
    public class C082 : IC082
    {
        
        /// <summary>
        /// Party identifier
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C088")]
    public class C088 : IC088
    {
        
        /// <summary>
        /// Institution name code
        /// </summary>
        [DataElement("3433", typeof(EDIFACT_ID_3433))]
        [Pos(1)]
        public string Institutionnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Institution branch identifier
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchidentifier_04 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch location name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchlocationname_08 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [Composite("C100")]
    public class C100 : IC100
    {
        
        /// <summary>
        /// Delivery or transport terms description code
        /// </summary>
        [DataElement("4053", typeof(EDIFACT_ID_4053))]
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Delivery or transport terms description
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        /// <summary>
        /// Delivery or transport terms description
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C106")]
    public class C106 : IC106
    {
        
        /// <summary>
        /// Document identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Revisionidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C107")]
    public class C107 : IC107
    {
        
        /// <summary>
        /// Free text value code
        /// </summary>
        [Required]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// TEXT LITERAL
    /// </summary>
    [Serializable()]
    [Composite("C108")]
    public class C108 : IC108
    {
        
        /// <summary>
        /// Free text value
        /// </summary>
        [Required]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextvalue_01 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetextvalue_02 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetextvalue_03 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetextvalue_04 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetextvalue_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [Composite("C110")]
    public class C110 : IC110
    {
        
        /// <summary>
        /// Payment terms description identifier
        /// </summary>
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C112")]
    public class C112 : IC112
    {
        
        /// <summary>
        /// Time reference code
        /// </summary>
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C128")]
    public class C128 : IC128
    {
        
        /// <summary>
        /// Rate type code qualifier
        /// </summary>
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Unit price basis rate
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Unitpricebasisrate_02 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasisvalue_03 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(4)]
        public string Measurementunitcode_04 { get; set; }
    }
    
    /// <summary>
    /// PRICE MULTIPLIER INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C138")]
    public class C138 : IC138
    {
        
        /// <summary>
        /// Price multiplier rate
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplierrate_01 { get; set; }
        /// <summary>
        /// Price multiplier type code qualifier
        /// </summary>
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [Composite("C174")]
    public class C174 : IC174
    {
        
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C186")]
    public class C186 : IC186
    {
        
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C202")]
    public class C202 : IC202
    {
        
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataElement("7065", typeof(EDIFACT_ID_7065))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    /// <summary>
    /// IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [Composite("C208")]
    public class C208 : IC208
    {
        
        /// <summary>
        /// Object identifier
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// MARKS & LABELS
    /// </summary>
    [Serializable()]
    [Composite("C210")]
    public class C210 : IC210
    {
        
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarksdescription_01 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarksdescription_02 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarksdescription_03 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarksdescription_04 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarksdescription_05 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarksdescription_06 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarksdescription_07 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarksdescription_08 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarksdescription_09 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarksdescription_10 { get; set; }
    }
    
    /// <summary>
    /// ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C212")]
    public class C212 : IC212
    {
        
        /// <summary>
        /// Item identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C214")]
    public class C214 : IC214
    {
        
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [Composite("C220")]
    public class C220 : IC220
    {
        
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [DataElement("8067", typeof(EDIFACT_ID_8067))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C222")]
    public class C222 : IC222
    {
        
        /// <summary>
        /// Transport means identification name identifier
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Transport means identification name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        /// <summary>
        /// Transport means nationality code
        /// </summary>
        [DataElement("8453", typeof(EDIFACT_ID_8453))]
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [Composite("C228")]
    public class C228 : IC228
    {
        
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C241")]
    public class C241 : IC241
    {
        
        /// <summary>
        /// Duty or tax or fee type name code
        /// </summary>
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [Composite("C243")]
    public class C243 : IC243
    {
        
        /// <summary>
        /// Duty or tax or fee rate code
        /// </summary>
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee rate
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        /// <summary>
        /// Duty or tax or fee rate basis code
        /// </summary>
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [Composite("C270")]
    public class C270 : IC270
    {
        
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [Composite("C272")]
    public class C272 : IC272
    {
        
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [Composite("C273")]
    public class C273 : IC273
    {
        
        /// <summary>
        /// Item description code
        /// </summary>
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C279")]
    public class C279 : IC279
    {
        
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C401")]
    public class C401 : IC401
    {
        
        /// <summary>
        /// Excess transportation reason code
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility code
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        /// <summary>
        /// Customer shipment authorisation identifier
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C402")]
    public class C402 : IC402
    {
        
        /// <summary>
        /// Description format code
        /// </summary>
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C501")]
    public class C501 : IC501
    {
        
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C502")]
    public class C502 : IC502
    {
        
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C504")]
    public class C504 : IC504
    {
        
        /// <summary>
        /// Currency usage code qualifier
        /// </summary>
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        /// <summary>
        /// Currency rate value
        /// </summary>
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C506")]
    public class C506 : IC506
    {
        
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [Composite("C507")]
    public class C507 : IC507
    {
        
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C509")]
    public class C509 : IC509
    {
        
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Composite("C516")]
    public class C516 : IC516
    {
        
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C517")]
    public class C517 : IC517
    {
        
        /// <summary>
        /// Location name code
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Location name
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C519")]
    public class C519 : IC519
    {
        
        /// <summary>
        /// First related location name code
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// First related location name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C531")]
    public class C531 : IC531
    {
        
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C532")]
    public class C532 : IC532
    {
        
        /// <summary>
        /// Returnable package freight payment responsibility code
        /// </summary>
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        /// <summary>
        /// Returnable package load contents code
        /// </summary>
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [Composite("C533")]
    public class C533 : IC533
    {
        
        /// <summary>
        /// Duty or tax or fee account code
        /// </summary>
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C534")]
    public class C534 : IC534
    {
        
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C552")]
    public class C552 : IC552
    {
        
        /// <summary>
        /// Allowance or charge identifier
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C553")]
    public class C553 : IC553
    {
        
        /// <summary>
        /// Second related location name code
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Second related location name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    /// <summary>
    /// COUNTRY SUB-ENTITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C819")]
    public class C819 : IC819
    {
        
        /// <summary>
        /// Country sub-entity name code
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country sub-entity name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [Composite("C827")]
    public class C827 : IC827
    {
        
        /// <summary>
        /// Marking type code
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Markingtypecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C829")]
    public class C829 : IC829
    {
        
        /// <summary>
        /// Sub-line indicator code
        /// </summary>
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcode_01 { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [Composite("C960")]
    public class C960 : IC960
    {
        
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
}
