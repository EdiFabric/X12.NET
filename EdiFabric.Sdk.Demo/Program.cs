using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Edifact;
using EdiFabric.Templates.Hipaa5010;
using EdiFabric.Templates.X12;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EdiFabric.Sdk.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  To translate your own EDI files, simply change the path to point to your file
            //  The Demo supports all transactions for X12 004010, HIPAA 005010 and EDIFACT D96A

            //  Read X12 file
            //  var x12Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\X12004010PurchaseOrders.txt");
            var x12Stream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\X12004010Invoice.txt");
            List<IEdiItem> x12Items;
            using (var ediReader = new X12Reader(x12Stream, LoadFactory, Encoding.UTF8, true))
                x12Items = ediReader.ReadToEnd().ToList();

            var x12Transactions = x12Items.OfType<TS810>();

            //  Read HIPAA file
            //  var hipaaStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\Hipaa005010BenefitEnrollment.txt");
            var hipaaStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\Hipaa005010ClaimPayment.txt");
            List<IEdiItem> hipaaItems;
            using (var ediReader = new X12Reader(hipaaStream, LoadFactory, Encoding.UTF8, true))
                hipaaItems = ediReader.ReadToEnd().ToList();

            var hipaaTransactions = hipaaItems.OfType<TS837P>();

            //  Read EDIFACT files
            //  var edifactStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\EdifactD96APurchaseOrder.txt");
            var edifactStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files.Demo\EdifactD96AInvoic.txt");
            List<IEdiItem> edifactItems;
            using (var ediReader = new EdifactReader(edifactStream, LoadFactory, Encoding.UTF8, true))
                edifactItems = ediReader.ReadToEnd().ToList();

            var edifactTransactions = edifactItems.OfType<TSINVOIC>();
        }

        static Assembly LoadFactory(MessageContext mc)
        {
            if (mc.Format.Equals("X12", StringComparison.Ordinal))
            {
                if (mc.Version.StartsWith("005010X2", StringComparison.Ordinal))
                    return Assembly.Load("EdiFabric.Templates.Hipaa");

                return Assembly.Load("EdiFabric.Templates.X12");
            }

            if (mc.Format.Equals("EDIFACT", StringComparison.Ordinal))
                return Assembly.Load("EdiFabric.Templates.Edifact");

            throw new Exception(string.Format("Transaction is not supported: Format {0} Version {1} Transaction ID {2} .", mc.Format, mc.Version, mc.Name));
        }
    }
}
