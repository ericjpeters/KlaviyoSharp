namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class BadgeOptions
{
    /// <summary>
    /// Must be one of the following:
    /// * increment_one
    /// * set_count
    /// * set_property
    /// </summary>
    public string? BadgeConfig { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? SetFromProperty { get; set; }
}
