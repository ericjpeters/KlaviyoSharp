namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Category Bulk Create Job
/// </summary>
public class CatalogCategoryBulkJob : KlaviyoObject<CatalogCategoryBulkJobAttributes, CatalogCategoryBulkJobRelationships>
{
    /// <summary>
    /// Not implemented. Use specific methods for creating bulk jobs.
    /// </summary>
    /// <returns></returns>
    public static new CatalogCategoryBulkJob Create()
    {
        throw new NotImplementedException("Use specific methods for creating bulk jobs.");
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-create-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateCreateJob()
    {
        return new() { Type = "catalog-category-bulk-create-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-update-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateUpdateJob()
    {
        return new() { Type = "catalog-category-bulk-update-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-delete-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateDeleteJob()
    {
        return new() { Type = "catalog-category-bulk-delete-job" };
    }
}
