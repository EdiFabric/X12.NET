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
    public class All_AMT_837D
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
    public class All_DTP_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_ServiceDate DTP_Date_ServiceDate { get; set; }
        /// <summary>
        /// Date - Prior Placement
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_PriorPlacement DTP_Date_PriorPlacement { get; set; }
        /// <summary>
        /// Date - Appliance Placement
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_AppliancePlacement DTP_Date_AppliancePlacement { get; set; }
        /// <summary>
        /// Date - Replacement
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP_Replacement DTP_Date_Replacement { get; set; }
        /// <summary>
        /// Date - Treatment Start
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP_TreatmentStart DTP_Date_TreatmentStart { get; set; }
        /// <summary>
        /// Date - Treatment Completion
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP_TreatmentCompletion DTP_Date_TreatmentCompletion { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTP_837D_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date - Accident
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTP_AccidentDate_2 DTP_Date_Accident { get; set; }
        /// <summary>
        /// Date - Appliance Placement
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP_AppliancePlacement DTP_Date_AppliancePlacement { get; set; }
        /// <summary>
        /// Date - Service Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_ClaimLevelServiceDate DTP_Date_ServiceDate { get; set; }
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
    public class All_NM1_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Billing Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2010AA_837D Loop2010AA { get; set; }
        /// <summary>
        /// Loop for Pay-to Address Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010AB_837D Loop2010AB { get; set; }
        /// <summary>
        /// Loop for Pay-To Plan Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2010AC_837D Loop2010AC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837D_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2010BA_837D Loop2010BA { get; set; }
        /// <summary>
        /// Loop for Payer Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2010BB_837D Loop2010BB { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837D_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<Loop_2310A_837D> Loop2310A { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2310B_837D Loop2310B { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2310C_837D Loop2310C { get; set; }
        /// <summary>
        /// Loop for Assistant Surgeon Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2310D_837D Loop2310D { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2310E_837D Loop2310E { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837D_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2330A_837D Loop2330A { get; set; }
        /// <summary>
        /// Loop for Other Payer Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2330B_837D Loop2330B { get; set; }
        /// <summary>
        /// Loop for Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2330C_837D> Loop2330C { get; set; }
        /// <summary>
        /// Loop for Other Payer Rendering Provider
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2330D_837D Loop2330D { get; set; }
        /// <summary>
        /// Loop for Other Payer Supervising Provider
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_2330E_837D Loop2330E { get; set; }
        /// <summary>
        /// Loop for Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2330F_837D Loop2330F { get; set; }
        /// <summary>
        /// Loop for Other Payer Service Facility Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_2330G_837D Loop2330G { get; set; }
        /// <summary>
        /// Loop for Other Payer Assistant Surgeon
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_2330H_837D Loop2330H { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837D_5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Rendering Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2420A_837D Loop2420A { get; set; }
        /// <summary>
        /// Loop for Assistant Surgeon Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2420B_837D Loop2420B { get; set; }
        /// <summary>
        /// Loop for Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2420C_837D Loop2420C { get; set; }
        /// <summary>
        /// Loop for Service Facility Location Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2420D_837D Loop2420D { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_837D_6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Submitter Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_1000A_837D Loop1000A { get; set; }
        /// <summary>
        /// Loop for Receiver Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_1000B_837D Loop1000B { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837D
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
        /// Other Payer Predetermination Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_OtherPayerPredeterminationIdentification REF_OtherPayerPredeterminationIdentification { get; set; }
        /// <summary>
        /// Other Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837D_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Predetermination Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<REF_OtherPayerPredeterminationIdentification_2> REF_ServicePredeterminationIdentification { get; set; }
        /// <summary>
        /// Prior Authorization
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OtherPayerPriorAuthorizationNumber_2> REF_PriorAuthorization { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Referral Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF_OtherPayerReferralNumber_2> REF_ReferralNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837D_3
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
        [Pos(2)]
        public virtual REF_BillingProviderTaxIdentification_2 REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837D_4
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
    public class All_REF_837D_5
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
    public class All_REF_837D_6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Predetermination Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_OtherPayerPredeterminationIdentification REF_PredeterminationIdentification { get; set; }
        /// <summary>
        /// Service Authorization Exception Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        /// <summary>
        /// Payer Claim Control Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_OtherPayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
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
        /// Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        /// <summary>
        /// Adjusted Repriced Claim Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        /// <summary>
        /// Claim Identifier For Transmission Intermediaries
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_837D_7
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
    public class All_REF_837D_8
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Tax Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        /// <summary>
        /// Billing Provider UPIN/License Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_BillingProviderUPIN> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Submitter Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_InformationReceiverName_4))]
    public class Loop_1000A_837D
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
    public class Loop_1000B_837D
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
    public class Loop_2000A_837D
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
        public virtual All_NM1_837D AllNM1 { get; set; }
        /// <summary>
        /// Loop for Subscriber Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2000B_837D> Loop2000B { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_SubscriberHierarchicalLevel))]
    public class Loop_2000B_837D
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
        public virtual SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_NM1_837D_2 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2300_837D> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Patient Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2000C_837D> Loop2000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL_DependentLevel))]
    public class Loop_2000C_837D
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
        public virtual Loop_2010CA_837D Loop2010CA { get; set; }
        /// <summary>
        /// Loop for Claim Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2300_837D> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_BillingProviderName_2))]
    public class Loop_2010AA_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billing Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_BillingProviderName_2 NM1_BillingProviderName { get; set; }
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
        [DataMember]
        [Pos(4)]
        public virtual All_REF_837D_8 AllREF { get; set; }
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
    [Group(typeof(NM1_Pay))]
    public class Loop_2010AB_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pay-to Address Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_Pay NM1_Pay_AddressName { get; set; }
        /// <summary>
        /// Pay-to Address - ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_Pay_Address_ADDRESS { get; set; }
        /// <summary>
        /// Pay-to Address - City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_Address_City_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_Pay_3))]
    public class Loop_2010AC_837D
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
        /// Pay-To Plan City, State, Zip Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_Pay_ToPlanCity_State_ZipCode { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_837D_3 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SubscriberName_5))]
    public class Loop_2010BA_837D
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
        public virtual All_REF_837D_4 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2010BB_837D
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
        public virtual All_REF_837D_5 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_PatientName_3))]
    public class Loop_2010CA_837D
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
        /// Patient City, State, ZIP Code
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
        public virtual All_REF_837D_7 AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLM_ClaimInformation))]
    public class Loop_2300_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_DTP_837D_2 AllDTP { get; set; }
        /// <summary>
        /// Orthodontic Total Months of Treatment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DN1_OrthodonticTotalMonthsofTreatment DN1_OrthodonticTotalMonthsofTreatment { get; set; }
        /// <summary>
        /// Tooth Status
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DN2_ToothStatus> DN2_ToothStatus { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CN1_ContractInformation CN1_ContractInformation { get; set; }
        /// <summary>
        /// Patient Amount Paid
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual All_REF_837D_6 AllREF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Claim Note
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<NTE_BillingNote> NTE_ClaimNote { get; set; }
        /// <summary>
        /// Health Care Diagnosis Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        /// <summary>
        /// Claim Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual HCP_ClaimPricing HCP_ClaimPricing_RepricingInformation { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual All_NM1_837D_3 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Other Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_2320_837D> Loop2320 { get; set; }
        /// <summary>
        /// Loop for Service Line Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_2400_837D> Loop2400 { get; set; }
    }
    
    /// <summary>
    /// Loop for Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ReferringProviderName))]
    public class Loop_2310A_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Referring Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        /// <summary>
        /// Referring Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation { get; set; }
        /// <summary>
        /// Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_OrderingProviderSecondaryIdentification_2> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName))]
    public class Loop_2310B_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
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
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceFacilityLocation))]
    public class Loop_2310C_837D
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
        /// Service Facility Location City, State, Zip Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZipCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AssistantSurgeonName))]
    public class Loop_2310D_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assistant Surgeon Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_AssistantSurgeonName NM1_AssistantSurgeonName { get; set; }
        /// <summary>
        /// Assistant Surgeon Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation { get; set; }
        /// <summary>
        /// Assistant Surgeon Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_AssistantSurgeonSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SupervisingProviderName))]
    public class Loop_2310E_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBR_OtherSubscriberInformation))]
    public class Loop_2320_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        /// <summary>
        /// Claim Level Adjustments
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual All_AMT_837D AllAMT { get; set; }
        /// <summary>
        /// Other Insurance Coverage Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_NM1_837D_4 AllNM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherSubscriberName))]
    public class Loop_2330A_837D
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
        /// Other Subscriber City/State/Zip Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_OtherSubscriberCity_State_ZipCode { get; set; }
        /// <summary>
        /// Other Subscriber Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerName))]
    public class Loop_2330B_837D
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
        /// Other Payer City, State ,ZIP Code
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
        public virtual All_REF_837D AllREF { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerReferringProvider))]
    public class Loop_2330C_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Referring Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        /// <summary>
        /// Other Payer Referring Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_OrderingProviderSecondaryIdentification_2> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerRenderingProvider))]
    public class Loop_2330D_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        /// <summary>
        /// Other Payer Rendering Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerSupervisingProvider))]
    public class Loop_2330E_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        /// <summary>
        /// Other Payer Supervising Provider Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerSupervisingProviderIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerBillingProvider))]
    public class Loop_2330F_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Billing Provider
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider { get; set; }
        /// <summary>
        /// Other Payer Billing Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_BillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerServiceFacilityLocation))]
    public class Loop_2330G_837D
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
    /// Loop for Other Payer Assistant Surgeon
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_OtherPayerAssistantSurgeon))]
    public class Loop_2330H_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Payer Assistant Surgeon
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_OtherPayerAssistantSurgeon NM1_OtherPayerAssistantSurgeon { get; set; }
        /// <summary>
        /// Other Payer Assistant Surgeon Secondary Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification> REF_OtherPayerAssistantSurgeonSecondaryIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2400_837D
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
        /// Dental Service
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SV3_DentalService SV3_DentalService { get; set; }
        /// <summary>
        /// Tooth Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<TOO_ToothInformation> TOO_ToothInformation { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_DTP_837D AllDTP { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CN1_ContractInformation CN1_ContractInformation { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_REF_837D_2 AllREF { get; set; }
        /// <summary>
        /// Sales Tax Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<K3_FileInformation> K3_FileInformation { get; set; }
        /// <summary>
        /// Line Pricing/Repricing Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual HCP_LinePricing HCP_LinePricing_RepricingInformation { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual All_NM1_837D_5 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Line Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_2430_837D> Loop2430 { get; set; }
    }
    
    /// <summary>
    /// Loop for Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_RenderingProviderName))]
    public class Loop_2420A_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rendering Provider Name
        /// </summary>
        [DataMember]
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
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification_2> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_AssistantSurgeonName))]
    public class Loop_2420B_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assistant Surgeon Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_AssistantSurgeonName NM1_AssistantSurgeonName { get; set; }
        /// <summary>
        /// Assistant Surgeon Specialty Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV_AssistantSurgeonSpecialtyInformation PRV_AssistantSurgeonSpecialtyInformation { get; set; }
        /// <summary>
        /// Assistant Surgeon Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification_2> REF_AssistantSurgeonSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Supervising Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_SupervisingProviderName))]
    public class Loop_2420C_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supervising Provider Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        /// <summary>
        /// Supervising Provider Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AssistantSurgeonSecondaryIdentification_2> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Facility Location Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ServiceFacilityLocation))]
    public class Loop_2420D_837D
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
        /// Service Facility Location City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Service Facility Location Secondary Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVD_LineAdjudicationInformation))]
    public class Loop_2430_837D
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
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
    /// Health Care Claim : Dental
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X224A2", "837")]
    public class TS837D : EdiMessage
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
        public virtual All_NM1_837D_6 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Billing Provider Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2000A_837D> Loop2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
