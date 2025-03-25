namespace KlaviyoSharp.Models;

/// <summary>
/// Relationships for a subscription to a list created for the client api
/// </summary>
public class ClientSubscriptionRelationships
{
    /// <summary>
    /// List to subscribe to.
    /// </summary>
    public DataObject<GenericObject>? List { get; set; }
}
