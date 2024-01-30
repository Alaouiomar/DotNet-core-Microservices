using Microservices.Web.Models;

namespace Microsevices.Web.Services.IServices
{
    public interface IProductService
    {
     
         Task<ResponseDto?> GetAllProductAsync();
         Task<ResponseDto?> GetProductByIdAsync(int id);
         Task<ResponseDto?> CreateProductAsync(ProductDto productDto);
         Task<ResponseDto?> UpdateProductAsync(ProductDto productDto);
         Task<ResponseDto?> DeleteProductAsync(int id);
    }
}
