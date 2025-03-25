namespace KlaviyoSharp.Models;

/// <summary>
/// Tag Relationships
/// </summary>
public class TagRelationships
{
    /// <summary>
    /// The tag group that this tag belongs to.
    /// </summary>
    public DataObject<GenericObject>? TagGroup { get; set; }

    /// <summary>
    /// Lists that this tag is applied to.
    /// </summary>
    public DataListObjectRelated<GenericObject>? Lists { get; set; }

    /// <summary>
    /// Segments that this tag is applied to.
    /// </summary>
    public DataListObjectRelated<GenericObject>? Segments { get; set; }

    /// <summary>
    /// Campaigns that this tag is applied to.
    /// </summary>
    public DataListObjectRelated<GenericObject>? Campaigns { get; set; }

    /// <summary>
    /// Flows that this tag is applied to.
    /// </summary>
    public DataListObjectRelated<GenericObject>? Flows { get; set; }
}
