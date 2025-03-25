namespace KlaviyoSharp.Models;

/// <summary>
/// Tag Group Attributes
/// </summary>
public class TagGroupAttributes
{
    /// <summary>
    /// The Tag Group name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// If a tag group is non-exclusive, any given related resource (campaign, flow, etc.) can be linked to multiple
    /// tags from that tag group. If a tag group is exclusive, any given related resource can only be linked to one tag
    /// from that tag group.
    /// </summary>
    public bool? Exclusive { get; set; }

    /// <summary>
    /// Every company automatically has one Default Tag Group. The Default Tag Group cannot be deleted, and no other
    /// Default Tag Groups can be created. This value is true for the Default Tag Group and false for all other Tag
    /// Groups.
    /// </summary>
    public bool? Default { get; set; }
}