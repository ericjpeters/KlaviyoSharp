using System.Text.Json.Serialization;

namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// Attributes for a Klaviyo Profile created for the client api
/// </summary>
public class ClientProfileAttributes
{
    /// <summary>
    /// Individual's email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Individual's phone number in E.164 format
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// A unique identifier used by customers to associate Klaviyo profiles with profiles in an external system, such
    /// as a point-of-sale system.
    /// Format varies based on the external system.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    public string? AnonymousId { get; set; }

    /// <summary>
    /// Also known as the exchange_id, this is an encrypted identifier used for identifying a profile by Klaviyo's web tracking.  
    /// You can use this field as a filter when retrieving profiles via the Get Profiles endpoint.
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
    /// Individual's job title
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// URL pointing to the location of a profile image
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    ///
    /// </summary>
    public ClientProfileLocation? Location { get; set; }

    /// <summary>
    /// An object containing key/value pairs for any custom properties assigned to this profile
    /// </summary>
    public Dictionary<string, object>? Properties { get; set; }
}
