namespace KlaviyoSharp.Models;

/// <summary>
/// A Segment in Klaviyo
/// </summary>
public class Segment : KlaviyoObject<SegmentAttributes, SegmentRelationships>
{
    /// <summary>
    /// Creates a new instance of the Segment class
    /// </summary>
    /// <returns></returns>
    public static new Segment Create()
    {
        return new Segment() { Type = "segment" };
    }
}
