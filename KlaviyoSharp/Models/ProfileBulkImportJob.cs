namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Profile Bulk Import Job
/// </summary>
public class ProfileBulkImportJob : KlaviyoObject<ProfileBulkImportJobAttributes, ProfileBulkImportJobRelationships>
{
    /// <summary>
    /// Creates a new Profile Bulk Import Job with default values
    /// </summary>
    /// <returns></returns>
    public static new ProfileBulkImportJob Create()
    {
        return new() { Type = "profile-bulk-import-job" };
    }
}
