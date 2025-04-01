using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EBanContentCheckResult
{
    k_EBanContentCheckResult_NotScanned = 0,
    k_EBanContentCheckResult_Reset = 1,
    k_EBanContentCheckResult_NeedsChecking = 2,
    k_EBanContentCheckResult_VeryUnlikely = 5,
    k_EBanContentCheckResult_Unlikely = 30,
    k_EBanContentCheckResult_Possible = 50,
    k_EBanContentCheckResult_Likely = 75,
    k_EBanContentCheckResult_VeryLikely = 100,
}
public enum EProtoClanEventType
{
    k_EClanOtherEvent = 1,
    k_EClanGameEvent = 2,
    k_EClanPartyEvent = 3,
    k_EClanMeetingEvent = 4,
    k_EClanSpecialCauseEvent = 5,
    k_EClanMusicAndArtsEvent = 6,
    k_EClanSportsEvent = 7,
    k_EClanTripEvent = 8,
    k_EClanChatEvent = 9,
    k_EClanGameReleaseEvent = 10,
    k_EClanBroadcastEvent = 11,
    k_EClanSmallUpdateEvent = 12,
    k_EClanPreAnnounceMajorUpdateEvent = 13,
    k_EClanMajorUpdateEvent = 14,
    k_EClanDLCReleaseEvent = 15,
    k_EClanFutureReleaseEvent = 16,
    k_EClanESportTournamentStreamEvent = 17,
    k_EClanDevStreamEvent = 18,
    k_EClanFamousStreamEvent = 19,
    k_EClanGameSalesEvent = 20,
    k_EClanGameItemSalesEvent = 21,
    k_EClanInGameBonusXPEvent = 22,
    k_EClanInGameLootEvent = 23,
    k_EClanInGamePerksEvent = 24,
    k_EClanInGameChallengeEvent = 25,
    k_EClanInGameContestEvent = 26,
    k_EClanIRLEvent = 27,
    k_EClanNewsEvent = 28,
    k_EClanBetaReleaseEvent = 29,
    k_EClanInGameContentReleaseEvent = 30,
    k_EClanFreeTrial = 31,
    k_EClanSeasonRelease = 32,
    k_EClanSeasonUpdate = 33,
    k_EClanCrosspostEvent = 34,
    k_EClanInGameEventGeneral = 35,
}
public enum PartnerEventNotificationType
{
    k_EEventStart = 0,
    k_EEventBroadcastStart = 1,
    k_EEventMatchStart = 2,
    k_EEventPartnerMaxType = 3,
}
public record CMsgIPAddress(int SF1v4, byte[] v6) : DotaPacket;
public record CMsgIPAddressBucket(CMsgIPAddress original_ip_address, long SF2bucket) : DotaPacket;
public record CMsgGCRoutingProtoBufHeader(ulong dst_gcid_queue, uint dst_gc_dir_index) : DotaPacket;
public record CMsgProtoBufHeader(long SF2steamid, int client_sessionid, uint routing_appid, bool unused4, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, long SF2jobid_source, long SF2jobid_target, string target_job_name, int eresult, string error_message, uint ip, uint auth_account_flags, int transport_error, ulong messageid, uint publisher_group_id, uint sysid, ulong trace_tag, uint token_source, bool admin_spoofing_user, int seq_num, uint webapi_key_id, bool is_from_external_source, List<uint> forward_to_sysid, uint cm_sysid, byte[] ip_v6, uint launcher_type, uint realm, int timeout_ms) : DotaPacket
{
    public enum ESessionDisposition
    {
        k_ESessionDispositionNormal = 0,
        k_ESessionDispositionDisconnect = 1,
    }
}
public record CMsgMulti(uint size_unzipped, byte[] message_body) : DotaPacket;
public record CMsgProtobufWrapped(byte[] message_body) : DotaPacket;
public record CMsgAuthTicket(uint estate, uint eresult, long SF2steamid, long SF2gameid, uint h_steam_pipe, uint ticket_crc, byte[] ticket, byte[] server_secret, uint ticket_type) : DotaPacket;
public record CCDDBAppDetailCommon(uint appid, string name, string icon, bool unused4, bool unused5, bool tool, bool demo, bool media, bool community_visible_stats, string friendly_name, string propagation, bool has_adult_content, bool is_visible_in_steam_china, uint app_type, bool has_adult_content_sex, bool has_adult_content_violence, List<uint> content_descriptorids) : DotaPacket;
public record CMsgAppRights(bool edit_info, bool publish, bool view_error_data, bool download, bool upload_cdkeys, bool generate_cdkeys, bool view_financials, bool manage_ceg, bool manage_signing, bool manage_cdkeys, bool edit_marketing, bool economy_support, bool economy_support_supervisor, bool manage_pricing, bool broadcast_live, bool view_marketing_traffic, bool edit_store_display_content) : DotaPacket;
public record CCuratorPreferences(uint supported_languages, bool platform_windows, bool platform_mac, bool platform_linux, bool vr_content, bool adult_content_violence, bool adult_content_sex, uint timestamp_updated, List<uint> tagids_curated, List<uint> tagids_filtered, string website_title, string website_url, string discussion_url, bool show_broadcast) : DotaPacket;
public record CLocalizationToken(uint language, string localized_string) : DotaPacket;
public record CClanEventUserNewsTuple(uint clanid, long SF2event_gid, long SF2announcement_gid, uint rtime_start, uint rtime_end, uint priority_score, uint type, uint clamp_range_slot, uint appid, uint rtime32_last_modified) : DotaPacket;
public record CClanMatchEventByRange(uint rtime_before, uint rtime_after, uint qualified, List<CClanEventUserNewsTuple> events) : DotaPacket;
public record CCommunity_ClanAnnouncementInfo(ulong gid, ulong clanid, ulong posterid, string headline, uint posttime, uint updatetime, string body, int commentcount, List<string> tags, int language, bool hidden, long SF2forum_topic_id, long SF2event_gid, int voteupcount, int votedowncount, EBanContentCheckResult ban_check_result, bool banned) : DotaPacket;
public record CClanEventData(long SF2gid, long SF2clan_steamid, string event_name, EProtoClanEventType event_type, uint appid, string server_address, string server_password, uint rtime32_start_time, uint rtime32_end_time, int comment_count, long SF2creator_steamid, long SF2last_update_steamid, string event_notes, string jsondata, CCommunity_ClanAnnouncementInfo announcement_body, bool published, bool hidden, uint rtime32_visibility_start, uint rtime32_visibility_end, uint broadcaster_accountid, uint follower_count, uint ignore_count, long SF2forum_topic_id, uint rtime32_last_modified, long SF2news_post_gid, uint rtime_mod_reviewed, uint featured_app_tagid, List<uint> referenced_appids, uint build_id, string build_branch) : DotaPacket;
public record CBilling_Address(string first_name, string last_name, string address1, string address2, string city, string us_state, string country_code, string postcode, int zip_plus4, string phone) : DotaPacket;
public record CPackageReservationStatus(uint packageid, int reservation_state, int queue_position, int total_queue_size, string reservation_country_code, bool expired, uint time_expires, uint time_reserved) : DotaPacket;
public record CMsgKeyValuePair(string name, string value) : DotaPacket;
public record CMsgKeyValueSet(List<CMsgKeyValuePair> pairs) : DotaPacket;
public record UserContentDescriptorPreferences(List<UserContentDescriptorPreferences.ContentDescriptor> content_descriptors_to_exclude) : DotaPacket
{
    public record ContentDescriptor(uint content_descriptorid, uint timestamp_added);
}
