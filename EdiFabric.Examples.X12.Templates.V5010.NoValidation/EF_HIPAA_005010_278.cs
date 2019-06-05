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
    public class All_CRC_278
    {
        
        /// <summary>
        /// Ambulance Certification Information
        /// </summary>
        [Pos(1)]
        public CRC_AmbulanceCertificationInformation CRC_AmbulanceCertificationInformation { get; set; }
        /// <summary>
        /// Chiropractic Certification Information
        /// </summary>
        [Pos(2)]
        public CRC_ChiropracticCertificationInformation CRC_ChiropracticCertificationInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Information
        /// </summary>
        [Pos(3)]
        public CRC_DurableMedicalEquipmentInformation CRC_DurableMedicalEquipmentInformation { get; set; }
        /// <summary>
        /// Oxygen Therapy Certification Information
        /// </summary>
        [Pos(4)]
        public CRC_OxygenTherapyCertificationInformation CRC_OxygenTherapyCertificationInformation { get; set; }
        /// <summary>
        /// Functional Limitations Information
        /// </summary>
        [Pos(5)]
        public CRC_FunctionalLimitationsInformation CRC_FunctionalLimitationsInformation { get; set; }
        /// <summary>
        /// Activities Permitted Information
        /// </summary>
        [Pos(6)]
        public CRC_ActivitiesPermittedInformation CRC_ActivitiesPermittedInformation { get; set; }
        /// <summary>
        /// Mental Status Information
        /// </summary>
        [Pos(7)]
        public CRC_MentalStatusInformation CRC_MentalStatusInformation { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_278
    {
        
        /// <summary>
        /// Service Date
        /// </summary>
        [Pos(1)]
        public DTP_ClaimLevelServiceDate DTP_ServiceDate { get; set; }
        /// <summary>
        /// Certification Issue Date
        /// </summary>
        [Pos(2)]
        public DTP_CertificationIssueDate DTP_CertificationIssueDate { get; set; }
        /// <summary>
        /// Certification Expiration Date
        /// </summary>
        [Pos(3)]
        public DTP_CertificationExpirationDate DTP_CertificationExpirationDate { get; set; }
        /// <summary>
        /// Certification Effective Date
        /// </summary>
        [Pos(4)]
        public DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_278_2
    {
        
        /// <summary>
        /// Accident Date
        /// </summary>
        [Pos(1)]
        public DTP_AccidentDate DTP_AccidentDate { get; set; }
        /// <summary>
        /// Last Menstrual Period Date
        /// </summary>
        [Pos(2)]
        public DTP_LastMenstrualPeriodDate DTP_LastMenstrualPeriodDate { get; set; }
        /// <summary>
        /// Estimated Date of Birth
        /// </summary>
        [Pos(3)]
        public DTP_EstimatedDateofBirth DTP_EstimatedDateofBirth { get; set; }
        /// <summary>
        /// Onset of Current Symptoms or Illness Date
        /// </summary>
        [Pos(4)]
        public DTP_OnsetofCurrentSymptomsorIllnessDate DTP_OnsetofCurrentSymptomsorIllnessDate { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [Pos(5)]
        public DTP_EventDate DTP_EventDate { get; set; }
        /// <summary>
        /// Admission Date
        /// </summary>
        [Pos(6)]
        public DTP_AdmissionDate_2 DTP_AdmissionDate { get; set; }
        /// <summary>
        /// Discharge Date
        /// </summary>
        [Pos(7)]
        public DTP_DischargeDate DTP_DischargeDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_278_3
    {
        
        /// <summary>
        /// Accident Date
        /// </summary>
        [Pos(1)]
        public DTP_AccidentDate_2 DTP_AccidentDate { get; set; }
        /// <summary>
        /// Last Menstrual Period Date
        /// </summary>
        [Pos(2)]
        public DTP_LastMenstrualPeriod DTP_LastMenstrualPeriodDate { get; set; }
        /// <summary>
        /// Estimated Date of Birth
        /// </summary>
        [Pos(3)]
        public DTP_EstimatedDateofBirth_2 DTP_EstimatedDateofBirth { get; set; }
        /// <summary>
        /// Onset of Current Symptoms or Illness Date
        /// </summary>
        [Pos(4)]
        public DTP_OnsetofCurrentIllnessorSymptom DTP_OnsetofCurrentSymptomsorIllnessDate { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [Pos(5)]
        public DTP_EventDate_2 DTP_EventDate { get; set; }
        /// <summary>
        /// Admission Date
        /// </summary>
        [Pos(6)]
        public DTP_AdmissionDate_3 DTP_AdmissionDate { get; set; }
        /// <summary>
        /// Discharge Date
        /// </summary>
        [Pos(7)]
        public DTP_Discharge DTP_DischargeDate { get; set; }
        /// <summary>
        /// Certification Issue Date
        /// </summary>
        [Pos(8)]
        public DTP_CertificationIssueDate DTP_CertificationIssueDate { get; set; }
        /// <summary>
        /// Certification Expiration Date
        /// </summary>
        [Pos(9)]
        public DTP_CertificationExpirationDate DTP_CertificationExpirationDate { get; set; }
        /// <summary>
        /// Certification Effective Date
        /// </summary>
        [Pos(10)]
        public DTP_CertificationEffectiveDate DTP_CertificationEffectiveDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_278
    {
        
        /// <summary>
        /// Loop for Service Provider Name
        /// </summary>
        [Pos(1)]
        public List<Loop_2010FA_278> Loop2010FA { get; set; }
        /// <summary>
        /// Loop for Additional Service Information Contact Name
        /// </summary>
        [Pos(2)]
        public Loop_2010FB_278 Loop2010FB { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_278_2
    {
        
        /// <summary>
        /// Loop for Patient Event Provider Name
        /// </summary>
        [Pos(1)]
        public List<Loop_2010EA_278> Loop2010EA { get; set; }
        /// <summary>
        /// Loop for Patient Event Transport Information
        /// </summary>
        [Pos(2)]
        public List<Loop_2010EB_278> Loop2010EB { get; set; }
        /// <summary>
        /// Loop for Patient Event Other UMO Name
        /// </summary>
        [Pos(3)]
        public List<Loop_2010EC_278> Loop2010EC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_278_3
    {
        
        /// <summary>
        /// Loop for Patient Event Provider Name
        /// </summary>
        [Pos(1)]
        public List<Loop_2010EA_278_2> Loop2010EA { get; set; }
        /// <summary>
        /// Loop for Additional Patient Information Contact Name
        /// </summary>
        [Pos(2)]
        public Loop_2010EB_278_2 Loop2010EB { get; set; }
        /// <summary>
        /// Loop for Patient Event Transport Information
        /// </summary>
        [Pos(3)]
        public List<Loop_2010EC_278_2> Loop2010EC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_278
    {
        
        /// <summary>
        /// Previous Review Authorization Number
        /// </summary>
        [Pos(1)]
        public REF_PreviousReviewAuthorizationNumber REF_PreviousReviewAuthorizationNumber { get; set; }
        /// <summary>
        /// Previous Review Administrative Reference Number
        /// </summary>
        [Pos(2)]
        public REF_PreviousReviewAdministrativeReferenceNumber REF_PreviousReviewAdministrativeReferenceNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_278_2
    {
        
        /// <summary>
        /// Administrative Reference Number
        /// </summary>
        [Pos(1)]
        public REF_AdministrativeReferenceNumber REF_AdministrativeReferenceNumber { get; set; }
        /// <summary>
        /// Previous Review Authorization Number
        /// </summary>
        [Pos(2)]
        public REF_PreviousReviewAuthorizationNumber_2 REF_PreviousReviewAuthorizationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_UtilizationManagementOrganization))]
    public class Loop_2000A_278
    {
        
        /// <summary>
        /// Utilization Management Organization (UMO) Level
        /// </summary>
        [Pos(1)]
        public HL_UtilizationManagementOrganization HL_UtilizationManagementOrganization_UMO_Level { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Name
        /// </summary>
        [Pos(2)]
        public Loop_2010A_278 Loop2010A { get; set; }
        /// <summary>
        /// Loop for Requester Level
        /// </summary>
        [Pos(3)]
        public Loop_2000B_278 Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_278_2
    {
        
        /// <summary>
        /// Utilization Management Organization (UMO) Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_UtilizationManagementOrganization_UMO_Level { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [Pos(2)]
        public List<AAA_DependentRequestValidation> AAA_RequestValidation { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Name
        /// </summary>
        [Pos(3)]
        public Loop_2010A_278_2 Loop2010A { get; set; }
        /// <summary>
        /// Loop for Requester Level
        /// </summary>
        [Pos(4)]
        public Loop_2000B_278_2 Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_RequesterLevel))]
    public class Loop_2000B_278
    {
        
        /// <summary>
        /// Requester Level
        /// </summary>
        [Pos(1)]
        public HL_RequesterLevel HL_RequesterLevel { get; set; }
        /// <summary>
        /// Loop for Requester Name
        /// </summary>
        [Pos(2)]
        public Loop_2010B_278 Loop2010B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(3)]
        public Loop_2000C_278 Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_InformationReceiverLevel))]
    public class Loop_2000B_278_2
    {
        
        /// <summary>
        /// Requester Level
        /// </summary>
        [Pos(1)]
        public HL_InformationReceiverLevel HL_RequesterLevel { get; set; }
        /// <summary>
        /// Loop for Requester Name
        /// </summary>
        [Pos(2)]
        public List<Loop_2010B_278_2> Loop2010B { get; set; }
        /// <summary>
        /// Loop for Subscriber Level
        /// </summary>
        [Pos(3)]
        public Loop_2000C_278_2 Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberLevel))]
    public class Loop_2000C_278
    {
        
        /// <summary>
        /// Subscriber Level
        /// </summary>
        [Pos(1)]
        public HL_SubscriberLevel HL_SubscriberLevel { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(2)]
        public Loop_2010C_278 Loop2010C { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(3)]
        public Loop_2000D_278 Loop2000D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [Pos(4)]
        public Loop_2000E_278 Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000C_278_2
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
        public Loop_2010C_278_2 Loop2010C { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000E_278_2> Loop2000E { get; set; }
        /// <summary>
        /// Loop for Dependent Level
        /// </summary>
        [Pos(4)]
        public Loop_2000D_278_2 Loop2000D { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel_2))]
    public class Loop_2000D_278
    {
        
        /// <summary>
        /// Dependent Level
        /// </summary>
        [Pos(1)]
        public HL_DependentLevel_2 HL_DependentLevel { get; set; }
        /// <summary>
        /// Loop for Dependent Name
        /// </summary>
        [Pos(2)]
        public Loop_2010D_278 Loop2010D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [Pos(3)]
        public Loop_2000E_278 Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000D_278_2
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
        public Loop_2010D_278_2 Loop2010D { get; set; }
        /// <summary>
        /// Loop for Patient Event Level
        /// </summary>
        [Pos(3)]
        public List<Loop_2000E_278_2> Loop2000E { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_PatientEventLevel))]
    public class Loop_2000E_278
    {
        
        /// <summary>
        /// Patient Event Level
        /// </summary>
        [Pos(1)]
        public HL_PatientEventLevel HL_PatientEventLevel { get; set; }
        /// <summary>
        /// Patient Event Tracking Number
        /// </summary>
        [Pos(2)]
        public List<TRN_PatientEventTrackingNumber> TRN_PatientEventTrackingNumber { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [Pos(3)]
        public UM_HealthCareServicesReviewInformation_3 UM_HealthCareServicesReviewInformation { get; set; }
        [Pos(4)]
        public All_REF_278 AllREF { get; set; }
        [Pos(5)]
        public All_DTP_278_2 AllDTP { get; set; }
        /// <summary>
        /// Patient Diagnosis
        /// </summary>
        [Pos(6)]
        public HI_PatientDiagnosis HI_PatientDiagnosis { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(7)]
        public HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery { get; set; }
        [Pos(8)]
        public All_CRC_278 AllCRC { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [Pos(9)]
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [Pos(10)]
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [Pos(11)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        /// <summary>
        /// Home Oxygen Therapy Information
        /// </summary>
        [Pos(12)]
        public CR5_HomeOxygenTherapyInformation CR5_HomeOxygenTherapyInformation { get; set; }
        /// <summary>
        /// Home Health Care Information
        /// </summary>
        [Pos(13)]
        public CR6_HomeHealthCareInformation CR6_HomeHealthCareInformation { get; set; }
        /// <summary>
        /// Additional Patient Information
        /// </summary>
        [Pos(14)]
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalPatientInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(15)]
        public MSG_MessageText MSG_MessageText { get; set; }
        [Pos(16)]
        public All_NM1_278_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Service Level
        /// </summary>
        [Pos(17)]
        public List<Loop_2000F_278> Loop2000F { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_PatientEventLevel_2))]
    public class Loop_2000E_278_2
    {
        
        /// <summary>
        /// Patient Event Level
        /// </summary>
        [Pos(1)]
        public HL_PatientEventLevel_2 HL_PatientEventLevel { get; set; }
        /// <summary>
        /// Patient Event Tracking Number
        /// </summary>
        [Pos(2)]
        public List<TRN_DependentTraceNumber> TRN_PatientEventTrackingNumber { get; set; }
        /// <summary>
        /// Patient Event Request Validation
        /// </summary>
        [Pos(3)]
        public List<AAA_DependentRequestValidation_2> AAA_PatientEventRequestValidation { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [Pos(4)]
        public UM_HealthCareServicesReviewInformation_4 UM_HealthCareServicesReviewInformation { get; set; }
        /// <summary>
        /// Health Care Services Review
        /// </summary>
        [Pos(5)]
        public HCR_HealthCareServicesReview_2 HCR_HealthCareServicesReview { get; set; }
        [Pos(6)]
        public All_REF_278_2 AllREF { get; set; }
        [Pos(7)]
        public All_DTP_278_3 AllDTP { get; set; }
        /// <summary>
        /// Patient Diagnosis
        /// </summary>
        [Pos(8)]
        public HI_PatientDiagnosis_2 HI_PatientDiagnosis { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(9)]
        public HSD_HealthCareServicesDelivery HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [Pos(10)]
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [Pos(11)]
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [Pos(12)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        /// <summary>
        /// Home Oxygen Therapy Information
        /// </summary>
        [Pos(13)]
        public CR5_HomeOxygenTherapyInformation_2 CR5_HomeOxygenTherapyInformation { get; set; }
        /// <summary>
        /// Home Health Care Information
        /// </summary>
        [Pos(14)]
        public CR6_HomeHealthCareInformation_2 CR6_HomeHealthCareInformation { get; set; }
        /// <summary>
        /// Additional Patient Information
        /// </summary>
        [Pos(15)]
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalPatientInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(16)]
        public MSG_MessageText MSG_MessageText { get; set; }
        [Pos(17)]
        public All_NM1_278_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Service Level
        /// </summary>
        [Pos(18)]
        public List<Loop_2000F_278_2> Loop2000F { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_ServiceLevel))]
    public class Loop_2000F_278
    {
        
        /// <summary>
        /// Service Level
        /// </summary>
        [Pos(1)]
        public HL_ServiceLevel HL_ServiceLevel { get; set; }
        /// <summary>
        /// Service Trace Number
        /// </summary>
        [Pos(2)]
        public List<TRN_PatientEventTrackingNumber> TRN_ServiceTraceNumber { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [Pos(3)]
        public UM_HealthCareServicesReviewInformation UM_HealthCareServicesReviewInformation { get; set; }
        [Pos(4)]
        public All_REF_278 AllREF { get; set; }
        /// <summary>
        /// Service Date
        /// </summary>
        [Pos(5)]
        public DTP_ServiceDate_2 DTP_ServiceDate { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [Pos(6)]
        public SV1_ProfessionalService_2 SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [Pos(7)]
        public SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [Pos(8)]
        public SV3_DentalService_2 SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [Pos(9)]
        public List<TOO_ToothInformation_2> TOO_ToothInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(10)]
        public HSD_HealthCareServicesDelivery_2 HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Additional Service Information
        /// </summary>
        [Pos(11)]
        public List<PWK_AdditionalPatientInformation> PWK_AdditionalServiceInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(12)]
        public MSG_MessageText MSG_MessageText { get; set; }
        /// <summary>
        /// Loop for Service Provider Name
        /// </summary>
        [Pos(13)]
        public List<Loop_2010F_278> Loop2010F { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_ServiceLevel_2))]
    public class Loop_2000F_278_2
    {
        
        /// <summary>
        /// Service Level
        /// </summary>
        [Pos(1)]
        public HL_ServiceLevel_2 HL_ServiceLevel { get; set; }
        /// <summary>
        /// Service Trace Number
        /// </summary>
        [Pos(2)]
        public List<TRN_DependentTraceNumber> TRN_ServiceTraceNumber { get; set; }
        /// <summary>
        /// Service Request Validation
        /// </summary>
        [Pos(3)]
        public List<AAA_DependentRequestValidation_2> AAA_ServiceRequestValidation { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [Pos(4)]
        public UM_HealthCareServicesReviewInformation_2 UM_HealthCareServicesReviewInformation { get; set; }
        /// <summary>
        /// Health Care Services Review
        /// </summary>
        [Pos(5)]
        public HCR_HealthCareServicesReview HCR_HealthCareServicesReview { get; set; }
        [Pos(6)]
        public All_REF_278_2 AllREF { get; set; }
        [Pos(7)]
        public All_DTP_278 AllDTP { get; set; }
        /// <summary>
        /// Request For Additional Information
        /// </summary>
        [Pos(8)]
        public HI_RequestForAdditionalInformation HI_RequestForAdditionalInformation { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [Pos(9)]
        public SV1_ProfessionalService_3 SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [Pos(10)]
        public SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [Pos(11)]
        public SV3_DentalService SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [Pos(12)]
        public List<TOO_ToothInformation> TOO_ToothInformation { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [Pos(13)]
        public HSD_HealthCareServicesDelivery HSD_HealthCareServicesDelivery { get; set; }
        /// <summary>
        /// Additional Service Information
        /// </summary>
        [Pos(14)]
        public List<PWK_AdditionalPatientInformation_2> PWK_AdditionalServiceInformation { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [Pos(15)]
        public MSG_MessageText MSG_MessageText { get; set; }
        [Pos(16)]
        public All_NM1_278 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_UtilizationManagementOrganization))]
    public class Loop_2010A_278
    {
        
        /// <summary>
        /// Utilization Management Organization (UMO) Name
        /// </summary>
        [Pos(1)]
        public NM1_UtilizationManagementOrganization NM1_UtilizationManagementOrganization_UMO_Name { get; set; }
    }
    
    /// <summary>
    /// Loop for Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_UtilizationManagementOrganization_2))]
    public class Loop_2010A_278_2
    {
        
        /// <summary>
        /// Utilization Management Organization (UMO) Name
        /// </summary>
        [Pos(1)]
        public NM1_UtilizationManagementOrganization_2 NM1_UtilizationManagementOrganization_UMO_Name { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Contact Information
        /// </summary>
        [Pos(2)]
        public PER_AdditionalPatientInformationContactInformation PER_UtilizationManagementOrganization_UMO_ContactInformation { get; set; }
        /// <summary>
        /// Utilization Management Organization (UMO) Request Validation
        /// </summary>
        [Pos(3)]
        public List<AAA_DependentRequestValidation_2> AAA_UtilizationManagementOrganization_UMO_RequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_RequesterName))]
    public class Loop_2010B_278
    {
        
        /// <summary>
        /// Requester Name
        /// </summary>
        [Pos(1)]
        public NM1_RequesterName NM1_RequesterName { get; set; }
        /// <summary>
        /// Requester Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_RequesterSupplementalIdentification> REF_RequesterSupplementalIdentification { get; set; }
        /// <summary>
        /// Requester Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_RequesterAddress { get; set; }
        /// <summary>
        /// Requester City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_RequesterCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Requester Contact Information
        /// </summary>
        [Pos(5)]
        public PER_PatientEventProviderContactInformation PER_RequesterContactInformation { get; set; }
        /// <summary>
        /// Requester Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_RequesterProviderInformation PRV_RequesterProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Requester Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_RequesterName_2))]
    public class Loop_2010B_278_2
    {
        
        /// <summary>
        /// Requester Name
        /// </summary>
        [Pos(1)]
        public NM1_RequesterName_2 NM1_RequesterName { get; set; }
        /// <summary>
        /// Requester Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_RequesterSupplementalIdentification_2> REF_RequesterSupplementalIdentification { get; set; }
        /// <summary>
        /// Requester Request Validation
        /// </summary>
        [Pos(3)]
        public List<AAA_DependentRequestValidation_2> AAA_RequesterRequestValidation { get; set; }
        /// <summary>
        /// Requester Provider Information
        /// </summary>
        [Pos(4)]
        public PRV_RequesterProviderInformation_2 PRV_RequesterProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_SubscriberName))]
    public class Loop_2010C_278
    {
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_SubscriberName NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_SubscriberSupplementalIdentification> REF_SubscriberSupplementalIdentification { get; set; }
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
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(5)]
        public DMG_DependentDemographicInformation_2 DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [Pos(6)]
        public INS_SubscriberRelationship INS_SubscriberRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_SubscriberName_2))]
    public class Loop_2010C_278_2
    {
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_SubscriberName_2 NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_SubscriberSupplementalIdentification_2> REF_SubscriberSupplementalIdentification { get; set; }
        /// <summary>
        /// Subscriber Mailing Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberMailingAddress { get; set; }
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Request Validation
        /// </summary>
        [Pos(5)]
        public List<AAA_DependentRequestValidation_2> AAA_SubscriberRequestValidation { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(6)]
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        /// <summary>
        /// Subscriber Relationship
        /// </summary>
        [Pos(7)]
        public INS_MultipleBirthSequenceNumber INS_SubscriberRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_3))]
    public class Loop_2010D_278
    {
        
        /// <summary>
        /// Dependent Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_3 NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_DependentSupplementalIdentification> REF_DependentSupplementalIdentification { get; set; }
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
        /// Dependent Demographic Information
        /// </summary>
        [Pos(5)]
        public DMG_DependentDemographicInformation_2 DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [Pos(6)]
        public INS_DependentRelationship_3 INS_DependentRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Dependent Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2010D_278_2
    {
        
        /// <summary>
        /// Dependent Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_2 NM1_DependentName { get; set; }
        /// <summary>
        /// Dependent Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_DependentSupplementalIdentification_2> REF_DependentSupplementalIdentification { get; set; }
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
        public List<AAA_DependentRequestValidation_2> AAA_DependentRequestValidation { get; set; }
        /// <summary>
        /// Dependent Demographic Information
        /// </summary>
        [Pos(6)]
        public DMG_DependentDemographicInformation DMG_DependentDemographicInformation { get; set; }
        /// <summary>
        /// Dependent Relationship
        /// </summary>
        [Pos(7)]
        public INS_DependentRelationship_4 INS_DependentRelationship { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientEventProviderName))]
    public class Loop_2010EA_278
    {
        
        /// <summary>
        /// Patient Event Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_PatientEventProviderName NM1_PatientEventProviderName { get; set; }
        /// <summary>
        /// Patient Event Provider Supplemental Information
        /// </summary>
        [Pos(2)]
        public List<REF_PatientEventProviderSupplementalInformation> REF_PatientEventProviderSupplementalInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress { get; set; }
        /// <summary>
        /// Patient Event Provider City, State, Zip Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_PatientEventProviderCity_State_ZipCode { get; set; }
        /// <summary>
        /// Patient Event Provider Contact Information
        /// </summary>
        [Pos(5)]
        public PER_PatientEventProviderContactInformation PER_PatientEventProviderContactInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_PatientEventProviderInformation PRV_PatientEventProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientEventProviderName_2))]
    public class Loop_2010EA_278_2
    {
        
        /// <summary>
        /// Patient Event Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_PatientEventProviderName_2 NM1_PatientEventProviderName { get; set; }
        /// <summary>
        /// Patient Event Provider Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_PatientEventProviderSupplementalIdentification> REF_PatientEventProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Patient Event Provider Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventProviderAddress { get; set; }
        /// <summary>
        /// Patient Event Provider City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_PatientEventProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Contact Information
        /// </summary>
        [Pos(5)]
        public PER_AdditionalPatientInformationContactInformation PER_ProviderContactInformation { get; set; }
        /// <summary>
        /// Patient Event Provider Request Validation
        /// </summary>
        [Pos(6)]
        public List<AAA_DependentRequestValidation_2> AAA_PatientEventProviderRequestValidation { get; set; }
        /// <summary>
        /// Patient Event Provider Information
        /// </summary>
        [Pos(7)]
        public PRV_PatientEventProviderInformation_2 PRV_PatientEventProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientEventTransportInformation))]
    public class Loop_2010EB_278
    {
        
        /// <summary>
        /// Patient Event Transport Information
        /// </summary>
        [Pos(1)]
        public NM1_PatientEventTransportInformation NM1_PatientEventTransportInformation { get; set; }
        /// <summary>
        /// Patient Event Transport Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress { get; set; }
        /// <summary>
        /// Patient Event Transport Location City/State/ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_PatientEventTransportLocationCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Patient Information Contact Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AdditionalPatientInformationContactName))]
    public class Loop_2010EB_278_2
    {
        
        /// <summary>
        /// Additional Patient Information Contact Name
        /// </summary>
        [Pos(1)]
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalPatientInformationContactName { get; set; }
        /// <summary>
        /// Additional Patient Information Contact Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalPatientInformationContactAddress { get; set; }
        /// <summary>
        /// Additional Patient Information Contact City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AdditionalPatientInformationContactCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Additional Patient Information Contact Information
        /// </summary>
        [Pos(4)]
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalPatientInformationContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Other UMO Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientEventOtherUMOName))]
    public class Loop_2010EC_278
    {
        
        /// <summary>
        /// Patient Event Other UMO Name
        /// </summary>
        [Pos(1)]
        public NM1_PatientEventOtherUMOName NM1_PatientEventOtherUMOName { get; set; }
        /// <summary>
        /// Other UMO Denial Reason
        /// </summary>
        [Pos(2)]
        public REF_OtherUMODenialReason REF_OtherUMODenialReason { get; set; }
        /// <summary>
        /// Other UMO Denial Date
        /// </summary>
        [Pos(3)]
        public DTP_OtherUMODenialDate DTP_OtherUMODenialDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientEventTransportInformation_2))]
    public class Loop_2010EC_278_2
    {
        
        /// <summary>
        /// Patient Event Transport Information
        /// </summary>
        [Pos(1)]
        public NM1_PatientEventTransportInformation_2 NM1_PatientEventTransportInformation { get; set; }
        /// <summary>
        /// Patient Event Transport Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_PatientEventTransportLocationAddress { get; set; }
        /// <summary>
        /// Patient Event Transport Location City/State/ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_PatientEventTransportLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Event Transport Location Request Validation
        /// </summary>
        [Pos(4)]
        public List<AAA_DependentRequestValidation_2> AAA_PatientEventTransportLocationRequestValidation { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ServiceProviderName))]
    public class Loop_2010F_278
    {
        
        /// <summary>
        /// Service Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_ServiceProviderName NM1_ServiceProviderName { get; set; }
        /// <summary>
        /// Service Provider Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_PatientEventProviderSupplementalInformation> REF_ServiceProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Service Provider Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress { get; set; }
        /// <summary>
        /// Service Provider City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Provider Contact Information
        /// </summary>
        [Pos(5)]
        public PER_PatientEventProviderContactInformation PER_ServiceProviderContactInformation { get; set; }
        /// <summary>
        /// Service Provider Information
        /// </summary>
        [Pos(6)]
        public PRV_ServiceProviderInformation PRV_ServiceProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ServiceProviderName_2))]
    public class Loop_2010FA_278
    {
        
        /// <summary>
        /// Service Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_ServiceProviderName_2 NM1_ServiceProviderName { get; set; }
        /// <summary>
        /// Service Provider Supplemental Identification
        /// </summary>
        [Pos(2)]
        public List<REF_ServiceProviderSupplementalIdentification> REF_ServiceProviderSupplementalIdentification { get; set; }
        /// <summary>
        /// Service Provider Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_ServiceProviderAddress { get; set; }
        /// <summary>
        /// Service Provider City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Provider Contact Information
        /// </summary>
        [Pos(5)]
        public PER_AdditionalPatientInformationContactInformation PER_ServiceProviderContactInformation { get; set; }
        /// <summary>
        /// Service Provider Request Validation
        /// </summary>
        [Pos(6)]
        public List<AAA_DependentRequestValidation_2> AAA_ServiceProviderRequestValidation { get; set; }
        /// <summary>
        /// Service Provider Information
        /// </summary>
        [Pos(7)]
        public PRV_ServiceProviderInformation_2 PRV_ServiceProviderInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Service Information Contact Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AdditionalPatientInformationContactName))]
    public class Loop_2010FB_278
    {
        
        /// <summary>
        /// Additional Service Information Contact Name
        /// </summary>
        [Pos(1)]
        public NM1_AdditionalPatientInformationContactName NM1_AdditionalServiceInformationContactName { get; set; }
        /// <summary>
        /// Additional Service Information Contact Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AdditionalServiceInformationContactAddress { get; set; }
        /// <summary>
        /// Additional Service Information Contact City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AdditionalServiceInformationContactCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Additional Service Information Contact Information
        /// </summary>
        [Pos(4)]
        public PER_AdditionalPatientInformationContactInformation PER_AdditionalServiceInformationContactInformation { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(BHT_BeginningofHierarchicalTransaction_5))]
    public class Loop_BHT_278
    {
        
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [Pos(1)]
        public BHT_BeginningofHierarchicalTransaction_5 BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Level
        /// </summary>
        [Pos(2)]
        public Loop_2000A_278 Loop2000A { get; set; }
    }
    
    [Serializable()]
    [Group(typeof(BHT_BeginningofHierarchicalTransaction_6))]
    public class Loop_BHT_278_2
    {
        
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [Pos(1)]
        public BHT_BeginningofHierarchicalTransaction_6 BHT_BeginningofHierarchicalTransaction { get; set; }
        /// <summary>
        /// Loop for Utilization Management Organization (UMO) Level
        /// </summary>
        [Pos(2)]
        public Loop_2000A_278_2 Loop2000A { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information - Request
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X217", "278")]
    public class TS278 : EdiMessage
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        [Pos(2)]
        public Loop_BHT_278 LoopBHT { get; set; }
        [Pos(3)]
        public Loop_BHT_278_2 LoopBHT2 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(4)]
        public SE SE { get; set; }
    }
}
