using KlaviyoSharp.Models.Filters;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "CampaignServices")]
public class CampaignServices_Tests : IClassFixture<CampaignServices_Tests_Fixture>
{
    private CampaignServices_Tests_Fixture Fixture { get; }

    public CampaignServices_Tests(CampaignServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetCampaigns()
    {
        Models.DataListObjectWithIncluded<Models.Campaign>? campaigns = await Fixture.AdminApi.CampaignServices.GetCampaigns(new Filter(FilterOperation.Equals, "messages.channel", "email"), cancellationToken: CancellationToken.None);
        campaigns.ShouldNotBeNull();
    }
}
