namespace EdiFabric.Sdk.Edifact.Import.Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.DeserializeFromXmlWithXmlSerializer();
            Examples.DeserializeFromXmlWithDataContractSerializer();
        }
    }
}
