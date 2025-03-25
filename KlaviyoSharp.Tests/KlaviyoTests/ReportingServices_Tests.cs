using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "ReportingServices")]
public class ReportingServices_Tests : IClassFixture<ReportingServices_Tests_Fixture>
{
    private ReportingServices_Tests_Fixture Fixture { get; }

    public ReportingServices_Tests(ReportingServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task QueryCampaignValues()
    {
        DataListObject<Metric>? metricList = await Fixture.AdminApi.MetricServices.GetMetrics(cancellationToken: CancellationToken.None);
        Metric? metric = metricList?.Data?.First(x => x.Attributes?.Name?.CompareTo("Received Email") == 0);

        ReportingRequest output = ReportingRequest.CreateCampaignValuesReport();
        output.Attributes = new()
        {
            Statistics = ["opens", "open_rate"],
            ConversionMetricId = metric?.Id,
            Timeframe = new()
            {
                Key = "last_12_months",
            }
        };

        DataObjectWithNavigate<Reporting>? result = await Fixture.AdminApi.ReportingServices.QueryCampaignValues(output, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task QueryFlowValues()
    {
        DataListObject<Metric>? metricList = await Fixture.AdminApi.MetricServices.GetMetrics(cancellationToken: CancellationToken.None);
        Metric? metric = metricList?.Data?.First(x => x.Attributes?.Name?.CompareTo("Received Email") == 0);

        ReportingRequest output = ReportingRequest.CreateFlowValuesReport();
        output.Attributes = new()
        {
            Statistics = ["opens", "open_rate"],
            ConversionMetricId = metric?.Id,
            Timeframe = new()
            {
                Key = "last_12_months",
            }
        };

        DataObjectWithNavigate<Reporting>? result = await Fixture.AdminApi.ReportingServices.QueryFlowValues(output, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task QueryFlowSeries()
    {
        DataListObject<Metric>? metricList = await Fixture.AdminApi.MetricServices.GetMetrics(cancellationToken: CancellationToken.None);
        Metric? metric = metricList?.Data?.First(x => x.Attributes?.Name?.CompareTo("Received Email") == 0);

        ReportingRequest output = ReportingRequest.CreateFlowSeriesReport();
        output.Attributes = new()
        {
            Statistics = ["opens", "open_rate"],
            ConversionMetricId = metric?.Id,
            Interval = "monthly",
            Timeframe = new()
            {
                Key = "last_12_months",
            }
        };

        DataObjectWithNavigate<Reporting>? result = await Fixture.AdminApi.ReportingServices.QueryFlowSeries(output, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
    }
}
