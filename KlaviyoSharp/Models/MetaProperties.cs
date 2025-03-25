namespace KlaviyoSharp.Models;

/// <summary>
/// Properties used in Patching Resources
/// </summary>
public class MetaProperties
{
    /// <summary>
    /// Specify one or more patch operations to apply to existing property data
    /// </summary>
    public List<PatchProperties>? PatchProperties { get; set; }
}
