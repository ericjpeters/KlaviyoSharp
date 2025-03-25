using KlaviyoSharp.Models;

namespace KlaviyoSharp.Tests;

public class CouponServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public readonly int SleepTime = 10 * 1000; //10 Seconds
    public readonly int Retries = 3;
    public Coupon NewCoupon
    {
        get
        {
            Coupon output = Coupon.Create();
            output.Attributes = new()
            {
                ExternalId = $"test{Config.Random}",
                Description = $"Test {Config.Random}",
            };
            return output;
        }
    }

    public CouponCode NewCouponCode
    {
        get
        {
            //Coupon coupon = NewCoupon;
            CouponCode output = CouponCode.Create();
            output.Attributes = new()
            {
                UniqueCode = $"test{Config.Random}",
            };

            return output;
        }
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
