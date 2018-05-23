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
    public class AMT
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string AMT01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string AMT02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string AMT03 { get; set; }
    }
    
    [Serializable()]
    public class BHT
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string BHT01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string BHT02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string BHT03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string BHT04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string BHT05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string BHT06 { get; set; }
    }
    
    [Serializable()]
    public class CAS
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CAS01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CAS02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CAS03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CAS04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CAS05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CAS06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CAS07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CAS08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CAS09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CAS10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string CAS11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string CAS12 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string CAS13 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string CAS14 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string CAS15 { get; set; }
        [XmlIgnore]
        [Pos(16)]
        public string CAS16 { get; set; }
        [XmlIgnore]
        [Pos(17)]
        public string CAS17 { get; set; }
        [XmlIgnore]
        [Pos(18)]
        public string CAS18 { get; set; }
        [XmlIgnore]
        [Pos(19)]
        public string CAS19 { get; set; }
    }
    
    [Serializable()]
    public class CLM
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CLM01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CLM02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CLM03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CLM04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public C023 CLM05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CLM06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CLM07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CLM08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CLM09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CLM10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public C024 CLM11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string CLM12 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string CLM13 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string CLM14 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string CLM15 { get; set; }
        [XmlIgnore]
        [Pos(16)]
        public string CLM16 { get; set; }
        [XmlIgnore]
        [Pos(17)]
        public string CLM17 { get; set; }
        [XmlIgnore]
        [Pos(18)]
        public string CLM18 { get; set; }
        [XmlIgnore]
        [Pos(19)]
        public string CLM19 { get; set; }
        [XmlIgnore]
        [Pos(20)]
        public string CLM20 { get; set; }
    }
    
    [Serializable()]
    public class CN1
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CN101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CN102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CN103 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CN104 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CN105 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CN106 { get; set; }
    }
    
    [Serializable()]
    public class CR1
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CR101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CR102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CR103 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CR104 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CR105 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CR106 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CR107 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CR108 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CR109 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CR110 { get; set; }
    }
    
    [Serializable()]
    public class CR2
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CR201 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CR202 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CR203 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CR204 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CR205 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CR206 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CR207 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CR208 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CR209 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CR210 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string CR211 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string CR212 { get; set; }
    }
    
    [Serializable()]
    public class CR3
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CR301 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CR302 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CR303 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CR304 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CR305 { get; set; }
    }
    
    [Serializable()]
    public class CRC
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CRC01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CRC02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CRC03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CRC04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CRC05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CRC06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CRC07 { get; set; }
    }
    
    [Serializable()]
    public class CTP
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CTP01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CTP02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CTP03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CTP04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public C001 CTP05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CTP06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CTP07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CTP08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CTP09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CTP10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string CTP11 { get; set; }
    }
    
    [Serializable()]
    public class CUR
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string CUR01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string CUR02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string CUR03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string CUR04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string CUR05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string CUR06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string CUR07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string CUR08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string CUR09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string CUR10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string CUR11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string CUR12 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string CUR13 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string CUR14 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string CUR15 { get; set; }
        [XmlIgnore]
        [Pos(16)]
        public string CUR16 { get; set; }
        [XmlIgnore]
        [Pos(17)]
        public string CUR17 { get; set; }
        [XmlIgnore]
        [Pos(18)]
        public string CUR18 { get; set; }
        [XmlIgnore]
        [Pos(19)]
        public string CUR19 { get; set; }
        [XmlIgnore]
        [Pos(20)]
        public string CUR20 { get; set; }
        [XmlIgnore]
        [Pos(21)]
        public string CUR21 { get; set; }
    }
    
    [Serializable()]
    public class DMG
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string DMG01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string DMG02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string DMG03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string DMG04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public List<C056> DMG05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string DMG06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string DMG07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string DMG08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string DMG09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string DMG10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string DMG11 { get; set; }
    }
    
    [Serializable()]
    public class DTP
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string DTP01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string DTP02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string DTP03 { get; set; }
    }
    
    [Serializable()]
    public class FRM
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string FRM01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string FRM02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string FRM03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string FRM04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string FRM05 { get; set; }
    }
    
    [Serializable()]
    public class HCP
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string HCP01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string HCP02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string HCP03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string HCP04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string HCP05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string HCP06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string HCP07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string HCP08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string HCP09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string HCP10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string HCP11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string HCP12 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string HCP13 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string HCP14 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string HCP15 { get; set; }
    }
    
    [Serializable()]
    public class HI
    {
        
        [XmlIgnore]
        [Pos(1)]
        public C022 HI01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public C022 HI02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public C022 HI03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public C022 HI04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public C022 HI05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public C022 HI06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public C022 HI07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public C022 HI08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public C022 HI09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public C022 HI10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public C022 HI11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public C022 HI12 { get; set; }
    }
    
    [Serializable()]
    public class HL
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string HL01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string HL02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string HL03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string HL04 { get; set; }
    }
    
    [Serializable()]
    public class K3
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string K301 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string K302 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public C001 K303 { get; set; }
    }
    
    [Serializable()]
    public class LIN
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string LIN01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string LIN02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string LIN03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string LIN04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string LIN05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string LIN06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string LIN07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string LIN08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string LIN09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string LIN10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string LIN11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string LIN12 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string LIN13 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string LIN14 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string LIN15 { get; set; }
        [XmlIgnore]
        [Pos(16)]
        public string LIN16 { get; set; }
        [XmlIgnore]
        [Pos(17)]
        public string LIN17 { get; set; }
        [XmlIgnore]
        [Pos(18)]
        public string LIN18 { get; set; }
        [XmlIgnore]
        [Pos(19)]
        public string LIN19 { get; set; }
        [XmlIgnore]
        [Pos(20)]
        public string LIN20 { get; set; }
        [XmlIgnore]
        [Pos(21)]
        public string LIN21 { get; set; }
        [XmlIgnore]
        [Pos(22)]
        public string LIN22 { get; set; }
        [XmlIgnore]
        [Pos(23)]
        public string LIN23 { get; set; }
        [XmlIgnore]
        [Pos(24)]
        public string LIN24 { get; set; }
        [XmlIgnore]
        [Pos(25)]
        public string LIN25 { get; set; }
        [XmlIgnore]
        [Pos(26)]
        public string LIN26 { get; set; }
        [XmlIgnore]
        [Pos(27)]
        public string LIN27 { get; set; }
        [XmlIgnore]
        [Pos(28)]
        public string LIN28 { get; set; }
        [XmlIgnore]
        [Pos(29)]
        public string LIN29 { get; set; }
        [XmlIgnore]
        [Pos(30)]
        public string LIN30 { get; set; }
        [XmlIgnore]
        [Pos(31)]
        public string LIN31 { get; set; }
    }
    
    [Serializable()]
    public class LQ
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string LQ01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string LQ02 { get; set; }
    }
    
    [Serializable()]
    public class LX
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string LX01 { get; set; }
    }
    
    [Serializable()]
    public class MEA
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string MEA01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string MEA02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string MEA03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public C001 MEA04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string MEA05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string MEA06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string MEA07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string MEA08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string MEA09 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string MEA10 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string MEA11 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string MEA12 { get; set; }
    }
    
    [Serializable()]
    public class MOA
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string MOA01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string MOA02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string MOA03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string MOA04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string MOA05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string MOA06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string MOA07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string MOA08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string MOA09 { get; set; }
    }
    
    [Serializable()]
    public class N3
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string N301 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string N302 { get; set; }
    }
    
    [Serializable()]
    public class N4
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string N401 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string N402 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string N403 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string N404 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string N405 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string N406 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string N407 { get; set; }
    }
    
    [Serializable()]
    public class NM1
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string NM101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string NM102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string NM103 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string NM104 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string NM105 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string NM106 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string NM107 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string NM108 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string NM109 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string NM110 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string NM111 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string NM112 { get; set; }
    }
    
    [Serializable()]
    public class NTE
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string NTE01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string NTE02 { get; set; }
    }
    
    [Serializable()]
    public class OI
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string OI01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string OI02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string OI03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string OI04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string OI05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string OI06 { get; set; }
    }
    
    [Serializable()]
    public class PAT
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string PAT01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string PAT02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string PAT03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string PAT04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string PAT05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string PAT06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string PAT07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string PAT08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string PAT09 { get; set; }
    }
    
    [Serializable()]
    public class PER
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string PER01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string PER02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string PER03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string PER04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string PER05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string PER06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string PER07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string PER08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string PER09 { get; set; }
    }
    
    [Serializable()]
    public class PRV
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string PRV01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string PRV02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string PRV03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string PRV04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public C035 PRV05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string PRV06 { get; set; }
    }
    
    [Serializable()]
    public class PS1
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string PS101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string PS102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string PS103 { get; set; }
    }
    
    [Serializable()]
    public class PWK
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string PWK01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string PWK02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string PWK03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string PWK04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string PWK05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string PWK06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string PWK07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public C002 PWK08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string PWK09 { get; set; }
    }
    
    [Serializable()]
    public class QTY
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string QTY01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string QTY02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public C001 QTY03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string QTY04 { get; set; }
    }
    
    [Serializable()]
    public class REF
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string REF01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string REF02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string REF03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public C040 REF04 { get; set; }
    }
    
    [Serializable()]
    public class SBR
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string SBR01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string SBR02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string SBR03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string SBR04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string SBR05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string SBR06 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string SBR07 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string SBR08 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string SBR09 { get; set; }
    }
    
    [Serializable()]
    public class SV1
    {
        
        [XmlIgnore]
        [Pos(1)]
        public C003 SV101 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string SV102 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string SV103 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string SV104 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string SV105 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string SV106 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public C004 SV107 { get; set; }
        [XmlIgnore]
        [Pos(8)]
        public string SV108 { get; set; }
        [XmlIgnore]
        [Pos(9)]
        public string SV109 { get; set; }
        [XmlIgnore]
        [Pos(10)]
        public string SV110 { get; set; }
        [XmlIgnore]
        [Pos(11)]
        public string SV111 { get; set; }
        [XmlIgnore]
        [Pos(12)]
        public string SV112 { get; set; }
        [XmlIgnore]
        [Pos(13)]
        public string SV113 { get; set; }
        [XmlIgnore]
        [Pos(14)]
        public string SV114 { get; set; }
        [XmlIgnore]
        [Pos(15)]
        public string SV115 { get; set; }
        [XmlIgnore]
        [Pos(16)]
        public string SV116 { get; set; }
        [XmlIgnore]
        [Pos(17)]
        public string SV117 { get; set; }
        [XmlIgnore]
        [Pos(18)]
        public string SV118 { get; set; }
        [XmlIgnore]
        [Pos(19)]
        public string SV119 { get; set; }
        [XmlIgnore]
        [Pos(20)]
        public string SV120 { get; set; }
        [XmlIgnore]
        [Pos(21)]
        public string SV121 { get; set; }
    }
    
    [Serializable()]
    public class SV5
    {
        
        [XmlIgnore]
        [Pos(1)]
        public C003 SV501 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string SV502 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public string SV503 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string SV504 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string SV505 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string SV506 { get; set; }
        [XmlIgnore]
        [Pos(7)]
        public string SV507 { get; set; }
    }
    
    [Serializable()]
    public class SVD
    {
        
        [XmlIgnore]
        [Pos(1)]
        public string SVD01 { get; set; }
        [XmlIgnore]
        [Pos(2)]
        public string SVD02 { get; set; }
        [XmlIgnore]
        [Pos(3)]
        public C003 SVD03 { get; set; }
        [XmlIgnore]
        [Pos(4)]
        public string SVD04 { get; set; }
        [XmlIgnore]
        [Pos(5)]
        public string SVD05 { get; set; }
        [XmlIgnore]
        [Pos(6)]
        public string SVD06 { get; set; }
    }
}
