using KlaviyoSharp.Models;
using System.Linq;

namespace KlaviyoSharp;

/// <summary>
/// An exception thrown by the Klaviyo API
/// </summary>
public class KlaviyoException : Exception
{
    /// <summary>
    /// The full list of errors returned by the Klaviyo API
    /// </summary>
    public KlaviyoErrorDetails[]? InternalErrors { get; set; }

    /// <summary>
    /// Creates a new KlaviyoException with the given KlaviyoError. Uses the message from the first error in the list.
    /// </summary>
    /// <param name="error"></param>
    public KlaviyoException(KlaviyoError? error)
        : base(error?.Errors?.FirstOrDefault()?.Detail)
    {
        InternalErrors = error?.Errors;
    }
}