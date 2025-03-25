namespace KlaviyoSharp.Models;

/// <summary>
/// Flow Messages returned from the API
/// </summary>
public class FlowMessage : KlaviyoObject<FlowMessageAttributes, FlowMessageRelationships>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Flow Create()
    {
        return new Flow() { Type = "flow-message" };
    }
}
