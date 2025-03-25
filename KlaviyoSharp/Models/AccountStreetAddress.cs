namespace KlaviyoSharp.Models;

/// <summary>
/// Street address for a account
/// </summary>
public class AccountStreetAddress
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
    /// Region within a country, such as state or province
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// Zip code
    /// </summary>
    public string? Zip { get; set; }
}
