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
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hipaa5010;

namespace EdiFabric.Examples.X12.ReadEDI
{
    class ReadCustomTransaction
    {
        /// <summary>
        /// Reads a partner-specific transaction.
        /// The 835 EDI templates is changed to allow an additional EDI code in the first data element of SVC
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\Custom835.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, (ISA isa, GS gs, ST st) => typeof(TS835_Custom).GetTypeInfo()))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the custom transactions
            var custom835 = ediItems.OfType<TS835_Custom>();
        }
    }

    /// <summary>
    /// Create a custom version of the EDI template
    /// </summary>
    public class TS835_Custom : TS835
    {
        [DataMember]
        [Pos(8)]
        public new List<Loop_2000_835_Custom> Loop2000 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX_HeaderNumber))]
    public class Loop_2000_835_Custom : Loop_2000_835
    {
        [DataMember]
        [Required]
        [Pos(4)]
        public new List<Loop_2100_835_Custom> Loop2100 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(CLP_ClaimPaymentInformation))]
    public class Loop_2100_835_Custom : Loop_2100_835
    {
        [DataMember]
        [ListCount(999)]
        [Pos(11)]
        public new List<Loop_2110_835_Custom> Loop2110 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(SVC_ServicePaymentInformation_Custom))]
    public class Loop_2110_835_Custom : Loop_2110_835
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public new SVC_ServicePaymentInformation_Custom SVC_ServicePaymentInformation { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Segment("SVC", typeof(X12_ID_235_15_Custom))]
    public class SVC_ServicePaymentInformation_Custom : SVC_ServicePaymentInformation
    {

    }

    /// <summary>
    /// Specify a custom code for the first data element in SVC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,ER,HC,HP,IV,N4,N6,NU,UI,WK,MY_CUSTOM_CODE,")]
    public class X12_ID_235_15_Custom
    {
    }
}
