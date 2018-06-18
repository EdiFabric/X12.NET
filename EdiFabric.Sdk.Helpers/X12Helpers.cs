using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Rules.X12_005010X231A1;
using System;
using System.IO;
using System.Text;

namespace EdiFabric.Sdk.Helpers
{
    public static class X12Helpers
    {
        public static GS CreateGs(string controlNumber)
        {
            return new GS
            {
                //  Functional ID Code
                CodeIdentifyingInformationType_1 = "IN",
                //  Application Senders Code
                SenderIDCode_2 = "RECEIVER1",
                //  Application Receivers Code
                ReceiverIDCode_3 = "SENDER1",
                //  Date
                Date_4 = DateTime.Now.Date.ToString("yyMMdd"),
                //  Time
                Time_5 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                //  Group Control Number
                //  Must be unique to both partners for this interchange
                GroupControlNumber_6 = controlNumber.PadLeft(9, '0'),
                //  Responsible Agency Code
                TransactionTypeCode_7 = "X",
                //  Version/Release/Industry id code
                VersionAndRelease_8 = "002040"
            };
        }

        public static ISA CreateIsa(string controlNumber)
        {
            return new ISA
            {
                //  Authorization Information Qualifier
                AuthorizationInformationQualifier_1 = "00",
                //  Authorization Information
                AuthorizationInformation_2 = "          ",
                //  Security Information Qualifier
                SecurityInformationQualifier_3 = "00",
                //  Security Information
                SecurityInformation_4 = "          ",
                //  Interchange ID Qualifier
                SenderIDQualifier_5 = "14",
                //  Interchange Sender
                InterchangeSenderID_6 = "RECEIVER1      ",
                //  Interchange ID Qualifier
                ReceiverIDQualifier_7 = "16",
                //  Interchange Receiver
                InterchangeReceiverID_8 = "SENDER1        ",
                //  Date
                InterchangeDate_9 = DateTime.Now.Date.ToString("yyMMdd"),
                //  Time
                InterchangeTime_10 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                //  Standard identifier
                InterchangeControlStandardsIdentifier_11 = "U",
                //  Interchange Version ID
                //  This is the ISA version and not the transaction sets versions
                InterchangeControlVersionNumber_12 = "00204",
                //  Interchange Control Number
                InterchangeControlNumber_13 = controlNumber.PadLeft(9, '0'),
                //  Acknowledgment Requested (0 or 1)
                AcknowledgementRequested_14 = "1",
                //  Test Indicator
                UsageIndicator_15 = "T",
            };
        }

        public static GS ToAckGs(this GS header, string controlNumber, AckVersion ackVersion)
        {
            return new GS
            {
                CodeIdentifyingInformationType_1 = "FA",
                SenderIDCode_2 = header.ReceiverIDCode_3,
                ReceiverIDCode_3 = header.SenderIDCode_2,
                Date_4 = DateTime.Now.Date.ToString("yyMMdd"),
                Time_5 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                GroupControlNumber_6 = controlNumber,
                TransactionTypeCode_7 = "X",
                VersionAndRelease_8 = GetGsVersion(ackVersion)
            };
        }

        public static ISA ToAckIsa(this ISA header, string controlNumber, AckVersion ackVersion)
        {
            return new ISA
            {
                AuthorizationInformationQualifier_1 = "00",
                AuthorizationInformation_2 = "          ",
                SecurityInformationQualifier_3 = "00",
                SecurityInformation_4 = "          ",
                SenderIDQualifier_5 = header.ReceiverIDQualifier_7.PadRight(2),
                InterchangeSenderID_6 = header.InterchangeReceiverID_8.PadRight(15),
                ReceiverIDQualifier_7 = header.SenderIDQualifier_5.PadRight(2),
                InterchangeReceiverID_8 = header.InterchangeSenderID_6.PadRight(15),
                InterchangeDate_9 = DateTime.Now.Date.ToString("yyMMdd"),
                InterchangeTime_10 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                InterchangeControlStandardsIdentifier_11 = "^",
                InterchangeControlVersionNumber_12 = GetIsaVersion(ackVersion),
                InterchangeControlNumber_13 = controlNumber,
                AcknowledgementRequested_14 = "0",
                UsageIndicator_15 = header.UsageIndicator_15
            };
        }

        private static string GetGsVersion(AckVersion ackVersion)
        {
            if (ackVersion == AckVersion.Hipaa_999)
                return "005010X231A1";

            if (ackVersion == AckVersion.Hipaa_997)
                return "005010X230";

            if (ackVersion == AckVersion.X12_997)
                return "004010";

            return null;
        }

        private static string GetIsaVersion(AckVersion ackVersion)
        {
            return ackVersion == AckVersion.Hipaa_999 ? "00501" : "00401";
        }

        public static string BuildAck(ISA originalIsa, GS originalGs, TS997 ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1)
        {
            return BuildAck<TS997>(originalIsa, originalGs, ack, ackVersion, isaControlNumber, gsControlNumber);
        }

        public static string BuildAck(ISA originalIsa, GS originalGs, TS999 ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1)
        {
            return BuildAck<TS999>(originalIsa, originalGs, ack, ackVersion, isaControlNumber, gsControlNumber);
        }

        public static string BuildAck(ISA originalIsa, GS originalGs, TS999Custom1 ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1)
        {
            return BuildAck<TS999Custom1>(originalIsa, originalGs, ack, ackVersion, isaControlNumber, gsControlNumber);
        }

        private static string BuildAck<T>(ISA originalIsa, GS originalGs, T ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1) where T : EdiMessage
        {
            var memoryStream = new MemoryStream();

            using (var writer = new X12Writer(memoryStream, Encoding.Default, Environment.NewLine))
            {
                writer.Write(originalIsa.ToAckIsa(isaControlNumber.ToString().PadLeft(9, '0'), ackVersion));
                writer.Write(originalGs.ToAckGs(gsControlNumber.ToString(), ackVersion));
                writer.Write(ack);
            }

            memoryStream.Position = 0;
            using (var reader = new StreamReader(memoryStream))
                return reader.ReadToEnd();
        }
    }
}
