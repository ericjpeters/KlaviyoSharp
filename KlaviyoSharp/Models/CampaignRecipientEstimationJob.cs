namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Send Job
/// </summary>
public class CampaignRecipientEstimationJob : KlaviyoObject<CampaignRecipientEstimationJobAttributes>
{
    /// <summary>
    /// Creates a new Campaign Send Job with default values
    /// </summary>
    /// <returns></returns>
    public static new Account Create()
    {
        return new() { Type = "campaign-recipient-estimation-job" };
    }
}
