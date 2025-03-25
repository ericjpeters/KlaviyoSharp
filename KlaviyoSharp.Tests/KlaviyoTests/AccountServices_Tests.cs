using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "AccountServices")]
public class AccountServices_Tests : IClassFixture<AccountServices_Tests_Fixture>
{
    private AccountServices_Tests_Fixture Fixture { get; }

    public AccountServices_Tests(AccountServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetAccounts()
    {
        Models.DataListObject<Models.Account>? accounts = await Fixture.AdminApi.AccountServices.GetAccounts(new List<string>() { "public_api_key" }, cancellationToken: CancellationToken.None);
        accounts.ShouldNotBeNull();
        accounts.Data.ShouldNotBeNull();
        accounts.Data.ShouldNotBeEmpty();

        Models.DataObject<Models.Account>? account = await Fixture.AdminApi.AccountServices.GetAccount(accounts.Data?[0].Id, new List<string>() { "public_api_key", "contact_information.street_address" }, cancellationToken: CancellationToken.None);
        account.ShouldNotBeNull();
        account.Data.ShouldNotBeNull();
        account.Data.Attributes.ShouldNotBeNull();
        account.Data.Attributes.ContactInformation.ShouldNotBeNull();
        account.Data.Attributes.PublicApiKey.ShouldNotBeNull();
    }
}
