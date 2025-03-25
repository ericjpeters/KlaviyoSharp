namespace KlaviyoSharp.Models;

/// <summary>
/// Request to suppress a list of profiles
/// </summary>
public class ProfileSuppressionRequest : KlaviyoObjectBasic<ProfileSuppressionRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Profile Suppression Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileSuppressionRequest Create()
    {
        return new ProfileSuppressionRequest() { Type = "profile-suppression-bulk-create-job" };
    }
}
