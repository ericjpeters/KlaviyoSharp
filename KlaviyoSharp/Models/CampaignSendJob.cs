namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Send Job
/// </summary>
public class CampaignSendJob : KlaviyoObject<CampaignSendJobAttributes>
{
    /// <summary>
    /// Creates a new Campaign Send Job with default values
    /// </summary>
    /// <returns></returns>
    public static new Account Create()
    {
        return new() { Type = "campaign-send-job" };
    }
}
