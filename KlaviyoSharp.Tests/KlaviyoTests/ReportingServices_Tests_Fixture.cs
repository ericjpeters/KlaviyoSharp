using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;

namespace KlaviyoSharp.Tests;

public class ReportingServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public readonly int SleepTime = 1000;
    public readonly int Retries = 30;

#if REMOVED_2025_01_15
    public ReportingRequest NewCampaignValuesReport
    {
        get
        {
            ReportingRequest output = ReportingRequest.CreateCampaignValuesReport();
            output.Attributes = new()
            {
                Statistics = ["opens", "open_rate"],
                Filter = new FilterList()
                {
                },
                Timeframe = new()
                {
                    Key = "last_12_months",
                }
            };
            return output;
        }
    }

    public ReportingRequest NewFlowValuesReport
    {
        get
        {
            ReportingRequest output = ReportingRequest.CreateFlowValuesReport();
            output.Attributes = new()
            {
                Filter = new FilterList()
                {
                },
                Timeframe = new()
                {
                    Key = "last_12_months",
                }
            };
            return output;
        }
    }

    public ReportingRequest NewFlowSeriesReport
    {
        get
        {
            ReportingRequest output = ReportingRequest.CreateFlowSeriesReport();
            output.Attributes = new()
            {
                Filter = new FilterList()
                {
                },
                Timeframe = new()
                {
                    Key = "last_12_months",
                },
                Interval = "weekly"
            };
            return output;
        }
    }

    public CouponCode NewCouponCode
    {
        get
        {
            CouponCode output = CouponCode.Create();
            output.Attributes = new()
            {
                UniqueCode = $"test{Config.Random}",
            };

            return output;
        }
    }
#endif

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
