using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(TrialLicense.SerialKey);

            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
