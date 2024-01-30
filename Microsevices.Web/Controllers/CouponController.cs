using Microservices.Web.Models;
using Microsevices.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Microsevices.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _CouponService;
        public CouponController(ICouponService couponService)
        {
            _CouponService = couponService;
        }

        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? list = new();

            ResponseDto? response = await _CouponService.GetAllCouponAsync();

            if(response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list);
        }

        public async Task<IActionResult> CouponCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CouponCreate(CouponDto model)
        {
            if(ModelState.IsValid)
            {
                ResponseDto? response = await _CouponService.CreateCouponAsync(model);

                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Coupon created successfully";
                    return RedirectToAction(nameof(CouponIndex));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(model);
        }

        public async Task<IActionResult> CouponDelete(int couponId)
        {
			ResponseDto? response = await _CouponService.GetCouponByIdAsync(couponId);

			if (response != null && response.IsSuccess)
			{
				CouponDto? model = JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(response.Result));
                return View(model);
			}
			else
			{
				TempData["error"] = response?.Message;
			}

			return NotFound();
        }

		[HttpPost]
		public async Task<IActionResult> CouponDelete(CouponDto couponDto)
		{
			ResponseDto? response = await _CouponService.DeleteCouponAsync(couponDto.CouponID);

			if (response != null && response.IsSuccess)
			{
				TempData["success"] = "Coupon deleted successfully";
				return RedirectToAction(nameof(CouponIndex));
			}
			else
			{
				TempData["error"] = response?.Message;
			}

			return View(couponDto);
		}
	}
}
