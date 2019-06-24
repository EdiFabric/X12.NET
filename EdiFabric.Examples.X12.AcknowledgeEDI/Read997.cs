using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Core.Model.Edi;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
{
    class Read997
    {
        /// <summary>
        /// Reads 997 using EdiFabric.Core.Model.Edi.X12.TS997
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\997.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var ack997 = ediItems.OfType<TS997>();
        }

        public static TypeInfo TypeFactory(ISA isa, GS gs, ST st)
        {
            if (st.TransactionSetIdentifierCode_01 == "997")
                return typeof(TS997).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, gs.VersionAndRelease_8));
        }
    }
}
