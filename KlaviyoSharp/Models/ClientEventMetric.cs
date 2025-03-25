namespace KlaviyoSharp.Models;

/// <summary>
/// The associated metric for the event. An account can have up to 200 unique metrics.
/// </summary>
public class ClientEventMetric
{
    /// <summary>
    /// Name of the event. Must be less than 128 characters.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// This is for advanced usage. For api requests, this should use the default, which is set to api.
    /// </summary>
    public string? Service { get; set; }
}