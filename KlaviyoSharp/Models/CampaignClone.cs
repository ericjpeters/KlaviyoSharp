namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Clone Request
/// </summary>
public class CampaignClone : KlaviyoObject<CampaignCloneAttributes>
{
    /// <summary>
    /// Creates a new Campaign Clone with default values
    /// </summary>
    /// <returns></returns>
    public static new CampaignClone Create()
    {
        return new() { Type = "campaign" };
    }
}
