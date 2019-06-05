namespace EdiFabric.Templates.X12004010.PartnerB
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
    /// Advertising Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADV")]
    public class ADV : I_ADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceCharacteristicsQualifier_02 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(3)]
        public string RangeMinimum_03 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(4)]
        public string RangeMaximum_04 { get; set; }
        /// <summary>
        /// Category
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("729", typeof(X12_AN))]
        [Pos(5)]
        public string Category_05 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(6)]
        public string ServiceCharacteristicsQualifier_06 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(7)]
        public string MeasurementValue_07 { get; set; }
    }
    
    /// <summary>
    /// Monetary Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT")]
    public class AMT : I_AMT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Balance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAL")]
    public class BAL : I_BAL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Balance Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("951", typeof(X12_ID_951))]
        [Pos(1)]
        public string BalanceTypeCode_01 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Purchase Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BEG")]
    public class BEG : I_BEG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("92", typeof(X12_ID_92))]
        [Pos(2)]
        public string PurchaseOrderTypeCode_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [Required]
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(6)]
        public string ContractNumber_06 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [DataElement("587", typeof(X12_ID_587))]
        [Pos(7)]
        public string AcknowledgmentType_07 { get; set; }
        /// <summary>
        /// Invoice Type Code
        /// </summary>
        [DataMember]
        [DataElement("1019", typeof(X12_ID_1019))]
        [Pos(8)]
        public string InvoiceTypeCode_08 { get; set; }
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [DataMember]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(9)]
        public string ContractTypeCode_09 { get; set; }
        /// <summary>
        /// Purchase Category
        /// </summary>
        [DataMember]
        [DataElement("1232", typeof(X12_ID_1232))]
        [Pos(10)]
        public string PurchaseCategory_10 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(11)]
        public string SecurityLevelCode_11 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(12)]
        public string TransactionTypeCode_12 { get; set; }
        [Pos(13)]
        public string NewField_13 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BIG")]
    public class BIG : I_BIG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(8)]
        public string TransactionSetPurposeCode_08 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [DataElement("306", typeof(X12_ID_306))]
        [Pos(9)]
        public string ActionCode_09 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(10)]
        public string InvoiceNumber_10 { get; set; }
    }
    
    /// <summary>
    /// Carrier Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAD")]
    public class CAD : I_CAD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(1)]
        public string TransportationMethodTypeCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("387", typeof(X12_AN))]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(7)]
        public string ReferenceIdentificationQualifier_07 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceIdentification_08 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(9)]
        public string ServiceLevelCode_09 { get; set; }
    }
    
    /// <summary>
    /// Contract and Cost Accounting Standards Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CB1")]
    public class CB1 : I_CB1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Acquisition Data Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1309", typeof(X12_ID_1309))]
        [Pos(1)]
        public string AcquisitionDataCode_01 { get; set; }
        /// <summary>
        /// Financing Type Code
        /// </summary>
        [DataMember]
        [DataElement("1310", typeof(X12_ID_1310))]
        [Pos(2)]
        public string FinancingTypeCode_02 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CN1")]
    public class CN1 : I_CN1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string Percent_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercent_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string VersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC")]
    public class CRC : I_CRC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public string YesNoConditionorResponseCode_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    /// <summary>
    /// Sales Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CSH")]
    public class CSH : I_CSH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Requirement Code
        /// </summary>
        [DataMember]
        [DataElement("563", typeof(X12_ID_563))]
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [DataElement("306", typeof(X12_ID_306))]
        [Pos(2)]
        public string ActionCode_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(6)]
        public string AgencyQualifierCode_06 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(7)]
        public string SpecialServicesCode_07 { get; set; }
        /// <summary>
        /// Product/Service Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("566", typeof(X12_ID_566))]
        [Pos(8)]
        public string ProductServiceSubstitutionCode_08 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(9)]
        public string Percent_09 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1004", typeof(X12_ID_1004))]
        [Pos(10)]
        public string PercentQualifier_10 { get; set; }
    }
    
    /// <summary>
    /// Restrictions/Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTB")]
    public class CTB : I_CTB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Restrictions/Conditions Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("688", typeof(X12_ID_688))]
        [Pos(1)]
        public string RestrictionsConditionsQualifier_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(3)]
        public string QuantityQualifier_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(5)]
        public string AmountQualifierCode_05 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(6)]
        public string Amount_06 { get; set; }
    }
    
    /// <summary>
    /// Pricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTP")]
    public class CTP : I_CTP<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [DataMember]
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C001 CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        /// <summary>
        /// Condition Value
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("499", typeof(X12_AN))]
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("289", typeof(X12_N0))]
        [Pos(11)]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    /// <summary>
    /// Transaction Totals
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTT")]
    public class CTT : I_CTT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Line Items
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("354", typeof(X12_N0))]
        [Pos(1)]
        public string NumberofLineItems_01 { get; set; }
        /// <summary>
        /// Hash Total
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("347", typeof(X12_R))]
        [Pos(2)]
        public string HashTotal_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    /// <summary>
    /// Currency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR")]
    public class CUR : I_CUR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [StringLength(4, 10)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Discount Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIS")]
    public class DIS : I_DIS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Discount Terms Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("653", typeof(X12_ID_653))]
        [Pos(1)]
        public string DiscountTermsTypeCode_01 { get; set; }
        /// <summary>
        /// Discount Base Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("654", typeof(X12_ID_654))]
        [Pos(2)]
        public string DiscountBaseQualifier_02 { get; set; }
        /// <summary>
        /// Discount Base Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("655", typeof(X12_R))]
        [Pos(3)]
        public string DiscountBaseValue_03 { get; set; }
        /// <summary>
        /// Discount Control Limit Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("656", typeof(X12_ID_656))]
        [Pos(4)]
        public string DiscountControlLimitQualifier_04 { get; set; }
        /// <summary>
        /// Discount Control Limit
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("657", typeof(X12_N0))]
        [Pos(5)]
        public string DiscountControlLimit_05 { get; set; }
        /// <summary>
        /// Discount Control Limit
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("657", typeof(X12_N0))]
        [Pos(6)]
        public string DiscountControlLimit_06 { get; set; }
    }
    
    /// <summary>
    /// Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG")]
    public class DMG : I_DMG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string DateTimePeriod_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string GenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(5)]
        public string RaceorEthnicityCode_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        public string Quantity_09 { get; set; }
    }
    
    /// <summary>
    /// Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM : I_DTM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FA1")]
    public class FA1 : I_FA1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [DataElement("1300", typeof(X12_ID_1300))]
        [Pos(2)]
        public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
        [DataElement("248", typeof(X12_ID_248))]
        [Pos(3)]
        public string AllowanceorChargeIndicator_03 { get; set; }
    }
    
    /// <summary>
    /// Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FA2")]
    public class FA2 : I_FA2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Breakdown Structure Detail Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1196", typeof(X12_ID_1196))]
        [Pos(1)]
        public string BreakdownStructureDetailCode_01 { get; set; }
        /// <summary>
        /// Financial Information Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("1195", typeof(X12_AN))]
        [Pos(2)]
        public string FinancialInformationCode_02 { get; set; }
    }
    
    /// <summary>
    /// F.O.B. Related Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FOB")]
    public class FOB : I_FOB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Transportation Terms Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("334", typeof(X12_ID_334))]
        [Pos(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        /// <summary>
        /// Transportation Terms Code
        /// </summary>
        [DataMember]
        [DataElement("335", typeof(X12_ID_335))]
        [Pos(5)]
        public string TransportationTermsCode_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Risk of Loss Code
        /// </summary>
        [DataMember]
        [DataElement("54", typeof(X12_ID_54))]
        [Pos(8)]
        public string RiskofLossCode_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string Description_09 { get; set; }
    }
    
    /// <summary>
    /// Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G61")]
    public class G61 : I_G61
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(5)]
        public string ContactInquiryReference_05 { get; set; }
    }
    
    /// <summary>
    /// Installment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INC")]
    public class INC : I_INC<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Terms Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("336", typeof(X12_ID_336))]
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C001 CompositeUnitofMeasure_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
    }
    
    /// <summary>
    /// Invoice Shipment Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ISS")]
    public class ISS : I_ISS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        public string Weight_08 { get; set; }
    }
    
    /// <summary>
    /// Baseline Item Data (Invoice)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT1")]
    public class IT1 : I_IT1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Invoiced
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("358", typeof(X12_R))]
        [Pos(2)]
        public string QuantityInvoiced_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }
    
    /// <summary>
    /// Additional Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT3")]
    public class IT3 : I_IT3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(3)]
        public string ShipmentOrderStatusCode_03 { get; set; }
        /// <summary>
        /// Quantity Difference
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("383", typeof(X12_R))]
        [Pos(4)]
        public string QuantityDifference_04 { get; set; }
        /// <summary>
        /// Change Reason Code
        /// </summary>
        [DataMember]
        [DataElement("371", typeof(X12_ID_371))]
        [Pos(5)]
        public string ChangeReasonCode_05 { get; set; }
    }
    
    /// <summary>
    /// Conditions of Sale
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT8")]
    public class IT8 : I_IT8
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Requirement Code
        /// </summary>
        [DataMember]
        [DataElement("563", typeof(X12_ID_563))]
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [DataElement("306", typeof(X12_ID_306))]
        [Pos(2)]
        public string ActionCode_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(6)]
        public string AgencyQualifierCode_06 { get; set; }
        /// <summary>
        /// Product/Service Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("566", typeof(X12_ID_566))]
        [Pos(7)]
        public string ProductServiceSubstitutionCode_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
    }
    
    /// <summary>
    /// Terms of Sale/Deferred Terms of Sale
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITD")]
    public class ITD : I_ITD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Terms Type Code
        /// </summary>
        [DataMember]
        [DataElement("336", typeof(X12_ID_336))]
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        /// <summary>
        /// Terms Basis Date Code
        /// </summary>
        [DataMember]
        [DataElement("333", typeof(X12_ID_333))]
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(3)]
        public string TermsDiscountPercent_03 { get; set; }
        /// <summary>
        /// Terms Discount Due Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("370", typeof(X12_DT))]
        [Pos(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        /// <summary>
        /// Terms Discount Days Due
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("351", typeof(X12_N0))]
        [Pos(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        /// <summary>
        /// Terms Net Due Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("446", typeof(X12_DT))]
        [Pos(6)]
        public string TermsNetDueDate_06 { get; set; }
        /// <summary>
        /// Terms Net Days
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("386", typeof(X12_N0))]
        [Pos(7)]
        public string TermsNetDays_07 { get; set; }
        /// <summary>
        /// Terms Discount Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("362", typeof(X12_N2))]
        [Pos(8)]
        public string TermsDiscountAmount_08 { get; set; }
        /// <summary>
        /// Terms Deferred Due Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("388", typeof(X12_DT))]
        [Pos(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        /// <summary>
        /// Deferred Amount Due
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("389", typeof(X12_N2))]
        [Pos(10)]
        public string DeferredAmountDue_10 { get; set; }
        /// <summary>
        /// Percent of Invoice Payable
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("342", typeof(X12_R))]
        [Pos(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(12)]
        public string Description_12 { get; set; }
        /// <summary>
        /// Day of Month
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("765", typeof(X12_N0))]
        [Pos(13)]
        public string DayofMonth_13 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [DataElement("107", typeof(X12_ID_107))]
        [Pos(14)]
        public string PaymentMethodCode_14 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(15)]
        public string Percent_15 { get; set; }
    }
    
    /// <summary>
    /// Tariff Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L7")]
    public class L7 : I_L7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Tariff Agency Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("168", typeof(X12_AN))]
        [Pos(2)]
        public string TariffAgencyCode_02 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("171", typeof(X12_AN))]
        [Pos(3)]
        public string TariffNumber_03 { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("172", typeof(X12_AN))]
        [Pos(4)]
        public string TariffSection_04 { get; set; }
        /// <summary>
        /// Tariff Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 16)]
        [DataElement("169", typeof(X12_AN))]
        [Pos(5)]
        public string TariffItemNumber_05 { get; set; }
        /// <summary>
        /// Tariff Item Part
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("170", typeof(X12_N0))]
        [Pos(6)]
        public string TariffItemPart_06 { get; set; }
        /// <summary>
        /// Freight Class Code
        /// </summary>
        [DataMember]
        [StringLength(2, 5)]
        [DataElement("59", typeof(X12_AN))]
        [Pos(7)]
        public string FreightClassCode_07 { get; set; }
        /// <summary>
        /// Tariff Supplement Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("173", typeof(X12_AN))]
        [Pos(8)]
        public string TariffSupplementIdentifier_08 { get; set; }
        /// <summary>
        /// Ex Parte
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("46", typeof(X12_AN))]
        [Pos(9)]
        public string ExParte_09 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(10)]
        public string Date_10 { get; set; }
        /// <summary>
        /// Rate Basis Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("119", typeof(X12_AN))]
        [Pos(11)]
        public string RateBasisNumber_11 { get; set; }
        /// <summary>
        /// Tariff Column
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("227", typeof(X12_AN))]
        [Pos(12)]
        public string TariffColumn_12 { get; set; }
        /// <summary>
        /// Tariff Distance
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("294", typeof(X12_N0))]
        [Pos(13)]
        public string TariffDistance_13 { get; set; }
        /// <summary>
        /// Distance Qualifier
        /// </summary>
        [DataMember]
        [DataElement("295", typeof(X12_ID_295))]
        [Pos(14)]
        public string DistanceQualifier_14 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(15)]
        public string CityName_15 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(16)]
        public string StateorProvinceCode_16 { get; set; }
    }
    
    /// <summary>
    /// Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LDT")]
    public class LDT : I_LDT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lead Time Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("345", typeof(X12_ID_345))]
        [Pos(1)]
        public string LeadTimeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Time Period or Interval
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(3)]
        public string UnitofTimePeriodorInterval_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
    }
    
    /// <summary>
    /// Loop Trailer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LE")]
    public class LE : I_LE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN : I_LIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(2)]
        public string ProductServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }
    
    /// <summary>
    /// Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LM")]
    public class LM : I_LM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("822", typeof(X12_AN))]
        [Pos(2)]
        public string SourceSubqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// Industry Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LQ")]
    public class LQ : I_LQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
    }
    
    /// <summary>
    /// Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LS")]
    public class LS : I_LS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MAN")]
    public class MAN : I_MAN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("88", typeof(X12_ID_88))]
        [Pos(1)]
        public string MarksandNumbersQualifier_01 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(2)]
        public string MarksandNumbers_02 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(3)]
        public string MarksandNumbers_03 { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [DataElement("88", typeof(X12_ID_88))]
        [Pos(4)]
        public string MarksandNumbersQualifier_04 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(5)]
        public string MarksandNumbers_05 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(6)]
        public string MarksandNumbers_06 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA : I_MEA<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [DataMember]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIDCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string MeasurementValue_03 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C001 CompositeUnitofMeasure_04 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [DataMember]
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(X12_ID_1373))]
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
    }
    
    /// <summary>
    /// Message Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG : I_MSG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(1)]
        public string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [DataElement("934", typeof(X12_ID_934))]
        [Pos(2)]
        public string PrinterCarriageControlCode_02 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1470", typeof(X12_N0))]
        [Pos(3)]
        public string Number_03 { get; set; }
    }
    
    /// <summary>
    /// Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MTX")]
    public class MTX : I_MTX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1551", typeof(X12_AN))]
        [Pos(2)]
        public string MessageText_02 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1551", typeof(X12_AN))]
        [Pos(3)]
        public string MessageText_03 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [DataElement("934", typeof(X12_ID_934))]
        [Pos(4)]
        public string PrinterCarriageControlCode_04 { get; set; }
    }
    
    /// <summary>
    /// Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1")]
    public class N1 : I_N1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Additional Name Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N2")]
    public class N2 : I_N2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(1)]
        public string Name_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    /// <summary>
    /// Address Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N3")]
    public class N3 : I_N3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
    }
    
    /// <summary>
    /// Geographic Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4 : I_N4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N9")]
    public class N9 : I_N9<C040>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("369", typeof(X12_AN))]
        [Pos(3)]
        public string FreeformDescription_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(6)]
        public string TimeCode_06 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C040 ReferenceIdentifier_07 { get; set; }
    }
    
    /// <summary>
    /// Note/Special Instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE")]
    public class NTE : I_NTE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
    }
    
    /// <summary>
    /// Location ID Component
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NX2")]
    public class NX2 : I_NX2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address Component Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1106", typeof(X12_ID_1106))]
        [Pos(1)]
        public string AddressComponentQualifier_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
        /// <summary>
        /// County Designator
        /// </summary>
        [DataMember]
        [StringLength(5, 5)]
        [DataElement("1096", typeof(X12_AN))]
        [Pos(3)]
        public string CountyDesignator_03 { get; set; }
    }
    
    /// <summary>
    /// Period Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAM")]
    public class PAM : I_PAM<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001 CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(4)]
        public string AmountQualifierCode_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Unit of Time Period or Interval
        /// </summary>
        [DataMember]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(6)]
        public string UnitofTimePeriodorInterval_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1004", typeof(X12_ID_1004))]
        [Pos(13)]
        public string PercentQualifier_13 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(14)]
        public string Percent_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    /// <summary>
    /// Percent Amounts
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCT")]
    public class PCT : I_PCT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1004", typeof(X12_ID_1004))]
        [Pos(1)]
        public string PercentQualifier_01 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(2)]
        public string Percent_02 { get; set; }
    }
    
    /// <summary>
    /// Administrative Communications Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER")]
    public class PER : I_PER
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PID")]
    public class PID : I_PID
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Description Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_AN))]
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("822", typeof(X12_AN))]
        [Pos(7)]
        public string SourceSubqualifier_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(8)]
        public string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("819", typeof(X12_AN))]
        [Pos(9)]
        public string LanguageCode_09 { get; set; }
    }
    
    /// <summary>
    /// Marking, Packaging, Loading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PKG")]
    public class PKG : I_PKG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Description Type
        /// </summary>
        [DataMember]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Packaging Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("753", typeof(X12_ID_753))]
        [Pos(2)]
        public string PackagingCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Packaging Description Code
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("754", typeof(X12_AN))]
        [Pos(4)]
        public string PackagingDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Unit Load Option Code
        /// </summary>
        [DataMember]
        [DataElement("400", typeof(X12_ID_400))]
        [Pos(6)]
        public string UnitLoadOptionCode_06 { get; set; }
    }
    
    /// <summary>
    /// Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO1")]
    public class PO1 : I_PO1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("330", typeof(X12_R))]
        [Pos(2)]
        public string QuantityOrdered_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }
    
    /// <summary>
    /// Additional Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO3")]
    public class PO3 : I_PO3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("371", typeof(X12_ID_371))]
        [Pos(1)]
        public string ChangeReasonCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(3)]
        public string PriceIdentifierCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(8)]
        public string Description_08 { get; set; }
    }
    
    /// <summary>
    /// Item Physical Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO4")]
    public class PO4 : I_PO4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("356", typeof(X12_N0))]
        [Pos(1)]
        public string Pack_01 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("357", typeof(X12_R))]
        [Pos(2)]
        public string Size_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(4)]
        public string PackagingCode_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Gross Weight per Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("384", typeof(X12_R))]
        [Pos(6)]
        public string GrossWeightperPack_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Gross Volume per Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("385", typeof(X12_R))]
        [Pos(8)]
        public string GrossVolumeperPack_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("82", typeof(X12_R))]
        [Pos(10)]
        public string Length_10 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("189", typeof(X12_R))]
        [Pos(11)]
        public string Width_11 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("65", typeof(X12_R))]
        [Pos(12)]
        public string Height_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Inner Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("810", typeof(X12_N0))]
        [Pos(14)]
        public string InnerPack_14 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(15)]
        public string SurfaceLayerPositionCode_15 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(16)]
        public string AssignedIdentification_16 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(17)]
        public string AssignedIdentification_17 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1470", typeof(X12_N0))]
        [Pos(18)]
        public string Number_18 { get; set; }
    }
    
    /// <summary>
    /// Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK")]
    public class PWK : I_PWK<C002>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string ReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY : I_QTY<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001 CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeFormMessage_04 { get; set; }
    }
    
    /// <summary>
    /// Port or Terminal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R4")]
    public class R4 : I_R4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port or Terminal Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("115", typeof(X12_ID_115))]
        [Pos(1)]
        public string PortorTerminalFunctionCode_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Port Name
        /// </summary>
        [DataMember]
        [StringLength(2, 24)]
        [DataElement("114", typeof(X12_AN))]
        [Pos(4)]
        public string PortName_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
        /// <summary>
        /// Terminal Name
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("174", typeof(X12_AN))]
        [Pos(6)]
        public string TerminalName_06 { get; set; }
        /// <summary>
        /// Pier Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("113", typeof(X12_AN))]
        [Pos(7)]
        public string PierNumber_07 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(8)]
        public string StateorProvinceCode_08 { get; set; }
    }
    
    /// <summary>
    /// Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF")]
    public class REF : I_REF<C040>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SAC")]
    public class SAC : I_SAC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("248", typeof(X12_ID_248))]
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [DataElement("1300", typeof(X12_ID_1300))]
        [Pos(2)]
        public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Agency Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("1301", typeof(X12_AN))]
        [Pos(4)]
        public string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(5)]
        public string Amount_05 { get; set; }
        /// <summary>
        /// Allowance/Charge Percent Qualifier
        /// </summary>
        [DataMember]
        [DataElement("378", typeof(X12_ID_378))]
        [Pos(6)]
        public string AllowanceChargePercentQualifier_06 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(7)]
        public string Percent_07 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(8)]
        public string Rate_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(11)]
        public string Quantity_11 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [DataMember]
        [DataElement("331", typeof(X12_ID_331))]
        [Pos(12)]
        public string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(13)]
        public string ReferenceIdentification_13 { get; set; }
        /// <summary>
        /// Option Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("770", typeof(X12_AN))]
        [Pos(14)]
        public string OptionNumber_14 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(15)]
        public string Description_15 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("819", typeof(X12_AN))]
        [Pos(16)]
        public string LanguageCode_16 { get; set; }
    }
    
    /// <summary>
    /// Line Item Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCH")]
    public class SCH : I_SCH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string Name_04 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(5)]
        public string DateTimeQualifier_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(8)]
        public string DateTimeQualifier_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(10)]
        public string Time_10 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("326", typeof(X12_AN))]
        [Pos(11)]
        public string RequestReferenceNumber_11 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(12)]
        public string AssignedIdentification_12 { get; set; }
    }
    
    /// <summary>
    /// Destination Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDQ")]
    public class SDQ : I_SDQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(5)]
        public string IdentificationCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(7)]
        public string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(8)]
        public string Quantity_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(11)]
        public string IdentificationCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(13)]
        public string IdentificationCode_13 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(14)]
        public string Quantity_14 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(15)]
        public string IdentificationCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string Quantity_16 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(17)]
        public string IdentificationCode_17 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(18)]
        public string Quantity_18 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(19)]
        public string IdentificationCode_19 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(20)]
        public string Quantity_20 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(21)]
        public string IdentificationCode_21 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(22)]
        public string Quantity_22 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(23)]
        public string LocationIdentifier_23 { get; set; }
    }
    
    /// <summary>
    /// Service Characteristic Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SI")]
    public class SI : I_SI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceCharacteristicsQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(4)]
        public string ServiceCharacteristicsQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(6)]
        public string ServiceCharacteristicsQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(8)]
        public string ServiceCharacteristicsQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(10)]
        public string ServiceCharacteristicsQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(12)]
        public string ServiceCharacteristicsQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(14)]
        public string ServiceCharacteristicsQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(16)]
        public string ServiceCharacteristicsQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(18)]
        public string ServiceCharacteristicsQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1000", typeof(X12_AN))]
        [Pos(20)]
        public string ServiceCharacteristicsQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
    }
    
    /// <summary>
    /// Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SLN")]
    public class SLN : I_SLN<C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(2)]
        public string AssignedIdentification_02 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("662", typeof(X12_ID_662))]
        [Pos(3)]
        public string RelationshipCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C001 CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [DataElement("662", typeof(X12_ID_662))]
        [Pos(8)]
        public string RelationshipCode_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(28)]
        public string ProductServiceID_28 { get; set; }
    }
    
    /// <summary>
    /// Specification Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPI")]
    public class SPI : I_SPI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(1)]
        public string SecurityLevelCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// Entity Title
        /// </summary>
        [DataMember]
        [StringLength(1, 132)]
        [DataElement("790", typeof(X12_AN))]
        [Pos(4)]
        public string EntityTitle_04 { get; set; }
        /// <summary>
        /// Entity Purpose
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("791", typeof(X12_AN))]
        [Pos(5)]
        public string EntityPurpose_05 { get; set; }
        /// <summary>
        /// Entity Status Code
        /// </summary>
        [DataMember]
        [DataElement("792", typeof(X12_ID_792))]
        [Pos(6)]
        public string EntityStatusCode_06 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(7)]
        public string TransactionSetPurposeCode_07 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(8)]
        public string ReportTypeCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(10)]
        public string AgencyQualifierCode_10 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("822", typeof(X12_AN))]
        [Pos(11)]
        public string SourceSubqualifier_11 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(12)]
        public string AssignedNumber_12 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [DataElement("1322", typeof(X12_ID_1322))]
        [Pos(13)]
        public string CertificationTypeCode_13 { get; set; }
        /// <summary>
        /// Proposal Data Detail Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("1401", typeof(X12_ID_1401))]
        [Pos(14)]
        public string ProposalDataDetailIdentifierCode_14 { get; set; }
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [DataElement("1005", typeof(X12_ID_1005))]
        [Pos(15)]
        public string HierarchicalStructureCode_15 { get; set; }
    }
    
    /// <summary>
    /// Requested Service Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SR")]
    public class SR : I_SR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Day Rotation
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("1430", typeof(X12_AN))]
        [Pos(2)]
        public string DayRotation_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("3", typeof(X12_AN))]
        [Pos(5)]
        public string FreeFormMessage_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
    }
    
    /// <summary>
    /// Tax Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX : I_TAX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("325", typeof(X12_AN))]
        [Pos(1)]
        public string TaxIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(4)]
        public string LocationQualifier_04 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(5)]
        public string LocationIdentifier_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(7)]
        public string LocationIdentifier_07 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(8)]
        public string LocationQualifier_08 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(9)]
        public string LocationIdentifier_09 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(10)]
        public string LocationQualifier_10 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(11)]
        public string LocationIdentifier_11 { get; set; }
        /// <summary>
        /// Tax Exempt Code
        /// </summary>
        [DataMember]
        [DataElement("441", typeof(X12_ID_441))]
        [Pos(12)]
        public string TaxExemptCode_12 { get; set; }
        /// <summary>
        /// Customs Entry Type Group Code
        /// </summary>
        [DataMember]
        [DataElement("1179", typeof(X12_ID_1179))]
        [Pos(13)]
        public string CustomsEntryTypeGroupCode_13 { get; set; }
    }
    
    /// <summary>
    /// Commodity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TC2")]
    public class TC2 : I_TC2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("23", typeof(X12_ID_23))]
        [Pos(1)]
        public string CommodityCodeQualifier_01 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(2)]
        public string CommodityCode_02 { get; set; }
    }
    
    /// <summary>
    /// Carrier Details (Quantity and Weight)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD1")]
    public class TD1 : I_TD1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(1)]
        public string PackagingCode_01 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(2)]
        public string LadingQuantity_02 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("23", typeof(X12_ID_23))]
        [Pos(3)]
        public string CommodityCodeQualifier_03 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(4)]
        public string CommodityCode_04 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("79", typeof(X12_AN))]
        [Pos(5)]
        public string LadingDescription_05 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(6)]
        public string WeightQualifier_06 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(7)]
        public string Weight_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(9)]
        public string Volume_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
    }
    
    /// <summary>
    /// Carrier Details (Equipment)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD3")]
    public class TD3 : I_TD3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [DataElement("40", typeof(X12_ID_40))]
        [Pos(1)]
        public string EquipmentDescriptionCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(5)]
        public string Weight_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Ownership Code
        /// </summary>
        [DataMember]
        [DataElement("102", typeof(X12_ID_102))]
        [Pos(7)]
        public string OwnershipCode_07 { get; set; }
        /// <summary>
        /// Seal Status Code
        /// </summary>
        [DataMember]
        [DataElement("407", typeof(X12_ID_407))]
        [Pos(8)]
        public string SealStatusCode_08 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [StringLength(2, 15)]
        [DataElement("225", typeof(X12_AN))]
        [Pos(9)]
        public string SealNumber_09 { get; set; }
        /// <summary>
        /// Equipment Type
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("24", typeof(X12_AN))]
        [Pos(10)]
        public string EquipmentType_10 { get; set; }
    }
    
    /// <summary>
    /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD4")]
    public class TD4 : I_TD4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [DataElement("152", typeof(X12_ID_152))]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Hazardous Material Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("208", typeof(X12_ID_208))]
        [Pos(2)]
        public string HazardousMaterialCodeQualifier_02 { get; set; }
        /// <summary>
        /// Hazardous Material Class Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("209", typeof(X12_AN))]
        [Pos(3)]
        public string HazardousMaterialClassCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(4)]
        public string Description_04 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(5)]
        public string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    /// <summary>
    /// Carrier Details (Routing Sequence/Transit Time)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD5")]
    public class TD5 : I_TD5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [DataElement("133", typeof(X12_ID_133))]
        [Pos(1)]
        public string RoutingSequenceCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("387", typeof(X12_AN))]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(7)]
        public string LocationQualifier_07 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
        /// <summary>
        /// Transit Direction Code
        /// </summary>
        [DataMember]
        [DataElement("731", typeof(X12_ID_731))]
        [Pos(9)]
        public string TransitDirectionCode_09 { get; set; }
        /// <summary>
        /// Transit Time Direction Qualifier
        /// </summary>
        [DataMember]
        [DataElement("732", typeof(X12_ID_732))]
        [Pos(10)]
        public string TransitTimeDirectionQualifier_10 { get; set; }
        /// <summary>
        /// Transit Time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("733", typeof(X12_R))]
        [Pos(11)]
        public string TransitTime_11 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(12)]
        public string ServiceLevelCode_12 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(13)]
        public string ServiceLevelCode_13 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(14)]
        public string ServiceLevelCode_14 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(15)]
        public string CountryCode_15 { get; set; }
    }
    
    /// <summary>
    /// Total Monetary Value Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDS")]
    public class TDS : I_TDS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(1)]
        public string Amount_01 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(2)]
        public string Amount_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(4)]
        public string Amount_04 { get; set; }
    }
    
    /// <summary>
    /// Tax Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TXI")]
    public class TXI : I_TXI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("963", typeof(X12_ID_963))]
        [Pos(1)]
        public string TaxTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(3)]
        public string Percent_03 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("955", typeof(X12_ID_955))]
        [Pos(4)]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("956", typeof(X12_AN))]
        [Pos(5)]
        public string TaxJurisdictionCode_05 { get; set; }
        /// <summary>
        /// Tax Exempt Code
        /// </summary>
        [DataMember]
        [DataElement("441", typeof(X12_ID_441))]
        [Pos(6)]
        public string TaxExemptCode_06 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [DataElement("662", typeof(X12_ID_662))]
        [Pos(7)]
        public string RelationshipCode_07 { get; set; }
        /// <summary>
        /// Dollar Basis For Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("828", typeof(X12_R))]
        [Pos(8)]
        public string DollarBasisForPercent_08 { get; set; }
        /// <summary>
        /// Tax Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("325", typeof(X12_AN))]
        [Pos(9)]
        public string TaxIdentificationNumber_09 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(10)]
        public string AssignedIdentification_10 { get; set; }
    }
    
    /// <summary>
    /// Vessel Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("V1")]
    public class V1 : I_V1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vessel Code
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("597", typeof(X12_AN))]
        [Pos(1)]
        public string VesselCode_01 { get; set; }
        /// <summary>
        /// Vessel Name
        /// </summary>
        [DataMember]
        [StringLength(2, 28)]
        [DataElement("182", typeof(X12_AN))]
        [Pos(2)]
        public string VesselName_02 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(3)]
        public string CountryCode_03 { get; set; }
        /// <summary>
        /// Flight/Voyage Number
        /// </summary>
        [DataMember]
        [StringLength(2, 10)]
        [DataElement("55", typeof(X12_AN))]
        [Pos(4)]
        public string FlightVoyageNumber_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Vessel Requirement Code
        /// </summary>
        [DataMember]
        [DataElement("249", typeof(X12_ID_249))]
        [Pos(6)]
        public string VesselRequirementCode_06 { get; set; }
        /// <summary>
        /// Vessel Type Code
        /// </summary>
        [DataMember]
        [DataElement("854", typeof(X12_ID_854))]
        [Pos(7)]
        public string VesselTypeCode_07 { get; set; }
        /// <summary>
        /// Vessel Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("897", typeof(X12_ID_897))]
        [Pos(8)]
        public string VesselCodeQualifier_08 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(9)]
        public string TransportationMethodTypeCode_09 { get; set; }
    }
    
    /// <summary>
    /// Yes/No Question
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("YNQ")]
    public class YNQ : I_YNQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(1)]
        public string ConditionIndicator_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public string YesNoConditionorResponseCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(5)]
        public string FreeFormMessageText_05 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(6)]
        public string FreeFormMessageText_06 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(7)]
        public string FreeFormMessageText_07 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(8)]
        public string CodeListQualifierCode_08 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(9)]
        public string IndustryCode_09 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(10)]
        public string FreeFormMessageText_10 { get; set; }
    }
}
