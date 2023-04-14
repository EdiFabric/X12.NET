using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Dex;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadDEXFile
    {
        /// <summary>
        /// Reads the EDI stream from start to end.
        /// This method loads the file into memory. Do not use for large files. 
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\DEX\DEX_894.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new DexReader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var messages = ediItems.OfType<TS894>();           
        }

        public static TypeInfo TypeFactory(DXS dxs, ST st)
        {
            if (st.TransactionSetIdentifierCode_01 == "894")
                return typeof(TS894).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, dxs.Version_3));
        }
    }
}
