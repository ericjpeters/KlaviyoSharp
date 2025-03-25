using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "TagServices")]
public class TagServices_Tests : IClassFixture<TagServices_Tests_Fixture>
{
    private TagServices_Tests_Fixture Fixture { get; }

    public TagServices_Tests(TagServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetTags()
    {
        Models.DataListObject<Models.Tag> tags = await Fixture.AdminApi.TagServices.GetTags(cancellationToken: CancellationToken.None);
        tags.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetTagGroups()
    {
        Models.DataListObject<Models.TagGroup> tagGroups = await Fixture.AdminApi.TagServices.GetTagGroups(cancellationToken: CancellationToken.None);
        tagGroups.ShouldNotBeNull();
    }
}
