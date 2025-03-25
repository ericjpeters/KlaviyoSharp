using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "MetricServices")]
public class MetricServices_Tests : IClassFixture<MetricServices_Tests_Fixture>
{
    private MetricServices_Tests_Fixture Fixture { get; }

    public MetricServices_Tests(MetricServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetMetrics()
    {
        Models.DataListObject<Models.Metric>? result = await Fixture.AdminApi.MetricServices.GetMetrics(cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        Models.DataObject<Models.Metric>? res = await Fixture.AdminApi.MetricServices.GetMetric(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);
    }

    [Fact]
    public async Task QueryMetricAggregate()
    {
        Models.DataListObject<Models.Metric>? metrics = await Fixture.AdminApi.MetricServices.GetMetrics(cancellationToken: CancellationToken.None);
        Models.Metric? metric = metrics?.Data?.FirstOrDefault(x => x.Attributes?.Name?.CompareTo("C# Test") == 0);
        metric.ShouldNotBeNull();

        Models.MetricAggregateQuery metricAggregateQuery = Models.MetricAggregateQuery.Create();
        metricAggregateQuery.Attributes = new()
        {
            MetricId = metric.Id,
            Measurements = new List<string> { "count", "sum_value", "unique" },
            Interval = "month",
            Filter = new List<string> {
                new Models.Filters.Filter(Models.Filters.FilterOperation.GreaterOrEqual, "datetime", DateTime.UtcNow.AddMonths(-1)).ToString(),
                new Models.Filters.Filter(Models.Filters.FilterOperation.LessThan, "datetime", DateTime.UtcNow).ToString(),

            }
        };
        Models.DataObject<Models.MetricAggregate>? result = await Fixture.AdminApi.MetricServices.QueryMetricAggregate(metricAggregateQuery, cancellationToken: CancellationToken.None);
        result?.Data?.Attributes?.Data.ShouldNotBeNull();
        result?.Data?.Attributes?.Data.ShouldNotBeEmpty();
    }
}
