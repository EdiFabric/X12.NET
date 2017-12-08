using EdiFabric.Core.Model.Edi.Edifact;
using System;
using System.IO;
using System.Text;

namespace EdiFabric.Sdk.Edifact
{
    static class Helpers
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

        public static string LoadString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
