namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes for the Segment
/// </summary>
public class SegmentAttributes
{
    /// <summary>
    /// A helpful name to label the segment
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Date and time when the segment was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Date and time when the segment was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public int? ProfileCount { get; set; }
}