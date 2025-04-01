using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgClientToGCPrivateChatInvite(string private_chat_channel_name, uint invited_account_id) : DotaPacket;
public record CMsgClientToGCPrivateChatKick(string private_chat_channel_name, uint kick_account_id) : DotaPacket;
public record CMsgClientToGCPrivateChatPromote(string private_chat_channel_name, uint promote_account_id) : DotaPacket;
public record CMsgClientToGCPrivateChatDemote(string private_chat_channel_name, uint demote_account_id) : DotaPacket;
public record CMsgGCToClientPrivateChatResponse(string private_chat_channel_name, CMsgGCToClientPrivateChatResponse.Result result, string username) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE_CREATION_LOCK = 1,
        FAILURE_SQL_TRANSACTION = 2,
        FAILURE_SDO_LOAD = 3,
        FAILURE_NO_PERMISSION = 4,
        FAILURE_ALREADY_MEMBER = 5,
        FAILURE_NOT_A_MEMBER = 7,
        FAILURE_NO_REMAINING_ADMINS = 8,
        FAILURE_NO_ROOM = 9,
        FAILURE_CREATION_RATE_LIMITED = 10,
        FAILURE_UNKNOWN_CHANNEL_NAME = 11,
        FAILURE_UNKNOWN_USER = 12,
        FAILURE_UNKNOWN_ERROR = 13,
        FAILURE_CANNOT_KICK_ADMIN = 14,
        FAILURE_ALREADY_ADMIN = 15,
    }
}
public record CMsgDOTAJoinChatChannel(bool unused1, string channel_name, bool unused3, DOTAChatChannelType_t channel_type, bool silent_rejection) : DotaPacket;
public record CMsgDOTALeaveChatChannel(ulong channel_id) : DotaPacket;
public record CMsgGCChatReportPublicSpam(ulong channel_id, uint channel_user_id) : DotaPacket;
public record CMsgDOTAChatModeratorBan(ulong channel_id, uint account_id, uint duration) : DotaPacket;
public record CMsgDOTAChatMessage(uint account_id, ulong channel_id, string persona_name, string text, uint timestamp, uint suggest_invite_account_id, string suggest_invite_name, uint fantasy_draft_owner_account_id, uint fantasy_draft_player_account_id, uint event_id, bool suggest_invite_to_lobby, bool unused12, bool coin_flip, int player_id, uint share_profile_account_id, uint channel_user_id, CMsgDOTAChatMessage.DiceRoll dice_roll, ulong share_party_id, ulong share_lobby_id, ulong share_lobby_custom_game_id, string share_lobby_passkey, uint private_chat_channel_id, uint status, bool legacy_battle_cup_victory, uint badge_level, int suggest_pick_hero_id, string suggest_pick_hero_role, bool unused28, uint battle_cup_streak, int suggest_ban_hero_id, bool unused31, CMsgDOTAChatMessage.TriviaAnswered trivia_answer, int requested_ability_id, uint chat_flags, bool started_finding_match, bool ctrl_is_down, uint favorite_team_id, uint favorite_team_quality, int suggest_player_draft_pick, CMsgDOTAChatMessage.PlayerDraftPick player_draft_pick, CMsgDOTAChatMessage.ChatWheelMessage chat_wheel_message, uint event_level, uint suggest_pick_hero_facet, int requested_hero_id) : DotaPacket
{
    public record DiceRoll(int roll_min, int roll_max, int result);
    public record TriviaAnswered(uint question_id, uint answer_index, uint party_questions_correct, uint party_questions_viewed, uint party_trivia_points);
    public record PlayerDraftPick(int player_id, int team);
    public record ChatWheelMessage(uint message_id, uint emoticon_id, string message_text, uint hero_badge_tier);
}
public record CMsgDOTAChatMember(long SF2steam_id, string persona_name, uint channel_user_id, uint status) : DotaPacket;
public record CMsgDOTAJoinChatChannelResponse(uint response, string channel_name, long SF2channel_id, uint max_members, List<CMsgDOTAChatMember> members, DOTAChatChannelType_t channel_type, CMsgDOTAJoinChatChannelResponse.Result result, bool gc_initiated_join, uint channel_user_id, string welcome_message, EChatSpecialPrivileges special_privileges) : DotaPacket
{
    public enum Result
    {
        JOIN_SUCCESS = 0,
        INVALID_CHANNEL_TYPE = 1,
        ACCOUNT_NOT_FOUND = 2,
        ACH_FAILED = 3,
        USER_IN_TOO_MANY_CHANNELS = 4,
        RATE_LIMIT_EXCEEDED = 5,
        CHANNEL_FULL = 6,
        CHANNEL_FULL_OVERFLOWED = 7,
        FAILED_TO_ADD_USER = 8,
        CHANNEL_TYPE_DISABLED = 9,
        PRIVATE_CHAT_CREATE_FAILED = 10,
        PRIVATE_CHAT_NO_PERMISSION = 11,
        PRIVATE_CHAT_CREATE_LOCK_FAILED = 12,
        PRIVATE_CHAT_KICKED = 13,
        USER_NOT_ALLOWED = 14,
        ENSURE_SPECIAL_PRIVILEGES_FAILED = 15,
        NEW_PLAYER_USER_NOT_ELIGIBLE = 16,
        SILENT_ERROR = 17,
        NEW_PLAYER_USER_BANNED = 18,
    }
}
public record CMsgDOTAOtherJoinedChatChannel(long SF2channel_id, string persona_name, long SF2steam_id, uint channel_user_id, uint status) : DotaPacket;
public record CMsgDOTAOtherLeftChatChannel(long SF2channel_id, long SF2steam_id, uint channel_user_id) : DotaPacket;
public record CMsgDOTARequestChatChannelList : DotaPacket;
public record CMsgDOTARequestChatChannelListResponse(List<CMsgDOTARequestChatChannelListResponse.ChatChannel> channels) : DotaPacket
{
    public record ChatChannel(string channel_name, uint num_members, DOTAChatChannelType_t channel_type);
}
public record CMsgDOTAChatGetUserListResponse(long SF2channel_id, List<CMsgDOTAChatGetUserListResponse.Member> members) : DotaPacket
{
    public record Member(long SF2steam_id, string persona_name, uint channel_user_id, uint status);
}
public record CMsgDOTAChatGetMemberCount(string channel_name, DOTAChatChannelType_t channel_type) : DotaPacket;
public record CMsgDOTAChatGetMemberCountResponse(string channel_name, DOTAChatChannelType_t channel_type, uint member_count) : DotaPacket;
public record CMsgDOTAChatRegionsEnabled(bool enable_all_regions, List<CMsgDOTAChatRegionsEnabled.Region> enabled_regions) : DotaPacket
{
    public record Region(float min_latitude, float max_latitude, float min_longitude, float max_longitude);
}
