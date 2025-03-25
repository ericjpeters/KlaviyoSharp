namespace KlaviyoSharp;

/// <summary>
/// 2025-01-15 -- updated
/// The Klaviyo Client API. All /client endpoints use a public API key, your 6-character company ID, also known as a site ID.
/// </summary>
/// <remarks>
/// Creates a new instance of the Klaviyo Client API.
/// </remarks>
/// <param name="config">The KlaviyoConfig object.</param>
public class KlaviyoClientApi(KlaviyoConfig config) : KlaviyoApiBase(config)
{
    const string REVISION = "2025-01-15";

    /// <summary>
    /// Creates a new instance of the Klaviyo Client API.
    /// </summary>
    /// <param name="companyId">Your 6-character company ID, also known as a site ID.</param>
    public KlaviyoClientApi(string companyId)
        : this(new KlaviyoConfig(companyId) { ApiPath = "/client", UseAuthentication = false, ApiDomain = "https://a.klaviyo.com" })
    {
    }

    private Services.ClientServices? _ClientServices;

    /// <summary>
    /// Services for /client endpoints
    /// </summary>    
    public Services.ClientServices ClientServices
    {
        get
        {
            _ClientServices ??= new(REVISION, this);
            return _ClientServices;
        }
    }
}