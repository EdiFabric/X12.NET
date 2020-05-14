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
    /// Loop for Information Source Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationSourceLevel))]
    public class Loop_2000A_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Source Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_InformationSourceLevel HL_InformationSourceLevel { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AAA_RequestValidation_2> AAA_RequestValidation { get; set; }
        /// <summary>
        /// Loop for Information Source Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100A_271 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Information Receiver Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000B_271> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel_2))]
    public class Loop_2000B_271
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
        public virtual Loop_2100B_271 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000C_271> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_271
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
        public virtual List<TRN_DependentTraceNumber_2> TRN_SubscriberTraceNumber { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100C_271 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000D_271> Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000D_271
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
        public virtual List<TRN_DependentTraceNumber_2> TRN_DependentTraceNumber { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100D_271 Loop2100D { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Source Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationSourceName))]
    public class Loop_2100A_271
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
        /// <summary>
        /// Information Source Contact Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PER_InformationSourceContactInformation> PER_InformationSourceContactInformation { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AAA_RequestValidation> AAA_RequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_2100B_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Receiver Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationReceiverName_2 NM1_InformationReceiverName { get; set; }
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
        /// Information Receiver Request Validation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AAA_InformationReceiverRequestValidation> AAA_InformationReceiverRequestValidation { get; set; }
        /// <summary>
        /// Information Receiver Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_DependentBenefitRelatedProviderInformation PRV_InformationReceiverProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName))]
    public class Loop_2100C_271
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
        public virtual List<REF_SubscriberAdditionalIdentification_3> REF_SubscriberAdditionalIdentification { get; set; }
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
        /// Subscriber Request Validation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AAA_SubscriberRequestValidation> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_ProviderInformation_2 PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DMG_DependentDemographicInformation_2 DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual INS_SubscriberRelationship INS_SubscriberRelationship { get; set; }
        /// <summary>
        /// Subscriber Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual HI_DependentHealthCareDiagnosisCode_3 HI_SubscriberHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Subscriber Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DTP_EligibilityOrBenefitDate> DTP_SubscriberDate { get; set; }
        /// <summary>
        /// Subscriber Military Personnel Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual MPI_DependentMilitaryPersonnelInformation MPI_SubscriberMilitaryPersonnelInformation { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_2110C_271> Loop2110C { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentName))]
    public class Loop_2100D_271
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
        public virtual List<REF_DependentAdditionalIdentification_3> REF_DependentAdditionalIdentification { get; set; }
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
        /// Dependent Request Validation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AAA_DependentRequestValidation_2> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_ProviderInformation_2 PRV_ProviderInformation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DMG_DependentDemographicInformation_2 DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual INS_DependentRelationship_2 INS_DependentRelationship { get; set; }
        /// <summary>
        /// Dependent Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual HI_DependentHealthCareDiagnosisCode HI_DependentHealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Dependent Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DTP_EligibilityOrBenefitDate> DTP_DependentDate { get; set; }
        /// <summary>
        /// Dependent Military Personnel Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual MPI_DependentMilitaryPersonnelInformation MPI_DependentMilitaryPersonnelInformation { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_2110D_271> Loop2110D { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EB_SubscriberEligibilityorBenefitInformation))]
    public class Loop_2110C_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EB_SubscriberEligibilityorBenefitInformation EB_SubscriberEligibilityorBenefitInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Subscriber Additional Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_SubscriberAdditionalIdentification> REF_SubscriberAdditionalIdentification { get; set; }
        /// <summary>
        /// Subscriber Eligibility/Benefit Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP_DependentEligibility_2> DTP_SubscriberEligibility_BenefitDate { get; set; }
        /// <summary>
        /// Subscriber Request Validation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AAA_DependentRequestValidation> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MSG_MessageText> MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Subscriber Eligibility or Benefit Additional Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2115C_271> Loop2115C { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_LS_271_2 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EB_DependentEligibilityorBenefitInformation))]
    public class Loop_2110D_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EB_DependentEligibilityorBenefitInformation EB_DependentEligibilityorBenefitInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Dependent Additional Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_DependentAdditionalIdentification> REF_DependentAdditionalIdentification { get; set; }
        /// <summary>
        /// Dependent Eligibility/Benefit Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP_DependentEligibility_2> DTP_DependentEligibility_BenefitDate { get; set; }
        /// <summary>
        /// Dependent Request Validation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AAA_DependentRequestValidation> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MSG_MessageText> MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Dependent Eligibility or Benefit Additional Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2115D_271> Loop2115D { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_LS_271 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(III_DependentEligibilityorBenefitAdditionalInformation))]
    public class Loop_2115C_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Eligibility or Benefit Additional Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual III_DependentEligibilityorBenefitAdditionalInformation III_SubscriberEligibilityorBenefitAdditionalInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(III_DependentEligibilityorBenefitAdditionalInformation))]
    public class Loop_2115D_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Eligibility or Benefit Additional Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual III_DependentEligibilityorBenefitAdditionalInformation III_DependentEligibilityorBenefitAdditionalInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentBenefitRelatedEntityName))]
    public class Loop_2120C_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentBenefitRelatedEntityName NM1_SubscriberBenefitRelatedEntityName { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_SubscriberBenefitRelatedEntityAddress { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_DependentBenefitRelatedEntityCity N4_SubscriberBenefitRelatedEntityCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Entity Contact Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PER_DependentBenefitRelatedEntityContactInformation> PER_SubscriberBenefitRelatedEntityContactInformation { get; set; }
        /// <summary>
        /// Subscriber Benefit Related Provider Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRV_DependentBenefitRelatedProviderInformation PRV_SubscriberBenefitRelatedProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentBenefitRelatedEntityName))]
    public class Loop_2120D_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentBenefitRelatedEntityName NM1_DependentBenefitRelatedEntityName { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_DependentBenefitRelatedEntityAddress { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_DependentBenefitRelatedEntityCity N4_DependentBenefitRelatedEntityCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Dependent Benefit Related Entity Contact Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PER_DependentBenefitRelatedEntityContactInformation> PER_DependentBenefitRelatedEntityContactInformation { get; set; }
        /// <summary>
        /// Dependent Benefit Related Provider Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRV_DependentBenefitRelatedProviderInformation PRV_DependentBenefitRelatedProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LS_AdditionalReportingCategories LS_Header { get; set; }
        /// <summary>
        /// Loop for Dependent Benefit Related Entity Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2120D_271> Loop2120D { get; set; }
        /// <summary>
        /// Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LE_AdditionalReportingCategoriesTermination LE_Trailer { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_271_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LS_AdditionalReportingCategories LS_Header { get; set; }
        /// <summary>
        /// Loop for Subscriber Benefit Related Entity Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2120C_271> Loop2120C { get; set; }
        /// <summary>
        /// Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LE_AdditionalReportingCategoriesTermination LE_Trailer { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X279A1", "271")]
    public class TS271 : EdiMessage
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
        public virtual BHT_BeginningOfHierarchicalTransaction_2 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Information Source Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000A_271> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
