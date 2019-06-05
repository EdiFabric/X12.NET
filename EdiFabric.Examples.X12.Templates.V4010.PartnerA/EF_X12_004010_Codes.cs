using EdiFabric.Core.Annotations.Edi;
using System;
using System.Runtime.Serialization;

namespace EdiFabric.Examples.X12.Templates.V4010.PartnerA
{
    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PA,PB,")]
    public class X12_ID_353_PartnerA
    {
    }
}
