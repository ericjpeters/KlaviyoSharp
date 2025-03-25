namespace KlaviyoSharp.Models;

/// <summary>
/// 2025-01-15 -- Updated
/// Metadata about the device that created the push token
/// </summary>
public class PushTokenDeviceMetadata
{
    /// <summary>
    /// Relatively stable ID for the device. Will update on app uninstall and reinstall
    /// </summary>
    public string? DeviceId { get; set; }

    /// <summary>
    /// The name of the SDK used to create the push token.
    /// 
    /// Must be one of the following:
    /// * swift
    /// * android
    /// * flutter_community
    /// * react_native
    /// </summary>
    public string? KlaviyoSdk { get; set; }

    /// <summary>
    /// The version of the SDK used to create the push token
    /// </summary>
    public string? SdkVersion { get; set; }

    /// <summary>
    /// The model of the device
    /// </summary>
    public string? DeviceModel { get; set; }

    /// <summary>
    /// The name of the operating system on the device.
    /// 
    /// Must be one of the following:
    /// * ios
    /// * android
    /// * macos
    /// * ipados
    /// * tvos
    /// </summary>
    public string? OsName { get; set; }

    /// <summary>
    /// The version of the operating system on the device
    /// </summary>
    public string? OsVersion { get; set; }

    /// <summary>
    /// The manufacturer of the device
    /// </summary>
    public string? Manufacturer { get; set; }

    /// <summary>
    /// The name of the app that created the push token
    /// </summary>
    public string? AppName { get; set; }

    /// <summary>
    /// The version of the app that created the push token
    /// </summary>
    public string? AppVersion { get; set; }

    /// <summary>
    /// The build of the app that created the push token
    /// </summary>
    public string? AppBuild { get; set; }

    /// <summary>
    /// The ID of the app that created the push token
    /// </summary>
    public string? AppId { get; set; }

    /// <summary>
    /// The environment in which the push token was created
    /// </summary>
    public string? Environment { get; set; }
}
