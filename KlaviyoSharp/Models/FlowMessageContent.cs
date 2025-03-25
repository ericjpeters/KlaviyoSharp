namespace KlaviyoSharp.Models;

/// <summary>
/// Flow Message Content. Obsolte. See <see href="https://developers.klaviyo.com/en/reference/get_flow_message"/>
/// </summary>
public class FlowMessageContent
{
    /// <summary>
    /// Undocumented. Email only.
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Undocumented. Email only.
    /// </summary>
    public string? FromEmail { get; set; }

    /// <summary>
    /// Undocumented. Email only.
    /// </summary>
    public string? FromName { get; set; }

    /// <summary>
    /// Undocumented. Email only.
    /// </summary>
    public string? PreviewText { get; set; }

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
    /// Undocumented. SMS only.
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Undocumented. SMS only.
    /// </summary>
    public string? Media { get; set; }
}