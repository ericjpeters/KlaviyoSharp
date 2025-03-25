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
        DataListObject<Profile> result = await Fixture.AdminApi.ProfileServices.GetProfiles(sort: "email", cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        DataObjectWithIncluded<Profile>? res = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);
    }

    [Fact]
    public async Task CreateAndUpdateProfile()
    {
        DataObject<Profile>? result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        string NewName = "Name Updated";
        PatchProfile update = PatchProfile.Create();
        update.Attributes = new() { LastName = NewName };
        update.Id = result.Data?.Id;
        update.Attributes.Properties = new Dictionary<string, object>() {
                { "$organization", "XXXX Co" },
                { "custom property", "test-prop" },
            };

        DataObject<Profile>? updated = await Fixture.AdminApi.ProfileServices.UpdateProfile(result.Data?.Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.LastName.ShouldBe(NewName);
    }

    [Fact]
    public async Task CreateOrUpdateProfile()
    {
        DataObject<Profile>? result = await Fixture.AdminApi.ProfileServices.CreateOrUpdateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        string NewName = "Name Updated";
        PatchProfile update = PatchProfile.Create();
        update.Attributes = new() { LastName = NewName };
        update.Id = result.Data?.Id;

        DataObject<Profile>? updated = await Fixture.AdminApi.ProfileServices.CreateOrUpdateProfile(update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.LastName.ShouldBe(NewName);
    }

    [Fact]
    public async Task MergeProfiles()
    {
        DataObject<Profile>? oldProfile = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        oldProfile.ShouldNotBeNull();

        DataObject<Profile>? newProfile = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        newProfile.ShouldNotBeNull();

        DataObject<ProfileMerge>? updated = await Fixture.AdminApi.ProfileServices.MergeProfiles([oldProfile], newProfile, cancellationToken: CancellationToken.None);
        updated?.Data?.Id.ShouldBe(newProfile.Data?.Id);

        KlaviyoException? exception = null;
        int retryCount = 0;
        do
        {
            try
            {
                await Fixture.AdminApi.ProfileServices.GetProfile(oldProfile.Data?.Id, cancellationToken: CancellationToken.None);
                Thread.Sleep(Fixture.SleepTime);
                retryCount++;
            }
            catch (KlaviyoException ex)
            {
                exception = ex;
            }
        }
        while ((retryCount <= Fixture.Retries) && (exception == null));

        exception.ShouldNotBeNull();
        exception.Message.ShouldBe($"A profile with id {oldProfile.Data?.Id} does not exist.");
    }

    [Fact]
    public async Task SuppressProfiles()
    {
        //Create new profile to test supression
        DataObject<Profile>? result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        //Suppress profile and check
        ProfileSuppressionRequest request = ProfileSuppressionRequest.Create();
        request.Attributes = new()
        {
            Profiles = new()
            {
                Data = new() { new() { Type = "profile", Attributes = new() { Email = result.Data?.Attributes?.Email } } }
            }
        };
        await Fixture.AdminApi.ProfileServices.SuppressProfiles(request, cancellationToken: CancellationToken.None);

        await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, cancellationToken: CancellationToken.None);

        //Unsuppress profile and check
        ProfileUnsuppressionRequest request2 = ProfileUnsuppressionRequest.Create();
        request2.Attributes = new()
        {
            Profiles = new()
            {
                Data = new() { new() { Type = "profile", Attributes = new() { Email = result.Data?.Attributes?.Email } } }
            }

        };
        await Fixture.AdminApi.ProfileServices.UnsuppressProfiles(request2, cancellationToken: CancellationToken.None);
        Thread.Sleep(Fixture.SleepTime);

        await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task SubscribeProfiles()
    {
        //Create new profile to test subscription
        DataObject<Profile>? result = await Fixture.AdminApi.ProfileServices.CreateProfile(Fixture.NewProfile, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        DataListObject<List> x = await Fixture.AdminApi.ListServices.GetLists(new() { "id" }, new Filter(FilterOperation.Equals, "name", "Sample Data List"), cancellationToken: CancellationToken.None);
        string? ListId = x.Data?[0].Id;
        ListId.ShouldNotBeNull();
        ListId.ShouldNotBeEmpty();

        //Subscribe profile and check
        ProfileSubscriptionRequest request = ProfileSubscriptionRequest.Create();
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

        await Fixture.AdminApi.ProfileServices.SubscribeProfiles(request, cancellationToken: CancellationToken.None);
        int checkCount = 0;

        //Because the call is async, check a couple of times with a delay. This should fix failing tests.
        DataObject<Profile>? check;
        do
        {
            if (checkCount > 0)
            {
                Thread.Sleep(Fixture.SleepTime);
            }

            checkCount++;
            check = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, listFields: new() { "id" }, includedObjects: new() { "lists" }, cancellationToken: CancellationToken.None);
        }
        while ((checkCount <= Fixture.Retries) && !(check?.Data?.Relationships?.Lists?.Data?.Any(x => x.Id?.CompareTo(ListId) == 0) ?? false));

        (check?.Data?.Relationships?.Lists?.Data ?? []).ShouldContain(x => (x.Id != null) && (x.Id.CompareTo(ListId) == 0));

        //Unsubscribe profile and check
        ProfileUnsubscriptionRequest request2 = ProfileUnsubscriptionRequest.Create();
        request2.Attributes = new()
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
                                        Consent = "UNSUBSCRIBED"
                                    }
                                }
                            }
                        }
                    }
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

        await Fixture.AdminApi.ProfileServices.UnsubscribeProfiles(request2, cancellationToken: CancellationToken.None);

        //Because the call is async, check a couple of times with a delay. This should fix failing tests.
        DataObject<Profile>? final;
        checkCount = 0;
        do
        {
            if (checkCount > 0)
            {
                Thread.Sleep(Fixture.SleepTime);
            }

            checkCount++;
            final = await Fixture.AdminApi.ProfileServices.GetProfile(result.Data?.Id, listFields: new() { "id" }, includedObjects: new() { "lists" }, cancellationToken: CancellationToken.None);
        } while (checkCount <= Fixture.Retries && (final?.Data?.Relationships?.Lists?.Data?.Any(x => x.Id?.CompareTo(ListId) == 0) ?? false));

        (final?.Data?.Relationships?.Lists?.Data ?? []).ShouldNotContain(x => (x.Id != null) && (x.Id.CompareTo(ListId) == 0));
    }

    [Fact]
    public async Task GetProfileLists()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?[0];
        DataListObject<List>? result = await Fixture.AdminApi.ProfileServices.GetProfileLists(profile?.Id, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileSegments()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?[0];
        DataListObject<List>? result = await Fixture.AdminApi.ProfileServices.GetProfileSegments(profile?.Id, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileRelationshipsLists()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?[0];
        DataListObject<GenericObject>? result = await Fixture.AdminApi.ProfileServices.GetProfileRelationshipsLists(profile?.Id, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetProfileRelationshipsSegments()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?[0];
        DataListObject<GenericObject>? result = await Fixture.AdminApi.ProfileServices.GetProfileRelationshipsSegments(profile?.Id, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
    }
}
