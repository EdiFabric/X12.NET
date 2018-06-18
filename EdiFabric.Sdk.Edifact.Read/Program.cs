namespace EdiFabric.Sdk.Edifact.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.ReadAllPurchaseOrders();
            Examples.ReadPurchaseOrdersOneAtATime();
            Examples.ReadCustomTemplate1();
            Examples.ReadCustomTemplate2();
            Examples.ReadWithSplitting();
            Examples.CrossSegmentValidation();
            Examples.ValidateControlSegments();
            Examples.ReadMixedTransactions();
            Examples.ReadCorruptUnb();
            Examples.ReadWithContinueOnError();
        }
    }
}
