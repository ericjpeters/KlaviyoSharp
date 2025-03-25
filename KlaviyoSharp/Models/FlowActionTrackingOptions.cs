namespace KlaviyoSharp.Models;

/// <summary>
/// Undocumented flow action settings
/// </summary>
public class FlowActionTrackingOptions
{
    /// <summary>
    /// Undocumented
    /// </summary>
    public bool? AddUtm { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public List<UTMParams>? UtmParams { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public bool? IsTrackingOpens { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public bool? IsTrackingClicks { get; set; }
}
