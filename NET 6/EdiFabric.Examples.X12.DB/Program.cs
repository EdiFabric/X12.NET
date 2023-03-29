using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004010;
using System.Text;

namespace EdiFabric.Examples.EFCore.X12.TS850
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
        //  The connection string is in EF_X12_004010_DbContext.cs, and is set to the local instance of SQL Server
        static void Main(string[] args)
        {
            SerialKey.Set(GetSerial());

            var path = Directory.GetCurrentDirectory() + @"\..\..\..\PurchaseOrder.txt";
            Stream ediStream = File.OpenRead(path);

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var tran = ediItems.OfType<Templates.X12004010.TS850>().Single();

            Save850(tran);
            var edi = Pull850(ediItems);

            Console.ReadKey();
        }

        public static void Save850(Templates.X12004010.TS850 tran)
        {
            using (var db = new X12Context())
            {
                tran.ClearCache();
                db.TS850.Add(tran);
                db.SaveChanges();
            }
        }

        public static string Pull850(List<IEdiItem> ediItems)
        {
            using (var db = new X12Context())
            {
                var tran = db.TS850.FirstOrDefault();
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
