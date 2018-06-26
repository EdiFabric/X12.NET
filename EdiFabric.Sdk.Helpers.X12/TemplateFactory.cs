using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework;
using EdiFabric.Templates.Hipaa5010;
using EdiFabric.Templates.X12004010;
using System;
using System.Reflection;

namespace EdiFabric.Sdk.Helpers.X12
{
    public class TemplateFactory
    {
        /// <summary>
        /// Parse the transaction explicitly.
        /// </summary>
        /// <param name="isa">The ISA.</param>
        /// <param name="gs">The GS.</param>
        /// <param name="st">The ST.</param>
        /// <returns>The type to parse to.</returns>
        public static TypeInfo FullTemplateFactory(ISA isa, GS gs, ST st)
        {
            if (isa.InterchangeSenderID_6.StartsWith("SPLIT1", StringComparison.Ordinal) &&
               st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850Split).GetTypeInfo();

            if (isa.InterchangeSenderID_6.StartsWith("INVALID1", StringComparison.Ordinal) &&
                st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850Validation).GetTypeInfo();

            if (isa.InterchangeSenderID_6.StartsWith("CUSTOM1", StringComparison.Ordinal) &&
                st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850Custom1).GetTypeInfo();

            if (isa.InterchangeSenderID_6.StartsWith("CUSTOM2", StringComparison.Ordinal) &&
               st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850Custom2).GetTypeInfo();

            if (gs.VersionAndRelease_8 == "004010" &&
                 st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850).GetTypeInfo();

            if (gs.VersionAndRelease_8 == "004010" &&
                  st.TransactionSetIdentifierCode_01 == "810")
                return typeof(TS810).GetTypeInfo();

            if (gs.VersionAndRelease_8 == "005010X222A1" &&
                  st.TransactionSetIdentifierCode_01 == "837")
                return typeof(TS837P).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, gs.VersionAndRelease_8));
        }

        public static Assembly TrialTemplateFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "004010")
                return Assembly.Load("EdiFabric.Templates.X12");

            throw new Exception(string.Format("Unsupported version {0}", messageContext.Version));
        }
    }
}
