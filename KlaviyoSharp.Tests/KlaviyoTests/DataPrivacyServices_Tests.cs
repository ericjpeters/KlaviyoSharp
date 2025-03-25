using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "DataPrivacyServices")]
public class DataPrivacyServices_Tests : IClassFixture<DataPrivacyServices_Tests_Fixture>
{
    private DataPrivacyServices_Tests_Fixture Fixture { get; }

    public DataPrivacyServices_Tests(DataPrivacyServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    //Add Tests Here
    [Fact]
    public async Task RequestProfileDeletion()
    {
        //Create new profile to test deletion
        Profile tempProfile = Models.Profile.Create();
        tempProfile.Attributes = new()
        {
            Email = $"test{Config.Random}@example.com",
            FirstName = $"Test-{Config.Random}",
            LastName = "Name"
        };

        ProfileDeletionRequest deletionRequest = Models.ProfileDeletionRequest.Create();
        string? tempProfileId = null;

        DataObject<Profile>? p = await Fixture.AdminApi.ProfileServices.CreateProfile(tempProfile, cancellationToken: CancellationToken.None);
        if (p != null)
        {
            tempProfileId = p.Data?.Id;
            Profile profile = Models.Profile.Create();
            profile.Attributes = new() { Email = tempProfile.Attributes.Email };
            deletionRequest.Attributes = new() { Profile = new(profile) };
        }

        //Request profile deletion
        await Fixture.AdminApi.DataPrivacyServices.RequestProfileDeletion(deletionRequest, cancellationToken: CancellationToken.None);

        //Check if profile is deleted by looking for a not_found error
        int retryCount = 0;
        DataObjectWithIncluded<Profile>? output = null;
        KlaviyoException? exception = null;
        do
        {
            try
            {
                // in the case where the profile is not found, the call to GetProfile will throw before the
                // output variable is assigned.   Therefore, output must be explicitly set to null, or it
                // will continue to hold the value of the previous iteration, and will fail the .ShouldBeNull assertion
                // at the end of this test.   Setting to null properly indicates if the method is actually returning
                // data or not.
                output = null;
                output = await Fixture.AdminApi.ProfileServices.GetProfile(tempProfileId, null, null, null, null, null, cancellationToken: CancellationToken.None);
                Thread.Sleep(Fixture.SleepTime);
                retryCount++;
            }
            catch (KlaviyoException ex)
            {
                ex.ShouldNotBeNull();
                ex.InternalErrors?[0].Code.ShouldBe("not_found");
                exception = ex;
            }
        }
        while ((retryCount <= Fixture.Retries) && (exception == null));

        exception.ShouldNotBeNull();
        output.ShouldBeNull();
    }
}
