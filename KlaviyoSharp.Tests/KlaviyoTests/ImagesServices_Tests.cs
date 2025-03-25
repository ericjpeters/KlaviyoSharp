using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "ImagesServices")]
public class ImagesServices_Tests : IClassFixture<ImagesServices_Tests_Fixture>
{
    private ImagesServices_Tests_Fixture Fixture { get; }
    public ImagesServices_Tests(ImagesServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetImages()
    {
        DataListObject<Image>? result = await Fixture.AdminApi.ImagesServices.GetImages(cancellationToken: CancellationToken.None);
        if ((result?.Data ?? []).Count == 0)
        {
            DataObject<Image>? r = await Fixture.AdminApi.ImagesServices.UploadImageFromUrl(Fixture.NewImageFromUrl, cancellationToken: CancellationToken.None);
            r.ShouldNotBeNull();

            string newName = $"test{Config.Random}";
            PatchImage update = PatchImage.Create();
            update.Attributes = new()
            {
                Name = newName,
                Hidden = false
            };

            update.Id = r.Data?.Id;
            await Fixture.AdminApi.ImagesServices.UpdateImage(r.Data?.Id, update, cancellationToken: CancellationToken.None);
            result = await Fixture.AdminApi.ImagesServices.GetImages(cancellationToken: CancellationToken.None);
        }

        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        DataObject<Image>? res = await Fixture.AdminApi.ImagesServices.GetImage(result?.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result?.Data?[0].Id);
    }

    [Fact]
    public async Task CreateAndUpdateImages()
    {
        DataObject<Image>? result = await Fixture.AdminApi.ImagesServices.UploadImageFromUrl(Fixture.NewImageFromUrl, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        string NewName = $"test{Config.Random}";
        PatchImage update = PatchImage.Create();
        update.Attributes = new() { Name = NewName, Hidden = true };
        update.Id = result.Data?.Id;

        DataObject<Image>? updated = await Fixture.AdminApi.ImagesServices.UpdateImage(result.Data?.Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.Name.ShouldBe(NewName);
        updated?.Data?.Attributes?.Hidden.ShouldBeTrue();
    }

    [Fact]
    public async Task CreateImageFromBase64()
    {
        DataObject<Image>? result = await Fixture.AdminApi.ImagesServices.UploadImageFromUrl(Fixture.NewImageFromBase64, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        string NewName = $"test{Config.Random}";
        PatchImage update = PatchImage.Create();
        update.Attributes = new() { Name = NewName, Hidden = true };
        update.Id = result.Data?.Id;

        DataObject<Image>? updated = await Fixture.AdminApi.ImagesServices.UpdateImage(result.Data?.Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.Name.ShouldBe(NewName);
        updated?.Data?.Attributes?.Hidden.ShouldBeTrue();
    }
}
