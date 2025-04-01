namespace Tranquil.Schema;

public enum ESourceEngine
{
    k_ESE_Source1 = 0,
    k_ESE_Source2 = 1,
}
public enum PartnerAccountType
{
    PARTNER_NONE = 0,
    PARTNER_PERFECT_WORLD = 1,
    PARTNER_INVALID = 3,
}
public enum GCConnectionStatus
{
    GCConnectionStatus_HAVE_SESSION = 0,
    GCConnectionStatus_GC_GOING_DOWN = 1,
    GCConnectionStatus_NO_SESSION = 2,
    GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE = 3,
    GCConnectionStatus_NO_STEAM = 4,
    GCConnectionStatus_SUSPENDED = 5,
    GCConnectionStatus_STEAM_GOING_DOWN = 6,
}
public record CExtraMsgBlock(uint msg_type, byte[] contents, ulong msg_key, bool is_compressed) : DotaPacket;
public record CMsgSteamLearnServerInfo(bool unused1, bool unused2, bool unused3, CMsgSteamLearnAccessTokens access_tokens, List<CMsgSteamLearnServerInfo.ProjectInfo> project_infos) : DotaPacket
{
    public record ProjectInfo(uint project_id, uint snapshot_published_version, uint inference_published_version, bool unused4, bool unused5, uint snapshot_percentage, bool snapshot_enabled);
}
public record CMsgGCAssertJobData(string message_type, byte[] message_data) : DotaPacket;
public record CMsgGCConCommand(string command) : DotaPacket;
public record CMsgSDOAssert(int sdo_type, List<CMsgSDOAssert.Request> requests) : DotaPacket
{
    public record Request(List<ulong> key, string requesting_job);
}
public record CMsgSOIDOwner(uint type, ulong id) : DotaPacket;
public record CMsgSOSingleObject(bool unused1, int type_id, byte[] object_data, long SF2version, CMsgSOIDOwner owner_soid, uint service_id) : DotaPacket;
public record CMsgSOMultipleObjects(bool unused1, List<CMsgSOMultipleObjects.SingleObject> objects_modified, long SF2version, List<CMsgSOMultipleObjects.SingleObject> objects_added, List<CMsgSOMultipleObjects.SingleObject> objects_removed, CMsgSOIDOwner owner_soid, uint service_id) : DotaPacket
{
    public record SingleObject(int type_id, byte[] object_data);
}
public record CMsgSOCacheSubscribed(bool unused1, List<CMsgSOCacheSubscribed.SubscribedType> objects, long SF2version, CMsgSOIDOwner owner_soid, uint service_id, List<uint> service_list, long SF2sync_version) : DotaPacket
{
    public record SubscribedType(int type_id, List<byte[]> object_data);
}
public record CMsgSOCacheSubscribedUpToDate(long SF2version, CMsgSOIDOwner owner_soid, uint service_id, List<uint> service_list, long SF2sync_version) : DotaPacket;
public record CMsgSOCacheUnsubscribed(bool unused1, CMsgSOIDOwner owner_soid) : DotaPacket;
public record CMsgSOCacheSubscriptionCheck(bool unused1, long SF2version, CMsgSOIDOwner owner_soid, uint service_id, List<uint> service_list, long SF2sync_version) : DotaPacket;
public record CMsgSOCacheSubscriptionRefresh(bool unused1, CMsgSOIDOwner owner_soid) : DotaPacket;
public record CMsgSOCacheVersion(long SF2version) : DotaPacket;
public record CMsgGCMultiplexMessage(uint msgtype, byte[] payload, List<long> SF2steamids) : DotaPacket;
public record CMsgGCToGCSubGCStarting(int dir_index) : DotaPacket;
public record CGCToGCMsgMasterAck(int dir_index, bool unused2, string machine_name, string process_name, bool unused5, List<CGCToGCMsgMasterAck.Process> directory) : DotaPacket
{
    public record Process(int dir_index, List<uint> type_instances);
}
public record CGCToGCMsgMasterAck_Response(int eresult) : DotaPacket;
public record CMsgGCToGCUniverseStartup(bool is_initial_startup) : DotaPacket;
public record CMsgGCToGCUniverseStartupResponse(int eresult) : DotaPacket;
public record CGCToGCMsgMasterStartupComplete(List<CGCToGCMsgMasterStartupComplete.GCInfo> gc_info) : DotaPacket
{
    public record GCInfo(int dir_index, string machine_name);
}
public record CGCToGCMsgRouted(uint msg_type, long SF2sender_id, byte[] net_message) : DotaPacket;
public record CGCToGCMsgRoutedReply(uint msg_type, byte[] net_message) : DotaPacket;
public record CMsgGCUpdateSubGCSessionInfo(List<CMsgGCUpdateSubGCSessionInfo.CMsgUpdate> updates) : DotaPacket
{
    public record CMsgUpdate(long SF2steamid, int SF1ip, bool trusted);
}
public record CMsgGCRequestSubGCSessionInfo(long SF2steamid) : DotaPacket;
public record CMsgGCRequestSubGCSessionInfoResponse(int SF1ip, bool trusted, uint port, bool success) : DotaPacket;
public record CMsgSOCacheHaveVersion(CMsgSOIDOwner soid, long SF2version, uint service_id, uint cached_file_version) : DotaPacket;
public record CMsgClientHello(uint version, List<CMsgSOCacheHaveVersion> socache_have_versions, uint client_session_need, PartnerAccountType client_launcher, string secret_key, uint client_language, ESourceEngine engine, byte[] steamdatagram_login, uint platform_id, byte[] game_msg, int os_type, uint render_system, uint render_system_req, uint screen_width, uint screen_height, uint screen_refresh, uint render_width, uint render_height, uint swap_width, uint swap_height, bool unused21, bool is_steam_china, string platform_name, bool is_steam_china_client) : DotaPacket;
public record CMsgClientWelcome(uint version, byte[] game_data, List<CMsgSOCacheSubscribed> outofdate_subscribed_caches, List<CMsgSOCacheSubscriptionCheck> uptodate_subscribed_caches, CMsgClientWelcome.Location location, bool unused6, bool unused7, bool unused8, uint gc_socache_file_version, string txn_country_code, byte[] game_data2, uint rtime32_gc_welcome_timestamp, uint currency, uint balance, string balance_url, bool has_accepted_china_ssa, bool is_banned_steam_china, CExtraMsgBlock additional_welcome_msgs, bool unused19, CMsgSteamLearnServerInfo steam_learn_server_info) : DotaPacket
{
    public record Location(float latitude, float longitude, string country);
}
public record CMsgConnectionStatus(GCConnectionStatus status, uint client_session_need, int queue_position, int queue_size, int wait_seconds, int estimated_wait_seconds_remaining) : DotaPacket;
public record CMsgGCToGCSOCacheSubscribe(long SF2subscriber, long SF2subscribe_to_id, long SF2sync_version, List<CMsgGCToGCSOCacheSubscribe.CMsgHaveVersions> have_versions, uint subscribe_to_type) : DotaPacket
{
    public record CMsgHaveVersions(uint service_id, ulong version);
}
public record CMsgGCToGCSOCacheUnsubscribe(long SF2subscriber, long SF2unsubscribe_from_id, uint unsubscribe_from_type) : DotaPacket;
public record CMsgGCClientPing : DotaPacket;
public record CMsgGCToGCForwardAccountDetails(long SF2steamid, CGCSystemMsg_GetAccountDetails_Response account_details, uint age_seconds) : DotaPacket;
public record CMsgGCToGCLoadSessionSOCache(uint account_id, CMsgGCToGCForwardAccountDetails forward_account_details) : DotaPacket;
public record CMsgGCToGCLoadSessionSOCacheResponse : DotaPacket;
public record CMsgGCToGCUpdateSessionStats(uint user_sessions, uint server_sessions, bool in_logon_surge) : DotaPacket;
public record CMsgGCToClientRequestDropped : DotaPacket;
public record CWorkshop_PopulateItemDescriptions_Request(uint appid, List<CWorkshop_PopulateItemDescriptions_Request.ItemDescriptionsLanguageBlock> languages) : DotaPacket
{
    public record SingleItemDescription(uint gameitemid, string item_description);
    public record ItemDescriptionsLanguageBlock(string language, List<CWorkshop_PopulateItemDescriptions_Request.SingleItemDescription> descriptions);
}
public record CWorkshop_GetContributors_Request(uint appid, uint gameitemid) : DotaPacket;
public record CWorkshop_GetContributors_Response(List<long> SF2contributors) : DotaPacket;
public record CWorkshop_SetItemPaymentRules_Request(uint appid, uint gameitemid, List<CWorkshop_SetItemPaymentRules_Request.WorkshopItemPaymentRule> associated_workshop_files, List<CWorkshop_SetItemPaymentRules_Request.PartnerItemPaymentRule> partner_accounts, bool validate_only, bool make_workshop_files_subscribable, CWorkshop_SetItemPaymentRules_Request.WorkshopDirectPaymentRule associated_workshop_file_for_direct_payments) : DotaPacket
{
    public record WorkshopItemPaymentRule(ulong workshop_file_id, float revenue_percentage, string rule_description, uint rule_type);
    public record WorkshopDirectPaymentRule(ulong workshop_file_id, string rule_description);
    public record PartnerItemPaymentRule(uint account_id, float revenue_percentage, string rule_description);
}
public record CWorkshop_SetItemPaymentRules_Response(List<string> validation_errors) : DotaPacket;
public record CCommunity_ClanAnnouncementInfo(ulong gid, ulong clanid, ulong posterid, string headline, uint posttime, uint updatetime, string body, int commentcount, List<string> tags, int language, bool hidden, long SF2forum_topic_id) : DotaPacket;
public record CCommunity_GetClanAnnouncements_Request(ulong steamid, uint offset, uint count, uint maxchars, bool strip_html, List<string> required_tags, bool require_no_tags, List<uint> language_preference, bool hidden_only, bool only_gid, uint rtime_oldest_date, bool include_hidden, bool include_partner_events) : DotaPacket;
public record CCommunity_GetClanAnnouncements_Response(uint maxchars, bool strip_html, List<CCommunity_ClanAnnouncementInfo> announcements) : DotaPacket;
public record CBroadcast_PostGameDataFrame_Request(uint appid, long SF2steamid, long SF2broadcast_id, byte[] frame_data) : DotaPacket;
public record CMsgSerializedSOCache(uint file_version, List<CMsgSerializedSOCache.Cache> caches, uint gc_socache_file_version) : DotaPacket
{
    public record TypeCache(uint type, List<byte[]> objects, uint service_id);
    public record Cache(uint type, ulong id, List<CMsgSerializedSOCache.Cache.Version> versions, List<CMsgSerializedSOCache.TypeCache> type_caches)
    {
        public record Version(uint service, ulong version);
    }
}
public record CMsgGCToClientPollConvarRequest(string convar_name, uint poll_id) : DotaPacket;
public record CMsgGCToClientPollConvarResponse(uint poll_id, string convar_value) : DotaPacket;
public record CGCMsgCompressedMsgToClient(uint msg_id, byte[] compressed_msg) : DotaPacket;
public record CMsgGCToGCMasterBroadcastMessage(uint users_per_second, bool send_to_users, bool send_to_servers, uint msg_id, byte[] msg_data) : DotaPacket;
public record CMsgGCToGCMasterSubscribeToCache(uint soid_type, long SF2soid_id, List<uint> account_ids, List<long> SF2steam_ids) : DotaPacket;
public record CMsgGCToGCMasterSubscribeToCacheResponse : DotaPacket;
public record CMsgGCToGCMasterSubscribeToCacheAsync(CMsgGCToGCMasterSubscribeToCache subscribe_msg) : DotaPacket;
public record CMsgGCToGCMasterUnsubscribeFromCache(uint soid_type, long SF2soid_id, List<uint> account_ids, List<long> SF2steam_ids) : DotaPacket;
public record CMsgGCToGCMasterDestroyCache(uint soid_type, long SF2soid_id) : DotaPacket;
