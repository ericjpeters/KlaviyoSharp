namespace KlaviyoSharp.Models;

/// <summary>
///
/// </summary>
public class MetricAggregateQuery : KlaviyoObject<MetricAggregateQueryAttributes>
{
    /// <summary>
    /// Creates a new instance of the Metric Aggregate Query class
    /// </summary>
    /// <returns></returns>
    public static new MetricAggregateQuery Create()
    {
        return new MetricAggregateQuery() { Type = "metric-aggregate" };
    }
}
