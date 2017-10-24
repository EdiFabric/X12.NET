namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [Composite("C108")]
    public class C108
    {
        
        [Required]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetext_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetext_02 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetext_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetext_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C107")]
    public class C107
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("4441", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C506")]
    public class C506
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referencenumber_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Linenumber_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionnumber_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C901")]
    public class C901
    {
        
        [Required]
        [StringLength(1, 8)]
        [DataElement("9321", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Applicationerroridentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C076")]
    public class C076
    {
        
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationchannelqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C056")]
    public class C056
    {
        
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployee_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C059")]
    public class C059
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberpobox_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C080")]
    public class C080
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcoded_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C058")]
    public class C058
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressline_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C082")]
    public class C082
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyididentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C507")]
    public class C507
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Datetimeperiodqualifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Datetimeperiod_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C270")]
    public class C270
    {
        
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentmessagenamecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentmessagename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C088")]
    public class C088
    {
        
        [StringLength(1, 11)]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }
    
    [Serializable()]
    [Composite("C078")]
    public class C078
    {
        
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C503")]
    public class C503
    {
        
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        [DataElement("1373", typeof(EDIFACT_ID_1373))]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Languagecoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C516")]
    public class C516
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypequalifier_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Currencycoded_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statuscoded_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C529")]
    public class C529
    {
        
        [Required]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(1)]
        public string Processingindicatorcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(4)]
        public string Processtypeidentification_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C286")]
    public class C286
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sequencenumber_01 { get; set; }
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(2)]
        public string Sequencenumbersourcecoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C829")]
    public class C829
    {
        
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C212")]
    public class C212
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemnumbertypecoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C551")]
    public class C551
    {
        
        [Required]
        [DataElement("4383", typeof(EDIFACT_ID_4383))]
        [Pos(1)]
        public string Bankoperationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C521")]
    public class C521
    {
        
        [Required]
        [DataElement("4027", typeof(EDIFACT_ID_4027))]
        [Pos(1)]
        public string Businessfunctionqualifier_01 { get; set; }
        [Required]
        [DataElement("4025", typeof(EDIFACT_ID_4025))]
        [Pos(2)]
        public string Businessfunctioncoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4022", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Businessdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C501")]
    public class C501
    {
        
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagequalifier_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasiscoded_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C504")]
    public class C504
    {
        
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Currencycoded_02 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratebase_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C236")]
    public class C236
    {
        
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dangerousgoodslabelmarking_01 { get; set; }
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dangerousgoodslabelmarking_02 { get; set; }
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Dangerousgoodslabelmarking_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C235")]
    public class C235
    {
        
        [StringLength(1, 4)]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardidentificationnumberupperpart_01 { get; set; }
        [StringLength(4, 4)]
        [DataElement("8186", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Substanceidentificationnumberlowerpart_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C223")]
    public class C223
    {
        
        [StringLength(3, 3)]
        [DataElement("7106", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Shipmentflashpoint_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C234")]
    public class C234
    {
        
        [StringLength(4, 4)]
        [DataElement("7124", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UNDGnumber_01 { get; set; }
        [StringLength(1, 8)]
        [DataElement("7088", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dangerousgoodsflashpoint_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C205")]
    public class C205
    {
        
        [Required]
        [StringLength(1, 7)]
        [DataElement("8351", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardcodeidentification_01 { get; set; }
        [StringLength(1, 7)]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Hazardsubstanceitempagenumber_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("8092", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Hazardcodeversionnumber_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C237")]
    public class C237
    {
        
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C224")]
    public class C224
    {
        
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypeidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Equipmentsizeandtype_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C553")]
    public class C553
    {
        
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationtwo_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C519")]
    public class C519
    {
        
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Placelocationidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Placelocation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C280")]
    public class C280
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C239")]
    public class C239
    {
        
        [StringLength(3, 3)]
        [DataElement("6246", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Temperaturesetting_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C211")]
    public class C211
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lengthdimension_02 { get; set; }
        [StringLength(1, 15)]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Widthdimension_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Heightdimension_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C174")]
    public class C174
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigits_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C502")]
    public class C502
    {
        
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measurementdimensioncoded_01 { get; set; }
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Measurementattributecoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measurementattribute_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C703")]
    public class C703
    {
        
        [Required]
        [DataElement("7085", typeof(EDIFACT_ID_7085))]
        [Pos(1)]
        public string Natureofcargocoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C213")]
    public class C213
    {
        
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackagesidentification_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C222")]
    public class C222
    {
        
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Idofmeansoftransportidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Idofthemeansoftransport_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nationalityofmeansoftransportcoded_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C401")]
    public class C401
    {
        
        [Required]
        [DataElement("8457", typeof(EDIFACT_ID_8457))]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }
        [Required]
        [DataElement("8459", typeof(EDIFACT_ID_8459))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customerauthorizationnumber_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040")]
    public class C040
    {
        
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C228")]
    public class C228
    {
        
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Typeofmeansoftransportidentification_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofmeansoftransport_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C220")]
    public class C220
    {
        
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Modeoftransportcoded_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Modeoftransport_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C523")]
    public class C523
    {
        
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofunits_01 { get; set; }
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(2)]
        public string Numberofunitsqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C509")]
    public class C509
    {
        
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Price_02 { get; set; }
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricetypequalifier_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Measureunitqualifier_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C186")]
    public class C186
    {
        
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C206")]
    public class C206
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C550")]
    public class C550
    {
        
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C824")]
    public class C824
    {
        
        [StringLength(1, 3)]
        [DataElement("7507", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Componentmaterialcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7506", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Componentmaterial_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C823")]
    public class C823
    {
        
        [StringLength(1, 3)]
        [DataElement("7505", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofunitcomponentcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7504", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofunitcomponent_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C826")]
    public class C826
    {
        
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string Actionrequestnotificationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Actionrequestnotification_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C825")]
    public class C825
    {
        
        [StringLength(1, 3)]
        [DataElement("7509", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Damageseveritycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7508", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Damageseverity_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C822")]
    public class C822
    {
        
        [StringLength(1, 4)]
        [DataElement("7503", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Damageareaidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Damagearea_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C821")]
    public class C821
    {
        
        [StringLength(1, 3)]
        [DataElement("7501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofdamagecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7500", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofdamage_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C215")]
    public class C215
    {
        
        [DataElement("9303", typeof(EDIFACT_ID_9303))]
        [Pos(1)]
        public string Sealingpartycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Sealingparty_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C219")]
    public class C219
    {
        
        [DataElement("8335", typeof(EDIFACT_ID_8335))]
        [Pos(1)]
        public string Movementtypecoded_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("8334", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Movementtype_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C218")]
    public class C218
    {
        
        [StringLength(1, 4)]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C524")]
    public class C524
    {
        
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C232")]
    public class C232
    {
        
        [DataElement("9415", typeof(EDIFACT_ID_9415))]
        [Pos(1)]
        public string Governmentagencycoded_01 { get; set; }
        [DataElement("9411", typeof(EDIFACT_ID_9411))]
        [Pos(2)]
        public string Governmentinvolvementcoded_02 { get; set; }
        [DataElement("9417", typeof(EDIFACT_ID_9417))]
        [Pos(3)]
        public string Governmentactioncoded_03 { get; set; }
        [DataElement("9353", typeof(EDIFACT_ID_9353))]
        [Pos(4)]
        public string Governmentprocedurecoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C850")]
    public class C850
    {
        
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C522")]
    public class C522
    {
        
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instruction_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C849")]
    public class C849
    {
        
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301))]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }
        [DataElement("3285", typeof(EDIFACT_ID_3285))]
        [Pos(2)]
        public string Recipientoftheinstructionidentification_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C243")]
    public class C243
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C533")]
    public class C533
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C241")]
    public class C241
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C549")]
    public class C549
    {
        
        [Required]
        [DataElement("5007", typeof(EDIFACT_ID_5007))]
        [Pos(1)]
        public string Monetaryfunctioncoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C960")]
    public class C960
    {
        
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C138")]
    public class C138
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultiplierqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C112")]
    public class C112
    {
        
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofperiods_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C110")]
    public class C110
    {
        
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofpayment_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C534")]
    public class C534
    {
        
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcoded_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C045")]
    public class C045
    {
        
        [StringLength(1, 17)]
        [DataElement("7436", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Leveloneid_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7438", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Leveltwoid_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Levelthreeid_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7442", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Levelfourid_04 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7444", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Levelfiveid_05 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7446", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Levelsixid_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C546")]
    public class C546
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5030", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Indexvalue_01 { get; set; }
        [DataElement("5039", typeof(EDIFACT_ID_5039))]
        [Pos(2)]
        public string Indexvaluerepresentationcoded_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C545")]
    public class C545
    {
        
        [Required]
        [DataElement("5013", typeof(EDIFACT_ID_5013))]
        [Pos(1)]
        public string Indexqualifier_01 { get; set; }
        [DataElement("5027", typeof(EDIFACT_ID_5027))]
        [Pos(2)]
        public string Indextypecoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C273")]
    public class C273
    {
        
        [StringLength(1, 17)]
        [DataElement("7009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Languagecoded_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C543")]
    public class C543
    {
        
        [Required]
        [DataElement("7431", typeof(EDIFACT_ID_7431))]
        [Pos(1)]
        public string Agreementtypequalifier_01 { get; set; }
        [DataElement("7433", typeof(EDIFACT_ID_7433))]
        [Pos(2)]
        public string Agreementtypecoded_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("7434", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Agreementtypedescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C079")]
    public class C079
    {
        
        [StringLength(1, 3)]
        [DataElement("1511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Computerenvironmentcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Computerenvironment_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Version_05 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Release_06 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Identitynumber_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C099")]
    public class C099
    {
        
        [Required]
        [StringLength(1, 17)]
        [DataElement("1516", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Fileformat_01 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Version_02 { get; set; }
        [DataElement("1503", typeof(EDIFACT_ID_1503))]
        [Pos(3)]
        public string Dataformatcoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dataformat_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C077")]
    public class C077
    {
        
        [StringLength(1, 35)]
        [DataElement("1508", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Filename_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Itemdescription_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C214")]
    public class C214
    {
        
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservice_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservice_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C552")]
    public class C552
    {
        
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Chargeallowancedescriptioncoded_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C128")]
    public class C128
    {
        
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measureunitqualifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C537")]
    public class C537
    {
        
        [Required]
        [DataElement("4219", typeof(EDIFACT_ID_4219))]
        [Pos(1)]
        public string Transportprioritycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C233")]
    public class C233
    {
        
        [Required]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(1)]
        public string Servicerequirementcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(4)]
        public string Servicerequirementcoded_04 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C536")]
    public class C536
    {
        
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065))]
        [Pos(1)]
        public string Contractandcarriageconditioncoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C827")]
    public class C827
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C210")]
    public class C210
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarks_10 { get; set; }
    }
    
    [Serializable()]
    [Composite("C878")]
    public class C878
    {
        
        [Required]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionbranchnumber_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Accountholdernumber_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Currencycoded_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C242")]
    public class C242
    {
        
        [Required]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(1)]
        public string Processtypeidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Processtype_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Processtype_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C246")]
    public class C246
    {
        
        [Required]
        [StringLength(1, 18)]
        [DataElement("7361", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Customscodeidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C532")]
    public class C532
    {
        
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscoded_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C402")]
    public class C402
    {
        
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemnumbertypecoded_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C202")]
    public class C202
    {
        
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C531")]
    public class C531
    {
        
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C231")]
    public class C231
    {
        
        [Required]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(1)]
        public string Transportchargesmethodofpaymentcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C229")]
    public class C229
    {
        
        [Required]
        [DataElement("5237", typeof(EDIFACT_ID_5237))]
        [Pos(1)]
        public string Chargecategorycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C279")]
    public class C279
    {
        
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string Quantityqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C100")]
    public class C100
    {
        
        [StringLength(1, 3)]
        [DataElement("4053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Termsofdeliveryortransportcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofdeliveryortransport_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofdeliveryortransport_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C208")]
    public class C208
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Identitynumber_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C701")]
    public class C701
    {
        
        [Required]
        [DataElement("1049", typeof(EDIFACT_ID_1049))]
        [Pos(1)]
        public string Messagesectioncoded_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1052", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Messageitemnumber_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1054", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Messagesubitemnumber_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C329")]
    public class C329
    {
        
        [DataElement("2013", typeof(EDIFACT_ID_2013))]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }
        [DataElement("2015", typeof(EDIFACT_ID_2015))]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C702")]
    public class C702
    {
        
        [StringLength(1, 4)]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Simpledataelementtag_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C709")]
    public class C709
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("1475", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Messagetypeidentifier_01 { get; set; }
        [Required]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Version_02 { get; set; }
        [Required]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Release_03 { get; set; }
        [Required]
        [StringLength(1, 2)]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Controlagency_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1523", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Associationassignedidentification_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionnumber_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C784")]
    public class C784
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("9432", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Footnoteidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C240")]
    public class C240
    {
        
        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristic_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristic_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C778")]
    public class C778
    {
        
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Sequencenumber_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C770")]
    public class C770
    {
        
        [StringLength(1, 35)]
        [DataElement("9424", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Arraycellinformation_01 { get; set; }
    }
    
    [Serializable()]
    [Composite("C941")]
    public class C941
    {
        
        [StringLength(1, 3)]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relationshipcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9142", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relationship_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C783")]
    public class C783
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("9430", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Footnotesetidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C956")]
    public class C956
    {
        
        [StringLength(1, 3)]
        [DataElement("9019", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Attributecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9018", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Attribute_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C955")]
    public class C955
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("9021", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Attributetypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C786")]
    public class C786
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7512", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Structurecomponentidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C556")]
    public class C556
    {
        
        [Required]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(1)]
        public string Statusreasoncoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9012", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusreason_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C555")]
    public class C555
    {
        
        [Required]
        [DataElement("9011", typeof(EDIFACT_ID_9011))]
        [Pos(1)]
        public string Statuseventcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9010", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusevent_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C601")]
    public class C601
    {
        
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015))]
        [Pos(1)]
        public string Statustypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C782")]
    public class C782
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("1520", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Datasetidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C779")]
    public class C779
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("9428", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Arraystructureidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C785")]
    public class C785
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("6434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Statisticalconceptidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C780")]
    public class C780
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("1518", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Valuelistidentifier_01 { get; set; }
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C554")]
    public class C554
    {
        
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C528")]
    public class C528
    {
        
        [StringLength(1, 18)]
        [DataElement("7357", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Commodityrateidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C203")]
    public class C203
    {
        
        [Required]
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Ratetariffclass_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Supplementaryratetariffbasisidentification_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Supplementaryratetariffbasisidentification_08 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(9)]
        public string Codelistqualifier_09 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(10)]
        public string Codelistresponsibleagencycoded_10 { get; set; }
    }
    
    [Serializable()]
    [Composite("C200")]
    public class C200
    {
        
        [StringLength(1, 17)]
        [DataElement("8023", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freightandchargesidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 26)]
        [DataElement("8022", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freightandcharges_04 { get; set; }
        [DataElement("4237", typeof(EDIFACT_ID_4237))]
        [Pos(5)]
        public string Prepaidcollectindicatorcoded_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Itemnumber_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C331")]
    public class C331
    {
        
        [StringLength(1, 17)]
        [DataElement("4495", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Insurancecoveridentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Insurancecover_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Insurancecover_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C330")]
    public class C330
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Insurancecovertypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C049")]
    public class C049
    {
        
        [DataElement("5315", typeof(EDIFACT_ID_5315))]
        [Pos(1)]
        public string Remunerationtypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Remunerationtype_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Remunerationtype_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C508")]
    public class C508
    {
        
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Languagecoded_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3452", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Language_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C585")]
    public class C585
    {
        
        [StringLength(1, 3)]
        [DataElement("4037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Prioritycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Priority_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C950")]
    public class C950
    {
        
        [StringLength(1, 3)]
        [DataElement("9007", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Qualificationclassificationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Qualificationclassification_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Qualificationclassification_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C951")]
    public class C951
    {
        
        [StringLength(1, 3)]
        [DataElement("9009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Occupationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Occupation_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Occupation_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C948")]
    public class C948
    {
        
        [StringLength(1, 3)]
        [DataElement("9005", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Employmentcategorycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9004", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Employmentcategory_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C101")]
    public class C101
    {
        
        [StringLength(1, 3)]
        [DataElement("3483", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Religioncoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3482", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Religion_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C085")]
    public class C085
    {
        
        [DataElement("3479", typeof(EDIFACT_ID_3479))]
        [Pos(1)]
        public string Maritalstatuscoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3478", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Maritalstatus_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C042")]
    public class C042
    {
        
        [StringLength(1, 3)]
        [DataElement("3293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nationalitycoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3292", typeof(EDIFACT_A))]
        [Pos(4)]
        public string Nationality_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C819")]
    public class C819
    {
        
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentityidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentity_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C090")]
    public class C090
    {
        
        [Required]
        [DataElement("3477", typeof(EDIFACT_ID_3477))]
        [Pos(1)]
        public string Addressformatcoded_01 { get; set; }
        [Required]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Addresscomponent_02 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Addresscomponent_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Addresscomponent_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Addresscomponent_05 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Addresscomponent_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C817")]
    public class C817
    {
        
        [DataElement("3299", typeof(EDIFACT_ID_3299))]
        [Pos(1)]
        public string Addresspurposecoded_01 { get; set; }
        [DataElement("3131", typeof(EDIFACT_ID_3131))]
        [Pos(2)]
        public string Addresstypecoded_02 { get; set; }
        [DataElement("3475", typeof(EDIFACT_ID_3475))]
        [Pos(3)]
        public string Addressstatuscoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C816")]
    public class C816
    {
        
        [Required]
        [DataElement("3405", typeof(EDIFACT_ID_3405))]
        [Pos(1)]
        public string Namecomponentqualifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3398", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Namecomponent_02 { get; set; }
        [DataElement("3401", typeof(EDIFACT_ID_3401))]
        [Pos(3)]
        public string Namecomponentstatuscoded_03 { get; set; }
        [DataElement("3295", typeof(EDIFACT_ID_3295))]
        [Pos(4)]
        public string Namecomponentoriginalrepresentationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C818")]
    public class C818
    {
        
        [StringLength(1, 8)]
        [DataElement("3311", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Personinheritedcharacteristicidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3310", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Personinheritedcharacteristic_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C889")]
    public class C889
    {
        
        [StringLength(1, 3)]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C288")]
    public class C288
    {
        
        [StringLength(1, 3)]
        [DataElement("5389", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Productgroupcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Productgroup_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C515")]
    public class C515
    {
        
        [StringLength(1, 17)]
        [DataElement("4425", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Testreasonidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4424", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Testreason_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C244")]
    public class C244
    {
        
        [StringLength(1, 17)]
        [DataElement("4415", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Testmethodidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4416", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Testdescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C527")]
    public class C527
    {
        
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Measurementvalue_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(3)]
        public string Measurementdimensioncoded_03 { get; set; }
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(4)]
        public string Measurementsignificancecoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C512")]
    public class C512
    {
        
        [DataElement("6173", typeof(EDIFACT_ID_6173))]
        [Pos(1)]
        public string Sizequalifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("6174", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Size_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C526")]
    public class C526
    {
        
        [Required]
        [DataElement("6071", typeof(EDIFACT_ID_6071))]
        [Pos(1)]
        public string Frequencyqualifier_01 { get; set; }
        [StringLength(1, 9)]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Frequencyvalue_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C514")]
    public class C514
    {
        
        [DataElement("3237", typeof(EDIFACT_ID_3237))]
        [Pos(1)]
        public string Samplelocationcoded_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3236", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Samplelocation_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C333")]
    public class C333
    {
        
        [DataElement("4511", typeof(EDIFACT_ID_4511))]
        [Pos(1)]
        public string Requestedinformationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requestedinformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C564")]
    public class C564
    {
        
        [DataElement("7007", typeof(EDIFACT_ID_7007))]
        [Pos(1)]
        public string Physicalorlogicalstatecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C945")]
    public class C945
    {
        
        [Required]
        [DataElement("7455", typeof(EDIFACT_ID_7455))]
        [Pos(1)]
        public string Membershiplevelqualifier_01 { get; set; }
        [StringLength(1, 9)]
        [DataElement("7457", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Membershiplevelidentification_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7456", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Membershiplevel_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C944")]
    public class C944
    {
        
        [StringLength(1, 3)]
        [DataElement("7453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Membershipstatuscoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7452", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Membershipstatus_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C942")]
    public class C942
    {
        
        [Required]
        [DataElement("7451", typeof(EDIFACT_ID_7451))]
        [Pos(1)]
        public string Membershipcategoryidentification_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7450", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Membershipcategory_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C815")]
    public class C815
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("4039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Additionalsafetyinformationcoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4038", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Additionalsafetyinformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C814")]
    public class C814
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("4046", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Safetysection_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4044", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Safetysectionname_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C332")]
    public class C332
    {
        
        [Required]
        [StringLength(1, 17)]
        [DataElement("3496", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Saleschannelidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C953")]
    public class C953
    {
        
        [Required]
        [DataElement("5049", typeof(EDIFACT_ID_5049))]
        [Pos(1)]
        public string Contributiontypecoded_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5048", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Contributiontype_04 { get; set; }
    }
}
