using AutoMapper;

namespace DocGenerationAPI2.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile() 
        {
            CreateMap<Entites.Client,Models.ClientDto>();

            CreateMap<Entites.Invoice, Models.InvoiceDto>();
            CreateMap<Entites.InvoiceLine, Models.InvoiceLineDto>();
            CreateMap<Entites.Service, Models.ServiceDto>();
        }
    }
}
