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
    public class All_AMT_837D
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
    public class All_DTP_837D
    {
        
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [Pos(1)]
        public DTP_ServiceDate DTP_Date_ServiceDate { get; set; }
        /// <summary>
        /// Date - Prior Placement
        /// </summary>
        [Pos(2)]
        public DTP_PriorPlacement DTP_Date_PriorPlacement { get; set; }
        /// <summary>
        /// Date - Appliance Placement
        /// </summary>
        [Pos(3)]
        public DTP_AppliancePlacement DTP_Date_AppliancePlacement { get; set; }
        /// <summary>
        /// Date - Replacement
        /// </summary>
        [Pos(4)]
        public DTP_Replacement DTP_Date_Replacement { get; set; }
        /// <summary>
        /// Date - Treatment Start
        /// </summary>
        [Pos(5)]
        public DTP_TreatmentStart DTP_Date_TreatmentStart { get; set; }
        /// <summary>
        /// Date - Treatment Completion
        /// </summary>
        [Pos(6)]
        public DTP_TreatmentCompletion DTP_Date_TreatmentCompletion { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_837D_2
    {
        
        /// <summary>
        /// Date - Accident
        /// </summary>
        [Pos(1)]
        public DTP_AccidentDate_2 DTP_Date_Accident { get; set; }
        /// <summary>
        /// Date - Appliance Placement
        /// </summary>
        [Pos(2)]
        public DTP_AppliancePlacement DTP_Date_AppliancePlacement { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [Pos(3)]
        public DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
        /// <summary>
        /// Date - Repricer Received Date
        /// </summary>
        [Pos(4)]
        public DTP_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D
    {
        
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2010AA_837D Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [Pos(2)]
        public Loop_2010AB_837D Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [Pos(3)]
        public Loop_2010AC_837D Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D_2
    {
        
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2010BA_837D Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2010BB_837D Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D_3
    {
        
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [Pos(1)]
        public List<Loop_2310A_837D> Loop2310A { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(2)]
        public Loop_2310B_837D Loop2310B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [Pos(3)]
        public Loop_2310C_837D Loop2310C { get; set; }
        /// <summary>
        /// Loop for Assistant Surgeon Name
        /// </summary>
        [Pos(4)]
        public Loop_2310D_837D Loop2310D { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [Pos(5)]
        public Loop_2310E_837D Loop2310E { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D_4
    {
        
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [Pos(1)]
        public Loop_2330A_837D Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [Pos(2)]
        public Loop_2330B_837D Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [Pos(3)]
        public List<Loop_2330C_837D> Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider
        /// </summary>
        [Pos(4)]
        public Loop_2330D_837D Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Supervising Provider
        /// </summary>
        [Pos(5)]
        public Loop_2330E_837D Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [Pos(6)]
        public Loop_2330F_837D Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [Pos(7)]
        public Loop_2330G_837D Loop2330G { get; set; }
        /// <summary>
        /// Loop for Other Payer Assistant Surgeon
        /// </summary>
        [Pos(8)]
        public Loop_2330H_837D Loop2330H { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D_5
    {
        
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [Pos(1)]
        public Loop_2420A_837D Loop2420A { get; set; }
        /// <summary>
        /// Loop for Assistant Surgeon Name
        /// </summary>
        [Pos(2)]
        public Loop_2420B_837D Loop2420B { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [Pos(3)]
        public Loop_2420C_837D Loop2420C { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [Pos(4)]
        public Loop_2420D_837D Loop2420D { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_837D_6
    {
        
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [Pos(1)]
        public Loop_1000A_837D Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [Pos(2)]
        public Loop_1000B_837D Loop1000B { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837D
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
        /// Other Payer Predetermination Identification
        /// </summary>
        [Pos(5)]
        public REF_OtherPayerPredeterminationIdentification REF_OtherPayerPredeterminationIdentification { get; set; }
        /// <summary>
        /// Other Payer Claim Control Number
        /// </summary>
        [Pos(6)]
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837D_2
    {
        
        /// <summary>
        /// Service Predetermination Identification
        /// </summary>
        [Pos(1)]
        public List<REF_OtherPayerPredeterminationIdentification> REF_ServicePredeterminationIdentification { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [Pos(2)]
        public List<REF_OtherPayerPriorAuthorizationNumber> REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [Pos(3)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [Pos(4)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [Pos(5)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [Pos(6)]
        public List<REF_OtherPayerReferralNumber> REF_ReferralNumber { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837D_3
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
    public class All_REF_837D_4
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
    public class All_REF_837D_5
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
    public class All_REF_837D_6
    {
        
        /// <summary>
        /// Predetermination Identification
        /// </summary>
        [Pos(1)]
        public REF_OtherPayerPredeterminationIdentification REF_PredeterminationIdentification { get; set; }
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        [Pos(2)]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [Pos(3)]
        public REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
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
        /// Repriced Claim Number
        /// </summary>
        [Pos(6)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [Pos(7)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [Pos(8)]
        public REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_837D_7
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
    public class All_REF_837D_8
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
    public class Loop_1000A_837D
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
    public class Loop_1000B_837D
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
    public class Loop_2000A_837D
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
        public All_NM1_837D AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000B_837D> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_837D
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
        public All_NM1_837D_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [Pos(4)]
        public List<Loop_2300_837D_2> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [Pos(5)]
        public List<Loop_2000C_837D> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_837D
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
        public Loop_2010CA_837D Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [Pos(4)]
        public List<Loop_2300_837D> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2010AA_837D
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
        public All_REF_837D_8 AllREF { get; set; }
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
    public class Loop_2010AB_837D
    {
        
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [Pos(1)]
        public NM1_Pay NM1_Pay_AddressName { get; set; }
        /// <summary>
        /// Pay-to Address - ADDRESS
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_Pay_Address_ADDRESS { get; set; }
        /// <summary>
        /// Pay-to Address - City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_Pay_Address_City_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_Pay_3))]
    public class Loop_2010AC_837D
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
        /// Pay-To Plan City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZipCode { get; set; }
        [Pos(4)]
        public All_REF_837D_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2010BA_837D
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
        public All_REF_837D_4 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2010BB_837D
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
        public All_REF_837D_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DependentName_2))]
    public class Loop_2010CA_837D
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
        public All_REF_837D_7 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837D
    {
        
        /// <summary>
        /// Claim Information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP_837D_2 AllDTP { get; set; }
        /// <summary>
        /// Orthodontic Total Months of Treatment
        /// </summary>
        [Pos(3)]
        public DN1_OrthodonticTotalMonthsofTreatment DN1_OrthodonticTotalMonthsofTreatment { get; set; }
        /// <summary>
        /// Tooth Status
        /// </summary>
        [Pos(4)]
        public List<DN2_ToothStatus> DN2_ToothStatus { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(5)]
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(6)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [Pos(7)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [Pos(8)]
        public All_REF_837D_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(9)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [Pos(10)]
        public List<NTE_BillingNote> NTE_ClaimNote { get; set; }
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        [Pos(11)]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(12)]
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(13)]
        public All_NM1_837D_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(14)]
        public List<Loop_2320_837D> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(15)]
        public List<Loop_2400_837D> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837D_2
    {
        
        /// <summary>
        /// Claim Information
        /// </summary>
        [Pos(1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP_837D_2 AllDTP { get; set; }
        /// <summary>
        /// Orthodontic Total Months of Treatment
        /// </summary>
        [Pos(3)]
        public DN1_OrthodonticTotalMonthsofTreatment DN1_OrthodonticTotalMonthsofTreatment { get; set; }
        /// <summary>
        /// Tooth Status
        /// </summary>
        [Pos(4)]
        public List<DN2_ToothStatus> DN2_ToothStatus { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [Pos(5)]
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(6)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [Pos(7)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [Pos(8)]
        public All_REF_837D_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(9)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [Pos(10)]
        public List<NTE_BillingNote> NTE_ClaimNote { get; set; }
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        [Pos(11)]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [Pos(12)]
        public HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(13)]
        public All_NM1_837D_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [Pos(14)]
        public List<Loop_2320_837D> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [Pos(15)]
        public List<Loop_2400_837D> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2310A_837D
    {
        
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerReferringProvider NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2310B_837D
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
    public class Loop_2310C_837D
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
        /// Service Facility Location City, State, Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZipCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AssistantSurgeonName))]
    public class Loop_2310D_837D
    {
        
        /// <summary>
        /// Assistant Surgeon Name
        /// </summary>
        [Pos(1)]
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName { get; set; }
        /// <summary>
        /// Assistant Surgeon Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation { get; set; }
        /// <summary>
        /// Assistant Surgeon Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2310E_837D
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
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SBR_OtherSubscriberInformation))]
    public class Loop_2320_837D
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
        public All_AMT_837D AllAMT { get; set; }
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
        public All_NM1_837D_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_InsuredName))]
    public class Loop_2330A_837D
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
        /// Other Subscriber City/State/Zip Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZipCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Identification
        /// </summary>
        [Pos(4)]
        public List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CorrectedPriorityPayerName))]
    public class Loop_2330B_837D
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
        /// Other Payer City, State ,ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_OtherPayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Claim Check Or Remittance Date
        /// </summary>
        [Pos(4)]
        public DTP_ClaimCheckOrRemittanceDate DTP_ClaimCheckOrRemittanceDate { get; set; }
        [Pos(5)]
        public All_REF_837D AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2330C_837D
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
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2330D_837D
    {
        
        /// <summary>
        /// Other Payer Rendering Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2330E_837D
    {
        
        /// <summary>
        /// Other Payer Supervising Provider
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider Identification
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_BillingProviderName))]
    public class Loop_2330F_837D
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
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330G_837D
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
    /// Loop for Other Payer Assistant Surgeon
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerAssistantSurgeon))]
    public class Loop_2330H_837D
    {
        
        /// <summary>
        /// Other Payer Assistant Surgeon
        /// </summary>
        [Pos(1)]
        public NM1_OtherPayerAssistantSurgeon NM1_OtherPayerAssistantSurgeon { get; set; }
        /// <summary>
        /// Other Payer Assistant Surgeon Secondary Identifier
        /// </summary>
        [Pos(2)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAssistantSurgeonSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_837D
    {
        
        /// <summary>
        /// Service Line Number
        /// </summary>
        [Pos(1)]
        public LX_HeaderNumber LX_ServiceLineNumber { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [Pos(2)]
        public SV3_DentalService SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [Pos(3)]
        public List<TOO_ToothInformation> TOO_ToothInformation { get; set; }
        [Pos(4)]
        public All_DTP_837D AllDTP { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [Pos(5)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        [Pos(6)]
        public All_REF_837D_2 AllREF { get; set; }
        /// <summary>
        /// Sales Tax Amount
        /// </summary>
        [Pos(7)]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [Pos(8)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [Pos(9)]
        public HCP_ClaimPricing_2 HCP_LinePricing_RepricingInformation { get; set; }
        [Pos(10)]
        public All_NM1_837D_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [Pos(11)]
        public List<Loop_2430_837D> Loop2430 { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerRenderingProvider_2))]
    public class Loop_2420A_837D
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
    /// Loop for Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_AssistantSurgeonName))]
    public class Loop_2420B_837D
    {
        
        /// <summary>
        /// Assistant Surgeon Name
        /// </summary>
        [Pos(1)]
        public NM1_AssistantSurgeonName NM1_AssistantSurgeonName { get; set; }
        /// <summary>
        /// Assistant Surgeon Specialty Information
        /// </summary>
        [Pos(2)]
        public PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation { get; set; }
        /// <summary>
        /// Assistant Surgeon Secondary Identification
        /// </summary>
        [Pos(3)]
        public List<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2420C_837D
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
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2420D_837D
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
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SVD_LineAdjudicationInformation))]
    public class Loop_2430_837D
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
    /// Health Care Claim : Dental
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X224A2", "837")]
    public class TS837D : EdiMessage
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
        public All_NM1_837D_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [Pos(4)]
        public List<Loop_2000A_837D> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(5)]
        public SE SE { get; set; }
    }
}
