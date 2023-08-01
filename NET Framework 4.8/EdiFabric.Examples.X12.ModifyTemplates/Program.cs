using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12;

namespace EdiFabric.Examples.X12.ModifyTemplates
{
    /// <summary>
    /// Reads both standard purchase order and modified purchase order.
    /// The modified template is in project EdiFabric.Examples.X12.Templates
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            // Parse 850
            ParsePO(Config.TestFilesPath + @"\X12\PurchaseOrder.txt");

            //  Parse modified 850 
            ParseModifiedPO(Config.TestFilesPath + @"\X12\PurchaseOrderModified.txt");
        }

        public static void ParsePO(string ediFile)
        {
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + ediFile);

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();
        }

        public static void ParseModifiedPO(string ediFile)
        {
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + ediFile);

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, ModifiedTypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var modifiedPurchaseOrders = ediItems.OfType<TS850Modified>();
        }

        public static TypeInfo TypeFactory(ISA isa, GS gs, ST st)
        {
            if (gs.VersionAndRelease_8 == "004010" &&
                 st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, gs.VersionAndRelease_8));
        }

        public static TypeInfo ModifiedTypeFactory(ISA isa, GS gs, ST st)
        {
            if (gs.VersionAndRelease_8 == "004010" &&
                 st.TransactionSetIdentifierCode_01 == "850")
                return typeof(TS850Modified).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                st.TransactionSetIdentifierCode_01, gs.VersionAndRelease_8));
        }
    }
}
