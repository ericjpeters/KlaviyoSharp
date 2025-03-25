namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Klaviyo Push Token
/// </summary>
public class PushToken : KlaviyoObject<PushTokenAttributes>
{
    /// <summary>
    /// Creates a new instance of a Klaviyo Push Token with the Type property set to "push-token"
    /// </summary>
    /// <returns></returns>
    public static new PushToken Create() => new() { Type = "push-token" };
}
