using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "EventServices")]
public class EventServices_Tests : IClassFixture<EventServices_Tests_Fixture>
{
    private EventServices_Tests_Fixture Fixture { get; }

    public EventServices_Tests(EventServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    //Add Tests Here
    [Fact]
    public async Task GetEvents()
    {
        DataListObjectWithIncluded<Event> result = await Fixture.AdminApi.EventServices.GetEvents(cancellationToken: CancellationToken.None);
        string? eventId = result.Data?[0].Id;
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        DataObjectWithIncluded<Event>? result2 = await Fixture.AdminApi.EventServices.GetEvent(eventId, cancellationToken: CancellationToken.None);
        result2?.Data?.Id.ShouldBe(eventId);

        DataObject<Metric>? result3 = await Fixture.AdminApi.EventServices.GetEventMetric(eventId, cancellationToken: CancellationToken.None);
        result3?.Data.ShouldNotBeNull();

        DataObject<Profile>? result4 = await Fixture.AdminApi.EventServices.GetEventProfile(eventId, cancellationToken: CancellationToken.None);
        result4?.Data.ShouldNotBeNull();

        DataObject<GenericObject>? result5 = await Fixture.AdminApi.EventServices.GetEventRelationshipsMetric(eventId, cancellationToken: CancellationToken.None);
        result5?.Data.ShouldNotBeNull();

        DataObject<GenericObject>? result6 = await Fixture.AdminApi.EventServices.GetEventRelationshipsProfile(eventId, cancellationToken: CancellationToken.None);
        result6?.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task CreateEvent()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?.First();

        EventRequest newEvent = EventRequest.Create();
        Profile profile1 = Profile.Create();
        profile1.Attributes = new()
        {
            Email = profile?.Attributes?.Email
        };

        Metric metric = Metric.Create();
        metric.Attributes = new()
        {
            Name = "C# Test"
        };

        newEvent.Attributes = new()
        {
            Profile = new(profile1),
            Metric = new(metric),
            Time = DateTime.Now,
            Value = 12.99,
            UniqueId = Guid.NewGuid().ToString(),
            Properties = new() { { "test", "test" } }
        };

        await Fixture.AdminApi.EventServices.CreateEvent(newEvent, cancellationToken: CancellationToken.None);
    }
}
