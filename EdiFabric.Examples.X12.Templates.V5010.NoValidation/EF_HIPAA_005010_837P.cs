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
    public class All_AMT_837P
    {
        
        /// <summary>
        /// Sales Tax Amount
        /// </summary>
        [Pos(1)]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        /// <summary>
        /// Postage Claimed Amount
        /// </summary>
        [Pos(2)]
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_837P_2
    {
        
        /// <summary>
        /// Coordination of Benefits (COB) Payer Paid Amount
        /// </summary>
        [Pos(1)]
        public AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        /// <summary>
        /// Coordination of Benefits (COB) Total Non-covered Amount
        /// </summary>
        [Pos(2)]
        public AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount { get; set; }
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        [Pos(3)]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_837P
    {
        
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [Pos(1)]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        /// <summary>
        /// Hospice Employee Indicator
        /// </summary>
        [Pos(2)]
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        /// <summary>
        /// Condition Indicator/Durable Medical Equipment
        /// </summary>
        [Pos(3)]
        public CRC_ConditionIndicator CRC_ConditionIndicator_DurableMedicalEquipment { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_837P_2
    {
        
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [Pos(1)]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        /// <summary>
        /// Patient Condition Information: Vision
        /// </summary>
        [Pos(2)]
        public List<CRC_PatientConditionInformation> CRC_PatientConditionInformation_Vision { get; set; }
        /// <summary>
        /// Homebound Indicator
        /// </summary>
        [Pos(3)]
        public CRC_HomeboundIndicator CRC_HomeboundIndicator { get; set; }
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        [Pos(4)]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_837P
    {
        
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [Pos(1)]
        public DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
        /// <summary>
        /// Date - Prescription Date
        /// </summary>
        [Pos(2)]
        public DTP_HearingandVisionPrescriptionDate DTP_Date_PrescriptionDate { get; set; }
        /// <summary>
        /// DATE - Certification Revision/Recertification Date
        /// </summary>
        [Pos(3)]
        public DTP_CertificationRevision DTP_DATE_CertificationRevision_RecertificationDate { get; set; }
        /// <summary>
        /// Date - Begin Therapy Date
        /// </summary>
        [Pos(4)]
        public DTP_BeginTherapyDate DTP_Date_BeginTherapyDate { get; set; }
        /// <summary>
        /// Date - Last Certification Date
        /// </summary>
        [Pos(5)]
        public DTP_LastCertificationDate DTP_Date_LastCertificationDate { get; set; }
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        [Pos(6)]
        public DTP_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        /// <summary>
        /// Date - Test Date
        /// </summary>
        [Pos(7)]
        public List<DTP_TestDate> DTP_Date_TestDate { get; set; }
        /// <summary>
        /// Date - Shipped Date
        /// </summary>
        [Pos(8)]
        public DTP_ShippedDate DTP_Date_ShippedDate { get; set; }
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        [Pos(9)]
        public DTP_LastXrayDate DTP_Date_LastX_Date { get; set; }
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        [Pos(10)]
        public DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_837P_2
    {
        
        /// <summary>
        /// Date - Onset of Current Illness or Symptom
        /// </summary>
        [Pos(1)]
        public DTP_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom { get; set; }
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        [Pos(2)]
        public DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        [Pos(3)]
        public DTP_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        /// <summary>
        /// Date - Acute Manifestation
        /// </summary>
        [Pos(4)]
        public DTP_AcuteManifestation DTP_Date_AcuteManifestation { get; set; }
        /// <summary>
        /// Date - Accident
        /// </summary>
        [Pos(5)]
        public DTP_AccidentDate_2 DTP_Date_Accident { get; set; }
        /// <summary>
        /// Date - Last Menstrual Period
        /// </summary>
        [Pos(6)]
        public DTP_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod { get; set; }
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        [Pos(7)]
        public DTP_LastXrayDate DTP_Date_LastX_Date { get; set; }
        /// <summary>
        /// Date - Hearing and Vision Prescription Date
        /// </summary>
        [Pos(8)]
        public DTP_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate { get; set; }
        /// <summary>
        /// Date - Disability Dates
        /// </summary>
        [Pos(9)]
        public DTP_DisabilityDates DTP_Date_DisabilityDates { get; set; }
        /// <summary>
        /// Date - Last Worked
        /// </summary>
        [Pos(10)]
        public DTP_LastWorked DTP_Date_LastWorked { get; set; }
        /// <summary>
        /// Date - Authorized Return to Work
        /// </summary>
        [Pos(11)]
        public DTP_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork { get; set; }
        /// <summary>
        /// Date - Admission
        /// </summary>
        [Pos(12)]
        public DTP_AdmissionDate_4 DTP_Date_Admission { get; set; }
        /// <summary>
        /// Date - Discharge
        /// </summary>
        [Pos(13)]
        public DTP_Discharge DTP_Date_Discharge { get; set; }
        /// <summary>
        /// Date - Assumed and Relinquished Care Dates
        /// </summary>
        [Pos(14)]
        public List<DTP_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates { get; set; }
        /// <summary>
        /// Property and Casualty Date of First Contact
        /// </summary>
        [Pos(15)]
        public DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        [Pos(16)]
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_HI_837P
    {
        
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        [Pos(1)]
        public HI_DependentHealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Anesthesia Related Procedure
        /// </summary>
        [Pos(2)]
        public HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure { get; set; }
        /// <summary>
        /// Condition Information
        /// </summary>
        [Pos(3)]
        public List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P
    {
        
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2010AA_837P Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [Pos(2)]
        public Loop_2010AB_837P Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [Pos(3)]
        public Loop_2010AC_837P Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P_2
    {
        
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2010BA_837P Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2010BB_837P Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P_3
    {
        
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [Pos(1)]
        public List<Loop_2310A_837P> Loop2310A { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(2)]
        public Loop_2310B_837P Loop2310B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [Pos(3)]
        public Loop_2310C_837P Loop2310C { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [Pos(4)]
        public Loop_2310D_837P Loop2310D { get; set; }
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        [Pos(5)]
        public Loop_2310E_837P Loop2310E { get; set; }
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        [Pos(6)]
        public Loop_2310F_837P Loop2310F { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P_4
    {
        
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2330A_837P Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2330B_837P Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [Pos(3)]
        public List<Loop_2330C_837P> Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider
        /// </summary>
        [Pos(4)]
        public Loop_2330D_837P Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [Pos(5)]
        public Loop_2330E_837P Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Supervising Provider
        /// </summary>
        [Pos(6)]
        public Loop_2330F_837P Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [Pos(7)]
        public Loop_2330G_837P Loop2330G { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P_5
    {
        
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2420A_837P Loop2420A { get; set; }
        /// <summary>
        /// Loop for Purchased Service Provider Name
        /// </summary>
        [Pos(2)]
        public Loop_2420B_837P Loop2420B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location
        /// </summary>
        [Pos(3)]
        public Loop_2420C_837P Loop2420C { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [Pos(4)]
        public Loop_2420D_837P Loop2420D { get; set; }
        /// <summary>
        /// Loop for Ordering Provider Name
        /// </summary>
        [Pos(5)]
        public Loop_2420E_837P Loop2420E { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [Pos(6)]
        public List<Loop_2420F_837P> Loop2420F { get; set; }
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        [Pos(7)]
        public Loop_2420G_837P Loop2420G { get; set; }
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        [Pos(8)]
        public Loop_2420H_837P Loop2420H { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837P_6
    {
        
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [Pos(1)]
        public Loop_1000A_837P Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [Pos(2)]
        public Loop_1000B_837P Loop1000B { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NTE_837P
    {
        
        /// <summary>
        /// Line Note
        /// </summary>
        [Pos(1)]
        public NTE_LineNote NTE_LineNote { get; set; }
        /// <summary>
        /// Third Party Organization Notes
        /// </summary>
        [Pos(2)]
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_PWK_837P
    {
        
        /// <summary>
        /// Line Supplemental Information
        /// </summary>
        [Pos(1)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certificate of Medical Necessity Indicator
        /// </summary>
        [Pos(2)]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_QTY_837P
    {
        
        /// <summary>
        /// Ambulance Patient Count
        /// </summary>
        [Pos(1)]
        public QTY_AmbulancePatientCount QTY_AmbulancePatientCount { get; set; }
        /// <summary>
        /// Obstetric Anesthesia Additional Units
        /// </summary>
        [Pos(2)]
        public QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P
    {
        
        /// <summary>
        /// Other Payer Secondary Identifier
        /// </summary>
        [Pos(1)]
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        /// <summary>
        /// Other Payer Prior Authorization Number
        /// </summary>
        [Pos(2)]
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber { get; set; }
        /// <summary>
        /// Other Payer Referral Number
        /// </summary>
        [Pos(3)]
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber { get; set; }
        /// <summary>
        /// Other Payer Claim Adjustment Indicator
        /// </summary>
        [Pos(4)]
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        /// <summary>
        /// Other Payer Claim Control Number
        /// </summary>
        [Pos(5)]
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_2
    {
        
        /// <summary>
        /// Repriced Line Item Reference Number
        /// </summary>
        [Pos(1)]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Line Item Reference Number
        /// </summary>
        [Pos(2)]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [Pos(3)]
        public List<REF_OtherPayerPriorAuthorizationNumber> REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [Pos(4)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        [Pos(5)]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        [Pos(6)]
        public REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        /// <summary>
        /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
        /// </summary>
        [Pos(7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendment REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification { get; set; }
        /// <summary>
        /// Immunization Batch Number
        /// </summary>
        [Pos(8)]
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [Pos(9)]
        public List<REF_OtherPayerReferralNumber> REF_ReferralNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_3
    {
        
        /// <summary>
        /// Pay-To Plan Secondary Identification
        /// </summary>
        [Pos(1)]
        public REF_Pay REF_Pay_ToPlanSecondaryIdentification { get; set; }
        /// <summary>
        /// Pay-To Plan Tax Identification Number
        /// </summary>
        [Pos(2)]
        public REF_BillingProviderTaxIdentification_2 REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_4
    {
        
        /// <summary>
        /// Subscriber Secondary Identification
        /// </summary>
        [Pos(1)]
        public REF_OtherSubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification { get; set; }
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        [Pos(2)]
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_5
    {
        
        /// <summary>
        /// Payer Secondary Identification
        /// </summary>
        [Pos(1)]
        public List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification { get; set; }
        /// <summary>
        /// Billing Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_6
    {
        
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        [Pos(1)]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        /// <summary>
        /// Mandatory Medicare (Section 4081) Crossover Indicator
        /// </summary>
        [Pos(2)]
        public REF_MandatoryMedicare REF_MandatoryMedicare_Section4081_CrossoverIndicator { get; set; }
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        [Pos(3)]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [Pos(4)]
        public REF_OtherPayerReferralNumber REF_ReferralNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [Pos(5)]
        public REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [Pos(6)]
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        [Pos(7)]
        public REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [Pos(8)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [Pos(9)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Investigational Device Exemption Number
        /// </summary>
        [Pos(10)]
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [Pos(11)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Medical Record Number
        /// </summary>
        [Pos(12)]
        public REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        /// <summary>
        /// Demonstration Project Identifier
        /// </summary>
        [Pos(13)]
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        /// <summary>
        /// Care Plan Oversight
        /// </summary>
        [Pos(14)]
        public REF_CarePlanOversight REF_CarePlanOversight { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_7
    {
        
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        [Pos(1)]
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
        /// <summary>
        /// Property and Casualty Patient Identifier
        /// </summary>
        [Pos(2)]
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837P_8
    {
        
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        [Pos(1)]
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        /// <summary>
        /// Billing Provider UPIN/License Information
        /// </summary>
        [Pos(2)]
        public List<REF_BillingProviderUPIN> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_1000A_837P
    {
        
        /// <summary>
        /// Submitter Name
        /// </summary>
        [Pos(1)]
        public NM1_InformationReceiverName_2 NM1_SubmitterName { get; set; }
        /// <summary>
        /// Submitter EDI Contact Information
        /// </summary>
        [Pos(2)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ReceiverName))]
    public class Loop_1000B_837P
    {
        
        /// <summary>
        /// Receiver Name
        /// </summary>
        [Pos(1)]
        public NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_837P
    {
        
        /// <summary>
        /// Billing Provider Hierarchical Level
        /// </summary>
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel { get; set; }
        /// <summary>
        /// Billing Provider Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        [Pos(3)]
        public CUR_ForeignCurrencyInformation_3 CUR_ForeignCurrencyInformation { get; set; }
        [Pos(4)]
        public All_NM1_837P AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000B_837P> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_837P
    {
        
        /// <summary>
        /// Subscriber Hierarchical Level
        /// </summary>
        [Pos(1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        /// <summary>
        /// Subscriber Information
        /// </summary>
        [Pos(2)]
        public SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [Pos(3)]
        public PAT_PatientInformation_2 PAT_PatientInformation { get; set; }
        [Pos(4)]
        public All_NM1_837P_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2300_837P_2> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [Pos(6)]
        public List<Loop_2000C_837P> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_837P
    {
        
        /// <summary>
        /// Patient Hierarchical Level
        /// </summary>
        [Pos(1)]
        public HL_DependentLevel HL_PatientHierarchicalLevel { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [Pos(2)]
        public PAT_PatientInformation PAT_PatientInformation { get; set; }
        /// <summary>
        /// Loop for Patient Name
        /// </summary>
        [Pos(3)]
        public Loop_2010CA_837P Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [Pos(4)]
        public List<Loop_2300_837P> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2010AA_837P
    {
        
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
        /// <summary>
        /// Billing Provider Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress { get; set; }
        /// <summary>
        /// Billing Provider City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_BillingProviderCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public All_REF_837P_8 AllREF { get; set; }
        /// <summary>
        /// Billing Provider Contact Information
        /// </summary>
        [Pos(5)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_Pay))]
    public class Loop_2010AB_837P
    {
        
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [Pos(1)]
        public NM1_Pay NM1_Pay_AddressName { get; set; }
        /// <summary>
        /// Pay-To Address - ADDRESS
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_Pay_ToAddress_ADDRESS { get; set; }
        /// <summary>
        /// Pay-to Address City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_Pay_AddressCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_Pay_3))]
    public class Loop_2010AC_837P
    {
        
        /// <summary>
        /// Pay-To Plan Name
        /// </summary>
        [Pos(1)]
        public NM1_Pay_3 NM1_Pay_ToPlanName { get; set; }
        /// <summary>
        /// Pay-To Plan Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_Pay_ToPlanAddress { get; set; }
        /// <summary>
        /// Pay-To Plan City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public All_REF_837P_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2010BA_837P
    {
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_InsuredName NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress { get; set; }
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [Pos(4)]
        public DMG_DependentDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_837P_4 AllREF { get; set; }
        /// <summary>
        /// Property and Casualty Subscriber Contact Information
        /// </summary>
        [Pos(6)]
        public PER_AdditionalPatientInformationContactInformation PER_PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2010BB_837P
    {
        
        /// <summary>
        /// Payer Name
        /// </summary>
        [Pos(1)]
        public NM1_CorrectedPriorityPayerName NM1_PayerName { get; set; }
        /// <summary>
        /// Payer Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_PayerAddress { get; set; }
        /// <summary>
        /// Payer City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_PayerCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public All_REF_837P_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2010CA_837P
    {
        
        /// <summary>
        /// Patient Name
        /// </summary>
        [Pos(1)]
        public NM1_DependentName_2 NM1_PatientName { get; set; }
        /// <summary>
        /// Patient Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_PatientAddress { get; set; }
        /// <summary>
        /// Patient City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Demographic Information
        /// </summary>
        [Pos(4)]
        public DMG_DependentDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_837P_7 AllREF { get; set; }
        /// <summary>
        /// Property and Casualty Patient Contact Information
        /// </summary>
        [Pos(6)]
        public PER_AdditionalPatientInformationContactInformation PER_PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837P
    {
        
        /// <summary>
        /// Claim Information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP_837P_2 AllDTP { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(4)]
        public CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [Pos(5)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [Pos(6)]
        public All_REF_837P_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(7)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [Pos(8)]
        public NTE_ClaimNote_2 NTE_ClaimNote { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [Pos(9)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [Pos(10)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [Pos(11)]
        public All_CRC_837P_2 AllCRC { get; set; }
        [Pos(12)]
        public All_HI_837P AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(13)]
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(14)]
        public All_NM1_837P_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(15)]
        public List<Loop_2320_837P> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(16)]
        public List<Loop_2400_837P> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837P_2
    {
        
        /// <summary>
        /// Claim Information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP_837P_2 AllDTP { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(4)]
        public CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [Pos(5)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [Pos(6)]
        public All_REF_837P_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(7)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [Pos(8)]
        public NTE_ClaimNote_2 NTE_ClaimNote { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [Pos(9)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [Pos(10)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [Pos(11)]
        public All_CRC_837P_2 AllCRC { get; set; }
        [Pos(12)]
        public All_HI_837P AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(13)]
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(14)]
        public All_NM1_837P_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(15)]
        public List<Loop_2320_837P> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(16)]
        public List<Loop_2400_837P> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2310A_837P
    {
        
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2310B_837P
    {
        
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider_2 NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2310C_837P
    {
        
        /// <summary>
        /// Service Facility Location Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_ServiceFacilityLocationName { get; set; }
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress { get; set; }
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
        /// <summary>
        /// Service Facility Contact Information
        /// </summary>
        [Pos(5)]
        public PER_AdditionalPatientInformationContactInformation PER_ServiceFacilityContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2310D_837P
    {
        
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulancePick))]
    public class Loop_2310E_837P
    {
        
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        [Pos(1)]
        public NM1_AmbulancePick NM1_AmbulancePick_Location { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulanceDrop))]
    public class Loop_2310F_837P
    {
        
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        [Pos(1)]
        public NM1_AmbulanceDrop NM1_AmbulanceDrop_Location { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SBR_OtherSubscriberInformation))]
    public class Loop_2320_837P
    {
        
        /// <summary>
        /// Other Subscriber Information
        /// </summary>
        [Pos(1)]
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        /// <summary>
        /// Claim Level Adjustments
        /// </summary>
        [Pos(2)]
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [Pos(3)]
        public All_AMT_837P_2 AllAMT { get; set; }
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        [Pos(4)]
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [Pos(5)]
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [Pos(6)]
        public All_NM1_837P_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2330A_837P
    {
        
        /// <summary>
        /// Other Subscriber Name
        /// </summary>
        [Pos(1)]
        public NM1_InsuredName NM1_OtherSubscriberName { get; set; }
        /// <summary>
        /// Other Subscriber Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress { get; set; }
        /// <summary>
        /// Other Subscriber City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Identification
        /// </summary>
        [Pos(4)]
        public REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2330B_837P
    {
        
        /// <summary>
        /// Other Payer Name
        /// </summary>
        [Pos(1)]
        public NM1_CorrectedPriorityPayerName NM1_OtherPayerName { get; set; }
        /// <summary>
        /// Other Payer Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress { get; set; }
        /// <summary>
        /// Other Payer City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Claim Check or Remittance Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckorRemittanceDate { get; set; }
        [Pos(5)]
        public All_REF_837P AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2330C_837P
    {
        
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2330D_837P
    {
        
        /// <summary>
        /// Other Payer Rendering Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330E_837P
    {
        
        /// <summary>
        /// Other Payer Service Facility Location
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        /// <summary>
        /// Other Payer Service Facility Location Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2330F_837P
    {
        
        /// <summary>
        /// Other Payer Supervising Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2330G_837P
    {
        
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        [Pos(1)]
        public NM1_BillingProviderName NM1_OtherPayerBillingProvider { get; set; }
        /// <summary>
        /// Other Payer Billing Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_837P
    {
        
        /// <summary>
        /// Service Line Number
        /// </summary>
        [Pos(1)]
        public LX_HeaderNumber LX_ServiceLineNumber { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [Pos(2)]
        public SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Durable Medical Equipment Service
        /// </summary>
        [Pos(3)]
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [Pos(4)]
        public All_PWK_837P AllPWK { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [Pos(5)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certification
        /// </summary>
        [Pos(6)]
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [Pos(7)]
        public All_CRC_837P AllCRC { get; set; }
        [Pos(8)]
        public All_DTP_837P AllDTP { get; set; }
        [Pos(9)]
        public All_QTY_837P AllQTY { get; set; }
        /// <summary>
        /// Test Result
        /// </summary>
        [Pos(10)]
        public List<MEA_TestResult> MEA_TestResult { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(11)]
        public CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        [Pos(12)]
        public All_REF_837P_2 AllREF { get; set; }
        [Pos(13)]
        public All_AMT_837P AllAMT { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(14)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [Pos(15)]
        public All_NTE_837P AllNTE { get; set; }
        /// <summary>
        /// Purchased Service Information
        /// </summary>
        [Pos(16)]
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [Pos(17)]
        public HCP_ClaimPricing_2 HCP_LinePricing_RepricingInformation { get; set; }
        /// <summary>
        /// Loop for Drug Identification
        /// </summary>
        [Pos(18)]
        public Loop_2410_837P Loop2410 { get; set; }
        [Pos(19)]
        public All_NM1_837P_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [Pos(20)]
        public List<Loop_2430_837P> Loop2430 { get; set; }
        /// <summary>
        /// Loop for Form Identification Code
        /// </summary>
        [Pos(21)]
        public List<Loop_2440_837P> Loop2440 { get; set; }
    }
    
    /// <summary>
    /// Loop for Drug Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(LIN_DrugIdentification))]
    public class Loop_2410_837P
    {
        
        /// <summary>
        /// Drug Identification
        /// </summary>
        [Pos(1)]
        public LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        /// <summary>
        /// Drug Quantity
        /// </summary>
        [Pos(2)]
        public CTP_DrugQuantity CTP_DrugQuantity { get; set; }
        /// <summary>
        /// Prescription or Compound Drug Association Number
        /// </summary>
        [Pos(3)]
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2420A_837P
    {
        
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider_2 NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PurchasedServiceProviderName))]
    public class Loop_2420B_837P
    {
        
        /// <summary>
        /// Purchased Service Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        /// <summary>
        /// Purchased Service Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2420C_837P
    {
        
        /// <summary>
        /// Service Facility Location
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress { get; set; }
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_BillingProviderSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2420D_837P
    {
        
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ordering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OrderingProviderName))]
    public class Loop_2420E_837P
    {
        
        /// <summary>
        /// Ordering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        /// <summary>
        /// Ordering Provider Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_OrderingProviderAddress { get; set; }
        /// <summary>
        /// Ordering Provider City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OrderingProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Ordering Provider Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        /// <summary>
        /// Ordering Provider Contact Information
        /// </summary>
        [Pos(5)]
        public PER_AdditionalPatientInformationContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2420F_837P
    {
        
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulancePick))]
    public class Loop_2420G_837P
    {
        
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        [Pos(1)]
        public NM1_AmbulancePick NM1_AmbulancePick_Location { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulanceDrop))]
    public class Loop_2420H_837P
    {
        
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        [Pos(1)]
        public NM1_AmbulanceDrop NM1_AmbulanceDrop_Location { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVD_LineAdjudicationInformation))]
    public class Loop_2430_837P
    {
        
        /// <summary>
        /// Line Adjudication Information
        /// </summary>
        [Pos(1)]
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
        /// <summary>
        /// Line Adjustment
        /// </summary>
        [Pos(2)]
        public List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment { get; set; }
        /// <summary>
        /// Line Check or Remittance Date
        /// </summary>
        [Pos(3)]
        public DTP_ClaimCheckOrRemittanceDate DTP_LineCheckorRemittanceDate { get; set; }
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        [Pos(4)]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    /// <summary>
    /// Loop for Form Identification Code
    /// </summary>
    [Serializable()]
    [Group(typeof(LQ_FormIdentificationCode))]
    public class Loop_2440_837P
    {
        
        /// <summary>
        /// Form Identification Code
        /// </summary>
        [Pos(1)]
        public LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        /// <summary>
        /// Supporting Documentation
        /// </summary>
        [Pos(2)]
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim : Professional
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X222A1", "837")]
    public class TS837P : EdiMessage
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
        public BHT_BeginningofHierarchicalTransaction_7 BHT_BeginningofHierarchicalTransaction { get; set; }
        [Pos(3)]
        public All_NM1_837P_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000A_837P> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(5)]
        public SE SE { get; set; }
    }
}
