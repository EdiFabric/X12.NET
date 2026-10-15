namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    public interface I_AAA
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string RejectReasonCode_03 { get; set; }
        string FollowupActionCode_04 { get; set; }
    }
    
    public interface I_ACD
    {
        
        string AccountRelationshipCode_01 { get; set; }
        string RatingRemarksCode_02 { get; set; }
        string LoanTypeCode_03 { get; set; }
    }
    
    public interface I_ACK
    {
        
        string LineItemStatusCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string RequestReferenceNumber_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
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
        string AgencyQualifierCode_27 { get; set; }
        string SourceSubqualifier_28 { get; set; }
        string IndustryCode_29 { get; set; }
    }
    
    public interface I_ACS
    {
        
        string Amount_01 { get; set; }
        string SpecialChargeorAllowanceCode_02 { get; set; }
        string Description_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
    }
    
    public interface I_ACT
    {
        
        string AccountNumber_01 { get; set; }
        string Name_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string AccountNumberQualifier_05 { get; set; }
        string AccountNumber_06 { get; set; }
        string Description_07 { get; set; }
        string PaymentMethodCode_08 { get; set; }
        string BenefitStatusCode_09 { get; set; }
    }
    
    public interface I_AD1
    {
        
        string AdjustmentReasonCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string AdjustmentReasonCodeCharacteristic_03 { get; set; }
        string FrequencyCode_04 { get; set; }
        string LateReasonCode_05 { get; set; }
    }
    
    public interface I_ADI
    {
        
        string AnimalDispositionCode_01 { get; set; }
        string Date_02 { get; set; }
        string TestPeriodorIntervalValue_03 { get; set; }
        string UnitofTimePeriodorInterval_04 { get; set; }
    }
    
    public interface I_ADJ
    {
        
        string AdjustmentApplicationCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string Number_06 { get; set; }
        string Description_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string Amount_10 { get; set; }
        string Amount_11 { get; set; }
        string Amount_12 { get; set; }
        string Quantity_13 { get; set; }
        string Quantity_14 { get; set; }
        string Quantity_15 { get; set; }
        string ReferenceIdentificationQualifier_16 { get; set; }
        string ReferenceIdentification_17 { get; set; }
    }
    
    public interface I_ADT
    {
        
        string ParturitionStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string TestPeriodorIntervalValue_03 { get; set; }
        string UnitofTimePeriodorInterval_04 { get; set; }
        string Date_05 { get; set; }
        string TestPeriodorIntervalValue_06 { get; set; }
        string UnitofTimePeriodorInterval_07 { get; set; }
        string Time_08 { get; set; }
        string TestPeriodorIntervalValue_09 { get; set; }
        string UnitofTimePeriodorInterval_10 { get; set; }
    }
    
    public interface I_ADV
    {
        
        string AgencyQualifierCode_01 { get; set; }
        string ServiceCharacteristicsQualifier_02 { get; set; }
        string RangeMinimum_03 { get; set; }
        string RangeMaximum_04 { get; set; }
        string Category_05 { get; set; }
        string ServiceCharacteristicsQualifier_06 { get; set; }
        string MeasurementValue_07 { get; set; }
    }
    
    public interface I_ADX
    {
        
        string MonetaryAmount_01 { get; set; }
        string AdjustmentReasonCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_AEI
    {
        
        string EquipmentDescriptionCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public interface I_AES
    {
        
        string AutomaticEquipmentIdentificationSiteStatusCode_01 { get; set; }
        string MovementTypeCode_02 { get; set; }
        string TrainTerminationStatusCode_03 { get; set; }
        string AutomaticEquipmentIdentificationConsistConfidenceLevelCode_04 { get; set; }
        string IndustryCode_05 { get; set; }
    }
    
    public interface I_AIN
    {
        
        string TypeofIncomeCode_01 { get; set; }
        string FrequencyCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Quantity_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string AmountQualifierCode_07 { get; set; }
        string TaxTreatmentCode_08 { get; set; }
        string EarningsRateofPay_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Quantity_11 { get; set; }
        string IndustryCode_12 { get; set; }
    }
    
    public interface I_AK1
    {
        
        string FunctionalIdentifierCode_01 { get; set; }
        string GroupControlNumber_02 { get; set; }
    }
    
    public interface I_AK2
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string TransactionSetControlNumber_02 { get; set; }
    }
    
    public interface I_AK3
    {
        
        string SegmentIDCode_01 { get; set; }
        string SegmentPositioninTransactionSet_02 { get; set; }
        string LoopIdentifierCode_03 { get; set; }
        string SegmentSyntaxErrorCode_04 { get; set; }
    }
    
    public interface I_AK4<T1>
        where T1 : I_C030
    {
        
        T1 PositioninSegment_01 { get; set; }
        string DataElementReferenceNumber_02 { get; set; }
        string DataElementSyntaxErrorCode_03 { get; set; }
        string CopyofBadDataElement_04 { get; set; }
    }
    
    public interface I_AK5
    {
        
        string TransactionSetAcknowledgmentCode_01 { get; set; }
        string TransactionSetSyntaxErrorCode_02 { get; set; }
        string TransactionSetSyntaxErrorCode_03 { get; set; }
        string TransactionSetSyntaxErrorCode_04 { get; set; }
        string TransactionSetSyntaxErrorCode_05 { get; set; }
        string TransactionSetSyntaxErrorCode_06 { get; set; }
    }
    
    public interface I_AK9
    {
        
        string FunctionalGroupAcknowledgeCode_01 { get; set; }
        string NumberofTransactionSetsIncluded_02 { get; set; }
        string NumberofReceivedTransactionSets_03 { get; set; }
        string NumberofAcceptedTransactionSets_04 { get; set; }
        string FunctionalGroupSyntaxErrorCode_05 { get; set; }
        string FunctionalGroupSyntaxErrorCode_06 { get; set; }
        string FunctionalGroupSyntaxErrorCode_07 { get; set; }
        string FunctionalGroupSyntaxErrorCode_08 { get; set; }
        string FunctionalGroupSyntaxErrorCode_09 { get; set; }
    }
    
    public interface I_AM1
    {
        
        string CodeCategory_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string Quantity_05 { get; set; }
        string Percent_06 { get; set; }
    }
    
    public interface I_AMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
    }
    
    public interface I_ANI
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string TestPeriodorIntervalValue_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string Date_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_AOC
    {
        
        string OffspringCountCode_01 { get; set; }
        string Count_02 { get; set; }
        string Date_03 { get; set; }
        string TestPeriodorIntervalValue_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
    }
    
    public interface I_AOI
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string GenderCode_03 { get; set; }
        string OffspringFetusStatusCode_04 { get; set; }
        string TestPeriodorIntervalValue_05 { get; set; }
        string UnitofTimePeriodorInterval_06 { get; set; }
        string AnimalDispositionCode_07 { get; set; }
        string TestPeriodorIntervalValue_08 { get; set; }
        string UnitofTimePeriodorInterval_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
        string Date_11 { get; set; }
        string TestPeriodorIntervalValue_12 { get; set; }
        string UnitofTimePeriodorInterval_13 { get; set; }
    }
    
    public interface I_AOL
    {
        
        string ObservationTypeCode_01 { get; set; }
        string Description_02 { get; set; }
        string TissueorSpecimenDispositionCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string SubLocation_05 { get; set; }
        string SubLocation_06 { get; set; }
        string SubLocation_07 { get; set; }
        string SurfaceLayerPositionCode_08 { get; set; }
    }
    
    public interface I_AOR
    {
        
        string ObservationDistribution_01 { get; set; }
        string ObservationSeverity_02 { get; set; }
        string NeoplasmCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string LinkageIdentifier_05 { get; set; }
        string LinkageIdentifier_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string TestPeriodorIntervalValue_08 { get; set; }
        string UnitofTimePeriodorInterval_09 { get; set; }
        string TestPeriodorIntervalValue_10 { get; set; }
        string UnitofTimePeriodorInterval_11 { get; set; }
        string TestPeriodorIntervalValue_12 { get; set; }
        string UnitofTimePeriodorInterval_13 { get; set; }
    }
    
    public interface I_AP1
    {
        
        string ConditionIndicator_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PriceIdentifierCode_03 { get; set; }
        string Percent_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string PostalCode_06 { get; set; }
        string PostalCode_07 { get; set; }
        string PrintOptionCode_08 { get; set; }
        string Number_09 { get; set; }
        string Quantity_10 { get; set; }
        string FreeFormMessage_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string Description_13 { get; set; }
    }
    
    public interface I_API
    {
        
        string CodeCategory_01 { get; set; }
        string ActionCode_02 { get; set; }
        string MaintenanceTypeCode_03 { get; set; }
        string StatusReasonCode_04 { get; set; }
        string AffectedAreaorSectionCode_05 { get; set; }
        string InsuranceTypeCode_06 { get; set; }
        string LoanTypeCode_07 { get; set; }
        string InformationStatusCode_08 { get; set; }
    }
    
    public interface I_APR
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string AssociationofAmericanRailroadsAARPoolCode_02 { get; set; }
        string AssociationofAmericanRailroadsAARPoolCode_03 { get; set; }
    }
    
    public interface I_ARC
    {
        
        string Count_01 { get; set; }
        string TestTypeCode_02 { get; set; }
        string ObservationTypeCode_03 { get; set; }
    }
    
    public interface I_ARS
    {
        
        string TypeofResidenceCode_01 { get; set; }
        string PropertyOwnershipRightsCode_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
    }
    
    public interface I_ASI
    {
        
        string ActionCode_01 { get; set; }
        string MaintenanceTypeCode_02 { get; set; }
        string StatusReasonCode_03 { get; set; }
    }
    
    public interface I_ASL
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string AssetLiabilityTypeCode_03 { get; set; }
        string FrequencyCode_04 { get; set; }
    }
    
    public interface I_ASM
    {
        
        string Amount_01 { get; set; }
        string PaymentMethodCode_02 { get; set; }
        string AmountQualifierCode_03 { get; set; }
    }
    
    public interface I_ASO<T1>
        where T1 : I_C007
    {
        
        string PropertyOwnershipRightsCode_01 { get; set; }
        string TypeofPersonalorBusinessAssetCode_02 { get; set; }
        string TypeofPersonalorBusinessAssetCode_03 { get; set; }
        string FreeFormMessageText_04 { get; set; }
        string GeneralPropertyOwnershipCode_05 { get; set; }
        T1 AmountQualifyingDescription_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string Percent_08 { get; set; }
        string Quantity_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
    }
    
    public interface I_AST
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string TestPeriodorIntervalValue_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
        string Date_06 { get; set; }
        string TestPeriodorIntervalValue_07 { get; set; }
        string UnitofTimePeriodorInterval_08 { get; set; }
        string Date_09 { get; set; }
        string TestPeriodorIntervalValue_10 { get; set; }
        string UnitofTimePeriodorInterval_11 { get; set; }
    }
    
    public interface I_AT1
    {
        
        string LadingLineItemNumber_01 { get; set; }
    }
    
    public interface I_AT2
    {
        
        string LadingQuantity_01 { get; set; }
        string PackagingFormCode_02 { get; set; }
        string WeightQualifier_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string Weight_05 { get; set; }
        string LadingQuantity_06 { get; set; }
        string PackagingFormCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string CommodityCode_09 { get; set; }
        string FreightClassCode_10 { get; set; }
    }
    
    public interface I_AT3
    {
        
        string Charge_01 { get; set; }
        string FreightRateQualifier_02 { get; set; }
        string FreightRate_03 { get; set; }
        string RatedasQualifier_04 { get; set; }
        string Quantity_05 { get; set; }
        string BillofLadingChargeCode_06 { get; set; }
        string Percent_07 { get; set; }
    }
    
    public interface I_AT4
    {
        
        string LadingDescription_01 { get; set; }
    }
    
    public interface I_AT5
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialServicesCode_02 { get; set; }
        string SpecialHandlingDescription_03 { get; set; }
    }
    
    public interface I_AT6
    {
        
        string InternationalDutiableStatusCode_01 { get; set; }
        string ImportExportCode_02 { get; set; }
        string TransportationTermsCode_03 { get; set; }
    }
    
    public interface I_AT7
    {
        
        string ShipmentStatusCode_01 { get; set; }
        string ShipmentStatusorAppointmentReasonCode_02 { get; set; }
        string ShipmentAppointmentStatusCode_03 { get; set; }
        string ShipmentStatusorAppointmentReasonCode_04 { get; set; }
        string Date_05 { get; set; }
        string Time_06 { get; set; }
        string TimeCode_07 { get; set; }
    }
    
    public interface I_AT8
    {
        
        string WeightQualifier_01 { get; set; }
        string WeightUnitCode_02 { get; set; }
        string Weight_03 { get; set; }
        string LadingQuantity_04 { get; set; }
        string LadingQuantity_05 { get; set; }
        string VolumeUnitQualifier_06 { get; set; }
        string Volume_07 { get; set; }
    }
    
    public interface I_AT9
    {
        
        string EquipmentLength_01 { get; set; }
        string Height_02 { get; set; }
        string Width_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string Weight_06 { get; set; }
        string VolumeUnitQualifier_07 { get; set; }
        string Volume_08 { get; set; }
    }
    
    public interface I_ATA
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
    }
    
    public interface I_ATH
    {
        
        string ResourceAuthorizationCode_01 { get; set; }
        string Date_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
        string Date_05 { get; set; }
    }
    
    public interface I_ATN
    {
        
        string Quantity_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string FrequencyCode_04 { get; set; }
        string AttendanceTypeCode_05 { get; set; }
        string Description_06 { get; set; }
    }
    
    public interface I_ATR<T1>
        where T1 : I_C001
    {
        
        string TestTypeCode_01 { get; set; }
        string TestPeriodorIntervalValue_02 { get; set; }
        string UnitofTimePeriodorInterval_03 { get; set; }
        string MeasurementValue_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string NonNumericTestValue_06 { get; set; }
        string Description_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
        string Time_10 { get; set; }
    }
    
    public interface I_ATV<T1>
        where T1 : I_C001
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string EntityTitle_03 { get; set; }
        string EntityTitle_04 { get; set; }
        string Quantity_05 { get; set; }
        T1 CompositeUnitofMeasure_06 { get; set; }
        string LevelofIndividualTestorCourseCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
    }
    
    public interface I_AVA
    {
        
        string MonetaryAmount_01 { get; set; }
        string Availability_02 { get; set; }
    }
    
    public interface I_AWD<T1>
        where T1 : I_C007
    {
        
        T1 AmountQualifyingDescription_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string FreeFormMessage_03 { get; set; }
        string CurrencyCode_04 { get; set; }
    }
    
    public interface I_AXL
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string MeasurementUnitQualifier_03 { get; set; }
        string Length_04 { get; set; }
        string Width_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string Weight_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_B1
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ReservationActionCode_04 { get; set; }
    }
    
    public interface I_B10
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string InquiryRequestNumber_04 { get; set; }
        string ReferenceIdentificationQualifier_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_B11
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string Date_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Quantity_05 { get; set; }
        string AmountQualifierCode_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string ItemDescriptionType_08 { get; set; }
        string Description_09 { get; set; }
        string ServiceLevelCode_10 { get; set; }
        string ReportTransmissionCode_11 { get; set; }
    }
    
    public interface I_B12
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string EquipmentType_03 { get; set; }
    }
    
    public interface I_B13
    {
        
        string ReferenceIdentification_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
    }
    
    public interface I_B2
    {
        
        string TariffServiceCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string StandardPointLocationCode_03 { get; set; }
        string ShipmentIdentificationNumber_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string ShipmentMethodofPayment_06 { get; set; }
        string ShipmentQualifier_07 { get; set; }
        string TotalEquipment_08 { get; set; }
        string ShipmentWeightCode_09 { get; set; }
        string CustomsDocumentationHandlingCode_10 { get; set; }
        string TransportationTermsCode_11 { get; set; }
        string PaymentMethodCode_12 { get; set; }
    }
    
    public interface I_B2A
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ApplicationType_02 { get; set; }
    }
    
    public interface I_B3
    {
        
        string ShipmentQualifier_01 { get; set; }
        string InvoiceNumber_02 { get; set; }
        string ShipmentIdentificationNumber_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string Date_06 { get; set; }
        string NetAmountDue_07 { get; set; }
        string CorrectionIndicator_08 { get; set; }
        string DeliveryDate_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string StandardCarrierAlphaCode_11 { get; set; }
        string Date_12 { get; set; }
        string TariffServiceCode_13 { get; set; }
        string TransportationTermsCode_14 { get; set; }
    }
    
    public interface I_B3A
    {
        
        string TransactionTypeCode_01 { get; set; }
        string NumberofShipments_02 { get; set; }
    }
    
    public interface I_B3B
    {
        
        string InvoiceNumber_01 { get; set; }
        string ShipmentMethodofPayment_02 { get; set; }
        string Date_03 { get; set; }
        string NetAmountDue_04 { get; set; }
        string Date_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string TransportationMethodTypeCode_07 { get; set; }
        string ShipmentIdentificationNumber_08 { get; set; }
        string WeightUnitCode_09 { get; set; }
        string CorrectionIndicator_10 { get; set; }
        string CurrencyCode_11 { get; set; }
    }
    
    public interface I_B4
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string InquiryRequestNumber_02 { get; set; }
        string ShipmentStatusCode_03 { get; set; }
        string Date_04 { get; set; }
        string StatusTime_05 { get; set; }
        string StatusLocation_06 { get; set; }
        string EquipmentInitial_07 { get; set; }
        string EquipmentNumber_08 { get; set; }
        string EquipmentStatusCode_09 { get; set; }
        string EquipmentType_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string LocationQualifier_12 { get; set; }
        string EquipmentNumberCheckDigit_13 { get; set; }
    }
    
    public interface I_B9
    {
        
        string ReferenceIdentification_01 { get; set; }
        string TransactionSetPurposeCode_02 { get; set; }
        string ShipmentMethodofPayment_03 { get; set; }
    }
    
    public interface I_B9A
    {
        
        string ServiceRequestCode_01 { get; set; }
    }
    
    public interface I_BA1
    {
        
        string RelatedCompanyIndicationCode_01 { get; set; }
        string ActionCode_02 { get; set; }
        string TransportationMethodTypeCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string PostalCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
        string Authority_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string VesselName_12 { get; set; }
    }
    
    public interface I_BA2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string VesselCode_02 { get; set; }
        string FlightVoyageNumber_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string PierNumber_06 { get; set; }
        string PierName_07 { get; set; }
        string PortorTerminalFunctionCode_08 { get; set; }
        string PortName_09 { get; set; }
        string Date_10 { get; set; }
        string VesselCodeQualifier_11 { get; set; }
    }
    
    public interface I_BAA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string Date_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string Time_06 { get; set; }
    }
    
    public interface I_BAK
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string AcknowledgmentType_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string Date_04 { get; set; }
        string ReleaseNumber_05 { get; set; }
        string RequestReferenceNumber_06 { get; set; }
        string ContractNumber_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Date_09 { get; set; }
        string TransactionTypeCode_10 { get; set; }
    }
    
    public interface I_BAL
    {
        
        string BalanceTypeCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
    }
    
    public interface I_BAT
    {
        
        string Date_01 { get; set; }
        string Time_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string BatchTypeCode_04 { get; set; }
    }
    
    public interface I_BAU
    {
        
        string ReferenceIdentification_01 { get; set; }
        string PaymentMethodCode_02 { get; set; }
        string DFIIDNumberQualifier_03 { get; set; }
        string DFIIdentificationNumber_04 { get; set; }
        string AccountNumber_05 { get; set; }
        string Name_06 { get; set; }
    }
    
    public interface I_BAX
    {
        
        string StandardPointLocationCode_01 { get; set; }
        string TypeofConsistCode_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string InterchangeTrainIdentification_06 { get; set; }
        string StandardPointLocationCode_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string DirectionIdentifierCode_09 { get; set; }
        string Date_10 { get; set; }
        string Time_11 { get; set; }
        string TimeCode_12 { get; set; }
        string TransactionSetPurposeCode_13 { get; set; }
        string ServiceLevelCode_14 { get; set; }
    }
    
    public interface I_BBC
    {
        
        string ClaimTypeCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_BC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
        string ActionCode_07 { get; set; }
    }
    
    public interface I_BCA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string AcknowledgmentType_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string ChangeOrderSequenceNumber_05 { get; set; }
        string Date_06 { get; set; }
        string RequestReferenceNumber_07 { get; set; }
        string ContractNumber_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string Date_10 { get; set; }
        string Date_11 { get; set; }
        string Date_12 { get; set; }
        string PurchaseOrderTypeCode_13 { get; set; }
        string SecurityLevelCode_14 { get; set; }
        string TransactionTypeCode_15 { get; set; }
    }
    
    public interface I_BCD
    {
        
        string Date_01 { get; set; }
        string CreditDebitAdjustmentNumber_02 { get; set; }
        string TransactionHandlingCode_03 { get; set; }
        string Amount_04 { get; set; }
        string CreditDebitFlagCode_05 { get; set; }
        string Date_06 { get; set; }
        string InvoiceNumber_07 { get; set; }
        string VendorOrderNumber_08 { get; set; }
        string Date_09 { get; set; }
        string PurchaseOrderNumber_10 { get; set; }
        string TransactionSetPurposeCode_11 { get; set; }
        string TransactionTypeCode_12 { get; set; }
        string ReferenceIdentificationQualifier_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
        string ActionCode_15 { get; set; }
    }
    
    public interface I_BCH
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string PurchaseOrderTypeCode_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string ChangeOrderSequenceNumber_05 { get; set; }
        string Date_06 { get; set; }
        string RequestReferenceNumber_07 { get; set; }
        string ContractNumber_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string Date_10 { get; set; }
        string Date_11 { get; set; }
        string ContractTypeCode_12 { get; set; }
        string SecurityLevelCode_13 { get; set; }
        string AcknowledgmentType_14 { get; set; }
        string TransactionTypeCode_15 { get; set; }
        string PurchaseCategory_16 { get; set; }
    }
    
    public interface I_BCI
    {
        
        string IndustryCode_01 { get; set; }
        string InsuranceTypeCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string ReportTypeCode_07 { get; set; }
        string CurrencyCode_08 { get; set; }
    }
    
    public interface I_BCM
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string ContractNumber_04 { get; set; }
        string FreeformDescription_05 { get; set; }
        string ContractActionCode_06 { get; set; }
        string ProgramTypeCode_07 { get; set; }
        string FreeformDescription_08 { get; set; }
        string ContractingFundingCode_09 { get; set; }
        string ContractTypeCode_10 { get; set; }
        string SecurityLevelCode_11 { get; set; }
        string CurrencyCode_12 { get; set; }
    }
    
    public interface I_BCO
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string RequestforQuoteReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ContractStatusCode_05 { get; set; }
        string Date_06 { get; set; }
        string Date_07 { get; set; }
        string AcknowledgmentType_08 { get; set; }
        string ReferenceIdentificationQualifier_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
        string TransactionTypeCode_11 { get; set; }
        string ActionCode_12 { get; set; }
    }
    
    public interface I_BCP
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string ContractActionCode_05 { get; set; }
        string ContractTypeCode_06 { get; set; }
        string Date_07 { get; set; }
        string Time_08 { get; set; }
        string ChangeOrderSequenceNumber_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
        string Description_12 { get; set; }
        string Description_13 { get; set; }
    }
    
    public interface I_BCQ
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
    }
    
    public interface I_BCS<T1>
        where T1 : I_C001
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string ContractNumber_03 { get; set; }
        string Date_04 { get; set; }
        string ContractTypeCode_05 { get; set; }
        string Description_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string ProgramTypeCode_08 { get; set; }
        string SecurityLevelCode_09 { get; set; }
        string Percent_10 { get; set; }
        string Percent_11 { get; set; }
        T1 CompositeUnitofMeasure_12 { get; set; }
    }
    
    public interface I_BCT
    {
        
        string CatalogPurposeCode_01 { get; set; }
        string CatalogNumber_02 { get; set; }
        string CatalogVersionNumber_03 { get; set; }
        string CatalogRevisionNumber_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string CatalogNumber_06 { get; set; }
        string CatalogVersionNumber_07 { get; set; }
        string CatalogRevisionNumber_08 { get; set; }
        string Description_09 { get; set; }
        string TransactionSetPurposeCode_10 { get; set; }
    }
    
    public interface I_BCU
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string ActionCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string Date_07 { get; set; }
    }
    
    public interface I_BDD
    {
        
        string InvoiceNumber_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string ShipmentIdentificationNumber_03 { get; set; }
    }
    
    public interface I_BEG
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string PurchaseOrderTypeCode_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string Date_05 { get; set; }
        string ContractNumber_06 { get; set; }
        string AcknowledgmentType_07 { get; set; }
        string InvoiceTypeCode_08 { get; set; }
        string ContractTypeCode_09 { get; set; }
        string PurchaseCategory_10 { get; set; }
        string SecurityLevelCode_11 { get; set; }
        string TransactionTypeCode_12 { get; set; }
    }
    
    public interface I_BEN
    {
        
        string PrimaryorContingentCode_01 { get; set; }
        string Percent_02 { get; set; }
        string IndividualRelationshipCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string TypeofAccountCode_06 { get; set; }
    }
    
    public interface I_BEP
    {
        
        string ProgramParticipationandServicesCode_01 { get; set; }
        string InstructionalSettingCode_02 { get; set; }
    }
    
    public interface I_BFR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReleaseNumber_03 { get; set; }
        string ScheduleTypeQualifier_04 { get; set; }
        string ScheduleQuantityQualifier_05 { get; set; }
        string Date_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
        string Date_09 { get; set; }
        string ContractNumber_10 { get; set; }
        string PurchaseOrderNumber_11 { get; set; }
        string PlanningScheduleTypeCode_12 { get; set; }
        string ActionCode_13 { get; set; }
    }
    
    public interface I_BFS
    {
        
        string RateValueQualifier_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string Date_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Date_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string TypeofIncomeCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
    }
    
    public interface I_BGF
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
    }
    
    public interface I_BGN
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string TimeCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string TransactionTypeCode_07 { get; set; }
        string ActionCode_08 { get; set; }
        string SecurityLevelCode_09 { get; set; }
    }
    
    public interface I_BGP
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ProblemLogReasonCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string EquipmentInitial_05 { get; set; }
        string EquipmentNumber_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string InterchangeTrainIdentification_09 { get; set; }
    }
    
    public interface I_BHT
    {
        
        string HierarchicalStructureCode_01 { get; set; }
        string TransactionSetPurposeCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
    }
    
    public interface I_BIA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReportTypeCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string ActionCode_06 { get; set; }
    }
    
    public interface I_BIG
    {
        
        string Date_01 { get; set; }
        string InvoiceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string PurchaseOrderNumber_04 { get; set; }
        string ReleaseNumber_05 { get; set; }
        string ChangeOrderSequenceNumber_06 { get; set; }
        string TransactionTypeCode_07 { get; set; }
        string TransactionSetPurposeCode_08 { get; set; }
        string ActionCode_09 { get; set; }
        string InvoiceNumber_10 { get; set; }
    }
    
    public interface I_BIN
    {
        
        string LengthofBinaryData_01 { get; set; }
        string BinaryData_02 { get; set; }
    }
    
    public interface I_BIX
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Date_03 { get; set; }
        string InspectionLocationTypeCode_04 { get; set; }
        string RampIdentification_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string InspectorIdentityCode_08 { get; set; }
        string DamageCodeQualifier_09 { get; set; }
        string IdentificationCodeQualifier_10 { get; set; }
        string IdentificationCode_11 { get; set; }
    }
    
    public interface I_BJF
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string RuleJunctionCode_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string CityName_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string CountryCode_07 { get; set; }
    }
    
    public interface I_BL
    {
        
        string RebillReasonCode_01 { get; set; }
        string FreightStationAccountingCode_02 { get; set; }
        string FreightStationAccountingCode_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string CityName_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string CityName_09 { get; set; }
        string StateorProvinceCode_10 { get; set; }
        string CountryCode_11 { get; set; }
        string StandardCarrierAlphaCode_12 { get; set; }
        string StandardCarrierAlphaCode_13 { get; set; }
        string StandardCarrierAlphaCode_14 { get; set; }
        string StandardCarrierAlphaCode_15 { get; set; }
        string StandardCarrierAlphaCode_16 { get; set; }
        string StandardCarrierAlphaCode_17 { get; set; }
    }
    
    public interface I_BLI
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Quantity_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string PriceIdentifierCode_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductOptionCode_14 { get; set; }
        string ProductOptionCode_15 { get; set; }
        string ProductOptionCode_16 { get; set; }
        string ProductOptionCode_17 { get; set; }
        string FrequencyCode_18 { get; set; }
    }
    
    public interface I_BLN
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TimeCode_06 { get; set; }
    }
    
    public interface I_BLR
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string Date_02 { get; set; }
    }
    
    public interface I_BLS
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string AcknowledgmentType_06 { get; set; }
    }
    
    public interface I_BMA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string Description_08 { get; set; }
    }
    
    public interface I_BMG
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Description_02 { get; set; }
        string TransactionTypeCode_03 { get; set; }
    }
    
    public interface I_BMM
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string WaybillNumber_04 { get; set; }
        string StandardPointLocationCode_05 { get; set; }
        string ShipmentIdentificationNumber_06 { get; set; }
        string VehicleStatus_07 { get; set; }
        string AccountNumber_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string TransactionSetPurposeCode_10 { get; set; }
    }
    
    public interface I_BMP
    {
        
        string TransactionHandlingCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string PaymentMethodCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_BMS
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string LanguageCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string RevisionValue_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string RevisionValue_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
        string CountryCode_09 { get; set; }
    }
    
    public interface I_BNR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string NonconformanceReportStatusCode_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
    }
    
    public interface I_BNX
    {
        
        string ShipmentWeightCode_01 { get; set; }
        string ReferencedPatternIdentifier_02 { get; set; }
        string BillingCode_03 { get; set; }
        string RepetitivePatternNumber_04 { get; set; }
    }
    
    public interface I_BOL
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string ShipmentMethodofPayment_02 { get; set; }
        string ShipmentIdentificationNumber_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string StatusReportRequestCode_07 { get; set; }
        string SectionSevenCode_08 { get; set; }
        string CustomsDocumentationHandlingCode_09 { get; set; }
        string ShipmentMethodofPayment_10 { get; set; }
        string CurrencyCode_11 { get; set; }
    }
    
    public interface I_BOR
    {
        
        string ReportTypeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string TransportationMethodTypeCode_07 { get; set; }
        string ActionCode_08 { get; set; }
        string StatusReasonCode_09 { get; set; }
        string LanguageCode_10 { get; set; }
    }
    
    public interface I_BOS
    {
        
        string StatementNumber_01 { get; set; }
        string Date_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string StatementFormatCode_04 { get; set; }
        string TransactionTypeCode_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_BOX
    {
        
        string FrequencyCode_01 { get; set; }
        string ShowCode_02 { get; set; }
        string TicketCategoryCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string CurrencyCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Quantity_07 { get; set; }
        string Quantity_08 { get; set; }
        string Quantity_09 { get; set; }
        string Quantity_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string UnitPrice_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
        string ReferenceIdentification_15 { get; set; }
    }
    
    public interface I_BPA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_BPP
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string NetworkorScheduleDataType_03 { get; set; }
        string ContractNumber_04 { get; set; }
        string Description_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string Date_07 { get; set; }
        string ReportTypeCode_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string Description_10 { get; set; }
        string Date_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
        string SecurityLevelCode_13 { get; set; }
        string VersionIdentifier_14 { get; set; }
    }
    
    public interface I_BPR
    {
        
        string TransactionHandlingCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
        string PaymentMethodCode_04 { get; set; }
        string PaymentFormatCode_05 { get; set; }
        string DFIIDNumberQualifier_06 { get; set; }
        string DFIIdentificationNumber_07 { get; set; }
        string AccountNumberQualifier_08 { get; set; }
        string AccountNumber_09 { get; set; }
        string OriginatingCompanyIdentifier_10 { get; set; }
        string OriginatingCompanySupplementalCode_11 { get; set; }
        string DFIIDNumberQualifier_12 { get; set; }
        string DFIIdentificationNumber_13 { get; set; }
        string AccountNumberQualifier_14 { get; set; }
        string AccountNumber_15 { get; set; }
        string Date_16 { get; set; }
        string BusinessFunctionCode_17 { get; set; }
        string DFIIDNumberQualifier_18 { get; set; }
        string DFIIdentificationNumber_19 { get; set; }
        string AccountNumberQualifier_20 { get; set; }
        string AccountNumber_21 { get; set; }
    }
    
    public interface I_BPT
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string ReportTypeCode_04 { get; set; }
        string PriceMultiplierQualifier_05 { get; set; }
        string Multiplier_06 { get; set; }
        string ActionCode_07 { get; set; }
        string Time_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string SecurityLevelCode_10 { get; set; }
    }
    
    public interface I_BQR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string RequestforQuoteReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string BidTypeResponseCode_06 { get; set; }
        string SecurityLevelCode_07 { get; set; }
        string ChangeOrderSequenceNumber_08 { get; set; }
    }
    
    public interface I_BQT
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string RequestforQuoteReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string PurchaseOrderTypeCode_06 { get; set; }
        string RequestforQuoteTypeCode_07 { get; set; }
        string ContractTypeCode_08 { get; set; }
        string SecurityLevelCode_09 { get; set; }
        string PurchaseCategory_10 { get; set; }
        string ChangeOrderSequenceNumber_11 { get; set; }
    }
    
    public interface I_BR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string Date_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string ActionCode_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Time_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
    }
    
    public interface I_BRA
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Date_02 { get; set; }
        string TransactionSetPurposeCode_03 { get; set; }
        string ReceivingAdviceorAcceptanceCertificateTypeCode_04 { get; set; }
        string Time_05 { get; set; }
        string ReceivingConditionCode_06 { get; set; }
        string ActionCode_07 { get; set; }
    }
    
    public interface I_BRC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_BRR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_BSC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_BSD
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Description_03 { get; set; }
        string Level_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string BreakdownStructureDetailCode_06 { get; set; }
        string Level_07 { get; set; }
        string SecurityLevelCode_08 { get; set; }
    }
    
    public interface I_BSF
    {
        
        string ClassofTradeCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
    }
    
    public interface I_BSI
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Date_02 { get; set; }
        string OrderItemCode_03 { get; set; }
        string ProductDateCode_04 { get; set; }
        string LocationCode_05 { get; set; }
        string Time_06 { get; set; }
        string TransactionSetPurposeCode_07 { get; set; }
        string TransactionTypeCode_08 { get; set; }
        string ActionCode_09 { get; set; }
    }
    
    public interface I_BSN
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ShipmentIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string HierarchicalStructureCode_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
        string StatusReasonCode_07 { get; set; }
    }
    
    public interface I_BSR
    {
        
        string StatusReportCode_01 { get; set; }
        string OrderItemCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string ProductDateCode_05 { get; set; }
        string LocationCode_06 { get; set; }
        string Time_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Date_09 { get; set; }
        string Time_10 { get; set; }
        string TransactionSetPurposeCode_11 { get; set; }
        string ActionCode_12 { get; set; }
    }
    
    public interface I_BSS
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string ScheduleTypeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
        string ReleaseNumber_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string ContractNumber_09 { get; set; }
        string PurchaseOrderNumber_10 { get; set; }
        string ScheduleQuantityQualifier_11 { get; set; }
    }
    
    public interface I_BT1
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string NumberofTransactionSetsTotaled_02 { get; set; }
        string TotalQualifier_03 { get; set; }
        string DataElementTotaled_04 { get; set; }
        string Total_05 { get; set; }
        string TotalQualifier_06 { get; set; }
        string DataElementTotaled_07 { get; set; }
        string Total_08 { get; set; }
        string TotalQualifier_09 { get; set; }
        string DataElementTotaled_10 { get; set; }
        string Total_11 { get; set; }
    }
    
    public interface I_BTA
    {
        
        string AcknowledgmentType_01 { get; set; }
        string Date_02 { get; set; }
        string AmountQualifierCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
    }
    
    public interface I_BTC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ParameterTraceRegistrationTypeCode_02 { get; set; }
        string ParameterTraceTypeCode_03 { get; set; }
        string OutputEventSelectionCode_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string Count_09 { get; set; }
        string IdentificationCode_10 { get; set; }
        string AssociationofAmericanRailroadsAARPoolCode_11 { get; set; }
        string IndustryCode_12 { get; set; }
    }
    
    public interface I_BTI
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string Date_05 { get; set; }
        string NameControlIdentifier_06 { get; set; }
        string IdentificationCodeQualifier_07 { get; set; }
        string IdentificationCode_08 { get; set; }
        string IdentificationCodeQualifier_09 { get; set; }
        string IdentificationCode_10 { get; set; }
        string IdentificationCodeQualifier_11 { get; set; }
        string IdentificationCode_12 { get; set; }
        string TransactionSetPurposeCode_13 { get; set; }
        string TransactionTypeCode_14 { get; set; }
    }
    
    public interface I_BTP
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string TransactionTypeCode_05 { get; set; }
        string TransactionSetPurposeCode_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
        string PaymentMethodCode_10 { get; set; }
    }
    
    public interface I_BTR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReportTypeCode_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string SecurityLevelCode_07 { get; set; }
    }
    
    public interface I_BTS
    {
        
        string InterchangeTrainIdentification_01 { get; set; }
        string TotalEquipment_02 { get; set; }
        string EquipmentStatusCode_03 { get; set; }
        string TotalEquipment_04 { get; set; }
        string EquipmentStatusCode_05 { get; set; }
        string Weight_06 { get; set; }
        string Length_07 { get; set; }
        string Horsepower_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string TransactionSetPurposeCode_10 { get; set; }
        string ServiceLevelCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_BUY
    {
        
        string LoanBuydownTypeCode_01 { get; set; }
        string BuydownSourceCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
        string Percent_05 { get; set; }
    }
    
    public interface I_BVA
    {
        
        string PaymentTypeCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string Date_05 { get; set; }
        string InvoiceNumber_06 { get; set; }
        string IdentificationCodeQualifier_07 { get; set; }
        string IdentificationCode_08 { get; set; }
        string VehicleServiceCode_09 { get; set; }
        string IdentificationCodeQualifier_10 { get; set; }
        string IdentificationCode_11 { get; set; }
        string CurrencyCode_12 { get; set; }
        string LadingDescriptionQualifier_13 { get; set; }
        string Date_14 { get; set; }
        string ReferenceIdentification_15 { get; set; }
        string Date_16 { get; set; }
        string CheckNumber_17 { get; set; }
        string EquipmentInitial_18 { get; set; }
        string EquipmentNumber_19 { get; set; }
        string EquipmentDescriptionCode_20 { get; set; }
        string Quantity_21 { get; set; }
        string ShipmentIdentificationNumber_22 { get; set; }
        string FlightVoyageNumber_23 { get; set; }
        string VehicleStatus_24 { get; set; }
        string TransactionSetPurposeCode_25 { get; set; }
    }
    
    public interface I_BVB
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string BayTypeCode_04 { get; set; }
        string CapacityQualifier_05 { get; set; }
        string Quantity_06 { get; set; }
        string TransactionSetPurposeCode_07 { get; set; }
    }
    
    public interface I_BVP
    {
        
        string VehicleProductionStatus_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string VehicleServiceCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string VehicleStatus_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string Date_10 { get; set; }
        string TransactionSetPurposeCode_11 { get; set; }
    }
    
    public interface I_BVS
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string VehicleServiceCode_05 { get; set; }
        string VehicleStatus_06 { get; set; }
        string InvoiceNumber_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string BillofLadingWaybillNumber_10 { get; set; }
        string AccountNumber_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
    }
    
    public interface I_BW
    {
        
        string OriginEDICarrierCode_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string WeightUnitCode_03 { get; set; }
    }
    
    public interface I_BX
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string ShipmentMethodofPayment_03 { get; set; }
        string ShipmentIdentificationNumber_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string ShipmentQualifier_07 { get; set; }
        string SectionSevenCode_08 { get; set; }
        string CapacityLoadCode_09 { get; set; }
        string StatusReportRequestCode_10 { get; set; }
        string CustomsDocumentationHandlingCode_11 { get; set; }
        string ConfidentialBillingRequestCode_12 { get; set; }
        string GoodsandServicesTaxReasonCode_13 { get; set; }
        string ApplicationType_14 { get; set; }
    }
    
    public interface I_C2
    {
        
        string BankClientCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string ClientBankNumber_04 { get; set; }
        string BankAccountNumber_05 { get; set; }
        string PaymentMethodCode_06 { get; set; }
        string Date_07 { get; set; }
    }
    
    public interface I_C3
    {
        
        string CurrencyCode_01 { get; set; }
        string ExchangeRate_02 { get; set; }
        string CurrencyCode_03 { get; set; }
        string CurrencyCode_04 { get; set; }
    }
    
    public interface I_C4
    {
        
        string CurrencyCode_01 { get; set; }
        string NetAmountDue_02 { get; set; }
    }
    
    public interface I_C8
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string CertificationClauseCode_02 { get; set; }
        string CertificationClauseText_03 { get; set; }
        string ShippersExportDeclarationRequirements_04 { get; set; }
    }
    
    public interface I_C8C
    {
        
        string CertificationClauseText_01 { get; set; }
        string CertificationClauseText_02 { get; set; }
        string CertificationClauseText_03 { get; set; }
    }
    
    public interface I_CA1
    {
        
        string RateRequestID_01 { get; set; }
        string RateResponseSuffix_02 { get; set; }
    }
    
    public interface I_CAD
    {
        
        string TransportationMethodTypeCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string Routing_05 { get; set; }
        string ShipmentOrderStatusCode_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string ServiceLevelCode_09 { get; set; }
    }
    
    public interface I_CAI
    {
        
        string PublicRecordorObligationCode_01 { get; set; }
        string Name_02 { get; set; }
        string Name_03 { get; set; }
        string AmountQualifierCode_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string RateValueQualifier_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
    }
    
    public interface I_CAL
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string UnitofTimePeriodorInterval_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string Time_06 { get; set; }
        string TimeCode_07 { get; set; }
        string ShipDeliveryorCalendarPatternCode_08 { get; set; }
        string DateTimeQualifier_09 { get; set; }
        string Date_10 { get; set; }
        string Time_11 { get; set; }
        string TimeCode_12 { get; set; }
        string ShipDeliveryorCalendarPatternCode_13 { get; set; }
        string QuantityQualifier_14 { get; set; }
        string Quantity_15 { get; set; }
        string FreeformDescription_16 { get; set; }
    }
    
    public interface I_CAS
    {
        
        string ClaimAdjustmentGroupCode_01 { get; set; }
        string ClaimAdjustmentReasonCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Quantity_04 { get; set; }
        string ClaimAdjustmentReasonCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Quantity_07 { get; set; }
        string ClaimAdjustmentReasonCode_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string Quantity_10 { get; set; }
        string ClaimAdjustmentReasonCode_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string Quantity_13 { get; set; }
        string ClaimAdjustmentReasonCode_14 { get; set; }
        string MonetaryAmount_15 { get; set; }
        string Quantity_16 { get; set; }
        string ClaimAdjustmentReasonCode_17 { get; set; }
        string MonetaryAmount_18 { get; set; }
        string Quantity_19 { get; set; }
    }
    
    public interface I_CAT
    {
        
        string ReportTypeCode_01 { get; set; }
        string ReportTransmissionCode_02 { get; set; }
        string VersionIdentifier_03 { get; set; }
        string CodeListQualifierCode_04 { get; set; }
        string IndustryCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
        string VersionIdentifier_07 { get; set; }
    }
    
    public interface I_CB1
    {
        
        string AcquisitionDataCode_01 { get; set; }
        string FinancingTypeCode_02 { get; set; }
    }
    
    public interface I_CBS<T1>
        where T1 : I_C001
    {
        
        string AssignedIdentification_01 { get; set; }
        string Quantity_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public interface I_CCI
    {
        
        string IdentificationCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string DateTimePeriod_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string CounselingStatusCode_10 { get; set; }
    }
    
    public interface I_CD
    {
        
        string ConditionSegmentLogicalConnector_01 { get; set; }
        string ConditionCode_02 { get; set; }
        string ConditionValue_03 { get; set; }
        string ConditionValue_04 { get; set; }
        string ConditionValue_05 { get; set; }
        string AssignedNumber_06 { get; set; }
        string ChangeTypeCode_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string DocketControlNumber_09 { get; set; }
        string DocketIdentification_10 { get; set; }
        string GroupTitle_11 { get; set; }
    }
    
    public interface I_CD1
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string EquipmentType_03 { get; set; }
        string BillofLadingWaybillNumber_04 { get; set; }
        string TypeofServiceCode_05 { get; set; }
        string HazardousMaterialCodeQualifier_06 { get; set; }
        string HazardousMaterialClassCode_07 { get; set; }
        string Date_08 { get; set; }
        string LocationIdentifier_09 { get; set; }
        string Quantity_10 { get; set; }
        string PackagingCode_11 { get; set; }
        string DispositionCode_12 { get; set; }
        string DispositionCode_13 { get; set; }
        string DispositionCode_14 { get; set; }
        string RateClassCode_15 { get; set; }
        string RateValueQualifier_16 { get; set; }
        string Rate_17 { get; set; }
        string RateClassCode_18 { get; set; }
        string RateValueQualifier_19 { get; set; }
        string Rate_20 { get; set; }
        string RateClassCode_21 { get; set; }
        string RateValueQualifier_22 { get; set; }
        string Rate_23 { get; set; }
        string DateTimeQualifier_24 { get; set; }
        string Date_25 { get; set; }
        string ShipmentStatusCode_26 { get; set; }
        string StandardCarrierAlphaCode_27 { get; set; }
        string ReferenceIdentificationQualifier_28 { get; set; }
        string ReferenceIdentification_29 { get; set; }
        string ReferenceIdentificationQualifier_30 { get; set; }
        string ReferenceIdentification_31 { get; set; }
    }
    
    public interface I_CD2
    {
        
        string CodeCategory_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string MedicalCodeValue_03 { get; set; }
        string MedicalCodeValue_04 { get; set; }
        string MedicalCodeValue_05 { get; set; }
        string MedicalCodeValue_06 { get; set; }
        string MedicalCodeValue_07 { get; set; }
        string MedicalCodeValue_08 { get; set; }
    }
    
    public interface I_CD3
    {
        
        string WeightQualifier_01 { get; set; }
        string Weight_02 { get; set; }
        string Zone_03 { get; set; }
        string ServiceStandard_04 { get; set; }
        string ServiceLevelCode_05 { get; set; }
        string PickuporDeliveryCode_06 { get; set; }
        string RateValueQualifier_07 { get; set; }
        string Charge_08 { get; set; }
        string RateValueQualifier_09 { get; set; }
        string Charge_10 { get; set; }
        string ServiceLevelCode_11 { get; set; }
        string ServiceLevelCode_12 { get; set; }
        string PaymentMethodCode_13 { get; set; }
        string CountryCode_14 { get; set; }
    }
    
    public interface I_CDA
    {
        
        string AccountNumber_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string TypeofAccountCode_06 { get; set; }
        string TypeofCreditAccountCode_07 { get; set; }
        string Quantity_08 { get; set; }
        string Quantity_09 { get; set; }
        string DateTimePeriodFormatQualifier_10 { get; set; }
        string DateTimePeriod_11 { get; set; }
        string DateTimePeriod_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string DateTimePeriod_14 { get; set; }
        string DateTimePeriod_15 { get; set; }
        string Description_16 { get; set; }
        string ReferenceIdentification_17 { get; set; }
        string LoanTypeCode_18 { get; set; }
        string FrequencyCode_19 { get; set; }
        string ReferenceIdentification_20 { get; set; }
    }
    
    public interface I_CDD
    {
        
        string AdjustmentReasonCode_01 { get; set; }
        string CreditDebitFlagCode_02 { get; set; }
        string AssignedIdentification_03 { get; set; }
        string Amount_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string PriceBracketIdentifier_06 { get; set; }
        string CreditDebitQuantity_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string UnitPriceDifference_09 { get; set; }
        string PriceIdentifierCode_10 { get; set; }
        string UnitPrice_11 { get; set; }
        string PriceIdentifierCode_12 { get; set; }
        string UnitPrice_13 { get; set; }
    }
    
    public interface I_CDI<T1>
        where T1 : I_C045
    {
        
        string OptionTypeCode_01 { get; set; }
        T1 ConditionsIndicated_02 { get; set; }
        string ConvertibilityRateTypeCode_03 { get; set; }
        string StatusReasonCode_04 { get; set; }
        string RateValueQualifier_05 { get; set; }
        string Quantity_06 { get; set; }
        string Number_07 { get; set; }
        string Number_08 { get; set; }
        string IndexIdentityCode_09 { get; set; }
        string PrimarySourceofIndexCode_10 { get; set; }
        string Description_11 { get; set; }
    }
    
    public interface I_CDS
    {
        
        string CaseTypeCode_01 { get; set; }
        string AdministrationofJusticeOrganizationTypeCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Description_05 { get; set; }
        string IdentificationCodeQualifier_06 { get; set; }
        string IdentificationCode_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string IdentificationCodeQualifier_10 { get; set; }
        string IdentificationCode_11 { get; set; }
    }
    
    public interface I_CED
    {
        
        string AdministrationofJusticeEventTypeCode_01 { get; set; }
        string ActionCode_02 { get; set; }
        string NoticeTypeCode_03 { get; set; }
        string CaseTypeCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_CF1
    {
        
        string MasterReferenceLinkNumber_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Date_03 { get; set; }
        string Count_04 { get; set; }
        string Amount_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_CF2
    {
        
        string InvoiceNumber_01 { get; set; }
        string NetAmountDue_02 { get; set; }
        string ShipmentIdentificationNumber_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
        string WeightQualifier_07 { get; set; }
        string WeightUnitCode_08 { get; set; }
        string Weight_09 { get; set; }
        string TransactionTypeCode_10 { get; set; }
    }
    
    public interface I_CFT<T1>
        where T1 : I_C001
    {
        
        string ReportTypeCode_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string ContractingFundingCode_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string DateTimeQualifier_06 { get; set; }
        string Date_07 { get; set; }
        string AppropriationCode_08 { get; set; }
        string Description_09 { get; set; }
    }
    
    public interface I_CGS
    {
        
        string Charge_01 { get; set; }
        string CurrencyCode_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string SpecialChargeorAllowanceCode_05 { get; set; }
    }
    
    public interface I_CHB
    {
        
        string LocationQualifier_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string ReasonStoppedWorkCode_03 { get; set; }
        string ClaimTypeCode_04 { get; set; }
        string ClaimStatusCode_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
        string CreditDebitFlagCode_07 { get; set; }
        string IndustryCode_08 { get; set; }
        string AllowanceorChargeIndicator_09 { get; set; }
    }
    
    public interface I_CHR
    {
        
        string RateSource_01 { get; set; }
        string BilledRatedasQualifier_02 { get; set; }
        string Multiplier_03 { get; set; }
    }
    
    public interface I_CI
    {
        
        string Name_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
        string InterchangeAgreementStatusCode_07 { get; set; }
        string DateTimeQualifier_08 { get; set; }
        string Date_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string Date_11 { get; set; }
        string Name_12 { get; set; }
        string ReferenceIdentificationQualifier_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
    }
    
    public interface I_CIC
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string CarTypeCode_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string MechanicalCarCode_05 { get; set; }
    }
    
    public interface I_CID
    {
        
        string MeasurementQualifier_01 { get; set; }
        string ProductProcessCharacteristicCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string ProductDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
        string SourceSubqualifier_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_CIV
    {
        
        string PublicRecordorObligationCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string Name_05 { get; set; }
        string Name_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string CityName_09 { get; set; }
        string CountyDesignator_10 { get; set; }
        string StateorProvinceCode_11 { get; set; }
        string DateTimePeriodFormatQualifier_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string DateTimeQualifier_14 { get; set; }
        string DateTimePeriodFormatQualifier_15 { get; set; }
        string DateTimePeriod_16 { get; set; }
        string Description_17 { get; set; }
        string ReferenceIdentification_18 { get; set; }
    }
    
    public interface I_CL
    {
        
        string FreightClassCode_01 { get; set; }
    }
    
    public interface I_CL1
    {
        
        string AdmissionTypeCode_01 { get; set; }
        string AdmissionSourceCode_02 { get; set; }
        string PatientStatusCode_03 { get; set; }
        string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    public interface I_CLD
    {
        
        string NumberofLoads_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string PackagingCode_03 { get; set; }
        string Size_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
    }
    
    public interface I_CLI
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string BreakdownStructureDetailCode_02 { get; set; }
        string AssignedIdentification_03 { get; set; }
        string FreeformDescription_04 { get; set; }
        string RateorValueTypeCode_05 { get; set; }
        string ContractTypeCode_06 { get; set; }
    }
    
    public interface I_CLM<T1, T2>
        where T1 : I_C023
        where T2 : I_C024
    {
        
        string ClaimSubmittersIdentifier_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string ClaimFilingIndicatorCode_03 { get; set; }
        string NonInstitutionalClaimTypeCode_04 { get; set; }
        T1 HealthCareServiceLocationInformation_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string ProviderAcceptAssignmentCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
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
    
    public interface I_CLP
    {
        
        string ClaimSubmittersIdentifier_01 { get; set; }
        string ClaimStatusCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string ClaimFilingIndicatorCode_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string FacilityCodeValue_08 { get; set; }
        string ClaimFrequencyTypeCode_09 { get; set; }
        string PatientStatusCode_10 { get; set; }
        string DiagnosisRelatedGroupDRGCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string Percent_13 { get; set; }
    }
    
    public interface I_CLR
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_CM
    {
        
        string FlightVoyageNumber_01 { get; set; }
        string PortorTerminalFunctionCode_02 { get; set; }
        string PortName_03 { get; set; }
        string Date_04 { get; set; }
        string BookingNumber_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string Date_08 { get; set; }
        string VesselName_09 { get; set; }
        string PierNumber_10 { get; set; }
        string PierName_11 { get; set; }
        string TerminalName_12 { get; set; }
        string StateorProvinceCode_13 { get; set; }
        string CountryCode_14 { get; set; }
        string ReferenceIdentification_15 { get; set; }
        string CorrectionIndicator_16 { get; set; }
        string TransportationMethodTypeCode_17 { get; set; }
    }
    
    public interface I_CMA
    {
        
        string TransactionTypeCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string Week_05 { get; set; }
        string MarketAreaCodeQualifier_06 { get; set; }
        string MarketAreaCodeIdentifier_07 { get; set; }
        string CurrencyCode_08 { get; set; }
        string MarketProfile_09 { get; set; }
        string ContractNumber_10 { get; set; }
        string TransactionSetPurposeCode_11 { get; set; }
    }
    
    public interface I_CN1
    {
        
        string ContractTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string TermsDiscountPercent_05 { get; set; }
        string VersionIdentifier_06 { get; set; }
    }
    
    public interface I_COB
    {
        
        string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string CoordinationofBenefitsCode_03 { get; set; }
    }
    
    public interface I_COM
    {
        
        string CommunicationNumberQualifier_01 { get; set; }
        string CommunicationNumber_02 { get; set; }
    }
    
    public interface I_CON
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ContractStatusCode_03 { get; set; }
    }
    
    public interface I_CPR
    {
        
        string MarketExchangeIdentifier_01 { get; set; }
        string Date_02 { get; set; }
        string UnitPrice_03 { get; set; }
        string CommodityIdentification_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_CR1
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string Weight_02 { get; set; }
        string AmbulanceTransportCode_03 { get; set; }
        string AmbulanceTransportReasonCode_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string AddressInformation_07 { get; set; }
        string AddressInformation_08 { get; set; }
        string Description_09 { get; set; }
        string Description_10 { get; set; }
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
        string NatureofConditionCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string Description_10 { get; set; }
        string Description_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_CR3
    {
        
        string CertificationTypeCode_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string InsulinDependentCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_CR4
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string CertificationTypeCode_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string NonVisitCode_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string Quantity_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Height_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
        string Weight_13 { get; set; }
        string Quantity_14 { get; set; }
        string Description_15 { get; set; }
        string NutrientAdministrationMethodCode_16 { get; set; }
        string NutrientAdministrationTechniqueCode_17 { get; set; }
        string Quantity_18 { get; set; }
        string Quantity_19 { get; set; }
        string Description_20 { get; set; }
        string Quantity_21 { get; set; }
        string Percent_22 { get; set; }
        string Quantity_23 { get; set; }
        string Quantity_24 { get; set; }
        string Percent_25 { get; set; }
        string Quantity_26 { get; set; }
        string Percent_27 { get; set; }
        string Quantity_28 { get; set; }
        string Description_29 { get; set; }
    }
    
    public interface I_CR5
    {
        
        string CertificationTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string OxygenEquipmentTypeCode_03 { get; set; }
        string OxygenEquipmentTypeCode_04 { get; set; }
        string Description_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
        string Quantity_08 { get; set; }
        string Description_09 { get; set; }
        string Quantity_10 { get; set; }
        string Quantity_11 { get; set; }
        string OxygenTestConditionCode_12 { get; set; }
        string OxygenTestFindingsCode_13 { get; set; }
        string OxygenTestFindingsCode_14 { get; set; }
        string OxygenTestFindingsCode_15 { get; set; }
        string Quantity_16 { get; set; }
        string OxygenDeliverySystemCode_17 { get; set; }
        string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    public interface I_CR6
    {
        
        string PrognosisCode_01 { get; set; }
        string Date_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string Date_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string CertificationTypeCode_08 { get; set; }
        string Date_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string MedicalCodeValue_11 { get; set; }
        string Date_12 { get; set; }
        string Date_13 { get; set; }
        string Date_14 { get; set; }
        string DateTimePeriodFormatQualifier_15 { get; set; }
        string DateTimePeriod_16 { get; set; }
        string PatientLocationCode_17 { get; set; }
        string Date_18 { get; set; }
        string Date_19 { get; set; }
        string Date_20 { get; set; }
        string Date_21 { get; set; }
    }
    
    public interface I_CR7
    {
        
        string DisciplineTypeCode_01 { get; set; }
        string Number_02 { get; set; }
        string Number_03 { get; set; }
    }
    
    public interface I_CR8
    {
        
        string ImplantTypeCode_01 { get; set; }
        string ImplantStatusCode_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_CRC
    {
        
        string CodeCategory_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string ConditionIndicator_03 { get; set; }
        string ConditionIndicator_04 { get; set; }
        string ConditionIndicator_05 { get; set; }
        string ConditionIndicator_06 { get; set; }
        string ConditionIndicator_07 { get; set; }
    }
    
    public interface I_CRD
    {
        
        string CountryCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
    }
    
    public interface I_CRI
    {
        
        string MaintenanceTypeCode_01 { get; set; }
        string ClaimStatusCode_02 { get; set; }
        string MaintenanceReasonCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string FrequencyCode_05 { get; set; }
        string ClaimFilingIndicatorCode_06 { get; set; }
        string DateTimePeriodFormatQualifier_07 { get; set; }
        string DateTimePeriod_08 { get; set; }
        string AdjustmentReasonCodeCharacteristic_09 { get; set; }
        string LateReasonCode_10 { get; set; }
    }
    
    public interface I_CRO
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DateTimePeriod_02 { get; set; }
        string ProductServiceIDQualifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string ActionCode_05 { get; set; }
        string CreditReportMergeTypeCode_06 { get; set; }
    }
    
    public interface I_CRS
    {
        
        string BasisforAcademicCreditCode_01 { get; set; }
        string AcademicCreditTypeCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
        string AcademicGradeQualifier_05 { get; set; }
        string AcademicGrade_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string AcademicGradeorCourseLevelCode_08 { get; set; }
        string CourseRepeatorNoCountIndicatorCode_09 { get; set; }
        string IdentificationCodeQualifier_10 { get; set; }
        string IdentificationCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string LevelofIndividualTestorCourseCode_13 { get; set; }
        string Name_14 { get; set; }
        string ReferenceIdentification_15 { get; set; }
        string Name_16 { get; set; }
        string Quantity_17 { get; set; }
        string Quantity_18 { get; set; }
        string Date_19 { get; set; }
        string OverrideAcademicCourseSourceCode_20 { get; set; }
    }
    
    public interface I_CRT<T1, T2>
        where T1 : I_C001
        where T2 : I_C001
    {
        
        string ReportTypeCode_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        T2 CompositeUnitofMeasure_03 { get; set; }
        string BreakdownStructureDetailCode_04 { get; set; }
        string ActionCode_05 { get; set; }
        string RateorValueTypeCode_06 { get; set; }
        string ContractActionCode_07 { get; set; }
        string ProgramTypeCode_08 { get; set; }
        string FreeformDescription_09 { get; set; }
        string SecurityLevelCode_10 { get; set; }
    }
    
    public interface I_CRV
    {
        
        string NetCostCode_01 { get; set; }
        string Amount_02 { get; set; }
        string CountryCode_03 { get; set; }
        string ProductProcessCharacteristicCode_04 { get; set; }
        string Percent_05 { get; set; }
        string CertificationClauseCode_06 { get; set; }
        string PreferentialDutyCriteriaCode_07 { get; set; }
    }
    
    public interface I_CS
    {
        
        string ContractNumber_01 { get; set; }
        string ChangeOrderSequenceNumber_02 { get; set; }
        string ReleaseNumber_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string PurchaseOrderNumber_06 { get; set; }
        string SpecialServicesCode_07 { get; set; }
        string FOBPointCode_08 { get; set; }
        string Percent_09 { get; set; }
        string Percent_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string TermsTypeCode_12 { get; set; }
        string SpecialServicesCode_13 { get; set; }
        string UnitorBasisforMeasurementCode_14 { get; set; }
        string UnitPrice_15 { get; set; }
        string TermsTypeCode_16 { get; set; }
        string YesNoConditionorResponseCode_17 { get; set; }
        string YesNoConditionorResponseCode_18 { get; set; }
    }
    
    public interface I_CSB
    {
        
        string CryptographicServiceMessageCSMFieldTag_01 { get; set; }
        string CryptographicServiceMessageCSMFieldContents_02 { get; set; }
    }
    
    public interface I_CSC<T1, T2, T3>
        where T1 : I_C050
        where T2 : I_C040
        where T3 : I_C033
    {
        
        string CryptographicManagementPurpose_01 { get; set; }
        string SecurityOriginatorName_02 { get; set; }
        string SecurityRecipientName_03 { get; set; }
        T1 CertificateLookupInformation_04 { get; set; }
        T2 ReferenceIdentifier_05 { get; set; }
        string FilterIDCode_06 { get; set; }
        string VersionIdentifier_07 { get; set; }
        string LengthofData_08 { get; set; }
        T3 SecurityValue_09 { get; set; }
    }
    
    public interface I_CSD
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
        string Charge_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_CSE
    {
        
        string Name_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string AcademicCreditTypeCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string Quantity_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string AcademicGradeorCourseLevelCode_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string EntityTitle_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_CSF<T1>
        where T1 : I_C001
    {
        
        T1 CompositeUnitofMeasure_01 { get; set; }
        string SampleSelectionModulus_02 { get; set; }
        string SampleFrequencyValueperUnitofMeasurementCode_03 { get; set; }
    }
    
    public interface I_CSH
    {
        
        string SalesRequirementCode_01 { get; set; }
        string ActionCode_02 { get; set; }
        string Amount_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string Date_05 { get; set; }
        string AgencyQualifierCode_06 { get; set; }
        string SpecialServicesCode_07 { get; set; }
        string ProductServiceSubstitutionCode_08 { get; set; }
        string Percent_09 { get; set; }
        string PercentQualifier_10 { get; set; }
    }
    
    public interface I_CSI
    {
        
        string ClaimSubmissionReasonCode_01 { get; set; }
        string DateTimeQualifier_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
    }
    
    public interface I_CSM
    {
        
        string CryptographicServiceMessageCSMMessageClassCode_01 { get; set; }
        string SecurityOriginatorName_02 { get; set; }
        string SecurityRecipientName_03 { get; set; }
    }
    
    public interface I_CSS<T1>
        where T1 : I_C001
    {
        
        string SamplingSequenceQualifier_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string SamplingSequenceValue_03 { get; set; }
        string SamplingSequenceValue_04 { get; set; }
        string SamplingSequenceValue_05 { get; set; }
        string SamplingSequenceValue_06 { get; set; }
        string SamplingSequenceValue_07 { get; set; }
    }
    
    public interface I_CST<T1>
        where T1 : I_C001
    {
        
        string CostCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string Quantity_04 { get; set; }
    }
    
    public interface I_CSU<T1>
        where T1 : I_C001
    {
        
        string Name_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string InstructionalSettingCode_07 { get; set; }
        string AcademicCreditTypeCode_08 { get; set; }
        string Quantity_09 { get; set; }
        T1 CompositeUnitofMeasure_10 { get; set; }
    }
    
    public interface I_CT
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string CarTypeCode_02 { get; set; }
        string CarTypeCode_03 { get; set; }
    }
    
    public interface I_CTB
    {
        
        string RestrictionsConditionsQualifier_01 { get; set; }
        string Description_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string Quantity_04 { get; set; }
        string AmountQualifierCode_05 { get; set; }
        string Amount_06 { get; set; }
    }
    
    public interface I_CTC
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string CarHireDetailSummaryCode_03 { get; set; }
        string AccountTypeCode_04 { get; set; }
        string TransactionSetPurposeCode_05 { get; set; }
        string Year_06 { get; set; }
        string MonthoftheYearCode_07 { get; set; }
        string Year_08 { get; set; }
        string MonthoftheYearCode_09 { get; set; }
        string AccountDescriptionCode_10 { get; set; }
    }
    
    public interface I_CTP<T1>
        where T1 : I_C001
    {
        
        string ClassofTradeCode_01 { get; set; }
        string PriceIdentifierCode_02 { get; set; }
        string UnitPrice_03 { get; set; }
        string Quantity_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string PriceMultiplierQualifier_06 { get; set; }
        string Multiplier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string BasisofUnitPriceCode_09 { get; set; }
        string ConditionValue_10 { get; set; }
        string MultiplePriceQuantity_11 { get; set; }
    }
    
    public interface I_CTT
    {
        
        string NumberofLineItems_01 { get; set; }
        string HashTotal_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Description_07 { get; set; }
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
    
    public interface I_CV
    {
        
        string LoadEmptyStatusCode_01 { get; set; }
        string PaymentActionCode_02 { get; set; }
        string CarTypeGroupCode_03 { get; set; }
        string TimePeriodQualifier_04 { get; set; }
        string Quantity_05 { get; set; }
        string MileageSettlementCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string Quantity_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string MonetaryAmount_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string PenaltyCode_14 { get; set; }
    }
    
    public interface I_CYC
    {
        
        string Year_01 { get; set; }
        string MonthoftheYearCode_02 { get; set; }
        string CycleMonthHours_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string AssociationofAmericanRailroadsAARPoolCode_06 { get; set; }
    }
    
    public interface I_D9
    {
        
        string FreightStationAccountingCode_01 { get; set; }
        string CityName_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string FreightStationAccountingCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string PostalCode_09 { get; set; }
        string StandardPointLocationCode_10 { get; set; }
        string PostalCode_11 { get; set; }
        string CountryCode_12 { get; set; }
    }
    
    public interface I_DAD
    {
        
        string ActionCode_01 { get; set; }
        string TransactionHandlingCode_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
        string OriginatingCompanyIdentifier_05 { get; set; }
        string OriginatingCompanySupplementalCode_06 { get; set; }
        string AmountQualifierCode_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
        string DFIIDNumberQualifier_11 { get; set; }
        string DFIIdentificationNumber_12 { get; set; }
        string AccountNumber_13 { get; set; }
        string Number_14 { get; set; }
        string FrequencyCode_15 { get; set; }
    }
    
    public interface I_DAI
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string CodeListReference_02 { get; set; }
        string NoteIdentificationNumber_03 { get; set; }
    }
    
    public interface I_DAM
    {
        
        string DamageStatusCode_01 { get; set; }
        string DamageAreaCode_02 { get; set; }
        string Amount_03 { get; set; }
        string CurrencyCode_04 { get; set; }
        string DamageStatusCode_05 { get; set; }
        string DamageAreaCode_06 { get; set; }
        string Amount_07 { get; set; }
        string DamageStatusCode_08 { get; set; }
        string DamageAreaCode_09 { get; set; }
        string Amount_10 { get; set; }
        string DamageStatusCode_11 { get; set; }
        string DamageAreaCode_12 { get; set; }
        string Amount_13 { get; set; }
        string DamageStatusCode_14 { get; set; }
        string DamageAreaCode_15 { get; set; }
        string Amount_16 { get; set; }
    }
    
    public interface I_DB
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DateTimePeriod_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_DD
    {
        
        string IndustryCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string IndustryCode_05 { get; set; }
        string CodeListQualifierCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string IndustryCode_09 { get; set; }
        string CodeListQualifierCode_10 { get; set; }
    }
    
    public interface I_DDI
    {
        
        string Description_01 { get; set; }
    }
    
    public interface I_DED
    {
        
        string TypeofDeduction_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Amount_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string Name_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_DEF
    {
        
        string DelayedRepaymentQualifierCode_01 { get; set; }
        string DelayedRepaymentReasonCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string InterestPaymentCode_05 { get; set; }
    }
    
    public interface I_DEG
    {
        
        string AcademicDegreeCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string Description_04 { get; set; }
        string StatusReasonCode_05 { get; set; }
    }
    
    public interface I_DEL
    {
        
        string Quantity_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string InvoiceNumber_04 { get; set; }
        string MoveTypeCode_05 { get; set; }
    }
    
    public interface I_DEP
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string DFIIDNumberQualifier_05 { get; set; }
        string DFIIdentificationNumber_06 { get; set; }
        string AccountNumberQualifier_07 { get; set; }
        string AccountNumber_08 { get; set; }
    }
    
    public interface I_DEX
    {
        
        string SalesTermsCode_01 { get; set; }
        string RemittanceTypeCode_02 { get; set; }
        string InvestorOwnershipTypeCode_03 { get; set; }
        string Number_04 { get; set; }
        string CodeListQualifierCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
    }
    
    public interface I_DFI
    {
        
        string StatusReasonCode_01 { get; set; }
        string ClaimFilingIndicatorCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    public interface I_DH
    {
        
        string ShipDeliveryorCalendarPatternCode_01 { get; set; }
        string Time_02 { get; set; }
        string Time_03 { get; set; }
    }
    
    public interface I_DIS
    {
        
        string DiscountTermsTypeCode_01 { get; set; }
        string DiscountBaseQualifier_02 { get; set; }
        string DiscountBaseValue_03 { get; set; }
        string DiscountControlLimitQualifier_04 { get; set; }
        string DiscountControlLimit_05 { get; set; }
        string DiscountControlLimit_06 { get; set; }
    }
    
    public interface I_DK
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string DocketControlNumber_02 { get; set; }
        string DocketIdentification_03 { get; set; }
        string RevisionNumber_04 { get; set; }
        string ConveyanceCode_05 { get; set; }
        string DocketTypeCode_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
        string ApplicationType_09 { get; set; }
        string GroupTitle_10 { get; set; }
    }
    
    public interface I_DL
    {
        
        string ActionCode_01 { get; set; }
        string LaborHours_02 { get; set; }
        string LaborHours_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Amount_05 { get; set; }
        string Number_06 { get; set; }
        string Number_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    public interface I_DLV
    {
        
        string QuantityOrdered_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string ProgramTypeCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_DM
    {
        
        string GeographyQualifierCode_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string TimeQualifier_03 { get; set; }
        string Time_04 { get; set; }
        string NumberofPeriods_05 { get; set; }
        string TimePeriodQualifier_06 { get; set; }
        string NumberofPeriods_07 { get; set; }
        string Rate_08 { get; set; }
        string IntermodalServiceCode_09 { get; set; }
        string TariffApplicationCode_10 { get; set; }
        string BillingCode_11 { get; set; }
        string TimePeriodQualifier_12 { get; set; }
        string NumberofPeriods_13 { get; set; }
        string NumberofPeriods_14 { get; set; }
        string Rate_15 { get; set; }
        string NumberofPeriods_16 { get; set; }
        string Rate_17 { get; set; }
        string NumberofPeriods_18 { get; set; }
        string Rate_19 { get; set; }
        string NumberofPeriods_20 { get; set; }
        string Rate_21 { get; set; }
    }
    
    public interface I_DMA
    {
        
        string ReferenceIdentification_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string ApplicantTypeCode_05 { get; set; }
        string LicensingAgencyCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string LanguageCode_08 { get; set; }
        string StatusCode_09 { get; set; }
    }
    
    public interface I_DMG
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DateTimePeriod_02 { get; set; }
        string GenderCode_03 { get; set; }
        string MaritalStatusCode_04 { get; set; }
        string RaceorEthnicityCode_05 { get; set; }
        string CitizenshipStatusCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string BasisofVerificationCode_08 { get; set; }
        string Quantity_09 { get; set; }
    }
    
    public interface I_DMI
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string DataMaintenanceNumber_02 { get; set; }
        string Name_03 { get; set; }
        string AddressInformation_04 { get; set; }
        string AddressInformation_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string PostalCode_08 { get; set; }
        string CountryCode_09 { get; set; }
        string CommunicationNumberQualifier_10 { get; set; }
        string CommunicationNumber_11 { get; set; }
        string NoteIdentificationNumber_12 { get; set; }
    }
    
    public interface I_DN
    {
        
        string DateQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string DemandArea_03 { get; set; }
        string FinancialStatus_04 { get; set; }
    }
    
    public interface I_DN1
    {
        
        string Quantity_01 { get; set; }
        string Quantity_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_DN2
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ToothStatusCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
    }
    
    public interface I_DOS
    {
        
        string ContractTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string Percent_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_DP
    {
        
        string ActionCode_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Amount_03 { get; set; }
        string Amount_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string ConditionIndicator_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string Quantity_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string FreeformDescription_13 { get; set; }
        string Percent_14 { get; set; }
        string AllowanceorChargeTotalAmount_15 { get; set; }
        string YesNoConditionorResponseCode_16 { get; set; }
    }
    
    public interface I_DPN
    {
        
        string Number_01 { get; set; }
        string MaritalStatusCode_02 { get; set; }
        string EmploymentStatusCode_03 { get; set; }
        string Number_04 { get; set; }
    }
    
    public interface I_DR
    {
        
        string Date_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string DocketControlNumber_03 { get; set; }
        string DocketIdentification_04 { get; set; }
        string RevisionNumber_05 { get; set; }
        string DocketIdentification_06 { get; set; }
    }
    
    public interface I_DRT
    {
        
        string LoadEmptyStatusCode_01 { get; set; }
        string BilledRatedasQualifier_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
        string ChangeTypeCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_DSB
    {
        
        string DisabilityTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string OccupationCode_03 { get; set; }
        string WorkIntensityCode_04 { get; set; }
        string ProductOptionCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string MedicalCodeValue_08 { get; set; }
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
    
    public interface I_DTP
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
    }
    
    public interface I_DVI
    {
        
        string PriceIdentifierCode_01 { get; set; }
        string UnitPrice_02 { get; set; }
        string CurrencyCode_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string Name_06 { get; set; }
        string Quantity_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string StateorProvinceCode_09 { get; set; }
        string DateTimePeriodFormatQualifier_10 { get; set; }
        string DateTimePeriod_11 { get; set; }
        string LicensePlateType_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
    }
    
    public interface I_E01
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string ElectronicFormStandardsTypeCode_02 { get; set; }
        string VersionReleaseIndustryIdentifierCode_03 { get; set; }
        string FullorPartialIndicator_04 { get; set; }
    }
    
    public interface I_E03
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string LevelNumber_02 { get; set; }
        string SegmentIDCode_03 { get; set; }
        string EnvelopeIndicator_04 { get; set; }
        string RequirementDesignator_05 { get; set; }
        string MaximumUse_06 { get; set; }
        string NoteIdentificationNumber_07 { get; set; }
    }
    
    public interface I_E1
    {
        
        string NameCharacterFormat_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
    }
    
    public interface I_E10
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string TransactionSetIdentifierCode_02 { get; set; }
        string FunctionalIdentifierCode_03 { get; set; }
        string Description_04 { get; set; }
        string NoteIdentificationNumber_05 { get; set; }
    }
    
    public interface I_E13
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string PositioninSet_02 { get; set; }
        string SectionDesignator_03 { get; set; }
        string SegmentIDCode_04 { get; set; }
        string RequirementDesignator_05 { get; set; }
        string MaximumUse_06 { get; set; }
        string LoopName_07 { get; set; }
        string LoopRepeatCount_08 { get; set; }
        string LoopLevelNumber_09 { get; set; }
        string NoteIdentificationNumber_10 { get; set; }
    }
    
    public interface I_E20
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string SegmentIDCode_02 { get; set; }
        string Description_03 { get; set; }
        string NoteIdentificationNumber_04 { get; set; }
    }
    
    public interface I_E22
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string RelationCode_02 { get; set; }
        string PositioninSegment_03 { get; set; }
        string PositioninSegment_04 { get; set; }
        string PositioninSegment_05 { get; set; }
        string PositioninSegment_06 { get; set; }
        string PositioninSegment_07 { get; set; }
        string PositioninSegment_08 { get; set; }
        string PositioninSegment_09 { get; set; }
        string PositioninSegment_10 { get; set; }
        string PositioninSegment_11 { get; set; }
        string PositioninSegment_12 { get; set; }
    }
    
    public interface I_E24
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string PositioninSegment_02 { get; set; }
        string DataElementReferenceNumber_03 { get; set; }
        string RequirementDesignator_04 { get; set; }
        string DataElementType_05 { get; set; }
        string NoteIdentificationNumber_06 { get; set; }
    }
    
    public interface I_E26
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string PositioninComposite_02 { get; set; }
        string DataElementReferenceNumber_03 { get; set; }
        string RequirementDesignator_04 { get; set; }
        string DataElementType_05 { get; set; }
        string NoteIdentificationNumber_06 { get; set; }
    }
    
    public interface I_E30
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string DataElementReferenceNumber_02 { get; set; }
        string DataElementType_03 { get; set; }
        string MinimumLength_04 { get; set; }
        string MaximumLength_05 { get; set; }
        string Description_06 { get; set; }
        string NoteIdentificationNumber_07 { get; set; }
        string DataElementReferenceNumber_08 { get; set; }
        string CodeListReference_09 { get; set; }
    }
    
    public interface I_E34
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string CodeValue_02 { get; set; }
        string PartitionIndicator_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_E4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PostalCode_03 { get; set; }
        string CountryCode_04 { get; set; }
    }
    
    public interface I_E40
    {
        
        string MaintenanceOperationCode_01 { get; set; }
        string NoteIdentificationNumber_02 { get; set; }
        string ElectronicFormNoteReferenceCode_03 { get; set; }
        string AssignedIdentification_04 { get; set; }
    }
    
    public interface I_E5
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
    }
    
    public interface I_E6
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string IntermediateSwitchCarrier_06 { get; set; }
        string CommodityCode_07 { get; set; }
        string CarTypeCode_08 { get; set; }
        string EquipmentStatusCode_09 { get; set; }
    }
    
    public interface I_E8
    {
        
        string BlockIdentification_01 { get; set; }
        string MovementAuthorityCode_02 { get; set; }
    }
    
    public interface I_EA<T1>
        where T1 : I_C001
    {
        
        string EquipmentAttributeCode_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string Quantity_03 { get; set; }
    }
    
    public interface I_EB<T1>
        where T1 : I_C003
    {
        
        string EligibilityorBenefitInformation_01 { get; set; }
        string CoverageLevelCode_02 { get; set; }
        string ServiceTypeCode_03 { get; set; }
        string InsuranceTypeCode_04 { get; set; }
        string PlanCoverageDescription_05 { get; set; }
        string TimePeriodQualifier_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string Percent_08 { get; set; }
        string QuantityQualifier_09 { get; set; }
        string Quantity_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_13 { get; set; }
    }
    
    public interface I_EC
    {
        
        string EmploymentClassCode_01 { get; set; }
        string EmploymentClassCode_02 { get; set; }
        string EmploymentClassCode_03 { get; set; }
        string Percent_04 { get; set; }
        string InformationStatusCode_05 { get; set; }
        string OccupationCode_06 { get; set; }
    }
    
    public interface I_ED
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string LoadEmptyStatusCode_03 { get; set; }
        string CommodityCode_04 { get; set; }
        string LadingDescription_05 { get; set; }
        string WaybillNumber_06 { get; set; }
        string EquipmentNumber_07 { get; set; }
        string Date_08 { get; set; }
    }
    
    public interface I_EFI
    {
        
        string SecurityLevelCode_01 { get; set; }
        string FreeFormMessageText_02 { get; set; }
        string SecurityTechniqueCode_03 { get; set; }
        string VersionIdentifier_04 { get; set; }
        string ProgramIdentifier_05 { get; set; }
        string VersionIdentifier_06 { get; set; }
        string InterchangeFormat_07 { get; set; }
        string VersionIdentifier_08 { get; set; }
        string CompressionTechnique_09 { get; set; }
        string DrawingSheetSizeCode_10 { get; set; }
        string FileName_11 { get; set; }
        string BlockType_12 { get; set; }
        string RecordLength_13 { get; set; }
        string BlockLength_14 { get; set; }
        string VersionIdentifier_15 { get; set; }
        string FilterIDCode_16 { get; set; }
    }
    
    public interface I_EI
    {
        
        string Count_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string EquipmentOrientationCode_04 { get; set; }
        string Position_05 { get; set; }
        string TagStatusCode_06 { get; set; }
    }
    
    public interface I_EIA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Count_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
    }
    
    public interface I_EM
    {
        
        string WeightUnitCode_01 { get; set; }
        string Weight_02 { get; set; }
        string VolumeUnitQualifier_03 { get; set; }
        string Volume_04 { get; set; }
        string CountryCode_05 { get; set; }
        string ConstructionType_06 { get; set; }
        string Date_07 { get; set; }
    }
    
    public interface I_EMP
    {
        
        string Description_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string Description_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
    }
    
    public interface I_EMS
    {
        
        string Description_01 { get; set; }
        string EmploymentClassCode_02 { get; set; }
        string OccupationCode_03 { get; set; }
        string EmploymentStatusCode_04 { get; set; }
        string ReferenceIdentificationQualifier_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
    }
    
    public interface I_EMT
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string Description_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    public interface I_ENE
    {
        
        string CommunicationsEnvironmentCode_01 { get; set; }
        string CommunicationNumberQualifier_02 { get; set; }
        string CommunicationNumber_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
    }
    
    public interface I_ENR
    {
        
        string StatusReasonCode_01 { get; set; }
        string LevelofIndividualTestorCourseCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string MajorCourseofStudy_05 { get; set; }
        string RangeMinimum_06 { get; set; }
        string RangeMaximum_07 { get; set; }
        string AcademicGradePointAverage_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string DateTimePeriodFormatQualifier_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string YesNoConditionorResponseCode_14 { get; set; }
        string DateTimePeriodFormatQualifier_15 { get; set; }
        string DateTimePeriod_16 { get; set; }
        string DateTimePeriodFormatQualifier_17 { get; set; }
        string DateTimePeriod_18 { get; set; }
        string YesNoConditionorResponseCode_19 { get; set; }
        string YesNoConditionorResponseCode_20 { get; set; }
    }
    
    public interface I_ENT
    {
        
        string AssignedNumber_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string IdentificationCodeQualifier_06 { get; set; }
        string IdentificationCode_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_EQ<T1>
        where T1 : I_C003
    {
        
        string ServiceTypeCode_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string CoverageLevelCode_03 { get; set; }
        string InsuranceTypeCode_04 { get; set; }
    }
    
    public interface I_ER
    {
        
        string ActionCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string EventCode_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string DateTimeQualifier_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string InterchangeTrainIdentification_09 { get; set; }
        string Date_10 { get; set; }
        string LoadEmptyStatusCode_11 { get; set; }
    }
    
    public interface I_ERI
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string EntityRelationshipCode_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string EntityRelationshipCode_06 { get; set; }
        string EntityRelationshipCode_07 { get; set; }
        string EntityRelationshipCode_08 { get; set; }
        string HierarchyCode_09 { get; set; }
    }
    
    public interface I_ERP
    {
        
        string TransactionTypeCode_01 { get; set; }
        string StatusReasonCode_02 { get; set; }
        string ActionCode_03 { get; set; }
    }
    
    public interface I_ES
    {
        
        string BadOrderReasonCode_01 { get; set; }
        string HoldReasonCode_02 { get; set; }
        string AssociationofAmericanRailroadsCarGradeCode_03 { get; set; }
        string TimePeriodQualifier_04 { get; set; }
        string Quantity_05 { get; set; }
        string SwitchTypeCode_06 { get; set; }
    }
    
    public interface I_ESI
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string Time_04 { get; set; }
        string Quantity_05 { get; set; }
        string EmploymentStatusCode_06 { get; set; }
        string WorkIntensityCode_07 { get; set; }
        string ReasonStoppedWorkCode_08 { get; set; }
    }
    
    public interface I_ETD
    {
        
        string ExcessTransportationReasonCode_01 { get; set; }
        string ExcessTransportationResponsibilityCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReturnableContainerFreightPaymentResponsibilityCode_05 { get; set; }
    }
    
    public interface I_EXI<T1>
        where T1 : I_C040
    {
        
        T1 ReferenceIdentifier_01 { get; set; }
        string Priority_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string TimePeriodQualifier_05 { get; set; }
        string Quantity_06 { get; set; }
        string Description_07 { get; set; }
        string ActionCode_08 { get; set; }
    }
    
    public interface I_F01
    {
        
        string Date_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Amount_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string SupportingEvidenceCode_05 { get; set; }
        string CurrencyCode_06 { get; set; }
        string ExchangeRate_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string IdentificationCode_09 { get; set; }
    }
    
    public interface I_F02
    {
        
        string Date_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentificationQualifier_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string VesselCode_08 { get; set; }
        string VesselName_09 { get; set; }
    }
    
    public interface I_F04
    {
        
        string Weight_01 { get; set; }
        string WeightUnitCode_02 { get; set; }
        string WeightQualifier_03 { get; set; }
        string Weight_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string Volume_07 { get; set; }
        string VolumeUnitQualifier_08 { get; set; }
        string Volume_09 { get; set; }
        string VolumeUnitQualifier_10 { get; set; }
    }
    
    public interface I_F05
    {
        
        string ChargeAllowanceQualifier_01 { get; set; }
        string Amount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
    }
    
    public interface I_F07
    {
        
        string AssignedNumber_01 { get; set; }
        string Quantity_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string PartName_04 { get; set; }
        string Amount_05 { get; set; }
        string DamageAreaCode_06 { get; set; }
        string DamageTypeCode_07 { get; set; }
        string DamageSeverityCode_08 { get; set; }
        string LaborOperationIdentifier_09 { get; set; }
        string FreeformDescription_10 { get; set; }
        string LaborHours_11 { get; set; }
        string LaborHours_12 { get; set; }
        string TotalLaborCost_13 { get; set; }
        string TotalMiscellaneousCosts_14 { get; set; }
        string TotalRepairCost_15 { get; set; }
        string AuthorizationIdentification_16 { get; set; }
        string InspectionLocationTypeCode_17 { get; set; }
        string DamageAreaCode_18 { get; set; }
        string DamageTypeCode_19 { get; set; }
        string DamageSeverityCode_20 { get; set; }
        string DeclineAmendReasonCode_21 { get; set; }
        string ChargeAllowanceQualifier_22 { get; set; }
    }
    
    public interface I_F09
    {
        
        string Quantity_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string NatureofClaimCode_03 { get; set; }
        string Amount_04 { get; set; }
        string Amount_05 { get; set; }
        string Description_06 { get; set; }
        string LadingDescription_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
        string LadingLineItemNumber_12 { get; set; }
    }
    
    public interface I_F10
    {
        
        string Date_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
    }
    
    public interface I_F11
    {
        
        string Date_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Amount_04 { get; set; }
        string Amount_05 { get; set; }
        string StatusCode_06 { get; set; }
        string Date_07 { get; set; }
        string DeclineAmendReasonCode_08 { get; set; }
        string CurrencyCode_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
    }
    
    public interface I_F12
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string CreditDebitAdjustmentNumber_04 { get; set; }
        string Date_05 { get; set; }
        string LaborRate_06 { get; set; }
        string LaborRate_07 { get; set; }
        string DamageCodeQualifier_08 { get; set; }
    }
    
    public interface I_F13
    {
        
        string CheckNumber_01 { get; set; }
        string Date_02 { get; set; }
        string Amount_03 { get; set; }
        string MICRNumber_04 { get; set; }
        string Date_05 { get; set; }
        string CurrencyCode_06 { get; set; }
    }
    
    public interface I_F14
    {
        
        string AssignedNumber_01 { get; set; }
        string DeclineAmendReasonCode_02 { get; set; }
    }
    
    public interface I_F6X
    {
        
        string VehicleIdentificationNumber_01 { get; set; }
        string AutomotiveManufacturersCode_02 { get; set; }
        string DealerCode_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string InvoiceNumber_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
    }
    
    public interface I_F9
    {
        
        string FreightStationAccountingCode_01 { get; set; }
        string CityName_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string FreightStationAccountingCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string PostalCode_09 { get; set; }
        string StandardPointLocationCode_10 { get; set; }
        string PostalCode_11 { get; set; }
        string CountryCode_12 { get; set; }
    }
    
    public interface I_FA1
    {
        
        string AgencyQualifierCode_01 { get; set; }
        string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        string AllowanceorChargeIndicator_03 { get; set; }
    }
    
    public interface I_FA2
    {
        
        string BreakdownStructureDetailCode_01 { get; set; }
        string FinancialInformationCode_02 { get; set; }
    }
    
    public interface I_FAA<T1>
        where T1 : I_C001
    {
        
        string AccountNumberQualifier_01 { get; set; }
        string AccountNumber_02 { get; set; }
        string Date_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string TypeofAccountCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        T1 CompositeUnitofMeasure_07 { get; set; }
        string Quantity_08 { get; set; }
        string DateTimeQualifier_09 { get; set; }
        string DateTimePeriodFormatQualifier_10 { get; set; }
        string DateTimePeriod_11 { get; set; }
        string ReferenceIdentificationQualifier_12 { get; set; }
        string ReferenceIdentification_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
    }
    
    public interface I_FAC
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string EquipmentDescriptionCode_03 { get; set; }
        string DirectionFacing_04 { get; set; }
        string EquipmentStatusCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_FBB
    {
        
        string CountryCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Percent_07 { get; set; }
    }
    
    public interface I_FC
    {
        
        string ContributionCode_01 { get; set; }
        string Percent_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Number_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_FCL
    {
        
        string DeficiencyJudgmentCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string AmountQualifierCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string AdjustmentReasonCode_05 { get; set; }
    }
    
    public interface I_FDA
    {
        
        string PropertyOwnershipRightsCode_01 { get; set; }
        string Description_02 { get; set; }
        string TypeofRealEstateAssetCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Quantity_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
        string ConstructionType_07 { get; set; }
        string ConstructionType_08 { get; set; }
        string Description_09 { get; set; }
    }
    
    public interface I_FGS
    {
        
        string AssignedIdentification_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
    }
    
    public interface I_FH
    {
        
        string IndividualRelationshipCode_01 { get; set; }
        string QuantityQualifier_02 { get; set; }
        string Quantity_03 { get; set; }
        string CurrentHealthConditionCode_04 { get; set; }
    }
    
    public interface I_FIR
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TimeCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string Quantity_08 { get; set; }
        string CreditDebitFlagCode_09 { get; set; }
        string FinancialTransactionStatusCode_10 { get; set; }
        string CurrencyCode_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
    }
    
    public interface I_FIS
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
    }
    
    public interface I_FK
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CityName_04 { get; set; }
        string RuleJunctionCode_05 { get; set; }
        string PercentageDivision_06 { get; set; }
        string FactorAmount_07 { get; set; }
        string FactorAmount_08 { get; set; }
        string FactorAmount_09 { get; set; }
        string FactorAmount_10 { get; set; }
        string FactorAmount_11 { get; set; }
        string FactorAmount_12 { get; set; }
        string FactorAmount_13 { get; set; }
        string FactorAmount_14 { get; set; }
    }
    
    public interface I_FNA
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string DependencyStatusCode_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_FOB
    {
        
        string ShipmentMethodofPayment_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string Description_03 { get; set; }
        string TransportationTermsQualifierCode_04 { get; set; }
        string TransportationTermsCode_05 { get; set; }
        string LocationQualifier_06 { get; set; }
        string Description_07 { get; set; }
        string RiskofLossCode_08 { get; set; }
        string Description_09 { get; set; }
    }
    
    public interface I_FOS
    {
        
        string AcademicFieldofStudyLevelorTypeCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string Description_04 { get; set; }
        string Description_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
    }
    
    public interface I_FPT
    {
        
        string TypeofAccountCode_01 { get; set; }
        string Percent_02 { get; set; }
    }
    
    public interface I_FSA
    {
        
        string MaintenanceTypeCode_01 { get; set; }
        string FlexibleSpendingAccountSelectionCode_02 { get; set; }
        string MaintenanceReasonCode_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string FrequencyCode_05 { get; set; }
        string PlanCoverageDescription_06 { get; set; }
        string ProductOptionCode_07 { get; set; }
        string ProductOptionCode_08 { get; set; }
        string ProductOptionCode_09 { get; set; }
    }
    
    public interface I_FST
    {
        
        string Quantity_01 { get; set; }
        string ForecastQualifier_02 { get; set; }
        string ForecastTimingQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string DateTimeQualifier_06 { get; set; }
        string Time_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string PlanningScheduleTypeCode_10 { get; set; }
    }
    
    public interface I_FTH
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string TypeofResidenceCode_03 { get; set; }
        string TypeofAccountCode_04 { get; set; }
    }
    
    public interface I_G01
    {
        
        string Date_01 { get; set; }
        string InvoiceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string PurchaseOrderNumber_04 { get; set; }
        string VendorOrderNumber_05 { get; set; }
        string MasterReferenceLinkNumber_06 { get; set; }
        string LinkSequenceNumber_07 { get; set; }
        string TransactionTypeCode_08 { get; set; }
    }
    
    public interface I_G05
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string LadingQuantity_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
    }
    
    public interface I_G07
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string SealNumber_03 { get; set; }
        string SealNumber_04 { get; set; }
        string SealStatusCode_05 { get; set; }
        string Temperature_06 { get; set; }
    }
    
    public interface I_G08
    {
        
        string QuantityofPalletsReceived_01 { get; set; }
        string QuantityofPalletsReturned_02 { get; set; }
        string QuantityContested_03 { get; set; }
        string ReceivingConditionCode_04 { get; set; }
    }
    
    public interface I_G1
    {
        
        string ShipmentTypeCode_01 { get; set; }
        string SpecialIndicatorCode_02 { get; set; }
        string SpecialIndicatorCode_03 { get; set; }
    }
    
    public interface I_G11
    {
        
        string Level_01 { get; set; }
        string Category_02 { get; set; }
        string Category_03 { get; set; }
        string Category_04 { get; set; }
        string Category_05 { get; set; }
        string Category_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string FreeformDescription_10 { get; set; }
    }
    
    public interface I_G12
    {
        
        string Length_01 { get; set; }
        string Width_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string PromotionConditionCode_05 { get; set; }
        string PositionCode_06 { get; set; }
        string PositionCode_07 { get; set; }
    }
    
    public interface I_G13
    {
        
        string ClassofTradeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Number_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string AmountQualifierCode_06 { get; set; }
    }
    
    public interface I_G14
    {
        
        string ServicePromotionAllowanceorChargeCode_01 { get; set; }
        string ServicePromotionAllowanceorChargeCode_02 { get; set; }
    }
    
    public interface I_G15
    {
        
        string Quantity_01 { get; set; }
        string CouponDistributionMediaCode_02 { get; set; }
        string CouponTypeCode_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_G17
    {
        
        string QuantityInvoiced_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string ItemListCost_03 { get; set; }
        string UPCCaseCode_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string PriceBracketIdentifier_09 { get; set; }
        string NumberofUnitsShipped_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string PriceListNumber_12 { get; set; }
        string PriceListIssueNumber_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
    }
    
    public interface I_G18
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string Length_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
    }
    
    public interface I_G19
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string QuantityDifference_03 { get; set; }
        string ShipmentOrderStatusCode_04 { get; set; }
        string PriceReasonCode_05 { get; set; }
        string TermsExceptionCode_06 { get; set; }
        string UPCCaseCode_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
    }
    
    public interface I_G2
    {
        
        string SpecialIndicatorCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_G20
    {
        
        string Pack_01 { get; set; }
        string Size_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Weight_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Volume_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Color_08 { get; set; }
        string InnerPack_09 { get; set; }
    }
    
    public interface I_G21
    {
        
        string AuthorizeDeAuthorizeCode_01 { get; set; }
        string Date_02 { get; set; }
        string UPCEANConsumerPackageCode_03 { get; set; }
        string UPCCaseCode_04 { get; set; }
        string Pack_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string InnerPack_09 { get; set; }
    }
    
    public interface I_G22
    {
        
        string PrepricedOptionCode_01 { get; set; }
        string PriceNewSuggestedRetail_02 { get; set; }
        string MultiplePriceQuantity_03 { get; set; }
        string FreeFormMessage_04 { get; set; }
        string Date_05 { get; set; }
    }
    
    public interface I_G23
    {
        
        string TermsTypeCode_01 { get; set; }
        string TermsBasisDateCode_02 { get; set; }
        string TermsStartDate_03 { get; set; }
        string TermsDueDateQualifier_04 { get; set; }
        string TermsDiscountPercent_05 { get; set; }
        string TermsDiscountDueDate_06 { get; set; }
        string TermsDiscountDaysDue_07 { get; set; }
        string TermsNetDueDate_08 { get; set; }
        string TermsNetDays_09 { get; set; }
        string TermsDiscountAmount_10 { get; set; }
        string DiscountedAmountDue_11 { get; set; }
        string AmountSubjecttoTermsDiscount_12 { get; set; }
        string InstallmentTotalInvoiceAmountDue_13 { get; set; }
        string PercentofInvoicePayable_14 { get; set; }
        string FreeFormMessage_15 { get; set; }
        string InstallmentGroupIndicator_16 { get; set; }
    }
    
    public interface I_G24
    {
        
        string AllowanceorChargeNumber_01 { get; set; }
    }
    
    public interface I_G25
    {
        
        string ShipmentMethodofPayment_01 { get; set; }
        string FOBPointCode_02 { get; set; }
        string FOBPoint_03 { get; set; }
    }
    
    public interface I_G26
    {
        
        string PriceConditionCode_01 { get; set; }
        string DateQualifier_02 { get; set; }
        string Date_03 { get; set; }
        string QuantityBasis_04 { get; set; }
        string Quantity_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
    }
    
    public interface I_G27
    {
        
        string TransportationMethodTypeCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string Routing_05 { get; set; }
        string ShipmentOrderStatusCode_06 { get; set; }
    }
    
    public interface I_G28
    {
        
        string UPCCaseCode_01 { get; set; }
        string UPCEANConsumerPackageCode_02 { get; set; }
        string ProductServiceIDQualifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
    }
    
    public interface I_G29
    {
        
        string DisplayTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
    }
    
    public interface I_G3
    {
        
        string CompensationPaid_01 { get; set; }
        string TotalCompensationAmount_02 { get; set; }
        string Name_03 { get; set; }
        string BusinessTransactionStatus_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string CompensationQualifier_06 { get; set; }
    }
    
    public interface I_G30
    {
        
        string MarketingTypeCode_01 { get; set; }
        string Number_02 { get; set; }
    }
    
    public interface I_G31
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string OrderSizingFactor_07 { get; set; }
        string PriceBracketIdentifier_08 { get; set; }
        string PaymentMethodCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string Weight_11 { get; set; }
    }
    
    public interface I_G32
    {
        
        string Number_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_G33
    {
        
        string Amount_01 { get; set; }
    }
    
    public interface I_G35
    {
        
        string PromotionConditionCode_01 { get; set; }
        string CouponTypeCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
    }
    
    public interface I_G36
    {
        
        string PriceListNumber_01 { get; set; }
        string PriceListIssueNumber_02 { get; set; }
        string Date_03 { get; set; }
        string PriceConditionAppliesCode_04 { get; set; }
    }
    
    public interface I_G37
    {
        
        string LaborActivityCode_01 { get; set; }
        string Time_02 { get; set; }
        string Time_03 { get; set; }
    }
    
    public interface I_G38
    {
        
        string MonetaryAmount_01 { get; set; }
        string PaymentMethodCode_02 { get; set; }
        string ReturnsDispositionCode_03 { get; set; }
    }
    
    public interface I_G39
    {
        
        string UPCCaseCode_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string SpecialHandlingCode_04 { get; set; }
        string UnitWeight_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string WeightUnitCode_07 { get; set; }
        string Height_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string Width_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string Length_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string Volume_14 { get; set; }
        string UnitorBasisforMeasurementCode_15 { get; set; }
        string PalletBlockandTiers_16 { get; set; }
        string Pack_17 { get; set; }
        string Size_18 { get; set; }
        string UnitorBasisforMeasurementCode_19 { get; set; }
        string Color_20 { get; set; }
        string OrderSizingFactor_21 { get; set; }
        string AlternateTiersperPallet_22 { get; set; }
        string ProductServiceIDQualifier_23 { get; set; }
        string ProductServiceID_24 { get; set; }
        string WeightQualifier_25 { get; set; }
        string UnitWeight_26 { get; set; }
        string InnerPack_27 { get; set; }
        string PackagingCode_28 { get; set; }
    }
    
    public interface I_G4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string NameCharacterFormat_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string ScaleTypeCode_06 { get; set; }
    }
    
    public interface I_G40
    {
        
        string PriceBracketIdentifier_01 { get; set; }
        string ItemListCostNew_02 { get; set; }
        string ItemListCostOld_03 { get; set; }
        string FreeformDescription_04 { get; set; }
        string PriceNewSuggestedRetail_05 { get; set; }
        string PriceOldSuggestedRetail_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string PriceIdentifierCode_08 { get; set; }
        string Number_09 { get; set; }
    }
    
    public interface I_G42
    {
        
        string PromotionStatusCode_01 { get; set; }
        string AllowanceorChargeNumber_02 { get; set; }
        string TransactionTypeCode_03 { get; set; }
    }
    
    public interface I_G43
    {
        
        string MarketAreaCodeQualifier_01 { get; set; }
        string MarketAreaCodeIdentifier_02 { get; set; }
        string Description_03 { get; set; }
        string ClassofTradeCode_04 { get; set; }
    }
    
    public interface I_G45
    {
        
        string UPCCaseCode_01 { get; set; }
        string UPCEANConsumerPackageCode_02 { get; set; }
        string AllowanceorChargeNumber_03 { get; set; }
        string ExceptionNumber_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string Pack_07 { get; set; }
        string Size_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string DateQualifier_10 { get; set; }
        string Date_11 { get; set; }
        string InnerPack_12 { get; set; }
        string AllowanceorChargeRate_13 { get; set; }
    }
    
    public interface I_G46
    {
        
        string AllowanceorChargeCode_01 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_02 { get; set; }
        string AllowanceorChargeRate_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Amount_05 { get; set; }
        string AllowanceChargePercentQualifier_06 { get; set; }
        string Percent_07 { get; set; }
        string ExceptionNumber_08 { get; set; }
        string OptionNumber_09 { get; set; }
        string Description_10 { get; set; }
        string PriceIdentifierCode_11 { get; set; }
        string Number_12 { get; set; }
    }
    
    public interface I_G47
    {
        
        string Date_01 { get; set; }
        string StatementNumber_02 { get; set; }
    }
    
    public interface I_G48
    {
        
        string InvoiceNumber_01 { get; set; }
        string Date_02 { get; set; }
        string StoreNumber_03 { get; set; }
        string Date_04 { get; set; }
        string PurchaseOrderNumber_05 { get; set; }
        string VendorOrderNumber_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Date_09 { get; set; }
    }
    
    public interface I_G49
    {
        
        string Amount_01 { get; set; }
        string Amount_02 { get; set; }
        string Amount_03 { get; set; }
    }
    
    public interface I_G5
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string WaybillNumber_03 { get; set; }
        string Date_04 { get; set; }
        string Weight_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string TareWeight_07 { get; set; }
        string TareQualifierCode_08 { get; set; }
        string WeightAllowance_09 { get; set; }
        string WeightAllowanceTypeCode_10 { get; set; }
        string FreightRate_11 { get; set; }
        string RateValueQualifier_12 { get; set; }
        string InterchangeTrainIdentification_13 { get; set; }
        string CommodityCode_14 { get; set; }
        string ReferenceIdentificationQualifier_15 { get; set; }
        string ReferenceIdentification_16 { get; set; }
        string Date_17 { get; set; }
    }
    
    public interface I_G50
    {
        
        string OrderStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string TaxExemptCode_04 { get; set; }
        string MasterReferenceLinkNumber_05 { get; set; }
        string LinkSequenceNumber_06 { get; set; }
        string PurchaseOrderTypeCode_07 { get; set; }
    }
    
    public interface I_G51
    {
        
        string QuantityFree_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string QuantityMustPurchase_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string UPCCaseCode_05 { get; set; }
        string UPCEANConsumerPackageCode_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
    }
    
    public interface I_G53
    {
        
        string MaintenanceTypeCode_01 { get; set; }
    }
    
    public interface I_G54
    {
        
        string Quantity_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string UPCCaseCode_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string FreeformDescription_06 { get; set; }
    }
    
    public interface I_G55
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string ProductServiceIDQualifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string Height_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Width_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string Length_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Volume_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
        string Pack_13 { get; set; }
        string Size_14 { get; set; }
        string UnitorBasisforMeasurementCode_15 { get; set; }
        string CashRegisterItemDescription_16 { get; set; }
        string CashRegisterItemDescription_17 { get; set; }
        string CouponFamilyCode_18 { get; set; }
        string DatedProductNumberofDays_19 { get; set; }
        string DepositValue_20 { get; set; }
        string YesNoConditionorResponseCode_21 { get; set; }
        string Color_22 { get; set; }
        string UnitWeight_23 { get; set; }
        string WeightQualifier_24 { get; set; }
        string WeightUnitCode_25 { get; set; }
        string UnitWeight_26 { get; set; }
        string WeightQualifier_27 { get; set; }
        string WeightUnitCode_28 { get; set; }
        string ProductServiceIDQualifier_29 { get; set; }
        string ProductServiceID_30 { get; set; }
        string FreeformDescription_31 { get; set; }
        string InnerPack_32 { get; set; }
        string PackagingCode_33 { get; set; }
    }
    
    public interface I_G61
    {
        
        string ContactFunctionCode_01 { get; set; }
        string Name_02 { get; set; }
        string CommunicationNumberQualifier_03 { get; set; }
        string CommunicationNumber_04 { get; set; }
        string ContactInquiryReference_05 { get; set; }
    }
    
    public interface I_G62
    {
        
        string DateQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string TimeQualifier_03 { get; set; }
        string Time_04 { get; set; }
        string TimeCode_05 { get; set; }
    }
    
    public interface I_G63
    {
        
        string TimePeriodQualifier_01 { get; set; }
        string NumberofPeriods_02 { get; set; }
        string TariffApplicationCode_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_G66
    {
        
        string ShipmentMethodofPayment_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string PalletExchangeCode_03 { get; set; }
        string UnitLoadOptionCode_04 { get; set; }
        string Routing_05 { get; set; }
        string FOBPointCode_06 { get; set; }
        string FOBPoint_07 { get; set; }
    }
    
    public interface I_G68
    {
        
        string QuantityOrdered_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string ItemListCost_03 { get; set; }
        string UPCCaseCode_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string PriceBracketIdentifier_09 { get; set; }
        string QuantityCost_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string PriceListNumber_12 { get; set; }
        string PriceListIssueNumber_13 { get; set; }
        string PrePriceQuantityDesignator_14 { get; set; }
        string RetailPrePrice_15 { get; set; }
    }
    
    public interface I_G69
    {
        
        string FreeformDescription_01 { get; set; }
    }
    
    public interface I_G70
    {
        
        string Pack_01 { get; set; }
        string Size_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string PurchaseOrderInstructionCode_04 { get; set; }
        string PriceReasonCode_05 { get; set; }
        string TermsExceptionCode_06 { get; set; }
        string TaxExemptCode_07 { get; set; }
        string Color_08 { get; set; }
        string PalletBlockandTiers_09 { get; set; }
        string InnerPack_10 { get; set; }
    }
    
    public interface I_G72
    {
        
        string AllowanceorChargeCode_01 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_02 { get; set; }
        string AllowanceorChargeNumber_03 { get; set; }
        string ExceptionNumber_04 { get; set; }
        string AllowanceorChargeRate_05 { get; set; }
        string AllowanceorChargeQuantity_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string AllowanceorChargeTotalAmount_08 { get; set; }
        string Percent_09 { get; set; }
        string DollarBasisForPercent_10 { get; set; }
        string OptionNumber_11 { get; set; }
    }
    
    public interface I_G73
    {
        
        string FreeformDescription_01 { get; set; }
    }
    
    public interface I_G76
    {
        
        string QuantityOrdered_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string OrderSizingFactor_07 { get; set; }
        string Amount_08 { get; set; }
        string PriceBracketIdentifier_09 { get; set; }
        string PaymentMethodCode_10 { get; set; }
    }
    
    public interface I_G82
    {
        
        string CreditDebitFlagCode_01 { get; set; }
        string SuppliersDeliveryReturnNumber_02 { get; set; }
        string DUNSNumber_03 { get; set; }
        string ReceiversLocationNumber_04 { get; set; }
        string DUNSNumber_05 { get; set; }
        string SuppliersLocationNumber_06 { get; set; }
        string PhysicalDeliveryorReturnDate_07 { get; set; }
        string ProductOwnershipTransferDate_08 { get; set; }
        string PurchaseOrderNumber_09 { get; set; }
        string PurchaseOrderDate_10 { get; set; }
        string ShipmentMethodofPayment_11 { get; set; }
        string CODMethodofPaymentCode_12 { get; set; }
    }
    
    public interface I_G83
    {
        
        string DirectStoreDeliverySequenceNumber_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string UPCEANConsumerPackageCode_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string UPCCaseCode_07 { get; set; }
        string ItemListCost_08 { get; set; }
        string Pack_09 { get; set; }
        string CashRegisterItemDescription_10 { get; set; }
        string ProductServiceIDQualifier_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string InnerPack_13 { get; set; }
    }
    
    public interface I_G84
    {
        
        string Quantity_01 { get; set; }
        string TotalInvoiceAmount_02 { get; set; }
        string TotalDepositDollarAmount_03 { get; set; }
    }
    
    public interface I_G85
    {
        
        string IntegrityCheckValue_01 { get; set; }
    }
    
    public interface I_G86
    {
        
        string Signature_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    public interface I_G87
    {
        
        string InitiatorCode_01 { get; set; }
        string CreditDebitFlagCode_02 { get; set; }
        string SuppliersDeliveryReturnNumber_03 { get; set; }
        string IntegrityCheckValue_04 { get; set; }
        string AdjustmentNumber_05 { get; set; }
        string ReceiverDeliveryReturnNumber_06 { get; set; }
    }
    
    public interface I_G88
    {
        
        string PhysicalDeliveryorReturnDate_01 { get; set; }
        string ProductOwnershipTransferDate_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string PurchaseOrderDate_04 { get; set; }
        string ReceiversLocationNumber_05 { get; set; }
    }
    
    public interface I_G89
    {
        
        string DirectStoreDeliverySequenceNumber_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string UPCEANConsumerPackageCode_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string UPCCaseCode_07 { get; set; }
        string ItemListCost_08 { get; set; }
        string Pack_09 { get; set; }
        string InnerPack_10 { get; set; }
    }
    
    public interface I_G91
    {
        
        string ChangeTypeCode_01 { get; set; }
    }
    
    public interface I_G92
    {
        
        string ChangeorResponseTypeCode_01 { get; set; }
        string Date_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
    }
    
    public interface I_G93
    {
        
        string PriceBracketIdentifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string FreeformDescription_04 { get; set; }
        string TransportationMethodTypeCode_05 { get; set; }
        string PriceIdentifierCode_06 { get; set; }
        string ActionCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    public interface I_G94
    {
        
        string PromotionConditionQualifier_01 { get; set; }
        string OptionNumber_02 { get; set; }
    }
    
    public interface I_G95
    {
        
        string PromotionConditionQualifier_01 { get; set; }
        string PromotionConditionCode_02 { get; set; }
        string AssignedNumber_03 { get; set; }
        string Quantity_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Description_06 { get; set; }
        string Number_07 { get; set; }
    }
    
    public interface I_GA
    {
        
        string FumigatedCleanedIndicator_01 { get; set; }
        string CommodityCode_02 { get; set; }
        string InspectedWeighedIndicatorCode_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string Week_06 { get; set; }
        string UnloadTerminalElevatorCode_07 { get; set; }
        string Date_08 { get; set; }
        string Number_09 { get; set; }
        string MachineSeparableIndicatorCode_10 { get; set; }
        string CanadianWheatBoardCWBMarketingClassCode_11 { get; set; }
        string CanadianWheatBoardCWBMarketingClassTypeCode_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
        string LocationIdentifier_14 { get; set; }
        string StateorProvinceCode_15 { get; set; }
        string PercentQualifier_16 { get; set; }
        string Percent_17 { get; set; }
    }
    
    public interface I_GDP<T1>
        where T1 : I_C001
    {
        
        string MeasurementValue_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string RouteofAdministration_03 { get; set; }
        string TestPeriodorIntervalValue_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
        string TestPeriodorIntervalValue_06 { get; set; }
        string UnitofTimePeriodorInterval_07 { get; set; }
    }
    
    public interface I_GF
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ContractNumber_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string ReferenceIdentificationQualifier_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReleaseNumber_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_GH
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string NumberofLineItems_03 { get; set; }
        string RevisionNumber_04 { get; set; }
    }
    
    public interface I_GID
    {
        
        string Name_01 { get; set; }
        string GenderCode_02 { get; set; }
        string Name_03 { get; set; }
    }
    
    public interface I_GR
    {
        
        string LoanTypeCode_01 { get; set; }
        string LoanStatusCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string DateTimePeriodFormatQualifier_07 { get; set; }
        string DateTimePeriod_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string InterestRate_10 { get; set; }
        string LoanRateTypeCode_11 { get; set; }
        string InterestRate_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
        string DateTimePeriodFormatQualifier_15 { get; set; }
        string DateTimePeriod_16 { get; set; }
        string MonetaryAmount_17 { get; set; }
        string ReferenceIdentification_18 { get; set; }
        string YesNoConditionorResponseCode_19 { get; set; }
        string Quantity_20 { get; set; }
        string YesNoConditionorResponseCode_21 { get; set; }
    }
    
    public interface I_GR2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string CityName_04 { get; set; }
        string StateorProvinceCode_05 { get; set; }
        string CountryCode_06 { get; set; }
        string InterchangeTrainIdentification_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string StandardCarrierAlphaCode_11 { get; set; }
        string InterchangeTrainIdentification_12 { get; set; }
    }
    
    public interface I_GR4
    {
        
        string ConfigurationTypeCode_01 { get; set; }
        string EquipmentDescriptionCode_02 { get; set; }
        string EquipmentUseCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string EquipmentInitial_05 { get; set; }
        string EquipmentNumber_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
        string CityName_09 { get; set; }
        string StateorProvinceCode_10 { get; set; }
        string CountryCode_11 { get; set; }
    }
    
    public interface I_GR5
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SurfaceLayerPositionCode_02 { get; set; }
        string MeasurementValue_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string StatusReasonCode_05 { get; set; }
    }
    
    public interface I_GRI
    {
        
        string ReportedDataIDCode_01 { get; set; }
        string ReportedDataResponse_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string Quantity_04 { get; set; }
        string AmountQualifierCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string PercentQualifier_07 { get; set; }
        string Percent_08 { get; set; }
        string DateTimeQualifier_09 { get; set; }
        string Date_10 { get; set; }
        string Description_11 { get; set; }
    }
    
    public interface I_GRP
    {
        
        string Number_01 { get; set; }
        string UnitDoseCode_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_GY
    {
        
        string GeographyQualifierCode_01 { get; set; }
        string CommodityGeographicLogicalConnectorCode_02 { get; set; }
        string LocationQualifier_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string ChangeTypeCode_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string DocketControlNumber_10 { get; set; }
        string DocketIdentification_11 { get; set; }
        string GroupTitle_12 { get; set; }
        string StateorProvinceCode_13 { get; set; }
        string CityName_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    public interface I_H1
    {
        
        string HazardousMaterialCode_01 { get; set; }
        string HazardousMaterialClassCode_02 { get; set; }
        string HazardousMaterialCodeQualifier_03 { get; set; }
        string HazardousMaterialDescription_04 { get; set; }
        string HazardousMaterialContact_05 { get; set; }
        string HazardousMaterialsPage_06 { get; set; }
        string FlashpointTemperature_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string PackingGroupCode_09 { get; set; }
    }
    
    public interface I_H2
    {
        
        string HazardousMaterialDescription_01 { get; set; }
        string HazardousMaterialClassification_02 { get; set; }
    }
    
    public interface I_H3
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialHandlingDescription_02 { get; set; }
        string ProtectiveServiceCode_03 { get; set; }
        string VentInstructionCode_04 { get; set; }
        string TariffApplicationCode_05 { get; set; }
    }
    
    public interface I_H5
    {
        
        string CarServiceOrderCode_01 { get; set; }
        string CityName_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
    }
    
    public interface I_H6
    {
        
        string SpecialServicesCode_01 { get; set; }
        string SpecialServicesCode_02 { get; set; }
        string QuantityofPalletsShipped_03 { get; set; }
        string PalletExchangeCode_04 { get; set; }
        string Weight_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string PickuporDeliveryCode_07 { get; set; }
    }
    
    public interface I_HC
    {
        
        string DiseaseConditionTypeCode_01 { get; set; }
        string MedicalTreatmentTypeCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_HCP
    {
        
        string PricingMethodology_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Rate_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
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
    
    public interface I_HCR
    {
        
        string ActionCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string RejectReasonCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
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
        string YesNoConditionorResponseCode_09 { get; set; }
        string DrugHouseCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
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
    
    public interface I_HL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
    }
    
    public interface I_HLH
    {
        
        string HealthRelatedCode_01 { get; set; }
        string Height_02 { get; set; }
        string Weight_03 { get; set; }
        string Weight_04 { get; set; }
        string Description_05 { get; set; }
        string CurrentHealthConditionCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_HS
    {
        
        string HealthScreeningTypeCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string StatusReasonCode_04 { get; set; }
    }
    
    public interface I_HSD
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string SampleSelectionModulus_04 { get; set; }
        string TimePeriodQualifier_05 { get; set; }
        string NumberofPeriods_06 { get; set; }
        string ShipDeliveryorCalendarPatternCode_07 { get; set; }
        string ShipDeliveryPatternTimeCode_08 { get; set; }
    }
    
    public interface I_IC
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string TareWeight_03 { get; set; }
        string TareQualifierCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string EquipmentLength_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string ChassisType_08 { get; set; }
    }
    
    public interface I_ICH
    {
        
        string Count_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string GenderCode_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string OccupationCode_08 { get; set; }
        string IndividualRelationshipCode_09 { get; set; }
        string Description_10 { get; set; }
        string Description_11 { get; set; }
        string PoliticalPartyAffiliationCode_12 { get; set; }
    }
    
    public interface I_ICM
    {
        
        string FrequencyCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Quantity_03 { get; set; }
        string LocationIdentifier_04 { get; set; }
        string SalaryGrade_05 { get; set; }
        string CurrencyCode_06 { get; set; }
    }
    
    public interface I_ID
    {
        
        string DamageAreaCode_01 { get; set; }
        string DamageTypeCode_02 { get; set; }
        string DamageSeverityCode_03 { get; set; }
    }
    
    public interface I_ID1
    {
        
        string UPCEANConsumerPackageCode_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string FreeformDescription_04 { get; set; }
        string Size_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Height_07 { get; set; }
        string Width_08 { get; set; }
        string ItemDepth_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Weight_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
        string CategoryReferenceCode_13 { get; set; }
        string Category_14 { get; set; }
        string Subcategory_15 { get; set; }
        string UnitorBasisforMeasurementCode_16 { get; set; }
        string Pack_17 { get; set; }
        string InnerPack_18 { get; set; }
        string DateQualifier_19 { get; set; }
        string Date_20 { get; set; }
        string NestingCode_21 { get; set; }
        string Nesting_22 { get; set; }
        string UnitorBasisforMeasurementCode_23 { get; set; }
        string PegCode_24 { get; set; }
        string UnitorBasisforMeasurementCode_25 { get; set; }
        string ReferenceIdentification_26 { get; set; }
        string XPeg_27 { get; set; }
        string YPeg_28 { get; set; }
        string ReferenceIdentification_29 { get; set; }
        string XPeg_30 { get; set; }
        string YPeg_31 { get; set; }
        string ReferenceIdentification_32 { get; set; }
        string XPeg_33 { get; set; }
        string YPeg_34 { get; set; }
    }
    
    public interface I_ID2
    {
        
        string CashRegisterItemDescription_01 { get; set; }
        string CashRegisterItemDescription_02 { get; set; }
        string SpaceManagementReferenceCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Name_05 { get; set; }
        string Name_06 { get; set; }
        string SpaceManagementReferenceCode_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_ID3
    {
        
        string UPCCaseCode_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string Pack_04 { get; set; }
        string InnerPack_05 { get; set; }
        string Height_06 { get; set; }
        string Width_07 { get; set; }
        string ItemDepth_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string Weight_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string Volume_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string TrayCount_14 { get; set; }
        string Height_15 { get; set; }
        string Width_16 { get; set; }
        string ItemDepth_17 { get; set; }
        string UnitorBasisforMeasurementCode_18 { get; set; }
        string NestingCode_19 { get; set; }
        string Nesting_20 { get; set; }
        string UnitorBasisforMeasurementCode_21 { get; set; }
    }
    
    public interface I_ID4
    {
        
        string DeclaredValue_01 { get; set; }
        string PickuporDeliveryCode_02 { get; set; }
        string WeightQualifier_03 { get; set; }
        string Weight_04 { get; set; }
        string VolumeUnitQualifier_05 { get; set; }
        string Volume_06 { get; set; }
        string Number_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_IDB
    {
        
        string LoanTypeCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string InterestRate_04 { get; set; }
        string LoanRateTypeCode_05 { get; set; }
    }
    
    public interface I_IDC
    {
        
        string PlanCoverageDescription_01 { get; set; }
        string IdentificationCardTypeCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string ActionCode_04 { get; set; }
    }
    
    public interface I_IGI
    {
        
        string InsurerGuarantorTypeCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
        string MortgageInsuranceCoverageTypeCode_04 { get; set; }
        string InsurerCoverageIndicatorCode_05 { get; set; }
        string PayerResponsibilitySequenceNumberCode_06 { get; set; }
    }
    
    public interface I_III<T1>
        where T1 : I_C001
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string CodeCategory_03 { get; set; }
        string FreeFormMessageText_04 { get; set; }
        string Quantity_05 { get; set; }
        T1 CompositeUnitofMeasure_06 { get; set; }
        string SurfaceLayerPositionCode_07 { get; set; }
        string SurfaceLayerPositionCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public interface I_IIS
    {
        
        string ReportedStartSegmentIDI_01 { get; set; }
        string ReportedControlNumberI_02 { get; set; }
        string ReportedDateI_03 { get; set; }
        string ReportedTimeI_04 { get; set; }
        string ReportedInterchangeSenderIDQualifierI_05 { get; set; }
        string ReportedSenderIDI_06 { get; set; }
        string ReportedInterchangeReceiverIDQualifierI_07 { get; set; }
        string ReportedReceiverIDI_08 { get; set; }
        string FirstReferenceIDQualifierI_09 { get; set; }
        string FirstReferenceIDI_10 { get; set; }
        string SecondReferenceIDQualifierI_11 { get; set; }
        string SecondReferenceIDI_12 { get; set; }
        string MessageDirectionCodeI_13 { get; set; }
        string ReportedGrouporTransactionIdentifierI_14 { get; set; }
    }
    
    public interface I_IM
    {
        
        string WaterMovementCode_01 { get; set; }
        string SpecialHandlingCode_02 { get; set; }
        string InlandTransportationCode_03 { get; set; }
    }
    
    public interface I_IMA
    {
        
        string MovementAuthorityCode_01 { get; set; }
        string SpecialHandlingDescription_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string TariffApplicationCode_04 { get; set; }
        string TariffApplicationCode_05 { get; set; }
    }
    
    public interface I_IMM
    {
        
        string ImmunizationTypeCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string ImmunizationStatusCode_04 { get; set; }
        string ReportTypeCode_05 { get; set; }
    }
    
    public interface I_IMP
    {
        
        string PartofBodyCode_01 { get; set; }
        string Percent_02 { get; set; }
    }
    
    public interface I_IN1
    {
        
        string EntityTypeQualifier_01 { get; set; }
        string NameTypeCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string IndividualRelationshipCode_06 { get; set; }
        string LevelofIndividualTestorCourseCode_07 { get; set; }
    }
    
    public interface I_IN2
    {
        
        string NameComponentQualifier_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    public interface I_INC<T1>
        where T1 : I_C001
    {
        
        string TermsTypeCode_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
    }
    
    public interface I_IND
    {
        
        string CountryCode_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string CountyDesignator_03 { get; set; }
        string CityName_04 { get; set; }
        string LanguageCode_05 { get; set; }
        string LanguageProficiencyIndicator_06 { get; set; }
        string LanguageCode_07 { get; set; }
        string LanguageCode_08 { get; set; }
        string IdentificationCodeQualifier_09 { get; set; }
        string IdentificationCode_10 { get; set; }
        string IdentificationCodeQualifier_11 { get; set; }
        string IdentificationCode_12 { get; set; }
    }
    
    public interface I_INQ
    {
        
        string ResultsCode_01 { get; set; }
        string TypeofAccountCode_02 { get; set; }
    }
    
    public interface I_INR
    {
        
        string CodeCategory_01 { get; set; }
        string InformationType_02 { get; set; }
        string InformationStatusCode_03 { get; set; }
    }
    
    public interface I_INS
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string IndividualRelationshipCode_02 { get; set; }
        string MaintenanceTypeCode_03 { get; set; }
        string MaintenanceReasonCode_04 { get; set; }
        string BenefitStatusCode_05 { get; set; }
        string MedicarePlanCode_06 { get; set; }
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
        string Number_17 { get; set; }
    }
    
    public interface I_INT
    {
        
        string InterestTypeCode_01 { get; set; }
        string InterestRate_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string Quantity_05 { get; set; }
    }
    
    public interface I_INV
    {
        
        string Description_01 { get; set; }
        string Percent_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Quantity_04 { get; set; }
        string StateorProvinceCode_05 { get; set; }
        string Description_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
    }
    
    public interface I_INX<T1>
        where T1 : I_C036
    {
        
        string IndexQualifier_01 { get; set; }
        T1 IndexIdentification_02 { get; set; }
    }
    
    public interface I_IRA
    {
        
        string InvestorReportingActionCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
    }
    
    public interface I_IRP
    {
        
        string ReportTypeCodeI_01 { get; set; }
        string ReportIdentifierI_02 { get; set; }
        string ReportIncrementalIndicatorCodeI_03 { get; set; }
        string MessageDirectionCodeI_04 { get; set; }
        string ReportStatusLevelCodeI_05 { get; set; }
        string ReportLevelofDetailCodeI_06 { get; set; }
        string ShipDeliveryorCalendarPatternCode_07 { get; set; }
    }
    
    public interface I_IS1
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string LoadEmptyStatusCode_04 { get; set; }
        string RetripReasonCode_05 { get; set; }
        string CarTypeCode_06 { get; set; }
        string IndustryCode_07 { get; set; }
    }
    
    public interface I_IS2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string EventCode_02 { get; set; }
        string AccomplishCode_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string Date_05 { get; set; }
        string Time_06 { get; set; }
        string TimeCode_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string InterchangeTrainIdentification_09 { get; set; }
        string Date_10 { get; set; }
        string BlockIdentification_11 { get; set; }
        string Date_12 { get; set; }
        string Time_13 { get; set; }
        string Date_14 { get; set; }
        string Time_15 { get; set; }
        string CityName_16 { get; set; }
        string StateorProvinceCode_17 { get; set; }
    }
    
    public interface I_ISC
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string EventCode_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string Time_06 { get; set; }
        string NumberofDays_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string InterchangeTrainIdentification_09 { get; set; }
        string BlockIdentification_10 { get; set; }
    }
    
    public interface I_ISD
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string EventCode_03 { get; set; }
        string Time_04 { get; set; }
    }
    
    public interface I_ISR
    {
        
        string ShipmentOrderStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string StatusReasonCode_03 { get; set; }
    }
    
    public interface I_ISS
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string Weight_08 { get; set; }
    }
    
    public interface I_IT1
    {
        
        string AssignedIdentification_01 { get; set; }
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
    
    public interface I_IT3
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string ShipmentOrderStatusCode_03 { get; set; }
        string QuantityDifference_04 { get; set; }
        string ChangeReasonCode_05 { get; set; }
    }
    
    public interface I_IT8
    {
        
        string SalesRequirementCode_01 { get; set; }
        string ActionCode_02 { get; set; }
        string Amount_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string Date_05 { get; set; }
        string AgencyQualifierCode_06 { get; set; }
        string ProductServiceSubstitutionCode_07 { get; set; }
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
    }
    
    public interface I_ITA
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string SpecialServicesCode_03 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        string AllowanceorChargeNumber_05 { get; set; }
        string AllowanceorChargeRate_06 { get; set; }
        string AllowanceorChargeTotalAmount_07 { get; set; }
        string AllowanceChargePercentQualifier_08 { get; set; }
        string Percent_09 { get; set; }
        string Quantity_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string Description_13 { get; set; }
        string SpecialChargeorAllowanceCode_14 { get; set; }
        string SourceSubqualifier_15 { get; set; }
        string RelationshipCode_16 { get; set; }
        string UnitorBasisforMeasurementCode_17 { get; set; }
    }
    
    public interface I_ITC
    {
        
        string InformationRequestResultCode_01 { get; set; }
        string InformationType_02 { get; set; }
        string InformationStatusCode_03 { get; set; }
        string ActionCode_04 { get; set; }
        string FinancialInformationTypeCode_05 { get; set; }
        string ConsolidationCode_06 { get; set; }
        string ConditionIndicator_07 { get; set; }
        string FinancialStatementFormatCode_08 { get; set; }
        string FreeFormMessage_09 { get; set; }
        string UnitofTimePeriodorInterval_10 { get; set; }
        string Description_11 { get; set; }
        string SourceofDisclosureCode_12 { get; set; }
    }
    
    public interface I_ITD
    {
        
        string TermsTypeCode_01 { get; set; }
        string TermsBasisDateCode_02 { get; set; }
        string TermsDiscountPercent_03 { get; set; }
        string TermsDiscountDueDate_04 { get; set; }
        string TermsDiscountDaysDue_05 { get; set; }
        string TermsNetDueDate_06 { get; set; }
        string TermsNetDays_07 { get; set; }
        string TermsDiscountAmount_08 { get; set; }
        string TermsDeferredDueDate_09 { get; set; }
        string DeferredAmountDue_10 { get; set; }
        string PercentofInvoicePayable_11 { get; set; }
        string Description_12 { get; set; }
        string DayofMonth_13 { get; set; }
        string PaymentMethodCode_14 { get; set; }
        string Percent_15 { get; set; }
    }
    
    public interface I_IV1
    {
        
        string VolumeUnitQualifier_01 { get; set; }
        string Volume_02 { get; set; }
        string Number_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
    }
    
    public interface I_JCT
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string FreightStationAccountingCode_03 { get; set; }
        string FreightStationAccountingCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string InterchangeTypeCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_JID<T1>
        where T1 : I_C001
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Quantity_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string ProductServiceConditionCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
    }
    
    public interface I_JIL
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string Date_06 { get; set; }
        string AmountQualifierCode_07 { get; set; }
    }
    
    public interface I_JIT
    {
        
        string Quantity_01 { get; set; }
        string Time_02 { get; set; }
    }
    
    public interface I_JL
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string NameCharacterFormat_04 { get; set; }
    }
    
    public interface I_JS
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RailJunctionSettlementRoleCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string RailJunctionSettlementRoleCode_04 { get; set; }
    }
    
    public interface I_K1
    {
        
        string FreeFormMessage_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
    }
    
    public interface I_K2
    {
        
        string Description_01 { get; set; }
    }
    
    public interface I_K3<T1>
        where T1 : I_C001
    {
        
        string FixedFormatInformation_01 { get; set; }
        string RecordFormatCode_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public interface I_L0
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string BilledRatedasQuantity_02 { get; set; }
        string BilledRatedasQualifier_03 { get; set; }
        string Weight_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string Volume_06 { get; set; }
        string VolumeUnitQualifier_07 { get; set; }
        string LadingQuantity_08 { get; set; }
        string PackagingFormCode_09 { get; set; }
        string DunnageDescription_10 { get; set; }
        string WeightUnitCode_11 { get; set; }
        string TypeofServiceCode_12 { get; set; }
        string Quantity_13 { get; set; }
        string PackagingFormCode_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    public interface I_L1
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string FreightRate_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string Charge_04 { get; set; }
        string Advances_05 { get; set; }
        string PrepaidAmount_06 { get; set; }
        string RateCombinationPointCode_07 { get; set; }
        string SpecialChargeorAllowanceCode_08 { get; set; }
        string RateClassCode_09 { get; set; }
        string EntitlementCode_10 { get; set; }
        string ChargeMethodofPayment_11 { get; set; }
        string SpecialChargeDescription_12 { get; set; }
        string TariffApplicationCode_13 { get; set; }
        string DeclaredValue_14 { get; set; }
        string RateValueQualifier_15 { get; set; }
        string LadingLiabilityCode_16 { get; set; }
        string BilledRatedasQuantity_17 { get; set; }
        string BilledRatedasQualifier_18 { get; set; }
        string Percent_19 { get; set; }
        string CurrencyCode_20 { get; set; }
        string Amount_21 { get; set; }
    }
    
    public interface I_L10
    {
        
        string Weight_01 { get; set; }
        string WeightQualifier_02 { get; set; }
        string WeightUnitCode_03 { get; set; }
    }
    
    public interface I_L11
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string Description_03 { get; set; }
    }
    
    public interface I_L12
    {
        
        string LadingDescriptionQualifier_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_L13
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string AmountQualifierCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string AssignedNumber_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string Quantity_09 { get; set; }
        string WeightUnitCode_10 { get; set; }
        string Weight_11 { get; set; }
        string FreeformDescription_12 { get; set; }
        string ExportExceptionCode_13 { get; set; }
        string ActionCode_14 { get; set; }
        string HarborMaintenanceFeeHMFExemptionCode_15 { get; set; }
        string Amount_16 { get; set; }
    }
    
    public interface I_L1A
    {
        
        string Amount_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
    }
    
    public interface I_L3
    {
        
        string Weight_01 { get; set; }
        string WeightQualifier_02 { get; set; }
        string FreightRate_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string Charge_05 { get; set; }
        string Advances_06 { get; set; }
        string PrepaidAmount_07 { get; set; }
        string SpecialChargeorAllowanceCode_08 { get; set; }
        string Volume_09 { get; set; }
        string VolumeUnitQualifier_10 { get; set; }
        string LadingQuantity_11 { get; set; }
        string WeightUnitCode_12 { get; set; }
        string TariffNumber_13 { get; set; }
        string DeclaredValue_14 { get; set; }
        string RateValueQualifier_15 { get; set; }
    }
    
    public interface I_L4
    {
        
        string Length_01 { get; set; }
        string Width_02 { get; set; }
        string Height_03 { get; set; }
        string MeasurementUnitQualifier_04 { get; set; }
        string Quantity_05 { get; set; }
        string IndustryCode_06 { get; set; }
    }
    
    public interface I_L5
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string LadingDescription_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string CommodityCodeQualifier_04 { get; set; }
        string PackagingCode_05 { get; set; }
        string MarksandNumbers_06 { get; set; }
        string MarksandNumbersQualifier_07 { get; set; }
        string CommodityCodeQualifier_08 { get; set; }
        string CommodityCode_09 { get; set; }
        string CompartmentIDCode_10 { get; set; }
    }
    
    public interface I_L7
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string TariffAgencyCode_02 { get; set; }
        string TariffNumber_03 { get; set; }
        string TariffSection_04 { get; set; }
        string TariffItemNumber_05 { get; set; }
        string TariffItemPart_06 { get; set; }
        string FreightClassCode_07 { get; set; }
        string TariffSupplementIdentifier_08 { get; set; }
        string ExParte_09 { get; set; }
        string Date_10 { get; set; }
        string RateBasisNumber_11 { get; set; }
        string TariffColumn_12 { get; set; }
        string TariffDistance_13 { get; set; }
        string DistanceQualifier_14 { get; set; }
        string CityName_15 { get; set; }
        string StateorProvinceCode_16 { get; set; }
    }
    
    public interface I_L7A
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string RegulatoryAgencyCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string IssuingCarrierIdentifier_04 { get; set; }
        string ContractNumber_05 { get; set; }
        string ContractSuffix_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
    }
    
    public interface I_L8
    {
        
        string BilledRatedasQuantity_01 { get; set; }
        string BilledRatedasQualifier_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string FreightRate_06 { get; set; }
        string RateValueQualifier_07 { get; set; }
        string Amount_08 { get; set; }
        string SpecialChargeorAllowanceCode_09 { get; set; }
        string SpecialChargeDescription_10 { get; set; }
        string ChargeMethodofPayment_11 { get; set; }
    }
    
    public interface I_L9
    {
        
        string SpecialChargeorAllowanceCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
    }
    
    public interface I_LAD
    {
        
        string PackagingFormCode_01 { get; set; }
        string LadingQuantity_02 { get; set; }
        string WeightUnitCode_03 { get; set; }
        string UnitWeight_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string Weight_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string ProductServiceIDQualifier_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string ProductServiceIDQualifier_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string LadingDescription_13 { get; set; }
    }
    
    public interface I_LC
    {
        
        string MaintenanceTypeCode_01 { get; set; }
        string MaintenanceReasonCode_02 { get; set; }
        string InsuranceLineCode_03 { get; set; }
        string PlanCoverageDescription_04 { get; set; }
        string Quantity_05 { get; set; }
        string ProductOptionCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_LC1
    {
        
        string NumberofShipments_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Number_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string NumberofShipments_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string LaneRanking_08 { get; set; }
        string FreightRate_09 { get; set; }
        string FreightRate_10 { get; set; }
        string RateValueQualifier_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_LCD
    {
        
        string AssignedIdentification_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string ActionCode_03 { get; set; }
        string Date_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
    }
    
    public interface I_LCT
    {
        
        string ReferenceIdentification_01 { get; set; }
        string PackagingFormCode_02 { get; set; }
        string Description_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string UnitWeight_05 { get; set; }
        string MeasurementUnitQualifier_06 { get; set; }
        string Length_07 { get; set; }
        string Width_08 { get; set; }
        string Height_09 { get; set; }
        string VolumeUnitQualifier_10 { get; set; }
        string Volume_11 { get; set; }
        string PalletExchangeCode_12 { get; set; }
    }
    
    public interface I_LDT
    {
        
        string LeadTimeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitofTimePeriodorInterval_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_LE
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LEP
    {
        
        string EPAWasteStreamNumberCode_01 { get; set; }
        string WasteCharacteristicsCode_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_LEQ
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Year_03 { get; set; }
        string MonthoftheYearCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string Date_08 { get; set; }
        string ExchangeRate_09 { get; set; }
    }
    
    public interface I_LET
    {
        
        string SurfaceLayerPositionCode_01 { get; set; }
        string EquipmentDescriptionCode_02 { get; set; }
        string ShapeCode_03 { get; set; }
        string CarTypeCode_04 { get; set; }
    }
    
    public interface I_LFG
    {
        
        string Description_01 { get; set; }
        string HazardousClassification_02 { get; set; }
        string UNNAIdentificationCode_03 { get; set; }
        string HazardousPlacardNotation_04 { get; set; }
        string PackingGroupCode_05 { get; set; }
        string HazardousMaterialRegulationsExceptionCode_06 { get; set; }
    }
    
    public interface I_LFH
    {
        
        string HazardousMaterialShipmentInformationQualifier_01 { get; set; }
        string HazardousMaterialShipmentInformation_02 { get; set; }
        string HazardousMaterialShipmentInformation_03 { get; set; }
        string HazardZoneCode_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
    }
    
    public interface I_LFI
    {
        
        string StandardPointLocationCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string EquipmentStatusCode_04 { get; set; }
        string IndustryCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
        string IndustryCode_07 { get; set; }
        string InterchangeTrainIdentification_08 { get; set; }
    }
    
    public interface I_LH
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string HazardousMnemonicCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReportableQuantityCode_05 { get; set; }
        string LimitedQuantityIndicationCode_06 { get; set; }
    }
    
    public interface I_LH1
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string LadingQuantity_02 { get; set; }
        string UNNAIdentificationCode_03 { get; set; }
        string HazardousMaterialsPage_04 { get; set; }
        string CommodityCode_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string CompartmentIDCode_08 { get; set; }
        string ResidueIndicatorCode_09 { get; set; }
        string PackingGroupCode_10 { get; set; }
        string InterimHazardousMaterialRegulatoryNumber_11 { get; set; }
    }
    
    public interface I_LH2
    {
        
        string HazardousClassification_01 { get; set; }
        string HazardousClassQualifier_02 { get; set; }
        string HazardousPlacardNotation_03 { get; set; }
        string HazardousEndorsement_04 { get; set; }
        string ReportableQuantityCode_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Temperature_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string Temperature_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Temperature_11 { get; set; }
    }
    
    public interface I_LH3
    {
        
        string HazardousMaterialShippingName_01 { get; set; }
        string HazardousMaterialShippingNameQualifier_02 { get; set; }
        string NOSIndicatorCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    public interface I_LH4
    {
        
        string EmergencyResponsePlanNumber_01 { get; set; }
        string CommunicationNumber_02 { get; set; }
        string PackingGroupCode_03 { get; set; }
        string SubsidiaryClassification_04 { get; set; }
        string SubsidiaryClassification_05 { get; set; }
        string SubsidiaryClassification_06 { get; set; }
        string SubsidiaryRiskIndicator_07 { get; set; }
        string NetExplosiveQuantity_08 { get; set; }
        string CanadianHazardousNotation_09 { get; set; }
        string SpecialCommodityIndicatorCode_10 { get; set; }
        string CommunicationNumber_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
    }
    
    public interface I_LH6
    {
        
        string Name_01 { get; set; }
        string HazardousCertificationCode_02 { get; set; }
        string HazardousCertificationDeclaration_03 { get; set; }
        string HazardousCertificationDeclaration_04 { get; set; }
    }
    
    public interface I_LHE
    {
        
        string HazardousMaterialShippingName_01 { get; set; }
        string HazardousPlacardNotation_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReportableQuantityCode_05 { get; set; }
    }
    
    public interface I_LHR
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
    }
    
    public interface I_LHT
    {
        
        string HazardousClassification_01 { get; set; }
        string HazardousPlacardNotation_02 { get; set; }
        string HazardousEndorsement_03 { get; set; }
    }
    
    public interface I_LIC
    {
        
        string StateorProvinceCode_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string StatusCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_LID
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DateTimePeriod_02 { get; set; }
        string IndustryCode_03 { get; set; }
        string IndustryCode_04 { get; set; }
        string Description_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string Description_08 { get; set; }
    }
    
    public interface I_LIE
    {
        
        string LocationTypeCode_01 { get; set; }
        string ProximityCode_02 { get; set; }
        string Description_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
    }
    
    public interface I_LIN
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
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
    
    public interface I_LM
    {
        
        string AgencyQualifierCode_01 { get; set; }
        string SourceSubqualifier_02 { get; set; }
    }
    
    public interface I_LN
    {
        
        string ReferenceIdentification_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string FrequencyCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Percent_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string LoanPurposeCode_09 { get; set; }
        string LoanPaymentTypeCode_10 { get; set; }
        string LoanRateTypeCode_11 { get; set; }
    }
    
    public interface I_LN1
    {
        
        string MonetaryAmount_01 { get; set; }
        string LienPriorityCode_02 { get; set; }
        string RealEstateLoanTypeCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string Percent_05 { get; set; }
        string Percent_06 { get; set; }
        string RateValueQualifier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string RealEstateLoanSecurityInstrumentCode_09 { get; set; }
        string LoanDocumentationTypeCode_10 { get; set; }
        string LoanRateTypeCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
        string AccountNumber_13 { get; set; }
        string Percent_14 { get; set; }
        string Percent_15 { get; set; }
        string DateTimePeriodFormatQualifier_16 { get; set; }
        string DateTimePeriod_17 { get; set; }
        string DateTimePeriod_18 { get; set; }
        string DateTimePeriod_19 { get; set; }
        string DateTimePeriod_20 { get; set; }
        string DateTimePeriod_21 { get; set; }
        string MonetaryAmount_22 { get; set; }
        string MonetaryAmount_23 { get; set; }
    }
    
    public interface I_LN2<T1>
        where T1 : I_C040
    {
        
        string LienPriorityCode_01 { get; set; }
        string RealEstateLoanTypeCode_02 { get; set; }
        string Percent_03 { get; set; }
        string FrequencyCode_04 { get; set; }
        string LoanPaymentTypeCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string AssumptionTermsCode_07 { get; set; }
        string Name_08 { get; set; }
        T1 ReferenceIdentifier_09 { get; set; }
        string QuantityQualifier_10 { get; set; }
        string Quantity_11 { get; set; }
        string Quantity_12 { get; set; }
    }
    
    public interface I_LOC<T1, T2, T3, T4, T5, T6>
        where T1 : I_C001
        where T2 : I_C001
        where T3 : I_C001
        where T4 : I_C001
        where T5 : I_C001
        where T6 : I_C001
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Description_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Category_05 { get; set; }
        string ReferenceIdentificationQualifier_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string Description_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string MeasurementValue_10 { get; set; }
        T1 CompositeUnitofMeasure_11 { get; set; }
        string MeasurementValue_12 { get; set; }
        T2 CompositeUnitofMeasure_13 { get; set; }
        string MeasurementValue_14 { get; set; }
        T3 CompositeUnitofMeasure_15 { get; set; }
        string MeasurementValue_16 { get; set; }
        T4 CompositeUnitofMeasure_17 { get; set; }
        string MeasurementValue_18 { get; set; }
        T5 CompositeUnitofMeasure_19 { get; set; }
        string MeasurementValue_20 { get; set; }
        T6 CompositeUnitofMeasure_21 { get; set; }
        string ReferenceIdentificationQualifier_22 { get; set; }
        string ReferenceIdentification_23 { get; set; }
        string Description_24 { get; set; }
    }
    
    public interface I_LOD
    {
        
        string GeneralTerritoryCode_01 { get; set; }
        string ConditionIndicator_02 { get; set; }
        string FreeFormMessage_03 { get; set; }
        string ThoroughfareTypeQualifier_04 { get; set; }
        string ThoroughfareTypeCode_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
    }
    
    public interface I_LP
    {
        
        string EquipmentType_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string ShipmentIdentificationNumber_03 { get; set; }
        string VentInstructionCode_04 { get; set; }
        string EquipmentNumber_05 { get; set; }
        string Number_06 { get; set; }
        string Number_07 { get; set; }
    }
    
    public interface I_LQ
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
    }
    
    public interface I_LRQ<T1>
        where T1 : I_C048
    {
        
        string MonetaryAmount_01 { get; set; }
        string Percent_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string TypeofResidenceCode_05 { get; set; }
        string ContactMethodCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string AssumptionTermsCode_08 { get; set; }
        string LoanPurposeCode_09 { get; set; }
        T1 CompositeUseofProceeds_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string Description_13 { get; set; }
        string Description_14 { get; set; }
        string RealEstateLoanTypeCode_15 { get; set; }
        string Description_16 { get; set; }
        string LoanPaymentTypeCode_17 { get; set; }
        string Description_18 { get; set; }
        string Number_19 { get; set; }
        string Description_20 { get; set; }
    }
    
    public interface I_LS
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LS1
    {
        
        string Quantity_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string ChangeorResponseTypeCode_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string ProductServiceID_07 { get; set; }
    }
    
    public interface I_LT
    {
        
        string IndividualRelationshipCode_01 { get; set; }
        string Description_02 { get; set; }
        string Name_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_LTE
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string Description_03 { get; set; }
        string RatingSummaryValueCode_04 { get; set; }
    }
    
    public interface I_LTR<T1>
        where T1 : I_C001
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string MeasurementValue_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string CodeListQualifierCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
        string ShipmentStatusCode_07 { get; set; }
        string RangeMinimum_08 { get; set; }
        string RangeMaximum_09 { get; set; }
        string GenderCode_10 { get; set; }
        string RangeMinimum_11 { get; set; }
        string RangeMaximum_12 { get; set; }
    }
    
    public interface I_LUC<T1>
        where T1 : I_C048
    {
        
        string LoanDocumentationTypeCode_01 { get; set; }
        string LoanPurposeCode_02 { get; set; }
        T1 CompositeUseofProceeds_03 { get; set; }
        string RiskofLossCode_04 { get; set; }
    }
    
    public interface I_LUI
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string Description_03 { get; set; }
        string UseofLanguageIndicator_04 { get; set; }
        string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    public interface I_LV
    {
        
        string AssignedNumber_01 { get; set; }
        string LoanVerificationCode_02 { get; set; }
    }
    
    public interface I_LX
    {
        
        string AssignedNumber_01 { get; set; }
    }
    
    public interface I_M0
    {
        
        string LetterofCreditNumber_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_M1
    {
        
        string CountryCode_01 { get; set; }
        string CarriageValue_02 { get; set; }
        string DeclaredValue_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
        string RateValueQualifier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string PercentQualifier_09 { get; set; }
        string Percent_10 { get; set; }
        string PercentQualifier_11 { get; set; }
        string Percent_12 { get; set; }
    }
    
    public interface I_M10
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string CountryCode_03 { get; set; }
        string VesselCode_04 { get; set; }
        string VesselName_05 { get; set; }
        string FlightVoyageNumber_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string Quantity_08 { get; set; }
        string ManifestTypeCode_09 { get; set; }
        string VesselCodeQualifier_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
    }
    
    public interface I_M11
    {
        
        string BillofLadingWaybillNumber_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string Quantity_03 { get; set; }
        string ManifestUnitCode_04 { get; set; }
        string Weight_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string Volume_07 { get; set; }
        string VolumeUnitQualifier_08 { get; set; }
        string BillofLadingTypeCode_09 { get; set; }
        string PlaceofReceiptbyPrecarrier_10 { get; set; }
        string BillofLadingWaybillNumber_11 { get; set; }
        string StandardCarrierAlphaCode_12 { get; set; }
        string StandardCarrierAlphaCode_13 { get; set; }
        string StandardCarrierAlphaCode_14 { get; set; }
        string StandardCarrierAlphaCode_15 { get; set; }
        string ShippersExportDeclarationRequirements_16 { get; set; }
        string ExportExceptionCode_17 { get; set; }
        string StandardCarrierAlphaCode_18 { get; set; }
        string StandardCarrierAlphaCode_19 { get; set; }
    }
    
    public interface I_M12
    {
        
        string CustomsEntryTypeCode_01 { get; set; }
        string CustomsEntryNumber_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string LocationIdentifier_04 { get; set; }
        string CustomsShipmentValue_05 { get; set; }
        string InbondControlNumber_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string TransportationMethodTypeCode_10 { get; set; }
        string VesselName_11 { get; set; }
    }
    
    public interface I_M13
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string AmendmentTypeCode_03 { get; set; }
        string BillofLadingWaybillNumber_04 { get; set; }
        string Quantity_05 { get; set; }
        string AmendmentCode_06 { get; set; }
        string ActionCode_07 { get; set; }
        string BillofLadingWaybillNumber_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
    }
    
    public interface I_M14
    {
        
        string BillofLadingWaybillNumber_01 { get; set; }
        string BillofLadingStatusCode_02 { get; set; }
        string CustomsEntryNumber_03 { get; set; }
        string CustomsEntryTypeCode_04 { get; set; }
        string Date_05 { get; set; }
        string BillofLadingWaybillNumber_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string Quantity_09 { get; set; }
        string ReferenceIdentification_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
    }
    
    public interface I_M15
    {
        
        string NotificationEntityQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string LocationIdentifier_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string Time_06 { get; set; }
        string SealNumber_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string CityName_10 { get; set; }
        string StateorProvinceCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public interface I_M2
    {
        
        string SalesTermsCode_01 { get; set; }
        string SalesReferenceNumber_02 { get; set; }
        string SalesReferenceDate_03 { get; set; }
        string TransportationTermsCode_04 { get; set; }
        string SalesComment_05 { get; set; }
        string DeliveryDate_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
    }
    
    public interface I_M20
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string BillofLadingWaybillNumber_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string FreeformDescription_09 { get; set; }
    }
    
    public interface I_M21
    {
        
        string CustomsEntryTypeCode_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string BillofLadingWaybillNumber_04 { get; set; }
        string MasterInbondTypeCode_05 { get; set; }
        string InbondControlNumber_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string BillofLadingWaybillNumber_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string BillofLadingWaybillNumber_10 { get; set; }
        string StandardCarrierAlphaCode_11 { get; set; }
        string StandardCarrierAlphaCode_12 { get; set; }
        string Quantity_13 { get; set; }
    }
    
    public interface I_M3
    {
        
        string ReleaseCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
    }
    
    public interface I_M7
    {
        
        string SealNumber_01 { get; set; }
        string SealNumber_02 { get; set; }
        string SealNumber_03 { get; set; }
        string SealNumber_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
    }
    
    public interface I_M7A
    {
        
        string SealNumber_01 { get; set; }
        string SealNumber_02 { get; set; }
        string Date_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string Name_05 { get; set; }
        string Description_06 { get; set; }
    }
    
    public interface I_MAN
    {
        
        string MarksandNumbersQualifier_01 { get; set; }
        string MarksandNumbers_02 { get; set; }
        string MarksandNumbers_03 { get; set; }
        string MarksandNumbersQualifier_04 { get; set; }
        string MarksandNumbers_05 { get; set; }
        string MarksandNumbers_06 { get; set; }
    }
    
    public interface I_MBL
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string BillofLadingWaybillNumber_02 { get; set; }
        string ActionCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string TypeofServiceCode_05 { get; set; }
    }
    
    public interface I_MC
    {
        
        string SpecialChargeorAllowanceCode_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string Rate_03 { get; set; }
        string SpecialChargeDescription_04 { get; set; }
        string AssignedNumber_05 { get; set; }
    }
    
    public interface I_MCD
    {
        
        string MonetaryAmount_01 { get; set; }
        string Date_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Name_04 { get; set; }
    }
    
    public interface I_MCT
    {
        
        string SpecialChargeorAllowanceCode_01 { get; set; }
        string TariffValueCode_02 { get; set; }
        string RangeMinimum_03 { get; set; }
        string RangeMaximum_04 { get; set; }
        string RateValueQualifier_05 { get; set; }
        string Rate_06 { get; set; }
        string TariffReferenceFlag_07 { get; set; }
        string SpecialChargeDescription_08 { get; set; }
    }
    
    public interface I_MEA<T1>
        where T1 : I_C001
    {
        
        string MeasurementReferenceIDCode_01 { get; set; }
        string MeasurementQualifier_02 { get; set; }
        string MeasurementValue_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string RangeMinimum_05 { get; set; }
        string RangeMaximum_06 { get; set; }
        string MeasurementSignificanceCode_07 { get; set; }
        string MeasurementAttributeCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
        string MeasurementMethodorDevice_10 { get; set; }
    }
    
    public interface I_MI
    {
        
        string MediaTypeIdentifier_01 { get; set; }
        string Amount_02 { get; set; }
        string Amount_03 { get; set; }
        string Amount_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_MI1
    {
        
        string SourceCode_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string Number_03 { get; set; }
    }
    
    public interface I_MIA
    {
        
        string Quantity_01 { get; set; }
        string Quantity_02 { get; set; }
        string Quantity_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string MonetaryAmount_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string Quantity_15 { get; set; }
        string MonetaryAmount_16 { get; set; }
        string MonetaryAmount_17 { get; set; }
        string MonetaryAmount_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
        string ReferenceIdentification_20 { get; set; }
        string ReferenceIdentification_21 { get; set; }
        string ReferenceIdentification_22 { get; set; }
        string ReferenceIdentification_23 { get; set; }
        string MonetaryAmount_24 { get; set; }
    }
    
    public interface I_MIC<T1>
        where T1 : I_C001
    {
        
        string MortgageInsuranceApplicationType_01 { get; set; }
        string MortgageInsuranceCoverageTypeCode_02 { get; set; }
        string MortgageInsuranceCertificateTypeCode_03 { get; set; }
        string Percent_04 { get; set; }
        string PremiumRatePatternCode_05 { get; set; }
        string MortgageInsuranceDurationCode_06 { get; set; }
        T1 CompositeUnitofMeasure_07 { get; set; }
        string Quantity_08 { get; set; }
        string MortgageInsuranceRenewalOptionCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string TermsTypeCode_11 { get; set; }
        string MortgageInsurancePremiumTypeCode_12 { get; set; }
        string Amount_13 { get; set; }
        string PremiumSourceEntityCode_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
        string ProductServiceID_16 { get; set; }
        string YesNoConditionorResponseCode_17 { get; set; }
    }
    
    public interface I_MIN
    {
        
        string LoadingRestriction_01 { get; set; }
        string LoadingRestriction_02 { get; set; }
        string LoadingRestriction_03 { get; set; }
        string LoadingRestriction_04 { get; set; }
        string LoadingRestriction_05 { get; set; }
        string LoadingRestriction_06 { get; set; }
        string LoadingRestriction_07 { get; set; }
        string LoadingRestriction_08 { get; set; }
        string LoadingRestriction_09 { get; set; }
        string LoadingRestriction_10 { get; set; }
        string LoadingRestriction_11 { get; set; }
        string LoadingRestriction_12 { get; set; }
        string LoadingRestriction_13 { get; set; }
        string LoadingRestriction_14 { get; set; }
        string LoadingRestriction_15 { get; set; }
        string LoadingRestriction_16 { get; set; }
    }
    
    public interface I_MIR<T1>
        where T1 : I_C001
    {
        
        string MortgageInsuranceApplicationType_01 { get; set; }
        string UnderwritingDecisionCode_02 { get; set; }
        string MortgageInsuranceCertificateTypeCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Percent_05 { get; set; }
        string Amount_06 { get; set; }
        T1 CompositeUnitofMeasure_07 { get; set; }
        string Quantity_08 { get; set; }
        string Percent_09 { get; set; }
        string Percent_10 { get; set; }
        string MortgageInsuranceRenewalOptionCode_11 { get; set; }
        string Date_12 { get; set; }
    }
    
    public interface I_MIS
    {
        
        string MortgageeInformationStatusCode_01 { get; set; }
        string DateTimeQualifier_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string JurisdictionCode_05 { get; set; }
    }
    
    public interface I_MIT
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Description_02 { get; set; }
        string PageWidth_03 { get; set; }
        string PageLengthLines_04 { get; set; }
    }
    
    public interface I_MKS
    {
        
        string MarkCodeType_01 { get; set; }
        string AcademicGradeQualifier_02 { get; set; }
        string AcademicGrade_03 { get; set; }
    }
    
    public interface I_MLS
    {
        
        string MilestoneNumberIdentification_01 { get; set; }
        string Description_02 { get; set; }
        string WorkStatusCode_03 { get; set; }
        string ActionCode_04 { get; set; }
    }
    
    public interface I_MNC
    {
        
        string CodeCategory_01 { get; set; }
        string RealEstateLoanTypeCode_02 { get; set; }
        string LienPriorityCode_03 { get; set; }
        string LoanPaymentTypeCode_04 { get; set; }
        string LoanRateTypeCode_05 { get; set; }
        string FrequencyCode_06 { get; set; }
        string InterestRateCalculationMethodCode_07 { get; set; }
        string Number_08 { get; set; }
        string Number_09 { get; set; }
        string PaymentMethodCode_10 { get; set; }
        string InterestPaymentCode_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductProcessCharacteristicCode_14 { get; set; }
        string ProductDescriptionCode_15 { get; set; }
        string TypeofRealEstateAssetCode_16 { get; set; }
        string RealEstateLoanSecurityInstrumentCode_17 { get; set; }
    }
    
    public interface I_MOA
    {
        
        string Percent_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
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
    
    public interface I_MPP
    {
        
        string CodeCategory_01 { get; set; }
        string ProgramTypeCode_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string AccrualRateMethodCode_07 { get; set; }
        string CertificationTypeCode_08 { get; set; }
    }
    
    public interface I_MRC
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string MortgagorResponseCode_02 { get; set; }
        string ContactMethodCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
        string ContactMethodCode_06 { get; set; }
        string Quantity_07 { get; set; }
        string ContactMethodCode_08 { get; set; }
        string Quantity_09 { get; set; }
    }
    
    public interface I_MS
    {
        
        string AgencyQualifierCode_01 { get; set; }
        string SpecialServicesCode_02 { get; set; }
        string Charge_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string Charge_05 { get; set; }
        string AssignedNumber_06 { get; set; }
    }
    
    public interface I_MS1
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string CountryCode_03 { get; set; }
        string LongitudeCode_04 { get; set; }
        string LatitudeCode_05 { get; set; }
        string DirectionIdentifierCode_06 { get; set; }
        string DirectionIdentifierCode_07 { get; set; }
    }
    
    public interface I_MS2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string EquipmentDescriptionCode_03 { get; set; }
        string EquipmentNumberCheckDigit_04 { get; set; }
    }
    
    public interface I_MS3
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string StateorProvinceCode_05 { get; set; }
    }
    
    public interface I_MS4
    {
        
        string MeasurementUnitQualifier_01 { get; set; }
        string Length_02 { get; set; }
        string Height_03 { get; set; }
        string Width_04 { get; set; }
    }
    
    public interface I_MS5
    {
        
        string DeclaredValue_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string FreightRate_03 { get; set; }
        string DeclaredValue_04 { get; set; }
        string CurrencyCode_05 { get; set; }
    }
    
    public interface I_MS6
    {
        
        string Quantity_01 { get; set; }
        string WeightQualifier_02 { get; set; }
        string Weight_03 { get; set; }
    }
    
    public interface I_MSG
    {
        
        string FreeFormMessageText_01 { get; set; }
        string PrinterCarriageControlCode_02 { get; set; }
        string Number_03 { get; set; }
    }
    
    public interface I_MSS
    {
        
        string ReportSectionNameCode_01 { get; set; }
        string Description_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string ChangeTypeCode_05 { get; set; }
        string ReportSectionNumber_06 { get; set; }
        string SafetyCharacteristicHazardCode_07 { get; set; }
    }
    
    public interface I_MTX
    {
        
        string NoteReferenceCode_01 { get; set; }
        string MessageText_02 { get; set; }
        string MessageText_03 { get; set; }
        string PrinterCarriageControlCode_04 { get; set; }
    }
    
    public interface I_N1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string Name_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string EntityRelationshipCode_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
    }
    
    public interface I_N10
    {
        
        string Quantity_01 { get; set; }
        string FreeformDescription_02 { get; set; }
        string MarksandNumbers_03 { get; set; }
        string CommodityCodeQualifier_04 { get; set; }
        string CommodityCode_05 { get; set; }
        string CustomsShipmentValue_06 { get; set; }
        string WeightUnitCode_07 { get; set; }
        string Weight_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string ManifestUnitCode_10 { get; set; }
        string CountryCode_11 { get; set; }
        string CountryCode_12 { get; set; }
        string CurrencyCode_13 { get; set; }
    }
    
    public interface I_N11
    {
        
        string StoreNumber_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
    }
    
    public interface I_N12<T1>
        where T1 : I_C001
    {
        
        string FuelType_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
    }
    
    public interface I_N2
    {
        
        string Name_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    public interface I_N3
    {
        
        string AddressInformation_01 { get; set; }
        string AddressInformation_02 { get; set; }
    }
    
    public interface I_N4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PostalCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
    }
    
    public interface I_N5
    {
        
        string EquipmentLength_01 { get; set; }
        string WeightCapacity_02 { get; set; }
        string CubicCapacity_03 { get; set; }
        string CarTypeCode_04 { get; set; }
        string MetricQualifier_05 { get; set; }
        string Height_06 { get; set; }
        string LadingPercentage_07 { get; set; }
        string LadingPercentQualifier_08 { get; set; }
        string EquipmentDescriptionCode_09 { get; set; }
    }
    
    public interface I_N7
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string TareWeight_05 { get; set; }
        string WeightAllowance_06 { get; set; }
        string Dunnage_07 { get; set; }
        string Volume_08 { get; set; }
        string VolumeUnitQualifier_09 { get; set; }
        string OwnershipCode_10 { get; set; }
        string EquipmentDescriptionCode_11 { get; set; }
        string StandardCarrierAlphaCode_12 { get; set; }
        string TemperatureControl_13 { get; set; }
        string Position_14 { get; set; }
        string EquipmentLength_15 { get; set; }
        string TareQualifierCode_16 { get; set; }
        string WeightUnitCode_17 { get; set; }
        string EquipmentNumberCheckDigit_18 { get; set; }
        string TypeofServiceCode_19 { get; set; }
        string Height_20 { get; set; }
        string Width_21 { get; set; }
        string EquipmentType_22 { get; set; }
        string StandardCarrierAlphaCode_23 { get; set; }
        string CarTypeCode_24 { get; set; }
    }
    
    public interface I_N7A
    {
        
        string LoadorDeviceCode_01 { get; set; }
        string Length_02 { get; set; }
        string Diameter_03 { get; set; }
        string HoseTypeCode_04 { get; set; }
        string Diameter_05 { get; set; }
        string Diameter_06 { get; set; }
        string InletorOutletMaterialTypeCode_07 { get; set; }
        string InletorOutletFittingTypeCode_08 { get; set; }
        string MiscellaneousEquipmentCode_09 { get; set; }
    }
    
    public interface I_N7B
    {
        
        string NumberofTankCompartments_01 { get; set; }
        string LoadingorDischargeLocationCode_02 { get; set; }
        string VesselMaterialCode_03 { get; set; }
        string GasketTypeCode_04 { get; set; }
        string TrailerLiningTypeCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
    }
    
    public interface I_N8
    {
        
        string WaybillNumber_01 { get; set; }
        string Date_02 { get; set; }
        string CrossReferenceTypeCode_03 { get; set; }
        string EquipmentInitial_04 { get; set; }
        string EquipmentNumber_05 { get; set; }
        string WaybillNumber_06 { get; set; }
        string Date_07 { get; set; }
        string CityName_08 { get; set; }
        string StateorProvinceCode_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string FreightStationAccountingCode_11 { get; set; }
    }
    
    public interface I_N8A
    {
        
        string WaybillCrossReferenceCode_01 { get; set; }
        string WaybillNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string CityName_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string FreightStationAccountingCode_08 { get; set; }
        string EquipmentInitial_09 { get; set; }
        string EquipmentNumber_10 { get; set; }
    }
    
    public interface I_N9<T1>
        where T1 : I_C040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string FreeformDescription_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TimeCode_06 { get; set; }
        T1 ReferenceIdentifier_07 { get; set; }
    }
    
    public interface I_NA
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string CrossReferenceTypeCode_05 { get; set; }
        string Position_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string EquipmentLength_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string ChassisType_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    public interface I_NCA<T1>
        where T1 : I_C001
    {
        
        string AssignedIdentification_01 { get; set; }
        string NonconformanceResultantResponseCode_02 { get; set; }
        string Description_03 { get; set; }
        string Quantity_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
    }
    
    public interface I_NCD
    {
        
        string MeasurementAttributeCode_01 { get; set; }
        string NonconformanceDeterminationCode_02 { get; set; }
        string AssignedIdentification_03 { get; set; }
        string ProductProcessCharacteristicCode_04 { get; set; }
        string AgencyQualifierCode_05 { get; set; }
        string ProductDescriptionCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_NM1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string EntityTypeQualifier_02 { get; set; }
        string NameLastorOrganizationName_03 { get; set; }
        string NameFirst_04 { get; set; }
        string NameMiddle_05 { get; set; }
        string NamePrefix_06 { get; set; }
        string NameSuffix_07 { get; set; }
        string IdentificationCodeQualifier_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string EntityRelationshipCode_10 { get; set; }
        string EntityIdentifierCode_11 { get; set; }
    }
    
    public interface I_NTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_NX1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
    }
    
    public interface I_NX2
    {
        
        string AddressComponentQualifier_01 { get; set; }
        string AddressInformation_02 { get; set; }
        string CountyDesignator_03 { get; set; }
    }
    
    public interface I_OBI
    {
        
        string ObligationTypeCode_01 { get; set; }
        string Name_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string FrequencyCode_05 { get; set; }
        string Quantity_06 { get; set; }
    }
    
    public interface I_OD
    {
        
        string StandardPointLocationCode_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
    }
    
    public interface I_OI
    {
        
        string ClaimFilingIndicatorCode_01 { get; set; }
        string ClaimSubmissionReasonCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string PatientSignatureSourceCode_04 { get; set; }
        string ProviderAgreementCode_05 { get; set; }
        string ReleaseofInformationCode_06 { get; set; }
    }
    
    public interface I_OID
    {
        
        string ReferenceIdentification_01 { get; set; }
        string PurchaseOrderNumber_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Quantity_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string Weight_07 { get; set; }
        string VolumeUnitQualifier_08 { get; set; }
        string Volume_09 { get; set; }
    }
    
    public interface I_OPS<T1>
        where T1 : I_C001
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string InstructionalSettingCode_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string Quantity_06 { get; set; }
    }
    
    public interface I_OPX
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string PlacementCriteriaCode_02 { get; set; }
        string StatusReasonCode_03 { get; set; }
    }
    
    public interface I_OQS
    {
        
        string SequenceValue_01 { get; set; }
        string QuantityOrdered_02 { get; set; }
    }
    
    public interface I_OTI
    {
        
        string ApplicationAcknowledgmentCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ApplicationSendersCode_04 { get; set; }
        string ApplicationReceiversCode_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
        string GroupControlNumber_08 { get; set; }
        string TransactionSetControlNumber_09 { get; set; }
        string TransactionSetIdentifierCode_10 { get; set; }
        string VersionReleaseIndustryIdentifierCode_11 { get; set; }
        string TransactionSetPurposeCode_12 { get; set; }
        string TransactionTypeCode_13 { get; set; }
        string ApplicationType_14 { get; set; }
        string ActionCode_15 { get; set; }
        string TransactionHandlingCode_16 { get; set; }
        string StatusReasonCode_17 { get; set; }
    }
    
    public interface I_P1
    {
        
        string PickuporDeliveryCode_01 { get; set; }
        string PickupDate_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string PickupTime_04 { get; set; }
        string EquipmentInitial_05 { get; set; }
        string EquipmentNumber_06 { get; set; }
        string NumberofShipments_07 { get; set; }
    }
    
    public interface I_P2
    {
        
        string PickuporDeliveryCode_01 { get; set; }
        string DeliveryDate_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
    }
    
    public interface I_P4
    {
        
        string LocationIdentifier_01 { get; set; }
        string Date_02 { get; set; }
        string Quantity_03 { get; set; }
        string LocationIdentifier_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_P5
    {
        
        string PortorTerminalFunctionCode_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
    }
    
    public interface I_PAD
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductTransferTypeCode_02 { get; set; }
        string ChangeorResponseTypeCode_03 { get; set; }
        string PriceMultiplierQualifier_04 { get; set; }
        string Multiplier_05 { get; set; }
    }
    
    public interface I_PAI
    {
        
        string Date_01 { get; set; }
        string MeasurementValue_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Amount_04 { get; set; }
        string Amount_05 { get; set; }
    }
    
    public interface I_PAL
    {
        
        string PalletTypeCode_01 { get; set; }
        string PalletTiers_02 { get; set; }
        string PalletBlocks_03 { get; set; }
        string Pack_04 { get; set; }
        string UnitWeight_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Length_07 { get; set; }
        string Width_08 { get; set; }
        string Height_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string GrossWeightperPack_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
        string GrossVolumeperPack_13 { get; set; }
        string UnitorBasisforMeasurementCode_14 { get; set; }
        string PalletExchangeCode_15 { get; set; }
        string InnerPack_16 { get; set; }
    }
    
    public interface I_PAM<T1>
        where T1 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string AmountQualifierCode_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string UnitofTimePeriodorInterval_06 { get; set; }
        string DateTimeQualifier_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string Date_11 { get; set; }
        string Time_12 { get; set; }
        string PercentQualifier_13 { get; set; }
        string Percent_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    public interface I_PAS
    {
        
        string PropertyValueEstimateTypeCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string ImprovementStatusCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_PAT
    {
        
        string IndividualRelationshipCode_01 { get; set; }
        string PatientLocationCode_02 { get; set; }
        string EmploymentStatusCode_03 { get; set; }
        string StudentStatusCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Weight_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_PAY<T1, T2>
        where T1 : I_C001
        where T2 : I_C001
    {
        
        string PaymentAdjustmentCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string Percent_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        T1 CompositeUnitofMeasure_07 { get; set; }
        string Quantity_08 { get; set; }
        T2 CompositeUnitofMeasure_09 { get; set; }
        string Quantity_10 { get; set; }
        string Percent_11 { get; set; }
        string Percent_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string YesNoConditionorResponseCode_14 { get; set; }
        string Quantity_15 { get; set; }
        string Percent_16 { get; set; }
        string MonetaryAmount_17 { get; set; }
        string NegativeAmortizationQualifier_18 { get; set; }
        string Percent_19 { get; set; }
        string MonetaryAmount_20 { get; set; }
        string NegativeAmortizationCapSourceCode_21 { get; set; }
        string YesNoConditionorResponseCode_22 { get; set; }
    }
    
    public interface I_PBI
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ActionCode_02 { get; set; }
        string FreeFormMessageText_03 { get; set; }
        string TaxInformationIdentificationNumber_04 { get; set; }
        string Quantity_05 { get; set; }
        string FixedFormatInformation_06 { get; set; }
        string Quantity_07 { get; set; }
        string FixedFormatInformation_08 { get; set; }
    }
    
    public interface I_PCL
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string AcademicDegreeCode_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_PCR
    {
        
        string PaymentCancellationType_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
    }
    
    public interface I_PCS
    {
        
        string ClaimStatusCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string SourceSubqualifier_03 { get; set; }
        string ClaimResponseReasonCode_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string FollowupActionCode_06 { get; set; }
        string AgencyQualifierCode_07 { get; set; }
        string SourceSubqualifier_08 { get; set; }
        string DispositionCode_09 { get; set; }
        string Description_10 { get; set; }
        string AuthorizationIdentification_11 { get; set; }
    }
    
    public interface I_PCT
    {
        
        string PercentQualifier_01 { get; set; }
        string Percent_02 { get; set; }
    }
    
    public interface I_PD<T1>
        where T1 : I_C001
    {
        
        string UnitofTimePeriodorInterval_01 { get; set; }
        string Date_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string Quantity_04 { get; set; }
        string Name_05 { get; set; }
        string Description_06 { get; set; }
        string BreakdownStructureDetailCode_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Description_09 { get; set; }
        string ProposalDataDetailIdentifierCode_10 { get; set; }
    }
    
    public interface I_PDD
    {
        
        string AssignedIdentification_01 { get; set; }
        string Quantity_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
        string ProposalDataDetailIdentifierCode_05 { get; set; }
    }
    
    public interface I_PDE<T1>
        where T1 : I_C001
    {
        
        string FreeFormMessageText_01 { get; set; }
        string DirectionIdentifierCode_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string MeasurementValue_04 { get; set; }
    }
    
    public interface I_PDL
    {
        
        string PaymentMethodCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
        string CreditDebitFlagCode_05 { get; set; }
        string FrequencyCode_06 { get; set; }
        string DFIIDNumberQualifier_07 { get; set; }
        string DFIIdentificationNumber_08 { get; set; }
        string AccountNumberQualifier_09 { get; set; }
        string AccountNumber_10 { get; set; }
        string DateTimePeriodFormatQualifier_11 { get; set; }
        string DateTimePeriod_12 { get; set; }
    }
    
    public interface I_PDP
    {
        
        string TypeofPersonalorBusinessAssetCode_01 { get; set; }
        string CommodityCodeQualifier_02 { get; set; }
        string CommodityCode_03 { get; set; }
    }
    
    public interface I_PDR
    {
        
        string TypeofRealEstateAssetCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
        string OccupancyCode_04 { get; set; }
    }
    
    public interface I_PDS<T1>
        where T1 : I_C040
    {
        
        string PropertyDescriptionQualifier_01 { get; set; }
        string FreeFormMessageText_02 { get; set; }
        T1 ReferenceIdentifier_03 { get; set; }
    }
    
    public interface I_PEN
    {
        
        string TransactionTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string ContributionCode_03 { get; set; }
        string Percent_04 { get; set; }
        string SpecialProcessingType_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string Number_07 { get; set; }
        string LoanTypeCode_08 { get; set; }
        string MaintenanceTypeCode_09 { get; set; }
    }
    
    public interface I_PER
    {
        
        string ContactFunctionCode_01 { get; set; }
        string Name_02 { get; set; }
        string CommunicationNumberQualifier_03 { get; set; }
        string CommunicationNumber_04 { get; set; }
        string CommunicationNumberQualifier_05 { get; set; }
        string CommunicationNumber_06 { get; set; }
        string CommunicationNumberQualifier_07 { get; set; }
        string CommunicationNumber_08 { get; set; }
        string ContactInquiryReference_09 { get; set; }
    }
    
    public interface I_PEX<T1>
        where T1 : I_C001
    {
        
        string GeneralExpenseQualifier_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string TaxTypeCode_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string EntityIdentifierCode_06 { get; set; }
        string TaxExemptCode_07 { get; set; }
        T1 CompositeUnitofMeasure_08 { get; set; }
    }
    
    public interface I_PI
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string PrimaryPublicationAuthorityCode_03 { get; set; }
        string RegulatoryAgencyCode_04 { get; set; }
        string TariffAgencyCode_05 { get; set; }
        string IssuingCarrierIdentifier_06 { get; set; }
        string ContractSuffix_07 { get; set; }
        string TariffItemNumber_08 { get; set; }
        string TariffSupplementIdentifier_09 { get; set; }
        string TariffSection_10 { get; set; }
        string ContractSuffix_11 { get; set; }
        string Date_12 { get; set; }
        string Date_13 { get; set; }
        string AlternationPrecedenceCode_14 { get; set; }
        string AlternationPrecedenceCode_15 { get; set; }
    }
    
    public interface I_PID
    {
        
        string ItemDescriptionType_01 { get; set; }
        string ProductProcessCharacteristicCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string ProductDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
        string SurfaceLayerPositionCode_06 { get; set; }
        string SourceSubqualifier_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string LanguageCode_09 { get; set; }
    }
    
    public interface I_PIN
    {
        
        string AssignedNumber_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Name_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string IndustryCode_07 { get; set; }
    }
    
    public interface I_PKD
    {
        
        string PackagingCode_01 { get; set; }
        string SourceSubqualifier_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string PackagingDescriptionCode_04 { get; set; }
        string OwnershipCode_05 { get; set; }
    }
    
    public interface I_PKG
    {
        
        string ItemDescriptionType_01 { get; set; }
        string PackagingCharacteristicCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string PackagingDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
        string UnitLoadOptionCode_06 { get; set; }
    }
    
    public interface I_PKL
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string Height_05 { get; set; }
        string Width_06 { get; set; }
        string ItemDepth_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string GrossWeightperPack_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string GrossVolumeperPack_11 { get; set; }
        string UnitorBasisforMeasurementCode_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
    }
    
    public interface I_PL<T1>
        where T1 : I_C001
    {
        
        string AssignedNumber_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string Name_03 { get; set; }
        string CalculationOperationCode_04 { get; set; }
        string Description_05 { get; set; }
        string Count_06 { get; set; }
    }
    
    public interface I_PLA
    {
        
        string ActionCode_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string MaintenanceReasonCode_05 { get; set; }
    }
    
    public interface I_PLB<T1, T2, T3, T4, T5, T6>
        where T1 : I_C042
        where T2 : I_C042
        where T3 : I_C042
        where T4 : I_C042
        where T5 : I_C042
        where T6 : I_C042
    {
        
        string ReferenceIdentification_01 { get; set; }
        string Date_02 { get; set; }
        T1 AdjustmentIdentifier_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        T2 AdjustmentIdentifier_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        T3 AdjustmentIdentifier_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        T4 AdjustmentIdentifier_09 { get; set; }
        string MonetaryAmount_10 { get; set; }
        T5 AdjustmentIdentifier_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        T6 AdjustmentIdentifier_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
    }
    
    public interface I_PLC
    {
        
        string Number_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
    }
    
    public interface I_PLD
    {
        
        string QuantityofPalletsShipped_01 { get; set; }
        string PalletExchangeCode_02 { get; set; }
        string WeightUnitCode_03 { get; set; }
        string Weight_04 { get; set; }
    }
    
    public interface I_PLI
    {
        
        string LoanTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string InterestRate_03 { get; set; }
        string LevelofIndividualTestorCourseCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string Quantity_08 { get; set; }
        string LoanRateTypeCode_09 { get; set; }
    }
    
    public interface I_PM
    {
        
        string DFIIdentificationNumber_01 { get; set; }
        string AccountNumber_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string AccountNumberQualifier_05 { get; set; }
        string DFIIDNumberQualifier_06 { get; set; }
    }
    
    public interface I_PO1
    {
        
        string AssignedIdentification_01 { get; set; }
        string QuantityOrdered_02 { get; set; }
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
    
    public interface I_PO3
    {
        
        string ChangeReasonCode_01 { get; set; }
        string Date_02 { get; set; }
        string PriceIdentifierCode_03 { get; set; }
        string UnitPrice_04 { get; set; }
        string BasisofUnitPriceCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Description_08 { get; set; }
    }
    
    public interface I_PO4
    {
        
        string Pack_01 { get; set; }
        string Size_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string PackagingCode_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string GrossWeightperPack_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string GrossVolumeperPack_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string Length_10 { get; set; }
        string Width_11 { get; set; }
        string Height_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string InnerPack_14 { get; set; }
        string SurfaceLayerPositionCode_15 { get; set; }
        string AssignedIdentification_16 { get; set; }
        string AssignedIdentification_17 { get; set; }
        string Number_18 { get; set; }
    }
    
    public interface I_POC<T1>
        where T1 : I_C001
    {
        
        string AssignedIdentification_01 { get; set; }
        string ChangeorResponseTypeCode_02 { get; set; }
        string QuantityOrdered_03 { get; set; }
        string QuantityLefttoReceive_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string BasisofUnitPriceCode_07 { get; set; }
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
    }
    
    public interface I_POD
    {
        
        string Date_01 { get; set; }
        string Time_02 { get; set; }
        string Name_03 { get; set; }
    }
    
    public interface I_PPA
    {
        
        string LocationQualifier_01 { get; set; }
        string LocationIdentifier_02 { get; set; }
        string LongitudeCode_03 { get; set; }
        string DirectionIdentifierCode_04 { get; set; }
        string LatitudeCode_05 { get; set; }
        string DirectionIdentifierCode_06 { get; set; }
    }
    
    public interface I_PPD
    {
        
        string PaymentPattern_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string RatingCode_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string Number_08 { get; set; }
        string Number_09 { get; set; }
        string Number_10 { get; set; }
        string Number_11 { get; set; }
        string Number_12 { get; set; }
        string Number_13 { get; set; }
    }
    
    public interface I_PPL
    {
        
        string AcquisitionDataCode_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string Description_04 { get; set; }
        string ProposalDataDetailIdentifierCode_05 { get; set; }
    }
    
    public interface I_PPY
    {
        
        string TypeofPersonalorBusinessAssetCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Description_03 { get; set; }
        string Description_04 { get; set; }
        string Description_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_PR
    {
        
        string CommodityGeographicLogicalConnectorCode_01 { get; set; }
        string CommodityCodeQualifier_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string CommodityCode_04 { get; set; }
        string ChangeTypeCode_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string DocketControlNumber_07 { get; set; }
        string DocketIdentification_08 { get; set; }
        string GroupTitle_09 { get; set; }
    }
    
    public interface I_PR1
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string LocationQualifier_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string LocationQualifier_09 { get; set; }
        string LocationIdentifier_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string StateorProvinceCode_12 { get; set; }
        string StandardCarrierAlphaCode_13 { get; set; }
    }
    
    public interface I_PR2
    {
        
        string Date_01 { get; set; }
        string Date_02 { get; set; }
        string RouteCode_03 { get; set; }
        string CarTypeCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string ConveyanceCode_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_PRC<T1>
        where T1 : I_C001
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string InterestRate_04 { get; set; }
        string InterestRate_05 { get; set; }
        string InterestRate_06 { get; set; }
        string AmountQualifierCode_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string QuantityQualifier_10 { get; set; }
        string Quantity_11 { get; set; }
        T1 CompositeUnitofMeasure_12 { get; set; }
    }
    
    public interface I_PRD
    {
        
        string LoanPaymentTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string LoanRateTypeCode_04 { get; set; }
        string Percent_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
    }
    
    public interface I_PRF
    {
        
        string PurchaseOrderNumber_01 { get; set; }
        string ReleaseNumber_02 { get; set; }
        string ChangeOrderSequenceNumber_03 { get; set; }
        string Date_04 { get; set; }
        string AssignedIdentification_05 { get; set; }
        string ContractNumber_06 { get; set; }
        string PurchaseOrderTypeCode_07 { get; set; }
    }
    
    public interface I_PRI
    {
        
        string PrimaryPublicationAuthorityCode_01 { get; set; }
        string TariffAgencyCode_02 { get; set; }
        string TariffNumber_03 { get; set; }
        string TariffNumberSuffix_04 { get; set; }
        string TariffSupplementIdentifier_05 { get; set; }
        string TariffSection_06 { get; set; }
        string TariffItemNumber_07 { get; set; }
        string ReferenceIdentificationQualifier_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string DocketControlNumber_11 { get; set; }
        string DocketIdentification_12 { get; set; }
        string RevisionNumber_13 { get; set; }
        string GroupTitle_14 { get; set; }
    }
    
    public interface I_PRJ
    {
        
        string Name_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_PRM
    {
        
        string CarTypeCode_01 { get; set; }
        string LoadEmptyStatusCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string StandardPointLocationCode_05 { get; set; }
        string CommodityCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
        string StandardPointLocationCode_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string TransportationConditionCode_11 { get; set; }
        string AssociationofAmericanRailroadsCarGradeCode_12 { get; set; }
        string IntermodalServiceCode_13 { get; set; }
    }
    
    public interface I_PRR
    {
        
        string AssignedIdentification_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string SourceSubqualifier_03 { get; set; }
        string ComplaintCode_04 { get; set; }
        string Description_05 { get; set; }
        string AgencyQualifierCode_06 { get; set; }
        string SourceSubqualifier_07 { get; set; }
        string ServiceClassificationCode_08 { get; set; }
        string AgencyQualifierCode_09 { get; set; }
        string SourceSubqualifier_10 { get; set; }
        string SeverityConditionCode_11 { get; set; }
    }
    
    public interface I_PRS
    {
        
        string PartReleaseStatusCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_PRT
    {
        
        string DispositionCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string SourceSubqualifier_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    public interface I_PRV<T1>
        where T1 : I_C035
    {
        
        string ProviderCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        T1 ProviderSpecialtyInformation_05 { get; set; }
        string ProviderOrganizationCode_06 { get; set; }
    }
    
    public interface I_PS
    {
        
        string ProtectiveServiceRuleCode_01 { get; set; }
        string ProtectiveServiceCode_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Temperature_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string FreightStationAccountingCode_06 { get; set; }
        string CityName_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
        string Weight_09 { get; set; }
        string PreCooledRuleCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
        string YesNoConditionorResponseCode_13 { get; set; }
        string Temperature_14 { get; set; }
    }
    
    public interface I_PS1
    {
        
        string ReferenceIdentification_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
    }
    
    public interface I_PSA
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string OwnersShare_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string AmountQualifierCode_05 { get; set; }
    }
    
    public interface I_PSC<T1, T2>
        where T1 : I_C001
        where T2 : I_C001
    {
        
        string ContractStatusCode_01 { get; set; }
        string TypeofProductServiceCode_02 { get; set; }
        string TypeofProductServiceCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string ContractNumber_06 { get; set; }
        T1 CompositeUnitofMeasure_07 { get; set; }
        string Count_08 { get; set; }
        string DateTimeQualifier_09 { get; set; }
        string Date_10 { get; set; }
        string Date_11 { get; set; }
        T2 CompositeUnitofMeasure_12 { get; set; }
        string RangeMaximum_13 { get; set; }
        string RangeMinimum_14 { get; set; }
        string MeasurementValue_15 { get; set; }
        string ActionCode_16 { get; set; }
        string Percent_17 { get; set; }
        string AgencyQualifierCode_18 { get; set; }
        string SourceSubqualifier_19 { get; set; }
        string OperationEnvironmentCode_20 { get; set; }
        string SpecialServicesCode_21 { get; set; }
        string Description_22 { get; set; }
        string UnitPrice_23 { get; set; }
        string YesNoConditionorResponseCode_24 { get; set; }
        string ContactMethodCode_25 { get; set; }
    }
    
    public interface I_PSD<T1>
        where T1 : I_C001
    {
        
        string SampleProcessStatusCode_01 { get; set; }
        string SampleSelectionMethodCode_02 { get; set; }
        string SampleFrequencyValueperUnitofMeasurementCode_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string SampleDescriptionCode_05 { get; set; }
        string SampleDirectionCode_06 { get; set; }
        string PositionCode_07 { get; set; }
        string Description_08 { get; set; }
        string SampleSelectionModulus_09 { get; set; }
    }
    
    public interface I_PT
    {
        
        string ConditionSegmentLogicalConnector_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string NameCharacterFormat_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string ChangeTypeCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string DocketControlNumber_08 { get; set; }
        string DocketIdentification_09 { get; set; }
        string GroupTitle_10 { get; set; }
        string EntityRelationshipCode_11 { get; set; }
    }
    
    public interface I_PTD
    {
        
        string ProductTransferTypeCode_01 { get; set; }
        string PriceMultiplierQualifier_02 { get; set; }
        string Multiplier_03 { get; set; }
        string ReferenceIdentificationQualifier_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ProductTransferMovementTypeCode_06 { get; set; }
    }
    
    public interface I_PTF<T1>
        where T1 : I_C001
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string FrequencyCode_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string TaxTypeCode_06 { get; set; }
        string TaxExemptCode_07 { get; set; }
    }
    
    public interface I_PUN
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_PWK<T1>
        where T1 : I_C002
    {
        
        string ReportTypeCode_01 { get; set; }
        string ReportTransmissionCode_02 { get; set; }
        string ReportCopiesNeeded_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
        string Description_07 { get; set; }
        T1 ActionsIndicated_08 { get; set; }
        string RequestCategoryCode_09 { get; set; }
    }
    
    public interface I_PYD
    {
        
        string MonetaryAmount_01 { get; set; }
        string FrequencyCode_02 { get; set; }
        string TaxTreatmentCode_03 { get; set; }
        string DeductionTypeCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_PYM
    {
        
        string RatingCode_01 { get; set; }
        string UnitofTimePeriodorInterval_02 { get; set; }
        string NumberofPeriods_03 { get; set; }
        string NumberofPeriods_04 { get; set; }
        string TimePeriodQualifier_05 { get; set; }
        string RatingRemarksCode_06 { get; set; }
        string Percent_07 { get; set; }
    }
    
    public interface I_PYT
    {
        
        string TermsNetDays_01 { get; set; }
        string TermsTypeCode_02 { get; set; }
        string DayofMonth_03 { get; set; }
        string TermsDiscountPercent_04 { get; set; }
        string TermsDiscountPercent_05 { get; set; }
        string TermsTypeCode_06 { get; set; }
        string TermsDiscountDaysDue_07 { get; set; }
        string TermsDiscountDaysDue_08 { get; set; }
    }
    
    public interface I_Q2
    {
        
        string VesselCode_01 { get; set; }
        string CountryCode_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string LadingQuantity_06 { get; set; }
        string Weight_07 { get; set; }
        string WeightQualifier_08 { get; set; }
        string FlightVoyageNumber_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
        string VesselCodeQualifier_12 { get; set; }
        string VesselName_13 { get; set; }
        string Volume_14 { get; set; }
        string VolumeUnitQualifier_15 { get; set; }
        string WeightUnitCode_16 { get; set; }
    }
    
    public interface I_Q3
    {
        
        string Date_01 { get; set; }
        string ShipmentMethodofPayment_02 { get; set; }
    }
    
    public interface I_Q5
    {
        
        string ShipmentStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
        string StatusReasonCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string CountryCode_08 { get; set; }
        string EquipmentInitial_09 { get; set; }
        string EquipmentNumber_10 { get; set; }
        string ReferenceIdentificationQualifier_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
        string DirectionIdentifierCode_13 { get; set; }
        string ReferenceIdentificationQualifier_14 { get; set; }
        string ReferenceIdentification_15 { get; set; }
        string DirectionIdentifierCode_16 { get; set; }
        string Percent_17 { get; set; }
        string PickuporDeliveryCode_18 { get; set; }
    }
    
    public interface I_Q7
    {
        
        string LadingExceptionCode_01 { get; set; }
        string PackagingFormCode_02 { get; set; }
        string LadingQuantity_03 { get; set; }
    }
    
    public interface I_Q8
    {
        
        string LadingExceptionCode_01 { get; set; }
        string PackagingFormCode_02 { get; set; }
        string LadingQuantity_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string LadingDescription_06 { get; set; }
        string DamageReasonCode_07 { get; set; }
        string ActionCode_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string Description_10 { get; set; }
    }
    
    public interface I_QTY<T1>
        where T1 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string FreeFormMessage_04 { get; set; }
    }
    
    public interface I_R1
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string AirportCode_03 { get; set; }
        string AirCarrierCode_04 { get; set; }
        string AirportCode_05 { get; set; }
        string AirCarrierCode_06 { get; set; }
        string AirportCode_07 { get; set; }
        string AirCarrierCode_08 { get; set; }
        string AirportCode_09 { get; set; }
        string AirCarrierCode_10 { get; set; }
        string AirportCode_11 { get; set; }
        string AirCarrierCode_12 { get; set; }
        string AirportCode_13 { get; set; }
    }
    
    public interface I_R2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string IntermodalServiceCode_05 { get; set; }
        string TransportationMethodTypeCode_06 { get; set; }
        string IntermediateSwitchCarrier_07 { get; set; }
        string IntermediateSwitchCarrier_08 { get; set; }
        string InvoiceNumber_09 { get; set; }
        string Date_10 { get; set; }
        string FreeformDescription_11 { get; set; }
        string TypeofServiceCode_12 { get; set; }
        string RouteDescription_13 { get; set; }
    }
    
    public interface I_R2A
    {
        
        string RoutingSequenceCode_01 { get; set; }
        string Preference_02 { get; set; }
        string TransportationMethodTypeCode_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string TypeofServiceCode_07 { get; set; }
        string RouteCode_08 { get; set; }
        string RouteDescription_09 { get; set; }
        string EntityIdentifierCode_10 { get; set; }
    }
    
    public interface I_R2B
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RuleJunctionCode_02 { get; set; }
        string Amount_03 { get; set; }
    }
    
    public interface I_R2C
    {
        
        string DivisionTypeCode_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string FactorAmount_03 { get; set; }
    }
    
    public interface I_R2D
    {
        
        string SpecialChargeorAllowanceCode_01 { get; set; }
        string Amount_02 { get; set; }
    }
    
    public interface I_R3
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string StandardPointLocationCode_05 { get; set; }
        string InvoiceNumber_06 { get; set; }
        string Date_07 { get; set; }
        string Amount_08 { get; set; }
        string FreeformDescription_09 { get; set; }
        string ServiceLevelCode_10 { get; set; }
        string ServiceLevelCode_11 { get; set; }
        string ServiceLevelCode_12 { get; set; }
    }
    
    public interface I_R4
    {
        
        string PortorTerminalFunctionCode_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string PortName_04 { get; set; }
        string CountryCode_05 { get; set; }
        string TerminalName_06 { get; set; }
        string PierNumber_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
    }
    
    public interface I_R9
    {
        
        string RouteCode_01 { get; set; }
        string AgentShipperRoutingCode_02 { get; set; }
        string IntermodalServiceCode_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string ActionCode_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    public interface I_RA
    {
        
        string RouteCode_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string AlternationPrecedenceCode_04 { get; set; }
        string NumberofRates_05 { get; set; }
        string UnitConversionFactor_06 { get; set; }
        string RateLevelQualifierCode_07 { get; set; }
        string RateLevel_08 { get; set; }
        string Date_09 { get; set; }
        string Date_10 { get; set; }
    }
    
    public interface I_RAB
    {
        
        string RateValueQualifier_01 { get; set; }
        string AssignedNumber_02 { get; set; }
        string AlternationPrecedenceCode_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string MinimumWeightLogic_05 { get; set; }
        string LoadingRestriction_06 { get; set; }
        string LoadingRestriction_07 { get; set; }
        string Percent_08 { get; set; }
        string UnitConversionFactor_09 { get; set; }
        string AssignedNumber_10 { get; set; }
    }
    
    public interface I_RAP
    {
        
        string EducationalTestorRequirementCode_01 { get; set; }
        string Name_02 { get; set; }
        string Name_03 { get; set; }
        string UsageIndicator_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
    }
    
    public interface I_RAT<T1, T2, T3>
        where T1 : I_C001
        where T2 : I_C001
        where T3 : I_C001
    {
        
        T1 CompositeUnitofMeasure_01 { get; set; }
        string Quantity_02 { get; set; }
        string IndexIdentityCode_03 { get; set; }
        string Percent_04 { get; set; }
        string Percent_05 { get; set; }
        string Percent_06 { get; set; }
        T2 CompositeUnitofMeasure_07 { get; set; }
        string Quantity_08 { get; set; }
        T3 CompositeUnitofMeasure_09 { get; set; }
        string Quantity_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string Percent_12 { get; set; }
        string Percent_13 { get; set; }
        string Percent_14 { get; set; }
        string RoundingSystemCode_15 { get; set; }
        string RateLifeCapSourceCode_16 { get; set; }
        string Percent_17 { get; set; }
    }
    
    public interface I_RB
    {
        
        string AssignedNumber_01 { get; set; }
        string RateApplicationTypeCode_02 { get; set; }
        string FreightRate_03 { get; set; }
        string MinimumWeightLogic_04 { get; set; }
        string LoadingRestriction_05 { get; set; }
        string LoadingRestriction_06 { get; set; }
        string Percent_07 { get; set; }
        string ChangeTypeCode_08 { get; set; }
    }
    
    public interface I_RC
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Name_03 { get; set; }
        string AgencyQualifierCode_04 { get; set; }
        string SourceSubqualifier_05 { get; set; }
        string CasualPartConditionCode_06 { get; set; }
        string Description_07 { get; set; }
        string FreeFormMessageText_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_RCD<T1, T2, T3, T4, T5, T6, T7>
        where T1 : I_C001
        where T2 : I_C001
        where T3 : I_C001
        where T4 : I_C001
        where T5 : I_C001
        where T6 : I_C001
        where T7 : I_C001
    {
        
        string AssignedIdentification_01 { get; set; }
        string QuantityUnitsReceivedorAccepted_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string QuantityUnitsReturned_04 { get; set; }
        T2 CompositeUnitofMeasure_05 { get; set; }
        string QuantityinQuestion_06 { get; set; }
        T3 CompositeUnitofMeasure_07 { get; set; }
        string ReceivingConditionCode_08 { get; set; }
        string QuantityinQuestion_09 { get; set; }
        T4 CompositeUnitofMeasure_10 { get; set; }
        string ReceivingConditionCode_11 { get; set; }
        string QuantityinQuestion_12 { get; set; }
        T5 CompositeUnitofMeasure_13 { get; set; }
        string ReceivingConditionCode_14 { get; set; }
        string QuantityinQuestion_15 { get; set; }
        T6 CompositeUnitofMeasure_16 { get; set; }
        string ReceivingConditionCode_17 { get; set; }
        string QuantityinQuestion_18 { get; set; }
        T7 CompositeUnitofMeasure_19 { get; set; }
        string ReceivingConditionCode_20 { get; set; }
        string Quantity_21 { get; set; }
    }
    
    public interface I_RD
    {
        
        string AssignedNumber_01 { get; set; }
        string RateApplicationTypeCode_02 { get; set; }
        string FreightRate_03 { get; set; }
        string ChangeTypeCode_04 { get; set; }
    }
    
    public interface I_RDD
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RuleJunctionCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string RuleJunctionCode_04 { get; set; }
        string AssignedNumber_05 { get; set; }
    }
    
    public interface I_RDI
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string CountryCode_02 { get; set; }
        string AmountQualifierCode_03 { get; set; }
        string Amount_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_RDM<T1, T2>
        where T1 : I_C040
        where T2 : I_C040
    {
        
        string ReportTransmissionCode_01 { get; set; }
        string Name_02 { get; set; }
        string CommunicationNumber_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
        T2 ReferenceIdentifier_05 { get; set; }
    }
    
    public interface I_RDR
    {
        
        string ReturnsDispositionCode_01 { get; set; }
        string ReturnRequestReasonCode_02 { get; set; }
        string ReturnResponseReasonCode_03 { get; set; }
        string Description_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_RDT
    {
        
        string RevisionLevelCode_01 { get; set; }
        string RevisionValue_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TimeCode_06 { get; set; }
    }
    
    public interface I_REA<T1, T2>
        where T1 : I_C047
        where T2 : I_C001
    {
        
        T1 CompositeTypeofRealEstateAssetCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string Date_03 { get; set; }
        string PropertyOwnershipRightsCode_04 { get; set; }
        string Date_05 { get; set; }
        string StatusofPlansforRealEstateAssetCode_06 { get; set; }
        string DateTimePeriodFormatQualifier_07 { get; set; }
        string DateTimePeriod_08 { get; set; }
        T2 CompositeUnitofMeasure_09 { get; set; }
        string Quantity_10 { get; set; }
        string LocationQualifier_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
        string TypeofResidenceCode_13 { get; set; }
    }
    
    public interface I_REC<T1>
        where T1 : I_C001
    {
        
        string OccupancyCode_01 { get; set; }
        string RealEstatePropertyConditionCode_02 { get; set; }
        string PropertyDamageCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Quantity_05 { get; set; }
        string PropertyInspectionQualifier_06 { get; set; }
        string ActionCode_07 { get; set; }
        string QuantityQualifier_08 { get; set; }
        string Quantity_09 { get; set; }
        T1 CompositeUnitofMeasure_10 { get; set; }
        string OccupancyVerificationCode_11 { get; set; }
        string NoteReferenceCode_12 { get; set; }
        string FreeFormMessage_13 { get; set; }
    }
    
    public interface I_RED
    {
        
        string Description_01 { get; set; }
        string RelatedDataIdentificationCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string SourceSubqualifier_04 { get; set; }
        string CodeListQualifierCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
    }
    
    public interface I_REF<T1>
        where T1 : I_C040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Description_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
    }
    
    public interface I_REL
    {
        
        string IndividualRelationshipCode_01 { get; set; }
        string Number_02 { get; set; }
    }
    
    public interface I_REN
    {
        
        string RateRequestResponseCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Description_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string RateRequestResponseCode_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_REP
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string AgencyQualifierCode_06 { get; set; }
        string SourceSubqualifier_07 { get; set; }
        string RepairActionCode_08 { get; set; }
        string Description_09 { get; set; }
        string AgencyQualifierCode_10 { get; set; }
        string SourceSubqualifier_11 { get; set; }
        string RepairComplexityCode_12 { get; set; }
        string ProductServiceIDQualifier_13 { get; set; }
        string ProductServiceID_14 { get; set; }
        string RepairActionCode_15 { get; set; }
        string Description_16 { get; set; }
        string AgencyQualifierCode_17 { get; set; }
        string SourceSubqualifier_18 { get; set; }
        string ReferenceIdentification_19 { get; set; }
        string AuthorizationIdentification_20 { get; set; }
    }
    
    public interface I_REQ
    {
        
        string InquiryResponseCode_01 { get; set; }
        string InquirySelectionCode_02 { get; set; }
    }
    
    public interface I_RET
    {
        
        string InformationStatusCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string StatusCode_03 { get; set; }
        string StatusofPlansforRealEstateAssetCode_04 { get; set; }
        string ContractTypeCode_05 { get; set; }
    }
    
    public interface I_RH
    {
        
        string TariffServiceCode_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string FreightRate_03 { get; set; }
    }
    
    public interface I_RIC
    {
        
        string ApplicationErrorConditionCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string AccountNumberQualifier_05 { get; set; }
        string DFIIDNumberQualifier_06 { get; set; }
        string DFIIdentificationNumber_07 { get; set; }
        string AccountNumber_08 { get; set; }
        string AccountNumberQualifier_09 { get; set; }
        string DFIIDNumberQualifier_10 { get; set; }
        string DFIIdentificationNumber_11 { get; set; }
        string AccountNumber_12 { get; set; }
        string AccountNumberQualifier_13 { get; set; }
        string DFIIDNumberQualifier_14 { get; set; }
        string DFIIdentificationNumber_15 { get; set; }
    }
    
    public interface I_RLD
    {
        
        string TypeofDownpaymentCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Description_03 { get; set; }
        string AmountQualifierCode_04 { get; set; }
    }
    
    public interface I_RLT<T1>
        where T1 : I_C001
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string RealEstateLoanTypeCode_05 { get; set; }
        string LoanPaymentTypeCode_06 { get; set; }
        string QuantityQualifier_07 { get; set; }
        string Quantity_08 { get; set; }
        T1 CompositeUnitofMeasure_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
        string ProgramTypeCode_12 { get; set; }
    }
    
    public interface I_RMR
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string PaymentActionCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string AdjustmentReasonCode_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
    }
    
    public interface I_RMT
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string AdjustmentReasonCode_09 { get; set; }
        string Description_10 { get; set; }
    }
    
    public interface I_RO
    {
        
        string PublicRecordorObligationCode_01 { get; set; }
        string DispositionCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string AmountQualifierCode_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string RateValueQualifier_06 { get; set; }
        string ReferenceIdentificationQualifier_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string TypeofAccountCode_09 { get; set; }
    }
    
    public interface I_RP
    {
        
        string MaintenanceTypeCode_01 { get; set; }
        string InsuranceLineCode_02 { get; set; }
        string MaintenanceReasonCode_03 { get; set; }
        string Description_04 { get; set; }
        string ParticipantStatusCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
        string SpecialProcessingType_07 { get; set; }
        string Authority_08 { get; set; }
        string PlanCoverageDescription_09 { get; set; }
    }
    
    public interface I_RPA<T1>
        where T1 : I_C001
    {
        
        string RateorValueTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Rate_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string Percent_05 { get; set; }
    }
    
    public interface I_RQS
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string Description_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_RRA
    {
        
        string InformationType_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
    }
    
    public interface I_RS
    {
        
        string AssignedNumber_01 { get; set; }
        string Number_02 { get; set; }
        string RateLevelQualifierCode_03 { get; set; }
        string RateLevel_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_RSC
    {
        
        string ResourceCodeorIdentifier_01 { get; set; }
        string Description_02 { get; set; }
        string ResourceType_03 { get; set; }
        string ActionCode_04 { get; set; }
    }
    
    public interface I_RSD
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string IndividualRelationshipCode_03 { get; set; }
    }
    
    public interface I_RST
    {
        
        string CarrierRestrictionCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_RT
    {
        
        string RateValueQualifier_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string DealerCode_03 { get; set; }
        string VehicleServiceCode_04 { get; set; }
        string DistanceQualifier_05 { get; set; }
        string TariffDistance_06 { get; set; }
        string NationalMotorFreightTransportationAssociationLocationName_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
        string Name_09 { get; set; }
        string AddressInformation_10 { get; set; }
        string IdentificationCode_11 { get; set; }
        string IdentificationCodeQualifier_12 { get; set; }
    }
    
    public interface I_RT1
    {
        
        string TransportationMethodTypeCode_01 { get; set; }
        string VehicleTypeCode_02 { get; set; }
        string FreightRate_03 { get; set; }
        string RoundingRuleCode_04 { get; set; }
        string VehicleIdentificationNumberVINPlantCode_05 { get; set; }
        string EquipmentDescriptionCode_06 { get; set; }
        string TariffItemNumber_07 { get; set; }
        string SpecialRateCode_08 { get; set; }
    }
    
    public interface I_RTE
    {
        
        string RateQualifier_01 { get; set; }
        string InterestRate_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Number_04 { get; set; }
        string Number_05 { get; set; }
    }
    
    public interface I_RTS
    {
        
        string FreightRate_01 { get; set; }
        string FreightRate_02 { get; set; }
        string FreightRate_03 { get; set; }
        string FreightRate_04 { get; set; }
        string FreightRate_05 { get; set; }
        string FreightRate_06 { get; set; }
        string FreightRate_07 { get; set; }
        string FreightRate_08 { get; set; }
        string FreightRate_09 { get; set; }
        string FreightRate_10 { get; set; }
        string FreightRate_11 { get; set; }
        string FreightRate_12 { get; set; }
        string FreightRate_13 { get; set; }
        string FreightRate_14 { get; set; }
        string FreightRate_15 { get; set; }
        string FreightRate_16 { get; set; }
    }
    
    public interface I_RTT
    {
        
        string RateValueQualifier_01 { get; set; }
        string FreightRate_02 { get; set; }
    }
    
    public interface I_RU1
    {
        
        string RailRetirementActivityCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Name_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Date_05 { get; set; }
        string EmploymentCode_06 { get; set; }
        string UnemployedReasonCode_07 { get; set; }
        string Date_08 { get; set; }
        string ClaimProfile_09 { get; set; }
    }
    
    public interface I_RU2
    {
        
        string RailRetirementActivityCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string EmploymentStatusCode_04 { get; set; }
        string Amount_05 { get; set; }
        string FrequencyCode_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
    }
    
    public interface I_RU3
    {
        
        string Date_01 { get; set; }
        string PayrollStatusCode_02 { get; set; }
        string WagesPaidCode_03 { get; set; }
        string PayrollStatusCode_04 { get; set; }
        string WagesPaidCode_05 { get; set; }
        string PayrollStatusCode_06 { get; set; }
        string WagesPaidCode_07 { get; set; }
        string PayrollStatusCode_08 { get; set; }
        string WagesPaidCode_09 { get; set; }
        string PayrollStatusCode_10 { get; set; }
        string WagesPaidCode_11 { get; set; }
        string PayrollStatusCode_12 { get; set; }
        string WagesPaidCode_13 { get; set; }
        string PayrollStatusCode_14 { get; set; }
        string WagesPaidCode_15 { get; set; }
        string PayrollStatusCode_16 { get; set; }
        string WagesPaidCode_17 { get; set; }
        string PayrollStatusCode_18 { get; set; }
        string WagesPaidCode_19 { get; set; }
        string PayrollStatusCode_20 { get; set; }
        string WagesPaidCode_21 { get; set; }
        string PayrollStatusCode_22 { get; set; }
        string WagesPaidCode_23 { get; set; }
        string PayrollStatusCode_24 { get; set; }
        string WagesPaidCode_25 { get; set; }
        string PayrollStatusCode_26 { get; set; }
        string WagesPaidCode_27 { get; set; }
        string PayrollStatusCode_28 { get; set; }
        string WagesPaidCode_29 { get; set; }
    }
    
    public interface I_RYL
    {
        
        string AssignedNumber_01 { get; set; }
        string NameLastorOrganizationName_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
    }
    
    public interface I_S1
    {
        
        string StopSequenceNumber_01 { get; set; }
        string NameCharacterFormat_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string AccomplishCode_06 { get; set; }
    }
    
    public interface I_S2
    {
        
        string StopSequenceNumber_01 { get; set; }
        string AddressInformation_02 { get; set; }
        string AddressInformation_03 { get; set; }
    }
    
    public interface I_S5
    {
        
        string StopSequenceNumber_01 { get; set; }
        string StopReasonCode_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string NumberofUnitsShipped_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string Volume_07 { get; set; }
        string VolumeUnitQualifier_08 { get; set; }
        string Description_09 { get; set; }
        string StandardPointLocationCode_10 { get; set; }
        string AccomplishCode_11 { get; set; }
    }
    
    public interface I_S9
    {
        
        string StopSequenceNumber_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string CountryCode_05 { get; set; }
        string StopReasonCode_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
    }
    
    public interface I_SA
    {
        
        string Date_01 { get; set; }
        string ActionCode_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string NameCharacterFormat_04 { get; set; }
        string Date_05 { get; set; }
    }
    
    public interface I_SAC
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        string Amount_05 { get; set; }
        string AllowanceChargePercentQualifier_06 { get; set; }
        string Percent_07 { get; set; }
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
    
    public interface I_SAL
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string Amount_02 { get; set; }
        string LaborRate_03 { get; set; }
        string NumberofPeriods_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
        string Date_06 { get; set; }
        string Date_07 { get; set; }
    }
    
    public interface I_SB
    {
        
        string Level_01 { get; set; }
    }
    
    public interface I_SBR
    {
        
        string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        string IndividualRelationshipCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Name_04 { get; set; }
        string InsuranceTypeCode_05 { get; set; }
        string CoordinationofBenefitsCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string EmploymentStatusCode_08 { get; set; }
        string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public interface I_SBT
    {
        
        string SubtestCode_01 { get; set; }
        string Name_02 { get; set; }
        string TestScoreInterpretationCode_03 { get; set; }
    }
    
    public interface I_SC
    {
        
        string Level_01 { get; set; }
        string SubLevel_02 { get; set; }
    }
    
    public interface I_SCA
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string StatisticCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string Quantity_05 { get; set; }
        string RangeMinimum_06 { get; set; }
        string RangeMaximum_07 { get; set; }
    }
    
    public interface I_SCD
    {
        
        string EmploymentStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string EmploymentStatusCode_03 { get; set; }
        string Date_04 { get; set; }
        string AgencyQualifierCode_05 { get; set; }
        string IndustryCode_06 { get; set; }
        string GenderCode_07 { get; set; }
    }
    
    public interface I_SCH
    {
        
        string Quantity_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
        string Name_04 { get; set; }
        string DateTimeQualifier_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
        string DateTimeQualifier_08 { get; set; }
        string Date_09 { get; set; }
        string Time_10 { get; set; }
        string RequestReferenceNumber_11 { get; set; }
        string AssignedIdentification_12 { get; set; }
    }
    
    public interface I_SCL
    {
        
        string RateBasisQualifier_01 { get; set; }
        string RateBasisNumber_02 { get; set; }
        string RateBasisNumber_03 { get; set; }
        string LocationQualifier_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string TariffAddOnFactor_08 { get; set; }
        string TariffClassAdjustmentReference_09 { get; set; }
        string TariffClassAdjustmentReference_10 { get; set; }
    }
    
    public interface I_SCM
    {
        
        string ProductServiceID_01 { get; set; }
        string Number_02 { get; set; }
        string EvaluationRatingCode_03 { get; set; }
        string FreeFormMessage_04 { get; set; }
    }
    
    public interface I_SCN
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string TransactionSetPurposeCode_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
        string Amount_05 { get; set; }
    }
    
    public interface I_SCO
    {
        
        string Quantity_01 { get; set; }
        string CommodityCodeQualifier_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string CarTypeCode_04 { get; set; }
        string EquipmentDescriptionCode_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string EquipmentLength_07 { get; set; }
        string Height_08 { get; set; }
        string Width_09 { get; set; }
        string WeightCapacity_10 { get; set; }
        string CubicCapacity_11 { get; set; }
        string ProtectiveServiceCode_12 { get; set; }
        string Temperature_13 { get; set; }
        string FloorTypeCode_14 { get; set; }
        string Height_15 { get; set; }
        string Width_16 { get; set; }
        string DoorTypeCode_17 { get; set; }
        string CarTypeCode_18 { get; set; }
    }
    
    public interface I_SCP
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReservationActionCode_03 { get; set; }
        string ShipmentorWorkAssignmentDeclineReasonCode_04 { get; set; }
    }
    
    public interface I_SCS
    {
        
        string ReferenceIdentification_01 { get; set; }
        string FreeFormMessageText_02 { get; set; }
    }
    
    public interface I_SCT
    {
        
        string AcademicCreditTypeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string SessionCode_03 { get; set; }
        string DateTimePeriodFormatQualifier_04 { get; set; }
        string DateTimePeriod_05 { get; set; }
    }
    
    public interface I_SD1
    {
        
        string ItemDescriptionType_01 { get; set; }
        string SafetyCharacteristicHazardCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string SourceSubqualifier_04 { get; set; }
        string ProductDescriptionCode_05 { get; set; }
        string Description_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string CountryCode_08 { get; set; }
    }
    
    public interface I_SDP
    {
        
        string ShipDeliveryorCalendarPatternCode_01 { get; set; }
        string ShipDeliveryPatternTimeCode_02 { get; set; }
        string ShipDeliveryorCalendarPatternCode_03 { get; set; }
        string ShipDeliveryPatternTimeCode_04 { get; set; }
        string ShipDeliveryorCalendarPatternCode_05 { get; set; }
        string ShipDeliveryPatternTimeCode_06 { get; set; }
        string ShipDeliveryorCalendarPatternCode_07 { get; set; }
        string ShipDeliveryPatternTimeCode_08 { get; set; }
    }
    
    public interface I_SDQ
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string IdentificationCode_07 { get; set; }
        string Quantity_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string IdentificationCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string IdentificationCode_13 { get; set; }
        string Quantity_14 { get; set; }
        string IdentificationCode_15 { get; set; }
        string Quantity_16 { get; set; }
        string IdentificationCode_17 { get; set; }
        string Quantity_18 { get; set; }
        string IdentificationCode_19 { get; set; }
        string Quantity_20 { get; set; }
        string IdentificationCode_21 { get; set; }
        string Quantity_22 { get; set; }
        string LocationIdentifier_23 { get; set; }
    }
    
    public interface I_SER
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string UnitPrice_05 { get; set; }
        string Quantity_06 { get; set; }
        string Description_07 { get; set; }
        string PriceIdentifierCode_08 { get; set; }
        string PaymentMethodCode_09 { get; set; }
        string ReferenceIdentificationQualifier_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
    }
    
    public interface I_SES
    {
        
        string DateTimePeriod_01 { get; set; }
        string Count_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string SessionCode_04 { get; set; }
        string Name_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string DateTimePeriodFormatQualifier_08 { get; set; }
        string DateTimePeriod_09 { get; set; }
        string LevelofIndividualTestorCourseCode_10 { get; set; }
        string IdentificationCodeQualifier_11 { get; set; }
        string IdentificationCode_12 { get; set; }
        string Name_13 { get; set; }
        string StatusReasonCode_14 { get; set; }
    }
    
    public interface I_SFC
    {
        
        string FacilityCharacteristicCodeQualifier_01 { get; set; }
        string FacilityCharacteristicCode_02 { get; set; }
    }
    
    public interface I_SG
    {
        
        string ShipmentStatusCode_01 { get; set; }
        string StatusReasonCode_02 { get; set; }
        string DispositionCode_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TimeCode_06 { get; set; }
    }
    
    public interface I_SHD
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string QuantityReceived_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Weight_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Volume_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string OrderSizingFactor_08 { get; set; }
        string PriceBracketIdentifier_09 { get; set; }
        string TransportationMethodTypeCode_10 { get; set; }
        string StandardCarrierAlphaCode_11 { get; set; }
        string ShipmentOrderStatusCode_12 { get; set; }
        string ReferenceIdentificationQualifier_13 { get; set; }
        string ReferenceIdentification_14 { get; set; }
    }
    
    public interface I_SHP
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
    }
    
    public interface I_SHR
    {
        
        string YesNoConditionorResponseCode_01 { get; set; }
        string SpecialHandlingCode_02 { get; set; }
    }
    
    public interface I_SI
    {
        
        string AgencyQualifierCode_01 { get; set; }
        string ServiceCharacteristicsQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string ServiceCharacteristicsQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ServiceCharacteristicsQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ServiceCharacteristicsQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ServiceCharacteristicsQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ServiceCharacteristicsQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ServiceCharacteristicsQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ServiceCharacteristicsQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ServiceCharacteristicsQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ServiceCharacteristicsQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
    }
    
    public interface I_SID
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string Date_04 { get; set; }
        string RatingSummaryValueCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_SII<T1>
        where T1 : I_C001
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Quantity_03 { get; set; }
        T1 CompositeUnitofMeasure_04 { get; set; }
        string UnitPrice_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
    }
    
    public interface I_SIN<T1>
        where T1 : I_C001
    {
        
        string InformationStatusCode_01 { get; set; }
        string ControlledSubstanceTypeCode_02 { get; set; }
        string FreeFormMessageText_03 { get; set; }
        string FrequencyCode_04 { get; set; }
        string Quantity_05 { get; set; }
        T1 CompositeUnitofMeasure_06 { get; set; }
    }
    
    public interface I_SL1
    {
        
        string ServiceLevelCode_01 { get; set; }
        string TariffNumber_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string Scale_04 { get; set; }
        string Date_05 { get; set; }
        string ServiceLevelCode_06 { get; set; }
        string ShipmentMethodofPayment_07 { get; set; }
        string DataSourceCode_08 { get; set; }
        string InternationalDomesticCode_09 { get; set; }
    }
    
    public interface I_SLI
    {
        
        string LoanTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string InterestRate_04 { get; set; }
        string LoanRateTypeCode_05 { get; set; }
        string DateTimePeriodFormatQualifier_06 { get; set; }
        string DateTimePeriod_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string DateTimePeriodFormatQualifier_10 { get; set; }
        string DateTimePeriod_11 { get; set; }
        string DateTimePeriodFormatQualifier_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string Quantity_15 { get; set; }
        string Quantity_16 { get; set; }
        string Quantity_17 { get; set; }
        string YesNoConditionorResponseCode_18 { get; set; }
        string YesNoConditionorResponseCode_19 { get; set; }
        string DateTimePeriodFormatQualifier_20 { get; set; }
        string DateTimePeriod_21 { get; set; }
        string PaymentMethodCode_22 { get; set; }
    }
    
    public interface I_SLN<T1>
        where T1 : I_C001
    {
        
        string AssignedIdentification_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string RelationshipCode_03 { get; set; }
        string Quantity_04 { get; set; }
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
    
    public interface I_SMA
    {
        
        string AddressTypeCode_01 { get; set; }
        string AddressInformation_02 { get; set; }
        string CityName_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string PostalCode_05 { get; set; }
    }
    
    public interface I_SMB
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string StationTypeCode_02 { get; set; }
        string StandardPointLocationCode_03 { get; set; }
        string StationTypeCode_04 { get; set; }
        string StationTypeCode_05 { get; set; }
        string StationTypeCode_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string RuleJunctionCode_08 { get; set; }
        string StationTypeCode_09 { get; set; }
    }
    
    public interface I_SMD
    {
        
        string ServiceLevelCode_01 { get; set; }
        string ShipmentMethodofPayment_02 { get; set; }
        string PickuporDeliveryCode_03 { get; set; }
    }
    
    public interface I_SMO
    {
        
        string AutomobileRampFacilityCode_01 { get; set; }
        string IntermodalFacilityCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string Weight_05 { get; set; }
        string RailCarPlateSizeCode_06 { get; set; }
        string ImportExportCode_07 { get; set; }
    }
    
    public interface I_SMR
    {
        
        string LocationQualifier_01 { get; set; }
        string StandardPointLocationCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
    }
    
    public interface I_SMS
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string FreightStationAccountingCode_02 { get; set; }
        string RuleJunctionCode_03 { get; set; }
        string PostalCode_04 { get; set; }
        string ReciprocalSwitchCode_05 { get; set; }
        string TimeCode_06 { get; set; }
        string LocationIdentifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string IdentificationCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    public interface I_SN1
    {
        
        string AssignedIdentification_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string QuantityShippedtoDate_04 { get; set; }
        string QuantityOrdered_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string ReturnableContainerLoadMakeUpCode_07 { get; set; }
        string LineItemStatusCode_08 { get; set; }
    }
    
    public interface I_SOI
    {
        
        string TypeofIncomeCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string Number_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_SOM
    {
        
        string LoanStatusCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string TypeofBankruptcyCode_05 { get; set; }
        string Date_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
        string LoanStatusCode_08 { get; set; }
        string DateTimePeriodFormatQualifier_09 { get; set; }
        string DateTimePeriod_10 { get; set; }
        string LoanStatusCode_11 { get; set; }
        string DateTimePeriodFormatQualifier_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
    }
    
    public interface I_SP
    {
        
        string SpecialProgramCategoryCode_01 { get; set; }
        string Percent_02 { get; set; }
        string ProgramParticipationandServicesCode_03 { get; set; }
        string ProgramandServicesFundingSourceCode_04 { get; set; }
        string Name_05 { get; set; }
    }
    
    public interface I_SPA
    {
        
        string StatusCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string AmountQualifierCode_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string StatusReasonCode_06 { get; set; }
        string StatusReasonCode_07 { get; set; }
        string StatusReasonCode_08 { get; set; }
        string AgencyQualifierCode_09 { get; set; }
        string ProductDescriptionCode_10 { get; set; }
        string SourceSubqualifier_11 { get; set; }
    }
    
    public interface I_SPI
    {
        
        string SecurityLevelCode_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string EntityTitle_04 { get; set; }
        string EntityPurpose_05 { get; set; }
        string EntityStatusCode_06 { get; set; }
        string TransactionSetPurposeCode_07 { get; set; }
        string ReportTypeCode_08 { get; set; }
        string SecurityLevelCode_09 { get; set; }
        string AgencyQualifierCode_10 { get; set; }
        string SourceSubqualifier_11 { get; set; }
        string AssignedNumber_12 { get; set; }
        string CertificationTypeCode_13 { get; set; }
        string ProposalDataDetailIdentifierCode_14 { get; set; }
        string HierarchicalStructureCode_15 { get; set; }
    }
    
    public interface I_SPK
    {
        
        string SpecimenKitTypeCode_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string Temperature_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
    }
    
    public interface I_SPO
    {
        
        string PurchaseOrderNumber_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string WeightUnitCode_05 { get; set; }
        string Weight_06 { get; set; }
        string ApplicationErrorConditionCode_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_SPR
    {
        
        string RatingCategoryCode_01 { get; set; }
        string MeasurementValue_02 { get; set; }
        string RangeMinimum_03 { get; set; }
        string RangeMaximum_04 { get; set; }
        string RatingSummaryValueCode_05 { get; set; }
        string Description_06 { get; set; }
        string MeasurementValue_07 { get; set; }
    }
    
    public interface I_SPS<T1>
        where T1 : I_C001
    {
        
        string Count_01 { get; set; }
        string Count_02 { get; set; }
        string Count_03 { get; set; }
        string ConfidenceLimit_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string SampleFrequencyValueperUnitofMeasurementCode_06 { get; set; }
    }
    
    public interface I_SPY
    {
        
        string ActionCode_01 { get; set; }
        string ScopeofPowerofAttorneyIdentificationCode_02 { get; set; }
        string Description_03 { get; set; }
    }
    
    public interface I_SR
    {
        
        string AssignedIdentification_01 { get; set; }
        string DayRotation_02 { get; set; }
        string Time_03 { get; set; }
        string Time_04 { get; set; }
        string FreeFormMessage_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string Quantity_07 { get; set; }
        string Date_08 { get; set; }
        string Date_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string ProductServiceID_11 { get; set; }
    }
    
    public interface I_SRA
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string MeasurementValue_02 { get; set; }
    }
    
    public interface I_SRD
    {
        
        string DistanceQualifier_01 { get; set; }
        string RateBasisNumber_02 { get; set; }
        string DistanceQualifier_03 { get; set; }
        string RateBasisNumber_04 { get; set; }
        string FreightRate_05 { get; set; }
        string FreightRate_06 { get; set; }
        string FreightRate_07 { get; set; }
        string FreightRate_08 { get; set; }
        string FreightRate_09 { get; set; }
        string FreightRate_10 { get; set; }
        string FreightRate_11 { get; set; }
        string FreightRate_12 { get; set; }
        string FreightRate_13 { get; set; }
        string FreightRate_14 { get; set; }
        string FreightRate_15 { get; set; }
        string FreightRate_16 { get; set; }
        string FreightRate_17 { get; set; }
        string FreightRate_18 { get; set; }
        string FreightRate_19 { get; set; }
        string FreightRate_20 { get; set; }
    }
    
    public interface I_SRE
    {
        
        string TestScoreQualifierCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_SRM
    {
        
        string FreightRate_01 { get; set; }
        string FreightRate_02 { get; set; }
        string FreightRate_03 { get; set; }
        string FreightRate_04 { get; set; }
        string FreightRate_05 { get; set; }
        string FreightRate_06 { get; set; }
        string FreightRate_07 { get; set; }
        string FreightRate_08 { get; set; }
        string FreightRate_09 { get; set; }
        string FreightRate_10 { get; set; }
        string FreightRate_11 { get; set; }
        string FreightRate_12 { get; set; }
        string FreightRate_13 { get; set; }
        string FreightRate_14 { get; set; }
        string FreightRate_15 { get; set; }
        string FreightRate_16 { get; set; }
    }
    
    public interface I_SRT
    {
        
        string ChangeTypeCode_01 { get; set; }
        string RouteCode_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string RateApplicationTypeCode_05 { get; set; }
        string Scale_06 { get; set; }
        string Scale_07 { get; set; }
        string MinimumWeightLogic_08 { get; set; }
        string LoadingRestriction_09 { get; set; }
        string LoadingRestriction_10 { get; set; }
        string Percent_11 { get; set; }
        string SpecialChargeorAllowanceCode_12 { get; set; }
        string SpecialChargeDescription_13 { get; set; }
    }
    
    public interface I_SS
    {
        
        string Date_01 { get; set; }
        string RateLevel_02 { get; set; }
        string RateDistributionCode_03 { get; set; }
        string IndependenceCode_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
        string NumberofPeriods_07 { get; set; }
        string Date_08 { get; set; }
        string RateMaintenanceAuthorityCode_09 { get; set; }
    }
    
    public interface I_SSC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string ServiceCommitmentTypeCode_06 { get; set; }
        string LoadEmptyStatusCode_07 { get; set; }
        string Percent_08 { get; set; }
    }
    
    public interface I_SSD
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ApplicationErrorConditionCode_04 { get; set; }
    }
    
    public interface I_SSE
    {
        
        string Date_01 { get; set; }
        string Date_02 { get; set; }
        string StatusReasonCode_03 { get; set; }
        string Number_04 { get; set; }
    }
    
    public interface I_SSS
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string SpecialServicesCode_03 { get; set; }
        string ServiceMarksandNumbers_04 { get; set; }
        string AllowanceorChargeRate_05 { get; set; }
        string Amount_06 { get; set; }
        string Description_07 { get; set; }
        string Quantity_08 { get; set; }
        string SourceSubqualifier_09 { get; set; }
    }
    
    public interface I_SST
    {
        
        string StatusReasonCode_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
        string StatusReasonCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
        string StatusReasonCode_07 { get; set; }
        string LevelofIndividualTestorCourseCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_STA<T1>
        where T1 : I_C001
    {
        
        string StatisticCode_01 { get; set; }
        string MeasurementValue_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string MeasurementQualifier_04 { get; set; }
        string MeasurementReferenceIDCode_05 { get; set; }
        string RangeMinimum_06 { get; set; }
        string RangeMaximum_07 { get; set; }
        string MeasurementSignificanceCode_08 { get; set; }
    }
    
    public interface I_STC<T1, T2, T3>
        where T1 : I_C043
        where T2 : I_C043
        where T3 : I_C043
    {
        
        T1 HealthCareClaimStatus_01 { get; set; }
        string Date_02 { get; set; }
        string ActionCode_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Date_06 { get; set; }
        string PaymentMethodCode_07 { get; set; }
        string Date_08 { get; set; }
        string CheckNumber_09 { get; set; }
        T2 HealthCareClaimStatus_10 { get; set; }
        T3 HealthCareClaimStatus_11 { get; set; }
        string FreeFormMessageText_12 { get; set; }
    }
    
    public interface I_STP
    {
        
        string Date_01 { get; set; }
        string EntityTitle_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string Number_05 { get; set; }
        string Number_06 { get; set; }
        string Number_07 { get; set; }
        string Number_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
    }
    
    public interface I_STS
    {
        
        string ActionCodeI_01 { get; set; }
        string ActionDateI_02 { get; set; }
        string ActionTimeI_03 { get; set; }
        string TimeCode_04 { get; set; }
        string ErrorReasonCodeI_05 { get; set; }
    }
    
    public interface I_SUM
    {
        
        string AcademicCreditTypeCode_01 { get; set; }
        string AcademicGradeorCourseLevelCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string Quantity_05 { get; set; }
        string Quantity_06 { get; set; }
        string RangeMinimum_07 { get; set; }
        string RangeMaximum_08 { get; set; }
        string AcademicGradePointAverage_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string ClassRank_11 { get; set; }
        string Quantity_12 { get; set; }
        string DateTimePeriodFormatQualifier_13 { get; set; }
        string DateTimePeriod_14 { get; set; }
        string NumberofDays_15 { get; set; }
        string Quantity_16 { get; set; }
        string Quantity_17 { get; set; }
        string AcademicSummarySource_18 { get; set; }
    }
    
    public interface I_SUP
    {
        
        string SupplementaryInformationQualifier_01 { get; set; }
        string CertificationClauseCode_02 { get; set; }
        string FreeFormMessage_03 { get; set; }
        string PrintOptionCode_04 { get; set; }
    }
    
    public interface I_SV
    {
        
        string UnitofTimePeriodorInterval_01 { get; set; }
        string ServiceStandard_02 { get; set; }
        string ServiceStandard_03 { get; set; }
        string TypeofServiceOfferedCode_04 { get; set; }
    }
    
    public interface I_SV1<T1, T2>
        where T1 : I_C003
        where T2 : I_C004
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string FacilityCodeValue_05 { get; set; }
        string ServiceTypeCode_06 { get; set; }
        T2 CompositeDiagnosisCodePointer_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string MultipleProcedureCode_10 { get; set; }
        string YesNoConditionorResponseCode_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
        string ReviewCode_13 { get; set; }
        string NationalorLocalAssignedReviewValue_14 { get; set; }
        string CopayStatusCode_15 { get; set; }
        string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        string ReferenceIdentification_17 { get; set; }
        string PostalCode_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
        string LevelofCareCode_20 { get; set; }
        string ProviderAgreementCode_21 { get; set; }
    }
    
    public interface I_SV2<T1>
        where T1 : I_C003
    {
        
        string ProductServiceID_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Quantity_05 { get; set; }
        string UnitRate_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
        string NursingHomeResidentialStatusCode_09 { get; set; }
        string LevelofCareCode_10 { get; set; }
    }
    
    public interface I_SV3<T1, T2, T3>
        where T1 : I_C003
        where T2 : I_C006
        where T3 : I_C004
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string FacilityCodeValue_03 { get; set; }
        T2 OralCavityDesignation_04 { get; set; }
        string ProsthesisCrownorInlayCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string Description_07 { get; set; }
        string CopayStatusCode_08 { get; set; }
        string ProviderAgreementCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        T3 CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    public interface I_SV4<T1>
        where T1 : I_C003
    {
        
        string ReferenceIdentification_01 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string DispenseasWrittenCode_05 { get; set; }
        string LevelofServiceCode_06 { get; set; }
        string PrescriptionOriginCode_07 { get; set; }
        string Description_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
        string YesNoConditionorResponseCode_10 { get; set; }
        string UnitDoseCode_11 { get; set; }
        string BasisofCostDeterminationCode_12 { get; set; }
        string BasisofDaysSupplyDeterminationCode_13 { get; set; }
        string DosageFormCode_14 { get; set; }
        string CopayStatusCode_15 { get; set; }
        string PatientLocationCode_16 { get; set; }
        string LevelofCareCode_17 { get; set; }
        string PriorAuthorizationTypeCode_18 { get; set; }
    }
    
    public interface I_SV5<T1>
        where T1 : I_C003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string FrequencyCode_06 { get; set; }
        string PrognosisCode_07 { get; set; }
    }
    
    public interface I_SV6<T1, T2>
        where T1 : I_C003
        where T2 : I_C004
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string FacilityCodeQualifier_02 { get; set; }
        string FacilityCodeValue_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        T2 CompositeDiagnosisCodePointer_05 { get; set; }
        string Quantity_06 { get; set; }
        string YesNoConditionorResponseCode_07 { get; set; }
    }
    
    public interface I_SV7
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string PrescriptionDenialOverrideCode_03 { get; set; }
        string CoverageLevelCode_04 { get; set; }
        string ProductProcessCharacteristicCode_05 { get; set; }
        string YesNoConditionorResponseCode_06 { get; set; }
    }
    
    public interface I_SVC<T1, T2>
        where T1 : I_C003
        where T2 : I_C003
    {
        
        T1 CompositeMedicalProcedureIdentifier_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string Quantity_05 { get; set; }
        T2 CompositeMedicalProcedureIdentifier_06 { get; set; }
        string Quantity_07 { get; set; }
    }
    
    public interface I_SVD<T1>
        where T1 : I_C003
    {
        
        string IdentificationCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        T1 CompositeMedicalProcedureIdentifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
        string Quantity_05 { get; set; }
        string AssignedNumber_06 { get; set; }
    }
    
    public interface I_SW
    {
        
        string TariffApplicationCode_01 { get; set; }
        string ConditionSegmentLogicalConnector_02 { get; set; }
        string ConditionCode_03 { get; set; }
        string ConditionValue_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string RateValueQualifier_06 { get; set; }
        string Rate_07 { get; set; }
        string RuleJunctionCode_08 { get; set; }
        string AssignedNumber_09 { get; set; }
    }
    
    public interface I_T1
    {
        
        string AssignedNumber_01 { get; set; }
        string WaybillNumber_02 { get; set; }
        string Date_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string CityName_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string StandardPointLocationCode_07 { get; set; }
        string TransitRegistrationNumber_08 { get; set; }
        string TransitLevelCode_09 { get; set; }
    }
    
    public interface I_T2
    {
        
        string AssignedNumber_01 { get; set; }
        string LadingDescription_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string FreightRate_05 { get; set; }
        string RateValueQualifier_06 { get; set; }
        string FreightRate_07 { get; set; }
        string RateValueQualifier_08 { get; set; }
        string CityName_09 { get; set; }
        string CityName_10 { get; set; }
        string ThroughSurchargePercent_11 { get; set; }
        string PaidInSurchargePercent_12 { get; set; }
    }
    
    public interface I_T3
    {
        
        string AssignedNumber_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string RoutingSequenceCode_03 { get; set; }
        string CityName_04 { get; set; }
        string StandardPointLocationCode_05 { get; set; }
        string EquipmentInitial_06 { get; set; }
        string EquipmentNumber_07 { get; set; }
    }
    
    public interface I_T6
    {
        
        string AssignedNumber_01 { get; set; }
        string FreightRate_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string CityName_04 { get; set; }
        string FreightRate_05 { get; set; }
        string RateValueQualifier_06 { get; set; }
        string CityName_07 { get; set; }
    }
    
    public interface I_T8
    {
        
        string AssignedNumber_01 { get; set; }
        string FreeformTransitData_02 { get; set; }
    }
    
    public interface I_TAX
    {
        
        string TaxIdentificationNumber_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string LocationQualifier_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string LocationQualifier_06 { get; set; }
        string LocationIdentifier_07 { get; set; }
        string LocationQualifier_08 { get; set; }
        string LocationIdentifier_09 { get; set; }
        string LocationQualifier_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string TaxExemptCode_12 { get; set; }
        string CustomsEntryTypeGroupCode_13 { get; set; }
    }
    
    public interface I_TBA<T1>
        where T1 : I_C001
    {
        
        T1 CompositeUnitofMeasure_01 { get; set; }
        string Quantity_02 { get; set; }
        string Percent_03 { get; set; }
    }
    
    public interface I_TBI
    {
        
        string IdentificationCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
    }
    
    public interface I_TC2
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
    }
    
    public interface I_TCD
    {
        
        string AssignedIdentification_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string LocationQualifier_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
        string StateorProvinceCode_09 { get; set; }
        string MeasurementValue_10 { get; set; }
        string MeasurementValue_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string MonetaryAmount_15 { get; set; }
        string RelationshipCode_16 { get; set; }
    }
    
    public interface I_TD1
    {
        
        string PackagingCode_01 { get; set; }
        string LadingQuantity_02 { get; set; }
        string CommodityCodeQualifier_03 { get; set; }
        string CommodityCode_04 { get; set; }
        string LadingDescription_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string Weight_07 { get; set; }
        string UnitorBasisforMeasurementCode_08 { get; set; }
        string Volume_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
    }
    
    public interface I_TD3
    {
        
        string EquipmentDescriptionCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string Weight_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
        string OwnershipCode_07 { get; set; }
        string SealStatusCode_08 { get; set; }
        string SealNumber_09 { get; set; }
        string EquipmentType_10 { get; set; }
    }
    
    public interface I_TD4
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string HazardousMaterialCodeQualifier_02 { get; set; }
        string HazardousMaterialClassCode_03 { get; set; }
        string Description_04 { get; set; }
        string YesNoConditionorResponseCode_05 { get; set; }
    }
    
    public interface I_TD5
    {
        
        string RoutingSequenceCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string Routing_05 { get; set; }
        string ShipmentOrderStatusCode_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
        string TransitDirectionCode_09 { get; set; }
        string TransitTimeDirectionQualifier_10 { get; set; }
        string TransitTime_11 { get; set; }
        string ServiceLevelCode_12 { get; set; }
        string ServiceLevelCode_13 { get; set; }
        string ServiceLevelCode_14 { get; set; }
        string CountryCode_15 { get; set; }
    }
    
    public interface I_TDS
    {
        
        string Amount_01 { get; set; }
        string Amount_02 { get; set; }
        string Amount_03 { get; set; }
        string Amount_04 { get; set; }
    }
    
    public interface I_TED
    {
        
        string ApplicationErrorConditionCode_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
        string SegmentIDCode_03 { get; set; }
        string SegmentPositioninTransactionSet_04 { get; set; }
        string ElementPositioninSegment_05 { get; set; }
        string DataElementReferenceNumber_06 { get; set; }
        string CopyofBadDataElement_07 { get; set; }
        string DataElementNewContent_08 { get; set; }
    }
    
    public interface I_TEM
    {
        
        string Quantity_01 { get; set; }
        string Quantity_02 { get; set; }
        string WeightUnitCode_03 { get; set; }
        string Weight_04 { get; set; }
    }
    
    public interface I_TER
    {
        
        string ClassofTradeCode_01 { get; set; }
        string GeneralTerritoryCode_02 { get; set; }
        string FreeFormMessageText_03 { get; set; }
        string CountryCode_04 { get; set; }
        string Percent_05 { get; set; }
    }
    
    public interface I_TF
    {
        
        string TariffAgencyCode_01 { get; set; }
        string TariffNumber_02 { get; set; }
        string TariffNumberSuffix_03 { get; set; }
        string TariffSupplementIdentifier_04 { get; set; }
    }
    
    public interface I_TFA
    {
        
        string RateValueQualifier_01 { get; set; }
        string TariffAdjustmentValueAmount_02 { get; set; }
        string TariffAdjustmentValueAmount_03 { get; set; }
        string TariffAdjustmentValueAmount_04 { get; set; }
        string TariffAdjustmentValueAmount_05 { get; set; }
        string TariffAdjustmentValueAmount_06 { get; set; }
        string TariffAdjustmentValueAmount_07 { get; set; }
        string TariffAdjustmentValueAmount_08 { get; set; }
        string TariffAdjustmentValueAmount_09 { get; set; }
        string TariffAdjustmentValueAmount_10 { get; set; }
        string TariffAdjustmentValueAmount_11 { get; set; }
        string TariffAdjustmentValueAmount_12 { get; set; }
        string TariffAdjustmentValueAmount_13 { get; set; }
        string TariffAdjustmentValueAmount_14 { get; set; }
        string TariffAdjustmentValueAmount_15 { get; set; }
        string TariffAdjustmentValueAmount_16 { get; set; }
        string TariffAdjustmentValueAmount_17 { get; set; }
    }
    
    public interface I_TFD
    {
        
        string RateValueQualifier_01 { get; set; }
        string TariffAdjustmentValueAmount_02 { get; set; }
    }
    
    public interface I_TFM
    {
        
        string FreightRate_01 { get; set; }
    }
    
    public interface I_TFR
    {
        
        string TariffRestrictionIDCode_01 { get; set; }
        string TariffRestrictionDescription_02 { get; set; }
        string TariffRestrictionValue_03 { get; set; }
        string TariffRestrictionValue_04 { get; set; }
    }
    
    public interface I_TFS
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
        string Date_07 { get; set; }
        string NameControlIdentifier_08 { get; set; }
    }
    
    public interface I_THE
    {
        
        string IdentificationCode_01 { get; set; }
        string Name_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Quantity_04 { get; set; }
        string Quantity_05 { get; set; }
    }
    
    public interface I_TI
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string Date_05 { get; set; }
        string SealStatusCode_06 { get; set; }
        string CarTypeCode_07 { get; set; }
    }
    
    public interface I_TIA<T1, T2>
        where T1 : I_C037
        where T2 : I_C001
    {
        
        T1 TaxFieldIdentification_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string FixedFormatInformation_03 { get; set; }
        string Quantity_04 { get; set; }
        T2 CompositeUnitofMeasure_05 { get; set; }
        string Percent_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
    }
    
    public interface I_TID
    {
        
        string TaskIDQualifier_01 { get; set; }
        string TaskIdentifier_02 { get; set; }
        string RelationshipTaskIdentifier_03 { get; set; }
        string Description_04 { get; set; }
        string WorkStatusCode_05 { get; set; }
        string ActionCode_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string Level_09 { get; set; }
    }
    
    public interface I_TIS
    {
        
        string TitleInsuranceServicesCode_01 { get; set; }
        string Date_02 { get; set; }
        string ProductServiceIDQualifier_03 { get; set; }
        string ProductServiceID_04 { get; set; }
    }
    
    public interface I_TLN
    {
        
        string AccountNumber_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
        string TypeofAccountCode_04 { get; set; }
        string TypeofAccountCode_05 { get; set; }
        string TypeofCreditAccountCode_06 { get; set; }
        string Number_07 { get; set; }
        string LoanTypeCode_08 { get; set; }
        string RatingCode_09 { get; set; }
        string RatingRemarksCode_10 { get; set; }
        string SourceofDisclosureCode_11 { get; set; }
        string DateTimePeriodFormatQualifier_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string RatingCode_15 { get; set; }
        string DateTimePeriodFormatQualifier_16 { get; set; }
        string DateTimePeriod_17 { get; set; }
        string MonetaryAmount_18 { get; set; }
        string RatingCode_19 { get; set; }
        string YesNoConditionorResponseCode_20 { get; set; }
        string Number_21 { get; set; }
        string Description_22 { get; set; }
    }
    
    public interface I_TMD
    {
        
        string ProductProcessCharacteristicCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string ProductDescriptionCode_03 { get; set; }
        string TestAdministrationMethodCode_04 { get; set; }
        string TestMediumCode_05 { get; set; }
        string Description_06 { get; set; }
        string Date_07 { get; set; }
        string ReferenceIdentification_08 { get; set; }
        string SourceSubqualifier_09 { get; set; }
    }
    
    public interface I_TOA
    {
        
        string TypeofActivityCode_01 { get; set; }
        string LicenseTypeCode_02 { get; set; }
        string StatusCode_03 { get; set; }
        string TypeofRatingCode_04 { get; set; }
        string TypeofRatingCode_05 { get; set; }
    }
    
    public interface I_TOO<T1>
        where T1 : I_C005
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        T1 ToothSurface_03 { get; set; }
    }
    
    public interface I_TOV
    {
        
        string HazardousVehicleTypeCode_01 { get; set; }
        string DateTimeQualifier_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string QuantityQualifier_05 { get; set; }
        string Quantity_06 { get; set; }
    }
    
    public interface I_TPB
    {
        
        string BusinessProfessionalTitleCode_01 { get; set; }
        string FreeFormMessageText_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string SourceSubqualifier_04 { get; set; }
    }
    
    public interface I_TPD
    {
        
        string ItemDescriptionType_01 { get; set; }
        string CommodityCodeQualifier_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_TRF<T1, T2>
        where T1 : I_C001
        where T2 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        T1 CompositeUnitofMeasure_02 { get; set; }
        string Quantity_03 { get; set; }
        T2 CompositeUnitofMeasure_04 { get; set; }
        string Quantity_05 { get; set; }
    }
    
    public interface I_TRN
    {
        
        string TraceTypeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string OriginatingCompanyIdentifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_TRS
    {
        
        string ActionCode_01 { get; set; }
        string FreeformDescription_02 { get; set; }
        string Percent_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
        string RateApplicationCode_05 { get; set; }
    }
    
    public interface I_TS
    {
        
        string TariffSection_01 { get; set; }
        string TariffItemNumber_02 { get; set; }
        string TariffItemSuffix_03 { get; set; }
        string TariffSectionIDCode_04 { get; set; }
        string RateValueQualifier_05 { get; set; }
        string EquipmentDescriptionCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_TS2
    {
        
        string MonetaryAmount_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string Quantity_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string Quantity_10 { get; set; }
        string Quantity_11 { get; set; }
        string Quantity_12 { get; set; }
        string Quantity_13 { get; set; }
        string Quantity_14 { get; set; }
        string MonetaryAmount_15 { get; set; }
        string Quantity_16 { get; set; }
        string MonetaryAmount_17 { get; set; }
        string MonetaryAmount_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
    }
    
    public interface I_TS3
    {
        
        string ReferenceIdentification_01 { get; set; }
        string FacilityCodeValue_02 { get; set; }
        string Date_03 { get; set; }
        string Quantity_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string MonetaryAmount_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string MonetaryAmount_09 { get; set; }
        string MonetaryAmount_10 { get; set; }
        string MonetaryAmount_11 { get; set; }
        string MonetaryAmount_12 { get; set; }
        string MonetaryAmount_13 { get; set; }
        string MonetaryAmount_14 { get; set; }
        string MonetaryAmount_15 { get; set; }
        string MonetaryAmount_16 { get; set; }
        string MonetaryAmount_17 { get; set; }
        string MonetaryAmount_18 { get; set; }
        string MonetaryAmount_19 { get; set; }
        string MonetaryAmount_20 { get; set; }
        string MonetaryAmount_21 { get; set; }
        string MonetaryAmount_22 { get; set; }
        string Quantity_23 { get; set; }
        string MonetaryAmount_24 { get; set; }
    }
    
    public interface I_TSD
    {
        
        string AssignedIdentification_01 { get; set; }
        string Position_02 { get; set; }
    }
    
    public interface I_TSI
    {
        
        string TagStatusCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
    }
    
    public interface I_TSP
    {
        
        string TestPeriodorIntervalQualifier_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string TestPeriodorIntervalValue_03 { get; set; }
        string UnitofTimePeriodorInterval_04 { get; set; }
    }
    
    public interface I_TST
    {
        
        string EducationalTestorRequirementCode_01 { get; set; }
        string Name_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string ReferenceIdentification_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string LevelofIndividualTestorCourseCode_07 { get; set; }
        string LevelofIndividualTestorCourseCode_08 { get; set; }
        string DateTimePeriod_09 { get; set; }
        string TestNormTypeCode_10 { get; set; }
        string TestNormingPeriodCode_11 { get; set; }
        string LanguageCode_12 { get; set; }
        string DateTimePeriod_13 { get; set; }
        string YesNoConditionorResponseCode_14 { get; set; }
        string YesNoConditionorResponseCode_15 { get; set; }
    }
    
    public interface I_TSU
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Quantity_04 { get; set; }
        string Quantity_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
        string TimeCode_08 { get; set; }
    }
    
    public interface I_TT
    {
        
        string AssignedNumber_01 { get; set; }
        string FixedFormatInformation_02 { get; set; }
    }
    
    public interface I_TUD
    {
        
        string TradeUnionCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
    }
    
    public interface I_TXI
    {
        
        string TaxTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string TaxJurisdictionCodeQualifier_04 { get; set; }
        string TaxJurisdictionCode_05 { get; set; }
        string TaxExemptCode_06 { get; set; }
        string RelationshipCode_07 { get; set; }
        string DollarBasisForPercent_08 { get; set; }
        string TaxIdentificationNumber_09 { get; set; }
        string AssignedIdentification_10 { get; set; }
    }
    
    public interface I_TXN
    {
        
        string ActionCode_01 { get; set; }
        string ResponsibleAgencyCode_02 { get; set; }
        string TransactionSetIdentifierCode_03 { get; set; }
        string VersionReleaseIndustryIdentifierCode_04 { get; set; }
        string ActionCode_05 { get; set; }
        string ApplicationReceiversCode_06 { get; set; }
        string ApplicationSendersCode_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
    }
    
    public interface I_TXP
    {
        
        string TaxIdentificationNumber_01 { get; set; }
        string TaxPaymentTypeCode_02 { get; set; }
        string Date_03 { get; set; }
        string TaxInformationIdentificationNumber_04 { get; set; }
        string TaxAmount_05 { get; set; }
        string TaxInformationIdentificationNumber_06 { get; set; }
        string TaxAmount_07 { get; set; }
        string TaxInformationIdentificationNumber_08 { get; set; }
        string TaxAmount_09 { get; set; }
        string TaxpayerVerification_10 { get; set; }
    }
    
    public interface I_UC
    {
        
        string CodeCategory_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    public interface I_UCS<T1>
        where T1 : I_C001
    {
        
        string CodeCategory_01 { get; set; }
        string Description_02 { get; set; }
        string ItemDescriptionType_03 { get; set; }
        string Description_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string Number_07 { get; set; }
        T1 CompositeUnitofMeasure_08 { get; set; }
    }
    
    public interface I_UD
    {
        
        string StatusCode_01 { get; set; }
        string StatusCode_02 { get; set; }
        string UnderwritingDecisionCode_03 { get; set; }
        string Date_04 { get; set; }
        string Description_05 { get; set; }
        string OfferBasisCode_06 { get; set; }
        string AssignedNumber_07 { get; set; }
        string OfferBasisCode_08 { get; set; }
        string AssignedNumber_09 { get; set; }
        string Description_10 { get; set; }
        string Percent_11 { get; set; }
        string Amount_12 { get; set; }
        string Number_13 { get; set; }
        string StateorProvinceCode_14 { get; set; }
        string CountryCode_15 { get; set; }
        string StateorProvinceCode_16 { get; set; }
        string CountryCode_17 { get; set; }
    }
    
    public interface I_UDA
    {
        
        string OfferBasisCode_01 { get; set; }
        string Description_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string Quantity_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string Amount_06 { get; set; }
        string Percent_07 { get; set; }
    }
    
    public interface I_UIT<T1>
        where T1 : I_C001
    {
        
        T1 CompositeUnitofMeasure_01 { get; set; }
        string UnitPrice_02 { get; set; }
        string BasisofUnitPriceCode_03 { get; set; }
    }
    
    public interface I_UM<T1, T2>
        where T1 : I_C023
        where T2 : I_C024
    {
        
        string RequestCategoryCode_01 { get; set; }
        string CertificationTypeCode_02 { get; set; }
        string ServiceTypeCode_03 { get; set; }
        T1 HealthCareServiceLocationInformation_04 { get; set; }
        T2 RelatedCausesInformation_05 { get; set; }
        string LevelofServiceCode_06 { get; set; }
        string CurrentHealthConditionCode_07 { get; set; }
        string PrognosisCode_08 { get; set; }
        string ReleaseofInformationCode_09 { get; set; }
        string DelayReasonCode_10 { get; set; }
    }
    
    public interface I_UQS
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string FreeFormMessageText_03 { get; set; }
        string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    public interface I_UR
    {
        
        string ApprovalCode_01 { get; set; }
        string Quantity_02 { get; set; }
    }
    
    public interface I_USD<T1, T2>
        where T1 : I_C001
        where T2 : I_C001
    {
        
        string RelationshipCode_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string Rate_03 { get; set; }
        string Percent_04 { get; set; }
        T1 CompositeUnitofMeasure_05 { get; set; }
        string Quantity_06 { get; set; }
        string Quantity_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string Amount_09 { get; set; }
        T2 CompositeUnitofMeasure_10 { get; set; }
        string RangeMinimum_11 { get; set; }
        string RangeMaximum_12 { get; set; }
    }
    
    public interface I_UWI
    {
        
        string UnderwritingMethodCode_01 { get; set; }
        string Name_02 { get; set; }
        string DispositionCode_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
    }
    
    public interface I_V1
    {
        
        string VesselCode_01 { get; set; }
        string VesselName_02 { get; set; }
        string CountryCode_03 { get; set; }
        string FlightVoyageNumber_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string VesselRequirementCode_06 { get; set; }
        string VesselTypeCode_07 { get; set; }
        string VesselCodeQualifier_08 { get; set; }
        string TransportationMethodTypeCode_09 { get; set; }
    }
    
    public interface I_V2
    {
        
        string LocationIdentifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string Weight_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string Weight_07 { get; set; }
        string WeightUnitCode_08 { get; set; }
        string Weight_09 { get; set; }
        string WeightUnitCode_10 { get; set; }
        string Weight_11 { get; set; }
        string WeightUnitCode_12 { get; set; }
        string Name_13 { get; set; }
        string Length_14 { get; set; }
        string UnitorBasisforMeasurementCode_15 { get; set; }
        string Quantity_16 { get; set; }
        string Quantity_17 { get; set; }
    }
    
    public interface I_V3
    {
        
        string CurrentPortofLoading_01 { get; set; }
        string Date_02 { get; set; }
        string NextPortofDischarge_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_V4
    {
        
        string VesselStowageLocation_01 { get; set; }
    }
    
    public interface I_V5
    {
        
        string VesselCodeQualifier_01 { get; set; }
        string VesselCode_02 { get; set; }
        string CountryCode_03 { get; set; }
    }
    
    public interface I_V9
    {
        
        string EventCode_01 { get; set; }
        string Event_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string CityName_05 { get; set; }
        string StateorProvinceCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string StatusReasonCode_08 { get; set; }
        string StandardPointLocationCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string TrainDelayReasonCode_11 { get; set; }
        string FreeFormMessage_12 { get; set; }
        string TimeCode_13 { get; set; }
        string Quantity_14 { get; set; }
        string StandardPointLocationCode_15 { get; set; }
        string TotalEquipment_16 { get; set; }
        string TotalEquipment_17 { get; set; }
        string TotalEquipment_18 { get; set; }
        string Weight_19 { get; set; }
        string Length_20 { get; set; }
    }
    
    public interface I_VAD
    {
        
        string VehicleIdentificationNumber_01 { get; set; }
        string InvoiceNumber_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Rate_04 { get; set; }
        string DealerCode_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
        string ApplicationErrorConditionCode_07 { get; set; }
        string ApplicationErrorConditionCode_08 { get; set; }
        string ApplicationErrorConditionCode_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string Date_11 { get; set; }
    }
    
    public interface I_VAR
    {
        
        string IdentificationCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string CreditFileVariationCode_03 { get; set; }
        string CreditFileVariationCode_04 { get; set; }
        string CreditFileVariationCode_05 { get; set; }
        string CreditFileVariationCode_06 { get; set; }
        string CreditFileVariationCode_07 { get; set; }
    }
    
    public interface I_VAT
    {
        
        string IndustryCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string Amount_03 { get; set; }
        string CurrencyCode_04 { get; set; }
        string ProductProcessCharacteristicCode_05 { get; set; }
        string AgencyQualifierCode_06 { get; set; }
        string SourceSubqualifier_07 { get; set; }
        string IndustryCode_08 { get; set; }
        string Description_09 { get; set; }
        string Quantity_10 { get; set; }
        string UnitorBasisforMeasurementCode_11 { get; set; }
    }
    
    public interface I_VC
    {
        
        string VehicleIdentificationNumber_01 { get; set; }
        string VehicleDeckPositionCode_02 { get; set; }
        string VehicleTypeCode_03 { get; set; }
        string DealerCode_04 { get; set; }
        string RouteCode_05 { get; set; }
        string BayLocation_06 { get; set; }
        string AutomotiveManufacturersCode_07 { get; set; }
        string DamageExceptionIndicator_08 { get; set; }
        string SupplementalInspectionCode_09 { get; set; }
        string FactoryCarOrderNumber_10 { get; set; }
        string VesselStowageLocation_11 { get; set; }
    }
    
    public interface I_VC1
    {
        
        string Color_01 { get; set; }
        string Color_02 { get; set; }
        string VehicleDimension_03 { get; set; }
        string SpecialHandlingCode_04 { get; set; }
        string CurrencyCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
        string WeightUnitCode_07 { get; set; }
        string Weight_08 { get; set; }
        string MeasurementUnitQualifier_09 { get; set; }
        string Height_10 { get; set; }
        string Length_11 { get; set; }
        string Width_12 { get; set; }
        string VolumeUnitQualifier_13 { get; set; }
        string Volume_14 { get; set; }
        string LocationIdentifier_15 { get; set; }
    }
    
    public interface I_VDI<T1>
        where T1 : I_C046
    {
        
        string CodeCategory_01 { get; set; }
        T1 CompositeQualifierIdentifier_02 { get; set; }
        string Quantity_03 { get; set; }
        string Percent_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Number_06 { get; set; }
        string Number_07 { get; set; }
        string DateTimePeriodFormatQualifier_08 { get; set; }
        string DateTimePeriod_09 { get; set; }
        string UnitofTimePeriodorInterval_10 { get; set; }
        string Quantity_11 { get; set; }
        string Multiplier_12 { get; set; }
        string RoundingSystemCode_13 { get; set; }
        string LoanPaymentTypeCode_14 { get; set; }
        string LoanPaymentTypeCode_15 { get; set; }
    }
    
    public interface I_VEH
    {
        
        string AssignedNumber_01 { get; set; }
        string VehicleIdentificationNumber_02 { get; set; }
        string Year_03 { get; set; }
        string AgencyQualifierCode_04 { get; set; }
        string ProductDescriptionCode_05 { get; set; }
        string ProductDescriptionCode_06 { get; set; }
        string ProductDescriptionCode_07 { get; set; }
        string Length_08 { get; set; }
        string ReferenceIdentification_09 { get; set; }
        string StateorProvinceCode_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string YesNoConditionorResponseCode_12 { get; set; }
        string Amount_13 { get; set; }
        string YesNoConditionorResponseCode_14 { get; set; }
        string Amount_15 { get; set; }
        string ActionCode_16 { get; set; }
    }
    
    public interface I_VID
    {
        
        string EquipmentDescriptionCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string SealNumber_04 { get; set; }
        string SealNumber_05 { get; set; }
        string EquipmentLength_06 { get; set; }
        string Height_07 { get; set; }
        string Width_08 { get; set; }
        string EquipmentType_09 { get; set; }
        string LoadEmptyStatusCode_10 { get; set; }
        string TypeofServiceCode_11 { get; set; }
        string LocationIdentifier_12 { get; set; }
        string StandardCarrierAlphaCode_13 { get; set; }
    }
    
    public interface I_VR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TariffNumber_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string IdentificationCodeQualifier_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string CurrencyCode_06 { get; set; }
        string TariffAgencyCode_07 { get; set; }
        string TariffSupplementIdentifier_08 { get; set; }
        string ExParte_09 { get; set; }
    }
    
    public interface I_VRC
    {
        
        string DateTimePeriodFormatQualifier_01 { get; set; }
        string DateTimePeriod_02 { get; set; }
        string Quantity_03 { get; set; }
        string RecoveryConditionCode_04 { get; set; }
        string RecoveryClassificationCode_05 { get; set; }
    }
    
    public interface I_W01
    {
        
        string QuantityOrdered_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string UPCCaseCode_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string FreightClassCode_08 { get; set; }
        string RateClassCode_09 { get; set; }
        string CommodityCodeQualifier_10 { get; set; }
        string CommodityCode_11 { get; set; }
        string PalletBlockandTiers_12 { get; set; }
        string WarehouseLotNumber_13 { get; set; }
        string ProductServiceConditionCode_14 { get; set; }
        string ProductServiceIDQualifier_15 { get; set; }
        string ProductServiceID_16 { get; set; }
    }
    
    public interface I_W03
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string Weight_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Volume_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string LadingQuantity_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
    }
    
    public interface I_W04
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string UPCCaseCode_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string FreightClassCode_08 { get; set; }
        string RateClassCode_09 { get; set; }
        string CommodityCodeQualifier_10 { get; set; }
        string CommodityCode_11 { get; set; }
        string PalletBlockandTiers_12 { get; set; }
        string InboundConditionHoldCode_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
    }
    
    public interface I_W05
    {
        
        string OrderStatusCode_01 { get; set; }
        string DepositorOrderNumber_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string LinkSequenceNumber_04 { get; set; }
        string MasterReferenceLinkNumber_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
        string ActionCode_07 { get; set; }
    }
    
    public interface I_W06
    {
        
        string ReportingCode_01 { get; set; }
        string DepositorOrderNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ShipmentIdentificationNumber_04 { get; set; }
        string AgentShipmentIDNumber_05 { get; set; }
        string PurchaseOrderNumber_06 { get; set; }
        string MasterReferenceLinkNumber_07 { get; set; }
        string LinkSequenceNumber_08 { get; set; }
        string SpecialHandlingCode_09 { get; set; }
        string ShippingDateChangeReasonCode_10 { get; set; }
        string TransactionTypeCode_11 { get; set; }
        string ActionCode_12 { get; set; }
    }
    
    public interface I_W07
    {
        
        string QuantityReceived_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string UPCCaseCode_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string WarehouseLotNumber_08 { get; set; }
        string WarehouseDetailAdjustmentIdentifier_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
    }
    
    public interface I_W08
    {
        
        string TransportationMethodTypeCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Routing_03 { get; set; }
        string EquipmentInitial_04 { get; set; }
        string EquipmentNumber_05 { get; set; }
        string SealNumber_06 { get; set; }
        string SealNumber_07 { get; set; }
        string SealStatusCode_08 { get; set; }
        string UnitLoadOptionCode_09 { get; set; }
    }
    
    public interface I_W09
    {
        
        string EquipmentDescriptionCode_01 { get; set; }
        string Temperature_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Temperature_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
        string VentSettingCode_07 { get; set; }
        string Percent_08 { get; set; }
        string Quantity_09 { get; set; }
    }
    
    public interface I_W1
    {
        
        string BlockIdentification_01 { get; set; }
    }
    
    public interface I_W10
    {
        
        string UnitLoadOptionCode_01 { get; set; }
        string QuantityofPalletsShipped_02 { get; set; }
        string PalletExchangeCode_03 { get; set; }
        string SealNumber_04 { get; set; }
        string SealNumber_05 { get; set; }
        string Temperature_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Temperature_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
    }
    
    public interface I_W12
    {
        
        string ShipmentOrderStatusCode_01 { get; set; }
        string QuantityOrdered_02 { get; set; }
        string NumberofUnitsShipped_03 { get; set; }
        string QuantityDifference_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string UPCCaseCode_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string WarehouseLotNumber_09 { get; set; }
        string Weight_10 { get; set; }
        string WeightQualifier_11 { get; set; }
        string WeightUnitCode_12 { get; set; }
        string Weight_13 { get; set; }
        string WeightQualifier_14 { get; set; }
        string WeightUnitCode_15 { get; set; }
        string UPCCaseCode_16 { get; set; }
        string ProductServiceIDQualifier_17 { get; set; }
        string ProductServiceID_18 { get; set; }
        string LineItemChangeReasonCode_19 { get; set; }
        string WarehouseDetailAdjustmentIdentifier_20 { get; set; }
        string ProductServiceIDQualifier_21 { get; set; }
        string ProductServiceID_22 { get; set; }
    }
    
    public interface I_W13
    {
        
        string Quantity_01 { get; set; }
        string UnitorBasisforMeasurementCode_02 { get; set; }
        string ReceivingConditionCode_03 { get; set; }
        string WarehouseLotNumber_04 { get; set; }
        string DamageReasonCode_05 { get; set; }
    }
    
    public interface I_W14
    {
        
        string QuantityReceived_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string QuantityDamagedOnHold_03 { get; set; }
        string LadingQuantityReceived_04 { get; set; }
        string LadingQuantity_05 { get; set; }
    }
    
    public interface I_W15
    {
        
        string Date_01 { get; set; }
        string AdjustmentNumber_02 { get; set; }
        string AdjustmentNumber_03 { get; set; }
        string TransactionSetPurposeCode_04 { get; set; }
        string TransactionTypeCode_05 { get; set; }
        string ActionCode_06 { get; set; }
    }
    
    public interface I_W17
    {
        
        string ReportingCode_01 { get; set; }
        string Date_02 { get; set; }
        string WarehouseReceiptNumber_03 { get; set; }
        string DepositorOrderNumber_04 { get; set; }
        string ShipmentIdentificationNumber_05 { get; set; }
        string TimeQualifier_06 { get; set; }
        string Time_07 { get; set; }
        string MasterReferenceLinkNumber_08 { get; set; }
        string LinkSequenceNumber_09 { get; set; }
    }
    
    public interface I_W18
    {
        
        string TemperatureProbeLocationCode_01 { get; set; }
        string Temperature_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
    }
    
    public interface I_W19
    {
        
        string QuantityorStatusAdjustmentReasonCode_01 { get; set; }
        string CreditDebitQuantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string UPCCaseCode_04 { get; set; }
        string ProductServiceIDQualifier_05 { get; set; }
        string ProductServiceID_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string WarehouseLotNumber_09 { get; set; }
        string Weight_10 { get; set; }
        string WeightQualifier_11 { get; set; }
        string WeightUnitCode_12 { get; set; }
        string Weight_13 { get; set; }
        string WeightQualifier_14 { get; set; }
        string WeightUnitCode_15 { get; set; }
        string InventoryTransactionTypeCode_16 { get; set; }
        string ProductServiceIDQualifier_17 { get; set; }
        string ProductServiceID_18 { get; set; }
    }
    
    public interface I_W2
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string EquipmentDescriptionCode_04 { get; set; }
        string EquipmentStatusCode_05 { get; set; }
        string NetTons_06 { get; set; }
        string IntermodalServiceCode_07 { get; set; }
        string CarServiceOrderCode_08 { get; set; }
        string Date_09 { get; set; }
        string TypeofLocomotiveMaintenanceCode_10 { get; set; }
        string EquipmentInitial_11 { get; set; }
        string EquipmentNumber_12 { get; set; }
        string EquipmentNumberCheckDigit_13 { get; set; }
        string Position_14 { get; set; }
        string CarTypeCode_15 { get; set; }
        string YesNoConditionorResponseCode_16 { get; set; }
    }
    
    public interface I_W20
    {
        
        string Pack_01 { get; set; }
        string Size_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Weight_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string WeightUnitCode_06 { get; set; }
        string UnitWeight_07 { get; set; }
        string Volume_08 { get; set; }
        string UnitorBasisforMeasurementCode_09 { get; set; }
        string Color_10 { get; set; }
    }
    
    public interface I_W27
    {
        
        string TransportationMethodTypeCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Routing_03 { get; set; }
        string ShipmentMethodofPayment_04 { get; set; }
        string EquipmentDescriptionCode_05 { get; set; }
        string EquipmentInitial_06 { get; set; }
        string EquipmentNumber_07 { get; set; }
        string ShipmentOrderStatusCode_08 { get; set; }
        string SpecialHandlingCode_09 { get; set; }
        string CarrierRouteChangeReasonCode_10 { get; set; }
    }
    
    public interface I_W28
    {
        
        string ConsolidationCode_01 { get; set; }
        string Weight_02 { get; set; }
        string WeightQualifier_03 { get; set; }
        string WeightUnitCode_04 { get; set; }
        string TotalStopoffs_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string BillofLadingWaybillNumber_08 { get; set; }
    }
    
    public interface I_W3
    {
        
        string WaybillNumber_01 { get; set; }
        string Date_02 { get; set; }
        string AbbreviatedCustomerName_03 { get; set; }
        string CityName_04 { get; set; }
        string StateorProvinceCode_05 { get; set; }
        string CityNameQualifierCode_06 { get; set; }
    }
    
    public interface I_W4
    {
        
        string AbbreviatedCustomerName_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string FreightStationAccountingCode_03 { get; set; }
        string CityName_04 { get; set; }
        string StateorProvinceCode_05 { get; set; }
    }
    
    public interface I_W5
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string CityName_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string CityName_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string CityName_06 { get; set; }
    }
    
    public interface I_W6
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialHandlingCode_02 { get; set; }
        string SpecialHandlingCode_03 { get; set; }
        string SpecialHandlingCode_04 { get; set; }
    }
    
    public interface I_W66
    {
        
        string ShipmentMethodofPayment_01 { get; set; }
        string TransportationMethodTypeCode_02 { get; set; }
        string PalletExchangeCode_03 { get; set; }
        string UnitLoadOptionCode_04 { get; set; }
        string Routing_05 { get; set; }
        string FOBPointCode_06 { get; set; }
        string FOBPoint_07 { get; set; }
        string CODMethodofPaymentCode_08 { get; set; }
        string Amount_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
    }
    
    public interface I_W76
    {
        
        string QuantityOrdered_01 { get; set; }
        string Weight_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string Volume_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
        string OrderSizingFactor_06 { get; set; }
    }
    
    public interface I_WGP
    {
        
        string Weight_01 { get; set; }
        string Weight_02 { get; set; }
        string Weight_03 { get; set; }
        string Weight_04 { get; set; }
        string Weight_05 { get; set; }
        string Weight_06 { get; set; }
        string Weight_07 { get; set; }
        string Weight_08 { get; set; }
        string Weight_09 { get; set; }
        string Weight_10 { get; set; }
        string Weight_11 { get; set; }
        string Weight_12 { get; set; }
        string Weight_13 { get; set; }
        string Weight_14 { get; set; }
        string Weight_15 { get; set; }
        string Weight_16 { get; set; }
    }
    
    public interface I_WS
    {
        
        string ShipDeliveryorCalendarPatternCode_01 { get; set; }
        string Time_02 { get; set; }
        string Time_03 { get; set; }
    }
    
    public interface I_X01
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string VesselCodeQualifier_04 { get; set; }
        string VesselCode_05 { get; set; }
        string VesselName_06 { get; set; }
        string FlightVoyageNumber_07 { get; set; }
        string DateTimeQualifier_08 { get; set; }
        string Date_09 { get; set; }
        string Quantity_10 { get; set; }
    }
    
    public interface I_X02
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string BillofLadingWaybillNumber_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string BillofLadingWaybillNumber_05 { get; set; }
    }
    
    public interface I_X1
    {
        
        string LicensingAgencyCode_01 { get; set; }
        string ExportLicenseNumber_02 { get; set; }
        string ExportLicenseStatusCode_03 { get; set; }
        string Date_04 { get; set; }
        string ExportLicenseSymbolCode_05 { get; set; }
        string ExportLicenseControlCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string ScheduleBCode_08 { get; set; }
        string InternationalDomesticCode_09 { get; set; }
        string LadingQuantity_10 { get; set; }
        string LadingValue_11 { get; set; }
        string ExportFilingKeyCode_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string UnitPrice_14 { get; set; }
        string USGovernmentLicenseType_15 { get; set; }
        string IdentificationCode_16 { get; set; }
    }
    
    public interface I_X2
    {
        
        string ImportLicenseNumber_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
        string ImportLicenseNumber_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_X4
    {
        
        string BillofLadingWaybillNumber_01 { get; set; }
        string Quantity_02 { get; set; }
        string CustomsEntryTypeCode_03 { get; set; }
        string CustomsEntryNumber_04 { get; set; }
        string Date_05 { get; set; }
        string Time_06 { get; set; }
        string DispositionCode_07 { get; set; }
        string BillofLadingWaybillNumber_08 { get; set; }
        string StandardCarrierAlphaCode_09 { get; set; }
        string StandardCarrierAlphaCode_10 { get; set; }
        string EquipmentInitial_11 { get; set; }
        string EquipmentNumber_12 { get; set; }
        string LocationIdentifier_13 { get; set; }
        string LocationIdentifier_14 { get; set; }
        string ReferenceIdentificationQualifier_15 { get; set; }
        string ReferenceIdentification_16 { get; set; }
        string TimeCode_17 { get; set; }
    }
    
    public interface I_X7
    {
        
        string FreeFormMessage_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
    }
    
    public interface I_XD
    {
        
        string SwitchTypeCode_01 { get; set; }
        string Zone_02 { get; set; }
        string Track_03 { get; set; }
        string Spot_04 { get; set; }
        string Spot_05 { get; set; }
        string StandardCarrierAlphaCode_06 { get; set; }
        string LoadEmptyStatusCode_07 { get; set; }
        string RejectReasonCode_08 { get; set; }
    }
    
    public interface I_XH
    {
        
        string CurrencyCode_01 { get; set; }
        string RelatedCompanyIndicationCode_02 { get; set; }
        string SpecialChargeorAllowanceCode_03 { get; set; }
        string Amount_04 { get; set; }
        string BlockCode_05 { get; set; }
        string ChemicalAnalysisPercentage_06 { get; set; }
        string UnitPrice_07 { get; set; }
    }
    
    public interface I_XPO
    {
        
        string PurchaseOrderNumber_01 { get; set; }
        string PurchaseOrderNumber_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
    }
    
    public interface I_XQ
    {
        
        string TransactionHandlingCode_01 { get; set; }
        string Date_02 { get; set; }
        string Date_03 { get; set; }
    }
    
    public interface I_Y1
    {
        
        string SailingFlightDateEstimated_01 { get; set; }
        string Date_02 { get; set; }
        string StandardCarrierAlphaCode_03 { get; set; }
        string TransportationMethodTypeCode_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string TariffServiceCode_08 { get; set; }
        string DateTimeQualifier_09 { get; set; }
    }
    
    public interface I_Y2
    {
        
        string NumberofContainers_01 { get; set; }
        string ContainerTypeRequestCode_02 { get; set; }
        string TypeofServiceCode_03 { get; set; }
        string EquipmentType_04 { get; set; }
        string TransportationMethodTypeCode_05 { get; set; }
        string IntermodalServiceCode_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string ContainerTermsCode_08 { get; set; }
        string ContainerTermsCodeQualifier_09 { get; set; }
        string TotalStopoffs_10 { get; set; }
    }
    
    public interface I_Y3
    {
        
        string BookingNumber_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string Date_03 { get; set; }
        string Date_04 { get; set; }
        string StandardPointLocationCode_05 { get; set; }
        string PierName_06 { get; set; }
        string Date_07 { get; set; }
        string Time_08 { get; set; }
        string TransportationMethodTypeCode_09 { get; set; }
        string TariffServiceCode_10 { get; set; }
        string TimeCode_11 { get; set; }
    }
    
    public interface I_Y4
    {
        
        string BookingNumber_01 { get; set; }
        string BookingNumber_02 { get; set; }
        string Date_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string NumberofContainers_05 { get; set; }
        string EquipmentType_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string LocationQualifier_08 { get; set; }
        string LocationIdentifier_09 { get; set; }
        string TypeofServiceCode_10 { get; set; }
    }
    
    public interface I_Y5
    {
        
        string BookingNumber_01 { get; set; }
    }
    
    public interface I_Y6
    {
        
        string AuthorityIdentifierCode_01 { get; set; }
        string Authority_02 { get; set; }
        string AuthorizationDate_03 { get; set; }
    }
    
    public interface I_Y7
    {
        
        string Priority_01 { get; set; }
        string PriorityCode_02 { get; set; }
        string PriorityCodeQualifier_03 { get; set; }
        string PortCallFileNumber_04 { get; set; }
        string Date_05 { get; set; }
    }
    
    public interface I_YNQ
    {
        
        string ConditionIndicator_01 { get; set; }
        string YesNoConditionorResponseCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string FreeFormMessageText_05 { get; set; }
        string FreeFormMessageText_06 { get; set; }
        string FreeFormMessageText_07 { get; set; }
        string CodeListQualifierCode_08 { get; set; }
        string IndustryCode_09 { get; set; }
        string FreeFormMessageText_10 { get; set; }
    }
    
    public interface I_ZA
    {
        
        string ActivityCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitorBasisforMeasurementCode_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string ReferenceIdentificationQualifier_06 { get; set; }
        string ReferenceIdentification_07 { get; set; }
        string YesNoConditionorResponseCode_08 { get; set; }
    }
    
    public interface I_ZC1
    {
        
        string ShipmentIdentificationNumber_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string TransactionReferenceNumber_04 { get; set; }
        string TransactionReferenceDate_05 { get; set; }
        string CorrectionIndicator_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string TransportationMethodTypeCode_08 { get; set; }
    }
    
    public interface I_ZD
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string TransactionReferenceNumber_05 { get; set; }
        string TransactionReferenceDate_06 { get; set; }
        string CorrectionIndicator_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
    }
    
    public interface I_ZR
    {
        
        string WaybillResponseCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string WaybillNumber_04 { get; set; }
        string Date_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
        string StandardCarrierAlphaCode_07 { get; set; }
        string Date_08 { get; set; }
        string InterlineSettlementSystemStatusActionorDisputeCode_09 { get; set; }
        string InterlineSettlementSystemStatusActionorDisputeCode_10 { get; set; }
        string ReferenceIdentification_11 { get; set; }
        string ReferenceIdentification_12 { get; set; }
        string CorrectionIndicator_13 { get; set; }
    }
    
    public interface I_ZT
    {
        
        string WaybillRequestCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string WaybillNumber_04 { get; set; }
        string Date_05 { get; set; }
    }
}
