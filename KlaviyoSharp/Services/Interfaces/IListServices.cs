using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;
using System.Threading;
using System.Threading.Tasks;

namespace KlaviyoSharp.Services;

/// <summary>
/// Interface for Klaviyo List Services
/// </summary>
public interface IListServices
{
    /// <summary>
    /// Get all lists in an account. Filter to request a subset of all lists. Lists can be filtered by id, name,
    /// created, and updated fields.
    /// </summary>
    /// <param name="listFields">For more information please visit
    /// https://developers.klaviyo.com/en/reference/api-overview#sparse-fieldsets</param>
    /// <param name="filter">For more information please visit
    /// <see href="https://developers.klaviyo.com/en/reference/api-overview#filtering" /> Allowed field(s): name, id,
    /// created, updated</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataListObject<List>> GetLists(List<string>? listFields,
                                        IFilter? filter,
                                        CancellationToken cancellationToken);
    /// <summary>
    /// Get a list with the given list ID.
    /// </summary>
    /// <param name="id">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
    /// <param name="listFields">For more information please visit
    /// https://developers.klaviyo.com/en/reference/api-overview#sparse-fieldsets</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataObject<List>?> GetList(string? id, List<string>? listFields, CancellationToken cancellationToken);
    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="listAttributes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataObject<List>?> CreateList(List listAttributes, CancellationToken cancellationToken);
    /// <summary>
    /// Update the name of a list with the given list ID.
    /// </summary>
    /// <param name="id">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
    /// <param name="listAttributes"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataObject<List>?> UpdateList(string? id, List listAttributes, CancellationToken cancellationToken);
    /// <summary>
    /// Delete a list with the given list ID.
    /// </summary>
    /// <param name="id">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteList(string? id, CancellationToken cancellationToken);
    /// <summary>
    /// Return all tags associated with the given list ID.
    /// </summary>
    /// <param name="id">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
    /// <param name="listFields"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataListObject<Tag>?> GetListTags(string? id, List<string>? listFields, CancellationToken cancellationToken);
    /// <summary>
    /// Add a profile to a list with the given list ID.
    /// It is recommended that you use the <see href="https://developers.klaviyo.com/en/reference/subscribe_profiles">
    /// Subscribe Profiles</see> endpoint if you're trying to give a profile consent to receive email marketing.
    /// This endpoint accepts a maximum of 1000 profiles per call.
    /// </summary>
    /// <param name="id">Primary key that uniquely identifies this list. Generated by Klaviyo.</param>
    /// <param name="profileId">List of Profile IDs to </param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AddProfileToList(string? id, List<string?> profileId, CancellationToken cancellationToken);
    /// <summary>
    /// Remove a profile from a list with the given list ID.
    /// The provided profile will no longer receive marketing from this particular list once removed.
    /// Removing a profile from a list will not impact the profile's consent status or subscription status in general.
    /// To update a profile's subscription status, please use the
    /// <see href="https://developers.klaviyo.com/en/reference/unsubscribe_profiles">Unsubscribe Profiles</see> endpoint
    /// This endpoint accepts a maximum of 1000 profiles per call.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="profileId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task RemoveProfileFromList(string? id, List<string?> profileId, CancellationToken cancellationToken);
    /// <summary>
    /// Get all profiles within a list with the given list ID.
    /// Filter to request a subset of all profiles. Profiles can be filtered by email, phone_number, and
    /// push_token fields.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="profileFields">For more information please visit
    /// https://developers.klaviyo.com/en/reference/api-overview#sparse-fieldsets</param>
    /// <param name="additionalFields">Request additional fields not included by default in the response. Supported
    /// values: 'predictive_analytics'</param>
    /// <param name="filter">For more information please visit
    /// <see href="https://developers.klaviyo.com/en/reference/api-overview#filtering" />. Allowed field(s): email,
    /// phone_number, push_token, _kx</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataListObject<Profile>> GetListProfiles(string? id, List<string>? profileFields, List<string>? additionalFields, IFilter? filter, CancellationToken cancellationToken);

    /// <summary>
    /// Returns the tag IDs of all tags associated with the given list.
    /// </summary>
    /// <param name="id">List id</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataListObject<GenericObject>?> GetListRelationshipsTags(string? id, CancellationToken cancellationToken);

    /// <summary>
    ///Get profile membership <see href="https://developers.klaviyo.com/en/reference/api_overview#relationships">
    ///relationships</see> for a list with the given list ID.
    /// </summary>
    /// <param name="id">List id</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataListObject<GenericObject>?> GetListRelationshipsProfiles(string? id, CancellationToken cancellationToken);
}