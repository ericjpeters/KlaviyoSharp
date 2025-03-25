namespace KlaviyoSharp.Models;

/// <summary>
/// Relationships of the CatalogCategoryBulkCreateJob
/// </summary>
public class CatalogCategoryBulkJobRelationships
{
    /// <summary>
    /// Catalog Categorys associated with the CatalogCategoryBulkCreateJob
    /// </summary>
    public DataListObject<GenericObject>? Categories { get; set; }
}
