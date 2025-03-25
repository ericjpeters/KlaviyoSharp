using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "CouponServices")]
public class CouponServices_Tests : IClassFixture<CouponServices_Tests_Fixture>
{
    private CouponServices_Tests_Fixture Fixture { get; }

    public CouponServices_Tests(CouponServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetCoupons()
    {
        DataListObject<Coupon>? result = await Fixture.AdminApi.CouponServices.GetCoupons(cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        DataObject<Coupon>? res = await Fixture.AdminApi.CouponServices.GetCoupon(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);
    }

    [Fact]
    public async Task CreateAndUpdateCoupon()
    {
        DataObject<Coupon>? result = await Fixture.AdminApi.CouponServices.CreateCoupon(Fixture.NewCoupon, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        string NewDescription = $"{Config.Random}OFF";
        Coupon update = Coupon.Create();
        update.Attributes = new() { Description = NewDescription };
        update.Id = result.Data?.Id;
        DataObject<Coupon>? updated = await Fixture.AdminApi.CouponServices.UpdateCoupon(result.Data?.Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.Description.ShouldBe(NewDescription);
    }

    [Fact]
    public async Task GetCouponCodes()
    {
        Coupon couponData = Fixture.NewCoupon;
        DataObject<Coupon>? coupon = await Fixture.AdminApi.CouponServices.CreateCoupon(couponData, cancellationToken: CancellationToken.None);
        coupon?.Data?.Attributes?.ExternalId.ShouldBe(couponData.Attributes?.ExternalId);

        CouponCode couponCodeData = Fixture.NewCouponCode;
        DataObject<CouponCode>? remote = await Fixture.AdminApi.CouponServices.CreateCouponCode(couponCodeData, coupon, cancellationToken: CancellationToken.None);
        Filter filter = new(FilterOperation.Equals, "coupon.id", coupon?.Data?.Id ?? String.Empty);

        DataListObject<CouponCode>? result = await Fixture.AdminApi.CouponServices.GetCouponCodes(filter: filter, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();

        DataObject<CouponCode>? res = await Fixture.AdminApi.CouponServices.GetCouponCode(result.Data?[0].Id, cancellationToken: CancellationToken.None);
        res?.Data?.Id.ShouldBe(result.Data?[0].Id);
        remote?.Data?.Id.ShouldBe(result.Data?[0].Id);
    }

    [Fact]
    public async Task CreateAndUpdateCouponCode()
    {
        DataObject<Coupon>? coupon = await Fixture.AdminApi.CouponServices.CreateCoupon(Fixture.NewCoupon, cancellationToken: CancellationToken.None);
        CouponCode output = Fixture.NewCouponCode;
        output.Relationships = new()
        {
            Coupon = new DataObjectRelated<GenericObject>(new(coupon?.Data?.Type, coupon?.Data?.Id))
        };

        DataObject<CouponCode>? result = await Fixture.AdminApi.CouponServices.CreateCouponCode(output, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();

        DateTime NewExpiresAt = DateTime.Now.Date.AddDays(100);
        CouponCode update = CouponCode.Create();
        update.Attributes = new()
        {
            ExpiresAt = NewExpiresAt,
        };
        update.Id = result.Data?.Id;

        DataObject<CouponCode>? updated = await Fixture.AdminApi.CouponServices.UpdateCouponCode(result.Data?.Id, update, cancellationToken: CancellationToken.None);
        updated?.Data?.Attributes?.ExpiresAt.ShouldBe(NewExpiresAt);
    }
}
