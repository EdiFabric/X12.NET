using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Export to custom CSV
            ExportToCsv.Run();

            //  Import from custom CSV
            ImportFromCsv.Run();
        }
    }
}
