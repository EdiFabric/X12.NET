using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
