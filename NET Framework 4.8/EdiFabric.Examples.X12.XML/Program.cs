﻿using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
