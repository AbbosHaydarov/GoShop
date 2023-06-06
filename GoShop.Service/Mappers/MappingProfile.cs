using AutoMapper;
using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.Markets;
using GoShop.Domain.Entities.ShtrixCodes;
using GoShop.Service.DTOs.Categories;
using GoShop.Service.DTOs.Markets;
using GoShop.Service.DTOs.ShtrixCodes;

namespace GoShop.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // category
            CreateMap<Category, CategoryDTO>().ReverseMap();

            //Market
            CreateMap<Market, MarketDTO>().ReverseMap();

            //Shtrix
            CreateMap<ShtrixCode, ShtrixCodeDTO>().ReverseMap();
        }
    }
}
