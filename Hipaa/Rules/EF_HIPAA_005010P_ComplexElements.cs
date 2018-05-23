namespace EdiFabric.Rules.HIPAA_5010
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
    public class C001_CompositeUnitofMeasure : C001
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00101 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00102 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00103 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00104 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00106 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00107 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00108 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00109 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00110 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00111 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00112 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00113 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00114 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00115 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [Composite("C001")]
    public class C001_CompositeUnitofMeasure_2 : C001
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_7))]
        [Pos(1)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00101 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00102 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00103 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00104 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00106 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00107 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00108 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00109 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00110 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00111 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00112 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string C00113 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        /// <summary>
        /// Exponent
        /// </summary>
        public new string C00114 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string C00115 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002_ActionsIndicated : C002
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public new string C00201 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public new string C00202 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public new string C00203 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public new string C00204 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        public new string C00205 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier : C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(1)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string C00301 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string C00302 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00303 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00304 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00305 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00306 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public new string C00307 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string C00308 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_2 : C003
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string C00301 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string C00302 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00303 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00304 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00305 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        public new string C00306 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public new string C00307 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string C00308 { get; set; }
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
        public new string C00401 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public new string C00402 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public new string C00403 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        public new string C00404 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_2))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_2 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_3 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_4))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_4 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_5 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_5))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_6 : C022
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C02201 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02202 { get; set; }
        [Paired(4)]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string C02203 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string C02204 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string C02205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string C02206 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string C02207 { get; set; }
        [Exclusion(9)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C02208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C02209 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation : C023
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Facility Code Value
        /// </summary>
        public new string C02301 { get; set; }
        [Required]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        public new string C02302 { get; set; }
        [Required]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        public new string C02303 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation : C024
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(1)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public new string C02401 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(2)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public new string C02402 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        public new string C02403 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public new string C02404 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Country Code
        /// </summary>
        public new string C02405 { get; set; }
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
        public new string C03501 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        public new string C03502 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(3)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string C03503 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04001 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04002 { get; set; }
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04003 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04004 { get; set; }
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04005 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04006 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_2 : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_24))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04001 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04002 { get; set; }
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04003 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04004 { get; set; }
        [Paired(6)]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04005 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04006 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_3 : C040
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04001 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04002 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04003 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04004 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string C04005 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string C04006 { get; set; }
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
        public new string C05601 { get; set; }
        [Paired(3)]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(2)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string C05602 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string C05603 { get; set; }
    }
}
