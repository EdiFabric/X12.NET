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
    public class All_REF_276
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
        /// Application or Location System Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_ApplicationorLocationSystemIdentifier REF_ApplicationorLocationSystemIdentifier { get; set; }
        /// <summary>
        /// Group Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_GroupNumber REF_GroupNumber { get; set; }
        /// <summary>
        /// Patient Control Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_PatientControlNumber REF_PatientControlNumber { get; set; }
        /// <summary>
        /// Pharmacy Prescription Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_PharmacyPrescriptionNumber REF_PharmacyPrescriptionNumber { get; set; }
        /// <summary>
        /// Claim Identification Number For Clearinghouses and Other Transmission Intermediaries
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_276
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
        public virtual Loop_2100A_276 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000B_276> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_InformationReceiverLevel HL_InformationReceiverLevel { get; set; }
        /// <summary>
        /// Loop for Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100B_276 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Service Provider Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000C_276> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_ServiceProviderLevel))]
    public class Loop_2000C_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Provider Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_ServiceProviderLevel HL_ServiceProviderLevel { get; set; }
        /// <summary>
        /// Loop for Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2100C_276> Loop2100C { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000D_276> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000D_276
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
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DMG_DependentDemographicInformation_3 DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100D_276 Loop2100D { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2200D_276> Loop2200D { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2000E_276> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel_2))]
    public class Loop_2000E_276
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
        /// Dependent Demographic Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DMG_DependentDemographicInformation_3 DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100E_276 Loop2100E { get; set; }
        /// <summary>
        /// Loop for Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2200E_276> Loop2200E { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2100A_276
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
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_3))]
    public class Loop_2100B_276
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
    public class Loop_2100C_276
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
    public class Loop_2100D_276
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
    public class Loop_2100E_276
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
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200D_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_REF_276 AllREF { get; set; }
        /// <summary>
        /// Claim Submitted Charges
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges { get; set; }
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
        public virtual List<Loop_2210D_276> Loop2210D { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRN_ClaimStatusTrackingNumber))]
    public class Loop_2200E_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Status Tracking Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TRN_ClaimStatusTrackingNumber TRN_ClaimStatusTrackingNumber { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_REF_276 AllREF { get; set; }
        /// <summary>
        /// Claim Submitted Charges
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT_ClaimSubmittedCharges AMT_ClaimSubmittedCharges { get; set; }
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
        public virtual List<Loop_2210E_276> Loop2210E { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2210D_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServiceLineInformation))]
    public class Loop_2210E_276
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVC_ServiceLineInformation SVC_ServiceLineInformation { get; set; }
        /// <summary>
        /// Service Line Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_ServiceLineItemIdentification REF_ServiceLineItemIdentification { get; set; }
        /// <summary>
        /// Service Line Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceLineDate { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X212", "276")]
    public class TS276 : EdiMessage
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
        public virtual BHT_BeginningOfHierarchicalTransaction_3 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000A_276> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
