namespace KlaviyoSharp.Tests;

public class AccountServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(new KlaviyoConfig(Config.ApiKey) { MaxDelay = 120, MaxRetries = 5 });

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
