namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Profiles returned from the Klaviyo API
/// </summary>
public class Profile : KlaviyoObject<ProfileAttributes, ProfileRelationships>
{
    /// <summary>
    /// Creates a new instance of the Profile class
    /// </summary>
    /// <returns></returns>
    public static new Profile Create() => new() { Type = "profile" };
}
