using KlaviyoSharp.Models.Filters;

namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting Attributes
/// </summary>
public class ReportingRequestAttributes
{
    /// <summary>
    /// <para>
    ///     List of statistics to query for.
    ///     All rate statistics will be returned in fractional form [0.0, 1.0]
    /// </para>
    /// <para>Defined reporting metric</para>
    /// <list type="bullet">
    ///     <item>
    ///         <term>average_order_value</term>
    ///     </item>
    ///     <item>
    ///         <term>bounce_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>bounced</term>
    ///     </item>
    ///     <item>
    ///         <term>bounced_or_failed</term>
    ///     </item>
    ///     <item>
    ///         <term>bounced_or_failed_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>click_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>click_to_open_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>clicks</term>
    ///     </item>
    ///     <item>
    ///         <term>clicks_unique</term>
    ///     </item>
    ///     <item>
    ///         <term>conversion_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>conversion_uniques</term>
    ///     </item>
    ///     <item>
    ///         <term>conversion_value</term>
    ///     </item>
    ///     <item>
    ///         <term>conversions</term>
    ///     </item>
    ///     <item>
    ///         <term>delivered</term>
    ///     </item>
    ///     <item>
    ///         <term>delivery_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>failed</term>
    ///     </item>
    ///     <item>
    ///         <term>failed_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>open_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>opens</term>
    ///     </item>
    ///     <item>
    ///         <term>opens_unique</term>
    ///     </item>
    ///     <item>
    ///         <term>recipients</term>
    ///     </item>
    ///     <item>
    ///         <term>revenue_per_recipient</term>
    ///     </item>
    ///     <item>
    ///         <term>spam_complaint_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>spam_complaints</term>
    ///     </item>
    ///     <item>
    ///         <term>unsubscribe_rate</term>
    ///     </item>
    ///     <item>
    ///         <term>unsubscribe_uniques</term>
    ///     </item>
    ///     <item>
    ///         <term>unsubscribes</term>
    ///     </item>
    /// </list>
    /// </summary>
    public string[]? Statistics { get; set; }

    /// <summary>
    /// The timeframe to query for data within. The max length a timeframe can be is 1 year
    /// </summary>
    public ReportingRequestTimeframe? Timeframe { get; set; }

    /// <summary>
    /// The interval used to aggregate data within the series request.
    /// If hourly is used, the timeframe cannot be longer than 7 days.
    /// If daily is used, the timeframe cannot be longer than 60 days.
    /// If monthly is used, the timeframe cannot be longer than 52 weeks.
    /// <list type="bullet">
    ///     <item>
    ///         <term>daily</term>
    ///     </item>
    ///     <item>
    ///         <term>hourly</term>
    ///     </item>
    ///     <item>
    ///         <term>weekly</term>
    ///     </item>
    ///     <item>
    ///         <term>monthly</term>
    ///     </item>
    /// </list>
    /// </summary>
    public string? Interval { get; set; }

    /// <summary>
    /// ID of the metric to be used for conversion statistics
    /// </summary>
    public string? ConversionMetricId { get; set; }

    /// <summary>
    /// API filter string used to filter the query.
    /// Allowed filters are send_channel, campaign_id.
    /// Allowed operators are equals, contains-any.
    /// Only one filter can be used per attribute, only AND can be used as a combination operator.
    /// Max of 100 messages per ANY filter.
    /// </summary>
    public IFilter? Filter { get; set; } = null;
}
