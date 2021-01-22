using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Templates.X12004010;
using System.Collections.Generic;

namespace EdiFabric.Examples.X12.Common
{
    public class EF_X12_004010_850_Builder
    {
        /// <summary>
        /// Build purchase order.
        /// Original example from http://www.x12.org/examples/004010X357/tax-exempt-purchase-order/
        /// </summary>
        public static TS850 BuildPurchaseOrder(string controlNumber)
        {
            var result = new TS850();

            //  Indicates the start of a purchase order transaction set and assigns a control number.
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "850";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Indicates that this is original purchase order number XX-1234, dated March 1, 2017, and that no acknowledgment is necessary.
            result.BEG = new BEG();
            result.BEG.TransactionSetPurposeCode_01 = "00";
            result.BEG.PurchaseOrderTypeCode_02 = "SA";
            result.BEG.PurchaseOrderNumber_03 = "XX-1234";
            result.BEG.Date_05 = "20170301";
            result.BEG.AcknowledgmentType_07 = "NA";

            //  Repeating PER
            result.PER = new List<PER>();

            //  Indicates that the name of the Buyer is Ed Smith, and his telephone number is (800) 123-4567.
            var per = new PER();
            per.ContactFunctionCode_01 = "BD";
            per.Name_02 = "ED SMITH";
            per.CommunicationNumberQualifier_03 = "TE";
            per.CommunicationNumber_04 = "8001234567";
            result.PER.Add(per);

            //  Repeating TAX
            result.TAX = new List<TAX>();

            //  Provides state tax exempt ID 53247765.
            var tax = new TAX();
            tax.TaxIdentificationNumber_01 = "53247765";
            tax.LocationQualifier_02 = "SP";
            tax.LocationIdentifier_03 = "CA";
            tax.TaxExemptCode_12 = "9";
            result.TAX.Add(tax);

            //  Repeating N1 Loops  
            result.N1Loop = new List<Loop_N1_850>();

            //  Begin N1 Loop 
            var n1Loop = new Loop_N1_850();

            //  Indicates that the buyer is ABC Aerospace. ABC's D-U-N-S+4 number is 123456789-0101.
            n1Loop.N1 = new N1();
            n1Loop.N1.EntityIdentifierCode_01 = "BY";
            n1Loop.N1.Name_02 = "ABC AEROSPACE";
            n1Loop.N1.IdentificationCodeQualifier_03 = "9";
            n1Loop.N1.IdentificationCode_04 = "1234567890101";

            //  Repeating N2
            n1Loop.N2 = new List<N2>();

            //  Provides additional name content for the buyer.
            var n2 = new N2();
            n2.Name_01 = "AIRCRAFT DIVISION";
            n1Loop.N2.Add(n2);

            //  Repeating N3
            n1Loop.N3 = new List<N3>();

            //  The buyer’s street address is 2000 Jet Blvd.
            var n3 = new N3();
            n3.AddressInformation_01 = "2000 JET BLVD";
            n1Loop.N3.Add(n3);

            //  Repeating N4
            n1Loop.N4 = new List<N4>();

            //  The buyer’s city, state, and ZIP is Fighter Town, CA 98898.
            var n4 = new N4();
            n4.CityName_01 = "FIGHTER TOWN";
            n4.StateorProvinceCode_02 = "CA";
            n4.PostalCode_03 = "98898";
            n1Loop.N4.Add(n4);

            //  End N1 Loop 
            result.N1Loop.Add(n1Loop);

            //  Repeating PO1 Loops  
            result.PO1Loop = new List<Loop_PO1_850>();

            //  Begin PO1 Loop 
            var pO1Loop = new Loop_PO1_850();

            //  Indicates Baseline item 1 is a request to purchase 25 units, with a price of $36.00 each, of manufacturer's part number XYZ-1234.
            pO1Loop.PO1 = new PO1();
            pO1Loop.PO1.AssignedIdentification_01 = "1";
            pO1Loop.PO1.QuantityOrdered_02 = "25";
            pO1Loop.PO1.UnitorBasisforMeasurementCode_03 = "EA";
            pO1Loop.PO1.UnitPrice_04 = "36";
            pO1Loop.PO1.BasisofUnitPriceCode_05 = "PE";
            pO1Loop.PO1.ProductServiceIDQualifier_06 = "MG";
            pO1Loop.PO1.ProductServiceID_07 = "XYZ-1234";

            //  Repeating MEA
            pO1Loop.MEA = new List<MEA>();

            //  Indicates that each unit in the order weighs 10 ounces.
            var mea = new MEA();
            mea.MeasurementReferenceIDCode_01 = "WT";
            mea.MeasurementQualifier_02 = "WT";
            mea.MeasurementValue_03 = "10";
            mea.CompositeUnitofMeasure_04 = new C001();
            mea.CompositeUnitofMeasure_04.UnitorBasisforMeasurementCode_01 = "OZ";
            pO1Loop.MEA.Add(mea);

            //  Indicates that no product substitution is allowed.
            pO1Loop.IT8 = new IT8();
            pO1Loop.IT8.ProductServiceSubstitutionCode_07 = "B0";

            //  Repeating SCH Loops  
            pO1Loop.SCHLoop = new List<Loop_SCH_850>();

            //  Begin SCH Loop 
            var schLoop = new Loop_SCH_850();

            //  Indicates that the 25 units are required to arrive by June 15, 2017.
            schLoop.SCH = new SCH();
            schLoop.SCH.Quantity_01 = "25";
            schLoop.SCH.UnitorBasisforMeasurementCode_02 = "EA";
            schLoop.SCH.DateTimeQualifier_05 = "106";
            schLoop.SCH.Date_06 = "20170615";

            //  End SCH Loop 
            pO1Loop.SCHLoop.Add(schLoop);

            //  End PO1 Loop 
            result.PO1Loop.Add(pO1Loop);

            //  Begin CTT Loop   
            result.CTTLoop = new Loop_CTT_850();

            //  Indicates that the purchase order contains 1 line item.
            result.CTTLoop.CTT = new CTT();
            result.CTTLoop.CTT.NumberofLineItems_01 = "1";

            //  Indicates that the total amount of the purchase order is $900.
            result.CTTLoop.AMT = new AMT();
            result.CTTLoop.AMT.AmountQualifierCode_01 = "TT";
            result.CTTLoop.AMT.MonetaryAmount_02 = "900";

            //  End CTT Loop   

            return result;
        }
    }
}
