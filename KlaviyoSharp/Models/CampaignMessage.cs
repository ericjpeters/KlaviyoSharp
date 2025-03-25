namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Campaign Message
/// </summary>
public class CampaignMessage : KlaviyoObject<CampaignMessageAttributes, CampaignMessageRelationships>
{
    /// <summary>
    /// Creates a new Campaign Message with default values
    /// </summary>
    /// <returns></returns>
    public static new CampaignMessage Create()
    {
        return new() { Type = "campaign-message" };
    }
}

/// <summary>
///
/// </summary>
public class CampaignMessageRelationships
{
    /// <summary>
    /// The parent campaign
    /// </summary>
    public DataObject<GenericObject>? Campaign { get; set; }
    /// <summary>
    /// The template associated with the message
    /// </summary>
    public DataObject<GenericObject>? Template { get; set; }
}

/// <summary>
/// 2025-01-15 -- updated
/// Campaign Message Attributes
/// </summary>
public class CampaignMessageAttributes
{
    /// <summary>
    /// The label or name on the message
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// The channel the message is to be sent on
    /// 
    /// Must be one of the following:
    /// * email
    /// * sms
    /// * mobile_push
    /// </summary>
    public string? Channel { get; set; }

    /// <summary>
    /// Additional attributes relating to the content of the message
    /// </summary>
    public CampaignMessageContent? Content { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public RenderOptions? RenderOptions { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Dictionary<string, string>? KvPairs { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Options? Options { get; set; }

    /// <summary>
    /// Must be one of the following:
    /// * standard
    /// * silent
    /// </summary>
    public string? NotificationType { get; set; }

#if REMOVED_2025_01_15
    /// <summary>
    /// The list of appropriate Send Time Sub-objects associated with the message
    /// </summary>
    public List<CampaignMessageSendTimes>? SendTimes { get; set; }

    /// <summary>
    /// The datetime when the message was created
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime when the message was last updated
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The parent campaign id
    /// </summary>
    public string? CampaignId { get; set; }
#endif
}

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class Options
{
    /// <summary>
    /// 2025-01-15 -- updated
    /// </summary>
    public OnOpen? OnOpen { get; set; }

    /// <summary>
    /// 2025-01-15 -- updated
    /// </summary>
    public Badge? Badge { get; set; }

    /// <summary>
    /// 2025-01-15 -- updated
    /// </summary>
    public bool PlaySound { get; set; } = false;
}

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class OnOpen
{
    /// <summary>
    /// Must be one of the following:
    /// * open_app
    /// * deep_link
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? IosDeepLink { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? AndroidDeepLink { get; set; }
}

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class Badge
{
    /// <summary>
    /// 
    /// </summary>
    public bool Display { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public BadgeOptions? BadgeOptions { get; set; }
}

/// <summary>
/// 2025-01-15 -- updated
/// </summary>
public class BadgeOptions
{
    /// <summary>
    /// Must be one of the following:
    /// * increment_one
    /// * set_count
    /// * set_property
    /// </summary>
    public string? BadgeConfig { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? SetFromProperty { get; set; }
}

/// <summary>
/// 2025-01-15 -- updated
/// Additional options for rendering the message
/// </summary>
public class RenderOptions
{ 
    /// <summary>
    /// 
    /// </summary>
    public bool ShortenLinks { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddOrgPrefix { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddInfoLink { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public bool AddOptOutLanguage { get; set; } = false;
}

/// <summary>
/// 2025-01-15 -- updated
/// Campaign Message Content
/// </summary>
public class CampaignMessageContent
{
    /// <summary>
    /// The subject of the message
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Preview text associated with the message
    /// </summary>
    public string? PreviewText { get; set; }

    /// <summary>
    /// The email the message should be sent from
    /// </summary>
    public string? FromEmail { get; set; }

    /// <summary>
    /// The label associated with the from_email
    /// </summary>
    public string? FromLabel { get; set; }

    /// <summary>
    /// Optional Reply-To email address
    /// </summary>
    public string? ReplyToEmail { get; set; }

    /// <summary>
    /// Optional CC email address
    /// </summary>
    public string? CcEmail { get; set; }

    /// <summary>
    /// Optional BCC email address
    /// </summary>
    public string? BccEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Body { get; set; }
}

/// <summary>
/// Campaign Message Send Times
/// </summary>
public class CampaignMessageSendTimes
{
    /// <summary>
    /// The datetime that the message is to be sent
    /// </summary>
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Whether that datetime is to be a local datetime for the recipient
    /// </summary>
    public bool? IsLocal { get; set; }
}