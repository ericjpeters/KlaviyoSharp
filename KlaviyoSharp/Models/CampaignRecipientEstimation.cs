namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Recipient Estimation
/// </summary>
public class CampaignRecipientEstimation : KlaviyoObject<CampaignRecipientEstimationAttributes>
{
    /// <summary>
    /// Creates a new Campaign Recipient Estimation with default values
    /// </summary>
    /// <returns></returns>
    public static new Account Create()
    {
        return new() { Type = "campaign-recipient-estimation" };
    }
}
