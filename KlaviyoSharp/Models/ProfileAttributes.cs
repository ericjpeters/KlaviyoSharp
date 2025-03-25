using System.Text.Json.Serialization;

namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Profile Attributes
/// </summary>
public class ProfileAttributes
{
    /// <summary>
    /// Individual's email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Individual's email address
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// A unique identifier used by customers to associate Klaviyo profiles with profiles in an external system, such as a point-of-sale system. Format varies based on the external system.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// Id that can be used to identify a profile when other identifiers are not available
    /// </summary>
    public string? AnonymousId { get; set; }

    /// <summary>
    /// Also known as the exchange_id, this is an encrypted identifier used for identifying a profile by Klaviyo's web tracking.
    /// </summary>
    [JsonPropertyName("_kx")]
    public string? ExchangeId { get; set; }

    /// <summary>
    /// Individual's first name
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Individual's last name
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Name of the company or organization within the company for whom the individual works
    /// </summary>
    public string? Organization { get; set; }

    /// <summary>
    /// The locale of the profile, in the IETF BCP 47 language tag format like (ISO 639-1/2)-(ISO 3166 alpha-2)
    /// </summary>
    public string? Locale { get; set; }

    /// <summary>
    /// Individual's job title
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// URL pointing to the location of a profile image
    /// </summary>
    public string? Image { get; set; }

#if REMOVED_2025_01_15
    /// <summary>
    /// Date and time when the profile was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// Date and time when the profile was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Date and time of the most recent event the triggered an update to the profile, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? LastEvent { get; set; }
#endif 

    /// <summary>
    /// Location information for the profile
    /// </summary>
    public ProfileLocation? Location { get; set; }

    /// <summary>
    /// Subscriptions for the profile
    /// </summary>
    public ProfileSubscriptions? Subscriptions { get; set; }

#if REMOVED_2025_01_15
    /// <summary>
    /// Analytics for the profile
    /// </summary>
    public ProfilePredictiveAnalytics? PredictiveAnalytics { get; set; }
#endif
    /// <summary>
    /// Custom Properties
    /// </summary>
    public Dictionary<string, object>? Properties { get; set; }

    /// <summary>
    /// Meta properties for patching
    /// </summary>
    public MetaProperties? Meta { get; set; }
}
