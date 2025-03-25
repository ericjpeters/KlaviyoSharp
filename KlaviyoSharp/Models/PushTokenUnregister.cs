namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Klaviyo Push Token
/// </summary>
public class PushTokenUnregister : KlaviyoObject<PushTokenUnregisterAttributes>
{
    /// <summary>
    /// Creates a new instance of a Klaviyo Push Token with the Type property set to "push-token"
    /// </summary>
    /// <returns></returns>
    public static new PushTokenUnregister Create() => new() { Type = "push-token-unregister" };
}
