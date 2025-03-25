namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Clone Attributes
/// </summary>
public class CampaignCloneAttributes
{
    /// <summary>
    /// The campaign ID to be cloned
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The name for the new cloned campaign
    /// </summary>
    public string? NewName { get; set; }
}
