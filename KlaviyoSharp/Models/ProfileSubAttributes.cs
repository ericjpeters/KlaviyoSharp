namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes of a Profile Subscription Request
/// </summary>
public class ProfileSubAttributes
{
    /// <summary>
    /// A custom method detail or source to store on the consent records.
    /// </summary>
    public string? CustomSource { get; set; }

    /// <summary>
    /// The profiles to subscribe
    /// </summary>
    public DataListObject<Profile>? Profiles { get; set; }

    /// <summary>
    /// Whether this subscription is part of a historical import. If true, the consented_at field must be provided for each profile.
    /// </summary>
    public bool HistoricalImport { get; set; } = false;
}
