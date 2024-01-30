using Microservices.Web.Models;

namespace Microsevices.Web.Services.IServices
{
    public interface ICouponService
    {
         Task<ResponseDto?> GetCouponAsync(string CouponCode);
         Task<ResponseDto?> GetAllCouponAsync();
         Task<ResponseDto?> GetCouponByIdAsync(int id);
         Task<ResponseDto?> CreateCouponAsync(CouponDto couponDTO);
         Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDTO);
         Task<ResponseDto?> DeleteCouponAsync(int id);
    }
}
