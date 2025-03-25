namespace KlaviyoSharp.Models;

/// <summary>
/// Generic object with a single property called "data"
/// </summary>
/// <typeparam name="T"></typeparam>
public class DataObject<T>
{
    /// <summary>
    /// Creates a new instance of the DataObject class
    /// </summary>
    public DataObject()
    {
    }

    /// <summary>
    /// Creates a new instance of the DataObject class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public DataObject(T data)
    {
        Data = data;
    }

    /// <summary>
    /// The data property
    /// </summary>
    public T? Data { get; set; }
}
