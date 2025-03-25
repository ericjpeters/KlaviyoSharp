using KlaviyoSharp.Models;

namespace KlaviyoSharp.Tests;

public class ProfileServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public readonly int SleepTime = 1000;
    public readonly int Retries = 30;

    public Profile NewProfile
    {
        get
        {
            Profile output = Profile.Create();
            output.Attributes = new()
            {
                Email = $"test{Config.Random}@example.com",
                FirstName = $"Test-{Config.Random}",
                LastName = "Name"
            };
            return output;
        }
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
