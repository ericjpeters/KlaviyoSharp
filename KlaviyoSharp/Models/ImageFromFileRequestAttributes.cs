﻿namespace KlaviyoSharp.Models;

/// <summary>
/// Image From File Request
/// </summary>
public class ImageFromFileRequestAttributes
{
    /// <summary>
    /// A name for the image.
    /// Defaults to the filename if not provided.
    /// If the name matches an existing image, a suffix will be added.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The image file to upload.
    /// Supported image formats: jpeg,png,gif.
    /// Maximum image size: 5MB.
    /// </summary>
    public string? File { get; set; }

    /// <summary>
    /// If true, this image is not shown in the asset library.
    /// </summary>
    public bool Hidden { get; set; }
}