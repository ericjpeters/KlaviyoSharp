namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Push Token Attributes
/// </summary>
public class PushTokenUnregisterAttributes
{
    /// <summary>
    /// A push token from APNS or FCM.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    /// The platform on which the push token was created.
    /// 
    /// Must be one of the following:
    /// * android
    /// * ios
    /// </summary>
    public string? Platform { get; set; }

    /// <summary>
    /// The vendor of the push token.
    /// 
    /// Must be one of the following:
    /// * apns
    /// * fcm
    /// </summary>
    public string? Vendor { get; set; }

    /// <summary>
    /// The profile associated with the push token to create/update
    /// </summary>
    public DataObject<Profile>? Profile { get; set; }
}
