namespace Tranquil.Schema;

public enum ELobbyMemberCoachRequestState
{
    k_eLobbyMemberCoachRequestState_None = 0,
    k_eLobbyMemberCoachRequestState_Accepted = 1,
    k_eLobbyMemberCoachRequestState_Rejected = 2,
}
public enum LobbyDotaTVDelay
{
    LobbyDotaTV_10 = 0,
    LobbyDotaTV_120 = 1,
    LobbyDotaTV_300 = 2,
    LobbyDotaTV_900 = 3,
}
public enum LobbyDotaPauseSetting
{
    LobbyDotaPauseSetting_Unlimited = 0,
    LobbyDotaPauseSetting_Limited = 1,
    LobbyDotaPauseSetting_Disabled = 2,
}
public record CMsgLobbyCoachFriendRequest(uint coach_account_id, uint player_account_id, ELobbyMemberCoachRequestState request_state) : DotaPacket;
public record CMsgLobbyPlayerPlusSubscriptionData(List<CMsgLobbyPlayerPlusSubscriptionData.HeroBadge> hero_badges) : DotaPacket
{
    public record HeroBadge(int hero_id, uint hero_badge_xp);
}
public record CMsgEventActionData(uint action_id, uint action_score) : DotaPacket;
public record CMsgPeriodicResourceData(uint periodic_resource_id, uint remaining, uint max) : DotaPacket;
public record CMsgLobbyEventPoints(uint event_id, List<CMsgLobbyEventPoints.AccountPoints> account_points) : DotaPacket
{
    public record AccountPoints(uint account_id, uint normal_points, uint premium_points, bool owned, bool unused5, bool unused6, uint event_level, bool unused8, bool unused9, bool unused10, bool unused11, ulong active_effects_mask, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, bool unused20, bool unused21, bool unused22, uint wager_streak, bool unused24, List<CMsgEventActionData> event_game_custom_actions, uint tip_amount_index, uint active_event_season_id, uint teleport_fx_level, bool unused29, List<CMsgEventActionData> networked_event_actions, List<CMsgPeriodicResourceData> periodic_resources, List<CExtraMsgBlock> extra_event_messages);
}
public record CMsgLobbyEventGameData(uint game_seed, uint event_window_start_time) : DotaPacket;
public record CSODOTALobbyInvite(ulong group_id, long SF2sender_id, string sender_name, List<CSODOTALobbyInvite.LobbyMember> members, ulong custom_game_id, long SF2invite_gid, long SF2custom_game_crc, int SF1custom_game_timestamp) : DotaPacket
{
    public record LobbyMember(string name, long SF2steam_id);
}
public record CSODOTALobbyMember(long SF2id, int hero_id, DOTA_GC_TEAM team, bool unused4, bool unused5, bool unused6, uint slot, bool unused8, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, bool unused15, DOTALeaverStatus_t leaver_status, bool unused17, bool unused18, bool unused19, bool unused20, bool unused21, bool unused22, DOTA_GC_TEAM coach_team, bool unused24, bool unused25, bool unused26, bool unused27, uint leaver_actions, bool unused29, bool unused30, List<uint> custom_game_product_ids, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, DOTA_GC_TEAM live_spectator_team, bool unused41, bool unused42, bool unused43, List<CMsgPendingEventAward> pending_awards, List<CMsgPendingEventAward> pending_awards_on_victory, bool unused46, bool unused47, bool unused48, bool unused49, bool unused50, bool unused51, uint reports_available, bool unused53, bool unused54, uint live_spectator_account_id, uint comms_reports_available) : DotaPacket;
public record CSODOTAServerLobbyMember : DotaPacket;
public record CSODOTAStaticLobbyMember(string name, ulong party_id, uint channel, bool cameraman) : DotaPacket;
public record CSODOTAServerStaticLobbyMember(long SF2steam_id, bool unused2, int rank_tier, int leaderboard_rank, int lane_selection_flags, EDOTAMMRBoostType rank_mmr_boost_type, int coach_rating, List<uint> coached_account_ids, bool was_mvp_last_game, bool can_earn_rewards, bool is_plus_subscriber, ulong favorite_team_packed, bool is_steam_china, uint title, uint guild_id, List<int> SF1disabled_random_hero_bits, List<int> disabled_hero_id, List<int> enabled_hero_id, List<int> banned_hero_ids) : DotaPacket;
public record CLobbyTeamDetails(string team_name, bool unused2, string team_tag, uint team_id, ulong team_logo, ulong team_base_logo, ulong team_banner_logo, bool team_complete, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, uint rank, int SS1rank_change, bool is_home_team, bool is_challenge_match, ulong challenge_match_token_account, string team_logo_url, string team_abbreviation) : DotaPacket;
public record CLobbyGuildDetails(uint guild_id, uint guild_primary_color, uint guild_secondary_color, uint guild_pattern, ulong guild_logo, uint guild_points, uint guild_event, uint guild_flags, DOTA_GC_TEAM team_for_guild, string guild_tag, uint guild_weekly_percentile) : DotaPacket;
public record CLobbyTimedRewardDetails(bool unused1, uint item_def_index, bool is_supply_crate, bool is_timed_drop, uint account_id, uint origin) : DotaPacket;
public record CLobbyBroadcastChannelInfo(uint channel_id, string country_code, string description, string language_code) : DotaPacket;
public record CLobbyGuildChallenge(uint guild_id, EEvent event_id, uint challenge_instance_id, uint challenge_parameter, uint challenge_timestamp, uint challenge_period_serial, uint challenge_progress_at_start, List<uint> eligible_account_ids) : DotaPacket;
public record CDOTALobbyMatchQualityData(uint overall_quality, uint team_balance, uint match_skill_range, uint match_behavior) : DotaPacket;
public record CSODOTALobby(ulong lobby_id, bool unused2, uint game_mode, CSODOTALobby.State state, string connect, long SF2server_id, bool unused7, bool unused8, bool unused9, List<long> SF2pending_invites, long SF2leader_id, CSODOTALobby.LobbyType lobby_type, bool allow_cheats, bool fill_with_bots, bool unused15, string game_name, List<CLobbyTeamDetails> team_details, bool unused18, uint tournament_id, uint tournament_game_id, uint server_region, DOTA_GameState game_state, uint num_spectators, bool unused24, uint matchgroup, bool unused26, bool unused27, DOTA_CM_PICK cm_pick, bool unused29, ulong match_id, bool allow_spectating, bool unused32, bool unused33, bool unused34, bool unused35, DOTABotDifficulty bot_difficulty_radiant, bool unused37, bool unused38, string pass_key, bool unused40, bool unused41, uint leagueid, uint penalty_level_radiant, uint penalty_level_dire, bool unused45, uint series_type, uint radiant_series_wins, uint dire_series_wins, bool unused49, bool unused50, bool allchat, bool unused52, LobbyDotaTVDelay dota_tv_delay, string custom_game_mode, string custom_map_name, uint custom_difficulty, bool lan, List<CLobbyBroadcastChannelInfo> broadcast_channel_info, uint first_leaver_accountid, uint series_id, bool low_priority, List<CSODOTALobby.CExtraMsg> extra_messages, bool unused63, bool unused64, bool first_blood_happened, bool unused66, bool mass_disconnect, ulong custom_game_id, bool unused69, EMatchOutcome match_outcome, uint custom_min_players, uint custom_max_players, bool unused73, bool unused74, DOTALobbyVisibility visibility, long SF2custom_game_crc, bool custom_game_auto_created_lobby, bool unused78, bool unused79, int SF1custom_game_timestamp, List<ulong> previous_series_matches, ulong previous_match_override, bool unused83, bool unused84, bool unused85, bool unused86, uint game_start_time, LobbyDotaPauseSetting pause_setting, bool unused89, uint weekend_tourney_division_id, uint weekend_tourney_skill_level, uint weekend_tourney_bracket_round, DOTABotDifficulty bot_difficulty_dire, ulong bot_radiant, ulong bot_dire, List<EEvent> event_progression_enabled, DOTASelectionPriorityRules selection_priority_rules, uint series_previous_selection_priority_team_id, uint series_current_selection_priority_team_id, DOTASelectionPriorityChoice series_current_priority_team_choice, DOTASelectionPriorityChoice series_current_non_priority_team_choice, bool series_current_selection_priority_used_coin_toss, EEvent current_primary_event, bool unused104, List<int> emergency_disabled_hero_ids, long SF2custom_game_private_key, bool custom_game_penalties, bool unused108, string lan_host_ping_location, uint league_node_id, uint match_duration, bool unused112, uint league_phase, bool unused114, bool unused115, bool experimental_gameplay_enabled, List<CLobbyGuildChallenge> guild_challenges, List<CLobbyGuildDetails> guild_details, bool unused119, List<CSODOTALobbyMember> all_members, List<uint> member_indices, List<uint> left_member_indices, List<uint> free_member_indices, List<int> requested_hero_ids, List<CMsgLobbyCoachFriendRequest> coach_friend_requests, bool is_in_steam_china, bool with_scenario_save, uint lobby_creation_time, string event_game_definition, bool unused130, CDOTALobbyMatchQualityData match_quality_data, List<int> requested_hero_teams) : DotaPacket
{
    public enum State
    {
        UI = 0,
        READYUP = 4,
        SERVERSETUP = 1,
        RUN = 2,
        POSTGAME = 3,
        NOTREADY = 5,
        SERVERASSIGN = 6,
    }
    public enum LobbyType
    {
        INVALID = -1,
        CASUAL_MATCH = 0,
        PRACTICE = 1,
        COOP_BOT_MATCH = 4,
        COMPETITIVE_MATCH = 7,
        WEEKEND_TOURNEY = 9,
        LOCAL_BOT_MATCH = 10,
        SPECTATOR = 11,
        EVENT_MATCH = 12,
        NEW_PLAYER_POOL = 14,
        FEATURED_GAMEMODE = 15,
    }
    public record CExtraMsg(uint id, byte[] contents);
}
public record CSODOTAServerLobby(List<CSODOTAServerLobbyMember> all_members, List<CSODOTALobby.CExtraMsg> extra_startup_messages) : DotaPacket;
public record CSODOTAStaticLobby(List<CSODOTAStaticLobbyMember> all_members, bool is_player_draft, bool is_last_match_in_series) : DotaPacket;
public record CSODOTAServerStaticLobby(List<CSODOTAServerStaticLobbyMember> all_members, float post_patch_strategy_time_buffer, List<CMsgLobbyEventPoints> lobby_event_points) : DotaPacket;
public record CMsgAdditionalLobbyStartupAccountData(uint account_id, CMsgLobbyPlayerPlusSubscriptionData plus_data, List<CMsgAdditionalLobbyStartupAccountData.ChatWheelMessageRange> unlocked_chat_wheel_message_ranges, List<CMsgAdditionalLobbyStartupAccountData.PingWheelMessageRange> unlocked_ping_wheel_message_ranges) : DotaPacket
{
    public record ChatWheelMessageRange(uint message_id_start, uint message_id_end);
    public record PingWheelMessageRange(uint message_id_start, uint message_id_end);
}
public record CMsgLobbyInitializationComplete : DotaPacket;
public record CMsgLobbyPlaytestDetails(string json) : DotaPacket;
public record CMsgLocalServerGuildData(uint guild_id, EEvent event_id, uint guild_points, ulong guild_logo, uint guild_primary_color, uint guild_secondary_color, uint guild_pattern, uint guild_flags, uint guild_weekly_percentile) : DotaPacket;
public record CMsgLocalServerFakeLobbyData(uint account_id, List<CMsgLobbyEventPoints> event_points, bool is_plus_subscriber, uint primary_event_id, uint favorite_team, uint favorite_team_quality, CMsgLocalServerGuildData guild_info, uint teleport_fx_level, CMsgAdditionalLobbyStartupAccountData additional_data) : DotaPacket;
