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
    
    [Serializable()]
    [DataContract()]
    public class C001
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string UnitorBasisforMeasurementCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string Exponent_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string Multiplier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string UnitorBasisforMeasurementCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string Exponent_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string Multiplier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string UnitorBasisforMeasurementCode_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string Exponent_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string Multiplier_09 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual string UnitorBasisforMeasurementCode_10 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual string Exponent_11 { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual string Multiplier_12 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual string UnitorBasisforMeasurementCode_13 { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual string Exponent_14 { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual string Multiplier_15 { get; set; }
    }
    
    public interface I_C002
    {
        
        string PaperworkReportActionCode_01 { get; set; }
        string PaperworkReportActionCode_02 { get; set; }
        string PaperworkReportActionCode_03 { get; set; }
        string PaperworkReportActionCode_04 { get; set; }
        string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string PaperworkReportActionCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string PaperworkReportActionCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string PaperworkReportActionCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string PaperworkReportActionCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string PaperworkReportActionCode_05 { get; set; }
    }
    
    public interface I_C003
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
    
    [Serializable()]
    [DataContract()]
    public class C003
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ProductorServiceIDQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ProcedureCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ProcedureModifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ProcedureModifier_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ProcedureModifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ProcedureModifier_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string Description_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string ProductServiceID_08 { get; set; }
    }
    
    public interface I_C004
    {
        
        string DiagnosisCodePointer_01 { get; set; }
        string DiagnosisCodePointer_02 { get; set; }
        string DiagnosisCodePointer_03 { get; set; }
        string DiagnosisCodePointer_04 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C004
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string DiagnosisCodePointer_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string DiagnosisCodePointer_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DiagnosisCodePointer_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string DiagnosisCodePointer_04 { get; set; }
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
        string IndustryCode_08 { get; set; }
        string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C022
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string CodeListQualifierCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string IndustryCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string DateTimePeriodFormatQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string DateTimePeriod_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string MonetaryAmount_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string Quantity_06 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual string VersionIdentifier_07 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual string IndustryCode_08 { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public interface I_C023
    {
        
        string FacilityTypeCode_01 { get; set; }
        string FacilityCodeQualifier_02 { get; set; }
        string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C023
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string FacilityTypeCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string FacilityCodeQualifier_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    public interface I_C024
    {
        
        string RelatedCausesCode_01 { get; set; }
        string RelatedCausesCode_02 { get; set; }
        string RelatedCausesCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string CountryCode_05 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C024
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string RelatedCausesCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string RelatedCausesCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string RelatedCausesCode_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string StateorProvinceCode_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string CountryCode_05 { get; set; }
    }
    
    public interface I_C035
    {
        
        string ProviderSpecialtyCode_01 { get; set; }
        string AgencyQualifierCode_02 { get; set; }
        string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C035
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ProviderSpecialtyCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string AgencyQualifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string YesNoConditionorResponseCode_03 { get; set; }
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
    
    [Serializable()]
    [DataContract()]
    public class C040
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string ReferenceIdentificationQualifier_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string ReferenceIdentification_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string ReferenceIdentificationQualifier_03 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual string ReferenceIdentification_04 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual string ReferenceIdentificationQualifier_05 { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual string ReferenceIdentification_06 { get; set; }
    }
    
    public interface I_C056
    {
        
        string RaceorEthnicityCode_01 { get; set; }
        string CodeListQualifierCode_02 { get; set; }
        string IndustryCode_03 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    public class C056
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual string RaceorEthnicityCode_01 { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual string CodeListQualifierCode_02 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual string IndustryCode_03 { get; set; }
    }
}
