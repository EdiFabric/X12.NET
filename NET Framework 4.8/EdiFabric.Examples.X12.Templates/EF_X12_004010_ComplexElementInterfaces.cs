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
    
    
    public interface I_C001
    {
        
        string UnitorBasisforMeasurementCode_01 { get; set; }
        string Exponent_02 { get; set; }
        string Multiplier_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Exponent_05 { get; set; }
        string Multiplier_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Exponent_08 { get; set; }
        string Multiplier_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Exponent_11 { get; set; }
        string Multiplier_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string Exponent_14 { get; set; }
        string Multiplier_15 { get; set; }
    }
    
    public interface I_C002
    {
        
        string PaperworkReportActionCode_01 { get; set; }
        string PaperworkReportActionCode_02 { get; set; }
        string PaperworkReportActionCode_03 { get; set; }
        string PaperworkReportActionCode_04 { get; set; }
        string PaperworkReportActionCode_05 { get; set; }
    }
    
    public interface I_C003
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string ProcedureModifier_03 { get; set; }
        string ProcedureModifier_04 { get; set; }
        string ProcedureModifier_05 { get; set; }
        string ProcedureModifier_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_C004
    {
        
        string DiagnosisCodePointer_01 { get; set; }
        string DiagnosisCodePointer_02 { get; set; }
        string DiagnosisCodePointer_03 { get; set; }
        string DiagnosisCodePointer_04 { get; set; }
    }
    
    public interface I_C005
    {
        
        string ToothSurfaceCode_01 { get; set; }
        string ToothSurfaceCode_02 { get; set; }
        string ToothSurfaceCode_03 { get; set; }
        string ToothSurfaceCode_04 { get; set; }
        string ToothSurfaceCode_05 { get; set; }
    }
    
    public interface I_C006
    {
        
        string OralCavityDesignationCode_01 { get; set; }
        string OralCavityDesignationCode_02 { get; set; }
        string OralCavityDesignationCode_03 { get; set; }
        string OralCavityDesignationCode_04 { get; set; }
        string OralCavityDesignationCode_05 { get; set; }
    }
    
    public interface I_C007
    {
        
        string AmountQualifierCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string ValueDetailCode_03 { get; set; }
        string MeasurementSignificanceCode_04 { get; set; }
        string UnitofTimePeriodorInterval_05 { get; set; }
        string NetGrossCode_06 { get; set; }
        string MeasurementSignificanceCode_07 { get; set; }
        string Description_08 { get; set; }
    }
    
    public interface I_C022
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Quantity_06 { get; set; }
        string VersionIdentifier_07 { get; set; }
    }
    
    public interface I_C023
    {
        
        string FacilityCodeValue_01 { get; set; }
        string FacilityCodeQualifier_02 { get; set; }
        string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    public interface I_C024
    {
        
        string RelatedCausesCode_01 { get; set; }
        string RelatedCausesCode_02 { get; set; }
        string RelatedCausesCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string CountryCode_05 { get; set; }
    }
    
    public interface I_C030
    {
        
        string ElementPositioninSegment_01 { get; set; }
        string ComponentDataElementPositioninComposite_02 { get; set; }
    }
    
    public interface I_C033
    {
        
        string SecurityValueQualifier_01 { get; set; }
        string EncodedSecurityValue_02 { get; set; }
    }
    
    public interface I_C035
    {
        
        string ProviderSpecialtyCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public interface I_C036
    {
        
        string ConfigurationTypeCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentification_03 { get; set; }
        string XPeg_04 { get; set; }
        string YPeg_05 { get; set; }
    }
    
    public interface I_C037
    {
        
        string TaxInformationIdentificationNumber_01 { get; set; }
        string ApplicationErrorConditionCode_02 { get; set; }
    }
    
    public interface I_C040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentificationQualifier_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
    }
    
    public interface I_C042
    {
        
        string AdjustmentReasonCode_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
    }
    
    public interface I_C043
    {
        
        string IndustryCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
    }
    
    public interface I_C045
    {
        
        string ConditionIndicator_01 { get; set; }
        string ConditionIndicator_02 { get; set; }
        string ConditionIndicator_03 { get; set; }
        string ConditionIndicator_04 { get; set; }
        string ConditionIndicator_05 { get; set; }
    }
    
    public interface I_C046
    {
        
        string RateValueQualifier_01 { get; set; }
        string RateValueQualifier_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string RateValueQualifier_05 { get; set; }
    }
    
    public interface I_C047
    {
        
        string TypeofRealEstateAssetCode_01 { get; set; }
        string TypeofRealEstateAssetCode_02 { get; set; }
        string TypeofRealEstateAssetCode_03 { get; set; }
        string TypeofRealEstateAssetCode_04 { get; set; }
        string TypeofRealEstateAssetCode_05 { get; set; }
    }
    
    public interface I_C048
    {
        
        string UseofProceedsCode_01 { get; set; }
        string RefinanceTypeCode_02 { get; set; }
        string UseofProceedsCode_03 { get; set; }
    }
    
    public interface I_C050
    {
        
        string LookupValueProtocolCode_01 { get; set; }
        string FilterIDCode_02 { get; set; }
        string VersionIdentifier_03 { get; set; }
        string LookupValue_04 { get; set; }
        string LookupValueProtocolCode_05 { get; set; }
        string FilterIDCode_06 { get; set; }
        string VersionIdentifier_07 { get; set; }
        string LookupValue_08 { get; set; }
        string LookupValueProtocolCode_09 { get; set; }
        string FilterIDCode_10 { get; set; }
        string VersionIdentifier_11 { get; set; }
        string LookupValue_12 { get; set; }
    }
}
