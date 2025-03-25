namespace KlaviyoSharp.Models;

/// <summary>
/// Profile Merge Request
/// </summary>
public class ProfileMergeRequest : ProfileMerge
{
    /// <inheritdoc/>
    public ProfileMergeRequest() : base() { }
    /// <inheritdoc/>
    public ProfileMergeRequest(string type, string id) : base(type, id) { }
    /// <summary>
    /// Creates a new instance of the Profile Merge Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileMergeRequest Create() => new() { Type = "profile-merge" };

    /// <summary>
    /// Lists associated with the Profile Merge
    /// </summary>
    public ProfileMergeRelationships Relationships { get; set; } = new();
}
