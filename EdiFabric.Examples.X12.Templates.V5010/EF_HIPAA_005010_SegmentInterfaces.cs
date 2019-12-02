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
    using System.Linq;

    public interface I_AAA
    {
        
        string ValidRequestIndicator_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string RejectReasonCode_03 { get; set; }
        string FollowupActionCode_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class AAA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ValidRequestIndicator_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AgencyQualifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string RejectReasonCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string FollowupActionCode_04 { get; set; }
    }
    
    public interface I_ACT
    {
        
        string TPAorBrokerAccountNumber_01 { get; set; }
        string Name_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string AccountNumberQualifier_05 { get; set; }
        string TPAorBrokerAccountNumber_06 { get; set; }
        string Description_07 { get; set; }
        string PaymentMethodTypeCode_08 { get; set; }
        string BenefitStatusCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class ACT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string TPAorBrokerAccountNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Name_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string IdentificationCodeQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string IdentificationCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string AccountNumberQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string TPAorBrokerAccountNumber_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Description_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string PaymentMethodTypeCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string BenefitStatusCode_09 { get; set; }
    }
    
    public interface I_ADX
    {
        
        string AdjustmentAmount_01 { get; set; }
        string AdjustmentReasonCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class ADX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AdjustmentAmount_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AdjustmentReasonCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ReferenceIdentificationQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_AMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string TotalClaimChargeAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class AMT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AmountQualifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TotalClaimChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CreditDebitFlagCode_03 { get; set; }
    }
    
    public interface I_BGN
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionSetReferenceNumber_02 { get; set; }
        string TransactionSetCreationDate_03 { get; set; }
        string TransactionSetCreationTime_04 { get; set; }
        string TimeZoneCode_05 { get; set; }
        string OriginalTransactionSetReferenceNumber_06 { get; set; }
        string TransactionTypeCode_07 { get; set; }
        string ActionCode_08 { get; set; }
        string SecurityLevelCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class BGN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string TransactionSetPurposeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TransactionSetReferenceNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string TransactionSetCreationDate_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TransactionSetCreationTime_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TimeZoneCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string OriginalTransactionSetReferenceNumber_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string TransactionTypeCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ActionCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string SecurityLevelCode_09 { get; set; }
    }
    
    public interface I_BHT
    {
        
        string HierarchicalStructureCode_01 { get; set; }
        string TransactionSetPurposeCode_02 { get; set; }
        string SubmitterTransactionIdentifier_03 { get; set; }
        string TransactionSetCreationDate_04 { get; set; }
        string TransactionSetCreationTime_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class BHT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string HierarchicalStructureCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TransactionSetPurposeCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string SubmitterTransactionIdentifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TransactionSetCreationDate_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TransactionSetCreationTime_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string TransactionTypeCode_06 { get; set; }
    }
    
    public interface I_BPR
    {
        
        string TransactionHandlingCode_01 { get; set; }
        string TotalPremiumPaymentAmount_02 { get; set; }
        string CreditorDebitFlagCode_03 { get; set; }
        string PaymentMethodCode_04 { get; set; }
        string PaymentFormatCode_05 { get; set; }
        string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        string AccountNumberQualifier_08 { get; set; }
        string SenderBankAccountNumber_09 { get; set; }
        string PayerIdentifier_10 { get; set; }
        string OriginatingCompanySupplementalCode_11 { get; set; }
        string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        string AccountNumberQualifier_14 { get; set; }
        string ReceiverBankAccountNumber_15 { get; set; }
        string CheckIssueorEFTEffectiveDate_16 { get; set; }
        string BusinessFunctionCode_17 { get; set; }
        string DFIIDNumberQualifier_18 { get; set; }
        string DFIIdentificationNumber_19 { get; set; }
        string AccountNumberQualifier_20 { get; set; }
        string AccountNumber_21 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class BPR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string TransactionHandlingCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TotalPremiumPaymentAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CreditorDebitFlagCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string PaymentMethodCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PaymentFormatCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string AccountNumberQualifier_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string SenderBankAccountNumber_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string PayerIdentifier_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string OriginatingCompanySupplementalCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string AccountNumberQualifier_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string ReceiverBankAccountNumber_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string CheckIssueorEFTEffectiveDate_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string BusinessFunctionCode_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string DFIIDNumberQualifier_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string DFIIdentificationNumber_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string AccountNumberQualifier_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string AccountNumber_21 { get; set; }
    }
    
    public interface I_CAS
    {
        
        string ClaimAdjustmentGroupCode_01 { get; set; }
        string AdjustmentReasonCode_02 { get; set; }
        string AdjustmentAmount_03 { get; set; }
        string AdjustmentQuantity_04 { get; set; }
        string AdjustmentReasonCode_05 { get; set; }
        string AdjustmentAmount_06 { get; set; }
        string AdjustmentQuantity_07 { get; set; }
        string AdjustmentReasonCode_08 { get; set; }
        string AdjustmentAmount_09 { get; set; }
        string AdjustmentQuantity_10 { get; set; }
        string AdjustmentReasonCode_11 { get; set; }
        string AdjustmentAmount_12 { get; set; }
        string AdjustmentQuantity_13 { get; set; }
        string AdjustmentReasonCode_14 { get; set; }
        string AdjustmentAmount_15 { get; set; }
        string AdjustmentQuantity_16 { get; set; }
        string AdjustmentReasonCode_17 { get; set; }
        string AdjustmentAmount_18 { get; set; }
        string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CAS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ClaimAdjustmentGroupCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AdjustmentReasonCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string AdjustmentAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string AdjustmentQuantity_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string AdjustmentReasonCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string AdjustmentAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string AdjustmentQuantity_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string AdjustmentReasonCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string AdjustmentAmount_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string AdjustmentQuantity_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string AdjustmentReasonCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string AdjustmentAmount_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string AdjustmentQuantity_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string AdjustmentReasonCode_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string AdjustmentAmount_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string AdjustmentQuantity_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string AdjustmentReasonCode_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string AdjustmentAmount_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string AdjustmentQuantity_19 { get; set; }
    }
    
    public interface I_CL1
    {
        
        string AdmissionTypeCode_01 { get; set; }
        string AdmissionSourceCode_02 { get; set; }
        string PatientStatusCode_03 { get; set; }
        string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CL1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AdmissionTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AdmissionSourceCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string PatientStatusCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    public interface I_CLM<T1, T2>
        where T1 : I_C023
        where T2 : I_C024
    {
        
        string PatientControlNumber_01 { get; set; }
        string TotalClaimChargeAmount_02 { get; set; }
        string ClaimFilingIndicatorCode_03 { get; set; }
        string NonInstitutionalClaimTypeCode_04 { get; set; }
        T1 HealthCareServiceLocationInformation_05 { get; set; }
        string ProviderorSupplierSignatureIndicator_06 { get; set; }
        string AssignmentorPlanParticipationCode_07 { get; set; }
        string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        string ReleaseofInformationCode_09 { get; set; }
        string PatientSignatureSourceCode_10 { get; set; }
        T2 RelatedCausesInformation_11 { get; set; }
        string SpecialProgramIndicator_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
        string LevelofServiceCode_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
        string ProviderAgreementCode_16 { get; set; }
        string ClaimStatusCode_17 { get; set; }
        string YesNoConditionorResponseCode_18 { get; set; }
        string PredeterminationofBenefitsCode_19 { get; set; }
        string DelayReasonCode_20 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CLM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PatientControlNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TotalClaimChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ClaimFilingIndicatorCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string NonInstitutionalClaimTypeCode_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string AssignmentorPlanParticipationCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ReleaseofInformationCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string PatientSignatureSourceCode_10 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string SpecialProgramIndicator_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string YesNoConditionorResponseCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string LevelofServiceCode_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string YesNoConditionorResponseCode_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string ProviderAgreementCode_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ClaimStatusCode_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string YesNoConditionorResponseCode_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string PredeterminationofBenefitsCode_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string DelayReasonCode_20 { get; set; }
    }
    
    public interface I_CLP
    {
        
        string PatientControlNumber_01 { get; set; }
        string ClaimStatusCode_02 { get; set; }
        string TotalClaimChargeAmount_03 { get; set; }
        string ClaimPaymentAmount_04 { get; set; }
        string PatientResponsibilityAmount_05 { get; set; }
        string ClaimFilingIndicatorCode_06 { get; set; }
        string PayerClaimControlNumber_07 { get; set; }
        string FacilityTypeCode_08 { get; set; }
        string ClaimFrequencyCode_09 { get; set; }
        string PatientStatusCode_10 { get; set; }
        string DiagnosisRelatedGroupDRGCode_11 { get; set; }
        string DiagnosisRelatedGroupDRGWeight_12 { get; set; }
        string DischargeFraction_13 { get; set; }
        string YesNoConditionorResponseCode_14 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CLP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PatientControlNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ClaimStatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string TotalClaimChargeAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ClaimPaymentAmount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PatientResponsibilityAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ClaimFilingIndicatorCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string PayerClaimControlNumber_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string FacilityTypeCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ClaimFrequencyCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string PatientStatusCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string DiagnosisRelatedGroupDRGCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string DiagnosisRelatedGroupDRGWeight_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string DischargeFraction_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string YesNoConditionorResponseCode_14 { get; set; }
    }
    
    public interface I_CN1
    {
        
        string ContractTypeCode_01 { get; set; }
        string ContractAmount_02 { get; set; }
        string ContractPercentage_03 { get; set; }
        string ContractCode_04 { get; set; }
        string TermsDiscountPercentage_05 { get; set; }
        string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CN1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ContractTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ContractAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ContractPercentage_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ContractCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TermsDiscountPercentage_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ContractVersionIdentifier_06 { get; set; }
    }
    
    public interface I_COB
    {
        
        string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        string MemberGrouporPolicyNumber_02 { get; set; }
        string CoordinationofBenefitsCode_03 { get; set; }
        List<string> ServiceTypeCode_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class COB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MemberGrouporPolicyNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CoordinationofBenefitsCode_03 { get; set; }

        protected List<string> _serviceTypeCode { get; set; }
        public virtual string ServiceTypeCode
        {
            get
            {
                if (_serviceTypeCode != null)
                    return string.Join("^", _serviceTypeCode);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _serviceTypeCode = value.Split('^').ToList();
            }
        }
    }
    
    public interface I_CR1
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string PatientWeight_02 { get; set; }
        string AmbulanceTransportCode_03 { get; set; }
        string AmbulanceTransportReasonCode_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string TransportDistance_06 { get; set; }
        string AddressInformation_07 { get; set; }
        string AddressInformation_08 { get; set; }
        string RoundTripPurposeDescription_09 { get; set; }
        string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CR1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string UnitorBasisforMeasurementCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PatientWeight_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string AmbulanceTransportCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string AmbulanceTransportReasonCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string UnitorBasisforMeasurementCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string TransportDistance_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string AddressInformation_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string AddressInformation_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string RoundTripPurposeDescription_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string StretcherPurposeDescription_10 { get; set; }
    }
    
    public interface I_CR2
    {
        
        string Count_01 { get; set; }
        string Quantity_02 { get; set; }
        string SubluxationLevelCode_03 { get; set; }
        string SubluxationLevelCode_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
        string PatientConditionCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string PatientConditionDescription_10 { get; set; }
        string PatientConditionDescription_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CR2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string Count_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string SubluxationLevelCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string SubluxationLevelCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string UnitorBasisforMeasurementCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string Quantity_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Quantity_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string PatientConditionCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string YesNoConditionorResponseCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string PatientConditionDescription_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string PatientConditionDescription_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_CR3
    {
        
        string CertificationTypeCode_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string DurableMedicalEquipmentDuration_03 { get; set; }
        string InsulinDependentCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CR3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CertificationTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string UnitorBasisforMeasurementCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DurableMedicalEquipmentDuration_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string InsulinDependentCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Description_05 { get; set; }
    }
    
    public interface I_CR5
    {
        
        string CertificationTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string OxygenEquipmentTypeCode_03 { get; set; }
        string OxygenEquipmentTypeCode_04 { get; set; }
        string EquipmentReasonDescription_05 { get; set; }
        string OxygenFlowRate_06 { get; set; }
        string DailyOxygenUseCount_07 { get; set; }
        string OxygenUsePeriodHourCount_08 { get; set; }
        string RespiratoryTherapistOrderText_09 { get; set; }
        string ArterialBloodGasQuantity_10 { get; set; }
        string OxygenSaturationQuantity_11 { get; set; }
        string OxygenTestConditionCode_12 { get; set; }
        string OxygenTestFindingsCode_13 { get; set; }
        string OxygenTestFindingsCode_14 { get; set; }
        string OxygenTestFindingsCode_15 { get; set; }
        string PortableOxygenSystemFlowRate_16 { get; set; }
        string OxygenDeliverySystemCode_17 { get; set; }
        string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CR5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CertificationTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string OxygenEquipmentTypeCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string OxygenEquipmentTypeCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string EquipmentReasonDescription_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string OxygenFlowRate_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string DailyOxygenUseCount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string OxygenUsePeriodHourCount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string RespiratoryTherapistOrderText_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ArterialBloodGasQuantity_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string OxygenSaturationQuantity_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string OxygenTestConditionCode_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string OxygenTestFindingsCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string OxygenTestFindingsCode_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string OxygenTestFindingsCode_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string PortableOxygenSystemFlowRate_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string OxygenDeliverySystemCode_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    public interface I_CR6
    {
        
        string PrognosisCode_01 { get; set; }
        string HomeHealthStartDate_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string HomeHealthCertificationPeriod_04 { get; set; }
        string Date_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string MedicareCoverageIndicator_07 { get; set; }
        string CertificationTypeCode_08 { get; set; }
        string SurgeryDate_09 { get; set; }
        string ProductorServiceIDQualifier_10 { get; set; }
        string SurgicalProcedureCode_11 { get; set; }
        string PhysicianOrderDate_12 { get; set; }
        string LastVisitDate_13 { get; set; }
        string PhysicianContactDate_14 { get; set; }
        string DateTimePeriodFormatQualifier_15 { get; set; }
        string LastAdmissionPeriod_16 { get; set; }
        string PatientLocationCode_17 { get; set; }
        string Date_18 { get; set; }
        string Date_19 { get; set; }
        string Date_20 { get; set; }
        string Date_21 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CR6
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PrognosisCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string HomeHealthStartDate_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DateTimePeriodFormatQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string HomeHealthCertificationPeriod_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Date_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string YesNoConditionorResponseCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string MedicareCoverageIndicator_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string CertificationTypeCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string SurgeryDate_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProductorServiceIDQualifier_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string SurgicalProcedureCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string PhysicianOrderDate_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string LastVisitDate_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string PhysicianContactDate_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string DateTimePeriodFormatQualifier_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string LastAdmissionPeriod_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string PatientLocationCode_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string Date_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string Date_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string Date_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string Date_21 { get; set; }
    }
    
    public interface I_CRC
    {
        
        string CodeCategory_01 { get; set; }
        string CertificationConditionIndicator_02 { get; set; }
        string ConditionCode_03 { get; set; }
        string ConditionCode_04 { get; set; }
        string ConditionCode_05 { get; set; }
        string ConditionCode_06 { get; set; }
        string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CRC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CodeCategory_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string CertificationConditionIndicator_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ConditionCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ConditionCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ConditionCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ConditionCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ConditionCode_07 { get; set; }
    }
    
    public interface I_CTP<T1>
        where T1 : I_C001
    {
        
        string ClassofTradeCode_01 { get; set; }
        string PriceIdentifierCode_02 { get; set; }
        string UnitPrice_03 { get; set; }
        string NationalDrugUnitCount_04 { get; set; }
        T1 CompositeUnitOfMeasure_05 { get; set; }
        string PriceMultiplierQualifier_06 { get; set; }
        string Multiplier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string BasisofUnitPriceCode_09 { get; set; }
        string ConditionValue_10 { get; set; }
        string MultiplePriceQuantity_11 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CTP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ClassofTradeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PriceIdentifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string UnitPrice_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string NationalDrugUnitCount_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string PriceMultiplierQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Multiplier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string BasisofUnitPriceCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ConditionValue_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string MultiplePriceQuantity_11 { get; set; }
    }
    
    public interface I_CUR
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string CurrencyCode_02 { get; set; }
        string ExchangeRate_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string CurrencyCode_05 { get; set; }
        string CurrencyMarketExchangeCode_06 { get; set; }
        string DateTimeQualifier_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string Date_11 { get; set; }
        string Time_12 { get; set; }
        string DateTimeQualifier_13 { get; set; }
        string Date_14 { get; set; }
        string Time_15 { get; set; }
        string DateTimeQualifier_16 { get; set; }
        string Date_17 { get; set; }
        string Time_18 { get; set; }
        string DateTimeQualifier_19 { get; set; }
        string Date_20 { get; set; }
        string Time_21 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class CUR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string EntityIdentifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string CurrencyCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ExchangeRate_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string EntityIdentifierCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string CurrencyCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CurrencyMarketExchangeCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string DateTimeQualifier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string Date_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string Time_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string DateTimeQualifier_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string Date_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string Time_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string DateTimeQualifier_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string Date_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string Time_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string DateTimeQualifier_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string Date_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string Time_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string DateTimeQualifier_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string Date_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string Time_21 { get; set; }
    }
    
    public interface I_DMG<T1>
        where T1 : I_C056
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DependentBirthDate_02 { get; set; }
        string DependentGenderCode_03 { get; set; }
        string MaritalStatusCode_04 { get; set; }
        List<T1> CompositeRaceOrEthnicityInformation_05 { get; set; }
        string CitizenshipStatusCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string BasisofVerificationCode_08 { get; set; }
        string Quantity_09 { get; set; }
        string CodeListQualifierCode_10 { get; set; }
        string IndustryCode_11 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DMG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string DateTimePeriodFormatQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string DependentBirthDate_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DependentGenderCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string MaritalStatusCode_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CitizenshipStatusCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string CountryCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string BasisofVerificationCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string Quantity_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string CodeListQualifierCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string IndustryCode_11 { get; set; }
    }
    
    public interface I_DN1
    {
        
        string OrthodonticTreatmentMonthsCount_01 { get; set; }
        string OrthodonticTreatmentMonthsRemainingCount_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string OrthodonticTreatmentIndicator_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DN1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string OrthodonticTreatmentMonthsCount_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string OrthodonticTreatmentMonthsRemainingCount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string YesNoConditionorResponseCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string OrthodonticTreatmentIndicator_04 { get; set; }
    }
    
    public interface I_DN2
    {
        
        string ToothNumber_01 { get; set; }
        string ToothStatusCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string CodeListQualifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DN2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ToothNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ToothStatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string Quantity_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string DateTimePeriodFormatQualifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string DateTimePeriod_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CodeListQualifierCode_06 { get; set; }
    }
    
    public interface I_DSB
    {
        
        string DisabilityTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string OccupationCode_03 { get; set; }
        string WorkIntensityCode_04 { get; set; }
        string ProductOptionCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string ProductorServiceIDQualifier_07 { get; set; }
        string DiagnosisCode_08 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DSB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string DisabilityTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string OccupationCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string WorkIntensityCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ProductOptionCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string MonetaryAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ProductorServiceIDQualifier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string DiagnosisCode_08 { get; set; }
    }
    
    public interface I_DTM
    {
        
        string DateTimeQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DTM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string DateTimeQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Date_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string Time_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TimeCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string DateTimePeriodFormatQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string DateTimePeriod_06 { get; set; }
    }
    
    public interface I_DTP
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class DTP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string DateTimeQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string DateTimePeriodFormatQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DateTimePeriod_03 { get; set; }
    }
    
    public interface I_EB<T1, T2>
        where T1 : I_C003
        where T2 : I_C004
    {
        
        string EligibilityorBenefitInformation_01 { get; set; }
        string BenefitCoverageLevelCode_02 { get; set; }
        List<string> ServiceTypeCode_03 { get; set; }
        string InsuranceTypeCode_04 { get; set; }
        string PlanCoverageDescription_05 { get; set; }
        string TimePeriodQualifier_06 { get; set; }
        string BenefitAmount_07 { get; set; }
        string BenefitPercent_08 { get; set; }
        string QuantityQualifier_09 { get; set; }
        string BenefitQuantity_10 { get; set; }
        string AuthorizationorCertificationIndicator_11 { get; set; }
        string InPlanNetworkIndicator_12 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_13 { get; set; }
        T2 CompositeDiagnosisCodePointer_14 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class EB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string EligibilityorBenefitInformation_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string BenefitCoverageLevelCode_02 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string InsuranceTypeCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PlanCoverageDescription_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string TimePeriodQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string BenefitAmount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string BenefitPercent_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string QuantityQualifier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string BenefitQuantity_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string AuthorizationorCertificationIndicator_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string InPlanNetworkIndicator_12 { get; set; }

        protected List<string> _serviceTypeCode { get; set; }
        public virtual string ServiceTypeCode
        {
            get
            {
                if (_serviceTypeCode != null)
                    return string.Join("^", _serviceTypeCode);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _serviceTypeCode = value.Split('^').ToList();
            }
        }
    }
    
    public interface I_EC
    {
        
        string EmploymentClassCode_01 { get; set; }
        string EmploymentClassCode_02 { get; set; }
        string EmploymentClassCode_03 { get; set; }
        string PercentageasDecimal_04 { get; set; }
        string InformationStatusCode_05 { get; set; }
        string OccupationCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class EC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string EmploymentClassCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string EmploymentClassCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string EmploymentClassCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string PercentageasDecimal_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string InformationStatusCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string OccupationCode_06 { get; set; }
    }
    
    public interface I_ENT
    {
        
        string AssignedNumber_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string ReceiversIndividualIdentifier_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string IdentificationCodeQualifier_06 { get; set; }
        string IdentificationCode_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class ENT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AssignedNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string EntityIdentifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string IdentificationCodeQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ReceiversIndividualIdentifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string EntityIdentifierCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string IdentificationCodeQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string IdentificationCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ReferenceIdentificationQualifier_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_EQ<T1, T2>
        where T1 : I_C003
        where T2 : I_C004
    {
        
        List<string> ServiceTypeCode_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string CoverageLevelCode_03 { get; set; }
        string InsuranceTypeCode_04 { get; set; }
        T2 CompositeDiagnosisCodePointer_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class EQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CoverageLevelCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string InsuranceTypeCode_04 { get; set; }

        protected List<string> _serviceTypeCode { get; set; }
        public virtual string ServiceTypeCode
        {
            get
            {
                if (_serviceTypeCode != null)
                    return string.Join("^", _serviceTypeCode);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _serviceTypeCode = value.Split('^').ToList();
            }
        }
    }
    
    public interface I_FRM
    {
        
        string QuestionNumberLetter_01 { get; set; }
        string QuestionResponse_02 { get; set; }
        string QuestionResponse_03 { get; set; }
        string QuestionResponse_04 { get; set; }
        string QuestionResponse_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class FRM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string QuestionNumberLetter_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string QuestionResponse_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string QuestionResponse_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string QuestionResponse_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string QuestionResponse_05 { get; set; }
    }
    
    public interface I_HCP
    {
        
        string PricingMethodology_01 { get; set; }
        string RepricedAllowedAmount_02 { get; set; }
        string RepricedSavingAmount_03 { get; set; }
        string RepricingOrganizationIdentifier_04 { get; set; }
        string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string ProductServiceIDQualifier_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string RejectReasonCode_13 { get; set; }
        string PolicyComplianceCode_14 { get; set; }
        string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HCP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PricingMethodology_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string RepricedAllowedAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string RepricedSavingAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string RepricingOrganizationIdentifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string MonetaryAmount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ProductServiceID_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ProductServiceIDQualifier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProductServiceID_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string UnitorBasisforMeasurementCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string Quantity_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string RejectReasonCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string PolicyComplianceCode_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string ExceptionCode_15 { get; set; }
    }
    
    public interface I_HCR
    {
        
        string ActionCode_01 { get; set; }
        string ReviewIdentificationNumber_02 { get; set; }
        List<string> ReviewDecisionReasonCode_03 { get; set; }
        string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HCR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ActionCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ReviewIdentificationNumber_02 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string SecondSurgicalOpinionIndicator_04 { get; set; }

        protected List<string> _reviewDecisionReasonCode { get; set; }
        public virtual string ReviewDecisionReasonCode
        {
            get
            {
                if (_reviewDecisionReasonCode != null)
                    return string.Join("^", _reviewDecisionReasonCode);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _reviewDecisionReasonCode = value.Split('^').ToList();
            }
        }
    }
    
    public interface I_HD
    {
        
        string MaintenanceTypeCode_01 { get; set; }
        string MaintenanceReasonCode_02 { get; set; }
        string InsuranceLineCode_03 { get; set; }
        string PlanCoverageDescription_04 { get; set; }
        string CoverageLevelCode_05 { get; set; }
        string Count_06 { get; set; }
        string Count_07 { get; set; }
        string UnderwritingDecisionCode_08 { get; set; }
        string LateEnrollmentIndicator_09 { get; set; }
        string DrugHouseCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string MaintenanceTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MaintenanceReasonCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string InsuranceLineCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string PlanCoverageDescription_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string CoverageLevelCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string Count_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Count_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string UnderwritingDecisionCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string LateEnrollmentIndicator_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string DrugHouseCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    public interface I_HI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        where T1 : I_C022
        where T2 : I_C022
        where T3 : I_C022
        where T4 : I_C022
        where T5 : I_C022
        where T6 : I_C022
        where T7 : I_C022
        where T8 : I_C022
        where T9 : I_C022
        where T10 : I_C022
        where T11 : I_C022
        where T12 : I_C022
    {
        
        T1 HealthCareCodeInformation_01 { get; set; }
        T2 HealthCareCodeInformation_02 { get; set; }
        T3 HealthCareCodeInformation_03 { get; set; }
        T4 HealthCareCodeInformation_04 { get; set; }
        T5 HealthCareCodeInformation_05 { get; set; }
        T6 HealthCareCodeInformation_06 { get; set; }
        T7 HealthCareCodeInformation_07 { get; set; }
        T8 HealthCareCodeInformation_08 { get; set; }
        T9 HealthCareCodeInformation_09 { get; set; }
        T10 HealthCareCodeInformation_10 { get; set; }
        T11 HealthCareCodeInformation_11 { get; set; }
        T12 HealthCareCodeInformation_12 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    public class HI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
    }

    public interface I_HL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HL
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string HierarchicalIDNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string HierarchicalParentIDNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string HierarchicalLevelCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string HierarchicalChildCode_04 { get; set; }
    }
    
    public interface I_HLH
    {
        
        string HealthRelatedCode_01 { get; set; }
        string MemberHeight_02 { get; set; }
        string MemberWeight_03 { get; set; }
        string Weight_04 { get; set; }
        string Description_05 { get; set; }
        string CurrentHealthConditionCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HLH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string HealthRelatedCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MemberHeight_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string MemberWeight_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string Weight_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Description_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CurrentHealthConditionCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Description_07 { get; set; }
    }
    
    public interface I_HSD
    {
        
        string QuantityQualifier_01 { get; set; }
        string BenefitQuantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string SampleSelectionModulus_04 { get; set; }
        string TimePeriodQualifier_05 { get; set; }
        string PeriodCount_06 { get; set; }
        string DeliveryFrequencyCode_07 { get; set; }
        string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class HSD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string QuantityQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string BenefitQuantity_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string UnitorBasisforMeasurementCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string SampleSelectionModulus_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TimePeriodQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string PeriodCount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string DeliveryFrequencyCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public interface I_ICM
    {
        
        string FrequencyCode_01 { get; set; }
        string WageAmount_02 { get; set; }
        string WorkHoursCount_03 { get; set; }
        string LocationIdentificationCode_04 { get; set; }
        string SalaryGradeCode_05 { get; set; }
        string CurrencyCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class ICM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string FrequencyCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string WageAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string WorkHoursCount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string LocationIdentificationCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string SalaryGradeCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CurrencyCode_06 { get; set; }
    }
    
    public interface I_IDC
    {
        
        string PlanCoverageDescription_01 { get; set; }
        string IdentificationCardTypeCode_02 { get; set; }
        string IdentificationCardCount_03 { get; set; }
        string ActionCode_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class IDC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PlanCoverageDescription_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string IdentificationCardTypeCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string IdentificationCardCount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ActionCode_04 { get; set; }
    }
    
    public interface I_III<T1>
        where T1 : I_C001
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string CodeCategory_03 { get; set; }
        string InjuredBodyPartName_04 { get; set; }
        string Quantity_05 { get; set; }
        T1 CompositeUnitOfMeasure_06 { get; set; }
        string SurfaceLayerPositionCode_07 { get; set; }
        string SurfaceLayerPositionCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class III
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CodeListQualifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string IndustryCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CodeCategory_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string InjuredBodyPartName_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Quantity_05 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string SurfaceLayerPositionCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string SurfaceLayerPositionCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public interface I_INS<T1>
        where T1 : I_C052
    {
        
        string InsuredIndicator_01 { get; set; }
        string IndividualRelationshipCode_02 { get; set; }
        string MaintenanceTypeCode_03 { get; set; }
        string MaintenanceReasonCode_04 { get; set; }
        string BenefitStatusCode_05 { get; set; }
        T1 MedicareStatusCode_06 { get; set; }
        string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        string EmploymentStatusCode_08 { get; set; }
        string StudentStatusCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string DateTimePeriodFormatQualifier_11 { get; set; }
        string DateTimePeriod_12 { get; set; }
        string ConfidentialityCode_13 { get; set; }
        string CityName_14 { get; set; }
        string StateorProvinceCode_15 { get; set; }
        string CountryCode_16 { get; set; }
        string BirthSequenceNumber_17 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class INS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string InsuredIndicator_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string IndividualRelationshipCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string MaintenanceTypeCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string MaintenanceReasonCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string BenefitStatusCode_05 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string EmploymentStatusCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string StudentStatusCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string YesNoConditionorResponseCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string DateTimePeriodFormatQualifier_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string DateTimePeriod_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ConfidentialityCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string CityName_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string StateorProvinceCode_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string CountryCode_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string BirthSequenceNumber_17 { get; set; }
    }
    
    public interface I_IT1
    {
        
        string LineItemControlNumber_01 { get; set; }
        string QuantityInvoiced_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string UnitPrice_04 { get; set; }
        string BasisofUnitPriceCode_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class IT1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string LineItemControlNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string QuantityInvoiced_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string UnitorBasisforMeasurementCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string UnitPrice_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string BasisofUnitPriceCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProductServiceIDQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ProductServiceID_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ProductServiceIDQualifier_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ProductServiceID_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProductServiceIDQualifier_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string ProductServiceID_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string ProductServiceIDQualifier_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ProductServiceID_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string ProductServiceIDQualifier_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string ProductServiceID_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string ProductServiceIDQualifier_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ProductServiceID_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string ProductServiceIDQualifier_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string ProductServiceID_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string ProductServiceIDQualifier_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string ProductServiceID_21 { get; set; }
        [DataMember]
        [Pos(22)]
        public virtual string ProductServiceIDQualifier_22 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual string ProductServiceID_23 { get; set; }
        [DataMember]
        [Pos(24)]
        public virtual string ProductServiceIDQualifier_24 { get; set; }
        [DataMember]
        [Pos(25)]
        public virtual string ProductServiceID_25 { get; set; }
    }
    
    public interface I_K3<T1>
        where T1 : I_C001
    {
        
        string FixedFormatInformation_01 { get; set; }
        string RecordFormatCode_02 { get; set; }
        T1 CompositeUnitOfMeasure_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class K3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string FixedFormatInformation_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string RecordFormatCode_02 { get; set; }
    }
    
    public interface I_LE
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LIN
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductorServiceIDQualifier_02 { get; set; }
        string NationalDrugCode_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
        string ProductServiceIDQualifier_26 { get; set; }
        string ProductServiceID_27 { get; set; }
        string ProductServiceIDQualifier_28 { get; set; }
        string ProductServiceID_29 { get; set; }
        string ProductServiceIDQualifier_30 { get; set; }
        string ProductServiceID_31 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AssignedIdentification_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ProductorServiceIDQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string NationalDrugCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ProductServiceIDQualifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ProductServiceID_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProductServiceIDQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ProductServiceID_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ProductServiceIDQualifier_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ProductServiceID_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProductServiceIDQualifier_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string ProductServiceID_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string ProductServiceIDQualifier_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ProductServiceID_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string ProductServiceIDQualifier_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string ProductServiceID_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string ProductServiceIDQualifier_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ProductServiceID_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string ProductServiceIDQualifier_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string ProductServiceID_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string ProductServiceIDQualifier_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string ProductServiceID_21 { get; set; }
        [DataMember]
        [Pos(22)]
        public virtual string ProductServiceIDQualifier_22 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual string ProductServiceID_23 { get; set; }
        [DataMember]
        [Pos(24)]
        public virtual string ProductServiceIDQualifier_24 { get; set; }
        [DataMember]
        [Pos(25)]
        public virtual string ProductServiceID_25 { get; set; }
        [DataMember]
        [Pos(26)]
        public virtual string ProductServiceIDQualifier_26 { get; set; }
        [DataMember]
        [Pos(27)]
        public virtual string ProductServiceID_27 { get; set; }
        [DataMember]
        [Pos(28)]
        public virtual string ProductServiceIDQualifier_28 { get; set; }
        [DataMember]
        [Pos(29)]
        public virtual string ProductServiceID_29 { get; set; }
        [DataMember]
        [Pos(30)]
        public virtual string ProductServiceIDQualifier_30 { get; set; }
        [DataMember]
        [Pos(31)]
        public virtual string ProductServiceID_31 { get; set; }
    }
    
    public interface I_LQ
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string FormIdentifier_02 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CodeListQualifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string FormIdentifier_02 { get; set; }
    }
    
    public interface I_LS
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LUI
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string LanguageCode_02 { get; set; }
        string LanguageDescription_03 { get; set; }
        string LanguageUseIndicator_04 { get; set; }
        string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LUI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string IdentificationCodeQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string LanguageCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string LanguageDescription_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string LanguageUseIndicator_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    public interface I_LX
    {
        
        string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class LX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AssignedNumber_01 { get; set; }
    }
    
    public interface I_MEA<T1>
        where T1 : I_C001
    {
        
        string MeasurementReferenceIdentificationCode_01 { get; set; }
        string MeasurementQualifier_02 { get; set; }
        string TestResults_03 { get; set; }
        T1 CompositeUnitOfMeasure_04 { get; set; }
        string RangeMinimum_05 { get; set; }
        string RangeMaximum_06 { get; set; }
        string MeasurementSignificanceCode_07 { get; set; }
        string MeasurementAttributeCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
        string MeasurementMethodorDevice_10 { get; set; }
        string CodeListQualifierCode_11 { get; set; }
        string IndustryCode_12 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class MEA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string MeasurementReferenceIdentificationCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MeasurementQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string TestResults_03 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string RangeMinimum_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string RangeMaximum_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string MeasurementSignificanceCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MeasurementAttributeCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string SurfaceLayerPositionCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string MeasurementMethodorDevice_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string CodeListQualifierCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string IndustryCode_12 { get; set; }
    }
    
    public interface I_MIA
    {
        
        string CoveredDaysorVisitsCount_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string LifetimePsychiatricDaysCount_03 { get; set; }
        string ClaimDRGAmount_04 { get; set; }
        string ClaimPaymentRemarkCode_05 { get; set; }
        string ClaimDisproportionateShareAmount_06 { get; set; }
        string ClaimMSPPassthroughAmount_07 { get; set; }
        string ClaimPPSCapitalAmount_08 { get; set; }
        string PPSCapitalFSPDRGAmount_09 { get; set; }
        string PPSCapitalHSPDRGAmount_10 { get; set; }
        string PPSCapitalDSHDRGAmount_11 { get; set; }
        string OldCapitalAmount_12 { get; set; }
        string PPSCapitalIMEamount_13 { get; set; }
        string PPSOperatingHospitalSpecificDRGAmount_14 { get; set; }
        string CostReportDayCount_15 { get; set; }
        string PPSOperatingFederalSpecificDRGAmount_16 { get; set; }
        string ClaimPPSCapitalOutlierAmount_17 { get; set; }
        string ClaimIndirectTeachingAmount_18 { get; set; }
        string NonpayableProfessionalComponentAmount_19 { get; set; }
        string ClaimPaymentRemarkCode_20 { get; set; }
        string ClaimPaymentRemarkCode_21 { get; set; }
        string ClaimPaymentRemarkCode_22 { get; set; }
        string ClaimPaymentRemarkCode_23 { get; set; }
        string PPSCapitalExceptionAmount_24 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class MIA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CoveredDaysorVisitsCount_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string LifetimePsychiatricDaysCount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ClaimDRGAmount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ClaimPaymentRemarkCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ClaimDisproportionateShareAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ClaimMSPPassthroughAmount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ClaimPPSCapitalAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string PPSCapitalFSPDRGAmount_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string PPSCapitalHSPDRGAmount_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string PPSCapitalDSHDRGAmount_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string OldCapitalAmount_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string PPSCapitalIMEamount_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string PPSOperatingHospitalSpecificDRGAmount_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string CostReportDayCount_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string PPSOperatingFederalSpecificDRGAmount_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ClaimPPSCapitalOutlierAmount_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string ClaimIndirectTeachingAmount_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string NonpayableProfessionalComponentAmount_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string ClaimPaymentRemarkCode_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string ClaimPaymentRemarkCode_21 { get; set; }
        [DataMember]
        [Pos(22)]
        public virtual string ClaimPaymentRemarkCode_22 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual string ClaimPaymentRemarkCode_23 { get; set; }
        [DataMember]
        [Pos(24)]
        public virtual string PPSCapitalExceptionAmount_24 { get; set; }
    }
    
    public interface I_MOA
    {
        
        string ReimbursementRate_01 { get; set; }
        string HCPCSPayableAmount_02 { get; set; }
        string ClaimPaymentRemarkCode_03 { get; set; }
        string ClaimPaymentRemarkCode_04 { get; set; }
        string ClaimPaymentRemarkCode_05 { get; set; }
        string ClaimPaymentRemarkCode_06 { get; set; }
        string ClaimPaymentRemarkCode_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class MOA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ReimbursementRate_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string HCPCSPayableAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ClaimPaymentRemarkCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ClaimPaymentRemarkCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ClaimPaymentRemarkCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ClaimPaymentRemarkCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ClaimPaymentRemarkCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public interface I_MPI
    {
        
        string InformationStatusCode_01 { get; set; }
        string EmploymentStatusCode_02 { get; set; }
        string GovernmentServiceAffiliationCode_03 { get; set; }
        string Description_04 { get; set; }
        string MilitaryServiceRankCode_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class MPI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string InformationStatusCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string EmploymentStatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string GovernmentServiceAffiliationCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string Description_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string MilitaryServiceRankCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string DateTimePeriodFormatQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string DateTimePeriod_07 { get; set; }
    }
    
    public interface I_MSG
    {
        
        string FreeFormMessageText_01 { get; set; }
        string PrinterCarriageControlCode_02 { get; set; }
        string Number_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class MSG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string FreeFormMessageText_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PrinterCarriageControlCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string Number_03 { get; set; }
    }
    
    public interface I_N1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string PremiumPayerName_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IntermediaryBankIdentifier_04 { get; set; }
        string EntityRelationshipCode_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class N1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string EntityIdentifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PremiumPayerName_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string IdentificationCodeQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string IntermediaryBankIdentifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string EntityRelationshipCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string EntityIdentifierCode_06 { get; set; }
    }
    
    public interface I_N2
    {
        
        string IntermediaryBankAdditionalName_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class N2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string IntermediaryBankAdditionalName_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Name_02 { get; set; }
    }
    
    public interface I_N3
    {
        
        string ResponseContactAddressLine_01 { get; set; }
        string ResponseContactAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class N3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ResponseContactAddressLine_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ResponseContactAddressLine_02 { get; set; }
    }
    
    public interface I_N4
    {
        
        string AdditionalPatientInformationContactCityName_01 { get; set; }
        string AdditionalPatientInformationContactStateCode_02 { get; set; }
        string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class N4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AdditionalPatientInformationContactCityName_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AdditionalPatientInformationContactStateCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string CountryCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string LocationQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string LocationIdentifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string CountrySubdivisionCode_07 { get; set; }
    }
    
    public interface I_NM1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string EntityTypeQualifier_02 { get; set; }
        string ResponseContactLastorOrganizationName_03 { get; set; }
        string ResponseContactFirstName_04 { get; set; }
        string ResponseContactMiddleName_05 { get; set; }
        string NamePrefix_06 { get; set; }
        string ResponseContactNameSuffix_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string ResponseContactIdentifier_09 { get; set; }
        string EntityRelationshipCode_10 { get; set; }
        string EntityIdentifierCode_11 { get; set; }
        string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class NM1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string EntityIdentifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string EntityTypeQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ResponseContactLastorOrganizationName_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ResponseContactFirstName_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ResponseContactMiddleName_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string NamePrefix_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string ResponseContactNameSuffix_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string IdentificationCodeQualifier_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ResponseContactIdentifier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string EntityRelationshipCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string EntityIdentifierCode_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string NameLastorOrganizationName_12 { get; set; }
    }
    
    public interface I_NTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string BillingNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class NTE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string NoteReferenceCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string BillingNoteText_02 { get; set; }
    }
    
    public interface I_OI
    {
        
        string ClaimFilingIndicatorCode_01 { get; set; }
        string ClaimSubmissionReasonCode_02 { get; set; }
        string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        string PatientSignatureSourceCode_04 { get; set; }
        string ProviderAgreementCode_05 { get; set; }
        string ReleaseofInformationCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class OI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ClaimFilingIndicatorCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ClaimSubmissionReasonCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string PatientSignatureSourceCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ProviderAgreementCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ReleaseofInformationCode_06 { get; set; }
    }
    
    public interface I_PAT
    {
        
        string IndividualRelationshipCode_01 { get; set; }
        string PatientLocationCode_02 { get; set; }
        string EmploymentStatusCode_03 { get; set; }
        string StudentStatusCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string PatientDeathDate_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string PatientWeight_08 { get; set; }
        string PregnancyIndicator_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string IndividualRelationshipCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PatientLocationCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string EmploymentStatusCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string StudentStatusCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string DateTimePeriodFormatQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string PatientDeathDate_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string UnitorBasisforMeasurementCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string PatientWeight_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string PregnancyIndicator_09 { get; set; }
    }
    
    public interface I_PER
    {
        
        string ContactFunctionCode_01 { get; set; }
        string ResponseContactName_02 { get; set; }
        string CommunicationNumberQualifier_03 { get; set; }
        string ResponseContactCommunicationNumber_04 { get; set; }
        string CommunicationNumberQualifier_05 { get; set; }
        string ResponseContactCommunicationNumber_06 { get; set; }
        string CommunicationNumberQualifier_07 { get; set; }
        string ResponseContactCommunicationNumber_08 { get; set; }
        string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PER
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ContactFunctionCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ResponseContactName_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string CommunicationNumberQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ResponseContactCommunicationNumber_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string CommunicationNumberQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ResponseContactCommunicationNumber_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string CommunicationNumberQualifier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ResponseContactCommunicationNumber_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ContactInquiryReference_09 { get; set; }
    }
    
    public interface I_PLA
    {
        
        string ActionCode_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string ProviderEffectiveDate_03 { get; set; }
        string Time_04 { get; set; }
        string MaintenanceReasonCode_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PLA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ActionCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string EntityIdentifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ProviderEffectiveDate_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string Time_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string MaintenanceReasonCode_05 { get; set; }
    }
    
    public interface I_PLB<T1, T2, T3, T4, T5, T6>
        where T1 : I_C042
        where T2 : I_C042
        where T3 : I_C042
        where T4 : I_C042
        where T5 : I_C042
        where T6 : I_C042
    {
        
        string ProviderIdentifier_01 { get; set; }
        string FiscalPeriodDate_02 { get; set; }
        T1 AdjustmentIdentifier_03 { get; set; }
        string ProviderAdjustmentAmount_04 { get; set; }
        T2 AdjustmentIdentifier_05 { get; set; }
        string ProviderAdjustmentAmount_06 { get; set; }
        T3 AdjustmentIdentifier_07 { get; set; }
        string ProviderAdjustmentAmount_08 { get; set; }
        T4 AdjustmentIdentifier_09 { get; set; }
        string ProviderAdjustmentAmount_10 { get; set; }
        T5 AdjustmentIdentifier_11 { get; set; }
        string ProviderAdjustmentAmount_12 { get; set; }
        T6 AdjustmentIdentifier_13 { get; set; }
        string ProviderAdjustmentAmount_14 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PLB
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ProviderIdentifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string FiscalPeriodDate_02 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ProviderAdjustmentAmount_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProviderAdjustmentAmount_06 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ProviderAdjustmentAmount_08 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProviderAdjustmentAmount_10 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string ProviderAdjustmentAmount_12 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string ProviderAdjustmentAmount_14 { get; set; }
    }
    
    public interface I_PRV<T1>
        where T1 : I_C035
    {
        
        string ProviderCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ProviderTaxonomyCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        T1 ProviderSpecialtyInformation_05 { get; set; }
        string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PRV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ProviderCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ReferenceIdentificationQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ProviderTaxonomyCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string StateorProvinceCode_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProviderOrganizationCode_06 { get; set; }
    }
    
    public interface I_PS1
    {
        
        string PurchasedServiceProviderIdentifier_01 { get; set; }
        string PurchasedServiceChargeAmount_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PS1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PurchasedServiceProviderIdentifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PurchasedServiceChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string StateorProvinceCode_03 { get; set; }
    }
    
    public interface I_PWK<T1>
        where T1 : I_C002
    {
        
        string AttachmentReportTypeCode_01 { get; set; }
        string ReportTransmissionCode_02 { get; set; }
        string ReportCopiesNeeded_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string AttachmentControlNumber_06 { get; set; }
        string AttachmentDescription_07 { get; set; }
        T1 ActionsIndicated_08 { get; set; }
        string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class PWK
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AttachmentReportTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ReportTransmissionCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ReportCopiesNeeded_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string EntityIdentifierCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string IdentificationCodeQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string AttachmentControlNumber_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string AttachmentDescription_07 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string RequestCategoryCode_09 { get; set; }
    }
    
    public interface I_QTY<T1>
        where T1 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        string AmbulancePatientCount_02 { get; set; }
        T1 CompositeUnitOfMeasure_03 { get; set; }
        string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class QTY
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string QuantityQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AmbulancePatientCount_02 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string FreeformInformation_04 { get; set; }
    }
    
    public interface I_RDM<T1, T2>
        where T1 : I_C040
        where T2 : I_C040
    {
        
        string RemittanceDeliveryMethodCode_01 { get; set; }
        string PremiumReceiversLastorOrganizationName_02 { get; set; }
        string PremiumReceiversCommunicationNumber_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
        T2 ReferenceIdentifier_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class RDM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string RemittanceDeliveryMethodCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PremiumReceiversLastorOrganizationName_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string PremiumReceiversCommunicationNumber_03 { get; set; }
    }
    
    public interface I_REF<T1>
        where T1 : I_C040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string MemberGrouporPolicyNumber_02 { get; set; }
        string Description_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class REF
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ReferenceIdentificationQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string MemberGrouporPolicyNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string Description_03 { get; set; }
    }
    
    public interface I_RMR
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string InsuranceRemittanceReferenceNumber_02 { get; set; }
        string PaymentActionCode_03 { get; set; }
        string DetailPremiumPaymentAmount_04 { get; set; }
        string BilledPremiumAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string AdjustmentReasonCode_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class RMR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ReferenceIdentificationQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string InsuranceRemittanceReferenceNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string PaymentActionCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string DetailPremiumPaymentAmount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string BilledPremiumAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string MonetaryAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string AdjustmentReasonCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
    }
    
    public interface I_SAC
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        string Amount_05 { get; set; }
        string AllowanceChargePercentQualifier_06 { get; set; }
        string PercentDecimalFormat_07 { get; set; }
        string Rate_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string Quantity_11 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        string ReferenceIdentification_13 { get; set; }
        string OptionNumber_14 { get; set; }
        string Description_15 { get; set; }
        string LanguageCode_16 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SAC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string AllowanceorChargeIndicator_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string AgencyQualifierCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Amount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string AllowanceChargePercentQualifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string PercentDecimalFormat_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string Rate_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string UnitorBasisforMeasurementCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string Quantity_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string Quantity_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ReferenceIdentification_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string OptionNumber_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string Description_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string LanguageCode_16 { get; set; }
    }
    
    public interface I_SBR
    {
        
        string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        string IndividualRelationshipCode_02 { get; set; }
        string InsuredGrouporPolicyNumber_03 { get; set; }
        string OtherInsuredGroupName_04 { get; set; }
        string InsuranceTypeCode_05 { get; set; }
        string CoordinationofBenefitsCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string EmploymentStatusCode_08 { get; set; }
        string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SBR
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string IndividualRelationshipCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string InsuredGrouporPolicyNumber_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string OtherInsuredGroupName_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string InsuranceTypeCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string CoordinationofBenefitsCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string YesNoConditionorResponseCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string EmploymentStatusCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public interface I_SLN<T1>
        where T1 : I_C001
    {
        
        string LineItemControlNumber_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string InformationOnlyIndicator_03 { get; set; }
        string HeadCount_04 { get; set; }
        T1 CompositeUnitOfMeasure_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string BasisofUnitPriceCode_07 { get; set; }
        string RelationshipCode_08 { get; set; }
        string ProductServiceIDQualifier_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string ProductServiceIDQualifier_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string ProductServiceIDQualifier_13 { get; set; }
        string ProductServiceID_14 { get; set; }
        string ProductServiceIDQualifier_15 { get; set; }
        string ProductServiceID_16 { get; set; }
        string ProductServiceIDQualifier_17 { get; set; }
        string ProductServiceID_18 { get; set; }
        string ProductServiceIDQualifier_19 { get; set; }
        string ProductServiceID_20 { get; set; }
        string ProductServiceIDQualifier_21 { get; set; }
        string ProductServiceID_22 { get; set; }
        string ProductServiceIDQualifier_23 { get; set; }
        string ProductServiceID_24 { get; set; }
        string ProductServiceIDQualifier_25 { get; set; }
        string ProductServiceID_26 { get; set; }
        string ProductServiceIDQualifier_27 { get; set; }
        string ProductServiceID_28 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SLN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string LineItemControlNumber_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AssignedIdentification_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string InformationOnlyIndicator_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string HeadCount_04 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string UnitPrice_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string BasisofUnitPriceCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string RelationshipCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ProductServiceIDQualifier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string ProductServiceID_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string ProductServiceIDQualifier_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string ProductServiceID_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ProductServiceIDQualifier_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string ProductServiceID_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string ProductServiceIDQualifier_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string ProductServiceID_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ProductServiceIDQualifier_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string ProductServiceID_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string ProductServiceIDQualifier_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string ProductServiceID_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string ProductServiceIDQualifier_21 { get; set; }
        [DataMember]
        [Pos(22)]
        public virtual string ProductServiceID_22 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual string ProductServiceIDQualifier_23 { get; set; }
        [DataMember]
        [Pos(24)]
        public virtual string ProductServiceID_24 { get; set; }
        [DataMember]
        [Pos(25)]
        public virtual string ProductServiceIDQualifier_25 { get; set; }
        [DataMember]
        [Pos(26)]
        public virtual string ProductServiceID_26 { get; set; }
        [DataMember]
        [Pos(27)]
        public virtual string ProductServiceIDQualifier_27 { get; set; }
        [DataMember]
        [Pos(28)]
        public virtual string ProductServiceID_28 { get; set; }
    }
    
    public interface I_STC<T1, T2, T3>
        where T1 : I_C043
        where T2 : I_C043
        where T3 : I_C043
    {
        
        T1 HealthCareClaimStatus_01 { get; set; }
        string Date_02 { get; set; }
        string ActionCode_03 { get; set; }
        string TotalSubmittedChargesForUnitWork_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Date_06 { get; set; }
        string PaymentMethodCode_07 { get; set; }
        string Date_08 { get; set; }
        string CheckNumber_09 { get; set; }
        T2 HealthCareClaimStatus_10 { get; set; }
        T3 HealthCareClaimStatus_11 { get; set; }
        string FreeformMessageText_12 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class STC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Date_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ActionCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TotalSubmittedChargesForUnitWork_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string MonetaryAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string Date_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string PaymentMethodCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string Date_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string CheckNumber_09 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string FreeformMessageText_12 { get; set; }
    }
    
    public interface I_SV1<T1, T2>
        where T1 : I_C003
        where T2 : I_C004
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string LineItemChargeAmount_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string ServiceUnitCount_04 { get; set; }
        string PlaceofServiceCode_05 { get; set; }
        string ServiceTypeCode_06 { get; set; }
        T2 CompositeDiagnosisCodePointer_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string EmergencyIndicator_09 { get; set; }
        string MultipleProcedureCode_10 { get; set; }
        string EPSDTIndicator_11 { get; set; }
        string FamilyPlanningIndicator_12 { get; set; }
        string ReviewCode_13 { get; set; }
        string NationalorLocalAssignedReviewValue_14 { get; set; }
        string CoPayStatusCode_15 { get; set; }
        string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        string ReferenceIdentification_17 { get; set; }
        string PostalCode_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
        string LevelofCareCode_20 { get; set; }
        string ProviderAgreementCode_21 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SV1
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string LineItemChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string UnitorBasisforMeasurementCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ServiceUnitCount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PlaceofServiceCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ServiceTypeCode_06 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string EmergencyIndicator_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string MultipleProcedureCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string EPSDTIndicator_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string FamilyPlanningIndicator_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string ReviewCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string NationalorLocalAssignedReviewValue_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string CoPayStatusCode_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string ReferenceIdentification_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string PostalCode_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string MonetaryAmount_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string LevelofCareCode_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string ProviderAgreementCode_21 { get; set; }
    }
    
    public interface I_SV2<T1>
        where T1 : I_C003
    {
        
        string ServiceLineRevenueCode_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string LineItemChargeAmount_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string ServiceUnitCount_05 { get; set; }
        string UnitRate_06 { get; set; }
        string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string NursingHomeResidentialStatusCode_09 { get; set; }
        string LevelofCareCode_10 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SV2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ServiceLineRevenueCode_01 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string LineItemChargeAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string UnitorBasisforMeasurementCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ServiceUnitCount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string UnitRate_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string YesNoConditionorResponseCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string NursingHomeResidentialStatusCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string LevelofCareCode_10 { get; set; }
    }
    
    public interface I_SV3<T1, T2, T3>
        where T1 : I_C003
        where T2 : I_C006
        where T3 : I_C004
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string LineItemChargeAmount_02 { get; set; }
        string PlaceofServiceCode_03 { get; set; }
        T2 OralCavityDesignation_04 { get; set; }
        string ProsthesisCrownorInlayCode_05 { get; set; }
        string ProcedureCount_06 { get; set; }
        string Description_07 { get; set; }
        string CopayStatusCode_08 { get; set; }
        string ProviderAgreementCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        T3 CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SV3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string LineItemChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string PlaceofServiceCode_03 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ProsthesisCrownorInlayCode_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProcedureCount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Description_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string CopayStatusCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ProviderAgreementCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string YesNoConditionorResponseCode_10 { get; set; }
    }
    
    public interface I_SV5<T1>
        where T1 : I_C003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string LengthofMedicalNecessity_03 { get; set; }
        string DMERentalPrice_04 { get; set; }
        string DMEPurchasePrice_05 { get; set; }
        string RentalUnitPriceIndicator_06 { get; set; }
        string PrognosisCode_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SV5
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string UnitorBasisforMeasurementCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string LengthofMedicalNecessity_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string DMERentalPrice_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string DMEPurchasePrice_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string RentalUnitPriceIndicator_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string PrognosisCode_07 { get; set; }
    }
    
    public interface I_SVC<T1, T2>
        where T1 : I_C003
        where T2 : I_C003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string LineItemChargeAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string RevenueCode_04 { get; set; }
        string Quantity_05 { get; set; }
        T2 CompositeMedicalProcedureIdentifier_06 { get; set; }
        string UnitsofServiceCount_07 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SVC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string LineItemChargeAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string MonetaryAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string RevenueCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Quantity_05 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string UnitsofServiceCount_07 { get; set; }
    }
    
    public interface I_SVD<T1>
        where T1 : I_C003
    {
        
        string OtherPayerPrimaryIdentifier_01 { get; set; }
        string ServiceLinePaidAmount_02 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string PaidServiceUnitCount_05 { get; set; }
        string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class SVD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string OtherPayerPrimaryIdentifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ServiceLinePaidAmount_02 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ProductServiceID_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PaidServiceUnitCount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public interface I_TOO<T1>
        where T1 : I_C005
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string ToothCode_02 { get; set; }
        T1 ToothSurface_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class TOO
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CodeListQualifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ToothCode_02 { get; set; }
    }
    
    public interface I_TRN
    {
        
        string TraceTypeCode_01 { get; set; }
        string CurrentTransactionTraceNumber_02 { get; set; }
        string OriginatingCompanyIdentifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class TRN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string TraceTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string CurrentTransactionTraceNumber_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string OriginatingCompanyIdentifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_TS2
    {
        
        string TotalDRGAmount_01 { get; set; }
        string TotalFederalSpecificAmount_02 { get; set; }
        string TotalHospitalSpecificAmount_03 { get; set; }
        string TotalDisproportionateShareAmount_04 { get; set; }
        string TotalCapitalAmount_05 { get; set; }
        string TotalIndirectMedicalEducationAmount_06 { get; set; }
        string TotalOutlierDayCount_07 { get; set; }
        string TotalDayOutlierAmount_08 { get; set; }
        string TotalCostOutlierAmount_09 { get; set; }
        string AverageDRGLengthofStay_10 { get; set; }
        string TotalDischargeCount_11 { get; set; }
        string TotalCostReportDayCount_12 { get; set; }
        string TotalCoveredDayCount_13 { get; set; }
        string TotalNoncoveredDayCount_14 { get; set; }
        string TotalMSPPassThroughAmount_15 { get; set; }
        string AverageDRGweight_16 { get; set; }
        string TotalPPSCapitalFSPDRGAmount_17 { get; set; }
        string TotalPPSCapitalHSPDRGAmount_18 { get; set; }
        string TotalPPSDSHDRGAmount_19 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class TS2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string TotalDRGAmount_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string TotalFederalSpecificAmount_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string TotalHospitalSpecificAmount_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TotalDisproportionateShareAmount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TotalCapitalAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string TotalIndirectMedicalEducationAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string TotalOutlierDayCount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string TotalDayOutlierAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string TotalCostOutlierAmount_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string AverageDRGLengthofStay_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string TotalDischargeCount_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string TotalCostReportDayCount_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string TotalCoveredDayCount_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string TotalNoncoveredDayCount_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string TotalMSPPassThroughAmount_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string AverageDRGweight_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string TotalPPSCapitalFSPDRGAmount_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string TotalPPSCapitalHSPDRGAmount_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string TotalPPSDSHDRGAmount_19 { get; set; }
    }
    
    public interface I_TS3
    {
        
        string ProviderIdentifier_01 { get; set; }
        string FacilityTypeCode_02 { get; set; }
        string FiscalPeriodDate_03 { get; set; }
        string TotalClaimCount_04 { get; set; }
        string TotalClaimChargeAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string MonetaryAmount_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string TotalMSPPayerAmount_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string TotalNonLabChargeAmount_15 { get; set; }
        string MonetaryAmount_16 { get; set; }
        string TotalHCPCSReportedChargeAmount_17 { get; set; }
        string TotalHCPCSPayableAmount_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
        string TotalProfessionalComponentAmount_20 { get; set; }
        string TotalMSPPatientLiabilityMetAmount_21 { get; set; }
        string TotalPatientReimbursementAmount_22 { get; set; }
        string TotalPIPClaimCount_23 { get; set; }
        string TotalPIPAdjustmentAmount_24 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class TS3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ProviderIdentifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string FacilityTypeCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string FiscalPeriodDate_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string TotalClaimCount_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string TotalClaimChargeAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string MonetaryAmount_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string MonetaryAmount_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string MonetaryAmount_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string MonetaryAmount_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string MonetaryAmount_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string MonetaryAmount_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string TotalMSPPayerAmount_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string MonetaryAmount_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string TotalNonLabChargeAmount_15 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual string MonetaryAmount_16 { get; set; }
        [DataMember]
        [Pos(17)]
        public virtual string TotalHCPCSReportedChargeAmount_17 { get; set; }
        [DataMember]
        [Pos(18)]
        public virtual string TotalHCPCSPayableAmount_18 { get; set; }
        [DataMember]
        [Pos(19)]
        public virtual string MonetaryAmount_19 { get; set; }
        [DataMember]
        [Pos(20)]
        public virtual string TotalProfessionalComponentAmount_20 { get; set; }
        [DataMember]
        [Pos(21)]
        public virtual string TotalMSPPatientLiabilityMetAmount_21 { get; set; }
        [DataMember]
        [Pos(22)]
        public virtual string TotalPatientReimbursementAmount_22 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual string TotalPIPClaimCount_23 { get; set; }
        [DataMember]
        [Pos(24)]
        public virtual string TotalPIPAdjustmentAmount_24 { get; set; }
    }
    
    public interface I_UM<T1, T2>
        where T1 : I_C023
        where T2 : I_C024
    {
        
        string RequestCategoryCode_01 { get; set; }
        string CertificationTypeCode_02 { get; set; }
        string ServiceTypeCode_03 { get; set; }
        T1 ValuesEntered_04 { get; set; }
        T2 RelatedCausesInformation_05 { get; set; }
        string LevelofServiceCode_06 { get; set; }
        string CurrentHealthConditionCode_07 { get; set; }
        string PrognosisCode_08 { get; set; }
        string ReleaseofInformationCode_09 { get; set; }
        string DelayReasonCode_10 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class UM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string RequestCategoryCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string CertificationTypeCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ServiceTypeCode_03 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string LevelofServiceCode_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string CurrentHealthConditionCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string PrognosisCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string ReleaseofInformationCode_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string DelayReasonCode_10 { get; set; }
    }
}
