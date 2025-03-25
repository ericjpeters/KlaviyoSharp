namespace KlaviyoSharp.Models;

/// <summary>
/// Tags returned from the Klaviyo API
/// </summary>
public class Tag : KlaviyoObject<TagAttributes, TagRelationships>
{
    /// <summary>
    /// Creates a new instance of the Tag class
    /// </summary>
    /// <returns></returns>
    public static new Tag Create()
    {
        return new() { Type = "tag" };
    }
}
