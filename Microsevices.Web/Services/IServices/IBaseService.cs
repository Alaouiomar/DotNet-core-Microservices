using Microservices.Web.Models;
using Microsevices.Web.Models;

namespace Microsevices.Web.Services.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDTO, bool withBearer = true);
      
    }
}
