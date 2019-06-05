using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using System;
using System.IO;
using System.Text;

namespace EdiFabric.Examples.X12.Common
{
    public static class AckBuilders
    {
        /// <summary>
        /// Swap the original sender and receiver and copy over the rest of the values.
        /// </summary>
        public static ISA ToAckIsa(this ISA header, string controlNumber, AckVersion ackVersion)
        {
            return new ISA
            {
                AuthorizationInformationQualifier_1 = "00",
                AuthorizationInformation_2 = "".PadRight(10, ' '),
                SecurityInformationQualifier_3 = "00",
                SecurityInformation_4 = "".PadRight(10, ' '),
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

        /// <summary>
        /// Swap the original sender and receiver and copy over the rest of the values.
        /// </summary>
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

        /// <summary>
        /// Build functional 997 acknowledgment using the original ISA and GS.
        /// </summary>
        public static string BuildAck(ISA originalIsa, GS originalGs, TS997 ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1)
        {
            return BuildAck<TS997>(originalIsa, originalGs, ack, ackVersion, isaControlNumber, gsControlNumber);
        }

        /// <summary>
        /// Build implementation 999 acknowledgment using the original ISA and GS.
        /// </summary>
        public static string BuildAck(ISA originalIsa, GS originalGs, TS999 ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1)
        {
            return BuildAck<TS999>(originalIsa, originalGs, ack, ackVersion, isaControlNumber, gsControlNumber);
        }

        private static string BuildAck<T>(ISA originalIsa, GS originalGs, T ack, AckVersion ackVersion, int isaControlNumber = 1, int gsControlNumber = 1) where T : EdiMessage
        {
            var memoryStream = new MemoryStream();

            using (var writer = new X12Writer(memoryStream, new X12WriterSettings() { Encoding = Encoding.Default, Postfix = Environment.NewLine }))
            {
                writer.Write(originalIsa.ToAckIsa(isaControlNumber.ToString().PadLeft(9, '0'), ackVersion));
                writer.Write(originalGs.ToAckGs(gsControlNumber.ToString(), ackVersion));
                writer.Write(ack);
            }

            memoryStream.Position = 0;
            using (var reader = new StreamReader(memoryStream))
                return reader.ReadToEnd();
        }

        private static string GetIsaVersion(AckVersion ackVersion)
        {
            return ackVersion == AckVersion.Hipaa_999 ? "00501" : "00401";
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
    }
}
