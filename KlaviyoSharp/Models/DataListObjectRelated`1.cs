namespace KlaviyoSharp.Models;

/// <summary>
/// A generic data list object for relationships
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataListObjectRelated<T>
{
    /// <summary>
    /// Creates a new instance of the DataListObjectRelated class
    /// </summary>
    public DataListObjectRelated()
    {
    }

    /// <summary>
    /// Creates a new instance of the DataListObjectRelated class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public DataListObjectRelated(List<T> data)
    {
        Data = data;
    }

    /// <summary>
    /// The data property
    /// </summary>
    public List<T>? Data { get; set; }
    /// <summary>
    /// Links to paginate through the list
    /// </summary>
    public Links.RelatedLink? Links { get; set; }
}
