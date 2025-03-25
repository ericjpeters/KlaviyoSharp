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

/// <summary>
/// Attributes of a metric
/// </summary>
public class MetricAttributes
{
    /// <summary>
    /// The name of the metric
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Service { get; set; }

#if REMOVED_2025_01_15
    /// <summary>
    /// Creation time in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Last updated time in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// The integration associated with the event
    /// </summary>
    [Obsolete("THIS CLASS IS NOT DOCUMENTED IN THE KLAVIYO API DOCS! RECONSTRUCTED FROM THE RESPONSE OF A GET REQUEST, USE AT YOUR OWN RISK!")]
    public MetricIntegration? Integration { get; set; }
#endif
}
