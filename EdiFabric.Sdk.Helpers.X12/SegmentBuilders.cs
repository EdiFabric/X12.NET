using EdiFabric.Core.Model.Edi.X12;
using System;

namespace EdiFabric.Sdk.Helpers.X12
{
    public static class SegmentBuilders
    {
        /// <summary>
        /// Build ISA.
        /// </summary>
        public static ISA BuildIsa(string controlNumber)
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

        /// <summary>
        /// Build GS.
        /// </summary>
        public static GS BuildGs(string controlNumber)
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
                VersionAndRelease_8 = "004010"
            };
        }
    }
}
