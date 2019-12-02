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
    
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTM_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Process Date
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DTM_ProcessDate DTM_ProcessDate { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM_DeliveryDate DTM_DeliveryDate { get; set; }
        /// <summary>
        /// Coverage Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM_CoveragePeriod DTM_CoveragePeriod { get; set; }
        /// <summary>
        /// Creation Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTM_CreationDate DTM_CreationDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_ENT_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2000A_820 Loop2000A { get; set; }
        /// <summary>
        /// Loop for Individual Remittance
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2000B_820> Loop2000B { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_N1_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Premium Receiver's Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_1000A_820 Loop1000A { get; set; }
        /// <summary>
        /// Loop for Premium Payer's Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_1000B_820 Loop1000B { get; set; }
        /// <summary>
        /// Loop for Intermediary Bank Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_1000C_820> Loop1000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Premium Receiver's Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PremiumReceiver))]
    public class Loop_1000A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Premium Receiver's Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_PremiumReceiver N1_PremiumReceiver_Name { get; set; }
        /// <summary>
        /// Premium Receiver Additional Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2_IntermediaryBankAdditionalName N2_PremiumReceiverAdditionalName { get; set; }
        /// <summary>
        /// Premium Receiver's Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PremiumReceiver_Address { get; set; }
        /// <summary>
        /// Premium Receiver's City, State, and ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PremiumReceiver_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Premium Receiver's Remittance Delivery Method
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual RDM_PremiumReceiver RDM_PremiumReceiver_RemittanceDeliveryMethod { get; set; }
    }
    
    /// <summary>
    /// Loop for Premium Payer's Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PremiumPayer))]
    public class Loop_1000B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Premium Payer's Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_PremiumPayer N1_PremiumPayer_Name { get; set; }
        /// <summary>
        /// Premium Payer Additional Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2_IntermediaryBankAdditionalName N2_PremiumPayerAdditionalName { get; set; }
        /// <summary>
        /// Premium Payer's Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PremiumPayer_Address { get; set; }
        /// <summary>
        /// Premium Payer’s City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PremiumPayer_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Premium Payer's Administrative Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER_IntermediaryBank> PER_PremiumPayer_AdministrativeContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Intermediary Bank Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_IntermediaryBankInformation))]
    public class Loop_1000C_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Intermediary Bank Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_IntermediaryBankInformation N1_IntermediaryBankInformation { get; set; }
        /// <summary>
        /// Intermediary Bank Additional Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2_IntermediaryBankAdditionalName N2_IntermediaryBankAdditionalName { get; set; }
        /// <summary>
        /// Intermediary Bank's Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_IntermediaryBank_Address { get; set; }
        /// <summary>
        /// Intermediary Bank's City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_IntermediaryBank_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Intermediary Bank's Administrative Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER_IntermediaryBank> PER_IntermediaryBank_AdministrativeContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT_OrganizationSummaryRemittance))]
    public class Loop_2000A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Organization Summary Remittance
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ENT_OrganizationSummaryRemittance ENT_OrganizationSummaryRemittance { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Level Adjustment for Previous Payment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2200A_820> Loop2200A { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2300A_820> Loop2300A { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Remittance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT_IndividualRemittance))]
    public class Loop_2000B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Remittance
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ENT_IndividualRemittance ENT_IndividualRemittance { get; set; }
        /// <summary>
        /// Loop for Individual Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2100B_820> Loop2100B { get; set; }
        /// <summary>
        /// Loop for Individual Premium Adjustment for Previous Payment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2200B_820> Loop2200B { get; set; }
        /// <summary>
        /// Loop for Individual Premium Remittance Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2300B_820> Loop2300B { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_IndividualName))]
    public class Loop_2100B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_IndividualName NM1_IndividualName { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Level Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment))]
    public class Loop_2200A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Organization Summary Remittance Level Adjustment for Previous Payment
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforPreviousPayment))]
    public class Loop_2200B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Premium Adjustment for Previous Payment
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ADX_IndividualPremiumAdjustmentforPreviousPayment ADX_IndividualPremiumAdjustmentforPreviousPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMR_OrganizationSummaryRemittanceDetail))]
    public class Loop_2300A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Organization Summary Remittance Detail
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual RMR_OrganizationSummaryRemittanceDetail RMR_OrganizationSummaryRemittanceDetail { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_ReferenceInformation_2> REF_ReferenceInformation { get; set; }
        /// <summary>
        /// Organizational Coverage Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM_IndividualCoveragePeriod DTM_OrganizationalCoveragePeriod { get; set; }
        /// <summary>
        /// Loop for Summary Line Item
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_2310A_820 Loop2310A { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Level Adjustment for Current Payment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2320A_820> Loop2320A { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Remittance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMR_IndividualPremiumRemittanceDetail))]
    public class Loop_2300B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Premium Remittance Detail
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual RMR_IndividualPremiumRemittanceDetail RMR_IndividualPremiumRemittanceDetail { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_ReferenceInformation> REF_ReferenceInformation { get; set; }
        /// <summary>
        /// Individual Coverage Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM_IndividualCoveragePeriod DTM_IndividualCoveragePeriod { get; set; }
        /// <summary>
        /// Loop for Individual Premium Adjustment for Current Payment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2320B_820> Loop2320B { get; set; }
    }
    
    /// <summary>
    /// Loop for Summary Line Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IT1_SummaryLineItem))]
    public class Loop_2310A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Summary Line Item
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual IT1_SummaryLineItem IT1_SummaryLineItem { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2312A_820> Loop2312A { get; set; }
        /// <summary>
        /// Loop for Member Count
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_2315A_820> Loop2315A { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC_Service))]
    public class Loop_2312A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SAC_Service SAC_Service_Promotion_Allowance_ChargeInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN_MemberCount))]
    public class Loop_2315A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Count
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SLN_MemberCount SLN_MemberCount { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Level Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2320A_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Organization Summary Remittance Level Adjustment for Current Payment
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforCurrentPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2320B_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Premium Adjustment for Current Payment
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_IndividualPremiumAdjustmentforCurrentPayment { get; set; }
    }
    
    /// <summary>
    /// Payment Order/Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X218", "820")]
    public class TS820 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// 820 Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Financial Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual BPR_FinancialInformation BPR_FinancialInformation { get; set; }
        /// <summary>
        /// Reassociation Trace Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TRN_ReassociationTraceNumber TRN_ReassociationTraceNumber { get; set; }
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        /// <summary>
        /// Premium Receivers Identification Key
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<REF_PremiumReceiversIdentificationKey> REF_PremiumReceiversIdentificationKey { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_DTM_820 AllDTM { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_N1_820 AllN1 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual All_ENT_820 AllENT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
