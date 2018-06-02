namespace EdiFabric.Rules.HIPAA_5010
{
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Health Care Claim : Professional
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X222A1", "837")]
    public class TS837P : EdiMessage
    {

        [Pos(1)]
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Beginning of Hierarchical Transaction
        /// </summary>
        public BHT_BeginningofHierarchicalTransaction_7 BeginningofHierarchicalTransaction { get; set; }
        [Required]
        [Pos(3)]
        public All_NM1_TS837P AllNM1 { get; set; }
        [Required]
        [Pos(4)]
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        public List<Loop_2000A_TS837P> Loop2000A { get; set; }
        [Pos(5)]
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        public SE SE { get; set; }
    }

    [Serializable()]
    [All()]
    public class All_AMT_2_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Sales Tax Amount
        /// </summary>
        public AMT_SalesTaxAmount SalesTaxAmount { get; set; }
        [Pos(2)]
        /// <summary>
        /// Postage Claimed Amount
        /// </summary>
        public AMT_PostageClaimedAmount PostageClaimedAmount { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_3_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Coordination of Benefits (COB) Payer Paid Amount
        /// </summary>
        public AMT_CoordinationofBenefits CoordinationofBenefits { get; set; }
        [Pos(2)]
        /// <summary>
        /// Coordination of Benefits (COB) Total Non-covered Amount
        /// </summary>
        public AMT_CoordinationofBenefits_2 CoordinationofBenefits_02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        public AMT_RemainingPatientLiability RemainingPatientLiability { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_2_TS837P
    {
        
        [ListCount(3)]
        [Pos(1)]
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        public List<CRC_AmbulanceCertification> AmbulanceCertification { get; set; }
        [Pos(2)]
        /// <summary>
        /// Hospice Employee Indicator
        /// </summary>
        public CRC_HospiceEmployeeIndicator HospiceEmployeeIndicator { get; set; }
        [Pos(3)]
        /// <summary>
        /// Condition Indicator/Durable Medical Equipment
        /// </summary>
        public CRC_ConditionIndicator ConditionIndicator { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_3_TS837P
    {
        
        [ListCount(3)]
        [Pos(1)]
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        public List<CRC_AmbulanceCertification> AmbulanceCertification { get; set; }
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Patient Condition Information: Vision
        /// </summary>
        public List<CRC_PatientConditionInformation> PatientConditionInformation { get; set; }
        [Pos(3)]
        /// <summary>
        /// Homebound Indicator
        /// </summary>
        public CRC_HomeboundIndicator HomeboundIndicator { get; set; }
        [Pos(4)]
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        public CRC_EPSDTReferral EPSDTReferral { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Date - Service Date
        /// </summary>
        public DTP_ClaimLevelServiceDate Date { get; set; }
        [Pos(2)]
        /// <summary>
        /// Date - Prescription Date
        /// </summary>
        public DTP_HearingandVisionPrescriptionDate Date_02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// DATE - Certification Revision/Recertification Date
        /// </summary>
        public DTP_CertificationRevision DATE { get; set; }
        [Pos(4)]
        /// <summary>
        /// Date - Begin Therapy Date
        /// </summary>
        public DTP_BeginTherapyDate Date_04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Date - Last Certification Date
        /// </summary>
        public DTP_LastCertificationDate Date_05 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        public DTP_LastSeenDate Date_06 { get; set; }
        [ListCount(2)]
        [Pos(7)]
        /// <summary>
        /// Date - Test Date
        /// </summary>
        public List<DTP_TestDate> Date_07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Date - Shipped Date
        /// </summary>
        public DTP_ShippedDate Date_08 { get; set; }
        [Pos(9)]
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        public DTP_LastXrayDate Date_09 { get; set; }
        [Pos(10)]
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        public DTP_InitialTreatmentDate Date_10 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_3_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Date - Onset of Current Illness or Symptom
        /// </summary>
        public DTP_OnsetofCurrentIllnessorSymptom Date { get; set; }
        [Pos(2)]
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        public DTP_InitialTreatmentDate Date_02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        public DTP_LastSeenDate Date_03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Date - Acute Manifestation
        /// </summary>
        public DTP_AcuteManifestation Date_04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Date - Accident
        /// </summary>
        public DTP_AccidentDate_2 Date_05 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Date - Last Menstrual Period
        /// </summary>
        public DTP_LastMenstrualPeriod Date_06 { get; set; }
        [Pos(7)]
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        public DTP_LastXrayDate Date_07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Date - Hearing and Vision Prescription Date
        /// </summary>
        public DTP_HearingandVisionPrescriptionDate Date_08 { get; set; }
        [Pos(9)]
        /// <summary>
        /// Date - Disability Dates
        /// </summary>
        public DTP_DisabilityDates Date_09 { get; set; }
        [Pos(10)]
        /// <summary>
        /// Date - Last Worked
        /// </summary>
        public DTP_LastWorked Date_10 { get; set; }
        [Pos(11)]
        /// <summary>
        /// Date - Authorized Return to Work
        /// </summary>
        public DTP_AuthorizedReturntoWork Date_11 { get; set; }
        [Pos(12)]
        /// <summary>
        /// Date - Admission
        /// </summary>
        public DTP_AdmissionDate_4 Date_12 { get; set; }
        [Pos(13)]
        /// <summary>
        /// Date - Discharge
        /// </summary>
        public DTP_Discharge Date_13 { get; set; }
        [ListCount(2)]
        [Pos(14)]
        /// <summary>
        /// Date - Assumed and Relinquished Care Dates
        /// </summary>
        public List<DTP_AssumedandRelinquishedCareDates> Date_14 { get; set; }
        [Pos(15)]
        /// <summary>
        /// Property and Casualty Date of First Contact
        /// </summary>
        public DTP_PropertyandCasualtyDateofFirstContact PropertyandCasualtyDateofFirstContact { get; set; }
        [Pos(16)]
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        public DTP_RepricerReceivedDate Date_16 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_HI_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        public HI_DependentHealthCareDiagnosisCode HealthCareDiagnosisCode { get; set; }
        [Pos(2)]
        /// <summary>
        /// Anesthesia Related Procedure
        /// </summary>
        public HI_AnesthesiaRelatedProcedure AnesthesiaRelatedProcedure { get; set; }
        [ListCount(2)]
        [Pos(3)]
        /// <summary>
        /// Condition Information
        /// </summary>
        public List<HI_ConditionInformation> ConditionInformation { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        public Loop_2010AA_TS837P Loop2010AA { get; set; }
        [Pos(2)]
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        public Loop_2010AB_TS837P Loop2010AB { get; set; }
        [Pos(3)]
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        public Loop_2010AC_TS837P Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_3_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        public Loop_2010BA_TS837P Loop2010BA { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        public Loop_2010BB_TS837P Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_4_TS837P
    {
        
        [ListCount(2)]
        [Pos(1)]
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        public List<Loop_2310A_2_TS837P> Loop2310A { get; set; }
        [Pos(2)]
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        public Loop_2310B_2_TS837P Loop2310B { get; set; }
        [Pos(3)]
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        public Loop_2310C_2_TS837P Loop2310C { get; set; }
        [Pos(4)]
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        public Loop_2310D_2_TS837P Loop2310D { get; set; }
        [Pos(5)]
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        public Loop_2310E_2_TS837P Loop2310E { get; set; }
        [Pos(6)]
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        public Loop_2310F_2_TS837P Loop2310F { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_5_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        public Loop_2330A_2_TS837P Loop2330A { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        public Loop_2330B_2_TS837P Loop2330B { get; set; }
        [ListCount(2)]
        [Pos(3)]
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        public List<Loop_2330C_2_TS837P> Loop2330C { get; set; }
        [Pos(4)]
        /// <summary>
        /// Loop for Other Payer Rendering Provider
        /// </summary>
        public Loop_2330D_2_TS837P Loop2330D { get; set; }
        [Pos(5)]
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        public Loop_2330E_2_TS837P Loop2330E { get; set; }
        [Pos(6)]
        /// <summary>
        /// Loop for Other Payer Supervising Provider
        /// </summary>
        public Loop_2330F_2_TS837P Loop2330F { get; set; }
        [Pos(7)]
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        public Loop_2330G_2_TS837P Loop2330G { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_6_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        public Loop_2420A_2_TS837P Loop2420A { get; set; }
        [Pos(2)]
        /// <summary>
        /// Loop for Purchased Service Provider Name
        /// </summary>
        public Loop_2420B_2_TS837P Loop2420B { get; set; }
        [Pos(3)]
        /// <summary>
        /// Loop for Service Facility Location
        /// </summary>
        public Loop_2420C_2_TS837P Loop2420C { get; set; }
        [Pos(4)]
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        public Loop_2420D_2_TS837P Loop2420D { get; set; }
        [Pos(5)]
        /// <summary>
        /// Loop for Ordering Provider Name
        /// </summary>
        public Loop_2420E_2_TS837P Loop2420E { get; set; }
        [ListCount(2)]
        [Pos(6)]
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        public List<Loop_2420F_2_TS837P> Loop2420F { get; set; }
        [Pos(7)]
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        public Loop_2420G_2_TS837P Loop2420G { get; set; }
        [Pos(8)]
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        public Loop_2420H_2_TS837P Loop2420H { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        public Loop_1000A_TS837P Loop1000A { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        public Loop_1000B_TS837P Loop1000B { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NTE_2_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Line Note
        /// </summary>
        public NTE_LineNote LineNote { get; set; }
        [Pos(2)]
        /// <summary>
        /// Third Party Organization Notes
        /// </summary>
        public NTE_ThirdPartyOrganizationNotes ThirdPartyOrganizationNotes { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_PWK_2_TS837P
    {
        
        [ListCount(10)]
        [Pos(1)]
        /// <summary>
        /// Line Supplemental Information
        /// </summary>
        public List<PWK_ClaimSupplementalInformation_2> LineSupplementalInformation { get; set; }
        [Pos(2)]
        /// <summary>
        /// Durable Medical Equipment Certificate of Medical Necessity Indicator
        /// </summary>
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_QTY_2_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Ambulance Patient Count
        /// </summary>
        public QTY_AmbulancePatientCount AmbulancePatientCount { get; set; }
        [Pos(2)]
        /// <summary>
        /// Obstetric Anesthesia Additional Units
        /// </summary>
        public QTY_ObstetricAnesthesiaAdditionalUnits ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_10_TS837P
    {
        
        [ListCount(2)]
        [Pos(1)]
        /// <summary>
        /// Other Payer Secondary Identifier
        /// </summary>
        public List<REF_OtherPayerSecondaryIdentifier> OtherPayerSecondaryIdentifier { get; set; }
        [Pos(2)]
        /// <summary>
        /// Other Payer Prior Authorization Number
        /// </summary>
        public REF_OtherPayerPriorAuthorizationNumber OtherPayerPriorAuthorizationNumber { get; set; }
        [Pos(3)]
        /// <summary>
        /// Other Payer Referral Number
        /// </summary>
        public REF_OtherPayerReferralNumber OtherPayerReferralNumber { get; set; }
        [Pos(4)]
        /// <summary>
        /// Other Payer Claim Adjustment Indicator
        /// </summary>
        public REF_OtherPayerClaimAdjustmentIndicator OtherPayerClaimAdjustmentIndicator { get; set; }
        [Pos(5)]
        /// <summary>
        /// Other Payer Claim Control Number
        /// </summary>
        public REF_OtherPayerClaimControlNumber OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_11_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Repriced Line Item Reference Number
        /// </summary>
        public REF_RepricedLineItemReferenceNumber RepricedLineItemReferenceNumber { get; set; }
        [Pos(2)]
        /// <summary>
        /// Adjusted Repriced Line Item Reference Number
        /// </summary>
        public REF_AdjustedRepricedLineItemReferenceNumber AdjustedRepricedLineItemReferenceNumber { get; set; }
        [ListCount(5)]
        [Pos(3)]
        /// <summary>
        /// Prior Authorization
        /// </summary>
        public List<REF_OtherPayerPriorAuthorizationNumber> PriorAuthorization { get; set; }
        [Pos(4)]
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        public REF_LineItemControlNumber LineItemControlNumber { get; set; }
        [Pos(5)]
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        public REF_MammographyCertificationNumber MammographyCertificationNumber { get; set; }
        [Pos(6)]
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        public REF_ClinicalLaboratoryImprovementAmendment ClinicalLaboratoryImprovementAmendment { get; set; }
        [Pos(7)]
        /// <summary>
        /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
        /// </summary>
        public REF_ReferringClinicalLaboratoryImprovementAmendment ReferringClinicalLaboratoryImprovementAmendment { get; set; }
        [Pos(8)]
        /// <summary>
        /// Immunization Batch Number
        /// </summary>
        public REF_ImmunizationBatchNumber ImmunizationBatchNumber { get; set; }
        [ListCount(5)]
        [Pos(9)]
        /// <summary>
        /// Referral Number
        /// </summary>
        public List<REF_OtherPayerReferralNumber> ReferralNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Pay-To Plan Secondary Identification
        /// </summary>
        public REF_Pay Pay { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Pay-To Plan Tax Identification Number
        /// </summary>
        public REF_BillingProviderTaxIdentification_2 Pay_02 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_3_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Subscriber Secondary Identification
        /// </summary>
        public REF_OtherSubscriberSecondaryIdentification SubscriberSecondaryIdentification { get; set; }
        [Pos(2)]
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        public REF_PropertyandCasualtyClaimNumber PropertyandCasualtyClaimNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_4_TS837P
    {
        
        [ListCount(3)]
        [Pos(1)]
        /// <summary>
        /// Payer Secondary Identification
        /// </summary>
        public List<REF_OtherPayerSecondaryIdentifier> PayerSecondaryIdentification { get; set; }
        [ListCount(2)]
        [Pos(2)]
        /// <summary>
        /// Billing Provider Secondary Identification
        /// </summary>
        public List<REF_BillingProviderSecondaryIdentification> BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_5_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        public REF_ServiceAuthorizationExceptionCode ServiceAuthorizationExceptionCode { get; set; }
        [Pos(2)]
        /// <summary>
        /// Mandatory Medicare (Section 4081) Crossover Indicator
        /// </summary>
        public REF_MandatoryMedicare MandatoryMedicare { get; set; }
        [Pos(3)]
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        public REF_MammographyCertificationNumber MammographyCertificationNumber { get; set; }
        [Pos(4)]
        /// <summary>
        /// Referral Number
        /// </summary>
        public REF_OtherPayerReferralNumber ReferralNumber { get; set; }
        [Pos(5)]
        /// <summary>
        /// Prior Authorization
        /// </summary>
        public REF_OtherPayerPriorAuthorizationNumber PriorAuthorization { get; set; }
        [Pos(6)]
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        public REF_OtherPayerClaimControlNumber PayerClaimControlNumber { get; set; }
        [Pos(7)]
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        public REF_ClinicalLaboratoryImprovementAmendment ClinicalLaboratoryImprovementAmendment { get; set; }
        [Pos(8)]
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        public REF_RepricedClaimNumber RepricedClaimNumber { get; set; }
        [Pos(9)]
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        public REF_AdjustedRepricedClaimNumber AdjustedRepricedClaimNumber { get; set; }
        [Pos(10)]
        /// <summary>
        /// Investigational Device Exemption Number
        /// </summary>
        public REF_InvestigationalDeviceExemptionNumber InvestigationalDeviceExemptionNumber { get; set; }
        [Pos(11)]
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries ClaimIdentifierForTransmissionIntermediaries { get; set; }
        [Pos(12)]
        /// <summary>
        /// Medical Record Number
        /// </summary>
        public REF_MedicalRecordNumber MedicalRecordNumber { get; set; }
        [Pos(13)]
        /// <summary>
        /// Demonstration Project Identifier
        /// </summary>
        public REF_DemonstrationProjectIdentifier DemonstrationProjectIdentifier { get; set; }
        [Pos(14)]
        /// <summary>
        /// Care Plan Oversight
        /// </summary>
        public REF_CarePlanOversight CarePlanOversight { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_8_TS837P
    {
        
        [Pos(1)]
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        public REF_PropertyandCasualtyClaimNumber PropertyandCasualtyClaimNumber { get; set; }
        [Pos(2)]
        /// <summary>
        /// Property and Casualty Patient Identifier
        /// </summary>
        public REF_PropertyandCasualtyPatientIdentifier PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        public REF_BillingProviderTaxIdentification BillingProviderTaxIdentification { get; set; }
        [ListCount(2)]
        [Pos(2)]
        /// <summary>
        /// Billing Provider UPIN/License Information
        /// </summary>
        public List<REF_BillingProviderUPIN> BillingProviderUPIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_4))]
    public class Loop_1000A_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Submitter Name
        /// </summary>
        public NM1_InformationReceiverName_4 SubmitterName { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        /// <summary>
        /// Submitter EDI Contact Information
        /// </summary>
        public List<PER_BillingProviderContactInformation> SubmitterEDIContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Receiver Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ReceiverName))]
    public class Loop_1000B_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Receiver Name
        /// </summary>
        public NM1_ReceiverName ReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Billing Provider Hierarchical Level
        /// </summary>
        public HL_BillingProviderHierarchicalLevel BillingProviderHierarchicalLevel { get; set; }
        [Pos(2)]
        /// <summary>
        /// Billing Provider Specialty Information
        /// </summary>
        public PRV_BillingProviderSpecialtyInformation BillingProviderSpecialtyInformation { get; set; }
        [Pos(3)]
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        public CUR_ForeignCurrencyInformation_3 ForeignCurrencyInformation { get; set; }
        [Required]
        [Pos(4)]
        public All_NM1_2_TS837P AllNM1 { get; set; }
        [Required]
        [Pos(5)]
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        public List<Loop_2000B_TS837P> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Subscriber Hierarchical Level
        /// </summary>
        public HL_SubscriberHierarchicalLevel SubscriberHierarchicalLevel { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Subscriber Information
        /// </summary>
        public SBR_SubscriberInformation SubscriberInformation { get; set; }
        [Pos(3)]
        /// <summary>
        /// Patient Information
        /// </summary>
        public PAT_PatientInformation_3 PatientInformation { get; set; }
        [Required]
        [Pos(4)]
        public All_NM1_3_TS837P AllNM1 { get; set; }
        [ListCount(100)]
        [Pos(5)]
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        public List<Loop_2300_2_TS837P> Loop2300 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        public List<Loop_2000C_TS837P> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Patient Hierarchical Level
        /// </summary>
        public HL_DependentLevel PatientHierarchicalLevel { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Patient Information
        /// </summary>
        public PAT_PatientInformation PatientInformation { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Loop for Patient Name
        /// </summary>
        public Loop_2010CA_TS837P Loop2010CA { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(4)]
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        public List<Loop_2300_2_TS837P> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName_2))]
    public class Loop_2010AA_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        public NM1_BillingProviderName_2 BillingProviderName { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Billing Provider Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress BillingProviderAddress { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Billing Provider City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity BillingProviderCity { get; set; }
        [Required]
        [Pos(4)]
        public All_REF_TS837P AllREF { get; set; }
        [ListCount(2)]
        [Pos(5)]
        /// <summary>
        /// Billing Provider Contact Information
        /// </summary>
        public List<PER_BillingProviderContactInformation> BillingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_Pay))]
    public class Loop_2010AB_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        public NM1_Pay Pay { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Pay-To Address - ADDRESS
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress Pay_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Pay-to Address City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity Pay_03 { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_Pay_3))]
    public class Loop_2010AC_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Pay-To Plan Name
        /// </summary>
        public NM1_Pay_3 Pay { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Pay-To Plan Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress Pay_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Pay-To Plan City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity Pay_03 { get; set; }
        [Required]
        [Pos(4)]
        public All_REF_2_TS837P AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_SubscriberName_5))]
    public class Loop_2010BA_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Subscriber Name
        /// </summary>
        public NM1_SubscriberName_5 SubscriberName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Subscriber Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress SubscriberAddress { get; set; }
        [Pos(3)]
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity SubscriberCity { get; set; }
        [Pos(4)]
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        public DMG_PatientDemographicInformation SubscriberDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_3_TS837P AllREF { get; set; }
        [Pos(6)]
        /// <summary>
        /// Property and Casualty Subscriber Contact Information
        /// </summary>
        public PER_PropertyandCasualtyPatientContactInformation PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2010BB_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Payer Name
        /// </summary>
        public NM1_OtherPayerName PayerName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Payer Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress PayerAddress { get; set; }
        [Pos(3)]
        /// <summary>
        /// Payer City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity PayerCity { get; set; }
        [Pos(4)]
        public All_REF_4_TS837P AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PatientName_3))]
    public class Loop_2010CA_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Patient Name
        /// </summary>
        public NM1_PatientName_3 PatientName { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Patient Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress PatientAddress { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Patient City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity PatientCity { get; set; }
        [Required]
        [Pos(4)]
        /// <summary>
        /// Patient Demographic Information
        /// </summary>
        public DMG_PatientDemographicInformation PatientDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_8_TS837P AllREF { get; set; }
        [Pos(6)]
        /// <summary>
        /// Property and Casualty Patient Contact Information
        /// </summary>
        public PER_PropertyandCasualtyPatientContactInformation PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation_2))]
    public class Loop_2300_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Claim Information
        /// </summary>
        public CLM_ClaimInformation_2 ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP_3_TS837P AllDTP { get; set; }
        [ListCount(10)]
        [Pos(3)]
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        public List<PWK_ClaimSupplementalInformation_3> ClaimSupplementalInformation { get; set; }
        [Pos(4)]
        /// <summary>
        /// Contract Information
        /// </summary>
        public CN1_ContractInformation_2 ContractInformation { get; set; }
        [Pos(5)]
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        public AMT_PatientAmountPaid PatientAmountPaid { get; set; }
        [Pos(6)]
        public All_REF_5_TS837P AllREF { get; set; }
        [ListCount(10)]
        [Pos(7)]
        /// <summary>
        /// File Information
        /// </summary>
        public List<K3_FileInformation> FileInformation { get; set; }
        [Pos(8)]
        /// <summary>
        /// Claim Note
        /// </summary>
        public NTE_ClaimNote_2 ClaimNote { get; set; }
        [Pos(9)]
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        public CR1_AmbulanceTransportInformation AmbulanceTransportInformation { get; set; }
        [Pos(10)]
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        public CR2_SpinalManipulationServiceInformation SpinalManipulationServiceInformation { get; set; }
        [Pos(11)]
        public All_CRC_3_TS837P AllCRC { get; set; }
        [Required]
        [Pos(12)]
        public All_HI_2_TS837P AllHI { get; set; }
        [Pos(13)]
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        public HCP_ClaimPricing ClaimPricing { get; set; }
        [Pos(14)]
        public All_NM1_4_TS837P AllNM1 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        public List<Loop_2320_2_TS837P> Loop2320 { get; set; }
        [Required]
        [ListCount(50)]
        [Pos(16)]
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        public List<Loop_2400_2_TS837P> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ReferringProviderName))]
    public class Loop_2310A_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        public NM1_ReferringProviderName ReferringProviderName { get; set; }
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        public List<REF_OrderingProviderSecondaryIdentification> ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_RenderingProviderName))]
    public class Loop_2310B_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        public NM1_RenderingProviderName RenderingProviderName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        public PRV_RenderingProviderSpecialtyInformation RenderingProviderSpecialtyInformation { get; set; }
        [ListCount(4)]
        [Pos(3)]
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ServiceFacilityLocation))]
    public class Loop_2310C_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Service Facility Location Name
        /// </summary>
        public NM1_ServiceFacilityLocation ServiceFacilityLocationName { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress ServiceFacilityLocationAddress { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity ServiceFacilityLocationCity { get; set; }
        [ListCount(3)]
        [Pos(4)]
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> ServiceFacilityLocationSecondaryIdentification { get; set; }
        [Pos(5)]
        /// <summary>
        /// Service Facility Contact Information
        /// </summary>
        public PER_PropertyandCasualtyPatientContactInformation ServiceFacilityContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_SupervisingProviderName))]
    public class Loop_2310D_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        public NM1_SupervisingProviderName SupervisingProviderName { get; set; }
        [ListCount(4)]
        [Pos(2)]
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulancePick))]
    public class Loop_2310E_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        public NM1_AmbulancePick AmbulancePick { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress AmbulancePick_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity AmbulancePick_03 { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulanceDrop))]
    public class Loop_2310F_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        public NM1_AmbulanceDrop AmbulanceDrop { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress AmbulanceDrop_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity AmbulanceDrop_03 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SBR_OtherSubscriberInformation))]
    public class Loop_2320_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Subscriber Information
        /// </summary>
        public SBR_OtherSubscriberInformation OtherSubscriberInformation { get; set; }
        [ListCount(5)]
        [Pos(2)]
        /// <summary>
        /// Claim Level Adjustments
        /// </summary>
        public List<CAS_ClaimLevelAdjustments> ClaimLevelAdjustments { get; set; }
        [Pos(3)]
        public All_AMT_3_TS837P AllAMT { get; set; }
        [Required]
        [Pos(4)]
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        public OI_OtherInsuranceCoverageInformation_2 OtherInsuranceCoverageInformation { get; set; }
        [Pos(5)]
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        public MOA_OutpatientAdjudicationInformation OutpatientAdjudicationInformation { get; set; }
        [Required]
        [Pos(6)]
        public All_NM1_5_TS837P AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherSubscriberName))]
    public class Loop_2330A_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Subscriber Name
        /// </summary>
        public NM1_OtherSubscriberName OtherSubscriberName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Other Subscriber Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress OtherSubscriberAddress { get; set; }
        [Pos(3)]
        /// <summary>
        /// Other Subscriber City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity OtherSubscriberCity { get; set; }
        [Pos(4)]
        /// <summary>
        /// Other Subscriber Secondary Identification
        /// </summary>
        public REF_OtherSubscriberSecondaryIdentification OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2330B_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Name
        /// </summary>
        public NM1_OtherPayerName OtherPayerName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Other Payer Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress OtherPayerAddress { get; set; }
        [Pos(3)]
        /// <summary>
        /// Other Payer City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity OtherPayerCity { get; set; }
        [Pos(4)]
        /// <summary>
        /// Claim Check or Remittance Date
        /// </summary>
        public DTP_ClaimCheckOrRemittanceDate ClaimCheckorRemittanceDate { get; set; }
        [Pos(5)]
        public All_REF_10_TS837P AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2330C_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        public NM1_OtherPayerReferringProvider OtherPayerReferringProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        public List<REF_OrderingProviderSecondaryIdentification> OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2330D_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Rendering Provider
        /// </summary>
        public NM1_OtherPayerRenderingProvider_2 OtherPayerRenderingProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330E_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Service Facility Location
        /// </summary>
        public NM1_OtherPayerServiceFacilityLocation OtherPayerServiceFacilityLocation { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Other Payer Service Facility Location Secondary Identification
        /// </summary>
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2330F_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Supervising Provider
        /// </summary>
        public NM1_OtherPayerSupervisingProvider OtherPayerSupervisingProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        /// <summary>
        /// Other Payer Supervising Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerBillingProvider))]
    public class Loop_2330G_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        public NM1_OtherPayerBillingProvider OtherPayerBillingProvider { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        /// <summary>
        /// Other Payer Billing Provider Secondary Identification
        /// </summary>
        public List<REF_BillingProviderSecondaryIdentification> OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Service Line Number
        /// </summary>
        public LX_HeaderNumber ServiceLineNumber { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Professional Service
        /// </summary>
        public SV1_ProfessionalService ProfessionalService { get; set; }
        [Pos(3)]
        /// <summary>
        /// Durable Medical Equipment Service
        /// </summary>
        public SV5_DurableMedicalEquipmentService DurableMedicalEquipmentService { get; set; }
        [Pos(4)]
        public All_PWK_2_TS837P AllPWK { get; set; }
        [Pos(5)]
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        public CR1_AmbulanceTransportInformation AmbulanceTransportInformation { get; set; }
        [Pos(6)]
        /// <summary>
        /// Durable Medical Equipment Certification
        /// </summary>
        public CR3_DurableMedicalEquipmentCertification DurableMedicalEquipmentCertification { get; set; }
        [Pos(7)]
        public All_CRC_2_TS837P AllCRC { get; set; }
        [Required]
        [Pos(8)]
        public All_DTP_2_TS837P AllDTP { get; set; }
        [Pos(9)]
        public All_QTY_2_TS837P AllQTY { get; set; }
        [ListCount(5)]
        [Pos(10)]
        /// <summary>
        /// Test Result
        /// </summary>
        public List<MEA_TestResult> TestResult { get; set; }
        [Pos(11)]
        /// <summary>
        /// Contract Information
        /// </summary>
        public CN1_ContractInformation_2 ContractInformation { get; set; }
        [Pos(12)]
        public All_REF_11_TS837P AllREF { get; set; }
        [Pos(13)]
        public All_AMT_2_TS837P AllAMT { get; set; }
        [ListCount(10)]
        [Pos(14)]
        /// <summary>
        /// File Information
        /// </summary>
        public List<K3_FileInformation> FileInformation { get; set; }
        [Pos(15)]
        public All_NTE_2_TS837P AllNTE { get; set; }
        [Pos(16)]
        /// <summary>
        /// Purchased Service Information
        /// </summary>
        public PS1_PurchasedServiceInformation PurchasedServiceInformation { get; set; }
        [Pos(17)]
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        public HCP_LinePricing_3 LinePricing { get; set; }
        [Pos(18)]
        /// <summary>
        /// Loop for Drug Identification
        /// </summary>
        public Loop_2410_2_TS837P Loop2410 { get; set; }
        [Pos(19)]
        public All_NM1_6_TS837P AllNM1 { get; set; }
        [ListCount(15)]
        [Pos(20)]
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        public List<Loop_2430_2_TS837P> Loop2430 { get; set; }
        [Pos(21)]
        /// <summary>
        /// Loop for Form Identification Code
        /// </summary>
        public List<Loop_2440_2_TS837P> Loop2440 { get; set; }
    }
    
    /// <summary>
    /// Loop for Drug Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(LIN_DrugIdentification_2))]
    public class Loop_2410_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Drug Identification
        /// </summary>
        public LIN_DrugIdentification_2 DrugIdentification { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Drug Quantity
        /// </summary>
        public CTP_DrugQuantity DrugQuantity { get; set; }
        [Pos(3)]
        /// <summary>
        /// Prescription or Compound Drug Association Number
        /// </summary>
        public REF_PrescriptionorCompoundDrugAssociationNumber PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_RenderingProviderName))]
    public class Loop_2420A_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        public NM1_RenderingProviderName RenderingProviderName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        public PRV_RenderingProviderSpecialtyInformation RenderingProviderSpecialtyInformation { get; set; }
        [ListCount(20)]
        [Pos(3)]
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_PurchasedServiceProviderName))]
    public class Loop_2420B_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Purchased Service Provider Name
        /// </summary>
        public NM1_PurchasedServiceProviderName PurchasedServiceProviderName { get; set; }
        [ListCount(20)]
        [Pos(2)]
        /// <summary>
        /// Purchased Service Provider Secondary Identification
        /// </summary>
        public List<REF_OrderingProviderSecondaryIdentification> PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ServiceFacilityLocation))]
    public class Loop_2420C_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Service Facility Location
        /// </summary>
        public NM1_ServiceFacilityLocation ServiceFacilityLocation { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress ServiceFacilityLocationAddress { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity ServiceFacilityLocationCity { get; set; }
        [ListCount(3)]
        [Pos(4)]
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        public List<REF_BillingProviderSecondaryIdentification> ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_SupervisingProviderName))]
    public class Loop_2420D_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        public NM1_SupervisingProviderName SupervisingProviderName { get; set; }
        [ListCount(20)]
        [Pos(2)]
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        public List<REF_AssistantSurgeonSecondaryIdentification> SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ordering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OrderingProviderName))]
    public class Loop_2420E_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Ordering Provider Name
        /// </summary>
        public NM1_OrderingProviderName OrderingProviderName { get; set; }
        [Pos(2)]
        /// <summary>
        /// Ordering Provider Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress OrderingProviderAddress { get; set; }
        [Pos(3)]
        /// <summary>
        /// Ordering Provider City, State, ZIP Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity OrderingProviderCity { get; set; }
        [ListCount(20)]
        [Pos(4)]
        /// <summary>
        /// Ordering Provider Secondary Identification
        /// </summary>
        public List<REF_OrderingProviderSecondaryIdentification> OrderingProviderSecondaryIdentification { get; set; }
        [Pos(5)]
        /// <summary>
        /// Ordering Provider Contact Information
        /// </summary>
        public PER_BillingProviderContactInformation OrderingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ReferringProviderName))]
    public class Loop_2420F_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        public NM1_ReferringProviderName ReferringProviderName { get; set; }
        [ListCount(20)]
        [Pos(2)]
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        public List<REF_OrderingProviderSecondaryIdentification> ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulancePick))]
    public class Loop_2420G_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        public NM1_AmbulancePick AmbulancePick { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress AmbulancePick_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity AmbulancePick_03 { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AmbulanceDrop))]
    public class Loop_2420H_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        public NM1_AmbulanceDrop AmbulanceDrop { get; set; }
        [Required]
        [Pos(2)]
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        public N3_AdditionalPatientInformationContactAddress AmbulanceDrop_02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        public N4_AdditionalPatientInformationContactCity AmbulanceDrop_03 { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVD_LineAdjudicationInformation))]
    public class Loop_2430_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Line Adjudication Information
        /// </summary>
        public SVD_LineAdjudicationInformation LineAdjudicationInformation { get; set; }
        [ListCount(5)]
        [Pos(2)]
        /// <summary>
        /// Line Adjustment
        /// </summary>
        public List<CAS_ClaimLevelAdjustments> LineAdjustment { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Line Check or Remittance Date
        /// </summary>
        public DTP_ClaimCheckOrRemittanceDate LineCheckorRemittanceDate { get; set; }
        [Pos(4)]
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        public AMT_RemainingPatientLiability RemainingPatientLiability { get; set; }
    }
    
    /// <summary>
    /// Loop for Form Identification Code
    /// </summary>
    [Serializable()]
    [Group(typeof(LQ_FormIdentificationCode))]
    public class Loop_2440_2_TS837P
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Form Identification Code
        /// </summary>
        public LQ_FormIdentificationCode FormIdentificationCode { get; set; }
        [Required]
        [ListCount(99)]
        [Pos(2)]
        /// <summary>
        /// Supporting Documentation
        /// </summary>
        public List<FRM_SupportingDocumentation> SupportingDocumentation { get; set; }
    }
        
}
