namespace KlaviyoSharp.Models;

/// <summary>
/// Relationships of a Profile Unsubscription Request
/// </summary>
public class ProfileUnsubscriptionRelationships
{
    /// <summary>
    /// The list to remove the profiles from
    /// </summary>
    public DataObject<GenericObject>? List { get; set; }
}
