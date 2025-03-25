namespace KlaviyoSharp.Models;

/// <summary>
/// A generic data object for relationships
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataObjectRelated<T>
{
    /// <summary>
    /// Creates a new instance of the DataObjectRelated class
    /// </summary>
    public DataObjectRelated()
    {
    }

    /// <summary>
    /// Creates a new instance of the DataObjectRelated class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public DataObjectRelated(T data)
    {
        Data = data;
    }

    /// <summary>
    /// The data property
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// Links to paginate through the list
    /// </summary>
    public Links.RelatedLink? Links { get; set; }
}
