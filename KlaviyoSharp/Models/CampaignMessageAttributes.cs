namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Campaign Message Attributes
/// </summary>
public class CampaignMessageAttributes
{
    /// <summary>
    /// The label or name on the message
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// The channel the message is to be sent on
    /// 
    /// Must be one of the following:
    /// * email
    /// * sms
    /// * mobile_push
    /// </summary>
    public string? Channel { get; set; }

    /// <summary>
    /// Additional attributes relating to the content of the message
    /// </summary>
    public CampaignMessageContent? Content { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public RenderOptions? RenderOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Dictionary<string, string>? KvPairs { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Options? Options { get; set; }

    /// <summary>
    /// Must be one of the following:
    /// * standard
    /// * silent
    /// </summary>
    public string? NotificationType { get; set; }

#if REMOVED_2025_01_15
    /// <summary>
    /// The list of appropriate Send Time Sub-objects associated with the message
    /// </summary>
    public List<CampaignMessageSendTimes>? SendTimes { get; set; }

    /// <summary>
    /// The datetime when the message was created
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime when the message was last updated
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The parent campaign id
    /// </summary>
    public string? CampaignId { get; set; }
#endif
}
