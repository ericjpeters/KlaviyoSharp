using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "CatalogServices")]
public class CatalogServices_Tests : IClassFixture<CatalogServices_Tests_Fixture>
{
    private CatalogServices_Tests_Fixture Fixture { get; }

    public CatalogServices_Tests(CatalogServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task Items()
    {
        DataListObject<CatalogItem> GetCatalogItems = await Fixture.AdminApi.CatalogServices.GetCatalogItems(cancellationToken: CancellationToken.None);
        GetCatalogItems.ShouldNotBeNull();

        DataListObject<CatalogItemBulkJob> GetCreateItemsJobs = await Fixture.AdminApi.CatalogServices.GetCreateItemsJobs(cancellationToken: CancellationToken.None);
        GetCreateItemsJobs.ShouldNotBeNull();

        DataListObject<CatalogItemBulkJob> GetUpdateItemsJobs = await Fixture.AdminApi.CatalogServices.GetUpdateItemsJobs(cancellationToken: CancellationToken.None);
        GetUpdateItemsJobs.ShouldNotBeNull();

        DataListObject<CatalogItemBulkJob> GetDeleteItemsJobs = await Fixture.AdminApi.CatalogServices.GetDeleteItemsJobs(cancellationToken: CancellationToken.None);
        GetDeleteItemsJobs.ShouldNotBeNull();

        if (GetCatalogItems.Data?.Count == 0)
        {
            DataListObject<CatalogCategory> GetCatalogCategories = await Fixture.AdminApi.CatalogServices.GetCatalogCategories(cancellationToken: CancellationToken.None);
            string? categoryId = GetCatalogCategories.Data?.FirstOrDefault()?.Id;
            if (categoryId == null)
            {
                CatalogCategory categoryItem = CatalogCategory.Create();
                categoryItem.Attributes = new()
                {
                    Name = Guid.NewGuid().ToString(),
                    ExternalId = Guid.NewGuid().ToString()
                };

                DataObject<CatalogCategory>? category = await Fixture.AdminApi.CatalogServices.CreateCatalogCategory(categoryItem, cancellationToken: CancellationToken.None);
                categoryId = category?.Data?.Id;
            }

            CatalogItem item = CatalogItem.Create();
            item.Attributes = new()
            {
                ExternalId = Guid.NewGuid().ToString(),
                Title = Guid.NewGuid().ToString(),
                Description = Guid.NewGuid().ToString(),
                Url = Guid.NewGuid().ToString()
            };

            item.Relationships = new()
            {
                Categories = new()
                {
                    Data = new()
                    {
                        new("catalog-category", categoryId)
                    }
                }
            };

            await Fixture.AdminApi.CatalogServices.CreateCatalogItem(item, cancellationToken: CancellationToken.None);
        }
    }

    [Fact]
    public async Task Variants()
    {
        DataListObject<CatalogVariant> GetCatalogVariants = await Fixture.AdminApi.CatalogServices.GetCatalogVariants(cancellationToken: CancellationToken.None);
        GetCatalogVariants.ShouldNotBeNull();

        DataListObject<CatalogVariantBulkJob> GetCreateVariantsJobs = await Fixture.AdminApi.CatalogServices.GetCreateVariantsJobs(cancellationToken: CancellationToken.None);
        GetCreateVariantsJobs.ShouldNotBeNull();

        DataListObject<CatalogVariantBulkJob> GetUpdateVariantsJobs = await Fixture.AdminApi.CatalogServices.GetUpdateVariantsJobs(cancellationToken: CancellationToken.None);
        GetUpdateVariantsJobs.ShouldNotBeNull();

        DataListObject<CatalogVariantBulkJob> GetDeleteVariantsJobs = await Fixture.AdminApi.CatalogServices.GetDeleteVariantsJobs(cancellationToken: CancellationToken.None);
        GetDeleteVariantsJobs.ShouldNotBeNull();

        if (GetCatalogVariants.Data?.Count == 0)
        {
            DataListObject<CatalogItem> GetCatalogItems = await Fixture.AdminApi.CatalogServices.GetCatalogItems(cancellationToken: CancellationToken.None);

            CatalogVariant variant = CatalogVariant.Create();
            variant.Attributes = new()
            {
                ExternalId = "TEST",
                CatalogType = "$default",
                IntegrationType = "$custom",
                Title = "test item",
                Description = "Item for testing",
                Sku = "test",
                InventoryQuantity = 0,
                Price = 100,
                Url = "https://www.test.com",
                Published = true
            };
            variant.Relationships = new()
            {
                Item = new()
                {
                    Data = new("catalog-item", GetCatalogItems.Data?.First().Id)
                }
            };
            await Fixture.AdminApi.CatalogServices.CreateCatalogVariant(variant, cancellationToken: CancellationToken.None);
        }
    }

    [Fact]
    public async Task Categories()
    {
        DataListObject<CatalogCategory> GetCatalogCategories = await Fixture.AdminApi.CatalogServices.GetCatalogCategories(cancellationToken: CancellationToken.None);

        GetCatalogCategories.ShouldNotBeNull();
        DataListObject<CatalogCategoryBulkJob> GetCreateCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetCreateCategoriesJobs(cancellationToken: CancellationToken.None);
        GetCreateCategoriesJobs.ShouldNotBeNull();

        DataListObject<CatalogCategoryBulkJob> GetUpdateCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetUpdateCategoriesJobs(cancellationToken: CancellationToken.None);
        GetUpdateCategoriesJobs.ShouldNotBeNull();

        DataListObject<CatalogCategoryBulkJob> GetDeleteCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetDeleteCategoriesJobs(cancellationToken: CancellationToken.None);
        GetDeleteCategoriesJobs.ShouldNotBeNull();

        if (GetCatalogCategories.Data?.Count == 0)
        {
            CatalogCategory category = CatalogCategory.Create();
            category.Attributes = new()
            {
                ExternalId = "Testing",
                Name = "test category",
                IntegrationType = "$custom",
                CatalogType = "$default"
            };
        }
    }

    [Fact]
    public async Task BackInStock()
    {
        Profile? profile = (await Fixture.AdminApi.ProfileServices.GetProfiles(cancellationToken: CancellationToken.None)).Data?.First();
        CatalogVariant? variant = (await Fixture.AdminApi.CatalogServices.GetCatalogVariants(cancellationToken: CancellationToken.None)).Data?.FirstOrDefault();
        Profile newProfile = Profile.Create();
        newProfile.Attributes = new() { Email = profile?.Attributes?.Email };

        BackInStockSubscription backInStockRequest = BackInStockSubscription.Create();
        backInStockRequest.Attributes = new()
        {
            Channels = new() { "EMAIL" },
            Profile = new(newProfile)
        };
        backInStockRequest.Relationships = new()
        {
            Variant = new()
            {
                Data = new("catalog-variant", variant?.Id)
            }
        };

        await Fixture.AdminApi.CatalogServices.CreateBackInStockSubscription(backInStockRequest, cancellationToken: CancellationToken.None);
    }
}
