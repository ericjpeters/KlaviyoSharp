namespace KlaviyoSharp.Models;

/// <summary>
/// Campaign Send Strategy
/// </summary>
public class CampaignSendStrategy
{
    /// <summary>
    /// Describes the shape of the options object. Allowed values: ['static', 'throttled', 'immediate',
    /// 'smart_send_time']
    /// </summary>
    public string? Method { get; set; }

    /// <summary>
    /// The send configuration options the campaign will send with. These define variables that alter the send strategy
    /// and must match the given method. Intended to be used with the 'static' method.
    /// </summary>
    public CampaignSendStrategyOptionsStatic? OptionsStatic { get; set; }

    /// <summary>
    /// The send configuration options the campaign will send with. These define variables that alter the send strategy
    /// and must match the given method. Intended to be used with the 'throttled' method.
    /// </summary>
    public CampaignSendStrategyOptionsThrottled? OptionsThrottled { get; set; }

    /// <summary>
    /// The send configuration options the campaign will send with. These define variables that alter the send strategy
    /// and must match the given method. Intended to be used with the 'smart_send_time' method.
    /// </summary>
    public CampaignSendStrategyOptionsSto? OptionsSto { get; set; }
}
