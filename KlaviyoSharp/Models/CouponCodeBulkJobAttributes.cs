namespace KlaviyoSharp.Models;

/// <summary>
/// Coupon Code Bulk Job Attributes
/// </summary>
public class CouponCodeBulkJobAttributes
{
    /// <summary>
    /// Status of the asynchronous job.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The action you would like to take with this send job from among 'cancel' and 'revert'
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// The date and time the job was created in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The total number of operations to be processed by the job. See <see cref="CompletedCount"/> for the job's current progress.
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// The total number of operations that have been completed by the job.
    /// </summary>
    public int CompletedCount { get; set; }

    /// <summary>
    /// The total number of operations that have failed as part of the job.
    /// </summary>
    public int FailedCount { get; set; }

    /// <summary>
    /// Date and time the job was completed in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Array of errors encountered during the processing of the job.
    /// </summary>
    public List<KlaviyoError>? Errors { get; set; }
}
