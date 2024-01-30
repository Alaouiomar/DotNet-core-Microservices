namespace Microservices.Services.CouponAPI.Models.Dto
{
    public class CouponDTO
    {
        public int CouponID { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAccount { get; set; }
    }
}
