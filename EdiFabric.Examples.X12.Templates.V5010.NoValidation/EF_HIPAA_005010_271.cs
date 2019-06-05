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
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_271
    {
        
        /// <summary>
        /// Information Source Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [Pos(2)]
        public List<AAA_DependentRequestValidation> AAA_RequestValidation { get; set; }
        /// <summary>
        /// Loop for Information Source Name
        /// </summary>
        [Pos(3)]
        public Loop_2100A_271 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000B_271> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_271
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
        public Loop_2100B_271 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000C_271> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_271
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
        public List<TRN_DependentTraceNumber> TRN_SubscriberTraceNumber { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(3)]
        public Loop_2100C_271 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000D_271> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000D_271
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
        public List<TRN_DependentTraceNumber> TRN_DependentTraceNumber { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [Pos(3)]
        public Loop_2100D_271 Loop2100D { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationSourceName))]
    public class Loop_2100A_271
    {
        
        /// <summary>
        /// Information Source Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationSourceName NM1_InformationSourceName { get; set; }
        /// <summary>
        /// Information Source Contact Information
        /// </summary>
        [Pos(2)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_InformationSourceContactInformation { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [Pos(3)]
        public List<AAA_DependentRequestValidation> AAA_RequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName))]
    public class Loop_2100B_271
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
        /// Information Receiver Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation> AAA_InformationReceiverRequestValidation { get; set; }
        /// <summary>
        /// Information Receiver Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2100C_271
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
        public List<REF_SubscriberAdditionalIdentification_3> REF_SubscriberAdditionalIdentification { get; set; }
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
        /// Subscriber Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_ProviderInformation_2 PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(7)]
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [Pos(8)]
        public INS_MultipleBirthSequenceNumber INS_SubscriberRelationship { get; set; }
        /// <summary>
        /// Subscriber Health Care Diagnosis Code
        /// </summary>
        [Pos(9)]
        public HI_DependentHealthCareDiagnosisCode HI_SubscriberHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Subscriber Date
        /// </summary>
        [Pos(10)]
        public List<DTP_DependentDate_2> DTP_SubscriberDate { get; set; }
        /// <summary>
        /// Subscriber Military Personnel Information
        /// </summary>
        [Pos(11)]
        public MPI_DependentMilitaryPersonnelInformation MPI_SubscriberMilitaryPersonnelInformation { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Information
        /// </summary>
        [Pos(12)]
        public List<Loop_2110C_271> Loop2110C { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName))]
    public class Loop_2100D_271
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
        public List<REF_DependentAdditionalIdentification_3> REF_DependentAdditionalIdentification { get; set; }
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
        /// Dependent Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_ProviderInformation_2 PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [Pos(7)]
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [Pos(8)]
        public INS_DependentRelationship_2 INS_DependentRelationship { get; set; }
        /// <summary>
        /// Dependent Health Care Diagnosis Code
        /// </summary>
        [Pos(9)]
        public HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Dependent Date
        /// </summary>
        [Pos(10)]
        public List<DTP_DependentDate_2> DTP_DependentDate { get; set; }
        /// <summary>
        /// Dependent Military Personnel Information
        /// </summary>
        [Pos(11)]
        public MPI_DependentMilitaryPersonnelInformation MPI_DependentMilitaryPersonnelInformation { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Information
        /// </summary>
        [Pos(12)]
        public List<Loop_2110D_271> Loop2110D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [Group(typeof(EB_SubscriberEligibilityorBenefitInformation))]
    public class Loop_2110C_271
    {
        
        /// <summary>
        /// Subscriber Eligibility or Benefit Information
        /// </summary>
        [Pos(1)]
        public EB_SubscriberEligibilityorBenefitInformation EB_SubscriberEligibilityorBenefitInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(2)]
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Subscriber Additional Identification
        /// </summary>
        [Pos(3)]
        public List<REF_SubscriberAdditionalIdentification> REF_SubscriberAdditionalIdentification { get; set; }
        /// <summary>
        /// Subscriber Eligibility/Benefit Date
        /// </summary>
        [Pos(4)]
        public List<DTP_DependentEligibility_2> DTP_SubscriberEligibility_BenefitDate { get; set; }
        /// <summary>
        /// Subscriber Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(6)]
        public List<MSG_MessageText> MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Additional Information
        /// </summary>
        [Pos(7)]
        public List<Loop_2115C_271> Loop2115C { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [Pos(8)]
        public Loop_LS_271_2 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [Group(typeof(EB_DependentEligibilityorBenefitInformation))]
    public class Loop_2110D_271
    {
        
        /// <summary>
        /// Dependent Eligibility or Benefit Information
        /// </summary>
        [Pos(1)]
        public EB_DependentEligibilityorBenefitInformation EB_DependentEligibilityorBenefitInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(2)]
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Dependent Additional Identification
        /// </summary>
        [Pos(3)]
        public List<REF_DependentAdditionalIdentification> REF_DependentAdditionalIdentification { get; set; }
        /// <summary>
        /// Dependent Eligibility/Benefit Date
        /// </summary>
        [Pos(4)]
        public List<DTP_DependentEligibility_2> DTP_DependentEligibility_BenefitDate { get; set; }
        /// <summary>
        /// Dependent Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(6)]
        public List<MSG_MessageText> MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Additional Information
        /// </summary>
        [Pos(7)]
        public List<Loop_2115D_271> Loop2115D { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [Pos(8)]
        public Loop_LS_271 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [Group(typeof(III_DependentEligibilityorBenefitAdditionalInformation))]
    public class Loop_2115C_271
    {
        
        /// <summary>
        /// Subscriber Eligibility or Benefit Additional Information
        /// </summary>
        [Pos(1)]
        public III_DependentEligibilityorBenefitAdditionalInformation III_SubscriberEligibilityorBenefitAdditionalInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [Group(typeof(III_DependentEligibilityorBenefitAdditionalInformation))]
    public class Loop_2115D_271
    {
        
        /// <summary>
        /// Dependent Eligibility or Benefit Additional Information
        /// </summary>
        [Pos(1)]
        public III_DependentEligibilityorBenefitAdditionalInformation III_DependentEligibilityorBenefitAdditionalInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentBenefitRelatedEntityName))]
    public class Loop_2120C_271
    {
        
        /// <summary>
        /// Subscriber Benefit Related Entity Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentBenefitRelatedEntityName NM1_SubscriberBenefitRelatedEntityName { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberBenefitRelatedEntityAddress { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_SubscriberBenefitRelatedEntityCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity Contact Information
        /// </summary>
        [Pos(4)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_SubscriberBenefitRelatedEntityContactInformation { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Provider Information
        /// </summary>
        [Pos(5)]
        public PRV_DependentBenefitRelatedProviderInformation PRV_SubscriberBenefitRelatedProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentBenefitRelatedEntityName))]
    public class Loop_2120D_271
    {
        
        /// <summary>
        /// Dependent Benefit Related Entity Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentBenefitRelatedEntityName NM1_DependentBenefitRelatedEntityName { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_DependentBenefitRelatedEntityAddress { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_DependentBenefitRelatedEntityCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity Contact Information
        /// </summary>
        [Pos(4)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_DependentBenefitRelatedEntityContactInformation { get; set; }
        /// <summary>
        /// Dependent Benefit Related Provider Information
        /// </summary>
        [Pos(5)]
        public PRV_DependentBenefitRelatedProviderInformation PRV_DependentBenefitRelatedProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_271
    {
        
        /// <summary>
        /// Header
        /// </summary>
        [Pos(1)]
        public LS_AdditionalReportingCategories LS_Header { get; set; }
        /// <summary>
        /// Loop for Dependent Benefit Related Entity Name
        /// </summary>
        [Pos(2)]
        public List<Loop_2120D_271> Loop2120D { get; set; }
        /// <summary>
        /// Trailer
        /// </summary>
        [Pos(3)]
        public LE_AdditionalReportingCategoriesTermination LE_Trailer { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_271_2
    {
        
        /// <summary>
        /// Header
        /// </summary>
        [Pos(1)]
        public LS_AdditionalReportingCategories LS_Header { get; set; }
        /// <summary>
        /// Loop for Subscriber Benefit Related Entity Name
        /// </summary>
        [Pos(2)]
        public List<Loop_2120C_271> Loop2120C { get; set; }
        /// <summary>
        /// Trailer
        /// </summary>
        [Pos(3)]
        public LE_AdditionalReportingCategoriesTermination LE_Trailer { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Information
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X279A1", "271")]
    public class TS271 : EdiMessage
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
        public BHT_BeginningofHierarchicalTransaction_2 BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000A_271> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
