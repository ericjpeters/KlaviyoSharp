namespace KlaviyoSharp.Models;
/// <summary>
/// Profile Merge Relationships
/// </summary>
public class ProfileMergeRelationships
{
    /// <summary>
    /// Creates a new instance of the ProfileMergeRelationships class
    /// </summary>
    public ProfileMergeRelationships()
    {
        Profiles.Data = new();
    }
    /// <summary>
    /// Creates a new instance of the ProfileMergeRelationships class with the provided data
    /// </summary>
    /// <param name="data"></param>
    public ProfileMergeRelationships(List<GenericObject> data)
    {
        Profiles.Data = data;
    }
    /// <summary>
    /// 
    /// </summary>
    public DataObject<List<GenericObject>> Profiles { get; set; } = new();

}
