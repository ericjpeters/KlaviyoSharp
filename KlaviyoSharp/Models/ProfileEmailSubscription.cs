namespace KlaviyoSharp.Models;

/// <summary>
/// Email Subscriptions associated with a profile
/// </summary>
public class ProfileEmailSubscription
{
    /// <summary>
    /// The email marketing subscription.
    /// </summary>
    public ProfileEmailSubscriptionMarketing? Marketing { get; set; }
}
