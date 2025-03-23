using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "ProfileServices")]
public class ProfileServices_Tests : IClassFixture<ProfileServices_Tests_Fixture>
{
    private ProfileServices_Tests_Fixture Fixture { get; }

    public ProfileServices_Tests(ProfileServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetProfiles()
    {
        var result = await Fixture.AdminApi.ProfileServices.GetProfiles(sort: "email");
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        var res = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?[0].Id);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);
    }

    [Fact]
    public async Task CreateAndUpdateProfile()
    {
        var result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile);
        result.ShouldNotBeNull();

        string NewName = "Name Updated";
        var update = PatchProfile.Create();
        update.Attributes = new() { LastName = NewName };
        update.Id = result.Data?.Id;
        update.Attributes.Properties = new Dictionary<string, object>() {
                { "$organization", "XXXX Co" },
                { "custom property", "test-prop" },
            };
        
        var updated = await Fixture.AdminApi.ProfileServices.UpdateProfile(result.Data?.Id, update);
        updated?.Data?.Attributes?.LastName.ShouldBe(NewName);
    }

    [Fact]
    public async Task CreateOrUpdateProfile()
    {
        var result = await Fixture.AdminApi.ProfileServices.CreateOrUpdateProfile(Fixture.NewProfile);
        result.ShouldNotBeNull();

        string NewName = "Name Updated";
        var update = PatchProfile.Create();
        update.Attributes = new() { LastName = NewName };
        update.Id = result.Data?.Id;
        
        var updated = await Fixture.AdminApi.ProfileServices.CreateOrUpdateProfile(update);
        updated?.Data?.Attributes?.LastName.ShouldBe(NewName);
    }

    [Fact]
    public async Task MergeProfiles()
    {
        var oldProfile = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile);
        oldProfile.ShouldNotBeNull();

        var newProfile = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile);
        newProfile.ShouldNotBeNull();

        var updated = await Fixture.AdminApi.ProfileServices.MergeProfiles([oldProfile], newProfile);
        updated?.Data?.Id.ShouldBe(newProfile.Data?.Id);

        var exception = await Should.ThrowAsync<KlaviyoException>(() => Fixture.AdminApi.ProfileServices.GetProfile(oldProfile.Data?.Id));        
        exception.Message.ShouldBe($"A profile with id {oldProfile.Data?.Id} does not exist.");
    }

    [Fact]
    public async Task SuppressProfiles()
    {
        //Create new profile to test supression
        DataObject<Profile>? result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile);
        result.ShouldNotBeNull();

        //Suppress profile and check
        var request = ProfileSuppressionRequest.Create();
        request.Attributes = new()
        {
            Profiles = new()
            {
                Data = new() { new() { Type = "profile", Attributes = new() { Email = result.Data?.Attributes?.Email } } }
            }
        };
        await Fixture.AdminApi.ProfileServices.SuppressProfiles(request);

        var check = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id);
        (check?.Data?.Attributes?.Subscriptions?.Email?.Marketing?.Suppression ?? []).ShouldContain(x => x.Reason == "USER_SUPPRESSED");

        //Unsuppress profile and check
        var request2 = ProfileUnsuppressionRequest.Create();
        request2.Attributes = new()
        {
            Profiles = new()
            {
                Data = new() { new() { Type = "profile", Attributes = new() { Email = result.Data?.Attributes?.Email } } }
            }

        };
        await Fixture.AdminApi.ProfileServices.UnsuppressProfiles(request2);
        Thread.Sleep(Fixture.SleepTime);

        var final = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id);
        (final?.Data?.Attributes?.Subscriptions?.Email?.Marketing?.Suppression ?? []).ShouldNotContain(x => x.Reason == "USER_SUPPRESSED");
    }

    [Fact]
    public async Task SubscribeProfiles()
    {
        //Create new profile to test subscription
        var result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile);
        result.ShouldNotBeNull();

        var x = await Fixture.AdminApi.ListServices.GetLists(new() { "id" }, new Filter(FilterOperation.Equals, "name", "Sample Data List"));
        var ListId = x.Data?[0].Id;
        ListId.ShouldNotBeNull();
        ListId.ShouldNotBeEmpty();

        //Subscribe profile and check
        var request = ProfileSubscriptionRequest.Create();
        request.Attributes = new()
        {
            Profiles = new()
            {
                Data = new()
                {
                    new() 
                    { 
                        Type = "profile", 
                        Attributes = new() 
                        { 
                            Email = result.Data?.Attributes?.Email,
                            Subscriptions = new()
                            {
                                Email = new() 
                                {
                                    Marketing = new()
                                    { 
                                        Consent = "SUBSCRIBED"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        request.Relationships = new()
        {
            List = new()
            {
                Data = new() { Type = "list", Id = ListId }
            }
        };

        await Fixture.AdminApi.ProfileServices.SubscribeProfiles(request);
        int checkCount = 0;

        //Because the call is async, check a couple of times with a delay. This should fix failing tests.
        DataObject<Profile>? check;
        do
        {
            if (checkCount > 0) Thread.Sleep(Fixture.SleepTime);
            checkCount++;
            check = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, listFields: new() { "id" }, includedObjects: new() { "lists" });

        } while (checkCount <= Fixture.Retries && !(check?.Data?.Relationships?.Lists?.Data?.Any(x => x.Id == ListId) ?? false));

        (check?.Data?.Relationships?.Lists?.Data ?? []).ShouldContain(x => x.Id == ListId);

        //Unsubscribe profile and check
        var request2 = ProfileUnsubscriptionRequest.Create();
        request2.Attributes = new()
        {
            Profiles = new()
            {
                Data = new() {
                    new() { Type = "profile", Attributes = new() { Email = result.Data?.Attributes?.Email } }
                }
            }
        };
        request2.Relationships = new()
        {
            List = new()
            {
                Data = new() { Type = "list", Id = ListId }
            }
        };
        await Fixture.AdminApi.ProfileServices.UnsuscribeProfiles(request2);

        //Because the call is async, check a couple of times with a delay. This should fix failing tests.
        DataObject<Profile>? final;
        checkCount = 0;
        do
        {
            if (checkCount > 0) Thread.Sleep(Fixture.SleepTime);
            checkCount++;
            final = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, listFields: new() { "id" }, includedObjects: new() { "lists" });
        } while (checkCount <= Fixture.Retries && (final?.Data?.Relationships?.Lists?.Data?.Any(x => x.Id == ListId) ?? false));

        (final?.Data?.Relationships?.Lists?.Data ?? []).ShouldNotContain(x => x.Id == ListId);
    }

    [Fact]
    public async Task GetProfileLists()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?[0];
        var result = await Fixture.AdminApi.ProfileServices.GetProfileLists(profile?.Id);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileSegments()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?[0];
        var result = await Fixture.AdminApi.ProfileServices.GetProfileSegments(profile?.Id);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileRelationshipsLists()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?[0];
        var result = await Fixture.AdminApi.ProfileServices.GetProfileRelationshipsLists(profile?.Id);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileRelationshipsSegments()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?[0];
        var result = await Fixture.AdminApi.ProfileServices.GetProfileRelationshipsSegments(profile?.Id);
        result.ShouldNotBeNull();
    }
}

public class ProfileServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public readonly int SleepTime = 1000;
    public readonly int Retries = 3;

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
