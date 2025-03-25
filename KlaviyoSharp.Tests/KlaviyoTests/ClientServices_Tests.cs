using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;
using Shouldly;

namespace KlaviyoSharp.Tests;

/// <summary>
/// Klaviyo API Client Tests. Only tests the /client endpoints.
/// </summary>
[Trait("Category", "ClientServices")]
public class ClientServices_Tests : IClassFixture<ClientServices_Tests_Fixture>
{
    private ClientServices_Tests_Fixture Fixture { get; }
    public ClientServices_Tests(ClientServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task CreateEvent()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?.First();
        EventRequest newEvent = EventRequest.Create();
        Profile profile1 = Profile.Create();
        profile1.Attributes = new() { Email = profile?.Attributes?.Email };
        Metric metric = Metric.Create();
        metric.Attributes = new() { Name = "C# Test" };
        newEvent.Attributes = new()
        {
            Profile = new(profile1),
            Metric = new(metric),
            Time = DateTime.Now,
            Value = 12.99,
            UniqueId = Guid.NewGuid().ToString(),
            Properties = new() { { "test", "test" } }
        };

        await Fixture.ClientApi.ClientServices.CreateEvent(newEvent, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task CreateSubscription()
    {
        DataListObject<List> list = await Fixture.AdminApi.ListServices.GetLists(new() { "id" }, new Filter(FilterOperation.Equals, "name", "Sample Data List"), cancellationToken: CancellationToken.None);
        string? _listId = list.Data?.FirstOrDefault()?.Id;

        Profile profile = Profile.Create();
        profile.Attributes = new() { Email = "test@test.com" };
        ClientSubscription newSubscription = ClientSubscription.Create();
        newSubscription.Attributes = new()
        {
            CustomSource = "C# Test",
            Profile = new(profile)
        };
        newSubscription.Relationships = new()
        {
            List = new(new() { Type = "list", Id = _listId })
        };

        await Fixture.ClientApi.ClientServices.CreateSubscription(newSubscription, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task UpsertProfile()
    {
        ClientProfile newProfile = ClientProfile.Create();
        newProfile.Id = "01H42N4KX4N2NV2CT2595KCG6Z";
        newProfile.Attributes = new()
        {
            Email = "test@test.com",
            FirstName = "Test",
            LastName = "Profile",
            ExternalId = "TestAccount",
            Organization = "Test Organization",
            Title = "Test Title",
            Image = "https://dummyimage.com/300",
            Location = new()
            {
                Address1 = "1 Main St",
                Address2 = "Suite 101",
                Latitude = 42.35843,
                Longitude = -71.05977,
                Timezone = "America/New_York",
                City = "Boston",
                Region = "MA",
                Country = "USA",
                Zip = "02110"
            },
            Properties = new() { { "Last Test", DateTime.Now.ToString() } }
        };

        await Fixture.ClientApi.ClientServices.UpsertProfile(newProfile, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task PushTokens()
    {
        //GitHub Issue #12 tracks an issue with this test.
        //Should be able to confirm that the endpoint is working with a correctly configured account and request.

        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?.First();
        Profile tokenProfile = Profile.Create();
        tokenProfile.Attributes = new() { Email = profile?.Attributes?.Email };
        PushToken pushToken = PushToken.Create();
        pushToken.Attributes = new()
        {
            Token = "1234567890",
            Platform = "android",
            EnablementStatus = "AUTHORIZED",
            Vendor = "apns",
            Background = "AVAILABLE",
            Profile = new(tokenProfile),
            DeviceMetadata = new()
            {
                DeviceId = "1234567890",
                KlaviyoSdk = "swift",
                SdkVersion = "1.0.0",
                DeviceModel = "iPhone12,1",
                OsName = "ios",
                OsVersion = "14.0",
                Manufacturer = "Apple",
                AppName = "KlaviyoSharp",
                AppVersion = System.Reflection.Assembly.GetAssembly(typeof(KlaviyoClientApi))?.GetName().Version?.ToString(),
                AppBuild = "1",
                AppId = "com.test.app",
                Environment = "debug"
            }
        };

        try
        {
            await Fixture.ClientApi.ClientServices.CreateOrUpdateClientPushToken(pushToken, cancellationToken: CancellationToken.None);
        }
        catch (KlaviyoException ex)
        {
            ex.ShouldNotBeNull();
            ex.Message.ShouldBe("Company is not able to process push tokens");
        }

        PushTokenUnregister pushTokenUnregister = PushTokenUnregister.Create();
        pushTokenUnregister.Attributes = new()
        {
            Token = pushToken.Attributes.Token,
            Platform = pushToken.Attributes.Platform,
            Vendor = pushToken.Attributes.Vendor,
            Profile = new(tokenProfile)
        };

        try
        {
            await Fixture.ClientApi.ClientServices.UnregisterClientPushToken(pushTokenUnregister, cancellationToken: CancellationToken.None);
        }
        catch (KlaviyoException ex)
        {
            // Catch the exception if the company is not setup for push tokens.
            ex.ShouldNotBeNull();
            ex.Message.ShouldBe("Company is not able to process push tokens");
        }
    }

    [Fact]
    public async Task BulkCreateEvents()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?[0];
        ClientEventBulkCreate bulkEventRequest = ClientEventBulkCreate.Create();
        bulkEventRequest.Attributes = new()
        {
            Profile = new(new() { Type = "profile", Attributes = new() { Email = profile?.Attributes?.Email } }),
            Events = new()
            {
                Data = new(){
                new(){
                    Type="event",
                    Attributes = new(){
                        Properties = new(),
                        Metric = new(new(){
                            Type = "metric",
                            Attributes = new(){
                                Name = "C# Test"
                            }
                            } )
                        },
                    }
                }
            }
        };

        await Fixture.ClientApi.ClientServices.BulkCreateClientEvents(bulkEventRequest, cancellationToken: CancellationToken.None);
    }
}
