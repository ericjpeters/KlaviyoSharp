namespace KlaviyoSharp.Models;

/// <summary>
/// Profile Bulk Import Job Relationships
/// </summary>
public class ProfileBulkImportJobRelationships
{
    /// <summary>
    /// Lists associated with the Job
    /// </summary>
    public DataListObjectRelated<GenericObject>? Lists { get; set; }

    /// <summary>
    /// Profiles associated with this Job
    /// </summary>
    public DataListObject<GenericObject>? Profiles { get; set; }

    /// <summary>
    /// Import Errors associated with this Job
    /// </summary>
    public DataListObject<GenericObject>? ImportErrors { get; set; }
}
