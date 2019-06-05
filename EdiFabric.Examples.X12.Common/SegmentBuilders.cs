using EdiFabric.Core.Model.Edi.X12;
using System;

namespace EdiFabric.Examples.X12.Common
{
    public static class SegmentBuilders
    {
        /// <summary>
        /// Build ISA.
        /// </summary>
        public static ISA BuildIsa(string controlNumber, 
            string senderId = "SENDER1", 
            string senderQ = "14", 
            string receiverId = "RECEIVER1", 
            string receiverQ = "16", 
            string ackRequested = "1", 
            string testIndicator = "T")
        {
            return new ISA
            {
                //  Authorization Information Qualifier
                AuthorizationInformationQualifier_1 = "00",
                //  Authorization Information
                AuthorizationInformation_2 = "".PadRight(10),
                //  Security Information Qualifier
                SecurityInformationQualifier_3 = "00",
                //  Security Information
                SecurityInformation_4 = "".PadRight(10),
                //  Interchange ID Qualifier
                SenderIDQualifier_5 = senderQ,
                //  Interchange Sender
                InterchangeSenderID_6 = senderId.PadRight(15),
                //  Interchange ID Qualifier
                ReceiverIDQualifier_7 = receiverQ,
                //  Interchange Receiver
                InterchangeReceiverID_8 = receiverId.PadRight(15),
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
                AcknowledgementRequested_14 = ackRequested,
                //  Test Indicator
                UsageIndicator_15 = testIndicator,
            };
        }

        /// <summary>
        /// Build GS.
        /// </summary>
        public static GS BuildGs(string controlNumber, 
            string senderId = "SENDER1", 
            string receiverId = "RECEIVER1")
        {
            return new GS
            {
                //  Functional ID Code
                CodeIdentifyingInformationType_1 = "IN",
                //  Application Senders Code
                SenderIDCode_2 = senderId,
                //  Application Receivers Code
                ReceiverIDCode_3 = receiverId,
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
