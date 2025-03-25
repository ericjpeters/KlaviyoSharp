using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;

namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- updated
/// A Klaviyo Profile created for the client api
/// </summary>
public class ClientProfile : KlaviyoObject<ClientProfileAttributes>
{
    /// <summary>
    /// Creates a new instance of the ClientProfile class
    /// </summary>
    /// <returns></returns>
    public static new ClientProfile Create()
    {
        return new() { Type = "profile" };
    }

    /// <summary>
    /// 
    /// </summary>
    public MetaProperties? Meta { get; set; }
}

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

/// <summary>
/// 2025-01-15 -- updated
/// Location information for a Klaviyo Profile created for the client api
/// </summary>
public class ClientProfileLocation
{
    /// <summary>
    /// First line of street address
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// First line of street address
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// City name
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Country name
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Latitude coordinate. We recommend providing a precision of four decimal places.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude coordinate. We recommend providing a precision of four decimal places.
    /// </summary>
    public double? Longitude { get; set; }

    /// <summary>
    /// Region within a country, such as state or province
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// Zip code
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// Time zone name. We recommend using time zones from the IANA Time Zone Database.
    /// </summary>
    public string? Timezone { get; set; }

    /// <summary>
    /// IP Address
    /// </summary>
    public string? Ip { get; set; }
}
