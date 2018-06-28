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
    
    
    public interface IC001
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
    
    public interface IC002
    {
        
        string PaperworkReportActionCode_01 { get; set; }
        string PaperworkReportActionCode_02 { get; set; }
        string PaperworkReportActionCode_03 { get; set; }
        string PaperworkReportActionCode_04 { get; set; }
        string PaperworkReportActionCode_05 { get; set; }
    }
    
    public interface IC003
    {
        
        string ProductorServiceIDQualifier_01 { get; set; }
        string ProcedureCode_02 { get; set; }
        string ProcedureModifier_03 { get; set; }
        string ProcedureModifier_04 { get; set; }
        string ProcedureModifier_05 { get; set; }
        string ProcedureModifier_06 { get; set; }
        string Description_07 { get; set; }
        string ProductServiceID_08 { get; set; }
    }
    
    public interface IC004
    {
        
        string DiagnosisCodePointer_01 { get; set; }
        string DiagnosisCodePointer_02 { get; set; }
        string DiagnosisCodePointer_03 { get; set; }
        string DiagnosisCodePointer_04 { get; set; }
    }
    
    public interface IC005
    {
        
        string ToothSurfaceCode_01 { get; set; }
        string ToothSurfaceCode_02 { get; set; }
        string ToothSurfaceCode_03 { get; set; }
        string ToothSurfaceCode_04 { get; set; }
        string ToothSurfaceCode_05 { get; set; }
    }
    
    public interface IC006
    {
        
        string OralCavityDesignationCode_01 { get; set; }
        string OralCavityDesignationCode_02 { get; set; }
        string OralCavityDesignationCode_03 { get; set; }
        string OralCavityDesignationCode_04 { get; set; }
        string OralCavityDesignationCode_05 { get; set; }
    }
    
    public interface IC022
    {
        
        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Quantity_06 { get; set; }
        string VersionIdentifier_07 { get; set; }
        string IndustryCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface IC023
    {
        
        string FacilityTypeCode_01 { get; set; }
        string FacilityCodeQualifier_02 { get; set; }
        string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    public interface IC024
    {
        
        string RelatedCausesCode_01 { get; set; }
        string RelatedCausesCode_02 { get; set; }
        string RelatedCausesCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string CountryCode_05 { get; set; }
    }
    
    public interface IC035
    {
        
        string ProviderSpecialtyCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public interface IC040
    {
        
        string ReferenceIdentificationQualifier_01 { get; set; }
        string ReferenceIdentification_02 { get; set; }
        string ReferenceIdentificationQualifier_03 { get; set; }
        string ReferenceIdentification_04 { get; set; }
        string ReferenceIdentificationQualifier_05 { get; set; }
        string ReferenceIdentification_06 { get; set; }
    }
    
    public interface IC042
    {
        
        string AdjustmentReasonCode_01 { get; set; }
        string ProviderAdjustmentIdentifier_02 { get; set; }
    }
    
    public interface IC043
    {
        
        string HealthCareClaimStatusCategoryCode_01 { get; set; }
        string StatusCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
        string CodeListQualifierCode_04 { get; set; }
    }
    
    public interface IC052
    {
        
        string MedicarePlanCode_01 { get; set; }
        string EligibilityReasonCode_02 { get; set; }
        string EligibilityReasonCode_03 { get; set; }
        string EligibilityReasonCode_04 { get; set; }
    }
    
    public interface IC056
    {
        
        string RaceorEthnicityCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
    }
}
