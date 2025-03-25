namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Attributes
/// </summary>
public class CampaignAttributes
{
    /// <summary>
    /// The campaign name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The current status of the campaign
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Whether the campaign has been archived or not
    /// </summary>
    public bool? Archived { get; set; }

    /// <summary>
    /// The type of campaign
    /// </summary>
    public string? Channel { get; set; }

    /// <summary>
    /// The audiences to be included and/or excluded from the campaign
    /// </summary>
    public CampaignAudiences? Audiences { get; set; }

    /// <summary>
    /// Options to use when sending a campaign
    /// </summary>
    public CampaignSendOptions? SendOptions { get; set; }

    /// <summary>
    /// The tracking options associated with the campaign
    /// </summary>
    public CampaignTrackingOptions? TrackingOptions { get; set; }

    /// <summary>
    /// The send strategy the campaign will send with
    /// </summary>
    public CampaignSendStrategy? SendStrategy { get; set; }

    /// <summary>
    /// The send strategy the campaign will send with
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime when the campaign was last updated by a user or the system
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The datetime when the campaign was scheduled for future sending
    /// </summary>
    public DateTime? ScheduledAt { get; set; }

    /// <summary>
    /// The datetime when the campaign will be / was sent or None if not yet scheduled by a send_job.
    /// </summary>
    public DateTime? SendTime { get; set; }
}
