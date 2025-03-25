namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Message Send Times
/// </summary>
public class CampaignMessageSendTimes
{
    /// <summary>
    /// The datetime that the message is to be sent
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Whether that datetime is to be a local datetime for the recipient
    /// </summary>
    public bool? IsLocal { get; set; }
}