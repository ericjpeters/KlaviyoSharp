# KlaviyoSharp

KlaviyoSharp is a .NET 9 library that enables you to interact with the Klaviyo API in .NET. This project was started as there was no fully fleshed out and updated package available to interact with the Klaviyo API in .NET.

Previous support for .NET Standard 2.0 has been removed.

Current API documentation is located at https://developers.klaviyo.com/en/reference/api_overview

## API Support

Klaviyo's API is versioned by using dates in the request headers. The mapping of these to this package is as follows:

| Klaviyo API Version                                                                | KlaviyoSharp Version    |
| ---------------------------------------------------------------------------------- | ----------------------- |
| [2025-01-15](https://developers.klaviyo.com/en/v2025-01-15/reference/api_overview) | 2025.1.15 (in progress) |
| [2024-02-15](https://developers.klaviyo.com/en/v2024-02-15/reference/api_overview) | 1.2.x (obsolete)        |
| [2023-07-15](https://developers.klaviyo.com/en/v2023-07-15/reference/api_overview) | 1.1.x (obsolete)        |
| [2023-06-15](https://developers.klaviyo.com/en/v2023-06-15/reference/api_overview) | 1.0.x (obsolete)        |

### v2025.1.15 Status

* Status Key

    | Symbology          | Description                          | Current Count |
    | ------------------ | ------------------------------------ | ------------- |
    | :question:         | To Do                                | ( 255 / 277 ) |
    | :white_check_mark: | Complete (and tested)                | (   8 / 277 ) |
    | :heavy_check_mark: | Converted to 2025-01-15 (not tested) | (   1 / 277 ) |
    | :wrench:           | In Progress                          | (  10 / 277 ) |
    | :x:                | Deprecated or Beta                   | (   3 / 277 ) |

* :heavy_check_mark: Client APIs
    * :heavy_check_mark: Client
        * :white_check_mark: [Create Client Subscription](https://developers.klaviyo.com/en/reference/create_client_subscription)
        * :white_check_mark: [Create or Update Client Push Token](https://developers.klaviyo.com/en/reference/create_client_push_token)
        * :white_check_mark: [Unregister Client Push Token](https://developers.klaviyo.com/en/reference/unregister_client_push_token)
        * :white_check_mark: [Create Client Event](https://developers.klaviyo.com/en/reference/create_client_event)
        * :white_check_mark: [Create Or Update Client Profile](https://developers.klaviyo.com/en/reference/create_client_profile)
        * :white_check_mark: [Bulk Create Client Events](https://developers.klaviyo.com/en/reference/bulk_create_client_events)
        * :heavy_check_mark: [Create Client Back In Stock Subscription](https://developers.klaviyo.com/en/reference/create_client_back_in_stock_subscription)
* :wrench: Admin APIs
    * :x: Beta APIs
        * :x: Reviews
            * :x: [Get Client Review Values Reports](https://developers.klaviyo.com/en/reference/get_client_review_values_reports_beta)
            * :x: [Get Client Reviews](https://developers.klaviyo.com/en/reference/get_client_reviews_beta)
            * :x: [Create Client Review](https://developers.klaviyo.com/en/reference/create_client_review_beta)
    * :white_check_mark: Accounts APIs
        * :white_check_mark: Accounts
            * :white_check_mark: [Get Accounts](https://developers.klaviyo.com/en/reference/get_accounts)
            * :white_check_mark: [Get Account](https://developers.klaviyo.com/en/reference/get_account)
    * :wrench: Campaigns APIs
        * :wrench: Messages
            * :wrench: [Get Campaign Message](https://developers.klaviyo.com/en/reference/get_campaign_message)
            * :wrench: [Update Campaign Message](https://developers.klaviyo.com/en/reference/update_campaign_message)
            * :wrench: [Assign Template to Campaign Message](https://developers.klaviyo.com/en/reference/assign_template_to_campaign_message)
            * :wrench: [Get Campaign for Campaign Message](https://developers.klaviyo.com/en/reference/get_campaign_for_campaign_message)
            * :wrench: [Get Campaign ID for Campaign Message](https://developers.klaviyo.com/en/reference/get_campaign_id_for_campaign_message)
            * :wrench: [Get Template for Campaign Message](https://developers.klaviyo.com/en/reference/get_template_for_campaign_message)
            * :wrench: [Get Template ID for Campaign Message](https://developers.klaviyo.com/en/reference/get_template_id_for_campaign_message)
            * :wrench: [Get Image for Campaign Message](https://developers.klaviyo.com/en/reference/get_image_for_campaign_message)
            * :wrench: [Get Image ID for Campaign Message](https://developers.klaviyo.com/en/reference/get_image_id_for_campaign_message)
            * :wrench: [Update Image for Campaign Message](https://developers.klaviyo.com/en/reference/update_image_for_campaign_message)
        * :question: Jobs
            * :question: [Get Campaign Send Job](https://developers.klaviyo.com/en/reference/get_campaign_send_job)
            * :question: [Cancel Campaign Send](https://developers.klaviyo.com/en/reference/cancel_campaign_send)
            * :question: [Get Campaign Receipient Estimation Job](https://developers.klaviyo.com/en/reference/get_campaign_recipient_estimation_job)
            * :question: [Send Campaign](https://developers.klaviyo.com/en/reference/send_campaign)
            * :question: [Refresh Campaign Recipient Estimation](https://developers.klaviyo.com/en/reference/refresh_campaign_recipient_estimation)
        * :question: Campaigns
            * :question: [Get Campaigns](https://developers.klaviyo.com/en/reference/get_campaigns)
            * :question: [Create Campaign](https://developers.klaviyo.com/en/reference/create_campaign)
            * :question: [Get Campaign](https://developers.klaviyo.com/en/reference/get_campaign)
            * :question: [Update Campaign](https://developers.klaviyo.com/en/reference/update_campaign)
            * :question: [Delete Campaign](https://developers.klaviyo.com/en/reference/delete_campaign)
            * :question: [Get Campaign Recipient Estimation](https://developers.klaviyo.com/en/reference/get_campaign_recipient_estimation)
            * :question: [Create Campaign Clone](https://developers.klaviyo.com/en/reference/create_campaign_clone)
            * :question: [Get Tags for Campaign](https://developers.klaviyo.com/en/reference/get_tags_for_campaign)
            * :question: [Get Tag IDs for Campaign](https://developers.klaviyo.com/en/reference/get_tag_ids_for_campaign)
            * :question: [Get Messages for Campaign](https://developers.klaviyo.com/en/reference/get_messages_for_campaign)
            * :question: [Get Message IDs for Campaign](https://developers.klaviyo.com/en/reference/get_message_ids_for_campaign)
    * :question: Catalogs APIs
        * :question: Categories
            * :question: [Get Catalog Categories](https://developers.klaviyo.com/en/reference/get_catalog_categories)
            * :question: [Create Catalog Category](https://developers.klaviyo.com/en/reference/create_catalog_category)
            * :question: [Get Catalog Category](https://developers.klaviyo.com/en/reference/get_catalog_category)
            * :question: [Update Catalog Category](https://developers.klaviyo.com/en/reference/update_catalog_category)
            * :question: [Delete Catalog Category](https://developers.klaviyo.com/en/reference/delete_catalog_category)
            * :question: [Get Bulk Create Categories Jobs](https://developers.klaviyo.com/en/reference/get_bulk_create_categories_jobs)
            * :question: [Bulk Create Catalog Categories](https://developers.klaviyo.com/en/reference/bulk_create_catalog_categories)
            * :question: [Get Bulk Create Categories Job](https://developers.klaviyo.com/en/reference/get_bulk_create_categories_job)
            * :question: [Get Bulk Update Categories Jobs](https://developers.klaviyo.com/en/reference/get_bulk_update_categories_jobs)
            * :question: [Bulk Update Catalog Categories](https://developers.klaviyo.com/en/reference/bulk_update_catalog_categories)
            * :question: [Get Bulk Update Categories Job](https://developers.klaviyo.com/en/reference/get_bulk_update_categories_job)
            * :question: [Get Bulk Delete Categories Jobs](https://developers.klaviyo.com/en/reference/get_bulk_delete_categories_jobs)
            * :question: [Bulk Delete Catalog Categories](https://developers.klaviyo.com/en/reference/bulk_delete_catalog_categories)
            * :question: [Get Bulk Delete Categories Job](https://developers.klaviyo.com/en/reference/get_bulk_delete_categories_job)
            * :question: [Get Item IDs for Catalog Category](https://developers.klaviyo.com/en/reference/get_item_ids_for_catalog_category)
            * :question: [Add Items to Catalog Category](https://developers.klaviyo.com/en/reference/add_items_to_catalog_category)
            * :question: [Update Items for Catalog Category](https://developers.klaviyo.com/en/reference/update_items_for_catalog_category)
            * :question: [Remove Items from Catalog Category](https://developers.klaviyo.com/en/reference/remove_items_from_catalog_category)
            * :question: [Get Categories for Catalog Item](https://developers.klaviyo.com/en/reference/get_categories_for_catalog_item)
        * :question: Back In Stock
            * :question: [Create Back In Stock Subscription](https://developers.klaviyo.com/en/reference/create_back_in_stock_subscription)
        * :question: Items
            * :question: [Get Catalog Items](https://developers.klaviyo.com/en/reference/get_catalog_items)
            * :question: [Create Catalog Item](https://developers.klaviyo.com/en/reference/create_catalog_item)
            * :question: [Get Catalog Item](https://developers.klaviyo.com/en/reference/get_catalog_item)
            * :question: [Update Catalog Item](https://developers.klaviyo.com/en/reference/update_catalog_item)
            * :question: [Delete Catalog Item](https://developers.klaviyo.com/en/reference/delete_catalog_item)
            * :question: [Get Bulk Create Catalog Items Jobs](https://developers.klaviyo.com/en/reference/get_bulk_create_catalog_items_jobs)
            * :question: [Bulk Create Catalog Items](https://developers.klaviyo.com/en/reference/bulk_create_catalog_items)
            * :question: [Get Bulk Create Catalog Items Job](https://developers.klaviyo.com/en/reference/get_bulk_create_catalog_items_job)
            * :question: [Get Bulk Update Catalog Items Jobs](https://developers.klaviyo.com/en/reference/get_bulk_update_catalog_items_jobs)
            * :question: [Bulk Update Catalog Items](https://developers.klaviyo.com/en/reference/bulk_delete_catalog_items)
            * :question: [Get Bulk Update Catalog Items Job](https://developers.klaviyo.com/en/reference/get_bulk_update_catalog_items_job)
            * :question: [Get Bulk Delete Catalog Items Jobs](https://developers.klaviyo.com/en/reference/get_bulk_delete_catalog_items_jobs)
            * :question: [Bulk Delete Catalog Items](https://developers.klaviyo.com/en/reference/bulk_delete_catalog_items)
            * :question: [Get Bulk Delete Catalog Items Job](https://developers.klaviyo.com/en/reference/get_bulk_delete_catalog_items_job)
            * :question: [Get Items for Catalog Category](https://developers.klaviyo.com/en/reference/get_items_for_catalog_category)
            * :question: [Get Category IDs for Catalog Item](https://developers.klaviyo.com/en/reference/get_category_ids_for_catalog_item)
            * :question: [Add Categories to Catalog Item](https://developers.klaviyo.com/en/reference/add_categories_to_catalog_item)
            * :question: [Update Categories for Catalog Item](https://developers.klaviyo.com/en/reference/update_categories_for_catalog_item)
            * :question: [Remove Categories from Catalog Item](https://developers.klaviyo.com/en/reference/remove_categories_from_catalog_item)
        * :question: Variants
            * :question: [Get Catalog Variants](https://developers.klaviyo.com/en/reference/get_catalog_variants)
            * :question: [Create Catalog Variant](https://developers.klaviyo.com/en/reference/create_catalog_variant)
            * :question: [Get Catalog Variant](https://developers.klaviyo.com/en/reference/get_catalog_variant)
            * :question: [Update Catalog Variant](https://developers.klaviyo.com/en/reference/update_catalog_variant)
            * :question: [Delete Catalog Variant](https://developers.klaviyo.com/en/reference/delete_catalog_variant)
            * :question: [Get Bulk Create Variants Jobs](https://developers.klaviyo.com/en/reference/get_bulk_create_variants_jobs)
            * :question: [Bulk Create Catalog Variants](https://developers.klaviyo.com/en/reference/bulk_create_catalog_variants)
            * :question: [Get Bulk Create Variants Job](https://developers.klaviyo.com/en/reference/get_bulk_create_variants_job)
            * :question: [Get Bulk Update Variants Jobs](https://developers.klaviyo.com/en/reference/get_bulk_update_variants_jobs)
            * :question: [Bulk Update Catalog Variants](https://developers.klaviyo.com/en/reference/bulk_update_catalog_variants)
            * :question: [Get Bulk Update Variants Job](https://developers.klaviyo.com/en/reference/get_bulk_update_variants_job)
            * :question: [Get Bulk Delete Variants Jobs](https://developers.klaviyo.com/en/reference/get_bulk_delete_variants_jobs)
            * :question: [Bulk Delete Catalog Variants](https://developers.klaviyo.com/en/reference/bulk_delete_catalog_variants)
            * :question: [Get Bulk Delete Variants Job](https://developers.klaviyo.com/en/reference/get_bulk_delete_variants_job)
            * :question: [Get Variants for Catalog Item](https://developers.klaviyo.com/en/reference/get_variants_for_catalog_item)
            * :question: [Get Variant IDs for Catalog Item](https://developers.klaviyo.com/en/reference/get_variant_ids_for_catalog_item)
    * :question: Coupons APIs
        * :question: Coupons
            * :question: [Get Coupons](https://developers.klaviyo.com/en/reference/get_coupons)
            * :question: [Create Coupon](https://developers.klaviyo.com/en/reference/create_coupon)
            * :question: [Get Coupon](https://developers.klaviyo.com/en/reference/get_coupon)
            * :question: [Update Coupon](https://developers.klaviyo.com/en/reference/update_coupon)
            * :question: [Delete Coupon](https://developers.klaviyo.com/en/reference/delete_coupon)
            * :question: [Get Coupon Codes](https://developers.klaviyo.com/en/reference/get_coupon_codes)
            * :question: [Create Coupon Code](https://developers.klaviyo.com/en/reference/create_coupon_code)
            * :question: [Get Coupon Code](https://developers.klaviyo.com/en/reference/get_coupon_code)
            * :question: [Update Coupon Code](https://developers.klaviyo.com/en/reference/update_coupon_code)
            * :question: [Delete Coupon Code](https://developers.klaviyo.com/en/reference/delete_coupon_code)
            * :question: [Get Bulk Create Coupon Code Jobs](https://developers.klaviyo.com/en/reference/get_bulk_create_coupon_code_jobs)
            * :question: [Bulk Create Coupon Codes](https://developers.klaviyo.com/en/reference/bulk_create_coupon_codes)
            * :question: [Get Bulk Create Coupon Codes Job](https://developers.klaviyo.com/en/reference/get_bulk_create_coupon_codes_job)
            * :question: [Get Coupon For Coupon Code](https://developers.klaviyo.com/en/reference/get_coupon_for_coupon_code)
            * :question: [Get Coupon ID for Coupon Code](https://developers.klaviyo.com/en/reference/get_coupon_id_for_coupon_code)
            * :question: [Get Coupon Codes for Coupon](https://developers.klaviyo.com/en/reference/get_coupon_codes_for_coupon)
            * :question: [Get Coupon Code IDs for Coupon](https://developers.klaviyo.com/en/reference/get_coupon_code_ids_for_coupon)
    * :question: Data Privacy APIs
        * :question: Data Privacy
            * :question: [Request Profile Deletion](https://developers.klaviyo.com/en/reference/request_profile_deletion)
    * :question: Events APIs
        * :question: Events
            * :question: [Get Events](https://developers.klaviyo.com/en/reference/get_events)
            * :question: [Create Event](https://developers.klaviyo.com/en/reference/create_event)
            * :question: [Get Event](https://developers.klaviyo.com/en/reference/get_event)
            * :question: [Bulk Create Events](https://developers.klaviyo.com/en/reference/bulk_create_events)
            * :question: [Get Metric for Event](https://developers.klaviyo.com/en/reference/get_metric_for_event)
            * :question: [Get Metric ID for Event](https://developers.klaviyo.com/en/reference/get_metric_id_for_event)
            * :question: [Get Profile for Event](https://developers.klaviyo.com/en/reference/get_profile_for_event)
            * :question: [Get Profile ID for Event](https://developers.klaviyo.com/en/reference/get_profile_id_for_event)
    * :question: Flows APIs
        * :question: Flows
            * :question: [Get Flows](https://developers.klaviyo.com/en/reference/get_flows)
            * :question: [Create Flow](https://developers.klaviyo.com/en/reference/create_flow)
            * :question: [Get Flow](https://developers.klaviyo.com/en/reference/get_flow)
            * :question: [Update Flow Status](https://developers.klaviyo.com/en/reference/update_flow)
            * :question: [Delete Flow](https://developers.klaviyo.com/en/reference/delete_flow)
            * :question: [Get Flow Action](https://developers.klaviyo.com/en/reference/get_flow_action)
            * :question: [Get Flow Message](https://developers.klaviyo.com/en/reference/get_flow_message)
            * :question: [Get Actions for Flow](https://developers.klaviyo.com/en/reference/get_actions_for_flow)
            * :question: [Get Action IDs for Flow](https://developers.klaviyo.com/en/reference/get_action_ids_for_flow)
            * :question: [Get Tags for Flow](https://developers.klaviyo.com/en/reference/get_tags_for_flow)
            * :question: [Get Tag IDs for Flow](https://developers.klaviyo.com/en/reference/get_tag_ids_for_flow)
            * :question: [Get Flow for Flow Action](https://developers.klaviyo.com/en/reference/get_flow_for_flow_action)
            * :question: [Get Flow ID for Flow Action](https://developers.klaviyo.com/en/reference/get_flow_id_for_flow_action)
            * :question: [Get Messages For Flow Action](https://developers.klaviyo.com/en/reference/get_flow_action_messages)
            * :question: [Get Message IDs for Flow Action](https://developers.klaviyo.com/en/reference/get_message_ids_for_flow_action)
            * :question: [Get Action for Flow Message](https://developers.klaviyo.com/en/reference/get_action_for_flow_message)
            * :question: [Get Action ID for Flow Message](https://developers.klaviyo.com/en/reference/get_action_id_for_flow_message)
            * :question: [Get Template for Flow Message](https://developers.klaviyo.com/en/reference/get_template_for_flow_message)
            * :question: [Get Template ID for Flow Message](https://developers.klaviyo.com/en/reference/get_template_id_for_flow_message)
    * :question: Forms APIs
        * :question: Forms
            * :question: [Get Forms](https://developers.klaviyo.com/en/reference/get_forms)
            * :question: [Get Form](https://developers.klaviyo.com/en/reference/get_form)
            * :question: [Get Form Version](https://developers.klaviyo.com/en/reference/get_form_version)
            * :question: [Get Versions for Form](https://developers.klaviyo.com/en/reference/get_versions_for_form)
            * :question: [Get Version IDs for Form](https://developers.klaviyo.com/en/reference/get_version_ids_for_form)
            * :question: [Get Form for Form Version](https://developers.klaviyo.com/en/reference/get_form_for_form_version)
            * :question: [Get Form ID for Form Version](https://developers.klaviyo.com/en/reference/get_form_id_for_form_version)
    * :question: Images APIs
        * :question: Images
            * :question: [Get Images](https://developers.klaviyo.com/en/reference/get_images)
            * :question: [Upload Image From URL](https://developers.klaviyo.com/en/reference/upload_image_from_url)
            * :question: [Get Image](https://developers.klaviyo.com/en/reference/get_image)
            * :question: [Update Image](https://developers.klaviyo.com/en/reference/update_image)
            * :question: [Upload Image From File](https://developers.klaviyo.com/en/reference/upload_image_from_file)
    * :question: Lists APIs
        * :question: Lists
            * :question: [Get Lists](https://developers.klaviyo.com/en/reference/get_lists)
            * :question: [Create List](https://developers.klaviyo.com/en/reference/create_list)
            * :question: [Get List](https://developers.klaviyo.com/en/reference/get_list)
            * :question: [Update List](https://developers.klaviyo.com/en/reference/update_list)
            * :question: [Delete List](https://developers.klaviyo.com/en/reference/delete_list)
            * :question: [Get Tags for List](https://developers.klaviyo.com/en/reference/get_tags_for_list)
            * :question: [Get Tag IDs for List](https://developers.klaviyo.com/en/reference/get_tag_ids_for_list)
            * :question: [Get Profiles for List](https://developers.klaviyo.com/en/reference/get_profiles_for_list)
            * :question: [Get Profile IDs for List](https://developers.klaviyo.com/en/reference/get_profile_ids_for_list)
            * :question: [Add Profiles to List](https://developers.klaviyo.com/en/reference/add_profiles_to_list)
            * :question: [Remove Profiles from List](https://developers.klaviyo.com/en/reference/remove_profiles_from_list)
            * :question: [Get Flows Triggered by List](https://developers.klaviyo.com/en/reference/get_flows_triggered_by_list)
            * :question: [Get IDs for Flows Triggered by List](https://developers.klaviyo.com/en/reference/get_ids_for_flows_triggered_by_list)
    * :question: Metrics APIs
        * :question: Metrics
            * :question: [Get Metrics](https://developers.klaviyo.com/en/reference/get_metrics)
            * :question: [Get Metric](https://developers.klaviyo.com/en/reference/get_metric)
            * :question: [Get Metric Property](https://developers.klaviyo.com/en/reference/get_metric_property)
            * :question: [Query Metric Aggregates](https://developers.klaviyo.com/en/reference/query_metric_aggregates)
            * :question: [Get Flows Triggered by Metric](https://developers.klaviyo.com/en/reference/get_flows_triggered_by_metric)
            * :question: [Get IDs for Flows Triggered by Metric](https://developers.klaviyo.com/en/reference/get_ids_for_flows_triggered_by_metric)
            * :question: [Get Properties for Metric](https://developers.klaviyo.com/en/reference/get_properties_for_metric)
            * :question: [Get Property IDs for Metric](https://developers.klaviyo.com/en/reference/get_property_ids_for_metric)
            * :question: [Get Metric for Metric Property](https://developers.klaviyo.com/en/reference/get_metric_for_metric_property)
            * :question: [Get Metric ID for Metric Property](https://developers.klaviyo.com/en/reference/get_metric_id_for_metric_property)
    * :question: Profiles APIs
        * :question: Profiles
            * :question: [Get Profiles](https://developers.klaviyo.com/en/reference/get_profiles)
            * :question: [Create Profile](https://developers.klaviyo.com/en/reference/create_profile)
            * :question: [Get Profile](https://developers.klaviyo.com/en/reference/get_profile)
            * :question: [Update Profile](https://developers.klaviyo.com/en/reference/update_profile)
            * :question: [Create or Update Profile](https://developers.klaviyo.com/en/reference/create_or_update_profile)
            * :question: [Merge Profiles](https://developers.klaviyo.com/en/reference/merge_profiles)
            * :question: [Create or Update Push Token](https://developers.klaviyo.com/en/reference/create_push_token)
            * :question: [Get Lists for Profile](https://developers.klaviyo.com/en/reference/get_lists_for_profile)
            * :question: [Get List IDs for Profile](https://developers.klaviyo.com/en/reference/get_list_ids_for_profile)
            * :question: [Get Segments for Profile](https://developers.klaviyo.com/en/reference/get_segments_for_profile)
            * :question: [Get Segment IDs for Profile](https://developers.klaviyo.com/en/reference/get_segment_ids_for_profile)
        * :question: Consent
            * :question: [Get Bulk Suppress Profiles Jobs](https://developers.klaviyo.com/en/reference/get_bulk_suppress_profiles_jobs)
            * :question: [Bulk Suppress Profiles](https://developers.klaviyo.com/en/reference/bulk_suppress_profiles)
            * :question: [Get Bulk Suppress Profiles Job](https://developers.klaviyo.com/en/reference/get_bulk_suppress_profiles_job)
            * :question: [Get Bulk Unsuppress Profiles Jobs](https://developers.klaviyo.com/en/reference/get_bulk_unsuppress_profiles_jobs)
            * :question: [Bulk Unsuppress Profiles](https://developers.klaviyo.com/en/reference/bulk_unsuppress_profiles)
            * :question: [Get Bulk Unsuppress Profiles Job](https://developers.klaviyo.com/en/reference/get_bulk_unsuppress_profiles_job)
            * :question: [Bulk Subscribe Profiles](https://developers.klaviyo.com/en/reference/bulk_subscribe_profiles)
            * :question: [Bulk Unsubscribe Profiles](https://developers.klaviyo.com/en/reference/bulk_unsubscribe_profiles)
        * :question: Bulk Import Profiles
            * :question: [Get Bulk Import Profiles Jobs](https://developers.klaviyo.com/en/reference/get_bulk_import_profiles_jobs)
            * :question: [Bulk Import Profiles](https://developers.klaviyo.com/en/reference/bulk_import_profiles)
            * :question: [Get Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_bulk_import_profiles_job)
            * :question: [Get List for Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_list_for_bulk_import_profiles_job)
            * :question: [Get List IDs for Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_list_ids_for_bulk_import_profiles_job)
            * :question: [Get Profiles for Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_profiles_for_bulk_import_profiles_job)
            * :question: [Get Profile IDs for Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_profile_ids_for_bulk_import_profiles_job)
            * :question: [Get Errors for Bulk Import Profiles Job](https://developers.klaviyo.com/en/reference/get_errors_for_bulk_import_profiles_job)
    * :question: Reporting APIs
        * :question: Reporting
            * :question: [Query Campaign Values](https://developers.klaviyo.com/en/reference/query_campaign_values)
            * :question: [Query Flow Values](https://developers.klaviyo.com/en/reference/query_flow_values)
            * :question: [Query Flow Series](https://developers.klaviyo.com/en/reference/query_flow_series)
            * :question: [Query Form Values](https://developers.klaviyo.com/en/reference/query_form_values)
            * :question: [Query Form Series](https://developers.klaviyo.com/en/reference/query_form_series)
            * :question: [Query Segment Values](https://developers.klaviyo.com/en/reference/query_segment_values)
            * :question: [Query Segment Series](https://developers.klaviyo.com/en/reference/query_segment_series)
    * :question: Reviews APIs
        * :question: Reviews
            * :question: [Get Reviews](https://developers.klaviyo.com/en/reference/get_reviews)
            * :question: [Get Review](https://developers.klaviyo.com/en/reference/get_review)
            * :question: [Update Review](https://developers.klaviyo.com/en/reference/update_review)
    * :question: Segments APIs
        * :question: Segments
            * :question: [Get Segments](https://developers.klaviyo.com/en/reference/get_segments)
            * :question: [Create Segment](https://developers.klaviyo.com/en/reference/create_segment)
            * :question: [Get Segment](https://developers.klaviyo.com/en/reference/get_segment)
            * :question: [Update Segment](https://developers.klaviyo.com/en/reference/update_segment)
            * :question: [Delete Segment](https://developers.klaviyo.com/en/reference/delete_segment)
            * :question: [Get Tags for Segment](https://developers.klaviyo.com/en/reference/get_tags_for_segment)
            * :question: [Get Tag IDs for Segment](https://developers.klaviyo.com/en/reference/get_tag_ids_for_segment)
            * :question: [Get Profiles for Segment](https://developers.klaviyo.com/en/reference/get_profiles_for_segment)
            * :question: [Get Profile IDs for Segment](https://developers.klaviyo.com/en/reference/get_profile_ids_for_segment)
            * :question: [Get Flows Triggered by Segment](https://developers.klaviyo.com/en/reference/get_flows_triggered_by_segment)
            * :question: [Get IDs for Flows Triggered by Segment](https://developers.klaviyo.com/en/reference/get_ids_for_flows_triggered_by_segment)
    * :question: Tags APIs
        * :question: Tags
            * :question: [Get Tags](https://developers.klaviyo.com/en/reference/get_tags)
            * :question: [Create Tag](https://developers.klaviyo.com/en/reference/create_tag)
            * :question: [Get Tag](https://developers.klaviyo.com/en/reference/get_tag)
            * :question: [Update Tag](https://developers.klaviyo.com/en/reference/update_tag)
            * :question: [Delete Tag](https://developers.klaviyo.com/en/reference/delete_tag)
            * :question: [Get Flow IDs for Tag](https://developers.klaviyo.com/en/reference/get_flow_ids_for_tag)
            * :question: [Tag Flows](https://developers.klaviyo.com/en/reference/tag_flows)
            * :question: [Remove Tag from Flows](https://developers.klaviyo.com/en/reference/remove_tag_from_flows)
            * :question: [Get Campaign IDs for Tag](https://developers.klaviyo.com/en/reference/get_campaign_ids_for_tag)
            * :question: [Tag Campaigns](https://developers.klaviyo.com/en/reference/tag_campaigns)
            * :question: [Remove Tag from Campaigns](https://developers.klaviyo.com/en/reference/remove_tag_from_campaigns)
            * :question: [Get List IDs for Tag](https://developers.klaviyo.com/en/reference/get_list_ids_for_tag)
            * :question: [Tag Lists](https://developers.klaviyo.com/en/reference/tag_lists)
            * :question: [Remove Tag from Lists](https://developers.klaviyo.com/en/reference/remove_tag_from_lists)
            * :question: [Get Segment IDs for Tag](https://developers.klaviyo.com/en/reference/get_segment_ids_for_tag)
            * :question: [Tag Segments](https://developers.klaviyo.com/en/reference/tag_segments)
            * :question: [Remove Tag from Segments](https://developers.klaviyo.com/en/reference/remove_tag_from_segments)
            * :question: [Get Tag Group for Tag](https://developers.klaviyo.com/en/reference/get_tag_group_for_tag)
            * :question: [Get Tag Group ID for Tag](https://developers.klaviyo.com/en/reference/get_tag_group_id_for_tag)
        * :question: Tag Groups
            * :question: [Get Tag Groups](https://developers.klaviyo.com/en/reference/get_tag_groups)
            * :question: [Create Tag Group](https://developers.klaviyo.com/en/reference/create_tag_group)
            * :question: [Get Tag Group](https://developers.klaviyo.com/en/reference/get_tag_group)
            * :question: [Update Tag Group](https://developers.klaviyo.com/en/reference/update_tag_group)
            * :question: [Delete Tag Group](https://developers.klaviyo.com/en/reference/delete_tag_group)
            * :question: [Get Tags for Tag Group](https://developers.klaviyo.com/en/reference/get_tags_for_tag_group)
            * :question: [Get Tag IDs for Tag Group](https://developers.klaviyo.com/en/reference/get_tag_ids_for_tag_group)
    * :question: Templates APIs
        * :question: Templates
            * :question: [Get Templates](https://developers.klaviyo.com/en/reference/get_templates)
            * :question: [Create Template](https://developers.klaviyo.com/en/reference/create_template)
            * :question: [Get Template](https://developers.klaviyo.com/en/reference/get_template)
            * :question: [Update Template](https://developers.klaviyo.com/en/reference/update_template)
            * :question: [Delete Template](https://developers.klaviyo.com/en/reference/delete_template)
            * :question: [Render Template](https://developers.klaviyo.com/en/reference/render_template)
            * :question: [Clone Template](https://developers.klaviyo.com/en/reference/clone_template)
        * :question: Universal Content
            * :question: [Get All Universal Content](https://developers.klaviyo.com/en/reference/get_all_universal_content)
            * :question: [Create Universal Content](https://developers.klaviyo.com/en/reference/create_universal_content)
            * :question: [Get Universal Content](https://developers.klaviyo.com/en/reference/get_universal_content)
            * :question: [Update Universal Content](https://developers.klaviyo.com/en/reference/update_universal_content)
            * :question: [Delete Universal Content](https://developers.klaviyo.com/en/reference/delete_universal_content)
    * :question: Tracking Settings APIs
        * :question: Tracking Settings
            * :question: [Get Tracking Settings](https://developers.klaviyo.com/en/reference/get_tracking_settings)
            * :question: [Get Tracking Setting](https://developers.klaviyo.com/en/reference/get_tracking_setting)
            * :question: [Update Tracking Setting](https://developers.klaviyo.com/en/reference/update_tracking_setting)
    * :question: Webhooks APIs
        * :question: Webhooks
            * :question: [Get Webhooks](https://developers.klaviyo.com/en/reference/get_webhooks)
            * :question: [Create Webhook](https://developers.klaviyo.com/en/reference/create_webhook)
            * :question: [Get Webhook](https://developers.klaviyo.com/en/reference/get_webhook)
            * :question: [Update Webhook](https://developers.klaviyo.com/en/reference/update_webhook)
            * :question: [Delete Webhook](https://developers.klaviyo.com/en/reference/delete_webhook)
            * :question: [Get Webhook Topics](https://developers.klaviyo.com/en/reference/get_webhook_topics)
            * :question: [Get Webhook Topic](https://developers.klaviyo.com/en/reference/get_webhook_topic)

## How to Use

```csharp
//Setup the config and client
var config = new KlaviyoConfig("Api-Key-Goes-Here");
var client = new KlaviyoAdminApi(config);

//You can also directly pass in the API key to the client
client = new KlaviyoAdminApi("Api-Key-Goes-Here");

//The public client doesn't use an API key, just a company ID
var publicClient = new KlaviyoClientApi("Company-ID-Goes-Here");

//Create filter for listing objects. Filters added to a FilterList are ANDed together.
var filter1 = new Filter(FilterOperation.Equals, "email", "test@example.com");
var filter2 = new Filter(FilterOperation.LessThan, "last_updated", DateOnly.Parse("2021-01-01"));
var filters = new FilterList() { filter1, filter2 };

//Retrieve profiles using the filter. All API calls are async.
var profiles = client.ProfileServices.GetProfiles(filter: filters, sort: "last_updated").Result;

//Returned lists are wrapped in a DataListObject class. The Data property contains the list of objects.
foreach (var profile in profiles.Data)
{
    Console.WriteLine(profile.Id);
}

//Create a new profile - Using the Create method sets the required default properties.
var newProfile = Profile.Create();
newProfile.Attributes = new()
{
    FirstName = "Test",
    LastName = "User",
    Email = "testing@example.com"
};
var createdProfile = client.ProfileServices.CreateProfile(newProfile).Result;

//Returned single items are wrapped in a DataObject class. The Data property contains the object.
Console.WriteLine(createdProfile.Data.Id);
```
