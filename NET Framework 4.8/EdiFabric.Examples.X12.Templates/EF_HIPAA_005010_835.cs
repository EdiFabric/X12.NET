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
    using System.Reflection;
    using EdiFabric.Core.ErrorCodes;

    [Serializable()]
    [DataContract()]
    [All()]
    public class All_DTM_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statement From or To Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(1)]
        public virtual List<DTM_StatementFromorToDate> DTM_StatementFromorToDate { get; set; }
        /// <summary>
        /// Coverage Expiration Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM_CoverageExpirationDate DTM_CoverageExpirationDate { get; set; }
        /// <summary>
        /// Claim Received Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM_ClaimReceivedDate DTM_ClaimReceivedDate { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_N1_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Payer Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Loop_1000A_835 Loop1000A { get; set; }
        /// <summary>
        /// Loop for Payee Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual Loop_1000B_835 Loop1000B { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patient Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_PatientName_2 NM1_PatientName { get; set; }
        /// <summary>
        /// Insured Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1_InsuredName NM1_InsuredName { get; set; }
        /// <summary>
        /// Corrected Patient/Insured Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NM1_CorrectedPatient NM1_CorrectedPatient_InsuredName { get; set; }
        /// <summary>
        /// Service Provider Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NM1_ServiceProviderName_3 NM1_ServiceProviderName { get; set; }
        /// <summary>
        /// Crossover Carrier Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1_CrossoverCarrierName NM1_CrossoverCarrierName { get; set; }
        /// <summary>
        /// Corrected Priority Payer Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual NM1_CorrectedPriorityPayerName NM1_CorrectedPriorityPayerName { get; set; }
        /// <summary>
        /// Other Subscriber Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual NM1_OtherSubscriberName_2 NM1_OtherSubscriberName { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_PER_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Business Contact Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PER_PayerBusinessContactInformation PER_PayerBusinessContactInformation { get; set; }
        /// <summary>
        /// Payer Technical Contact Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<PER_PayerTechnicalContactInformation> PER_PayerTechnicalContactInformation { get; set; }
        /// <summary>
        /// Payer WEB Site
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PER_PayerWEBSite PER_PayerWEBSite { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Other Claim Related Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<REF_OtherClaimRelatedIdentification> REF_OtherClaimRelatedIdentification { get; set; }
        /// <summary>
        /// Rendering Provider Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<REF_RenderingProviderIdentification> REF_RenderingProviderIdentification { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_835_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Identification
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(1)]
        public virtual List<REF_ServiceIdentification> REF_ServiceIdentification { get; set; }
        /// <summary>
        /// Line Item Control Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        /// <summary>
        /// Rendering Provider Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<REF_RenderingProviderInformation> REF_RenderingProviderInformation { get; set; }
        /// <summary>
        /// HealthCare Policy Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF_HealthCarePolicyIdentification> REF_HealthCarePolicyIdentification { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_835_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Receiver Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_ReceiverIdentification REF_ReceiverIdentification { get; set; }
        /// <summary>
        /// Version Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_VersionIdentification REF_VersionIdentification { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PayerIdentification), "1000A")]
    public class Loop_1000A_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1_PayerIdentification N1_PayerIdentification { get; set; }
        /// <summary>
        /// Payer Address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PayerAddress { get; set; }
        /// <summary>
        /// Payer City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PayerCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Additional Payer Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(4)]
        public virtual List<REF_AdditionalPayerIdentification> REF_AdditionalPayerIdentification { get; set; }
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual All_PER_835 AllPER { get; set; }
    }
    
    /// <summary>
    /// Loop for Payee Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PayeeIdentification), "1000B")]
    public class Loop_1000B_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payee Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1_PayeeIdentification N1_PayeeIdentification { get; set; }
        /// <summary>
        /// Payee Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_PayeeAddress { get; set; }
        /// <summary>
        /// Payee City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_PayeeCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Payee Additional Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF_PayeeAdditionalIdentification> REF_PayeeAdditionalIdentification { get; set; }
        /// <summary>
        /// Remittance Delivery Method
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual RDM_RemittanceDeliveryMethod RDM_RemittanceDeliveryMethod { get; set; }
    }
    
    /// <summary>
    /// Loop for Header Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber), "2000")]
    public class Loop_2000_835
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Header Number
        /// </summary>
        [SeqCount]
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX_HeaderNumber LX_HeaderNumber { get; set; }
        /// <summary>
        /// Provider Summary Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TS3_ProviderSummaryInformation TS3_ProviderSummaryInformation { get; set; }
        /// <summary>
        /// Provider Supplemental Summary Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TS2_ProviderSupplementalSummaryInformation TS2_ProviderSupplementalSummaryInformation { get; set; }
        /// <summary>
        /// Loop for Claim Payment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_2100_835> Loop2100 { get; set; }
    }
    
    /// <summary>
    /// Loop for Claim Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLP_ClaimPaymentInformation), "2100")]
    public class Loop_2100_835 : IEdiValidator
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Claim Payment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLP_ClaimPaymentInformation CLP_ClaimPaymentInformation { get; set; }
        /// <summary>
        /// Claims Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CAS_ClaimsAdjustment> CAS_ClaimsAdjustment { get; set; }
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual All_NM1_835 AllNM1 { get; set; }
        /// <summary>
        /// Inpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MIA_InpatientAdjudicationInformation MIA_InpatientAdjudicationInformation { get; set; }
        /// <summary>
        /// Outpatient Adjudication Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_REF_835 AllREF { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual All_DTM_835 AllDTM { get; set; }
        /// <summary>
        /// Claim Contact Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<PER_ClaimContactInformation> PER_ClaimContactInformation { get; set; }
        /// <summary>
        /// Claim Supplemental Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(9)]
        public virtual List<AMT_ClaimSupplementalInformation> AMT_ClaimSupplementalInformation { get; set; }
        /// <summary>
        /// Claim Supplemental Information Quantity
        /// </summary>
        [DataMember]
        [ListCount(14)]
        [Pos(10)]
        public virtual List<QTY_ClaimSupplementalInformationQuantity> QTY_ClaimSupplementalInformationQuantity { get; set; }
        /// <summary>
        /// Loop for Service Payment Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(11)]
        public virtual List<Loop_2110_835> Loop2110 { get; set; }

        public SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            if (validationContext.SNIPLevel == ValidationLevel.Balancing_SNIP3 || validationContext.SNIPLevel == ValidationLevel.InterSegment_SNIP4)
            {
                if (CLP_ClaimPaymentInformation != null && !string.IsNullOrEmpty(CLP_ClaimPaymentInformation.TotalClaimChargeAmount_03) && !string.IsNullOrEmpty(CLP_ClaimPaymentInformation.ClaimPaymentAmount_04))
                {
                    var segmentError = new SegmentErrorContext("CLP", validationContext.SegmentIndex + 1, null, typeof(CLP_ClaimPaymentInformation).GetTypeInfo());

                    decimal clp03Amount;
                    if (!decimal.TryParse(CLP_ClaimPaymentInformation.TotalClaimChargeAmount_03, out clp03Amount))
                    {
                        var errorContext = new DataElementErrorContext("782", 3, DataElementErrorCode.InvalidCodeValue, 0, 1, CLP_ClaimPaymentInformation.TotalClaimChargeAmount_03, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                    decimal clp04Amount;
                    if (!decimal.TryParse(CLP_ClaimPaymentInformation.ClaimPaymentAmount_04, out clp04Amount))
                    {
                        var errorContext = new DataElementErrorContext("782", 4, DataElementErrorCode.InvalidCodeValue, 0, 1, CLP_ClaimPaymentInformation.ClaimPaymentAmount_04, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                    decimal totalCas2100Amount = GetSumOfCAS();
                    decimal totalCas2110Amount = 0;
                    if (Loop2110 != null)
                    {
                        foreach (var l2110 in Loop2110)
                        {
                            totalCas2110Amount = totalCas2110Amount + l2110.GetSumOfCAS();
                        }
                    }

                    if (clp03Amount - totalCas2100Amount - totalCas2110Amount != clp04Amount)
                    {
                        var errorContext = new DataElementErrorContext("782", 3, DataElementErrorCode.InvalidCodeValue, 0, 1, CLP_ClaimPaymentInformation.TotalClaimChargeAmount_03, "CLP.03 does not match CLP.04 + the sum of CAS2100.03,06,09,12,15,18 + the sum of CAS2110.03,06,09,12,15,18");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                }
            }

            return null;
        }

        public decimal GetSumOfCAS()
        {
            decimal totalCasAmount = 0;

            if (CAS_ClaimsAdjustment != null)
            {
                foreach (var cas in CAS_ClaimsAdjustment)
                {
                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_03))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_03, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_06))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_06, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_09))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_09, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_12))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_12, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_15))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_15, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_18))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_18, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }
                }
            }

            return totalCasAmount;
        }
    }

    /// <summary>
    /// Loop for Service Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServicePaymentInformation), "2110")]
    public class Loop_2110_835 : IEdiValidator
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Payment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SVC_ServicePaymentInformation SVC_ServicePaymentInformation { get; set; }
        /// <summary>
        /// Service Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM_ServiceDate> DTM_ServiceDate { get; set; }
        /// <summary>
        /// Service Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<CAS_ClaimsAdjustment> CAS_ServiceAdjustment { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_835_2 AllREF { get; set; }
        /// <summary>
        /// Service Supplemental Amount
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<AMT_ServiceSupplementalAmount> AMT_ServiceSupplementalAmount { get; set; }
        /// <summary>
        /// Service Supplemental Quantity
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(6)]
        public virtual List<QTY_ServiceSupplementalQuantity> QTY_ServiceSupplementalQuantity { get; set; }
        /// <summary>
        /// Health Care Remark Codes
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<LQ_HealthCareRemarkCodes> LQ_HealthCareRemarkCodes { get; set; }

        public SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            if (validationContext.SNIPLevel == ValidationLevel.Balancing_SNIP3 || validationContext.SNIPLevel == ValidationLevel.InterSegment_SNIP4)
            {
                if (SVC_ServicePaymentInformation != null && !string.IsNullOrEmpty(SVC_ServicePaymentInformation.LineItemChargeAmount_02) && !string.IsNullOrEmpty(SVC_ServicePaymentInformation.MonetaryAmount_03))
                {
                    var segmentError = new SegmentErrorContext("SVC", validationContext.SegmentIndex + 1, null, typeof(SVC_ServicePaymentInformation).GetTypeInfo());

                    decimal svc02Amount;
                    if (!decimal.TryParse(SVC_ServicePaymentInformation.LineItemChargeAmount_02, out svc02Amount))
                    {
                        var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, SVC_ServicePaymentInformation.LineItemChargeAmount_02, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                    decimal svc03Amount;
                    if (!decimal.TryParse(SVC_ServicePaymentInformation.MonetaryAmount_03, out svc03Amount))
                    {
                        var errorContext = new DataElementErrorContext("782", 3, DataElementErrorCode.InvalidCodeValue, 0, 1, SVC_ServicePaymentInformation.MonetaryAmount_03, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }
                    
                    if (CAS_ServiceAdjustment != null)
                    {
                        decimal totalCasAmount = GetSumOfCAS();
                        if (svc02Amount - totalCasAmount != svc03Amount)
                        {
                            var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, SVC_ServicePaymentInformation.LineItemChargeAmount_02, "SVC.02 does not match SVC.03 + the sum of CAS.03,06,09,12,15,18");
                            segmentError.Add(errorContext);
                            return segmentError;
                        }
                    }
                }
            }

            return null;
        }

        public decimal GetSumOfCAS()
        {
            decimal totalCasAmount = 0;

            if (CAS_ServiceAdjustment != null)
            {
                foreach (var cas in CAS_ServiceAdjustment)
                {
                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_03))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_03, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_06))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_06, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_09))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_09, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_12))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_12, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_15))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_15, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(cas.AdjustmentAmount_18))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(cas.AdjustmentAmount_18, out currentAmount))
                        {
                            totalCasAmount = totalCasAmount + currentAmount;
                        }
                    }
                }
            }

            return totalCasAmount;
        }
    }
    
    /// <summary>
    /// Health Care Claim Payment/Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X221A1", "835")]
    public class TS835 : EdiMessage, IEdiValidator
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Financial Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPR_FinancialInformation_2 BPR_FinancialInformation { get; set; }
        /// <summary>
        /// Reassociation Trace Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual TRN_DependentTraceNumber TRN_ReassociationTraceNumber { get; set; }
        /// <summary>
        /// Foreign Currency Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR_ForeignCurrencyInformation_2 CUR_ForeignCurrencyInformation { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual All_REF_835_3 AllREF { get; set; }
        /// <summary>
        /// Production Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTM_ProductionDate DTM_ProductionDate { get; set; }
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual All_N1_835 AllN1 { get; set; }
        /// <summary>
        /// Loop for Header Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_2000_835> Loop2000 { get; set; }
        /// <summary>
        /// Provider Adjustment
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<PLB_ProviderAdjustment> PLB_ProviderAdjustment { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }

        public SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            if (validationContext.SNIPLevel == ValidationLevel.Balancing_SNIP3 || validationContext.SNIPLevel == ValidationLevel.InterSegment_SNIP4)
            {
                if (BPR_FinancialInformation != null && !string.IsNullOrEmpty(BPR_FinancialInformation.TotalPremiumPaymentAmount_02))
                {
                    var segmentError = new SegmentErrorContext("BPR", validationContext.SegmentIndex + 1, null, typeof(BPR_FinancialInformation_2).GetTypeInfo());

                    decimal bpr02Amount;
                    if (!decimal.TryParse(BPR_FinancialInformation.TotalPremiumPaymentAmount_02, out bpr02Amount))
                    {
                        var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, BPR_FinancialInformation.TotalPremiumPaymentAmount_02, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                    var clpAmount = GetSumOfCLP();
                    var plbAmount = GetSumOfPLB();
                    if(clpAmount < 0)
                    {
                        if(bpr02Amount == 0)
                            return null;
                        else
                        {
                            var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, BPR_FinancialInformation.TotalPremiumPaymentAmount_02, "BPR.02 must be 0 when Loop2100.CLP.04 is negative");
                            segmentError.Add(errorContext);
                            return segmentError;
                        }
                    }

                    if (clpAmount - plbAmount != bpr02Amount)
                    {
                        var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, BPR_FinancialInformation.TotalPremiumPaymentAmount_02, "BPR.02 does not match the sum of Loop2100.CLP.04 take away the sum of PLB.04,06,08,10,12,14");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }
                }
            }

            return null;
        }

        public decimal GetSumOfCLP()
        {
            decimal totalAmount = 0;

            if (Loop2000 != null)
            {
                foreach (var l2000 in Loop2000)
                {
                    if (l2000.Loop2100 != null)
                    {
                        foreach (var l2100 in l2000.Loop2100)
                        {
                            if (l2100.CLP_ClaimPaymentInformation != null && !string.IsNullOrEmpty(l2100.CLP_ClaimPaymentInformation.ClaimPaymentAmount_04))
                            {
                                decimal currentAmount;
                                if (decimal.TryParse(l2100.CLP_ClaimPaymentInformation.ClaimPaymentAmount_04, out currentAmount))
                                {
                                    totalAmount = totalAmount + currentAmount;
                                }
                            }
                        }
                    }
                }
            }

            return totalAmount;
        }

        public decimal GetSumOfPLB()
        {
            decimal totalAmount = 0;

            if (PLB_ProviderAdjustment != null)
            {
                foreach (var plb in PLB_ProviderAdjustment)
                {
                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_04))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_04, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_06))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_06, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_08))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_08, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_10))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_10, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_12))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_12, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }

                    if (!string.IsNullOrEmpty(plb.ProviderAdjustmentAmount_14))
                    {
                        decimal currentAmount;
                        if (decimal.TryParse(plb.ProviderAdjustmentAmount_14, out currentAmount))
                        {
                            totalAmount = totalAmount + currentAmount;
                        }
                    }
                }
            }

            return totalAmount;
        }
    }
}
