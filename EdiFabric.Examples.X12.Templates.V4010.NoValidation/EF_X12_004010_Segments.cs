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
    /// Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA")]
    public class AAA : I_AAA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string YesNoConditionorResponseCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Line Item Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACK")]
    public class ACK : I_ACK
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Status Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LineItemStatusCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string DateTimeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string RequestReferenceNumber_06 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceIDQualifier_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(27)]
        public string AgencyQualifierCode_27 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [Pos(28)]
        public string SourceSubqualifier_28 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(29)]
        public string IndustryCode_29 { get; set; }
    }
    
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
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ServiceCharacteristicsQualifier_02 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RangeMinimum_03 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string RangeMaximum_04 { get; set; }
        /// <summary>
        /// Category
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Category_05 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ServiceCharacteristicsQualifier_06 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Bill of Lading Handling Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AT5")]
    public class AT5 : I_AT5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SpecialServicesCode_02 { get; set; }
        /// <summary>
        /// Special Handling Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SpecialHandlingDescription_03 { get; set; }
    }
    
    /// <summary>
    /// Shipment Status Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AT7")]
    public class AT7 : I_AT7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Status Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ShipmentStatusCode_01 { get; set; }
        /// <summary>
        /// Shipment Status or Appointment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ShipmentStatusorAppointmentReasonCode_02 { get; set; }
        /// <summary>
        /// Shipment Appointment Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ShipmentAppointmentStatusCode_03 { get; set; }
        /// <summary>
        /// Shipment Status or Appointment Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ShipmentStatusorAppointmentReasonCode_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Time_06 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string TimeCode_07 { get; set; }
    }
    
    /// <summary>
    /// Shipment Weight, Packaging and Quantity Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AT8")]
    public class AT8 : I_AT8
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string WeightQualifier_01 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string WeightUnitCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string LadingQuantity_04 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string LadingQuantity_05 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string VolumeUnitQualifier_06 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Volume_07 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Transportation Carrier Shipment Status Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("B10")]
    public class B10 : I_B10
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentification_01 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ShipmentIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string StandardCarrierAlphaCode_03 { get; set; }
        /// <summary>
        /// Inquiry Request Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string InquiryRequestNumber_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Carrier's Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("B3")]
    public class B3 : I_B3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ShipmentQualifier_01 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ShipmentIdentificationNumber_03 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ShipmentMethodofPayment_04 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string WeightUnitCode_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Net Amount Due
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string NetAmountDue_07 { get; set; }
        /// <summary>
        /// Correction Indicator
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CorrectionIndicator_08 { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string DeliveryDate_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string StandardCarrierAlphaCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Date_12 { get; set; }
        /// <summary>
        /// Tariff Service Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TariffServiceCode_13 { get; set; }
        /// <summary>
        /// Transportation Terms Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string TransportationTermsCode_14 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Purchase Order Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAK")]
    public class BAK : I_BAK
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AcknowledgmentType_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string RequestReferenceNumber_06 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ContractNumber_07 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReferenceIdentification_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TransactionTypeCode_10 { get; set; }
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
        [Pos(1)]
        public string BalanceTypeCode_01 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Price/Sales Catalog
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCT")]
    public class BCT : I_BCT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Catalog Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CatalogPurposeCode_01 { get; set; }
        /// <summary>
        /// Catalog Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CatalogNumber_02 { get; set; }
        /// <summary>
        /// Catalog Version Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CatalogVersionNumber_03 { get; set; }
        /// <summary>
        /// Catalog Revision Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CatalogRevisionNumber_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Catalog Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CatalogNumber_06 { get; set; }
        /// <summary>
        /// Catalog Version Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CatalogVersionNumber_07 { get; set; }
        /// <summary>
        /// Catalog Revision Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CatalogRevisionNumber_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Description_09 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TransactionSetPurposeCode_10 { get; set; }
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
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PurchaseOrderTypeCode_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ContractNumber_06 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string AcknowledgmentType_07 { get; set; }
        /// <summary>
        /// Invoice Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string InvoiceTypeCode_08 { get; set; }
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ContractTypeCode_09 { get; set; }
        /// <summary>
        /// Purchase Category
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string PurchaseCategory_10 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string SecurityLevelCode_11 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TransactionTypeCode_12 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGN")]
    public class BGN : I_BGN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TimeCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ActionCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT")]
    public class BHT : I_BHT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
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
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TransactionSetPurposeCode_08 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ActionCode_09 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string InvoiceNumber_10 { get; set; }
    }
    
    /// <summary>
    /// Binary Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BIN")]
    public class BIN : I_BIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Length of Binary Data
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LengthofBinaryData_01 { get; set; }
        /// <summary>
        /// Binary Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string BinaryData_02 { get; set; }
    }
    
    /// <summary>
    /// Billing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BL")]
    public class BL : I_BL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rebill Reason Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string RebillReasonCode_01 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreightStationAccountingCode_02 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string FreightStationAccountingCode_03 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardPointLocationCode_04 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CityName_05 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string StateorProvinceCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string StandardPointLocationCode_08 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CityName_09 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string StateorProvinceCode_10 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string CountryCode_11 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string StandardCarrierAlphaCode_12 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string StandardCarrierAlphaCode_13 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string StandardCarrierAlphaCode_14 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string StandardCarrierAlphaCode_15 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string StandardCarrierAlphaCode_16 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string StandardCarrierAlphaCode_17 { get; set; }
    }
    
    /// <summary>
    /// Rail Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BNX")]
    public class BNX : I_BNX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Weight Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ShipmentWeightCode_01 { get; set; }
        /// <summary>
        /// Referenced Pattern Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferencedPatternIdentifier_02 { get; set; }
        /// <summary>
        /// Billing Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string BillingCode_03 { get; set; }
        /// <summary>
        /// Repetitive Pattern Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string RepetitivePatternNumber_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Receiving Advice or Acceptance Certificate
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BRA")]
    public class BRA : I_BRA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentification_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string TransactionSetPurposeCode_03 { get; set; }
        /// <summary>
        /// Receiving Advice or Acceptance Certificate Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReceivingAdviceorAcceptanceCertificateTypeCode_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ReceivingConditionCode_06 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ActionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment for Ship Notice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BSN")]
    public class BSN : I_BSN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Shipment Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ShipmentIdentification_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string HierarchicalStructureCode_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
        /// <summary>
        /// Status Reason Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StatusReasonCode_07 { get; set; }
    }
    
    /// <summary>
    /// General Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BX")]
    public class BX : I_BX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string TransportationMethodTypeCode_02 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ShipmentMethodofPayment_03 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ShipmentIdentificationNumber_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string WeightUnitCode_06 { get; set; }
        /// <summary>
        /// Shipment Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ShipmentQualifier_07 { get; set; }
        /// <summary>
        /// Section Seven Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string SectionSevenCode_08 { get; set; }
        /// <summary>
        /// Capacity Load Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CapacityLoadCode_09 { get; set; }
        /// <summary>
        /// Status Report Request Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string StatusReportRequestCode_10 { get; set; }
        /// <summary>
        /// Customs Documentation Handling Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string CustomsDocumentationHandlingCode_11 { get; set; }
        /// <summary>
        /// Confidential Billing Request Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ConfidentialBillingRequestCode_12 { get; set; }
        /// <summary>
        /// Goods and Services Tax Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string GoodsandServicesTaxReasonCode_13 { get; set; }
        /// <summary>
        /// Application Type
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ApplicationType_14 { get; set; }
    }
    
    /// <summary>
    /// Bank ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("C2")]
    public class C2 : I_C2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bank Client Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string BankClientCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Client Bank Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ClientBankNumber_04 { get; set; }
        /// <summary>
        /// Bank Account Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BankAccountNumber_05 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PaymentMethodCode_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Date_07 { get; set; }
    }
    
    /// <summary>
    /// Currency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("C3")]
    public class C3 : I_C3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CurrencyCode_01 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ExchangeRate_02 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CurrencyCode_03 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CurrencyCode_04 { get; set; }
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
        [Pos(1)]
        public string TransportationMethodTypeCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ReferenceIdentificationQualifier_07 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReferenceIdentification_08 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AcquisitionDataCode_01 { get; set; }
        /// <summary>
        /// Financing Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FinancingTypeCode_02 { get; set; }
    }
    
    /// <summary>
    /// Carton (Package) Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CD3")]
    public class CD3 : I_CD3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string WeightQualifier_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Weight_02 { get; set; }
        /// <summary>
        /// Zone
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Zone_03 { get; set; }
        /// <summary>
        /// Service Standard
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ServiceStandard_04 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ServiceLevelCode_05 { get; set; }
        /// <summary>
        /// Pick-up or Delivery Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PickuporDeliveryCode_06 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string RateValueQualifier_07 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Charge_08 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string RateValueQualifier_09 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Charge_10 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ServiceLevelCode_11 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ServiceLevelCode_12 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string PaymentMethodCode_13 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string CountryCode_14 { get; set; }
    }
    
    /// <summary>
    /// Load Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLD")]
    public class CLD : I_CLD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Loads
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string NumberofLoads_01 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string NumberofUnitsShipped_02 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PackagingCode_03 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Size_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
    }
    
    /// <summary>
    /// Cargo Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CM")]
    public class CM : I_CM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Flight/Voyage Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FlightVoyageNumber_01 { get; set; }
        /// <summary>
        /// Port or Terminal Function Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PortorTerminalFunctionCode_02 { get; set; }
        /// <summary>
        /// Port Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PortName_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Booking Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BookingNumber_05 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string StandardCarrierAlphaCode_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Vessel Name
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string VesselName_09 { get; set; }
        /// <summary>
        /// Pier Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string PierNumber_10 { get; set; }
        /// <summary>
        /// Pier Name
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string PierName_11 { get; set; }
        /// <summary>
        /// Terminal Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TerminalName_12 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string StateorProvinceCode_13 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string CountryCode_14 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ReferenceIdentification_15 { get; set; }
        /// <summary>
        /// Correction Indicator
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string CorrectionIndicator_16 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string TransportationMethodTypeCode_17 { get; set; }
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
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Percent_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TermsDiscountPercent_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string YesNoConditionorResponseCode_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    /// <summary>
    /// Content Reporting Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRD")]
    public class CRD : I_CRD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CountryCode_01 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Percent_04 { get; set; }
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
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ActionCode_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string AgencyQualifierCode_06 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string SpecialServicesCode_07 { get; set; }
        /// <summary>
        /// Product/Service Substitution Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceSubstitutionCode_08 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Percent_09 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string RestrictionsConditionsQualifier_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Description_02 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string QuantityQualifier_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string AmountQualifierCode_05 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
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
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        /// <summary>
        /// Condition Value
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string NumberofLineItems_01 { get; set; }
        /// <summary>
        /// Hash Total
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HashTotal_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Destination Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("D9")]
    public class D9 : I_D9
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FreightStationAccountingCode_01 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CityName_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreightStationAccountingCode_05 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StateorProvinceCode_07 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string StandardPointLocationCode_08 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string PostalCode_09 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string StandardPointLocationCode_10 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string PostalCode_11 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string CountryCode_12 { get; set; }
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
        [Pos(1)]
        public string DiscountTermsTypeCode_01 { get; set; }
        /// <summary>
        /// Discount Base Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DiscountBaseQualifier_02 { get; set; }
        /// <summary>
        /// Discount Base Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string DiscountBaseValue_03 { get; set; }
        /// <summary>
        /// Discount Control Limit Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string DiscountControlLimitQualifier_04 { get; set; }
        /// <summary>
        /// Discount Control Limit
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string DiscountControlLimit_05 { get; set; }
        /// <summary>
        /// Discount Control Limit
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DateTimePeriod_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string GenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string RaceorEthnicityCode_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Date or Time or Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP")]
    public class DTP : I_DTP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Empty Car Disposition - Pended Destination Consignee
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E1")]
    public class E1 : I_E1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name (30 Character Format)
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string NameCharacterFormat_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
    }
    
    /// <summary>
    /// Empty Car Disposition - Pended Destination City
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E4")]
    public class E4 : I_E4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
    }
    
    /// <summary>
    /// Empty Car Disposition - Pended Destination Route
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E5")]
    public class E5 : I_E5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardPointLocationCode_04 { get; set; }
    }
    
    /// <summary>
    /// Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EFI")]
    public class EFI : I_EFI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SecurityLevelCode_01 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeFormMessageText_02 { get; set; }
        /// <summary>
        /// Security Technique Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SecurityTechniqueCode_03 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string VersionIdentifier_04 { get; set; }
        /// <summary>
        /// Program Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ProgramIdentifier_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string VersionIdentifier_06 { get; set; }
        /// <summary>
        /// Interchange Format
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string InterchangeFormat_07 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string VersionIdentifier_08 { get; set; }
        /// <summary>
        /// Compression Technique
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CompressionTechnique_09 { get; set; }
        /// <summary>
        /// Drawing Sheet Size Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DrawingSheetSizeCode_10 { get; set; }
        /// <summary>
        /// File Name
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string FileName_11 { get; set; }
        /// <summary>
        /// Block Type
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string BlockType_12 { get; set; }
        /// <summary>
        /// Record Length
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string RecordLength_13 { get; set; }
        /// <summary>
        /// Block Length
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string BlockLength_14 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string VersionIdentifier_15 { get; set; }
        /// <summary>
        /// Filter ID Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string FilterIDCode_16 { get; set; }
    }
    
    /// <summary>
    /// Equipment Characteristics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EM")]
    public class EM : I_EM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string WeightUnitCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Weight_02 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string VolumeUnitQualifier_03 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Volume_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
        /// <summary>
        /// Construction Type
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ConstructionType_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Date_07 { get; set; }
    }
    
    /// <summary>
    /// Excess Transportation Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ETD")]
    public class ETD : I_ETD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Excess Transportation Reason Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ExcessTransportationReasonCode_01 { get; set; }
        /// <summary>
        /// Excess Transportation Responsibility Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ExcessTransportationResponsibilityCode_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Returnable Container Freight Payment Responsibility Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReturnableContainerFreightPaymentResponsibilityCode_05 { get; set; }
    }
    
    /// <summary>
    /// Origin Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("F9")]
    public class F9 : I_F9
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FreightStationAccountingCode_01 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CityName_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreightStationAccountingCode_05 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StateorProvinceCode_07 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string StandardPointLocationCode_08 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string PostalCode_09 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string StandardPointLocationCode_10 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string PostalCode_11 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string CountryCode_12 { get; set; }
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
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string BreakdownStructureDetailCode_01 { get; set; }
        /// <summary>
        /// Financial Information Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Transportation Terms Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        /// <summary>
        /// Transportation Terms Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TransportationTermsCode_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Risk of Loss Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string RiskofLossCode_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Description_09 { get; set; }
    }
    
    /// <summary>
    /// Total Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G05")]
    public class G05 : I_G05
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LadingQuantity_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
    }
    
    /// <summary>
    /// Pricing Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G26")]
    public class G26 : I_G26
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price Condition Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PriceConditionCode_01 { get; set; }
        /// <summary>
        /// Date Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DateQualifier_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Quantity Basis
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string QuantityBasis_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
    }
    
    /// <summary>
    /// Price List Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G36")]
    public class G36 : I_G36
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price List Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PriceListNumber_01 { get; set; }
        /// <summary>
        /// Price List Issue Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PriceListIssueNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Price Condition Applies Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PriceConditionAppliesCode_04 { get; set; }
    }
    
    /// <summary>
    /// Item Characteristics - Vendor's Selling Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G39")]
    public class G39 : I_G39
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// U.P.C. Case Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string UPCCaseCode_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProductServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SpecialHandlingCode_04 { get; set; }
        /// <summary>
        /// Unit Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitWeight_05 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string WeightQualifier_06 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string WeightUnitCode_07 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Height_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Width_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Length_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Volume_14 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string UnitorBasisforMeasurementCode_15 { get; set; }
        /// <summary>
        /// Pallet Block and Tiers
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string PalletBlockandTiers_16 { get; set; }
        /// <summary>
        /// Pack
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string Pack_17 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string Size_18 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string UnitorBasisforMeasurementCode_19 { get; set; }
        /// <summary>
        /// Color
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string Color_20 { get; set; }
        /// <summary>
        /// Order Sizing Factor
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string OrderSizingFactor_21 { get; set; }
        /// <summary>
        /// Alternate Tiers per Pallet
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string AlternateTiersperPallet_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string WeightQualifier_25 { get; set; }
        /// <summary>
        /// Unit Weight
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string UnitWeight_26 { get; set; }
        /// <summary>
        /// Inner Pack
        /// </summary>
        [DataMember]
        [Pos(27)]
        public string InnerPack_27 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Pos(28)]
        public string PackagingCode_28 { get; set; }
    }
    
    /// <summary>
    /// Bracket Price
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G40")]
    public class G40 : I_G40
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price Bracket Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PriceBracketIdentifier_01 { get; set; }
        /// <summary>
        /// Item List Cost - New
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ItemListCostNew_02 { get; set; }
        /// <summary>
        /// Item List Cost - Old
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ItemListCostOld_03 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string FreeformDescription_04 { get; set; }
        /// <summary>
        /// Price New, Suggested Retail
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string PriceNewSuggestedRetail_05 { get; set; }
        /// <summary>
        /// Price Old, Suggested Retail
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PriceOldSuggestedRetail_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string PriceIdentifierCode_08 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Number_09 { get; set; }
    }
    
    /// <summary>
    /// Promotion/Price List Area
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G43")]
    public class G43 : I_G43
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Market Area Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string MarketAreaCodeQualifier_01 { get; set; }
        /// <summary>
        /// Market Area Code Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MarketAreaCodeIdentifier_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ClassofTradeCode_04 { get; set; }
    }
    
    /// <summary>
    /// Maintenance Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G53")]
    public class G53 : I_G53
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string MaintenanceTypeCode_01 { get; set; }
    }
    
    /// <summary>
    /// Module Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G54")]
    public class G54 : I_G54
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// U.P.C. Case Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UPCCaseCode_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string FreeformDescription_06 { get; set; }
    }
    
    /// <summary>
    /// Item Characteristics - Consumer Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G55")]
    public class G55 : I_G55
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ProductServiceIDQualifier_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ProductServiceID_04 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Height_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Width_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Length_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Volume_11 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string UnitorBasisforMeasurementCode_12 { get; set; }
        /// <summary>
        /// Pack
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string Pack_13 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Size_14 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string UnitorBasisforMeasurementCode_15 { get; set; }
        /// <summary>
        /// Cash Register Item Description
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string CashRegisterItemDescription_16 { get; set; }
        /// <summary>
        /// Cash Register Item Description
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string CashRegisterItemDescription_17 { get; set; }
        /// <summary>
        /// Coupon Family Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string CouponFamilyCode_18 { get; set; }
        /// <summary>
        /// Dated Product Number of Days
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string DatedProductNumberofDays_19 { get; set; }
        /// <summary>
        /// Deposit Value
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string DepositValue_20 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string YesNoConditionorResponseCode_21 { get; set; }
        /// <summary>
        /// Color
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string Color_22 { get; set; }
        /// <summary>
        /// Unit Weight
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string UnitWeight_23 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string WeightQualifier_24 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string WeightUnitCode_25 { get; set; }
        /// <summary>
        /// Unit Weight
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string UnitWeight_26 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(27)]
        public string WeightQualifier_27 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(28)]
        public string WeightUnitCode_28 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(29)]
        public string ProductServiceIDQualifier_29 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(30)]
        public string ProductServiceID_30 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(31)]
        public string FreeformDescription_31 { get; set; }
        /// <summary>
        /// Inner Pack
        /// </summary>
        [DataMember]
        [Pos(32)]
        public string InnerPack_32 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Pos(33)]
        public string PackagingCode_33 { get; set; }
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
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ContactInquiryReference_05 { get; set; }
    }
    
    /// <summary>
    /// Date/Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G62")]
    public class G62 : I_G62
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string DateQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string TimeQualifier_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TimeCode_05 { get; set; }
    }
    
    /// <summary>
    /// Line Item Detail - Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G69")]
    public class G69 : I_G69
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FreeformDescription_01 { get; set; }
    }
    
    /// <summary>
    /// Allowance or Charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G72")]
    public class G72 : I_G72
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AllowanceorChargeCode_01 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AllowanceorChargeMethodofHandlingCode_02 { get; set; }
        /// <summary>
        /// Allowance or Charge Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AllowanceorChargeNumber_03 { get; set; }
        /// <summary>
        /// Exception Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ExceptionNumber_04 { get; set; }
        /// <summary>
        /// Allowance or Charge Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string AllowanceorChargeRate_05 { get; set; }
        /// <summary>
        /// Allowance or Charge Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string AllowanceorChargeQuantity_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Allowance or Charge Total Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string AllowanceorChargeTotalAmount_08 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Percent_09 { get; set; }
        /// <summary>
        /// Dollar Basis For Percent
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DollarBasisForPercent_10 { get; set; }
        /// <summary>
        /// Option Number
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string OptionNumber_11 { get; set; }
    }
    
    /// <summary>
    /// Price Bracket Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G93")]
    public class G93 : I_G93
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price Bracket Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PriceBracketIdentifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string FreeformDescription_04 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TransportationMethodTypeCode_05 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PriceIdentifierCode_06 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ActionCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    /// <summary>
    /// Canadian Grain Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GA")]
    public class GA : I_GA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Fumigated/Cleaned Indicator
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FumigatedCleanedIndicator_01 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CommodityCode_02 { get; set; }
        /// <summary>
        /// Inspected/Weighed Indicator Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string InspectedWeighedIndicatorCode_03 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReferenceIdentificationQualifier_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReferenceIdentification_05 { get; set; }
        /// <summary>
        /// Week
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Week_06 { get; set; }
        /// <summary>
        /// Unload Terminal Elevator Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnloadTerminalElevatorCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Number_09 { get; set; }
        /// <summary>
        /// Machine Separable Indicator Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string MachineSeparableIndicatorCode_10 { get; set; }
        /// <summary>
        /// Canadian Wheat Board (CWB) Marketing Class Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string CanadianWheatBoardCWBMarketingClassCode_11 { get; set; }
        /// <summary>
        /// Canadian Wheat Board (CWB) Marketing Class Type Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string CanadianWheatBoardCWBMarketingClassTypeCode_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string LocationIdentifier_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string PercentQualifier_16 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string Percent_17 { get; set; }
    }
    
    /// <summary>
    /// Furnished Goods and Services
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GF")]
    public class GF : I_GF
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ContractNumber_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ReleaseNumber_07 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReferenceIdentificationQualifier_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ReferenceIdentification_09 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H1")]
    public class H1 : I_H1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousMaterialCode_01 { get; set; }
        /// <summary>
        /// Hazardous Material Class Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousMaterialClassCode_02 { get; set; }
        /// <summary>
        /// Hazardous Material Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousMaterialCodeQualifier_03 { get; set; }
        /// <summary>
        /// Hazardous Material Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardousMaterialDescription_04 { get; set; }
        /// <summary>
        /// Hazardous Material Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string HazardousMaterialContact_05 { get; set; }
        /// <summary>
        /// Hazardous Materials Page
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string HazardousMaterialsPage_06 { get; set; }
        /// <summary>
        /// Flashpoint Temperature
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string FlashpointTemperature_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Packing Group Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string PackingGroupCode_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Hazardous Material Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H2")]
    public class H2 : I_H2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Description
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousMaterialDescription_01 { get; set; }
        /// <summary>
        /// Hazardous Material Classification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousMaterialClassification_02 { get; set; }
    }
    
    /// <summary>
    /// Special Handling Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H3")]
    public class H3 : I_H3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Special Handling Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SpecialHandlingDescription_02 { get; set; }
        /// <summary>
        /// Protective Service Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ProtectiveServiceCode_03 { get; set; }
        /// <summary>
        /// Vent Instruction Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string VentInstructionCode_04 { get; set; }
        /// <summary>
        /// Tariff Application Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TariffApplicationCode_05 { get; set; }
    }
    
    /// <summary>
    /// Special Services
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H6")]
    public class H6 : I_H6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SpecialServicesCode_01 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SpecialServicesCode_02 { get; set; }
        /// <summary>
        /// Quantity of Pallets Shipped
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string QuantityofPalletsShipped_03 { get; set; }
        /// <summary>
        /// Pallet Exchange Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PalletExchangeCode_04 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Weight_05 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string WeightUnitCode_06 { get; set; }
        /// <summary>
        /// Pick-up or Delivery Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string PickuporDeliveryCode_07 { get; set; }
    }
    
    /// <summary>
    /// Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL")]
    public class HL : I_HL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Intermodal Chassis Equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IC")]
    public class IC : I_IC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EquipmentInitial_01 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentNumber_02 { get; set; }
        /// <summary>
        /// Tare Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string TareWeight_03 { get; set; }
        /// <summary>
        /// Tare Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TareQualifierCode_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EquipmentLength_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Chassis Type
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ChassisType_08 { get; set; }
    }
    
    /// <summary>
    /// Intermodal Movement Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IM")]
    public class IM : I_IM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Water Movement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string WaterMovementCode_01 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SpecialHandlingCode_02 { get; set; }
        /// <summary>
        /// Inland Transportation Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string InlandTransportationCode_03 { get; set; }
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
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C001 CompositeUnitofMeasure_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Invoiced
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string QuantityInvoiced_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ShipmentOrderStatusCode_03 { get; set; }
        /// <summary>
        /// Quantity Difference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string QuantityDifference_04 { get; set; }
        /// <summary>
        /// Change Reason Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ActionCode_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string AgencyQualifierCode_06 { get; set; }
        /// <summary>
        /// Product/Service Substitution Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceSubstitutionCode_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        /// <summary>
        /// Terms Basis Date Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string TermsDiscountPercent_03 { get; set; }
        /// <summary>
        /// Terms Discount Due Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        /// <summary>
        /// Terms Discount Days Due
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        /// <summary>
        /// Terms Net Due Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TermsNetDueDate_06 { get; set; }
        /// <summary>
        /// Terms Net Days
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string TermsNetDays_07 { get; set; }
        /// <summary>
        /// Terms Discount Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TermsDiscountAmount_08 { get; set; }
        /// <summary>
        /// Terms Deferred Due Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        /// <summary>
        /// Deferred Amount Due
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DeferredAmountDue_10 { get; set; }
        /// <summary>
        /// Percent of Invoice Payable
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Description_12 { get; set; }
        /// <summary>
        /// Day of Month
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string DayofMonth_13 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string PaymentMethodCode_14 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string Percent_15 { get; set; }
    }
    
    /// <summary>
    /// Remarks
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("K1")]
    public class K1 : I_K1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FreeFormMessage_01 { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }
    
    /// <summary>
    /// Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L0")]
    public class L0 : I_L0
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Billed/Rated-as Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string BilledRatedasQuantity_02 { get; set; }
        /// <summary>
        /// Billed/Rated-as Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string BilledRatedasQualifier_03 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Weight_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Volume_06 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string VolumeUnitQualifier_07 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LadingQuantity_08 { get; set; }
        /// <summary>
        /// Packaging Form Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string PackagingFormCode_09 { get; set; }
        /// <summary>
        /// Dunnage Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DunnageDescription_10 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string WeightUnitCode_11 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TypeofServiceCode_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string Quantity_13 { get; set; }
        /// <summary>
        /// Packaging Form Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string PackagingFormCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    /// <summary>
    /// Rate and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L1")]
    public class L1 : I_L1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreightRate_02 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RateValueQualifier_03 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Charge_04 { get; set; }
        /// <summary>
        /// Advances
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Advances_05 { get; set; }
        /// <summary>
        /// Prepaid Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PrepaidAmount_06 { get; set; }
        /// <summary>
        /// Rate Combination Point Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string RateCombinationPointCode_07 { get; set; }
        /// <summary>
        /// Special Charge or Allowance Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string SpecialChargeorAllowanceCode_08 { get; set; }
        /// <summary>
        /// Rate Class Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string RateClassCode_09 { get; set; }
        /// <summary>
        /// Entitlement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string EntitlementCode_10 { get; set; }
        /// <summary>
        /// Charge Method of Payment
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ChargeMethodofPayment_11 { get; set; }
        /// <summary>
        /// Special Charge Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string SpecialChargeDescription_12 { get; set; }
        /// <summary>
        /// Tariff Application Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TariffApplicationCode_13 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string DeclaredValue_14 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string RateValueQualifier_15 { get; set; }
        /// <summary>
        /// Lading Liability Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string LadingLiabilityCode_16 { get; set; }
        /// <summary>
        /// Billed/Rated-as Quantity
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string BilledRatedasQuantity_17 { get; set; }
        /// <summary>
        /// Billed/Rated-as Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string BilledRatedasQualifier_18 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string Percent_19 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string CurrencyCode_20 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string Amount_21 { get; set; }
    }
    
    /// <summary>
    /// Business Instructions and Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L11")]
    public class L11 : I_L11
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentification_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Description_03 { get; set; }
    }
    
    /// <summary>
    /// Total Weight and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L3")]
    public class L3 : I_L3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Weight_01 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string WeightQualifier_02 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string FreightRate_03 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Charge_05 { get; set; }
        /// <summary>
        /// Advances
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Advances_06 { get; set; }
        /// <summary>
        /// Prepaid Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string PrepaidAmount_07 { get; set; }
        /// <summary>
        /// Special Charge or Allowance Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string SpecialChargeorAllowanceCode_08 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Volume_09 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string VolumeUnitQualifier_10 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string LadingQuantity_11 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string WeightUnitCode_12 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TariffNumber_13 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string DeclaredValue_14 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string RateValueQualifier_15 { get; set; }
    }
    
    /// <summary>
    /// Measurement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L4")]
    public class L4 : I_L4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Length_01 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Width_02 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Height_03 { get; set; }
        /// <summary>
        /// Measurement Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string MeasurementUnitQualifier_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string IndustryCode_06 { get; set; }
    }
    
    /// <summary>
    /// Description, Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L5")]
    public class L5 : I_L5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LadingDescription_02 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CommodityCode_03 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CommodityCodeQualifier_04 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string PackagingCode_05 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string MarksandNumbers_06 { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string MarksandNumbersQualifier_07 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CommodityCodeQualifier_08 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CommodityCode_09 { get; set; }
        /// <summary>
        /// Compartment ID Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string CompartmentIDCode_10 { get; set; }
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
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Tariff Agency Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string TariffAgencyCode_02 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string TariffNumber_03 { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TariffSection_04 { get; set; }
        /// <summary>
        /// Tariff Item Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TariffItemNumber_05 { get; set; }
        /// <summary>
        /// Tariff Item Part
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TariffItemPart_06 { get; set; }
        /// <summary>
        /// Freight Class Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string FreightClassCode_07 { get; set; }
        /// <summary>
        /// Tariff Supplement Identifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TariffSupplementIdentifier_08 { get; set; }
        /// <summary>
        /// Ex Parte
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ExParte_09 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Date_10 { get; set; }
        /// <summary>
        /// Rate Basis Number
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string RateBasisNumber_11 { get; set; }
        /// <summary>
        /// Tariff Column
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TariffColumn_12 { get; set; }
        /// <summary>
        /// Tariff Distance
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TariffDistance_13 { get; set; }
        /// <summary>
        /// Distance Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string DistanceQualifier_14 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string CityName_15 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string StateorProvinceCode_16 { get; set; }
    }
    
    /// <summary>
    /// Charge Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L9")]
    public class L9 : I_L9
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Charge or Allowance Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SpecialChargeorAllowanceCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
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
        [Pos(1)]
        public string LeadTimeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Time Period or Interval
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitofTimePeriodorInterval_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// EPA Required Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LEP")]
    public class LEP : I_LEP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EPA Waste Stream Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EPAWasteStreamNumberCode_01 { get; set; }
        /// <summary>
        /// Waste Characteristics Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string WasteCharacteristicsCode_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Information, Finished Goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LFG")]
    public class LFG : I_LFG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Description_01 { get; set; }
        /// <summary>
        /// Hazardous Classification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousClassification_02 { get; set; }
        /// <summary>
        /// UN/NA Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UNNAIdentificationCode_03 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardousPlacardNotation_04 { get; set; }
        /// <summary>
        /// Packing Group Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string PackingGroupCode_05 { get; set; }
        /// <summary>
        /// Hazardous Material Regulations Exception Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string HazardousMaterialRegulationsExceptionCode_06 { get; set; }
    }
    
    /// <summary>
    /// Freeform Hazardous Material Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LFH")]
    public class LFH : I_LFH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Shipment Information Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousMaterialShipmentInformationQualifier_01 { get; set; }
        /// <summary>
        /// Hazardous Material Shipment Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousMaterialShipmentInformation_02 { get; set; }
        /// <summary>
        /// Hazardous Material Shipment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousMaterialShipmentInformation_03 { get; set; }
        /// <summary>
        /// Hazard Zone Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardZoneCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Quantity_07 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH1")]
    public class LH1 : I_LH1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LadingQuantity_02 { get; set; }
        /// <summary>
        /// UN/NA Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UNNAIdentificationCode_03 { get; set; }
        /// <summary>
        /// Hazardous Materials Page
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardousMaterialsPage_04 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CommodityCode_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Compartment ID Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CompartmentIDCode_08 { get; set; }
        /// <summary>
        /// Residue Indicator Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ResidueIndicatorCode_09 { get; set; }
        /// <summary>
        /// Packing Group Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string PackingGroupCode_10 { get; set; }
        /// <summary>
        /// Interim Hazardous Material Regulatory Number
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string InterimHazardousMaterialRegulatoryNumber_11 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Classification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH2")]
    public class LH2 : I_LH2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Classification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousClassification_01 { get; set; }
        /// <summary>
        /// Hazardous Class Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousClassQualifier_02 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousPlacardNotation_03 { get; set; }
        /// <summary>
        /// Hazardous Endorsement
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardousEndorsement_04 { get; set; }
        /// <summary>
        /// Reportable Quantity Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReportableQuantityCode_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Temperature_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Temperature_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Temperature_11 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Material Shipping Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH3")]
    public class LH3 : I_LH3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousMaterialShippingName_01 { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousMaterialShippingNameQualifier_02 { get; set; }
        /// <summary>
        /// N.O.S. Indicator Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string NOSIndicatorCode_03 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    /// <summary>
    /// Canadian Dangerous Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH4")]
    public class LH4 : I_LH4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Emergency Response Plan Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EmergencyResponsePlanNumber_01 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CommunicationNumber_02 { get; set; }
        /// <summary>
        /// Packing Group Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PackingGroupCode_03 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SubsidiaryClassification_04 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string SubsidiaryClassification_05 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string SubsidiaryClassification_06 { get; set; }
        /// <summary>
        /// Subsidiary Risk Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string SubsidiaryRiskIndicator_07 { get; set; }
        /// <summary>
        /// Net Explosive Quantity
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string NetExplosiveQuantity_08 { get; set; }
        /// <summary>
        /// Canadian Hazardous Notation
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CanadianHazardousNotation_09 { get; set; }
        /// <summary>
        /// Special Commodity Indicator Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string SpecialCommodityIndicatorCode_10 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string CommunicationNumber_11 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string UnitorBasisforMeasurementCode_12 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Certification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH6")]
    public class LH6 : I_LH6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Name_01 { get; set; }
        /// <summary>
        /// Hazardous Certification Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousCertificationCode_02 { get; set; }
        /// <summary>
        /// Hazardous Certification Declaration
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousCertificationDeclaration_03 { get; set; }
        /// <summary>
        /// Hazardous Certification Declaration
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string HazardousCertificationDeclaration_04 { get; set; }
    }
    
    /// <summary>
    /// Empty Equipment Hazardous Material Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LHE")]
    public class LHE : I_LHE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousMaterialShippingName_01 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousPlacardNotation_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reportable Quantity Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ReportableQuantityCode_05 { get; set; }
    }
    
    /// <summary>
    /// Hazardous Material Identifying Reference Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LHR")]
    public class LHR : I_LHR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
    }
    
    /// <summary>
    /// Transborder Hazardous Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LHT")]
    public class LHT : I_LHT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Classification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string HazardousClassification_01 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousPlacardNotation_02 { get; set; }
        /// <summary>
        /// Hazardous Endorsement
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousEndorsement_03 { get; set; }
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
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProductServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LX")]
    public class LX : I_LX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    /// <summary>
    /// Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M1")]
    public class M1 : I_M1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CountryCode_01 { get; set; }
        /// <summary>
        /// Carriage Value
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CarriageValue_02 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string DeclaredValue_03 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string EntityIdentifierCode_05 { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string FreeFormMessage_06 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string RateValueQualifier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string PercentQualifier_09 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Percent_10 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string PercentQualifier_11 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Percent_12 { get; set; }
    }
    
    /// <summary>
    /// In-bond Identifying Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M12")]
    public class M12 : I_M12
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Customs Entry Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CustomsEntryTypeCode_01 { get; set; }
        /// <summary>
        /// Customs Entry Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string CustomsEntryNumber_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string LocationIdentifier_04 { get; set; }
        /// <summary>
        /// Customs Shipment Value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CustomsShipmentValue_05 { get; set; }
        /// <summary>
        /// In-bond Control Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string InbondControlNumber_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReferenceIdentificationQualifier_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ReferenceIdentification_09 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TransportationMethodTypeCode_10 { get; set; }
        /// <summary>
        /// Vessel Name
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string VesselName_11 { get; set; }
    }
    
    /// <summary>
    /// Release
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M3")]
    public class M3 : I_M3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Release Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReleaseCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TimeCode_04 { get; set; }
    }
    
    /// <summary>
    /// Seal Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M7")]
    public class M7 : I_M7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SealNumber_01 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SealNumber_02 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SealNumber_03 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SealNumber_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string EntityIdentifierCode_05 { get; set; }
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
        [Pos(1)]
        public string MarksandNumbersQualifier_01 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MarksandNumbers_02 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string MarksandNumbers_03 { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string MarksandNumbersQualifier_04 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string MarksandNumbers_05 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string MeasurementReferenceIDCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
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
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
    }
    
    /// <summary>
    /// Equipment, Shipment, or Real Property Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MS1")]
    public class MS1 : I_MS1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CountryCode_03 { get; set; }
        /// <summary>
        /// Longitude Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string LongitudeCode_04 { get; set; }
        /// <summary>
        /// Latitude Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string LatitudeCode_05 { get; set; }
        /// <summary>
        /// Direction Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string DirectionIdentifierCode_06 { get; set; }
        /// <summary>
        /// Direction Identifier Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string DirectionIdentifierCode_07 { get; set; }
    }
    
    /// <summary>
    /// Equipment or Container Owner and Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MS2")]
    public class MS2 : I_MS2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentNumber_02 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EquipmentDescriptionCode_03 { get; set; }
        /// <summary>
        /// Equipment Number Check Digit
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string EquipmentNumberCheckDigit_04 { get; set; }
    }
    
    /// <summary>
    /// Interline Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MS3")]
    public class MS3 : I_MS3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StateorProvinceCode_05 { get; set; }
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
        [Pos(1)]
        public string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PrinterCarriageControlCode_02 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MessageText_02 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string MessageText_03 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Quantity and Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N10")]
    public class N10 : I_N10
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeformDescription_02 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string MarksandNumbers_03 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CommodityCodeQualifier_04 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CommodityCode_05 { get; set; }
        /// <summary>
        /// Customs Shipment Value
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CustomsShipmentValue_06 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string WeightUnitCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Weight_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ReferenceIdentification_09 { get; set; }
        /// <summary>
        /// Manifest Unit Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ManifestUnitCode_10 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string CountryCode_11 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string CountryCode_12 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string CurrencyCode_13 { get; set; }
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
        [Pos(1)]
        public string Name_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Equipment Ordered
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N5")]
    public class N5 : I_N5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EquipmentLength_01 { get; set; }
        /// <summary>
        /// Weight Capacity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string WeightCapacity_02 { get; set; }
        /// <summary>
        /// Cubic Capacity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CubicCapacity_03 { get; set; }
        /// <summary>
        /// Car Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CarTypeCode_04 { get; set; }
        /// <summary>
        /// Metric Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string MetricQualifier_05 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Height_06 { get; set; }
        /// <summary>
        /// Lading Percentage
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LadingPercentage_07 { get; set; }
        /// <summary>
        /// Lading Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LadingPercentQualifier_08 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string EquipmentDescriptionCode_09 { get; set; }
    }
    
    /// <summary>
    /// Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N7")]
    public class N7 : I_N7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EquipmentInitial_01 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentNumber_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Tare Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TareWeight_05 { get; set; }
        /// <summary>
        /// Weight Allowance
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string WeightAllowance_06 { get; set; }
        /// <summary>
        /// Dunnage
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Dunnage_07 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Volume_08 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string VolumeUnitQualifier_09 { get; set; }
        /// <summary>
        /// Ownership Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string OwnershipCode_10 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string EquipmentDescriptionCode_11 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string StandardCarrierAlphaCode_12 { get; set; }
        /// <summary>
        /// Temperature Control
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TemperatureControl_13 { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Position_14 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string EquipmentLength_15 { get; set; }
        /// <summary>
        /// Tare Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string TareQualifierCode_16 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string WeightUnitCode_17 { get; set; }
        /// <summary>
        /// Equipment Number Check Digit
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string EquipmentNumberCheckDigit_18 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string TypeofServiceCode_19 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string Height_20 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string Width_21 { get; set; }
        /// <summary>
        /// Equipment Type
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string EquipmentType_22 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string StandardCarrierAlphaCode_23 { get; set; }
        /// <summary>
        /// Car Type Code
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string CarTypeCode_24 { get; set; }
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
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string FreeformDescription_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
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
    /// Cross-Reference Equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NA")]
    public class NA : I_NA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EquipmentInitial_03 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string EquipmentNumber_04 { get; set; }
        /// <summary>
        /// Cross Reference Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CrossReferenceTypeCode_05 { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Position_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string EquipmentLength_08 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string StandardCarrierAlphaCode_09 { get; set; }
        /// <summary>
        /// Chassis Type
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ChassisType_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    /// <summary>
    /// Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1")]
    public class NM1 : I_NM1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string NameLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string NameFirst_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string NameMiddle_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
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
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AddressComponentQualifier_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
        /// <summary>
        /// County Designator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CountyDesignator_03 { get; set; }
    }
    
    /// <summary>
    /// Original Transaction Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OTI")]
    public class OTI : I_OTI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application Acknowledgment Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ApplicationAcknowledgmentCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// Application Sender's Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ApplicationSendersCode_04 { get; set; }
        /// <summary>
        /// Application Receiver's Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ApplicationReceiversCode_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Group Control Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string GroupControlNumber_08 { get; set; }
        /// <summary>
        /// Transaction Set Control Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TransactionSetControlNumber_09 { get; set; }
        /// <summary>
        /// Transaction Set Identifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TransactionSetIdentifierCode_10 { get; set; }
        /// <summary>
        /// Version / Release / Industry Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string VersionReleaseIndustryIdentifierCode_11 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TransactionSetPurposeCode_12 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string TransactionTypeCode_13 { get; set; }
        /// <summary>
        /// Application Type
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ApplicationType_14 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ActionCode_15 { get; set; }
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string TransactionHandlingCode_16 { get; set; }
        /// <summary>
        /// Status Reason Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string StatusReasonCode_17 { get; set; }
    }
    
    /// <summary>
    /// Pallet Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAL")]
    public class PAL : I_PAL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pallet Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PalletTypeCode_01 { get; set; }
        /// <summary>
        /// Pallet Tiers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PalletTiers_02 { get; set; }
        /// <summary>
        /// Pallet Blocks
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PalletBlocks_03 { get; set; }
        /// <summary>
        /// Pack
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Pack_04 { get; set; }
        /// <summary>
        /// Unit Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitWeight_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Length_07 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Width_08 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Height_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Gross Weight per Pack
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string GrossWeightperPack_11 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string UnitorBasisforMeasurementCode_12 { get; set; }
        /// <summary>
        /// Gross Volume per Pack
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string GrossVolumeperPack_13 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string UnitorBasisforMeasurementCode_14 { get; set; }
        /// <summary>
        /// Pallet Exchange Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string PalletExchangeCode_15 { get; set; }
        /// <summary>
        /// Inner Pack
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string InnerPack_16 { get; set; }
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
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
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
        [Pos(4)]
        public string AmountQualifierCode_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Unit of Time Period or Interval
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitofTimePeriodorInterval_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string PercentQualifier_13 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Percent_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string PercentQualifier_01 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Price Authority Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PI")]
    public class PI : I_PI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Primary Publication Authority Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PrimaryPublicationAuthorityCode_03 { get; set; }
        /// <summary>
        /// Regulatory Agency Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string RegulatoryAgencyCode_04 { get; set; }
        /// <summary>
        /// Tariff Agency Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TariffAgencyCode_05 { get; set; }
        /// <summary>
        /// Issuing Carrier Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string IssuingCarrierIdentifier_06 { get; set; }
        /// <summary>
        /// Contract Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ContractSuffix_07 { get; set; }
        /// <summary>
        /// Tariff Item Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TariffItemNumber_08 { get; set; }
        /// <summary>
        /// Tariff Supplement Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TariffSupplementIdentifier_09 { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TariffSection_10 { get; set; }
        /// <summary>
        /// Contract Suffix
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ContractSuffix_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Date_12 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string Date_13 { get; set; }
        /// <summary>
        /// Alternation Precedence Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string AlternationPrecedenceCode_14 { get; set; }
        /// <summary>
        /// Alternation Precedence Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string AlternationPrecedenceCode_15 { get; set; }
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
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string SourceSubqualifier_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Packaging Characteristic Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PackagingCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Packaging Description Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PackagingDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Unit Load Option Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitLoadOptionCode_06 { get; set; }
    }
    
    /// <summary>
    /// Multi-Pack Configuration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PKL")]
    public class PKL : I_PKL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Height_05 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Width_06 { get; set; }
        /// <summary>
        /// Item Depth
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ItemDepth_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Gross Weight per Pack
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string GrossWeightperPack_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Gross Volume per Pack
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string GrossVolumeperPack_11 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string UnitorBasisforMeasurementCode_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
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
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string QuantityOrdered_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string ChangeReasonCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PriceIdentifierCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Pack_01 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Size_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PackagingCode_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Gross Weight per Pack
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string GrossWeightperPack_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Gross Volume per Pack
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string GrossVolumeperPack_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Length_10 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Width_11 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Height_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Inner Pack
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string InnerPack_14 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string SurfaceLayerPositionCode_15 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string AssignedIdentification_16 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string AssignedIdentification_17 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string Number_18 { get; set; }
    }
    
    /// <summary>
    /// Proof of Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POD")]
    public class POD : I_POD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Name_03 { get; set; }
    }
    
    /// <summary>
    /// Purchase Order Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRF")]
    public class PRF : I_PRF
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PurchaseOrderNumber_01 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReleaseNumber_02 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ChangeOrderSequenceNumber_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string AssignedIdentification_05 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ContractNumber_06 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string PurchaseOrderTypeCode_07 { get; set; }
    }
    
    /// <summary>
    /// Protective Service Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PS")]
    public class PS : I_PS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Protective Service Rule Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ProtectiveServiceRuleCode_01 { get; set; }
        /// <summary>
        /// Protective Service Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ProtectiveServiceCode_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Temperature_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string FreightStationAccountingCode_06 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CityName_07 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string StateorProvinceCode_08 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Weight_09 { get; set; }
        /// <summary>
        /// Pre-Cooled (Rule 710) Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string PreCooledRuleCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string YesNoConditionorResponseCode_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string YesNoConditionorResponseCode_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Temperature_14 { get; set; }
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
        [Pos(1)]
        public string ReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
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
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Lading Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("Q7")]
    public class Q7 : I_Q7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LadingExceptionCode_01 { get; set; }
        /// <summary>
        /// Packaging Form Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string PackagingFormCode_02 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string LadingQuantity_03 { get; set; }
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
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
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
        [Pos(4)]
        public string FreeFormMessage_04 { get; set; }
    }
    
    /// <summary>
    /// Route Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R2")]
    public class R2 : I_R2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardPointLocationCode_04 { get; set; }
        /// <summary>
        /// Intermodal Service Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string IntermodalServiceCode_05 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TransportationMethodTypeCode_06 { get; set; }
        /// <summary>
        /// Intermediate Switch Carrier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string IntermediateSwitchCarrier_07 { get; set; }
        /// <summary>
        /// Intermediate Switch Carrier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string IntermediateSwitchCarrier_08 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string InvoiceNumber_09 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Date_10 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string FreeformDescription_11 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TypeofServiceCode_12 { get; set; }
        /// <summary>
        /// Route Description
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string RouteDescription_13 { get; set; }
    }
    
    /// <summary>
    /// Route Information - Motor
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R3")]
    public class R3 : I_R3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardPointLocationCode_05 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string InvoiceNumber_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Amount_08 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string FreeformDescription_09 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ServiceLevelCode_10 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ServiceLevelCode_11 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ServiceLevelCode_12 { get; set; }
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
        [Pos(1)]
        public string PortorTerminalFunctionCode_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Port Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string PortName_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
        /// <summary>
        /// Terminal Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TerminalName_06 { get; set; }
        /// <summary>
        /// Pier Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string PierNumber_07 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string StateorProvinceCode_08 { get; set; }
    }
    
    /// <summary>
    /// Route Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R9")]
    public class R9 : I_R9
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Route Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string RouteCode_01 { get; set; }
        /// <summary>
        /// Agent/Shipper Routing Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AgentShipperRoutingCode_02 { get; set; }
        /// <summary>
        /// Intermodal Service Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IntermodalServiceCode_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ActionCode_05 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string StandardCarrierAlphaCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    /// <summary>
    /// Receiving Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCD")]
    public class RCD : I_RCD<C001, C001, C001, C001, C001, C001, C001>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Units Received or Accepted
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string QuantityUnitsReceivedorAccepted_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001 CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Quantity Units Returned
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string QuantityUnitsReturned_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C001 CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string QuantityinQuestion_06 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C001 CompositeUnitofMeasure_07 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReceivingConditionCode_08 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string QuantityinQuestion_09 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C001 CompositeUnitofMeasure_10 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ReceivingConditionCode_11 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string QuantityinQuestion_12 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual C001 CompositeUnitofMeasure_13 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ReceivingConditionCode_14 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string QuantityinQuestion_15 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual C001 CompositeUnitofMeasure_16 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ReceivingConditionCode_17 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string QuantityinQuestion_18 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual C001 CompositeUnitofMeasure_19 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ReceivingConditionCode_20 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string Quantity_21 { get; set; }
    }
    
    /// <summary>
    /// Related Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RED")]
    public class RED : I_RED
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Description_01 { get; set; }
        /// <summary>
        /// Related Data Identification Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RelatedDataIdentificationCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SourceSubqualifier_04 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CodeListQualifierCode_05 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string IndustryCode_06 { get; set; }
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
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
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
    /// Stop-off Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("S1")]
    public class S1 : I_S1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Sequence Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StopSequenceNumber_01 { get; set; }
        /// <summary>
        /// Name (30 Character Format)
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string NameCharacterFormat_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Accomplish Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string AccomplishCode_06 { get; set; }
    }
    
    /// <summary>
    /// Stop-off Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("S2")]
    public class S2 : I_S2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Sequence Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StopSequenceNumber_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AddressInformation_03 { get; set; }
    }
    
    /// <summary>
    /// Stop Off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("S5")]
    public class S5 : I_S5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Sequence Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StopSequenceNumber_01 { get; set; }
        /// <summary>
        /// Stop Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StopReasonCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string WeightUnitCode_04 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string NumberofUnitsShipped_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Volume_07 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string VolumeUnitQualifier_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Description_09 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string StandardPointLocationCode_10 { get; set; }
        /// <summary>
        /// Accomplish Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string AccomplishCode_11 { get; set; }
    }
    
    /// <summary>
    /// Stop-off Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("S9")]
    public class S9 : I_S9
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Sequence Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string StopSequenceNumber_01 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StandardPointLocationCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
        /// <summary>
        /// Stop Reason Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string StopReasonCode_06 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LocationQualifier_07 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
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
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Agency Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Amount_05 { get; set; }
        /// <summary>
        /// Allowance/Charge Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string AllowanceChargePercentQualifier_06 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Percent_07 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Rate_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string Quantity_11 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ReferenceIdentification_13 { get; set; }
        /// <summary>
        /// Option Number
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string OptionNumber_14 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string Description_15 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Name_04 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string DateTimeQualifier_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string DateTimeQualifier_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Time_10 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string RequestReferenceNumber_11 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string IdentificationCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Quantity_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string IdentificationCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string IdentificationCode_13 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string Quantity_14 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string IdentificationCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string Quantity_16 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string IdentificationCode_17 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string Quantity_18 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string IdentificationCode_19 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string Quantity_20 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string IdentificationCode_21 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string Quantity_22 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AgencyQualifierCode_01 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ServiceCharacteristicsQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ServiceCharacteristicsQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ServiceCharacteristicsQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ServiceCharacteristicsQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ServiceCharacteristicsQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ServiceCharacteristicsQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ServiceCharacteristicsQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ServiceCharacteristicsQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ServiceCharacteristicsQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Service Characteristics Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ServiceCharacteristicsQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string AssignedIdentification_02 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RelationshipCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
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
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string RelationshipCode_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(28)]
        public string ProductServiceID_28 { get; set; }
    }
    
    /// <summary>
    /// Item Detail (Shipment)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SN1")]
    public class SN1 : I_SN1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string NumberofUnitsShipped_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity Shipped to Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string QuantityShippedtoDate_04 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string QuantityOrdered_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Returnable Container Load Make-Up Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ReturnableContainerLoadMakeUpCode_07 { get; set; }
        /// <summary>
        /// Line Item Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LineItemStatusCode_08 { get; set; }
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
        [Pos(1)]
        public string SecurityLevelCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// Entity Title
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string EntityTitle_04 { get; set; }
        /// <summary>
        /// Entity Purpose
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string EntityPurpose_05 { get; set; }
        /// <summary>
        /// Entity Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EntityStatusCode_06 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string TransactionSetPurposeCode_07 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReportTypeCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string AgencyQualifierCode_10 { get; set; }
        /// <summary>
        /// Source Subqualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string SourceSubqualifier_11 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string AssignedNumber_12 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string CertificationTypeCode_13 { get; set; }
        /// <summary>
        /// Proposal Data Detail Identifier Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ProposalDataDetailIdentifierCode_14 { get; set; }
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string HierarchicalStructureCode_15 { get; set; }
    }
    
    /// <summary>
    /// Shipment Purchase Order Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPO")]
    public class SPO : I_SPO
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string PurchaseOrderNumber_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string WeightUnitCode_05 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Weight_06 { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ApplicationErrorConditionCode_07 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ReferenceIdentification_08 { get; set; }
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
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Day Rotation
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DayRotation_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreeFormMessage_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
    }
    
    /// <summary>
    /// Transit Inbound Origin
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("T1")]
    public class T1 : I_T1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Waybill Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string WaybillNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string CityName_05 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string StateorProvinceCode_06 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardPointLocationCode_07 { get; set; }
        /// <summary>
        /// Transit Registration Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TransitRegistrationNumber_08 { get; set; }
        /// <summary>
        /// Transit Level Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TransitLevelCode_09 { get; set; }
    }
    
    /// <summary>
    /// Transit Inbound Lading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("T2")]
    public class T2 : I_T2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LadingDescription_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreightRate_05 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string RateValueQualifier_06 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string FreightRate_07 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string RateValueQualifier_08 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string CityName_09 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string CityName_10 { get; set; }
        /// <summary>
        /// Through Surcharge Percent
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string ThroughSurchargePercent_11 { get; set; }
        /// <summary>
        /// Paid-In Surcharge Percent
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string PaidInSurchargePercent_12 { get; set; }
    }
    
    /// <summary>
    /// Transit Inbound Route
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("T3")]
    public class T3 : I_T3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StandardCarrierAlphaCode_02 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RoutingSequenceCode_03 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CityName_04 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardPointLocationCode_05 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EquipmentInitial_06 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string EquipmentNumber_07 { get; set; }
    }
    
    /// <summary>
    /// Transit Inbound Rates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("T6")]
    public class T6 : I_T6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreightRate_02 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string RateValueQualifier_03 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CityName_04 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreightRate_05 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string RateValueQualifier_06 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CityName_07 { get; set; }
    }
    
    /// <summary>
    /// Free-form Transit Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("T8")]
    public class T8 : I_T8
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Free-form Transit Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeformTransitData_02 { get; set; }
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
        [Pos(1)]
        public string TaxIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string LocationQualifier_04 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string LocationIdentifier_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LocationIdentifier_07 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LocationQualifier_08 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string LocationIdentifier_09 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string LocationQualifier_10 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string LocationIdentifier_11 { get; set; }
        /// <summary>
        /// Tax Exempt Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string TaxExemptCode_12 { get; set; }
        /// <summary>
        /// Customs Entry Type Group Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string CommodityCodeQualifier_01 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string PackagingCode_01 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string LadingQuantity_02 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CommodityCodeQualifier_03 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string CommodityCode_04 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string LadingDescription_05 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string WeightQualifier_06 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Weight_07 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string UnitorBasisforMeasurementCode_08 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Volume_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string EquipmentDescriptionCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Weight_05 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UnitorBasisforMeasurementCode_06 { get; set; }
        /// <summary>
        /// Ownership Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string OwnershipCode_07 { get; set; }
        /// <summary>
        /// Seal Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string SealStatusCode_08 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SealNumber_09 { get; set; }
        /// <summary>
        /// Equipment Type
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Hazardous Material Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string HazardousMaterialCodeQualifier_02 { get; set; }
        /// <summary>
        /// Hazardous Material Class Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string HazardousMaterialClassCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Description_04 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string RoutingSequenceCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LocationQualifier_07 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
        /// <summary>
        /// Transit Direction Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TransitDirectionCode_09 { get; set; }
        /// <summary>
        /// Transit Time Direction Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string TransitTimeDirectionQualifier_10 { get; set; }
        /// <summary>
        /// Transit Time
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string TransitTime_11 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ServiceLevelCode_12 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string ServiceLevelCode_13 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string ServiceLevelCode_14 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Amount_01 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Amount_02 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Amount_03 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Amount_04 { get; set; }
    }
    
    /// <summary>
    /// Technical Error Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TED")]
    public class TED : I_TED
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ApplicationErrorConditionCode_01 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SegmentIDCode_03 { get; set; }
        /// <summary>
        /// Segment Position in Transaction Set
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SegmentPositioninTransactionSet_04 { get; set; }
        /// <summary>
        /// Element Position in Segment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ElementPositioninSegment_05 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string DataElementReferenceNumber_06 { get; set; }
        /// <summary>
        /// Copy of Bad Data Element
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CopyofBadDataElement_07 { get; set; }
        /// <summary>
        /// Data Element New Content
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string DataElementNewContent_08 { get; set; }
    }
    
    /// <summary>
    /// Trailer Shipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSD")]
    public class TSD : I_TSD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Position_02 { get; set; }
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
        [Pos(1)]
        public string TaxTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Percent_03 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TaxJurisdictionCode_05 { get; set; }
        /// <summary>
        /// Tax Exempt Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string TaxExemptCode_06 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string RelationshipCode_07 { get; set; }
        /// <summary>
        /// Dollar Basis For Percent
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string DollarBasisForPercent_08 { get; set; }
        /// <summary>
        /// Tax Identification Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TaxIdentificationNumber_09 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string VesselCode_01 { get; set; }
        /// <summary>
        /// Vessel Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string VesselName_02 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string CountryCode_03 { get; set; }
        /// <summary>
        /// Flight/Voyage Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string FlightVoyageNumber_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Vessel Requirement Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string VesselRequirementCode_06 { get; set; }
        /// <summary>
        /// Vessel Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string VesselTypeCode_07 { get; set; }
        /// <summary>
        /// Vessel Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string VesselCodeQualifier_08 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string TransportationMethodTypeCode_09 { get; set; }
    }
    
    /// <summary>
    /// Motor Vehicle Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VC")]
    public class VC : I_VC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle Identification Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string VehicleIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Vehicle Deck Position Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string VehicleDeckPositionCode_02 { get; set; }
        /// <summary>
        /// Vehicle Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string VehicleTypeCode_03 { get; set; }
        /// <summary>
        /// Dealer Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string DealerCode_04 { get; set; }
        /// <summary>
        /// Route Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string RouteCode_05 { get; set; }
        /// <summary>
        /// Bay Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string BayLocation_06 { get; set; }
        /// <summary>
        /// Automotive Manufacturers Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string AutomotiveManufacturersCode_07 { get; set; }
        /// <summary>
        /// Damage Exception Indicator
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string DamageExceptionIndicator_08 { get; set; }
        /// <summary>
        /// Supplemental Inspection Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SupplementalInspectionCode_09 { get; set; }
        /// <summary>
        /// Factory Car Order Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string FactoryCarOrderNumber_10 { get; set; }
        /// <summary>
        /// Vessel Stowage Location
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string VesselStowageLocation_11 { get; set; }
    }
    
    /// <summary>
    /// Total Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W03")]
    public class W03 : I_W03
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Weight_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Volume_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string LadingQuantity_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
    }
    
    /// <summary>
    /// Warehouse Shipment Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W06")]
    public class W06 : I_W06
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reporting Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ReportingCode_01 { get; set; }
        /// <summary>
        /// Depositor Order Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string DepositorOrderNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ShipmentIdentificationNumber_04 { get; set; }
        /// <summary>
        /// Agent Shipment ID Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string AgentShipmentIDNumber_05 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string PurchaseOrderNumber_06 { get; set; }
        /// <summary>
        /// Master Reference (Link) Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string MasterReferenceLinkNumber_07 { get; set; }
        /// <summary>
        /// Link Sequence Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string LinkSequenceNumber_08 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SpecialHandlingCode_09 { get; set; }
        /// <summary>
        /// Shipping Date Change Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string ShippingDateChangeReasonCode_10 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string TransactionTypeCode_11 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ActionCode_12 { get; set; }
    }
    
    /// <summary>
    /// Warehouse Additional Carrier Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W10")]
    public class W10 : I_W10
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit Load Option Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string UnitLoadOptionCode_01 { get; set; }
        /// <summary>
        /// Quantity of Pallets Shipped
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string QuantityofPalletsShipped_02 { get; set; }
        /// <summary>
        /// Pallet Exchange Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string PalletExchangeCode_03 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SealNumber_04 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string SealNumber_05 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Temperature_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Temperature_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
    }
    
    /// <summary>
    /// Warehouse Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W12")]
    public class W12 : I_W12
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ShipmentOrderStatusCode_01 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string QuantityOrdered_02 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string NumberofUnitsShipped_03 { get; set; }
        /// <summary>
        /// Quantity Difference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string QuantityDifference_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// U.P.C. Case Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string UPCCaseCode_06 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string ProductServiceIDQualifier_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Warehouse Lot Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string WarehouseLotNumber_09 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Weight_10 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string WeightQualifier_11 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string WeightUnitCode_12 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string Weight_13 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string WeightQualifier_14 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string WeightUnitCode_15 { get; set; }
        /// <summary>
        /// U.P.C. Case Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string UPCCaseCode_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Line Item Change Reason Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public string LineItemChangeReasonCode_19 { get; set; }
        /// <summary>
        /// Warehouse Detail Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public string WarehouseDetailAdjustmentIdentifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
    }
    
    /// <summary>
    /// Carrier Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W27")]
    public class W27 : I_W27
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string TransportationMethodTypeCode_01 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string StandardCarrierAlphaCode_02 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Routing_03 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string ShipmentMethodofPayment_04 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string EquipmentDescriptionCode_05 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EquipmentInitial_06 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string EquipmentNumber_07 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ShipmentOrderStatusCode_08 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string SpecialHandlingCode_09 { get; set; }
        /// <summary>
        /// Carrier/Route Change Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string CarrierRouteChangeReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Consolidation Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W28")]
    public class W28 : I_W28
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consolidation Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ConsolidationCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Weight_02 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string WeightQualifier_03 { get; set; }
        /// <summary>
        /// Weight Unit Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string WeightUnitCode_04 { get; set; }
        /// <summary>
        /// Total Stopoffs
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TotalStopoffs_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string LocationQualifier_07 { get; set; }
        /// <summary>
        /// Bill of Lading/Waybill Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string BillofLadingWaybillNumber_08 { get; set; }
    }
    
    /// <summary>
    /// Special Handling Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("W6")]
    public class W6 : I_W6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string SpecialHandlingCode_02 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SpecialHandlingCode_03 { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string SpecialHandlingCode_04 { get; set; }
    }
    
    /// <summary>
    /// Export License
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("X1")]
    public class X1 : I_X1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Licensing Agency Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string LicensingAgencyCode_01 { get; set; }
        /// <summary>
        /// Export License Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string ExportLicenseNumber_02 { get; set; }
        /// <summary>
        /// Export License Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string ExportLicenseStatusCode_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Export License Symbol Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string ExportLicenseSymbolCode_05 { get; set; }
        /// <summary>
        /// Export License Control Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ExportLicenseControlCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Schedule B Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string ScheduleBCode_08 { get; set; }
        /// <summary>
        /// International/Domestic Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string InternationalDomesticCode_09 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string LadingQuantity_10 { get; set; }
        /// <summary>
        /// Lading Value
        /// </summary>
        [DataMember]
        [Pos(11)]
        public string LadingValue_11 { get; set; }
        /// <summary>
        /// Export Filing Key Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string ExportFilingKeyCode_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(14)]
        public string UnitPrice_14 { get; set; }
        /// <summary>
        /// U.S. Government License Type
        /// </summary>
        [DataMember]
        [Pos(15)]
        public string USGovernmentLicenseType_15 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public string IdentificationCode_16 { get; set; }
    }
    
    /// <summary>
    /// Customs Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("X7")]
    public class X7 : I_X7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string FreeFormMessage_01 { get; set; }
        /// <summary>
        /// Free-Form Message
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }
    
    /// <summary>
    /// Pro Forma - B13 Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("XH")]
    public class XH : I_XH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string CurrencyCode_01 { get; set; }
        /// <summary>
        /// Related Company Indication Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string RelatedCompanyIndicationCode_02 { get; set; }
        /// <summary>
        /// Special Charge or Allowance Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string SpecialChargeorAllowanceCode_03 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Amount_04 { get; set; }
        /// <summary>
        /// Block 20 Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string BlockCode_05 { get; set; }
        /// <summary>
        /// Chemical Analysis Percentage
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string ChemicalAnalysisPercentage_06 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string UnitPrice_07 { get; set; }
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
        [Pos(1)]
        public string ConditionIndicator_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string YesNoConditionorResponseCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string FreeFormMessageText_05 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string FreeFormMessageText_06 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string FreeFormMessageText_07 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string CodeListQualifierCode_08 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string IndustryCode_09 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string FreeFormMessageText_10 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment For Data Correction Or Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ZC1")]
    public class ZC1 : I_ZC1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string ShipmentIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Transaction Reference Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string TransactionReferenceNumber_04 { get; set; }
        /// <summary>
        /// Transaction Reference Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string TransactionReferenceDate_05 { get; set; }
        /// <summary>
        /// Correction Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string CorrectionIndicator_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string TransportationMethodTypeCode_08 { get; set; }
    }
}
