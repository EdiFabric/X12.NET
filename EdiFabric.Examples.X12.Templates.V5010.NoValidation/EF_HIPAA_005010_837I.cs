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
    public class All_AMT_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Tax Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual AMT_ServiceTaxAmount AMT_ServiceTaxAmount { get; set; }
        /// <summary>
        /// Facility Tax Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT_FacilityTaxAmount AMT_FacilityTaxAmount { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_AMT_837I_2
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
        /// Remaining Patient Liability
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
        /// <summary>
        /// Coordination of Benefits (COB) Total Non-covered Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Discharge Hour
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_DischargeHour DTP_DischargeHour { get; set; }
        /// <summary>
        /// Statement Dates
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_StatementDates DTP_StatementDates { get; set; }
        /// <summary>
        /// Admission Date/Hour
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_AdmissionDate DTP_AdmissionDate_Hour { get; set; }
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_HI_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Principal Diagnosis
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HI_PrincipalDiagnosis HI_PrincipalDiagnosis { get; set; }
        /// <summary>
        /// Admitting Diagnosis
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual HI_AdmittingDiagnosis HI_AdmittingDiagnosis { get; set; }
        /// <summary>
        /// Patient's Reason For Visit
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual HI_Patient HI_Patient_ReasonForVisit { get; set; }
        /// <summary>
        /// External Cause of Injury
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual HI_ExternalCauseofInjury HI_ExternalCauseofInjury { get; set; }
        /// <summary>
        /// Diagnosis Related Group (DRG) Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual HI_DiagnosisRelatedGroup HI_DiagnosisRelatedGroup_DRG_Information { get; set; }
        /// <summary>
        /// Other Diagnosis Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<HI_OtherDiagnosisInformation> HI_OtherDiagnosisInformation { get; set; }
        /// <summary>
        /// Principal Procedure Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual HI_PrincipalProcedureInformation HI_PrincipalProcedureInformation { get; set; }
        /// <summary>
        /// Other Procedure Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<HI_OtherProcedureInformation> HI_OtherProcedureInformation { get; set; }
        /// <summary>
        /// Occurrence Span Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<HI_OccurrenceSpanInformation> HI_OccurrenceSpanInformation { get; set; }
        /// <summary>
        /// Occurrence Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<HI_OccurrenceInformation> HI_OccurrenceInformation { get; set; }
        /// <summary>
        /// Value Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<HI_ValueInformation> HI_ValueInformation { get; set; }
        /// <summary>
        /// Condition Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
        /// <summary>
        /// Treatment Code Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<HI_TreatmentCodeInformation> HI_TreatmentCodeInformation { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2010AA_837I Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010AB_837I Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2010AC_837I Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2010BA_837I Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010BB_837I Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Attending Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2310A_837I Loop2310A { get; set; }
        /// <summary>
        /// Loop for Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2310B_837I Loop2310B { get; set; }
        /// <summary>
        /// Loop for Other Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2310C_837I Loop2310C { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2310D_837I Loop2310D { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2310E_837I Loop2310E { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2310F_837I Loop2310F { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2330A_837I Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2330B_837I Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Attending Provider
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2330C_837I Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Operating Physician
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2330D_837I Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Other Operating Physician
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2330E_837I Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2330F_837I Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_2330G_837I Loop2330G { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_2330H_837I Loop2330H { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Loop_2330I_837I Loop2330I { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I_5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2420A_837I Loop2420A { get; set; }
        /// <summary>
        /// Loop for Other Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2420B_837I Loop2420B { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2420C_837I Loop2420C { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2420D_837I Loop2420D { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837I_6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_1000A_837I Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_1000B_837I Loop1000B { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NTE_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<NTE_ClaimNote> NTE_ClaimNote { get; set; }
        /// <summary>
        /// Billing Note
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NTE_BillingNote NTE_BillingNote { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Repriced Line Item Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Line Item Reference Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837I_2
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
    public class All_REF_837I_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<REF_OtherPayerSecondaryIdentifier> REF_PayerSecondaryIdentification { get; set; }
        /// <summary>
        /// Billing Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_BillingProviderSecondaryIdentification REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837I_4
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
        /// Referral Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_OtherPayerReferralNumber REF_ReferralNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Investigational Device Exemption Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<REF_InvestigationalDeviceExemptionNumber> REF_InvestigationalDeviceExemptionNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Auto Accident State
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual REF_ApplicationorLocationSystemIdentifier REF_AutoAccidentState { get; set; }
        /// <summary>
        /// Medical Record Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        /// <summary>
        /// Demonstration Project Identifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        /// <summary>
        /// Peer Review Organization (PRO) Approval Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual REF_PeerReviewOrganization REF_PeerReviewOrganization_PRO_ApprovalNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837I_5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Secondary Identifier
        /// </summary>
        [DataMember]
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
    public class All_REF_837I_6
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
    public class All_REF_837I_7
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
        /// Pay-To Tax Identification Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_BillingProviderTaxIdentification_2 REF_Pay_ToTaxIdentificationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_4))]
    public class Loop_1000A_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Submitter Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_InformationReceiverName_4 NM1_SubmitterName { get; set; }
        /// <summary>
        /// Submitter EDI Contact Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PER_BillingProviderContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReceiverName))]
    public class Loop_1000B_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Receiver Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_BillingProviderHierarchicalLevel))]
    public class Loop_2000A_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Hierarchical Level
        /// </summary>
        [DataMember]
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
        [Pos(4)]
        public virtual All_NM1_837I AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2000B_837I> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        /// <summary>
        /// Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SBR_SubscriberInformation_2 SBR_SubscriberInformation { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_NM1_837I_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2300_837I> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2000C_837I> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HL_DependentLevel HL_PatientHierarchicalLevel { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PAT_PatientInformation_2 PAT_PatientInformation { get; set; }
        /// <summary>
        /// Loop for Patient Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2010CA_837I Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2300_837I> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_BillingProviderName_3))]
    public class Loop_2010AA_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_BillingProviderName_3 NM1_BillingProviderName { get; set; }
        /// <summary>
        /// Billing Provider Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_BillingProviderAddress { get; set; }
        /// <summary>
        /// Billing Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_BillingProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_BillingProviderTaxIdentification_2 REF_BillingProviderTaxIdentification { get; set; }
        /// <summary>
        /// Billing Provider Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-to Address Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_Pay_2))]
    public class Loop_2010AB_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_Pay_2 NM1_Pay_AddressName { get; set; }
        /// <summary>
        /// Pay-To Address - ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_Pay_ToAddress_ADDRESS { get; set; }
        /// <summary>
        /// Pay-to Address City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_AddressCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_Pay_3))]
    public class Loop_2010AC_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-To Plan Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_Pay_3 NM1_Pay_ToPlanName { get; set; }
        /// <summary>
        /// Pay-To Plan Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_Pay_ToPlanAddress { get; set; }
        /// <summary>
        /// Pay-To Plan City/State/Zip Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZipCode { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_837I_7 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_5))]
    public class Loop_2010BA_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Name
        /// </summary>
        [DataMember]
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
        public virtual All_REF_837I_2 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2010BB_837I
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
        public virtual All_REF_837I_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientName_3))]
    public class Loop_2010CA_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_PatientName_3 NM1_PatientName { get; set; }
        /// <summary>
        /// Patient Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PatientAddress { get; set; }
        /// <summary>
        /// Patient City/State/ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837I_6 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLM_ClaimInformation_2))]
    public class Loop_2300_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CLM_ClaimInformation_2 CLM_ClaimInformation { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_DTP_837I AllDTP { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Estimated Amount Due
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_REF_837I_4 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<K3_FileInformation> K3_FileInformation { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual All_NTE_837I AllNTE { get; set; }
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual All_HI_837I AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual HCP_ClaimPricing_2 HCP_ClaimPricing_RepricingInformation { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual All_NM1_837I_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_2320_837I> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_2400_837I> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Attending Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AttendingProviderName))]
    public class Loop_2310A_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Attending Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_AttendingProviderName NM1_AttendingProviderName { get; set; }
        /// <summary>
        /// Attending Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_AttendingProviderSpecialtyInformation PRV_AttendingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Attending Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_AttendingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OperatingPhysicianName))]
    public class Loop_2310B_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OperatingPhysicianName NM1_OperatingPhysicianName { get; set; }
        /// <summary>
        /// Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherOperatingPhysicianName))]
    public class Loop_2310C_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName { get; set; }
        /// <summary>
        /// Other Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName_2))]
    public class Loop_2310D_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_RenderingProviderName_2 NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceFacilityLocation))]
    public class Loop_2310E_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Facility Location Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ServiceFacilityLocation NM1_ServiceFacilityLocationName { get; set; }
        /// <summary>
        /// Service Facility Location Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ServiceFacilityLocationAddress { get; set; }
        /// <summary>
        /// Service Facility Location City/State/ZIP
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIP { get; set; }
        /// <summary>
        /// Service Facility Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilitySecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReferringProviderName_2))]
    public class Loop_2310F_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ReferringProviderName_2 NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBR_OtherSubscriberInformation_2))]
    public class Loop_2320_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation { get; set; }
        /// <summary>
        /// Claim Level Adjustments
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_AMT_837I_2 AllAMT { get; set; }
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation { get; set; }
        /// <summary>
        /// Inpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_NM1_837I_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherSubscriberName))]
    public class Loop_2330A_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        /// <summary>
        /// Other Subscriber Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_OtherSubscriberAddress { get; set; }
        /// <summary>
        /// Other Subscriber City/State/ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2330B_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        /// <summary>
        /// Other Payer Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_OtherPayerAddress { get; set; }
        /// <summary>
        /// Other Payer City/State/ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Claim Check Or Remittance Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckOrRemittanceDate { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837I_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Attending Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerAttendingProvider))]
    public class Loop_2330C_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Attending Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerAttendingProvider NM1_OtherPayerAttendingProvider { get; set; }
        /// <summary>
        /// Other Payer Attending Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAttendingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Operating Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerOperatingPhysician))]
    public class Loop_2330D_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Operating Physician
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerOperatingPhysician NM1_OtherPayerOperatingPhysician { get; set; }
        /// <summary>
        /// Other Payer Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Other Operating Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerOtherOperatingPhysician))]
    public class Loop_2330E_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Other Operating Physician
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerOtherOperatingPhysician NM1_OtherPayerOtherOperatingPhysician { get; set; }
        /// <summary>
        /// Other Payer Other Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330F_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Service Facility Location
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        /// <summary>
        /// Other Payer Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2330G_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProviderName { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerReferringProvider_2))]
    public class Loop_2330H_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider { get; set; }
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerBillingProvider_2))]
    public class Loop_2330I_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerBillingProvider_2 NM1_OtherPayerBillingProvider { get; set; }
        /// <summary>
        /// Other Payer Billing Provider Secondary Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LX_HeaderNumber LX_ServiceLineNumber { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Line Supplemental Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_837I AllREF { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_AMT_837I AllAMT { get; set; }
        /// <summary>
        /// Third Party Organization Notes
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HCP_LinePricing_2 HCP_LinePricing_RepricingInformation { get; set; }
        /// <summary>
        /// Loop for Drug Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Loop_2410_837I Loop2410 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual All_NM1_837I_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_2430_837I> Loop2430 { get; set; }
    }
    
    /// <summary>
    /// Loop for Drug Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN_DrugIdentification))]
    public class Loop_2410_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Drug Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        /// <summary>
        /// Drug Quantity
        /// </summary>
        [DataMember]
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
    /// Loop for Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OperatingPhysicianName))]
    public class Loop_2420A_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OperatingPhysicianName NM1_OperatingPhysicianName { get; set; }
        /// <summary>
        /// Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherOperatingPhysicianName))]
    public class Loop_2420B_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Operating Physician Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName { get; set; }
        /// <summary>
        /// Other Operating Physician Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName_2))]
    public class Loop_2420C_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_RenderingProviderName_2 NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReferringProviderName_2))]
    public class Loop_2420D_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ReferringProviderName_2 NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVD_LineAdjudicationInformation_2))]
    public class Loop_2430_837I
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVD_LineAdjudicationInformation_2 SVD_LineAdjudicationInformation { get; set; }
        /// <summary>
        /// Line Adjustment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<CAS_ClaimLevelAdjustments> CAS_LineAdjustment { get; set; }
        /// <summary>
        /// Line Check or Remittance Date
        /// </summary>
        [DataMember]
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
    /// Health Care Claim : Institutional
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X223A2", "837")]
    public class TS837I : EdiMessage
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
        public virtual BHT_BeginningOfHierarchicalTransaction_8 BHT_BeginningOfHierarchicalTransaction { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_NM1_837I_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000A_837I> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
