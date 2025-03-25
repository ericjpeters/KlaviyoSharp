namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Variant Bulk Job Relationships
/// </summary>
public class CatalogVariantBulkJobRelationships
{
    /// <summary>
    /// Catalog Variants associated with the CatalogVariantBulkJob
    /// </summary>
    public DataListObject<GenericObject>? Variants { get; set; }
}
