namespace KlaviyoSharp.Models;

/// <summary>
/// SMS Subscriptions associated with a profile
/// 2025-01-15 -- Marketing Object 
/// </summary>
public class ProfileSmsSubscriptionMarketing : MarketingObject
{
#if REMOVED_2025_01_15
    /// <summary>
    /// Whether or not this profile is subscribed to receive SMS marketing.
    /// </summary>
    public bool CanReceiveSmsMarketing { get; set; }

    /// <summary>
    /// The timestamp when the SMS consent record was last modified, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// The method by which the profile was subscribed to marketing.
    /// </summary>
    public string? Method { get; set; }

    /// <summary>
    /// Additional details about the method by which the profile was subscribed to marketing. This may be empty if no details were provided.
    /// </summary>
    public string? MethodDetail { get; set; }
#endif
}
