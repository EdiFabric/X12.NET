using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileWithCustomISAorGS
    {
        /// <summary>
        /// Read with custom ISA or GS.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrders.txt");

            //  Use the base X12ReaderBase instead of X12Reader
            List<IEdiItem> ediItems;
            using (var ediReader = new X12ReaderBase<ISACustom, GSCustom>(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var isa = ediItems.OfType<ISACustom>();
            var gs = ediItems.OfType<GSCustom>();
        }
    }

    public class ISACustom : ISA
    {
    }

    public class GSCustom : GS
    {
    }
}
