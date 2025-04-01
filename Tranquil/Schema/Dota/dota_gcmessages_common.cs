namespace Tranquil.Schema;

public enum ESpecialPingValue
{
    k_ESpecialPingValue_NoData = 16382,
    k_ESpecialPingValue_Failed = 16383,
}
public enum EDOTAGCSessionNeed
{
    k_EDOTAGCSessionNeed_Unknown = 0,
    k_EDOTAGCSessionNeed_UserNoSessionNeeded = 100,
    k_EDOTAGCSessionNeed_UserInOnlineGame = 101,
    k_EDOTAGCSessionNeed_UserInLocalGame = 102,
    k_EDOTAGCSessionNeed_UserInUIWasConnected = 103,
    k_EDOTAGCSessionNeed_UserInUINeverConnected = 104,
    k_EDOTAGCSessionNeed_UserTutorials = 105,
    k_EDOTAGCSessionNeed_UserInUIWasConnectedIdle = 106,
    k_EDOTAGCSessionNeed_UserInUINeverConnectedIdle = 107,
    k_EDOTAGCSessionNeed_GameServerOnline = 200,
    k_EDOTAGCSessionNeed_GameServerLocal = 201,
    k_EDOTAGCSessionNeed_GameServerIdle = 202,
    k_EDOTAGCSessionNeed_GameServerRelay = 203,
    k_EDOTAGCSessionNeed_GameServerLocalUpload = 204,
}
public enum EDOTAMatchPlayerTimeCustomStat
{
    k_EDOTA_MatchPlayerTimeCustomStat_HPRegenUnderT1Towers = 1,
    k_EDOTA_MatchPlayerTimeCustomStat_MagicDamageReducedWithNewFormula_Absolute = 2,
    k_EDOTA_MatchPlayerTimeCustomStat_MagicDamageReducedWithNewFormula_PercentOfTotalHP = 3,
}
public enum DOTA_TournamentEvents
{
    TE_FIRST_BLOOD = 0,
    TE_GAME_END = 1,
    TE_MULTI_KILL = 2,
    TE_HERO_DENY = 3,
    TE_AEGIS_DENY = 4,
    TE_AEGIS_STOLEN = 5,
    TE_GODLIKE = 6,
    TE_COURIER_KILL = 7,
    TE_ECHOSLAM = 8,
    TE_RAPIER = 9,
    TE_EARLY_ROSHAN = 10,
    TE_BLACK_HOLE = 11,
}
public enum EBroadcastTimelineEvent
{
    EBroadcastTimelineEvent_MatchStarted = 1,
    EBroadcastTimelineEvent_GameStateChanged = 2,
    EBroadcastTimelineEvent_TowerDeath = 3,
    EBroadcastTimelineEvent_BarracksDeath = 4,
    EBroadcastTimelineEvent_AncientDeath = 5,
    EBroadcastTimelineEvent_RoshanDeath = 6,
    EBroadcastTimelineEvent_HeroDeath = 7,
    EBroadcastTimelineEvent_TeamFight = 8,
    EBroadcastTimelineEvent_FirstBlood = 9,
}
public enum ECustomGameWhitelistState
{
    CUSTOM_GAME_WHITELIST_STATE_UNKNOWN = 0,
    CUSTOM_GAME_WHITELIST_STATE_APPROVED = 1,
    CUSTOM_GAME_WHITELIST_STATE_REJECTED = 2,
}
public enum EDOTATriviaQuestionCategory
{
    k_EDOTATriviaQuestionCategory_AbilityIcon = 0,
    k_EDOTATriviaQuestionCategory_AbilityCooldown = 1,
    k_EDOTATriviaQuestionCategory_HeroAttributes = 2,
    k_EDOTATriviaQuestionCategory_HeroMovementSpeed = 3,
    k_EDOTATriviaQuestionCategory_TalentTree = 4,
    k_EDOTATriviaQuestionCategory_HeroStats = 5,
    k_EDOTATriviaQuestionCategory_ItemPrice = 6,
    k_EDOTATriviaQuestionCategory_AbilitySound = 7,
    k_EDOTATriviaQuestionCategory_InvokerSpells = 8,
    k_EDOTATriviaQuestionCategory_AbilityManaCost = 9,
    k_EDOTATriviaQuestionCategory_HeroAttackSound = 10,
    k_EDOTATriviaQuestionCategory_AbilityName = 11,
    k_EDOTATriviaQuestionCategory_ItemComponents = 12,
    k_EDOTATriviaQuestionCategory_ItemLore = 13,
    k_EDOTATriviaQuestionCategory_ItemPassives = 14,
    k_EDOTATriviaQuestionCategory_STATIC_QUESTIONS_END = 15,
    k_EDOTATriviaQuestionCategory_DYNAMIC_QUESTIONS_START = 99,
    k_EDOTATriviaQuestionCategory_Dynamic_ItemBuild = 100,
}
public enum EOverwatchConviction
{
    k_EOverwatchConviction_None = 0,
    k_EOverwatchConviction_NotGuilty = 1,
    k_EOverwatchConviction_GuiltUnclear = 2,
    k_EOverwatchConviction_Guilty = 3,
}
public enum EHeroRelicRarity
{
    HERO_RELIC_RARITY_INVALID = -1,
    HERO_RELIC_RARITY_COMMON = 0,
    HERO_RELIC_RARITY_RARE = 1,
}
public enum EStickerbookAuditAction
{
    STICKERBOOK_AUDIT_CREATE_PAGE = 0,
    STICKERBOOK_AUDIT_DELETE_PAGE = 1,
    STICKERBOOK_AUDIT_STICK_STICKERS = 2,
    STICKERBOOK_AUDIT_REPLACE_STICKERS = 3,
    STICKERBOOK_AUDIT_HERO_STICKER = 4,
}
public enum EStickerbookPageType
{
    STICKER_PAGE_GENERIC = 0,
    STICKER_PAGE_TEAM = 1,
    STICKER_PAGE_TALENT = 2,
}
public enum ENewBloomGiftingResponse
{
    kENewBloomGifting_Success = 0,
    kENewBloomGifting_UnknownFailure = 1,
    kENewBloomGifting_MalformedRequest = 2,
    kENewBloomGifting_FeatureDisabled = 3,
    kENewBloomGifting_ItemNotFound = 4,
    kENewBloomGifting_PlayerNotAllowedToGiveGifts = 5,
    kENewBloomGifting_TargetNotAllowedToReceiveGifts = 6,
    kENewBloomGifting_ServerNotAuthorized = 100,
    kENewBloomGifting_PlayerNotInLobby = 101,
    kENewBloomGifting_TargetNotInLobby = 102,
    kENewBloomGifting_LobbyNotEligible = 103,
    kENewBloomGifting_TargetNotFriend = 200,
    kENewBloomGifting_TargetFriendDurationTooShort = 201,
}
public record CSODOTAGameAccountClient(uint account_id, bool unused2, uint wins, uint losses, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, bool unused10, bool unused11, uint xp, uint level, uint initial_skill, uint leaver_count, bool unused16, bool unused17, uint low_priority_until_date, bool unused19, uint prevent_text_chat_until_date, uint prevent_voice_until_date, uint last_abandoned_game_date, uint leaver_penalty_count, uint completed_game_streak, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, uint account_disabled_until_date, uint account_disabled_count, bool unused40, uint match_disabled_until_date, uint match_disabled_count, bool unused43, bool unused44, bool unused45, bool unused46, uint shutdownlawterminatetimestamp, uint low_priority_games_remaining, bool unused49, bool unused50, bool unused51, bool unused52, bool unused53, bool unused54, uint recruitment_level, bool has_new_notifications, bool is_league_admin, uint secondary_leaver_count, uint last_secondary_abandoned_game_date, uint casual_games_played, uint solo_competitive_games_played, uint party_competitive_games_played, bool unused63, bool unused64, uint casual_1v1_games_played, bool unused66, int curr_all_hero_challenge_id, uint play_time_points, uint account_flags, uint play_time_level, uint player_behavior_seq_num_last_report, uint player_behavior_score_last_report, bool player_behavior_report_old_data, uint tourney_skill_level, bool unused75, bool unused76, bool unused77, bool unused78, bool unused79, bool unused80, bool unused81, bool unused82, bool unused83, bool unused84, uint tourney_recent_participation_date, uint prevent_public_text_chat_until_date, bool unused87, ulong anchored_phone_number_id, uint ranked_matchmaking_ban_until_date, uint recent_game_time_1, uint recent_game_time_2, uint recent_game_time_3, bool unused93, bool unused94, bool unused95, bool unused96, bool unused97, bool unused98, bool unused99, bool unused100, bool unused101, bool unused102, ulong favorite_team_packed, uint recent_report_time, uint custom_game_disabled_until_date, uint recent_win_time_1, uint recent_win_time_2, uint recent_win_time_3, uint coach_rating, bool unused110, bool unused111, bool unused112, bool unused113, uint queue_points, List<CSODOTAGameAccountClient.RoleHandicap> role_handicaps, bool unused116, bool unused117, bool unused118, bool unused119, uint event_mode_recent_time, uint mmr_recalibration_time, uint prevent_new_player_chat_until_date, List<int> banned_hero_ids) : DotaPacket
{
    public record RoleHandicap(uint role, float handicap);
}
public record CSODOTAGameAccountPlus(uint account_id, uint original_start_date, uint plus_flags, uint plus_status, uint prepaid_time_start, uint prepaid_time_balance, int SF1next_payment_date, long SF2steam_agreement_id) : DotaPacket;
public record CSODOTAChatWheel(uint message_id) : DotaPacket;
public record CMsgLobbyFeaturedGamemodeProgress(List<CMsgLobbyFeaturedGamemodeProgress.AccountProgress> accounts) : DotaPacket
{
    public record AccountProgress(uint account_id, uint current_value, uint max_value);
}
public record CMsgBattleCupVictory(uint account_id, uint win_date, uint valid_until, uint skill_level, uint tournament_id, uint division_id, uint team_id, uint streak, uint trophy_id) : DotaPacket;
public record CMsgLobbyBattleCupVictoryList(List<CMsgBattleCupVictory> winners) : DotaPacket;
public record CMsgDOTABroadcastNotification(string message) : DotaPacket;
public record CProtoItemHeroStatue(int hero_id, uint status_effect_index, string sequence_name, float cycle, List<uint> wearable, string inscription, List<uint> style, bool tournament_drop) : DotaPacket;
public record CMatchPlayerAbilityUpgrade(int ability, uint time) : DotaPacket;
public record CMatchPlayerTimedCustomStat(bool unused1, EDOTAMatchPlayerTimeCustomStat stat, float value) : DotaPacket;
public record CMatchPlayerTimedStats(uint time, uint kills, uint deaths, uint assists, uint net_worth, uint xp, uint last_hits, uint denies, uint bounty_rune_gold, uint range_creep_upgrade_gold, uint observer_wards_dewarded, uint reliable_gold_earned, uint gold_loss_prevented, uint hero_kill_gold, uint creep_kill_gold, uint building_gold, uint other_gold, uint comeback_gold, uint experimental_gold, uint experimental2_gold, uint creep_deny_gold, uint tp_scrolls_purchased_1, uint tp_scrolls_purchased_2, uint tp_scrolls_purchased_3, uint tp_scrolls_purchased_4, uint tp_scrolls_purchased_5, uint neutral_gold, uint courier_gold, uint roshan_gold, uint income_gold, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, uint item_value, uint support_gold_spent, uint camps_stacked, uint wards_placed, uint triple_kills, uint rampages, List<CMatchPlayerTimedCustomStat> custom_stats) : DotaPacket;
public record CMatchTeamTimedStats(uint time, uint enemy_towers_killed, uint enemy_barracks_killed, uint enemy_towers_status, uint enemy_barracks_status) : DotaPacket;
public record CMatchAdditionalUnitInventory(string unit_name, List<int> items) : DotaPacket;
public record CMatchPlayerPermanentBuff(uint permanent_buff, uint stack_count, uint grant_time) : DotaPacket;
public record CMatchHeroSelectEvent(bool is_pick, uint team, int hero_id) : DotaPacket;
public record CMatchClip(ulong match_id, uint player_account_id, uint game_time_seconds, uint duration_seconds, uint player_id, int hero_id, int ability_id, uint camera_mode, string comment) : DotaPacket;
public record CPartySearchClientParty(long SF2party_id, int beacon_type, List<int> SF1party_members) : DotaPacket;
public record CMsgDOTAHasItemQuery(uint account_id, ulong item_id) : DotaPacket;
public record CMsgDOTAHasItemResponse(bool has_item) : DotaPacket;
public record CMsgGCGetPlayerCardItemInfo(uint account_id, List<ulong> player_card_item_ids, uint all_for_event) : DotaPacket;
public record CMsgGCGetPlayerCardItemInfoResponse(List<CMsgGCGetPlayerCardItemInfoResponse.PlayerCardInfo> player_card_infos) : DotaPacket
{
    public record PlayerCardInfo(ulong player_card_item_id, uint account_id, ulong packed_bonuses);
}
public record CSODOTAMapLocationState(uint account_id, int location_id, bool completed) : DotaPacket;
public record CMsgLeagueAdminList(List<uint> account_ids) : DotaPacket;
public record CMsgDOTAProfileCard(uint account_id, bool unused2, List<CMsgDOTAProfileCard.Slot> slots, uint badge_points, bool unused5, uint event_id, CMsgBattleCupVictory recent_battle_cup_victory, uint rank_tier, uint leaderboard_rank, bool is_plus_subscriber, uint plus_original_start_date, uint rank_tier_score, bool unused13, bool unused14, bool unused15, bool unused16, uint leaderboard_rank_core, bool unused18, bool unused19, bool unused20, bool unused21, bool unused22, uint title, ulong favorite_team_packed, uint lifetime_games, uint event_level) : DotaPacket
{
    public enum EStatID
    {
        k_eStat_Wins = 3,
        k_eStat_Commends = 4,
        k_eStat_GamesPlayed = 5,
        k_eStat_FirstMatchDate = 6,
        k_eStat_PreviousSeasonRank = 7,
        k_eStat_GamesMVP = 8,
    }
    public record Slot(uint slot_id, CMsgDOTAProfileCard.Slot.Trophy trophy, CMsgDOTAProfileCard.Slot.Stat stat, CMsgDOTAProfileCard.Slot.Item item, CMsgDOTAProfileCard.Slot.Hero hero, CMsgDOTAProfileCard.Slot.Emoticon emoticon, CMsgDOTAProfileCard.Slot.Team team)
    {
        public record Trophy(uint trophy_id, uint trophy_score);
        public record Stat(CMsgDOTAProfileCard.EStatID stat_id, uint stat_score);
        public record Item(byte[] serialized_item, ulong item_id);
        public record Hero(int hero_id, uint hero_wins, uint hero_losses);
        public record Emoticon(uint emoticon_id);
        public record Team(uint team_id);
    }
}
public record CSODOTAPlayerChallenge(uint account_id, uint event_id, uint slot_id, bool unused4, uint int_param_0, uint int_param_1, uint created_time, uint completed, uint sequence_id, uint challenge_tier, uint flags, uint attempts, uint complete_limit, uint quest_rank, uint max_quest_rank, uint instance_id, int hero_id, uint template_id) : DotaPacket;
public record CMsgClientToGCRerollPlayerChallenge(EEvent event_id, bool unused2, uint sequence_id, int hero_id) : DotaPacket;
public record CMsgGCRerollPlayerChallengeResponse(CMsgGCRerollPlayerChallengeResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        eResult_Success = 0,
        eResult_Dropped = 1,
        eResult_NotFound = 2,
        eResult_CantReroll = 3,
        eResult_ServerError = 4,
    }
}
public record CMsgGCTopCustomGamesList(List<ulong> top_custom_games, ulong game_of_the_day) : DotaPacket;
public record CMsgDOTARealtimeGameStats(CMsgDOTARealtimeGameStats.MatchDetails match, List<CMsgDOTARealtimeGameStats.TeamDetails> teams, List<CMsgDOTARealtimeGameStats.BuildingDetails> buildings, CMsgDOTARealtimeGameStats.GraphData graph_data, bool delta_frame) : DotaPacket
{
    public record TeamDetails(uint team_number, uint team_id, string team_name, long SF2team_logo, uint score, List<CMsgDOTARealtimeGameStats.PlayerDetails> players, bool only_team, uint cheers, uint net_worth, string team_tag, string team_logo_url);
    public record ItemDetails(int item_ability_id, string name, int time, bool sold, uint stackcount);
    public record AbilityDetails(int id, string name, uint level, float cooldown, float cooldown_max);
    public record HeroToHeroStats(int victimid, uint kills, uint assists);
    public record AbilityList(List<int> id);
    public record PlayerDetails(uint accountid, int playerid, string name, uint team, int heroid, uint healthpoints, uint maxhealthpoints, float healthregenrate, uint manapoints, uint maxmanapoints, float manaregenrate, uint base_strength, uint base_agility, uint base_intelligence, int base_armor, uint base_movespeed, uint base_damage, uint strength, uint agility, uint intelligence, int armor, uint movespeed, uint damage, uint hero_damage, uint tower_damage, List<CMsgDOTARealtimeGameStats.AbilityDetails> abilities, uint level, uint kill_count, uint death_count, uint assists_count, uint denies_count, uint lh_count, uint hero_healing, uint gold_per_min, uint xp_per_min, uint net_gold, uint gold, float x, float y, int respawn_time, uint ultimate_cooldown, bool has_buyback, List<CMsgDOTARealtimeGameStats.ItemDetails> items, List<CMsgDOTARealtimeGameStats.ItemDetails> stashitems, List<CMsgDOTARealtimeGameStats.ItemDetails> itemshoppinglist, List<CMsgDOTARealtimeGameStats.AbilityList> levelpoints, List<CMsgDOTARealtimeGameStats.HeroToHeroStats> hero_to_hero_stats, bool has_ultimate, bool has_ultimate_mana, uint team_slot);
    public record BuildingDetails(bool unused1, uint team, float heading, uint lane, uint tier, uint type, float x, float y, bool destroyed);
    public record KillDetails(int player_id, int death_time, int killer_player_id);
    public record BroadcasterDetails(int player_id);
    public record PickBanDetails(int hero, uint team);
    public record MatchDetails(long SF2server_steam_id, ulong match_id, uint timestamp, float time_of_day, bool is_nightstalker_night, int game_time, bool unused7, uint teamid_radiant, uint teamid_dire, List<CMsgDOTARealtimeGameStats.PickBanDetails> picks, List<CMsgDOTARealtimeGameStats.PickBanDetails> bans, List<CMsgDOTARealtimeGameStats.KillDetails> kills, List<CMsgDOTARealtimeGameStats.BroadcasterDetails> broadcasters, uint game_mode, uint league_id, bool single_team, uint cheers_peak, uint league_node_id, uint game_state, uint lobby_type, uint start_timestamp, bool is_player_draft);
    public record GraphData(List<int> graph_gold, List<int> graph_xp, List<int> graph_kill, List<int> graph_tower, List<int> graph_rax, List<CMsgDOTARealtimeGameStats.GraphData.TeamLocationStats> team_loc_stats)
    {
        public enum eStat
        {
            CreepGoldEarned = 0,
            KillGoldEarned = 1,
            DeathAndBuybackGoldLost = 2,
            XPEarned = 3,
        }
        public enum eLocation
        {
            BotLane = 0,
            MidLane = 1,
            TopLane = 2,
            Jungle = 3,
            Ancients = 4,
            Other = 5,
        }
        public record LocationStats(List<int> stats);
        public record TeamLocationStats(List<CMsgDOTARealtimeGameStats.GraphData.LocationStats> loc_stats);
    }
}
public record CMsgDOTARealtimeGameStatsTerse(CMsgDOTARealtimeGameStatsTerse.MatchDetails match, List<CMsgDOTARealtimeGameStatsTerse.TeamDetails> teams, List<CMsgDOTARealtimeGameStatsTerse.BuildingDetails> buildings, CMsgDOTARealtimeGameStatsTerse.GraphData graph_data, bool delta_frame) : DotaPacket
{
    public record TeamDetails(uint team_number, uint team_id, string team_name, long SF2team_logo, uint score, List<CMsgDOTARealtimeGameStatsTerse.PlayerDetails> players, uint net_worth, string team_tag, string team_logo_url);
    public record PlayerDetails(uint accountid, int playerid, string name, uint team, int heroid, uint level, uint kill_count, uint death_count, uint assists_count, uint denies_count, uint lh_count, uint gold, float x, float y, uint net_worth, List<int> abilities, List<int> items, uint team_slot);
    public record BuildingDetails(uint team, float heading, uint type, uint lane, uint tier, float x, float y, bool destroyed);
    public record PickBanDetails(int hero, uint team);
    public record MatchDetails(long SF2server_steam_id, ulong match_id, uint timestamp, int game_time, bool unused5, List<uint> steam_broadcaster_account_ids, uint game_mode, uint league_id, uint league_node_id, uint game_state, List<CMsgDOTARealtimeGameStatsTerse.PickBanDetails> picks, List<CMsgDOTARealtimeGameStatsTerse.PickBanDetails> bans, uint lobby_type, uint start_timestamp, bool is_player_draft);
    public record GraphData(List<int> graph_gold);
}
public record CMsgDOTABroadcastTimelineEvent(EBroadcastTimelineEvent _event, int SF1timestamp, uint data, string string_data) : DotaPacket;
public record CMsgGCToClientMatchGroupsVersion(uint matchgroups_version) : DotaPacket;
public record CMsgDOTASDOHeroStatsHistory(ulong match_id, uint game_mode, uint lobby_type, uint start_time, bool won, uint gpm, uint xpm, uint kills, uint deaths, uint assists) : DotaPacket;
public record CMsgPredictionChoice(uint value, string name, uint min_raw_value, uint max_raw_value) : DotaPacket;
public record CMsgInGamePrediction(uint id, string name, CMsgInGamePrediction.EPredictionType type, CMsgInGamePrediction.ERandomSelectionGroup_t group, string question, List<CMsgPredictionChoice> choices, List<string> required_heroes, string query_name, List<CMsgInGamePrediction.QueryKeyValues> query_values, CMsgInGamePrediction.EResolutionType_t answer_resolution_type, uint points_to_grant, uint reward_action, uint debug_force_selection, CMsgInGamePrediction.ERawValueType_t raw_value_type) : DotaPacket
{
    public enum ERawValueType_t
    {
        Number = 0,
        Time = 1,
    }
    public enum EPredictionType
    {
        Generic = 0,
        Hero = 1,
        Team = 2,
        Player = 3,
        Special = 4,
        YesNo = 5,
        QualifiersTeam = 6,
    }
    public enum EResolutionType_t
    {
        InvalidQuery = 0,
        FirstToPassQuery = 1,
        LastToPassQuery = 2,
        LastRemainingQuery = 3,
        MaxToPassQuery = 4,
        MinToPassQuery = 5,
        SumQuery = 6,
        MaxTeamSumToPassQuery = 7,
        MinTeamSumToPassQuery = 8,
    }
    public enum ERandomSelectionGroup_t
    {
        EarlyGame = 0,
        MidGame = 1,
        LateGame = 2,
        Count = 3,
    }
    public record QueryKeyValues(string name, string value);
}
public record CMsgDOTASeasonPredictions(List<CMsgDOTASeasonPredictions.Prediction> predictions, List<CMsgInGamePrediction> in_game_predictions, uint in_game_prediction_count_per_game, uint in_game_prediction_voting_period_minutes) : DotaPacket
{
    public record Prediction(CMsgDOTASeasonPredictions.Prediction.EPredictionType type, string question, List<CMsgPredictionChoice> choices, uint selection_id, uint start_date, uint lock_date, uint reward, CMsgDOTASeasonPredictions.Prediction.EAnswerType answer_type, uint answer_id, List<CMsgDOTASeasonPredictions.Prediction.Answers> answers, string query_name, bool unused12, uint lock_on_selection_id, uint lock_on_selection_value, bool lock_on_selection_set, bool use_answer_value_ranges, ELeagueRegion region, List<ELeaguePhase> phases, EEvent reward_event, uint league_node_id)
    {
        public enum EPredictionType
        {
            Generic = 0,
            Hero = 1,
            Team = 2,
            Player = 3,
            Special = 4,
            YesNo = 5,
            QualifiersTeam = 6,
            LastChanceTeam = 7,
        }
        public enum EAnswerType
        {
            SingleInt = 0,
            SingleFloat = 1,
            MultipleInt = 2,
            MultipleFloat = 3,
            AnswerTeam = 4,
            SingleTime = 5,
            MultipleTime = 6,
            NoAnswer = 7,
        }
        public record Answers(uint answer_id);
    }
}
public record CMsgAvailablePredictions(List<CMsgAvailablePredictions.MatchPrediction> match_predictions) : DotaPacket
{
    public record MatchPrediction(ulong match_id, List<CMsgInGamePrediction> predictions);
}
public record CMsgLeagueWatchedGames(List<CMsgLeagueWatchedGames.League> leagues) : DotaPacket
{
    public record Series(uint node_id, List<uint> game);
    public record League(uint league_id, List<CMsgLeagueWatchedGames.Series> series);
}
public record CMsgDOTAMatch(bool unused1, bool unused2, uint duration, int SF1starttime, List<CMsgDOTAMatch.Player> players, ulong match_id, bool unused7, List<uint> tower_status, List<uint> barracks_status, uint cluster, bool unused11, uint first_blood_time, int SF1replay_salt, int SF1server_ip, uint server_port, uint lobby_type, uint human_players, uint average_skill, float game_balance, uint radiant_team_id, uint dire_team_id, uint leagueid, string radiant_team_name, string dire_team_name, ulong radiant_team_logo, ulong dire_team_logo, uint radiant_team_complete, uint dire_team_complete, bool unused29, bool unused30, DOTA_GameMode game_mode, List<CMatchHeroSelectEvent> picks_bans, ulong match_seq_num, CMsgDOTAMatch.ReplayState replay_state, uint radiant_guild_id, uint dire_guild_id, string radiant_team_tag, string dire_team_tag, uint series_id, uint series_type, bool unused41, bool unused42, List<CMsgDOTAMatch.BroadcasterChannel> broadcaster_channels, uint engine, CMsgDOTAMatch.CustomGameData custom_game_data, uint match_flags, int SF1private_metadata_key, uint radiant_team_score, uint dire_team_score, EMatchOutcome match_outcome, uint tournament_id, uint tournament_round, uint pre_game_duration, string radiant_team_logo_url, string dire_team_logo_url, bool unused56, List<CMsgDOTAMatch.Coach> coaches) : DotaPacket
{
    public enum ReplayState
    {
        REPLAY_AVAILABLE = 0,
        REPLAY_NOT_RECORDED = 1,
        REPLAY_EXPIRED = 2,
    }
    public record Player(uint account_id, uint player_slot, int hero_id, int item_0, int item_1, int item_2, int item_3, int item_4, int item_5, float expected_team_contribution, float scaled_metric, uint previous_rank, int SS1rank_change, uint kills, uint deaths, uint assists, uint leaver_status, uint gold, uint last_hits, uint denies, uint gold_per_min, uint xp_per_min, uint gold_spent, uint hero_damage, uint tower_damage, uint hero_healing, uint level, uint time_last_seen, string player_name, uint support_ability_value, bool unused31, bool feeding_detected, bool unused33, uint search_rank, uint search_rank_uncertainty, int rank_uncertainty_change, uint hero_play_count, long SF2party_id, float scaled_kills, float scaled_deaths, float scaled_assists, uint claimed_farm_gold, uint support_gold, uint claimed_denies, uint claimed_misses, uint misses, List<CMatchPlayerAbilityUpgrade> ability_upgrades, List<CMatchAdditionalUnitInventory> additional_units_inventory, bool unused49, CMsgDOTAMatch.Player.CustomGameData custom_game_data, bool active_plus_subscription, uint net_worth, bool unused53, uint scaled_hero_damage, uint scaled_tower_damage, uint scaled_hero_healing, List<CMatchPlayerPermanentBuff> permanent_buffs, uint bot_difficulty, int item_6, int item_7, int item_8, bool unused62, uint hero_pick_order, bool hero_was_randomed, bool unused65, bool unused66, List<CMsgDOTAMatch.Player.HeroDamageReceived> hero_damage_received, bool unused68, bool hero_was_dota_plus_suggestion, uint seconds_dead, uint gold_lost_to_death, string pro_name, string real_name, uint mmr_type, uint lane_selection_flags, int item_9, uint bounty_runes, uint outposts_captured, List<CMsgDOTAMatch.Player.HeroDamageReceived> hero_damage_dealt, DOTA_GC_TEAM team_number, uint team_slot, uint selected_facet, int item_10, int item_10_lvl)
    {
        public enum HeroDamageType
        {
            HERO_DAMAGE_PHYSICAL = 0,
            HERO_DAMAGE_MAGICAL = 1,
            HERO_DAMAGE_PURE = 2,
        }
        public record CustomGameData(uint dota_team, bool winner);
        public record HeroDamageReceived(uint pre_reduction, uint post_reduction, CMsgDOTAMatch.Player.HeroDamageType damage_type);
    }
    public record BroadcasterInfo(uint account_id, string name);
    public record BroadcasterChannel(string country_code, string description, List<CMsgDOTAMatch.BroadcasterInfo> broadcaster_infos, string language_code);
    public record Coach(uint account_id, string coach_name, uint coach_rating, uint coach_team, ulong coach_party_id, bool is_private_coach);
    public record CustomGameData(ulong custom_game_id, string map_name);
}
public record CMsgPlayerCard(uint account_id, List<CMsgPlayerCard.StatModifier> stat_modifier) : DotaPacket
{
    public record StatModifier(uint stat, uint value);
}
public record CMsgDOTAFantasyPlayerStats(uint player_account_id, ulong match_id, bool match_completed, uint team_id, uint league_id, uint delay, uint series_id, uint series_type, bool unused9, uint kills, uint deaths, uint cs, float gpm, uint tower_kills, uint roshan_kills, float teamfight_participation, uint wards_placed, uint camps_stacked, uint runes_grabbed, uint first_blood, float stuns, uint smokes, uint neutral_tokens, uint watchers, uint lotuses, uint tormentors, uint courier_kills, long SF2title_stats) : DotaPacket;
public record CMsgDOTAFantasyPlayerMatchStats(List<CMsgDOTAFantasyPlayerStats> matches) : DotaPacket;
public record CMsgDOTABotDebugInfo(List<CMsgDOTABotDebugInfo.Bot> bots, float desire_push_lane_top, float desire_push_lane_mid, float desire_push_lane_bot, float desire_defend_lane_top, float desire_defend_lane_mid, float desire_defend_lane_bot, float desire_farm_lane_top, float desire_farm_lane_mid, float desire_farm_lane_bot, float desire_farm_roshan, float execution_time, List<uint> rune_status) : DotaPacket
{
    public record Bot(int player_owner_id, int hero_id, uint difficulty, uint power_current, uint power_max, uint move_target_x, uint move_target_y, uint move_target_z, uint active_mode_id, float execution_time, List<CMsgDOTABotDebugInfo.Bot.Mode> modes, CMsgDOTABotDebugInfo.Bot.Action action)
    {
        public record Mode(uint mode_id, float desire, int target_entity, uint target_x, uint target_y, uint target_z);
        public record Action(uint action_id, string action_target);
    }
}
public record CMsgSuccessfulHero(int hero_id, float win_percent, uint longest_streak) : DotaPacket;
public record CMsgRecentMatchInfo(ulong match_id, DOTA_GameMode game_mode, uint kills, uint deaths, uint assists, uint duration, uint player_slot, EMatchOutcome match_outcome, uint timestamp, uint lobby_type, uint team_number) : DotaPacket;
public record CMsgMatchTips(bool unused1, List<CMsgMatchTips.SingleTip> tips) : DotaPacket
{
    public record SingleTip(uint source_account_id, uint target_account_id, uint tip_amount, EEvent event_id);
}
public record CMsgDOTAMatchMinimal(ulong match_id, int SF1start_time, uint duration, DOTA_GameMode game_mode, bool unused5, List<CMsgDOTAMatchMinimal.Player> players, CMsgDOTAMatchMinimal.Tourney tourney, EMatchOutcome match_outcome, uint radiant_score, uint dire_score, uint lobby_type) : DotaPacket
{
    public record Player(uint account_id, int hero_id, uint kills, uint deaths, uint assists, List<int> items, uint player_slot, string pro_name, uint level, DOTA_GC_TEAM team_number);
    public record Tourney(uint league_id, uint radiant_team_id, string radiant_team_name, long SF2radiant_team_logo, uint dire_team_id, string dire_team_name, long SF2dire_team_logo, uint series_type, uint series_game, uint weekend_tourney_tournament_id, uint weekend_tourney_season_trophy_id, uint weekend_tourney_division, uint weekend_tourney_skill_level, string radiant_team_logo_url, string dire_team_logo_url);
}
public record CMsgConsumableUsage(uint item_def, int quantity_change) : DotaPacket;
public record CMsgMatchConsumableUsage(List<CMsgMatchConsumableUsage.PlayerUsage> player_consumables_used) : DotaPacket
{
    public record PlayerUsage(uint account_id, List<CMsgConsumableUsage> consumables_used);
}
public record CMsgMatchEventActionGrants(List<CMsgMatchEventActionGrants.PlayerGrants> player_grants) : DotaPacket
{
    public record PlayerGrants(uint account_id, bool unused2, List<CMsgPendingEventAward> actions_granted);
}
public record CMsgCustomGameWhitelist(uint version, List<ulong> custom_games_whitelist, bool disable_whitelist) : DotaPacket;
public record CMsgCustomGameWhitelistForEdit(List<CMsgCustomGameWhitelistForEdit.WhitelistEntry> whitelist_entries) : DotaPacket
{
    public record WhitelistEntry(ulong custom_game_id, ECustomGameWhitelistState whitelist_state);
}
public record CMsgPlayerRecentMatchInfo(ulong match_id, uint timestamp, uint duration, bool win, int hero_id, uint kills, uint deaths, uint assists) : DotaPacket;
public record CMsgPlayerMatchRecord(uint wins, uint losses) : DotaPacket;
public record CMsgPlayerRecentMatchOutcomes(uint outcomes, uint match_count) : DotaPacket;
public record CMsgPlayerRecentCommends(uint commends, uint match_count) : DotaPacket;
public record CMsgPlayerRecentAccomplishments(CMsgPlayerRecentMatchOutcomes recent_outcomes, CMsgPlayerMatchRecord total_record, uint prediction_streak, uint plus_prediction_streak, CMsgPlayerRecentCommends recent_commends, uint first_match_timestamp, CMsgPlayerRecentMatchInfo last_match, CMsgPlayerRecentMatchOutcomes recent_mvps) : DotaPacket;
public record CMsgPlayerHeroRecentAccomplishments(CMsgPlayerRecentMatchOutcomes recent_outcomes, CMsgPlayerMatchRecord total_record, CMsgPlayerRecentMatchInfo last_match) : DotaPacket;
public record CMsgRecentAccomplishments(CMsgPlayerRecentAccomplishments player_accomplishments, CMsgPlayerHeroRecentAccomplishments hero_accomplishments) : DotaPacket;
public record CMsgServerToGCRequestPlayerRecentAccomplishments(uint account_id, int hero_id) : DotaPacket;
public record CMsgServerToGCRequestPlayerRecentAccomplishmentsResponse(CMsgServerToGCRequestPlayerRecentAccomplishmentsResponse.EResponse result, CMsgRecentAccomplishments player_accomplishments) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgArcanaVoteMatchVotes(uint match_id, int hero_id, uint vote_count) : DotaPacket;
public record CMsgGCtoGCAssociatedExploiterAccountInfo(uint account_id, uint num_matches_to_search, uint min_shared_match_count, uint num_additional_players) : DotaPacket;
public record CMsgGCtoGCAssociatedExploiterAccountInfoResponse(List<CMsgGCtoGCAssociatedExploiterAccountInfoResponse.Account> accounts) : DotaPacket
{
    public record Account(uint account_id, uint num_common_matches, uint earliest_common_match, uint latest_common_match, uint generation, string persona, bool already_banned);
}
public record CMsgPullTabsData(List<CMsgPullTabsData.Slot> slots, List<CMsgPullTabsData.Jackpot> jackpots, uint last_board) : DotaPacket
{
    public record Slot(uint event_id, uint board_id, int hero_id, uint action_id, bool redeemed);
    public record Jackpot(uint board_id, uint action_id, int hero_id);
}
public record CMsgUnderDraftData(List<CMsgUnderDraftData.BenchSlot> bench_slots, List<CMsgUnderDraftData.ShopSlot> shop_slots, uint gold, uint total_gold, bool not_restorable) : DotaPacket
{
    public record BenchSlot(uint slot_id, int hero_id, uint stars);
    public record ShopSlot(uint slot_id, int hero_id, bool is_special_reward);
}
public record CMsgPlayerTitleData(List<uint> title, List<uint> event_id, uint active) : DotaPacket;
public record CMsgDOTATriviaQuestion(uint question_id, EDOTATriviaQuestionCategory category, uint timestamp, string question_value, List<string> answer_values, uint correct_answer_index) : DotaPacket;
public record CMsgDOTATriviaQuestionAnswersSummary(bool summary_available, List<uint> picked_count) : DotaPacket;
public record CMsgGameDataSpecialValueBonus(string name, float value, uint operation) : DotaPacket;
public record CMsgGameDataSpecialValues(string name, List<float> values_float, bool unused3, bool is_percentage, string heading_loc, List<CMsgGameDataSpecialValueBonus> bonuses, List<float> values_shard, List<float> values_scepter, CMsgGameDataFacetAbilityBonus facet_bonus, string required_facet) : DotaPacket;
public record CMsgGameDataFacetAbilityBonus(string name, List<float> values, uint operation) : DotaPacket;
public record CMsgGameDataAbilityOrItem(int id, string name, bool unused3, bool unused4, string name_loc, string desc_loc, string lore_loc, List<string> notes_loc, string shard_loc, string scepter_loc, List<string> facets_loc, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, uint type, ulong behavior, uint target_team, uint target_type, uint flags, uint damage, uint immunity, uint dispellable, uint max_level, bool unused29, List<uint> cast_ranges, List<float> cast_points, List<float> channel_times, List<float> cooldowns, List<float> durations, List<uint> damages, List<uint> mana_costs, List<uint> gold_costs, List<uint> health_costs, bool unused39, List<CMsgGameDataSpecialValues> special_values, bool unused41, bool unused42, bool unused43, bool unused44, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, bool is_item, bool unused51, bool unused52, bool unused53, bool unused54, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, bool ability_has_scepter, bool ability_has_shard, bool ability_is_granted_by_scepter, bool ability_is_granted_by_shard, bool ability_is_innate, bool unused65, bool unused66, bool unused67, bool unused68, bool unused69, uint item_cost, uint item_initial_charges, uint item_neutral_tier, uint item_stock_max, float item_stock_time, bool unused75, bool unused76, bool unused77, bool unused78, bool unused79, bool unused80, bool unused81, bool unused82, bool unused83, bool unused84, uint item_quality) : DotaPacket;
public record CMsgGameDataAbilityOrItemList(List<CMsgGameDataAbilityOrItem> abilities) : DotaPacket;
public record CMsgGameDataHero(int id, string name, uint order_id, bool unused4, string name_loc, string bio_loc, string hype_loc, string npe_desc_loc, bool unused9, uint str_base, float str_gain, uint agi_base, float agi_gain, uint int_base, float int_gain, bool unused16, bool unused17, bool unused18, bool unused19, uint primary_attr, uint complexity, uint attack_capability, List<uint> role_levels, int damage_min, int damage_max, float attack_rate, uint attack_range, uint projectile_speed, float armor, uint magic_resistance, uint movement_speed, float turn_rate, uint sight_range_day, uint sight_range_night, uint max_health, float health_regen, uint max_mana, float mana_regen, bool unused39, List<CMsgGameDataAbilityOrItem> abilities, List<CMsgGameDataAbilityOrItem> talents, List<CMsgGameDataAbilityOrItemList> facet_abilities, List<CMsgGameDataHero.Facet> facets) : DotaPacket
{
    public record Facet(uint color, string title_loc, string description_loc, string name, string icon, int gradient_id);
}
public record CMsgGameDataAbilities(List<CMsgGameDataAbilityOrItem> abilities) : DotaPacket;
public record CMsgGameDataItems(List<CMsgGameDataAbilityOrItem> items) : DotaPacket;
public record CMsgGameDataHeroes(List<CMsgGameDataHero> heroes) : DotaPacket;
public record CMsgGameDataHeroList(List<CMsgGameDataHeroList.HeroInfo> heroes) : DotaPacket
{
    public record HeroInfo(int id, string name, string name_loc, string name_english_loc, uint primary_attr, uint complexity);
}
public record CMsgGameDataItemAbilityList(List<CMsgGameDataItemAbilityList.ItemAbilityInfo> itemabilities) : DotaPacket
{
    public record ItemAbilityInfo(int id, string name, string name_loc, string name_english_loc, int neutral_item_tier, bool is_pregame_suggested, bool is_earlygame_suggested, bool is_lategame_suggested, List<CMsgGameDataItemAbilityList.ItemAbilityInfo.Recipe> recipes)
    {
        public record Recipe(List<int> items);
    }
}
public record CMsgLobbyAbilityDraftData(bool shuffle_draft_order) : DotaPacket;
public record CSOEconItemDropRateBonus(uint account_id, int SF1expiration_date, float bonus, uint bonus_count, ulong item_id, uint def_index, uint seconds_left, uint booster_type) : DotaPacket;
public record CSOEconItemTournamentPassport(uint account_id, uint league_id, ulong item_id, uint original_purchaser_id, uint passports_bought, uint version, uint def_index, uint reward_flags) : DotaPacket;
public record CMsgStickerbookSticker(uint item_def_id, uint sticker_num, uint quality, float position_x, float position_y, float rotation, float scale, float position_z, ulong source_item_id, uint depth_bias) : DotaPacket;
public record CMsgStickerbookPage(uint page_num, EEvent event_id, uint team_id, List<CMsgStickerbookSticker> stickers, EStickerbookPageType page_type) : DotaPacket;
public record CMsgStickerbookTeamPageOrderSequence(List<uint> page_numbers) : DotaPacket;
public record CMsgStickerbook(List<CMsgStickerbookPage> pages, CMsgStickerbookTeamPageOrderSequence team_page_order_sequence, uint favorite_page_num) : DotaPacket;
public record CMsgStickerHero(int hero_id, uint item_def_id, uint quality, ulong source_item_id) : DotaPacket;
public record CMsgStickerHeroes(List<CMsgStickerHero> heroes) : DotaPacket;
public record CMsgHeroRoleStats(uint lane_selection_flags, uint match_count, uint win_count) : DotaPacket;
public record CMsgHeroRoleHeroStats(int hero_id, List<CMsgHeroRoleStats> role_stats) : DotaPacket;
public record CMsgHeroRoleRankStats(uint rank_tier, List<CMsgHeroRoleHeroStats> hero_stats) : DotaPacket;
public record CMsgHeroRoleAllRanksStats(uint start_timestamp, uint end_timestamp, List<CMsgHeroRoleRankStats> rank_stats) : DotaPacket;
public record CMsgMapStatsSnapshot(uint timestamp, ulong lotuses_gained, ulong wisdom_runes_gained, ulong roshan_kills_day, ulong roshan_kills_night, ulong portals_used, ulong watchers_taken, ulong tormentor_kills, ulong outposts_captured, ulong shield_runes_gained) : DotaPacket;
public record CMsgGlobalMapStats(CMsgMapStatsSnapshot current, CMsgMapStatsSnapshot window_start, CMsgMapStatsSnapshot window_end) : DotaPacket;
public record CMsgTrackedStat(uint tracked_stat_id, int tracked_stat_value) : DotaPacket;
public record CMsgDOTAClaimEventActionResponse(CMsgDOTAClaimEventActionResponse.ResultCode result, List<CMsgDOTAClaimEventActionResponse.GrantedRewardData> reward_results, uint action_id) : DotaPacket
{
    public enum ResultCode
    {
        Success = 0,
        InvalidEvent = 1,
        EventNotActive = 2,
        InvalidAction = 3,
        ServerError = 4,
        InsufficientPoints = 5,
        InsufficentLevel = 6,
        AlreadyClaimed = 7,
        SDOLockFailure = 8,
        SDOLoadFailure = 9,
        EventNotOwned = 10,
        Timeout = 11,
        RequiresPlusSubscription = 12,
        InvalidItem = 13,
        AsyncRewards = 14,
    }
    public record MysteryItemRewardData(uint item_def, uint item_category);
    public record LootListRewardData(List<uint> item_def);
    public record ActionListRewardData(uint action_id, byte[] result_reward_data);
    public record OverworldTokenRewardData(List<CMsgDOTAClaimEventActionResponse.OverworldTokenRewardData.TokenQuantity> tokens)
    {
        public record TokenQuantity(uint token_id, uint token_count);
    }
    public record GrantedRewardData(uint grant_index, uint score_index, uint reward_index, byte[] reward_data, uint action_id);
}
public record CMsgClientToGCDotaLabsFeedback(uint language, uint feedback_item, string feedback) : DotaPacket;
public record CMsgClientToGCDotaLabsFeedbackResponse(CMsgClientToGCDotaLabsFeedbackResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidItem = 6,
    }
}
public record CDotaMsg_PredictionResult(uint account_id, ulong match_id, bool correct, List<CDotaMsg_PredictionResult.Prediction> predictions) : DotaPacket
{
    public record Prediction(uint item_def, uint num_correct, uint num_fails, CDotaMsg_PredictionResult.Prediction.EResult result, bool unused5, List<uint> granted_item_defs)
    {
        public enum EResult
        {
            k_eResult_ItemGranted = 1,
            k_eResult_Destroyed = 2,
        }
    }
}
