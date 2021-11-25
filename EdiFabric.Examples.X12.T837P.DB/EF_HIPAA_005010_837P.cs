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
    public class All_AMT_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Tax Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        /// <summary>
        /// Postage Claimed Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_AMT_837P_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Coordination of Benefits (COB) Payer Paid Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        /// <summary>
        /// Coordination of Benefits (COB) Total Non-covered Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount { get; set; }
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_CRC_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(1)]
        public virtual List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        /// <summary>
        /// Hospice Employee Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        /// <summary>
        /// Condition Indicator/Durable Medical Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CRC_ConditionIndicator CRC_ConditionIndicator_DurableMedicalEquipment { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_CRC_837P_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(1)]
        public virtual List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        /// <summary>
        /// Patient Condition Information: Vision
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<CRC_PatientConditionInformation> CRC_PatientConditionInformation_Vision { get; set; }
        /// <summary>
        /// Homebound Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CRC_HomeboundIndicator CRC_HomeboundIndicator { get; set; }
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
        /// <summary>
        /// Date - Prescription Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_HearingandVisionPrescriptionDate DTP_Date_PrescriptionDate { get; set; }
        /// <summary>
        /// DATE - Certification Revision/Recertification Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_CertificationRevision DTP_DATE_CertificationRevision_RecertificationDate { get; set; }
        /// <summary>
        /// Date - Begin Therapy Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_BeginTherapyDate DTP_Date_BeginTherapyDate { get; set; }
        /// <summary>
        /// Date - Last Certification Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_LastCertificationDate DTP_Date_LastCertificationDate { get; set; }
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        /// <summary>
        /// Date - Test Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<DTP_TestDate> DTP_Date_TestDate { get; set; }
        /// <summary>
        /// Date - Shipped Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP_ShippedDate DTP_Date_ShippedDate { get; set; }
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DTP_LastXrayDate DTP_Date_LastX_Date { get; set; }
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_837P_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date - Onset of Current Illness or Symptom
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom { get; set; }
        /// <summary>
        /// Date - Initial Treatment Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
        /// <summary>
        /// Date - Last Seen Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        /// <summary>
        /// Date - Acute Manifestation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_AcuteManifestation DTP_Date_AcuteManifestation { get; set; }
        /// <summary>
        /// Date - Accident
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_AccidentDate_2 DTP_Date_Accident { get; set; }
        /// <summary>
        /// Date - Last Menstrual Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod { get; set; }
        /// <summary>
        /// Date - Last X-ray Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP_LastXrayDate DTP_Date_LastX_Date { get; set; }
        /// <summary>
        /// Date - Hearing and Vision Prescription Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate { get; set; }
        /// <summary>
        /// Date - Disability Dates
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DTP_DisabilityDates DTP_Date_DisabilityDates { get; set; }
        /// <summary>
        /// Date - Last Worked
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DTP_LastWorked DTP_Date_LastWorked { get; set; }
        /// <summary>
        /// Date - Authorized Return to Work
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DTP_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork { get; set; }
        /// <summary>
        /// Date - Admission
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual DTP_AdmissionDate_4 DTP_Date_Admission { get; set; }
        /// <summary>
        /// Date - Discharge
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual DTP_Discharge DTP_Date_Discharge { get; set; }
        /// <summary>
        /// Date - Assumed and Relinquished Care Dates
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<DTP_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates { get; set; }
        /// <summary>
        /// Property and Casualty Date of First Contact
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_HI_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HI_DependentHealthCareDiagnosisCode_2 HI_HealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Anesthesia Related Procedure
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure { get; set; }
        /// <summary>
        /// Condition Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Loop_2010AA_837P Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010AB_837P Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2010AC_837P Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Loop_2010BA_837P Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_2010BB_837P Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(1)]
        public virtual List<Loop_2310A_837P> Loop2310A { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2310B_837P Loop2310B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2310C_837P Loop2310C { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2310D_837P Loop2310D { get; set; }
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2310E_837P Loop2310E { get; set; }
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2310F_837P Loop2310F { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Loop_2330A_837P Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_2330B_837P Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_2330C_837P> Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2330D_837P Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2330E_837P Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Supervising Provider
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2330F_837P Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_2330G_837P Loop2330G { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P_5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2420A_837P Loop2420A { get; set; }
        /// <summary>
        /// Loop for Purchased Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2420B_837P Loop2420B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2420C_837P Loop2420C { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2420D_837P Loop2420D { get; set; }
        /// <summary>
        /// Loop for Ordering Provider Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2420E_837P Loop2420E { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_2420F_837P> Loop2420F { get; set; }
        /// <summary>
        /// Loop for Ambulance Pick-up Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_2420G_837P Loop2420G { get; set; }
        /// <summary>
        /// Loop for Ambulance Drop-off Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_2420H_837P Loop2420H { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837P_6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Loop_1000A_837P Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_1000B_837P Loop1000B { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NTE_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Note
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NTE_LineNote NTE_LineNote { get; set; }
        /// <summary>
        /// Third Party Organization Notes
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_PWK_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Supplemental Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(1)]
        public virtual List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certificate of Medical Necessity Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_QTY_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Patient Count
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual QTY_AmbulancePatientCount QTY_AmbulancePatientCount { get; set; }
        /// <summary>
        /// Obstetric Anesthesia Additional Units
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Secondary Identifier
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(1)]
        public virtual List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        /// <summary>
        /// Other Payer Prior Authorization Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber { get; set; }
        /// <summary>
        /// Other Payer Referral Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber { get; set; }
        /// <summary>
        /// Other Payer Claim Adjustment Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        /// <summary>
        /// Other Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Repriced Line Item Reference Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Line Item Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<REF_OtherPayerPriorAuthorizationNumber_2> REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        /// <summary>
        /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_ReferringClinicalLaboratoryImprovementAmendment REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification { get; set; }
        /// <summary>
        /// Immunization Batch Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<REF_OtherPayerReferralNumber_2> REF_ReferralNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-To Plan Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_Pay REF_Pay_ToPlanSecondaryIdentification { get; set; }
        /// <summary>
        /// Pay-To Plan Tax Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REF_BillingProviderTaxIdentification_2 REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_OtherSubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification { get; set; }
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(1)]
        public virtual List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification { get; set; }
        /// <summary>
        /// Billing Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        /// <summary>
        /// Mandatory Medicare (Section 4081) Crossover Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_MandatoryMedicare REF_MandatoryMedicare_Section4081_CrossoverIndicator { get; set; }
        /// <summary>
        /// Mammography Certification Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_OtherPayerReferralNumber REF_ReferralNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Clinical Laboratory Improvement Amendment (CLIA) Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_ClinicalLaboratoryImprovementAmendment REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Investigational Device Exemption Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Medical Record Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        /// <summary>
        /// Demonstration Project Identifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        /// <summary>
        /// Care Plan Oversight
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual REF_CarePlanOversight REF_CarePlanOversight { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_7
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property and Casualty Claim Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
        /// <summary>
        /// Property and Casualty Patient Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837P_8
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        /// <summary>
        /// Billing Provider UPIN/License Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF_BillingProviderUPIN> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_4), "1000A")]
    public class Loop_1000A_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Submitter Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_InformationReceiverName_4 NM1_SubmitterName { get; set; }
        /// <summary>
        /// Submitter EDI Contact Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<PER_BillingProviderContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReceiverName), "1000B")]
    public class Loop_1000B_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Receiver Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel), "2000A")]
    public class Loop_2000A_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel { get; set; }
        /// <summary>
        /// Billing Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR_ForeignCurrencyInformation_3 CUR_ForeignCurrencyInformation { get; set; }
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual All_NM1_837P AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_2000B_837P> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel), "2000B")]
    public class Loop_2000B_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        /// <summary>
        /// Subscriber Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PAT_PatientInformation_3 PAT_PatientInformation { get; set; }
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual All_NM1_837P_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(5)]
        public virtual List<Loop_2300_837P> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_2000C_837P> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel), "2000C")]
    public class Loop_2000C_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL_DependentLevel HL_PatientHierarchicalLevel { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual PAT_PatientInformation PAT_PatientInformation { get; set; }
        /// <summary>
        /// Loop for Patient Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual Loop_2010CA_837P Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<Loop_2300_837P> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_BillingProviderName_2), "2010AA")]
    public class Loop_2010AA_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_BillingProviderName_2 NM1_BillingProviderName { get; set; }
        /// <summary>
        /// Billing Provider Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress { get; set; }
        /// <summary>
        /// Billing Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_BillingProviderCity_State_ZIPCode { get; set; }
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual All_REF_837P_8 AllREF { get; set; }
        /// <summary>
        /// Billing Provider Contact Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-to Address Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_Pay), "2010AB")]
    public class Loop_2010AB_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_Pay NM1_Pay_AddressName { get; set; }
        /// <summary>
        /// Pay-To Address - ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_Pay_ToAddress_ADDRESS { get; set; }
        /// <summary>
        /// Pay-to Address City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_AddressCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_Pay_3), "2010AC")]
    public class Loop_2010AC_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-To Plan Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_Pay_3 NM1_Pay_ToPlanName { get; set; }
        /// <summary>
        /// Pay-To Plan Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_Pay_ToPlanAddress { get; set; }
        /// <summary>
        /// Pay-To Plan City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZIPCode { get; set; }
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual All_REF_837P_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_5), "2010BA")]
    public class Loop_2010BA_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_SubscriberName_5 NM1_SubscriberName { get; set; }
        /// <summary>
        /// Subscriber Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_SubscriberAddress { get; set; }
        /// <summary>
        /// Subscriber City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_SubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Subscriber Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG_PatientDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837P_4 AllREF { get; set; }
        /// <summary>
        /// Property and Casualty Subscriber Contact Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName), "2010BB")]
    public class Loop_2010BB_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerName NM1_PayerName { get; set; }
        /// <summary>
        /// Payer Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PayerAddress { get; set; }
        /// <summary>
        /// Payer City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PayerCity_State_ZIPCode { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_837P_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientName_3), "2010CA")]
    public class Loop_2010CA_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_PatientName_3 NM1_PatientName { get; set; }
        /// <summary>
        /// Patient Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientAddress { get; set; }
        /// <summary>
        /// Patient City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Demographic Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837P_7 AllREF { get; set; }
        /// <summary>
        /// Property and Casualty Patient Contact Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLM_ClaimInformation_3), "2300")]
    public class Loop_2300_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLM_ClaimInformation_3 CLM_ClaimInformation { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_DTP_837P_2 AllDTP { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<PWK_ClaimSupplementalInformation_3> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_REF_837P_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual NTE_ClaimNote_2 NTE_ClaimNote { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Spinal Manipulation Service Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual All_CRC_837P_2 AllCRC { get; set; }
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual All_HI_837P AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual All_NM1_837P_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_2320_837P> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(50)]
        [Pos(16)]
        public virtual List<Loop_2400_837P> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReferringProviderName), "2310A")]
    public class Loop_2310A_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification_2> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName), "2310B")]
    public class Loop_2310B_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_RenderingProviderName NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceFacilityLocation), "2310C")]
    public class Loop_2310C_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Facility Location Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName { get; set; }
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress { get; set; }
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
        /// <summary>
        /// Service Facility Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_PropertyandCasualtyPatientContactInformation PER_ServiceFacilityContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SupervisingProviderName), "2310D")]
    public class Loop_2310D_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AmbulancePick), "2310E")]
    public class Loop_2310E_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_AmbulancePick NM1_AmbulancePick_Location { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AmbulanceDrop), "2310F")]
    public class Loop_2310F_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_AmbulanceDrop NM1_AmbulanceDrop_Location { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBR_OtherSubscriberInformation), "2320")]
    public class Loop_2320_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Subscriber Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        /// <summary>
        /// Claim Level Adjustments
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_AMT_837P_2 AllAMT { get; set; }
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual All_NM1_837P_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherSubscriberName), "2330A")]
    public class Loop_2330A_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Subscriber Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        /// <summary>
        /// Other Subscriber Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress { get; set; }
        /// <summary>
        /// Other Subscriber City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName), "2330B")]
    public class Loop_2330B_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        /// <summary>
        /// Other Payer Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress { get; set; }
        /// <summary>
        /// Other Payer City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Claim Check or Remittance Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckorRemittanceDate { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837P AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerReferringProvider), "2330C")]
    public class Loop_2330C_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification_2> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2), "2330D")]
    public class Loop_2330D_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation), "2330E")]
    public class Loop_2330E_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Service Facility Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        /// <summary>
        /// Other Payer Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider), "2330F")]
    public class Loop_2330F_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerBillingProvider), "2330G")]
    public class Loop_2330G_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider { get; set; }
        /// <summary>
        /// Other Payer Billing Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber), "2400")]
    public class Loop_2400_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Number
        /// </summary>
        [SeqCount]
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX_HeaderNumber LX_ServiceLineNumber { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        /// <summary>
        /// Durable Medical Equipment Service
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_PWK_837P AllPWK { get; set; }
        /// <summary>
        /// Ambulance Transport Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_CRC_837P AllCRC { get; set; }
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual All_DTP_837P AllDTP { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual All_QTY_837P AllQTY { get; set; }
        /// <summary>
        /// Test Result
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<MEA_TestResult> MEA_TestResult { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual All_REF_837P_2 AllREF { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual All_AMT_837P AllAMT { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<K3_FileInformation> K3_FileInformation { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual All_NTE_837P AllNTE { get; set; }
        /// <summary>
        /// Purchased Service Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual HCP_LinePricing_3 HCP_LinePricing_RepricingInformation { get; set; }
        /// <summary>
        /// Loop for Drug Identification
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual Loop_2410_837P Loop2410 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual All_NM1_837P_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(20)]
        public virtual List<Loop_2430_837P> Loop2430 { get; set; }
        /// <summary>
        /// Loop for Form Identification Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_2440_837P> Loop2440 { get; set; }
    }
    
    /// <summary>
    /// Loop for Drug Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN_DrugIdentification_2), "2410")]
    public class Loop_2410_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Drug Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN_DrugIdentification_2 LIN_DrugIdentification { get; set; }
        /// <summary>
        /// Drug Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CTP_DrugQuantity CTP_DrugQuantity { get; set; }
        /// <summary>
        /// Prescription or Compound Drug Association Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName), "2420A")]
    public class Loop_2420A_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_RenderingProviderName NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification_2> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PurchasedServiceProviderName), "2420B")]
    public class Loop_2420B_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchased Service Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        /// <summary>
        /// Purchased Service Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceFacilityLocation), "2420C")]
    public class Loop_2420C_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Facility Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress { get; set; }
        /// <summary>
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<REF_BillingProviderSecondaryIdentification_2> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SupervisingProviderName), "2420D")]
    public class Loop_2420D_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification_2> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ordering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OrderingProviderName), "2420E")]
    public class Loop_2420E_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ordering Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        /// <summary>
        /// Ordering Provider Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_OrderingProviderAddress { get; set; }
        /// <summary>
        /// Ordering Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OrderingProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Ordering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        /// <summary>
        /// Ordering Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER_BillingProviderContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReferringProviderName), "2420F")]
    public class Loop_2420F_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AmbulancePick), "2420G")]
    public class Loop_2420G_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_AmbulancePick NM1_AmbulancePick_Location { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AmbulancePick_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Pick-up Location City, State, Zip Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AmbulancePick_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AmbulanceDrop), "2420H")]
    public class Loop_2420H_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_AmbulanceDrop NM1_AmbulanceDrop_Location { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_AmbulanceDrop_LocationAddress { get; set; }
        /// <summary>
        /// Ambulance Drop-off Location City, State, Zip Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_AmbulanceDrop_LocationCity_State_ZipCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVD_LineAdjudicationInformation_3), "2430")]
    public class Loop_2430_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Adjudication Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SVD_LineAdjudicationInformation_3 SVD_LineAdjudicationInformation { get; set; }
        /// <summary>
        /// Line Adjustment
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment { get; set; }
        /// <summary>
        /// Line Check or Remittance Date
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DTP_ClaimCheckOrRemittanceDate DTP_LineCheckorRemittanceDate { get; set; }
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    /// <summary>
    /// Loop for Form Identification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ_FormIdentificationCode), "2440")]
    public class Loop_2440_837P
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Form Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        /// <summary>
        /// Supporting Documentation
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim : Professional
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X222A1", "837")]
    public class TS837P : EdiMessage
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
        [Required]
        [Pos(2)]
        public virtual BHT_BeginningOfHierarchicalTransaction_8 BHT_BeginningOfHierarchicalTransaction { get; set; }
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual All_NM1_837P_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_2000A_837P> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
