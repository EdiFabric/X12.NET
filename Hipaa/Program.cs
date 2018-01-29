namespace EdiFabric.Sdk.Hipaa
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadSamples.Run();
            WriteSamples.Run();
            //Read834Samples.Run();
            Write834Samples.Run();
        }
    }
}
