using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EGCBaseMsg
{
    k_EMsgGCInviteToParty = 4501,
    k_EMsgGCInvitationCreated = 4502,
    k_EMsgGCPartyInviteResponse = 4503,
    k_EMsgGCKickFromParty = 4504,
    k_EMsgGCLeaveParty = 4505,
    k_EMsgGCServerAvailable = 4506,
    k_EMsgGCClientConnectToServer = 4507,
    k_EMsgGCGameServerInfo = 4508,
    k_EMsgGCLANServerAvailable = 4511,
    k_EMsgGCInviteToLobby = 4512,
    k_EMsgGCLobbyInviteResponse = 4513,
    k_EMsgGCToClientPollFileRequest = 4514,
    k_EMsgGCToClientPollFileResponse = 4515,
    k_EMsgGCToGCPerformManualOp = 4516,
    k_EMsgGCToGCPerformManualOpCompleted = 4517,
    k_EMsgGCToGCReloadServerRegionSettings = 4518,
    k_EMsgGCAdditionalWelcomeMsgList = 4519,
    k_EMsgGCToClientApplyRemoteConVars = 4520,
    k_EMsgGCToServerApplyRemoteConVars = 4521,
    k_EMsgClientToGCIntegrityStatus = 4522,
    k_EMsgClientToGCAggregateMetrics = 4523,
    k_EMsgGCToClientAggregateMetricsBackoff = 4524,
    k_EMsgGCToServerSteamLearnAccessTokensChanged = 4525,
    k_EMsgGCToServerSteamLearnUseHTTP = 4526,
}
public enum ECustomGameInstallStatus
{
    k_ECustomGameInstallStatus_Unknown = 0,
    k_ECustomGameInstallStatus_Ready = 1,
    k_ECustomGameInstallStatus_Busy = 2,
    k_ECustomGameInstallStatus_FailedGeneric = 101,
    k_ECustomGameInstallStatus_FailedInternalError = 102,
    k_ECustomGameInstallStatus_RequestedTimestampTooOld = 103,
    k_ECustomGameInstallStatus_RequestedTimestampTooNew = 104,
    k_ECustomGameInstallStatus_CRCMismatch = 105,
    k_ECustomGameInstallStatus_FailedSteam = 106,
    k_ECustomGameInstallStatus_FailedCanceled = 107,
}
public record CGCStorePurchaseInit_LineItem(uint item_def_id, uint quantity, uint cost_in_local_currency, uint purchase_type, ulong source_reference_id, int price_index) : DotaPacket;
public record CMsgGCStorePurchaseInit(string country, int language, int currency, List<CGCStorePurchaseInit_LineItem> line_items) : DotaPacket;
public record CMsgGCStorePurchaseInitResponse(int result, ulong txn_id) : DotaPacket;
public record CMsgClientPingData(bool unused1, bool unused2, bool unused3, List<int> SF1relay_codes, List<uint> relay_pings, bool unused6, bool unused7, List<uint> region_codes, List<uint> region_pings, uint region_ping_failed_bitmask) : DotaPacket;
public record CMsgInviteToParty(long SF2steam_id, uint client_version, uint team_id, bool as_coach, CMsgClientPingData ping_data) : DotaPacket;
public record CMsgInviteToLobby(long SF2steam_id, uint client_version) : DotaPacket;
public record CMsgInvitationCreated(ulong group_id, long SF2steam_id, bool user_offline) : DotaPacket;
public record CMsgPartyInviteResponse(ulong party_id, bool accept, uint client_version, bool unused4, bool unused5, bool unused6, bool unused7, CMsgClientPingData ping_data) : DotaPacket;
public record CMsgLobbyInviteResponse(long SF2lobby_id, bool accept, uint client_version, bool unused4, bool unused5, long SF2custom_game_crc, int SF1custom_game_timestamp) : DotaPacket;
public record CMsgKickFromParty(long SF2steam_id) : DotaPacket;
public record CMsgLeaveParty : DotaPacket;
public record CMsgCustomGameInstallStatus(ECustomGameInstallStatus status, string message, int SF1latest_timestamp_from_steam) : DotaPacket;
public record CMsgServerAvailable(CMsgCustomGameInstallStatus custom_game_install_status) : DotaPacket;
public record CMsgLANServerAvailable(long SF2lobby_id) : DotaPacket;
public record CSOEconGameAccountClient(uint additional_backpack_slots, bool trial_account, bool eligible_for_online_play, bool need_to_choose_most_helpful_friend, bool in_coaches_list, int SF1trade_ban_expiration, int SF1duel_ban_expiration, bool unused8, bool made_first_purchase) : DotaPacket;
public record CMsgApplyStrangePart(ulong strange_part_item_id, ulong item_item_id) : DotaPacket;
public record CMsgApplyPennantUpgrade(ulong upgrade_item_id, ulong pennant_item_id) : DotaPacket;
public record CMsgApplyEggEssence(ulong essence_item_id, ulong egg_item_id) : DotaPacket;
public record CSOEconItemAttribute(uint def_index, uint value, byte[] value_bytes) : DotaPacket;
public record CSOEconItemEquipped(uint new_class, uint new_slot) : DotaPacket;
public record CSOEconItem(ulong id, uint account_id, uint inventory, uint def_index, uint quantity, uint level, uint quality, uint flags, uint origin, bool unused10, bool unused11, List<CSOEconItemAttribute> attribute, CSOEconItem interior_item, bool unused14, uint style, ulong original_id, bool unused17, List<CSOEconItemEquipped> equipped_state) : DotaPacket;
public record CMsgSortItems(uint sort_type) : DotaPacket;
public record CMsgItemAcknowledged(uint account_id, uint inventory, uint def_index, uint quality, uint rarity, uint origin) : DotaPacket;
public record CMsgSetItemPositions(List<CMsgSetItemPositions.ItemPosition> item_positions) : DotaPacket
{
    public record ItemPosition(ulong item_id, uint position);
}
public record CMsgGCStorePurchaseCancel(ulong txn_id) : DotaPacket;
public record CMsgGCStorePurchaseCancelResponse(uint result) : DotaPacket;
public record CMsgGCStorePurchaseFinalize(ulong txn_id) : DotaPacket;
public record CMsgGCStorePurchaseFinalizeResponse(uint result, List<ulong> item_ids) : DotaPacket;
public record CMsgGCToGCBannedWordListUpdated(uint group_id) : DotaPacket;
public record CMsgGCToGCDirtySDOCache(uint sdo_type, ulong key_uint64) : DotaPacket;
public record CMsgSDONoMemcached : DotaPacket;
public record CMsgGCToGCUpdateSQLKeyValue(string key_name) : DotaPacket;
public record CMsgGCServerVersionUpdated(uint server_version) : DotaPacket;
public record CMsgGCClientVersionUpdated(uint client_version) : DotaPacket;
public record CMsgGCToGCWebAPIAccountChanged : DotaPacket;
public record CMsgExtractGems(ulong tool_item_id, ulong item_item_id, uint item_socket_id) : DotaPacket;
public record CMsgExtractGemsResponse(ulong item_id, CMsgExtractGemsResponse.EExtractGems response) : DotaPacket
{
    public enum EExtractGems
    {
        k_ExtractGems_Succeeded = 0,
        k_ExtractGems_Failed_ToolIsInvalid = 1,
        k_ExtractGems_Failed_ItemIsInvalid = 2,
        k_ExtractGems_Failed_ToolCannotRemoveGem = 3,
        k_ExtractGems_Failed_FailedToRemoveGem = 4,
    }
}
public record CMsgAddSocket(ulong tool_item_id, ulong item_item_id, bool unusual) : DotaPacket;
public record CMsgAddSocketResponse(ulong item_id, List<uint> updated_socket_index, CMsgAddSocketResponse.EAddSocket response) : DotaPacket
{
    public enum EAddSocket
    {
        k_AddSocket_Succeeded = 0,
        k_AddSocket_Failed_ToolIsInvalid = 1,
        k_AddSocket_Failed_ItemCannotBeSocketed = 2,
        k_AddSocket_Failed_FailedToAddSocket = 3,
    }
}
public record CMsgAddItemToSocketData(ulong gem_item_id, uint socket_index) : DotaPacket;
public record CMsgAddItemToSocket(ulong item_item_id, List<CMsgAddItemToSocketData> gems_to_socket) : DotaPacket;
public record CMsgAddItemToSocketResponse(ulong item_item_id, List<uint> updated_socket_index, CMsgAddItemToSocketResponse.EAddGem response) : DotaPacket
{
    public enum EAddGem
    {
        k_AddGem_Succeeded = 0,
        k_AddGem_Failed_GemIsInvalid = 1,
        k_AddGem_Failed_ItemIsInvalid = 2,
        k_AddGem_Failed_FailedToAddGem = 3,
        k_AddGem_Failed_InvalidGemTypeForSocket = 4,
        k_AddGem_Failed_InvalidGemTypeForHero = 5,
        k_AddGem_Failed_InvalidGemTypeForSlot = 6,
        k_AddGem_Failed_SocketContainsUnremovableGem = 7,
    }
}
public record CMsgResetStrangeGemCount(ulong item_item_id, uint socket_index) : DotaPacket;
public record CMsgResetStrangeGemCountResponse(CMsgResetStrangeGemCountResponse.EResetGem response) : DotaPacket
{
    public enum EResetGem
    {
        k_ResetGem_Succeeded = 0,
        k_ResetGem_Failed_FailedToResetGem = 1,
        k_ResetGem_Failed_ItemIsInvalid = 2,
        k_ResetGem_Failed_InvalidSocketId = 3,
        k_ResetGem_Failed_SocketCannotBeReset = 4,
    }
}
public record CMsgGCToClientPollFileRequest(string file_name, uint client_version, uint poll_id) : DotaPacket;
public record CMsgGCToClientPollFileResponse(uint poll_id, uint file_size, uint file_crc) : DotaPacket;
public record CMsgGCToGCPerformManualOp(ulong op_id, uint group_code) : DotaPacket;
public record CMsgGCToGCPerformManualOpCompleted(bool success, int source_gc) : DotaPacket;
public record CMsgGCToGCReloadServerRegionSettings : DotaPacket;
public record CMsgGCAdditionalWelcomeMsgList(List<CExtraMsgBlock> welcome_messages) : DotaPacket;
public record CMsgApplyRemoteConVars(List<CMsgApplyRemoteConVars.ConVar> con_vars) : DotaPacket
{
    public record ConVar(string name, string value, uint version_min, uint version_max, EGCPlatform platform);
}
public record CMsgGCToClientApplyRemoteConVars(CMsgApplyRemoteConVars msg) : DotaPacket;
public record CMsgGCToServerApplyRemoteConVars(CMsgApplyRemoteConVars msg) : DotaPacket;
public record CMsgClientToGCIntegrityStatus(string report, bool secure_allowed, List<CMsgClientToGCIntegrityStatus.keyvalue> diagnostics) : DotaPacket
{
    public record keyvalue(uint id, uint extended, ulong value, string string_value);
}
public record CMsgClientToGCAggregateMetrics(List<CMsgClientToGCAggregateMetrics.SingleMetric> metrics) : DotaPacket
{
    public record SingleMetric(string metric_name, uint metric_count);
}
public record CMsgGCToClientAggregateMetricsBackoff(float upload_rate_modifier) : DotaPacket;
public record CMsgGCToServerSteamLearnAccessTokensChanged(CMsgSteamLearnAccessTokens access_tokens) : DotaPacket;
public record CMsgGCToServerSteamLearnUseHTTP(bool use_http) : DotaPacket;
