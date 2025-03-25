namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// A metric is a custom event that you can use to track any action that you want to measure.
/// </summary>
public class Metric : KlaviyoObject<MetricAttributes>
{
    /// <summary>
    /// Creates a new instance of the Metric class
    /// </summary>
    /// <returns></returns>
    public static new Metric Create()
    {
        return new Metric() { Type = "metric" };
    }
}
