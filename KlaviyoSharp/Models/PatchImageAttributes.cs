namespace KlaviyoSharp.Models;

/// <summary>
/// PatchImage attributes
/// </summary>
public class PatchImageAttributes
{
    /// <summary>
    /// A name for the image.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// If true, this image is not shown in the asset library.
    /// </summary>
    public bool Hidden { get; set; }
}
