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
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001_CompositeUnitOfMeasure_3 : C001, I_C001
    {
        
        [DataMember]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public override string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001_CompositeUnitOfMeasure_4 : C001, I_C001
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_ActionsIndicated : C002, I_C002
    {
        
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaperworkReportActionCode_05 { get; set; }
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
        [Pos(1)]
        public override string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_10 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_11 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
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
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_13 : C003, I_C003
    {
        
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_14 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_15 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_16 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_2 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_3 : C003, I_C003
    {
        
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_4 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_5 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_6 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003_CompositeMedicalProcedureIdentifier_8 : C003, I_C003
    {
        
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ProductorServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProcedureCode_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Surface
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C005")]
    public class C005_ToothSurface : C005, I_C005
    {
        
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ToothSurfaceCode_05 { get; set; }
    }
    
    /// <summary>
    /// Tooth Surface
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C005")]
    public class C005_ToothSurface_2 : C005, I_C005
    {
        
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ToothSurfaceCode_05 { get; set; }
    }
    
    /// <summary>
    /// Oral Cavity Designation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C006")]
    public class C006_OralCavityDesignation : C006, I_C006
    {
        
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string OralCavityDesignationCode_01 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string OralCavityDesignationCode_02 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OralCavityDesignationCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OralCavityDesignationCode_04 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string OralCavityDesignationCode_05 { get; set; }
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_10 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_11 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_14 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_16 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_17 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_18 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_19 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_2 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_20 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_21 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_22 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_23 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_24 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_25 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_3 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_5 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_6 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_7 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022_HealthCareCodeInformation_9 : C022, I_C022
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation : C023, I_C023
    {
        
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFrequencyTypeCode_03 { get; set; }
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
        [Pos(1)]
        public override string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation_3 : C023, I_C023
    {
        
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023_HealthCareServiceLocationInformation_4 : C023, I_C023
    {
        
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FacilityTypeCode_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation : C024, I_C024
    {
        
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation_2 : C024, I_C024
    {
        
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CountryCode_05 { get; set; }
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
        [Pos(1)]
        public override string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024_RelatedCausesInformation_4 : C024, I_C024
    {
        
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035_ProviderSpecialtyInformation_2 : C035, I_C035
    {
        
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_2 : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_4 : C040, I_C040
    {
        
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_5 : C040, I_C040
    {
        
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_6 : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040_ReferenceIdentifier_8 : C040, I_C040
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Adjustment Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042_AdjustmentIdentifier : C042, I_C042
    {
        
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdjustmentReasonCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProviderAdjustmentIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus : C043, I_C043
    {
        
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus_2 : C043, I_C043
    {
        
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus_3 : C043, I_C043
    {
        
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus_4 : C043, I_C043
    {
        
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus_5 : C043, I_C043
    {
        
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043_HealthCareClaimStatus_6 : C043, I_C043
    {
        
        [DataMember]
        [Pos(1)]
        public override string HealthCareClaimStatusCategoryCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public override string StatusCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public override string EntityIdentifierCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public override string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Medicare Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C052")]
    public class C052_MedicareStatusCode : C052, I_C052
    {
        
        /// <summary>
        /// Medicare Plan Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string MedicarePlanCode_01 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EligibilityReasonCode_02 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EligibilityReasonCode_03 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EligibilityReasonCode_04 { get; set; }
    }
    
    /// <summary>
    /// Medicare Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C052")]
    public class C052_MedicareStatusCode_2 : C052, I_C052
    {
        
        /// <summary>
        /// Medicare Plan Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string MedicarePlanCode_01 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EligibilityReasonCode_02 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EligibilityReasonCode_03 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EligibilityReasonCode_04 { get; set; }
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
        [Pos(1)]
        public override string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IndustryCode_03 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056_CompositeRaceOrEthnicityInformation_2 : C056, I_C056
    {
        
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IndustryCode_03 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056_CompositeRaceOrEthnicityInformation_3 : C056, I_C056
    {
        
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IndustryCode_03 { get; set; }
    }
}
