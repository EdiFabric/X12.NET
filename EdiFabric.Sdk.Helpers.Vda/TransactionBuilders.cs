using EdiFabric.Rules.Vda;
using System.Collections.Generic;

namespace EdiFabric.Sdk.Helpers.Vda
{
    public class TransactionBuilders
    {
        /// <summary>
        /// Build delivery instruction.
        /// Original from 
        /// </summary>
        public static TS4905 BuildDeliveryInstruction()
        {
            var result = new TS4905();

            //  Header record delivery instruction 
            result.S511 = new S511();
            result.S511.RecordType_01 = "511";
            result.S511.Version_02 = "02";
            result.S511.CustomerCode_03 = "59012".PadRight(9, ' ');
            result.S511.SupplierCode_04 = "00323625".PadRight(9, ' ');
            result.S511.TransmissionNumberOld_05 = "00022".PadRight(5, ' ');
            result.S511.TransmissionNumberNew_06 = "00023".PadRight(5, ' ');
            result.S511.TransmissionDate_07 = "121115".PadRight(6, ' ');
            result.S511.StartingDate_08 = "111231".PadRight(6, ' ');
            result.S511.Blanks_09 = "".PadRight(83, ' ');

            //  Repeating 512 Groups
            result.S512Loop = new List<TS4905_S512Loop>();

            //  Begin 512 Group
            var s512Loop = new TS4905_S512Loop();

            //  Unique data to the article codes
            s512Loop.S512 = new S512();
            s512Loop.S512.RecordType_01 = "512";
            s512Loop.S512.Version_02 = "01";
            s512Loop.S512.CustomerPlantCode_03 = "03".PadRight(3, ' ');
            s512Loop.S512.DeliveryCallOffNumberNew_04 = "187".PadRight(9, ' ');
            s512Loop.S512.DeliveryCallOffDateNew_05 = "121115".PadRight(6, ' ');
            s512Loop.S512.DeliveryCallOffNumberOld_06 = "186".PadRight(9, ' ');
            s512Loop.S512.DeliveryCallOffDateOld_07 = "121109".PadRight(6, ' ');
            s512Loop.S512.ArticleCodeCustomer_08 = "1514280009100".PadRight(22, ' ');
            s512Loop.S512.ArticleCodeSupplier_09 = "".PadRight(22, ' ');
            s512Loop.S512.OrderNumber_10 = "CGF-56026482".PadRight(12, ' ');
            s512Loop.S512.DockGate_11 = "A 13".PadRight(5, ' ');
            s512Loop.S512.CustomerClerkIdentifier_12 = "".PadRight(4, ' ');
            s512Loop.S512.QuantityUnitOfMeasure_13 = "ST".PadRight(2, ' ');
            s512Loop.S512.DeliveryFrequency_14 = "L".PadRight(1, ' ');
            s512Loop.S512.ManufacturingRelease_15 = "".PadRight(1, ' ');
            s512Loop.S512.MaterialRelease_16 = "".PadRight(1, ' ');
            s512Loop.S512.RequirementCode_17 = "".PadRight(1, ' ');
            s512Loop.S512.AccountKey_18 = "".PadRight(7, ' ');
            s512Loop.S512.StockLocation_19 = "".PadRight(7, ' ');
            s512Loop.S512.Blanks_20 = "".PadRight(5, ' ');

            //  Reconciliation and call-off data
            s512Loop.S513 = new S513();
            s512Loop.S513.RecordType_01 = "513";
            s512Loop.S513.Version_02 = "01";
            s512Loop.S513.DateOfLastRecordedReceipt_03 = "121113".PadRight(6, ' ');
            s512Loop.S513.LastRecordedDeliveryNoteNumber_04 = "432701".PadRight(8, ' ');
            s512Loop.S513.DateOfLastRecordedReceipt_05 = "".PadRight(6, ' ');
            s512Loop.S513.QuantityLastRecordedReceipt_06 = "000000346000".PadRight(12, ' ');
            s512Loop.S513.CommulativeFigureReceipt_07 = "0000019427".PadRight(10, ' ');
            s512Loop.S513.CallOffDate1_08 = "121115".PadRight(6, ' ');
            s512Loop.S513.CallOffQuantity1_09 = "".PadRight(9, '0');
            s512Loop.S513.CallOffDate2_10 = "".PadRight(6, '0');
            s512Loop.S513.CallOffQuantity2_11 = "".PadRight(9, ' ');
            s512Loop.S513.CallOffDate3_12 = "".PadRight(6, ' ');
            s512Loop.S513.CallOffQuantity3_13 = "".PadRight(9, ' ');
            s512Loop.S513.CallOffDate4_14 = "".PadRight(6, ' ');
            s512Loop.S513.CallOffQuantity4_15 = "".PadRight(9, ' ');
            s512Loop.S513.CallOffDate5_16 = "".PadRight(6, ' ');
            s512Loop.S513.CallOffQuantity5_17 = "".PadRight(9, ' ');
            s512Loop.S513.Blanks_18 = "".PadRight(6, ' ');

            //  Complementary data delivery call 
            s512Loop.S515 = new S515();
            s512Loop.S515.RecordType_01 = "515";
            s512Loop.S515.Version_02 = "01";
            s512Loop.S515.ManufacturingReleaseStartDate_03 = "".PadRight(6, '0');
            s512Loop.S515.ManufacturingReleaseFinalDate_04 = "130213".PadRight(6, ' ');
            s512Loop.S515.ManufacturingReleaseCumulatedRequirements_05 = "".PadRight(10, '0');
            s512Loop.S515.MaterialReleaseStartDate_06 = "".PadRight(6, '0');
            s512Loop.S515.MaterialReleaseFinalDate_07 = "130315".PadRight(6, ' ');
            s512Loop.S515.MaterialReleaseCumulatedRequirements_08 = "".PadRight(10, '0');
            s512Loop.S515.CompletingArticleCode_09 = "".PadRight(22, ' ');
            s512Loop.S515.ImmediateSupplier_10 = "".PadRight(9, ' ');
            s512Loop.S515.DatePlanningHorizon_11 = "".PadRight(6, '0');
            s512Loop.S515.PointOfConsumption_12 = "".PadRight(14, ' ');
            s512Loop.S515.CumulativeFigure_13 = "".PadRight(10, ' ');
            s512Loop.S515.Blanks_14 = "".PadRight(18, ' ');

            //  Repeating 518
            s512Loop.S518 = new List<S518>();

            //  Text data 1
            var s5181 = new S518();
            s5181.RecordType_01 = "518";
            s5181.Version_02 = "01";
            s5181.DeliveryInstructionText1_03 = "07-08140295/04".PadRight(40, ' ');
            s5181.DeliveryInstructionText2_04 = "23-09140029".PadRight(40, ' ');
            s5181.DeliveryInstructionText3_05 = "".PadRight(40, ' ');
            s5181.Blanks_06 = "".PadRight(3, ' ');
            s512Loop.S518.Add(s5181);

            //  Text data 2
            var s5182 = new S518();
            s5182.RecordType_01 = "518";
            s5182.Version_02 = "01";
            s5182.DeliveryInstructionText1_03 = "".PadRight(40, ' ');
            s5182.DeliveryInstructionText2_04 = "".PadRight(40, ' ');
            s5182.DeliveryInstructionText3_05 = "".PadRight(40, ' ');
            s5182.Blanks_06 = "".PadRight(3, ' ');
            s512Loop.S518.Add(s5182);

            //  End 512 Group
            result.S512Loop.Add(s512Loop);

            //  Trailer record delivery instruction 
            result.S519 = new S519();
            result.S519.RecordType_01 = "519";
            result.S519.Version_02 = "01";
            result.S519.CounterRecordType511_03 = "1".PadLeft(7, '0');
            result.S519.CounterRecordType512_04 = "1".PadLeft(7, '0');
            result.S519.CounterRecordType513_05 = "1".PadLeft(7, '0');
            result.S519.CounterRecordType514_06 = "".PadLeft(7, '0');
            result.S519.CounterRecordType517_07 = "".PadLeft(7, '0');
            result.S519.CounterRecordType518_08 = "2".PadLeft(7, '0');
            result.S519.CounterRecordType519_09 = "1".PadLeft(7, '0');
            result.S519.CounterRecordType515_10 = "1".PadLeft(7, '0');
            result.S519.Blanks_11 = "".PadRight(40, ' ');


            return result;
        }
    }
}
