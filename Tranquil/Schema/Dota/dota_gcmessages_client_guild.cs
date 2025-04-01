namespace Tranquil.Schema;

public enum EGuildAuditAction
{
    k_EGuildAuditAction_Invalid = 0,
    k_EGuildAuditAction_GuildCreated = 1,
    k_EGuildAuditAction_GuildLanguageChanged = 2,
    k_EGuildAuditAction_GuildFlagsChanged = 3,
    k_EGuildAuditAction_GuildMemberJoined = 5,
    k_EGuildAuditAction_GuildMemberLeft = 6,
    k_EGuildAuditAction_GuildMemberKicked = 7,
    k_EGuildAuditAction_GuildMemberRoleChanged = 8,
    k_EGuildAuditAction_GuildLogoChanged = 9,
    k_EGuildAuditAction_GuildRegionChanged = 10,
    k_EGuildAuditAction_GuildDescriptionChanged = 11,
    k_EGuildAuditAction_GuildPrimaryColorChanged = 12,
    k_EGuildAuditAction_GuildSecondaryColorChanged = 13,
    k_EGuildAuditAction_GuildPatternChanged = 14,
    k_EGuildAuditAction_AdminClearedLogo = 15,
    k_EGuildAuditAction_GuildRequiredRankChanged = 16,
    k_EGuildAuditAction_GuildMotDChanged = 18,
    k_EGuildAuditAction_AdminResetName = 19,
    k_EGuildAuditAction_AdminResetTag = 20,
    k_EGuildAuditAction_AdminLock = 21,
    k_EGuildAuditAction_GuildNameChanged = 22,
    k_EGuildAuditAction_GuildTagChanged = 23,
    k_EGuildAuditAction_AdminPermitted = 24,
    k_EGuildAuditAction_AdminBlocked = 25,
    k_EGuildAuditAction_AdminBannedUser = 26,
    k_EGuildAuditAction_AdminExonerated = 27,
}
public enum EGuildChatType
{
    k_EGuildChatType_Unspecified = 0,
    k_EGuildChatType_SteamChatGroup = 1,
    k_EGuildChatType_GC = 2,
}
public record CMsgGuildInfo(string guild_name, string guild_tag, uint created_timestamp, uint guild_language, uint guild_flags, bool unused6, ulong guild_logo, uint guild_region, ulong guild_chat_group_id, string guild_description, ulong default_chat_channel_id, uint guild_primary_color, uint guild_secondary_color, uint guild_pattern, uint guild_refresh_time_offset, uint guild_required_rank_tier, uint guild_motd_timestamp, string guild_motd) : DotaPacket;
public record CMsgGuildSummary(CMsgGuildInfo guild_info, uint member_count, List<CMsgGuildSummary.EventPoints> event_points) : DotaPacket
{
    public record EventPoints(uint event_id, uint guild_points, uint guild_rank, uint guild_weekly_rank, uint guild_weekly_percentile, uint guild_current_percentile);
}
public record CMsgGuildRole(uint role_id, string role_name, uint role_flags, uint role_order) : DotaPacket;
public record CMsgGuildMember(uint member_account_id, uint member_role_id, uint member_joined_timestamp, uint member_last_active_timestamp) : DotaPacket;
public record CMsgGuildInvite(uint requester_account_id, uint target_account_id, uint timestamp_sent) : DotaPacket;
public record CMsgGuildData(uint guild_id, CMsgGuildInfo guild_info, List<CMsgGuildRole> guild_roles, List<CMsgGuildMember> guild_members, List<CMsgGuildInvite> guild_invites) : DotaPacket;
public record CMsgAccountGuildInvite(uint guild_id, uint requester_account_id, uint timestamp_sent) : DotaPacket;
public record CMsgAccountGuildMemberships(List<uint> guild_ids, List<CMsgAccountGuildInvite> guild_invites) : DotaPacket;
public record CMsgGuildPersonaInfo(uint guild_id, string guild_tag, uint guild_flags) : DotaPacket;
public record CMsgAccountGuildsPersonaInfo(List<CMsgGuildPersonaInfo> guild_persona_infos) : DotaPacket;
public record CMsgGuildFeedEvent(ulong feed_event_id, uint timestamp, uint event_type, uint param_uint_1, uint param_uint_2, uint param_uint_3) : DotaPacket;
public record CMsgClientToGCCreateGuild(CMsgGuildInfo guild_info, EGuildChatType guild_chat_type) : DotaPacket;
public record CMsgClientToGCCreateGuildResponse(CMsgClientToGCCreateGuildResponse.EResponse result, uint guild_id) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidName = 5,
        k_eNameAlreadyUsed = 6,
        k_eInvalidTag = 7,
        k_eTagAlreadyUsed = 8,
        k_eInvalidDescription = 9,
        k_eInvalidRegion = 10,
        k_eInvalidLogo = 11,
        k_eDoesNotOwnEvent = 12,
        k_eGuildLimit = 13,
        k_eInvalidMotD = 14,
        k_eBlocked = 15,
        k_eFreeTrialNotAllowed = 16,
    }
}
public record CMsgClientToGCSetGuildInfo(uint guild_id, CMsgGuildInfo guild_info, EGuildChatType guild_chat_type) : DotaPacket;
public record CMsgClientToGCSetGuildInfoResponse(CMsgClientToGCSetGuildInfoResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNotMember = 6,
        k_eNoPermission = 7,
        k_eMotDTooLong = 8,
        k_eNameChangeNoPermissions = 9,
        k_eTagChangeNoPermissions = 10,
        k_eNameInvalid = 11,
        k_eTagInvalid = 12,
        k_eDescriptionInvalid = 13,
        k_eBlocked = 14,
    }
}
public record CMsgClientToGCRequestGuildData(uint guild_id) : DotaPacket;
public record CMsgClientToGCRequestGuildDataResponse(CMsgClientToGCRequestGuildDataResponse.EResponse result, CMsgGuildData guild_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNotMember = 6,
    }
}
public record CMsgGCToClientGuildDataUpdated(CMsgGuildData guild_data, uint update_flags) : DotaPacket;
public record CMsgGCToClientGuildMembersDataUpdated(uint guild_id, List<CMsgGuildMember> members_data) : DotaPacket;
public record CMsgClientToGCRequestGuildMembership : DotaPacket;
public record CMsgClientToGCRequestGuildMembershipResponse(CMsgClientToGCRequestGuildMembershipResponse.EResponse result, CMsgAccountGuildMemberships guild_memberships) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
    }
}
public record CMsgGCToClientGuildMembershipUpdated(CMsgAccountGuildMemberships guild_memberships) : DotaPacket;
public record CMsgClientToGCJoinGuild(uint guild_id) : DotaPacket;
public record CMsgClientToGCJoinGuildResponse(CMsgClientToGCJoinGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eGuildFull = 6,
        k_eAlreadyMember = 7,
        k_eGuildLimit = 8,
        k_eGuildRequiresInvite = 9,
        k_eGuildRankTooLow = 10,
    }
}
public record CMsgClientToGCLeaveGuild(uint guild_id) : DotaPacket;
public record CMsgClientToGCLeaveGuildResponse(CMsgClientToGCLeaveGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNotMember = 6,
        k_eLastAdmin = 7,
    }
}
public record CMsgClientToGCKickGuildMember(uint guild_id, uint target_account_id) : DotaPacket;
public record CMsgClientToGCKickGuildMemberResponse(CMsgClientToGCKickGuildMemberResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eRequesterNotMember = 6,
        k_eTargetNotMember = 7,
        k_eNoPermission = 8,
        k_eCantKickSelf = 9,
    }
}
public record CMsgClientToGCSetGuildMemberRole(uint guild_id, uint target_account_id, uint target_role_id) : DotaPacket;
public record CMsgClientToGCSetGuildMemberRoleResponse(CMsgClientToGCSetGuildMemberRoleResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eRequesterNotMember = 6,
        k_eTargetNotMember = 7,
        k_eNoPermission = 8,
        k_eInvalidRole = 9,
        k_eAdminViolation = 10,
    }
}
public record CMsgClientToGCInviteToGuild(uint guild_id, uint target_account_id) : DotaPacket;
public record CMsgClientToGCInviteToGuildResponse(CMsgClientToGCInviteToGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eGuildFull = 6,
        k_eRequesterNotMember = 7,
        k_eAlreadyAMember = 8,
        k_eAlreadyInvited = 9,
        k_eNoInvitePermissions = 10,
        k_eTooManyInvites = 11,
        k_eInvalidUser = 12,
    }
}
public record CMsgClientToGCDeclineInviteToGuild(uint guild_id) : DotaPacket;
public record CMsgClientToGCDeclineInviteToGuildResponse(CMsgClientToGCDeclineInviteToGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNoInviteFound = 6,
    }
}
public record CMsgClientToGCAcceptInviteToGuild(uint guild_id) : DotaPacket;
public record CMsgClientToGCAcceptInviteToGuildResponse(CMsgClientToGCAcceptInviteToGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNoInviteFound = 6,
        k_eGuildFull = 7,
        k_eGuildLimit = 8,
        k_eInvalidInviter = 9,
        k_eAlreadyInGuild = 10,
    }
}
public record CMsgClientToGCCancelInviteToGuild(uint guild_id, uint target_account_id) : DotaPacket;
public record CMsgClientToGCCancelInviteToGuildResponse(CMsgClientToGCCancelInviteToGuildResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNoInviteFound = 6,
        k_eNoPermissions = 7,
    }
}
public record CMsgClientToGCAddGuildRole(uint guild_id, string role_name, uint role_flags) : DotaPacket;
public record CMsgClientToGCAddGuildRoleResponse(CMsgClientToGCAddGuildRoleResponse.EResponse result, uint role_id) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNameAlreadyUsed = 6,
        k_eNoPermissions = 7,
        k_eInvalidFlags = 8,
        k_eInvalidName = 9,
        k_eAdminViolation = 10,
        k_eTooManyRoles = 11,
        k_eBlocked = 12,
    }
}
public record CMsgClientToGCModifyGuildRole(uint guild_id, uint role_id, string role_name, uint role_flags) : DotaPacket;
public record CMsgClientToGCModifyGuildRoleResponse(CMsgClientToGCModifyGuildRoleResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eInvalidRole = 6,
        k_eNameAlreadyUsed = 7,
        k_eInvalidFlags = 8,
        k_eInvalidName = 9,
        k_eNoPermissions = 10,
        k_eAdminViolation = 11,
        k_eBlocked = 12,
    }
}
public record CMsgClientToGCRemoveGuildRole(uint guild_id, uint role_id) : DotaPacket;
public record CMsgClientToGCRemoveGuildRoleResponse(CMsgClientToGCRemoveGuildRoleResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eInvalidRole = 6,
        k_eRoleNotEmpty = 7,
        k_eNoPermissions = 8,
        k_eAdminViolation = 9,
        k_eCantRemoveDefaultRole = 10,
    }
}
public record CMsgClientToGCSetGuildRoleOrder(uint guild_id, List<uint> requested_role_ids, List<uint> previous_role_ids) : DotaPacket;
public record CMsgClientToGCSetGuildRoleOrderResponse(CMsgClientToGCSetGuildRoleOrderResponse.EResponse result, List<uint> confirmed_role_ids) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eInvalidRole = 6,
        k_eInvalidOrder = 7,
        k_eNoPermissions = 8,
        k_eAdminViolation = 9,
    }
}
public record CMsgClientToGCGuildFeedRequest(uint guild_id, ulong last_seen_id) : DotaPacket;
public record CMsgClientToGCRequestGuildFeedResponse(CMsgClientToGCRequestGuildFeedResponse.EResponse result, uint guild_id, List<CMsgGuildFeedEvent> feed_events) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNoPermissions = 6,
    }
}
public record CMsgGCToClientGuildFeedUpdated(uint guild_id) : DotaPacket;
public record CMsgClientToGCAddPlayerToGuildChat(uint guild_id) : DotaPacket;
public record CMsgClientToGCAddPlayerToGuildChatResponse(CMsgClientToGCAddPlayerToGuildChatResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidGuild = 5,
        k_eNotMember = 6,
        k_eSteamChatNotEnabled = 7,
    }
}
public record CMsgFindGuildByTagResponse(CMsgFindGuildByTagResponse.EResponse result, uint guild_id, CMsgGuildSummary guild_summary) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidTag = 5,
        k_eGuildNotFound = 6,
    }
}
public record CMsgSearchForOpenGuildsResponse(CMsgSearchForOpenGuildsResponse.EResponse result, List<CMsgSearchForOpenGuildsResponse.SearchResult> search_results, bool use_whitelist) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
    }
    public record SearchResult(uint guild_id, CMsgGuildSummary guild_summary);
}
public record CMsgClientToGCReportGuildContent(uint guild_id, uint guild_content_flags) : DotaPacket
{
    public enum EContentFlags
    {
        k_eNone = 0,
        k_eInappropriateName = 1,
        k_eInappropriateTag = 2,
        k_eInappropriateLogo = 4,
        k_eValidFlags = 7,
    }
}
public record CMsgClientToGCReportGuildContentResponse(CMsgClientToGCReportGuildContentResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eGuildNotFound = 5,
        k_eFlagsInvalid = 6,
    }
}
public record CMsgClientToGCRequestAccountGuildPersonaInfo(uint account_id) : DotaPacket;
public record CMsgClientToGCRequestAccountGuildPersonaInfoResponse(CMsgClientToGCRequestAccountGuildPersonaInfoResponse.EResponse result, CMsgAccountGuildsPersonaInfo persona_info) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidAccount = 5,
    }
}
public record CMsgClientToGCRequestAccountGuildPersonaInfoBatch(List<uint> account_ids) : DotaPacket;
public record CMsgClientToGCRequestAccountGuildPersonaInfoBatchResponse(CMsgClientToGCRequestAccountGuildPersonaInfoBatchResponse.EResponse result, List<CMsgAccountGuildsPersonaInfo> persona_infos) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidRequest = 5,
    }
}
