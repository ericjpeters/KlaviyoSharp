namespace KlaviyoSharp.Models;

/// <summary>
/// Flows returned from the API
/// </summary>
public class Flow : KlaviyoObject<FlowAttributes, FlowRelationships>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Flow Create()
    {
        return new Flow() { Type = "flow" };
    }
}
