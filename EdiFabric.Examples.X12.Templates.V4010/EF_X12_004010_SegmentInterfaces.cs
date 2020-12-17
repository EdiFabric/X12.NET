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
    
    public interface I_AT5
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialServicesCode_02 { get; set; }
        string SpecialHandlingDescription_03 { get; set; }
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
    
    public interface I_BHT
    {
        
        string HierarchicalStructureCode_01 { get; set; }
        string TransactionSetPurposeCode_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string TransactionTypeCode_06 { get; set; }
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
    
    public interface I_BNX
    {
        
        string ShipmentWeightCode_01 { get; set; }
        string ReferencedPatternIdentifier_02 { get; set; }
        string BillingCode_03 { get; set; }
        string RepetitivePatternNumber_04 { get; set; }
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
    
    public interface I_CLD
    {
        
        string NumberofLoads_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string PackagingCode_03 { get; set; }
        string Size_04 { get; set; }
        string UnitorBasisforMeasurementCode_05 { get; set; }
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
    
    public interface I_CRD
    {
        
        string CountryCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Percent_04 { get; set; }
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
    
    public interface I_DTP
    {
        
        string DateTimeQualifier_01 { get; set; }
        string DateTimePeriodFormatQualifier_02 { get; set; }
        string DateTimePeriod_03 { get; set; }
    }
    
    public interface I_E1
    {
        
        string NameCharacterFormat_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
    }
    
    public interface I_E4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PostalCode_03 { get; set; }
        string CountryCode_04 { get; set; }
    }
    
    public interface I_E5
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
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
    
    public interface I_ETD
    {
        
        string ExcessTransportationReasonCode_01 { get; set; }
        string ExcessTransportationResponsibilityCode_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReturnableContainerFreightPaymentResponsibilityCode_05 { get; set; }
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
    
    public interface I_G26
    {
        
        string PriceConditionCode_01 { get; set; }
        string DateQualifier_02 { get; set; }
        string Date_03 { get; set; }
        string QuantityBasis_04 { get; set; }
        string Quantity_05 { get; set; }
        string UnitorBasisforMeasurementCode_06 { get; set; }
    }
    
    public interface I_G36
    {
        
        string PriceListNumber_01 { get; set; }
        string PriceListIssueNumber_02 { get; set; }
        string Date_03 { get; set; }
        string PriceConditionAppliesCode_04 { get; set; }
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
    
    public interface I_G43
    {
        
        string MarketAreaCodeQualifier_01 { get; set; }
        string MarketAreaCodeIdentifier_02 { get; set; }
        string Description_03 { get; set; }
        string ClassofTradeCode_04 { get; set; }
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
    
    public interface I_G69
    {
        
        string FreeformDescription_01 { get; set; }
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
    
    public interface I_HL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
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
    
    public interface I_IM
    {
        
        string WaterMovementCode_01 { get; set; }
        string SpecialHandlingCode_02 { get; set; }
        string InlandTransportationCode_03 { get; set; }
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
    
    public interface I_K1
    {
        
        string FreeFormMessage_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
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
    
    public interface I_L11
    {
        
        string ReferenceIdentification_01 { get; set; }
        string ReferenceIdentificationQualifier_02 { get; set; }
        string Description_03 { get; set; }
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
    
    public interface I_L9
    {
        
        string SpecialChargeorAllowanceCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
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
    
    public interface I_LX
    {
        
        string AssignedNumber_01 { get; set; }
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
    
    public interface I_NX2
    {
        
        string AddressComponentQualifier_01 { get; set; }
        string AddressInformation_02 { get; set; }
        string CountyDesignator_03 { get; set; }
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
    
    public interface I_POD
    {
        
        string Date_01 { get; set; }
        string Time_02 { get; set; }
        string Name_03 { get; set; }
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
    
    public interface I_Q7
    {
        
        string LadingExceptionCode_01 { get; set; }
        string PackagingFormCode_02 { get; set; }
        string LadingQuantity_03 { get; set; }
    }
    
    public interface I_QTY<T1>
        where T1 : I_C001
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        T1 CompositeUnitofMeasure_03 { get; set; }
        string FreeFormMessage_04 { get; set; }
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
    
    public interface I_TSD
    {
        
        string AssignedIdentification_01 { get; set; }
        string Position_02 { get; set; }
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
    
    public interface I_W6
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialHandlingCode_02 { get; set; }
        string SpecialHandlingCode_03 { get; set; }
        string SpecialHandlingCode_04 { get; set; }
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
    
    public interface I_X7
    {
        
        string FreeFormMessage_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
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
}
