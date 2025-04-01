namespace Tranquil.Schema;

public enum DOTA_2013PassportSelectionIndices
{
    PP13_SEL_ALLSTAR_PLAYER_0 = 0,
    PP13_SEL_ALLSTAR_PLAYER_1 = 1,
    PP13_SEL_ALLSTAR_PLAYER_2 = 2,
    PP13_SEL_ALLSTAR_PLAYER_3 = 3,
    PP13_SEL_ALLSTAR_PLAYER_4 = 4,
    PP13_SEL_ALLSTAR_PLAYER_5 = 5,
    PP13_SEL_ALLSTAR_PLAYER_6 = 6,
    PP13_SEL_ALLSTAR_PLAYER_7 = 7,
    PP13_SEL_ALLSTAR_PLAYER_8 = 8,
    PP13_SEL_ALLSTAR_PLAYER_9 = 9,
    PP13_SEL_QUALPRED_WEST_0 = 10,
    PP13_SEL_QUALPRED_WEST_1 = 11,
    PP13_SEL_QUALPRED_WEST_2 = 12,
    PP13_SEL_QUALPRED_WEST_3 = 13,
    PP13_SEL_QUALPRED_WEST_4 = 14,
    PP13_SEL_QUALPRED_WEST_5 = 15,
    PP13_SEL_QUALPRED_WEST_6 = 16,
    PP13_SEL_QUALPRED_WEST_7 = 17,
    PP13_SEL_QUALPRED_WEST_8 = 18,
    PP13_SEL_QUALPRED_WEST_9 = 19,
    PP13_SEL_QUALPRED_WEST_10 = 20,
    PP13_SEL_QUALPRED_WEST_11 = 21,
    PP13_SEL_QUALPRED_WEST_12 = 22,
    PP13_SEL_QUALPRED_WEST_13 = 23,
    PP13_SEL_QUALPRED_WEST_14 = 24,
    PP13_SEL_QUALPRED_EAST_0 = 25,
    PP13_SEL_QUALPRED_EAST_1 = 26,
    PP13_SEL_QUALPRED_EAST_2 = 27,
    PP13_SEL_QUALPRED_EAST_3 = 28,
    PP13_SEL_QUALPRED_EAST_4 = 29,
    PP13_SEL_QUALPRED_EAST_5 = 30,
    PP13_SEL_QUALPRED_EAST_6 = 31,
    PP13_SEL_QUALPRED_EAST_7 = 32,
    PP13_SEL_QUALPRED_EAST_8 = 33,
    PP13_SEL_QUALPRED_EAST_9 = 34,
    PP13_SEL_QUALPRED_EAST_10 = 35,
    PP13_SEL_QUALPRED_EAST_11 = 36,
    PP13_SEL_QUALPRED_EAST_12 = 37,
    PP13_SEL_QUALPRED_EAST_13 = 38,
    PP13_SEL_QUALPRED_EAST_14 = 39,
    PP13_SEL_TEAMCUP_TEAM = 40,
    PP13_SEL_TEAMCUP_PLAYER = 41,
    PP13_SEL_TEAMCUP_TEAM_LOCK = 42,
    PP13_SEL_TEAMCUP_PLAYER_LOCK = 43,
    PP13_SEL_EVENTPRED_0 = 44,
    PP13_SEL_EVENTPRED_1 = 45,
    PP13_SEL_EVENTPRED_2 = 46,
    PP13_SEL_EVENTPRED_3 = 47,
    PP13_SEL_EVENTPRED_4 = 48,
    PP13_SEL_EVENTPRED_5 = 49,
    PP13_SEL_EVENTPRED_6 = 50,
    PP13_SEL_EVENTPRED_7 = 51,
    PP13_SEL_EVENTPRED_8 = 52,
    PP13_SEL_EVENTPRED_9 = 53,
    PP13_SEL_EVENTPRED_10 = 54,
    PP13_SEL_EVENTPRED_11 = 55,
    PP13_SEL_EVENTPRED_12 = 56,
    PP13_SEL_EVENTPRED_13 = 57,
    PP13_SEL_EVENTPRED_14 = 58,
    PP13_SEL_EVENTPRED_15 = 59,
    PP13_SEL_EVENTPRED_16 = 60,
    PP13_SEL_EVENTPRED_17 = 61,
    PP13_SEL_EVENTPRED_18 = 62,
    PP13_SEL_EVENTPRED_19 = 63,
    PP13_SEL_EVENTPRED_20 = 64,
    PP13_SEL_EVENTPRED_21 = 65,
    PP13_SEL_EVENTPRED_22 = 66,
    PP13_SEL_EVENTPRED_23 = 67,
    PP13_SEL_EVENTPRED_24 = 68,
    PP13_SEL_EVENTPRED_25 = 69,
    PP13_SEL_EVENTPRED_26 = 70,
    PP13_SEL_EVENTPRED_27 = 71,
    PP13_SEL_EVENTPRED_28 = 72,
    PP13_SEL_EVENTPRED_29 = 73,
    PP13_SEL_EVENTPRED_30 = 74,
    PP13_SEL_EVENTPRED_31 = 75,
    PP13_SEL_EVENTPRED_32 = 76,
    PP13_SEL_EVENTPRED_33 = 77,
    PP13_SEL_EVENTPRED_34 = 78,
    PP13_SEL_EVENTPRED_35 = 79,
    PP13_SEL_EVENTPRED_36 = 80,
    PP13_SEL_EVENTPRED_37 = 81,
    PP13_SEL_EVENTPRED_38 = 82,
    PP13_SEL_EVENTPRED_39 = 83,
    PP13_SEL_EVENTPRED_40 = 84,
    PP13_SEL_EVENTPRED_41 = 85,
    PP13_SEL_EVENTPRED_42 = 86,
    PP13_SEL_EVENTPRED_43 = 87,
    PP13_SEL_SOLO_0 = 88,
    PP13_SEL_SOLO_1 = 89,
    PP13_SEL_SOLO_2 = 90,
    PP13_SEL_SOLO_3 = 91,
    PP13_SEL_SOLO_4 = 92,
    PP13_SEL_SOLO_5 = 93,
    PP13_SEL_SOLO_6 = 94,
    PP13_SEL_SOLO_7 = 95,
}
public record CMsgDOTAPlayerInfo(uint account_id, string name, string country_code, Fantasy_Roles fantasy_role, uint team_id, string team_name, string team_tag, string sponsor, bool is_locked, bool is_pro, string real_name, bool unused12, uint total_earnings, List<CMsgDOTAPlayerInfo.Results> results, string team_url_logo, List<CMsgDOTAPlayerInfo.AuditEntry> audit_entries, string team_abbreviation) : DotaPacket
{
    public record Results(uint league_id, uint placement, uint earnings);
    public record AuditEntry(uint start_timestamp, uint end_timestamp, uint team_id, string team_name, string team_tag, string team_url_logo);
}
public record CMsgDOTAPlayerInfoList(List<CMsgDOTAPlayerInfo> player_infos) : DotaPacket;
public record CMsgDOTATeamRoster(uint timestamp, uint team_id, List<uint> member_account_ids, uint coach_account_id) : DotaPacket;
public record CMsgDOTADPCProfileInfo(CMsgDOTAPlayerInfo player_info, CMsgDOTADPCProfileInfo.PredictionInfo prediction_info, CMsgDOTADPCProfileInfo.FantasyInfo fantasy_info, List<uint> disabled_notifications) : DotaPacket
{
    public record PredictionInfo(uint percent, int shard_winnings);
    public record FantasyInfo(uint top_90_finishes, uint top_75_finishes, uint top_50_finishes, uint shard_winnings);
}
public record CMsgDOTALeaderboards(bool unused1, List<CMsgDOTALeaderboards.RegionLeaderboard> leaderboards) : DotaPacket
{
    public record RegionLeaderboard(uint division, List<uint> account_ids);
}
public record CMsgDOTAPassportVoteTeamGuess(uint league_id, uint winner_id, uint runnerup_id) : DotaPacket;
public record CMsgDOTAPassportVoteGenericSelection(DOTA_2013PassportSelectionIndices selection_index, uint selection) : DotaPacket;
public record CMsgDOTAPassportStampedPlayer(ulong steam_id, uint stamp_level) : DotaPacket;
public record CMsgDOTAPassportPlayerCardChallenge(uint challenge_id) : DotaPacket;
public record CMsgDOTAPassportVote(List<CMsgDOTAPassportVoteTeamGuess> team_votes, List<CMsgDOTAPassportVoteGenericSelection> generic_selections, List<CMsgDOTAPassportStampedPlayer> stamped_players, List<CMsgDOTAPassportPlayerCardChallenge> player_card_challenges) : DotaPacket;
public record CMsgClientToGCGetPlayerCardRosterRequest(uint league_id, bool unused2, uint fantasy_period) : DotaPacket;
public record CMsgClientToGCGetPlayerCardRosterResponse(CMsgClientToGCGetPlayerCardRosterResponse.Result result, List<ulong> player_card_item_id, float score, bool finalized, float percentile) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
        ERROR_INVALID_LEAGUE_ID = 2,
        ERROR_INVALID_TIMESTAMP = 3,
    }
}
public record CMsgClientToGCBatchGetPlayerCardRosterRequest(List<CMsgClientToGCBatchGetPlayerCardRosterRequest.LeagueTimestamp> league_timestamps) : DotaPacket
{
    public record LeagueTimestamp(uint league_id, bool unused2, uint fantasy_period);
}
public record CMsgClientToGCBatchGetPlayerCardRosterResponse(List<CMsgClientToGCBatchGetPlayerCardRosterResponse.RosterResponse> responses) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
        ERROR_INVALID_LEAGUE_ID = 2,
        ERROR_INVALID_TIMESTAMP = 3,
    }
    public record RosterResponse(uint league_id, uint deprecated_timestamp, CMsgClientToGCBatchGetPlayerCardRosterResponse.Result result, List<ulong> player_card_item_id, float score, bool finalized, float percentile, uint fantasy_period);
}
public record CMsgClientToGCSetPlayerCardRosterRequest(uint league_id, uint deprecated_timestamp, uint slot, ulong player_card_item_id, uint event_id, uint fantasy_period) : DotaPacket;
public record CMsgClientToGCSetPlayerCardRosterResponse(CMsgClientToGCSetPlayerCardRosterResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
        ERROR_INVALID_LEAGUE_ID = 2,
        ERROR_INVALID_TIMESTAMP = 3,
        ERROR_PLAYER_CARD_NOT_OWNED = 4,
        ERROR_INVALID_SLOT = 5,
        ERROR_FAILED_CARD_INFO = 6,
        ERROR_ACCOUNT_DUPLICATE = 7,
        ERROR_LOCKED_TIMESTAMP = 8,
        ERROR_INVALID_LEAGUE_FOR_PERIOD = 9,
        ERROR_INVALID_EVENT = 10,
    }
}
public record CMsgDOTAFantasyDPCLeagueStatus(List<CMsgDOTAFantasyDPCLeagueStatus.LeagueInfo> league_infos) : DotaPacket
{
    public enum ERosterStatus
    {
        UNSET = 0,
        PARTIAL = 1,
        FULL = 2,
        CONCLUDED = 3,
    }
    public record LeagueInfo(uint league_id, string league_name, uint start_timestamp, uint end_timestamp, List<uint> day_timestamps, bool unused6, bool unused7, CMsgDOTAFantasyDPCLeagueStatus.ERosterStatus status);
}
public record CMsgDOTADPCSearchResults(List<CMsgDOTADPCSearchResults.Player> players, List<CMsgDOTADPCSearchResults.Team> teams, List<CMsgDOTADPCSearchResults.League> leagues) : DotaPacket
{
    public enum ESearchResultsDesired
    {
        k_ESearchResultsDesired_Players = 1,
        k_ESearchResultsDesired_Teams = 2,
        k_ESearchResultsDesired_Leagues = 4,
        k_ESearchResultsDesired_All = 7,
    }
    public record Player(uint id, string name, string real_name);
    public record Team(uint id, string name, string url);
    public record League(uint id, string name);
}
public record CMsgDOTADPCTeamFavoriteRankings(List<CMsgDOTADPCTeamFavoriteRankings.Team> teams) : DotaPacket
{
    public record Team(uint team_id, uint favorites);
}
public record CMsgDotaFantasyCraftingTabletPeriodData(uint fantasy_period, List<CMsgDotaFantasyCraftingTabletPeriodData.Tablet> tablets) : DotaPacket
{
    public record Gem(Fantasy_Gem_Type type, uint slot, uint shape, uint quality, Fantasy_Scoring stat);
    public record Tablet(uint tablet_id, uint tablet_level, Fantasy_Roles fantasy_role, uint account_id, uint prefix, uint suffix, List<CMsgDotaFantasyCraftingTabletPeriodData.Gem> gems, float score, uint best_series);
}
public record CMsgDotaFantasyCraftingTabletData(List<CMsgDotaFantasyCraftingTabletData.TabletPeriodDataEntry> tablet_period_data) : DotaPacket
{
    public record TabletPeriodDataEntry(uint key, CMsgDotaFantasyCraftingTabletPeriodData value);
}
public record CMsgDotaFantasyCraftingUserData(List<uint> available_rolls, List<CMsgDotaFantasyCraftingUserData.PeriodRollTokensEntry> period_roll_tokens, List<CMsgDotaFantasyCraftingUserData.PeriodScoresEntry> period_scores) : DotaPacket
{
    public record PeriodScore(float total_score, float percentile);
    public record PeriodRollTokensEntry(uint key, uint value);
    public record PeriodScoresEntry(uint key, CMsgDotaFantasyCraftingUserData.PeriodScore value);
}
public record CMsgDotaFantasyCraftingDataCache(List<CMsgDotaFantasyCraftingDataCache.CacheEntry> cache_entries) : DotaPacket
{
    public record CacheEntry(uint account_id, uint fantasy_league, CMsgGCToClientFantasyCraftingDataUpdated cache_data);
}
public record CMsgClientToGCFantasyCraftingGetData(uint fantasy_league, uint account_id) : DotaPacket;
public record CMsgClientToGCFantasyCraftingGetDataResponse(CMsgClientToGCFantasyCraftingGetDataResponse.EResponse response, CMsgDotaFantasyCraftingUserData user_data, bool unused3, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
    }
}
public record CMsgClientToGCFantasyCraftingPerformOperation(uint fantasy_league, uint tablet_id, uint operation_id, ulong extra_data) : DotaPacket;
public record CMsgClientToGCFantasyCraftingPerformOperationResponse(CMsgClientToGCFantasyCraftingPerformOperationResponse.EResponse response, uint operation_id, List<uint> player_choices, List<uint> prefix_choices, List<uint> suffix_choices, List<CMsgClientToGCFantasyCraftingPerformOperationResponse.TitleChoice> title_choices, uint tablet_id, CMsgDotaFantasyCraftingUserData user_data, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
        k_eNoTokens = 6,
        k_eMoreInfo = 7,
    }
    public record TitleChoice(uint prefix_choice, uint suffix_choice);
}
public record CMsgGCToClientFantasyCraftingDataUpdated(uint fantasy_league, CMsgDotaFantasyCraftingUserData user_data, bool unused3, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket;
public record CMsgClientToGCFantasyCraftingDevModifyTablet(uint fantasy_league, bool reset_tablet, uint modify_tokens, bool unused4, uint fantasy_period, bool upgrade_tablets) : DotaPacket;
public record CMsgClientToGCFantasyCraftingDevModifyTabletResponse(CMsgClientToGCFantasyCraftingDevModifyTabletResponse.EResponse response, CMsgDotaFantasyCraftingUserData user_data, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
    }
}
public record CMsgClientToGCFantasyCraftingSelectPlayer(uint fantasy_league, uint account_id) : DotaPacket;
public record CMsgClientToGCFantasyCraftingSelectPlayerResponse(CMsgClientToGCFantasyCraftingSelectPlayerResponse.EResponse response, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
        k_eInvalidPlayer = 6,
    }
}
public record CMsgClientToGCFantasyCraftingGenerateTablets(uint fantasy_league, List<uint> account_ids) : DotaPacket;
public record CMsgClientToGCFantasyCraftingGenerateTabletsResponse(CMsgClientToGCFantasyCraftingGenerateTabletsResponse.EResponse response, CMsgDotaFantasyCraftingUserData user_data, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
        k_eInvalidPlayer = 6,
    }
}
public record CMsgClientToGcFantasyCraftingUpgradeTablets(uint fantasy_league) : DotaPacket;
public record CMsgClientToGcFantasyCraftingUpgradeTabletsResponse(CMsgClientToGcFantasyCraftingUpgradeTabletsResponse.EResponse response, bool unused2, CMsgDotaFantasyCraftingTabletData tablet_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
    }
}
public record CMsgClientToGCFantasyCraftingRerollOptions(uint fantasy_league) : DotaPacket;
public record CMsgClientToGCFantasyCraftingRerollOptionsResponse(CMsgClientToGCFantasyCraftingRerollOptionsResponse.EResponse response, CMsgDotaFantasyCraftingUserData user_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidLeague = 5,
        k_eInsufficientTokens = 6,
    }
}
