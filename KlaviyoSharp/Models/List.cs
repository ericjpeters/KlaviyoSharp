namespace KlaviyoSharp.Models;

/// <summary>
/// Lists returned from the Klaviyo API
/// </summary>
public class List : KlaviyoObject<ListAttributes, ListRelationships>
{
    /// <summary>
    /// Creates a new instance of the List class
    /// </summary>
    /// <returns></returns>
    public static new List Create()
    {
        return new List() { Type = "list" };
    }
}
