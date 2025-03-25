namespace KlaviyoSharp.Models;

/// <summary>
/// A generic data object for with navigation links
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataObjectWithNavigate<T>
{
    /// <summary>
    /// Creates a new instance of the DataObjectRelated class
    /// </summary>
    public DataObjectWithNavigate()
    {
    }

    /// <summary>
    /// Creates a new instance of the DataObjectRelated class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public DataObjectWithNavigate(T data)
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
    public Links.NavLink? Links { get; set; }
}
