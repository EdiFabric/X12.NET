namespace EdiFabric.Rules.X12_004010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    [Serializable()]
    [Composite("C001")]
    public class C001
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public string Exponent_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public string Exponent_08 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public string Exponent_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public string Exponent_14 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040")]
    public class C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C037")]
    public class C037
    {
        
        [Required]
        [StringLength(1, 30)]
        [DataElement("817", typeof(X12_AN))]
        [Pos(1)]
        public string TaxInformationIdentificationNumber_01 { get; set; }
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(2)]
        public string ApplicationErrorConditionCode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C007")]
    public class C007
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        [DataElement("1638", typeof(X12_ID_1638))]
        [Pos(3)]
        public string ValueDetailCode_03 { get; set; }
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(4)]
        public string MeasurementSignificanceCode_04 { get; set; }
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(5)]
        public string UnitofTimePeriodorInterval_05 { get; set; }
        [DataElement("1637", typeof(X12_ID_1637))]
        [Pos(6)]
        public string NetGrossCode_06 { get; set; }
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(8)]
        public string Description_08 { get; set; }
    }
    
    [Serializable()]
    [Composite("C036")]
    public class C036
    {
        
        [DataElement("1395", typeof(X12_ID_1395))]
        [Pos(1)]
        public string ConfigurationTypeCode_01 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        [StringLength(1, 6)]
        [DataElement("863", typeof(X12_R))]
        [Pos(4)]
        public string XPeg_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("864", typeof(X12_R))]
        [Pos(5)]
        public string YPeg_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C048")]
    public class C048
    {
        
        [Required]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(1)]
        public string UseofProceedsCode_01 { get; set; }
        [DataElement("1680", typeof(X12_ID_1680))]
        [Pos(2)]
        public string RefinanceTypeCode_02 { get; set; }
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(3)]
        public string UseofProceedsCode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C047")]
    public class C047
    {
        
        [Required]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(1)]
        public string TypeofRealEstateAssetCode_01 { get; set; }
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(2)]
        public string TypeofRealEstateAssetCode_02 { get; set; }
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(3)]
        public string TypeofRealEstateAssetCode_03 { get; set; }
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(4)]
        public string TypeofRealEstateAssetCode_04 { get; set; }
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(5)]
        public string TypeofRealEstateAssetCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C046")]
    public class C046
    {
        
        [Required]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(1)]
        public string RateValueQualifier_01 { get; set; }
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(2)]
        public string RateValueQualifier_02 { get; set; }
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(3)]
        public string RateValueQualifier_03 { get; set; }
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(5)]
        public string RateValueQualifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C045")]
    public class C045
    {
        
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(1)]
        public string ConditionIndicator_01 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(2)]
        public string ConditionIndicator_02 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C043")]
    public class C043
    {
        
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(1)]
        public string IndustryCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003")]
    public class C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C035")]
    public class C035
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("1222", typeof(X12_AN))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022")]
    public class C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C024")]
    public class C024
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C023")]
    public class C023
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public string FacilityCodeValue_01 { get; set; }
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_ID))]
        [Pos(3)]
        public string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C033")]
    public class C033
    {
        
        [Required]
        [DataElement("1572", typeof(X12_ID_1572))]
        [Pos(1)]
        public string SecurityValueQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 1000000)]
        [DataElement("1573", typeof(X12_AN))]
        [Pos(2)]
        public string EncodedSecurityValue_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C050")]
    public class C050
    {
        
        [Required]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(1)]
        public string LookupValueProtocolCode_01 { get; set; }
        [Required]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(2)]
        public string FilterIDCode_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(3)]
        public string VersionIdentifier_03 { get; set; }
        [Required]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(4)]
        public string LookupValue_04 { get; set; }
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(5)]
        public string LookupValueProtocolCode_05 { get; set; }
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(6)]
        public string FilterIDCode_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(8)]
        public string LookupValue_08 { get; set; }
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(9)]
        public string LookupValueProtocolCode_09 { get; set; }
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(10)]
        public string FilterIDCode_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(11)]
        public string VersionIdentifier_11 { get; set; }
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(12)]
        public string LookupValue_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C042")]
    public class C042
    {
        
        [Required]
        [DataElement("426", typeof(X12_ID_426))]
        [Pos(1)]
        public string AdjustmentReasonCode_01 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C004")]
    public class C004
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C005")]
    public class C005
    {
        
        [Required]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(1)]
        public string ToothSurfaceCode_01 { get; set; }
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(2)]
        public string ToothSurfaceCode_02 { get; set; }
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(3)]
        public string ToothSurfaceCode_03 { get; set; }
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(4)]
        public string ToothSurfaceCode_04 { get; set; }
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(5)]
        public string ToothSurfaceCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C006")]
    public class C006
    {
        
        [Required]
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(1)]
        public string OralCavityDesignationCode_01 { get; set; }
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(2)]
        public string OralCavityDesignationCode_02 { get; set; }
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(3)]
        public string OralCavityDesignationCode_03 { get; set; }
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(4)]
        public string OralCavityDesignationCode_04 { get; set; }
        [DataElement("1361", typeof(X12_ID_1361))]
        [Pos(5)]
        public string OralCavityDesignationCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C030")]
    public class C030
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(1)]
        public string ElementPositioninSegment_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1528", typeof(X12_N0))]
        [Pos(2)]
        public string ComponentDataElementPositioninComposite_02 { get; set; }
    }
}
