namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Event
/// </summary>
public class Event : KlaviyoObject<EventAttributes, EventRelationships>
{
    /// <summary>
    /// Creates a new instance of the Event class
    /// </summary>
    /// <returns></returns>
    public static new Event Create()
    {
        return new() { Type = "event" };
    }
}
