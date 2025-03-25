namespace KlaviyoSharp.Models;

/// <summary>
/// Profile Unsubscription Request
/// </summary>
public class ProfileUnsubscriptionRequest : KlaviyoObject<ProfileUnsubscriptionAttributes, ProfileUnsubscriptionRelationships>
{
    /// <summary>
    /// Creates a new instance of the Profile Unsubscription Request class
    /// </summary>
    /// <returns></returns>
    public static new ProfileUnsubscriptionRequest Create()
    {
        return new ProfileUnsubscriptionRequest() { Type = "profile-subscription-bulk-delete-job" };
    }
}
