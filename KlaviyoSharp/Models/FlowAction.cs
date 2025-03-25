namespace KlaviyoSharp.Models;

/// <summary>
/// Flow Actions returned from the API
/// </summary>
public class FlowAction : KlaviyoObject<FlowActionAttributes, FlowActionsRelationships>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Flow Create()
    {
        return new Flow() { Type = "flow-action" };
    }
}
