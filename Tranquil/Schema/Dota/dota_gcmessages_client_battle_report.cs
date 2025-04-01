namespace Tranquil.Schema;

public enum CMsgBattleReport_HighlightType
{
    k_eHighlightTypeInvalid = -1,
    k_eGameWinrate = 0,
    k_eLaneWinrate = 1,
    k_eMMRDelta = 2,
    k_eNumHeroesPlayed = 3,
    k_eNumGamesPlayed = 4,
    k_eAveragePowerRunesTaken = 5,
    k_eAverageBountyRunesTaken = 6,
    k_eTotalKillEnemyT1First = 7,
    k_eTotalRoshanKills = 8,
    k_eTotalDewards = 9,
    k_eTotalCampsStacked = 10,
    k_eMaxWinstreak = 11,
    k_eAverageDewards = 12,
    k_eAverageKills = 13,
    k_eMaxKills = 14,
    k_eAverageAssists = 15,
    k_eMaxAssists = 16,
    k_eAverageDeaths = 17,
    k_eMinDeaths = 18,
    k_eAverageCampsStacked = 19,
    k_eTotalLastHits = 20,
    k_eAverageLastHits = 21,
    k_eTotalDenies = 22,
    k_eAverageDenies = 23,
    k_eTotalGamesWithRoshanAdvantage = 24,
    k_ePercentGamesWithRoshanAdvantage = 25,
    k_eAverageStunDuration = 26,
    k_eTotalStunDuration = 27,
    k_eAverageTeleportsUsed = 28,
    k_eTotalTeleportsUsed = 29,
    k_eAverageHeroDamage = 30,
    k_eTotalHeroDamage = 31,
    k_eAverageHeroHealing = 32,
    k_eTotalHeroHealing = 33,
    k_eAverageTowerDamage = 34,
    k_eTotalTowerDamage = 35,
    k_eMaxLossStreak = 36,
    k_eAverageGameDuration = 37,
    k_eMaxGameDuration = 38,
    k_eMinGameDuration = 39,
    k_eAverageWinDuration = 40,
    k_eMaxWinDuration = 41,
    k_eMinWinDuration = 42,
    k_eAverageLossDuration = 43,
    k_eMaxLossDuration = 44,
    k_eMinLossDuration = 45,
    k_ePctGamesEnemyT1TakenFirst = 46,
    k_eMaxCampsStacked = 47,
    k_eMaxDewards = 48,
    k_eMaxRoshanKills = 49,
    k_eMaxBountyRunesTaken = 50,
    k_eMaxPowerRunesTaken = 51,
    k_eMaxDeaths = 52,
    k_eMaxLastHits = 53,
    k_eMaxDenies = 54,
    k_eRadiantWinRate = 55,
    k_eDireWinRate = 56,
    k_eRadiantGameCount = 57,
    k_eDireGameCount = 58,
    k_eMaxDamage = 59,
    k_eMaxHealing = 60,
    k_eMaxTowerDamage = 61,
    k_eAverageGPM = 62,
    k_eMaxGPM = 63,
    k_eAverageXPM = 64,
    k_eMaxXPM = 65,
}
public enum CMsgBattleReport_HighlightCategory
{
    k_eHighlightGeneral = 0,
    k_eHighlightHero = 1,
    k_eHighlightRole = 2,
}
public enum CMsgBattleReport_Role
{
    k_eUnknownRole = -1,
    k_eSafelane = 0,
    k_eMidlane = 1,
    k_eOfflane = 2,
    k_eSupport = 3,
    k_eHardSupport = 4,
}
public enum CMsgBattleReport_CompareContext
{
    k_eCompareContextInvalid = -1,
    k_eAbsoluteValue = 0,
    k_ePlayersOfSimilarRank = 1,
    k_eAllPlayers = 2,
    k_ePlayersPersonalHistory = 3,
}
public enum CMsgBattleReport_HighlightTier
{
    k_eHighlightTierLow = -1,
    k_eHighlightTierNone = 0,
    k_eHighlightTier1 = 1,
    k_eHighlightTier2 = 2,
    k_eHighlightTier3 = 3,
    k_eHighlightTierCustom = 4,
}
public enum CMsgBattleReport_HighlightRarity
{
    k_eHighlightCommon = 0,
    k_eHighlightUncommon = 1,
    k_eHighlightRare = 2,
}
public enum CMsgBattleReport_EOutcome
{
    k_eWin = 0,
    k_eLoss = 1,
}
public enum CMsgBattleReport_ELaneOutcome
{
    k_eUnknownLaneOutcome = -1,
    k_eWonLane = 0,
    k_eLostLane = 1,
    k_eEvenLane = 2,
}
public record CMsgClientToGCGetBattleReport(uint account_id, uint timestamp, uint duration) : DotaPacket;
public record CMsgBattleReport_Game(int hero_id, uint kills, uint deaths, uint assists, int rank_change, uint last_hits, uint gpm, uint xpm, CMsgBattleReport_Role role, CMsgBattleReport_EOutcome outcome, CMsgBattleReport_ELaneOutcome lane_outcome, bool ranked, ulong match_id, uint lane_selection_flags, uint predicted_position, uint seconds_dead, uint winning_team, bool unused18, bool party_game, uint start_time, uint denies, uint bounty_runes, uint water_runes, uint power_runes, uint time_enemy_t1_tower_destroyed, uint time_friendly_t1_tower_destroyed, uint enemy_roshan_kills, uint player_slot, uint teleports_used, uint dewards, uint camps_stacked, uint support_gold, uint hero_damage, uint hero_healing, uint tower_damage, uint successful_smokes, uint stun_duration, uint duration, uint friendly_roshan_kills, int previous_rank, uint game_mode, uint lobby_type, float time_purchased_shard, float time_purchased_scepter, int item0, int item1, int item2, int item3, int item4, int item5, uint selected_facet) : DotaPacket;
public record CMsgBattleReport_GameList(List<CMsgBattleReport_Game> games) : DotaPacket;
public record CMsgBattleReport(List<CMsgBattleReport_Game> games, bool unused2, CMsgBattleReportHighlights highlights) : DotaPacket
{
    public record HighlightGeneral(int win_loss_window, float win_percent, int mmr_delta, float highlight_score);
    public record Highlight(uint highlight_id, CMsgBattleReport_HighlightCategory category, CMsgBattleReport_HighlightTier tier, CMsgBattleReport_HighlightRarity rarity, float score, float confidence, int hero_id, CMsgBattleReport_Role role, float comparison_delta_value, CMsgBattleReport_CompareContext context);
}
public record CMsgBattleReportInfo(uint timestamp, uint duration, bool acknowledged, int featured_hero_id, uint featured_position, uint games_played, List<uint> medal_counts) : DotaPacket;
public record CMsgBattleReportInfoList(List<CMsgBattleReportInfo> battle_report_info) : DotaPacket;
public record CMsgBattleReportHighlights(List<CMsgBattleReport.Highlight> highlights) : DotaPacket;
public record CMsgBattleReportAggregateStats(List<CMsgBattleReportAggregateStats.CMsgBattleReportAggregate> result) : DotaPacket
{
    public record CMsgBattleReportStat(float mean, float stdev);
    public record CMsgBattleReportAggregate(int hero_id, uint predicted_position, uint game_count, uint win_count, uint lane_win_count, CMsgBattleReportAggregateStats.CMsgBattleReportStat kills, CMsgBattleReportAggregateStats.CMsgBattleReportStat deaths, CMsgBattleReportAggregateStats.CMsgBattleReportStat assists, CMsgBattleReportAggregateStats.CMsgBattleReportStat rank_change, CMsgBattleReportAggregateStats.CMsgBattleReportStat last_hits, CMsgBattleReportAggregateStats.CMsgBattleReportStat denies, CMsgBattleReportAggregateStats.CMsgBattleReportStat gpm, CMsgBattleReportAggregateStats.CMsgBattleReportStat xpm, CMsgBattleReportAggregateStats.CMsgBattleReportStat seconds_dead, CMsgBattleReportAggregateStats.CMsgBattleReportStat bounty_runes, CMsgBattleReportAggregateStats.CMsgBattleReportStat water_runes, CMsgBattleReportAggregateStats.CMsgBattleReportStat power_runes, CMsgBattleReportAggregateStats.CMsgBattleReportStat time_enemy_t1_tower_destroyed, CMsgBattleReportAggregateStats.CMsgBattleReportStat time_friendly_t1_tower_destroyed, CMsgBattleReportAggregateStats.CMsgBattleReportStat enemy_roshan_kills, CMsgBattleReportAggregateStats.CMsgBattleReportStat teleports_used, CMsgBattleReportAggregateStats.CMsgBattleReportStat dewards, CMsgBattleReportAggregateStats.CMsgBattleReportStat camps_stacked, CMsgBattleReportAggregateStats.CMsgBattleReportStat support_gold, CMsgBattleReportAggregateStats.CMsgBattleReportStat hero_damage, CMsgBattleReportAggregateStats.CMsgBattleReportStat hero_healing, CMsgBattleReportAggregateStats.CMsgBattleReportStat tower_damage, CMsgBattleReportAggregateStats.CMsgBattleReportStat successful_smokes, CMsgBattleReportAggregateStats.CMsgBattleReportStat stun_duration, CMsgBattleReportAggregateStats.CMsgBattleReportStat duration, CMsgBattleReportAggregateStats.CMsgBattleReportStat friendly_roshan_kills);
}
public record CMsgBattleReportAggregatedGeneralStats : DotaPacket;
public record CMsgClientToGCGetBattleReportResponse(CMsgBattleReport report, CMsgClientToGCGetBattleReportResponse.EResponse response, CMsgBattleReportAggregateStats aggregate_stats, CMsgBattleReportInfo info) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_ePermissionDenied = 4,
        k_eNotSubscribedToDotaPlus = 5,
        k_eInvalidParameters = 6,
        k_eUnableToGetPlusSubInfo = 7,
        k_eUnableToLoadBattleReport = 8,
        k_eUnableToSaveBattleReport = 9,
        k_eUnableToGetAggregates = 10,
        k_eNotEnoughGamesPlayed = 11,
    }
}
public record CMsgClientToGCGetBattleReportAggregateStats(List<CMsgClientToGCGetBattleReportAggregateStats.CMsgBattleReportAggregateKey> aggregate_keys, uint timestamp, uint duration, uint rank) : DotaPacket
{
    public record CMsgBattleReportAggregateKey(int hero_id, uint predicted_position);
}
public record CMsgClientToGCGetBattleReportAggregateStatsResponse(CMsgBattleReportAggregateStats aggregate_stats, CMsgClientToGCGetBattleReportAggregateStatsResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_ePermissionDenied = 4,
        k_eInvalidParams = 5,
        k_eNotSubscribedToDotaPlus = 6,
    }
}
public record CMsgClientToGCGetBattleReportInfo(uint account_id) : DotaPacket;
public record CMsgClientToGCGetBattleReportInfoResponse(CMsgBattleReportInfoList battle_report_info_list, CMsgClientToGCGetBattleReportInfoResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_ePermissionDenied = 4,
        k_eNotSubscribedToDotaPlus = 5,
    }
}
public record CMsgClientToGCAcknowledgeBattleReport(uint account_id, uint timestamp, uint duration) : DotaPacket;
public record CMsgClientToGCAcknowledgeBattleReportResponse(CMsgClientToGCAcknowledgeBattleReportResponse.EResponse response, uint shards_awarded) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_ePermissionDenied = 5,
        k_eUnableToLoadBattleReport = 6,
        k_eAlreadyAcknowledged = 7,
        k_eUnknownReport = 8,
        k_eNotSubscribedToDotaPlus = 9,
        k_eNotEnoughGamesPlayed = 10,
    }
}
public record CMsgClientToGCGetBattleReportMatchHistory(uint account_id, uint timestamp, uint duration) : DotaPacket;
public record CMsgClientToGCGetBattleReportMatchHistoryResponse(CMsgClientToGCGetBattleReportMatchHistoryResponse.EResponse response, CMsgBattleReport_GameList games) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_ePermissionDenied = 5,
        k_eNotSubscribedToDotaPlus = 6,
    }
}
