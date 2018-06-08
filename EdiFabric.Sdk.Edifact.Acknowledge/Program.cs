namespace EdiFabric.Sdk.Edifact.Acknowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.GenerateContrlForValid();
            Examples.GenerateContrlForInvalid();
            Examples.GenerateContrlWithDuplicateMessage();
            Examples.GenerateContrlWithDuplicateGroup();
            Examples.GenerateContrlWithDuplicateInterchange();
            Examples.GenerateContrlWithControlNumbers();
        }
    }
}
