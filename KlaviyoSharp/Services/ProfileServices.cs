using KlaviyoSharp.Infrastructure;
using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KlaviyoSharp.Services;

/// <summary>
/// Klaviyo Profile Services
/// </summary>
public class ProfileServices : KlaviyoServiceBase, IProfileServices
{
    /// <summary>
    /// Constructor for Klaviyo Profile Services
    /// </summary>
    /// <param name="revision"></param>
    /// <param name="klaviyoService"></param>
    public ProfileServices(string revision, KlaviyoApiBase klaviyoService) : base(revision, klaviyoService) { }

    /// <inheritdoc />
    public async Task<DataListObject<Profile>> GetProfiles(List<string>? fields = null, List<string>? additionalFields = null, IFilter? filter = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        QueryParams query = new();

        if (additionalFields != null)
        {
            query.AddAdditionalFields("profile", additionalFields);
        }

        query.AddFieldset("profile", fields);
        query.AddFilter(filter);
        query.AddSort(sort);
        return await _klaviyoService.HTTPRecursive<Profile>(HttpMethod.Get, $"profiles/", _revision, query, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObject<Profile>?> CreateProfile(Profile profile, CancellationToken cancellationToken = default)
    {
        return await _klaviyoService.HTTP<DataObject<Profile>>(HttpMethod.Post, "profiles/", _revision, null, null, new DataObject<Profile>(profile), cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObjectWithIncluded<Profile>?> GetProfile(string? profileId, List<string>? listFields = null, List<string>? profileFields = null, List<string>? segmentFields = null, List<string>? additionalFields = null, List<string>? includedObjects = null, CancellationToken cancellationToken = default)
    {
        QueryParams query = new();

        if (additionalFields != null)
        {
            query.AddAdditionalFields("profile", additionalFields);
        }

        query.AddFieldset("list", listFields);
        query.AddFieldset("profile", profileFields);
        query.AddFieldset("segment", segmentFields);

        if (includedObjects != null)
        {
            query.AddIncludes(includedObjects);
        }

        return await _klaviyoService.HTTP<DataObjectWithIncluded<Profile>>(HttpMethod.Get, $"profiles/{profileId}/", _revision, query, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObject<Profile>?> UpdateProfile(string? profileId, PatchProfile profile, CancellationToken cancellationToken = default)
    {
        return await _klaviyoService.HTTP<DataObject<Profile>>(new("PATCH"), $"profiles/{profileId}/", _revision, null, null, new DataObject<PatchProfile>(profile), cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObject<Profile>?> CreateOrUpdateProfile(Profile profile, CancellationToken cancellationToken = default)
    {
        return await _klaviyoService.HTTP<DataObject<Profile>>(HttpMethod.Post, "profile-import/", _revision, null, null, new DataObject<Profile>(profile), cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObject<ProfileMerge>?> MergeProfiles(List<string> sources, DataObject<Profile> destination, CancellationToken cancellationToken = default)
    {
        ProfileMergeRequest profileMerge = ProfileMergeRequest.Create();
        profileMerge.Id = destination.Data?.Id;
        foreach (string source in sources)
        {
            GenericObject profile = new("profile", source);
            profileMerge.Relationships.Profiles.Data?.Add(profile);
        }

        return await _klaviyoService.HTTP<DataObject<ProfileMerge>>(HttpMethod.Post, "profile-merge/", _revision, null, null, new DataObject<ProfileMerge>(profileMerge), cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataObject<ProfileMerge>?> MergeProfiles(List<DataObject<Profile>> sources, DataObject<Profile> destination, CancellationToken cancellationToken = default)
    {
        ProfileMergeRequest profileMerge = ProfileMergeRequest.Create();
        profileMerge.Id = destination.Data?.Id;
        foreach (DataObject<Profile> source in sources)
        {
            GenericObject profile = new(source.Data?.Type, source.Data?.Id);
            profileMerge.Relationships.Profiles.Data?.Add(profile);
        }

        return await _klaviyoService.HTTP<DataObject<ProfileMerge>>(HttpMethod.Post, "profile-merge/", _revision, null, null, new DataObject<ProfileMerge>(profileMerge), cancellationToken);
    }

    /// <inheritdoc />
    public async Task SuppressProfiles(ProfileSuppressionRequest supressions, CancellationToken cancellationToken = default)
    {
        await _klaviyoService.HTTP(HttpMethod.Post, "profile-suppression-bulk-create-jobs/", _revision, null, null, new DataObject<ProfileSuppressionRequest>(supressions), cancellationToken);
    }

    /// <inheritdoc />
    public async Task UnsuppressProfiles(ProfileUnsuppressionRequest unsupressions, CancellationToken cancellationToken = default)
    {
        await _klaviyoService.HTTP(HttpMethod.Post, "profile-suppression-bulk-delete-jobs/", _revision, null, null, new DataObject<ProfileUnsuppressionRequest>(unsupressions), cancellationToken);
    }

    /// <inheritdoc />
    public async Task SubscribeProfiles(ProfileSubscriptionRequest profileSubscriptions, CancellationToken cancellationToken = default)
    {
        await _klaviyoService.HTTP(HttpMethod.Post, "profile-subscription-bulk-create-jobs/", _revision, null, null, new DataObject<ProfileSubscriptionRequest>(profileSubscriptions), cancellationToken);
    }

    /// <inheritdoc />
    public async Task UnsubscribeProfiles(ProfileUnsubscriptionRequest profileUnsubscriptions, CancellationToken cancellationToken = default)
    {
        await _klaviyoService.HTTP(HttpMethod.Post, "profile-subscription-bulk-delete-jobs/", _revision, null, null, new DataObject<ProfileUnsubscriptionRequest>(profileUnsubscriptions), cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataListObject<ProfileBulkImportJob>> GetBulkProfileImportJobs(List<string>? fields = null, IFilter? filter = null, string? sort = null, CancellationToken cancellationToken = default)
    {
        QueryParams query = new();
        query.AddFieldset("profile-bulk-import-job", fields);
        query.AddFilter(filter);
        query.AddSort(sort);
        return await _klaviyoService.HTTPRecursive<ProfileBulkImportJob>(HttpMethod.Get, $"profile-bulk-import-jobs/", _revision, query, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataListObject<List>?> GetProfileLists(string? profileId, List<string>? fields = null, CancellationToken cancellationToken = default)
    {
        QueryParams query = new();
        query.AddFieldset("list", fields);
        return await _klaviyoService.HTTP<DataListObject<List>>(HttpMethod.Get, $"profiles/{profileId}/lists/", _revision, query, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataListObject<List>?> GetProfileSegments(string? profileId, List<string>? fields = null, CancellationToken cancellationToken = default)
    {
        QueryParams query = new();
        query.AddFieldset("segment", fields);
        return await _klaviyoService.HTTP<DataListObject<List>>(HttpMethod.Get, $"profiles/{profileId}/segments/", _revision, query, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataListObject<GenericObject>?> GetProfileRelationshipsLists(string? id, CancellationToken cancellationToken = default)
    {
        return await _klaviyoService.HTTP<DataListObject<GenericObject>>(HttpMethod.Get, $"profiles/{id}/relationships/lists/", _revision, null, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DataListObject<GenericObject>?> GetProfileRelationshipsSegments(string? id, CancellationToken cancellationToken = default)
    {
        return await _klaviyoService.HTTP<DataListObject<GenericObject>>(HttpMethod.Get, $"profiles/{id}/relationships/segments/", _revision, null, null, null, cancellationToken);
    }

    /// <inheritdoc />
    public async Task CreateOrUpdateClientPushToken(PushToken pushToken, CancellationToken cancellationToken = default)
    {
        await _klaviyoService.HTTP(HttpMethod.Post, "push-tokens/", _revision, null, null, new DataObject<PushToken>(pushToken), cancellationToken);
    }
}
