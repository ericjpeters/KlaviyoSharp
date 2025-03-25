namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Client Event Bulk Create Attributes
/// </summary>
public class ClientEventBulkCreateAttributes
{
    /// <summary>
    /// Profile to create events for.
    /// </summary>
    public DataObject<PatchProfile>? Profile { get; set; }

    /// <summary>
    /// List of events to create for this profile.
    /// </summary>
    public DataListObject<EventRequest>? Events { get; set; }
}
