namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting Relationships
/// </summary>
public class ReportingRelationships
{
    /// <summary>
    /// Lists associated with the Report
    /// </summary>
    public DataListObjectRelated<GenericObject>? Campaigns { get; set; }
}
