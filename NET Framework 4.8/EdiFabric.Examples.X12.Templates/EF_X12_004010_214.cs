namespace EdiFabric.Templates.X12004010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for Shipment Status Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AT7))]
    public class Loop_AT7_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT7 AT7 { get; set; }
        /// <summary>
        /// Equipment, Shipment, or Real Property Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MS1 MS1 { get; set; }
        /// <summary>
        /// Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MS2 MS2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Carton (Package) Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CD3))]
    public class Loop_CD3_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Carton (Package) Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CD3 CD3 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Loop for Shipment Status Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_AT7_214> AT7Loop { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        /// Shipment Weight, Packaging and Quantity Data
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AT8 AT8 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(8)]
        public virtual List<Loop_N1_214_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Carton (Package) Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CD3))]
    public class Loop_CD3_214_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Carton (Package) Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CD3 CD3 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Loop for Shipment Status Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_AT7_214> AT7Loop { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<MAN> MAN { get; set; }
    }
    
    /// <summary>
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Format Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EFI EFI { get; set; }
        /// <summary>
        /// Binary Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BIN BIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Loop for Shipment Status Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_AT7_214> AT7Loop { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Shipment Weight, Packaging and Quantity Data
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<AT8> AT8 { get; set; }
        /// <summary>
        /// Loop for Carton (Package) Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(9)]
        public virtual List<Loop_CD3_214> CD3Loop { get; set; }
        /// <summary>
        /// Loop for Purchase Order Reference
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(10)]
        public virtual List<Loop_PRF_214> PRFLoop { get; set; }
        /// <summary>
        /// Loop for Shipment Purchase Order Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(11)]
        public virtual List<Loop_SPO_214> SPOLoop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_EFI_214> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_214_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Purchase Order Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRF))]
    public class Loop_PRF_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<Loop_N1_214_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Carton (Package) Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(3)]
        public virtual List<Loop_CD3_214_2> CD3Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Shipment Purchase Order Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPO))]
    public class Loop_SPO_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Purchase Order Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPO SPO { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<SDQ> SDQ { get; set; }
    }
    
    /// <summary>
    /// Transportation Carrier Shipment Status Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "214")]
    public class TS214 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Transportation Carrier Shipment Status Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B10 B10 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_N1_214> N1Loop { get; set; }
        /// <summary>
        /// Interline Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<MS3> MS3 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(8)]
        public virtual List<Loop_LX_214> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
