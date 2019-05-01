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
    
    public interface I_AMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string CreditDebitFlagCode_03 { get; set; }
    }
    
    public interface I_BAL
    {
        
        string BalanceTypeCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
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
    
    public interface I_CB1
    {
        
        string AcquisitionDataCode_01 { get; set; }
        string FinancingTypeCode_02 { get; set; }
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
    
    public interface I_CTB
    {
        
        string RestrictionsConditionsQualifier_01 { get; set; }
        string Description_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string Quantity_04 { get; set; }
        string AmountQualifierCode_05 { get; set; }
        string Amount_06 { get; set; }
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
    
    public interface I_DIS
    {
        
        string DiscountTermsTypeCode_01 { get; set; }
        string DiscountBaseQualifier_02 { get; set; }
        string DiscountBaseValue_03 { get; set; }
        string DiscountControlLimitQualifier_04 { get; set; }
        string DiscountControlLimit_05 { get; set; }
        string DiscountControlLimit_06 { get; set; }
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
    
    public interface I_DTM
    {
        
        string DateTimeQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
        string DateTimePeriodFormatQualifier_05 { get; set; }
        string DateTimePeriod_06 { get; set; }
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
    
    public interface I_G61
    {
        
        string ContactFunctionCode_01 { get; set; }
        string Name_02 { get; set; }
        string CommunicationNumberQualifier_03 { get; set; }
        string CommunicationNumber_04 { get; set; }
        string ContactInquiryReference_05 { get; set; }
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
    
    public interface I_LQ
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
    }
    
    public interface I_LS
    {
        
        string LoopIdentifierCode_01 { get; set; }
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
    
    public interface I_MSG
    {
        
        string FreeFormMessageText_01 { get; set; }
        string PrinterCarriageControlCode_02 { get; set; }
        string Number_03 { get; set; }
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
    
    public interface I_NTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_NX2
    {
        
        string AddressComponentQualifier_01 { get; set; }
        string AddressInformation_02 { get; set; }
        string CountyDesignator_03 { get; set; }
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
    
    public interface I_PCT
    {
        
        string PercentQualifier_01 { get; set; }
        string Percent_02 { get; set; }
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
    
    public interface I_PKG
    {
        
        string ItemDescriptionType_01 { get; set; }
        string PackagingCharacteristicCode_02 { get; set; }
        string AgencyQualifierCode_03 { get; set; }
        string PackagingDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
        string UnitLoadOptionCode_06 { get; set; }
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
    
    public interface I_QTY<T1>
        where T1 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string FreeFormMessage_04 { get; set; }
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
    
    public interface I_REF<T1>
        where T1 : I_C040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string Description_03 { get; set; }
        T1 ReferenceIdentifier_04 { get; set; }
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
    
    public interface I_TC2
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
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
}
