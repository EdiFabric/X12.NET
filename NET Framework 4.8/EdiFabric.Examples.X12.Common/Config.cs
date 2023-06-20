namespace EdiFabric.Examples.X12.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\..\..\..\NET Framework 4.8\EdiFabric.Examples.X12.MapEDI\";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\";
#endif

    }
}
