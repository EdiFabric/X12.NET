using EdiFabric.Core.Model.Edi;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EdiFabric.Sdk.Helpers
{
    public class XmlHelpers
    {
        public static XDocument Serialize(EdiMessage instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var serializer = new XmlSerializer(instance.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static T Deserialize<T>(XElement xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(xml.CreateReader());
        }
    }
}
