namespace KlaviyoSharp.Models;

/// <summary>
/// A subscription to a list created for the client api
/// </summary>
public class ClientSubscription : KlaviyoObject<ClientSubscriptionAttributes, ClientSubscriptionRelationships>
{
    /// <summary>
    /// Creates a new instance of the ClientSubscription class
    /// </summary>
    /// <returns></returns>
    public static new ClientSubscription Create()
    {
        return new() { Type = "subscription" };
    }
}
