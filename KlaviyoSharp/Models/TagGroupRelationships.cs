namespace KlaviyoSharp.Models;

/// <summary>
/// Tag Group Relationships
/// </summary>
public class TagGroupRelationships
{
    /// <summary>
    /// The tags that belong to this tag group.
    /// </summary>
    public DataListObjectRelated<GenericObject>? Tags { get; set; }
}
