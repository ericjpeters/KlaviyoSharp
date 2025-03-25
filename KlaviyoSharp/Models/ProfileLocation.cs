namespace KlaviyoSharp.Models;

/// <summary>
/// Location information for the profile
/// 2025-01-15 -- Location Object
/// </summary>
public class ProfileLocation
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
