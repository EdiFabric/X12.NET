namespace EdiFabric.Rules.HIPAA_5010
{
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using System;

    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_8 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_4 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_11))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_12 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_20))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_15 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_23))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_13 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_4))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_02 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public string VersionIdentifier_07 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002_ActionsIndicated_2 : C002
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [Composite("C001")]
    public class C001_CompositeUnitofMeasure : C001
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_08 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_09 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_12 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_14 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_02 { get; set; }
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_04 { get; set; }
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_7 : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_02 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_04 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Composite("C035")]
    public class C035_ProviderSpecialtyInformation : C035
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(3)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056_CompositeRaceorEthnicityInformation : C056
    {
        
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        public string RaceorEthnicityCode_01 { get; set; }
        [Paired(3)]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(2)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public string CodeListQualifierCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public string IndustryCode_03 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation_2 : C023
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Facility Code Value
        /// </summary>
        public string FacilityTypeCode_01 { get; set; }
        [Required]
        [DataElement("1332", typeof(X12_ID_1332_2))]
        [Pos(2)]
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        public string FacilityCodeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        public string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation_3 : C024
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(1)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public string RelatedCausesCode_01 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(2)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public string RelatedCausesCode_02 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public string RelatedCausesCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public string StateorProvinceCode_04 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Country Code
        /// </summary>
        public string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_3 : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_02 { get; set; }
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_04 { get; set; }
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_12 : C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_6))]
        [Pos(1)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [Composite("C004")]
    public class C004_CompositeDiagnosisCodePointer : C004
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public string DiagnosisCodePointer_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public string DiagnosisCodePointer_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public string DiagnosisCodePointer_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_9 : C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_10))]
        [Pos(1)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [Composite("C001")]
    public class C001_CompositeUnitofMeasure_2 : C001
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_6))]
        [Pos(1)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_08 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_09 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_12 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        /// <summary>
        /// Exponent
        /// </summary>
        public string Exponent_14 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_7 : C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_8))]
        [Pos(1)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public string ProductServiceID_08 { get; set; }
    }
}
