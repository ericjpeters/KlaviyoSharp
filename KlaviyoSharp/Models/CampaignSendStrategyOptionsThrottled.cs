namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Strategy Options Throttled
/// </summary>
public class CampaignSendStrategyOptionsThrottled
{
    /// <summary>
    /// The time to send at
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// The percentage of recipients per hour to send to. Allowed values: [10, 11, 13, 14, 17, 20, 25, 33, 50]
    /// </summary>
    public int? ThrottlePercentage { get; set; }
}
