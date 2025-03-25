namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Client Back In Stock Subscription Relationships
/// </summary>
public class BackInStockSubRelationships
{
    /// <summary>
    /// Klaviyo Client Back In Stock Subscription Variants
    /// </summary>
    public DataObject<GenericObject>? Variant { get; set; }
}
