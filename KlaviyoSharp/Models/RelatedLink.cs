namespace KlaviyoSharp.Models.Links;

/// <summary>
/// Links returned from the Klaviyo API (with related link)
/// </summary>
public class RelatedLink : SelfLink
{
    /// <summary>
    /// Link to related objects
    /// </summary>
    public string? Related { get; set; }
}
