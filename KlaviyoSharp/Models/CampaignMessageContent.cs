namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Campaign Message Content
/// </summary>
public class CampaignMessageContent
{
    /// <summary>
    /// The subject of the message
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Preview text associated with the message
    /// </summary>
    public string? PreviewText { get; set; }

    /// <summary>
    /// The email the message should be sent from
    /// </summary>
    public string? FromEmail { get; set; }

    /// <summary>
    /// The label associated with the from_email
    /// </summary>
    public string? FromLabel { get; set; }

    /// <summary>
    /// Optional Reply-To email address
    /// </summary>
    public string? ReplyToEmail { get; set; }

    /// <summary>
    /// Optional CC email address
    /// </summary>
    public string? CcEmail { get; set; }

    /// <summary>
    /// Optional BCC email address
    /// </summary>
    public string? BccEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Body { get; set; }
}
