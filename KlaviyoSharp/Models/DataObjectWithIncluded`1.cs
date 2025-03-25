namespace KlaviyoSharp.Models;

/// <summary>
/// A generic data object with an additional property called "included"
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataObjectWithIncluded<T> : DataObject<T>
{
    /// <summary>
    /// Included records
    /// </summary>
    public List<object>? Included { get; set; }
}
