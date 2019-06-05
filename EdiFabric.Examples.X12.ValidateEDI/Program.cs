namespace EdiFabric.Examples.X12.ValidateEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Validate custom EDI codes
            ValidateCustomEDICodes.Run();

            //  Validate transactions after reading
            ValidateEDITransationsAfterRead.Run();

            //  Validate transactions before writing them out
            ValidateEDITransationsBeforeWrite.Run();

            //  Validate transactions with custom code
            ValidateEDITransationsWithCustomCode.Run();

            //  Validate control segments, ISA and GS
            ValidateISAorGS.Run();

            //  Validate sample transactions
            Validate810.Run();
            Validate850.Run();
            Validate837P.Run();
        }
    }
}
