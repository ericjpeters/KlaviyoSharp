namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes of a Profile Deletion Request
/// </summary>
public class ProfileDeletionRequestAttributes
{
    /// <summary>
    /// The profile to delete.
    /// </summary>
    public DataObject<Profile>? Profile { get; set; }
}