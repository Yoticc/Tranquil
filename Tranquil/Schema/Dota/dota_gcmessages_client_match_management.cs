using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EStartFindingMatchResult
{
    k_EStartFindingMatchResult_Invalid = 0,
    k_EStartFindingMatchResult_OK = 1,
    k_EStartFindingMatchResult_AlreadySearching = 2,
    k_EStartFindingMatchResult_FailGeneric = 100,
    k_EStartFindingMatchResult_FailedIgnore = 101,
    k_EStartFindingMatchResult_MatchmakingDisabled = 102,
    k_EStartFindingMatchResult_RegionOffline = 103,
    k_EStartFindingMatchResult_MatchmakingCooldown = 104,
    k_EStartFindingMatchResult_ClientOutOfDate = 105,
    k_EStartFindingMatchResult_CompetitiveNoLowPriority = 106,
    k_EStartFindingMatchResult_CompetitiveNotUnlocked = 107,
    k_EStartFindingMatchResult_GameModeNotUnlocked = 108,
    k_EStartFindingMatchResult_CompetitiveNotEnoughPlayTime = 109,
    k_EStartFindingMatchResult_MissingInitialSkill = 110,
    k_EStartFindingMatchResult_CompetitiveRankSpreadTooLarge = 111,
    k_EStartFindingMatchResult_MemberAlreadyInLobby = 112,
    k_EStartFindingMatchResult_MemberNotVACVerified = 113,
    k_EStartFindingMatchResult_WeekendTourneyBadPartySize = 114,
    k_EStartFindingMatchResult_WeekendTourneyTeamBuyInTooSmall = 115,
    k_EStartFindingMatchResult_WeekendTourneyIndividualBuyInTooLarge = 116,
    k_EStartFindingMatchResult_WeekendTourneyTeamBuyInTooLarge = 117,
    k_EStartFindingMatchResult_MemberMissingEventOwnership = 118,
    k_EStartFindingMatchResult_WeekendTourneyNotUnlocked = 119,
    k_EStartFindingMatchResult_WeekendTourneyRecentParticipation = 120,
    k_EStartFindingMatchResult_MemberMissingAnchoredPhoneNumber = 121,
    k_EStartFindingMatchResult_NotMemberOfClan = 122,
    k_EStartFindingMatchResult_CoachesChallengeBadPartySize = 123,
    k_EStartFindingMatchResult_CoachesChallengeRequirementsNotMet = 124,
    k_EStartFindingMatchResult_InvalidRoleSelections = 125,
    k_EStartFindingMatchResult_PhoneNumberDiscrepancy = 126,
    k_EStartFindingMatchResult_NoQueuePoints = 127,
    k_EStartFindingMatchResult_MemberMissingGauntletFlag = 128,
    k_EStartFindingMatchResult_MemberGauntletTooRecent = 129,
    k_EStartFindingMatchResult_DifficultyNotUnlocked = 130,
    k_EStartFindingMatchResult_CoachesNotAllowedInParty = 131,
    k_EStartFindingMatchResult_MatchmakingBusy = 132,
    k_EStartFindingMatchResult_SteamChinaBanned = 133,
    k_EStartFindingMatchResult_SteamChinaInvalidMixedParty = 134,
    k_EStartFindingMatchResult_RestrictedFromRanked = 135,
    k_EStartFindingMatchResult_RankPreventsParties = 136,
    k_EStartFindingMatchResult_RegisteredNameRequired = 137,
}
public record CMsgStartFindingMatch(string key, uint matchgroups, uint client_version, uint game_modes, bool unused5, MatchType match_type, uint matchlanguages, uint team_id, bool unused9, MatchLanguages game_language_enum, string game_language_name, CMsgClientPingData ping_data, uint region_select_flags, bool solo_queue, bool unused15, uint steam_clan_account_id, bool is_challenge_match, uint lane_selection_flags, bool high_priority_disabled, bool disable_experimental_gameplay, uint custom_game_difficulty_mask, uint bot_difficulty_mask, uint bot_script_index_mask) : DotaPacket;
public record CMsgStartFindingMatchResult(uint legacy_generic_eresult, EStartFindingMatchResult result, string error_token, string debug_message, List<long> SF2responsible_party_members, uint result_metadata) : DotaPacket;
public record CMsgStopFindingMatch(bool accept_cooldown) : DotaPacket;
public record CMsgPartyBuilderOptions(uint additional_slots, MatchType match_type, uint matchgroups, uint client_version, MatchLanguages language) : DotaPacket;
public record CMsgReadyUp(DOTALobbyReadyState state, long SF2ready_up_key, CDOTAClientHardwareSpecs hardware_specs) : DotaPacket;
public record CMsgReadyUpStatus(long SF2lobby_id, List<uint> accepted_ids, List<uint> declined_ids, List<uint> accepted_indices, List<uint> declined_indices, DOTALobbyReadyState local_ready_state) : DotaPacket;
public record CMsgAbandonCurrentGame : DotaPacket;
public record CMsgLobbyScenarioSave(int version, byte[] data) : DotaPacket;
public record CMsgPracticeLobbySetDetails(ulong lobby_id, string game_name, List<CLobbyTeamDetails> team_details, uint server_region, uint game_mode, DOTA_CM_PICK cm_pick, bool unused7, bool unused8, DOTABotDifficulty bot_difficulty_radiant, bool allow_cheats, bool fill_with_bots, bool unused12, bool allow_spectating, bool unused14, string pass_key, uint leagueid, uint penalty_level_radiant, uint penalty_level_dire, bool unused19, uint series_type, uint radiant_series_wins, uint dire_series_wins, bool allchat, LobbyDotaTVDelay dota_tv_delay, bool lan, string custom_game_mode, string custom_map_name, uint custom_difficulty, ulong custom_game_id, uint custom_min_players, uint custom_max_players, bool unused32, DOTALobbyVisibility visibility, long SF2custom_game_crc, bool unused35, bool unused36, int SF1custom_game_timestamp, ulong previous_match_override, bool unused39, bool unused40, bool unused41, LobbyDotaPauseSetting pause_setting, DOTABotDifficulty bot_difficulty_dire, ulong bot_radiant, ulong bot_dire, DOTASelectionPriorityRules selection_priority_rules, bool custom_game_penalties, string lan_host_ping_location, uint league_node_id, List<int> requested_hero_ids, CMsgLobbyScenarioSave scenario_save, CMsgPracticeLobbySetDetails.AbilityDraftSpecificDetails ability_draft_specific_details, bool do_player_draft, List<int> requested_hero_teams) : DotaPacket
{
    public record AbilityDraftSpecificDetails(bool shuffle_draft_order);
}
public record CMsgPracticeLobbyCreate(string search_key, bool unused2, bool unused3, bool unused4, string pass_key, uint client_version, CMsgPracticeLobbySetDetails lobby_details) : DotaPacket;
public record CMsgPracticeLobbySetTeamSlot(DOTA_GC_TEAM team, uint slot, DOTABotDifficulty bot_difficulty) : DotaPacket;
public record CMsgPracticeLobbySetCoach(DOTA_GC_TEAM team) : DotaPacket;
public record CMsgPracticeLobbyJoinBroadcastChannel(uint channel, string preferred_description, string preferred_country_code, string preferred_language_code) : DotaPacket;
public record CMsgPracticeLobbyCloseBroadcastChannel(uint channel) : DotaPacket;
public record CMsgPracticeLobbyToggleBroadcastChannelCameramanStatus : DotaPacket;
public record CMsgPracticeLobbyKick(bool unused1, bool unused2, uint account_id) : DotaPacket;
public record CMsgPracticeLobbyKickFromTeam(uint account_id) : DotaPacket;
public record CMsgPracticeLobbyLeave : DotaPacket;
public record CMsgPracticeLobbyLaunch(bool unused1, bool unused2, bool unused3, bool unused4, uint client_version) : DotaPacket;
public record CMsgApplyTeamToPracticeLobby(uint team_id) : DotaPacket;
public record CMsgPracticeLobbyList(bool unused1, string pass_key, uint region, DOTA_GameMode game_mode) : DotaPacket;
public record CMsgPracticeLobbyListResponseEntry(ulong id, bool unused2, bool unused3, bool unused4, List<CMsgPracticeLobbyListResponseEntry.CLobbyMember> members, bool requires_pass_key, uint leader_account_id, bool unused8, bool unused9, string name, string custom_game_mode, DOTA_GameMode game_mode, bool friend_present, uint players, string custom_map_name, uint max_player_count, uint server_region, bool unused18, uint league_id, string lan_host_ping_location, uint min_player_count, bool penalties_enabled) : DotaPacket
{
    public record CLobbyMember(uint account_id, string player_name);
}
public record CMsgPracticeLobbyListResponse(bool unused1, List<CMsgPracticeLobbyListResponseEntry> lobbies) : DotaPacket;
public record CMsgLobbyList(uint server_region, DOTA_GameMode game_mode) : DotaPacket;
public record CMsgLobbyListResponse(List<CMsgPracticeLobbyListResponseEntry> lobbies) : DotaPacket;
public record CMsgPracticeLobbyJoin(ulong lobby_id, uint client_version, string pass_key, long SF2custom_game_crc, int SF1custom_game_timestamp) : DotaPacket;
public record CMsgPracticeLobbyJoinResponse(DOTAJoinLobbyResult result) : DotaPacket;
public record CMsgFriendPracticeLobbyListRequest(List<uint> friends) : DotaPacket;
public record CMsgFriendPracticeLobbyListResponse(List<CMsgPracticeLobbyListResponseEntry> lobbies) : DotaPacket;
public record CMsgJoinableCustomGameModesRequest(uint server_region) : DotaPacket;
public record CMsgJoinableCustomGameModesResponseEntry(ulong custom_game_id, uint lobby_count, uint player_count) : DotaPacket;
public record CMsgJoinableCustomGameModesResponse(List<CMsgJoinableCustomGameModesResponseEntry> game_modes) : DotaPacket;
public record CMsgJoinableCustomLobbiesRequest(uint server_region, ulong custom_game_id) : DotaPacket;
public record CMsgJoinableCustomLobbiesResponseEntry(long SF2lobby_id, ulong custom_game_id, string lobby_name, uint member_count, uint leader_account_id, string leader_name, string custom_map_name, uint max_player_count, uint server_region, bool unused10, bool has_pass_key, string lan_host_ping_location, uint lobby_creation_time, uint custom_game_timestamp, ulong custom_game_crc, uint min_player_count, bool penalties_enabled) : DotaPacket;
public record CMsgJoinableCustomLobbiesResponse(List<CMsgJoinableCustomLobbiesResponseEntry> lobbies) : DotaPacket;
public record CMsgQuickJoinCustomLobby(uint legacy_server_region, ulong custom_game_id, uint client_version, CMsgPracticeLobbySetDetails create_lobby_details, bool allow_any_map, List<CMsgQuickJoinCustomLobby.LegacyRegionPing> legacy_region_pings, CMsgClientPingData ping_data) : DotaPacket
{
    public record LegacyRegionPing(uint server_region, uint ping, int SF1region_code);
}
public record CMsgQuickJoinCustomLobbyResponse(DOTAJoinLobbyResult result) : DotaPacket;
public record CMsgBotGameCreate(string search_key, uint client_version, DOTABotDifficulty difficulty_radiant, DOTA_GC_TEAM team, uint game_mode, DOTABotDifficulty difficulty_dire) : DotaPacket;
public record CMsgDOTAPartyMemberSetCoach(bool wants_coach) : DotaPacket;
public record CMsgDOTASetGroupLeader(long SF2new_leader_steamid) : DotaPacket;
public record CMsgDOTACancelGroupInvites(List<long> SF2invited_steamids, List<long> SF2invited_groupids) : DotaPacket;
public record CMsgDOTASetGroupOpenStatus(bool open) : DotaPacket;
public record CMsgDOTAGroupMergeInvite(long SF2other_group_id) : DotaPacket;
public record CMsgDOTAGroupMergeResponse(long SF2initiator_group_id, bool accept) : DotaPacket;
public record CMsgDOTAGroupMergeReply(EDOTAGroupMergeResult result) : DotaPacket;
public record CMsgSpectatorLobbyGameDetails(uint language, ulong match_id, long SF2server_steam_id, string stream_url, string stream_name, uint league_id, uint series_type, uint series_game, CMsgSpectatorLobbyGameDetails.Team radiant_team, CMsgSpectatorLobbyGameDetails.Team dire_team) : DotaPacket
{
    public record Team(uint team_id, string team_name, long SF2team_logo);
}
public record CMsgSetSpectatorLobbyDetails(ulong lobby_id, string lobby_name, string pass_key, CMsgSpectatorLobbyGameDetails game_details) : DotaPacket;
public record CMsgCreateSpectatorLobby(uint client_version, CMsgSetSpectatorLobbyDetails details) : DotaPacket;
public record CMsgSpectatorLobbyList : DotaPacket;
public record CMsgSpectatorLobbyListResponse(List<CMsgSpectatorLobbyListResponse.SpectatorLobby> lobbies) : DotaPacket
{
    public record SpectatorLobby(ulong lobby_id, string game_name, bool requires_pass_key, uint leader_account_id, uint member_count, bool unused6, CMsgSpectatorLobbyGameDetails game_details);
}
public record CMsgClientToGCRequestSteamDatagramTicket(long SF2server_steam_id) : DotaPacket;
public record CMsgClientToGCRequestSteamDatagramTicketResponse(byte[] serialized_ticket, string message) : DotaPacket;
public record CMsgGCToClientSteamDatagramTicket(int SF1legacy_time_expiry, long SF2legacy_authorized_steam_id, int SF1legacy_authorized_public_ip, long SF2legacy_gameserver_steam_id, long SF2legacy_gameserver_net_id, byte[] legacy_signature, uint legacy_app_id, List<byte[]> legacy_extra_fields, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, bool unused15, byte[] serialized_ticket) : DotaPacket;
public record CMsgGCToClientRequestLaneSelection : DotaPacket;
public record CMsgGCToClientRequestLaneSelectionResponse(uint lane_selection_flags, bool high_priority_disabled) : DotaPacket;
public record CMsgGCToClientRequestMMInfo : DotaPacket;
public record CMsgClientToGCMMInfo(uint lane_selection_flags, bool high_priority_disabled) : DotaPacket;
