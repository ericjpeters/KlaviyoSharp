namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class OnOpen
{
    /// <summary>
    /// Must be one of the following:
    /// * open_app
    /// * deep_link
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? IosDeepLink { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? AndroidDeepLink { get; set; }
}
