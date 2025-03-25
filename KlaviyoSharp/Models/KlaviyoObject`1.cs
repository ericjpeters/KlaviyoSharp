namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Account Object with ID and Links
/// </summary>
/// <typeparam name="T">Attributes Type</typeparam>
public abstract class KlaviyoObject<T> : KlaviyoObjectBasic<T>
{
    /// <summary>
    /// Unique identifier for the object
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Links to the object
    /// </summary>
    public Links.SelfLink? Links { get; set; }
}
