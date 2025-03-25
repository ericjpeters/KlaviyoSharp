using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "ListServices")]
public class ListServices_Tests : IClassFixture<ListServices_Tests_Fixture>
{
    private ListServices_Tests_Fixture Fixture { get; }

    public ListServices_Tests(ListServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetLists()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetList()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataObject<Models.List>? list = await Fixture.AdminApi.ListServices.GetList(lists.Data?[0].Id, cancellationToken: CancellationToken.None);
        list.ShouldNotBeNull();
    }

    [Fact]
    public async Task CRUDList()
    {
        Models.List newList = Models.List.Create();
        newList.Attributes = new() { Name = $"Test List - {Config.Random}" };

        Models.DataObject<Models.List>? list = await Fixture.AdminApi.ListServices.CreateList(newList, cancellationToken: CancellationToken.None);
        list.ShouldNotBeNull();

        Models.List newList2 = Models.List.Create();
        newList2.Id = list.Data?.Id;
        newList2.Attributes = new() { Name = $"{list.Data?.Attributes?.Name} - Updated" };

        Models.DataObject<Models.List>? updatedList = await Fixture.AdminApi.ListServices.UpdateList(list.Data?.Id, newList2, cancellationToken: CancellationToken.None);
        updatedList.ShouldNotBeNull();
        updatedList.Data?.Id.ShouldBe(list.Data?.Id);

        await Fixture.AdminApi.ListServices.DeleteList(list.Data?.Id, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task GetListTags()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.Tag>? tags = await Fixture.AdminApi.ListServices.GetListTags(lists.Data?[0].Id, cancellationToken: CancellationToken.None);
        tags.ShouldNotBeNull();
    }

    [Fact]
    public async Task AddProfileToList()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.Profile> profiles = await Fixture.AdminApi.ProfileServices.GetProfiles(null, null, null, null, cancellationToken: CancellationToken.None);
        profiles.ShouldNotBeNull();
        profiles.Data.ShouldNotBeNull();
        profiles.Data.ShouldNotBeEmpty();

        await Fixture.AdminApi.ListServices.AddProfileToList(lists.Data?[0].Id, new List<string?>() { profiles.Data?[0].Id }, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task RemoveProfileFromList()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.Profile> profiles = await Fixture.AdminApi.ProfileServices.GetProfiles(null, null, null, null, cancellationToken: CancellationToken.None);
        profiles.ShouldNotBeNull();
        profiles.Data.ShouldNotBeNull();
        profiles.Data.ShouldNotBeEmpty();

        await Fixture.AdminApi.ListServices.AddProfileToList(lists.Data?[0].Id, new List<string?>() { profiles.Data?[0].Id }, cancellationToken: CancellationToken.None);
        await Fixture.AdminApi.ListServices.RemoveProfileFromList(lists.Data?[0].Id, new List<string?>() { profiles.Data?[0].Id }, cancellationToken: CancellationToken.None);
    }

    [Fact]
    public async Task GetListProfiles()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.Profile> profiles = await Fixture.AdminApi.ListServices.GetListProfiles(lists.Data?[0].Id, cancellationToken: CancellationToken.None);
        profiles.ShouldNotBeNull();
        profiles.Data.ShouldNotBeNull();
        profiles.Data.ShouldNotBeEmpty();
    }

    [Fact]
    public async Task GetListRelationshipsTags()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.GenericObject>? relationships = await Fixture.AdminApi.ListServices.GetListRelationshipsTags(lists.Data?[0].Id, cancellationToken: CancellationToken.None);
        relationships.ShouldNotBeNull();
    }

    [Fact]
    public async Task GetListRelationshipsProfiles()
    {
        Models.DataListObject<Models.List> lists = await Fixture.AdminApi.ListServices.GetLists(cancellationToken: CancellationToken.None);
        lists.ShouldNotBeNull();
        lists.Data.ShouldNotBeNull();
        lists.Data.ShouldNotBeEmpty();

        Models.DataListObject<Models.GenericObject>? relationships = await Fixture.AdminApi.ListServices.GetListRelationshipsProfiles(lists.Data?[0].Id, cancellationToken: CancellationToken.None);
        relationships.ShouldNotBeNull();
    }
}
