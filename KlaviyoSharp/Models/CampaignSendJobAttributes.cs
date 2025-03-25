namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Job Attributes
/// </summary>
public class CampaignSendJobAttributes
{
    /// <summary>
    /// The status of the send job. One of: cancelled, complete, processing, queued.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The action you would like to take with this send job from among 'cancel' and 'revert'
    /// </summary>
    public string? Action { get; set; }
}