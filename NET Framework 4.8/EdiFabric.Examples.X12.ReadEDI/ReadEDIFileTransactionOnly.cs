using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileTransactionOnly
    {
        /// <summary>
        /// Reads file without envelopes - no ISA, GS, GE or IEA
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\X12\MixedTransactionsNoEnvelopes.txt");

            //  Set the NoEnvelope flag to true
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TypeFactory, new X12ReaderSettings() { NoEnvelope = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            var items = ediItems.OfType<EdiMessage>();
            foreach (var item in items)
            {
            }
        }

        public static TypeInfo TypeFactory(ISA isa, GS gs, ST st)
        {
            if ( st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850).GetTypeInfo();

            if (st.TransactionSetIdentifierCode_01 == "810")
                return typeof(TS810).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} is not supported.", st.TransactionSetIdentifierCode_01));
        }
    }
}
