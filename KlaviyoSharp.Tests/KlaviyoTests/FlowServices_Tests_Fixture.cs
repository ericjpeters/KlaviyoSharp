namespace KlaviyoSharp.Tests;

public class FlowServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public string? FlowId { get; set; }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        FlowId = AdminApi.FlowServices.GetFlows(cancellationToken: CancellationToken.None).Result.Data?.First().Id;
        return Task.CompletedTask;
    }
}
