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
    public class All_AMT_837I
    {
        
        /// <summary>
        /// Service Tax Amount
        /// </summary>
        [Pos(1)]
        public AMT_ServiceTaxAmount AMT_ServiceTaxAmount { get; set; }
        /// <summary>
        /// Facility Tax Amount
        /// </summary>
        [Pos(2)]
        public AMT_FacilityTaxAmount AMT_FacilityTaxAmount { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_837I_2
    {
        
        /// <summary>
        /// Coordination of Benefits (COB) Payer Paid Amount
        /// </summary>
        [Pos(1)]
        public AMT_CoordinationofBenefits AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        /// <summary>
        /// Remaining Patient Liability
        /// </summary>
        [Pos(2)]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
        /// <summary>
        /// Coordination of Benefits (COB) Total Non-covered Amount
        /// </summary>
        [Pos(3)]
        public AMT_CoordinationofBenefits_2 AMT_CoordinationofBenefits_COB_TotalNon_Amount { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_837I
    {
        
        /// <summary>
        /// Discharge Hour
        /// </summary>
        [Pos(1)]
        public DTP_DischargeHour DTP_DischargeHour { get; set; }
        /// <summary>
        /// Statement Dates
        /// </summary>
        [Pos(2)]
        public DTP_StatementDates DTP_StatementDates { get; set; }
        /// <summary>
        /// Admission Date/Hour
        /// </summary>
        [Pos(3)]
        public DTP_AdmissionDate DTP_AdmissionDate_Hour { get; set; }
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        [Pos(4)]
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_HI_837I
    {
        
        /// <summary>
        /// Principal Diagnosis
        /// </summary>
        [Pos(1)]
        public HI_PrincipalDiagnosis HI_PrincipalDiagnosis { get; set; }
        /// <summary>
        /// Admitting Diagnosis
        /// </summary>
        [Pos(2)]
        public HI_AdmittingDiagnosis HI_AdmittingDiagnosis { get; set; }
        /// <summary>
        /// Patient's Reason For Visit
        /// </summary>
        [Pos(3)]
        public HI_Patient HI_Patient_ReasonForVisit { get; set; }
        /// <summary>
        /// External Cause of Injury
        /// </summary>
        [Pos(4)]
        public HI_ExternalCauseofInjury HI_ExternalCauseofInjury { get; set; }
        /// <summary>
        /// Diagnosis Related Group (DRG) Information
        /// </summary>
        [Pos(5)]
        public HI_DiagnosisRelatedGroup HI_DiagnosisRelatedGroup_DRG_Information { get; set; }
        /// <summary>
        /// Other Diagnosis Information
        /// </summary>
        [Pos(6)]
        public List<HI_OtherDiagnosisInformation> HI_OtherDiagnosisInformation { get; set; }
        /// <summary>
        /// Principal Procedure Information
        /// </summary>
        [Pos(7)]
        public HI_PrincipalProcedureInformation HI_PrincipalProcedureInformation { get; set; }
        /// <summary>
        /// Other Procedure Information
        /// </summary>
        [Pos(8)]
        public List<HI_OtherProcedureInformation> HI_OtherProcedureInformation { get; set; }
        /// <summary>
        /// Occurrence Span Information
        /// </summary>
        [Pos(9)]
        public List<HI_OccurrenceSpanInformation> HI_OccurrenceSpanInformation { get; set; }
        /// <summary>
        /// Occurrence Information
        /// </summary>
        [Pos(10)]
        public List<HI_OccurrenceInformation> HI_OccurrenceInformation { get; set; }
        /// <summary>
        /// Value Information
        /// </summary>
        [Pos(11)]
        public List<HI_ValueInformation> HI_ValueInformation { get; set; }
        /// <summary>
        /// Condition Information
        /// </summary>
        [Pos(12)]
        public List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
        /// <summary>
        /// Treatment Code Information
        /// </summary>
        [Pos(13)]
        public List<HI_TreatmentCodeInformation> HI_TreatmentCodeInformation { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I
    {
        
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2010AA_837I Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [Pos(2)]
        public Loop_2010AB_837I Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [Pos(3)]
        public Loop_2010AC_837I Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I_2
    {
        
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2010BA_837I Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2010BB_837I Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I_3
    {
        
        /// <summary>
        /// Loop for Attending Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2310A_837I Loop2310A { get; set; }
        /// <summary>
        /// Loop for Operating Physician Name
        /// </summary>
        [Pos(2)]
        public Loop_2310B_837I Loop2310B { get; set; }
        /// <summary>
        /// Loop for Other Operating Physician Name
        /// </summary>
        [Pos(3)]
        public Loop_2310C_837I Loop2310C { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(4)]
        public Loop_2310D_837I Loop2310D { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [Pos(5)]
        public Loop_2310E_837I Loop2310E { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [Pos(6)]
        public Loop_2310F_837I Loop2310F { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I_4
    {
        
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2330A_837I Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2330B_837I Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Attending Provider
        /// </summary>
        [Pos(3)]
        public Loop_2330C_837I Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Operating Physician
        /// </summary>
        [Pos(4)]
        public Loop_2330D_837I Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Other Operating Physician
        /// </summary>
        [Pos(5)]
        public Loop_2330E_837I Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [Pos(6)]
        public Loop_2330F_837I Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider Name
        /// </summary>
        [Pos(7)]
        public Loop_2330G_837I Loop2330G { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [Pos(8)]
        public Loop_2330H_837I Loop2330H { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [Pos(9)]
        public Loop_2330I_837I Loop2330I { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I_5
    {
        
        /// <summary>
        /// Loop for Operating Physician Name
        /// </summary>
        [Pos(1)]
        public Loop_2420A_837I Loop2420A { get; set; }
        /// <summary>
        /// Loop for Other Operating Physician Name
        /// </summary>
        [Pos(2)]
        public Loop_2420B_837I Loop2420B { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(3)]
        public Loop_2420C_837I Loop2420C { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [Pos(4)]
        public Loop_2420D_837I Loop2420D { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837I_6
    {
        
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [Pos(1)]
        public Loop_1000A_837I Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [Pos(2)]
        public Loop_1000B_837I Loop1000B { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NTE_837I
    {
        
        /// <summary>
        /// Claim Note
        /// </summary>
        [Pos(1)]
        public List<NTE_ClaimNote> NTE_ClaimNote { get; set; }
        /// <summary>
        /// Billing Note
        /// </summary>
        [Pos(2)]
        public NTE_BillingNote NTE_BillingNote { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837I
    {
        
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [Pos(1)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Repriced Line Item Reference Number
        /// </summary>
        [Pos(2)]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Line Item Reference Number
        /// </summary>
        [Pos(3)]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837I_2
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
    public class All_REF_837I_3
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
        public REF_BillingProviderSecondaryIdentification REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837I_4
    {
        
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        [Pos(1)]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [Pos(2)]
        public REF_OtherPayerReferralNumber REF_ReferralNumber { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [Pos(3)]
        public REF_OtherPayerPriorAuthorizationNumber REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [Pos(4)]
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [Pos(5)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [Pos(6)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Investigational Device Exemption Number
        /// </summary>
        [Pos(7)]
        public List<REF_InvestigationalDeviceExemptionNumber> REF_InvestigationalDeviceExemptionNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [Pos(8)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        /// <summary>
        /// Auto Accident State
        /// </summary>
        [Pos(9)]
        public REF_ApplicationorLocationSystemIdentifier REF_AutoAccidentState { get; set; }
        /// <summary>
        /// Medical Record Number
        /// </summary>
        [Pos(10)]
        public REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        /// <summary>
        /// Demonstration Project Identifier
        /// </summary>
        [Pos(11)]
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        /// <summary>
        /// Peer Review Organization (PRO) Approval Number
        /// </summary>
        [Pos(12)]
        public REF_PeerReviewOrganization REF_PeerReviewOrganization_PRO_ApprovalNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837I_5
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
    public class All_REF_837I_6
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
    public class All_REF_837I_7
    {
        
        /// <summary>
        /// Pay-To Plan Secondary Identification
        /// </summary>
        [Pos(1)]
        public REF_Pay REF_Pay_ToPlanSecondaryIdentification { get; set; }
        /// <summary>
        /// Pay-To Tax Identification Number
        /// </summary>
        [Pos(2)]
        public REF_BillingProviderTaxIdentification_2 REF_Pay_ToTaxIdentificationNumber { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InformationReceiverName_2))]
    public class Loop_1000A_837I
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
    public class Loop_1000B_837I
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
    public class Loop_2000A_837I
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
        public All_NM1_837I AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000B_837I> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_837I
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
        [Pos(3)]
        public All_NM1_837I_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim information
        /// </summary>
        [Pos(4)]
        public List<Loop_2300_837I_2> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000C_837I> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_837I
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
        public Loop_2010CA_837I Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim information
        /// </summary>
        [Pos(4)]
        public List<Loop_2300_837I> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName_2))]
    public class Loop_2010AA_837I
    {
        
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_BillingProviderName_2 NM1_BillingProviderName { get; set; }
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
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        [Pos(4)]
        public REF_BillingProviderTaxIdentification_2 REF_BillingProviderTaxIdentification { get; set; }
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
    [Group(typeof(NM1_Pay_2))]
    public class Loop_2010AB_837I
    {
        
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [Pos(1)]
        public NM1_Pay_2 NM1_Pay_AddressName { get; set; }
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
    public class Loop_2010AC_837I
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
        /// Pay-To Plan City/State/Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZipCode { get; set; }
        [Pos(4)]
        public All_REF_837I_7 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2010BA_837I
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
        public All_REF_837I_2 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2010BB_837I
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
        public All_REF_837I_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2010CA_837I
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
        /// Patient City/State/ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_PatientCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Patient Demographic Information
        /// </summary>
        [Pos(4)]
        public DMG_DependentDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_837I_6 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837I
    {
        
        /// <summary>
        /// Claim information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_Claiminformation { get; set; }
        [Pos(2)]
        public All_DTP_837I AllDTP { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [Pos(3)]
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(4)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(5)]
        public CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Estimated Amount Due
        /// </summary>
        [Pos(6)]
        public AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue { get; set; }
        [Pos(7)]
        public All_REF_837I_4 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(8)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [Pos(9)]
        public All_NTE_837I AllNTE { get; set; }
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        [Pos(10)]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
        [Pos(11)]
        public All_HI_837I AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(12)]
        public HCP_ClaimPricing_2 HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(13)]
        public All_NM1_837I_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(14)]
        public List<Loop_2320_837I> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(15)]
        public List<Loop_2400_837I> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837I_2
    {
        
        /// <summary>
        /// Claim information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_Claiminformation { get; set; }
        [Pos(2)]
        public All_DTP_837I AllDTP { get; set; }
        /// <summary>
        /// Institutional Claim Code
        /// </summary>
        [Pos(3)]
        public CL1_InstitutionalClaimCode CL1_InstitutionalClaimCode { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(4)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(5)]
        public CN1_ContractInformation_2 CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Estimated Amount Due
        /// </summary>
        [Pos(6)]
        public AMT_PatientEstimatedAmountDue AMT_PatientEstimatedAmountDue { get; set; }
        [Pos(7)]
        public All_REF_837I_4 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(8)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [Pos(9)]
        public All_NTE_837I AllNTE { get; set; }
        /// <summary>
        /// EPSDT Referral
        /// </summary>
        [Pos(10)]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
        [Pos(11)]
        public All_HI_837I AllHI { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(12)]
        public HCP_ClaimPricing_2 HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(13)]
        public All_NM1_837I_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(14)]
        public List<Loop_2320_837I> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(15)]
        public List<Loop_2400_837I> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Attending Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AttendingProviderName))]
    public class Loop_2310A_837I
    {
        
        /// <summary>
        /// Attending Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_AttendingProviderName NM1_AttendingProviderName { get; set; }
        /// <summary>
        /// Attending Provider Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_AttendingProviderSpecialtyInformation PRV_AttendingProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Attending Provider Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AttendingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Operating Physician Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OperatingPhysicianName))]
    public class Loop_2310B_837I
    {
        
        /// <summary>
        /// Operating Physician Name
        /// </summary>
        [Pos(1)]
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName { get; set; }
        /// <summary>
        /// Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherOperatingPhysicianName))]
    public class Loop_2310C_837I
    {
        
        /// <summary>
        /// Other Operating Physician Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName { get; set; }
        /// <summary>
        /// Other Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2310D_837I
    {
        
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2310E_837I
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
        /// Service Facility Location City/State/ZIP
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIP { get; set; }
        /// <summary>
        /// Service Facility Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilitySecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider_2))]
    public class Loop_2310F_837I
    {
        
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider_2 NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SBR_OtherSubscriberInformation))]
    public class Loop_2320_837I
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
        public All_AMT_837I_2 AllAMT { get; set; }
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        [Pos(4)]
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        /// <summary>
        /// Inpatient Adjudication Information
        /// </summary>
        [Pos(5)]
        public MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [Pos(6)]
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [Pos(7)]
        public All_NM1_837I_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2330A_837I
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
        /// Other Subscriber City/State/ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Information
        /// </summary>
        [Pos(4)]
        public List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2330B_837I
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
        /// Other Payer City/State/ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Claim Check Or Remittance Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckOrRemittanceDate { get; set; }
        [Pos(5)]
        public All_REF_837I_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Attending Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AttendingProviderName))]
    public class Loop_2330C_837I
    {
        
        /// <summary>
        /// Other Payer Attending Provider
        /// </summary>
        [Pos(1)]
        public NM1_AttendingProviderName NM1_OtherPayerAttendingProvider { get; set; }
        /// <summary>
        /// Other Payer Attending Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAttendingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Operating Physician
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OperatingPhysicianName))]
    public class Loop_2330D_837I
    {
        
        /// <summary>
        /// Other Payer Operating Physician
        /// </summary>
        [Pos(1)]
        public NM1_OperatingPhysicianName NM1_OtherPayerOperatingPhysician { get; set; }
        /// <summary>
        /// Other Payer Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Other Operating Physician
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherOperatingPhysicianName))]
    public class Loop_2330E_837I
    {
        
        /// <summary>
        /// Other Payer Other Operating Physician
        /// </summary>
        [Pos(1)]
        public NM1_OtherOperatingPhysicianName NM1_OtherPayerOtherOperatingPhysician { get; set; }
        /// <summary>
        /// Other Payer Other Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerOtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330F_837I
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
    /// Loop for Other Payer Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2330G_837I
    {
        
        /// <summary>
        /// Other Payer Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProviderName { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identifier
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider_2))]
    public class Loop_2330H_837I
    {
        
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider { get; set; }
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName_2))]
    public class Loop_2330I_837I
    {
        
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        [Pos(1)]
        public NM1_BillingProviderName_2 NM1_OtherPayerBillingProvider { get; set; }
        /// <summary>
        /// Other Payer Billing Provider Secondary Identifier
        /// </summary>
        [Pos(2)]
        public List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_837I
    {
        
        /// <summary>
        /// Service Line Number
        /// </summary>
        [Pos(1)]
        public LX_HeaderNumber LX_ServiceLineNumber { get; set; }
        /// <summary>
        /// Institutional Service Line
        /// </summary>
        [Pos(2)]
        public SV2_InstitutionalServiceLine SV2_InstitutionalServiceLine { get; set; }
        /// <summary>
        /// Line Supplemental Information
        /// </summary>
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_LineSupplementalInformation { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
        [Pos(5)]
        public All_REF_837I AllREF { get; set; }
        [Pos(6)]
        public All_AMT_837I AllAMT { get; set; }
        /// <summary>
        /// Third Party Organization Notes
        /// </summary>
        [Pos(7)]
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [Pos(8)]
        public HCP_ClaimPricing_2 HCP_LinePricing_RepricingInformation { get; set; }
        /// <summary>
        /// Loop for Drug Identification
        /// </summary>
        [Pos(9)]
        public Loop_2410_837I Loop2410 { get; set; }
        [Pos(10)]
        public All_NM1_837I_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [Pos(11)]
        public List<Loop_2430_837I> Loop2430 { get; set; }
    }
    
    /// <summary>
    /// Loop for Drug Identification
    /// </summary>
    [Serializable()]
    [Group(typeof(LIN_DrugIdentification))]
    public class Loop_2410_837I
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
    /// Loop for Operating Physician Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OperatingPhysicianName))]
    public class Loop_2420A_837I
    {
        
        /// <summary>
        /// Operating Physician Name
        /// </summary>
        [Pos(1)]
        public NM1_OperatingPhysicianName NM1_OperatingPhysicianName { get; set; }
        /// <summary>
        /// Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherOperatingPhysicianName))]
    public class Loop_2420B_837I
    {
        
        /// <summary>
        /// Other Operating Physician Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherOperatingPhysicianName NM1_OtherOperatingPhysicianName { get; set; }
        /// <summary>
        /// Other Operating Physician Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherOperatingPhysicianSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2420C_837I
    {
        
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider NM1_RenderingProviderName { get; set; }
        /// <summary>
        /// Rendering Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider_2))]
    public class Loop_2420D_837I
    {
        
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider_2 NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVD_LineAdjudicationInformation))]
    public class Loop_2430_837I
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
    /// Health Care Claim : Institutional
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X223A2", "837")]
    public class TS837I : EdiMessage
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
        public All_NM1_837I_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000A_837I> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(5)]
        public SE SE { get; set; }
    }
}
