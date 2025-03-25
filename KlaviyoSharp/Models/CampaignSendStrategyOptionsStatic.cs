namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Strategy Options Static
/// </summary>
public class CampaignSendStrategyOptionsStatic
{
    /// <summary>
    /// The time to send at
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// If the campaign should be sent with local recipient timezone send (requires UTC time) or statically sent at the
    /// given time. Defaults to False.
    /// </summary>
    public bool? IsLocal { get; set; }

    /// <summary>
    /// Determines if we should send to local recipient timezone if the given time has passed. Only applicable to local
    /// sends. Defaults to False.
    /// </summary>
    public bool? SendPastRecipientsImmediately { get; set; }
}
