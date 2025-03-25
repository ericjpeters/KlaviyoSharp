namespace KlaviyoSharp.Models;

/// <summary>
/// Profile Unsubscription Attributes
/// </summary>
public class ProfileUnsubscriptionAttributes
{
    /// <summary>
    /// The profiles to unsubscribe
    /// </summary>
    public DataListObject<Profile>? Profiles { get; set; }
}