namespace EdiFabric.Sdk.Edifact
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadSamples.Run();
            WriteSamples.Run();
            XmlSamples.Run();
            AcknowledgmentSamples.Run();
        }
    }
}
