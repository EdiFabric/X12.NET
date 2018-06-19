using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Rules.X12_004010;
using System;
using System.Collections.Generic;

namespace EdiFabric.Sdk.Helpers.X12
{
    public static class TransactionBuilders
    {
        /// <summary>
        /// Build invoice.
        /// </summary>
        public static TS810 BuildInvoice(string controlNumber)
        {
            var result = new TS810();

            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "810";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            result.BIG = new BIG();
            result.BIG.Date_01 = DateTime.Now.ToString("yyyyMMdd");
            result.BIG.InvoiceNumber_02 = "123456789";
            result.BIG.Date_03 = "20030627";
            result.BIG.PurchaseOrderNumber_04 = "201177";

            result.REF = new List<REF>();

            var ref1 = new REF();
            ref1.ReferenceIdentificationQualifier_01 = "DP";
            ref1.ReferenceIdentification_02 = "123";
            result.REF.Add(ref1);

            var ref2 = new REF();
            ref2.ReferenceIdentificationQualifier_01 = "IA";
            ref2.ReferenceIdentification_02 = "456";
            result.REF.Add(ref2);

            result.N1Loop1 = new List<TS810_N1Loop1>();
            var n1Loop = new TS810_N1Loop1();
            n1Loop.N1 = new N1();
            n1Loop.N1.EntityIdentifierCode_01 = "ST";
            n1Loop.N1.IdentificationCodeQualifier_03 = "18";
            n1Loop.N1.IdentificationCode_04 = "123";

            result.N1Loop1.Add(n1Loop);

            result.ITD = new List<ITD>();
            var itd = new ITD();
            itd.TermsTypeCode_01 = "01";
            itd.TermsBasisDateCode_02 = "3";
            itd.TermsDiscountDaysDue_05 = "0";
            itd.TermsNetDays_07 = "45";

            result.IT1Loop1 = new List<TS810_IT1Loop1>();
            var it1Loop = new TS810_IT1Loop1();
            it1Loop.IT1 = new IT1();
            it1Loop.IT1.AssignedIdentification_01 = "1";
            it1Loop.IT1.QuantityInvoiced_02 = "2";
            it1Loop.IT1.UnitorBasisforMeasurementCode_03 = "EA";
            it1Loop.IT1.UnitPrice_04 = "120.6";
            it1Loop.IT1.ProductServiceIDQualifier_06 = "UP";
            it1Loop.IT1.ProductServiceID_07 = "123456789";

            result.IT1Loop1.Add(it1Loop);

            result.TDS = new TDS();
            result.TDS.Amount_01 = "24012";

            result.CAD = new CAD();
            result.CAD.Routing_05 = "1234";
            result.CAD.ReferenceIdentificationQualifier_07 = "BM";
            result.CAD.ReferenceIdentification_08 = "9999";

            result.CTT = new CTT();
            result.CTT.NumberofLineItems_01 = "1";

            return result;
        }

        /// <summary>
        /// Build purchase order
        /// </summary>
        public static TS850 BuildPurchaseOrder(string controlNumber)
        {
            var result = new TS850();

            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "850";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            result.BEG = new BEG();
            result.BEG.TransactionSetPurposeCode_01 = "00";
            result.BEG.PurchaseOrderTypeCode_02 = "SA";
            result.BEG.PurchaseOrderNumber_03 = "201177";
            result.BEG.Date_05 = "20030627";

            result.REF = new List<REF>();
            var refSegment = new REF();
            refSegment.ReferenceIdentificationQualifier_01 = "AN";
            refSegment.ReferenceIdentification_02 = "123456";
            result.REF.Add(refSegment);

            result.PER = new List<PER>();
            var perSegment = new PER();
            perSegment.ContactFunctionCode_01 = "BD";
            perSegment.Name_02 = "JOHN SMITH";
            perSegment.CommunicationNumberQualifier_03 = "TE";
            perSegment.CommunicationNumber_04 = "1112223334";
            result.PER.Add(perSegment);

            result.FOB = new List<FOB>();
            var fobSegment = new FOB();
            fobSegment.ShipmentMethodofPayment_01 = "PB";
            result.FOB.Add(fobSegment);

            result.DTM = new List<DTM>();

            var dtmSegment1 = new DTM();
            dtmSegment1.DateTimeQualifier_01 = "002";
            dtmSegment1.Date_02 = "20030705";
            result.DTM.Add(dtmSegment1);

            var dtmSegment2 = new DTM();
            dtmSegment2.DateTimeQualifier_01 = "118";
            dtmSegment2.Date_02 = "20030704";
            result.DTM.Add(dtmSegment2);

            result.PKG = new List<PKG>();
            var pkgSegment = new PKG();
            pkgSegment.PackagingDescriptionCode_04 = "01";
            result.PKG.Add(pkgSegment);

            result.TD5 = new List<TD5>();
            var td5Segment = new TD5();
            td5Segment.TransportationMethodTypeCode_04 = "H";
            td5Segment.Routing_05 = "OUR CR/T";
            result.TD5.Add(td5Segment);

            result.N9Loop1 = new List<TS850_N9Loop1>();
            var n9Loop = new TS850_N9Loop1();
            result.N9Loop1.Add(n9Loop);

            var n9Segment = new N9();
            n9Segment.ReferenceIdentificationQualifier_01 = "AH";
            n9Segment.ReferenceIdentification_02 = "201177";
            n9Loop.N9 = n9Segment;

            n9Loop.MSG = new List<MSG>();

            var msgSegment1 = new MSG();
            msgSegment1.FreeFormMessageText_01 = "THIS PURCHASE ORDER IS SUBJECT TO THE SAME TERMS AND";
            n9Loop.MSG.Add(msgSegment1);

            var msgSegment2 = new MSG();
            msgSegment2.FreeFormMessageText_01 = "CONDITIONS";
            n9Loop.MSG.Add(msgSegment2);

            result.N1Loop1 = new List<TS850_N1Loop1>();

            var n1Loop1 = new TS850_N1Loop1();
            result.N1Loop1.Add(n1Loop1);

            var n1Segment1 = new N1();
            n1Segment1.EntityIdentifierCode_01 = "ST";
            n1Segment1.Name_02 = "COMPANY INC";
            n1Segment1.IdentificationCodeQualifier_03 = "9";
            n1Segment1.IdentificationCode_04 = "0012345678901";
            n1Loop1.N1 = n1Segment1;

            var n2Segment1 = new N2();
            n2Segment1.Name_01 = "Name Other";
            n1Loop1.N2 = new List<N2>();
            n1Loop1.N2.Add(n2Segment1);

            var n3Segment1 = new N3();
            n3Segment1.AddressInformation_01 = "67100 Some Road";
            n1Loop1.N3 = new List<N3>();
            n1Loop1.N3.Add(n3Segment1);

            var n4Segment1 = new N4();
            n4Segment1.CityName_01 = "Name";
            n4Segment1.StateorProvinceCode_02 = "CA";
            n4Segment1.PostalCode_03 = "95376";
            n1Loop1.N4 = new List<N4>();
            n1Loop1.N4.Add(n4Segment1);

            var n1Loop2 = new TS850_N1Loop1();
            result.N1Loop1.Add(n1Loop2);

            var n1Segment2 = new N1();
            n1Segment2.EntityIdentifierCode_01 = "VN";
            n1Segment2.Name_02 = "SAMPLE SUPPLIER INC.";
            n1Segment2.IdentificationCodeQualifier_03 = "9";
            n1Segment2.IdentificationCode_04 = "1234567890000";
            n1Loop2.N1 = n1Segment2;

            var n3Segment2 = new N3();
            n3Segment2.AddressInformation_01 = "P.O. BOX 12345";
            n1Loop2.N3 = new List<N3>();
            n1Loop2.N3.Add(n3Segment2);

            var n4Segment2 = new N4();
            n4Segment2.CityName_01 = "LOS ANGELES";
            n4Segment2.StateorProvinceCode_02 = "CA";
            n4Segment2.PostalCode_03 = "90001";
            n1Loop2.N4 = new List<N4>();
            n1Loop2.N4.Add(n4Segment2);

            result.PO1Loop1 = new List<TS850_PO1Loop1>();
            var pO1Loop1 = new TS850_PO1Loop1();
            result.PO1Loop1.Add(pO1Loop1);

            var po1Segment = new PO1();
            po1Segment.AssignedIdentification_01 = "2";
            po1Segment.QuantityOrdered_02 = "120.6";
            po1Segment.UnitorBasisforMeasurementCode_03 = "EA";
            po1Segment.UnitPrice_04 = "9.55";
            po1Segment.BasisofUnitPriceCode_05 = "TE";
            po1Segment.ProductServiceIDQualifier_06 = "CB";
            po1Segment.ProductServiceID_07 = "067504-118";
            po1Segment.ProductServiceIDQualifier_08 = "PR";
            po1Segment.ProductServiceID_09 = "RO";
            po1Segment.ProductServiceIDQualifier_10 = "VN";
            po1Segment.ProductServiceID_11 = "12345";
            pO1Loop1.PO1 = po1Segment;

            pO1Loop1.PIDLoop1 = new List<TS850_PIDLoop1>();
            var pidLoop1 = new TS850_PIDLoop1();
            pO1Loop1.PIDLoop1.Add(pidLoop1);

            var pidSegment = new PID();
            pidSegment.ItemDescriptionType_01 = "F";
            pidSegment.Description_05 = "SOME ITEM";
            pidLoop1.PID = pidSegment;

            pO1Loop1.PO4 = new List<PO4>();

            var po4Segment = new PO4();
            po4Segment.Pack_01 = "6";
            po4Segment.Size_02 = "6";
            po4Segment.UnitorBasisforMeasurementCode_03 = "EA";
            po4Segment.PackagingCode_04 = "PLT94";
            po4Segment.GrossWeightperPack_06 = "3";
            po4Segment.UnitorBasisforMeasurementCode_07 = "LR";
            po4Segment.GrossVolumeperPack_08 = "10";
            po4Segment.UnitorBasisforMeasurementCode_09 = "CT";
            pO1Loop1.PO4.Add(po4Segment);

            result.CTTLoop1 = new TS850_CTTLoop1();

            var cttSegment = new CTT();
            cttSegment.NumberofLineItems_01 = "1";
            result.CTTLoop1.CTT = cttSegment;

            var amtSegment = new AMT();
            amtSegment.AmountQualifierCode_01 = "1";
            amtSegment.MonetaryAmount_02 = "240.12";
            result.CTTLoop1.AMT = amtSegment;

            return result;
        }
    }
}
