namespace KlaviyoSharp.Models;

/// <summary>
/// A profile's predictive analytics
/// </summary>
public class ProfilePredictiveAnalytics
{
    /// <summary>
    /// Total value of all historically placed orders
    /// </summary>
    public decimal HistoricClv { get; set; }

    /// <summary>
    /// Predicted value of all placed orders in the next 365 days
    /// </summary>
    public decimal PredictedClv { get; set; }

    /// <summary>
    /// Sum of historic and predicted CLV
    /// </summary>
    public decimal TotalClv { get; set; }

    /// <summary>
    /// Sum of historic and predicted CLV
    /// </summary>
    public int HistoricNumberOfOrders { get; set; }

    /// <summary>
    /// Predicted number of placed orders in the next 365 days
    /// </summary>
    public decimal PredictedNumberOfOrders { get; set; }

    /// <summary>
    /// Average number of days between orders (None if only one order has been placed)
    /// </summary>
    public decimal AverageDaysBetweenOrders { get; set; }

    /// <summary>
    /// Average value of placed orders
    /// </summary>
    public decimal AverageOrderValue { get; set; }

    /// <summary>
    /// Probability the customer has churned
    /// </summary>
    public decimal ChurnProbability { get; set; }

    /// <summary>
    /// Expected date of next order, as calculated at the time of their most recent order
    /// </summary>
    public DateTime? ExpectedDateOfNextOrder { get; set; }
}
