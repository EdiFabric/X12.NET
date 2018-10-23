namespace EdiFabric.Sdk.X12.Export.Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.SerializeToXmlWithXmlSerializer();
            Examples.SerializeToXmlWithDataContractSerializer();
        }
    }
}
