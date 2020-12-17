using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class ValidateISAorGS
    {
        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\Invoice.txt");

            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Examples.X12.Templates.V4010", new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
            {
                while (ediReader.Read())
                {
                    var isa = ediReader.Item as ISA;
                    if (isa != null)
                    {
                        //  Validate 
                        var isaErrors = isa.Validate();
                        //  Pull the sender id from ISA
                        var senderId = isa.InterchangeSenderID_6;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }

                    var gs = ediReader.Item as GS;
                    if (gs != null)
                    {
                        //  Validate 
                        var gsErrors = gs.Validate();
                        //  Pull the sender id from GS
                        var senderId = gs.SenderIDCode_2;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }
    }
}
