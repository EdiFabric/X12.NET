namespace EdiFabric.Sdk.X12.Import.Xml
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
