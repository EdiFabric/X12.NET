namespace EdiFabric.Templates.Hipaa5010
{
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.ErrorCodes;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using EdiFabric.Core.Model.Edi.X12;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for Payee Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PayeeName), "1000A")]
    public class Loop_1000A_820HIX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1_PayeeName N1_PayeeName { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_UniqueHealthPlanIdentifier REF_UniqueHealthPlanIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Payers Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_PayersName), "1000B")]
    public class Loop_1000B_820HIX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1_PayersName N1_PayersName { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PER_PayersAdministrativeContactInformation> PER_PayersAdministrativeContactInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Remittance Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT_RemittanceInformation), "2000")]
    public class Loop_2000_820HIX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity
        /// </summary>
        [SeqCount]
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT_RemittanceInformation ENT_RemittanceInformation { get; set; }
        /// <summary>
        /// Loop for Individual Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100_820HIX Loop2100 { get; set; }
        /// <summary>
        /// Loop for Remittance Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_2300_820HIX> Loop2300 { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_IndividualName), "2100")]
    public class Loop_2100_820HIX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1_IndividualName_2 NM1_IndividualName { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_ExchangeAssignedQualifiedHealthPlanIdentifier REF_ExchangeAssignedQualifiedHealthPlanIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_IssuerAssignedQualifiedHealthPlanIdentifier REF_IssuerAssignedQualifiedHealthPlanIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_ExchangeAssignedEmployerGroupIdentifier REF_ExchangeAssignedEmployerGroupIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_IssuerAssignedEmployerGroupIdentifier REF_IssuerAssignedEmployerGroupIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual REF_ExchangeAssignedPolicyIdentifier REF_ExchangeAssignedPolicyIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_IssuerAssignedPolicyIdentifier REF_IssuerAssignedPolicyIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF_ExchangeAssignedAPTCContributorTaxPayerIdentifier REF_ExchangeAssignedAPTCContributorTaxPayerIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual REF_IssuerAssignedAPTCContributorTaxPayerIdentifier REF_IssuerAssignedAPTCContributorTaxPayerIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual REF_ExchangeAssignedDependentIdentifier REF_ExchangeAssignedDependentIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual REF_IssuerAssignedDependentIdentifier REF_IssuerAssignedDependentIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual REF_IssuerAssignedSubscriberIdentifier REF_IssuerAssignedSubscriberIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Remittance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMR_RemittanceDetail), "2300")]
    public class Loop_2300_820HIX
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Remittance Advice Accounts Receivable Open Item Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RMR_RemittanceDetail RMR_RemittanceDetail { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_ExchangeReportDocumentControlNumber> REF_ExchangeReportDocumentControlNumber { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DTM_IndividualCoveragePeriod_2 DTM_IndividualCoveragePeriod { get; set; }
    }
    
    /// <summary>
    /// Health Insurance Exchange Related Payments
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X306", "820")]
    public class TS820HIX : EdiMessage, IEdiValidator
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
        /// Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPR_FinancialInformation_3 BPR_FinancialInformation { get; set; }
        /// <summary>
        /// Trace
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual TRN_ReassociationTraceNumber_2 TRN_ReassociationTraceNumber { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF_ExchangeAssignedQualifiedHealthPlanIdentifier REF_ExchangeAssignedQualifiedHealthPlanIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF_IssuerAssignedQualifiedHealthPlanIdentifier REF_IssuerAssignedQualifiedHealthPlanIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF_ExchangeAssignedEmployerGroupIdentifier REF_ExchangeAssignedEmployerGroupIdentifier { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF_IssuerAssignedEmployerGroupIdentifier REF_IssuerAssignedEmployerGroupIdentifier { get; set; }
        /// <summary>
        /// Loop for Payee Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual Loop_1000A_820HIX Loop1000A { get; set; }
        /// <summary>
        /// Loop for Payers Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual Loop_1000B_820HIX Loop1000B { get; set; }
        /// <summary>
        /// Loop for Remittance Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual List<Loop_2000_820HIX> Loop2000 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }

        public SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            if (validationContext.SNIPLevel == ValidationLevel.Balancing_SNIP3 || validationContext.SNIPLevel == ValidationLevel.InterSegment_SNIP4)
            {
                if (BPR_FinancialInformation != null)
                {
                    var segmentError = new SegmentErrorContext("BPR", validationContext.SegmentIndex + 1, null, typeof(BPR_FinancialInformation_3).GetTypeInfo());

                    decimal totalBprAmount;
                    if (!decimal.TryParse(BPR_FinancialInformation.TotalPremiumPaymentAmount_02, out totalBprAmount))
                    {
                        var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, BPR_FinancialInformation.TotalPremiumPaymentAmount_02, "Amount must be decimal");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }

                    decimal total2300Amount = 0;
                    if (Loop2000 != null && Loop2000.Count > 0)
                    {
                        foreach (var l2000 in Loop2000)
                        {
                            if (l2000.Loop2300 != null && l2000.Loop2300.Count > 0)
                            {
                                foreach (var l2300 in l2000.Loop2300)
                                {
                                    decimal currentAmount;
                                    if (decimal.TryParse(l2300.RMR_RemittanceDetail.DetailPremiumPaymentAmount_04, out currentAmount))
                                    {
                                        total2300Amount = total2300Amount + currentAmount;
                                    }
                                }
                            }
                        }
                    }

                    if (total2300Amount != totalBprAmount)
                    {
                        var errorContext = new DataElementErrorContext("782", 2, DataElementErrorCode.InvalidCodeValue, 0, 1, BPR_FinancialInformation.TotalPremiumPaymentAmount_02, "The sum of BPR.02 does not match the sum of 2300A.RMR.04 + the sum of 2300B.RMR.04");
                        segmentError.Add(errorContext);
                        return segmentError;
                    }
                }
            }

            return null;
        }
    }
}
