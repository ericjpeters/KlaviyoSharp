using Newtonsoft.Json;
using System.Net.Http;

namespace KlaviyoSharp.Models;

/// <summary>
/// Error Returned from the Klaviyo API
/// </summary>
public class KlaviyoError
{
    /// <summary>
    /// List of errors returned
    /// </summary>
    public KlaviyoErrorDetails[]? Errors { get; set; }

    /// <summary>
    /// Converts a HttpResponseMessage to a KlaviyoError
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    public static KlaviyoError? FromHttpResponse(HttpResponseMessage response)
    {
        return JsonConvert.DeserializeObject<KlaviyoError>(
            response.Content.ReadAsStringAsync().Result,
            Infrastructure.JsonContent.KlaviyoJsonSerializerSettings);
    }
}
