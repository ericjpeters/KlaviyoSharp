namespace KlaviyoSharp.Models;

/// <summary>
/// Tag Groups returned from the Klaviyo API
/// </summary>
public class TagGroup : KlaviyoObject<TagGroupAttributes, TagGroupRelationships>
{
    /// <summary>
    /// Creates a new instance of the Tag Group class
    /// </summary>
    /// <returns></returns>
    public static new TagGroup Create()
    {
        return new() { Type = "tag-group" };
    }
}
