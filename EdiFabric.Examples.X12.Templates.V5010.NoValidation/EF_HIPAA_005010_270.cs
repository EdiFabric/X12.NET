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
    public class All_AMT_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Spend Down Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AMT_SubscriberSpendDownAmount AMT_SubscriberSpendDownAmount { get; set; }
        /// <summary>
        /// Subscriber Spend Down Total Billed Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT_SubscriberSpendDownTotalBilledAmount AMT_SubscriberSpendDownTotalBilledAmount { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_270
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
        /// Loop for Information Source Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100A_270 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000B_270> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_270
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
        public virtual Loop_2100B_270 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000C_270> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_270
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
        /// Subscriber Trace Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_DependentTraceNumber> TRN_SubscriberTraceNumber { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100C_270 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000D_270> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000D_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_DependentLevel HL_DependentLevel { get; set; }
        /// <summary>
        /// Dependent Trace Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_DependentTraceNumber> TRN_DependentTraceNumber { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100D_270 Loop2100D { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationSourceName))]
    public class Loop_2100A_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Source Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationSourceName NM1_InformationSourceName { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName))]
    public class Loop_2100B_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationReceiverName NM1_InformationReceiverName { get; set; }
        /// <summary>
        /// Information Receiver Additional Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_InformationReceiverAdditionalIdentification> REF_InformationReceiverAdditionalIdentification { get; set; }
        /// <summary>
        /// Information Receiver Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_InformationReceiverAddress { get; set; }
        /// <summary>
        /// Information Receiver City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_InformationReceiverCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Information Receiver Provider Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName))]
    public class Loop_2100C_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SubscriberName NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Additional Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_SubscriberAdditionalIdentification_2> REF_SubscriberAdditionalIdentification { get; set; }
        /// <summary>
        /// Subscriber Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress { get; set; }
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRV_ProviderInformation PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Multiple Birth Sequence Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual INS_MultipleBirthSequenceNumber INS_MultipleBirthSequenceNumber { get; set; }
        /// <summary>
        /// Subscriber Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HI_DependentHealthCareDiagnosisCode HI_SubscriberHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Subscriber Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<DTP_SubscriberOrDependentDate> DTP_SubscriberDate { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_2110C_270> Loop2110C { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentName))]
    public class Loop_2100D_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentName NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Additional Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_DependentAdditionalIdentification_2> REF_DependentAdditionalIdentification { get; set; }
        /// <summary>
        /// Dependent Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_DependentAddress { get; set; }
        /// <summary>
        /// Dependent City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_DependentCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRV_ProviderInformation PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG_DependentDemographicInformation DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual INS_DependentRelationship INS_DependentRelationship { get; set; }
        /// <summary>
        /// Dependent Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Dependent Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<DTP_SubscriberOrDependentDate> DTP_DependentDate { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_2110D_270> Loop2110D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQ_SubscriberEligibilityorBenefitInquiry))]
    public class Loop_2110C_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EQ_SubscriberEligibilityorBenefitInquiry EQ_SubscriberEligibilityorBenefitInquiry { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_AMT_270 AllAMT { get; set; }
        /// <summary>
        /// Subscriber Eligibility or Benefit Additional Inquiry Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual III_DependentEligibilityorBenefitAdditionalInquiryInformation III_SubscriberEligibilityorBenefitAdditionalInquiryInformation { get; set; }
        /// <summary>
        /// Subscriber Additional Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_DependentAdditionalInformation REF_SubscriberAdditionalInformation { get; set; }
        /// <summary>
        /// Subscriber Eligibility/Benefit Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_DependentEligibility DTP_SubscriberEligibility_BenefitDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQ_DependentEligibilityorBenefitInquiry))]
    public class Loop_2110D_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EQ_DependentEligibilityorBenefitInquiry EQ_DependentEligibilityorBenefitInquiry { get; set; }
        /// <summary>
        /// Dependent Eligibility or Benefit Additional Inquiry Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual III_DependentEligibilityorBenefitAdditionalInquiryInformation III_DependentEligibilityorBenefitAdditionalInquiryInformation { get; set; }
        /// <summary>
        /// Dependent Additional Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_DependentAdditionalInformation REF_DependentAdditionalInformation { get; set; }
        /// <summary>
        /// Dependent Eligibility/Benefit Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_DependentEligibility DTP_DependentEligibility_BenefitDate { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X279A1", "270")]
    public class TS270 : EdiMessage
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
        public virtual BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000A_270> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
