using System.IO;
using System.Text;

namespace EdiFabric.Sdk.Helpers
{
    public class StreamHelpers
    {
        public static string LoadString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
