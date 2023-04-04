namespace EdiFabric.Examples.X12.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\..\..\..\NET Framework 4.8\EdiFabric.Examples.X12.MapEDI\";
        public static string SerialKeyPath = @"../../../../../../edifabric/serial.key";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\";
        public static string SerialKeyPath = @"../../../../../edifabric/serial.key";
#endif

    }
}
