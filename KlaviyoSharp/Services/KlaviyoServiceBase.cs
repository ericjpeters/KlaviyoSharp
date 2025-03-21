namespace KlaviyoSharp.Services;

/// <summary>
/// Base class for Klaviyo Services
/// </summary>
/// <remarks>
/// Constructor for Klaviyo Services
/// </remarks>
/// <param name="revision">Version of the Klaviyo API</param>
/// <param name="klaviyoService">Klaviyo API service</param>
public abstract class KlaviyoServiceBase(string revision, KlaviyoApiBase klaviyoService)
{
    /// <summary>
    /// Klaviyo API revision
    /// </summary>
    protected string _revision = revision;
    /// <summary>
    /// Klaviyo API service
    /// </summary>
    protected KlaviyoApiBase _klaviyoService = klaviyoService;
}