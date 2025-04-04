using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "General")]
public class General_Tests : IClassFixture<General_Tests_Fixture>
{
    [Fact]
    public async Task TooManyRetries()
    {
        // Get Accounts endoint is limited to 1 request per second. Easy one to force a retry on.
        KlaviyoAdminApi AdminApi = new(new KlaviyoConfig(Config.ApiKey) { MaxRetries = 0, MaxDelay = 1 });
        try
        {
            for (int i = 0; i < 10; i++)
            {
                await AdminApi.AccountServices.GetAccounts(cancellationToken: CancellationToken.None);
            }
        }
        catch (ApplicationException ex)
        {
            ex.Message.ShouldContain("Too many retries");
        }
    }

    [Fact]
    public async Task RetryTooLong()
    {
        // Get Accounts endoint is limited to 1 request per second. Easy one to force a retry on.
        KlaviyoAdminApi AdminApi = new(new KlaviyoConfig(Config.ApiKey) { MaxRetries = 10, MaxDelay = 1 });
        try
        {
            for (int i = 0; i < 10; i++)
            {
                await AdminApi.AccountServices.GetAccounts(cancellationToken: CancellationToken.None);
            }
        }
        catch (ApplicationException ex)
        {
            ex.Message.ShouldContain("Retry-After is too high");
        }
    }
}
