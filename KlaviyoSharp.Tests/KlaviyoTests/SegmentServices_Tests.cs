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
        Models.DataListObject<Models.Segment> result = await Fixture.AdminApi.SegmentServices.GetSegments(cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        Models.DataObject<Models.Segment>? res = await Fixture.AdminApi.SegmentServices.GetSegment(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);

        Models.DataListObject<Models.Tag>? tags = await Fixture.AdminApi.SegmentServices.GetSegmentTags(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        tags?.Data.ShouldNotBeNull();

        Models.DataListObject<Models.Profile> profiles = await Fixture.AdminApi.SegmentServices.GetSegmentProfiles(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        profiles.Data.ShouldNotBeNull();

        Models.DataListObject<Models.GenericObject>? RelationshipsTags = await Fixture.AdminApi.SegmentServices.GetSegmentRelationshipsTags(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        RelationshipsTags?.Data.ShouldNotBeNull();

        Models.DataListObject<Models.GenericObject>? RelationshipsProfiles = await Fixture.AdminApi.SegmentServices.GetSegmentRelationshipsProfiles(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        RelationshipsProfiles?.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task UpdateSegment()
    {
        Models.DataListObject<Models.Segment> result = await Fixture.AdminApi.SegmentServices.GetSegments(cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        string NewName = $"Segment Name Updated {Config.Random}";
        Models.Segment update = Models.Segment.Create();
        update.Attributes = new() { Name = NewName };
        update.Id = result.Data?[0].Id;
        Models.DataObject<Models.Segment>? updated = await Fixture.AdminApi.SegmentServices.UpdateSegment(result.Data?[0].Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.Name.ShouldBe(NewName);
    }
}
