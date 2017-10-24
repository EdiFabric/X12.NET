namespace EdiFabric.Rules.EDIFACT_D96A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectqualifier_01 { get; set; }
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Textfunctioncoded_02 { get; set; }
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class RFF
    {
        
        [Required]
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ERC")]
    public class ERC
    {
        
        [Required]
        [Pos(1)]
        public C901 APPLICATIONERRORDETAIL_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("COM")]
    public class COM
    {
        
        [Required]
        [Pos(1)]
        public C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTA")]
    public class CTA
    {
        
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncoded_01 { get; set; }
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NAD")]
    public class NAD
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }
        [Pos(5)]
        public C059 STREET_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Countrysubentityidentification_07 { get; set; }
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postcodeidentification_08 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Countrycoded_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Required]
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CNT")]
    public class CNT
    {
        
        [Required]
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("BGM")]
    public class BGM
    {
        
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Documentmessagenumber_02 { get; set; }
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncoded_03 { get; set; }
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("AUT")]
    public class AUT
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("9280", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Validationresult_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9282", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Validationkeyidentification_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("FII")]
    public class FII
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        [Pos(2)]
        public C078 ACCOUNTIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("DOC")]
    public class DOC
    {
        
        [Required]
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationchannelidentifiercoded_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofcopiesofdocumentrequired_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Numberoforiginalsofdocumentrequired_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class MOA
    {
        
        [Required]
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIS")]
    public class GIS
    {
        
        [Required]
        [Pos(1)]
        public C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("SEQ")]
    public class SEQ
    {
        
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(1)]
        public string Statusindicatorcoded_01 { get; set; }
        [Pos(2)]
        public C286 SEQUENCEINFORMATION_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("LIN")]
    public class LIN
    {
        
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Lineitemnumber_01 { get; set; }
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationcoded_02 { get; set; }
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationcoded_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("BUS")]
    public class BUS
    {
        
        [Pos(1)]
        public C521 BUSINESSFUNCTION_01 { get; set; }
        [DataElement("3279", typeof(EDIFACT_ID_3279))]
        [Pos(2)]
        public string Geographicenvironmentcoded_02 { get; set; }
        [DataElement("4487", typeof(EDIFACT_ID_4487))]
        [Pos(3)]
        public string Typeoffinancialtransactioncoded_03 { get; set; }
        [Pos(4)]
        public C551 BANKOPERATION_04 { get; set; }
        [DataElement("4463", typeof(EDIFACT_ID_4463))]
        [Pos(5)]
        public string Intracompanypaymentcoded_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class PCD
    {
        
        [Required]
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUX")]
    public class CUX
    {
        
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rateofexchange_03 { get; set; }
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Currencymarketexchangecoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("DGS")]
    public class DGS
    {
        
        [DataElement("8273", typeof(EDIFACT_ID_8273))]
        [Pos(1)]
        public string Dangerousgoodsregulationscoded_01 { get; set; }
        [Pos(2)]
        public C205 HAZARDCODE_02 { get; set; }
        [Pos(3)]
        public C234 UNDGINFORMATION_03 { get; set; }
        [Pos(4)]
        public C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(5)]
        public string Packinggroupcoded_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string EMSnumber_06 { get; set; }
        [StringLength(1, 4)]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string MFAG_07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Tremcardnumber_08 { get; set; }
        [Pos(9)]
        public C235 HAZARDIDENTIFICATION_09 { get; set; }
        [Pos(10)]
        public C236 DANGEROUSGOODSLABEL_10 { get; set; }
        [StringLength(1, 3)]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string Packinginstructioncoded_11 { get; set; }
        [DataElement("8325", typeof(EDIFACT_ID_8325))]
        [Pos(12)]
        public string Categoryofmeansoftransportcoded_12 { get; set; }
        [StringLength(1, 3)]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string Permissionfortransportcoded_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("EQA")]
    public class EQA
    {
        
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmentqualifier_01 { get; set; }
        [Pos(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("EQD")]
    public class EQD
    {
        
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmentqualifier_01 { get; set; }
        [Pos(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercoded_04 { get; set; }
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscoded_05 { get; set; }
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(6)]
        public string Fullemptyindicatorcoded_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class LOC
    {
        
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Placelocationqualifier_01 { get; set; }
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcoded_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("RNG")]
    public class RNG
    {
        
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string Rangetypequalifier_01 { get; set; }
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("TMP")]
    public class TMP
    {
        
        [Required]
        [DataElement("6245", typeof(EDIFACT_ID_6245))]
        [Pos(1)]
        public string Temperaturequalifier_01 { get; set; }
        [Pos(2)]
        public C239 TEMPERATURESETTING_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DIM")]
    public class DIM
    {
        
        [Required]
        [DataElement("6145", typeof(EDIFACT_ID_6145))]
        [Pos(1)]
        public string Dimensionqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C211 DIMENSIONS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA")]
    public class MEA
    {
        
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementapplicationqualifier_01 { get; set; }
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("GDS")]
    public class GDS
    {
        
        [Pos(1)]
        public C703 NATUREOFCARGO_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("GID")]
    public class GID
    {
        
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        [Pos(2)]
        public C213 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        [Pos(3)]
        public C213 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        [Pos(4)]
        public C213 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("TDT")]
    public class TDT
    {
        
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagequalifier_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Conveyancereferencenumber_02 { get; set; }
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectioncoded_06 { get; set; }
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportownershipcoded_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("EQN")]
    public class EQN
    {
        
        [Required]
        [Pos(1)]
        public C523 NUMBEROFUNITDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRI")]
    public class PRI
    {
        
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublinepricechangecoded_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class QTY
    {
        
        [Required]
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIR")]
    public class GIR
    {
        
        [Required]
        [DataElement("7297", typeof(EDIFACT_ID_7297))]
        [Pos(1)]
        public string Setidentificationqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [Pos(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }
        [Pos(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }
        [Pos(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }
        [Pos(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("RCS")]
    public class RCS
    {
        
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorsubjectidentificationqualifier_01 { get; set; }
        [Pos(2)]
        public C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNS")]
    public class UNS
    {
        
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("COD")]
    public class COD
    {
        
        [Pos(1)]
        public C823 TYPEOFUNITCOMPONENT_01 { get; set; }
        [Pos(2)]
        public C824 COMPONENTMATERIAL_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DAM")]
    public class DAM
    {
        
        [Required]
        [DataElement("7493", typeof(EDIFACT_ID_7493))]
        [Pos(1)]
        public string Damagedetailsqualifier_01 { get; set; }
        [Pos(2)]
        public C821 TYPEOFDAMAGE_02 { get; set; }
        [Pos(3)]
        public C822 DAMAGEAREA_03 { get; set; }
        [Pos(4)]
        public C825 DAMAGESEVERITY_04 { get; set; }
        [Pos(5)]
        public C826 ACTION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("PIA")]
    public class PIA
    {
        
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidfunctionqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("SEL")]
    public class SEL
    {
        
        [Required]
        [StringLength(1, 10)]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sealnumber_01 { get; set; }
        [Pos(2)]
        public C215 SEALISSUER_02 { get; set; }
        [DataElement("4517", typeof(EDIFACT_ID_4517))]
        [Pos(3)]
        public string Sealconditioncoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("TMD")]
    public class TMD
    {
        
        [Pos(1)]
        public C219 MOVEMENTTYPE_01 { get; set; }
        [StringLength(1, 26)]
        [DataElement("8332", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Equipmentplan_02 { get; set; }
        [DataElement("8341", typeof(EDIFACT_ID_8341))]
        [Pos(3)]
        public string Haulagearrangementscoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("SGP")]
    public class SGP
    {
        
        [Required]
        [Pos(1)]
        public C237 EQUIPMENTIDENTIFICATION_01 { get; set; }
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofpackages_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("HAN")]
    public class HAN
    {
        
        [Pos(1)]
        public C524 HANDLINGINSTRUCTIONS_01 { get; set; }
        [Pos(2)]
        public C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("GOR")]
    public class GOR
    {
        
        [DataElement("8323", typeof(EDIFACT_ID_8323))]
        [Pos(1)]
        public string Transportmovementcoded_01 { get; set; }
        [Pos(2)]
        public C232 GOVERNMENTACTION_02 { get; set; }
        [Pos(3)]
        public C232 GOVERNMENTACTION_03 { get; set; }
        [Pos(4)]
        public C232 GOVERNMENTACTION_04 { get; set; }
        [Pos(5)]
        public C232 GOVERNMENTACTION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("AJT")]
    public class AJT
    {
        
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465))]
        [Pos(1)]
        public string Adjustmentreasoncoded_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DLI")]
    public class DLI
    {
        
        [Required]
        [DataElement("1073", typeof(EDIFACT_ID_1073))]
        [Pos(1)]
        public string Documentlineindicatorcoded_01 { get; set; }
        [Required]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("INP")]
    public class INP
    {
        
        [Pos(1)]
        public C849 PARTIESTOINSTRUCTION_01 { get; set; }
        [Pos(2)]
        public C522 INSTRUCTION_02 { get; set; }
        [Pos(3)]
        public C850 STATUSOFINSTRUCTION_03 { get; set; }
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TAX
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutytaxfeefunctionqualifier_01 { get; set; }
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeeassessmentbasis_04 { get; set; }
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutytaxfeecategorycoded_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentificationnumber_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ARD")]
    public class ARD
    {
        
        [Pos(1)]
        public C549 MONETARYFUNCTION_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("APR")]
    public class APR
    {
        
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Classoftradecoded_01 { get; set; }
        [Pos(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAT")]
    public class PAT
    {
        
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypequalifier_01 { get; set; }
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAI")]
    public class PAI
    {
        
        [Required]
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("BII")]
    public class BII
    {
        
        [Required]
        [DataElement("7429", typeof(EDIFACT_ID_7429))]
        [Pos(1)]
        public string Indexingstructurequalifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C045 BILLLEVELIDENTIFICATION_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Itemnumber_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("IND")]
    public class IND
    {
        
        [Pos(1)]
        public C545 INDEXIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C546 INDEXVALUE_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("IMD")]
    public class IMD
    {
        
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public string Itemcharacteristiccoded_02 { get; set; }
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("AGR")]
    public class AGR
    {
        
        [Pos(1)]
        public C543 AGREEMENTTYPEIDENTIFICATION_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("9419", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Servicelayercoded_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("CED")]
    public class CED
    {
        
        [Required]
        [DataElement("1501", typeof(EDIFACT_ID_1501))]
        [Pos(1)]
        public string Computerenvironmentdetailsqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C079 COMPUTERENVIRONMENTIDENTIFICATION_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("EFI")]
    public class EFI
    {
        
        [Required]
        [Pos(1)]
        public C077 FILEIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C099 FILEDETAILS_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Sequencenumber_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALC")]
    public class ALC
    {
        
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargequalifier_01 { get; set; }
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementcoded_03 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequenceindicatorcoded_04 { get; set; }
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("RTE")]
    public class RTE
    {
        
        [Required]
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class ALI
    {
        
        [StringLength(1, 3)]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countryoforigincoded_01 { get; set; }
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Typeofdutyregimecoded_02 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditionscoded_03 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditionscoded_04 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditionscoded_05 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditionscoded_06 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditionscoded_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("TSR")]
    public class TSR
    {
        
        [Pos(1)]
        public C536 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        [Pos(2)]
        public C233 SERVICE_02 { get; set; }
        [Pos(3)]
        public C537 TRANSPORTPRIORITY_03 { get; set; }
        [Pos(4)]
        public C703 NATUREOFCARGO_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCI")]
    public class PCI
    {
        
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscoded_01 { get; set; }
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerpackagestatuscoded_03 { get; set; }
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CNI")]
    public class CNI
    {
        
        [StringLength(1, 4)]
        [DataElement("1490", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Consolidationitemnumber_01 { get; set; }
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        [StringLength(1, 4)]
        [DataElement("1312", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Consignmentloadsequencenumber_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("FCA")]
    public class FCA
    {
        
        [Required]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(1)]
        public string Settlementcoded_01 { get; set; }
        [Pos(2)]
        public C878 CHARGEALLOWANCEACCOUNT_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRC")]
    public class PRC
    {
        
        [Required]
        [Pos(1)]
        public C242 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CST")]
    public class CST
    {
        
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        [Pos(2)]
        public C246 CUSTOMSIDENTITYCODES_02 { get; set; }
        [Pos(3)]
        public C246 CUSTOMSIDENTITYCODES_03 { get; set; }
        [Pos(4)]
        public C246 CUSTOMSIDENTITYCODES_04 { get; set; }
        [Pos(5)]
        public C246 CUSTOMSIDENTITYCODES_05 { get; set; }
        [Pos(6)]
        public C246 CUSTOMSIDENTITYCODES_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAC")]
    public class PAC
    {
        
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("CPI")]
    public class CPI
    {
        
        [Pos(1)]
        public C229 CHARGECATEGORY_01 { get; set; }
        [Pos(2)]
        public C231 METHODOFPAYMENT_02 { get; set; }
        [DataElement("4237", typeof(EDIFACT_ID_4237))]
        [Pos(3)]
        public string Prepaidcollectindicatorcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("QVR")]
    public class QVR
    {
        
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancycoded_02 { get; set; }
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("TOD")]
    public class TOD
    {
        
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Termsofdeliveryortransportfunctioncoded_01 { get; set; }
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargesmethodofpaymentcoded_02 { get; set; }
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIN")]
    public class GIN
    {
        
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Identitynumberqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DMS")]
    public class DMS
    {
        
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(2)]
        public string Documentmessagenamecoded_02 { get; set; }
        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Totalnumberofitems_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("TPL")]
    public class TPL
    {
        
        [Required]
        [Pos(1)]
        public C222 TRANSPORTIDENTIFICATION_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ERP")]
    public class ERP
    {
        
        [Required]
        [Pos(1)]
        public C701 ERRORPOINTDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("SCC")]
    public class SCC
    {
        
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017))]
        [Pos(1)]
        public string Deliveryplanstatusindicatorcoded_01 { get; set; }
        [DataElement("4493", typeof(EDIFACT_ID_4493))]
        [Pos(2)]
        public string Deliveryrequirementscoded_02 { get; set; }
        [Pos(3)]
        public C329 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DLM")]
    public class DLM
    {
        
        [DataElement("4455", typeof(EDIFACT_ID_4455))]
        [Pos(1)]
        public string Backordercoded_01 { get; set; }
        [Pos(2)]
        public C522 INSTRUCTION_02 { get; set; }
        [Pos(3)]
        public C214 SPECIALSERVICESIDENTIFICATION_03 { get; set; }
        [DataElement("4457", typeof(EDIFACT_ID_4457))]
        [Pos(4)]
        public string Productservicesubstitutioncoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CPS")]
    public class CPS
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        [StringLength(1, 12)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Hierarchicalparentid_02 { get; set; }
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(3)]
        public string Packaginglevelcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CDV")]
    public class CDV
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("9426", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Codevalue_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("9434", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Codename_02 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CDS")]
    public class CDS
    {
        
        [Required]
        [Pos(1)]
        public C702 CODESETIDENTIFICATION_01 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("ELM")]
    public class ELM
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Simpledataelementtag_01 { get; set; }
        [DataElement("9153", typeof(EDIFACT_ID_9153))]
        [Pos(2)]
        public string Simpledataelementcharacterrepresentationcoded_02 { get; set; }
        [DataElement("9155", typeof(EDIFACT_ID_9155))]
        [Pos(3)]
        public string Simpledataelementlengthtypecoded_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("9156", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Simpledataelementmaximumlength_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("9158", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Simpledataelementminimumlength_05 { get; set; }
        [DataElement("9161", typeof(EDIFACT_ID_9161))]
        [Pos(6)]
        public string Codesetindicatorcoded_06 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(7)]
        public string Classdesignatorcoded_07 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(8)]
        public string Maintenanceoperationcoded_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("ELU")]
    public class ELU
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("9162", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dataelementtag_01 { get; set; }
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Sequencenumber_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CMP")]
    public class CMP
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("9146", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Compositedataelementtag_01 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("SEG")]
    public class SEG
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Segmenttag_01 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("GRU")]
    public class GRU
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("9164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Groupidentification_01 { get; set; }
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Maximumnumberofoccurrences_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Sequencenumber_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("SGU")]
    public class SGU
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Segmenttag_01 { get; set; }
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Maximumnumberofoccurrences_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("7168", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Levelnumber_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Sequencenumber_05 { get; set; }
        [DataElement("1049", typeof(EDIFACT_ID_1049))]
        [Pos(6)]
        public string Messagesectioncoded_06 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(7)]
        public string Maintenanceoperationcoded_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("MSG")]
    public class MSG
    {
        
        [Required]
        [Pos(1)]
        public C709 MESSAGEIDENTIFIER_01 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DII")]
    public class DII
    {
        
        [Required]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Version_01 { get; set; }
        [Required]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Release_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("9148", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Directorystatus_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Controlagency_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(6)]
        public string Maintenanceoperationcoded_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("FNT")]
    public class FNT
    {
        
        [Required]
        [Pos(1)]
        public C784 FOOTNOTEIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("IDE")]
    public class IDE
    {
        
        [Required]
        [DataElement("7495", typeof(EDIFACT_ID_7495))]
        [Pos(1)]
        public string Identificationqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [Pos(3)]
        public C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string Statuscoded_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        [Pos(6)]
        public C778 POSITIONIDENTIFICATION_06 { get; set; }
        [Pos(7)]
        public C240 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ARR")]
    public class ARR
    {
        
        [Pos(1)]
        public C778 POSITIONIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C770 ARRAYCELLDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("REL")]
    public class REL
    {
        
        [Required]
        [DataElement("9141", typeof(EDIFACT_ID_9141))]
        [Pos(1)]
        public string Relationshipqualifier_01 { get; set; }
        [Pos(2)]
        public C941 RELATIONSHIP_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("FNS")]
    public class FNS
    {
        
        [Required]
        [Pos(1)]
        public C783 FOOTNOTESETIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("ATT")]
    public class ATT
    {
        
        [Required]
        [DataElement("9017", typeof(EDIFACT_ID_9017))]
        [Pos(1)]
        public string Attributefunctionqualifier_01 { get; set; }
        [Pos(2)]
        public C955 ATTRIBUTETYPE_02 { get; set; }
        [Pos(3)]
        public C956 ATTRIBUTEDETAILS_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("SCD")]
    public class SCD
    {
        
        [Required]
        [DataElement("7497", typeof(EDIFACT_ID_7497))]
        [Pos(1)]
        public string Componentfunctionqualifier_01 { get; set; }
        [Pos(2)]
        public C786 STRUCTURECOMPONENTIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string Statuscoded_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        [Pos(6)]
        public C778 POSITIONIDENTIFICATION_06 { get; set; }
        [Pos(7)]
        public C240 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("STS")]
    public class STS
    {
        
        [Pos(1)]
        public C601 STATUSTYPE_01 { get; set; }
        [Pos(2)]
        public C555 STATUSEVENT_02 { get; set; }
        [Pos(3)]
        public C556 STATUSREASON_03 { get; set; }
        [Pos(4)]
        public C556 STATUSREASON_04 { get; set; }
        [Pos(5)]
        public C556 STATUSREASON_05 { get; set; }
        [Pos(6)]
        public C556 STATUSREASON_06 { get; set; }
        [Pos(7)]
        public C556 STATUSREASON_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("DSI")]
    public class DSI
    {
        
        [Required]
        [Pos(1)]
        public C782 DATASETIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [Pos(4)]
        public C286 SEQUENCEINFORMATION_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionnumber_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("ASI")]
    public class ASI
    {
        
        [Required]
        [Pos(1)]
        public C779 ARRAYSTRUCTUREIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("STC")]
    public class STC
    {
        
        [Required]
        [Pos(1)]
        public C785 STATISTICALCONCEPTIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("VLI")]
    public class VLI
    {
        
        [Required]
        [Pos(1)]
        public C780 VALUELISTIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1514", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Valuelistname_04 { get; set; }
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(5)]
        public string Classdesignatorcoded_05 { get; set; }
        [DataElement("1505", typeof(EDIFACT_ID_1505))]
        [Pos(6)]
        public string Valuelisttypecoded_06 { get; set; }
        [Pos(7)]
        public C240 PRODUCTCHARACTERISTIC_07 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(8)]
        public string Maintenanceoperationcoded_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("TCC")]
    public class TCC
    {
        
        [Pos(1)]
        public C200 CHARGE_01 { get; set; }
        [Pos(2)]
        public C203 RATETARIFFCLASS_02 { get; set; }
        [Pos(3)]
        public C528 COMMODITYRATEDETAIL_03 { get; set; }
        [Pos(4)]
        public C554 RATETARIFFCLASSDETAIL_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("ICD")]
    public class ICD
    {
        
        [Required]
        [Pos(1)]
        public C330 INSURANCECOVERTYPE_01 { get; set; }
        [Required]
        [Pos(2)]
        public C331 INSURANCECOVERDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("INV")]
    public class INV
    {
        
        [DataElement("4501", typeof(EDIFACT_ID_4501))]
        [Pos(1)]
        public string Inventorymovementdirectioncoded_01 { get; set; }
        [DataElement("7491", typeof(EDIFACT_ID_7491))]
        [Pos(2)]
        public string Typeofinventoryaffectedcoded_02 { get; set; }
        [DataElement("4499", typeof(EDIFACT_ID_4499))]
        [Pos(3)]
        public string Reasonforinventorymovementcoded_03 { get; set; }
        [DataElement("4503", typeof(EDIFACT_ID_4503))]
        [Pos(4)]
        public string Inventorybalancemethodcoded_04 { get; set; }
        [Pos(5)]
        public C522 INSTRUCTION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("SAL")]
    public class SAL
    {
        
        [Pos(1)]
        public C049 REMUNERATIONTYPEIDENTIFICATION_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LAN")]
    public class LAN
    {
        
        [Required]
        [DataElement("3455", typeof(EDIFACT_ID_3455))]
        [Pos(1)]
        public string Languagequalifier_01 { get; set; }
        [Pos(2)]
        public C508 LANGUAGEDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PTY")]
    public class PTY
    {
        
        [Required]
        [DataElement("4035", typeof(EDIFACT_ID_4035))]
        [Pos(1)]
        public string Priorityqualifier_01 { get; set; }
        [Pos(2)]
        public C585 PRIORITYDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("EMP")]
    public class EMP
    {
        
        [Required]
        [DataElement("9003", typeof(EDIFACT_ID_9003))]
        [Pos(1)]
        public string Employmentqualifier_01 { get; set; }
        [Pos(2)]
        public C948 EMPLOYMENTCATEGORY_02 { get; set; }
        [Pos(3)]
        public C951 OCCUPATION_03 { get; set; }
        [Pos(4)]
        public C950 QUALIFICATIONCLASSIFICATION_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3494", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Jobtitle_05 { get; set; }
        [DataElement("9035", typeof(EDIFACT_ID_9035))]
        [Pos(6)]
        public string Qualificationareacoded_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PDI")]
    public class PDI
    {
        
        [StringLength(1, 3)]
        [DataElement("3499", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sexcoded_01 { get; set; }
        [Pos(2)]
        public C085 MARITALSTATUSDETAILS_02 { get; set; }
        [Pos(3)]
        public C101 RELIGIONDETAILS_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("NAT")]
    public class NAT
    {
        
        [Required]
        [DataElement("3493", typeof(EDIFACT_ID_3493))]
        [Pos(1)]
        public string Nationalityqualifier_01 { get; set; }
        [Pos(2)]
        public C042 NATIONALITYDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("ADR")]
    public class ADR
    {
        
        [Pos(1)]
        public C817 ADDRESSUSAGE_01 { get; set; }
        [Pos(2)]
        public C090 ADDRESSDETAILS_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Cityname_03 { get; set; }
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Postcodeidentification_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Countrycoded_05 { get; set; }
        [Pos(6)]
        public C819 COUNTRYSUBENTITYDETAILS_06 { get; set; }
        [Pos(7)]
        public C517 LOCATIONIDENTIFICATION_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("PNA")]
    public class PNA
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [Pos(3)]
        public C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        [DataElement("3403", typeof(EDIFACT_ID_3403))]
        [Pos(4)]
        public string Nametypecoded_04 { get; set; }
        [DataElement("3397", typeof(EDIFACT_ID_3397))]
        [Pos(5)]
        public string Namestatuscoded_05 { get; set; }
        [Pos(6)]
        public C816 NAMECOMPONENTDETAILS_06 { get; set; }
        [Pos(7)]
        public C816 NAMECOMPONENTDETAILS_07 { get; set; }
        [Pos(8)]
        public C816 NAMECOMPONENTDETAILS_08 { get; set; }
        [Pos(9)]
        public C816 NAMECOMPONENTDETAILS_09 { get; set; }
        [Pos(10)]
        public C816 NAMECOMPONENTDETAILS_10 { get; set; }
    }
    
    [Serializable()]
    [Segment("IHC")]
    public class IHC
    {
        
        [Required]
        [DataElement("3289", typeof(EDIFACT_ID_3289))]
        [Pos(1)]
        public string Personcharacteristicqualifier_01 { get; set; }
        [Pos(2)]
        public C818 PERSONINHERITEDCHARACTERISTICDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("STG")]
    public class STG
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("9421", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Stagesqualifier_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("6426", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofstages_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("6428", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Actualstagecount_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAV")]
    public class CAV
    {
        
        [Required]
        [Pos(1)]
        public C889 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CCI")]
    public class CCI
    {
        
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string Propertyclasscoded_01 { get; set; }
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        [Pos(3)]
        public C240 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PGI")]
    public class PGI
    {
        
        [Required]
        [DataElement("5379", typeof(EDIFACT_ID_5379))]
        [Pos(1)]
        public string Productgrouptypecoded_01 { get; set; }
        [Pos(2)]
        public C288 PRODUCTGROUP_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("TEM")]
    public class TEM
    {
        
        [Pos(1)]
        public C244 TESTMETHOD_01 { get; set; }
        [DataElement("4419", typeof(EDIFACT_ID_4419))]
        [Pos(2)]
        public string Testrouteofadministeringcoded_02 { get; set; }
        [DataElement("3077", typeof(EDIFACT_ID_3077))]
        [Pos(3)]
        public string Testmediacoded_03 { get; set; }
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(4)]
        public string Measurementapplicationqualifier_04 { get; set; }
        [StringLength(1, 30)]
        [DataElement("7188", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Testrevisionnumber_05 { get; set; }
        [Pos(6)]
        public C515 TESTREASON_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("STA")]
    public class STA
    {
        
        [Required]
        [DataElement("6331", typeof(EDIFACT_ID_6331))]
        [Pos(1)]
        public string Statistictypecoded_01 { get; set; }
        [Pos(2)]
        public C527 STATISTICALDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("SPS")]
    public class SPS
    {
        
        [Pos(1)]
        public C526 FREQUENCYDETAILS_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("6074", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Confidencelimit_02 { get; set; }
        [Pos(3)]
        public C512 SIZEDETAILS_03 { get; set; }
        [Pos(4)]
        public C512 SIZEDETAILS_04 { get; set; }
        [Pos(5)]
        public C512 SIZEDETAILS_05 { get; set; }
        [Pos(6)]
        public C512 SIZEDETAILS_06 { get; set; }
        [Pos(7)]
        public C512 SIZEDETAILS_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("PSD")]
    public class PSD
    {
        
        [DataElement("4407", typeof(EDIFACT_ID_4407))]
        [Pos(1)]
        public string Sampleprocessstatuscoded_01 { get; set; }
        [DataElement("7039", typeof(EDIFACT_ID_7039))]
        [Pos(2)]
        public string Sampleselectionmethodcoded_02 { get; set; }
        [Pos(3)]
        public C526 FREQUENCYDETAILS_03 { get; set; }
        [DataElement("7045", typeof(EDIFACT_ID_7045))]
        [Pos(4)]
        public string Sampledescriptioncoded_04 { get; set; }
        [DataElement("7047", typeof(EDIFACT_ID_7047))]
        [Pos(5)]
        public string Sampledirectioncoded_05 { get; set; }
        [Pos(6)]
        public C514 SAMPLELOCATIONDETAILS_06 { get; set; }
        [Pos(7)]
        public C514 SAMPLELOCATIONDETAILS_07 { get; set; }
        [Pos(8)]
        public C514 SAMPLELOCATIONDETAILS_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("IRQ")]
    public class IRQ
    {
        
        [Required]
        [Pos(1)]
        public C333 INFORMATIONREQUEST_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CDI")]
    public class CDI
    {
        
        [Required]
        [DataElement("7001", typeof(EDIFACT_ID_7001))]
        [Pos(1)]
        public string Physicalorlogicalstatequalifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C564 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("CCD")]
    public class CCD
    {
        
        [DataElement("4505", typeof(EDIFACT_ID_4505))]
        [Pos(1)]
        public string Creditcoverrequestcoded_01 { get; set; }
        [DataElement("4507", typeof(EDIFACT_ID_4507))]
        [Pos(2)]
        public string Creditcoverresponsecoded_02 { get; set; }
        [DataElement("4509", typeof(EDIFACT_ID_4509))]
        [Pos(3)]
        public string Creditcoverreasoncoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEM")]
    public class MEM
    {
        
        [Required]
        [DataElement("7449", typeof(EDIFACT_ID_7449))]
        [Pos(1)]
        public string Membershipqualifier_01 { get; set; }
        [Pos(2)]
        public C942 MEMBERSHIPCATEGORY_02 { get; set; }
        [Pos(3)]
        public C944 MEMBERSHIPSTATUS_03 { get; set; }
        [Pos(4)]
        public C945 MEMBERSHIPLEVEL_04 { get; set; }
        [Pos(5)]
        public C203 RATETARIFFCLASS_05 { get; set; }
        [Pos(6)]
        public C960 REASONFORCHANGE_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("SFI")]
    public class SFI
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        [Pos(2)]
        public C814 SAFETYSECTION_02 { get; set; }
        [Pos(3)]
        public C815 ADDITIONALSAFETYINFORMATION_03 { get; set; }
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("MKS")]
    public class MKS
    {
        
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorsubjectidentificationqualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public C332 SALESCHANNELIDENTIFICATION_02 { get; set; }
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("COT")]
    public class COT
    {
        
        [Required]
        [DataElement("5047", typeof(EDIFACT_ID_5047))]
        [Pos(1)]
        public string Contributionqualifier_01 { get; set; }
        [Pos(2)]
        public C953 CONTRIBUTIONTYPE_02 { get; set; }
        [Pos(3)]
        public C522 INSTRUCTION_03 { get; set; }
        [Pos(4)]
        public C203 RATETARIFFCLASS_04 { get; set; }
        [Pos(5)]
        public C960 REASONFORCHANGE_05 { get; set; }
    }
}
