namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [Composite("C001")]
    public class C001_CompositeUnitofMeasure : IC001
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [Pos(2)]
        public string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [Pos(5)]
        public string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [Pos(8)]
        public string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [Pos(11)]
        public string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [Pos(14)]
        public string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002_ActionsIndicated : IC002
    {
        
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier : IC003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Pos(1)]
        public string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [Composite("C004")]
    public class C004_CompositeDiagnosisCodePointer : IC004
    {
        
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Surface
    /// </summary>
    [Serializable()]
    [Composite("C005")]
    public class C005_ToothSurface : IC005
    {
        
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [Pos(1)]
        public string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [Pos(2)]
        public string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [Pos(3)]
        public string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [Pos(4)]
        public string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [Pos(5)]
        public string ToothSurfaceCode_05 { get; set; }
    }
    
    /// <summary>
    /// Oral Cavity Designation
    /// </summary>
    [Serializable()]
    [Composite("C006")]
    public class C006_OralCavityDesignation : IC006
    {
        
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [Pos(1)]
        public string OralCavityDesignationCode_01 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [Pos(2)]
        public string OralCavityDesignationCode_02 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [Pos(3)]
        public string OralCavityDesignationCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [Pos(4)]
        public string OralCavityDesignationCode_04 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [Pos(5)]
        public string OralCavityDesignationCode_05 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation : IC022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation : IC023
    {
        
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [Pos(1)]
        public string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [Pos(3)]
        public string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation : IC024
    {
        
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Composite("C035")]
    public class C035_ProviderSpecialtyInformation : IC035
    {
        
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier : IC040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Adjustment Identifier
    /// </summary>
    [Serializable()]
    [Composite("C042")]
    public class C042_AdjustmentIdentifier : IC042
    {
        
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [Pos(1)]
        public string AdjustmentReasonCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Pos(2)]
        public string ProviderAdjustmentIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus : IC043
    {
        
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(1)]
        public string HealthCareClaimStatusCategoryCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(2)]
        public string StatusCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(4)]
        public string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Medicare Status Code
    /// </summary>
    [Serializable()]
    [Composite("C052")]
    public class C052_MedicareStatusCode : IC052
    {
        
        /// <summary>
        /// Medicare Plan Code
        /// </summary>
        [Pos(1)]
        public string MedicarePlanCode_01 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [Pos(2)]
        public string EligibilityReasonCode_02 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [Pos(3)]
        public string EligibilityReasonCode_03 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [Pos(4)]
        public string EligibilityReasonCode_04 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056_CompositeRaceorEthnicityInformation : IC056
    {
        
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [Pos(1)]
        public string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Pos(2)]
        public string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Pos(3)]
        public string IndustryCode_03 { get; set; }
    }
}
