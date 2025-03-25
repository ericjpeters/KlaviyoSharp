namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Coupon Code Bulk Job
/// </summary>
public class CouponCodeBulkJob : KlaviyoObject<CouponCodeBulkJobAttributes>
{
    /// <summary>
    /// Creates a new Coupon Code Bulk Job with default values
    /// </summary>
    /// <returns></returns>
    public static new CouponCodeBulkJob Create()
    {
        return new() { Type = "coupon-code-bulk-create-job" };
    }
}
