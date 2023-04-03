using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadEDIFileSplitting
    {
        /// <summary>
        /// Split a message into parts (blocks of segments) and read each part individually.
        /// Use to process large transactions with repeating loops.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrderMultiLine.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, (ISA isa, GS gs, ST st) => typeof(TS850Splitter).GetTypeInfo(), new X12ReaderSettings { Split = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Find all N1 loops, they are all different ediItems
            var poLoop = ediItems.OfType<TS850Splitter>().Where(m => m.PO1Loop != null).SelectMany(m => m.PO1Loop);
            Debug.WriteLine(string.Format("PO parts {0}", poLoop.Count()));
        }

        /// <summary>
        /// Copy a message and remove unwanted parts.
        /// </summary>
        public static void RunWithCopy()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\..\Files\X12\PurchaseOrderMultiLine.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
                ediItems = ediReader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();
            var splitPurchaseOrders = new List<TS850>();

            foreach(var po in purchaseOrders)
            {
                foreach(var po1Loop in po.PO1Loop)
                {
                    var splitPO = po.Copy() as TS850;                    
                    splitPO.PO1Loop.RemoveAll(l => splitPO.PO1Loop.IndexOf(l) != po.PO1Loop.IndexOf(po1Loop));
                    splitPurchaseOrders.Add(splitPO);
                }                
            }

            foreach(var po in purchaseOrders)
                Debug.WriteLine(string.Format("Original: PO - PO1 parts {0}", po.PO1Loop.Count()));

            foreach (var po in splitPurchaseOrders)
                Debug.WriteLine(string.Format("Split: PO - PO1 parts {0}", po.PO1Loop.Count()));
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("X12", "004010", "850")]
    public class TS850Splitter : TS850
    {
        [Splitter]
        [DataMember]
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public new List<Loop_PO1_850> PO1Loop { get; set; }
    }
}
