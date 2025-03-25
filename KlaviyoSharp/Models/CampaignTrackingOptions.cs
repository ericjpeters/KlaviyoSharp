namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Tracking Options
/// </summary>
public class CampaignTrackingOptions
{
    /// <summary>
    /// Whether the campaign is tracking open events. If not specified, uses company defaults.
    /// </summary>
    public bool? IsTrackingOpens { get; set; }

    /// <summary>
    /// Whether the campaign is tracking click events. If not specified, uses company defaults.
    /// </summary>
    public bool? IsTrackingClicks { get; set; }

    /// <summary>
    /// Whether the campaign needs UTM parameters. If set to False, UTM params will not be used.
    /// </summary>
    public bool? IsAddUtm { get; set; }

    /// <summary>
    /// A list of UTM parameters. If an empty list is given and is_add_utm is True, uses company defaults.
    /// </summary>
    public List<UTMParams>? UtmParams { get; set; }
}
