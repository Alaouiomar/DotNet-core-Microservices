using Microservices.Web.Models;
using Microsevices.Web.Models;
using Microsevices.Web.Services.IServices;
using Microsevices.Web.Utility;

namespace Microsevices.Web.Services
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _IBaseService;
        public CouponService(IBaseService baseService) 
        {
            _IBaseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDTO)
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data= couponDTO,
                Url = SD.CouponAPIBase + "/api/coupon/" 
            });
        }

        public  async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAsync()
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType= SD.ApiType.GET,
                Url=SD.CouponAPIBase+"/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string CouponCode)
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode/" + CouponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async  Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDTO)
        {
            return await _IBaseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = couponDTO,
                Url = SD.CouponAPIBase + "/api/coupon/"
            });
        }
    }
}
