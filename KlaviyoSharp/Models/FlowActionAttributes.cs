namespace KlaviyoSharp.Models;

/// <summary>
/// Flow actions attributes
/// </summary>
public class FlowActionAttributes
{
    /// <summary>
    /// Undocumented
    /// </summary>
    public string? ActionType { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public object? Settings { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public FlowActionTrackingOptions? TrackingOptions { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public FlowActionSendOptions? SendOptions { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public FlowActionRenderOptions? RenderOptions { get; set; }
}
