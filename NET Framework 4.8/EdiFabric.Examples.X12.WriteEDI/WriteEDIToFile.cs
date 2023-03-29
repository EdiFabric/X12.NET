﻿using System.Diagnostics;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIToFile
    {
        /// <summary>
        /// Generate and write EDI document to a file
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = SegmentBuilders.BuildInvoice("1");

            //  2.  Write directly to a file
            //  Change the path to a file on your machine
            using (var writer = new X12Writer(@"C:\Test\Output.txt", false))
            {
                writer.Write(SegmentBuilders.BuildIsa("1"));
                writer.Write(SegmentBuilders.BuildGs("1"));
                writer.Write(invoice);
            }

            Debug.WriteLine("Written to file.");
        }
    }
}
