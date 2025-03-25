namespace KlaviyoSharp.Models;

/// <summary>
/// Coupon Codes attributes
/// </summary>
public class CouponCodeAttributes
{
    /// <summary>
    /// This is a unique string that will be or is assigned to each customer/profile and is associated with a coupon.
    /// </summary>
    public string? UniqueCode { get; set; }

    /// <summary>
    /// The datetime when this coupon code will expire.
    /// If not specified or set to null, it will be automatically set to 1 year.
    /// </summary>
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// The current status of the coupon code.
    /// </summary>
    public string? Status { get; set; }
}