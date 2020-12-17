using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

namespace EdiFabric.Examples.X12.MapEDI
{
    class EDIToCustomObjectWithAutoMapper
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Init the AutoMapper map
            //  Map by interface to reuse mapping 
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<TS850, PurchaseOrder>()
                        .ForPath(dest => dest.OrderLines, m => m.MapFrom(src => src.PO1Loop.Select(l => l.PO1)));

                    cfg.CreateMap<I_BEG, PurchaseOrder>()
                        .ForMember(dest => dest.RefNumber, m => m.MapFrom(src => src.PurchaseOrderNumber_03))
                        .ForMember(dest => dest.Date, m => m.MapFrom(src => src.Date_05.Substring(0, 4) + "-" + src.Date_05.Substring(4, 2) + "-" + src.Date_05.Substring(6, 2)));

                    cfg.CreateMap<I_N1, PurchaseOrder>()
                        .ForPath(dest => dest.Customer.RefNumber, m => m.MapFrom(src => src.IdentificationCode_04))
                        .ForPath(dest => dest.Customer.Name, m => m.MapFrom(src => src.Name_02));

                    cfg.CreateMap<I_N3, PurchaseOrder>()
                        .ForPath(dest => dest.Customer.AddressLine, m => m.MapFrom(src => src.AddressInformation_01));

                    cfg.CreateMap<I_N4, PurchaseOrder>()
                        .ForPath(dest => dest.Customer.City, m => m.MapFrom(src => src.CityName_01))
                        .ForPath(dest => dest.Customer.State, m => m.MapFrom(src => src.StateorProvinceCode_02))
                        .ForPath(dest => dest.Customer.PostCode, m => m.MapFrom(src => src.PostalCode_03));

                    cfg.CreateMap<I_PO1, OrderLine>()
                        .ForMember(dest => dest.LineNumber, m => m.MapFrom(src => src.AssignedIdentification_01))
                        .ForMember(dest => dest.UPCNumber, m => m.MapFrom(src => src.ProductServiceID_07))
                        .ForMember(dest => dest.Quantity, m => m.MapFrom(src => src.QuantityOrdered_02))
                        .ForMember(dest => dest.Price, m => m.MapFrom(src => src.UnitPrice_04))
                        .ForMember(dest => dest.UOM, m => m.MapFrom(src => src.UnitorBasisforMeasurementCode_03));
                }
            );

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\X12\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12", new X12ReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TS850>();
            foreach (var transaction in transactions)
            {
                var n1Loop = transaction.N1Loop.Where(n1 => n1.N1.EntityIdentifierCode_01 == "ST").Single();

                //  Transform each transaction
                PurchaseOrder customTransaction = Mapper.Map<TS850, PurchaseOrder>(transaction);
                customTransaction = Mapper.Map<I_BEG, PurchaseOrder>(transaction.BEG, customTransaction);
                customTransaction = Mapper.Map<I_N1, PurchaseOrder>(n1Loop.N1, customTransaction);
                customTransaction = Mapper.Map<I_N3, PurchaseOrder>(n1Loop.N3.First(), customTransaction);
                customTransaction = Mapper.Map<I_N4, PurchaseOrder>(n1Loop.N4.First(), customTransaction);
            }
        }
    }
}
