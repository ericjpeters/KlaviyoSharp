namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Additional options for rendering the message
/// </summary>
public class RenderOptions
{
    /// <summary>
    /// 
    /// </summary>
    public bool ShortenLinks { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddOrgPrefix { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddInfoLink { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddOptOutLanguage { get; set; } = false;
}
