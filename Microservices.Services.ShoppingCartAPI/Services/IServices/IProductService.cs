using Microservices.Services.ShoppingCartAPI.Models.Dto;

namespace Microservices.Services.ShoppingCartAPI.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
