namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting Attributes
/// </summary>
public class ReportingAttributes
{
    /// <summary>
    /// An array of all the returned values data.
    /// Each object in the array represents one unique grouping and the results for that grouping.
    /// </summary>
    public List<ReportingValueData>? Results { get; set; }
}
