namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Klaviyo Client Back In Stock Subscription
/// </summary>
public class BackInStockSubscription : KlaviyoObject<BackInStockSubAttributes, BackInStockSubRelationships>
{
    /// <summary>
    /// Creates a new instance of the Klaviyo Client Back In Stock Subscription with default values
    /// </summary>
    /// <returns></returns>
    public static new BackInStockSubscription Create() => new() { Type = "back-in-stock-subscription" };
}
