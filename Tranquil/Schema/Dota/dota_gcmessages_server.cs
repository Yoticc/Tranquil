namespace Tranquil.Schema;

public enum EPoorNetworkConditionsType
{
    k_EPoorNetworkConditions_None = 0,
    k_EPoorNetworkConditions_Unknown = 1,
    k_EPoorNetworkConditions_MassDisconnect = 2,
    k_EPoorNetworkConditions_ExcessBadQosIntervals = 3,
}
public record CMsgPoorNetworkConditions(EPoorNetworkConditionsType detection_type, List<CMsgPoorNetworkConditions.Player> players) : DotaPacket
{
    public record Player(uint account_id, ENetworkDisconnectionReason disconnect_reason, uint num_bad_intervals, uint peak_loss_pct);
}
public record CMsgGameserverCrash(ulong match_id, long SF2lobby_id, DOTA_GameState game_state, int SF1sentinel_save_time, long SF2server_steam_id, int SF1server_public_ip_addr, uint server_port, uint server_cluster, uint pid, uint engine, long SF2custom_game_id, uint tournament_id) : DotaPacket;
public record CMsgConnectedPlayers(List<CMsgConnectedPlayers.Player> connected_players, DOTA_GameState game_state, bool unused3, bool unused4, bool unused5, bool first_blood_happened, List<CMsgConnectedPlayers.Player> disconnected_players, CMsgConnectedPlayers.SendReason send_reason, bool unused9, CMsgPoorNetworkConditions poor_network_conditions, uint radiant_kills, uint dire_kills, bool unused13, int radiant_lead, uint building_state, List<CMsgConnectedPlayers.PlayerDraft> player_draft) : DotaPacket
{
    public enum SendReason
    {
        INVALID = 0,
        HEARTBEAT = 1,
        GAME_STATE = 2,
        FIRST_BLOOD = 3,
        PLAYER_CONNECTED = 4,
        PLAYER_HERO = 5,
        PLAYER_DISCONNECTED_CONSEQUENCES = 6,
        PLAYER_DISCONNECTED_NOCONSEQUENCES = 7,
        GAMESTATE_TIMEOUT = 10,
        MASS_DISCONNECT = 11,
        KILLS = 13,
        BUILDING_STATE = 14,
    }
    public record Player(long SF2steam_id, int hero_id, CMsgLeaverState leaver_state, ENetworkDisconnectionReason disconnect_reason);
    public record PlayerDraft(long SF2steam_id, DOTA_GC_TEAM team, int team_slot);
}
public record CMsgGameServerInfo(int SF1server_public_ip_addr, int SF1server_private_ip_addr, uint server_port, uint server_tv_port, string server_key, bool server_hibernation, CMsgGameServerInfo.ServerType server_type, uint server_region, float server_loadavg, float server_tv_broadcast_time, float server_game_time, long SF2server_relay_connected_steam_id, uint relay_slots_max, int relays_connected, int relay_clients_connected, long SF2relayed_game_server_steam_id, uint parent_relay_count, long SF2tv_secret_code, uint server_version, uint server_cluster, bool unused21, uint assigned_server_tv_port, CMsgGameServerInfo.CustomGames allow_custom_games, uint build_version, bool unused25, uint srcds_instance, byte[] legacy_server_steamdatagram_address, bool dev_force_server_type, bool is_recording_match_training_data) : DotaPacket
{
    public enum ServerType
    {
        UNSPECIFIED = 0,
        GAME = 1,
        PROXY = 2,
        DOTA_ONLY = 4,
        CUSTOM_GAME_ONLY = 5,
        EVENT_GAME_ONLY = 6,
    }
    public enum CustomGames
    {
        BOTH = 0,
        NONE = 1,
        ONLY = 2,
        EVENT = 3,
    }
}
public record CMsgLeaverDetected(long SF2steam_id, DOTALeaverStatus_t leaver_status, bool unused3, CMsgLeaverState leaver_state, uint server_cluster, ENetworkDisconnectionReason disconnect_reason, CMsgPoorNetworkConditions poor_network_conditions) : DotaPacket;
public record CMsgLeaverDetectedResponse(uint result) : DotaPacket;
public record CMsgDOTAFantasyFinalPlayerStats(bool unused1, List<CMsgDOTAFantasyPlayerStats> stats) : DotaPacket;
public record CMsgDOTAFantasyLivePlayerStats(bool unused1, List<CMsgDOTAFantasyPlayerStats> stats) : DotaPacket;
public record CMsgServerToGCRealtimeStats(CMsgDOTARealtimeGameStatsTerse delayed) : DotaPacket;
public record CMsgGCToServerRealtimeStatsStartStop(bool delayed) : DotaPacket;
public record CMsgGCToServerUpdateSteamBroadcasting(bool active) : DotaPacket;
public record CMsgSignOutGameplayStats(List<CMsgSignOutGameplayStats.CTeam> teams) : DotaPacket
{
    public record CPlayer(long SF2steam_id, uint player_slot, int hero_id, List<CMatchPlayerTimedStats> timed_player_stats);
    public record CTeam(bool is_winning_team, bool is_radiant_team, List<CMatchTeamTimedStats> timed_team_stats, List<CMsgSignOutGameplayStats.CPlayer> players);
}
public record CMsgGameMatchSignOut(ulong match_id, uint duration, bool good_guys_win, int SF1date, bool unused5, List<CMsgGameMatchSignOut.CTeam> teams, bool unused7, List<uint> tower_status, List<uint> barracks_status, uint cluster, string server_addr, uint first_blood_time, bool unused13, uint event_score, bool unused15, bool unused16, List<CMsgEconPlayerStrangeCountAdjustment> player_strange_count_adjustments, bool automatic_surrender, uint server_version, List<CMsgGameMatchSignOut.CAdditionalSignoutMsg> additional_msgs, bool unused21, int SS1average_networth_delta, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, CMsgPoorNetworkConditions poor_network_conditions, List<CMsgGameMatchSignOut.CSocialFeedMatchEvent> social_feed_events, CMsgGameMatchSignOut.CCustomGameData custom_game_data, uint match_flags, List<uint> team_scores, uint pre_game_duration, List<CMsgDOTAFantasyPlayerStats> fantasy_stats, List<CMsgGameMatchSignOut.EventGameLeaderboardEntry> event_game_leaderboard_entries, List<CMsgGameMatchSignOut.WardPlacement> ward_placements, CMsgSignOutGameplayStats gameplay_stats, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, bool unused50, bool unused51, bool unused52, bool unused53, List<CExtraMsgBlock> extra_messages, bool training_data_recorded, DOTA_GC_TEAM winning_team, float normalized_win_probability_diff, List<CMsgTrackedStat> match_tracked_stats) : DotaPacket
{
    public record CTeam(List<CMsgGameMatchSignOut.CTeam.CPlayer> players, List<CMsgTrackedStat> team_tracked_stats)
    {
        public record CPlayer(long SF2steam_id, bool unused2, int hero_id, List<int> items, uint gold, uint kills, uint deaths, uint assists, uint leaver_status, uint last_hits, uint denies, uint gold_per_min, uint xp_per_minute, uint gold_spent, uint level, uint scaled_hero_damage, uint scaled_tower_damage, uint scaled_hero_healing, uint time_last_seen, uint support_ability_value, ulong party_id, bool unused22, bool unused23, bool unused24, bool unused25, bool unused26, uint claimed_farm_gold, uint support_gold, uint claimed_denies, uint claimed_misses, uint misses, List<CMatchPlayerAbilityUpgrade> ability_upgrades, List<CMatchAdditionalUnitInventory> additional_units_inventory, uint net_worth, CMsgGameMatchSignOut.CTeam.CPlayer.CCustomGameData custom_game_data, uint match_player_flags, uint hero_damage, uint tower_damage, uint hero_healing, List<CMatchPlayerPermanentBuff> permanent_buffs, List<int> talent_ability_ids, uint hero_pick_order, bool hero_was_randomed, bool unused44, uint lane, bool unused46, bool is_using_plus_guide, List<CMsgGameMatchSignOut.CTeam.CPlayer.HeroDamageReceived> hero_damage_received, bool unused49, bool hero_was_dota_plus_suggestion, uint seconds_dead, uint gold_lost_to_death, uint command_count, uint mouse_click_cast_command_count, uint teleports_used, uint cavern_crawl_preferred_map_variant, uint bounty_runes, uint outposts_captured, uint dewards, uint wards_placed, uint camps_stacked, uint player_slot, List<uint> item_purchase_times, List<CMsgGameMatchSignOut.CTeam.CPlayer.HeroDamageReceived> hero_damage_dealt, bool unused65, uint predicted_position, uint lane_outcomes, uint friendly_t1_destroyed_time, uint enemy_t1_destroyed_time, uint friendly_roshan_kills, uint enemy_roshan_kills, uint power_runes, uint water_runes, float stun_duration, DOTA_GC_TEAM team_number, uint team_slot, uint time_purchased_shard, uint time_purchased_aghs, List<int> ability_draft_abilities, List<CMsgTrackedStat> player_tracked_stats, uint predicted_rank, uint selected_facet, uint enhancement_level)
        {
            public enum HeroDamageType
            {
                HERO_DAMAGE_PHYSICAL = 0,
                HERO_DAMAGE_MAGICAL = 1,
                HERO_DAMAGE_PURE = 2,
            }
            public record CCustomGameData(uint dota_team, bool winner);
            public record HeroDamageReceived(uint pre_reduction, uint post_reduction, CMsgGameMatchSignOut.CTeam.CPlayer.HeroDamageType damage_type);
        }
    }
    public record CAdditionalSignoutMsg(uint id, byte[] contents);
    public record CSocialFeedMatchEvent(uint account_id, uint timestamp, uint event_type, int game_time, uint replay_time);
    public record CCustomGameData(uint publish_timestamp);
    public record EventGameLeaderboardEntry(string name_suffix, int score, uint extra_data_1, uint extra_data_2, uint extra_data_3, uint extra_data_4, uint extra_data_5);
    public record WardPlacement(int player_id, uint team_id, uint placed_time, uint building_state, uint creep_state, bool roshan_alive, uint position_x, uint position_y);
}
public record CMsgSignOutDraftInfo(uint radiant_captain_account_id, uint dire_captain_account_id, List<CMatchHeroSelectEvent> picks_bans) : DotaPacket;
public record CMsgSignOutBotInfo(bool allow_cheats, DOTABotDifficulty bot_difficulty_radiant, bool created_lobby, bool unused4, DOTABotDifficulty bot_difficulty_dire) : DotaPacket;
public record CMsgSignOutTextMuteInfo(List<CMsgSignOutTextMuteInfo.TextMuteMessage> text_mute_messages) : DotaPacket
{
    public record TextMuteMessage(uint region, bool caused_text_mute, string chat_message);
}
public record CMsgSignOutPlayerStats(int account_id, ulong match_id, uint rank, int hero_id, uint rampages, uint triple_kills, uint first_blood_claimed, uint first_blood_given, uint couriers_killed, uint aegises_snatched, uint cheeses_eaten, uint creeps_stacked, float fight_score, float farm_score, float support_score, float push_score, uint kills, uint deaths, uint assists, uint last_hits, uint denies, float gpm, float xppm, float net_worth, float damage, float heals, uint rapiers_purchased, uint observer_wards_placed, uint wards_destroyed, uint lobby_type) : DotaPacket;
public record CMsgSignOutCommunicationSummary(List<CMsgSignOutCommunicationSummary.PlayerCommunication> players) : DotaPacket
{
    public record PlayerCommunication(uint account_id, uint pings, uint max_pings_per_interval, uint teammate_pings, uint max_teammate_pings_per_interval, uint team_chat_messages, uint all_chat_messages, uint chat_wheel_messages, uint pauses, uint unpauses, uint lines_drawn, uint voice_chat_seconds, uint chat_mutes, uint voice_mutes, List<CMsgSignOutCommunicationSummary.PlayerCommunication.PingDetail> ping_details, uint comms_blocks_solo, uint comms_blocks_mass, List<string> chat_log)
    {
        public record PingDetail(uint type, uint count);
    }
}
public record CMsgGameMatchSignoutResponse(ulong match_id, int SF1replay_salt, bool unused3, bool unused4, uint leagueid, bool unused6, int SF1metadata_private_key, CMsgDOTAMatch match_details, List<CMsgGameMatchSignoutResponse.PlayerMetadata> players_metadata, CMvpData mvp_data, long SF2ow_private_key, int SF1ow_salt, ulong ow_replay_id, CMsgOverworldMatchRewards overworld_rewards) : DotaPacket
{
    public record PlayerMetadata(int hero_id, uint avg_kills_x16, uint avg_deaths_x16, uint avg_assists_x16, uint avg_gpm_x16, uint avg_xpm_x16, uint best_kills_x16, uint best_assists_x16, uint best_gpm_x16, uint best_xpm_x16, uint win_streak, uint best_win_streak, uint games_played);
}
public record CMsgGameMatchSignOutPermissionRequest(uint server_version, uint local_attempt, uint total_attempt, uint seconds_waited) : DotaPacket;
public record CMsgGameMatchSignOutPermissionResponse(bool permission_granted, bool abandon_signout, uint retry_delay_seconds) : DotaPacket;
public record CMsgGameMatchSignOutEventGameData(EEvent event_id, string game_name, string map_name, byte[] event_game_data, uint start_time) : DotaPacket;
public record CMsgGameMatchSignOutPerfData(List<float> average_frame_time, List<float> max_frame_time, float server_average_frame_time, float server_max_frame_time, List<float> average_compute_time, List<float> max_compute_time, List<float> average_client_tick_time, List<float> max_client_tick_time, List<float> average_client_simulate_time, List<float> max_client_simulate_time, List<float> average_output_time, List<float> max_output_time, List<float> average_wait_for_rendering_to_complete_time, List<float> max_wait_for_rendering_to_complete_time, List<float> average_swap_time, List<float> max_swap_time, List<float> average_frame_update_time, List<float> max_frame_update_time, List<float> average_idle_time, List<float> max_idle_time, List<float> average_input_processing_time, List<float> max_input_processing_time) : DotaPacket;
public record CMsgGameMatchSignOutBanData(List<int> hero_bans, List<int> hero_ban_votes) : DotaPacket;
public record CMsgDOTALiveScoreboardUpdate(uint tournament_id, uint tournament_game_id, float duration, int hltv_delay, CMsgDOTALiveScoreboardUpdate.Team team_good, CMsgDOTALiveScoreboardUpdate.Team team_bad, uint roshan_respawn_timer, uint league_id, ulong match_id) : DotaPacket
{
    public record Team(List<CMsgDOTALiveScoreboardUpdate.Team.Player> players, uint score, uint tower_state, uint barracks_state, List<int> hero_picks, List<int> hero_bans)
    {
        public record Player(uint player_slot, string player_name, string hero_name, int hero_id, uint kills, uint deaths, uint assists, uint last_hits, uint denies, uint gold, uint level, float gold_per_min, float xp_per_min, CMsgDOTALiveScoreboardUpdate.Team.Player.DOTAUltimateState ultimate_state, float ultimate_cooldown, int item0, int item1, int item2, int item3, int item4, int item5, uint respawn_timer, uint account_id, float position_x, float position_y, uint net_worth, List<CMsgDOTALiveScoreboardUpdate.Team.Player.HeroAbility> abilities)
        {
            public enum DOTAUltimateState
            {
                k_EDOTAUltimateStateNotLearned = 0,
                k_EDOTAUltimateStateCooldown = 1,
                k_EDOTAUltimateStateNeedsMana = 2,
                k_EDOTAUltimateStateReady = 3,
            }
            public record HeroAbility(int ability_id, uint ability_level);
        }
    }
}
public record CMsgServerToGCRequestBatchPlayerResources(List<uint> account_ids, bool unused2, bool unused3, List<uint> rank_types, int lobby_type) : DotaPacket;
public record CMsgServerToGCRequestBatchPlayerResourcesResponse(bool unused1, bool unused2, bool unused3, bool unused4, bool unused5, List<CMsgServerToGCRequestBatchPlayerResourcesResponse.Result> results) : DotaPacket
{
    public record Result(uint account_id, bool unused2, bool unused3, uint rank, bool rank_calibrated, bool low_priority, bool is_new_player, bool is_guide_player, int comm_level, int behavior_level, int wins, int losses, int smurf_category, int comm_score, int behavior_score, int rank_uncertainty);
}
public record CMsgDOTAPlayerFailedToConnect(List<long> SF2failed_loaders, List<long> SF2abandoned_loaders) : DotaPacket;
public record CMsgGCToRelayConnect(uint source_tv_public_addr, uint source_tv_private_addr, uint source_tv_port, ulong game_server_steam_id, uint parent_count, long SF2tv_unique_secret_code, long SF2source_tv_steamid) : DotaPacket;
public record CMsgGCGCToLANServerRelayConnect(long SF2relay_steamid) : DotaPacket;
public record CMsgGCBanStatusRequest(uint account_id) : DotaPacket;
public record CMsgGCBanStatusResponse(uint result, bool low_priority, bool text_chat_banned, bool voice_chat_banned) : DotaPacket;
public record CMsgTournamentItemEvent(int SF1killer_account_id, int SF1victim_account_id, DOTA_TournamentEvents event_type, int tv_delay, int dota_time, float replay_time, string loot_list, uint event_team, uint multi_kill_count, uint winner_score, uint loser_score, List<CProtoItemHeroStatue> hero_statues) : DotaPacket;
public record CMsgTournamentItemEventResponse(DOTA_TournamentEvents event_type, bool unused2, bool unused3, bool unused4, bool unused5, uint viewers_granted) : DotaPacket;
public record CMsgTeamFanfare(ulong match_id) : DotaPacket;
public record CMsgResponseTeamFanfare(uint fanfare_goodguys, uint fanfare_badguys) : DotaPacket;
public record CMsgDOTAAwardEventPoints(List<CMsgDOTAAwardEventPoints.AwardPoints> award_points, ulong match_id, bool unused3, EEvent event_id, uint timestamp, uint audit_action) : DotaPacket
{
    public record AwardPoints(uint account_id, int points, int premium_points, bool unused4, uint trade_ban_time, bool eligible_for_periodic_adjustment, uint point_cap_periodic_resource_id);
}
public record CMsgGCToServerPingRequest(long SF2request_id, ulong request_time) : DotaPacket;
public record CMsgGCToServerPingResponse(long SF2request_id, ulong request_time, uint cluster) : DotaPacket;
public record CMsgServerToGCMatchConnectionStats(ulong match_id, uint region_id, uint league_id, List<CMsgServerToGCMatchConnectionStats.Player> players, uint cluster_id) : DotaPacket
{
    public record Player(uint account_id, int SF1ip, uint avg_ping_ms, bool unused4, float packet_loss, float ping_deviation, uint full_resends);
}
public record CMsgServerGCUpdateSpectatorCount(uint spectator_count) : DotaPacket;
public record CSerializedCombatLog(uint version, CSerializedCombatLog.Dictionary dictionary, List<CMsgDOTACombatLogEntry> entries) : DotaPacket
{
    public record Dictionary(List<CSerializedCombatLog.Dictionary.DictString> strings)
    {
        public record DictString(uint id, string value);
    }
}
public record CMsgServerToGCVictoryPredictions(List<CMsgServerToGCVictoryPredictions.Record> records) : DotaPacket
{
    public record PredictionItem(ulong item_id, uint item_def);
    public record Record(uint account_id, bool unused2, bool unused3, bool unused4, List<ulong> item_ids, List<CMsgServerToGCVictoryPredictions.PredictionItem> prediction_items);
}
public record CMsgServerToGCRequestStatus : DotaPacket;
public record CMsgServerToGCRequestStatus_Response(uint response) : DotaPacket;
public record CMsgGCToServerEvaluateToxicChat(uint target_account_id, uint reporter_account_id) : DotaPacket;
public record CMsgServerToGCEvaluateToxicChat(uint target_account_id, uint reporter_account_id, long SF2match_id, List<uint> timestamp, List<string> line) : DotaPacket;
public record CMsgServerToGCEvaluateToxicChatResponse(uint target_account_id, uint reporter_account_id, uint ban_reason, uint ban_duration, float toxicity_score) : DotaPacket;
public record CMsgSignOutAssassinMiniGameInfo(List<long> SF2winning_players, List<long> SF2losing_players, List<long> SF2arcana_owners, bool assassin_won, int target_hero_id, bool contract_completed, float contract_complete_time, bool pa_is_radiant) : DotaPacket;
public record CMsgServerToGCKillSummaries(uint ingameevent_id, List<CMsgServerToGCKillSummaries.KillSummary> summaries) : DotaPacket
{
    public record KillSummary(uint killer_hero_id, uint victim_hero_id, uint kill_count);
}
public record CMsgServerToGCLockCharmTrading(uint account_id, ulong item_id) : DotaPacket;
public record CMsgSignOutUpdatePlayerChallenge(uint account_id, List<CMsgSignOutUpdatePlayerChallenge.Challenge> completed, List<CMsgSignOutUpdatePlayerChallenge.Challenge> rerolled, ulong match_id, int hero_id) : DotaPacket
{
    public record Challenge(EEvent event_id, uint slot_id, uint sequence_id, uint progress, uint challenge_rank);
}
public record CMsgServerToGCRerollPlayerChallenge(uint account_id, CMsgClientToGCRerollPlayerChallenge reroll_msg) : DotaPacket;
public record CMsgSpendWager(List<CMsgSpendWager.Player> players, EEvent event_id, uint timestamp, ulong match_id, ulong server_steam_id) : DotaPacket
{
    public record Player(uint account_id, uint wager, ulong wager_token_item_id);
}
public record CMsgSignOutXPCoins(List<CMsgSignOutXPCoins.Player> players, EEvent event_id, ulong match_id, uint timestamp) : DotaPacket
{
    public record Player(uint account_id, uint xp_gained, uint coins_spent, ulong wager_token_item_id, uint rank_wager, uint wager_streak);
}
public record CMsgSignOutBounties(List<CMsgSignOutBounties.Bounty> bounties, EEvent event_id, ulong match_id, uint timestamp) : DotaPacket
{
    public record Bounty(uint issuer_account_id, uint completer_account_id, uint target_account_id);
}
public record CMsgSignOutCommunityGoalProgress(EEvent event_id, List<CMsgSignOutCommunityGoalProgress.EventGoalIncrement> event_increments) : DotaPacket
{
    public record EventGoalIncrement(uint event_goal_id, uint increment_amount);
}
public record CMsgServerToGCCloseCompendiumInGamePredictionVoting(ulong match_id, uint hltv_delay, uint league_id) : DotaPacket;
public record CMsgServerToGCCloseCompendiumInGamePredictionVotingResponse(bool result) : DotaPacket;
public record CMsgServerToGCCompendiumInGamePredictionResults(ulong match_id, List<CMsgServerToGCCompendiumInGamePredictionResults.PredictionResult> results, uint league_id, uint league_node_id) : DotaPacket
{
    public record PredictionResult(uint prediction_id, uint prediction_value, bool prediction_value_is_mask);
}
public record CMsgServerToGCCompendiumChosenInGamePredictions(ulong match_id, List<CMsgServerToGCCompendiumChosenInGamePredictions.Prediction> predictions_chosen, uint league_id) : DotaPacket
{
    public record Prediction(uint prediction_id);
}
public record CMsgGCToGCCompendiumInGamePredictionResults(CMsgServerToGCCompendiumInGamePredictionResults results) : DotaPacket;
public record CMsgServerToGCMatchPlayerItemPurchaseHistory(ulong match_id, uint mmr, List<CMsgServerToGCMatchPlayerItemPurchaseHistory.Player> players) : DotaPacket
{
    public record ItemPurchase(int item, uint gold, uint net_worth, uint game_time, List<int> inventory_items, bool unused6, List<bool> talents_skilled);
    public record Player(uint player_slot, uint account_id, int hero_id, List<int> allied_hero_ids, List<int> enemy_hero_ids, List<CMsgServerToGCMatchPlayerItemPurchaseHistory.ItemPurchase> item_purchases, uint lane, bool is_winner);
}
public record CMsgServerToGCMatchPlayerNeutralItemEquipHistory(ulong match_id, List<CMsgServerToGCMatchPlayerNeutralItemEquipHistory.Player> players) : DotaPacket
{
    public record ItemEquip(int item, uint game_time, List<int> inventory_items, List<bool> talents_skilled, List<int> available_neutral_items);
    public record Player(uint account_id, List<int> allied_hero_ids, List<int> enemy_hero_ids, List<CMsgServerToGCMatchPlayerNeutralItemEquipHistory.ItemEquip> item_equips, bool is_winner);
}
public record CMsgServerToGCMatchStateHistory(ulong match_id, bool radiant_won, uint mmr, List<CMsgServerToGCMatchStateHistory.MatchState> match_states) : DotaPacket
{
    public record PlayerState(int hero_id, uint net_worth, uint level, uint deaths, uint respawn_time, bool has_buyback, bool has_aegis, bool has_rapier, uint distance);
    public record TeamState(uint team, List<CMsgServerToGCMatchStateHistory.PlayerState> player_states, List<uint> tower_health_pct, List<uint> barracks_health_pct, uint ancient_health_pct, uint glyph_cooldown, uint kills, uint creep_distance_safe, uint creep_distance_mid, uint creep_distance_off);
    public record MatchState(uint game_time, CMsgServerToGCMatchStateHistory.TeamState radiant_state, CMsgServerToGCMatchStateHistory.TeamState dire_state);
}
public record CMsgMatchStateSteamMLEntry(CMsgServerToGCMatchStateHistory.MatchState match_state, uint mmr, bool radiant_won) : DotaPacket;
public record CMsgLaneSelectionSteamMLEntry(List<int> hero_ids, List<uint> lanes) : DotaPacket;
public record CMsgAbilitySelectionSteamMLEntry(uint mmr, int hero_id, List<int> enemy_hero_ids, uint lane, List<int> abilities, int selected_ability) : DotaPacket;
public record CMsgItemPurchasePregameSteamMLEntry(uint mmr, uint lane, float balance, int hero_id, List<int> allied_hero_ids, List<int> enemy_hero_ids, List<int> items) : DotaPacket;
public record CMsgItemPurchaseSteamMLEntry(uint mmr, uint lane, int hero_id, List<int> allied_hero_ids, List<int> enemy_hero_ids, List<int> items, List<int> items_to_be_purchased) : DotaPacket;
public record CMsgItemPurchaseSequenceSteamMLEntry(uint mmr, uint lane, int hero_id, List<int> allied_hero_ids, List<int> enemy_hero_ids, List<int> items, int item_to_be_purchased) : DotaPacket;
public record CMsgServerToGCCavernCrawlIsHeroActive(uint event_id, uint account_id, uint preferred_map_variant, int hero_id, bool turbo_mode) : DotaPacket;
public record CMsgServerToGCPlayerChallengeHistory(ulong match_id, uint average_rank, List<CMsgServerToGCPlayerChallengeHistory.PlayerChallenge> challenge_records) : DotaPacket
{
    public record PlayerChallenge(uint account_id, EPlayerChallengeHistoryType challenge_type, uint challenge_id1, uint challenge_id2, uint progress_value_start, uint progress_value_end, bool team_won, ulong audit_data, int hero_id, uint rank_completed);
}
public record CMsgServerToGCCavernCrawlIsHeroActiveResponse(bool result, uint potential_winnings, List<CMsgServerToGCCavernCrawlIsHeroActiveResponse.MapResults> map_results, uint potential_plus_shard_winnings, uint map_variant) : DotaPacket
{
    public record MapResults(uint path_id_completed, uint room_id_claimed);
}
public record CMsgNeutralItemStats(List<CMsgNeutralItemStats.NeutralItem> neutral_items) : DotaPacket
{
    public record NeutralItem(int item_id, uint time_dropped, uint team, uint time_last_equipped, uint time_last_unequipped, uint duration_equipped);
}
public record CMsgGCToServerLobbyHeroBanRates(List<CMsgGCToServerLobbyHeroBanRates.HeroBanEntry> ban_data) : DotaPacket
{
    public record HeroBanEntry(int hero_id, uint ban_count, uint pick_count);
}
public record CMsgSignOutGuildContractProgress(List<CMsgSignOutGuildContractProgress.PlayerContract> player_contracts) : DotaPacket
{
    public record CompletedGuildEventContracts(uint guild_id, uint event_id, List<ulong> contracts);
    public record PlayerContract(uint account_id, List<CMsgSignOutGuildContractProgress.CompletedGuildEventContracts> completed_contracts);
}
public record CMsgSignOutGuildChallengeProgress(List<CMsgSignOutGuildChallengeProgress.ChallengeProgress> guild_challenges_progresses) : DotaPacket
{
    public record ChallengeProgress(uint guild_id, uint event_id, uint challenge_instance_id, uint challenge_instance_timestamp, uint challenge_period_serial, uint progress, uint challenge_parameter);
}
public record CMsgSignOutMVPStats(ulong match_id, uint game_mode, uint winning_team, float game_time, List<CMsgSignOutMVPStats.Player> players) : DotaPacket
{
    public record Player(uint team_id, uint team_networth_rank, uint account_id, int hero_id, uint role, int kills, int deaths, int assists, int xp, int net_worth, bool unused11, int support_gold_spent, int wards_placed, int wards_spotted_for_dewarding, int camps_stacked, int last_hits, int denies, bool unused18, int building_damage, int other_damage, bool unused21, bool unused22, bool unused23, bool unused24, bool unused25, int triple_kills, bool unused27, int rampages, bool unused29, bool unused30, int first_blood, uint player_slot, uint rank, List<CMsgSignOutMVPStats.Player.KillEaterEvent> kill_eater_events, uint highest_killstreak)
    {
        public record KillEaterEvent(uint event_type, uint amount);
    }
}
public record CMsgGCToServerRecordTrainingData(bool enable) : DotaPacket;
public record CMsgServerToGCGetGuildContracts(List<uint> account_ids) : DotaPacket;
public record CMsgServerToGCGetGuildContractsResponse(List<CMsgServerToGCGetGuildContractsResponse.Player> player_contracts) : DotaPacket
{
    public record ContractDetails(ulong contract_id, uint challenge_instance_id, uint challenge_parameter, uint contract_stars, uint contract_slot);
    public record Player(uint account_id, uint guild_id, EEvent event_id, List<CMsgServerToGCGetGuildContractsResponse.ContractDetails> contracts);
}
public record CMsgMatchDiretideCandy(List<CMsgMatchDiretideCandy.PlayerCandy> player_candy_data, EEvent event_id) : DotaPacket
{
    public record CandyDetails(uint amount, uint audit);
    public record PlayerCandy(uint account_id, bool unused2, uint candy_amount, bool consumes_periodic_resource, List<CMsgMatchDiretideCandy.CandyDetails> candy_breakdown);
}
public record CMsgGCToServerCheerData(List<CMsgGCToServerCheerData.CheerTypeCount> cheer_types) : DotaPacket
{
    public record CheerTypeCount(uint cheer_type, uint cheer_count);
}
public record CMsgCheerConfig(bool cheers_enabled, bool is_valid_league_id, float window_duration, uint window_bucket_count, bool unused5, float crowd_level_push_time, bool unused7, bool unused8, bool unused9, uint crowd_level_low, uint crowd_level_medium, uint crowd_level_high, float cheer_scale_start, float cheer_scale_speed, uint cheer_scale_push_mark, uint cheer_scale_pull_mark, float cheer_scale_pct_of_max_cps_clamp, float cheer_factor_bronze, float cheer_factor_silver, float cheer_factor_gold, float cheer_scale_dampener_value, uint cheer_scale_dampener_lerp_time) : DotaPacket;
public record CMsgGCToServerCheerConfig(CMsgCheerConfig cheer_config) : DotaPacket;
public record CMsgServerToGCGetCheerConfig(uint league_id) : DotaPacket;
public record CMsgServerToGCGetCheerConfigResponse(bool unused1, CMsgCheerConfig cheer_config) : DotaPacket;
public record CMsgGCToServerCheerScalesOverride(List<float> scales) : DotaPacket;
public record CMsgGCToServerGetCheerState : DotaPacket;
public record CMsgCheerTypeState(List<uint> cheer_counts, float max_per_second, float cheer_scale, float override_scale) : DotaPacket;
public record CMsgCheerState(List<CMsgCheerTypeState> cheer_types, uint radiant_crowd_level, uint dire_crowd_level) : DotaPacket;
public record CMsgServerToGCReportCheerState(CMsgCheerConfig cheer_config, CMsgCheerState cheer_state) : DotaPacket;
public record CMsgServerToGCGetStickerHeroes(List<uint> account_ids) : DotaPacket;
public record CMsgServerToGCGetStickerHeroesResponse(List<CMsgServerToGCGetStickerHeroesResponse.Player> players) : DotaPacket
{
    public record Player(uint account_id, CMsgStickerHeroes stickers);
}
public record CMsgSteamLearnMatchInfo(uint average_mmr, bool radiant_won, uint duration, uint game_mode, uint lobby_type) : DotaPacket;
public record CMsgSteamLearnMatchInfoPlayer(uint average_mmr, bool team_won, uint duration, uint game_mode, uint lobby_type, uint player_mmr) : DotaPacket;
public record CMsgSteamLearnMatchInfoTeam(List<CMsgSteamLearnMatchInfoTeam.Player> radiant_players, List<CMsgSteamLearnMatchInfoTeam.Player> dire_players, bool radiant_team_won) : DotaPacket
{
    public record Player(uint prematch_mmr, uint prematch_rank_uncertainty, uint prematch_behavior_score, uint prematch_comm_score, uint num_players_in_party);
}
public record CMsgSteamLearnMatchHeroesV3(List<int> radiant_hero_ids, List<int> dire_hero_ids, List<uint> radiant_lanes, List<uint> dire_lanes, List<uint> radiant_hero_facets, List<uint> dire_hero_facets, List<uint> radiant_positions, List<uint> dire_positions) : DotaPacket;
public record CMsgSteamLearnMatchHeroV3(int hero_id, uint lane, List<int> allied_hero_ids, List<int> enemy_hero_ids, uint hero_facet, List<uint> allied_hero_facets, List<uint> enemy_herofacets, uint position) : DotaPacket;
public record CMsgSteamLearnPlayerTimedStats(List<CMsgSteamLearnPlayerTimedStats.StatBucket> stat_buckets) : DotaPacket
{
    public record StatBucket(float game_time, uint kills, uint deaths, uint assists, uint experience, uint last_hits, uint denies, uint net_worth, float idle_time, uint commands_issued, uint sentry_wards_placed, uint observer_wards_placed);
}
public record CMsgSteamLearnMatchStateV5(float game_time, CMsgSteamLearnMatchStateV5.TeamState radiant_state, CMsgSteamLearnMatchStateV5.TeamState dire_state) : DotaPacket
{
    public record PlayerState(int hero_id, uint net_worth, uint level, uint deaths, uint respawn_time, bool has_buyback, bool has_aegis, bool has_rapier, uint distance, uint hero_facet);
    public record TeamState(uint team, List<CMsgSteamLearnMatchStateV5.PlayerState> player_states, List<uint> tower_health_pct, List<uint> barracks_health_pct, uint ancient_health_pct, uint glyph_cooldown, uint kills, uint creep_distance_safe, uint creep_distance_mid, uint creep_distance_off);
}
public record CMsgSteamLearnItemPurchase(int item_id, List<int> inventory_items, List<int> purchase_history, uint gold, uint net_worth, uint is_radiant_team, float game_time, bool is_using_dota_plus) : DotaPacket;
public record CMsgSteamLearnPreGameItemPurchases(List<int> item_ids, uint is_radiant_team, bool is_using_dota_plus) : DotaPacket;
public record CMsgSteamLearnNeutralItemPurchase(int item_id, uint tier, uint is_radiant_team, bool is_using_dota_plus) : DotaPacket;
public record CMsgSteamLearnNeutralItemPurchaseV2(uint tier, int trinket_id, int enhancement_id, int previous_trinket_id) : DotaPacket;
public record CMsgSteamLearnAbilitySkill(int ability_id, List<int> skilled_abilities, float game_time, bool is_using_dota_plus) : DotaPacket;
public record CMsgSteamLearnEarlyGameItemPurchasesV2(List<int> item_ids, List<int> other_item_ids) : DotaPacket;
public record CMsgSteamLearnLateGameItemPurchasesV2(List<int> item_ids, List<int> other_item_ids) : DotaPacket;
public record CMsgSteamLearnMainGameItemPurchases(List<int> item_ids) : DotaPacket;
public record CMsgSteamLearnWardPlacement(CMsgSteamLearnWardPlacement.Location ward_loc, List<CMsgSteamLearnWardPlacement.Location> existing_ward_locs, uint team) : DotaPacket
{
    public record Location(float x, float y);
}
public record CMsgSteamLearnPlayerMatchState(uint net_worth, uint level, uint deaths, uint respawn_time, bool has_buyback, bool has_aegis, bool has_rapier, uint team_net_worth, uint enemy_team_net_worth, uint team_kills, uint enemy_team_kills, float game_time) : DotaPacket;
public record CMsgSignOutMuertaMinigame(byte[] event_game_data) : DotaPacket;
public record CMsgSignOutMapStats(List<CMsgSignOutMapStats.Player> players, CMsgMapStatsSnapshot global_stats) : DotaPacket
{
    public record Player(uint account_id, CMsgMapStatsSnapshot personal_stats);
}
public record CMsgServerToGCNewBloomGift(uint defindex, uint gifter_account_id, List<uint> target_account_ids) : DotaPacket;
public record CMsgServerToGCNewBloomGiftResponse(ENewBloomGiftingResponse result, List<uint> received_account_ids) : DotaPacket;
public record CMsgSignOutOverworld(List<CMsgSignOutOverworld.Player> players, EEvent event_id) : DotaPacket
{
    public record Player(uint account_id, uint overworld_id, List<uint> desired_token_rewards);
}
public record CMsgSignOutCraftworks(List<CMsgSignOutCraftworks.Player> players, EEvent event_id) : DotaPacket
{
    public record Player(uint account_id, CMsgCraftworksComponents components);
}
