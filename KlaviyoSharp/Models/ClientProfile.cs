namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// A Klaviyo Profile created for the client api
/// </summary>
public class ClientProfile : KlaviyoObject<ClientProfileAttributes>
{
    /// <summary>
    /// Creates a new instance of the ClientProfile class
    /// </summary>
    /// <returns></returns>
    public static new ClientProfile Create()
    {
        return new() { Type = "profile" };
    }

    /// <summary>
    /// 
    /// </summary>
    public MetaProperties? Meta { get; set; }
}
