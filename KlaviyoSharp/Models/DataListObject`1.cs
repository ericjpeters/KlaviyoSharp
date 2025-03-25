namespace KlaviyoSharp.Models;

/// <summary>
/// Generic object with a single list property called "data"
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataListObject<T>
{
    /// <summary>
    /// Creates a new instance of the DataListObject class
    /// </summary>
    public DataListObject()
    {
    }

    /// <summary>
    /// Creates a new instance of the DataListObject class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public DataListObject(List<T> data)
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
    public Links.NavLink? Links { get; set; }
}
