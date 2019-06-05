namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    
    public interface IAAA
    {
        
        string ValidRequestIndicator_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string RejectReasonCode_03 { get; set; }
        string FollowupActionCode_04 { get; set; }
    }
    
    public interface IACT
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
    
    public interface IADX
    {
        
        string AdjustmentAmount_01 { get; set; }
        string AdjustmentReasonCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface IAMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string TotalClaimChargeAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
    }
    
    public interface IBGN
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
    
    public interface IBHT
    {
        
        string HierarchicalStructureCode_01 { get; set; }
        string TransactionSetPurposeCode_02 { get; set; }
        string SubmitterTransactionIdentifier_03 { get; set; }
        string TransactionSetCreationDate_04 { get; set; }
        string TransactionSetCreationTime_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
    }
    
    public interface IBPR
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
    
    public interface ICAS
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
    
    public interface ICL1
    {
        
        string AdmissionTypeCode_01 { get; set; }
        string AdmissionSourceCode_02 { get; set; }
        string PatientStatusCode_03 { get; set; }
        string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    public interface ICLM<T1, T2>
        where T1 : IC023
        where T2 : IC024
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
    
    public interface ICLP
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
    
    public interface ICN1
    {
        
        string ContractTypeCode_01 { get; set; }
        string ContractAmount_02 { get; set; }
        string ContractPercentage_03 { get; set; }
        string ContractCode_04 { get; set; }
        string TermsDiscountPercentage_05 { get; set; }
        string ContractVersionIdentifier_06 { get; set; }
    }
    
    public interface ICOB
    {
        
        string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        string MemberGrouporPolicyNumber_02 { get; set; }
        string CoordinationofBenefitsCode_03 { get; set; }
        List<string> ServiceTypeCode_04 { get; set; }
    }
    
    public interface ICR1
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
    
    public interface ICR2
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
    
    public interface ICR3
    {
        
        string CertificationTypeCode_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string DurableMedicalEquipmentDuration_03 { get; set; }
        string InsulinDependentCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface ICR5
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
    
    public interface ICR6
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
    
    public interface ICRC
    {
        
        string CodeCategory_01 { get; set; }
        string CertificationConditionIndicator_02 { get; set; }
        string ConditionCode_03 { get; set; }
        string ConditionCode_04 { get; set; }
        string ConditionCode_05 { get; set; }
        string ConditionCode_06 { get; set; }
        string ConditionCode_07 { get; set; }
    }
    
    public interface ICTP<T1>
        where T1 : IC001
    {
        
        string ClassofTradeCode_01 { get; set; }
        string PriceIdentifierCode_02 { get; set; }
        string UnitPrice_03 { get; set; }
        string NationalDrugUnitCount_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string PriceMultiplierQualifier_06 { get; set; }
        string Multiplier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string BasisofUnitPriceCode_09 { get; set; }
        string ConditionValue_10 { get; set; }
        string MultiplePriceQuantity_11 { get; set; }
    }
    
    public interface ICUR
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
    
    public interface IDMG<T1>
        where T1 : IC056
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DependentBirthDate_02 { get; set; }
        string DependentGenderCode_03 { get; set; }
        string MaritalStatusCode_04 { get; set; }
        List<T1> CompositeRaceorEthnicityInformation_05 { get; set; }
        string CitizenshipStatusCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string BasisofVerificationCode_08 { get; set; }
        string Quantity_09 { get; set; }
        string CodeListQualifierCode_10 { get; set; }
        string IndustryCode_11 { get; set; }
    }
    
    public interface IDN1
    {
        
        string OrthodonticTreatmentMonthsCount_01 { get; set; }
        string OrthodonticTreatmentMonthsRemainingCount_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string OrthodonticTreatmentIndicator_04 { get; set; }
    }
    
    public interface IDN2
    {
        
        string ToothNumber_01 { get; set; }
        string ToothStatusCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string CodeListQualifierCode_06 { get; set; }
    }
    
    public interface IDSB
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
    
    public interface IDTM
    {
        
        string DateTimeQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
    }
    
    public interface IDTP
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string AccidentDate_03 { get; set; }
    }
    
    public interface IEB<T1, T2>
        where T1 : IC003
        where T2 : IC004
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
    
    public interface IEC
    {
        
        string EmploymentClassCode_01 { get; set; }
        string EmploymentClassCode_02 { get; set; }
        string EmploymentClassCode_03 { get; set; }
        string PercentageasDecimal_04 { get; set; }
        string InformationStatusCode_05 { get; set; }
        string OccupationCode_06 { get; set; }
    }
    
    public interface IENT
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
    
    public interface IEQ<T1, T2>
        where T1 : IC003
        where T2 : IC004
    {
        
        List<string> ServiceTypeCode_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string CoverageLevelCode_03 { get; set; }
        string InsuranceTypeCode_04 { get; set; }
        T2 CompositeDiagnosisCodePointer_05 { get; set; }
    }
    
    public interface IFRM
    {
        
        string QuestionNumberLetter_01 { get; set; }
        string QuestionResponse_02 { get; set; }
        string QuestionResponse_03 { get; set; }
        string QuestionResponse_04 { get; set; }
        string QuestionResponse_05 { get; set; }
    }
    
    public interface IHCP
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
    
    public interface IHCR
    {
        
        string ActionCode_01 { get; set; }
        string ReviewIdentificationNumber_02 { get; set; }
        List<string> ReviewDecisionReasonCode_03 { get; set; }
        string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    public interface IHD
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
    
    public interface IHI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        where T1 : IC022
        where T2 : IC022
        where T3 : IC022
        where T4 : IC022
        where T5 : IC022
        where T6 : IC022
        where T7 : IC022
        where T8 : IC022
        where T9 : IC022
        where T10 : IC022
        where T11 : IC022
        where T12 : IC022
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
    
    public interface IHL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
    }
    
    public interface IHLH
    {
        
        string HealthRelatedCode_01 { get; set; }
        string MemberHeight_02 { get; set; }
        string MemberWeight_03 { get; set; }
        string Weight_04 { get; set; }
        string Description_05 { get; set; }
        string CurrentHealthConditionCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface IHSD
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
    
    public interface IICM
    {
        
        string FrequencyCode_01 { get; set; }
        string WageAmount_02 { get; set; }
        string WorkHoursCount_03 { get; set; }
        string LocationIdentificationCode_04 { get; set; }
        string SalaryGradeCode_05 { get; set; }
        string CurrencyCode_06 { get; set; }
    }
    
    public interface IIDC
    {
        
        string PlanCoverageDescription_01 { get; set; }
        string IdentificationCardTypeCode_02 { get; set; }
        string IdentificationCardCount_03 { get; set; }
        string ActionCode_04 { get; set; }
    }
    
    public interface IIII<T1>
        where T1 : IC001
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string CodeCategory_03 { get; set; }
        string InjuredBodyPartName_04 { get; set; }
        string Quantity_05 { get; set; }
        T1 CompositeUnitofMeasure_06 { get; set; }
        string SurfaceLayerPositionCode_07 { get; set; }
        string SurfaceLayerPositionCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public interface IINS<T1>
        where T1 : IC052
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
    
    public interface IIT1
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
    
    public interface IK3<T1>
        where T1 : IC001
    {
        
        string FixedFormatInformation_01 { get; set; }
        string RecordFormatCode_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public interface ILE
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface ILIN
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
    
    public interface ILQ
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string FormIdentifier_02 { get; set; }
    }
    
    public interface ILS
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface ILUI
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string LanguageCode_02 { get; set; }
        string LanguageDescription_03 { get; set; }
        string LanguageUseIndicator_04 { get; set; }
        string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    public interface ILX
    {
        
        string AssignedNumber_01 { get; set; }
    }
    
    public interface IMEA<T1>
        where T1 : IC001
    {
        
        string MeasurementReferenceIdentificationCode_01 { get; set; }
        string MeasurementQualifier_02 { get; set; }
        string TestResults_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string RangeMinimum_05 { get; set; }
        string RangeMaximum_06 { get; set; }
        string MeasurementSignificanceCode_07 { get; set; }
        string MeasurementAttributeCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
        string MeasurementMethodorDevice_10 { get; set; }
        string CodeListQualifierCode_11 { get; set; }
        string IndustryCode_12 { get; set; }
    }
    
    public interface IMIA
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
    
    public interface IMOA
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
    
    public interface IMPI
    {
        
        string InformationStatusCode_01 { get; set; }
        string EmploymentStatusCode_02 { get; set; }
        string GovernmentServiceAffiliationCode_03 { get; set; }
        string Description_04 { get; set; }
        string MilitaryServiceRankCode_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
    }
    
    public interface IMSG
    {
        
        string FreeFormMessageText_01 { get; set; }
        string PrinterCarriageControlCode_02 { get; set; }
        string Number_03 { get; set; }
    }
    
    public interface IN1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string PremiumPayerName_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IntermediaryBankIdentifier_04 { get; set; }
        string EntityRelationshipCode_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
    }
    
    public interface IN2
    {
        
        string IntermediaryBankAdditionalName_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    public interface IN3
    {
        
        string ResponseContactAddressLine_01 { get; set; }
        string ResponseContactAddressLine_02 { get; set; }
    }
    
    public interface IN4
    {
        
        string AdditionalPatientInformationContactCityName_01 { get; set; }
        string AdditionalPatientInformationContactStateCode_02 { get; set; }
        string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string CountrySubdivisionCode_07 { get; set; }
    }
    
    public interface INM1
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
    
    public interface INTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string BillingNoteText_02 { get; set; }
    }
    
    public interface IOI
    {
        
        string ClaimFilingIndicatorCode_01 { get; set; }
        string ClaimSubmissionReasonCode_02 { get; set; }
        string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        string PatientSignatureSourceCode_04 { get; set; }
        string ProviderAgreementCode_05 { get; set; }
        string ReleaseofInformationCode_06 { get; set; }
    }
    
    public interface IPAT
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
    
    public interface IPER
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
    
    public interface IPLA
    {
        
        string ActionCode_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string ProviderEffectiveDate_03 { get; set; }
        string Time_04 { get; set; }
        string MaintenanceReasonCode_05 { get; set; }
    }
    
    public interface IPLB<T1, T2, T3, T4, T5, T6>
        where T1 : IC042
        where T2 : IC042
        where T3 : IC042
        where T4 : IC042
        where T5 : IC042
        where T6 : IC042
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
    
    public interface IPRV<T1>
        where T1 : IC035
    {
        
        string ProviderCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ProviderTaxonomyCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        T1 ProviderSpecialtyInformation_05 { get; set; }
        string ProviderOrganizationCode_06 { get; set; }
    }
    
    public interface IPS1
    {
        
        string PurchasedServiceProviderIdentifier_01 { get; set; }
        string PurchasedServiceChargeAmount_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
    }
    
    public interface IPWK<T1>
        where T1 : IC002
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
    
    public interface IQTY<T1>
        where T1 : IC001
    {
        
        string QuantityQualifier_01 { get; set; }
        string AmbulancePatientCount_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string FreeformInformation_04 { get; set; }
    }
    
    public interface IRDM<T1, T2>
        where T1 : IC040
        where T2 : IC040
    {
        
        string RemittanceDeliveryMethodCode_01 { get; set; }
        string PremiumReceiversLastorOrganizationName_02 { get; set; }
        string PremiumReceiversCommunicationNumber_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
        T2 ReferenceIdentifier_05 { get; set; }
    }
    
    public interface IREF<T1>
        where T1 : IC040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string MemberGrouporPolicyNumber_02 { get; set; }
        string Description_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
    }
    
    public interface IRMR
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
    
    public interface ISAC
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
    
    public interface ISBR
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
    
    public interface ISLN<T1>
        where T1 : IC001
    {
        
        string LineItemControlNumber_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string InformationOnlyIndicator_03 { get; set; }
        string HeadCount_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
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
    
    public interface ISTC<T1, T2, T3>
        where T1 : IC043
        where T2 : IC043
        where T3 : IC043
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
    
    public interface ISV1<T1, T2>
        where T1 : IC003
        where T2 : IC004
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
    
    public interface ISV2<T1>
        where T1 : IC003
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
    
    public interface ISV3<T1, T2, T3>
        where T1 : IC003
        where T2 : IC006
        where T3 : IC004
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
    
    public interface ISV5<T1>
        where T1 : IC003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string LengthofMedicalNecessity_03 { get; set; }
        string DMERentalPrice_04 { get; set; }
        string DMEPurchasePrice_05 { get; set; }
        string RentalUnitPriceIndicator_06 { get; set; }
        string PrognosisCode_07 { get; set; }
    }
    
    public interface ISVC<T1, T2>
        where T1 : IC003
        where T2 : IC003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string LineItemChargeAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string RevenueCode_04 { get; set; }
        string Quantity_05 { get; set; }
        T2 CompositeMedicalProcedureIdentifier_06 { get; set; }
        string UnitsofServiceCount_07 { get; set; }
    }
    
    public interface ISVD<T1>
        where T1 : IC003
    {
        
        string OtherPayerPrimaryIdentifier_01 { get; set; }
        string ServiceLinePaidAmount_02 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string PaidServiceUnitCount_05 { get; set; }
        string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public interface ITOO<T1>
        where T1 : IC005
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string ToothCode_02 { get; set; }
        T1 ToothSurface_03 { get; set; }
    }
    
    public interface ITRN
    {
        
        string TraceTypeCode_01 { get; set; }
        string CurrentTransactionTraceNumber_02 { get; set; }
        string OriginatingCompanyIdentifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface ITS2
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
    
    public interface ITS3
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
    
    public interface IUM<T1, T2>
        where T1 : IC023
        where T2 : IC024
    {
        
        string RequestCategoryCode_01 { get; set; }
        string CertificationTypeCode_02 { get; set; }
        string ServiceTypeCode_03 { get; set; }
        T1 ValuesenteredattheServiceLeveloverridesthevalueatthePatientEventLevelforthisservice_04 { get; set; }
        T2 RelatedCausesInformation_05 { get; set; }
        string LevelofServiceCode_06 { get; set; }
        string CurrentHealthConditionCode_07 { get; set; }
        string PrognosisCode_08 { get; set; }
        string ReleaseofInformationCode_09 { get; set; }
        string DelayReasonCode_10 { get; set; }
    }
}
