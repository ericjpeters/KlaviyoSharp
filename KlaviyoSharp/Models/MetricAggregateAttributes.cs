namespace KlaviyoSharp.Models;

/// <summary>
/// Aggregation result attributes
/// </summary>
public class MetricAggregateAttributes
{
    /// <summary>
    /// The dates of the query range
    /// </summary>
    public List<DateTime>? Dates { get; set; }

    /// <summary>
    /// Aggregation result data
    /// </summary>
    public List<MetricAggregateData>? Data { get; set; }
}
