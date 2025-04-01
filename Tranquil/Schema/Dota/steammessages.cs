using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EGCPlatform
{
    k_eGCPlatform_None = 0,
    k_eGCPlatform_PC = 1,
    k_eGCPlatform_Mac = 2,
    k_eGCPlatform_Linux = 3,
    k_eGCPlatform_Android = 4,
    k_eGCPlatform_iOS = 5,
}
public enum GCProtoBufMsgSrc
{
    GCProtoBufMsgSrc_Unspecified = 0,
    GCProtoBufMsgSrc_FromSystem = 1,
    GCProtoBufMsgSrc_FromSteamID = 2,
    GCProtoBufMsgSrc_FromGC = 3,
    GCProtoBufMsgSrc_ReplySystem = 4,
    GCProtoBufMsgSrc_SpoofedSteamID = 5,
}
public record CGCSystemMsg_GetAccountDetails(long SF2steamid, uint appid) : DotaPacket;
public record CGCSystemMsg_GetAccountDetails_Response(uint eresult_deprecated, string account_name, string persona_name, bool is_profile_public, bool is_inventory_public, bool unused6, bool is_vac_banned, bool is_cyber_cafe, bool is_school_account, bool is_limited, bool is_subscribed, uint package, bool is_free_trial_account, uint free_trial_expiration, bool is_low_violence, bool is_account_locked_down, bool is_community_banned, bool is_trade_banned, uint trade_ban_expiration, uint accountid, uint suspension_end_time, string currency, uint steam_level, uint friend_count, uint account_creation_time, bool is_profile_created, bool is_steamguard_enabled, bool is_phone_verified, bool is_two_factor_auth_enabled, uint two_factor_enabled_time, uint phone_verification_time, bool unused32, ulong phone_id, bool is_phone_identifying, uint rt_identity_linked, uint rt_birth_date, string txn_country_code, bool has_accepted_china_ssa, bool is_banned_steam_china) : DotaPacket;
public record CIPLocationInfo(uint ip, float latitude, float longitude, string country, string state, string city) : DotaPacket;
public record CGCMsgGetIPLocationResponse(List<CIPLocationInfo> infos) : DotaPacket;
