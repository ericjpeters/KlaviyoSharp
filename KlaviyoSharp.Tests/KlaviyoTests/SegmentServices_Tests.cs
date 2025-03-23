using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "SegmentServices")]
public class SegmentServices_Tests : IClassFixture<SegmentServices_Tests_Fixture>
{
    private SegmentServices_Tests_Fixture Fixture { get; }

    public SegmentServices_Tests(SegmentServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetSegments()
    {
        var result = await Fixture.AdminApi.SegmentServices.GetSegments();
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        var res = await Fixture.AdminApi.SegmentServices.GetSegment(result.Data?[0].Id);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);

        var tags = await Fixture.AdminApi.SegmentServices.GetSegmentTags(result.Data?[0].Id);
        tags?.Data.ShouldNotBeNull();

        var profiles = await Fixture.AdminApi.SegmentServices.GetSegmentProfiles(result.Data?[0].Id);
        profiles.Data.ShouldNotBeNull();

        var RelationshipsTags = await Fixture.AdminApi.SegmentServices.GetSegmentRelationshipsTags(result.Data?[0].Id);
        RelationshipsTags?.Data.ShouldNotBeNull();

        var RelationshipsProfiles = await Fixture.AdminApi.SegmentServices.GetSegmentRelationshipsProfiles(result.Data?[0].Id);
        RelationshipsProfiles?.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task UpdateSegment()
    {
        var result = await Fixture.AdminApi.SegmentServices.GetSegments();
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        string NewName = $"Segment Name Updated {Config.Random}";
        var update = Models.Segment.Create();
        update.Attributes = new() { Name = NewName };
        update.Id = result.Data?[0].Id;
        var updated = await Fixture.AdminApi.SegmentServices.UpdateSegment(result.Data?[0].Id, update);
        updated?.Data?.Attributes?.Name.ShouldBe(NewName);
    }
}

public class SegmentServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
