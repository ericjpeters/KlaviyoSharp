namespace KlaviyoSharp.Models;

/// <summary>
/// List Attributes
/// </summary>
public class ListAttributes
{
    /// <summary>
    /// A helpful name to label the list
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Date and time when the list was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Date and time when the list was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Updated { get; set; }
}