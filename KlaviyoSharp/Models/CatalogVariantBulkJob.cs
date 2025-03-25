namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Variant Bulk Job
/// </summary>
public class CatalogVariantBulkJob : KlaviyoObject<CatalogVariantBulkJobAttributes, CatalogVariantBulkJobRelationships>
{
    /// <summary>
    /// Not implemented. Use specific methods for creating bulk jobs.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static new CatalogVariantBulkJob Create()
    {
        throw new NotImplementedException("Use specific methods for creating bulk jobs.");
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-variant-bulk-create-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogVariantBulkJob CreateCreateJob()
    {
        return new() { Type = "catalog-variant-bulk-create-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-variant-bulk-update-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogVariantBulkJob CreateUpdateJob()
    {
        return new() { Type = "catalog-variant-bulk-update-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-variant-bulk-delete-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogVariantBulkJob CreateDeleteJob()
    {
        return new() { Type = "catalog-variant-bulk-delete-job" };
    }
}
