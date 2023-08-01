using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            //  Read EDI file to the end
            ReadEDIFileToEnd.Run();
            ReadEDIFileToEndAsync.Run();

            //  Read one item at a time
            ReadEDIFileStreaming.Run();
            ReadEDIFileStreamingAsync.Run();

            //  Read batches of transactions
            ReadEDIFileBatch.Run();

            //  Split transactions to repeating loops
            ReadEDIFileSplitting.Run();
            ReadEDIFileSplitting.RunWithCopy();

            //  Read EDI files with issues
            ReadEDIFileCorrupt.Run();
            ReadEDIFileWithErrors.Run();

            //  Read transaction only
            ReadEDIFileTransactionOnly.Run();

            //  Read using partner-specific template (inherited)
            ReadEDIFileWithInheritedTemplate.Run();

            //  Read using dynamic template resolution
            ReadEDIFileWithTemplateResolution.RunWithAssemblyFactory();
            ReadEDIFileWithTemplateResolution.RunWithTypeFactory();

            //  Read with custom ISA or GS
            ReadEDIFileWithCustomISAorGS.Run();

            //  Reads custom transaction
            ReadCustomTransaction.Run();

            //  Reads DEX file
            ReadDEXFile.Run();
        }
    }
}
