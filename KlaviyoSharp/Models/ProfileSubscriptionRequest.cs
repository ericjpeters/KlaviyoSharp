namespace KlaviyoSharp.Models;

/// <summary>
/// Request to subscribe a list of profiles
/// </summary>
public class ProfileSubscriptionRequest : KlaviyoObject<ProfileSubAttributes, ProfileSubRequestRelationships>
{
    /// <summary>
    /// Creates a new instance of the Profile Subscription Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileSubscriptionRequest Create()
    {
        return new ProfileSubscriptionRequest() { Type = "profile-subscription-bulk-create-job" };
    }
}
