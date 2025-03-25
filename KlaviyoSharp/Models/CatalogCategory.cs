namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Category
/// </summary>
public class CatalogCategory : KlaviyoObject<CatalogCategoryAttributes, CatalogCategoryRelationships>
{
    /// <summary>
    /// Create a new CatalogCategory with default values
    /// </summary>
    /// <returns></returns>
    public static new CatalogCategory Create() => new() { Type = "catalog-category" };
}
