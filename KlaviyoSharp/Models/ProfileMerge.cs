namespace KlaviyoSharp.Models;

/// <summary>
/// Profiles Merge returned from the Klaviyo API
/// </summary>
public class ProfileMerge : GenericObject
{
    /// <summary>
    /// 
    /// </summary>
    public ProfileMerge() : base() { }
    /// <inheritdoc/>
    public ProfileMerge(string type, string id) : base(type, id) { }

    /// <summary>
    /// Creates a new instance of the Profile Merge class
    /// </summary>
    /// <returns></returns>
    public static ProfileMerge Create() => new() { Type = "profile-merge" };
}
