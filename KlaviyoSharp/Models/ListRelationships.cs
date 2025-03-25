namespace KlaviyoSharp.Models;

/// <summary>
/// List Relationships
/// </summary>
public class ListRelationships
{
    /// <summary>
    /// Profiles associated with the List
    /// </summary>
    public DataListObjectRelated<GenericObject>? Profiles { get; set; }

    /// <summary>
    /// Tags associated with the List
    /// </summary>
    public DataListObjectRelated<GenericObject>? Tags { get; set; }
}
