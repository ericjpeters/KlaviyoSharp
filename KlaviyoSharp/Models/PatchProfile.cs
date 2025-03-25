namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo profile with meta properties for patcching
/// </summary>
public class PatchProfile : Profile
{
    /// <summary>
    /// Generic Constructor
    /// </summary>
    public PatchProfile()
    {
    }

    /// <summary>
    /// Constructor for PatchProfile from existing Profile
    /// </summary>
    /// <param name="profile"></param>
    public PatchProfile(Profile profile)
    {
        Id = profile.Id;
        Type = profile.Type;
        Attributes = profile.Attributes;
        Relationships = profile.Relationships;
        Links = profile.Links;
    }

    /// <summary>
    /// Creates a new instance of the Klaviyo Profile with default values
    /// </summary>
    /// <returns></returns>
    public static new PatchProfile Create() => new() { Type = "profile" };

    /// <summary>
    /// 
    /// </summary>
    public MetaProperties? Meta { get; set; }
}
