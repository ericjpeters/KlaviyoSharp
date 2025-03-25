namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Item Bulk Create Job
/// </summary>
public class CatalogItemBulkJob : KlaviyoObject<CatalogItemBulkJobAttributes, CatalogItemBulkJobRelationships>
{
    /// <summary>
    /// Not implemented. Use specific methods for creating bulk jobs.
    /// </summary>
    /// <returns></returns>
    public static new CatalogItemBulkJob Create()
    {
        throw new NotImplementedException("Use specific methods for creating bulk jobs.");
    }
    /// <summary>
    /// Creates a new instance with the type set to "catalog-item-bulk-create-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogItemBulkJob CreateCreateJob()
    {
        return new() { Type = "catalog-item-bulk-create-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-item-bulk-update-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogItemBulkJob CreateUpdateJob()
    {
        return new() { Type = "catalog-item-bulk-update-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-item-bulk-delete-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogItemBulkJob CreateDeleteJob()
    {
        return new() { Type = "catalog-item-bulk-delete-job" };
    }
}
