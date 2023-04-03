using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileWithTemplateResolution
    {
        /// <summary>
        /// Reads the EDI stream from start to end using assembly factory. Allows you to dynamically specify a separate assembly to be used for parsing.
        /// </summary>
        public static void RunWithAssemblyFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, AssemblyFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TS850>();
        }

        public static Assembly AssemblyFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "004010")
                return Assembly.Load("EdiFabric.Templates.X12");

            throw new Exception(string.Format("Version {0} is not supported.", messageContext.Version));
        }

        /// <summary>
        /// Reads the EDI stream from start to end using type factory. Allows you to dynamically specify the exact template to be used for parsing.
        /// </summary>
        public static void RunWithTypeFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TS850>();
        }

        public static TypeInfo TypeFactory(ISA isa, GS gs, ST st)
        {
            if (gs.VersionAndRelease_8 == "004010" &&
                 st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850).GetTypeInfo();

            if (gs.VersionAndRelease_8 == "004010" &&
                  st.TransactionSetIdentifierCode_01 == "810")
                return typeof(TS810).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, gs.VersionAndRelease_8));
        }
    }
}
