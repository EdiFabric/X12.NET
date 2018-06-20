using EdiFabric.Framework;
using EdiFabric.Rules.Vda;
using System.Reflection;

namespace EdiFabric.Sdk.Helpers.Vda
{
    public class TemplateFactory
    {
        /// <summary>
        /// Sample factory to load the correct message context
        /// It is invoked for each transaction\message read from the VDA stream
        /// </summary>
        /// <param name="segment">The next 128 bytes</param>
        /// <returns>The message context</returns>
        public static MessageContext FullTemplateFactory(string segment)
        {
            var id = segment.Substring(0, 5);
            switch (id)
            {
                case "51102":
                    return new MessageContext("4905", segment.Substring(29, 5), "1", "VDA", typeof(TS4905).GetTypeInfo(), null, null, null, null);
            }

            return null;
        }
    }
}
