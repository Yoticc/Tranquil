namespace Tranquil.Schema;

public enum ETournamentEvent
{
    k_ETournamentEvent_None = 0,
    k_ETournamentEvent_TournamentCreated = 1,
    k_ETournamentEvent_TournamentsMerged = 2,
    k_ETournamentEvent_GameOutcome = 3,
    k_ETournamentEvent_TeamGivenBye = 4,
    k_ETournamentEvent_TournamentCanceledByAdmin = 5,
    k_ETournamentEvent_TeamAbandoned = 6,
    k_ETournamentEvent_ScheduledGameStarted = 7,
    k_ETournamentEvent_Canceled = 8,
    k_ETournamentEvent_TeamParticipationTimedOut_EntryFeeRefund = 9,
    k_ETournamentEvent_TeamParticipationTimedOut_EntryFeeForfeit = 10,
    k_ETournamentEvent_TeamParticipationTimedOut_GrantedVictory = 11,
}
public record CMsgRequestWeekendTourneySchedule : DotaPacket;
public record CMsgWeekendTourneySchedule(List<CMsgWeekendTourneySchedule.Division> divisions) : DotaPacket
{
    public record Division(uint division_code, uint time_window_open, uint time_window_close, uint time_window_open_next, uint trophy_id, bool free_weekend);
}
public record CMsgWeekendTourneyOpts(bool participating, uint division_id, uint buyin, uint skill_level, uint match_groups, uint team_id, string pickup_team_name, ulong pickup_team_logo) : DotaPacket;
public record CMsgWeekendTourneyLeave : DotaPacket;
public record CMsgDOTATournament(uint tournament_id, uint division_id, uint schedule_time, uint skill_level, ETournamentTemplate tournament_template, ETournamentState state, List<CMsgDOTATournament.Team> teams, List<CMsgDOTATournament.Game> games, List<CMsgDOTATournament.Node> nodes, uint state_seq_num, uint season_trophy_id) : DotaPacket
{
    public record Team(long SF2team_gid, uint node_or_state, List<uint> players, uint team_id, string team_name, bool unused6, ulong team_base_logo, ulong team_ui_logo, List<uint> player_buyin, List<uint> player_skill_level, uint match_group_mask);
    public record Game(uint node_idx, long SF2lobby_id, ulong match_id, bool team_a_good, ETournamentGameState state, uint start_time);
    public record Node(uint node_id, uint team_idx_a, uint team_idx_b, ETournamentNodeState node_state);
}
public record CMsgDOTATournamentStateChange(uint new_tournament_id, ETournamentEvent _event, ETournamentState new_tournament_state, List<CMsgDOTATournamentStateChange.GameChange> game_changes, List<CMsgDOTATournamentStateChange.TeamChange> team_changes, List<uint> merged_tournament_ids, uint state_seq_num) : DotaPacket
{
    public record GameChange(ulong match_id, ETournamentGameState new_state);
    public record TeamChange(ulong team_gid, uint new_node_or_state, uint old_node_or_state);
}
public record CMsgDOTAWeekendTourneyPlayerSkillLevelStats(uint skill_level, uint times_won_0, uint times_won_1, uint times_won_2, uint times_won_3, uint times_bye_and_lost, uint times_bye_and_won, uint total_games_won, uint score, uint times_unusual_champ) : DotaPacket;
public record CMsgDOTAWeekendTourneyPlayerStats(uint account_id, uint season_trophy_id, List<CMsgDOTAWeekendTourneyPlayerSkillLevelStats> skill_levels, uint current_tier) : DotaPacket;
public record CMsgDOTAWeekendTourneyPlayerStatsRequest(uint account_id, uint season_trophy_id) : DotaPacket;
public record CMsgDOTAWeekendTourneyPlayerHistory(uint account_id, bool unused2, List<CMsgDOTAWeekendTourneyPlayerHistory.Tournament> tournaments) : DotaPacket
{
    public record Tournament(uint tournament_id, uint start_time, uint tournament_tier, uint team_id, uint team_date, uint team_result, List<uint> account_id, string team_name, uint season_trophy_id);
}
public record CMsgDOTAWeekendTourneyParticipationDetails(List<CMsgDOTAWeekendTourneyParticipationDetails.Division> divisions) : DotaPacket
{
    public record Tier(uint tier, uint players, uint teams, uint winning_teams, uint players_streak_2, uint players_streak_3, uint players_streak_4, uint players_streak_5);
    public record Division(uint division_id, uint schedule_time, List<CMsgDOTAWeekendTourneyParticipationDetails.Tier> tiers);
}
