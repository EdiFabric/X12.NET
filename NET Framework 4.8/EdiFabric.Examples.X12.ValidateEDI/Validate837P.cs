﻿using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class Validate837P
    {
        /// <summary>
        /// Validate 837 P
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Hipaa\ClaimPayment.txt");

            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
                ediItems = reader.ReadToEnd().ToList();

            var claims = ediItems.OfType<TS837P>();

            foreach (var claim in claims)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!claim.IsValid(out errorContext))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  claim is valid, handle it downstream
                }
            }
        }
    }
}
