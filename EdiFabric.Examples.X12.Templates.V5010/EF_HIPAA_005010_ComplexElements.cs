namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001_CompositeUnitOfMeasure : C001, I_C001
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public override string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001_CompositeUnitOfMeasure_2 : C001, I_C001
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355_6))]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public override string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_ActionsIndicated_2 : C002, I_C002
    {
        
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public override string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public override string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public override string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public override string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public override string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_12 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235_6))]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_7 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235_8))]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_9 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235_10))]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C004")]
    public class C004_CompositeDiagnosisCodePointer : C004, I_C004
    {
        
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public override string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public override string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public override string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public override string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_12 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_20))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_13 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_4))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_15 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_23))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_4 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_11))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_8 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation_2 : C023, I_C023
    {
        
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public override string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1332", typeof(X12_ID_1332_2))]
        [Pos(2)]
        public override string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        public override string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation_3 : C024, I_C024
    {
        
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(1)]
        public override string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(2)]
        public override string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public override string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public override string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035_ProviderSpecialtyInformation : C035, I_C035
    {
        
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public override string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(3)]
        public override string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_3 : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_7 : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056_CompositeRaceOrEthnicityInformation : C056, I_C056
    {
        
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public override string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Paired(3)]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(2)]
        public override string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public override string IndustryCode_03 { get; set; }
    }
}
