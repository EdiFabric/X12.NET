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
    /// Sales Tax Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_7))]
    public class AMT_SalesTaxAmount : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_7))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Postage Claimed Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_10))]
    public class AMT_PostageClaimedAmount : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_10))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Payer Paid Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_CoordinationofBenefits : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Total Non-covered Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_CoordinationofBenefits_2 : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_6))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Remaining Patient Liability
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_RemainingPatientLiability : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_5))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_8), typeof(X12_ID_1073_4))]
    public class CRC_AmbulanceCertification : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_8))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Hospice Employee Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_4))]
    public class CRC_HospiceEmployeeIndicator : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_4))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Condition Indicator/Durable Medical Equipment
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_4))]
    public class CRC_ConditionIndicator : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_5))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Patient Condition Information: Vision
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_4))]
    public class CRC_PatientConditionInformation : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Homebound Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073))]
    public class CRC_HomeboundIndicator : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_2))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// EPSDT Referral
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_4))]
    public class CRC_EPSDTReferral : CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_3))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_2))]
    public class DTP_ClaimLevelServiceDate : DTP
    {
        
        /// <summary>
        /// Date Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Claim Service Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Hearing and Vision Prescription Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_48), typeof(X12_ID_1250_6))]
    public class DTP_HearingandVisionPrescriptionDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_48))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// DATE - Certification Revision/Recertification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250_6))]
    public class DTP_CertificationRevision : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_21))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Begin Therapy Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250_6))]
    public class DTP_BeginTherapyDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_22))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Certification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250_6))]
    public class DTP_LastCertificationDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_23))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Seen Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_36), typeof(X12_ID_1250_6))]
    public class DTP_LastSeenDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_36))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Test Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_24), typeof(X12_ID_1250_6))]
    public class DTP_TestDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Shipped Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_25), typeof(X12_ID_1250_6))]
    public class DTP_ShippedDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_25))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last X-ray Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_46), typeof(X12_ID_1250_6))]
    public class DTP_LastXrayDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_46))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Initial Treatment Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_32), typeof(X12_ID_1250_6))]
    public class DTP_InitialTreatmentDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_32))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Onset of Current Illness or Symptom
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250_6))]
    public class DTP_OnsetofCurrentIllnessorSymptom : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_20))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Acute Manifestation
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_40), typeof(X12_ID_1250_6))]
    public class DTP_AcuteManifestation : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_40))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Accident Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_6))]
    public class DTP_AccidentDate_2 : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_19))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Menstrual Period
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250_6))]
    public class DTP_LastMenstrualPeriod : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_16))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Disability Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250_2))]
    public class DTP_DisabilityDates : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_3))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Worked
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250_6))]
    public class DTP_LastWorked : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_5))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Authorized Return to Work
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250_6))]
    public class DTP_AuthorizedReturntoWork : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_6))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Admission
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_6))]
    public class DTP_AdmissionDate_4 : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_7))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Discharge
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_6))]
    public class DTP_Discharge : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Assumed and Relinquished Care Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250_6))]
    public class DTP_AssumedandRelinquishedCareDates : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Date of First Contact
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250_6))]
    public class DTP_PropertyandCasualtyDateofFirstContact : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_10))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Repricer Received Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250_6))]
    public class DTP_RepricerReceivedDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_11))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_11))]
    public class HI_DependentHealthCareDiagnosisCode : HI<C022_HealthCareCodeInformation_8, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_8 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Anesthesia Related Procedure
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_20), typeof(X12_ID_1270_23))]
    public class HI_AnesthesiaRelatedProcedure : HI<C022_HealthCareCodeInformation_12, C022_HealthCareCodeInformation_15, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_12 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation_15 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Condition Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_4), typeof(X12_ID_1270_4))]
    public class HI_ConditionInformation : HI<C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13>
    {
        
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(2)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(3)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(4)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(5)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(6)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(7)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(8)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(9)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(10)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(11)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [Pos(12)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Line Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_LineNote : NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Required]
        [DataElement("363", typeof(X12_ID_363_2))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Third Party Organization Notes
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ThirdPartyOrganizationNotes : NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Required]
        [DataElement("363", typeof(X12_ID_363_3))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_2 : PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Required]
        [DataElement("756", typeof(X12_ID_756_5))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_16))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certificate of Medical Necessity Indicator
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator : PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Required]
        [DataElement("755", typeof(X12_ID_755_2))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Patient Count
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_11))]
    public class QTY_AmbulancePatientCount : QTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Required]
        [DataElement("673", typeof(X12_ID_673_11))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [RequiredAny(4)]
        [Exclusion(4)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Obstetric Anesthesia Additional Units
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_4))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits : QTY<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [Required]
        [DataElement("673", typeof(X12_ID_673_4))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [RequiredAny(4)]
        [Exclusion(4)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Secondary Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_75))]
    public class REF_OtherPayerSecondaryIdentifier : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_75))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Prior Authorization Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_OtherPayerPriorAuthorizationNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_6))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referral Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_3))]
    public class REF_OtherPayerReferralNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Adjustment Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerClaimAdjustmentIndicator : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_OtherPayerClaimControlNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_8))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_RepricedLineItemReferenceNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_32))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_33))]
    public class REF_AdjustedRepricedLineItemReferenceNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_33))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Line Item Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_LineItemControlNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_28))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mammography Certification Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_11))]
    public class REF_MammographyCertificationNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_11))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Clinical Laboratory Improvement Amendment (CLIA) Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_ClinicalLaboratoryImprovementAmendment : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_41))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_41))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Immunization Batch Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_42))]
    public class REF_ImmunizationBatchNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_42))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_51))]
    public class REF_Pay : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_51))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_22))]
    public class REF_BillingProviderTaxIdentification_2 : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_60))]
    public class REF_OtherSubscriberSecondaryIdentification : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_60))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_69))]
    public class REF_PropertyandCasualtyClaimNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_69))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_2))]
    public class REF_BillingProviderSecondaryIdentification : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Authorization Exception Code
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7), typeof(X12_ID_127))]
    public class REF_ServiceAuthorizationExceptionCode : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [DataElement("127", typeof(X12_ID_127))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mandatory Medicare (Section 4081) Crossover Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [DataElement("127", typeof(X12_ID_127_2))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_RepricedClaimNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_12))]
    public class REF_AdjustedRepricedClaimNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_12))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Investigational Device Exemption Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_InvestigationalDeviceExemptionNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Identification Number For Clearinghouses and Other Transmission Intermediaries
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ClaimIdentificationNumberForClearinghousesandOtherTransmissionIntermediaries : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Medical Record Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_MedicalRecordNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Demonstration Project Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_DemonstrationProjectIdentifier : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_19))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Care Plan Oversight
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_CarePlanOversight : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_29))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_31))]
    public class REF_PropertyandCasualtyPatientIdentifier : REF<C040_ReferenceIdentifier_7>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier_7 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_BillingProviderTaxIdentification : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_21))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider UPIN/License Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_50))]
    public class REF_BillingProviderUPIN : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_50))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_21), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName_4 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_21))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Information Receiver Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Information Receiver First Name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Information Receiver Middle Name
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Information Receiver Primary Identifier
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_BillingProviderContactInformation : PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Required]
        [DataElement("366", typeof(X12_ID_366_4))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(4)]
        [Required]
        [DataElement("365", typeof(X12_ID_365_18))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(8)]
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_25), typeof(X12_ID_1065_3))]
    public class NM1_ReceiverName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_25))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_8))]
    public class HL_BillingProviderHierarchicalLevel : HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Required]
        [DataElement("735", typeof(X12_ID_735_8))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Required]
        [DataElement("736", typeof(X12_ID_736_3))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_10), typeof(X12_ID_128_35))]
    public class PRV_BillingProviderSpecialtyInformation : PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_10))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Paired(3)]
        [Required]
        [DataElement("128", typeof(X12_ID_128_35))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_31))]
    public class CUR_ForeignCurrencyInformation_3 : CUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_31))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [StringLength(4, 10)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataElement("374", typeof(X12_ID_374_51))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Conditional(7)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Conditional(7)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [ConditionalAny(11, 12)]
        [DataElement("374", typeof(X12_ID_374_51))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Conditional(10)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Conditional(10)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [ConditionalAny(14, 15)]
        [DataElement("374", typeof(X12_ID_374_51))]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Conditional(13)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Conditional(13)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [ConditionalAny(17, 18)]
        [DataElement("374", typeof(X12_ID_374_51))]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Conditional(16)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Conditional(16)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [ConditionalAny(20, 21)]
        [DataElement("374", typeof(X12_ID_374_51))]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Conditional(19)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Conditional(19)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_2))]
    public class HL_SubscriberHierarchicalLevel : HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Required]
        [DataElement("735", typeof(X12_ID_735_2))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Required]
        [DataElement("736", typeof(X12_ID_736))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_6))]
    public class SBR_SubscriberInformation : SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [Required]
        [DataElement("1138", typeof(X12_ID_1138_2))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataElement("1069", typeof(X12_ID_1069_6))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataElement("1336", typeof(X12_ID_1336_3))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataElement("1143", typeof(X12_ID_1143_2))]
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataElement("584", typeof(X12_ID_584_2))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataElement("1032", typeof(X12_ID_1032_3))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_5), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_3 : PAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataElement("1069", typeof(X12_ID_1069_5))]
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataElement("584", typeof(X12_ID_584_2))]
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(8)]
        [DataElement("355", typeof(X12_ID_355_16))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_4))]
    public class HL_DependentLevel : HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [Required]
        [DataElement("735", typeof(X12_ID_735_4))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [Required]
        [DataElement("736", typeof(X12_ID_736_2))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
    public class PAT_PatientInformation : PAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_2))]
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataElement("584", typeof(X12_ID_584_2))]
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(8)]
        [DataElement("355", typeof(X12_ID_355_16))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_2))]
    public class NM1_BillingProviderName_2 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_31))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Address
    /// </summary>
    [Serializable()]
    [Segment("N3")]
    public class N3_AdditionalPatientInformationContactAddress : N3
    {
        
        /// <summary>
        /// Address Information
        /// </summary>
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string ResponseContactAddressLine_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string ResponseContactAddressLine_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [Segment("N4")]
    public class N4_AdditionalPatientInformationContactCity : N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [Exclusion(7)]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        public string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(3)]
        public string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [Conditional(4)]
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_AN))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_36), typeof(X12_ID_1065_2))]
    public class NM1_Pay : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_36))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_23), typeof(X12_ID_1065_3))]
    public class NM1_Pay_3 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_23))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_20))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_SubscriberName_5 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_26))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_8))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Demographic Information
    /// </summary>
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_PatientDemographicInformation : DMG<C056_CompositeRaceorEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Paired(2)]
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [Required]
        [DataElement("1068", typeof(X12_ID_1068_2))]
        [Pos(3)]
        public string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [ListCount(10)]
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        public string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Paired(11)]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_PropertyandCasualtyPatientContactInformation : PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [Required]
        [DataElement("366", typeof(X12_ID_366_4))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(4)]
        [Required]
        [DataElement("365", typeof(X12_ID_365_8))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("365", typeof(X12_ID_365_7))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [Paired(8)]
        [DataElement("365", typeof(X12_ID_365_12))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_29), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_29))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_20))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_PatientName_3 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_13))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Claim Information
    /// </summary>
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation_2 : CLM<C023_HealthCareServiceLocationInformation_2, C024_RelatedCausesInformation_3>
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [Required]
        [StringLength(1, 38)]
        [DataElement("1028", typeof(X12_AN))]
        [Pos(1)]
        public string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(3)]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        [DataElement("1343", typeof(X12_ID_1343))]
        [Pos(4)]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [Required]
        [Pos(5)]
        public C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(6)]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        [Required]
        [DataElement("1359", typeof(X12_ID_1359_2))]
        [Pos(7)]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_5))]
        [Pos(8)]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Required]
        [DataElement("1363", typeof(X12_ID_1363_2))]
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(10)]
        public string PatientSignatureSourceCode_10 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [Pos(11)]
        public C024_RelatedCausesInformation_3 RelatedCausesInformation_11 { get; set; }
        /// <summary>
        /// Special Program Code
        /// </summary>
        [DataElement("1366", typeof(X12_ID_1366_3))]
        [Pos(12)]
        public string SpecialProgramCode_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataElement("1338", typeof(X12_ID_1338))]
        [Pos(14)]
        public string LevelofServiceCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(16)]
        public string ProviderAgreementCode_16 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [DataElement("1029", typeof(X12_ID_1029_2))]
        [Pos(17)]
        public string ClaimStatusCode_17 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(18)]
        public string YesNoConditionorResponseCode_18 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(19)]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataElement("1514", typeof(X12_ID_1514_2))]
        [Pos(20)]
        public string DelayReasonCode_20 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_5), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_3 : PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [Required]
        [DataElement("755", typeof(X12_ID_755_5))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [Required]
        [DataElement("756", typeof(X12_ID_756_5))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_16))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [Pos(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166_2))]
    public class CN1_ContractInformation_2 : CN1
    {
        
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [Required]
        [DataElement("1166", typeof(X12_ID_1166_2))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Amount Paid
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_16))]
    public class AMT_PatientAmountPaid : AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [Required]
        [DataElement("522", typeof(X12_ID_522_16))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// File Information
    /// </summary>
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation : K3<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Fixed Format Information
        /// </summary>
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        /// <summary>
        /// Record Format Code
        /// </summary>
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_5))]
    public class NTE_ClaimNote_2 : NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [Required]
        [DataElement("363", typeof(X12_ID_363_5))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_7))]
    public class CR1_AmbulanceTransportInformation : CR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(2)]
        [DataElement("355", typeof(X12_ID_355_7))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [Required]
        [DataElement("1317", typeof(X12_ID_1317_2))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(6)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_9))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation : CR2
    {
        
        /// <summary>
        /// Count
        /// </summary>
        [Paired(2)]
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(1)]
        public string Count_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(3)]
        public string SubluxationLevelCode_03 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [Conditional(3)]
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(4)]
        public string SubluxationLevelCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(6)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        [Required]
        [DataElement("1342", typeof(X12_ID_1342))]
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(12)]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_ClaimPricing : HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [RequiredAny(13)]
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_2))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(10)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(12)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataElement("901", typeof(X12_ID_901_15))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_54), typeof(X12_ID_1065))]
    public class NM1_ReferringProviderName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_54))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_OrderingProviderSecondaryIdentification : REF<C040_ReferenceIdentifier_3>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_18))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_RenderingProviderName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_5), typeof(X12_ID_128_35))]
    public class PRV_RenderingProviderSpecialtyInformation : PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_5))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Paired(3)]
        [Required]
        [DataElement("128", typeof(X12_ID_128_35))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_AssistantSurgeonSecondaryIdentification : REF<C040_ReferenceIdentifier_3>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_23))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Facility Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065_3))]
    public class NM1_ServiceFacilityLocation : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_5))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_SupervisingProviderName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_3))]
    public class NM1_AmbulancePick : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065_3))]
    public class NM1_AmbulanceDrop : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_4))]
    public class SBR_OtherSubscriberInformation : SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [Required]
        [DataElement("1138", typeof(X12_ID_1138_2))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_4))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataElement("1336", typeof(X12_ID_1336_3))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataElement("1143", typeof(X12_ID_1143_2))]
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataElement("584", typeof(X12_ID_584_2))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataElement("1032", typeof(X12_ID_1032_3))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Adjustments
    /// </summary>
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033_2))]
    public class CAS_ClaimLevelAdjustments : CAS
    {
        
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        [Required]
        [DataElement("1033", typeof(X12_ID_1033_2))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [ConditionalAny(6, 7)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Conditional(5)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Conditional(5)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [ConditionalAny(9, 10)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Conditional(8)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Conditional(8)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [ConditionalAny(12, 13)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Conditional(11)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Conditional(11)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [ConditionalAny(15, 16)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Conditional(14)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Conditional(14)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [ConditionalAny(18, 19)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Conditional(17)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Conditional(17)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    /// <summary>
    /// Other Insurance Coverage Information
    /// </summary>
    [Serializable()]
    [Segment("OI", typeof(X12_ID_1032), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation_2 : OI
    {
        
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(1)]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(2)]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_5))]
        [Pos(3)]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(4)]
        public string PatientSignatureSourceCode_04 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(5)]
        public string ProviderAgreementCode_05 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [Required]
        [DataElement("1363", typeof(X12_ID_1363_2))]
        [Pos(6)]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Outpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation : MOA
    {
        
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(1)]
        public string ReimbursementRate_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(7)]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_OtherSubscriberName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_26))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_8))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Claim Check Or Remittance Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250_6))]
    public class DTP_ClaimCheckOrRemittanceDate : DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [Required]
        [DataElement("374", typeof(X12_ID_374_12))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_6))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_54), typeof(X12_ID_1065))]
    public class NM1_OtherPayerReferringProvider : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_54))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerRenderingProvider_2 : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerServiceFacilityLocation : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_5))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_OtherPayerSupervisingProvider : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerBillingProvider : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_31))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_12))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Header Number
    /// </summary>
    [Serializable()]
    [Segment("LX")]
    public class LX_HeaderNumber : LX
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_6))]
    public class SV1_ProfessionalService : SV1<C003_CompositeMedicalProcedureIdentifier_12, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier_12 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(4)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_11))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataElement("1365", typeof(X12_ID_1365_2))]
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [Required]
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [DataElement("1340", typeof(X12_ID_1340))]
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [DataElement("1364", typeof(X12_ID_1364))]
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1341", typeof(X12_AN))]
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataElement("1327", typeof(X12_ID_1327_2))]
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [StringLength(1, 1)]
        [DataElement("1334", typeof(X12_AN))]
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataElement("1337", typeof(X12_ID_1337))]
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Service
    /// </summary>
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_10), typeof(X12_ID_355_12))]
    public class SV5_DurableMedicalEquipmentService : SV5<C003_CompositeMedicalProcedureIdentifier_9>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier_9 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Required]
        [DataElement("355", typeof(X12_ID_355_12))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string LengthofMedicalNecessity_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [RequiredAny(5)]
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string DMERentalPrice_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string DMEPurchasePrice_05 { get; set; }
        /// <summary>
        /// Frequency Code
        /// </summary>
        [Conditional(4)]
        [Required]
        [DataElement("594", typeof(X12_ID_594_2))]
        [Pos(6)]
        public string RentalUnitPriceIndicator_06 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataElement("923", typeof(X12_ID_923))]
        [Pos(7)]
        public string PrognosisCode_07 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certification
    /// </summary>
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322_4), typeof(X12_ID_355_13))]
    public class CR3_DurableMedicalEquipmentCertification : CR3
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [Required]
        [DataElement("1322", typeof(X12_ID_1322_4))]
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(3)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_13))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        /// <summary>
        /// Insulin Dependent Code
        /// </summary>
        [DataElement("1335", typeof(X12_ID_1335))]
        [Pos(4)]
        public string InsulinDependentCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }
    
    /// <summary>
    /// Test Result
    /// </summary>
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult : MEA<C001_CompositeUnitofMeasure>
    {
        
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [Required]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [Required]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [RequiredAny(5, 6, 8)]
        [Required]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string TestResults_03 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Pos(4)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_04 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [ConditionalAny(4, 12)]
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [ConditionalAny(4, 12)]
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [ConditionalAny(3, 5, 6)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [Exclusion(3)]
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        [DataElement("1373", typeof(X12_ID_1373))]
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Paired(12)]
        [DataElement("1270", typeof(X12_ID_1270_28))]
        [Pos(11)]
        public string CodeListQualifierCode_11 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(12)]
        public string IndustryCode_12 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Information
    /// </summary>
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation : PS1
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    /// <summary>
    /// Line Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_LinePricing_3 : HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [RequiredAny(13)]
        [Required]
        [DataElement("1473", typeof(X12_ID_1473))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(10)]
        [DataElement("235", typeof(X12_ID_235_6))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [Paired(12)]
        [DataElement("355", typeof(X12_ID_355_11))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataElement("901", typeof(X12_ID_901_15))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Drug Identification
    /// </summary>
    [Serializable()]
    [Segment("LIN")]
    public class LIN_DrugIdentification_2 : LIN
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Required]
        [DataElement("235", typeof(X12_ID_235_11))]
        [Pos(2)]
        public string ProductorServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string NationalDrugCode_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(5)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(7)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(27)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(29)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [Paired(31)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }
    
    /// <summary>
    /// Drug Quantity
    /// </summary>
    [Serializable()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity : CTP<C001_CompositeUnitofMeasure_2>
    {
        
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Paired(5)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [Required]
        [Pos(5)]
        public C001_CompositeUnitofMeasure_2 CompositeUnitofMeasure_05 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [Conditional(7)]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [Conditional(2)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        /// <summary>
        /// Condition Value
        /// </summary>
        [Conditional(2)]
        [StringLength(1, 10)]
        [DataElement("499", typeof(X12_AN))]
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 2)]
        [DataElement("289", typeof(X12_N0))]
        [Pos(11)]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    /// <summary>
    /// Prescription or Compound Drug Association Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber : REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [Required]
        [DataElement("128", typeof(X12_ID_128_34))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_2))]
    public class NM1_PurchasedServiceProviderName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_18), typeof(X12_ID_1065))]
    public class NM1_OrderingProviderName : NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Required]
        [DataElement("98", typeof(X12_ID_98_18))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataElement("706", typeof(X12_ID_706_3))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_19))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation : SVD<C003_CompositeMedicalProcedureIdentifier_7>
    {
        
        /// <summary>
        /// Identification Code
        /// </summary>
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [Required]
        [Pos(3)]
        public C003_CompositeMedicalProcedureIdentifier_7 CompositeMedicalProcedureIdentifier_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(4)]
        public string ProductServiceID_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(6)]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    /// <summary>
    /// Form Identification Code
    /// </summary>
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_25))]
    public class LQ_FormIdentificationCode : LQ
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [Conditional(2)]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_25))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Supporting Documentation
    /// </summary>
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation : FRM
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string QuestionNumberLetter_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [RequiredAny(3, 4, 5)]
        [DataElement("1073", typeof(X12_ID_1073_5))]
        [Pos(2)]
        public string QuestionResponse_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string QuestionResponse_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string QuestionResponse_04 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_5), typeof(X12_ID_353_7))]
    public class BHT_BeginningofHierarchicalTransaction_7 : BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [Required]
        [DataElement("1005", typeof(X12_ID_1005_5))]
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [Required]
        [DataElement("353", typeof(X12_ID_353_7))]
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [Required]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [Required]
        [DataElement("640", typeof(X12_ID_640_6))]
        [Pos(6)]
        public string TransactionTypeCode_06 { get; set; }
    }
}
