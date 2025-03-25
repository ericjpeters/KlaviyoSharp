namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Item Relationships
/// </summary>
public class CatalogItemRelationships
{
    /// <summary>
    /// Variants associated with the Catalog Item
    /// </summary>
    public DataListObject<GenericObject>? Variants { get; set; }

    /// <summary>
    /// Categories associated with the Catalog Item
    /// </summary>
    public DataListObject<GenericObject>? Categories { get; set; }
}
