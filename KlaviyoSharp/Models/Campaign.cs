namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign
/// </summary>
public class Campaign : KlaviyoObject<CampaignAttributes, CampaignRelationships>
{
    /// <summary>
    /// Creates a new Campaign with default values
    /// </summary>
    /// <returns></returns>
    public static new Account Create()
    {
        return new() { Type = "campaign" };
    }
}
