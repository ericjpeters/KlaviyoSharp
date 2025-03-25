namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Image for patching
/// </summary>
public class PatchImage : KlaviyoObject<PatchImageAttributes>
{
    /// <summary>
    /// Generic Constructor
    /// </summary>
    public PatchImage()
    {
    }

    /// <summary>
    /// Constructor for PatchImage from existing Image
    /// </summary>
    /// <param name="image"></param>
    public PatchImage(Image image)
    {
        Id = image.Id;
        Type = image.Type;
        Attributes = image.Attributes;
    }

    /// <summary>
    /// Creates a new instance of the Klaviyo Image with default values
    /// </summary>
    /// <returns></returns>
    public static new PatchImage Create() => new() { Type = "image" };
}
