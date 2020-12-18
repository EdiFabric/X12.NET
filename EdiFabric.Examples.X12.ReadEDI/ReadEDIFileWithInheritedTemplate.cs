using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileWithInheritedTemplate
    {
        /// <summary>
        /// Reads EDI file into a custom, partner-specific template. 
        /// Compare the files in EdiFabric.Examples.X12.Templates.V4010.PartnerC to the standard template in EdiFabric.Examples.X12.Templates.V4010
        /// and the base template in EdiFabric.Examples.X12.Templates.V4010.PartnerB for changes.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrderCustom2.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, (ISA isa, GS gs, ST st) => typeof(TS850PartnerC).GetTypeInfo(), new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TS850PartnerC>();
        }
    }

    [Serializable()]
    [Message("X12", "004010", "850")]
    public class TS850PartnerC : TS850
    {
        [ListCount(200)]
        [Pos(34)]
        public new List<TS850_N1Loop1PartnerC> N1Loop { get; set; }
    }

    [Serializable()]
    [Group(typeof(N1))]
    public class TS850_N1Loop1PartnerC : Loop_N1_850
    {
        //  Swap the positions of N2 and N3
        [ListCount(2)]
        [Pos(3)]
        public new List<N2PartnerC> N2 { get; set; }

        [ListCount(2)]
        [Pos(2)]
        public new List<N3> N3 { get; set; }
    }

    [Serializable()]
    [Segment("N2")]
    public class N2PartnerC : N2
    {
        //  Change the validation attribute and data element type at position 1
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_N0))]
        [Pos(1)]
        public new string Name_01 { get; set; }

        //  Add extra field
        [StringLength(1, 60)]
        [DataElement("94", typeof(X12_AN))]
        [Pos(3)]
        public string ExtraName_03 { get; set; }
    }
}
