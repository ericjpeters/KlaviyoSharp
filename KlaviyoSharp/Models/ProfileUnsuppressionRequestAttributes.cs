namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes of a Profile Unsuppression Request
/// </summary>
public class ProfileUnsuppressionRequestAttributes
{
    /// <summary>
    /// One or more profile to be unsupressed.
    /// </summary>
    public DataListObject<Profile>? Profiles { get; set; }
}
