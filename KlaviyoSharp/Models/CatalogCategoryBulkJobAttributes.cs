namespace KlaviyoSharp.Models;

/// <summary>
/// Attributes of the CatalogCategoryBulkCreateJob
/// </summary>
public class CatalogCategoryBulkJobAttributes
{
    /// <summary>
    /// Unique identifier for retrieving the job. Generated by Klaviyo.
    /// </summary>
    public string? JobId { get; set; }

    /// <summary>
    /// Status of the asynchronous job. One of: cancelled, complete, processing, queued
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The date and time the job was created in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The total number of operations to be processed by the job. See completed_count for the job's current progress.
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// The total number of operations that have been completed by the job.
    /// </summary>
    public int? CompletedCount { get; set; }

    /// <summary>
    /// The total number of operations that have failed as part of the job.
    /// </summary>
    public int? FailedCount { get; set; }

    /// <summary>
    /// Date and time the job was completed in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Date and time the job expires in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Array of errors encountered during the processing of the job.
    /// </summary>
    public List<KlaviyoErrorDetails>? Errors { get; set; }

    /// <summary>
    /// Array of catalog Categorys to create.
    /// </summary>
    public List<CatalogCategory>? Categories { get; set; }
}