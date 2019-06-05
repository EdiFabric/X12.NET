namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    /// <summary>
    /// Dependent Request Validation
    /// </summary>
    [Serializable()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_DependentRequestValidation : IAAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [Pos(3)]
        public string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [Pos(4)]
        public string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Request Validation
    /// </summary>
    [Serializable()]
    [Segment("AAA", typeof(X12_ID_1073_2), typeof(X12_ID_559))]
    public class AAA_DependentRequestValidation_2 : IAAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [Pos(3)]
        public string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [Pos(4)]
        public string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// TPA/Broker Account Information
    /// </summary>
    [Serializable()]
    [Segment("ACT")]
    public class ACT_TPA : IACT
    {
        
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(1)]
        public string TPAorBrokerAccountNumber_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(5)]
        public string AccountNumberQualifier_05 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(6)]
        public string TPAorBrokerAccountNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Payment Method Type Code
        /// </summary>
        [Pos(8)]
        public string PaymentMethodTypeCode_08 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(9)]
        public string BenefitStatusCode_09 { get; set; }
    }
    
    /// <summary>
    /// Individual Premium Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [Segment("ADX")]
    public class ADX_IndividualPremiumAdjustmentforCurrentPayment : IADX
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(1)]
        public string AdjustmentAmount_01 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Submitted Charges
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_12))]
    public class AMT_ClaimSubmittedCharges : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_15))]
    public class AMT_ClaimSupplementalInformation : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Payer Paid Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_CoordinationofBenefits : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Total Non-covered Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_CoordinationofBenefits_2 : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Facility Tax Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_9))]
    public class AMT_FacilityTaxAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Policy
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_14))]
    public class AMT_HealthCoveragePolicy : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Patient Amount Paid
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_16))]
    public class AMT_PatientAmountPaid : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Patient Estimated Amount Due
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_17))]
    public class AMT_PatientEstimatedAmountDue : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Postage Claimed Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_10))]
    public class AMT_PostageClaimedAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Remaining Patient Liability
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_RemainingPatientLiability : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Sales Tax Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_7))]
    public class AMT_SalesTaxAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Service Supplemental Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_3))]
    public class AMT_ServiceSupplementalAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Service Tax Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_8))]
    public class AMT_ServiceTaxAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Spend Down Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_11))]
    public class AMT_SubscriberSpendDownAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Spend Down Total Billed Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_SubscriberSpendDownTotalBilledAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_13))]
    public class AMT_TotalAcceptedAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_2))]
    public class AMT_TotalRejectedAmount : IAMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment
    /// </summary>
    [Serializable()]
    [Segment("BGN", typeof(X12_ID_353_6))]
    public class BGN_BeginningSegment : IBGN
    {
        
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string TransactionSetReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(3)]
        public string TransactionSetCreationDate_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationTime_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(5)]
        public string TimeZoneCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public string OriginalTransactionSetReferenceNumber_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(8)]
        public string ActionCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353))]
    public class BHT_BeginningofHierarchicalTransaction : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_3), typeof(X12_ID_353_4))]
    public class BHT_BeginningOfHierarchicalTransaction : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Transaction Set Creation Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Transaction Set Creation Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353_2))]
    public class BHT_BeginningofHierarchicalTransaction_2 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_2), typeof(X12_ID_353_3))]
    public class BHT_BeginningofHierarchicalTransaction_3 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_2), typeof(X12_ID_353_4))]
    public class BHT_BeginningofHierarchicalTransaction_4 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_6), typeof(X12_ID_353_8))]
    public class BHT_BeginningofHierarchicalTransaction_5 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_4), typeof(X12_ID_353_5))]
    public class BHT_BeginningofHierarchicalTransaction_6 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_5), typeof(X12_ID_353_7))]
    public class BHT_BeginningofHierarchicalTransaction_7 : IBHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Financial Information
    /// </summary>
    [Serializable()]
    [Segment("BPR", typeof(X12_ID_305))]
    public class BPR_FinancialInformation : IBPR
    {
        
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [Pos(1)]
        public string TransactionHandlingCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalPremiumPaymentAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditorDebitFlagCode_03 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [Pos(4)]
        public string PaymentMethodCode_04 { get; set; }
        /// <summary>
        /// Payment Format Code
        /// </summary>
        [Pos(5)]
        public string PaymentFormatCode_05 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(6)]
        public string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(7)]
        public string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(8)]
        public string AccountNumberQualifier_08 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(9)]
        public string SenderBankAccountNumber_09 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(10)]
        public string PayerIdentifier_10 { get; set; }
        /// <summary>
        /// Originating Company Supplemental Code
        /// </summary>
        [Pos(11)]
        public string OriginatingCompanySupplementalCode_11 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(12)]
        public string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(13)]
        public string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(14)]
        public string AccountNumberQualifier_14 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(15)]
        public string ReceiverBankAccountNumber_15 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(16)]
        public string CheckIssueorEFTEffectiveDate_16 { get; set; }
        /// <summary>
        /// Business Function Code
        /// </summary>
        [Pos(17)]
        public string BusinessFunctionCode_17 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(18)]
        public string DFIIDNumberQualifier_18 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(19)]
        public string DFIIdentificationNumber_19 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(20)]
        public string AccountNumberQualifier_20 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(21)]
        public string AccountNumber_21 { get; set; }
    }
    
    /// <summary>
    /// Financial Information
    /// </summary>
    [Serializable()]
    [Segment("BPR", typeof(X12_ID_305_2))]
    public class BPR_FinancialInformation_2 : IBPR
    {
        
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [Pos(1)]
        public string TransactionHandlingCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalPremiumPaymentAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [Pos(3)]
        public string CreditorDebitFlagCode_03 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [Pos(4)]
        public string PaymentMethodCode_04 { get; set; }
        /// <summary>
        /// Payment Format Code
        /// </summary>
        [Pos(5)]
        public string PaymentFormatCode_05 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(6)]
        public string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(7)]
        public string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(8)]
        public string AccountNumberQualifier_08 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(9)]
        public string SenderBankAccountNumber_09 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(10)]
        public string PayerIdentifier_10 { get; set; }
        /// <summary>
        /// Originating Company Supplemental Code
        /// </summary>
        [Pos(11)]
        public string OriginatingCompanySupplementalCode_11 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(12)]
        public string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(13)]
        public string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(14)]
        public string AccountNumberQualifier_14 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(15)]
        public string ReceiverBankAccountNumber_15 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(16)]
        public string CheckIssueorEFTEffectiveDate_16 { get; set; }
        /// <summary>
        /// Business Function Code
        /// </summary>
        [Pos(17)]
        public string BusinessFunctionCode_17 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [Pos(18)]
        public string DFIIDNumberQualifier_18 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [Pos(19)]
        public string DFIIdentificationNumber_19 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [Pos(20)]
        public string AccountNumberQualifier_20 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [Pos(21)]
        public string AccountNumber_21 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Adjustments
    /// </summary>
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033_2))]
    public class CAS_ClaimLevelAdjustments : ICAS
    {
        
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    /// <summary>
    /// Claims Adjustment
    /// </summary>
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_ClaimsAdjustment : ICAS
    {
        
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    /// <summary>
    /// Institutional Claim Code
    /// </summary>
    [Serializable()]
    [Segment("CL1")]
    public class CL1_InstitutionalClaimCode : ICL1
    {
        
        /// <summary>
        /// Admission Type Code
        /// </summary>
        [Pos(1)]
        public string AdmissionTypeCode_01 { get; set; }
        /// <summary>
        /// Admission Source Code
        /// </summary>
        [Pos(2)]
        public string AdmissionSourceCode_02 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [Pos(3)]
        public string PatientStatusCode_03 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [Pos(4)]
        public string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Information
    /// </summary>
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation : ICLM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [Pos(1)]
        public string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [Pos(3)]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        [Pos(4)]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Pos(5)]
        public C023_HealthCareServiceLocationInformation HealthCareServiceLocationInformation_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(6)]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        [Pos(7)]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(8)]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [Pos(10)]
        public string PatientSignatureSourceCode_10 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(11)]
        public C024_RelatedCausesInformation RelatedCausesInformation_11 { get; set; }
        /// <summary>
        /// Special Program Code
        /// </summary>
        [Pos(12)]
        public string SpecialProgramIndicator_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [Pos(14)]
        public string LevelofServiceCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(16)]
        public string ProviderAgreementCode_16 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [Pos(17)]
        public string ClaimStatusCode_17 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(18)]
        public string YesNoConditionorResponseCode_18 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [Pos(19)]
        public string PredeterminationofBenefitsCode_19 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [Pos(20)]
        public string DelayReasonCode_20 { get; set; }
    }
    
    /// <summary>
    /// Claim Payment Information
    /// </summary>
    [Serializable()]
    [Segment("CLP")]
    public class CLP_ClaimPaymentInformation : ICLP
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [Pos(1)]
        public string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [Pos(2)]
        public string ClaimStatusCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string TotalClaimChargeAmount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string ClaimPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string PatientResponsibilityAmount_05 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [Pos(6)]
        public string ClaimFilingIndicatorCode_06 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(7)]
        public string PayerClaimControlNumber_07 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(8)]
        public string FacilityTypeCode_08 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [Pos(9)]
        public string ClaimFrequencyCode_09 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [Pos(10)]
        public string PatientStatusCode_10 { get; set; }
        /// <summary>
        /// Diagnosis Related Group (DRG) Code
        /// </summary>
        [Pos(11)]
        public string DiagnosisRelatedGroupDRGCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(12)]
        public string DiagnosisRelatedGroupDRGWeight_12 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [Pos(13)]
        public string DischargeFraction_13 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(14)]
        public string YesNoConditionorResponseCode_14 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation : ICN1
    {
        
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166_2))]
    public class CN1_ContractInformation_2 : ICN1
    {
        
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits
    /// </summary>
    [Serializable()]
    [Segment("COB", typeof(X12_ID_1138))]
    public class COB_CoordinationofBenefits : ICOB
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [Pos(3)]
        public string CoordinationofBenefitsCode_03 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(4)]
        public List<string> ServiceTypeCode_04 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_2))]
    public class CR1_AmbulanceTransportInformation : ICR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_5))]
    public class CR1_AmbulanceTransportInformation_2 : ICR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355))]
    public class CR1_AmbulanceTransportInformation_3 : ICR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation : ICR2
    {
        
        /// <summary>
        /// Count
        /// </summary>
        [Pos(1)]
        public string Count_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [Pos(3)]
        public string SubluxationLevelCode_03 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [Pos(4)]
        public string SubluxationLevelCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certification
    /// </summary>
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322_3), typeof(X12_ID_355_4))]
    public class CR3_DurableMedicalEquipmentCertification : ICR3
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        /// <summary>
        /// Insulin Dependent Code
        /// </summary>
        [Pos(4)]
        public string InsulinDependentCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(5)]
        public string Description_05 { get; set; }
    }
    
    /// <summary>
    /// Home Oxygen Therapy Information
    /// </summary>
    [Serializable()]
    [Segment("CR5", typeof(X12_ID_1322_4))]
    public class CR5_HomeOxygenTherapyInformation : ICR5
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(3)]
        public string OxygenEquipmentTypeCode_03 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(4)]
        public string OxygenEquipmentTypeCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(5)]
        public string EquipmentReasonDescription_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string OxygenFlowRate_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string DailyOxygenUseCount_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(8)]
        public string OxygenUsePeriodHourCount_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(9)]
        public string RespiratoryTherapistOrderText_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string ArterialBloodGasQuantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(11)]
        public string OxygenSaturationQuantity_11 { get; set; }
        /// <summary>
        /// Oxygen Test Condition Code
        /// </summary>
        [Pos(12)]
        public string OxygenTestConditionCode_12 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(13)]
        public string OxygenTestFindingsCode_13 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(14)]
        public string OxygenTestFindingsCode_14 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(15)]
        public string OxygenTestFindingsCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(16)]
        public string PortableOxygenSystemFlowRate_16 { get; set; }
        /// <summary>
        /// Oxygen Delivery System Code
        /// </summary>
        [Pos(17)]
        public string OxygenDeliverySystemCode_17 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(18)]
        public string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    /// <summary>
    /// Home Oxygen Therapy Information
    /// </summary>
    [Serializable()]
    [Segment("CR5", typeof(X12_ID_1322))]
    public class CR5_HomeOxygenTherapyInformation_2 : ICR5
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(3)]
        public string OxygenEquipmentTypeCode_03 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(4)]
        public string OxygenEquipmentTypeCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(5)]
        public string EquipmentReasonDescription_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string OxygenFlowRate_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string DailyOxygenUseCount_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(8)]
        public string OxygenUsePeriodHourCount_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(9)]
        public string RespiratoryTherapistOrderText_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string ArterialBloodGasQuantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(11)]
        public string OxygenSaturationQuantity_11 { get; set; }
        /// <summary>
        /// Oxygen Test Condition Code
        /// </summary>
        [Pos(12)]
        public string OxygenTestConditionCode_12 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(13)]
        public string OxygenTestFindingsCode_13 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(14)]
        public string OxygenTestFindingsCode_14 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [Pos(15)]
        public string OxygenTestFindingsCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(16)]
        public string PortableOxygenSystemFlowRate_16 { get; set; }
        /// <summary>
        /// Oxygen Delivery System Code
        /// </summary>
        [Pos(17)]
        public string OxygenDeliverySystemCode_17 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [Pos(18)]
        public string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    /// <summary>
    /// Home Health Care Information
    /// </summary>
    [Serializable()]
    [Segment("CR6", typeof(X12_ID_923_2))]
    public class CR6_HomeHealthCareInformation : ICR6
    {
        
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(1)]
        public string PrognosisCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string HomeHealthStartDate_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(4)]
        public string HomeHealthCertificationPeriod_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(6)]
        public string YesNoConditionorResponseCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(7)]
        public string MedicareCoverageIndicator_07 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(8)]
        public string CertificationTypeCode_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(9)]
        public string SurgeryDate_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(10)]
        public string ProductorServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [Pos(11)]
        public string SurgicalProcedureCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(12)]
        public string PhysicianOrderDate_12 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(13)]
        public string LastVisitDate_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(14)]
        public string PhysicianContactDate_14 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(15)]
        public string DateTimePeriodFormatQualifier_15 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(16)]
        public string LastAdmissionPeriod_16 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [Pos(17)]
        public string PatientLocationCode_17 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(18)]
        public string Date_18 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(19)]
        public string Date_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(21)]
        public string Date_21 { get; set; }
    }
    
    /// <summary>
    /// Home Health Care Information
    /// </summary>
    [Serializable()]
    [Segment("CR6", typeof(X12_ID_923))]
    public class CR6_HomeHealthCareInformation_2 : ICR6
    {
        
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(1)]
        public string PrognosisCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string HomeHealthStartDate_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(4)]
        public string HomeHealthCertificationPeriod_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(6)]
        public string YesNoConditionorResponseCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(7)]
        public string MedicareCoverageIndicator_07 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(8)]
        public string CertificationTypeCode_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(9)]
        public string SurgeryDate_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(10)]
        public string ProductorServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [Pos(11)]
        public string SurgicalProcedureCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(12)]
        public string PhysicianOrderDate_12 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(13)]
        public string LastVisitDate_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(14)]
        public string PhysicianContactDate_14 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(15)]
        public string DateTimePeriodFormatQualifier_15 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(16)]
        public string LastAdmissionPeriod_16 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [Pos(17)]
        public string PatientLocationCode_17 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(18)]
        public string Date_18 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(19)]
        public string Date_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(21)]
        public string Date_21 { get; set; }
    }
    
    /// <summary>
    /// Activities Permitted Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_11), typeof(X12_ID_1073_7))]
    public class CRC_ActivitiesPermittedInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_6), typeof(X12_ID_1073_3))]
    public class CRC_AmbulanceCertification : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_13), typeof(X12_ID_1073_7))]
    public class CRC_AmbulanceCertificationInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Chiropractic Certification Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_7), typeof(X12_ID_1073_7))]
    public class CRC_ChiropracticCertificationInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Condition Indicator/Durable Medical Equipment
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_3))]
    public class CRC_ConditionIndicator : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_8), typeof(X12_ID_1073_7))]
    public class CRC_DurableMedicalEquipmentInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// EPSDT Referral
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_3))]
    public class CRC_EPSDTReferral : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Functional Limitations Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_10), typeof(X12_ID_1073_7))]
    public class CRC_FunctionalLimitationsInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Homebound Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073))]
    public class CRC_HomeboundIndicator : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Hospice Employee Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_3))]
    public class CRC_HospiceEmployeeIndicator : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Mental Status Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_12), typeof(X12_ID_1073_7))]
    public class CRC_MentalStatusInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Oxygen Therapy Certification Information
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_9), typeof(X12_ID_1073_7))]
    public class CRC_OxygenTherapyCertificationInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Patient Condition Information: Vision
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
    public class CRC_PatientConditionInformation : ICRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Drug Quantity
    /// </summary>
    [Serializable()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity : ICTP<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(5)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        /// <summary>
        /// Condition Value
        /// </summary>
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        [Pos(11)]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_53))]
    public class CUR_ForeignCurrencyInformation : ICUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_26))]
    public class CUR_ForeignCurrencyInformation_2 : ICUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_28))]
    public class CUR_ForeignCurrencyInformation_3 : ICUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_5))]
    public class DMG_DependentDemographicInformation : IDMG<C056_CompositeRaceorEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(2)]
        public string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [Pos(3)]
        public string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(9)]
        public string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_7))]
    public class DMG_DependentDemographicInformation_2 : IDMG<C056_CompositeRaceorEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(2)]
        public string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [Pos(3)]
        public string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(9)]
        public string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Orthodontic Total Months of Treatment
    /// </summary>
    [Serializable()]
    [Segment("DN1")]
    public class DN1_OrthodonticTotalMonthsofTreatment : IDN1
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(1)]
        public string OrthodonticTreatmentMonthsCount_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string OrthodonticTreatmentMonthsRemainingCount_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(4)]
        public string OrthodonticTreatmentIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Status
    /// </summary>
    [Serializable()]
    [Segment("DN2")]
    public class DN2_ToothStatus : IDN2
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(1)]
        public string ToothNumber_01 { get; set; }
        /// <summary>
        /// Tooth Status Code
        /// </summary>
        [Pos(2)]
        public string ToothStatusCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(4)]
        public string DateTimePeriodFormatQualifier_04 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(5)]
        public string DateTimePeriod_05 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(6)]
        public string CodeListQualifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Disability Information
    /// </summary>
    [Serializable()]
    [Segment("DSB", typeof(X12_ID_1146))]
    public class DSB_DisabilityInformation : IDSB
    {
        
        /// <summary>
        /// Disability Type Code
        /// </summary>
        [Pos(1)]
        public string DisabilityTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Occupation Code
        /// </summary>
        [Pos(3)]
        public string OccupationCode_03 { get; set; }
        /// <summary>
        /// Work Intensity Code
        /// </summary>
        [Pos(4)]
        public string WorkIntensityCode_04 { get; set; }
        /// <summary>
        /// Product Option Code
        /// </summary>
        [Pos(5)]
        public string ProductOptionCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(7)]
        public string ProductorServiceIDQualifier_07 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [Pos(8)]
        public string DiagnosisCode_08 { get; set; }
    }
    
    /// <summary>
    /// Claim Received Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_11))]
    public class DTM_ClaimReceivedDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Coverage Expiration Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_35))]
    public class DTM_CoverageExpirationDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Coverage Period
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_33))]
    public class DTM_CoveragePeriod : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Creation Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_38))]
    public class DTM_CreationDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Delivery Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_27))]
    public class DTM_DeliveryDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Individual Coverage Period
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_41))]
    public class DTM_IndividualCoveragePeriod : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Process Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_15))]
    public class DTM_ProcessDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Production Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_18))]
    public class DTM_ProductionDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_42))]
    public class DTM_ServiceDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Statement From or To Date
    /// </summary>
    [Serializable()]
    [Segment("DTM", typeof(X12_ID_374_29))]
    public class DTM_StatementFromorToDate : IDTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [Pos(4)]
        public string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Accident Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_60), typeof(X12_ID_1250_7))]
    public class DTP_AccidentDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Accident Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_5))]
    public class DTP_AccidentDate_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Acute Manifestation
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_40), typeof(X12_ID_1250_5))]
    public class DTP_AcuteManifestation : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date/Hour
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_4))]
    public class DTP_AdmissionDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_56), typeof(X12_ID_1250_6))]
    public class DTP_AdmissionDate_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250))]
    public class DTP_AdmissionDate_3 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Admission
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_5))]
    public class DTP_AdmissionDate_4 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Appliance Placement
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_30), typeof(X12_ID_1250_5))]
    public class DTP_AppliancePlacement : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Assumed and Relinquished Care Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250_5))]
    public class DTP_AssumedandRelinquishedCareDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Authorized Return to Work
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250_5))]
    public class DTP_AuthorizedReturntoWork : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Begin Therapy Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250_5))]
    public class DTP_BeginTherapyDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Effective Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374), typeof(X12_ID_1250))]
    public class DTP_CertificationEffectiveDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Expiration Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_35), typeof(X12_ID_1250_5))]
    public class DTP_CertificationExpirationDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Issue Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_44), typeof(X12_ID_1250_5))]
    public class DTP_CertificationIssueDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// DATE - Certification Revision/Recertification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250_5))]
    public class DTP_CertificationRevision : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Check Or Remittance Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250_5))]
    public class DTP_ClaimCheckOrRemittanceDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250))]
    public class DTP_ClaimLevelServiceDate : IDTP
    {
        
        /// <summary>
        /// Date Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Claim Service Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits Eligibility Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_39), typeof(X12_ID_1250_5))]
    public class DTP_CoordinationofBenefitsEligibilityDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_49), typeof(X12_ID_1250))]
    public class DTP_DependentDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_50), typeof(X12_ID_1250))]
    public class DTP_DependentDate_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility/Benefit Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_13), typeof(X12_ID_1250))]
    public class DTP_DependentEligibility : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility/Benefit Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_14), typeof(X12_ID_1250))]
    public class DTP_DependentEligibility_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Disability Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_DisabilityDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Disability Eligibility Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_28), typeof(X12_ID_1250_5))]
    public class DTP_DisabilityEligibilityDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Discharge
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_5))]
    public class DTP_Discharge : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Discharge Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_57), typeof(X12_ID_1250_7))]
    public class DTP_DischargeDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Discharge Hour
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_2))]
    public class DTP_DischargeHour : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Estimated Date of Birth
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_53), typeof(X12_ID_1250_7))]
    public class DTP_EstimatedDateofBirth : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Estimated Date of Birth
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_26), typeof(X12_ID_1250_5))]
    public class DTP_EstimatedDateofBirth_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Event Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_55), typeof(X12_ID_1250_6))]
    public class DTP_EventDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Event Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_37), typeof(X12_ID_1250))]
    public class DTP_EventDate_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// File Effective Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_51), typeof(X12_ID_1250_5))]
    public class DTP_FileEffectiveDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_34), typeof(X12_ID_1250))]
    public class DTP_HealthCoverageDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Hearing and Vision Prescription Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_48), typeof(X12_ID_1250_5))]
    public class DTP_HearingandVisionPrescriptionDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Information Source Process Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_15), typeof(X12_ID_1250_5))]
    public class DTP_InformationSourceProcessDate : IDTP
    {
        
        /// <summary>
        /// Date Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Information Source Process Date
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Initial Treatment Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_32), typeof(X12_ID_1250_5))]
    public class DTP_InitialTreatmentDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Certification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250_5))]
    public class DTP_LastCertificationDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Menstrual Period
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250_5))]
    public class DTP_LastMenstrualPeriod : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Last Menstrual Period Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_52), typeof(X12_ID_1250_7))]
    public class DTP_LastMenstrualPeriodDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Seen Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_36), typeof(X12_ID_1250_5))]
    public class DTP_LastSeenDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Worked
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250_5))]
    public class DTP_LastWorked : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last X-ray Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_46), typeof(X12_ID_1250_5))]
    public class DTP_LastXrayDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Member Level Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_17), typeof(X12_ID_1250_5))]
    public class DTP_MemberLevelDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Onset of Current Illness or Symptom
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250_5))]
    public class DTP_OnsetofCurrentIllnessorSymptom : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Onset of Current Symptoms or Illness Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_54), typeof(X12_ID_1250_7))]
    public class DTP_OnsetofCurrentSymptomsorIllnessDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Other UMO Denial Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_58), typeof(X12_ID_1250_7))]
    public class DTP_OtherUMODenialDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Prior Placement
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_43), typeof(X12_ID_1250_5))]
    public class DTP_PriorPlacement : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Date of First Contact
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250_5))]
    public class DTP_PropertyandCasualtyDateofFirstContact : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Replacement
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_45), typeof(X12_ID_1250_5))]
    public class DTP_Replacement : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Repricer Received Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250_5))]
    public class DTP_RepricerReceivedDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_5))]
    public class DTP_ServiceDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_59), typeof(X12_ID_1250_6))]
    public class DTP_ServiceDate_2 : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Shipped Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_25), typeof(X12_ID_1250_5))]
    public class DTP_ShippedDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Statement Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_31), typeof(X12_ID_1250_3))]
    public class DTP_StatementDates : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Test Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_24), typeof(X12_ID_1250_5))]
    public class DTP_TestDate : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Treatment Completion
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250_5))]
    public class DTP_TreatmentCompletion : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Treatment Start
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_47), typeof(X12_ID_1250_5))]
    public class DTP_TreatmentStart : IDTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [Segment("EB", typeof(X12_ID_1390), typeof(X12_ID_1207))]
    public class EB_DependentEligibilityorBenefitInformation : IEB<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Eligibility or Benefit Information Code
        /// </summary>
        [Pos(1)]
        public string EligibilityorBenefitInformation_01 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [Pos(2)]
        public string BenefitCoverageLevelCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public List<string> ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [Pos(4)]
        public string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [Pos(5)]
        public string PlanCoverageDescription_05 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [Pos(6)]
        public string TimePeriodQualifier_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string BenefitAmount_07 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [Pos(8)]
        public string BenefitPercent_08 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(9)]
        public string QuantityQualifier_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string BenefitQuantity_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string AuthorizationorCertificationIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string InPlanNetworkIndicator_12 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(13)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_13 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(14)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_14 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [Segment("EB", typeof(X12_ID_1390), typeof(X12_ID_1207_2))]
    public class EB_SubscriberEligibilityorBenefitInformation : IEB<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Eligibility or Benefit Information Code
        /// </summary>
        [Pos(1)]
        public string EligibilityorBenefitInformation_01 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [Pos(2)]
        public string BenefitCoverageLevelCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public List<string> ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [Pos(4)]
        public string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [Pos(5)]
        public string PlanCoverageDescription_05 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [Pos(6)]
        public string TimePeriodQualifier_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string BenefitAmount_07 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [Pos(8)]
        public string BenefitPercent_08 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(9)]
        public string QuantityQualifier_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string BenefitQuantity_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string AuthorizationorCertificationIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string InPlanNetworkIndicator_12 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(13)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_13 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(14)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_14 { get; set; }
    }
    
    /// <summary>
    /// Employment Class
    /// </summary>
    [Serializable()]
    [Segment("EC", typeof(X12_ID_1176), typeof(X12_ID_1176))]
    public class EC_EmploymentClass : IEC
    {
        
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [Pos(1)]
        public string EmploymentClassCode_01 { get; set; }
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [Pos(2)]
        public string EmploymentClassCode_02 { get; set; }
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [Pos(3)]
        public string EmploymentClassCode_03 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [Pos(4)]
        public string PercentageasDecimal_04 { get; set; }
        /// <summary>
        /// Information Status Code
        /// </summary>
        [Pos(5)]
        public string InformationStatusCode_05 { get; set; }
        /// <summary>
        /// Occupation Code
        /// </summary>
        [Pos(6)]
        public string OccupationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Individual Remittance
    /// </summary>
    [Serializable()]
    [Segment("ENT")]
    public class ENT_IndividualRemittance : IENT
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(2)]
        public string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string ReceiversIndividualIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(5)]
        public string EntityIdentifierCode_05 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(6)]
        public string IdentificationCodeQualifier_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(7)]
        public string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(8)]
        public string ReferenceIdentificationQualifier_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(9)]
        public string ReferenceIdentification_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [Segment("EQ", typeof(X12_ID_1365), typeof(X12_ID_235_9))]
    public class EQ_DependentEligibilityorBenefitInquiry : IEQ<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(1)]
        public List<string> ServiceTypeCode_01 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(2)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [Pos(3)]
        public string CoverageLevelCode_03 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [Pos(4)]
        public string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(5)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_05 { get; set; }
    }
    
    /// <summary>
    /// Supporting Documentation
    /// </summary>
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation : IFRM
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Pos(1)]
        public string QuestionNumberLetter_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(2)]
        public string QuestionResponse_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string QuestionResponse_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(4)]
        public string QuestionResponse_04 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [Pos(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_ClaimPricing : IHCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_ClaimPricing_2 : IHCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review
    /// </summary>
    [Serializable()]
    [Segment("HCR", typeof(X12_ID_306))]
    public class HCR_HealthCareServicesReview : IHCR
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(1)]
        public string ActionCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string ReviewIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(3)]
        public List<string> ReviewDecisionReasonCode_03 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(4)]
        public string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review
    /// </summary>
    [Serializable()]
    [Segment("HCR", typeof(X12_ID_306_3))]
    public class HCR_HealthCareServicesReview_2 : IHCR
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(1)]
        public string ActionCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string ReviewIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(3)]
        public List<string> ReviewDecisionReasonCode_03 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(4)]
        public string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage
    /// </summary>
    [Serializable()]
    [Segment("HD", typeof(X12_ID_875), typeof(X12_ID_1203))]
    public class HD_HealthCoverage : IHD
    {
        
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(1)]
        public string MaintenanceTypeCode_01 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(2)]
        public string MaintenanceReasonCode_02 { get; set; }
        /// <summary>
        /// Insurance Line Code
        /// </summary>
        [Pos(3)]
        public string InsuranceLineCode_03 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [Pos(4)]
        public string PlanCoverageDescription_04 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [Pos(5)]
        public string CoverageLevelCode_05 { get; set; }
        /// <summary>
        /// Count
        /// </summary>
        [Pos(6)]
        public string Count_06 { get; set; }
        /// <summary>
        /// Count
        /// </summary>
        [Pos(7)]
        public string Count_07 { get; set; }
        /// <summary>
        /// Underwriting Decision Code
        /// </summary>
        [Pos(8)]
        public string UnderwritingDecisionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string LateEnrollmentIndicator_09 { get; set; }
        /// <summary>
        /// Drug House Code
        /// </summary>
        [Pos(10)]
        public string DrugHouseCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    /// <summary>
    /// Admitting Diagnosis
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_12), typeof(X12_ID_1270_26))]
    public class HI_AdmittingDiagnosis : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Anesthesia Related Procedure
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_17), typeof(X12_ID_1270_20))]
    public class HI_AnesthesiaRelatedProcedure : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Condition Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_4), typeof(X12_ID_1270_4))]
    public class HI_ConditionInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_9))]
    public class HI_DependentHealthCareDiagnosisCode : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Diagnosis Related Group (DRG) Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_21), typeof(X12_ID_1270_26))]
    public class HI_DiagnosisRelatedGroup : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// External Cause of Injury
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_19), typeof(X12_ID_1270_19))]
    public class HI_ExternalCauseofInjury : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_11), typeof(X12_ID_1270_15))]
    public class HI_HealthCareDiagnosisCode : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Occurrence Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_2), typeof(X12_ID_1270_2))]
    public class HI_OccurrenceInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Occurrence Span Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270), typeof(X12_ID_1270))]
    public class HI_OccurrenceSpanInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Other Diagnosis Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_9), typeof(X12_ID_1270_9))]
    public class HI_OtherDiagnosisInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Other Procedure Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_24), typeof(X12_ID_1270_24))]
    public class HI_OtherProcedureInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient's Reason For Visit
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_16), typeof(X12_ID_1270_16))]
    public class HI_Patient : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Diagnosis
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_27), typeof(X12_ID_1270_28))]
    public class HI_PatientDiagnosis : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Diagnosis
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_7), typeof(X12_ID_1270_10))]
    public class HI_PatientDiagnosis_2 : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Principal Diagnosis
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_26))]
    public class HI_PrincipalDiagnosis : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Principal Procedure Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_23), typeof(X12_ID_1270_26))]
    public class HI_PrincipalProcedureInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Request For Additional Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_18), typeof(X12_ID_1270_18))]
    public class HI_RequestForAdditionalInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Treatment Code Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_5), typeof(X12_ID_1270_5))]
    public class HI_TreatmentCodeInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Value Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_3), typeof(X12_ID_1270_3))]
    public class HI_ValueInformation : IHI<C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_8))]
    public class HL_BillingProviderHierarchicalLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Of Service Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_3))]
    public class HL_BillingProviderOfServiceLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_4))]
    public class HL_DependentLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_11))]
    public class HL_DependentLevel_2 : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735))]
    public class HL_InformationReceiverLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_12))]
    public class HL_PatientEventLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_6))]
    public class HL_PatientEventLevel_2 : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_5))]
    public class HL_PatientLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_9))]
    public class HL_RequesterLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_13))]
    public class HL_ServiceLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_7))]
    public class HL_ServiceLevel_2 : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_2))]
    public class HL_SubscriberHierarchicalLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_10))]
    public class HL_SubscriberLevel : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_14))]
    public class HL_UtilizationManagementOrganization : IHL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Member Health Information
    /// </summary>
    [Serializable()]
    [Segment("HLH", typeof(X12_ID_1212))]
    public class HLH_MemberHealthInformation : IHLH
    {
        
        /// <summary>
        /// Health-Related Code
        /// </summary>
        [Pos(1)]
        public string HealthRelatedCode_01 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [Pos(2)]
        public string MemberHeight_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(3)]
        public string MemberWeight_03 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(4)]
        public string Weight_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [Pos(6)]
        public string CurrentHealthConditionCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [Segment("HSD", typeof(X12_ID_673))]
    public class HSD_HealthCareServicesDelivery : IHSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [Pos(4)]
        public string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [Pos(5)]
        public string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [Pos(6)]
        public string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [Pos(7)]
        public string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [Pos(8)]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [Segment("HSD", typeof(X12_ID_673_11))]
    public class HSD_HealthCareServicesDelivery_2 : IHSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [Pos(4)]
        public string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [Pos(5)]
        public string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [Pos(6)]
        public string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [Pos(7)]
        public string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [Pos(8)]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Member Income
    /// </summary>
    [Serializable()]
    [Segment("ICM", typeof(X12_ID_594))]
    public class ICM_MemberIncome : IICM
    {
        
        /// <summary>
        /// Frequency Code
        /// </summary>
        [Pos(1)]
        public string FrequencyCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string WageAmount_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string WorkHoursCount_03 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [Pos(4)]
        public string LocationIdentificationCode_04 { get; set; }
        /// <summary>
        /// Salary Grade
        /// </summary>
        [Pos(5)]
        public string SalaryGradeCode_05 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Pos(6)]
        public string CurrencyCode_06 { get; set; }
    }
    
    /// <summary>
    /// Identification Card
    /// </summary>
    [Serializable()]
    [Segment("IDC")]
    public class IDC_IdentificationCard : IIDC
    {
        
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [Pos(1)]
        public string PlanCoverageDescription_01 { get; set; }
        /// <summary>
        /// Identification Card Type Code
        /// </summary>
        [Pos(2)]
        public string IdentificationCardTypeCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string IdentificationCardCount_03 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(4)]
        public string ActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [Segment("III", typeof(X12_ID_1270_14))]
    public class III_DependentEligibilityorBenefitAdditionalInformation : IIII<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(3)]
        public string CodeCategory_03 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [Pos(4)]
        public string InjuredBodyPartName_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(6)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_06 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(7)]
        public string SurfaceLayerPositionCode_07 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(8)]
        public string SurfaceLayerPositionCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Additional Inquiry Information
    /// </summary>
    [Serializable()]
    [Segment("III", typeof(X12_ID_1270_13))]
    public class III_DependentEligibilityorBenefitAdditionalInquiryInformation : IIII<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Code Category
        /// </summary>
        [Pos(3)]
        public string CodeCategory_03 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [Pos(4)]
        public string InjuredBodyPartName_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(6)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_06 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(7)]
        public string SurfaceLayerPositionCode_07 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(8)]
        public string SurfaceLayerPositionCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_2), typeof(X12_ID_1069))]
    public class INS_DependentRelationship : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_2), typeof(X12_ID_1069_2))]
    public class INS_DependentRelationship_2 : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_6), typeof(X12_ID_1069_8))]
    public class INS_DependentRelationship_3 : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_2), typeof(X12_ID_1069_3))]
    public class INS_DependentRelationship_4 : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Member Level Detail
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_3), typeof(X12_ID_1069_7))]
    public class INS_MemberLevelDetail : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Multiple Birth Sequence Number
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073), typeof(X12_ID_1069_6))]
    public class INS_MultipleBirthSequenceNumber : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Relationship
    /// </summary>
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073_5), typeof(X12_ID_1069_9))]
    public class INS_SubscriberRelationship : IINS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(1)]
        public string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(12)]
        public string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(14)]
        public string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Summary Line Item
    /// </summary>
    [Serializable()]
    [Segment("IT1")]
    public class IT1_SummaryLineItem : IIT1
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Pos(1)]
        public string LineItemControlNumber_01 { get; set; }
        /// <summary>
        /// Quantity Invoiced
        /// </summary>
        [Pos(2)]
        public string QuantityInvoiced_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }
    
    /// <summary>
    /// File Information
    /// </summary>
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation : IK3<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Fixed Format Information
        /// </summary>
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        /// <summary>
        /// Record Format Code
        /// </summary>
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
    }
    
    /// <summary>
    /// Additional Reporting Categories Termination
    /// </summary>
    [Serializable()]
    [Segment("LE")]
    public class LE_AdditionalReportingCategoriesTermination : ILE
    {
        
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Drug Identification
    /// </summary>
    [Serializable()]
    [Segment("LIN")]
    public class LIN_DrugIdentification : ILIN
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(2)]
        public string ProductorServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(3)]
        public string NationalDrugCode_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }
    
    /// <summary>
    /// Form Identification Code
    /// </summary>
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_22))]
    public class LQ_FormIdentificationCode : ILQ
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Health Care Remark Codes
    /// </summary>
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_25))]
    public class LQ_HealthCareRemarkCodes : ILQ
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Reporting Categories
    /// </summary>
    [Serializable()]
    [Segment("LS")]
    public class LS_AdditionalReportingCategories : ILS
    {
        
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Member Language
    /// </summary>
    [Serializable()]
    [Segment("LUI", typeof(X12_ID_66))]
    public class LUI_MemberLanguage : ILUI
    {
        
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(1)]
        public string IdentificationCodeQualifier_01 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(2)]
        public string LanguageCode_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string LanguageDescription_03 { get; set; }
        /// <summary>
        /// Use of Language Indicator
        /// </summary>
        [Pos(4)]
        public string LanguageUseIndicator_04 { get; set; }
        /// <summary>
        /// Language Proficiency Indicator
        /// </summary>
        [Pos(5)]
        public string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    /// <summary>
    /// Header Number
    /// </summary>
    [Serializable()]
    [Segment("LX")]
    public class LX_HeaderNumber : ILX
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    /// <summary>
    /// Test Result
    /// </summary>
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult : IMEA<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [Pos(1)]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [Pos(3)]
        public string TestResults_03 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(4)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_04 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(11)]
        public string CodeListQualifierCode_11 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(12)]
        public string IndustryCode_12 { get; set; }
    }
    
    /// <summary>
    /// Inpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("MIA")]
    public class MIA_InpatientAdjudicationInformation : IMIA
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(1)]
        public string CoveredDaysorVisitsCount_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string LifetimePsychiatricDaysCount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string ClaimDRGAmount_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(5)]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string ClaimDisproportionateShareAmount_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string ClaimMSPPassthroughAmount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string ClaimPPSCapitalAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string PPSCapitalFSPDRGAmount_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(10)]
        public string PPSCapitalHSPDRGAmount_10 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(11)]
        public string PPSCapitalDSHDRGAmount_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(12)]
        public string OldCapitalAmount_12 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(13)]
        public string PPSCapitalIMEamount_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(14)]
        public string PPSOperatingHospitalSpecificDRGAmount_14 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(15)]
        public string CostReportDayCount_15 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(16)]
        public string PPSOperatingFederalSpecificDRGAmount_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(17)]
        public string ClaimPPSCapitalOutlierAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(18)]
        public string ClaimIndirectTeachingAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string NonpayableProfessionalComponentAmount_19 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(20)]
        public string ClaimPaymentRemarkCode_20 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(21)]
        public string ClaimPaymentRemarkCode_21 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(22)]
        public string ClaimPaymentRemarkCode_22 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(23)]
        public string ClaimPaymentRemarkCode_23 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(24)]
        public string PPSCapitalExceptionAmount_24 { get; set; }
    }
    
    /// <summary>
    /// Outpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation : IMOA
    {
        
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [Pos(1)]
        public string ReimbursementRate_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(5)]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(7)]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Military Personnel Information
    /// </summary>
    [Serializable()]
    [Segment("MPI", typeof(X12_ID_1201), typeof(X12_ID_584))]
    public class MPI_DependentMilitaryPersonnelInformation : IMPI
    {
        
        /// <summary>
        /// Information Status Code
        /// </summary>
        [Pos(1)]
        public string InformationStatusCode_01 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(2)]
        public string EmploymentStatusCode_02 { get; set; }
        /// <summary>
        /// Government Service Affiliation Code
        /// </summary>
        [Pos(3)]
        public string GovernmentServiceAffiliationCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(4)]
        public string Description_04 { get; set; }
        /// <summary>
        /// Military Service Rank Code
        /// </summary>
        [Pos(5)]
        public string MilitaryServiceRankCode_05 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(6)]
        public string DateTimePeriodFormatQualifier_06 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(7)]
        public string DateTimePeriod_07 { get; set; }
    }
    
    /// <summary>
    /// Message Text
    /// </summary>
    [Serializable()]
    [Segment("MSG")]
    public class MSG_MessageText : IMSG
    {
        
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [Pos(1)]
        public string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [Pos(2)]
        public string PrinterCarriageControlCode_02 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [Pos(3)]
        public string Number_03 { get; set; }
    }
    
    /// <summary>
    /// Intermediary Bank Information
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_31))]
    public class N1_IntermediaryBankInformation : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payee Identification
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_22))]
    public class N1_PayeeIdentification : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payer
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_23))]
    public class N1_Payer : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payer Identification
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_26))]
    public class N1_PayerIdentification : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Reporting Category
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_17))]
    public class N1_ReportingCategory : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Sponsor Name
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_54))]
    public class N1_SponsorName : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// TPA/Broker Name
    /// </summary>
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_27))]
    public class N1_TPA : IN1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(4)]
        public string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Intermediary Bank Additional Name
    /// </summary>
    [Serializable()]
    [Segment("N2")]
    public class N2_IntermediaryBankAdditionalName : IN2
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [Pos(1)]
        public string IntermediaryBankAdditionalName_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Address
    /// </summary>
    [Serializable()]
    [Segment("N3")]
    public class N3_AdditionalPatientInformationContactAddress : IN3
    {
        
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(1)]
        public string ResponseContactAddressLine_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [Pos(2)]
        public string ResponseContactAddressLine_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [Segment("N4")]
    public class N4_AdditionalPatientInformationContactCity : IN4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [Pos(1)]
        public string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(2)]
        public string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [Pos(3)]
        public string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_38), typeof(X12_ID_1065_2))]
    public class NM1_AdditionalPatientInformationContactName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065_3))]
    public class NM1_AmbulanceDrop : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_3))]
    public class NM1_AmbulancePick : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065))]
    public class NM1_AssistantSurgeonName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Attending Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_49), typeof(X12_ID_1065))]
    public class NM1_AttendingProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_28), typeof(X12_ID_1065_2))]
    public class NM1_BillingProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Provider Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Provider First Name
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Provider Middle Name
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Provider Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Billing Provider Identifier
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_28), typeof(X12_ID_1065_3))]
    public class NM1_BillingProviderName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits Related Entity
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065_3))]
    public class NM1_CoordinationofBenefitsRelatedEntity : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Corrected Patient/Insured Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_37), typeof(X12_ID_1065_2))]
    public class NM1_CorrectedPatient : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Corrected Priority Payer Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_3))]
    public class NM1_CorrectedPriorityPayerName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Crossover Carrier Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_44), typeof(X12_ID_1065_3))]
    public class NM1_CrossoverCarrierName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Custodial Parent
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98), typeof(X12_ID_1065))]
    public class NM1_CustodialParent : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_30), typeof(X12_ID_1065_2))]
    public class NM1_DependentBenefitRelatedEntityName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_29), typeof(X12_ID_1065))]
    public class NM1_DependentName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_DependentName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_57), typeof(X12_ID_1065_4))]
    public class NM1_DependentName_3 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Drop Off Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_DropOffLocation : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Incorrect Member Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_36), typeof(X12_ID_1065))]
    public class NM1_IncorrectMemberName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Individual Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_42), typeof(X12_ID_1065))]
    public class NM1_IndividualName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_19), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_20), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Source Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_50), typeof(X12_ID_1065_2))]
    public class NM1_InformationSourceName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Source Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_51), typeof(X12_ID_1065_3))]
    public class NM1_InformationSourceName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Information Source Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Information Source Identifier
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Insured Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_25), typeof(X12_ID_1065_2))]
    public class NM1_InsuredName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Employer
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_43), typeof(X12_ID_1065_2))]
    public class NM1_MemberEmployer : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Mailing Address
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_40), typeof(X12_ID_1065))]
    public class NM1_MemberMailingAddress : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_32), typeof(X12_ID_1065))]
    public class NM1_MemberName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member School
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_46), typeof(X12_ID_1065_3))]
    public class NM1_MemberSchool : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Operating Physician Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065))]
    public class NM1_OperatingPhysicianName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_18), typeof(X12_ID_1065))]
    public class NM1_OrderingProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065))]
    public class NM1_OtherOperatingPhysicianName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Assistant Surgeon
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerAssistantSurgeon : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_48), typeof(X12_ID_1065))]
    public class NM1_OtherPayerReferringProvider : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065))]
    public class NM1_OtherPayerReferringProvider_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065))]
    public class NM1_OtherPayerRenderingProvider : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerRenderingProvider_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerServiceFacilityLocation : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_OtherPayerSupervisingProvider : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_47), typeof(X12_ID_1065_2))]
    public class NM1_OtherSubscriberName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Other UMO Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_60), typeof(X12_ID_1065_5))]
    public class NM1_PatientEventOtherUMOName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_58), typeof(X12_ID_1065_6))]
    public class NM1_PatientEventProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_34), typeof(X12_ID_1065_2))]
    public class NM1_PatientEventProviderName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_59), typeof(X12_ID_1065_5))]
    public class NM1_PatientEventTransportInformation : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_41), typeof(X12_ID_1065_3))]
    public class NM1_PatientEventTransportInformation_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_33), typeof(X12_ID_1065_2))]
    public class NM1_Pay : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_33), typeof(X12_ID_1065_3))]
    public class NM1_Pay_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_22), typeof(X12_ID_1065_3))]
    public class NM1_Pay_3 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_2))]
    public class NM1_ProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065_2))]
    public class NM1_ProviderName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_2))]
    public class NM1_PurchasedServiceProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_24), typeof(X12_ID_1065_3))]
    public class NM1_ReceiverName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Requester Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_55), typeof(X12_ID_1065_6))]
    public class NM1_RequesterName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Requester Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_21), typeof(X12_ID_1065_2))]
    public class NM1_RequesterName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Responsible Person
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_ResponsiblePerson : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_61), typeof(X12_ID_1065_6))]
    public class NM1_ServiceProviderName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_45), typeof(X12_ID_1065_2))]
    public class NM1_ServiceProviderName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_56), typeof(X12_ID_1065_4))]
    public class NM1_SubscriberName : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_25), typeof(X12_ID_1065))]
    public class NM1_SubscriberName_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_62), typeof(X12_ID_1065_6))]
    public class NM1_UtilizationManagementOrganization : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_52), typeof(X12_ID_1065_2))]
    public class NM1_UtilizationManagementOrganization_2 : INM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363))]
    public class NTE_BillingNote : INTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_4))]
    public class NTE_ClaimNote : INTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_5))]
    public class NTE_ClaimNote_2 : INTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Line Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_LineNote : INTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Third Party Organization Notes
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ThirdPartyOrganizationNotes : INTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Other Insurance Coverage Information
    /// </summary>
    [Serializable()]
    [Segment("OI", typeof(X12_ID_1032), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation : IOI
    {
        
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [Pos(1)]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [Pos(2)]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(3)]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [Pos(4)]
        public string PatientSignatureSourceCode_04 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(5)]
        public string ProviderAgreementCode_05 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(6)]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
    public class PAT_PatientInformation : IPAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_5), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_2 : IPAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_AdditionalPatientInformationContactInformation : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Administrative Communications Contact
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_7))]
    public class PER_AdministrativeCommunicationsContact : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_9))]
    public class PER_ClaimContactInformation : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Custodial Parent Communications Numbers
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_5))]
    public class PER_CustodialParentCommunicationsNumbers : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member Communications Numbers
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_8))]
    public class PER_MemberCommunicationsNumbers : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member Employer Communications Numbers
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_MemberEmployerCommunicationsNumbers : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member School Commmunications Numbers
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_3))]
    public class PER_MemberSchoolCommmunicationsNumbers : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_10))]
    public class PER_PatientEventProviderContactInformation : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Payer Technical Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_2))]
    public class PER_PayerTechnicalContactInformation : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Responsible Person Communications Numbers
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_6))]
    public class PER_ResponsiblePersonCommunicationsNumbers : IPER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Provider Change Reason
    /// </summary>
    [Serializable()]
    [Segment("PLA", typeof(X12_ID_306_2), typeof(X12_ID_98_12))]
    public class PLA_ProviderChangeReason : IPLA
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(1)]
        public string ActionCode_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(2)]
        public string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(3)]
        public string ProviderEffectiveDate_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [Pos(5)]
        public string MaintenanceReasonCode_05 { get; set; }
    }
    
    /// <summary>
    /// Provider Adjustment
    /// </summary>
    [Serializable()]
    [Segment("PLB")]
    public class PLB_ProviderAdjustment : IPLB<C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier>
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(1)]
        public string ProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string FiscalPeriodDate_02 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(3)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string ProviderAdjustmentAmount_04 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(5)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string ProviderAdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(7)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string ProviderAdjustmentAmount_08 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(9)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(10)]
        public string ProviderAdjustmentAmount_10 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(11)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(12)]
        public string ProviderAdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [Pos(13)]
        public C042_AdjustmentIdentifier AdjustmentIdentifier_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(14)]
        public string ProviderAdjustmentAmount_14 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_7), typeof(X12_ID_128_33))]
    public class PRV_AssistantSurgeonSpecialtyInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Attending Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_4), typeof(X12_ID_128_33))]
    public class PRV_AttendingProviderSpecialtyInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_10), typeof(X12_ID_128_33))]
    public class PRV_BillingProviderSpecialtyInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_8), typeof(X12_ID_128_33))]
    public class PRV_DependentBenefitRelatedProviderInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_11), typeof(X12_ID_128_85))]
    public class PRV_PatientEventProviderInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128_33))]
    public class PRV_PatientEventProviderInformation_2 : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128_50))]
    public class PRV_ProviderInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128_33))]
    public class PRV_ProviderInformation_2 : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_3), typeof(X12_ID_128_33))]
    public class PRV_ReferringProviderSpecialtyInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_5), typeof(X12_ID_128_33))]
    public class PRV_RenderingProviderSpecialtyInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Requester Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_13), typeof(X12_ID_128_85))]
    public class PRV_RequesterProviderInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Requester Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_9), typeof(X12_ID_128_33))]
    public class PRV_RequesterProviderInformation_2 : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_12), typeof(X12_ID_128_85))]
    public class PRV_ServiceProviderInformation : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_6), typeof(X12_ID_128_33))]
    public class PRV_ServiceProviderInformation_2 : IPRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Information
    /// </summary>
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation : IPS1
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_6), typeof(X12_ID_756_6))]
    public class PWK_AdditionalPatientInformation : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
    public class PWK_AdditionalPatientInformation_2 : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_4), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_2 : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_5), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_3 : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certificate of Medical Necessity Indicator
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator : IPWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Patient Count
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_10))]
    public class QTY_AmbulancePatientCount : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_9))]
    public class QTY_ClaimSupplementalInformationQuantity : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Obstetric Anesthesia Additional Units
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_4))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Service Supplemental Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_3))]
    public class QTY_ServiceSupplementalQuantity : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_5))]
    public class QTY_TotalAcceptedQuantity : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_7))]
    public class QTY_TotalAcceptedQuantity_2 : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_6))]
    public class QTY_TotalRejectedQuantity : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Quantity
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_2))]
    public class QTY_TotalRejectedQuantity_2 : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Transaction Set Control Totals
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_8))]
    public class QTY_TransactionSetControlTotals : IQTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Premium Receiver's Remittance Delivery Method
    /// </summary>
    [Serializable()]
    [Segment("RDM", typeof(X12_ID_756_3))]
    public class RDM_PremiumReceiver : IRDM<C040_ReferenceIdentifier, C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(1)]
        public string RemittanceDeliveryMethodCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumReceiversLastorOrganizationName_02 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(3)]
        public string PremiumReceiversCommunicationNumber_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(5)]
        public C040_ReferenceIdentifier ReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Remittance Delivery Method
    /// </summary>
    [Serializable()]
    [Segment("RDM", typeof(X12_ID_756_4))]
    public class RDM_RemittanceDeliveryMethod : IRDM<C040_ReferenceIdentifier, C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Pos(1)]
        public string RemittanceDeliveryMethodCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(2)]
        public string PremiumReceiversLastorOrganizationName_02 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Pos(3)]
        public string PremiumReceiversCommunicationNumber_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(5)]
        public C040_ReferenceIdentifier ReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Additional Coordination of Benefits Identifiers
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_75))]
    public class REF_AdditionalCoordinationofBenefitsIdentifiers : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Additional Payer Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_47))]
    public class REF_AdditionalPayerIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_12))]
    public class REF_AdjustedRepricedClaimNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_31))]
    public class REF_AdjustedRepricedLineItemReferenceNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Administrative Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_63))]
    public class REF_AdministrativeReferenceNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Application or Location System Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_ApplicationorLocationSystemIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_22))]
    public class REF_AssistantSurgeonSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_2))]
    public class REF_BillingProviderSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_20))]
    public class REF_BillingProviderTaxIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_BillingProviderTaxIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider UPIN/License Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_48))]
    public class REF_BillingProviderUPIN : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Care Plan Oversight
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_CarePlanOversight : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Identification Number For Clearinghouses and Other Transmission Intermediaries
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Clinical Laboratory Improvement Amendment (CLIA) Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_ClinicalLaboratoryImprovementAmendment : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Demonstration Project Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_DemonstrationProjectIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_69))]
    public class REF_DependentAdditionalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_68))]
    public class REF_DependentAdditionalIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_60))]
    public class REF_DependentAdditionalIdentification_3 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_59))]
    public class REF_DependentAdditionalInformation : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_87))]
    public class REF_DependentSupplementalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_54))]
    public class REF_DependentSupplementalIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Group Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_52))]
    public class REF_GroupNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// HealthCare Policy Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_4))]
    public class REF_HealthCarePolicyIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Policy Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_65))]
    public class REF_HealthCoveragePolicyNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Immunization Batch Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_40))]
    public class REF_ImmunizationBatchNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_79))]
    public class REF_InformationReceiverAdditionalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Institutional Bill Type Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_InstitutionalBillTypeIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Investigational Device Exemption Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_InvestigationalDeviceExemptionNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Line Item Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_LineItemControlNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mammography Certification Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_11))]
    public class REF_MammographyCertificationNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mandatory Medicare (Section 4081) Crossover Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Medical Record Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_MedicalRecordNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Member Policy Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_46))]
    public class REF_MemberPolicyNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Member Supplemental Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_56))]
    public class REF_MemberSupplementalIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_OrderingProviderSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Claim Related Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_66))]
    public class REF_OtherClaimRelatedIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Adjustment Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OtherPayerClaimAdjustmentIndicator : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_OtherPayerClaimControlNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Predetermination Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_5))]
    public class REF_OtherPayerPredeterminationIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Prior Authorization Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_OtherPayerPriorAuthorizationNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referral Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_3))]
    public class REF_OtherPayerReferralNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Secondary Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_73))]
    public class REF_OtherPayerSecondaryIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_24))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_58))]
    public class REF_OtherSubscriberSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other UMO Denial Reason
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_91))]
    public class REF_OtherUMODenialReason : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_43))]
    public class REF_PatientControlNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_74))]
    public class REF_PatientEventProviderSupplementalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_90))]
    public class REF_PatientEventProviderSupplementalInformation : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_49))]
    public class REF_Pay : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Payee Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_57))]
    public class REF_PayeeAdditionalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_35))]
    public class REF_PayerClaimControlNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Peer Review Organization (PRO) Approval Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_PeerReviewOrganization : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Pharmacy Prescription Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_53))]
    public class REF_PharmacyPrescriptionNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Premium Receivers Identification Key
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_82))]
    public class REF_PremiumReceiversIdentificationKey : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Prescription or Compound Drug Association Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Administrative Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_89))]
    public class REF_PreviousReviewAdministrativeReferenceNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Authorization Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_88))]
    public class REF_PreviousReviewAuthorizationNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Authorization Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_70))]
    public class REF_PreviousReviewAuthorizationNumber_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Prior Coverage Months
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_71))]
    public class REF_PriorCoverageMonths : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_67))]
    public class REF_PropertyandCasualtyClaimNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_PropertyandCasualtyPatientIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Provider Secondary Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_80))]
    public class REF_ProviderSecondaryIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Billing Provider Additional Identifier
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Receiver Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_84))]
    public class REF_ReceiverIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reference Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_64))]
    public class REF_ReferenceInformation : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reference Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_45))]
    public class REF_ReferenceInformation_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_39))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_72))]
    public class REF_RenderingProviderIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128))]
    public class REF_RenderingProviderInformation : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reporting Category Reference
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_78))]
    public class REF_ReportingCategoryReference : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_RepricedClaimNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_30))]
    public class REF_RepricedLineItemReferenceNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_92))]
    public class REF_RequesterSupplementalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_81))]
    public class REF_RequesterSupplementalIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Authorization Exception Code
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7), typeof(X12_ID_127))]
    public class REF_ServiceAuthorizationExceptionCode : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_ServiceFacilityLocationSecondaryIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_76))]
    public class REF_ServiceIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Line Item Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_62))]
    public class REF_ServiceLineItemIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_77))]
    public class REF_ServiceProviderSupplementalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_51))]
    public class REF_SubscriberAdditionalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_41))]
    public class REF_SubscriberAdditionalIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_42))]
    public class REF_SubscriberAdditionalIdentification_3 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_37))]
    public class REF_SubscriberIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_86))]
    public class REF_SubscriberSupplementalIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Supplemental Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_44))]
    public class REF_SubscriberSupplementalIdentification_2 : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Transaction Set Policy Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_83))]
    public class REF_TransactionSetPolicyNumber : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Version Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_38))]
    public class REF_VersionIdentification : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Voucher Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_61))]
    public class REF_VoucherIdentifier : IREF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Individual Premium Remittance Detail
    /// </summary>
    [Serializable()]
    [Segment("RMR", typeof(X12_ID_128_55))]
    public class RMR_IndividualPremiumRemittanceDetail : IRMR
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string InsuranceRemittanceReferenceNumber_02 { get; set; }
        /// <summary>
        /// Payment Action Code
        /// </summary>
        [Pos(3)]
        public string PaymentActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string DetailPremiumPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string BilledPremiumAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [Pos(7)]
        public string AdjustmentReasonCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
    }
    
    /// <summary>
    /// Organization Summary Remittance Detail
    /// </summary>
    [Serializable()]
    [Segment("RMR", typeof(X12_ID_128_36))]
    public class RMR_OrganizationSummaryRemittanceDetail : IRMR
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string InsuranceRemittanceReferenceNumber_02 { get; set; }
        /// <summary>
        /// Payment Action Code
        /// </summary>
        [Pos(3)]
        public string PaymentActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string DetailPremiumPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string BilledPremiumAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [Pos(7)]
        public string AdjustmentReasonCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [Segment("SAC", typeof(X12_ID_248), typeof(X12_ID_1300))]
    public class SAC_Service : ISAC
    {
        
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [Pos(2)]
        public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [Pos(3)]
        public string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Agency Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [Pos(4)]
        public string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [Pos(5)]
        public string Amount_05 { get; set; }
        /// <summary>
        /// Allowance/Charge Percent Qualifier
        /// </summary>
        [Pos(6)]
        public string AllowanceChargePercentQualifier_06 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [Pos(7)]
        public string PercentDecimalFormat_07 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [Pos(8)]
        public string Rate_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(9)]
        public string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(11)]
        public string Quantity_11 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [Pos(12)]
        public string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(13)]
        public string ReferenceIdentification_13 { get; set; }
        /// <summary>
        /// Option Number
        /// </summary>
        [Pos(14)]
        public string OptionNumber_14 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(15)]
        public string Description_15 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [Pos(16)]
        public string LanguageCode_16 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_4))]
    public class SBR_OtherSubscriberInformation : ISBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_6))]
    public class SBR_SubscriberInformation : ISBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Member Count
    /// </summary>
    [Serializable()]
    [Segment("SLN")]
    public class SLN_MemberCount : ISLN<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Pos(1)]
        public string LineItemControlNumber_01 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Pos(2)]
        public string AssignedIdentification_02 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [Pos(3)]
        public string InformationOnlyIndicator_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string HeadCount_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(5)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [Pos(8)]
        public string RelationshipCode_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(28)]
        public string ProductServiceID_28 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Status Information
    /// </summary>
    [Serializable()]
    [Segment("STC")]
    public class STC_BillingProviderStatusInformation : ISTC<C043_HealthCareClaimStatus, C043_HealthCareClaimStatus, C043_HealthCareClaimStatus>
    {
        
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [Pos(1)]
        public C043_HealthCareClaimStatus HealthCareClaimStatus_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [Pos(3)]
        public string ActionCode_03 { get; set; }
        /// <summary>
        /// Total Submitted Charges for Unit Work
        /// </summary>
        [Pos(4)]
        public string TotalSubmittedChargesForUnitWork_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [Pos(7)]
        public string PaymentMethodCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Check Number
        /// </summary>
        [Pos(9)]
        public string CheckNumber_09 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [Pos(10)]
        public C043_HealthCareClaimStatus HealthCareClaimStatus_10 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [Pos(11)]
        public C043_HealthCareClaimStatus HealthCareClaimStatus_11 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [Pos(12)]
        public string FreeformMessageText_12 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_4))]
    public class SV1_ProfessionalService : ISV1<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_13))]
    public class SV1_ProfessionalService_2 : ISV1<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235))]
    public class SV1_ProfessionalService_3 : ISV1<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Institutional Service Line
    /// </summary>
    [Serializable()]
    [Segment("SV2")]
    public class SV2_InstitutionalServiceLine : ISV2<C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(1)]
        public string ServiceLineRevenueCode_01 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(2)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string LineItemChargeAmount_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string ServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Unit Rate
        /// </summary>
        [Pos(6)]
        public string UnitRate_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(8)]
        public string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [Pos(9)]
        public string NursingHomeResidentialStatusCode_09 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [Pos(10)]
        public string LevelofCareCode_10 { get; set; }
    }
    
    /// <summary>
    /// Dental Service
    /// </summary>
    [Serializable()]
    [Segment("SV3", typeof(X12_ID_235_2))]
    public class SV3_DentalService : ISV3<C003_CompositeMedicalProcedureIdentifier, C006_OralCavityDesignation, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(3)]
        public string PlaceofServiceCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation
        /// </summary>
        [Pos(4)]
        public C006_OralCavityDesignation OralCavityDesignation_04 { get; set; }
        /// <summary>
        /// Prosthesis, Crown or Inlay Code
        /// </summary>
        [Pos(5)]
        public string ProsthesisCrownorInlayCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string ProcedureCount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [Pos(8)]
        public string CopayStatusCode_08 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(9)]
        public string ProviderAgreementCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(11)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    /// <summary>
    /// Dental Service
    /// </summary>
    [Serializable()]
    [Segment("SV3", typeof(X12_ID_235_15))]
    public class SV3_DentalService_2 : ISV3<C003_CompositeMedicalProcedureIdentifier, C006_OralCavityDesignation, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(3)]
        public string PlaceofServiceCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation
        /// </summary>
        [Pos(4)]
        public C006_OralCavityDesignation OralCavityDesignation_04 { get; set; }
        /// <summary>
        /// Prosthesis, Crown or Inlay Code
        /// </summary>
        [Pos(5)]
        public string ProsthesisCrownorInlayCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string ProcedureCount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [Pos(8)]
        public string CopayStatusCode_08 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [Pos(9)]
        public string ProviderAgreementCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(10)]
        public string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Pos(11)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Service
    /// </summary>
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_7), typeof(X12_ID_355_3))]
    public class SV5_DurableMedicalEquipmentService : ISV5<C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(3)]
        public string LengthofMedicalNecessity_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string DMERentalPrice_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string DMEPurchasePrice_05 { get; set; }
        /// <summary>
        /// Frequency Code
        /// </summary>
        [Pos(6)]
        public string RentalUnitPriceIndicator_06 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(7)]
        public string PrognosisCode_07 { get; set; }
    }
    
    /// <summary>
    /// Service Line Information
    /// </summary>
    [Serializable()]
    [Segment("SVC", typeof(X12_ID_235_10))]
    public class SVC_ServiceLineInformation : ISVC<C003_CompositeMedicalProcedureIdentifier, C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(4)]
        public string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(6)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Service Line Information
    /// </summary>
    [Serializable()]
    [Segment("SVC", typeof(X12_ID_235_11))]
    public class SVC_ServiceLineInformation_2 : ISVC<C003_CompositeMedicalProcedureIdentifier, C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Line Item Charge Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Revenue Code
        /// </summary>
        [Pos(4)]
        public string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(6)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Original Units of Service Count
        /// </summary>
        [Pos(7)]
        public string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Service Payment Information
    /// </summary>
    [Serializable()]
    [Segment("SVC", typeof(X12_ID_235_12))]
    public class SVC_ServicePaymentInformation : ISVC<C003_CompositeMedicalProcedureIdentifier, C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(4)]
        public string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(6)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation : ISVD<C003_CompositeMedicalProcedureIdentifier>
    {
        
        /// <summary>
        /// Identification Code
        /// </summary>
        [Pos(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Pos(3)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(4)]
        public string ProductServiceID_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [Pos(6)]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    /// <summary>
    /// Tooth Information
    /// </summary>
    [Serializable()]
    [Segment("TOO", typeof(X12_ID_1270_8))]
    public class TOO_ToothInformation : ITOO<C005_ToothSurface>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string ToothCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface
        /// </summary>
        [Pos(3)]
        public C005_ToothSurface ToothSurface_03 { get; set; }
    }
    
    /// <summary>
    /// Tooth Information
    /// </summary>
    [Serializable()]
    [Segment("TOO", typeof(X12_ID_1270_29))]
    public class TOO_ToothInformation_2 : ITOO<C005_ToothSurface>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string ToothCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface
        /// </summary>
        [Pos(3)]
        public C005_ToothSurface ToothSurface_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Segment("TRN", typeof(X12_ID_481))]
    public class TRN_ClaimStatusTrackingNumber : ITRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(3)]
        public string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [Segment("TRN", typeof(X12_ID_481_2))]
    public class TRN_ClaimStatusTrackingNumber_2 : ITRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(3)]
        public string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Trace Number
    /// </summary>
    [Serializable()]
    [Segment("TRN", typeof(X12_ID_481_3))]
    public class TRN_DependentTraceNumber : ITRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(3)]
        public string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Tracking Number
    /// </summary>
    [Serializable()]
    [Segment("TRN", typeof(X12_ID_1065_4))]
    public class TRN_PatientEventTrackingNumber : ITRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(3)]
        public string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Reassociation Trace Number
    /// </summary>
    [Serializable()]
    [Segment("TRN", typeof(X12_ID_481_4))]
    public class TRN_ReassociationTraceNumber : ITRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [Pos(3)]
        public string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Provider Supplemental Summary Information
    /// </summary>
    [Serializable()]
    [Segment("TS2")]
    public class TS2_ProviderSupplementalSummaryInformation : ITS2
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(1)]
        public string TotalDRGAmount_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(2)]
        public string TotalFederalSpecificAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(3)]
        public string TotalHospitalSpecificAmount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(4)]
        public string TotalDisproportionateShareAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string TotalCapitalAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string TotalIndirectMedicalEducationAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(7)]
        public string TotalOutlierDayCount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string TotalDayOutlierAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string TotalCostOutlierAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(10)]
        public string AverageDRGLengthofStay_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(11)]
        public string TotalDischargeCount_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(12)]
        public string TotalCostReportDayCount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(13)]
        public string TotalCoveredDayCount_13 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(14)]
        public string TotalNoncoveredDayCount_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(15)]
        public string TotalMSPPassThroughAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(16)]
        public string AverageDRGweight_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(17)]
        public string TotalPPSCapitalFSPDRGAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(18)]
        public string TotalPPSCapitalHSPDRGAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string TotalPPSDSHDRGAmount_19 { get; set; }
    }
    
    /// <summary>
    /// Provider Summary Information
    /// </summary>
    [Serializable()]
    [Segment("TS3")]
    public class TS3_ProviderSummaryInformation : ITS3
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(1)]
        public string ProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(2)]
        public string FacilityTypeCode_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Pos(3)]
        public string FiscalPeriodDate_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(4)]
        public string TotalClaimCount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string TotalClaimChargeAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(7)]
        public string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(9)]
        public string MonetaryAmount_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(10)]
        public string MonetaryAmount_10 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(11)]
        public string MonetaryAmount_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(12)]
        public string MonetaryAmount_12 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(13)]
        public string TotalMSPPayerAmount_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(14)]
        public string MonetaryAmount_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(15)]
        public string TotalNonLabChargeAmount_15 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(16)]
        public string MonetaryAmount_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(17)]
        public string TotalHCPCSReportedChargeAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(18)]
        public string TotalHCPCSPayableAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(20)]
        public string TotalProfessionalComponentAmount_20 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(21)]
        public string TotalMSPPatientLiabilityMetAmount_21 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(22)]
        public string TotalPatientReimbursementAmount_22 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(23)]
        public string TotalPIPClaimCount_23 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(24)]
        public string TotalPIPAdjustmentAmount_24 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [Segment("UM", typeof(X12_ID_1525_3), typeof(X12_ID_1322_5))]
    public class UM_HealthCareServicesReviewInformation : IUM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(1)]
        public string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(2)]
        public string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Pos(4)]
        public C023_HealthCareServiceLocationInformation ValuesenteredattheServiceLeveloverridesthevalueatthePatientEventLevelforthisservice_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(5)]
        public C024_RelatedCausesInformation RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [Pos(6)]
        public string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [Pos(7)]
        public string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(8)]
        public string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [Pos(10)]
        public string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [Segment("UM", typeof(X12_ID_1525), typeof(X12_ID_1322_2))]
    public class UM_HealthCareServicesReviewInformation_2 : IUM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(1)]
        public string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(2)]
        public string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Pos(4)]
        public C023_HealthCareServiceLocationInformation ValuesenteredattheServiceLeveloverridesthevalueatthePatientEventLevelforthisservice_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(5)]
        public C024_RelatedCausesInformation RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [Pos(6)]
        public string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [Pos(7)]
        public string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(8)]
        public string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [Pos(10)]
        public string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [Segment("UM", typeof(X12_ID_1525_4), typeof(X12_ID_1322_5))]
    public class UM_HealthCareServicesReviewInformation_3 : IUM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(1)]
        public string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(2)]
        public string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Pos(4)]
        public C023_HealthCareServiceLocationInformation ValuesenteredattheServiceLeveloverridesthevalueatthePatientEventLevelforthisservice_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(5)]
        public C024_RelatedCausesInformation RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [Pos(6)]
        public string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [Pos(7)]
        public string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(8)]
        public string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [Pos(10)]
        public string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [Segment("UM", typeof(X12_ID_1525_2), typeof(X12_ID_1322_2))]
    public class UM_HealthCareServicesReviewInformation_4 : IUM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [Pos(1)]
        public string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Pos(2)]
        public string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [Pos(3)]
        public string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Pos(4)]
        public C023_HealthCareServiceLocationInformation ValuesenteredattheServiceLeveloverridesthevalueatthePatientEventLevelforthisservice_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(5)]
        public C024_RelatedCausesInformation RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [Pos(6)]
        public string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [Pos(7)]
        public string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [Pos(8)]
        public string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [Pos(10)]
        public string DelayReasonCode_10 { get; set; }
    }
}
