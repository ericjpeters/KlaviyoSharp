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
        var result = await Fixture.AdminApi.EventServices.GetEvents();
        var eventId = result.Data?[0].Id;
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();
        
        var result2 = await Fixture.AdminApi.EventServices.GetEvent(eventId);
        result2?.Data?.Id.ShouldBe(eventId);

        var result3 = await Fixture.AdminApi.EventServices.GetEventMetric(eventId);
        result3?.Data.ShouldNotBeNull();

        var result4 = await Fixture.AdminApi.EventServices.GetEventProfile(eventId);
        result4?.Data.ShouldNotBeNull();

        var result5 = await Fixture.AdminApi.EventServices.GetEventRelationshipsMetric(eventId);
        result5?.Data.ShouldNotBeNull();

        var result6 = await Fixture.AdminApi.EventServices.GetEventRelationshipsProfile(eventId);
        result6?.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task CreateEvent()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?.First();

        var newEvent = EventRequest.Create();
        var profile1 = Profile.Create();
        profile1.Attributes = new()
        {
            Email = profile?.Attributes?.Email
        };

        var metric = Metric.Create();
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

        await Fixture.AdminApi.EventServices.CreateEvent(newEvent);
    }
}

public class EventServices_Tests_Fixture : IAsyncLifetime
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
