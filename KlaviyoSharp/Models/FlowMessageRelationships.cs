namespace KlaviyoSharp.Models;

/// <summary>
/// Flow Messages relationships
/// </summary>
public class FlowMessageRelationships
{
    /// <summary>
    /// Flow actions associated with the flow
    /// </summary>
    public DataListObjectRelated<GenericObject>? FlowActions { get; set; }
}
