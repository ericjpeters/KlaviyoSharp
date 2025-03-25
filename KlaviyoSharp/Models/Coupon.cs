namespace KlaviyoSharp.Models;

/// <summary>
/// Coupons returned from the API
/// </summary>
public class Coupon : KlaviyoObject<CouponAttributes>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Coupon Create()
    {
        return new Coupon() { Type = "coupon" };
    }
}
