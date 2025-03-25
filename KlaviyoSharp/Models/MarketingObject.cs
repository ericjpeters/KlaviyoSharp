namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- Marketing Object
/// </summary>
public class MarketingObject
{
    /// <summary>
    /// The consent status for marketing.
    /// 
    /// Must be one of the following:
    /// * SUBSCRIBED
    /// * UNSUBSCRIBED
    /// </summary>
    public string? Consent { get; set; }

    /// <summary>
    /// The timestamp of when the profile's consent was gathered. This should only be used when syncing over historical consent info to Klaviyo; if the historical_import flag is not included, providing any value for this field will raise an error.
    /// </summary>
    public DateTime? ConsentedAt { get; set; }
}
