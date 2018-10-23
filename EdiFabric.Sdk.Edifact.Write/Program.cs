namespace EdiFabric.Sdk.Edifact.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.WriteSingleInvoiceToStream();
            Examples.WriteSingleInvoiceToStreamAsync();
            Examples.WriteSingleInvoiceToFile();
            Examples.WriteWithCustomSeparators();
            Examples.WriteWithSegmetPostfix();
            Examples.WriteMultipleInvoices();
            Examples.WriteMultipleGroups();
            Examples.WriteMultipleInterchanges();
            Examples.WriteSegmentWithWhitespace();
            Examples.WriteSinglePurchaseOrderToStream();
            Examples.WriteWithoutEnvelopes();
            Examples.WriteWithoutAutoTrailers();
        }
    }
}
