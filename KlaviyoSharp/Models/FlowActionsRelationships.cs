namespace KlaviyoSharp.Models;

/// <summary>
/// Flow actions relationships
/// </summary>
public class FlowActionsRelationships
{
    /// <summary>
    /// Flow actions associated with the flow
    /// </summary>
    public DataObject<GenericObject>? Flow { get; set; }

    /// <summary>
    /// Flow actions associated with the flow
    /// </summary>
    public DataListObjectRelated<GenericObject>? FlowMessages { get; set; }
}
