namespace EdiFabric.Sdk.X12.Acknowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.Generate999ForValid();
            Examples.Generate997ForValid();
            Examples.Generate999ForInvalid();
            Examples.Generate997WithDuplicateMessage();
            Examples.Generate997WithDuplicateGroup();
            Examples.Generate997WithDuplicateInterchange();
            Examples.Generate997WithControlNumbers();
            Examples.GenerateCustom999();
        }
    }
}
