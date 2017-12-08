namespace EdiFabric.Sdk.X12
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadSamples.Run();
            WriteSamples.Run();
            XmlSamples.Run();
            AcknowledgmentSamples.Run();
            Custom999Samples.Run();
        }
    }
}
