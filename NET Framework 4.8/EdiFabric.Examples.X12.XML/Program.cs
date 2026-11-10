using EdiFabric.Examples.X12.Common;
using System;

namespace EdiFabric.Examples.X12.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            License.EnsureToken(Config.TrialSerialKey, 3600);

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
