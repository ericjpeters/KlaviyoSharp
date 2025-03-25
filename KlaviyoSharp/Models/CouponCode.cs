namespace KlaviyoSharp.Models;

/// <summary>
/// Coupon Codes returned from the API
/// </summary>
public class CouponCode : KlaviyoObject<CouponCodeAttributes, CouponCodeRelationships>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new CouponCode Create()
    {
        return new CouponCode() { Type = "coupon-code" };
    }
}
