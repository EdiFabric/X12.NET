using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Hipaa5010;
using System.Text;

namespace EdiFabric.Examples.EFCore.X12.TS837P
{
    class Program
    {
        //  IMPORTANT!!!
        //  Before you run this you need to create a database
        //  Set this project to be the Startup Project and then open the Package Manager Console from Tools->NuGet Package Manager-> Package Manager Console
        //  In Package Manager Console select the Default Project to be this one
        //  Create the database with migrations in two steps:
        //  1. PM> Add-Migration InitialCreate
        //  2. PM> Update-Database
        //  The connection string is in EF_HIPAA_005010_837P_DbContext.cs, and is set to the local instance of SQL Server
        static void Main(string[] args)
        {
            SerialKey.Set(GetSerial());

            var path = Directory.GetCurrentDirectory() + @"\..\..\..\ClaimPayment.txt";
            Stream ediStream = File.OpenRead(path);

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream))
                ediItems = ediReader.ReadToEnd().ToList();

            var tran = ediItems.OfType<Templates.Hipaa5010.TS837P>().Single();

            Save837P(tran);
            var edi = Pull837P(ediItems);

            Console.ReadKey();
        }

        public static void Save837P(Templates.Hipaa5010.TS837P tran)
        {
            using (var db = new HIPAA_5010_837P_Context())
            {
                tran.ClearCache();
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
                        using (var writer = new X12Writer(stream, new X12WriterSettings { Postfix = Environment.NewLine, Separators = sep }))
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

        public static string GetSerial()
        {
            var serialKeyPath = @"../../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the correct path to the serial.key file!");

            return File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }
    }
}
