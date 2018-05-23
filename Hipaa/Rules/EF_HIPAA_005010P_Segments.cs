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
    /// Coordination of Benefits (COB) Payer Paid Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_CoordinationofBenefits : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Total Non-covered Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_2))]
    public class AMT_CoordinationofBenefits_2 : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_2))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Patient Amount Paid
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_PatientAmountPaid : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_6))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Postage Claimed Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_PostageClaimedAmount : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_5))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Remaining Patient Liability
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_3))]
    public class AMT_RemainingPatientLiability : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_3))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Sales Tax Amount
    /// </summary>
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_SalesTaxAmount : AMT
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        public new string AMT01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string AMT02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        public new string AMT03 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353))]
    public class BHT_BeginningofHierarchicalTransaction : BHT
    {
        
        [Required]
        [DataElement("1005", typeof(X12_ID_1005))]
        [Pos(1)]
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        public new string BHT01 { get; set; }
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(2)]
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        public new string BHT02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string BHT03 { get; set; }
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        /// <summary>
        /// Date
        /// </summary>
        public new string BHT04 { get; set; }
        [Required]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        /// <summary>
        /// Time
        /// </summary>
        public new string BHT05 { get; set; }
        [Required]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(6)]
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        public new string BHT06 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Adjustments
    /// </summary>
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_ClaimLevelAdjustments : CAS
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033))]
        [Pos(1)]
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        public new string CAS01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS02 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS04 { get; set; }
        [ConditionalAny(6, 7)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS05 { get; set; }
        [Conditional(5)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS06 { get; set; }
        [Conditional(5)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS07 { get; set; }
        [ConditionalAny(9, 10)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS08 { get; set; }
        [Conditional(8)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS09 { get; set; }
        [Conditional(8)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS10 { get; set; }
        [ConditionalAny(12, 13)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(11)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS11 { get; set; }
        [Conditional(11)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS12 { get; set; }
        [Conditional(11)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS13 { get; set; }
        [ConditionalAny(15, 16)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(14)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS14 { get; set; }
        [Conditional(14)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS15 { get; set; }
        [Conditional(14)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS16 { get; set; }
        [ConditionalAny(18, 19)]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_AN))]
        [Pos(17)]
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        public new string CAS17 { get; set; }
        [Conditional(17)]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CAS18 { get; set; }
        [Conditional(17)]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CAS19 { get; set; }
    }
    
    /// <summary>
    /// Claim Information
    /// </summary>
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation : CLM
    {
        
        [Required]
        [StringLength(1, 38)]
        [DataElement("1028", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        public new string CLM01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CLM02 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(3)]
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        public new string CLM03 { get; set; }
        [DataElement("1343", typeof(X12_ID_1343))]
        [Pos(4)]
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        public new string CLM04 { get; set; }
        [Required]
        [Pos(5)]
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        public new C023_HealthCareServiceLocationInformation CLM05 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(6)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CLM06 { get; set; }
        [Required]
        [DataElement("1359", typeof(X12_ID_1359))]
        [Pos(7)]
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        public new string CLM07 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(8)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CLM08 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(9)]
        /// <summary>
        /// Release of Information Code
        /// </summary>
        public new string CLM09 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(10)]
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        public new string CLM10 { get; set; }
        [Pos(11)]
        /// <summary>
        /// Related Causes Information
        /// </summary>
        public new C024_RelatedCausesInformation CLM11 { get; set; }
        [DataElement("1366", typeof(X12_ID_1366))]
        [Pos(12)]
        /// <summary>
        /// Special Program Code
        /// </summary>
        public new string CLM12 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(13)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CLM13 { get; set; }
        [DataElement("1338", typeof(X12_ID_1338))]
        [Pos(14)]
        /// <summary>
        /// Level of Service Code
        /// </summary>
        public new string CLM14 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(15)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CLM15 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(16)]
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        public new string CLM16 { get; set; }
        [DataElement("1029", typeof(X12_ID_1029))]
        [Pos(17)]
        /// <summary>
        /// Claim Status Code
        /// </summary>
        public new string CLM17 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(18)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CLM18 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(19)]
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        public new string CLM19 { get; set; }
        [DataElement("1514", typeof(X12_ID_1514))]
        [Pos(20)]
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        public new string CLM20 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation : CN1
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        /// <summary>
        /// Contract Type Code
        /// </summary>
        public new string CN101 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CN102 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        public new string CN103 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string CN104 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        public new string CN105 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Version Identifier
        /// </summary>
        public new string CN106 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_2))]
    public class CR1_AmbulanceTransportInformation : CR1
    {
        
        [Paired(2)]
        [DataElement("355", typeof(X12_ID_355_2))]
        [Pos(1)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string CR101 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Weight
        /// </summary>
        public new string CR102 { get; set; }
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        public new string CR103 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317))]
        [Pos(4)]
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        public new string CR104 { get; set; }
        [Paired(6)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_3))]
        [Pos(5)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string CR105 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CR106 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Address Information
        /// </summary>
        public new string CR107 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Address Information
        /// </summary>
        public new string CR108 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Description
        /// </summary>
        public new string CR109 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        /// <summary>
        /// Description
        /// </summary>
        public new string CR110 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation : CR2
    {
        
        [Paired(2)]
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(1)]
        /// <summary>
        /// Count
        /// </summary>
        public new string CR201 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CR202 { get; set; }
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(3)]
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        public new string CR203 { get; set; }
        [Conditional(3)]
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(4)]
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        public new string CR204 { get; set; }
        [Paired(6)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string CR205 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CR206 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CR207 { get; set; }
        [Required]
        [DataElement("1342", typeof(X12_ID_1342))]
        [Pos(8)]
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        public new string CR208 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CR209 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        /// <summary>
        /// Description
        /// </summary>
        public new string CR210 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(11)]
        /// <summary>
        /// Description
        /// </summary>
        public new string CR211 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(12)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CR212 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certification
    /// </summary>
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322), typeof(X12_ID_355_6))]
    public class CR3_DurableMedicalEquipmentCertification : CR3
    {
        
        [Required]
        [DataElement("1322", typeof(X12_ID_1322))]
        [Pos(1)]
        /// <summary>
        /// Certification Type Code
        /// </summary>
        public new string CR301 { get; set; }
        [Paired(3)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_6))]
        [Pos(2)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string CR302 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CR303 { get; set; }
        [DataElement("1335", typeof(X12_ID_1335))]
        [Pos(4)]
        /// <summary>
        /// Insulin Dependent Code
        /// </summary>
        public new string CR304 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Description
        /// </summary>
        public new string CR305 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_6), typeof(X12_ID_1073_2))]
    public class CRC_AmbulanceCertification : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_6))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// Condition Indicator/Durable Medical Equipment
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_2))]
    public class CRC_ConditionIndicator : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_5))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// EPSDT Referral
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_2))]
    public class CRC_EPSDTReferral : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_3))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// Homebound Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073))]
    public class CRC_HomeboundIndicator : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_2))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// Hospice Employee Indicator
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_2))]
    public class CRC_HospiceEmployeeIndicator : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_4))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// Patient Condition Information: Vision
    /// </summary>
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_2))]
    public class CRC_PatientConditionInformation : CRC
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        /// <summary>
        /// Code Category
        /// </summary>
        public new string CRC01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string CRC02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        /// <summary>
        /// Condition Indicator
        /// </summary>
        public new string CRC07 { get; set; }
    }
    
    /// <summary>
    /// Drug Quantity
    /// </summary>
    [Serializable()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity : CTP
    {
        
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        public new string CTP01 { get; set; }
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        public new string CTP02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Unit Price
        /// </summary>
        public new string CTP03 { get; set; }
        [Paired(5)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string CTP04 { get; set; }
        [Required]
        [Pos(5)]
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        public new C001_CompositeUnitofMeasure_2 CTP05 { get; set; }
        [Conditional(7)]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        public new string CTP06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        /// <summary>
        /// Multiplier
        /// </summary>
        public new string CTP07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string CTP08 { get; set; }
        [Conditional(2)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(9)]
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        public new string CTP09 { get; set; }
        [Conditional(2)]
        [StringLength(1, 10)]
        [DataElement("499", typeof(X12_AN))]
        [Pos(10)]
        /// <summary>
        /// Condition Value
        /// </summary>
        public new string CTP10 { get; set; }
        [Conditional(3)]
        [StringLength(1, 2)]
        [DataElement("289", typeof(X12_N0))]
        [Pos(11)]
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        public new string CTP11 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_11))]
    public class CUR_ForeignCurrencyInformation : CUR
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string CUR01 { get; set; }
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Currency Code
        /// </summary>
        public new string CUR02 { get; set; }
        [StringLength(4, 10)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Exchange Rate
        /// </summary>
        public new string CUR03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(4)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string CUR04 { get; set; }
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Currency Code
        /// </summary>
        public new string CUR05 { get; set; }
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        public new string CUR06 { get; set; }
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(7)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string CUR07 { get; set; }
        [Conditional(7)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        /// <summary>
        /// Date
        /// </summary>
        public new string CUR08 { get; set; }
        [Conditional(7)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        /// <summary>
        /// Time
        /// </summary>
        public new string CUR09 { get; set; }
        [ConditionalAny(11, 12)]
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(10)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string CUR10 { get; set; }
        [Conditional(10)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        /// <summary>
        /// Date
        /// </summary>
        public new string CUR11 { get; set; }
        [Conditional(10)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        /// <summary>
        /// Time
        /// </summary>
        public new string CUR12 { get; set; }
        [ConditionalAny(14, 15)]
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(13)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string CUR13 { get; set; }
        [Conditional(13)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        /// <summary>
        /// Date
        /// </summary>
        public new string CUR14 { get; set; }
        [Conditional(13)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        /// <summary>
        /// Time
        /// </summary>
        public new string CUR15 { get; set; }
        [ConditionalAny(17, 18)]
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(16)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string CUR16 { get; set; }
        [Conditional(16)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        /// <summary>
        /// Date
        /// </summary>
        public new string CUR17 { get; set; }
        [Conditional(16)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        /// <summary>
        /// Time
        /// </summary>
        public new string CUR18 { get; set; }
        [ConditionalAny(20, 21)]
        [DataElement("374", typeof(X12_ID_374_24))]
        [Pos(19)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string CUR19 { get; set; }
        [Conditional(19)]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        /// <summary>
        /// Date
        /// </summary>
        public new string CUR20 { get; set; }
        [Conditional(19)]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        /// <summary>
        /// Time
        /// </summary>
        public new string CUR21 { get; set; }
    }
    
    /// <summary>
    /// Patient Demographic Information
    /// </summary>
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_3))]
    public class DMG_PatientDemographicInformation : DMG
    {
        
        [Paired(2)]
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(1)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DMG01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DMG02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        /// <summary>
        /// Gender Code
        /// </summary>
        public new string DMG03 { get; set; }
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        /// <summary>
        /// Marital Status Code
        /// </summary>
        public new string DMG04 { get; set; }
        [ListCount(10)]
        [Pos(5)]
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        public new List<C056_CompositeRaceorEthnicityInformation> DMG05 { get; set; }
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        public new string DMG06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Country Code
        /// </summary>
        public new string DMG07 { get; set; }
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        public new string DMG08 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string DMG09 { get; set; }
        [Paired(11)]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(10)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string DMG10 { get; set; }
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string DMG11 { get; set; }
    }
    
    /// <summary>
    /// Claim Check or Remittance Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250_3))]
    public class DTP_ClaimCheckorRemittanceDate : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Accident
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250_3))]
    public class DTP_Date : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_20))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// DATE - Certification Revision/Recertification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250_3))]
    public class DTP_DATE : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_12))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Initial Treatment Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_17), typeof(X12_ID_1250_3))]
    public class DTP_Date_10 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_17))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Certification Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_14), typeof(X12_ID_1250_3))]
    public class DTP_Date_11 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_14))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Menstrual Period
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250_3))]
    public class DTP_Date_12 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_21))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Seen Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_18), typeof(X12_ID_1250_3))]
    public class DTP_Date_13 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_18))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Worked
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250_3))]
    public class DTP_Date_14 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_2))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last X-ray Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250_3))]
    public class DTP_Date_15 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_22))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Onset of Current Illness or Symptom
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250_3))]
    public class DTP_Date_16 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_11))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Repricer Received Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_3))]
    public class DTP_Date_17 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Service Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250))]
    public class DTP_Date_18 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_10))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Shipped Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250_3))]
    public class DTP_Date_19 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_16))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Acute Manifestation
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_3))]
    public class DTP_Date_2 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_19))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Test Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_15), typeof(X12_ID_1250_3))]
    public class DTP_Date_20 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_15))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Admission
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_3))]
    public class DTP_Date_3 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Assumed and Relinquished Care Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250_3))]
    public class DTP_Date_4 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_6))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Authorized Return to Work
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250_3))]
    public class DTP_Date_5 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_3))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Begin Therapy Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_13), typeof(X12_ID_1250_3))]
    public class DTP_Date_6 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_13))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Disability Dates
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374), typeof(X12_ID_1250))]
    public class DTP_Date_7 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Discharge
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250_3))]
    public class DTP_Date_8 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_5))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Date - Hearing and Vision Prescription Date
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250_3))]
    public class DTP_Date_9 : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_23))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Date of First Contact
    /// </summary>
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_3))]
    public class DTP_PropertyandCasualtyDateofFirstContact : DTP
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_7))]
        [Pos(1)]
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        public new string DTP01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(2)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string DTP02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string DTP03 { get; set; }
    }
    
    /// <summary>
    /// Supporting Documentation
    /// </summary>
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation : FRM
    {
        
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Assigned Identification
        /// </summary>
        public new string FRM01 { get; set; }
        [RequiredAny(3, 4, 5)]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string FRM02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string FRM03 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        /// <summary>
        /// Date
        /// </summary>
        public new string FRM04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        public new string FRM05 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_ClaimPricing : HCP
    {
        
        [RequiredAny(13)]
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_2))]
        [Pos(1)]
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        public new string HCP01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string HCP04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Rate
        /// </summary>
        public new string HCP05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string HCP06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string HCP08 { get; set; }
        [Paired(10)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(9)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string HCP09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string HCP10 { get; set; }
        [Paired(12)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(11)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string HCP11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string HCP12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        public new string HCP13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        public new string HCP14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        /// <summary>
        /// Exception Code
        /// </summary>
        public new string HCP15 { get; set; }
    }
    
    /// <summary>
    /// Line Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_LinePricing : HCP
    {
        
        [RequiredAny(13)]
        [Required]
        [DataElement("1473", typeof(X12_ID_1473))]
        [Pos(1)]
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        public new string HCP01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string HCP04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Rate
        /// </summary>
        public new string HCP05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string HCP06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string HCP07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string HCP08 { get; set; }
        [Paired(10)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string HCP09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string HCP10 { get; set; }
        [Paired(12)]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(11)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string HCP11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string HCP12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        public new string HCP13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        public new string HCP14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        /// <summary>
        /// Exception Code
        /// </summary>
        public new string HCP15 { get; set; }
    }
    
    /// <summary>
    /// Anesthesia Related Procedure
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_3), typeof(X12_ID_1270_4))]
    public class HI_AnesthesiaRelatedProcedure : HI
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_2 HI01 { get; set; }
        [Pos(2)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_3 HI02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI05 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI06 { get; set; }
        [Pos(7)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI08 { get; set; }
        [Pos(9)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI09 { get; set; }
        [Pos(10)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI10 { get; set; }
        [Pos(11)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI11 { get; set; }
        [Pos(12)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_4 HI12 { get; set; }
    }
    
    /// <summary>
    /// Condition Information
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_5), typeof(X12_ID_1270_5))]
    public class HI_ConditionInformation : HI
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI01 { get; set; }
        [Pos(2)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI05 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI06 { get; set; }
        [Pos(7)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI08 { get; set; }
        [Pos(9)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI09 { get; set; }
        [Pos(10)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI10 { get; set; }
        [Pos(11)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI11 { get; set; }
        [Pos(12)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_5 HI12 { get; set; }
    }
    
    /// <summary>
    /// Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270), typeof(X12_ID_1270_2))]
    public class HI_HealthCareDiagnosisCode : HI
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation_6 HI01 { get; set; }
        [Pos(2)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI05 { get; set; }
        [Pos(6)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI06 { get; set; }
        [Pos(7)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI08 { get; set; }
        [Pos(9)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI09 { get; set; }
        [Pos(10)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI10 { get; set; }
        [Pos(11)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI11 { get; set; }
        [Pos(12)]
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        public new C022_HealthCareCodeInformation HI12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_3))]
    public class HL_BillingProviderHierarchicalLevel : HL
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        public new string HL01 { get; set; }
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        public new string HL02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_3))]
        [Pos(3)]
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        public new string HL03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_3))]
        [Pos(4)]
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        public new string HL04 { get; set; }
    }
    
    /// <summary>
    /// Patient Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735_2))]
    public class HL_PatientHierarchicalLevel : HL
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        public new string HL01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        public new string HL02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_2))]
        [Pos(3)]
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        public new string HL03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_2))]
        [Pos(4)]
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        public new string HL04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [Segment("HL", typeof(X12_ID_735))]
    public class HL_SubscriberHierarchicalLevel : HL
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        public new string HL01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        public new string HL02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735))]
        [Pos(3)]
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        public new string HL03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736))]
        [Pos(4)]
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        public new string HL04 { get; set; }
    }
    
    /// <summary>
    /// File Information
    /// </summary>
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation : K3
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Fixed Format Information
        /// </summary>
        public new string K301 { get; set; }
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        /// <summary>
        /// Record Format Code
        /// </summary>
        public new string K302 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        public new C001_CompositeUnitofMeasure K303 { get; set; }
    }
    
    /// <summary>
    /// Drug Identification
    /// </summary>
    [Serializable()]
    [Segment("LIN")]
    public class LIN_DrugIdentification : LIN
    {
        
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Assigned Identification
        /// </summary>
        public new string LIN01 { get; set; }
        [Required]
        [DataElement("235", typeof(X12_ID_235_3))]
        [Pos(2)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN02 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN03 { get; set; }
        [Paired(5)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(4)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN04 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN05 { get; set; }
        [Paired(7)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(6)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN06 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN07 { get; set; }
        [Paired(9)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(8)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN08 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN09 { get; set; }
        [Paired(11)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(10)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN10 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN11 { get; set; }
        [Paired(13)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(12)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN12 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN13 { get; set; }
        [Paired(15)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(14)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN14 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN15 { get; set; }
        [Paired(17)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(16)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN16 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN17 { get; set; }
        [Paired(19)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(18)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN18 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN19 { get; set; }
        [Paired(21)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(20)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN20 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN21 { get; set; }
        [Paired(23)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(22)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN22 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN23 { get; set; }
        [Paired(25)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(24)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN24 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN25 { get; set; }
        [Paired(27)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(26)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN26 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN27 { get; set; }
        [Paired(29)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(28)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN28 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN29 { get; set; }
        [Paired(31)]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(30)]
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        public new string LIN30 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string LIN31 { get; set; }
    }
    
    /// <summary>
    /// Form Identification Code
    /// </summary>
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_6))]
    public class LQ_FormIdentificationCode : LQ
    {
        
        [Conditional(2)]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string LQ01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string LQ02 { get; set; }
    }
    
    /// <summary>
    /// Service Line Number
    /// </summary>
    [Serializable()]
    [Segment("LX")]
    public class LX_ServiceLineNumber : LX
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        /// <summary>
        /// Assigned Number
        /// </summary>
        public new string LX01 { get; set; }
    }
    
    /// <summary>
    /// Test Result
    /// </summary>
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult : MEA
    {
        
        [Required]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        public new string MEA01 { get; set; }
        [Required]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        public new string MEA02 { get; set; }
        [RequiredAny(5, 6, 8)]
        [Required]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Measurement Value
        /// </summary>
        public new string MEA03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        public new C001_CompositeUnitofMeasure MEA04 { get; set; }
        [ConditionalAny(4, 12)]
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Range Minimum
        /// </summary>
        public new string MEA05 { get; set; }
        [ConditionalAny(4, 12)]
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        /// <summary>
        /// Range Maximum
        /// </summary>
        public new string MEA06 { get; set; }
        [ConditionalAny(3, 5, 6)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        public new string MEA07 { get; set; }
        [Exclusion(3)]
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        public new string MEA08 { get; set; }
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        public new string MEA09 { get; set; }
        [DataElement("1373", typeof(X12_ID_1373))]
        [Pos(10)]
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        public new string MEA10 { get; set; }
        [Paired(12)]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(11)]
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        public new string MEA11 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Industry Code
        /// </summary>
        public new string MEA12 { get; set; }
    }
    
    /// <summary>
    /// Outpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation : MOA
    {
        
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(1)]
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        public new string MOA01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string MOA02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string MOA03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string MOA04 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string MOA05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string MOA06 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string MOA07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string MOA08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string MOA09 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location Address
    /// </summary>
    [Serializable()]
    [Segment("N3")]
    public class N3_AmbulanceDrop : N3
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Address Information
        /// </summary>
        public new string N301 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Address Information
        /// </summary>
        public new string N302 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location City, State, Zip Code
    /// </summary>
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulanceDrop : N4
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// City Name
        /// </summary>
        public new string N401 { get; set; }
        [Exclusion(7)]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public new string N402 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Postal Code
        /// </summary>
        public new string N403 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Country Code
        /// </summary>
        public new string N404 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        /// <summary>
        /// Location Qualifier
        /// </summary>
        public new string N405 { get; set; }
        [Conditional(5)]
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Location Identifier
        /// </summary>
        public new string N406 { get; set; }
        [Conditional(4)]
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        public new string N407 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065))]
    public class NM1_AmbulanceDrop : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_5))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_AmbulancePick : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_3))]
    public class NM1_BillingProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065_2))]
    public class NM1_OrderingProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerBillingProvider : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065))]
    public class NM1_OtherPayerName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_15))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerReferringProvider : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerRenderingProvider : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065))]
    public class NM1_OtherPayerServiceFacilityLocation : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerSupervisingProvider : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_3))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_3))]
    public class NM1_OtherSubscriberName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Patient Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_PatientName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_8))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_Pay : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_Pay_2 : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_13))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065_3))]
    public class NM1_PurchasedServiceProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_6))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Receiver Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_ReceiverName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_10))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_2))]
    public class NM1_ReferringProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98), typeof(X12_ID_1065_3))]
    public class NM1_RenderingProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Service Facility Location
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065))]
    public class NM1_ServiceFacilityLocation : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Submitter Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_17), typeof(X12_ID_1065_3))]
    public class NM1_SubmitterName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_17))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [Required]
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_3))]
    public class NM1_SubscriberName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Supervising Provider Name
    /// </summary>
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065_2))]
    public class NM1_SupervisingProviderName : NM1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_3))]
        [Pos(1)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM101 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        public new string NM102 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM103 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name First
        /// </summary>
        public new string NM104 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Name Middle
        /// </summary>
        public new string NM105 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Name Prefix
        /// </summary>
        public new string NM106 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Name Suffix
        /// </summary>
        public new string NM107 { get; set; }
        [Paired(9)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string NM108 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string NM109 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        public new string NM110 { get; set; }
        [Conditional(10)]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(11)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string NM111 { get; set; }
        [Conditional(3)]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        public new string NM112 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ClaimNote : NTE
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_3))]
        [Pos(1)]
        /// <summary>
        /// Note Reference Code
        /// </summary>
        public new string NTE01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Description
        /// </summary>
        public new string NTE02 { get; set; }
    }
    
    /// <summary>
    /// Line Note
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363))]
    public class NTE_LineNote : NTE
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        /// <summary>
        /// Note Reference Code
        /// </summary>
        public new string NTE01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Description
        /// </summary>
        public new string NTE02 { get; set; }
    }
    
    /// <summary>
    /// Third Party Organization Notes
    /// </summary>
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_ThirdPartyOrganizationNotes : NTE
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_2))]
        [Pos(1)]
        /// <summary>
        /// Note Reference Code
        /// </summary>
        public new string NTE01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Description
        /// </summary>
        public new string NTE02 { get; set; }
    }
    
    /// <summary>
    /// Other Insurance Coverage Information
    /// </summary>
    [Serializable()]
    [Segment("OI", typeof(X12_ID_1032), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation : OI
    {
        
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(1)]
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        public new string OI01 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(2)]
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        public new string OI02 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(3)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string OI03 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(4)]
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        public new string OI04 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(5)]
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        public new string OI05 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(6)]
        /// <summary>
        /// Release of Information Code
        /// </summary>
        public new string OI06 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_3), typeof(X12_ID_1384))]
    public class PAT_PatientInformation : PAT
    {
        
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_3))]
        [Pos(1)]
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        public new string PAT01 { get; set; }
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        /// <summary>
        /// Patient Location Code
        /// </summary>
        public new string PAT02 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(3)]
        /// <summary>
        /// Employment Status Code
        /// </summary>
        public new string PAT03 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        /// <summary>
        /// Student Status Code
        /// </summary>
        public new string PAT04 { get; set; }
        [Paired(6)]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(5)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string PAT05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string PAT06 { get; set; }
        [Paired(8)]
        [DataElement("355", typeof(X12_ID_355_8))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string PAT07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Weight
        /// </summary>
        public new string PAT08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string PAT09 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_2 : PAT
    {
        
        [DataElement("1069", typeof(X12_ID_1069))]
        [Pos(1)]
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        public new string PAT01 { get; set; }
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        /// <summary>
        /// Patient Location Code
        /// </summary>
        public new string PAT02 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(3)]
        /// <summary>
        /// Employment Status Code
        /// </summary>
        public new string PAT03 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        /// <summary>
        /// Student Status Code
        /// </summary>
        public new string PAT04 { get; set; }
        [Paired(6)]
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(5)]
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        public new string PAT05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Date Time Period
        /// </summary>
        public new string PAT06 { get; set; }
        [Paired(8)]
        [DataElement("355", typeof(X12_ID_355_8))]
        [Pos(7)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string PAT07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Weight
        /// </summary>
        public new string PAT08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string PAT09 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_BillingProviderContactInformation : PER
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        /// <summary>
        /// Contact Function Code
        /// </summary>
        public new string PER01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Name
        /// </summary>
        public new string PER02 { get; set; }
        [Paired(4)]
        [Required]
        [DataElement("365", typeof(X12_ID_365_5))]
        [Pos(3)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER04 { get; set; }
        [Paired(6)]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER06 { get; set; }
        [Paired(8)]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        public new string PER09 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Contact Information
    /// </summary>
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_PropertyandCasualtyPatientContactInformation : PER
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        /// <summary>
        /// Contact Function Code
        /// </summary>
        public new string PER01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Name
        /// </summary>
        public new string PER02 { get; set; }
        [Paired(4)]
        [Required]
        [DataElement("365", typeof(X12_ID_365_2))]
        [Pos(3)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER04 { get; set; }
        [Paired(6)]
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(5)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER06 { get; set; }
        [Paired(8)]
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(7)]
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        public new string PER07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        /// <summary>
        /// Communication Number
        /// </summary>
        public new string PER08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        public new string PER09 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128_36))]
    public class PRV_BillingProviderSpecialtyInformation : PRV
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_2))]
        [Pos(1)]
        /// <summary>
        /// Provider Code
        /// </summary>
        public new string PRV01 { get; set; }
        [Paired(3)]
        [Required]
        [DataElement("128", typeof(X12_ID_128_36))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string PRV02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string PRV03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public new string PRV04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        public new C035_ProviderSpecialtyInformation PRV05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        public new string PRV06 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Specialty Information
    /// </summary>
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128_36))]
    public class PRV_RenderingProviderSpecialtyInformation : PRV
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221))]
        [Pos(1)]
        /// <summary>
        /// Provider Code
        /// </summary>
        public new string PRV01 { get; set; }
        [Paired(3)]
        [Required]
        [DataElement("128", typeof(X12_ID_128_36))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string PRV02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string PRV03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public new string PRV04 { get; set; }
        [Pos(5)]
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        public new C035_ProviderSpecialtyInformation PRV05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        public new string PRV06 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Information
    /// </summary>
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation : PS1
    {
        
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string PS101 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string PS102 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// State or Province Code
        /// </summary>
        public new string PS103 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
    public class PWK_ClaimSupplementalInformation : PWK
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_3))]
        [Pos(1)]
        /// <summary>
        /// Report Type Code
        /// </summary>
        public new string PWK01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_2))]
        [Pos(2)]
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        public new string PWK02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        public new string PWK03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(4)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string PWK04 { get; set; }
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(5)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string PWK05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string PWK06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public new string PWK07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Actions Indicated
        /// </summary>
        public new C002_ActionsIndicated PWK08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        /// <summary>
        /// Request Category Code
        /// </summary>
        public new string PWK09 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certificate of Medical Necessity Indicator
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator : PWK
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_2))]
        [Pos(1)]
        /// <summary>
        /// Report Type Code
        /// </summary>
        public new string PWK01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        public new string PWK02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        public new string PWK03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(4)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string PWK04 { get; set; }
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(5)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string PWK05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string PWK06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public new string PWK07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Actions Indicated
        /// </summary>
        public new C002_ActionsIndicated PWK08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        /// <summary>
        /// Request Category Code
        /// </summary>
        public new string PWK09 { get; set; }
    }
    
    /// <summary>
    /// Line Supplemental Information
    /// </summary>
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756_2))]
    public class PWK_LineSupplementalInformation : PWK
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        /// <summary>
        /// Report Type Code
        /// </summary>
        public new string PWK01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_2))]
        [Pos(2)]
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        public new string PWK02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        public new string PWK03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(4)]
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        public new string PWK04 { get; set; }
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(5)]
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        public new string PWK05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string PWK06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        /// <summary>
        /// Description
        /// </summary>
        public new string PWK07 { get; set; }
        [Pos(8)]
        /// <summary>
        /// Actions Indicated
        /// </summary>
        public new C002_ActionsIndicated PWK08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        /// <summary>
        /// Request Category Code
        /// </summary>
        public new string PWK09 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Patient Count
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_2))]
    public class QTY_AmbulancePatientCount : QTY
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673_2))]
        [Pos(1)]
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        public new string QTY01 { get; set; }
        [RequiredAny(4)]
        [Exclusion(4)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string QTY02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        public new C001_CompositeUnitofMeasure QTY03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Free-form Information
        /// </summary>
        public new string QTY04 { get; set; }
    }
    
    /// <summary>
    /// Obstetric Anesthesia Additional Units
    /// </summary>
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits : QTY
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        public new string QTY01 { get; set; }
        [RequiredAny(4)]
        [Exclusion(4)]
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string QTY02 { get; set; }
        [Pos(3)]
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        public new C001_CompositeUnitofMeasure QTY03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Free-form Information
        /// </summary>
        public new string QTY04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_AdjustedRepricedClaimNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_AdjustedRepricedLineItemReferenceNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_23))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128))]
    public class REF_BillingProviderSecondaryIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_11))]
    public class REF_BillingProviderTaxIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_11))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider UPIN/License Information
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_30))]
    public class REF_BillingProviderUPIN : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_30))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Care Plan Oversight
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_CarePlanOversight : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Claim Identifier For Transmission Intermediaries
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_ClaimIdentifierForTransmissionIntermediaries : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Clinical Laboratory Improvement Amendment (CLIA) Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_ClinicalLaboratoryImprovementAmendment : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_8))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Demonstration Project Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_DemonstrationProjectIdentifier : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Immunization Batch Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_ImmunizationBatchNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Investigational Device Exemption Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_12))]
    public class REF_InvestigationalDeviceExemptionNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_12))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Line Item Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_LineItemControlNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Mammography Certification Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_4))]
    public class REF_MammographyCertificationNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_4))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Mandatory Medicare (Section 4081) Crossover Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_3), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [DataElement("127", typeof(X12_ID_127_2))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Medical Record Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_MedicalRecordNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_OrderingProviderSecondaryIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier_2 REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Adjustment Indicator
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_20))]
    public class REF_OtherPayerClaimAdjustmentIndicator : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7))]
    public class REF_OtherPayerClaimControlNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Prior Authorization Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_OtherPayerPriorAuthorizationNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_6))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referral Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_5))]
    public class REF_OtherPayerReferralNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_5))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_OtherPayerRenderingProviderSecondaryIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_18))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Secondary Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_35))]
    public class REF_OtherPayerSecondaryIdentifier : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_35))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_19))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_33))]
    public class REF_OtherSubscriberSecondaryIdentification : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_33))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Secondary Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_31))]
    public class REF_Pay : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Tax Identification Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_Pay_2 : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_32))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Prescription or Compound Drug Association Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_28))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_PropertyandCasualtyClaimNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_34))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Identifier
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_PropertyandCasualtyPatientIdentifier : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_29))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier_3 REF04 { get; set; }
    }
    
    /// <summary>
    /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Claim Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9))]
    public class REF_RepricedClaimNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_RepricedLineItemReferenceNumber : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_21))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Service Authorization Exception Code
    /// </summary>
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_2), typeof(X12_ID_127))]
    public class REF_ServiceAuthorizationExceptionCode : REF
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        public new string REF01 { get; set; }
        [RequiredAny(3)]
        [Required]
        [DataElement("127", typeof(X12_ID_127))]
        [Pos(2)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string REF02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Description
        /// </summary>
        public new string REF03 { get; set; }
        [Pos(4)]
        /// <summary>
        /// Reference Identifier
        /// </summary>
        public new C040_ReferenceIdentifier REF04 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138), typeof(X12_ID_1069_2))]
    public class SBR_OtherSubscriberInformation : SBR
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        public new string SBR01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_2))]
        [Pos(2)]
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        public new string SBR02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string SBR03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name
        /// </summary>
        public new string SBR04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336))]
        [Pos(5)]
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        public new string SBR05 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(6)]
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        public new string SBR06 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(7)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string SBR07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        /// <summary>
        /// Employment Status Code
        /// </summary>
        public new string SBR08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(9)]
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        public new string SBR09 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Information
    /// </summary>
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138), typeof(X12_ID_1069_4))]
    public class SBR_SubscriberInformation : SBR
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        public new string SBR01 { get; set; }
        [DataElement("1069", typeof(X12_ID_1069_4))]
        [Pos(2)]
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        public new string SBR02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string SBR03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Name
        /// </summary>
        public new string SBR04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336))]
        [Pos(5)]
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        public new string SBR05 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(6)]
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        public new string SBR06 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(7)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string SBR07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        /// <summary>
        /// Employment Status Code
        /// </summary>
        public new string SBR08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(9)]
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        public new string SBR09 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235))]
    public class SV1_ProfessionalService : SV1
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        public new C003_CompositeMedicalProcedureIdentifier_2 SV101 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SV102 { get; set; }
        [Paired(4)]
        [Required]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(3)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string SV103 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string SV104 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(5)]
        /// <summary>
        /// Facility Code Value
        /// </summary>
        public new string SV105 { get; set; }
        [DataElement("1365", typeof(X12_ID_1365))]
        [Pos(6)]
        /// <summary>
        /// Service Type Code
        /// </summary>
        public new string SV106 { get; set; }
        [Required]
        [Pos(7)]
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        public new C004_CompositeDiagnosisCodePointer SV107 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SV108 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string SV109 { get; set; }
        [DataElement("1340", typeof(X12_ID_1340))]
        [Pos(10)]
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        public new string SV110 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(11)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string SV111 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(12)]
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        public new string SV112 { get; set; }
        [DataElement("1364", typeof(X12_ID_1364))]
        [Pos(13)]
        /// <summary>
        /// Review Code
        /// </summary>
        public new string SV113 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1341", typeof(X12_AN))]
        [Pos(14)]
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        public new string SV114 { get; set; }
        [DataElement("1327", typeof(X12_ID_1327))]
        [Pos(15)]
        /// <summary>
        /// Copay Status Code
        /// </summary>
        public new string SV115 { get; set; }
        [StringLength(1, 1)]
        [DataElement("1334", typeof(X12_AN))]
        [Pos(16)]
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        public new string SV116 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(17)]
        /// <summary>
        /// Reference Identification
        /// </summary>
        public new string SV117 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(18)]
        /// <summary>
        /// Postal Code
        /// </summary>
        public new string SV118 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(19)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SV119 { get; set; }
        [DataElement("1337", typeof(X12_ID_1337))]
        [Pos(20)]
        /// <summary>
        /// Level of Care Code
        /// </summary>
        public new string SV120 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(21)]
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        public new string SV121 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Service
    /// </summary>
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_2), typeof(X12_ID_355_5))]
    public class SV5_DurableMedicalEquipmentService : SV5
    {
        
        [Required]
        [Pos(1)]
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        public new C003_CompositeMedicalProcedureIdentifier SV501 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_5))]
        [Pos(2)]
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        public new string SV502 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string SV503 { get; set; }
        [RequiredAny(5)]
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SV504 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SV505 { get; set; }
        [Conditional(4)]
        [Required]
        [DataElement("594", typeof(X12_ID_594))]
        [Pos(6)]
        /// <summary>
        /// Frequency Code
        /// </summary>
        public new string SV506 { get; set; }
        [DataElement("923", typeof(X12_ID_923))]
        [Pos(7)]
        /// <summary>
        /// Prognosis Code
        /// </summary>
        public new string SV507 { get; set; }
    }
    
    /// <summary>
    /// Line Adjudication Information
    /// </summary>
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation : SVD
    {
        
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(1)]
        /// <summary>
        /// Identification Code
        /// </summary>
        public new string SVD01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        /// <summary>
        /// Monetary Amount
        /// </summary>
        public new string SVD02 { get; set; }
        [Required]
        [Pos(3)]
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        public new C003_CompositeMedicalProcedureIdentifier_2 SVD03 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(4)]
        /// <summary>
        /// Product/Service ID
        /// </summary>
        public new string SVD04 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(5)]
        /// <summary>
        /// Quantity
        /// </summary>
        public new string SVD05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(6)]
        /// <summary>
        /// Assigned Number
        /// </summary>
        public new string SVD06 { get; set; }
    }
}
