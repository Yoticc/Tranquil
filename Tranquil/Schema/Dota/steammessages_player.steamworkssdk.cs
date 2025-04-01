using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum ENotificationSetting
{
    k_ENotificationSettingNotifyUseDefault = 0,
    k_ENotificationSettingAlways = 1,
    k_ENotificationSettingNever = 2,
}
public record CPlayer_GetMutualFriendsForIncomingInvites_Request : DotaPacket;
public record CPlayer_IncomingInviteMutualFriendList(long SF2steamid, List<uint> mutual_friend_account_ids) : DotaPacket;
public record CPlayer_GetMutualFriendsForIncomingInvites_Response(List<CPlayer_IncomingInviteMutualFriendList> incoming_invite_mutual_friends_lists) : DotaPacket;
public record CPlayer_GetFriendsGameplayInfo_Request(uint appid) : DotaPacket;
public record CPlayer_GetFriendsGameplayInfo_Response(CPlayer_GetFriendsGameplayInfo_Response.OwnGameplayInfo your_info, List<CPlayer_GetFriendsGameplayInfo_Response.FriendsGameplayInfo> in_game, List<CPlayer_GetFriendsGameplayInfo_Response.FriendsGameplayInfo> played_recently, List<CPlayer_GetFriendsGameplayInfo_Response.FriendsGameplayInfo> played_ever, List<CPlayer_GetFriendsGameplayInfo_Response.FriendsGameplayInfo> owns, List<CPlayer_GetFriendsGameplayInfo_Response.FriendsGameplayInfo> in_wishlist) : DotaPacket
{
    public record FriendsGameplayInfo(long SF2steamid, uint minutes_played, uint minutes_played_forever);
    public record OwnGameplayInfo(long SF2steamid, uint minutes_played, uint minutes_played_forever, bool in_wishlist, bool owned);
}
public record CPlayer_GetGameBadgeLevels_Request(uint appid) : DotaPacket;
public record CPlayer_GetGameBadgeLevels_Response(uint player_level, List<CPlayer_GetGameBadgeLevels_Response.Badge> badges) : DotaPacket
{
    public record Badge(int level, int series, uint border_color);
}
public record CPlayer_GetLastPlayedTimes_Request(uint min_last_played) : DotaPacket;
public record CPlayer_GetLastPlayedTimes_Response(List<CPlayer_GetLastPlayedTimes_Response.Game> games) : DotaPacket
{
    public record Game(int appid, uint last_playtime, int playtime_2weeks, int playtime_forever, uint first_playtime);
}
public record CPlayer_AcceptSSA_Request : DotaPacket;
public record CPlayer_AcceptSSA_Response : DotaPacket;
public record CPlayer_GetNicknameList_Request : DotaPacket;
public record CPlayer_GetNicknameList_Response(List<CPlayer_GetNicknameList_Response.PlayerNickname> nicknames) : DotaPacket
{
    public record PlayerNickname(int SF1accountid, string nickname);
}
public record CPlayer_GetPerFriendPreferences_Request : DotaPacket;
public record PerFriendPreferences(int SF1accountid, string nickname, ENotificationSetting notifications_showingame, ENotificationSetting notifications_showonline, ENotificationSetting notifications_showmessages, ENotificationSetting sounds_showingame, ENotificationSetting sounds_showonline, ENotificationSetting sounds_showmessages, ENotificationSetting notifications_sendmobile) : DotaPacket;
public record CPlayer_GetPerFriendPreferences_Response(List<PerFriendPreferences> preferences) : DotaPacket;
public record CPlayer_SetPerFriendPreferences_Request(PerFriendPreferences preferences) : DotaPacket;
public record CPlayer_SetPerFriendPreferences_Response : DotaPacket;
public record CPlayer_AddFriend_Request(long SF2steamid) : DotaPacket;
public record CPlayer_AddFriend_Response(bool invite_sent, uint friend_relationship) : DotaPacket;
public record CPlayer_RemoveFriend_Request(long SF2steamid) : DotaPacket;
public record CPlayer_RemoveFriend_Response(uint friend_relationship) : DotaPacket;
public record CPlayer_IgnoreFriend_Request(long SF2steamid, bool unignore) : DotaPacket;
public record CPlayer_IgnoreFriend_Response(uint friend_relationship) : DotaPacket;
public record CPlayer_GetCommunityPreferences_Request : DotaPacket;
public record CPlayer_CommunityPreferences(bool hide_adult_content_violence, bool hide_adult_content_sex, uint timestamp_updated, bool parenthesize_nicknames) : DotaPacket;
public record CPlayer_GetCommunityPreferences_Response(CPlayer_CommunityPreferences preferences) : DotaPacket;
public record CPlayer_SetCommunityPreferences_Request(CPlayer_CommunityPreferences preferences) : DotaPacket;
public record CPlayer_SetCommunityPreferences_Response : DotaPacket;
public record CPlayer_GetNewSteamAnnouncementState_Request(int language) : DotaPacket;
public record CPlayer_GetNewSteamAnnouncementState_Response(int state, string announcement_headline, string announcement_url, uint time_posted, ulong announcement_gid) : DotaPacket;
public record CPlayer_UpdateSteamAnnouncementLastRead_Request(ulong announcement_gid, uint time_posted) : DotaPacket;
public record CPlayer_UpdateSteamAnnouncementLastRead_Response : DotaPacket;
