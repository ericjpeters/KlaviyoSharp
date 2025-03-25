namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Job Attributes
/// </summary>
public class CampaignRecipientEstimationJobAttributes
{
    /// <summary>
    /// The status of the recipient estimation job. One of: cancelled, complete, processing, queued.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The ID of the campaign to perform recipient estimation
    /// </summary>
    public string? Id { get; set; }
}