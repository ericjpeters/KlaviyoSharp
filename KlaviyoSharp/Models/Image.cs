namespace KlaviyoSharp.Models;

/// <summary>
/// Images returned from the API
/// </summary>
public class Image : KlaviyoObject<ImageAttributes>
{
    /// <summary>
    /// Creates a new instance of the Image class
    /// </summary>
    /// <returns></returns>
    public static new Image Create()
    {
        return new Image() { Type = "image" };
    }

    /// <summary>
    /// Creates a new instance of the Image class
    /// </summary>
    /// <returns></returns>
    public static ImageFromUrl CreateFromUrl()
    {
        return ImageFromUrl.Create();
    }

    /// <summary>
    /// Creates a new instance of the Image class
    /// </summary>
    /// <returns></returns>
    public static ImageFromFile CreateFromFile()
    {
        return ImageFromFile.Create();
    }
}
