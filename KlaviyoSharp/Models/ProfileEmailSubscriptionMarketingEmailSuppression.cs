namespace KlaviyoSharp.Models;

/// <summary>
/// Email Subscriptions associated with a profile
/// </summary>
public class ProfileEmailSubscriptionMarketingEmailSuppression
{
    /// <summary>
    /// The reason the profile was suppressed from the list.
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// The timestamp when the profile was suppressed from the list, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? Timestamp { get; set; }
}
