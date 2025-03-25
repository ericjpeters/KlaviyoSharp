namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Klaviyo Push Token Attributes
/// </summary>
public class PushTokenAttributes
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
    /// This is the enablement status for the individual push token.
    /// 
    /// Must be one of the following:
    /// * AUTHORIZED
    /// * DENIED
    /// * NOT_DETERMINED
    /// * PROVISIONAL
    /// * NOT AUTHORIZED
    /// </summary>
    public string? EnablementStatus { get; set; }

    /// <summary>
    /// The vendor of the push token.
    /// 
    /// Must be one of the following:
    /// * apns
    /// * fcm
    /// </summary>
    public string? Vendor { get; set; }

    /// <summary>
    /// The background state of the push token.
    /// 
    /// Must be one of the following:
    /// * AVAILABLE
    /// * DENIED
    /// * RESTRICTED
    /// </summary>
    public string? Background { get; set; }

    /// <summary>
    /// Metadata about the device that created the push token
    /// </summary>
    public PushTokenDeviceMetadata? DeviceMetadata { get; set; }

    /// <summary>
    /// The profile associated with the push token to create/update
    /// </summary>
    public DataObject<Profile>? Profile { get; set; }
}
