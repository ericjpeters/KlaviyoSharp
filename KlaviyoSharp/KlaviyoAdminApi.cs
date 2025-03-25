namespace KlaviyoSharp;

/// <summary>
/// The Klaviyo Admin API. All /api endpoints use a private API key.
/// </summary>
/// <remarks>
/// Creates a new instance of the Klaviyo Admin API.
/// </remarks>
/// <param name="config">The KlaviyoConfig object.</param>
public class KlaviyoAdminApi(KlaviyoConfig config) : KlaviyoApiBase(config)
{
    const string REVISION = "2025-01-15";

    private Services.AccountServices? _AccountServices;
    private Services.DataPrivacyServices? _DataPrivacyServices;
    private Services.CouponServices? _CouponServices;
    private Services.ListServices? _ListServices;
    private Services.ProfileServices? _ProfileServices;
    private Services.MetricServices? _MetricServices;
    private Services.EventServices? _EventServices;
    private Services.SegmentServices? _SegmentServices;
    private Services.TemplateServices? _TemplateServices;
    private Services.FlowServices? _FlowServices;
    private Services.TagServices? _TagServices;
    private Services.CampaignServices? _CampaignServices;
    private Services.CatalogServices? _CatalogServices;
    private Services.ImagesServices? _ImagesServices;
    private Services.ReportingServices? _ReportingServices;

    /// <summary>
    /// Creates a new instance of the Klaviyo Admin API.
    /// </summary>
    /// <param name="apiKey">Your private API key.</param>
    public KlaviyoAdminApi(string apiKey)
        : this(new KlaviyoConfig(apiKey))
    {
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Account
    /// </summary>
    public Services.AccountServices AccountServices
    {
        get
        {
            _AccountServices ??= new(REVISION, this);
            return _AccountServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Data Privacy API
    /// </summary>
    public Services.DataPrivacyServices DataPrivacyServices
    {
        get
        {
            _DataPrivacyServices ??= new(REVISION, this);
            return _DataPrivacyServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Coupon API
    /// </summary>
    public Services.CouponServices CouponServices
    {
        get
        {
            _CouponServices ??= new(REVISION, this);
            return _CouponServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Lists API
    /// </summary>
    public Services.ListServices ListServices
    {
        get
        {
            _ListServices ??= new(REVISION, this);
            return _ListServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Profiles API
    /// </summary>
    public Services.ProfileServices ProfileServices
    {
        get
        {
            _ProfileServices ??= new(REVISION, this);
            return _ProfileServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Metrics API
    /// </summary>
    public Services.MetricServices MetricServices
    {
        get
        {
            _MetricServices ??= new(REVISION, this);
            return _MetricServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Events API
    /// </summary>
    public Services.EventServices EventServices
    {
        get
        {
            _EventServices ??= new(REVISION, this);
            return _EventServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Segments API
    /// </summary>
    public Services.SegmentServices SegmentServices
    {
        get
        {
            _SegmentServices ??= new(REVISION, this);
            return _SegmentServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Templates API
    /// </summary>
    public Services.TemplateServices TemplateServices
    {
        get
        {
            _TemplateServices ??= new(REVISION, this);
            return _TemplateServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Flows API
    /// </summary>
    public Services.FlowServices FlowServices
    {
        get
        {
            _FlowServices ??= new(REVISION, this);
            return _FlowServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Tags API
    /// </summary>
    public Services.TagServices TagServices
    {
        get
        {
            _TagServices ??= new(REVISION, this);
            return _TagServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Campaigns API
    /// </summary>
    public Services.CampaignServices CampaignServices
    {
        get
        {
            _CampaignServices ??= new(REVISION, this);
            return _CampaignServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Catalogs API
    /// </summary>
    public Services.CatalogServices CatalogServices
    {
        get
        {
            _CatalogServices ??= new(REVISION, this);
            return _CatalogServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Image API
    /// </summary>
    public Services.ImagesServices ImagesServices
    {
        get
        {
            _ImagesServices ??= new(REVISION, this);
            return _ImagesServices;
        }
    }

    /// <summary>
    /// Services for interacting with the Klaviyo Catalogs API
    /// </summary>
    public Services.ReportingServices ReportingServices
    {
        get
        {
            _ReportingServices ??= new(REVISION, this);
            return _ReportingServices;
        }
    }
}
