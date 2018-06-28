namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    public interface IC002
    {
        
        string Documentnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Documentname_04 { get; set; }
    }
    
    public interface IC040
    {
        
        string Carrieridentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Carriername_04 { get; set; }
    }
    
    public interface IC056
    {
        
        string Departmentoremployeenamecode_01 { get; set; }
        string Departmentoremployeename_02 { get; set; }
    }
    
    public interface IC058
    {
        
        string Nameandaddressdescription_01 { get; set; }
        string Nameandaddressdescription_02 { get; set; }
        string Nameandaddressdescription_03 { get; set; }
        string Nameandaddressdescription_04 { get; set; }
        string Nameandaddressdescription_05 { get; set; }
    }
    
    public interface IC059
    {
        
        string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    public interface IC076
    {
        
        string Communicationaddressidentifier_01 { get; set; }
        string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    public interface IC078
    {
        
        string Accountholderidentifier_01 { get; set; }
        string Accountholdername_02 { get; set; }
        string Accountholdername_03 { get; set; }
        string Currencyidentificationcode_04 { get; set; }
    }
    
    public interface IC080
    {
        
        string Partyname_01 { get; set; }
        string Partyname_02 { get; set; }
        string Partyname_03 { get; set; }
        string Partyname_04 { get; set; }
        string Partyname_05 { get; set; }
        string Partynameformatcode_06 { get; set; }
    }
    
    public interface IC082
    {
        
        string Partyidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface IC088
    {
        
        string Institutionnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Institutionbranchidentifier_04 { get; set; }
        string Codelistidentificationcode_05 { get; set; }
        string Codelistresponsibleagencycode_06 { get; set; }
        string Institutionname_07 { get; set; }
        string Institutionbranchlocationname_08 { get; set; }
    }
    
    public interface IC100
    {
        
        string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Deliveryortransporttermsdescription_04 { get; set; }
        string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    public interface IC106
    {
        
        string Documentidentifier_01 { get; set; }
        string Versionidentifier_02 { get; set; }
        string Revisionidentifier_03 { get; set; }
    }
    
    public interface IC107
    {
        
        string Freetextvaluecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface IC108
    {
        
        string Freetextvalue_01 { get; set; }
        string Freetextvalue_02 { get; set; }
        string Freetextvalue_03 { get; set; }
        string Freetextvalue_04 { get; set; }
        string Freetextvalue_05 { get; set; }
    }
    
    public interface IC110
    {
        
        string Paymenttermsdescriptionidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Paymenttermsdescription_04 { get; set; }
        string Paymenttermsdescription_05 { get; set; }
    }
    
    public interface IC112
    {
        
        string Timereferencecode_01 { get; set; }
        string Termstimerelationcode_02 { get; set; }
        string Periodtypecode_03 { get; set; }
        string Periodcountquantity_04 { get; set; }
    }
    
    public interface IC128
    {
        
        string Ratetypecodequalifier_01 { get; set; }
        string Unitpricebasisrate_02 { get; set; }
        string Unitpricebasisvalue_03 { get; set; }
        string Measurementunitcode_04 { get; set; }
    }
    
    public interface IC138
    {
        
        string Pricemultiplierrate_01 { get; set; }
        string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    public interface IC174
    {
        
        string Measurementunitcode_01 { get; set; }
        string Measurementvalue_02 { get; set; }
        string Rangeminimumvalue_03 { get; set; }
        string Rangemaximumvalue_04 { get; set; }
        string Significantdigitsquantity_05 { get; set; }
    }
    
    public interface IC186
    {
        
        string Quantitytypecodequalifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string Measurementunitcode_03 { get; set; }
    }
    
    public interface IC202
    {
        
        string Packagetypedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Typeofpackages_04 { get; set; }
    }
    
    public interface IC208
    {
        
        string Objectidentifier_01 { get; set; }
        string Objectidentifier_02 { get; set; }
    }
    
    public interface IC210
    {
        
        string Shippingmarksdescription_01 { get; set; }
        string Shippingmarksdescription_02 { get; set; }
        string Shippingmarksdescription_03 { get; set; }
        string Shippingmarksdescription_04 { get; set; }
        string Shippingmarksdescription_05 { get; set; }
        string Shippingmarksdescription_06 { get; set; }
        string Shippingmarksdescription_07 { get; set; }
        string Shippingmarksdescription_08 { get; set; }
        string Shippingmarksdescription_09 { get; set; }
        string Shippingmarksdescription_10 { get; set; }
    }
    
    public interface IC212
    {
        
        string Itemidentifier_01 { get; set; }
        string Itemtypeidentificationcode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    public interface IC214
    {
        
        string Specialservicedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Specialservicedescription_04 { get; set; }
        string Specialservicedescription_05 { get; set; }
    }
    
    public interface IC220
    {
        
        string Transportmodenamecode_01 { get; set; }
        string Transportmodename_02 { get; set; }
    }
    
    public interface IC222
    {
        
        string Transportmeansidentificationnameidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Transportmeansidentificationname_04 { get; set; }
        string Transportmeansnationalitycode_05 { get; set; }
    }
    
    public interface IC228
    {
        
        string Transportmeansdescriptioncode_01 { get; set; }
        string Transportmeansdescription_02 { get; set; }
    }
    
    public interface IC241
    {
        
        string Dutyortaxorfeetypenamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    public interface IC243
    {
        
        string Dutyortaxorfeeratecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Dutyortaxorfeerate_04 { get; set; }
        string Dutyortaxorfeeratebasiscode_05 { get; set; }
        string Codelistidentificationcode_06 { get; set; }
        string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    public interface IC270
    {
        
        string Controltotaltypecodequalifier_01 { get; set; }
        string Controltotalvalue_02 { get; set; }
        string Measurementunitcode_03 { get; set; }
    }
    
    public interface IC272
    {
        
        string Itemcharacteristiccode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface IC273
    {
        
        string Itemdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Itemdescription_04 { get; set; }
        string Itemdescription_05 { get; set; }
        string Languagenamecode_06 { get; set; }
    }
    
    public interface IC279
    {
        
        string Quantityvariancevalue_01 { get; set; }
        string Quantitytypecodequalifier_02 { get; set; }
    }
    
    public interface IC401
    {
        
        string Excesstransportationreasoncode_01 { get; set; }
        string Excesstransportationresponsibilitycode_02 { get; set; }
        string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    public interface IC402
    {
        
        string Descriptionformatcode_01 { get; set; }
        string Typeofpackages_02 { get; set; }
        string Itemtypeidentificationcode_03 { get; set; }
        string Typeofpackages_04 { get; set; }
        string Itemtypeidentificationcode_05 { get; set; }
    }
    
    public interface IC501
    {
        
        string Percentagetypecodequalifier_01 { get; set; }
        string Percentage_02 { get; set; }
        string Percentagebasisidentificationcode_03 { get; set; }
        string Codelistidentificationcode_04 { get; set; }
        string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    public interface IC502
    {
        
        string Measuredattributecode_01 { get; set; }
        string Measurementsignificancecode_02 { get; set; }
        string Nondiscretemeasurementnamecode_03 { get; set; }
        string Nondiscretemeasurementname_04 { get; set; }
    }
    
    public interface IC504
    {
        
        string Currencyusagecodequalifier_01 { get; set; }
        string Currencyidentificationcode_02 { get; set; }
        string Currencytypecodequalifier_03 { get; set; }
        string Currencyratevalue_04 { get; set; }
    }
    
    public interface IC506
    {
        
        string Referencecodequalifier_01 { get; set; }
        string Referenceidentifier_02 { get; set; }
        string Documentlineidentifier_03 { get; set; }
        string Referenceversionidentifier_04 { get; set; }
        string Revisionidentifier_05 { get; set; }
    }
    
    public interface IC507
    {
        
        string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        string Dateortimeorperiodvalue_02 { get; set; }
        string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    public interface IC509
    {
        
        string Pricecodequalifier_01 { get; set; }
        string Priceamount_02 { get; set; }
        string Pricetypecode_03 { get; set; }
        string Pricespecificationcode_04 { get; set; }
        string Unitpricebasisvalue_05 { get; set; }
        string Measurementunitcode_06 { get; set; }
    }
    
    public interface IC516
    {
        
        string Monetaryamounttypecodequalifier_01 { get; set; }
        string Monetaryamount_02 { get; set; }
        string Currencyidentificationcode_03 { get; set; }
        string Currencytypecodequalifier_04 { get; set; }
        string Statusdescriptioncode_05 { get; set; }
    }
    
    public interface IC517
    {
        
        string Locationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Locationname_04 { get; set; }
    }
    
    public interface IC519
    {
        
        string Firstrelatedlocationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Firstrelatedlocationname_04 { get; set; }
    }
    
    public interface IC531
    {
        
        string Packaginglevelcode_01 { get; set; }
        string Packagingrelateddescriptioncode_02 { get; set; }
        string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    public interface IC532
    {
        
        string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    public interface IC533
    {
        
        string Dutyortaxorfeeaccountcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface IC534
    {
        
        string Paymentconditionscode_01 { get; set; }
        string Paymentguaranteemeanscode_02 { get; set; }
        string Paymentmeanscode_03 { get; set; }
        string Codelistidentificationcode_04 { get; set; }
        string Codelistresponsibleagencycode_05 { get; set; }
        string Paymentchannelcode_06 { get; set; }
    }
    
    public interface IC552
    {
        
        string Allowanceorchargeidentifier_01 { get; set; }
        string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    public interface IC553
    {
        
        string Secondrelatedlocationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Secondrelatedlocationname_04 { get; set; }
    }
    
    public interface IC819
    {
        
        string Countrysubentitynamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Countrysubentityname_04 { get; set; }
    }
    
    public interface IC827
    {
        
        string Markingtypecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface IC829
    {
        
        string Sublineindicatorcode_01 { get; set; }
        string Lineitemidentifier_02 { get; set; }
    }
    
    public interface IC960
    {
        
        string Changereasondescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Changereasondescription_04 { get; set; }
    }
}
