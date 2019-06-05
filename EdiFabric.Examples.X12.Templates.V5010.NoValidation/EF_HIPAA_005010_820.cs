namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    
    
    [Serializable()]
    [All()]
    public class All_DTM_820
    {
        
        /// <summary>
        /// Process Date
        /// </summary>
        [Pos(1)]
        public DTM_ProcessDate DTM_ProcessDate { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [Pos(2)]
        public DTM_DeliveryDate DTM_DeliveryDate { get; set; }
        /// <summary>
        /// Coverage Period
        /// </summary>
        [Pos(3)]
        public DTM_CoveragePeriod DTM_CoveragePeriod { get; set; }
        /// <summary>
        /// Creation Date
        /// </summary>
        [Pos(4)]
        public DTM_CreationDate DTM_CreationDate { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_ENT_820
    {
        
        /// <summary>
        /// Loop for Organization Summary Remittance
        /// </summary>
        [Pos(1)]
        public Loop_2000A_820 Loop2000A { get; set; }
        /// <summary>
        /// Loop for Individual Remittance
        /// </summary>
        [Pos(2)]
        public List<Loop_2000B_820> Loop2000B { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_N1_820
    {
        
        /// <summary>
        /// Loop for Premium Receiver's Name
        /// </summary>
        [Pos(1)]
        public Loop_1000A_820 Loop1000A { get; set; }
        /// <summary>
        /// Loop for Premium Payer's Name
        /// </summary>
        [Pos(2)]
        public Loop_1000B_820 Loop1000B { get; set; }
        /// <summary>
        /// Loop for Intermediary Bank Information
        /// </summary>
        [Pos(3)]
        public List<Loop_1000C_820> Loop1000C { get; set; }
    }
    
    /// <summary>
    /// Loop for Premium Receiver's Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_PayeeIdentification))]
    public class Loop_1000A_820
    {
        
        /// <summary>
        /// Premium Receiver's Name
        /// </summary>
        [Pos(1)]
        public N1_PayeeIdentification N1_PremiumReceiver_Name { get; set; }
        /// <summary>
        /// Premium Receiver Additional Name
        /// </summary>
        [Pos(2)]
        public N2_IntermediaryBankAdditionalName N2_PremiumReceiverAdditionalName { get; set; }
        /// <summary>
        /// Premium Receiver's Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_PremiumReceiver_Address { get; set; }
        /// <summary>
        /// Premium Receiver's City, State, and ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_PremiumReceiver_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Premium Receiver's Remittance Delivery Method
        /// </summary>
        [Pos(5)]
        public RDM_PremiumReceiver RDM_PremiumReceiver_RemittanceDeliveryMethod { get; set; }
    }
    
    /// <summary>
    /// Loop for Premium Payer's Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_PayerIdentification))]
    public class Loop_1000B_820
    {
        
        /// <summary>
        /// Premium Payer's Name
        /// </summary>
        [Pos(1)]
        public N1_PayerIdentification N1_PremiumPayer_Name { get; set; }
        /// <summary>
        /// Premium Payer Additional Name
        /// </summary>
        [Pos(2)]
        public N2_IntermediaryBankAdditionalName N2_PremiumPayerAdditionalName { get; set; }
        /// <summary>
        /// Premium Payer's Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_PremiumPayer_Address { get; set; }
        /// <summary>
        /// Premium Payer’s City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_PremiumPayer_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Premium Payer's Administrative Contact
        /// </summary>
        [Pos(5)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_PremiumPayer_AdministrativeContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Intermediary Bank Information
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_IntermediaryBankInformation))]
    public class Loop_1000C_820
    {
        
        /// <summary>
        /// Intermediary Bank Information
        /// </summary>
        [Pos(1)]
        public N1_IntermediaryBankInformation N1_IntermediaryBankInformation { get; set; }
        /// <summary>
        /// Intermediary Bank Additional Name
        /// </summary>
        [Pos(2)]
        public N2_IntermediaryBankAdditionalName N2_IntermediaryBankAdditionalName { get; set; }
        /// <summary>
        /// Intermediary Bank's Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_IntermediaryBank_Address { get; set; }
        /// <summary>
        /// Intermediary Bank's City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_IntermediaryBank_City_State_ZIPCode { get; set; }
        /// <summary>
        /// Intermediary Bank's Administrative Contact
        /// </summary>
        [Pos(5)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_IntermediaryBank_AdministrativeContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance
    /// </summary>
    [Serializable()]
    [Group(typeof(ENT_IndividualRemittance))]
    public class Loop_2000A_820
    {
        
        /// <summary>
        /// Organization Summary Remittance
        /// </summary>
        [Pos(1)]
        public ENT_IndividualRemittance ENT_OrganizationSummaryRemittance { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Level Adjustment for Previous Payment
        /// </summary>
        [Pos(2)]
        public List<Loop_2200A_820> Loop2200A { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Detail
        /// </summary>
        [Pos(3)]
        public List<Loop_2300A_820> Loop2300A { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Remittance
    /// </summary>
    [Serializable()]
    [Group(typeof(ENT_IndividualRemittance))]
    public class Loop_2000B_820
    {
        
        /// <summary>
        /// Individual Remittance
        /// </summary>
        [Pos(1)]
        public ENT_IndividualRemittance ENT_IndividualRemittance { get; set; }
        /// <summary>
        /// Loop for Individual Name
        /// </summary>
        [Pos(2)]
        public List<Loop_2100B_820> Loop2100B { get; set; }
        /// <summary>
        /// Loop for Individual Premium Adjustment for Previous Payment
        /// </summary>
        [Pos(3)]
        public List<Loop_2200B_820> Loop2200B { get; set; }
        /// <summary>
        /// Loop for Individual Premium Remittance Detail
        /// </summary>
        [Pos(4)]
        public List<Loop_2300B_820> Loop2300B { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_IndividualName))]
    public class Loop_2100B_820
    {
        
        /// <summary>
        /// Individual Name
        /// </summary>
        [Pos(1)]
        public NM1_IndividualName NM1_IndividualName { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Level Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2200A_820
    {
        
        /// <summary>
        /// Organization Summary Remittance Level Adjustment for Previous Payment
        /// </summary>
        [Pos(1)]
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2200B_820
    {
        
        /// <summary>
        /// Individual Premium Adjustment for Previous Payment
        /// </summary>
        [Pos(1)]
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_IndividualPremiumAdjustmentforPreviousPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Detail
    /// </summary>
    [Serializable()]
    [Group(typeof(RMR_OrganizationSummaryRemittanceDetail))]
    public class Loop_2300A_820
    {
        
        /// <summary>
        /// Organization Summary Remittance Detail
        /// </summary>
        [Pos(1)]
        public RMR_OrganizationSummaryRemittanceDetail RMR_OrganizationSummaryRemittanceDetail { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [Pos(2)]
        public List<REF_ReferenceInformation_2> REF_ReferenceInformation { get; set; }
        /// <summary>
        /// Organizational Coverage Period
        /// </summary>
        [Pos(3)]
        public DTM_IndividualCoveragePeriod DTM_OrganizationalCoveragePeriod { get; set; }
        /// <summary>
        /// Loop for Summary Line Item
        /// </summary>
        [Pos(4)]
        public Loop_2310A_820 Loop2310A { get; set; }
        /// <summary>
        /// Loop for Organization Summary Remittance Level Adjustment for Current Payment
        /// </summary>
        [Pos(5)]
        public List<Loop_2320A_820> Loop2320A { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Remittance Detail
    /// </summary>
    [Serializable()]
    [Group(typeof(RMR_IndividualPremiumRemittanceDetail))]
    public class Loop_2300B_820
    {
        
        /// <summary>
        /// Individual Premium Remittance Detail
        /// </summary>
        [Pos(1)]
        public RMR_IndividualPremiumRemittanceDetail RMR_IndividualPremiumRemittanceDetail { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [Pos(2)]
        public List<REF_ReferenceInformation> REF_ReferenceInformation { get; set; }
        /// <summary>
        /// Individual Coverage Period
        /// </summary>
        [Pos(3)]
        public DTM_IndividualCoveragePeriod DTM_IndividualCoveragePeriod { get; set; }
        /// <summary>
        /// Loop for Individual Premium Adjustment for Current Payment
        /// </summary>
        [Pos(4)]
        public List<Loop_2320B_820> Loop2320B { get; set; }
    }
    
    /// <summary>
    /// Loop for Summary Line Item
    /// </summary>
    [Serializable()]
    [Group(typeof(IT1_SummaryLineItem))]
    public class Loop_2310A_820
    {
        
        /// <summary>
        /// Summary Line Item
        /// </summary>
        [Pos(1)]
        public IT1_SummaryLineItem IT1_SummaryLineItem { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [Pos(2)]
        public List<Loop_2312A_820> Loop2312A { get; set; }
        /// <summary>
        /// Loop for Member Count
        /// </summary>
        [Pos(3)]
        public List<Loop_2315A_820> Loop2315A { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [Group(typeof(SAC_Service))]
    public class Loop_2312A_820
    {
        
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [Pos(1)]
        public SAC_Service SAC_Service_Promotion_Allowance_ChargeInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Count
    /// </summary>
    [Serializable()]
    [Group(typeof(SLN_MemberCount))]
    public class Loop_2315A_820
    {
        
        /// <summary>
        /// Member Count
        /// </summary>
        [Pos(1)]
        public SLN_MemberCount SLN_MemberCount { get; set; }
    }
    
    /// <summary>
    /// Loop for Organization Summary Remittance Level Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2320A_820
    {
        
        /// <summary>
        /// Organization Summary Remittance Level Adjustment for Current Payment
        /// </summary>
        [Pos(1)]
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_OrganizationSummaryRemittanceLevelAdjustmentforCurrentPayment { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Premium Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [Group(typeof(ADX_IndividualPremiumAdjustmentforCurrentPayment))]
    public class Loop_2320B_820
    {
        
        /// <summary>
        /// Individual Premium Adjustment for Current Payment
        /// </summary>
        [Pos(1)]
        public ADX_IndividualPremiumAdjustmentforCurrentPayment ADX_IndividualPremiumAdjustmentforCurrentPayment { get; set; }
    }
    
    /// <summary>
    /// Payment Order/Remittance Advice
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X218", "820")]
    public class TS820 : EdiMessage
    {
        
        /// <summary>
        /// 820 Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        /// <summary>
        /// Financial Information
        /// </summary>
        [Pos(2)]
        public BPR_FinancialInformation BPR_FinancialInformation { get; set; }
        /// <summary>
        /// Reassociation Trace Number
        /// </summary>
        [Pos(3)]
        public TRN_ReassociationTraceNumber TRN_ReassociationTraceNumber { get; set; }
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        [Pos(4)]
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        /// <summary>
        /// Premium Receivers Identification Key
        /// </summary>
        [Pos(5)]
        public List<REF_PremiumReceiversIdentificationKey> REF_PremiumReceiversIdentificationKey { get; set; }
        [Pos(6)]
        public All_DTM_820 AllDTM { get; set; }
        [Pos(7)]
        public All_N1_820 AllN1 { get; set; }
        [Pos(8)]
        public All_ENT_820 AllENT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(9)]
        public SE SE { get; set; }
    }
}
