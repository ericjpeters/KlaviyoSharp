namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Variant Relationships
/// </summary>
public class CatalogVariantRelationships
{
    /// <summary>
    /// Related Catalog Item
    /// </summary>
    public DataObject<GenericObject>? Item { get; set; }
}
