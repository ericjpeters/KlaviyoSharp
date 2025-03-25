namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- Transactional Object
/// </summary>
public class ProfileSmsSubscriptionTransactional
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
    /// 
    /// </summary>
    public DateTime? ConsentedAt { get; set; }
}
