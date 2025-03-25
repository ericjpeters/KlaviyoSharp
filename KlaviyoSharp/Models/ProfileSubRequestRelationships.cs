namespace KlaviyoSharp.Models;

/// <summary>
/// Relationships of a Profile Subscription Request
/// </summary>
public class ProfileSubRequestRelationships
{
    /// <summary>
    /// The list to add the newly subscribed profiles to
    /// </summary>
    public DataObject<GenericObject>? List { get; set; }
}
