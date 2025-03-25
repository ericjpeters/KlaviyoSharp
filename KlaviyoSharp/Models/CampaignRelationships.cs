namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Relationships
/// </summary>
public class CampaignRelationships
{
    /// <summary>
    /// Campaign messages associated with the Campaign
    /// </summary>
    public DataListObjectRelated<GenericObject>? CampaignMessages { get; set; }

    /// <summary>
    /// Tags associated with the Campaign
    /// </summary>
    public DataListObjectRelated<GenericObject>? Tags { get; set; }
}
