namespace KlaviyoSharp.Models;

/// <summary>
/// Contact information for a account
/// </summary>
public class AccountContactInformation
{
    /// <summary>
    /// This field is used to auto-populate the default sender name on flow and campaign emails.
    /// </summary>
    public string? DefaultSenderName { get; set; }

    /// <summary>
    /// This field is used to auto-populate the default sender email address on flow and campaign emails.
    /// </summary>
    public string? DefaultSenderEmail { get; set; }

    /// <summary>
    ///
    /// </summary>
    public string? WebsiteUrl { get; set; }

    /// <summary>
    ///
    /// </summary>
    public string? OrganizationName { get; set; }

    /// <summary>
    /// Street address for your organization
    /// </summary>
    public AccountStreetAddress? StreetAddress { get; set; }
}
