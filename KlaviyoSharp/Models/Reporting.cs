namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting returned from the API
/// </summary>
public class Reporting : KlaviyoObject<ReportingAttributes, ReportingRelationships>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new Reporting Create()
    {
        return new Reporting() { Type = "image" };
    }
}
