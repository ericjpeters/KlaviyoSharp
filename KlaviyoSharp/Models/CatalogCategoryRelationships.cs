namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Category Relationships
/// </summary>
public class CatalogCategoryRelationships
{
    /// <summary>
    /// Related Items
    /// </summary>
    public DataListObject<GenericObject>? Items { get; set; }
}
