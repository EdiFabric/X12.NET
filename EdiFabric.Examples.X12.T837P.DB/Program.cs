using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Examples.X12.T837P.DB
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\GitHub\X12-Examples\Files\HIPAA\ClaimPayment.txt";
            Stream ediStream = File.OpenRead(path);
            
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa", new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = ediReader.ReadToEnd().ToList();

            var tran = ediItems.OfType<TS837P>().Single();

            Save837P(tran);
            var edi = Pull837P(ediItems);
           
            Console.ReadKey();
        }

        public static void Save837P(TS837P tran)
        {
            using (var db = new HIPAA_5010_837P_Context())
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                db.Configuration.ValidateOnSaveEnabled = false;
                db.TS837P.Add(tran);
                db.SaveChanges();
            }
        }

        public static string Pull837P(List<IEdiItem> ediItems)
        {
            using (var db = new HIPAA_5010_837P_Context())
            {
                var tran = db.TS837P.FirstOrDefault();
                var sep = Separators.X12;
                sep.ComponentDataElement = ':';

                if (tran != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        using (var writer = new X12Writer(stream, new X12WriterSettings { Postfix = Environment.NewLine, Separators = sep, SerialNumber = TrialLicense.SerialNumber }))
                        {
                            writer.Write(ediItems.OfType<ISA>().Single());
                            writer.Write(ediItems.OfType<GS>().Single());
                            writer.Write(tran);
                        }

                        return LoadString(stream);
                    }
                }
            }

            return null;
        }

        public static string LoadString(Stream stream, Encoding encoding = null)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, encoding ?? Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
