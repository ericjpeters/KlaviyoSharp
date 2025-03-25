namespace KlaviyoSharp.Models;

/// <summary>
/// Flow Messages attributes
/// </summary>
public class FlowMessageAttributes
{
    /// <summary>
    /// Undocumented
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public string? Channel { get; set; }

    /// <summary>
    /// Undocumented and Obsolete. See <see href="https://developers.klaviyo.com/en/reference/get_flow_message"/>
    /// </summary>
    [Obsolete("Marked Obsolete in Klaviyo API Docs")]
    public FlowMessageContent? Content { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public DateTime? Updated { get; set; }
}
