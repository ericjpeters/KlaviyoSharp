namespace KlaviyoSharp.Models;

/// <summary>
/// Coupon attributes
/// </summary>
public class CouponAttributes
{
    /// <summary>
    /// This is the id that is stored in an integration such as Shopify or Magento.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// A description of the coupon.
    /// </summary>
    public string? Description { get; set; }
}