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
    public class All_AMT_270
    {
        
        /// <summary>
        /// Subscriber Spend Down Amount
        /// </summary>
        [Pos(1)]
        public AMT_SubscriberSpendDownAmount AMT_SubscriberSpendDownAmount { get; set; }
        /// <summary>
        /// Subscriber Spend Down Total Billed Amount
        /// </summary>
        [Pos(2)]
        public AMT_SubscriberSpendDownTotalBilledAmount AMT_SubscriberSpendDownTotalBilledAmount { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_270
    {
        
        /// <summary>
        /// Information Source Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Loop for Information Source Name
        /// </summary>
        [Pos(2)]
        public Loop_2100A_270 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000B_270> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_270
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
        public Loop_2100B_270 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000C_270> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_270
    {
        
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [Pos(1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Subscriber Trace Number
        /// </summary>
        [Pos(2)]
        public List<TRN_ClaimStatusTrackingNumber> TRN_SubscriberTraceNumber { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(3)]
        public Loop_2100C_270 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000D_270> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000D_270
    {
        
        /// <summary>
        /// Dependent Level
        /// </summary>
        [Pos(1)]
        public HL_DependentLevel HL_DependentLevel { get; set; }
        /// <summary>
        /// Dependent Trace Number
        /// </summary>
        [Pos(2)]
        public List<TRN_ClaimStatusTrackingNumber> TRN_DependentTraceNumber { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [Pos(3)]
        public Loop_2100D_270 Loop2100D { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationSourceName))]
    public class Loop_2100A_270
    {
        
        /// <summary>
        /// Information Source Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationSourceName NM1_InformationSourceName { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName))]
    public class Loop_2100B_270
    {
        
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationReceiverName NM1_InformationReceiverName { get; set; }
        /// <summary>
        /// Information Receiver Additional Identification
        /// </summary>
        [Pos(2)]
        public List<REF_InformationReceiverAdditionalIdentification> REF_InformationReceiverAdditionalIdentification { get; set; }
        /// <summary>
        /// Information Receiver Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_InformationReceiverAddress { get; set; }
        /// <summary>
        /// Information Receiver City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_InformationReceiverCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Information Receiver Provider Information
        /// </summary>
        [Pos(5)]
        public PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2100C_270
    {
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_InsuredName NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Additional Identification
        /// </summary>
        [Pos(2)]
        public List<REF_SubscriberAdditionalIdentification_2> REF_SubscriberAdditionalIdentification { get; set; }
        /// <summary>
        /// Subscriber Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress { get; set; }
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [Pos(5)]
        public PRV_ProviderInformation PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(6)]
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Multiple Birth Sequence Number
        /// </summary>
        [Pos(7)]
        public INS_MultipleBirthSequenceNumber INS_MultipleBirthSequenceNumber { get; set; }
        /// <summary>
        /// Subscriber Health Care Diagnosis Code
        /// </summary>
        [Pos(8)]
        public HI_DependentHealthCareDiagnosisCode HI_SubscriberHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Subscriber Date
        /// </summary>
        [Pos(9)]
        public List<DTP_DependentDate> DTP_SubscriberDate { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Inquiry
        /// </summary>
        [Pos(10)]
        public List<Loop_2110C_270> Loop2110C { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName))]
    public class Loop_2100D_270
    {
        
        /// <summary>
        /// Dependent Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Additional Identification
        /// </summary>
        [Pos(2)]
        public List<REF_DependentAdditionalIdentification_2> REF_DependentAdditionalIdentification { get; set; }
        /// <summary>
        /// Dependent Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_DependentAddress { get; set; }
        /// <summary>
        /// Dependent City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_DependentCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [Pos(5)]
        public PRV_ProviderInformation PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [Pos(6)]
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [Pos(7)]
        public INS_DependentRelationship INS_DependentRelationship { get; set; }
        /// <summary>
        /// Dependent Health Care Diagnosis Code
        /// </summary>
        [Pos(8)]
        public HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Dependent Date
        /// </summary>
        [Pos(9)]
        public List<DTP_DependentDate> DTP_DependentDate { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Inquiry
        /// </summary>
        [Pos(10)]
        public List<Loop_2110D_270> Loop2110D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [Group(typeof(EQ_DependentEligibilityorBenefitInquiry))]
    public class Loop_2110C_270
    {
        
        /// <summary>
        /// Subscriber Eligibility or Benefit Inquiry
        /// </summary>
        [Pos(1)]
        public EQ_DependentEligibilityorBenefitInquiry EQ_SubscriberEligibilityorBenefitInquiry { get; set; }
        [Pos(2)]
        public All_AMT_270 AllAMT { get; set; }
        /// <summary>
        /// Subscriber Eligibility or Benefit Additional Inquiry Information
        /// </summary>
        [Pos(3)]
        public III_DependentEligibilityorBenefitAdditionalInquiryInformation III_SubscriberEligibilityorBenefitAdditionalInquiryInformation { get; set; }
        /// <summary>
        /// Subscriber Additional Information
        /// </summary>
        [Pos(4)]
        public REF_DependentAdditionalInformation REF_SubscriberAdditionalInformation { get; set; }
        /// <summary>
        /// Subscriber Eligibility/Benefit Date
        /// </summary>
        [Pos(5)]
        public DTP_DependentEligibility DTP_SubscriberEligibility_BenefitDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [Group(typeof(EQ_DependentEligibilityorBenefitInquiry))]
    public class Loop_2110D_270
    {
        
        /// <summary>
        /// Dependent Eligibility or Benefit Inquiry
        /// </summary>
        [Pos(1)]
        public EQ_DependentEligibilityorBenefitInquiry EQ_DependentEligibilityorBenefitInquiry { get; set; }
        /// <summary>
        /// Dependent Eligibility or Benefit Additional Inquiry Information
        /// </summary>
        [Pos(2)]
        public III_DependentEligibilityorBenefitAdditionalInquiryInformation III_DependentEligibilityorBenefitAdditionalInquiryInformation { get; set; }
        /// <summary>
        /// Dependent Additional Information
        /// </summary>
        [Pos(3)]
        public REF_DependentAdditionalInformation REF_DependentAdditionalInformation { get; set; }
        /// <summary>
        /// Dependent Eligibility/Benefit Date
        /// </summary>
        [Pos(4)]
        public DTP_DependentEligibility DTP_DependentEligibility_BenefitDate { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X279A1", "270")]
    public class TS270 : EdiMessage
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
        public BHT_BeginningofHierarchicalTransaction BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000A_270> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
