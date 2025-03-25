namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Audiences
/// </summary>
public class CampaignAudiences
{
    /// <summary>
    /// A list of included audiences
    /// </summary>
    public List<string>? Included { get; set; }

    /// <summary>
    /// An optional list of excluded audiences
    /// </summary>
    public List<string>? Excluded { get; set; }
}
