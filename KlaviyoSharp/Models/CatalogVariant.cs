namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Variant
/// </summary>
public class CatalogVariant : KlaviyoObject<CatalogVariantAttributes, CatalogVariantRelationships>
{
    /// <summary>
    /// Creates a new instance of the Catalog Variant class, setting the type to catalog-variant
    /// </summary>
    /// <returns></returns>
    public static new CatalogVariant Create() => new() { Type = "catalog-variant" };
}
