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
    public class All_N1_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Sponsor Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_1000A_834 Loop1000A { get; set; }
        /// <summary>
        /// Loop for Payer
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_1000B_834 Loop1000B { get; set; }
        /// <summary>
        /// Loop for TPA/Broker Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_1000C_834> Loop1000C { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_NM1_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop for Member Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual Loop_2100A_834 Loop2100A { get; set; }
        /// <summary>
        /// Loop for Incorrect Member Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2100B_834 Loop2100B { get; set; }
        /// <summary>
        /// Loop for Member Mailing Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_2100C_834 Loop2100C { get; set; }
        /// <summary>
        /// Loop for Member Employer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2100D_834> Loop2100D { get; set; }
        /// <summary>
        /// Loop for Member School
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2100E_834> Loop2100E { get; set; }
        /// <summary>
        /// Loop for Custodial Parent
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_2100F_834 Loop2100F { get; set; }
        /// <summary>
        /// Loop for Responsible Person
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2100G_834> Loop2100G { get; set; }
        /// <summary>
        /// Loop for Drop Off Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_2100H_834 Loop2100H { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Coverage Policy Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<REF_HealthCoveragePolicyNumber> REF_HealthCoveragePolicyNumber { get; set; }
        /// <summary>
        /// Prior Coverage Months
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_PriorCoverageMonths REF_PriorCoverageMonths { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [All()]
    public class All_REF_834_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual REF_SubscriberIdentifier REF_SubscriberIdentifier { get; set; }
        /// <summary>
        /// Member Policy Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_MemberPolicyNumber REF_MemberPolicyNumber { get; set; }
        /// <summary>
        /// Member Supplemental Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF_MemberSupplementalIdentifier> REF_MemberSupplementalIdentifier { get; set; }
    }
    
    /// <summary>
    /// Loop for Sponsor Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_SponsorName))]
    public class Loop_1000A_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sponsor Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_SponsorName N1_SponsorName { get; set; }
    }
    
    /// <summary>
    /// Loop for Payer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_Payer))]
    public class Loop_1000B_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payer
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_Payer N1_Payer { get; set; }
    }
    
    /// <summary>
    /// Loop for TPA/Broker Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_TPA))]
    public class Loop_1000C_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TPA/Broker Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_TPA N1_TPA_BrokerName { get; set; }
        /// <summary>
        /// Loop for TPA/Broker Account Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_1100C_834 Loop1100C { get; set; }
    }
    
    /// <summary>
    /// Loop for TPA/Broker Account Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ACT_TPA))]
    public class Loop_1100C_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TPA/Broker Account Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ACT_TPA ACT_TPA_BrokerAccountInformation { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Level Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INS_MemberLevelDetail))]
    public class Loop_2000_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Level Detail
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual INS_MemberLevelDetail INS_MemberLevelDetail { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual All_REF_834_2 AllREF { get; set; }
        /// <summary>
        /// Member Level Dates
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP_MemberLevelDates> DTP_MemberLevelDates { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_NM1_834 AllNM1 { get; set; }
        /// <summary>
        /// Loop for Disability Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_2200_834> Loop2200 { get; set; }
        /// <summary>
        /// Loop for Health Coverage
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_2300_834> Loop2300 { get; set; }
        /// <summary>
        /// Loop for Additional Reporting Categories
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_LS_834 LoopLS { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_MemberName))]
    public class Loop_2100A_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_MemberName NM1_MemberName { get; set; }
        /// <summary>
        /// Member Communications Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_MemberCommunicationsNumbers PER_MemberCommunicationsNumbers { get; set; }
        /// <summary>
        /// Member Residence Street Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_MemberResidenceStreetAddress { get; set; }
        /// <summary>
        /// Member City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_MemberCity N4_MemberCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Member Demographics
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG_MemberDemographics DMG_MemberDemographics { get; set; }
        /// <summary>
        /// Employment Class
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<EC_EmploymentClass> EC_EmploymentClass { get; set; }
        /// <summary>
        /// Member Income
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ICM_MemberIncome ICM_MemberIncome { get; set; }
        /// <summary>
        /// Member Policy Amounts
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<AMT_HealthCoveragePolicy> AMT_MemberPolicyAmounts { get; set; }
        /// <summary>
        /// Member Health Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual HLH_MemberHealthInformation HLH_MemberHealthInformation { get; set; }
        /// <summary>
        /// Member Language
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<LUI_MemberLanguage> LUI_MemberLanguage { get; set; }
    }
    
    /// <summary>
    /// Loop for Incorrect Member Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_IncorrectMemberName))]
    public class Loop_2100B_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Incorrect Member Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_IncorrectMemberName NM1_IncorrectMemberName { get; set; }
        /// <summary>
        /// Incorrect Member Demographics
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DMG_IncorrectMemberDemographics DMG_IncorrectMemberDemographics { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Mailing Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_MemberMailingAddress))]
    public class Loop_2100C_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Mailing Address
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_MemberMailingAddress NM1_MemberMailingAddress { get; set; }
        /// <summary>
        /// Member Mail Street Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_MemberMailStreetAddress { get; set; }
        /// <summary>
        /// Member Mail City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_MemberMailCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Employer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_MemberEmployer))]
    public class Loop_2100D_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Employer
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_MemberEmployer NM1_MemberEmployer { get; set; }
        /// <summary>
        /// Member Employer Communications Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_MemberEmployerCommunicationsNumbers PER_MemberEmployerCommunicationsNumbers { get; set; }
        /// <summary>
        /// Member Employer Street Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_MemberEmployerStreetAddress { get; set; }
        /// <summary>
        /// Member Employer City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_MemberEmployerCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Member School
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_MemberSchool))]
    public class Loop_2100E_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member School
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_MemberSchool NM1_MemberSchool { get; set; }
        /// <summary>
        /// Member School Commmunications Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_MemberSchoolCommmunicationsNumbers PER_MemberSchoolCommmunicationsNumbers { get; set; }
        /// <summary>
        /// Member School Street Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_MemberSchoolStreetAddress { get; set; }
        /// <summary>
        /// Member School City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_MemberSchoolCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Custodial Parent
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_CustodialParent))]
    public class Loop_2100F_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Custodial Parent
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_CustodialParent NM1_CustodialParent { get; set; }
        /// <summary>
        /// Custodial Parent Communications Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_CustodialParentCommunicationsNumbers PER_CustodialParentCommunicationsNumbers { get; set; }
        /// <summary>
        /// Custodial Parent Street Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_CustodialParentStreetAddress { get; set; }
        /// <summary>
        /// Custodial Parent City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_CustodialParentCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Responsible Person
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_ResponsiblePerson))]
    public class Loop_2100G_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Responsible Person
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_ResponsiblePerson NM1_ResponsiblePerson { get; set; }
        /// <summary>
        /// Responsible Person Communications Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER_ResponsiblePersonCommunicationsNumbers PER_ResponsiblePersonCommunicationsNumbers { get; set; }
        /// <summary>
        /// Responsible Person Street Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_ResponsiblePersonStreetAddress { get; set; }
        /// <summary>
        /// Responsible Person City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_AdditionalPatientInformationContactCity N4_ResponsiblePersonCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Drop Off Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_DropOffLocation))]
    public class Loop_2100H_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Drop Off Location
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_DropOffLocation NM1_DropOffLocation { get; set; }
        /// <summary>
        /// Drop Off Location Street Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_DropOffLocationStreetAddress { get; set; }
        /// <summary>
        /// Drop Off Location City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_DropOffLocationCity_State_ZIPCode { get; set; }
    }
    
    /// <summary>
    /// Loop for Disability Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DSB_DisabilityInformation))]
    public class Loop_2200_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Disability Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DSB_DisabilityInformation DSB_DisabilityInformation { get; set; }
        /// <summary>
        /// Disability Eligibility Dates
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP_DisabilityEligibilityDates> DTP_DisabilityEligibilityDates { get; set; }
    }
    
    /// <summary>
    /// Loop for Health Coverage
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HD_HealthCoverage))]
    public class Loop_2300_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Coverage
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HD_HealthCoverage HD_HealthCoverage { get; set; }
        /// <summary>
        /// Health Coverage Dates
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP_HealthCoverageDates> DTP_HealthCoverageDates { get; set; }
        /// <summary>
        /// Health Coverage Policy
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AMT_HealthCoveragePolicy> AMT_HealthCoveragePolicy { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual All_REF_834 AllREF { get; set; }
        /// <summary>
        /// Identification Card
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<IDC_IdentificationCard> IDC_IdentificationCard { get; set; }
        /// <summary>
        /// Loop for Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_2310_834> Loop2310 { get; set; }
        /// <summary>
        /// Loop for Coordination of Benefits
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2320_834> Loop2320 { get; set; }
    }
    
    /// <summary>
    /// Loop for Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2310_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LX_HeaderNumber LX_ProviderInformation { get; set; }
        /// <summary>
        /// Provider Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1_ProviderName_2 NM1_ProviderName { get; set; }
        /// <summary>
        /// Provider Address
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N3_AdditionalPatientInformationContactAddress> N3_ProviderAddress { get; set; }
        /// <summary>
        /// Provider City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4_ProviderCity N4_ProviderCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Provider Communications Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER_ProviderCommunicationsNumbers> PER_ProviderCommunicationsNumbers { get; set; }
        /// <summary>
        /// Provider Change Reason
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PLA_ProviderChangeReason PLA_ProviderChangeReason { get; set; }
    }
    
    /// <summary>
    /// Loop for Coordination of Benefits
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(COB_CoordinationofBenefits))]
    public class Loop_2320_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Coordination of Benefits
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual COB_CoordinationofBenefits COB_CoordinationofBenefits { get; set; }
        /// <summary>
        /// Additional Coordination of Benefits Identifiers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF_AdditionalCoordinationofBenefitsIdentifiers> REF_AdditionalCoordinationofBenefitsIdentifiers { get; set; }
        /// <summary>
        /// Coordination of Benefits Eligibility Dates
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP_CoordinationofBenefitsEligibilityDates> DTP_CoordinationofBenefitsEligibilityDates { get; set; }
        /// <summary>
        /// Loop for Coordination of Benefits Related Entity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_2330_834> Loop2330 { get; set; }
    }
    
    /// <summary>
    /// Loop for Coordination of Benefits Related Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1_CoordinationofBenefitsRelatedEntity))]
    public class Loop_2330_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Coordination of Benefits Related Entity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NM1_CoordinationofBenefitsRelatedEntity NM1_CoordinationofBenefitsRelatedEntity { get; set; }
        /// <summary>
        /// Coordination of Benefits Related Entity Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3_AdditionalPatientInformationContactAddress N3_CoordinationofBenefitsRelatedEntityAddress { get; set; }
        /// <summary>
        /// Coordination of Benefits Other Insurance Company City, State, ZIP Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4_AdditionalPatientInformationContactCity N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER_AdministrativeCommunicationsContact PER_AdministrativeCommunicationsContact { get; set; }
    }
    
    /// <summary>
    /// Loop for Member Reporting Categories
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2700_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Member Reporting Categories
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LX_HeaderNumber LX_MemberReportingCategories { get; set; }
        /// <summary>
        /// Loop for Reporting Category
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_2750_834 Loop2750 { get; set; }
    }
    
    /// <summary>
    /// Loop for Reporting Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1_ReportingCategory))]
    public class Loop_2750_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reporting Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual N1_ReportingCategory N1_ReportingCategory { get; set; }
        /// <summary>
        /// Reporting Category Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF_ReportingCategoryReference REF_ReportingCategoryReference { get; set; }
        /// <summary>
        /// Reporting Category Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP_CertificationEffectiveDate DTP_ReportingCategoryDate { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Reporting Categories
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS_AdditionalReportingCategories))]
    public class Loop_LS_834
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Additional Reporting Categories
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LS_AdditionalReportingCategories LS_AdditionalReportingCategories { get; set; }
        /// <summary>
        /// Loop for Member Reporting Categories
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_2700_834> Loop2700 { get; set; }
        /// <summary>
        /// Additional Reporting Categories Termination
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LE_AdditionalReportingCategoriesTermination LE_AdditionalReportingCategoriesTermination { get; set; }
    }
    
    /// <summary>
    /// Benefit Enrollment and Maintenance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "005010X220A1", "834")]
    public class TS834 : EdiMessage
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
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual BGN_BeginningSegment BGN_BeginningSegment { get; set; }
        /// <summary>
        /// Transaction Set Policy Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF_TransactionSetPolicyNumber REF_TransactionSetPolicyNumber { get; set; }
        /// <summary>
        /// File Effective Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP_FileEffectiveDate> DTP_FileEffectiveDate { get; set; }
        /// <summary>
        /// Transaction Set Control Totals
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY_TransactionSetControlTotals> QTY_TransactionSetControlTotals { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual All_N1_834 AllN1 { get; set; }
        /// <summary>
        /// Loop for Member Level Detail
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_2000_834> Loop2000 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
