using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.EDIFACT_D96A;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EdiFabric.Sdk.Helpers
{
    public static class EdifactHelpers
    {
        public static UNB CreateUnb(string controlNumber)
        {
            return new UNB
            {
                SYNTAXIDENTIFIER_1 = new S001
                {
                    //  Syntax Identifier
                    SyntaxIdentifier_1 = "UNOB",
                    //  Syntax Version Number
                    SyntaxVersionNumber_2 = "1"
                },
                INTERCHANGESENDER_2 = new S002
                {
                    //  Interchange sender identification
                    InterchangeSenderIdentification_1 = "RECEIVER1",
                    //  Identification code qualifier
                    IdentificationCodeQualifier_2 = "01",
                    //  Interchange sender internal identification
                    InterchangeSenderInternalIdentification_3 = "ZZUK"
                },
                INTERCHANGERECIPIENT_3 = new S003
                {
                    //  Interchange recipient identification
                    InterchangeRecipientIdentification_1 = "SENDER1",
                    //  Identification code qualifier
                    IdentificationCodeQualifier_2 = "16",
                    //  Interchange recipient internal identification
                    InterchangeRecipientInternalIdentification_3 = "ZZUK"
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    //  Date
                    Date_1 = DateTime.Now.Date.ToString("yyMMdd"),
                    //  Time
                    Time_2 = DateTime.Now.TimeOfDay.ToString("hhmm")
                },
                //  Interchange control reference
                //  Must be incremented with every interchange
                InterchangeControlReference_5 = controlNumber,
                //  Application reference
                ApplicationReference_7 = "INVOIC"
            };
        }

        public static UNB ToAckUnb(this UNB header, string controlNumber)
        {
            var result = new UNB();

            if (header.SYNTAXIDENTIFIER_1 != null)
                result.SYNTAXIDENTIFIER_1 = new S001
                {
                    SyntaxIdentifier_1 = header.SYNTAXIDENTIFIER_1.SyntaxIdentifier_1,
                    SyntaxVersionNumber_2 = header.SYNTAXIDENTIFIER_1.ServiceCodeListDirectoryVersionNumber_3
                };

            if (header.INTERCHANGERECIPIENT_3 != null)
                result.INTERCHANGESENDER_2 = new S002
                {
                    InterchangeSenderIdentification_1 = header.INTERCHANGERECIPIENT_3.InterchangeRecipientIdentification_1,
                    IdentificationCodeQualifier_2 = header.INTERCHANGERECIPIENT_3.IdentificationCodeQualifier_2,
                    InterchangeSenderInternalIdentification_3 = header.INTERCHANGERECIPIENT_3.InterchangeRecipientInternalIdentification_3
                };

            if (header.INTERCHANGESENDER_2 != null)
                result.INTERCHANGERECIPIENT_3 = new S003
                {
                    InterchangeRecipientIdentification_1 = header.INTERCHANGESENDER_2.InterchangeSenderIdentification_1,
                    IdentificationCodeQualifier_2 = header.INTERCHANGESENDER_2.IdentificationCodeQualifier_2,
                    InterchangeRecipientInternalIdentification_3 = header.INTERCHANGESENDER_2.InterchangeSenderInternalIdentification_3
                };

            result.DATEANDTIMEOFPREPARATION_4 = new S004
            {
                Date_1 = DateTime.Now.Date.ToString("yyMMdd"),
                Time_2 = DateTime.Now.TimeOfDay.ToString("hhmm")
            };
            result.InterchangeControlReference_5 = controlNumber;
            result.AcknowledgementRequest_9 = header.AcknowledgementRequest_9;
            result.TestIndicator_11 = header.TestIndicator_11;

            return result;
        }

        public static UNG ToAckUng(this UNG header, string controlNumber)
        {
            if (header == null)
                return null;

            return new UNG
            {
                MessageGroupIdentification_1 = "CONTRL",
                APPLICATIONSENDERIDENTIFICATION_2 = new S006
                {
                    ApplicationSenderIdentification_1 =
                        header.APPLICATIONRECIPIENTIDENTIFICATION_3.ApplicationRecipientIdentification_1,
                    IdentificationCodeQualifier_2 =
                        header.APPLICATIONRECIPIENTIDENTIFICATION_3.IdentificationCodeQualifier_2
                },
                APPLICATIONRECIPIENTIDENTIFICATION_3 = new S007
                {
                    ApplicationRecipientIdentification_1 = header.APPLICATIONSENDERIDENTIFICATION_2.ApplicationSenderIdentification_1,
                    IdentificationCodeQualifier_2 = header.APPLICATIONSENDERIDENTIFICATION_2.IdentificationCodeQualifier_2
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    Date_1 = DateTime.Now.Date.ToString("yyMMdd"),
                    Time_2 = DateTime.Now.TimeOfDay.ToString("hhmm")
                },
                GroupReferenceNumber_5 = controlNumber,
                ControllingAgency_6 = header.ControllingAgency_6
            };
        }

        public static string BuildAck(UNB originalUnb, UNG originalUng, EdiMessage ack, int unbControlNumber = 1, int ungControlNumber = 1)
        {
            var memoryStream = new MemoryStream();

            using (var writer = new EdifactWriter(memoryStream, Encoding.Default, Environment.NewLine))
            {
                writer.Write(originalUnb.ToAckUnb(unbControlNumber.ToString()));
                if (originalUng != null)
                    writer.Write(originalUng.ToAckUng(ungControlNumber.ToString()));
                writer.Write(ack);
            }

            memoryStream.Position = 0;
            using (var reader = new StreamReader(memoryStream))
                return reader.ReadToEnd();
        }

        public static TSINVOIC CreateInvoic(string controlNumber)
        {
            var result = new TSINVOIC();

            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "INVOIC";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "00A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "380";
            result.BGM.Documentmessagenumber_02 = "342459";
            result.BGM.Messagefunctioncoded_03 = "9";

            result.DTM = new List<DTM>();
            var dtm = new DTM();
            dtm.DATETIMEPERIOD_01 = new C507();
            dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "3";
            dtm.DATETIMEPERIOD_01.Datetimeperiod_02 = "20060515";
            dtm.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm);

            result.RFFLoop1 = new List<TSINVOIC_RFFLoop1>();
            var rffLoop = new TSINVOIC_RFFLoop1();
            rffLoop.RFF = new RFF();
            rffLoop.RFF.REFERENCE_01 = new C506();
            rffLoop.RFF.REFERENCE_01.Referencequalifier_01 = "ON";
            rffLoop.RFF.REFERENCE_01.Referencenumber_02 = "521052";
            result.RFFLoop1.Add(rffLoop);

            result.NADLoop1 = new List<TSINVOIC_NADLoop1>();

            var nadLoop1 = new TSINVOIC_NADLoop1();
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "BY";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "792820524";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistqualifier_02 = "16";
            nadLoop1.NAD.PARTYNAME_04 = new C080();
            nadLoop1.NAD.PARTYNAME_04.Partyname_01 = "SOME COMPANY";
            result.NADLoop1.Add(nadLoop1);

            var nadLoop2 = new TSINVOIC_NADLoop1();
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "SE";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "005435656";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "16";
            nadLoop2.NAD.PARTYNAME_04 = new C080();
            nadLoop2.NAD.PARTYNAME_04.Partyname_01 = "SOME COMPANY 2";
            result.NADLoop1.Add(nadLoop2);

            result.CUXLoop1 = new List<TSINVOIC_CUXLoop1>();
            var cuxLoop = new TSINVOIC_CUXLoop1();
            cuxLoop.CUX = new CUX();
            cuxLoop.CUX.CURRENCYDETAILS_01 = new C504();
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencydetailsqualifier_01 = "1";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencycoded_02 = "USD";
            result.CUXLoop1.Add(cuxLoop);

            result.LINLoop1 = new List<TSINVOIC_LINLoop1>();

            var linLoop1 = new TSINVOIC_LINLoop1();
            linLoop1.LIN = new LIN();
            linLoop1.LIN.Lineitemnumber_01 = "1";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "157870";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "IN";
            result.LINLoop1.Add(linLoop1);

            linLoop1.IMD = new List<IMD>();
            var imd1 = new IMD();
            imd1.Itemdescriptiontypecoded_01 = "F";
            imd1.ITEMDESCRIPTION_03 = new C273();
            imd1.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "100";
            linLoop1.IMD.Add(imd1);

            linLoop1.QTY = new List<QTY>();
            var qty1 = new QTY();
            qty1.QUANTITYDETAILS_01 = new C186();
            qty1.QUANTITYDETAILS_01.Quantityqualifier_01 = "21";
            qty1.QUANTITYDETAILS_01.Quantity_02 = "2";
            qty1.QUANTITYDETAILS_01.Measureunitqualifier_03 = "EA";
            linLoop1.QTY.Add(qty1);

            linLoop1.ALI = new List<ALI>();
            var ali1 = new ALI();
            ali1.Countryoforigincoded_01 = "US";
            linLoop1.ALI.Add(ali1);

            linLoop1.MOALoop2 = new List<TSINVOIC_MOALoop2>();
            var moaLoop1 = new TSINVOIC_MOALoop2();
            moaLoop1.MOA = new MOA();
            moaLoop1.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop1.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moaLoop1.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "1202.58";
            linLoop1.MOALoop2.Add(moaLoop1);

            linLoop1.PRILoop1 = new List<TSINVOIC_PRILoop1>();
            var priLoop1 = new TSINVOIC_PRILoop1();
            priLoop1.PRI = new PRI();
            priLoop1.PRI.PRICEINFORMATION_01 = new C509();
            priLoop1.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "INV";
            priLoop1.PRI.PRICEINFORMATION_01.Price_02 = "1.179";
            linLoop1.PRILoop1.Add(priLoop1);

            var linLoop2 = new TSINVOIC_LINLoop1();
            linLoop2.LIN = new LIN();
            linLoop2.LIN.Lineitemnumber_01 = "2";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "157871";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "IN";
            result.LINLoop1.Add(linLoop2);

            linLoop2.IMD = new List<IMD>();
            var imd2 = new IMD();
            imd2.Itemdescriptiontypecoded_01 = "F";
            imd2.ITEMDESCRIPTION_03 = new C273();
            imd2.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "101";
            linLoop2.IMD.Add(imd2);

            linLoop2.QTY = new List<QTY>();
            var qty2 = new QTY();
            qty2.QUANTITYDETAILS_01 = new C186();
            qty2.QUANTITYDETAILS_01.Quantityqualifier_01 = "47";
            qty2.QUANTITYDETAILS_01.Quantity_02 = "29";
            qty2.QUANTITYDETAILS_01.Measureunitqualifier_03 = "EA";
            linLoop2.QTY.Add(qty2);

            linLoop2.ALI = new List<ALI>();
            var ali2 = new ALI();
            ali2.Countryoforigincoded_01 = "JP";
            linLoop2.ALI.Add(ali2);

            linLoop2.MOALoop2 = new List<TSINVOIC_MOALoop2>();
            var moaLoop2 = new TSINVOIC_MOALoop2();
            moaLoop2.MOA = new MOA();
            moaLoop2.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop2.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moaLoop2.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "520";
            linLoop2.MOALoop2.Add(moaLoop2);

            linLoop2.PRILoop1 = new List<TSINVOIC_PRILoop1>();
            var priLoop2 = new TSINVOIC_PRILoop1();
            priLoop2.PRI = new PRI();
            priLoop2.PRI.PRICEINFORMATION_01 = new C509();
            priLoop2.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "INV";
            priLoop2.PRI.PRICEINFORMATION_01.Price_02 = "20.3";
            linLoop2.PRILoop1.Add(priLoop2);

            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "S";

            result.MOALoop4 = new List<TSINVOIC_MOALoop4>();

            var moaLoop3 = new TSINVOIC_MOALoop4();
            moaLoop3.MOA = new MOA();
            moaLoop3.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop3.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "39";
            moaLoop3.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "2137.58";
            result.MOALoop4.Add(moaLoop3);

            result.ALCLoop3 = new List<TSINVOIC_ALCLoop3>();
            var alcLoop = new TSINVOIC_ALCLoop3();
            alcLoop.ALC = new ALC();
            alcLoop.ALC.Allowanceorchargequalifier_01 = "C";
            alcLoop.ALC.ALLOWANCECHARGEINFORMATION_02 = new C552();
            alcLoop.ALC.ALLOWANCECHARGEINFORMATION_02.Allowanceorchargenumber_01 = "ABG";

            alcLoop.MOA = new List<MOA>();
            var moa = new MOA();
            moa.MONETARYAMOUNT_01 = new C516();
            moa.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "8";
            moa.MONETARYAMOUNT_01.Monetaryamount_02 = "634";
            alcLoop.MOA.Add(moa);

            result.ALCLoop3.Add(alcLoop);

            return result;
        }

        public static TSORDERS CreateOrders(string controlNumber)
        {
            var result = new TSORDERS();

            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "INVOIC";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "00A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "380";
            result.BGM.Documentmessagenumber_02 = "342459";
            result.BGM.Messagefunctioncoded_03 = "9";

            result.DTM = new List<DTM>();
            var dtm = new DTM();
            dtm.DATETIMEPERIOD_01 = new C507();
            dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "3";
            dtm.DATETIMEPERIOD_01.Datetimeperiod_02 = "20060515";
            dtm.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm);


            return result;
        }
    }
}
