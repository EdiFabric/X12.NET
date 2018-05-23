namespace EdiFabric.Rules.HIPAA_5010
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    public class C001
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C00101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C00102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C00103 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C00104 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C00105 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string C00106 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string C00107 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string C00108 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string C00109 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string C00110 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string C00111 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string C00112 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string C00113 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string C00114 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string C00115 { get; set; }
    }
    
    [Serializable()]
    public class C002
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C00201 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C00202 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C00203 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C00204 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C00205 { get; set; }
    }
    
    [Serializable()]
    public class C003
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C00301 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C00302 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C00303 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C00304 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C00305 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string C00306 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string C00307 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string C00308 { get; set; }
    }
    
    [Serializable()]
    public class C004
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C00401 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C00402 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C00403 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C00404 { get; set; }
    }
    
    [Serializable()]
    public class C022
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C02201 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C02202 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C02203 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C02204 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C02205 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string C02206 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string C02207 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string C02208 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string C02209 { get; set; }
    }
    
    [Serializable()]
    public class C023
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C02301 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C02302 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C02303 { get; set; }
    }
    
    [Serializable()]
    public class C024
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C02401 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C02402 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C02403 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C02404 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C02405 { get; set; }
    }
    
    [Serializable()]
    public class C035
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C03501 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C03502 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C03503 { get; set; }
    }
    
    [Serializable()]
    public class C040
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C04001 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C04002 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C04003 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string C04004 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string C04005 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string C04006 { get; set; }
    }
    
    [Serializable()]
    public class C056
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string C05601 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string C05602 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string C05603 { get; set; }
    }
}
