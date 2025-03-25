namespace KlaviyoSharp.Models;

/// <summary>
/// Request to Unsuppress a list of profiles
/// </summary>
public class ProfileUnsuppressionRequest : KlaviyoObjectBasic<ProfileUnsuppressionRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Profile Unsuppression Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileUnsuppressionRequest Create()
    {
        return new ProfileUnsuppressionRequest() { Type = "profile-suppression-bulk-delete-job" };
    }
}
