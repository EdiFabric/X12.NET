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
    public class All_N1_834
    {
        
        /// <summary>
        /// Loop for Sponsor Name
        /// </summary>
        [Pos(1)]
        public Loop_1000A_834 Loop1000A { get; set; }
        /// <summary>
        /// Loop for Payer
        /// </summary>
        [Pos(2)]
        public Loop_1000B_834 Loop1000B { get; set; }
        /// <summary>
        /// Loop for TPA/Broker Name
        /// </summary>
        [Pos(3)]
        public List<Loop_1000C_834> Loop1000C { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_834
    {
        
        /// <summary>
        /// Loop for Member Name
        /// </summary>
        [Pos(1)]
        public Loop_2100A_834 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Incorrect Member Name
        /// </summary>
        [Pos(2)]
        public Loop_2100B_834 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Member Mailing Address
        /// </summary>
        [Pos(3)]
        public Loop_2100C_834 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Member Employer
        /// </summary>
        [Pos(4)]
        public List<Loop_2100D_834> Loop2100D { get; set; }
        /// <summary>
        /// Loop for Member School
        /// </summary>
        [Pos(5)]
        public List<Loop_2100E_834> Loop2100E { get; set; }
        /// <summary>
        /// Loop for Custodial Parent
        /// </summary>
        [Pos(6)]
        public Loop_2100F_834 Loop2100F { get; set; }
        /// <summary>
        /// Loop for Responsible Person
        /// </summary>
        [Pos(7)]
        public List<Loop_2100G_834> Loop2100G { get; set; }
        /// <summary>
        /// Loop for Drop Off Location
        /// </summary>
        [Pos(8)]
        public Loop_2100H_834 Loop2100H { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_834
    {
        
        /// <summary>
        /// Health Coverage Policy Number
        /// </summary>
        [Pos(1)]
        public List<REF_HealthCoveragePolicyNumber> REF_HealthCoveragePolicyNumber { get; set; }
        /// <summary>
        /// Prior Coverage Months
        /// </summary>
        [Pos(2)]
        public REF_PriorCoverageMonths REF_PriorCoverageMonths { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_834_2
    {
        
        /// <summary>
        /// Subscriber Identifier
        /// </summary>
        [Pos(1)]
        public REF_SubscriberIdentifier REF_SubscriberIdentifier { get; set; }
        /// <summary>
        /// Member Policy Number
        /// </summary>
        [Pos(2)]
        public REF_MemberPolicyNumber REF_MemberPolicyNumber { get; set; }
        /// <summary>
        /// Member Supplemental Identifier
        /// </summary>
        [Pos(3)]
        public List<REF_MemberSupplementalIdentifier> REF_MemberSupplementalIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Sponsor Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_SponsorName))]
    public class Loop_1000A_834
    {
        
        /// <summary>
        /// Sponsor Name
        /// </summary>
        [Pos(1)]
        public N1_SponsorName N1_SponsorName { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_Payer))]
    public class Loop_1000B_834
    {
        
        /// <summary>
        /// Payer
        /// </summary>
        [Pos(1)]
        public N1_Payer N1_Payer { get; set; }
    }
    
    /// <summary>
    /// Loop for TPA/Broker Name
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_TPA))]
    public class Loop_1000C_834
    {
        
        /// <summary>
        /// TPA/Broker Name
        /// </summary>
        [Pos(1)]
        public N1_TPA N1_TPA_BrokerName { get; set; }
        /// <summary>
        /// Loop for TPA/Broker Account Information
        /// </summary>
        [Pos(2)]
        public Loop_1100C_834 Loop1100C { get; set; }
    }
    
    /// <summary>
    /// Loop for TPA/Broker Account Information
    /// </summary>
    [Serializable()]
    [Group(typeof(ACT_TPA))]
    public class Loop_1100C_834
    {
        
        /// <summary>
        /// TPA/Broker Account Information
        /// </summary>
        [Pos(1)]
        public ACT_TPA ACT_TPA_BrokerAccountInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Level Detail
    /// </summary>
    [Serializable()]
    [Group(typeof(INS_MemberLevelDetail))]
    public class Loop_2000_834
    {
        
        /// <summary>
        /// Member Level Detail
        /// </summary>
        [Pos(1)]
        public INS_MemberLevelDetail INS_MemberLevelDetail { get; set; }
        [Pos(2)]
        public All_REF_834_2 AllREF { get; set; }
        /// <summary>
        /// Member Level Dates
        /// </summary>
        [Pos(3)]
        public List<DTP_MemberLevelDates> DTP_MemberLevelDates { get; set; }
        [Pos(4)]
        public All_NM1_834 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Disability Information
        /// </summary>
        [Pos(5)]
        public List<Loop_2200_834> Loop2200 { get; set; }
        /// <summary>
        /// Loop for Health Coverage
        /// </summary>
        [Pos(6)]
        public List<Loop_2300_834> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Additional Reporting Categories
        /// </summary>
        [Pos(7)]
        public Loop_LS_834 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_MemberName))]
    public class Loop_2100A_834
    {
        
        /// <summary>
        /// Member Name
        /// </summary>
        [Pos(1)]
        public NM1_MemberName NM1_MemberName { get; set; }
        /// <summary>
        /// Member Communications Numbers
        /// </summary>
        [Pos(2)]
        public PER_MemberCommunicationsNumbers PER_MemberCommunicationsNumbers { get; set; }
        /// <summary>
        /// Member Residence Street Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_MemberResidenceStreetAddress { get; set; }
        /// <summary>
        /// Member City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_MemberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Member Demographics
        /// </summary>
        [Pos(5)]
        public DMG_DependentDemographicInformation DMG_MemberDemographics { get; set; }
        /// <summary>
        /// Employment Class
        /// </summary>
        [Pos(6)]
        public List<EC_EmploymentClass> EC_EmploymentClass { get; set; }
        /// <summary>
        /// Member Income
        /// </summary>
        [Pos(7)]
        public ICM_MemberIncome ICM_MemberIncome { get; set; }
        /// <summary>
        /// Member Policy Amounts
        /// </summary>
        [Pos(8)]
        public List<AMT_HealthCoveragePolicy> AMT_MemberPolicyAmounts { get; set; }
        /// <summary>
        /// Member Health Information
        /// </summary>
        [Pos(9)]
        public HLH_MemberHealthInformation HLH_MemberHealthInformation { get; set; }
        /// <summary>
        /// Member Language
        /// </summary>
        [Pos(10)]
        public List<LUI_MemberLanguage> LUI_MemberLanguage { get; set; }
    }
    
    /// <summary>
    /// Loop for Incorrect Member Name
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_IncorrectMemberName))]
    public class Loop_2100B_834
    {
        
        /// <summary>
        /// Incorrect Member Name
        /// </summary>
        [Pos(1)]
        public NM1_IncorrectMemberName NM1_IncorrectMemberName { get; set; }
        /// <summary>
        /// Incorrect Member Demographics
        /// </summary>
        [Pos(2)]
        public DMG_DependentDemographicInformation DMG_IncorrectMemberDemographics { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Mailing Address
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_MemberMailingAddress))]
    public class Loop_2100C_834
    {
        
        /// <summary>
        /// Member Mailing Address
        /// </summary>
        [Pos(1)]
        public NM1_MemberMailingAddress NM1_MemberMailingAddress { get; set; }
        /// <summary>
        /// Member Mail Street Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_MemberMailStreetAddress { get; set; }
        /// <summary>
        /// Member Mail City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_MemberMailCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Employer
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_MemberEmployer))]
    public class Loop_2100D_834
    {
        
        /// <summary>
        /// Member Employer
        /// </summary>
        [Pos(1)]
        public NM1_MemberEmployer NM1_MemberEmployer { get; set; }
        /// <summary>
        /// Member Employer Communications Numbers
        /// </summary>
        [Pos(2)]
        public PER_MemberEmployerCommunicationsNumbers PER_MemberEmployerCommunicationsNumbers { get; set; }
        /// <summary>
        /// Member Employer Street Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_MemberEmployerStreetAddress { get; set; }
        /// <summary>
        /// Member Employer City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_MemberEmployerCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Member School
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_MemberSchool))]
    public class Loop_2100E_834
    {
        
        /// <summary>
        /// Member School
        /// </summary>
        [Pos(1)]
        public NM1_MemberSchool NM1_MemberSchool { get; set; }
        /// <summary>
        /// Member School Commmunications Numbers
        /// </summary>
        [Pos(2)]
        public PER_MemberSchoolCommmunicationsNumbers PER_MemberSchoolCommmunicationsNumbers { get; set; }
        /// <summary>
        /// Member School Street Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_MemberSchoolStreetAddress { get; set; }
        /// <summary>
        /// Member School City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_MemberSchoolCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Custodial Parent
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CustodialParent))]
    public class Loop_2100F_834
    {
        
        /// <summary>
        /// Custodial Parent
        /// </summary>
        [Pos(1)]
        public NM1_CustodialParent NM1_CustodialParent { get; set; }
        /// <summary>
        /// Custodial Parent Communications Numbers
        /// </summary>
        [Pos(2)]
        public PER_CustodialParentCommunicationsNumbers PER_CustodialParentCommunicationsNumbers { get; set; }
        /// <summary>
        /// Custodial Parent Street Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_CustodialParentStreetAddress { get; set; }
        /// <summary>
        /// Custodial Parent City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_CustodialParentCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Responsible Person
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_ResponsiblePerson))]
    public class Loop_2100G_834
    {
        
        /// <summary>
        /// Responsible Person
        /// </summary>
        [Pos(1)]
        public NM1_ResponsiblePerson NM1_ResponsiblePerson { get; set; }
        /// <summary>
        /// Responsible Person Communications Numbers
        /// </summary>
        [Pos(2)]
        public PER_ResponsiblePersonCommunicationsNumbers PER_ResponsiblePersonCommunicationsNumbers { get; set; }
        /// <summary>
        /// Responsible Person Street Address
        /// </summary>
        [Pos(3)]
        public N3_AdditionalPatientInformationContactAddress N3_ResponsiblePersonStreetAddress { get; set; }
        /// <summary>
        /// Responsible Person City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_ResponsiblePersonCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Drop Off Location
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_DropOffLocation))]
    public class Loop_2100H_834
    {
        
        /// <summary>
        /// Drop Off Location
        /// </summary>
        [Pos(1)]
        public NM1_DropOffLocation NM1_DropOffLocation { get; set; }
        /// <summary>
        /// Drop Off Location Street Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_DropOffLocationStreetAddress { get; set; }
        /// <summary>
        /// Drop Off Location City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_DropOffLocationCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Disability Information
    /// </summary>
    [Serializable()]
    [Group(typeof(DSB_DisabilityInformation))]
    public class Loop_2200_834
    {
        
        /// <summary>
        /// Disability Information
        /// </summary>
        [Pos(1)]
        public DSB_DisabilityInformation DSB_DisabilityInformation { get; set; }
        /// <summary>
        /// Disability Eligibility Dates
        /// </summary>
        [Pos(2)]
        public List<DTP_DisabilityEligibilityDates> DTP_DisabilityEligibilityDates { get; set; }
    }
    
    /// <summary>
    /// Loop for Health Coverage
    /// </summary>
    [Serializable()]
    [Group(typeof(HD_HealthCoverage))]
    public class Loop_2300_834
    {
        
        /// <summary>
        /// Health Coverage
        /// </summary>
        [Pos(1)]
        public HD_HealthCoverage HD_HealthCoverage { get; set; }
        /// <summary>
        /// Health Coverage Dates
        /// </summary>
        [Pos(2)]
        public List<DTP_HealthCoverageDates> DTP_HealthCoverageDates { get; set; }
        /// <summary>
        /// Health Coverage Policy
        /// </summary>
        [Pos(3)]
        public List<AMT_HealthCoveragePolicy> AMT_HealthCoveragePolicy { get; set; }
        [Pos(4)]
        public All_REF_834 AllREF { get; set; }
        /// <summary>
        /// Identification Card
        /// </summary>
        [Pos(5)]
        public List<IDC_IdentificationCard> IDC_IdentificationCard { get; set; }
        /// <summary>
        /// Loop for Provider Information
        /// </summary>
        [Pos(6)]
        public List<Loop_2310_834> Loop2310 { get; set; }
        /// <summary>
        /// Loop for Coordination of Benefits
        /// </summary>
        [Pos(7)]
        public List<Loop_2320_834> Loop2320 { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider Information
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2310_834
    {
        
        /// <summary>
        /// Provider Information
        /// </summary>
        [Pos(1)]
        public LX_HeaderNumber LX_ProviderInformation { get; set; }
        /// <summary>
        /// Provider Name
        /// </summary>
        [Pos(2)]
        public NM1_ProviderName_2 NM1_ProviderName { get; set; }
        /// <summary>
        /// Provider Address
        /// </summary>
        [Pos(3)]
        public List<N3_AdditionalPatientInformationContactAddress> N3_ProviderAddress { get; set; }
        /// <summary>
        /// Provider City, State, ZIP Code
        /// </summary>
        [Pos(4)]
        public N4_AdditionalPatientInformationContactCity N4_ProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Communications Numbers
        /// </summary>
        [Pos(5)]
        public List<PER_AdditionalPatientInformationContactInformation> PER_ProviderCommunicationsNumbers { get; set; }
        /// <summary>
        /// Provider Change Reason
        /// </summary>
        [Pos(6)]
        public PLA_ProviderChangeReason PLA_ProviderChangeReason { get; set; }
    }
    
    /// <summary>
    /// Loop for Coordination of Benefits
    /// </summary>
    [Serializable()]
    [Group(typeof(COB_CoordinationofBenefits))]
    public class Loop_2320_834
    {
        
        /// <summary>
        /// Coordination of Benefits
        /// </summary>
        [Pos(1)]
        public COB_CoordinationofBenefits COB_CoordinationofBenefits { get; set; }
        /// <summary>
        /// Additional Coordination of Benefits Identifiers
        /// </summary>
        [Pos(2)]
        public List<REF_AdditionalCoordinationofBenefitsIdentifiers> REF_AdditionalCoordinationofBenefitsIdentifiers { get; set; }
        /// <summary>
        /// Coordination of Benefits Eligibility Dates
        /// </summary>
        [Pos(3)]
        public List<DTP_CoordinationofBenefitsEligibilityDates> DTP_CoordinationofBenefitsEligibilityDates { get; set; }
        /// <summary>
        /// Loop for Coordination of Benefits Related Entity
        /// </summary>
        [Pos(4)]
        public List<Loop_2330_834> Loop2330 { get; set; }
    }
    
    /// <summary>
    /// Loop for Coordination of Benefits Related Entity
    /// </summary>
    [Serializable()]
    [Group(typeof(NM1_CoordinationofBenefitsRelatedEntity))]
    public class Loop_2330_834
    {
        
        /// <summary>
        /// Coordination of Benefits Related Entity
        /// </summary>
        [Pos(1)]
        public NM1_CoordinationofBenefitsRelatedEntity NM1_CoordinationofBenefitsRelatedEntity { get; set; }
        /// <summary>
        /// Coordination of Benefits Related Entity Address
        /// </summary>
        [Pos(2)]
        public N3_AdditionalPatientInformationContactAddress N3_CoordinationofBenefitsRelatedEntityAddress { get; set; }
        /// <summary>
        /// Coordination of Benefits Other Insurance Company City, State, ZIP Code
        /// </summary>
        [Pos(3)]
        public N4_AdditionalPatientInformationContactCity N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [Pos(4)]
        public PER_AdministrativeCommunicationsContact PER_AdministrativeCommunicationsContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Reporting Categories
    /// </summary>
    [Serializable()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2700_834
    {
        
        /// <summary>
        /// Member Reporting Categories
        /// </summary>
        [Pos(1)]
        public LX_HeaderNumber LX_MemberReportingCategories { get; set; }
        /// <summary>
        /// Loop for Reporting Category
        /// </summary>
        [Pos(2)]
        public Loop_2750_834 Loop2750 { get; set; }
    }
    
    /// <summary>
    /// Loop for Reporting Category
    /// </summary>
    [Serializable()]
    [Group(typeof(N1_ReportingCategory))]
    public class Loop_2750_834
    {
        
        /// <summary>
        /// Reporting Category
        /// </summary>
        [Pos(1)]
        public N1_ReportingCategory N1_ReportingCategory { get; set; }
        /// <summary>
        /// Reporting Category Reference
        /// </summary>
        [Pos(2)]
        public REF_ReportingCategoryReference REF_ReportingCategoryReference { get; set; }
        /// <summary>
        /// Reporting Category Date
        /// </summary>
        [Pos(3)]
        public DTP_CertificationEffectiveDate DTP_ReportingCategoryDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Reporting Categories
    /// </summary>
    [Serializable()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_834
    {
        
        /// <summary>
        /// Additional Reporting Categories
        /// </summary>
        [Pos(1)]
        public LS_AdditionalReportingCategories LS_AdditionalReportingCategories { get; set; }
        /// <summary>
        /// Loop for Member Reporting Categories
        /// </summary>
        [Pos(2)]
        public List<Loop_2700_834> Loop2700 { get; set; }
        /// <summary>
        /// Additional Reporting Categories Termination
        /// </summary>
        [Pos(3)]
        public LE_AdditionalReportingCategoriesTermination LE_AdditionalReportingCategoriesTermination { get; set; }
    }
    
    /// <summary>
    /// Benefit Enrollment and Maintenance
    /// </summary>
    [Serializable()]
    [Message("X12", "005010X220A1", "834")]
    public class TS834 : EdiMessage
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [Pos(1)]
        public ST ST { get; set; }
        /// <summary>
        /// Beginning Segment
        /// </summary>
        [Pos(2)]
        public BGN_BeginningSegment BGN_BeginningSegment { get; set; }
        /// <summary>
        /// Transaction Set Policy Number
        /// </summary>
        [Pos(3)]
        public REF_TransactionSetPolicyNumber REF_TransactionSetPolicyNumber { get; set; }
        /// <summary>
        /// File Effective Date
        /// </summary>
        [Pos(4)]
        public List<DTP_FileEffectiveDate> DTP_FileEffectiveDate { get; set; }
        /// <summary>
        /// Transaction Set Control Totals
        /// </summary>
        [Pos(5)]
        public List<QTY_TransactionSetControlTotals> QTY_TransactionSetControlTotals { get; set; }
        [Pos(6)]
        public All_N1_834 AllN1 { get; set; }
        /// <summary>
        /// Loop for Member Level Detail
        /// </summary>
        [Pos(7)]
        public List<Loop_2000_834> Loop2000 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [Pos(8)]
        public SE SE { get; set; }
    }
}
