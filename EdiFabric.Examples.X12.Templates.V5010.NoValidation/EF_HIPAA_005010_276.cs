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
    public class All_REF_276
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
        /// Application or Location System Identifier
        /// </summary>
        [Pos(3)]
        public REF_ApplicationorLocationSystemIdentifier REF_ApplicationorLocationSystemIdentifier { get; set; }
        /// <summary>
        /// Group Number
        /// </summary>
        [Pos(4)]
        public REF_GroupNumber REF_GroupNumber { get; set; }
        /// <summary>
        /// Patient Control Number
        /// </summary>
        [Pos(5)]
        public REF_PatientControlNumber REF_PatientControlNumber { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [Pos(6)]
        public REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Claim Identification Number For Clearinghouses and Other Transmission Intermediaries
        /// </summary>
        [Pos(7)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_276
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
        public Loop_2100A_276 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000B_276> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_276
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
        public Loop_2100B_276 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Service Provider Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000C_276> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderOfServiceLevel))]
    public class Loop_2000C_276
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
        public List<Loop_2100C_276> Loop2100C { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000D_276> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000D_276
    {
        
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [Pos(1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(2)]
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(3)]
        public Loop_2100D_276 Loop2100D { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [Pos(4)]
        public List<Loop_2200D_276> Loop2200D { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000E_276> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000E_276
    {
        
        /// <summary>
        /// Dependent Level
        /// </summary>
        [Pos(1)]
        public HL_DependentLevel HL_DependentLevel { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [Pos(2)]
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [Pos(3)]
        public Loop_2100E_276 Loop2100E { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [Pos(4)]
        public List<Loop_2200E_276> Loop2200E { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2100A_276
    {
        
        /// <summary>
        /// Payer Name
        /// </summary>
        [Pos(1)]
        public NM1_CorrectedPriorityPayerName NM1_PayerName { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_2100B_276
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
    public class Loop_2100C_276
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
    public class Loop_2100D_276
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
    public class Loop_2100E_276
    {
        
        /// <summary>
        /// Dependent Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_2 NM1_DependentName { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200D_276
    {
        
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber { get; set; }
        [Pos(2)]
        public All_REF_276 AllREF { get; set; }
        /// <summary>
        /// Claim Submitted Charges
        /// </summary>
        [Pos(3)]
        public AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2210D_276> Loop2210D { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200E_276
    {
        
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [Pos(1)]
        public TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber { get; set; }
        [Pos(2)]
        public All_REF_276 AllREF { get; set; }
        /// <summary>
        /// Claim Submitted Charges
        /// </summary>
        [Pos(3)]
        public AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2210E_276> Loop2210E { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2210D_276
    {
        
        /// <summary>
        /// Service Line Information
        /// </summary>
        [Pos(1)]
        public SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [Pos(2)]
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [Pos(3)]
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2210E_276
    {
        
        /// <summary>
        /// Service Line Information
        /// </summary>
        [Pos(1)]
        public SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [Pos(2)]
        public REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [Pos(3)]
        public DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status Request
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X212", "276")]
    public class TS276 : EdiMessage
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
        public BHT_BeginningofHierarchicalTransaction_3 BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000A_276> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
