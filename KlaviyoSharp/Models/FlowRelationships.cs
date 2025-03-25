namespace KlaviyoSharp.Models;

/// <summary>
/// Flow relationships
/// </summary>
public class FlowRelationships
{
    /// <summary>
    /// Flow actions associated with the flow
    /// </summary>
    public DataListObjectRelated<GenericObject>? FlowActions { get; set; }

    /// <summary>
    /// Tags associated with the flow
    /// </summary>
    public DataListObjectRelated<GenericObject>? Tags { get; set; }
}
