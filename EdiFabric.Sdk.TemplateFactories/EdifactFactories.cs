using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Framework;
using EdiFabric.Rules.EDIFACT_D96A;
using System.Reflection;

namespace EdiFabric.Sdk.TemplateFactories
{
    public class EdifactFactories
    {
        /// <summary>
        /// Parse the transaction implicitly to a type with matching attributes in the specified assembly.
        /// Matching by UNH MessageIdentifier.
        /// </summary>
        /// <param name="messageContext">The message context.</param>
        /// <returns>The assembly containing the matching template.</returns>
        public static Assembly FullTemplateFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D96A" && (messageContext.Name == "ORDERS" || messageContext.Name == "INVOIC"))
                return Assembly.Load("EdiFabric.Sdk.Edifact.Templates.D96A");

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                messageContext.Name, messageContext.Version));
        }

        public static Assembly SplitFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D96A" && (messageContext.Name == "ORDERS" || messageContext.Name == "INVOIC"))
                return Assembly.Load("EdiFabric.Sdk.Edifact.Templates.D96A.Split");

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                messageContext.Name, messageContext.Version));
        }

        public static Assembly CustomValidationFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D96A" && (messageContext.Name == "ORDERS" || messageContext.Name == "INVOIC"))
                return Assembly.Load("EdiFabric.Sdk.Edifact.Templates.D96A.Validation");

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                messageContext.Name, messageContext.Version));
        }

        /// <summary>
        /// Parse the transaction explicitly to a type.
        /// </summary>
        /// <param name="unb">The UNB.</param>
        /// <param name="ung">The UNG.</param>
        /// <param name="unh">The UNH.</param>
        /// <returns>The type to parse to.</returns>
        public static TypeInfo TypeFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
                unh.MessageIdentifier_02.MessageType_01 == "ORDERS")
                return typeof(TSORDERS).GetTypeInfo();

            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
                unh.MessageIdentifier_02.MessageType_01 == "INVOIC")
                return typeof(TSINVOIC).GetTypeInfo();

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02));
        }
        
        public static Assembly TrialFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D96A")
                return Assembly.Load("EdiFabric.Rules.EdifactD96A");

            throw new System.Exception(string.Format("Unsupported version {0}", messageContext.Version));
        }
    }
}
