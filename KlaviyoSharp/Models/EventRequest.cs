namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Request to create a Klaviyo Event
/// </summary>
public class EventRequest : KlaviyoObjectBasic<EventRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of this type and sets the default properties
    /// </summary>
    public new static EventRequest Create()
    {
        return new() { Type = "event" };
    }
}
