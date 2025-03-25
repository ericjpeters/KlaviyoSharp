namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting returned from the API
/// </summary>
public class ReportingRequest : KlaviyoObjectBasic<ReportingRequestAttributes>
{
    /// <summary>
    /// Creates a new instance of the Template class
    /// </summary>
    /// <returns></returns>
    public static new ReportingRequest Create()
    {
        throw new NotImplementedException("Use specific methods for creating bulk jobs.");
    }

    /// <summary>
    /// Creates a new instance with the type set to "campaign-values-report"
    /// </summary>
    /// <returns></returns>
    public static ReportingRequest CreateCampaignValuesReport()
    {
        return new() { Type = "campaign-values-report" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "flow-values-report"
    /// </summary>
    /// <returns></returns>
    public static ReportingRequest CreateFlowValuesReport()
    {
        return new() { Type = "flow-values-report" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "flow-series-report"
    /// </summary>
    /// <returns></returns>
    public static ReportingRequest CreateFlowSeriesReport()
    {
        return new() { Type = "flow-series-report" };
    }
}
