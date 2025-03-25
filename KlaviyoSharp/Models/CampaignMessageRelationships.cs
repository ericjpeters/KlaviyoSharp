namespace KlaviyoSharp.Models;

/// <summary>
///
/// </summary>
public class CampaignMessageRelationships
{
    /// <summary>
    /// The parent campaign
    /// </summary>
    public DataObject<GenericObject>? Campaign { get; set; }
    /// <summary>
    /// The template associated with the message
    /// </summary>
    public DataObject<GenericObject>? Template { get; set; }
}
