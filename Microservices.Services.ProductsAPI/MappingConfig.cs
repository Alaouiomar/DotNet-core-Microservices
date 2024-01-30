using AutoMapper;
using Microservices.Services.ProductAPI.Models.Dto;
using Microservices.Services.ProductAPI.Models;

namespace Microservices.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingconfig;
        }
    }
}
