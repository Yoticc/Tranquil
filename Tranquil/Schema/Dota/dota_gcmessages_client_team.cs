using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum ETeamInviteResult
{
    TEAM_INVITE_SUCCESS = 0,
    TEAM_INVITE_FAILURE_INVITE_REJECTED = 1,
    TEAM_INVITE_FAILURE_INVITE_TIMEOUT = 2,
    TEAM_INVITE_ERROR_TEAM_AT_MEMBER_LIMIT = 3,
    TEAM_INVITE_ERROR_TEAM_LOCKED = 4,
    TEAM_INVITE_ERROR_INVITEE_NOT_AVAILABLE = 5,
    TEAM_INVITE_ERROR_INVITEE_BUSY = 6,
    TEAM_INVITE_ERROR_INVITEE_ALREADY_MEMBER = 7,
    TEAM_INVITE_ERROR_INVITEE_AT_TEAM_LIMIT = 8,
    TEAM_INVITE_ERROR_INVITEE_INSUFFICIENT_PLAY_TIME = 9,
    TEAM_INVITE_ERROR_INVITER_INVALID_ACCOUNT_TYPE = 10,
    TEAM_INVITE_ERROR_INVITER_NOT_ADMIN = 11,
    TEAM_INVITE_ERROR_INCORRECT_USER_RESPONDED = 12,
    TEAM_INVITE_ERROR_UNSPECIFIED = 13,
}
public record CMsgDOTATeamInfo(List<CMsgDOTATeamInfo.Member> members, uint team_id, string name, string tag, uint time_created, bool pro, bool unused7, bool pickup_team, ulong ugc_logo, ulong ugc_base_logo, ulong ugc_banner_logo, ulong ugc_sponsor_logo, string country_code, string url, uint wins, uint losses, bool unused17, bool unused18, uint games_played_total, uint games_played_matchmaking, bool unused21, bool unused22, bool unused23, string url_logo, bool unused25, bool unused26, bool unused27, bool unused28, ELeagueRegion region, List<uint> registered_member_account_ids, List<CMsgDOTATeamInfo.AuditEntry> audit_entries, string abbreviation, List<CMsgDOTATeamInfo.MemberStats> member_stats, CMsgDOTATeamInfo.TeamStats team_stats, List<CMsgDOTATeamInfo.DPCResult> dpc_results, uint coach_account_id, string color_primary, string color_secondary, uint team_captain) : DotaPacket
{
    public record HeroStats(int hero_id, uint picks, uint wins, uint bans, float avg_kills, float avg_deaths, float avg_assists, float avg_gpm, float avg_xpm);
    public record MemberStats(uint account_id, uint wins_with_team, uint losses_with_team, List<CMsgDOTATeamInfo.HeroStats> top_heroes, float avg_kills, float avg_deaths, float avg_assists);
    public record TeamStats(List<CMsgDOTATeamInfo.HeroStats> played_heroes, float farming, float fighting, float versatility, float avg_kills, float avg_deaths, float avg_duration);
    public record DPCResult(uint league_id, uint standing, uint points, uint earnings, uint timestamp);
    public record Member(uint account_id, uint time_joined, bool admin, bool unused4, bool unused5, string pro_name, bool unused7, Fantasy_Roles role, string real_name);
    public record AuditEntry(uint audit_action, uint timestamp, uint account_id);
}
public record CMsgDOTATeamsInfo(uint league_id, List<CMsgDOTATeamInfo> teams) : DotaPacket;
public record CMsgDOTATeamInfoList(List<CMsgDOTATeamInfo> teams) : DotaPacket;
public record CMsgDOTATeamInfoCache(uint cache_timestamp, CMsgDOTATeamInfoList team_list) : DotaPacket;
public record CMsgDOTAMyTeamInfoRequest : DotaPacket;
public record CMsgDOTACreateTeam(string name, string tag, ulong logo, ulong base_logo, ulong banner_logo, ulong sponsor_logo, string country_code, string url, bool pickup_team, string abbreviation) : DotaPacket;
public record CMsgDOTACreateTeamResponse(CMsgDOTACreateTeamResponse.Result result, uint team_id) : DotaPacket
{
    public enum Result
    {
        INVALID = -1,
        SUCCESS = 0,
        NAME_EMPTY = 1,
        NAME_BAD_CHARACTERS = 2,
        NAME_TAKEN = 3,
        NAME_TOO_LONG = 4,
        TAG_EMPTY = 5,
        TAG_BAD_CHARACTERS = 6,
        TAG_TAKEN = 7,
        TAG_TOO_LONG = 8,
        CREATOR_BUSY = 9,
        UNSPECIFIED_ERROR = 10,
        CREATOR_TEAM_LIMIT_REACHED = 11,
        NO_LOGO = 12,
        CREATOR_TEAM_CREATION_COOLDOWN = 13,
        LOGO_UPLOAD_FAILED = 14,
        NAME_CHANGED_TOO_RECENTLY = 15,
        CREATOR_INSUFFICIENT_LEVEL = 16,
        INVALID_ACCOUNT_TYPE = 17,
    }
}
public record CMsgDOTAEditTeamDetails(uint team_id, string name, string tag, ulong logo, ulong base_logo, ulong banner_logo, ulong sponsor_logo, string country_code, string url, bool in_use_by_party, string abbreviation) : DotaPacket;
public record CMsgDOTAEditTeamDetailsResponse(CMsgDOTAEditTeamDetailsResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE_INVALID_ACCOUNT_TYPE = 1,
        FAILURE_NOT_MEMBER = 2,
        FAILURE_TEAM_LOCKED = 3,
        FAILURE_UNSPECIFIED_ERROR = 4,
    }
}
public record CMsgDOTATeamInvite_InviterToGC(uint account_id, uint team_id) : DotaPacket;
public record CMsgDOTATeamInvite_GCImmediateResponseToInviter(ETeamInviteResult result, string invitee_name, uint required_play_time) : DotaPacket;
public record CMsgDOTATeamInvite_GCRequestToInvitee(uint inviter_account_id, string team_name, string team_tag, ulong logo) : DotaPacket;
public record CMsgDOTATeamInvite_InviteeResponseToGC(ETeamInviteResult result) : DotaPacket;
public record CMsgDOTATeamInvite_GCResponseToInviter(ETeamInviteResult result, string invitee_name) : DotaPacket;
public record CMsgDOTATeamInvite_GCResponseToInvitee(ETeamInviteResult result, string team_name) : DotaPacket;
public record CMsgDOTAKickTeamMember(uint account_id, uint team_id) : DotaPacket;
public record CMsgDOTAKickTeamMemberResponse(CMsgDOTAKickTeamMemberResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE_INVALID_ACCOUNT_TYPE = 1,
        FAILURE_KICKER_NOT_ADMIN = 2,
        FAILURE_KICKEE_NOT_MEMBER = 3,
        FAILURE_TEAM_LOCKED = 4,
        FAILURE_UNSPECIFIED_ERROR = 5,
    }
}
public record CMsgDOTATransferTeamAdmin(uint new_admin_account_id, uint team_id) : DotaPacket;
public record CMsgDOTATransferTeamAdminResponse(CMsgDOTATransferTeamAdminResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE_INVALID_ACCOUNT_TYPE = 1,
        FAILURE_NOT_ADMIN = 2,
        FAILURE_SAME_ACCOUNT = 3,
        FAILURE_NOT_MEMBER = 4,
        FAILURE_UNSPECIFIED_ERROR = 5,
    }
}
public record CMsgDOTALeaveTeam(uint team_id) : DotaPacket;
public record CMsgDOTALeaveTeamResponse(CMsgDOTALeaveTeamResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE_NOT_MEMBER = 1,
        FAILURE_TEAM_LOCKED = 2,
        FAILURE_UNSPECIFIED_ERROR = 3,
    }
}
public record CMsgDOTABetaParticipation(uint access_rights) : DotaPacket;
