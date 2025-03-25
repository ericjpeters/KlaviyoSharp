namespace KlaviyoSharp.Models;

/// <summary>
/// Profile Relationships
/// </summary>
public class ProfileRelationships
{
    /// <summary>
    /// Lists associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject>? Lists { get; set; }

    /// <summary>
    /// Segments associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject>? Segments { get; set; }
}
