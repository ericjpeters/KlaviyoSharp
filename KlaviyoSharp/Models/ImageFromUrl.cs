namespace KlaviyoSharp.Models;

/// <summary>
/// Upload Image From Url Request
/// </summary>
public class ImageFromUrl : KlaviyoObject<ImageFromUrlRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Image class
    /// </summary>
    /// <returns></returns>
    public static new ImageFromUrl Create()
    {
        return new() { Type = "image" };
    }
}
