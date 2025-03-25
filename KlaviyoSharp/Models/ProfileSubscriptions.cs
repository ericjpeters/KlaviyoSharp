namespace KlaviyoSharp.Models;

/// <summary>
/// Subscriptions associated with a profile
/// 2025-01-15 -- Subscriptions Object
/// </summary>
public class ProfileSubscriptions
{
    /// <summary>
    /// The email channel subscription.
    /// </summary>
    public ProfileEmailSubscription? Email { get; set; }

    /// <summary>
    /// The SMS channel subscription.
    /// </summary>
    public ProfileSmsSubscription? Sms { get; set; }
}
