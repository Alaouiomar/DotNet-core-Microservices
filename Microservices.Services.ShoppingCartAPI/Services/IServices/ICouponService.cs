using Microservices.Services.ShoppingCartAPI.Models.Dto;

namespace Microservices.Services.ShoppingCartAPI.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
