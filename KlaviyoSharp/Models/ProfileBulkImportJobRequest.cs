namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Profile Bulk Import Job Request
/// </summary>
public class ProfileBulkImportJobRequest
{
    /// <summary>
    /// Generic Constructor
    /// </summary>
    public ProfileBulkImportJobRequest()
    {
    }

    /// <summary>
    /// Constructor for Profile Bulk Import Job from existing Profiles
    /// </summary>
    /// <param name="profiles"></param>
    public ProfileBulkImportJobRequest(List<Profile> profiles)
    {
        Profiles = new()
        {
            Data = profiles
        };
    }

    /// <summary>
    /// Creates a new instance of the Klaviyo Profile with default values
    /// </summary>
    /// <returns></returns>
    public static PatchProfile Create() => new() { Type = "profile-bulk-import-job" };

    /// <summary>
    /// Lists associated with the Job
    /// </summary>
    public DataListObject<Profile>? Profiles { get; set; }
}
