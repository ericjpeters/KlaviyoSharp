namespace KlaviyoSharp.Models;

/// <summary>
/// Upload Image From File Request
/// </summary>
public class ImageFromFile : KlaviyoObject<ImageFromFileRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Image class
    /// </summary>
    /// <returns></returns>
    public static new ImageFromFile Create()
    {
        return new();
    }
}
