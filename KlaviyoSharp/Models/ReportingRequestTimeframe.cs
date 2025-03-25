namespace KlaviyoSharp.Models;

/// <summary>
/// Reporting Timeframe
/// </summary>
public class ReportingRequestTimeframe
{
    /// <summary>
    /// <para>Possible values</para>
    /// <list type="bullet">
    ///     <item>
    ///         <term>last_year</term>
    ///         <description>Last year.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_12_months</term>
    ///         <description>Last 12 months.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_365_days</term>
    ///         <description>Last 365 days.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_3_months</term>
    ///         <description>Last 3 months.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_90_days</term>
    ///         <description>Last 90 days.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_month</term>
    ///         <description>Last month.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_30_days</term>
    ///         <description>Last 30 days.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_week</term>
    ///         <description>Last week.</description>
    ///     </item>
    ///     <item>
    ///         <term>last_7_days</term>
    ///         <description>Last 7 days.</description>
    ///     </item>
    ///     <item>
    ///         <term>this_month</term>
    ///         <description>This month.</description>
    ///     </item>
    ///     <item>
    ///         <term>this_week</term>
    ///         <description>This week.</description>
    ///     </item>
    ///     <item>
    ///         <term>this_year</term>
    ///         <description>This year.</description>
    ///     </item>
    ///     <item>
    ///         <term>yesterday</term>
    ///         <description>Yesterday.</description>
    ///     </item>
    ///     <item>
    ///         <term>today</term>
    ///         <description>Today.</description>
    ///     </item>
    /// </list>
    /// </summary>
    public string? Key { get; set; } = null;

    /// <summary>
    /// Date and time where timeframe shall start, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS)
    /// </summary>
    public DateTime? Start { get; set; } = null;

    /// <summary>
    /// Date and time where timeframe shall end, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS)
    /// </summary>
    public DateTime? End { get; set; } = null;
}
