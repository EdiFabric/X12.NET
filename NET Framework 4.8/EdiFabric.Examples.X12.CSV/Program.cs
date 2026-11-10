using EdiFabric.Examples.X12.Common;
using System;

namespace EdiFabric.Examples.X12.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            License.EnsureToken(Config.TrialSerialKey, 3600);

            //  Export to custom CSV
            ExportToCsv.Run();

            //  Import from custom CSV
            ImportFromCsv.Run();
        }
    }
}
