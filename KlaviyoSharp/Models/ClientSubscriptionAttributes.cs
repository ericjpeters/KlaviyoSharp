namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes for a subscription to a list created for the client api
/// </summary>
public class ClientSubscriptionAttributes
{
    /// <summary>
    /// A custom method detail or source to store on the consent records for this subscription.
    /// </summary>
    public string? CustomSource { get; set; }

    /// <summary>
    /// The profile to subscribe.
    /// </summary>
    public DataObject<Profile>? Profile { get; set; }
}