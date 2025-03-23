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
        var GetCatalogItems = await Fixture.AdminApi.CatalogServices.GetCatalogItems();
        GetCatalogItems.ShouldNotBeNull();

        var GetCreateItemsJobs = await Fixture.AdminApi.CatalogServices.GetCreateItemsJobs();
        GetCreateItemsJobs.ShouldNotBeNull();

        var GetUpdateItemsJobs = await Fixture.AdminApi.CatalogServices.GetUpdateItemsJobs();
        GetUpdateItemsJobs.ShouldNotBeNull();

        var GetDeleteItemsJobs = await Fixture.AdminApi.CatalogServices.GetDeleteItemsJobs();
        GetDeleteItemsJobs.ShouldNotBeNull();

        if (GetCatalogItems.Data?.Count == 0)
        {
            var GetCatalogCategories = await Fixture.AdminApi.CatalogServices.GetCatalogCategories();
            var categoryId = GetCatalogCategories.Data?.FirstOrDefault()?.Id;
            if (categoryId == null)
            {
                var categoryItem = CatalogCategory.Create();
                categoryItem.Attributes = new()
                {
                    Name = Guid.NewGuid().ToString(),
                    ExternalId = Guid.NewGuid().ToString()
                };

                var category = await Fixture.AdminApi.CatalogServices.CreateCatalogCategory(categoryItem);
                categoryId = category?.Data?.Id;
            }

            var item = CatalogItem.Create();
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

            await Fixture.AdminApi.CatalogServices.CreateCatalogItem(item);
        }
    }

    [Fact]
    public async Task Variants()
    {
        var GetCatalogVariants = await Fixture.AdminApi.CatalogServices.GetCatalogVariants();
        GetCatalogVariants.ShouldNotBeNull();

        var GetCreateVariantsJobs = await Fixture.AdminApi.CatalogServices.GetCreateVariantsJobs();
        GetCreateVariantsJobs.ShouldNotBeNull();

        var GetUpdateVariantsJobs = await Fixture.AdminApi.CatalogServices.GetUpdateVariantsJobs();
        GetUpdateVariantsJobs.ShouldNotBeNull();

        var GetDeleteVariantsJobs = await Fixture.AdminApi.CatalogServices.GetDeleteVariantsJobs();
        GetDeleteVariantsJobs.ShouldNotBeNull();

        if (GetCatalogVariants.Data?.Count == 0)
        {
            var GetCatalogItems = await Fixture.AdminApi.CatalogServices.GetCatalogItems();

            var variant = CatalogVariant.Create();
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
            await Fixture.AdminApi.CatalogServices.CreateCatalogVariant(variant);
        }
    }

    [Fact]
    public async Task Categories()
    {
        var GetCatalogCategories = await Fixture.AdminApi.CatalogServices.GetCatalogCategories();
        
        GetCatalogCategories.ShouldNotBeNull();
        var GetCreateCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetCreateCategoriesJobs();
        GetCreateCategoriesJobs.ShouldNotBeNull();

        var GetUpdateCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetUpdateCategoriesJobs();
        GetUpdateCategoriesJobs.ShouldNotBeNull();

        var GetDeleteCategoriesJobs = await Fixture.AdminApi.CatalogServices.GetDeleteCategoriesJobs();
        GetDeleteCategoriesJobs.ShouldNotBeNull();

        if (GetCatalogCategories.Data?.Count == 0)
        {
            var category = CatalogCategory.Create();
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
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data?.First();
        var variant = (await Fixture.AdminApi.CatalogServices.GetCatalogVariants()).Data?.FirstOrDefault();
        var newProfile = Profile.Create();
        newProfile.Attributes = new() { Email = profile?.Attributes?.Email };
        
        var backInStockRequest = BackInStockSubscription.Create();
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

        await Fixture.AdminApi.CatalogServices.CreateBackInStockSubscription(backInStockRequest);
    }
}

public class CatalogServices_Tests_Fixture : IAsyncLifetime
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