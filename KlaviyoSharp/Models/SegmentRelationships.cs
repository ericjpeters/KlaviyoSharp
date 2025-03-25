namespace KlaviyoSharp.Models;

/// <summary>
/// Related objects for the Segment
/// </summary>
public class SegmentRelationships
{
    /// <summary>
    /// Profiles associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject>? Profiles { get; set; }

    /// <summary>
    /// Profiles associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject>? Tags { get; set; }
}
