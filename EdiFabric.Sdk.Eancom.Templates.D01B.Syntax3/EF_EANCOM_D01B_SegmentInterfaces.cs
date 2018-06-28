namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    public interface IALC<T1, T2>
        where T1 : IC552
        where T2 : IC214
    {
        
        string Allowanceorchargecodequalifier_01 { get; set; }
        T1 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        string Settlementmeanscode_03 { get; set; }
        string Calculationsequencecode_04 { get; set; }
        T2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    public interface IALI
    {
        
        string Countryoforiginnamecode_01 { get; set; }
        string Dutyregimetypecode_02 { get; set; }
        string Specialconditioncode_03 { get; set; }
        string Specialconditioncode_04 { get; set; }
        string Specialconditioncode_05 { get; set; }
        string Specialconditioncode_06 { get; set; }
        string Specialconditioncode_07 { get; set; }
    }
    
    public interface IAPR<T1, T2>
        where T1 : IC138
        where T2 : IC960
    {
        
        string Tradeclasscode_01 { get; set; }
        T1 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface IBGM<T1, T2>
        where T1 : IC002
        where T2 : IC106
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        T2 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        string Messagefunctioncode_03 { get; set; }
        string Responsetypecode_04 { get; set; }
    }
    
    public interface ICNT<T1>
        where T1 : IC270
    {
        
        T1 CONTROL_01 { get; set; }
    }
    
    public interface ICOM<T1>
        where T1 : IC076
    {
        
        T1 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    public interface ICTA<T1>
        where T1 : IC056
    {
        
        string Contactfunctioncode_01 { get; set; }
        T1 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    public interface ICUX<T1, T2>
        where T1 : IC504
        where T2 : IC504
    {
        
        T1 CURRENCYDETAILS_01 { get; set; }
        T2 CURRENCYDETAILS_02 { get; set; }
        string Currencyexchangerate_03 { get; set; }
        string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    public interface IDTM<T1>
        where T1 : IC507
    {
        
        T1 DATETIMEPERIOD_01 { get; set; }
    }
    
    public interface IFII<T1, T2>
        where T1 : IC078
        where T2 : IC088
    {
        
        string Partyfunctioncodequalifier_01 { get; set; }
        T1 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        T2 INSTITUTIONIDENTIFICATION_03 { get; set; }
        string Countrynamecode_04 { get; set; }
    }
    
    public interface IFTX<T1, T2>
        where T1 : IC107
        where T2 : IC108
    {
        
        string Textsubjectcodequalifier_01 { get; set; }
        string Freetextfunctioncode_02 { get; set; }
        T1 TEXTREFERENCE_03 { get; set; }
        T2 TEXTLITERAL_04 { get; set; }
        string Languagenamecode_05 { get; set; }
        string Freetextformatcode_06 { get; set; }
    }
    
    public interface IGIN<T1, T2, T3, T4, T5>
        where T1 : IC208
        where T2 : IC208
        where T3 : IC208
        where T4 : IC208
        where T5 : IC208
    {
        
        string Objectidentificationcodequalifier_01 { get; set; }
        T1 IDENTITYNUMBERRANGE_02 { get; set; }
        T2 IDENTITYNUMBERRANGE_03 { get; set; }
        T3 IDENTITYNUMBERRANGE_04 { get; set; }
        T4 IDENTITYNUMBERRANGE_05 { get; set; }
        T5 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    public interface IIMD<T1, T2>
        where T1 : IC272
        where T2 : IC273
    {
        
        string Descriptionformatcode_01 { get; set; }
        T1 ITEMCHARACTERISTIC_02 { get; set; }
        T2 ITEMDESCRIPTION_03 { get; set; }
        string Surfaceorlayercode_04 { get; set; }
    }
    
    public interface ILIN<T1, T2>
        where T1 : IC212
        where T2 : IC829
    {
        
        string Lineitemidentifier_01 { get; set; }
        string Actionrequestnotificationdescriptioncode_02 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        T2 SUBLINEINFORMATION_04 { get; set; }
        string Configurationlevelnumber_05 { get; set; }
        string Configurationoperationcode_06 { get; set; }
    }
    
    public interface ILOC<T1, T2, T3>
        where T1 : IC517
        where T2 : IC519
        where T3 : IC553
    {
        
        string Locationfunctioncodequalifier_01 { get; set; }
        T1 LOCATIONIDENTIFICATION_02 { get; set; }
        T2 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        T3 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        string Relationcode_05 { get; set; }
    }
    
    public interface IMEA<T1, T2>
        where T1 : IC502
        where T2 : IC174
    {
        
        string Measurementpurposecodequalifier_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 VALUERANGE_03 { get; set; }
        string Surfaceorlayercode_04 { get; set; }
    }
    
    public interface IMOA<T1>
        where T1 : IC516
    {
        
        T1 MONETARYAMOUNT_01 { get; set; }
    }
    
    public interface INAD<T1, T2, T3, T4, T5>
        where T1 : IC082
        where T2 : IC058
        where T3 : IC080
        where T4 : IC059
        where T5 : IC819
    {
        
        string Partyfunctioncodequalifier_01 { get; set; }
        T1 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        T2 NAMEANDADDRESS_03 { get; set; }
        T3 PARTYNAME_04 { get; set; }
        T4 STREET_05 { get; set; }
        string Cityname_06 { get; set; }
        T5 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        string Postalidentificationcode_08 { get; set; }
        string Countrynamecode_09 { get; set; }
    }
    
    public interface IPAC<T1, T2, T3, T4>
        where T1 : IC531
        where T2 : IC202
        where T3 : IC402
        where T4 : IC532
    {
        
        string Packagequantity_01 { get; set; }
        T1 PACKAGINGDETAILS_02 { get; set; }
        T2 PACKAGETYPE_03 { get; set; }
        T3 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        T4 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    public interface IPAI<T1>
        where T1 : IC534
    {
        
        T1 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    public interface IPAT<T1, T2>
        where T1 : IC110
        where T2 : IC112
    {
        
        string Paymenttermstypecodequalifier_01 { get; set; }
        T1 PAYMENTTERMS_02 { get; set; }
        T2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    public interface IPCD<T1>
        where T1 : IC501
    {
        
        T1 PERCENTAGEDETAILS_01 { get; set; }
        string Statusdescriptioncode_02 { get; set; }
    }
    
    public interface IPCI<T1, T2>
        where T1 : IC210
        where T2 : IC827
    {
        
        string Markinginstructionscode_01 { get; set; }
        T1 MARKSLABELS_02 { get; set; }
        string Containerorpackagecontentsindicatorcode_03 { get; set; }
        T2 TYPEOFMARKING_04 { get; set; }
    }
    
    public interface IPIA<T1, T2, T3, T4, T5>
        where T1 : IC212
        where T2 : IC212
        where T3 : IC212
        where T4 : IC212
        where T5 : IC212
    {
        
        string Productidentifiercodequalifier_01 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        T2 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        T3 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        T4 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        T5 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    public interface IPRI<T1>
        where T1 : IC509
    {
        
        T1 PRICEINFORMATION_01 { get; set; }
        string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    public interface IQTY<T1>
        where T1 : IC186
    {
        
        T1 QUANTITYDETAILS_01 { get; set; }
    }
    
    public interface IQVR<T1, T2>
        where T1 : IC279
        where T2 : IC960
    {
        
        T1 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        string Discrepancynatureidentificationcode_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface IRFF<T1>
        where T1 : IC506
    {
        
        T1 REFERENCE_01 { get; set; }
    }
    
    public interface IRTE<T1>
        where T1 : IC128
    {
        
        T1 RATEDETAILS_01 { get; set; }
        string Statusdescriptioncode_02 { get; set; }
    }
    
    public interface ITAX<T1, T2, T3>
        where T1 : IC241
        where T2 : IC533
        where T3 : IC243
    {
        
        string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        T1 DUTYTAXFEETYPE_02 { get; set; }
        T2 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        T3 DUTYTAXFEEDETAIL_05 { get; set; }
        string Dutyortaxorfeecategorycode_06 { get; set; }
        string Partytaxidentifier_07 { get; set; }
        string Calculationsequencecode_08 { get; set; }
    }
    
    public interface ITDT<T1, T2, T3, T4, T5>
        where T1 : IC220
        where T2 : IC228
        where T3 : IC040
        where T4 : IC401
        where T5 : IC222
    {
        
        string Transportstagecodequalifier_01 { get; set; }
        string Meansoftransportjourneyidentifier_02 { get; set; }
        T1 MODEOFTRANSPORT_03 { get; set; }
        T2 TRANSPORTMEANS_04 { get; set; }
        T3 CARRIER_05 { get; set; }
        string Transitdirectionindicatorcode_06 { get; set; }
        T4 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        T5 TRANSPORTIDENTIFICATION_08 { get; set; }
        string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    public interface ITOD<T1>
        where T1 : IC100
    {
        
        string Deliveryortransporttermsfunctioncode_01 { get; set; }
        string Transportchargespaymentmethodcode_02 { get; set; }
        T1 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    public interface IUNS
    {
        
        string Sectionidentification_01 { get; set; }
    }
}
