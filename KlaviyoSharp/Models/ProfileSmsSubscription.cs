namespace KlaviyoSharp.Models;

/// <summary>
/// SMS Subscriptions associated with a profile
/// 2025-01-15 -- Sms Object
/// </summary>
public class ProfileSmsSubscription
{
    /// <summary>
    /// The SMS marketing subscription.
    /// </summary>
    public ProfileSmsSubscriptionMarketing? Marketing { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ProfileSmsSubscriptionTransactional? Transactional { get; set; }
}
