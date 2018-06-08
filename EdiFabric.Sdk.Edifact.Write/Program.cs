namespace EdiFabric.Sdk.Edifact.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples.WriteSingleInvoiceToStream();
            Examples.WriteSingleInvoiceToFile();
            Examples.WriteMultipleInvoices();
            Examples.WriteMultipleInterchanges();
            Examples.WriteSegmentWithWhitespace();
            Examples.WriteWithCustomSeparators();
            Examples.WriteWithUna();
        }
    }
}
