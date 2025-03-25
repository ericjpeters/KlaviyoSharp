namespace KlaviyoSharp.Models;

/// <summary>
/// Aggregation result data
/// </summary>
public class MetricAggregateData
{
    /// <summary>
    /// List of dimensions associated with this set of measurements
    /// </summary>
    public List<string>? Dimensions { get; set; }

    /// <summary>
    /// Dictionary of measurement_key, values
    /// </summary>
    public Dictionary<string, List<double?>>? Measurements { get; set; }
}