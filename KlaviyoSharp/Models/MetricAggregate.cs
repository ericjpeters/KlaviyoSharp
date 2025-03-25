namespace KlaviyoSharp.Models;

/// <summary>
/// Metric Aggregation Result
/// </summary>
public class MetricAggregate : KlaviyoObject<MetricAggregateAttributes>
{
    /// <summary>
    /// Creates a new instance of the Metric Aggregate class
    /// </summary>
    /// <returns>Should not need to be used</returns>
    public static new MetricAggregate Create()
    {
        return new MetricAggregate() { Type = "metric-aggregate" };
    }
}
