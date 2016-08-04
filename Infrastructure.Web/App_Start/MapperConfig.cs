using AutoMapper;
using DomainModel.Entities;
using Infrastructure.Web.Dtos;

namespace Infrastructure.Web.App_Start
{
    public class MapperConfig
    {
        public static void ConfigureMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<QuoteItem, QuoteItemDto>();
                cfg.CreateMap<Quote, QuoteDto>();
            });
        }
    }
}