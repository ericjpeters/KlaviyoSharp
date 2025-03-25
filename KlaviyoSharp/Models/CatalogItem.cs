namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Item
/// </summary>
public class CatalogItem : KlaviyoObject<CatalogItemAttributes, CatalogItemRelationships>
{
    /// <summary>
    /// Creates a new instance of the CatalogItem class
    /// </summary>
    /// <returns></returns>
    public static new CatalogItem Create()
    {
        return new() { Type = "catalog-item" };
    }
}
