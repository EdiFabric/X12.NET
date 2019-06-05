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
    
    
    public interface IAMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string TotalClaimChargeAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
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
    
    public interface IDTP
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string AccidentDate_03 { get; set; }
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
    
    public interface INTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string BillingNoteText_02 { get; set; }
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
    
    public interface IREF<T1>
        where T1 : IC040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string MemberGrouporPolicyNumber_02 { get; set; }
        string Description_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
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
    
    public interface IHL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
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
        string SpecialProgramCode_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
        string LevelofServiceCode_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
        string ProviderAgreementCode_16 { get; set; }
        string ClaimStatusCode_17 { get; set; }
        string YesNoConditionorResponseCode_18 { get; set; }
        string ClaimSubmissionReasonCode_19 { get; set; }
        string DelayReasonCode_20 { get; set; }
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
    
    public interface IK3<T1>
        where T1 : IC001
    {
        
        string FixedFormatInformation_01 { get; set; }
        string RecordFormatCode_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
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
    
    public interface IOI
    {
        
        string ClaimFilingIndicatorCode_01 { get; set; }
        string ClaimSubmissionReasonCode_02 { get; set; }
        string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        string PatientSignatureSourceCode_04 { get; set; }
        string ProviderAgreementCode_05 { get; set; }
        string ReleaseofInformationCode_06 { get; set; }
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
    
    public interface ILX
    {
        
        string AssignedNumber_01 { get; set; }
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
    
    public interface ICR3
    {
        
        string CertificationTypeCode_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string DurableMedicalEquipmentDuration_03 { get; set; }
        string InsulinDependentCode_04 { get; set; }
        string Description_05 { get; set; }
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
    
    public interface IPS1
    {
        
        string PurchasedServiceProviderIdentifier_01 { get; set; }
        string PurchasedServiceChargeAmount_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
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
    
    public interface ILQ
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string FormIdentifier_02 { get; set; }
    }
    
    public interface IFRM
    {
        
        string QuestionNumberLetter_01 { get; set; }
        string QuestionResponse_02 { get; set; }
        string QuestionResponse_03 { get; set; }
        string QuestionResponse_04 { get; set; }
        string QuestionResponse_05 { get; set; }
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
}
