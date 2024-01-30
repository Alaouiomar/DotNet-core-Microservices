using AutoMapper;
using Microservices.Services.ShoppingCartAPI.Models.Dto;
using Microservices.Services.ShoppingCartAPI.Models;

namespace Microservices.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
            
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();

            });
            return mappingconfig;
        }
    }
}
