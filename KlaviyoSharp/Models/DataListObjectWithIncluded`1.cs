namespace KlaviyoSharp.Models;

/// <summary>
/// A generic data list object with an additional property called "included"
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataListObjectWithIncluded<T> : DataListObject<T>
{
    /// <summary>
    /// Included records
    /// </summary>
    public List<object>? Included { get; set; }
}
