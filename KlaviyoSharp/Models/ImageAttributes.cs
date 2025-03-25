namespace KlaviyoSharp.Models;

/// <summary>
/// Image attributes
/// </summary>
public class ImageAttributes : PatchImageAttributes
{
    /// <summary>
    /// Undocumented
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public int Size { get; private set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
