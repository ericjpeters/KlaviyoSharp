namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting Timeframe
/// </summary>
public class ReportingValueData
{
    /// <summary>
    /// Applied groupings and the values for this object
    /// </summary>
    public Dictionary<string, string>? Groupings { get; set; }

    /// <summary>
    /// Requested statistics and their values results
    /// </summary>
    public Dictionary<string, double>? Statistics { get; set; }
}