namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Event Relationships
/// </summary>
public class EventRelationships
{
    /// <summary>
    /// Klaviyo Profiles associated with the Event
    /// </summary>
    public DataObject<GenericObject>? Profile { get; set; }

    /// <summary>
    /// Klaviyo Metrics associated with the Event
    /// </summary>
    public DataObject<GenericObject>? Metric { get; set; }
}
