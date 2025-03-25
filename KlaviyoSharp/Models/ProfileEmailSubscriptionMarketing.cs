namespace KlaviyoSharp.Models;

/// <summary>
/// Email Subscriptions associated with a profile
/// 2025-01-15 -- Transactional Object
/// </summary>
public class ProfileEmailSubscriptionMarketing : MarketingObject
{
#if REMOVED_2025_01_15
    /// <summary>
    /// Whether or not this profile has implicit consent to receive email marketing.
    /// True if it does profile does not have any global suppressions.
    /// </summary>
    public bool CanReceiveEmailMarketing { get; set; }

    /// <summary>
    /// The timestamp when a field on the email marketing object was last modified.
    /// </summary>
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// The method by which the profile was subscribed to marketing.
    /// </summary>
    public string? Method { get; set; }

    /// <summary>
    /// Additional details about the method by which the profile was subscribed to marketing. This may be empty if no
    /// details were provided.
    /// </summary>
    public string? MethodDetail { get; set; }

    /// <summary>
    /// Additional detail provided by the caller when the profile was subscribed. This may be empty if no details were
    /// provided.
    /// </summary>
    public string? CustomMethodDetail { get; set; }

    /// <summary>
    /// Whether the profile was subscribed to email marketing using a double opt-in.
    /// </summary>
    public bool? DoubleOptIn { get; set; }

    /// <summary>
    /// The global email marketing suppressions for this profile.
    /// </summary>
    public List<ProfileEmailSubscriptionMarketingEmailSupression>? Suppression { get; set; }

    /// <summary>
    /// The list suppressions for this profile.
    /// </summary>
    public List<ProfileEmailSubscriptionMarketingListSupression>? ListSuppressions { get; set; }
#endif
}
