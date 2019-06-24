namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Generate 997 for valid group
            GenerateValid997.Run();

            //  Generate 997 for invalid group
            GenerateInvalid997.Run();

            //  Generate 997 for duplicates
            Generate997ForDuplicateTransaction.Run();
            Generate997ForDuplicateGroup.Run();
            Generate997ForDuplicateInterchange.Run();

            //  Generate 997 with explicit control numbers
            Generate997WithCustomControlNumbers.Run();

            Read997.Run();
        }
    }
}
