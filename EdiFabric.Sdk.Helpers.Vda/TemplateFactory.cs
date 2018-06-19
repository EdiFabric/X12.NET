using EdiFabric.Framework;
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
                    var newControlNumber = segment.Substring(29, 5);
                    //  Optional
                    var sender = segment.Substring(15, 9);
                    //  Optional
                    var receiver = segment.Substring(6, 9);

                    return new MessageContext("4905", newControlNumber, "1", "VDA", sender, "", receiver, "",
                        mc => Assembly.Load("EdiFabric.Sdk.Vda.Templates"));
            }

            return null;
        }
    }
}
