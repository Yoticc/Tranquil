using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EShowcaseHeroPlusFlag
{
    k_eShowcaseHeroPlusFlag_None = 0,
    k_eShowcaseHeroPlusFlag_BadgePosTop = 1,
    k_eShowcaseHeroPlusFlag_BadgePosBottom = 2,
    k_eShowcaseHeroPlusFlag_BadgePosLeft = 4,
    k_eShowcaseHeroPlusFlag_BadgePosRight = 8,
    k_eShowcaseHeroPlusFlag_ShowRelics = 16,
}
public enum EShowcaseType
{
    k_eShowcaseType_Invalid = 0,
    k_eShowcaseType_Profile = 1,
    k_eShowcaseType_MiniProfile = 2,
    k_eShowcaseType_DefaultProfile = 3,
    k_eShowcaseType_DefaultMiniProfile = 4,
}
public enum EShowcaseItemState
{
    k_eShowcaseItemState_Ok = 0,
    k_eShowcaseItemState_MinorModifications = 1,
    k_eShowcaseItemState_ValidityUnknown = 2,
    k_eShowcaseItemState_PartiallyInvalid = 3,
    k_eShowcaseItemState_Invalid = 4,
    k_eShowcaseItemState_Failure = 5,
}
public enum EShowcaseAuditAction
{
    k_eShowcaseAuditAction_Invalid = 0,
    k_eShowcaseAuditAction_ShowcaseChanged = 1,
    k_eShowcaseAuditAction_AdminShowcaseReset = 2,
    k_eShowcaseAuditAction_AdminShowcaseAccountLocked = 3,
    k_eShowcaseAuditAction_AdminShowcaseExonerated = 4,
    k_eShowcaseAuditAction_AdminShowcaseConvicted = 5,
    k_eShowcaseAuditAction_AdminModerationApproved = 6,
    k_eShowcaseAuditAction_AdminModerationRejected = 7,
}
public enum EShowcaseItemFlag
{
    k_eShowcaseItemFlag_None = 0,
    k_eShowcaseItemFlag_FlipHorizontally = 1,
}
public enum EShowcaseItemFlag_Hero
{
    k_eShowcaseItemFlag_Hero_None = 0,
    k_eShowcaseItemFlag_Hero_ShowPedestal = 1,
    k_eShowcaseItemFlag_Hero_UseCurrentLoadout = 2,
    k_eShowcaseItemFlag_Hero_ShowHeroCard = 4,
    k_eShowcaseItemFlag_Hero_HeroCardHideName = 8,
    k_eShowcaseItemFlag_Hero_HeroCardUseMovie = 16,
}
public record CMsgShowcaseEconItemReference(ulong id, ulong original_id, uint definition_index, int equipment_slot_index) : DotaPacket;
public record CMsgHeroPlusInfo(uint flags) : DotaPacket;
public record CMsgShowcaseItem_Trophy(CMsgShowcaseItem_Trophy.Data data, uint trophy_id) : DotaPacket
{
    public record Data(uint trophy_score);
}
public record CMsgShowcaseItem_EconItem(CMsgShowcaseItem_EconItem.Data data, CMsgShowcaseEconItemReference _ref) : DotaPacket
{
    public record Data(CSOEconItem econ_item);
}
public record CMsgShowcaseItem_Hero(CMsgShowcaseItem_Hero.Data data, int hero_id, List<CMsgShowcaseEconItemReference> econ_item_refs, uint rotation, uint flags, CMsgHeroPlusInfo plus_info, string animation_name, uint animation_playback_speed, uint animation_offset, uint zoom, uint slot_index, uint model_index) : DotaPacket
{
    public record Data(List<CSOEconItem> econ_items, int actual_hero_id, uint plus_hero_xp);
}
public record CMsgShowcaseItem_HeroIcon(CMsgShowcaseItem_HeroIcon.Data data, int hero_id, CMsgShowcaseEconItemReference econ_item_ref) : DotaPacket
{
    public record Data(CSOEconItem econ_item);
}
public record CMsgShowcaseItem_PlayerMatch(CMsgShowcaseItem_PlayerMatch.Data data, ulong match_id, uint player_slot) : DotaPacket
{
    public enum EPlayerOutcome
    {
        k_eInvalid = 0,
        k_eWin = 1,
        k_eLoss = 2,
        k_eNotScored = 3,
    }
    public record Data(int hero_id, uint timestamp, uint duration, DOTA_GameMode game_mode, CMsgShowcaseItem_PlayerMatch.EPlayerOutcome outcome, uint kills, uint deaths, uint assists);
}
public record CMsgShowcaseItem_ChatWheel(CMsgShowcaseItem_ChatWheel.Data data, uint chat_wheel_message_id) : DotaPacket
{
    public record Data;
}
public record CMsgShowcaseItem_Emoticon(CMsgShowcaseItem_Emoticon.Data data, uint emoticon_id) : DotaPacket
{
    public record Data;
}
public record CMsgShowcaseItem_SpiderGraph(CMsgShowcaseItem_SpiderGraph.Data data) : DotaPacket
{
    public record Data;
}
public record CMsgShowcaseItem_UserFeed(CMsgShowcaseItem_UserFeed.Data data) : DotaPacket
{
    public record Data;
}
public record CMsgShowcaseItem_Stat(CMsgShowcaseItem_Stat.Data data, CMsgDOTAProfileCard.EStatID stat_id) : DotaPacket
{
    public record Data(uint stat_score);
}
public record CMsgShowcaseBackground(CMsgShowcaseBackground.Data data, CMsgShowcaseEconItemReference loading_screen_ref, uint dim, uint blur, uint background_id) : DotaPacket
{
    public record Data(CSOEconItem loading_screen);
}
public record CMsgShowcaseItemData(CMsgShowcaseItem_Trophy trophy, CMsgShowcaseItem_EconItem econ_item_icon, CMsgShowcaseItem_EconItem sticker, CMsgShowcaseItem_Hero hero_model, CMsgShowcaseItem_PlayerMatch player_match, CMsgShowcaseItem_ChatWheel chat_wheel, CMsgShowcaseItem_ChatWheel spray, CMsgShowcaseItem_Emoticon emoticon, bool unused9, CMsgShowcaseItem_EconItem courier, CMsgShowcaseItem_EconItem ward, CMsgShowcaseItem_HeroIcon hero_icon, CMsgShowcaseItem_SpiderGraph spider_graph, CMsgShowcaseItem_UserFeed user_feed, CMsgShowcaseItem_Stat stat, CMsgShowcaseItem_EconItem roshan, CMsgShowcaseItem_EconItem creep, CMsgShowcaseItem_EconItem tower, CMsgShowcaseItem_EconItem effigy, CMsgShowcaseItem_EconItem decoration, bool unused21, bool unused22, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, bool unused41, bool unused42, bool unused43, bool unused44, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, bool unused50, bool unused51, bool unused52, bool unused53, bool unused54, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, bool unused60, bool unused61, bool unused62, bool unused63, bool unused64, bool unused65, bool unused66, bool unused67, bool unused68, bool unused69, bool unused70, bool unused71, bool unused72, bool unused73, bool unused74, bool unused75, bool unused76, bool unused77, bool unused78, bool unused79, bool unused80, bool unused81, bool unused82, bool unused83, bool unused84, bool unused85, bool unused86, bool unused87, bool unused88, bool unused89, bool unused90, bool unused91, bool unused92, bool unused93, bool unused94, bool unused95, bool unused96, bool unused97, bool unused98, bool unused99, CMsgShowcaseBackground background) : DotaPacket;
public record CMsgShowcaseItemPosition(int position_x, int position_y, uint scale, uint width, uint height, uint rotation, uint parent_id, uint parent_attachment_point_id, uint attachment_anchor_x, uint attachment_anchor_y) : DotaPacket;
public record CMsgShowcaseItem(uint showcase_item_id, CMsgShowcaseItemPosition item_position, CMsgShowcaseItemData item_data, EShowcaseItemState state, uint flags) : DotaPacket;
public record CMsgShowcase(List<CMsgShowcaseItem> showcase_items, bool unused2, CMsgShowcaseItem background, CMsgShowcase.EModerationState moderation_state) : DotaPacket
{
    public enum EModerationState
    {
        k_eModerationState_Ok = 0,
        k_eModerationState_PendingApproval = 1,
    }
}
public record CMsgClientToGCShowcaseGetUserData(uint account_id, EShowcaseType showcase_type) : DotaPacket;
public record CMsgClientToGCShowcaseGetUserDataResponse(CMsgClientToGCShowcaseGetUserDataResponse.EResponse response, CMsgShowcase showcase) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eUnknownShowcase = 5,
    }
}
public record CMsgClientToGCShowcaseSetUserData(EShowcaseType showcase_type, CMsgShowcase showcase, uint format_version) : DotaPacket;
public record CMsgClientToGCShowcaseSetUserDataResponse(CMsgClientToGCShowcaseSetUserDataResponse.EResponse response, CMsgShowcase validated_showcase, uint locked_until_timestamp) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalid = 5,
        k_eLockedFromEditing = 6,
        k_eBudgetExceeded = 7,
        k_eCommunicationScoreTooLow = 8,
    }
}
public record CMsgClientToGCShowcaseSubmitReport(uint target_account_id, EShowcaseType showcase_type, string report_comment) : DotaPacket;
public record CMsgClientToGCShowcaseSubmitReportResponse(CMsgClientToGCShowcaseSubmitReportResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eAlreadyReported = 5,
    }
}
public record CMsgShowcaseReportsRollupInfo(uint rollup_id, uint start_timestamp, uint end_timestamp) : DotaPacket;
public record CMsgShowcaseReportsRollupList(List<CMsgShowcaseReportsRollupInfo> rollups) : DotaPacket;
public record CMsgShowcaseReportsRollupEntry(uint account_id, EShowcaseType showcase_type, uint report_count) : DotaPacket;
public record CMsgShowcaseReportsRollup(CMsgShowcaseReportsRollupInfo rollup_info, List<CMsgShowcaseReportsRollupEntry> rollup_entries) : DotaPacket;
public record CMsgClientToGCShowcaseAdminGetReportsRollupList : DotaPacket;
public record CMsgClientToGCShowcaseAdminGetReportsRollupListResponse(CMsgClientToGCShowcaseAdminGetReportsRollupListResponse.EResponse response, CMsgShowcaseReportsRollupList rollup_list) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
    }
}
public record CMsgClientToGCShowcaseAdminGetReportsRollup(uint rollup_id) : DotaPacket;
public record CMsgClientToGCShowcaseAdminGetReportsRollupResponse(CMsgClientToGCShowcaseAdminGetReportsRollupResponse.EResponse response, CMsgShowcaseReportsRollup rollup) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
        k_eNotFound = 6,
    }
}
public record CMsgShowcaseAuditEntry(EShowcaseType showcase_type, EShowcaseAuditAction audit_action, ulong audit_data, uint timestamp) : DotaPacket;
public record CMsgShowcaseReport(uint reporter_account_id, EShowcaseType showcase_type, uint report_timestamp, string report_comment) : DotaPacket;
public record CMsgShowcaseAdminUserDetails(uint locked_until_timestamp, List<CMsgShowcaseAuditEntry> audit_entries, List<CMsgShowcaseReport> reports) : DotaPacket;
public record CMsgClientToGCShowcaseAdminGetUserDetails(uint account_id) : DotaPacket;
public record CMsgClientToGCShowcaseAdminGetUserDetailsResponse(CMsgClientToGCShowcaseAdminGetUserDetailsResponse.EResponse response, CMsgShowcaseAdminUserDetails user_details) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
    }
}
public record CMsgClientToGCShowcaseAdminReset(uint target_account_id, EShowcaseType showcase_type) : DotaPacket;
public record CMsgClientToGCShowcaseAdminResetResponse(CMsgClientToGCShowcaseAdminResetResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
    }
}
public record CMsgClientToGCShowcaseAdminLockAccount(uint target_account_id, uint locked_until_timestamp) : DotaPacket;
public record CMsgClientToGCShowcaseAdminLockAccountResponse(CMsgClientToGCShowcaseAdminLockAccountResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
    }
}
public record CMsgClientToGCShowcaseAdminConvict(uint target_account_id, EShowcaseType showcase_type) : DotaPacket;
public record CMsgClientToGCShowcaseAdminConvictResponse(CMsgClientToGCShowcaseAdminConvictResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
        k_eAlreadyConvicted = 6,
    }
}
public record CMsgClientToGCShowcaseAdminExonerate(uint target_account_id, EShowcaseType showcase_type) : DotaPacket;
public record CMsgClientToGCShowcaseAdminExonerateResponse(CMsgClientToGCShowcaseAdminExonerateResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
        k_eAlreadyExonerated = 6,
    }
}
public record CMsgShowcaseModerationInfo(uint account_id, EShowcaseType showcase_type, uint showcase_timestamp) : DotaPacket;
public record CMsgClientToGCShowcaseModerationGetQueue(uint start_timestamp, uint result_count) : DotaPacket;
public record CMsgClientToGCShowcaseModerationGetQueueResponse(CMsgClientToGCShowcaseModerationGetQueueResponse.EResponse response, List<CMsgShowcaseModerationInfo> showcases) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
    }
}
public record CMsgClientToGCShowcaseModerationApplyModeration(uint account_id, EShowcaseType showcase_type, uint showcase_timestamp, bool approve) : DotaPacket;
public record CMsgClientToGCShowcaseModerationApplyModerationResponse(CMsgClientToGCShowcaseModerationApplyModerationResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoPermission = 5,
        k_eGone = 6,
    }
}
