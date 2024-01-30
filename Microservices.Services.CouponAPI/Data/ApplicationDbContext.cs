using Microservices.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Services.CouponAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {
        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 1,
                CouponCode= "20REDOFF",
                DiscountAmount = 20,
                MinAccount = 40,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 2,
                CouponCode = "40REDOFF",
                DiscountAmount = 40,
                MinAccount = 80,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 3,
                CouponCode = "60REDOFF",
                DiscountAmount = 60,
                MinAccount = 120,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 4,
                CouponCode = "80REDOFF",
                DiscountAmount = 80,
                MinAccount = 160,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponID = 5,
                CouponCode = "50REDOFF",
                DiscountAmount = 50,
                MinAccount = 100,
            });
        }
    }
}
