namespace KlaviyoSharp.Models;

/// <summary>
/// A Template in Klaviyo
/// </summary>
public class Template : KlaviyoObject<TemplateAttributes>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Template Create()
    {
        return new Template() { Type = "template" };
    }
}
