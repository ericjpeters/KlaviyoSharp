namespace KlaviyoSharp.Models;

/// <summary>
/// Base class for Klaviyo objects
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class KlaviyoObjectBasic<T>
{
    /// <summary>
    /// Type of object
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Object attributes
    /// </summary>
    public T? Attributes { get; set; }

    /// <summary>
    /// Creates a new instance of this type and sets the default properties
    /// </summary>
    /// <remarks>Must be overridden in child classes to set the correct properties.</remarks>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static Account Create()
    {
        throw new NotImplementedException("Method not implemented for type");
    }
}
