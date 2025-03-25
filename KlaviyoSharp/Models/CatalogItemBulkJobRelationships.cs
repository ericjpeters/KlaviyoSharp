namespace KlaviyoSharp.Models;

/// <summary>
/// Relationships of the CatalogItemBulkCreateJob
/// </summary>
public class CatalogItemBulkJobRelationships
{
    /// <summary>
    /// Catalog Items associated with the CatalogItemBulkCreateJob
    /// </summary>
    public DataListObject<GenericObject>? Items { get; set; }
}
