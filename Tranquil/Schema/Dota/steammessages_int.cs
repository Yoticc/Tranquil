using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgWebAPIKey(uint status, uint account_id, uint publisher_group_id, uint key_id, string domain) : DotaPacket;
public record CMsgHttpRequest(uint request_method, string hostname, string url, List<CMsgHttpRequest.RequestHeader> headers, List<CMsgHttpRequest.QueryParam> get_params, List<CMsgHttpRequest.QueryParam> post_params, byte[] body, uint absolute_timeout, bool use_https) : DotaPacket
{
    public record RequestHeader(string name, string value);
    public record QueryParam(string name, byte[] value);
}
public record CMsgWebAPIRequest(bool unused1, string interface_name, string method_name, uint version, CMsgWebAPIKey api_key, CMsgHttpRequest request, uint routing_app_id) : DotaPacket;
public record CMsgHttpResponse(uint status_code, List<CMsgHttpResponse.ResponseHeader> headers, byte[] body) : DotaPacket
{
    public record ResponseHeader(string name, string value);
}
public record CMsgAMFindAccounts(uint search_type, string search_string) : DotaPacket;
public record CMsgAMFindAccountsResponse(List<long> SF2steam_id) : DotaPacket;
public record CMsgNotifyWatchdog(uint source, uint alert_type, bool unused3, bool critical, uint time, uint appid, string text, bool unused8, bool unused9, bool unused10, bool unused11, string recipient) : DotaPacket;
public record CMsgAMGetLicenses(long SF2steamid) : DotaPacket;
public record CMsgPackageLicense(uint package_id, uint time_created, uint owner_id) : DotaPacket;
public record CMsgAMGetLicensesResponse(List<CMsgPackageLicense> license, uint result) : DotaPacket;
public record CMsgGCGetCommandList(uint app_id, string command_prefix) : DotaPacket;
public record CMsgGCGetCommandListResponse(List<string> command_name) : DotaPacket;
public record CGCMsgMemCachedGet(List<string> keys) : DotaPacket;
public record CGCMsgMemCachedGetResponse(List<CGCMsgMemCachedGetResponse.ValueTag> values) : DotaPacket
{
    public record ValueTag(bool found, byte[] value);
}
public record CGCMsgMemCachedSet(List<CGCMsgMemCachedSet.KeyPair> keys) : DotaPacket
{
    public record KeyPair(string name, byte[] value);
}
public record CGCMsgMemCachedDelete(List<string> keys) : DotaPacket;
public record CGCMsgMemCachedStats : DotaPacket;
public record CGCMsgMemCachedStatsResponse(ulong curr_connections, ulong cmd_get, ulong cmd_set, ulong cmd_flush, ulong get_hits, ulong get_misses, ulong delete_hits, ulong delete_misses, ulong bytes_read, ulong bytes_written, ulong limit_maxbytes, ulong curr_items, ulong evictions, ulong bytes) : DotaPacket;
public record CGCMsgSQLStats(uint schema_catalog) : DotaPacket;
public record CGCMsgSQLStatsResponse(uint threads, uint threads_connected, uint threads_active, uint operations_submitted, uint prepared_statements_executed, uint non_prepared_statements_executed, uint deadlock_retries, uint operations_timed_out_in_queue, uint errors) : DotaPacket;
public record CMsgAMAddFreeLicense(long SF2steamid, uint ip_public, uint packageid, string store_country_code) : DotaPacket;
public record CMsgAMAddFreeLicenseResponse(int eresult, int purchase_result_detail, long SF2transid) : DotaPacket;
public record CGCMsgGetIPLocation(List<int> SF1ips) : DotaPacket;
public record CGCMsgGetIPASN(List<int> SF1ips) : DotaPacket;
public record CIPASNInfo(int SF1ip, uint asn) : DotaPacket;
public record CGCMsgGetIPASNResponse(List<CIPASNInfo> infos) : DotaPacket;
public record CMsgAMSendEmail(long SF2steamid, uint email_msg_type, uint email_format, bool unused4, List<CMsgAMSendEmail.PersonaNameReplacementToken> persona_name_tokens, uint source_gc, List<CMsgAMSendEmail.ReplacementToken> tokens) : DotaPacket
{
    public record ReplacementToken(string token_name, string token_value);
    public record PersonaNameReplacementToken(long SF2steamid, string token_name);
}
public record CMsgAMSendEmailResponse(uint eresult) : DotaPacket;
public record CMsgGCGetEmailTemplate(uint app_id, uint email_msg_type, int email_lang, int email_format) : DotaPacket;
public record CMsgGCGetEmailTemplateResponse(uint eresult, bool template_exists, string template) : DotaPacket;
public record CMsgAMGrantGuestPasses2(long SF2steam_id, uint package_id, int passes_to_grant, int days_to_expiration, int action) : DotaPacket;
public record CMsgAMGrantGuestPasses2Response(int eresult, int passes_granted) : DotaPacket;
public record CMsgGCGetPersonaNames(List<long> SF2steamids) : DotaPacket;
public record CMsgGCGetPersonaNames_Response(List<CMsgGCGetPersonaNames_Response.PersonaName> succeeded_lookups, List<long> SF2failed_lookup_steamids) : DotaPacket
{
    public record PersonaName(long SF2steamid, string persona_name);
}
public record CMsgGCCheckFriendship(long SF2steamid_left, long SF2steamid_right) : DotaPacket;
public record CMsgGCCheckFriendship_Response(bool success, bool found_friendship) : DotaPacket;
public record CMsgGCGetAppFriendsList(long SF2steamid, bool include_friendship_timestamps, bool include_friends_with_no_play_time) : DotaPacket;
public record CMsgGCGetAppFriendsList_Response(bool success, List<long> SF2steamids, List<int> SF1friendship_timestamps, List<int> SF1last_playtimes) : DotaPacket;
public record CMsgGCMsgMasterSetDirectory(int master_dir_index, List<CMsgGCMsgMasterSetDirectory.SubGC> dir) : DotaPacket
{
    public record SubGC(int dir_index, string name, string box, string command_line, string gc_binary);
}
public record CMsgGCMsgMasterSetDirectory_Response(int eresult, string message) : DotaPacket;
public record CMsgGCMsgWebAPIJobRequestForwardResponse(int dir_index) : DotaPacket;
public record CGCSystemMsg_GetPurchaseTrust_Request(long SF2steamid) : DotaPacket;
public record CGCSystemMsg_GetPurchaseTrust_Response(bool has_prior_purchase_history, bool has_no_recent_password_resets, bool is_wallet_cash_trusted, uint time_all_trusted) : DotaPacket;
public record CMsgGCHAccountVacStatusChange(long SF2steam_id, uint app_id, uint rtime_vacban_starts, bool is_banned_now, bool is_banned_future) : DotaPacket;
public record CMsgGCRoutingInfo(List<int> dir_index, CMsgGCRoutingInfo.RoutingMethod method, CMsgGCRoutingInfo.RoutingMethod fallback, uint protobuf_field, string webapi_param) : DotaPacket
{
    public enum RoutingMethod
    {
        RANDOM = 0,
        DISCARD = 1,
        CLIENT_STEAMID = 2,
        PROTOBUF_FIELD_UINT64 = 3,
        WEBAPI_PARAM = 4,
        WEBAPI_PARAM_STEAMID_ACCOUNTID = 5,
    }
}
public record CMsgGCMsgMasterSetWebAPIRouting(List<CMsgGCMsgMasterSetWebAPIRouting.Entry> entries) : DotaPacket
{
    public record Entry(string interface_name, string method_name, CMsgGCRoutingInfo routing);
}
public record CMsgGCMsgMasterSetClientMsgRouting(List<CMsgGCMsgMasterSetClientMsgRouting.Entry> entries) : DotaPacket
{
    public record Entry(uint msg_type, CMsgGCRoutingInfo routing);
}
public record CMsgGCMsgMasterSetWebAPIRouting_Response(int eresult) : DotaPacket;
public record CMsgGCMsgMasterSetClientMsgRouting_Response(int eresult) : DotaPacket;
public record CMsgGCMsgSetOptions(List<CMsgGCMsgSetOptions.Option> options, List<CMsgGCMsgSetOptions.MessageRange> client_msg_ranges, CMsgGCMsgSetOptions.GCSQLVersion gcsql_version) : DotaPacket
{
    public enum Option
    {
        NOTIFY_USER_SESSIONS = 0,
        NOTIFY_SERVER_SESSIONS = 1,
        NOTIFY_ACHIEVEMENTS = 2,
        NOTIFY_VAC_ACTION = 3,
    }
    public enum GCSQLVersion
    {
        GCSQL_VERSION_BASELINE = 1,
        GCSQL_VERSION_BOOLTYPE = 2,
    }
    public record MessageRange(uint low, uint high);
}
public record CMsgGCHUpdateSession(long SF2steam_id, uint app_id, bool online, long SF2server_steam_id, uint server_addr, uint server_port, uint os_type, uint client_addr, List<CMsgGCHUpdateSession.ExtraField> extra_fields) : DotaPacket
{
    public record ExtraField(string name, string value);
}
public record CMsgNotificationOfSuspiciousActivity(long SF2steamid, uint appid, CMsgNotificationOfSuspiciousActivity.MultipleGameInstances multiple_instances) : DotaPacket
{
    public record MultipleGameInstances(uint app_instance_count, List<long> SF2other_steamids);
}
public record CMsgGCHVacVerificationChange(long SF2steamid, uint appid, bool is_verified) : DotaPacket;
public record CMsgGCCheckClanMembership(long SF2steamid, uint clanid) : DotaPacket;
public record CMsgGCCheckClanMembership_Response(bool ismember) : DotaPacket;
public record CMsgGCHAppCheersReceived(uint appid, List<CMsgGCHAppCheersReceived.CheerTarget> cheer_targets) : DotaPacket
{
    public record CheerTypeAmount(uint cheer_type, uint cheer_amount);
    public record CheerTarget(ulong cheer_target, List<CMsgGCHAppCheersReceived.CheerTypeAmount> cheer_types);
}
public record CMsgGCHAppCheersGetAllowedTypes(uint appid, ulong cheer_target) : DotaPacket;
public record CMsgGCHAppCheersGetAllowedTypesResponse(List<uint> cheer_types_valid_all_users, List<CMsgGCHAppCheersGetAllowedTypesResponse.CheerRemaps> cheer_remaps, uint cache_duration) : DotaPacket
{
    public record CheerRemaps(uint original_cheer_type, uint remapped_cheer_type, List<uint> account_ids);
}
public record CWorkshop_AddSpecialPayment_Request(uint appid, uint gameitemid, string date, ulong payment_us_usd, ulong payment_row_usd) : DotaPacket;
public record CWorkshop_AddSpecialPayment_Response : DotaPacket;
public record CWorkshop_GetSpecialPayments_Request(uint appid, uint gameitemid, string date) : DotaPacket;
public record CWorkshop_GetSpecialPayments_Response(List<CWorkshop_GetSpecialPayments_Response.SpecialPayment> special_payments) : DotaPacket
{
    public record SpecialPayment(uint appid, uint gameitemid, string date, ulong net_payment_us_usd, ulong net_payment_row_usd);
}
