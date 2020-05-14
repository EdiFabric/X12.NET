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
    
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Institutional Bill Type Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_InstitutionalBillTypeIdentification REF_InstitutionalBillTypeIdentification { get; set; }
        /// <summary>
        /// Patient Control Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_PatientControlNumber REF_PatientControlNumber { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Voucher Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_VoucherIdentifier REF_VoucherIdentifier { get; set; }
        /// <summary>
        /// Claim Identification Number For Clearinghouses and Other Transmisson Intermediaries
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissonIntermediaries { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_277
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
        /// Loop for Payer Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100A_277 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000B_277> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel_2))]
    public class Loop_2000B_277
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
        /// Loop for Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100B_277 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Information Receiver Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2200B_277 Loop2200B { get; set; }
        /// <summary>
        /// Loop for Service Provider Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000C_277> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderOfServiceLevel))]
    public class Loop_2000C_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Provider Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_BillingProviderOfServiceLevel HL_ServiceProviderLevel { get; set; }
        /// <summary>
        /// Loop for Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2100C_277> Loop2100C { get; set; }
        /// <summary>
        /// Loop for Provider of Service Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2200C_277 Loop2200C { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000D_277> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000D_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_SubscriberHierarchicalLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100D_277 Loop2100D { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2200D_277> Loop2200D { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000E_277> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel_2))]
    public class Loop_2000E_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_DependentLevel_2 HL_DependentLevel { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100E_277 Loop2100E { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2200E_277> Loop2200E { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2100A_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerName NM1_PayerName { get; set; }
        /// <summary>
        /// Payer Contact Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_PayerContactInformation PER_PayerContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_3))]
    public class Loop_2100B_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationReceiverName_3 NM1_InformationReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ProviderName))]
    public class Loop_2100C_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ProviderName NM1_ProviderName { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_2))]
    public class Loop_2100D_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SubscriberName_2 NM1_SubscriberName { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2100E_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentName_2 NM1_DependentName { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Trace Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200B_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber_2 TRN_InformationReceiverTraceIdentifier { get; set; }
        /// <summary>
        /// Information Receiver Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation_5> STC_InformationReceiverStatusInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider of Service Trace Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200C_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider of Service Trace Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber TRN_ProviderofServiceTraceIdentifier { get; set; }
        /// <summary>
        /// Provider Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation_4> STC_ProviderStatusInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200D_277
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
        public virtual List<STC_ClaimLevelStatusInformation> STC_ClaimLevelStatusInformation { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_REF_277 AllREF { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2220D_277> Loop2220D { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber_2))]
    public class Loop_2200E_277
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
        public virtual List<STC_ClaimLevelStatusInformation> STC_ClaimLevelStatusInformation { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_REF_277 AllREF { get; set; }
        /// <summary>
        /// Claim Service Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimLevelServiceDate DTP_ClaimServiceDate { get; set; }
        /// <summary>
        /// Loop for Service Line Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2220E_277> Loop2220E { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServiceLineInformation_2))]
    public class Loop_2220D_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVC_ServiceLineInformation_2 SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation> STC_ServiceLineStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServiceLineInformation_2))]
    public class Loop_2220E_277
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVC_ServiceLineInformation_2 SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Status Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<STC_ClaimLevelStatusInformation> STC_ServiceLineStatusInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Information Status Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X212", "277")]
    public class TS277 : EdiMessage
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
        public virtual BHT_BeginningOfHierarchicalTransaction_4 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000A_277> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
