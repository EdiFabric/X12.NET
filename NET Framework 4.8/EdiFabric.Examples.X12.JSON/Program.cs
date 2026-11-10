using EdiFabric.Examples.X12.Common;
using System;

namespace EdiFabric.Examples.X12.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            License.EnsureToken(Config.TrialSerialKey, 3600);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
