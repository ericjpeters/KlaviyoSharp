namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Event Attributes
/// </summary>
public class EventAttributes
{
    /// <summary>
    /// Event timestamp in seconds
    /// </summary>
    public string? Timestamp { get; set; }

    /// <summary>
    /// Event properties, can include identifiers and extra properties
    /// </summary>
    public Dictionary<string, object>? EventProperties { get; set; }

    /// <summary>
    /// Event timestamp in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// A unique identifier for the event, this can be used as a cursor in pagination
    /// </summary>
    public string? Uuid { get; set; }
}
