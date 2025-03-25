namespace KlaviyoSharp.Models;

/// <summary>
/// Coupon Codes relationships
/// </summary>
public class CouponCodeRelationships
{
    /// <summary>
    /// Coupon associated with the couponcode
    /// </summary>
    public DataObjectRelated<GenericObject>? Coupon { get; set; }

    /// <summary>
    /// Profiles associated with the couponcode
    /// </summary>
    public CouponCodeRelationshipsProfile? Profile { get; set; }
}
