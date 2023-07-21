using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Validate custom EDI codes
            //ValidateCustomEDICodes.Run();
            //ValidateCustomEDICodes.Run2();

            //  Validate transactions after reading
            ValidateEDITransationsAfterRead.Run();

            //  Validate transactions before writing them out
            ValidateEDITransationsBeforeWrite.Run();

            //  Validate transactions with custom code
            ValidateEDITransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Basic();
            ValidateDataElementTypes.Extended();

            //  Validate control segments, ISA and GS
            ValidateISAorGS.Run();

            //  Validate sample transactions
            Validate810.Run();
            Validate850.Run();
            Validate837P.Run();

            //  Validate async
            ValidateEDITransationsAsync.Run();
        }
    }
}
