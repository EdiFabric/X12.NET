namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    /// <summary>
    /// Information Source Level Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_277A
    {
        
        /// <summary>
        /// Information Source Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Information Source Name Loop
        /// </summary>
        [Pos(2)]
        public Loop_2100A_277A Loop2100A { get; set; }
        /// <summary>
        /// Transmission Receipt Control Identifier Loop
        /// </summary>
        [Pos(3)]
        public Loop_2200A_277A Loop2200A { get; set; }
        /// <summary>
        /// Information Receiver Level Loop
        /// </summary>
        [Pos(4)]
        public Loop_2000B_277A Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Level Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_277A
    {
        
        /// <summary>
        /// Information Receiver Level
        /// </summary>
        [Pos(1)]
        public HL_InformationReceiverLevel HL_InformationReceiverLevel { get; set; }
        /// <summary>
        /// Information Receiver Name Loop
        /// </summary>
        [Pos(2)]
        public Loop_2100B_277A Loop2100B { get; set; }
        /// <summary>
        /// Information Receiver Application Trace Identifier Loop
        /// </summary>
        [Pos(3)]
        public Loop_2200B_277A Loop2200B { get; set; }
        /// <summary>
        /// Billing Provider Of Service Level Loop
        /// </summary>
        [Pos(4)]
        public List<Loop_2000C_277A> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Of Service Level Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderOfServiceLevel))]
    public class Loop_2000C_277A
    {
        
        /// <summary>
        /// Billing Provider Of Service Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderOfServiceLevel HL_BillingProviderOfServiceLevel { get; set; }
        /// <summary>
        /// Billing Provider Name Loop
        /// </summary>
        [Pos(2)]
        public Loop_2100C_277A Loop2100C { get; set; }
        /// <summary>
        /// Provider Of Service Information Trace Identifier Loop
        /// </summary>
        [Pos(3)]
        public Loop_2200C_277A Loop2200C { get; set; }
        /// <summary>
        /// Patient Level Loop
        /// </summary>
        [Pos(4)]
        public List<Loop_2000D_277A> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Patient Level Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_PatientLevel))]
    public class Loop_2000D_277A
    {
        
        /// <summary>
        /// Patient Level
        /// </summary>
        [Pos(1)]
        public HL_PatientLevel HL_PatientLevel { get; set; }
        /// <summary>
        /// Patient Name Loop
        /// </summary>
        [Pos(2)]
        public Loop_2100D_277A Loop2100D { get; set; }
        /// <summary>
        /// Claim Status Tracking Number Loop
        /// </summary>
        [Pos(3)]
        public List<Loop_2200D_277A> Loop2200D { get; set; }
    }
    
    /// <summary>
    /// Information Source Name Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationSourceName_2))]
    public class Loop_2100A_277A
    {
        
        /// <summary>
        /// Information Source Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationSourceName_2 NM1_InformationSourceName { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_2100B_277A
    {
        
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationReceiverName_2 NM1_InformationReceiverName { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2100C_277A
    {
        
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
    }
    
    /// <summary>
    /// Patient Name Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2100D_277A
    {
        
        /// <summary>
        /// Patient Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_2 NM1_PatientName { get; set; }
    }
    
    /// <summary>
    /// Transmission Receipt Control Identifier Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200A_277A
    {
        
        /// <summary>
        /// Transmission Receipt Control Identifier
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber TRN_TransmissionReceiptControlIdentifier { get; set; }
        /// <summary>
        /// Information Source Receipt Date
        /// </summary>
        [Pos(2)]
        public DTP_RepricerReceivedDate DTP_InformationSourceReceiptDate { get; set; }
        /// <summary>
        /// Information Source Process Date
        /// </summary>
        [Pos(3)]
        public DTP_InformationSourceProcessDate DTP_InformationSourceProcessDate { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Application Trace Identifier Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200B_277A
    {
        
        /// <summary>
        /// Information Receiver Application Trace Identifier
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber_2 TRN_InformationReceiverApplicationTraceIdentifier { get; set; }
        /// <summary>
        /// Information Receiver Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_InformationReceiverStatusInformation { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [Pos(3)]
        public QTY_TotalAcceptedQuantity_2 QTY_TotalAcceptedQuantity { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [Pos(4)]
        public QTY_TotalRejectedQuantity_2 QTY_TotalRejectedQuantity { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [Pos(5)]
        public AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [Pos(6)]
        public AMT_TotalRejectedAmount AMT_TotalRejectedAmount { get; set; }
    }
    
    /// <summary>
    /// Provider Of Service Information Trace Identifier Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200C_277A
    {
        
        /// <summary>
        /// Provider Of Service Information Trace Identifier
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber TRN_ProviderOfServiceInformationTraceIdentifier { get; set; }
        /// <summary>
        /// Billing Provider Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_BillingProviderStatusInformation { get; set; }
        /// <summary>
        /// Provider Secondary Identifier
        /// </summary>
        [Pos(3)]
        public List<REF_ProviderSecondaryIdentifier> REF_ProviderSecondaryIdentifier { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [Pos(4)]
        public QTY_TotalAcceptedQuantity QTY_TotalAcceptedQuantity { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [Pos(5)]
        public QTY_TotalRejectedQuantity QTY_TotalRejectedQuantity { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [Pos(6)]
        public AMT_TotalAcceptedAmount AMT_TotalAcceptedAmount { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [Pos(7)]
        public AMT_TotalRejectedAmount AMT_TotalRejectedAmount { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200D_277A
    {
        
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber_2 TRN_ClaimStatusTrackingNumber { get; set; }
        /// <summary>
        /// Claim Level Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_ClaimLevelStatusInformation { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [Pos(3)]
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [Pos(4)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Institutional Bill Type Identification
        /// </summary>
        [Pos(5)]
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification { get; set; }
        /// <summary>
        /// Claim Level Service Date
        /// </summary>
        [Pos(6)]
        public DTP_ClaimLevelServiceDate DTP_ClaimLevelServiceDate { get; set; }
        /// <summary>
        /// Service Line Information Loop
        /// </summary>
        [Pos(7)]
        public List<Loop_2220D_277A> Loop2220D { get; set; }
    }
    
    /// <summary>
    /// Service Line Information Loop
    /// </summary>
    [Serializable()]
    [Group(typeof(SVC_ServiceLineInformation_2))]
    public class Loop_2220D_277A
    {
        
        /// <summary>
        /// Service Line Information
        /// </summary>
        [Pos(1)]
        public SVC_ServiceLineInformation_2 SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Level Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_ServiceLineLevelStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [Pos(3)]
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [Pos(4)]
        public REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [Pos(5)]
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Acknowledgment
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X214", "277")]
    public class TS277A : EdiMessage
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [Pos(2)]
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Information Source Level Loop
        /// </summary>
        [Pos(3)]
        public Loop_2000A_277A Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
