namespace Tranquil.Schema;

public record CDOTAMatchMetadataFile(int version, ulong match_id, CDOTAMatchMetadata metadata, bool unused4, byte[] private_metadata) : DotaPacket;
public record CDOTAMatchMetadata(List<CDOTAMatchMetadata.Team> teams, bool unused2, long SF2lobby_id, long SF2report_until_time, byte[] event_game_custom_table, uint primary_event_id, bool unused7, CMsgMatchMatchmakingStats matchmaking_stats, CMvpData mvp_data, List<CDOTAMatchMetadata.GuildChallengeProgress> guild_challenge_progress, byte[] custom_post_game_table, List<CDOTAMatchMetadata.Tip> match_tips, List<CMsgTrackedStat> match_tracked_stats) : DotaPacket
{
    public record EconItem(uint def_index, uint quality, List<CSOEconItemAttribute> attribute, uint style, List<CSOEconItemEquipped> equipped_state);
    public record Team(uint dota_team, List<CDOTAMatchMetadata.Team.Player> players, List<float> graph_experience, List<float> graph_gold_earned, List<float> graph_net_worth, bool cm_first_pick, int cm_captain_player_id, bool unused8, bool unused9, uint cm_penalty, List<CMsgTrackedStat> team_tracked_stats)
    {
        public record PlayerKill(uint victim_slot, uint count);
        public record ItemPurchase(int item_id, int purchase_time);
        public record InventorySnapshot(List<int> item_id, int game_time, uint kills, uint deaths, uint assists, uint level, List<int> backpack_item_id, int neutral_item_id, int neutral_enhancement_id);
        public record AutoStyleCriteria(uint name_token, float value);
        public record StrangeGemProgress(uint kill_eater_type, uint gem_item_def_index, int required_hero_id, uint starting_value, uint ending_value, uint owner_item_def_index, ulong owner_item_id);
        public record VictoryPrediction(ulong item_id, uint item_def_index, uint starting_value, bool is_victory);
        public record SubChallenge(uint slot_id, uint start_value, uint end_value, bool completed);
        public record CavernChallengeResult(uint completed_path_id, uint claimed_room_id);
        public record ActionGrant(uint action_id, uint quantity, uint audit, bool unused4, ulong audit_data);
        public record CandyGrant(uint points, uint reason);
        public record PeriodicResourceData(uint periodic_resource_id, uint remaining, uint max);
        public record EventData(uint event_id, uint event_points, uint challenge_instance_id, uint challenge_quest_id, uint challenge_quest_challenge_id, bool challenge_completed, uint challenge_rank_completed, uint challenge_rank_previously_completed, bool event_owned, List<CDOTAMatchMetadata.Team.SubChallenge> sub_challenges_with_progress, uint wager_winnings, bool cavern_challenge_active, uint cavern_challenge_winnings, uint amount_wagered, bool unused15, uint periodic_point_adjustments, List<CDOTAMatchMetadata.Team.CavernChallengeResult> cavern_challenge_map_results, uint cavern_challenge_plus_shard_winnings, List<CDOTAMatchMetadata.Team.ActionGrant> actions_granted, uint cavern_crawl_map_variant, uint team_wager_bonus_pct, uint wager_streak_pct, List<CDOTAMatchMetadata.Team.CandyGrant> candy_points_granted, uint active_season_id, bool cavern_crawl_half_credit, List<CDOTAMatchMetadata.Team.PeriodicResourceData> periodic_resources, List<CExtraMsgBlock> extra_event_messages);
        public record FeaturedGamemodeProgress(uint start_value, uint end_value, uint max_value);
        public record Player(bool unused1, List<int> ability_upgrades, uint player_slot, bool unused4, List<CDOTAMatchMetadata.Team.PlayerKill> kills, List<CDOTAMatchMetadata.Team.ItemPurchase> items, uint avg_kills_x16, uint avg_deaths_x16, uint avg_assists_x16, uint avg_gpm_x16, uint avg_xpm_x16, uint best_kills_x16, uint best_assists_x16, uint best_gpm_x16, uint best_xpm_x16, uint win_streak, uint best_win_streak, float fight_score, float farm_score, float support_score, float push_score, List<uint> level_up_times, List<float> graph_net_worth, List<CDOTAMatchMetadata.Team.InventorySnapshot> inventory_snapshot, bool avg_stats_calibrated, List<CDOTAMatchMetadata.Team.AutoStyleCriteria> auto_style_criteria, bool unused27, bool unused28, List<CDOTAMatchMetadata.Team.EventData> event_data, List<CDOTAMatchMetadata.Team.StrangeGemProgress> strange_gem_progress, uint hero_xp, uint camps_stacked, List<CDOTAMatchMetadata.Team.VictoryPrediction> victory_prediction, uint lane_selection_flags, uint rampages, uint triple_kills, uint aegis_snatched, uint rapiers_purchased, uint couriers_killed, uint net_worth_rank, uint support_gold_spent, uint observer_wards_placed, uint sentry_wards_placed, uint wards_dewarded, float stun_duration, EDOTAMMRBoostType rank_mmr_boost_type, bool unused47, List<CDOTAMatchMetadata.Team.Player.ContractProgress> contract_progress, List<uint> guild_ids, List<float> graph_hero_damage, DOTA_GC_TEAM team_number, uint team_slot, CDOTAMatchMetadata.Team.FeaturedGamemodeProgress featured_gamemode_progress, uint featured_hero_sticker_index, uint featured_hero_sticker_quality, List<CDOTAMatchMetadata.EconItem> equipped_econ_items, int game_player_id, List<CMsgTrackedStat> player_tracked_stats, CDOTAMatchMetadata.Team.Player.OverworldRewards overworld_rewards, List<CMsgCraftworksQuestReward> craftworks_quest_rewards)
        {
            public record ContractProgress(uint guild_id, uint event_id, uint challenge_instance_id, uint challenge_parameter, uint contract_stars, uint contract_slot, bool completed);
            public record OverworldRewards(uint overworld_id, CMsgOverworldTokenQuantity tokens);
        }
    }
    public record GuildChallengeProgress(uint guild_id, EEvent event_id, uint challenge_instance_id, uint challenge_parameter, uint challenge_timestamp, uint challenge_progress_at_start, uint challenge_progress_accumulated, List<CDOTAMatchMetadata.GuildChallengeProgress.IndividualProgress> individual_progress)
    {
        public record IndividualProgress(bool unused1, uint progress, uint player_slot);
    }
    public record Tip(uint source_player_slot, uint target_player_slot, uint tip_amount, EEvent event_id);
}
public record CDOTAMatchPrivateMetadata(List<CDOTAMatchPrivateMetadata.Team> teams, List<float> graph_win_probability, List<CDOTAMatchPrivateMetadata.StringName> string_names) : DotaPacket
{
    public record StringName(uint id, string name);
    public record Team(uint dota_team, List<CDOTAMatchPrivateMetadata.Team.Player> players, List<CDOTAMatchPrivateMetadata.Team.Building> buildings)
    {
        public record Player(bool unused1, uint player_slot, byte[] position_stream, List<CDOTAMatchPrivateMetadata.Team.Player.CombatSegment> combat_segments, List<string> damage_unit_names, List<CDOTAMatchPrivateMetadata.Team.Player.BuffRecord> buff_records, List<float> graph_kills, List<float> graph_deaths, List<float> graph_assists, List<float> graph_lasthits, List<float> graph_denies, CDOTAMatchPrivateMetadata.Team.Player.GoldReceived gold_received, CDOTAMatchPrivateMetadata.Team.Player.XPReceived xp_received, DOTA_GC_TEAM team_number, uint team_slot)
        {
            public record CombatSegment(int game_time, List<CDOTAMatchPrivateMetadata.Team.Player.CombatSegment.DamageByAbility> damage_by_ability, List<CDOTAMatchPrivateMetadata.Team.Player.CombatSegment.HealingByAbility> healing_by_ability)
            {
                public record DamageByAbility(int ability_id, List<CDOTAMatchPrivateMetadata.Team.Player.CombatSegment.DamageByAbility.ByHeroTarget> by_hero_targets, uint source_unit_index)
                {
                    public record ByHeroTarget(int hero_id, uint damage);
                }
                public record HealingByAbility(int ability_id, List<CDOTAMatchPrivateMetadata.Team.Player.CombatSegment.HealingByAbility.ByHeroTarget> by_hero_targets, uint source_unit_index)
                {
                    public record ByHeroTarget(int hero_id, uint healing);
                }
            }
            public record BuffRecord(int buff_ability_id, List<CDOTAMatchPrivateMetadata.Team.Player.BuffRecord.ByHeroTarget> by_hero_targets, string buff_modifier_name)
            {
                public record ByHeroTarget(int hero_id, float elapsed_duration, bool is_hidden);
            }
            public record GoldReceived(uint creep, uint heroes, uint bounty_runes, uint passive, uint buildings, uint abilities, uint wards, uint other);
            public record XPReceived(uint creep, uint heroes, uint roshan, uint tome_of_knowledge, uint outpost, uint other, uint abilities);
        }
        public record Building(string unit_name, uint position_quant_x, uint position_quant_y, float death_time);
    }
}
