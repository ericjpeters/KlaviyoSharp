namespace KlaviyoSharp.Models.Links;

/// <summary>
/// Links returned from the Klaviyo API (with pagination links)
/// </summary>
public class NavLink : SelfLink
{
    /// <summary>
    /// Link to first page of objects
    /// </summary>
    public string? First { get; set; }

    /// <summary>
    /// Link to last page of objects
    /// </summary>
    public string? Last { get; set; }

    /// <summary>
    /// Link to previous page of objects
    /// </summary>
    public string? Prev { get; set; }

    /// <summary>
    /// Link to next page of objects
    /// </summary>
    public string? Next { get; set; }
}
