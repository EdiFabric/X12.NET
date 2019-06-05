namespace EdiFabric.Examples.X12.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
