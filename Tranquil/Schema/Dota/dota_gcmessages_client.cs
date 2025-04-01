using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum CMsgDOTARequestMatches_SkillLevel
{
    CMsgDOTARequestMatches_SkillLevel_Any = 0,
    CMsgDOTARequestMatches_SkillLevel_Normal = 1,
    CMsgDOTARequestMatches_SkillLevel_High = 2,
    CMsgDOTARequestMatches_SkillLevel_VeryHigh = 3,
}
public enum DOTA_WatchReplayType
{
    DOTA_WATCH_REPLAY_NORMAL = 0,
    DOTA_WATCH_REPLAY_HIGHLIGHTS = 1,
}
public enum EItemEditorReservationResult
{
    k_EItemEditorReservationResult_OK = 1,
    k_EItemEditorReservationResult_AlreadyExists = 2,
    k_EItemEditorReservationResult_Reserved = 3,
    k_EItemEditorReservationResult_TimedOut = 4,
}
public enum EWeekendTourneyRichPresenceEvent
{
    k_EWeekendTourneyRichPresenceEvent_None = 0,
    k_EWeekendTourneyRichPresenceEvent_StartedMatch = 1,
    k_EWeekendTourneyRichPresenceEvent_WonMatch = 2,
    k_EWeekendTourneyRichPresenceEvent_Eliminated = 3,
}
public enum EDOTATriviaAnswerResult
{
    k_EDOTATriviaAnswerResult_Success = 0,
    k_EDOTATriviaAnswerResult_InvalidQuestion = 1,
    k_EDOTATriviaAnswerResult_InvalidAnswer = 2,
    k_EDOTATriviaAnswerResult_QuestionLocked = 3,
    k_EDOTATriviaAnswerResult_AlreadyAnswered = 4,
    k_EDOTATriviaAnswerResult_TriviaDisabled = 5,
}
public enum EPurchaseHeroRelicResult
{
    k_EPurchaseHeroRelicResult_Success = 0,
    k_EPurchaseHeroRelicResult_FailedToSend = 1,
    k_EPurchaseHeroRelicResult_NotEnoughPoints = 2,
    k_EPurchaseHeroRelicResult_InternalServerError = 3,
    k_EPurchaseHeroRelicResult_PurchaseNotAllowed = 4,
    k_EPurchaseHeroRelicResult_InvalidRelic = 5,
    k_EPurchaseHeroRelicResult_AlreadyOwned = 6,
    k_EPurchaseHeroRelicResult_InvalidRarity = 7,
}
public enum EDevEventRequestResult
{
    k_EDevEventRequestResult_Success = 0,
    k_EDevEventRequestResult_NotAllowed = 1,
    k_EDevEventRequestResult_InvalidEvent = 2,
    k_EDevEventRequestResult_SqlFailure = 3,
    k_EDevEventRequestResult_Timeout = 4,
    k_EDevEventRequestResult_LockFailure = 5,
    k_EDevEventRequestResult_SDOLoadFailure = 6,
}
public enum ESupportEventRequestResult
{
    k_ESupportEventRequestResult_Success = 0,
    k_ESupportEventRequestResult_Timeout = 1,
    k_ESupportEventRequestResult_CantLockSOCache = 2,
    k_ESupportEventRequestResult_ItemNotInInventory = 3,
    k_ESupportEventRequestResult_InvalidItemDef = 4,
    k_ESupportEventRequestResult_InvalidEvent = 5,
    k_ESupportEventRequestResult_EventExpired = 6,
    k_ESupportEventRequestResult_InvalidSupportAccount = 7,
    k_ESupportEventRequestResult_InvalidSupportMessage = 8,
    k_ESupportEventRequestResult_InvalidEventPoints = 9,
    k_ESupportEventRequestResult_InvalidPremiumPoints = 10,
    k_ESupportEventRequestResult_InvalidActionID = 11,
    k_ESupportEventRequestResult_InvalidActionScore = 12,
    k_ESupportEventRequestResult_TransactionFailed = 13,
}
public enum EUnderDraftResponse
{
    k_eInternalError = 0,
    k_eSuccess = 1,
    k_eNoGold = 2,
    k_eInvalidSlot = 3,
    k_eNoBenchSpace = 4,
    k_eNoTickets = 5,
    k_eEventNotOwned = 6,
    k_eInvalidReward = 7,
    k_eHasBigReward = 8,
    k_eNoGCConnection = 9,
    k_eTooBusy = 10,
    k_eCantRollBack = 11,
}
public enum EDOTADraftTriviaAnswerResult
{
    k_EDOTADraftTriviaAnswerResult_Success = 0,
    k_EDOTADraftTriviaAnswerResult_InvalidMatchID = 1,
    k_EDOTADraftTriviaAnswerResult_AlreadyAnswered = 2,
    k_EDOTADraftTriviaAnswerResult_InternalError = 3,
    k_EDOTADraftTriviaAnswerResult_TriviaDisabled = 4,
    k_EDOTADraftTriviaAnswerResult_GCDown = 5,
}
public enum CMsgClientToGCUpdateComicBookStat_Type
{
    CMsgClientToGCUpdateComicBookStat_Type_HighestPageRead = 1,
    CMsgClientToGCUpdateComicBookStat_Type_SecondsSpentReading = 2,
    CMsgClientToGCUpdateComicBookStat_Type_HighestPercentRead = 3,
}
public record CMsgClientSuspended(uint time_end) : DotaPacket;
public record CMsgBalancedShuffleLobby : DotaPacket;
public record CMsgInitialQuestionnaireResponse(uint initial_skill) : DotaPacket;
public record CMsgDOTARequestMatchesResponse(List<CMsgDOTAMatch> matches, List<CMsgDOTARequestMatchesResponse.Series> series, uint request_id, uint total_results, uint results_remaining) : DotaPacket
{
    public record Series(List<CMsgDOTAMatch> matches, uint series_id, uint series_type);
}
public record CMsgDOTAPopup(CMsgDOTAPopup.PopupID id, string custom_text, int SS1int_data, byte[] popup_data, string loc_token_header, string loc_token_msg, List<string> var_names, List<string> var_values, string debug_text) : DotaPacket
{
    public enum PopupID
    {
        NONE = -1,
        KICKED_FROM_LOBBY = 0,
        KICKED_FROM_PARTY = 1,
        KICKED_FROM_TEAM = 2,
        TEAM_WAS_DISBANDED = 3,
        TEAM_MATCHMAKE_ALREADY_MATCH = 4,
        TEAM_MATCHMAKE_ALREADY_FINDING = 5,
        TEAM_MATCHMAKE_FULL = 6,
        TEAM_MATCHMAKE_FAIL_ADD = 7,
        TEAM_MATCHMAKE_FAIL_ADD_CURRENT = 8,
        TEAM_MATCHMAKE_FAILED_TEAM_MEMBER = 9,
        TEAM_MATCHMAKE_ALREADY_GAME = 10,
        TEAM_MATCHMAKE_FAIL_GET_PARTY = 11,
        MATCHMAKING_DISABLED = 12,
        INVITE_DENIED = 13,
        PARTY_FULL = 14,
        MADE_ADMIN = 15,
        NEED_TO_PURCHASE = 16,
        SIGNON_MESSAGE = 17,
        MATCHMAKING_REGION_OFFLINE = 19,
        TOURNAMENT_GAME_NOT_FOUND = 21,
        TOURNAMENT_GAME_HAS_LOBBY_ID = 22,
        TOURNAMENT_GAME_HAS_MATCH_ID = 23,
        TOURNAMENT_GAME_HAS_NO_RADIANT_TEAM = 24,
        TOURNAMENT_GAME_HAS_NO_DIRE_TEAM = 25,
        TOURNAMENT_GAME_SQL_UPDATE_FAILED = 26,
        NOT_LEAGUE_ADMIN = 27,
        IN_ANOTHER_GAME = 29,
        PARTY_MEMBER_IN_ANOTHER_GAME = 30,
        PARTY_MEMBER_IN_LOW_PRIORITY = 31,
        CLIENT_OUT_OF_DATE = 32,
        SAVE_GAME_CORRUPT = 38,
        INSUFFICIENT_INGOTS = 39,
        COMPETITIVE_MM_NOT_ENOUGH_PLAY_TIME_PLAY_MORE_CASUAL = 42,
        PARTY_LEADER_JOINED_LOBBY = 44,
        WEEKEND_TOURNEY_UNMATCHED = 48,
        POST_MATCH_SURVEY = 49,
        TROPHY_AWARDED = 50,
        TROPHY_LEVEL_UP = 51,
        ALL_HERO_CHALLENGE_PROGRESS = 52,
        NEED_INITIAL_SKILL = 53,
        NEED_INITIAL_SKILL_IN_PARTY = 54,
        TARGET_ENGINE_MISMATCH = 55,
        VAC_NOT_VERIFIED = 56,
        KICKED_FROM_QUEUE_EVENT_STARTING = 57,
        KICKED_FROM_QUEUE_EVENT_ENDING = 58,
        LOBBY_FULL = 62,
        EVENT_POINTS_EARNED = 63,
        CUSTOM_GAME_INCORRECT_VERSION = 64,
        LIMITED_USER_CHAT = 66,
        EVENT_PREMIUM_POINTS_EARNED = 67,
        LOBBY_MVP_AWARDED = 68,
        LOW_BADGE_LEVEL_CHAT = 71,
        LOW_WINS_CHAT = 72,
        UNVERIFIED_USER_CHAT = 73,
        PARTY_STARTED_FINDING_EVENT_MATCH = 74,
        GENERIC_INFO = 69,
        GENERIC_ERROR = 70,
        RANK_TIER_UPDATED = 75,
        CUSTOM_GAME_COOLDOWN_RESTRICTED = 76,
        CREATE_LOBBY_FAILED_TOO_MUCH_PLAYTIME = 77,
        CUSTOM_GAME_TOO_FEW_GAMES = 78,
        COMM_SCORE_TOO_LOW = 79,
    }
}
public record CMsgDOTAReportsRemainingRequest : DotaPacket;
public record CMsgDOTAReportsRemainingResponse(uint num_positive_reports_remaining, uint num_negative_reports_remaining, uint num_positive_reports_total, uint num_negative_reports_total, uint num_comms_reports_remaining, uint num_comms_reports_total) : DotaPacket;
public record CMsgDOTASubmitPlayerReport(uint target_account_id, uint report_flags, bool unused3, ulong lobby_id, string comment) : DotaPacket;
public record CMsgDOTASubmitPlayerReportResponse(uint target_account_id, uint report_flags, bool unused3, string debug_message, CMsgDOTASubmitPlayerReportResponse.EResult enum_result) : DotaPacket
{
    public enum EResult
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eDuplicateReport = 2,
        k_eMixedReportFlags = 3,
        k_eTooLate = 4,
        k_eInvalidPregameReport = 5,
        k_eHasntChatted = 6,
        k_eInvalid = 7,
        k_eOwnership = 8,
        k_eMissingRequirements = 9,
        k_eInvalidRoleReport = 10,
        k_eInvalidCoachReport = 11,
        k_eNoRemainingReports = 12,
        k_eInvalidMember = 13,
    }
}
public record CMsgDOTASubmitPlayerAvoidRequest(uint target_account_id, bool unused2, bool unused3, ulong lobby_id, string user_note) : DotaPacket;
public record CMsgDOTASubmitPlayerAvoidRequestResponse(uint target_account_id, uint result, string debug_message) : DotaPacket;
public record CMsgDOTASubmitPlayerReportV2(uint target_account_id, List<uint> report_reason, ulong lobby_id, float game_time, uint debug_slot, long SF2debug_match_id) : DotaPacket;
public record CMsgDOTASubmitPlayerReportResponseV2(uint target_account_id, List<uint> report_reason, bool unused3, string debug_message, CMsgDOTASubmitPlayerReportResponseV2.EResult enum_result) : DotaPacket
{
    public enum EResult
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eDuplicateReport = 2,
        k_eMixedReportFlags = 3,
        k_eTooLate = 4,
        k_eInvalidPregameReport = 5,
        k_eHasntChatted = 6,
        k_eInvalid = 7,
        k_eOwnership = 8,
        k_eMissingRequirements = 9,
        k_eInvalidRoleReport = 10,
        k_eInvalidCoachReport = 11,
        k_eNoRemainingReports = 12,
        k_eInvalidMember = 13,
        k_eCannotReportPartyMember = 14,
    }
}
public record CMsgDOTASubmitLobbyMVPVote(uint target_account_id) : DotaPacket;
public record CMsgDOTASubmitLobbyMVPVoteResponse(uint target_account_id, uint eresult) : DotaPacket;
public record CMsgDOTALobbyMVPAwarded(ulong match_id, List<uint> mvp_account_id) : DotaPacket;
public record CMsgDOTAKickedFromMatchmakingQueue(MatchType match_type) : DotaPacket;
public record CMsgGCMatchDetailsRequest(ulong match_id) : DotaPacket;
public record CMsgGCMatchDetailsResponse(uint result, CMsgDOTAMatch match, DOTAMatchVote vote) : DotaPacket;
public record CMsgDOTAProfileTickets(uint result, uint account_id, List<CMsgDOTAProfileTickets.LeaguePass> league_passes) : DotaPacket
{
    public record LeaguePass(uint league_id, uint item_def);
}
public record CMsgClientToGCGetProfileTickets(uint account_id) : DotaPacket;
public record CMsgGCToClientPartySearchInvites(List<CMsgGCToClientPartySearchInvite> invites) : DotaPacket;
public record CMsgDOTAWelcome(bool unused1, bool unused2, bool unused3, bool unused4, uint store_item_hash, uint timeplayedconsecutively, bool allow_3rd_party_match_history, bool unused8, bool unused9, bool unused10, bool unused11, bool unused12, uint last_ip_address, bool unused14, bool unused15, bool unused16, bool profile_private, uint currency, bool unused19, bool should_request_player_origin, bool unused21, uint gc_socache_file_version, bool unused23, bool is_perfect_world_test_account, bool unused25, List<CMsgDOTAWelcome.CExtraMsg> extra_messages, ulong minimum_recent_item_id, EEvent active_event, uint additional_user_message, uint custom_game_whitelist_version, CMsgGCToClientPartySearchInvites party_search_friend_invites, int remaining_playtime, bool disable_guild_persona_info, List<CExtraMsgBlock> extra_message_blocks) : DotaPacket
{
    public record CExtraMsg(uint id, byte[] contents);
}
public record CSODOTAGameHeroFavorites(uint account_id, int hero_id) : DotaPacket;
public record CMsgDOTAMatchVotes(ulong match_id, List<CMsgDOTAMatchVotes.PlayerVote> votes) : DotaPacket
{
    public record PlayerVote(uint account_id, uint vote);
}
public record CMsgMatchmakingMatchGroupInfo(uint players_searching, int SS1auto_region_select_ping_penalty, EMatchGroupServerStatus status, int SS1auto_region_select_ping_penalty_custom) : DotaPacket;
public record CMsgDOTAMatchmakingStatsRequest : DotaPacket;
public record CMsgDOTAMatchmakingStatsResponse(uint matchgroups_version, bool unused2, bool unused3, bool unused4, bool unused5, bool unused6, List<uint> legacy_searching_players_by_group_source2, List<CMsgMatchmakingMatchGroupInfo> match_groups) : DotaPacket;
public record CMsgDOTAUpdateMatchmakingStats(CMsgDOTAMatchmakingStatsResponse stats) : DotaPacket;
public record CMsgDOTAUpdateMatchManagementStats(CMsgDOTAMatchmakingStatsResponse stats) : DotaPacket;
public record CMsgDOTASetMatchHistoryAccess(bool allow_3rd_party_match_history) : DotaPacket;
public record CMsgDOTASetMatchHistoryAccessResponse(uint eresult) : DotaPacket;
public record CMsgDOTANotifyAccountFlagsChange(uint accountid, uint account_flags) : DotaPacket;
public record CMsgDOTASetProfilePrivacy(bool profile_private) : DotaPacket;
public record CMsgDOTASetProfilePrivacyResponse(uint eresult) : DotaPacket;
public record CMsgUpgradeLeagueItem(ulong match_id, uint league_id) : DotaPacket;
public record CMsgUpgradeLeagueItemResponse : DotaPacket;
public record CMsgGCWatchDownloadedReplay(ulong match_id, DOTA_WatchReplayType watch_type) : DotaPacket;
public record CMsgClientsRejoinChatChannels : DotaPacket;
public record CMsgGCGetHeroStandings : DotaPacket;
public record CMsgGCGetHeroStandingsResponse(List<CMsgGCGetHeroStandingsResponse.Hero> standings) : DotaPacket
{
    public record Hero(int hero_id, uint wins, uint losses, uint win_streak, uint best_win_streak, float avg_kills, float avg_deaths, float avg_assists, float avg_gpm, float avg_xpm, uint best_kills, uint best_assists, uint best_gpm, uint best_xpm, float performance, uint wins_with_ally, uint losses_with_ally, uint wins_against_enemy, uint losses_against_enemy, uint networth_peak, uint lasthit_peak, uint deny_peak, uint damage_peak, uint longest_game_peak, uint healing_peak, float avg_lasthits, float avg_denies);
}
public record CMatchPlayerTimedStatAverages(bool unused1, float kills, float deaths, float assists, float net_worth, float last_hits, float denies, float item_value, float support_gold_spent, float camps_stacked, float wards_placed, float dewards, float triple_kills, float rampages) : DotaPacket;
public record CMatchPlayerTimedStatStdDeviations(bool unused1, float kills, float deaths, float assists, float net_worth, float last_hits, float denies, float item_value, float support_gold_spent, float camps_stacked, float wards_placed, float dewards, float triple_kills, float rampages) : DotaPacket;
public record CMsgGCGetHeroTimedStatsResponse(int hero_id, List<CMsgGCGetHeroTimedStatsResponse.RankChunkedStats> rank_chunked_stats) : DotaPacket
{
    public record TimedStatsContainer(uint time, CMatchPlayerTimedStatAverages all_stats, CMatchPlayerTimedStatAverages winning_stats, CMatchPlayerTimedStatAverages losing_stats, CMatchPlayerTimedStatStdDeviations winning_stddevs, CMatchPlayerTimedStatStdDeviations losing_stddevs);
    public record RankChunkedStats(uint rank_chunk, List<CMsgGCGetHeroTimedStatsResponse.TimedStatsContainer> timed_stats);
}
public record CMsgGCItemEditorReservationsRequest : DotaPacket;
public record CMsgGCItemEditorReservation(uint def_index, string name) : DotaPacket;
public record CMsgGCItemEditorReservationsResponse(List<CMsgGCItemEditorReservation> reservations) : DotaPacket;
public record CMsgGCItemEditorReserveItemDef(uint def_index, string username) : DotaPacket;
public record CMsgGCItemEditorReserveItemDefResponse(uint def_index, string username, uint result) : DotaPacket;
public record CMsgGCItemEditorReleaseReservation(uint def_index, string username) : DotaPacket;
public record CMsgGCItemEditorReleaseReservationResponse(uint def_index, bool released) : DotaPacket;
public record CMsgFlipLobbyTeams : DotaPacket;
public record CMsgGCLobbyUpdateBroadcastChannelInfo(uint channel_id, string country_code, string description, string language_code) : DotaPacket;
public record CMsgDOTAClaimEventActionData(bool unused1, bool unused2, bool unused3, CMsgDOTAClaimEventActionData.GrantItemGiftData grant_item_gift_data) : DotaPacket
{
    public record GrantItemGiftData(uint give_to_account_id, string gift_message);
}
public record CMsgDOTAClaimEventAction(uint event_id, uint action_id, uint quantity, CMsgDOTAClaimEventActionData data, EEventActionScoreMode score_mode) : DotaPacket;
public record CMsgClientToGCClaimEventActionUsingItem(uint event_id, uint action_id, ulong item_id, uint quantity) : DotaPacket;
public record CMsgClientToGCClaimEventActionUsingItemResponse(CMsgDOTAClaimEventActionResponse action_results) : DotaPacket;
public record CMsgGCToClientClaimEventActionUsingItemCompleted(ulong item_id, CMsgDOTAClaimEventActionResponse action_results) : DotaPacket;
public record CMsgDOTAGetEventPoints(uint event_id, uint account_id) : DotaPacket;
public record CMsgDOTAGetEventPointsResponse(uint total_points, uint total_premium_points, uint event_id, uint points, uint premium_points, List<CMsgDOTAGetEventPointsResponse.Action> completed_actions, uint account_id, bool owned, uint audit_action, uint active_season_id) : DotaPacket
{
    public record Action(uint action_id, uint times_completed);
}
public record CMsgDOTAGetPeriodicResource(uint account_id, uint periodic_resource_id, uint timestamp) : DotaPacket;
public record CMsgDOTAGetPeriodicResourceResponse(uint periodic_resource_max, uint periodic_resource_used) : DotaPacket;
public record CMsgDOTAPeriodicResourceUpdated(CMsgDOTAGetPeriodicResource periodic_resource_key, CMsgDOTAGetPeriodicResourceResponse periodic_resource_value) : DotaPacket;
public record CMsgDOTACompendiumSelection(uint selection_index, uint selection, uint leagueid) : DotaPacket;
public record CMsgDOTACompendiumSelectionResponse(uint eresult) : DotaPacket;
public record CMsgDOTACompendiumRemoveAllSelections(uint leagueid) : DotaPacket;
public record CMsgDOTACompendiumRemoveAllSelectionsResponse(uint eresult) : DotaPacket;
public record CMsgDOTACompendiumData(List<CMsgDOTACompendiumSelection> selections) : DotaPacket;
public record CMsgDOTACompendiumDataRequest(uint account_id, uint leagueid) : DotaPacket;
public record CMsgDOTACompendiumDataResponse(uint account_id, uint leagueid, uint result, CMsgDOTACompendiumData compendium_data) : DotaPacket;
public record CMsgDOTAGetPlayerMatchHistory(uint account_id, ulong start_at_match_id, uint matches_requested, int hero_id, uint request_id, bool unused6, bool include_practice_matches, bool include_custom_games, bool include_event_games) : DotaPacket;
public record CMsgDOTAGetPlayerMatchHistoryResponse(List<CMsgDOTAGetPlayerMatchHistoryResponse.Match> matches, uint request_id) : DotaPacket
{
    public record Match(ulong match_id, uint start_time, int hero_id, bool winner, uint game_mode, int rank_change, uint previous_rank, uint lobby_type, bool solo_rank, bool abandon, uint duration, uint engine, bool active_plus_subscription, bool seasonal_rank, uint tourney_id, uint tourney_round, uint tourney_tier, uint tourney_division, uint team_id, string team_name, ulong ugc_team_ui_logo, uint selected_facet);
}
public record CMsgGCNotificationsRequest : DotaPacket;
public record CMsgGCNotifications_Notification(ulong id, uint type, uint timestamp, uint reference_a, uint reference_b, uint reference_c, string message, bool unread) : DotaPacket;
public record CMsgGCNotificationsUpdate(CMsgGCNotificationsUpdate.EResult result, List<CMsgGCNotifications_Notification> notifications) : DotaPacket
{
    public enum EResult
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
    }
}
public record CMsgGCNotificationsResponse(CMsgGCNotificationsUpdate update) : DotaPacket;
public record CMsgGCNotificationsMarkReadRequest : DotaPacket;
public record CMsgGCPlayerInfoSubmit(string name, string country_code, uint fantasy_role, uint team_id, string sponsor) : DotaPacket;
public record CMsgGCPlayerInfoSubmitResponse(CMsgGCPlayerInfoSubmitResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
        ERROR_INFO_LOCKED = 2,
        ERROR_NOT_MEMBER_OF_TEAM = 3,
    }
}
public record CMsgDOTAEmoticonAccessSDO(uint account_id, byte[] unlocked_emoticons) : DotaPacket;
public record CMsgClientToGCEmoticonDataRequest : DotaPacket;
public record CMsgGCToClientEmoticonData(CMsgDOTAEmoticonAccessSDO emoticon_access) : DotaPacket;
public record CMsgGCToClientTournamentItemDrop(uint item_def, uint event_type) : DotaPacket;
public record CMsgClientToGCGetAllHeroOrder : DotaPacket;
public record CMsgClientToGCGetAllHeroOrderResponse(List<int> hero_ids) : DotaPacket;
public record CMsgClientToGCGetAllHeroProgress(uint account_id) : DotaPacket;
public record CMsgClientToGCGetAllHeroProgressResponse(uint account_id, int curr_hero_id, uint laps_completed, uint curr_hero_games, uint curr_lap_time_started, uint curr_lap_games, uint best_lap_games, uint best_lap_time, uint lap_heroes_completed, uint lap_heroes_remaining, int next_hero_id, int prev_hero_id, uint prev_hero_games, float prev_avg_tries, float curr_avg_tries, float next_avg_tries, float full_lap_avg_tries, float curr_lap_avg_tries, string profile_name, int start_hero_id) : DotaPacket;
public record CMsgClientToGCGetTrophyList(uint account_id) : DotaPacket;
public record CMsgClientToGCGetTrophyListResponse(bool unused1, List<CMsgClientToGCGetTrophyListResponse.Trophy> trophies) : DotaPacket
{
    public record Trophy(uint trophy_id, uint trophy_score, uint last_updated);
}
public record CMsgGCToClientTrophyAwarded(uint trophy_id, uint trophy_score, uint trophy_old_score, uint last_updated) : DotaPacket;
public record CMsgClientToGCRankRequest(ERankType rank_type) : DotaPacket;
public record CMsgGCToClientRankResponse(CMsgGCToClientRankResponse.EResultCode result, uint rank_value, uint rank_data1, uint rank_data2, uint rank_data3) : DotaPacket
{
    public enum EResultCode
    {
        k_Succeeded = 0,
        k_Failed = 1,
        k_InvalidRankType = 2,
    }
}
public record CMsgGCToClientRankUpdate(ERankType rank_type, CMsgGCToClientRankResponse rank_info) : DotaPacket;
public record CMsgClientToGCGetProfileCard(uint account_id) : DotaPacket;
public record CMsgClientToGCSetProfileCardSlots(List<CMsgClientToGCSetProfileCardSlots.CardSlot> slots) : DotaPacket
{
    public record CardSlot(uint slot_id, EProfileCardSlotType slot_type, ulong slot_value);
}
public record CMsgClientToGCGetProfileCardStats : DotaPacket;
public record CMsgClientToGCCreateHeroStatue(ulong source_item_id, bool unused2, int hero_id, string sequence_name, float cycle, List<uint> wearables, string inscription, List<uint> styles, ulong reforger_item_id, bool tournament_drop) : DotaPacket;
public record CMsgGCToClientHeroStatueCreateResult(ulong resulting_item_id) : DotaPacket;
public record CMsgClientToGCPlayerStatsRequest(uint account_id) : DotaPacket;
public record CMsgGCToClientPlayerStatsResponse(uint account_id, List<float> player_stats, uint match_count, float mean_gpm, float mean_xppm, float mean_lasthits, uint rampages, uint triple_kills, uint first_blood_claimed, uint first_blood_given, uint couriers_killed, uint aegises_snatched, uint cheeses_eaten, uint creeps_stacked, float fight_score, float farm_score, float support_score, float push_score, float versatility_score, float mean_networth, float mean_damage, float mean_heals, uint rapiers_purchased) : DotaPacket;
public record CMsgClientToGCCustomGamesFriendsPlayedRequest : DotaPacket;
public record CMsgGCToClientCustomGamesFriendsPlayedResponse(uint account_id, List<CMsgGCToClientCustomGamesFriendsPlayedResponse.CustomGame> games) : DotaPacket
{
    public record CustomGame(ulong custom_game_id, List<uint> account_ids);
}
public record CMsgClientToGCSocialFeedPostCommentRequest(ulong event_id, string comment) : DotaPacket;
public record CMsgGCToClientSocialFeedPostCommentResponse(bool success) : DotaPacket;
public record CMsgClientToGCSocialFeedPostMessageRequest(string message, ulong match_id, uint match_timestamp) : DotaPacket;
public record CMsgGCToClientSocialFeedPostMessageResponse(bool success) : DotaPacket;
public record CMsgClientToGCFriendsPlayedCustomGameRequest(ulong custom_game_id) : DotaPacket;
public record CMsgGCToClientFriendsPlayedCustomGameResponse(ulong custom_game_id, List<uint> account_ids) : DotaPacket;
public record CMsgDOTAPartyRichPresence(long SF2party_id, CSODOTAParty.State party_state, bool open, List<CMsgDOTAPartyRichPresence.Member> members, bool low_priority, CMsgDOTAPartyRichPresence.WeekendTourney weekend_tourney, uint team_id, string team_name, ulong ugc_team_ui_logo) : DotaPacket
{
    public record Member(long SF2steam_id, bool coach);
    public record WeekendTourney(uint division, uint skill_level, uint round, uint tournament_id, uint state_seq_num, EWeekendTourneyRichPresenceEvent _event, uint event_round);
}
public record CMsgDOTALobbyRichPresence(long SF2lobby_id, CSODOTALobby.State lobby_state, bool password, DOTA_GameMode game_mode, uint member_count, uint max_member_count, long SF2custom_game_id, string name, uint lobby_type) : DotaPacket;
public record CMsgDOTACustomGameListenServerStartedLoading(long SF2lobby_id, ulong custom_game_id, List<uint> lobby_members, uint start_time) : DotaPacket;
public record CMsgDOTACustomGameClientFinishedLoading(long SF2lobby_id, uint loading_duration, int SS1result_code, string result_string, uint signon_states, string comment) : DotaPacket;
public record CMsgClientToGCApplyGemCombiner(ulong item_id_1, ulong item_id_2) : DotaPacket;
public record CMsgClientToGCH264Unsupported : DotaPacket;
public record CMsgClientToGCGetQuestProgress(List<uint> quest_ids) : DotaPacket;
public record CMsgClientToGCGetQuestProgressResponse(bool success, List<CMsgClientToGCGetQuestProgressResponse.Quest> quests) : DotaPacket
{
    public record Challenge(uint challenge_id, uint time_completed, uint attempts, int hero_id, uint template_id, uint quest_rank);
    public record Quest(uint quest_id, List<CMsgClientToGCGetQuestProgressResponse.Challenge> completed_challenges);
}
public record CMsgGCToClientMatchSignedOut(ulong match_id) : DotaPacket;
public record CMsgGCGetHeroStatsHistory(int hero_id) : DotaPacket;
public record CMsgGCGetHeroStatsHistoryResponse(int hero_id, List<CMsgDOTASDOHeroStatsHistory> records, CMsgGCGetHeroStatsHistoryResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgPlayerConductScorecardRequest : DotaPacket;
public record CMsgPlayerConductScorecard(uint account_id, ulong match_id, uint seq_num, uint reasons, uint matches_in_report, uint matches_clean, uint matches_reported, uint matches_abandoned, uint reports_count, uint reports_parties, uint commend_count, bool unused12, bool unused13, uint date, bool unused15, bool unused16, uint raw_behavior_score, uint old_raw_behavior_score, uint comms_reports, uint comms_parties, CMsgPlayerConductScorecard.EBehaviorRating behavior_rating) : DotaPacket
{
    public enum EBehaviorRating
    {
        k_eBehaviorGood = 0,
        k_eBehaviorWarning = 1,
        k_eBehaviorBad = 2,
    }
}
public record CMsgClientToGCWageringRequest(uint event_id) : DotaPacket;
public record CMsgGCToClientWageringResponse(uint coins_remaining, uint total_points_won, uint total_points_wagered, uint total_points_tipped, uint success_rate, uint total_games_wagered, uint coins_max, uint rank_wagers_remaining, uint rank_wagers_max, uint prediction_tokens_remaining, uint prediction_tokens_max, uint bounties_remaining, uint bounties_max) : DotaPacket;
public record CMsgGCToClientWageringUpdate(uint event_id, CMsgGCToClientWageringResponse wagering_info) : DotaPacket;
public record CMsgGCToClientArcanaVotesUpdate(uint event_id, CMsgClientToGCRequestArcanaVotesRemainingResponse arcana_votes) : DotaPacket;
public record CMsgClientToGCGetEventGoals(List<EEvent> event_ids) : DotaPacket;
public record CMsgEventGoals(List<CMsgEventGoals.EventGoal> event_goals) : DotaPacket
{
    public record EventGoal(EEvent event_id, uint goal_id, ulong value);
}
public record CMsgGCToGCLeaguePredictions(uint league_id) : DotaPacket;
public record CMsgPredictionRankings(List<CMsgPredictionRankings.Prediction> predictions) : DotaPacket
{
    public record PredictionLine(uint answer_id, string answer_name, ulong answer_logo, float answer_value);
    public record Prediction(uint selection_id, List<CMsgPredictionRankings.PredictionLine> prediction_lines);
}
public record CMsgPredictionResults(List<CMsgPredictionResults.Result> results) : DotaPacket
{
    public record ResultBreakdown(bool unused1, uint answer_selection, float answer_value);
    public record Result(uint selection_id, List<CMsgPredictionResults.ResultBreakdown> result_breakdown);
}
public record CMsgClientToGCHasPlayerVotedForMVP(ulong match_id) : DotaPacket;
public record CMsgClientToGCHasPlayerVotedForMVPResponse(bool result) : DotaPacket;
public record CMsgClientToGCVoteForMVP(ulong match_id, bool unused2, uint account_id) : DotaPacket;
public record CMsgClientToGCVoteForMVPResponse(bool result) : DotaPacket;
public record CMsgClientToGCMVPVoteTimeout(ulong match_id) : DotaPacket;
public record CMsgClientToGCMVPVoteTimeoutResponse(bool result) : DotaPacket;
public record CMsgClientToGCTeammateStatsRequest : DotaPacket;
public record CMsgClientToGCTeammateStatsResponse(bool success, List<CMsgClientToGCTeammateStatsResponse.TeammateStat> teammate_stats) : DotaPacket
{
    public record TeammateStat(uint account_id, uint games, uint wins, uint most_recent_game_timestamp, ulong most_recent_game_match_id, bool unused6, bool unused7, bool unused8, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, bool unused20, bool unused21, bool unused22, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, bool unused41, bool unused42, bool unused43, bool unused44, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, bool unused50, bool unused51, bool unused52, bool unused53, bool unused54, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, bool unused60, bool unused61, bool unused62, bool unused63, bool unused64, bool unused65, bool unused66, bool unused67, bool unused68, bool unused69, bool unused70, bool unused71, bool unused72, bool unused73, bool unused74, bool unused75, bool unused76, bool unused77, bool unused78, bool unused79, bool unused80, bool unused81, bool unused82, bool unused83, bool unused84, bool unused85, bool unused86, bool unused87, bool unused88, bool unused89, bool unused90, bool unused91, bool unused92, bool unused93, bool unused94, bool unused95, bool unused96, bool unused97, bool unused98, bool unused99, float performance);
}
public record CMsgClientToGCVoteForArcana(List<CMsgArcanaVoteMatchVotes> matches) : DotaPacket;
public record CMsgClientToGCVoteForArcanaResponse(CMsgClientToGCVoteForArcanaResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCEEDED = 0,
        VOTING_NOT_ENABLED_FOR_ROUND = 1,
        UNKNOWN_FAILURE = 2,
    }
}
public record CMsgClientToGCRequestArcanaVotesRemaining : DotaPacket;
public record CMsgClientToGCRequestArcanaVotesRemainingResponse(bool result, uint votes_remaining, uint votes_total, List<CMsgArcanaVoteMatchVotes> matches_previously_voted_for) : DotaPacket;
public record CMsgClientToGCRequestEventPointLogV2(uint event_id) : DotaPacket;
public record CMsgClientToGCRequestEventPointLogResponseV2(bool result, EEvent event_id, List<CMsgClientToGCRequestEventPointLogResponseV2.LogEntry> log_entries) : DotaPacket
{
    public record LogEntry(uint timestamp, uint audit_action, int event_points, ulong audit_data);
}
public record CMsgClientToGCPublishUserStat(uint user_stats_event, ulong reference_data) : DotaPacket;
public record CMsgClientToGCRequestSlarkGameResult(EEvent event_id, uint slot_chosen, uint week) : DotaPacket;
public record CMsgClientToGCRequestSlarkGameResultResponse(uint points_won, bool aura_won) : DotaPacket;
public record CMsgGCToClientQuestProgressUpdated(uint quest_id, List<CMsgGCToClientQuestProgressUpdated.Challenge> completed_challenges) : DotaPacket
{
    public record Challenge(uint challenge_id, uint time_completed, uint attempts, int hero_id, uint template_id, uint quest_rank, uint max_quest_rank);
}
public record CMsgDOTARedeemItem(ulong currency_id, uint purchase_def) : DotaPacket;
public record CMsgDOTARedeemItemResponse(CMsgDOTARedeemItemResponse.EResultCode response) : DotaPacket
{
    public enum EResultCode
    {
        k_Succeeded = 0,
        k_Failed = 1,
    }
}
public record CMsgClientToGCSelectCompendiumInGamePrediction(ulong match_id, List<CMsgClientToGCSelectCompendiumInGamePrediction.Prediction> predictions, uint league_id) : DotaPacket
{
    public record Prediction(uint prediction_id, uint prediction_value);
}
public record CMsgClientToGCSelectCompendiumInGamePredictionResponse(CMsgClientToGCSelectCompendiumInGamePredictionResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        SUCCESS = 0,
        INVALID_MATCH = 1,
        PREDICTIONS_ARE_CLOSED = 2,
        OTHER_ERROR = 3,
    }
}
public record CMsgClientToGCOpenPlayerCardPack(ulong player_card_pack_item_id, uint team_id, uint deprecated_league_id, ELeagueRegion region) : DotaPacket;
public record CMsgClientToGCOpenPlayerCardPackResponse(CMsgClientToGCOpenPlayerCardPackResponse.Result result, List<ulong> player_card_item_ids) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 1,
        ERROR_INTERNAL = 2,
        ERROR_FAILED_TO_FIND_PACK = 3,
        ERROR_ITEM_NOT_CARD_PACK = 4,
        ERROR_FAILED_CARD_CREATE = 5,
        ERROR_INVALID_TEAM_ID_ATTRIBUTE = 6,
        ERROR_INVALID_TEAM_ID = 7,
    }
}
public record CMsgClientToGCRecyclePlayerCard(bool unused1, uint event_id, List<ulong> player_card_item_ids) : DotaPacket;
public record CMsgClientToGCRecyclePlayerCardResponse(CMsgClientToGCRecyclePlayerCardResponse.Result result, uint dust_amount) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 1,
        ERROR_INTERNAL = 2,
        ERROR_FAILED_TO_FIND_PLAYER_CARD = 3,
        ERROR_ITEM_NOT_PLAYER_CARD = 4,
        ERROR_FAILED_DUST_CARD_CREATE = 5,
        ERROR_CARD_LOCKED = 6,
        ERROR_NO_CARDS_SPECIFIED = 7,
    }
}
public record CMsgClientToGCCreatePlayerCardPack(ulong card_dust_item_id, uint event_id, bool premium_pack) : DotaPacket;
public record CMsgClientToGCCreatePlayerCardPackResponse(CMsgClientToGCCreatePlayerCardPackResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 1,
        ERROR_INTERNAL = 2,
        ERROR_INSUFFICIENT_DUST = 3,
        ERROR_ITEM_NOT_DUST_ITEM = 4,
        ERROR_FAILED_CARD_PACK_CREATE = 5,
        ERROR_NO_CARD_PACK = 6,
        ERROR_NOT_AVAILABLE = 7,
    }
}
public record CMsgClientToGCCreateTeamPlayerCardPack(ulong card_dust_item_id, uint event_id, bool premium_pack, uint team_id) : DotaPacket;
public record CMsgClientToGCCreateTeamPlayerCardPackResponse(CMsgClientToGCCreateTeamPlayerCardPackResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 1,
        ERROR_INTERNAL = 2,
        ERROR_INSUFFICIENT_DUST = 3,
        ERROR_ITEM_NOT_DUST_ITEM = 4,
        ERROR_FAILED_CARD_PACK_CREATE = 5,
        ERROR_NO_CARD_PACK = 6,
        ERROR_NOT_AVAILABLE = 7,
    }
}
public record CMsgGCToClientBattlePassRollup_International2016(uint battle_pass_level, List<CMsgGCToClientBattlePassRollup_International2016.Questlines> questlines, CMsgGCToClientBattlePassRollup_International2016.Wagering wagering, CMsgGCToClientBattlePassRollup_International2016.Achievements achievements, CMsgGCToClientBattlePassRollup_International2016.BattleCup battle_cup, CMsgGCToClientBattlePassRollup_International2016.Predictions predictions, CMsgGCToClientBattlePassRollup_International2016.Bracket bracket, List<CMsgGCToClientBattlePassRollup_International2016.PlayerCard> player_cards, CMsgGCToClientBattlePassRollup_International2016.FantasyChallenge fantasy_challenge) : DotaPacket
{
    public record Questlines(string name, uint onestar, uint twostar, uint threestar, uint total);
    public record Wagering(uint total_wagered, uint total_won, uint average_won, uint success_rate, uint total_tips);
    public record Achievements(uint completed, uint total, uint points);
    public record BattleCup(uint wins, uint score);
    public record Predictions(uint correct, uint total, uint points);
    public record Bracket(uint correct, uint points);
    public record PlayerCard(uint account_id, uint quality);
    public record FantasyChallenge(float total_score, float percentile);
}
public record CMsgGCToClientBattlePassRollup_Fall2016(uint battle_pass_level, List<CMsgGCToClientBattlePassRollup_Fall2016.Questlines> questlines, CMsgGCToClientBattlePassRollup_Fall2016.Wagering wagering, CMsgGCToClientBattlePassRollup_Fall2016.Achievements achievements, CMsgGCToClientBattlePassRollup_Fall2016.BattleCup battle_cup, CMsgGCToClientBattlePassRollup_Fall2016.Predictions predictions, CMsgGCToClientBattlePassRollup_Fall2016.Bracket bracket, List<CMsgGCToClientBattlePassRollup_Fall2016.PlayerCard> player_cards, CMsgGCToClientBattlePassRollup_Fall2016.FantasyChallenge fantasy_challenge) : DotaPacket
{
    public record Questlines(string name, uint onestar, uint twostar, uint threestar, uint total);
    public record Wagering(uint total_wagered, uint total_won, uint average_won, uint success_rate, uint total_tips);
    public record Achievements(uint completed, uint total, uint points);
    public record BattleCup(uint wins, uint score);
    public record Predictions(uint correct, uint total, uint points);
    public record Bracket(uint correct, uint points);
    public record PlayerCard(uint account_id, uint quality);
    public record FantasyChallenge(float total_score, float percentile);
}
public record CMsgGCToClientBattlePassRollup_Winter2017(uint battle_pass_level, List<CMsgGCToClientBattlePassRollup_Winter2017.Questlines> questlines, CMsgGCToClientBattlePassRollup_Winter2017.Wagering wagering, CMsgGCToClientBattlePassRollup_Winter2017.Achievements achievements, CMsgGCToClientBattlePassRollup_Winter2017.BattleCup battle_cup, CMsgGCToClientBattlePassRollup_Winter2017.Predictions predictions, CMsgGCToClientBattlePassRollup_Winter2017.Bracket bracket, List<CMsgGCToClientBattlePassRollup_Winter2017.PlayerCard> player_cards, CMsgGCToClientBattlePassRollup_Winter2017.FantasyChallenge fantasy_challenge) : DotaPacket
{
    public record Questlines(string name, uint onestar, uint twostar, uint threestar, uint total);
    public record Wagering(uint total_wagered, uint total_won, uint average_won, uint success_rate, uint total_tips);
    public record Achievements(uint completed, uint total, uint points);
    public record BattleCup(uint wins, uint score);
    public record Predictions(uint correct, uint total, uint points);
    public record Bracket(uint correct, uint points);
    public record PlayerCard(uint account_id, uint quality);
    public record FantasyChallenge(float total_score, float percentile);
}
public record CMsgGCToClientBattlePassRollup_TI7(uint battle_pass_level, List<CMsgGCToClientBattlePassRollup_TI7.Questlines> questlines, CMsgGCToClientBattlePassRollup_TI7.Wagering wagering, CMsgGCToClientBattlePassRollup_TI7.Achievements achievements, CMsgGCToClientBattlePassRollup_TI7.BattleCup battle_cup, CMsgGCToClientBattlePassRollup_TI7.Predictions predictions, CMsgGCToClientBattlePassRollup_TI7.Bracket bracket, List<CMsgGCToClientBattlePassRollup_TI7.PlayerCard> player_cards, CMsgGCToClientBattlePassRollup_TI7.FantasyChallenge fantasy_challenge) : DotaPacket
{
    public record Questlines(string name, uint onestar, uint twostar, uint threestar, uint total);
    public record Wagering(uint total_wagered, uint total_won, uint average_won, uint success_rate, uint total_tips);
    public record Achievements(uint completed, uint total, uint points);
    public record BattleCup(uint wins, uint score);
    public record Predictions(uint correct, uint total, uint points);
    public record Bracket(uint correct, uint points);
    public record PlayerCard(uint account_id, uint quality);
    public record FantasyChallenge(float total_score, float percentile);
}
public record CMsgGCToClientBattlePassRollup_TI8(uint battle_pass_level, CMsgGCToClientBattlePassRollup_TI8.CavernCrawl cavern_crawl, CMsgGCToClientBattlePassRollup_TI8.Wagering wagering, CMsgGCToClientBattlePassRollup_TI8.Achievements achievements, bool unused5, CMsgGCToClientBattlePassRollup_TI8.Predictions predictions, CMsgGCToClientBattlePassRollup_TI8.Bracket bracket, List<CMsgGCToClientBattlePassRollup_TI8.PlayerCard> player_cards, CMsgGCToClientBattlePassRollup_TI8.FantasyChallenge fantasy_challenge) : DotaPacket
{
    public record CavernCrawl(uint rooms_cleared, bool carry_completed, bool support_completed, bool utility_completed);
    public record Wagering(uint total_wagered, uint total_won, uint average_won, uint success_rate, uint total_tips);
    public record Achievements(uint completed, uint total, uint points);
    public record Predictions(uint correct, uint total, uint points);
    public record Bracket(uint correct, uint points);
    public record PlayerCard(uint account_id, uint quality);
    public record FantasyChallenge(float total_score, float percentile);
}
public record CMsgGCToClientBattlePassRollup_TI9(uint battle_pass_level) : DotaPacket;
public record CMsgGCToClientBattlePassRollup_TI10(uint battle_pass_level) : DotaPacket;
public record CMsgGCToClientBattlePassRollupRequest(uint event_id, uint account_id) : DotaPacket;
public record CMsgGCToClientBattlePassRollupResponse(CMsgGCToClientBattlePassRollup_International2016 event_ti6, CMsgGCToClientBattlePassRollup_Fall2016 event_fall2016, CMsgGCToClientBattlePassRollup_Winter2017 event_winter2017, CMsgGCToClientBattlePassRollup_TI7 event_ti7, CMsgGCToClientBattlePassRollup_TI8 event_ti8, CMsgGCToClientBattlePassRollup_TI9 event_ti9, CMsgGCToClientBattlePassRollup_TI10 event_ti10) : DotaPacket;
public record CMsgGCToClientBattlePassRollupListRequest(uint account_id) : DotaPacket;
public record CMsgGCToClientBattlePassRollupListResponse(List<CMsgGCToClientBattlePassRollupListResponse.EventInfo> event_info) : DotaPacket
{
    public record EventInfo(uint event_id, uint level);
}
public record CMsgClientToGCTransferSeasonalMMRRequest(bool is_party) : DotaPacket;
public record CMsgClientToGCTransferSeasonalMMRResponse(bool success) : DotaPacket;
public record CMsgGCToClientPlaytestStatus(bool active) : DotaPacket;
public record CMsgClientToGCJoinPlaytest(uint client_version) : DotaPacket;
public record CMsgClientToGCJoinPlaytestResponse(string error) : DotaPacket;
public record CMsgDOTASetFavoriteTeam(uint team_id, uint event_id) : DotaPacket;
public record CMsgDOTATriviaCurrentQuestions(List<CMsgDOTATriviaQuestion> questions, bool trivia_enabled) : DotaPacket;
public record CMsgDOTASubmitTriviaQuestionAnswer(uint question_id, uint answer_index) : DotaPacket;
public record CMsgDOTASubmitTriviaQuestionAnswerResponse(EDOTATriviaAnswerResult result) : DotaPacket;
public record CMsgDOTAStartTriviaSession : DotaPacket;
public record CMsgDOTAStartTriviaSessionResponse(bool trivia_enabled, uint current_timestamp) : DotaPacket;
public record CMsgDOTAAnchorPhoneNumberRequest : DotaPacket;
public record CMsgDOTAAnchorPhoneNumberResponse(CMsgDOTAAnchorPhoneNumberResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        ERROR_NO_STEAM_PHONE = 2,
        ERROR_ALREADY_IN_USE = 3,
        ERROR_COOLDOWN_ACTIVE = 4,
        ERROR_GAC_ISSUE = 5,
    }
}
public record CMsgDOTAUnanchorPhoneNumberRequest : DotaPacket;
public record CMsgDOTAUnanchorPhoneNumberResponse(CMsgDOTAUnanchorPhoneNumberResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
    }
}
public record CMsgGCToClientCommendNotification(uint commender_account_id, string commender_name, uint flags, int commender_hero_id) : DotaPacket;
public record CMsgDOTAClientToGCQuickStatsRequest(uint player_account_id, int hero_id, int item_id, uint league_id) : DotaPacket;
public record CMsgDOTAClientToGCQuickStatsResponse(CMsgDOTAClientToGCQuickStatsRequest original_request, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats hero_stats, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats item_stats, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats item_hero_stats, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats item_player_stats, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats hero_player_stats, CMsgDOTAClientToGCQuickStatsResponse.SimpleStats full_set_stats) : DotaPacket
{
    public record SimpleStats(float win_percent, float pick_percent, uint win_count, uint pick_count);
}
public record CMsgDOTASelectionPriorityChoiceRequest(DOTASelectionPriorityChoice choice) : DotaPacket;
public record CMsgDOTASelectionPriorityChoiceResponse(CMsgDOTASelectionPriorityChoiceResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
    }
}
public record CMsgDOTAGameAutographReward(string badge_id) : DotaPacket;
public record CMsgDOTAGameAutographRewardResponse(CMsgDOTAGameAutographRewardResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
    }
}
public record CMsgDOTADestroyLobbyRequest : DotaPacket;
public record CMsgDOTADestroyLobbyResponse(CMsgDOTADestroyLobbyResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
    }
}
public record CMsgDOTAGetRecentPlayTimeFriendsRequest : DotaPacket;
public record CMsgDOTAGetRecentPlayTimeFriendsResponse(List<int> SF1account_ids) : DotaPacket;
public record CMsgPurchaseItemWithEventPoints(uint item_def, uint quantity, EEvent event_id, bool use_premium_points) : DotaPacket;
public record CMsgPurchaseItemWithEventPointsResponse(CMsgPurchaseItemWithEventPointsResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        UNKNOWN_EVENT = 1,
        UNKNOWN_ITEM = 2,
        BAD_QUANTITY = 3,
        NOT_PURCHASEABLE = 4,
        SDO_LOAD_FAILED = 5,
        NOT_ENOUGH_POINTS = 6,
        SQL_ERROR = 7,
        FAILED_TO_SEND = 8,
        SERVER_ERROR = 9,
        NOT_ALLOWED = 10,
        CANCELLED = 11,
        CLIENT_ERROR = 12,
        SUBSCRIPTION_REQUIRED = 13,
    }
}
public record CMsgPurchaseHeroRandomRelic(int hero_id, EHeroRelicRarity relic_rarity) : DotaPacket;
public record CMsgPurchaseHeroRandomRelicResponse(EPurchaseHeroRelicResult result, uint kill_eater_type) : DotaPacket;
public record CMsgClientToGCRequestPlusWeeklyChallengeResult(EEvent event_id, uint week) : DotaPacket;
public record CMsgClientToGCRequestPlusWeeklyChallengeResultResponse : DotaPacket;
public record CMsgProfileRequest(uint account_id) : DotaPacket;
public record CMsgProfileResponse(CSOEconItem background_item, List<CMsgProfileResponse.FeaturedHero> featured_heroes, List<CMsgProfileResponse.MatchInfo> recent_matches, List<CMsgSuccessfulHero> successful_heroes, CMsgRecentMatchInfo recent_match_details, CMsgProfileResponse.EResponse result, CMsgStickerbookPage stickerbook_page) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
    public record FeaturedHero(int hero_id, List<CSOEconItem> equipped_econ_items, bool manually_set, uint plus_hero_xp, CSOEconItem plus_hero_relics_item);
    public record MatchInfo(ulong match_id, uint match_timestamp, int SS1performance_rating, int hero_id, bool won_match);
}
public record CMsgProfileUpdate(ulong background_item_id, List<int> featured_hero_ids) : DotaPacket;
public record CMsgProfileUpdateResponse(CMsgProfileUpdateResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE = 1,
        FAILURE_BAD_HERO1 = 2,
        FAILURE_BAD_HERO2 = 3,
        FAILURE_BAD_HERO3 = 4,
    }
}
public record CMsgTalentWinRates(uint last_run, int ability_id, uint game_count, uint win_count) : DotaPacket;
public record CMsgGlobalHeroAverages(uint last_run, bool unused2, uint avg_gold_per_min, uint avg_xp_per_min, uint avg_kills, uint avg_deaths, uint avg_assists, uint avg_last_hits, uint avg_denies, uint avg_net_worth) : DotaPacket;
public record CMsgHeroGlobalDataRequest(int hero_id) : DotaPacket;
public record CMsgHeroGlobalDataResponse(int hero_id, List<CMsgHeroGlobalDataResponse.HeroDataPerRankChunk> hero_data_per_chunk) : DotaPacket
{
    public record GraphData(uint day, float win_percent, float pick_percent, float ban_percent);
    public record WeekData(uint week, float win_percent, float pick_percent, float ban_percent);
    public record HeroDataPerRankChunk(uint rank_chunk, List<CMsgTalentWinRates> talent_win_rates, CMsgGlobalHeroAverages hero_averages, List<CMsgHeroGlobalDataResponse.GraphData> graph_data, List<CMsgHeroGlobalDataResponse.WeekData> week_data);
}
public record CMsgHeroGlobalDataAllHeroes(List<CMsgHeroGlobalDataResponse> heroes) : DotaPacket;
public record CMsgHeroGlobalDataHeroesAlliesAndEnemies(List<CMsgHeroGlobalDataHeroesAlliesAndEnemies.RankedHeroData> ranked_hero_data) : DotaPacket
{
    public record HeroData(int hero_id, uint win_rate, int first_other_hero_id, bool unused4, List<uint> ally_win_rate, List<uint> enemy_win_rate);
    public record RankedHeroData(uint rank, List<CMsgHeroGlobalDataHeroesAlliesAndEnemies.HeroData> hero_data);
}
public record CMsgPrivateMetadataKeyRequest(ulong match_id) : DotaPacket;
public record CMsgPrivateMetadataKeyResponse(uint private_key) : DotaPacket;
public record CMsgActivatePlusFreeTrialResponse(CMsgActivatePlusFreeTrialResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_GENERIC = 1,
        ERROR_ALREADY_IN_FREE_TRIAL = 2,
        ERROR_ALREADY_USED_FREE_TRIAL = 3,
        ERROR_OFFER_NOT_VALID = 4,
    }
}
public record CMsgGCToClientCavernCrawlMapPathCompleted(uint event_id, int hero_id_completed, List<CMsgGCToClientCavernCrawlMapPathCompleted.CompletedPathInfo> completed_paths, uint map_variant) : DotaPacket
{
    public record CompletedPathInfo(uint path_id_completed, bool received_ultra_rare_reward, bool half_completed);
}
public record CMsgGCToClientCavernCrawlMapUpdated(uint event_id) : DotaPacket;
public record CMsgClientToGCCavernCrawlClaimRoom(uint event_id, uint room_id, uint map_variant) : DotaPacket;
public record CMsgClientToGCCavernCrawlClaimRoomResponse(CMsgClientToGCCavernCrawlClaimRoomResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        RECEIVED_ULTRA_RARE_REWARD = 2,
    }
}
public record CMsgClientToGCCavernCrawlUseItemOnRoom(uint event_id, uint room_id, uint item_type, uint map_variant) : DotaPacket;
public record CMsgClientToGCCavernCrawlUseItemOnRoomResponse(CMsgClientToGCCavernCrawlUseItemOnRoomResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        RECEIVED_ULTRA_RARE_REWARD = 2,
    }
}
public record CMsgClientToGCCavernCrawlUseItemOnPath(uint event_id, uint path_id, uint item_type, uint map_variant) : DotaPacket;
public record CMsgClientToGCCavernCrawlUseItemOnPathResponse(CMsgClientToGCCavernCrawlUseItemOnPathResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        RECEIVED_ULTRA_RARE_REWARD = 2,
    }
}
public record CMsgClientToGCCavernCrawlRequestMapState(uint event_id) : DotaPacket;
public record CMsgClientToGCCavernCrawlRequestMapStateResponse(CMsgClientToGCCavernCrawlRequestMapStateResponse.Result result, uint available_map_variants_mask, List<CMsgClientToGCCavernCrawlRequestMapStateResponse.InventoryItem> inventory_item, List<CMsgClientToGCCavernCrawlRequestMapStateResponse.MapVariant> map_variants) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        EVENT_NOT_OWNED = 2,
    }
    public record SwappedChallenge(uint path_id_1, uint path_id_2);
    public record InventoryItem(uint item_type, uint count);
    public record TreasureMap(uint map_room_id, uint revealed_room_id);
    public record MapVariant(uint map_variant, long SF2claimed_rooms_1, long SF2claimed_rooms_2, long SF2revealed_rooms_1, long SF2revealed_rooms_2, long SF2completed_paths_1, long SF2completed_paths_2, long SF2completed_paths_3, long SF2completed_paths_4, long SF2half_completed_paths_1, long SF2half_completed_paths_2, long SF2half_completed_paths_3, long SF2half_completed_paths_4, List<CMsgClientToGCCavernCrawlRequestMapStateResponse.SwappedChallenge> swapped_challenge, uint ultra_rare_reward_room_number, List<CMsgClientToGCCavernCrawlRequestMapStateResponse.TreasureMap> treasure_map);
}
public record CMsgClientToGCCavernCrawlGetClaimedRoomCount(uint event_id) : DotaPacket;
public record CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Result result, List<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.MapVariant> map_variants, uint available_map_variants_mask) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        ERROR_UNKNOWN = 1,
        EVENT_NOT_OWNED = 2,
    }
    public record MapVariant(uint map_variant, uint count);
}
public record CMsgDOTAMutationList(List<CMsgDOTAMutationList.Mutation> mutations) : DotaPacket
{
    public record Mutation(uint id, string name, string description);
}
public record CMsgEventTipsSummaryRequest(EEvent event_id, uint account_id) : DotaPacket;
public record CMsgEventTipsSummaryResponse(bool result, List<CMsgEventTipsSummaryResponse.Tipper> tips_received) : DotaPacket
{
    public record Tipper(uint tipper_account_id, uint tip_count);
}
public record CMsgSocialFeedRequest(uint account_id, bool self_only) : DotaPacket;
public record CMsgSocialFeedResponse(CMsgSocialFeedResponse.Result result, List<CMsgSocialFeedResponse.FeedEvent> feed_events) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILED_TO_LOAD_FRIENDS = 1,
        FAILED_TO_LOAD_FEED_DATA = 2,
        FAILED_TO_LOAD_FEED_ENTRY = 3,
        FAILED_TO_LOAD_COMMENTS = 4,
        FAILED_TOO_MANY_REQUESTS = 5,
    }
    public record FeedEvent(ulong feed_event_id, uint account_id, uint timestamp, uint comment_count, uint event_type, uint event_sub_type, ulong param_big_int_1, uint param_int_1, uint param_int_2, uint param_int_3, string param_string);
}
public record CMsgSocialFeedCommentsRequest(ulong feed_event_id) : DotaPacket;
public record CMsgSocialFeedCommentsResponse(CMsgSocialFeedCommentsResponse.Result result, bool unused2, List<CMsgSocialFeedCommentsResponse.FeedComment> feed_comments) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILED_TOO_MANY_REQUESTS = 1,
        FAILED_TO_LOAD_COMMENTS = 2,
    }
    public record FeedComment(uint commenter_account_id, uint timestamp, string comment_text);
}
public record CMsgClientToGCPlayerCardSpecificPurchaseRequest(uint player_account_id, uint event_id, ulong card_dust_item_id) : DotaPacket;
public record CMsgClientToGCPlayerCardSpecificPurchaseResponse(CMsgClientToGCPlayerCardSpecificPurchaseResponse.Result result, ulong item_id) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 1,
        ERROR_INTERNAL = 2,
        ERROR_INSUFFICIENT_DUST = 3,
        ERROR_ITEM_NOT_DUST_ITEM = 4,
        ERROR_FAILED_CARD_PACK_CREATE = 5,
        ERROR_NOT_AVAILABLE = 6,
    }
}
public record CMsgClientToGCRequestContestVotes(uint contest_id) : DotaPacket;
public record CMsgClientToGCRequestContestVotesResponse(CMsgClientToGCRequestContestVotesResponse.EResponse result, List<CMsgClientToGCRequestContestVotesResponse.ItemVote> votes) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
    public record ItemVote(ulong contest_item_id, int vote);
}
public record CMsgClientToGCRecordContestVote(uint contest_id, ulong contest_item_id, int vote) : DotaPacket;
public record CMsgGCToClientRecordContestVoteResponse(CMsgGCToClientRecordContestVoteResponse.EResult eresult) : DotaPacket
{
    public enum EResult
    {
        SUCCESS = 0,
        FAILED_EVENT_NOT_OWNED = 1,
        FAILED_SQL_INSERT_FAILED = 2,
        FAILED_INVALID_CONTEST = 3,
        FAILED_CONTEST_NOT_ACTIVE = 4,
        FAILED_TIMEOUT = 5,
    }
}
public record CMsgDevGrantEventPoints(EEvent event_id, uint event_points, uint premium_points) : DotaPacket;
public record CMsgDevGrantEventPointsResponse(EDevEventRequestResult result) : DotaPacket;
public record CMsgDevGrantEventAction(EEvent event_id, uint action_id, uint action_score) : DotaPacket;
public record CMsgDevGrantEventActionResponse(EDevEventRequestResult result) : DotaPacket;
public record CMsgDevDeleteEventActions(EEvent event_id, uint start_action_id, uint end_action_id, bool remove_audit) : DotaPacket;
public record CMsgDevDeleteEventActionsResponse(EDevEventRequestResult result) : DotaPacket;
public record CMsgDevResetEventState(EEvent event_id, bool remove_audit) : DotaPacket;
public record CMsgDevResetEventStateResponse(EDevEventRequestResult result) : DotaPacket;
public record CMsgConsumeEventSupportGrantItem(ulong item_id) : DotaPacket;
public record CMsgConsumeEventSupportGrantItemResponse(ESupportEventRequestResult result) : DotaPacket;
public record CMsgClientToGCGetFilteredPlayers : DotaPacket;
public record CMsgGCToClientGetFilteredPlayersResponse(CMsgGCToClientGetFilteredPlayersResponse.Result result, List<CMsgGCToClientGetFilteredPlayersResponse.CFilterEntry> filtered_players, int base_slots, int additional_slots, int next_slot_cost) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE = 1,
    }
    public record CFilterEntry(int SF1account_id, int SF1time_added, int SF1time_expires, string note);
}
public record CMsgClientToGCRemoveFilteredPlayer(int SF1account_id_to_remove) : DotaPacket;
public record CMsgGCToClientRemoveFilteredPlayerResponse(CMsgGCToClientRemoveFilteredPlayerResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE = 1,
    }
}
public record CMsgClientToGCPurchaseFilteredPlayerSlot(int additional_slots_current) : DotaPacket;
public record CMsgGCToClientPurchaseFilteredPlayerSlotResponse(CMsgGCToClientPurchaseFilteredPlayerSlotResponse.Result result, int additional_slots, int next_slot_cost) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE = 1,
        CURRENT_SLOTCOUNT_DOESNT_MATCH = 2,
        CANT_AFFORD = 3,
    }
}
public record CMsgClientToGCUpdateFilteredPlayerNote(int SF1target_account_id, string new_note) : DotaPacket;
public record CMsgGCToClientUpdateFilteredPlayerNoteResponse(CMsgGCToClientUpdateFilteredPlayerNoteResponse.Result result) : DotaPacket
{
    public enum Result
    {
        SUCCESS = 0,
        FAILURE = 1,
        NOT_FOUND = 2,
    }
}
public record CMsgPartySearchPlayer(int SF1account_id, long SF2match_id, int SF1creation_time) : DotaPacket;
public record CMsgGCToClientPlayerBeaconState(List<int> num_active_beacons) : DotaPacket;
public record CMsgGCToClientPartyBeaconUpdate(bool beacon_added, int beacon_type, int SF1account_id) : DotaPacket;
public record CMsgClientToGCUpdatePartyBeacon(CMsgClientToGCUpdatePartyBeacon.Action action) : DotaPacket
{
    public enum Action
    {
        ON = 0,
        OFF = 1,
    }
}
public record CMsgClientToGCRequestActiveBeaconParties : DotaPacket;
public record CMsgGCToClientRequestActiveBeaconPartiesResponse(CMsgGCToClientRequestActiveBeaconPartiesResponse.EResponse response, List<CPartySearchClientParty> active_parties) : DotaPacket
{
    public enum EResponse
    {
        SUCCESS = 0,
        FAILURE = 1,
        BUSY = 2,
    }
}
public record CMsgClientToGCJoinPartyFromBeacon(long SF2party_id, int SF1account_id, int beacon_type) : DotaPacket;
public record CMsgGCToClientJoinPartyFromBeaconResponse(CMsgGCToClientJoinPartyFromBeaconResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        SUCCESS = 0,
        FAILURE = 1,
        BUSY = 2,
        NOT_LEADER = 3,
    }
}
public record CMsgClientToGCManageFavorites(CMsgClientToGCManageFavorites.Action action, int SF1account_id, string favorite_name, bool invite_response, bool from_friendlist, long SF2lobby_id) : DotaPacket
{
    public enum Action
    {
        ADD = 0,
        REMOVE = 1,
    }
}
public record CMsgGCToClientManageFavoritesResponse(CMsgGCToClientManageFavoritesResponse.EResponse response, string debug_message, CMsgPartySearchPlayer player) : DotaPacket
{
    public enum EResponse
    {
        SUCCESS = 0,
        FAILURE = 1,
        NO_INVITE_PRESENT = 2,
        INVITE_SENT = 3,
        EXPIRED = 4,
        BUSY = 5,
    }
}
public record CMsgClientToGCGetFavoritePlayers(ulong pagination_key, int pagination_count) : DotaPacket;
public record CMsgGCToClientGetFavoritePlayersResponse(CMsgGCToClientGetFavoritePlayersResponse.EResponse response, List<CMsgPartySearchPlayer> players, ulong next_pagination_key) : DotaPacket
{
    public enum EResponse
    {
        SUCCESS = 0,
        FAILURE = 1,
    }
}
public record CMsgGCToClientPartySearchInvite(int SF1account_id) : DotaPacket;
public record CMsgClientToGCVerifyFavoritePlayers(List<int> SF1account_ids) : DotaPacket;
public record CMsgGCToClientVerifyFavoritePlayersResponse(List<CMsgGCToClientVerifyFavoritePlayersResponse.Result> results) : DotaPacket
{
    public record Result(CMsgPartySearchPlayer player, bool is_favorite);
}
public record CMsgClientToGCRequestPlayerRecentAccomplishments(uint account_id) : DotaPacket;
public record CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.EResponse result, CMsgPlayerRecentAccomplishments player_accomplishments) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgClientToGCRequestPlayerHeroRecentAccomplishments(uint account_id, int hero_id) : DotaPacket;
public record CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.EResponse result, CMsgPlayerHeroRecentAccomplishments hero_accomplishments) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgClientToGCSubmitPlayerMatchSurvey(ulong match_id, bool unused2, int SS1rating, uint flags) : DotaPacket;
public record CMsgClientToGCSubmitPlayerMatchSurveyResponse(CMsgClientToGCSubmitPlayerMatchSurveyResponse.EResponse eresult, uint account_id) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eAlreadySubmitted = 4,
        k_ePlayerNotValid = 5,
    }
}
public record CMsgGCToClientVACReminder : DotaPacket;
public record CMsgClientToGCUnderDraftRequest(uint account_id, uint event_id) : DotaPacket;
public record CMsgClientToGCUnderDraftResponse(EUnderDraftResponse result, uint account_id, uint event_id, CMsgUnderDraftData draft_data) : DotaPacket;
public record CMsgClientToGCUnderDraftReroll(uint event_id) : DotaPacket;
public record CMsgClientToGCUnderDraftRerollResponse(EUnderDraftResponse result, uint event_id, CMsgUnderDraftData draft_data) : DotaPacket;
public record CMsgClientToGCUnderDraftBuy(uint event_id, uint slot_id) : DotaPacket;
public record CMsgGCToClientGuildUnderDraftGoldUpdated(uint event_id) : DotaPacket;
public record CMsgClientToGCUnderDraftBuyResponse(EUnderDraftResponse result, uint event_id, uint slot_id, CMsgUnderDraftData draft_data) : DotaPacket;
public record CMsgClientToGCUnderDraftRollBackBench(uint event_id) : DotaPacket;
public record CMsgClientToGCUnderDraftRollBackBenchResponse(EUnderDraftResponse result, uint event_id, CMsgUnderDraftData draft_data) : DotaPacket;
public record CMsgClientToGCUnderDraftSell(uint event_id, uint slot_id) : DotaPacket;
public record CMsgClientToGCUnderDraftSellResponse(EUnderDraftResponse result, uint event_id, uint slot_id, CMsgUnderDraftData draft_data) : DotaPacket;
public record CMsgClientToGCUnderDraftRedeemReward(uint event_id, uint action_id) : DotaPacket;
public record CMsgClientToGCUnderDraftRedeemRewardResponse(EUnderDraftResponse result) : DotaPacket;
public record CMsgClientToGCSubmitDraftTriviaMatchAnswer(bool chose_radiant_as_winner, uint event_id, uint end_time) : DotaPacket;
public record CMsgClientToGCSubmitDraftTriviaMatchAnswerResponse(EDOTADraftTriviaAnswerResult result) : DotaPacket;
public record CMsgDraftTriviaVoteCount(uint total_votes, uint radiant_votes, uint dire_votes) : DotaPacket;
public record CMsgClientToGCRequestReporterUpdates : DotaPacket;
public record CMsgClientToGCRequestReporterUpdatesResponse(CMsgClientToGCRequestReporterUpdatesResponse.EResponse enum_result, List<CMsgClientToGCRequestReporterUpdatesResponse.ReporterUpdate> updates, int num_reported, int num_no_action_taken) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 3,
        k_eNotPermitted = 4,
        k_eNotToSoon = 5,
        k_eNotValid = 6,
    }
    public record ReporterUpdate(ulong match_id, int hero_id, uint report_reason, uint timestamp);
}
public record CMsgClientToGCAcknowledgeReporterUpdates(List<ulong> match_ids) : DotaPacket;
public record CMsgClientToGCRecalibrateMMR : DotaPacket;
public record CMsgClientToGCRecalibrateMMRResponse(CMsgClientToGCRecalibrateMMRResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 3,
        k_eNotPermitted = 4,
        k_eNotToSoon = 5,
        k_eNotValid = 6,
    }
}
public record CMsgDOTAPostGameItemAwardNotification(uint receiver_account_id, List<uint> item_def_index, uint action_id) : DotaPacket;
public record CMsgClientToGCGetOWMatchDetails : DotaPacket;
public record CMsgClientToGCGetOWMatchDetailsResponse(CMsgClientToGCGetOWMatchDetailsResponse.EResponse result, ulong overwatch_replay_id, ulong decryption_key, uint cluster, uint overwatch_salt, uint target_player_slot, List<CMsgClientToGCGetOWMatchDetailsResponse.Marker> markers, EOverwatchReportReason report_reason, int target_hero_id, uint rank_tier, uint lane_selection_flags) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 3,
        k_eNotPermitted = 4,
        k_eNoCaseAvailable = 5,
    }
    public record Marker(uint start_game_time_s, uint end_game_time_s);
}
public record CMsgClientToGCSubmitOWConviction(ulong overwatch_replay_id, uint target_player_slot, EOverwatchConviction cheating_conviction, EOverwatchConviction griefing_conviction) : DotaPacket;
public record CMsgClientToGCSubmitOWConvictionResponse(CMsgClientToGCSubmitOWConvictionResponse.EResponse result, ulong overwatch_replay_id) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 3,
        k_eNotPermitted = 4,
        k_eInvalidReplayID = 5,
        k_eInvalidConviction = 6,
        k_eInvalidPlayerSlot = 7,
    }
}
public record CMsgClientToGCChinaSSAURLRequest : DotaPacket;
public record CMsgClientToGCChinaSSAURLResponse(string agreement_url) : DotaPacket;
public record CMsgClientToGCChinaSSAAcceptedRequest : DotaPacket;
public record CMsgClientToGCChinaSSAAcceptedResponse(bool agreement_accepted) : DotaPacket;
public record CMsgGCToClientOverwatchCasesAvailable(int SF1expire_time) : DotaPacket;
public record CMsgClientToGCStartWatchingOverwatch(ulong overwatch_replay_id, uint target_player_slot) : DotaPacket;
public record CMsgClientToGCStopWatchingOverwatch(ulong overwatch_replay_id, uint target_player_slot) : DotaPacket;
public record CMsgClientToGCOverwatchReplayError(ulong overwatch_replay_id) : DotaPacket;
public record CMsgClientToGCGetDPCFavorites : DotaPacket;
public record CMsgClientToGCGetDPCFavoritesResponse(CMsgClientToGCGetDPCFavoritesResponse.EResponse result, List<CMsgClientToGCGetDPCFavoritesResponse.Favorite> favorites) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidRequest = 5,
    }
    public record Favorite(EDPCFavoriteType favorite_type, uint favorite_id);
}
public record CMsgClientToGCSetDPCFavoriteState(EDPCFavoriteType favorite_type, uint favorite_id, bool enabled) : DotaPacket;
public record CMsgClientToGCSetDPCFavoriteStateResponse(CMsgClientToGCSetDPCFavoriteStateResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eFavoriteTypeOutOfRange = 2,
        k_eLockFailed = 3,
        k_eAlreadyFavorited = 4,
        k_eAlreadyUnfavorited = 5,
        k_eInsertRecordFailed = 6,
        k_eRemoveRecordFailed = 7,
        k_eTimeout = 8,
    }
}
public record CMsgClientToGCSetEventActiveSeasonID(uint event_id, uint active_season_id) : DotaPacket;
public record CMsgClientToGCSetEventActiveSeasonIDResponse(CMsgClientToGCSetEventActiveSeasonIDResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eDisabled = 2,
        k_eTooBusy = 3,
        k_eNotAllowed = 4,
        k_eTimeout = 5,
        k_eInternalSuccessNoChange = 6,
    }
}
public record CMsgClientToGCPurchaseLabyrinthBlessings(EEvent event_id, List<int> blessing_ids, bool debug, bool debug_remove) : DotaPacket;
public record CMsgClientToGCPurchaseLabyrinthBlessingsResponse(CMsgClientToGCPurchaseLabyrinthBlessingsResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eNoSuchBlessing = 2,
        k_eNotEnoughShards = 3,
        k_eNoPath = 4,
        k_eTimeout = 5,
    }
}
public record CMsgClientToGCGetStickerbookRequest(uint account_id) : DotaPacket;
public record CMsgClientToGCGetStickerbookResponse(CMsgClientToGCGetStickerbookResponse.EResponse response, CMsgStickerbook stickerbook) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eNotAllowed = 3,
        k_eTooBusy = 4,
    }
}
public record CMsgClientToGCCreateStickerbookPageRequest(uint team_id, EEvent event_id, EStickerbookPageType page_type) : DotaPacket;
public record CMsgClientToGCCreateStickerbookPageResponse(CMsgClientToGCCreateStickerbookPageResponse.EResponse response, uint page_number) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooManyPages = 3,
        k_eTooBusy = 4,
    }
}
public record CMsgClientToGCDeleteStickerbookPageRequest(uint page_num, uint sticker_count, uint sticker_max) : DotaPacket;
public record CMsgClientToGCDeleteStickerbookPageResponse(CMsgClientToGCDeleteStickerbookPageResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eInvalidStickerCount = 3,
        k_eTooBusy = 4,
        k_eInvalidStickerMax = 5,
        k_eInvalidPage = 6,
    }
}
public record CMsgClientToGCPlaceStickersRequest(List<CMsgClientToGCPlaceStickersRequest.StickerItem> sticker_items) : DotaPacket
{
    public record StickerItem(bool unused1, uint page_num, CMsgStickerbookSticker sticker);
}
public record CMsgClientToGCPlaceStickersResponse(CMsgClientToGCPlaceStickersResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eMissingItem = 3,
        k_eTooBusy = 4,
        k_eDuplicateItem = 5,
        k_eInvalidPage = 6,
        k_ePageTypeMismatch = 7,
        k_eTooManyStickers = 8,
    }
}
public record CMsgClientToGCPlaceCollectionStickersRequest(List<CMsgClientToGCPlaceCollectionStickersRequest.Slot> slots) : DotaPacket
{
    public record Slot(uint page_num, uint slot, ulong new_item_id, uint old_item_def_id, uint old_quality);
}
public record CMsgClientToGCPlaceCollectionStickersResponse(CMsgClientToGCPlaceCollectionStickersResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eMissingItem = 3,
        k_eTooBusy = 4,
        k_eDuplicateItem = 5,
        k_eInvalidPage = 6,
        k_ePageTypeMismatch = 7,
        k_eOldItemMismatch = 8,
        k_eInvalidSlot = 9,
        k_eSlotTypeMismatch = 10,
    }
}
public record CMsgClientToGCOrderStickerbookTeamPageRequest(CMsgStickerbookTeamPageOrderSequence page_order_sequence) : DotaPacket;
public record CMsgClientToGCOrderStickerbookTeamPageResponse(CMsgClientToGCOrderStickerbookTeamPageResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooManyPages = 3,
        k_eTooBusy = 4,
        k_eInvalidPage = 5,
    }
}
public record CMsgClientToGCSetHeroSticker(int hero_id, ulong new_item_id, ulong old_item_id) : DotaPacket;
public record CMsgClientToGCSetHeroStickerResponse(CMsgClientToGCSetHeroStickerResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eMissingItem = 3,
        k_eTooBusy = 4,
        k_eOldItemMismatch = 5,
        k_eInvalidHero = 6,
    }
}
public record CMsgClientToGCGetHeroStickers : DotaPacket;
public record CMsgClientToGCGetHeroStickersResponse(CMsgClientToGCGetHeroStickersResponse.EResponse response, CMsgStickerHeroes sticker_heroes) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 4,
    }
}
public record CMsgClientToGCSetFavoritePage(uint page_num, bool clear) : DotaPacket;
public record CMsgClientToGCSetFavoritePageResponse(CMsgClientToGCSetFavoritePageResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 4,
        k_eInvalidPage = 5,
    }
}
public record CMsgClientToGCClaimSwag(EEvent event_id, uint action_id, uint data) : DotaPacket;
public record CMsgClientToGCClaimSwagResponse(CMsgClientToGCClaimSwagResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 4,
        k_eAlreadyClaimed = 5,
        k_eDisabled = 6,
        k_eInvalidRequest = 7,
        k_eUserNotEligible = 8,
        k_eStorageError = 9,
        k_eRewardDisabled = 10,
    }
}
public record CMsgClientToGCCollectorsCacheAvailableDataRequest(uint contest_id) : DotaPacket;
public record CMsgGCToClientCollectorsCacheAvailableDataResponse(List<CMsgGCToClientCollectorsCacheAvailableDataResponse.Vote> votes) : DotaPacket
{
    public record Vote(uint item_def, CMsgGCToClientCollectorsCacheAvailableDataResponse.Vote.EVoteType vote_type)
    {
        public enum EVoteType
        {
            k_eUp = 0,
            k_eDown = 1,
        }
    }
}
public record CMsgClientToGCUploadMatchClip(CMatchClip match_clip) : DotaPacket;
public record CMsgGCToClientUploadMatchClipResponse(CMsgGCToClientUploadMatchClipResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTimeout = 2,
        k_eTooBusy = 4,
    }
}
public record CMsgClientToGCMapStatsRequest : DotaPacket;
public record CMsgGCToClientMapStatsResponse(CMsgGCToClientMapStatsResponse.EResponse response, CMsgMapStatsSnapshot personal_stats, CMsgGlobalMapStats global_stats) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
    }
}
public record CMsgRoadToTIAssignedQuest(uint quest_id, uint difficulty, uint progress_flags, uint half_credit_flags, bool completed) : DotaPacket;
public record CMsgRoadToTIUserData(List<CMsgRoadToTIAssignedQuest> quests) : DotaPacket;
public record CMsgClientToGCRoadToTIGetQuests(uint event_id) : DotaPacket;
public record CMsgClientToGCRoadToTIGetQuestsResponse(CMsgClientToGCRoadToTIGetQuestsResponse.EResponse response, CMsgRoadToTIUserData quest_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidID = 5,
    }
}
public record CMsgClientToGCRoadToTIGetActiveQuest(uint event_id) : DotaPacket;
public record CMsgClientToGCRoadToTIGetActiveQuestResponse(CMsgClientToGCRoadToTIGetActiveQuestResponse.EResponse response, CMsgRoadToTIAssignedQuest quest_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eNone = 2,
        k_eTooBusy = 3,
        k_eDisabled = 4,
        k_eTimeout = 5,
        k_eInvalidID = 6,
    }
}
public record CMsgGCToClientRoadToTIQuestDataUpdated(uint event_id, CMsgRoadToTIUserData quest_data) : DotaPacket;
public record CMsgClientToGCRoadToTIUseItem(uint event_id, uint item_type, uint hero_index) : DotaPacket;
public record CMsgClientToGCRoadToTIUseItemResponse(CMsgClientToGCRoadToTIUseItemResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eBadInput = 2,
        k_eNoItem = 3,
        k_eDisabled = 4,
        k_eTimeout = 5,
        k_eInvalidID = 6,
    }
}
public record CMsgClientToGCRoadToTIDevForceQuest(uint event_id, bool force_match_type, uint force_id) : DotaPacket;
public record CMsgLobbyRoadToTIMatchQuestData(CMsgRoadToTIAssignedQuest quest_data, uint quest_period, uint quest_number) : DotaPacket;
public record CMsgClientToGCNewBloomGift(uint defindex, ulong lobby_id, List<uint> target_account_ids) : DotaPacket;
public record CMsgClientToGCNewBloomGiftResponse(ENewBloomGiftingResponse result, List<uint> received_account_ids) : DotaPacket;
public record CMsgClientToGCSetBannedHeroes(List<int> banned_hero_ids) : DotaPacket;
public record CMsgClientToGCUpdateComicBookStats(uint comic_id, List<CMsgClientToGCUpdateComicBookStats.SingleStat> stats, CMsgClientToGCUpdateComicBookStats.LanguageStats language_stats) : DotaPacket
{
    public record SingleStat(CMsgClientToGCUpdateComicBookStat_Type stat_type, uint stat_value);
    public record LanguageStats(uint comic_id, uint client_language, uint client_comic_language);
}
public record CMsgGCRankedPlayerInfoSubmit(string name) : DotaPacket;
public record CMsgGCRankedPlayerInfoSubmitResponse(CMsgGCRankedPlayerInfoSubmitResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        SUCCESS = 0,
        ERROR_UNSPECIFIED = 1,
    }
}
