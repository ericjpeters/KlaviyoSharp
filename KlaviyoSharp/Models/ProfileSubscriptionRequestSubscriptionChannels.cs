namespace KlaviyoSharp.Models;

/// <summary>
/// The communication types to subscribe
/// </summary>
public class ProfileSubscriptionRequestSubscriptionChannels
{
    /// <summary>
    /// The communication types to subscribe to on the "EMAIL" Channel. Currently supports "MARKETING".
    /// </summary>
    public List<string>? Email { get; set; }

    /// <summary>
    /// The communication types to subscribe to on the "SMS" Channel. Currently supports "MARKETING".
    /// </summary>
    public List<string>? Sms { get; set; }
}
