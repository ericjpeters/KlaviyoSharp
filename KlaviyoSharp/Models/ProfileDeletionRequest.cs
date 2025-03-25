namespace KlaviyoSharp.Models;

/// <summary>
/// Request to delete a profile
/// </summary>
public class ProfileDeletionRequest : KlaviyoObjectBasic<ProfileDeletionRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Profile Deletion Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileDeletionRequest Create()
    {
        return new() { Type = "data-privacy-deletion-job" };
    }
}
