using AutoMapper;

namespace DocGenerationAPI2.Profiles
{
    public class InvoiceProfile:Profile

    {
        public InvoiceProfile()
        {
            CreateMap<Entites.Invoice, Models.InvoiceDto>();
            CreateMap<Entites.InvoiceLine, Models.InvoiceLineDto>();
            CreateMap<Entites.Service, Models.ServiceDto>();

            CreateMap<Models.InvoiceDto,Entites.Invoice>();
            CreateMap<Models.InvoiceLineDto, Entites.InvoiceLine>();
            CreateMap<Models.ServiceDto, Entites.Service>();
        }
    }
}
