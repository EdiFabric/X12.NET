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
    public class All_CRC_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Certification Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CRC_AmbulanceCertificationInformation CRC_AmbulanceCertificationInformation { get; set; }
        /// <summary>
        /// Chiropractic Certification Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CRC_ChiropracticCertificationInformation CRC_ChiropracticCertificationInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CRC_DurableMedicalEquipmentInformation CRC_DurableMedicalEquipmentInformation { get; set; }
        /// <summary>
        /// Oxygen Therapy Certification Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CRC_OxygenTherapyCertificationInformation CRC_OxygenTherapyCertificationInformation { get; set; }
        /// <summary>
        /// Functional Limitations Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CRC_FunctionalLimitationsInformation CRC_FunctionalLimitationsInformation { get; set; }
        /// <summary>
        /// Activities Permitted Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CRC_ActivitiesPermittedInformation CRC_ActivitiesPermittedInformation { get; set; }
        /// <summary>
        /// Mental Status Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CRC_MentalStatusInformation CRC_MentalStatusInformation { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_ClaimLevelServiceDate DTP_ServiceDate { get; set; }
        /// <summary>
        /// Certification Issue Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_CertificationIssueDate DTP_CertificationIssueDate { get; set; }
        /// <summary>
        /// Certification Expiration Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_CertificationExpirationDate DTP_CertificationExpirationDate { get; set; }
        /// <summary>
        /// Certification Effective Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Accident Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_AccidentDate DTP_AccidentDate { get; set; }
        /// <summary>
        /// Last Menstrual Period Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_LastMenstrualPeriodDate DTP_LastMenstrualPeriodDate { get; set; }
        /// <summary>
        /// Estimated Date of Birth
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_EstimatedDateofBirth DTP_EstimatedDateofBirth { get; set; }
        /// <summary>
        /// Onset of Current Symptoms or Illness Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_OnsetofCurrentSymptomsorIllnessDate DTP_OnsetofCurrentSymptomsorIllnessDate { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_EventDate DTP_EventDate { get; set; }
        /// <summary>
        /// Admission Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_AdmissionDate_2 DTP_AdmissionDate { get; set; }
        /// <summary>
        /// Discharge Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP_DischargeDate DTP_DischargeDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_278_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Accident Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_AccidentDate_2 DTP_AccidentDate { get; set; }
        /// <summary>
        /// Last Menstrual Period Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_LastMenstrualPeriod DTP_LastMenstrualPeriodDate { get; set; }
        /// <summary>
        /// Estimated Date of Birth
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_EstimatedDateofBirth_2 DTP_EstimatedDateofBirth { get; set; }
        /// <summary>
        /// Onset of Current Symptoms or Illness Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_OnsetofCurrentIllnessorSymptom DTP_OnsetofCurrentSymptomsorIllnessDate { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_EventDate_2 DTP_EventDate { get; set; }
        /// <summary>
        /// Admission Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_AdmissionDate_3 DTP_AdmissionDate { get; set; }
        /// <summary>
        /// Discharge Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP_Discharge DTP_DischargeDate { get; set; }
        /// <summary>
        /// Certification Issue Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP_CertificationIssueDate DTP_CertificationIssueDate { get; set; }
        /// <summary>
        /// Certification Expiration Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DTP_CertificationExpirationDate DTP_CertificationExpirationDate { get; set; }
        /// <summary>
        /// Certification Effective Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<Loop_2010FA_278> Loop2010FA { get; set; }
        /// <summary>
        /// Loop for Additional Service Information Contact Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010FB_278 Loop2010FB { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Patient Event Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<Loop_2010EA_278> Loop2010EA { get; set; }
        /// <summary>
        /// Loop for Patient Event Transport Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2010EB_278> Loop2010EB { get; set; }
        /// <summary>
        /// Loop for Patient Event Other UMO Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2010EC_278> Loop2010EC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_278_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Patient Event Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<Loop_2010EA_278_2> Loop2010EA { get; set; }
        /// <summary>
        /// Loop for Additional Patient Information Contact Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010EB_278_2 Loop2010EB { get; set; }
        /// <summary>
        /// Loop for Patient Event Transport Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2010EC_278_2> Loop2010EC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Previous Review Authorization Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_PreviousReviewAuthorizationNumber REF_PreviousReviewAuthorizationNumber { get; set; }
        /// <summary>
        /// Previous Review Administrative Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_PreviousReviewAdministrativeReferenceNumber REF_PreviousReviewAdministrativeReferenceNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administrative Reference Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_AdministrativeReferenceNumber REF_AdministrativeReferenceNumber { get; set; }
        /// <summary>
        /// Previous Review Authorization Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_PreviousReviewAuthorizationNumber_2 REF_PreviousReviewAuthorizationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_UtilizationManagementOrganization))]
    public class Loop_2000A_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_UtilizationManagementOrganization HL_UtilizationManagementOrganization_UMO_Level { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010A_278 Loop2010A { get; set; }
        /// <summary>
        /// Loop for Requester Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000B_278 Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationSourceLevel))]
    public class Loop_2000A_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_InformationSourceLevel HL_UtilizationManagementOrganization_UMO_Level { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AAA_RequestValidation_3> AAA_RequestValidation { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2010A_278_2 Loop2010A { get; set; }
        /// <summary>
        /// Loop for Requester Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2000B_278_2 Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_RequesterLevel))]
    public class Loop_2000B_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requester Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_RequesterLevel HL_RequesterLevel { get; set; }
        /// <summary>
        /// Loop for Requester Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010B_278 Loop2010B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000C_278 Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_InformationReceiverLevel_2))]
    public class Loop_2000B_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requester Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_InformationReceiverLevel_2 HL_RequesterLevel { get; set; }
        /// <summary>
        /// Loop for Requester Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2010B_278_2> Loop2010B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000C_278_2 Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberLevel))]
    public class Loop_2000C_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_SubscriberLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010C_278 Loop2010C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000D_278 Loop2000D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2000E_278 Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_278_2
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
        public virtual Loop_2010C_278_2 Loop2010C { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000E_278_2> Loop2000E { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2000D_278_2 Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel_3))]
    public class Loop_2000D_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_DependentLevel_3 HL_DependentLevel { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010D_278 Loop2010D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2000E_278 Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel_4))]
    public class Loop_2000D_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_DependentLevel_4 HL_DependentLevel { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010D_278_2 Loop2010D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2000E_278_2> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_PatientEventLevel))]
    public class Loop_2000E_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_PatientEventLevel HL_PatientEventLevel { get; set; }
        /// <summary>
        /// Patient Event Tracking Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_PatientEventTrackingNumber> TRN_PatientEventTrackingNumber { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual UM_HealthCareServicesReviewInformation_3 UM_HealthCareServicesReviewInformation { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_278 AllREF { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_DTP_278_2 AllDTP { get; set; }
        /// <summary>
        /// Patient Diagnosis
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual HI_PatientDiagnosis HI_PatientDiagnosis { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual All_CRC_278 AllCRC { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CL1_InstitutionalClaimCode_2 CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation { get; set; }
        /// <summary>
        /// Home Oxygen Therapy Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CR5_HomeOxygenTherapyInformation CR5_HomeOxygenTherapyInformation { get; set; }
        /// <summary>
        /// Home Health Care Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CR6_HomeHealthCareInformation CR6_HomeHealthCareInformation { get; set; }
        /// <summary>
        /// Additional Patient Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<PWK_AdditionalPatientInformation> PWK_AdditionalPatientInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual MSG_MessageText_2 MSG_MessageText { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual All_NM1_278_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Service Level
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_2000F_278> Loop2000F { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_PatientEventLevel_2))]
    public class Loop_2000E_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_PatientEventLevel_2 HL_PatientEventLevel { get; set; }
        /// <summary>
        /// Patient Event Tracking Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_DependentTraceNumber_2> TRN_PatientEventTrackingNumber { get; set; }
        /// <summary>
        /// Patient Event Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AAA_PatientEventRequestValidation> AAA_PatientEventRequestValidation { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual UM_HealthCareServicesReviewInformation_4 UM_HealthCareServicesReviewInformation { get; set; }
        /// <summary>
        /// Health Care Services Review
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual HCR_HealthCareServicesReview_2 HCR_HealthCareServicesReview { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_REF_278_2 AllREF { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_DTP_278_3 AllDTP { get; set; }
        /// <summary>
        /// Patient Diagnosis
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HI_PatientDiagnosis_2 HI_PatientDiagnosis { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual HSD_HealthCareServicesDelivery_4 HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CL1_InstitutionalClaimCode_3 CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CR2_SpinalManipulationServiceInformation_3 CR2_SpinalManipulationServiceInformation { get; set; }
        /// <summary>
        /// Home Oxygen Therapy Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CR5_HomeOxygenTherapyInformation_2 CR5_HomeOxygenTherapyInformation { get; set; }
        /// <summary>
        /// Home Health Care Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual CR6_HomeHealthCareInformation_2 CR6_HomeHealthCareInformation { get; set; }
        /// <summary>
        /// Additional Patient Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<PWK_AdditionalPatientInformation_2> PWK_AdditionalPatientInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual MSG_MessageText MSG_MessageText { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual All_NM1_278_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Service Level
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_2000F_278_2> Loop2000F { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_ServiceLevel))]
    public class Loop_2000F_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_ServiceLevel HL_ServiceLevel { get; set; }
        /// <summary>
        /// Service Trace Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_PatientEventTrackingNumber> TRN_ServiceTraceNumber { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual UM_HealthCareServicesReviewInformation UM_HealthCareServicesReviewInformation { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_278 AllREF { get; set; }
        /// <summary>
        /// Service Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_ServiceDate_2 DTP_ServiceDate { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SV1_ProfessionalService_2 SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SV2_InstitutionalServiceLine_2 SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SV3_DentalService_2 SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<TOO_ToothInformation_2> TOO_ToothInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Additional Service Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<PWK_AdditionalPatientInformation> PWK_AdditionalServiceInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual MSG_MessageText_2 MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_2010F_278> Loop2010F { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_ServiceLevel_2))]
    public class Loop_2000F_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_ServiceLevel_2 HL_ServiceLevel { get; set; }
        /// <summary>
        /// Service Trace Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TRN_DependentTraceNumber_2> TRN_ServiceTraceNumber { get; set; }
        /// <summary>
        /// Service Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AAA_ServiceRequestValidation> AAA_ServiceRequestValidation { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual UM_HealthCareServicesReviewInformation_2 UM_HealthCareServicesReviewInformation { get; set; }
        /// <summary>
        /// Health Care Services Review
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual HCR_HealthCareServicesReview HCR_HealthCareServicesReview { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_REF_278_2 AllREF { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_DTP_278 AllDTP { get; set; }
        /// <summary>
        /// Request For Additional Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HI_RequestForAdditionalInformation HI_RequestForAdditionalInformation { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SV1_ProfessionalService_3 SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SV2_InstitutionalServiceLine_3 SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SV3_DentalService_3 SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<TOO_ToothInformation> TOO_ToothInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual HSD_HealthCareServicesDelivery_3 HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Additional Service Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<PWK_AdditionalPatientInformation_2> PWK_AdditionalServiceInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual MSG_MessageText MSG_MessageText { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual All_NM1_278 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_UtilizationManagementOrganization))]
    public class Loop_2010A_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_UtilizationManagementOrganization NM1_UtilizationManagementOrganization_UMO_Name { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_UtilizationManagementOrganization_2))]
    public class Loop_2010A_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_UtilizationManagementOrganization_2 NM1_UtilizationManagementOrganization_UMO_Name { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Contact Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_AdditionalServiceInformationContactInformation PER_UtilizationManagementOrganization_UMO_ContactInformation { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AAA_UtilizationManagementOrganization> AAA_UtilizationManagementOrganization_UMO_RequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RequesterName))]
    public class Loop_2010B_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requester Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_RequesterName NM1_RequesterName { get; set; }
        /// <summary>
        /// Requester Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_RequesterSupplementalIdentification> REF_RequesterSupplementalIdentification { get; set; }
        /// <summary>
        /// Requester Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_RequesterAddress { get; set; }
        /// <summary>
        /// Requester City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_DependentCity N4_RequesterCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Requester Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_PatientEventProviderContactInformation PER_RequesterContactInformation { get; set; }
        /// <summary>
        /// Requester Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_RequesterProviderInformation PRV_RequesterProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RequesterName_2))]
    public class Loop_2010B_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requester Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_RequesterName_2 NM1_RequesterName { get; set; }
        /// <summary>
        /// Requester Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_RequesterSupplementalIdentification_2> REF_RequesterSupplementalIdentification { get; set; }
        /// <summary>
        /// Requester Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AAA_RequesterRequestValidation> AAA_RequesterRequestValidation { get; set; }
        /// <summary>
        /// Requester Provider Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRV_RequesterProviderInformation_2 PRV_RequesterProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_3))]
    public class Loop_2010C_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SubscriberName_3 NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_SubscriberSupplementalIdentification> REF_SubscriberSupplementalIdentification { get; set; }
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
        public virtual N4_DependentCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG_DependentDemographicInformation_4 DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual INS_SubscriberRelationship_2 INS_SubscriberRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_4))]
    public class Loop_2010C_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SubscriberName_4 NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_SubscriberSupplementalIdentification_2> REF_SubscriberSupplementalIdentification { get; set; }
        /// <summary>
        /// Subscriber Mailing Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_SubscriberMailingAddress { get; set; }
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
        public virtual List<AAA_SubscriberRequestValidation_2> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG_DependentDemographicInformation_5 DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual INS_SubscriberRelationship_3 INS_SubscriberRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentName_3))]
    public class Loop_2010D_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentName_3 NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_DependentSupplementalIdentification> REF_DependentSupplementalIdentification { get; set; }
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
        public virtual N4_DependentCity N4_DependentCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG_DependentDemographicInformation_4 DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual INS_DependentRelationship_3 INS_DependentRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DependentName_4))]
    public class Loop_2010D_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dependent Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DependentName_4 NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_DependentSupplementalIdentification_2> REF_DependentSupplementalIdentification { get; set; }
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
        public virtual List<AAA_DependentRequestValidation_3> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG_DependentDemographicInformation_5 DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual INS_DependentRelationship_4 INS_DependentRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientEventProviderName))]
    public class Loop_2010EA_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientEventProviderName NM1_PatientEventProviderName { get; set; }
        /// <summary>
        /// Patient Event Provider Supplemental Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_PatientEventProviderSupplementalInformation> REF_PatientEventProviderSupplementalInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress { get; set; }
        /// <summary>
        /// Patient Event Provider City, State, Zip Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_DependentCity N4_PatientEventProviderCity_State_ZipCode { get; set; }
        /// <summary>
        /// Patient Event Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_PatientEventProviderContactInformation PER_PatientEventProviderContactInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_PatientEventProviderInformation PRV_PatientEventProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientEventProviderName_2))]
    public class Loop_2010EA_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientEventProviderName_2 NM1_PatientEventProviderName { get; set; }
        /// <summary>
        /// Patient Event Provider Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_PatientEventProviderSupplementalIdentification> REF_PatientEventProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Patient Event Provider Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress { get; set; }
        /// <summary>
        /// Patient Event Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PatientEventProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_AdditionalServiceInformationContactInformation PER_ProviderContactInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Request Validation
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AAA_PatientEventProviderRequestValidation> AAA_PatientEventProviderRequestValidation { get; set; }
        /// <summary>
        /// Patient Event Provider Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PRV_PatientEventProviderInformation_2 PRV_PatientEventProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientEventTransportInformation))]
    public class Loop_2010EB_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Transport Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientEventTransportInformation NM1_PatientEventTransportInformation { get; set; }
        /// <summary>
        /// Patient Event Transport Location Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress { get; set; }
        /// <summary>
        /// Patient Event Transport Location City/State/ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_PatientEventTransportLocationCity N4_PatientEventTransportLocationCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Patient Information Contact Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AdditionalPatientInformationContactName))]
    public class Loop_2010EB_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Additional Patient Information Contact Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_AdditionalPatientInformationContactName NM1_AdditionalPatientInformationContactName { get; set; }
        /// <summary>
        /// Additional Patient Information Contact Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AdditionalPatientInformationContactAddress { get; set; }
        /// <summary>
        /// Additional Patient Information Contact City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AdditionalPatientInformationContactCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Additional Patient Information Contact Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER_AdditionalPatientInformationContactInformation PER_AdditionalPatientInformationContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Other UMO Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientEventOtherUMOName))]
    public class Loop_2010EC_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Other UMO Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientEventOtherUMOName NM1_PatientEventOtherUMOName { get; set; }
        /// <summary>
        /// Other UMO Denial Reason
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_OtherUMODenialReason REF_OtherUMODenialReason { get; set; }
        /// <summary>
        /// Other UMO Denial Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_OtherUMODenialDate DTP_OtherUMODenialDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientEventTransportInformation_2))]
    public class Loop_2010EC_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Event Transport Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientEventTransportInformation_2 NM1_PatientEventTransportInformation { get; set; }
        /// <summary>
        /// Patient Event Transport Location Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress { get; set; }
        /// <summary>
        /// Patient Event Transport Location City/State/ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_PatientEventTransportLocationCity_2 N4_PatientEventTransportLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Event Transport Location Request Validation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<AAA_PatientEventTransportLocationRequestValidation> AAA_PatientEventTransportLocationRequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceProviderName))]
    public class Loop_2010F_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ServiceProviderName NM1_ServiceProviderName { get; set; }
        /// <summary>
        /// Service Provider Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_PatientEventProviderSupplementalInformation> REF_ServiceProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Service Provider Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress { get; set; }
        /// <summary>
        /// Service Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_DependentCity N4_ServiceProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_PatientEventProviderContactInformation PER_ServiceProviderContactInformation { get; set; }
        /// <summary>
        /// Service Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV_ServiceProviderInformation PRV_ServiceProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceProviderName_2))]
    public class Loop_2010FA_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ServiceProviderName_2 NM1_ServiceProviderName { get; set; }
        /// <summary>
        /// Service Provider Supplemental Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_ServiceProviderSupplementalIdentification> REF_ServiceProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Service Provider Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress { get; set; }
        /// <summary>
        /// Service Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_AdditionalServiceInformationContactInformation PER_ServiceProviderContactInformation { get; set; }
        /// <summary>
        /// Service Provider Request Validation
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AAA_PatientEventProviderRequestValidation> AAA_ServiceProviderRequestValidation { get; set; }
        /// <summary>
        /// Service Provider Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PRV_ServiceProviderInformation_2 PRV_ServiceProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Service Information Contact Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AdditionalPatientInformationContactName))]
    public class Loop_2010FB_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Additional Service Information Contact Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_AdditionalPatientInformationContactName NM1_AdditionalServiceInformationContactName { get; set; }
        /// <summary>
        /// Additional Service Information Contact Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AdditionalServiceInformationContactAddress { get; set; }
        /// <summary>
        /// Additional Service Information Contact City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AdditionalServiceInformationContactCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Additional Service Information Contact Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER_AdditionalServiceInformationContactInformation PER_AdditionalServiceInformationContactInformation { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(BHT_BeginningOfHierarchicalTransaction_6))]
    public class Loop_BHT_278
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual BHT_BeginningOfHierarchicalTransaction_6 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Level
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2000A_278 Loop2000A { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(BHT_BeginningOfHierarchicalTransaction_7))]
    public class Loop_BHT_278_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual BHT_BeginningOfHierarchicalTransaction_7 BHT_BeginningOfHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Level
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2000A_278_2 Loop2000A { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information - Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X217", "278")]
    public class TS278 : EdiMessage
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
        [DataMember]
        [Pos(2)]
        public virtual Loop_BHT_278 LoopBHT { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual Loop_BHT_278_2 LoopBHT2 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
