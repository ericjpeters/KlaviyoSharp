namespace KlaviyoSharp.Tests;

public class General_Tests_Fixture : IAsyncLifetime
{
    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
