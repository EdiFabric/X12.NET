namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Information Source Level Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Source Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Information Source Name Loop
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100A_277A Loop2100A { get; set; }
        /// <summary>
        /// Transmission Receipt Control Identifier Loop
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2200A_277A Loop2200A { get; set; }
        /// <summary>
        /// Information Receiver Level Loop
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2000B_277A Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Level Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel_2))]
    public class Loop_2000B_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_InformationReceiverLevel_2 HL_InformationReceiverLevel { get; set; }
        /// <summary>
        /// Information Receiver Name Loop
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100B_277A Loop2100B { get; set; }
        /// <summary>
        /// Information Receiver Application Trace Identifier Loop
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2200B_277A Loop2200B { get; set; }
        /// <summary>
        /// Billing Provider Of Service Level Loop
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000C_277A> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Of Service Level Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderOfServiceLevel))]
    public class Loop_2000C_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Of Service Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_BillingProviderOfServiceLevel HL_BillingProviderOfServiceLevel { get; set; }
        /// <summary>
        /// Billing Provider Name Loop
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100C_277A Loop2100C { get; set; }
        /// <summary>
        /// Provider Of Service Information Trace Identifier Loop
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2200C_277A Loop2200C { get; set; }
        /// <summary>
        /// Patient Level Loop
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000D_277A> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Patient Level Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_PatientLevel))]
    public class Loop_2000D_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_PatientLevel HL_PatientLevel { get; set; }
        /// <summary>
        /// Patient Name Loop
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100D_277A Loop2100D { get; set; }
        /// <summary>
        /// Claim Status Tracking Number Loop
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2200D_277A> Loop2200D { get; set; }
    }
    
    /// <summary>
    /// Information Source Name Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationSourceName_2))]
    public class Loop_2100A_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Source Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationSourceName_2 NM1_InformationSourceName { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_4))]
    public class Loop_2100B_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationReceiverName_4 NM1_InformationReceiverName { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2100C_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_BillingProviderName NM1_BillingProviderName { get; set; }
    }
    
    /// <summary>
    /// Patient Name Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientName))]
    public class Loop_2100D_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientName NM1_PatientName { get; set; }
    }
    
    /// <summary>
    /// Transmission Receipt Control Identifier Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200A_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transmission Receipt Control Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber TRN_TransmissionReceiptControlIdentifier { get; set; }
        /// <summary>
        /// Information Source Receipt Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_RepricerReceivedDate DTP_InformationSourceReceiptDate { get; set; }
        /// <summary>
        /// Information Source Process Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_InformationSourceProcessDate DTP_InformationSourceProcessDate { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Application Trace Identifier Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200B_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Application Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber_2 TRN_InformationReceiverApplicationTraceIdentifier { get; set; }
        /// <summary>
        /// Information Receiver Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation_2> STC_InformationReceiverStatusInformation { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY_TotalAcceptedQuantity_2 QTY_TotalAcceptedQuantity { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY_TotalRejectedQuantity_2 QTY_TotalRejectedQuantity { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AMT_TotalRejectedAmount AMT_TotalRejectedAmount { get; set; }
    }
    
    /// <summary>
    /// Provider Of Service Information Trace Identifier Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200C_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider Of Service Information Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber TRN_ProviderOfServiceInformationTraceIdentifier { get; set; }
        /// <summary>
        /// Billing Provider Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_BillingProviderStatusInformation> STC_BillingProviderStatusInformation { get; set; }
        /// <summary>
        /// Provider Secondary Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_ProviderSecondaryIdentifier> REF_ProviderSecondaryIdentifier { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY_TotalAcceptedQuantity QTY_TotalAcceptedQuantity { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY_TotalRejectedQuantity QTY_TotalRejectedQuantity { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AMT_TotalRejectedAmount AMT_TotalRejectedAmount { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200D_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber_2 TRN_ClaimStatusTrackingNumber { get; set; }
        /// <summary>
        /// Claim Level Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation_2> STC_ClaimLevelStatusInformation { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Institutional Bill Type Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification { get; set; }
        /// <summary>
        /// Claim Level Service Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_ClaimLevelServiceDate DTP_ClaimLevelServiceDate { get; set; }
        /// <summary>
        /// Service Line Information Loop
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2220D_277A> Loop2220D { get; set; }
    }
    
    /// <summary>
    /// Service Line Information Loop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServiceLineInformation_3))]
    public class Loop_2220D_277A
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVC_ServiceLineInformation_3 SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Level Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ServiceLineLevelStatusInformation> STC_ServiceLineLevelStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X214", "277")]
    public class TS277A : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual BHT_BeginningOfHierarchicalTransaction_5 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Information Source Level Loop
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000A_277A Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
