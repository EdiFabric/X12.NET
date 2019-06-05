namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    [Serializable()]
    [All()]
    public class All_REF_277
    {
        
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [Pos(1)]
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Institutional Bill Type Identification
        /// </summary>
        [Pos(2)]
        public REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification { get; set; }
        /// <summary>
        /// Patient Control Number
        /// </summary>
        [Pos(3)]
        public REF_PatientControlNumber REF_PatientControlNumber { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [Pos(4)]
        public REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Voucher Identifier
        /// </summary>
        [Pos(5)]
        public REF_VoucherIdentifier REF_VoucherIdentifier { get; set; }
        /// <summary>
        /// Claim Identification Number For Clearinghouses and Other Transmisson Intermediaries
        /// </summary>
        [Pos(6)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissonIntermediaries { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_277
    {
        
        /// <summary>
        /// Information Source Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2100A_277 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000B_277> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_277
    {
        
        /// <summary>
        /// Information Receiver Level
        /// </summary>
        [Pos(1)]
        public HL_InformationReceiverLevel HL_InformationReceiverLevel { get; set; }
        /// <summary>
        /// Loop for Information Receiver Name
        /// </summary>
        [Pos(2)]
        public Loop_2100B_277 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Information Receiver Trace Identifier
        /// </summary>
        [Pos(3)]
        public Loop_2200B_277 Loop2200B { get; set; }
        /// <summary>
        /// Loop for Service Provider Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000C_277> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderOfServiceLevel))]
    public class Loop_2000C_277
    {
        
        /// <summary>
        /// Service Provider Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderOfServiceLevel HL_ServiceProviderLevel { get; set; }
        /// <summary>
        /// Loop for Provider Name
        /// </summary>
        [Pos(2)]
        public List<Loop_2100C_277> Loop2100C { get; set; }
        /// <summary>
        /// Loop for Provider of Service Trace Identifier
        /// </summary>
        [Pos(3)]
        public Loop_2200C_277 Loop2200C { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000D_277> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000D_277
    {
        
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [Pos(1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(2)]
        public Loop_2100D_277 Loop2100D { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [Pos(3)]
        public List<Loop_2200D_277> Loop2200D { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000E_277> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000E_277
    {
        
        /// <summary>
        /// Dependent Level
        /// </summary>
        [Pos(1)]
        public HL_DependentLevel HL_DependentLevel { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [Pos(2)]
        public Loop_2100E_277 Loop2100E { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [Pos(3)]
        public List<Loop_2200E_277> Loop2200E { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2100A_277
    {
        
        /// <summary>
        /// Payer Name
        /// </summary>
        [Pos(1)]
        public NM1_CorrectedPriorityPayerName NM1_PayerName { get; set; }
        /// <summary>
        /// Payer Contact Information
        /// </summary>
        [Pos(2)]
        public PER_AdditionalPatientInformationContactInformation PER_PayerContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_2100B_277
    {
        
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationReceiverName_2 NM1_InformationReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ProviderName))]
    public class Loop_2100C_277
    {
        
        /// <summary>
        /// Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_ProviderName NM1_ProviderName { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2100D_277
    {
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_InsuredName NM1_SubscriberName { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2100E_277
    {
        
        /// <summary>
        /// Dependent Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_2 NM1_DependentName { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Trace Identifier
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200B_277
    {
        
        /// <summary>
        /// Information Receiver Trace Identifier
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber_2 TRN_InformationReceiverTraceIdentifier { get; set; }
        /// <summary>
        /// Information Receiver Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_InformationReceiverStatusInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider of Service Trace Identifier
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200C_277
    {
        
        /// <summary>
        /// Provider of Service Trace Identifier
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber TRN_ProviderofServiceTraceIdentifier { get; set; }
        /// <summary>
        /// Provider Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_ProviderStatusInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200D_277
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
        [Pos(3)]
        public All_REF_277 AllREF { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2220D_277> Loop2220D { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200E_277
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
        [Pos(3)]
        public All_REF_277 AllREF { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2220E_277> Loop2220E { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2220D_277
    {
        
        /// <summary>
        /// Service Line Information
        /// </summary>
        [Pos(1)]
        public SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_ServiceLineStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [Pos(3)]
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2220E_277
    {
        
        /// <summary>
        /// Service Line Information
        /// </summary>
        [Pos(1)]
        public SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Status Information
        /// </summary>
        [Pos(2)]
        public List<STC_BillingProviderStatusInformation> STC_ServiceLineStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [Pos(3)]
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Information Status Notification
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X212", "277")]
    public class TS277 : EdiMessage
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
        public BHT_BeginningofHierarchicalTransaction_4 BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000A_277> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
