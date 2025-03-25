namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Account Object with ID, Links, and Relationships
/// </summary>
/// <typeparam name="T">Attributes Type</typeparam>
/// <typeparam name="U">Relationships Type</typeparam>
public abstract class KlaviyoObject<T, U> : KlaviyoObjectBasic<T>
{
    /// <summary>
    /// Unique identifier for the object
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Links to the object
    /// </summary>
    public Links.SelfLink? Links { get; set; }

    /// <summary>
    /// Relationships to the object
    /// </summary>
    public U? Relationships { get; set; }
}
