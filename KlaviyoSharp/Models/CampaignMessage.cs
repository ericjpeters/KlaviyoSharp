namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Message
/// </summary>
public class CampaignMessage : KlaviyoObject<CampaignMessageAttributes, CampaignMessageRelationships>
{
    /// <summary>
    /// Creates a new Campaign Message with default values
    /// </summary>
    /// <returns></returns>
    public static new CampaignMessage Create()
    {
        return new() { Type = "campaign-message" };
    }
}
