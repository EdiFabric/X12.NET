namespace EdiFabric.Sdk.X12.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.WriteSingleInvoiceToStream();
            Examples.WriteSingleInvoiceToFile();
            Examples.WriteWithCustomSeparators();
            Examples.WriteWithSegmetPostfix();
            Examples.WriteMultipleInvoices();
            Examples.WriteMultipleGroups();
            Examples.WriteMultipleInterchanges();
            Examples.WriteSegmentWithWhitespace();
            Examples.WriteSinglePurchaseOrderToStream();
            Examples.WriteWithoutEnvelopes();
        }
    }
}
