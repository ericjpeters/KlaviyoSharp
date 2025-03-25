namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Account Object
/// </summary>
public class Account : KlaviyoObject<AccountAttributes>
{
    /// <summary>
    /// Creates a new instance of this type and sets the default properties
    /// </summary>
    /// <returns></returns>
    public static new Account Create()
    {
        return new() { Type = "account" };
    }
}
