using EdiFabric.Examples.X12.Common;

namespace EdiFabric.Examples.X12.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
