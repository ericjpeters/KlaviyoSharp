using KlaviyoSharp.Infrastructure;

namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Strategy Options Sto
/// </summary>
public class CampaignSendStrategyOptionsSto
{
    /// <summary>
    /// The day to send on
    /// </summary>
    public KlaviyoDateOnly Date { get; set; }
}
