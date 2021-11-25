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
