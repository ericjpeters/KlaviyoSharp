namespace KlaviyoSharp.Models;

/// <summary>
///
/// </summary>
public class ProfileSuppressionRequestAttributes
{
    /// <summary>
    /// One or more profiles to be suppressed.
    /// </summary>
    public DataListObject<Profile>? Profiles { get; set; }
}