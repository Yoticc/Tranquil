namespace Tranquil.Schema;

public enum ELeagueNodeGroupType
{
    INVALID_GROUP_TYPE = 0,
    ORGANIZATIONAL = 1,
    ROUND_ROBIN = 2,
    SWISS = 3,
    BRACKET_SINGLE = 4,
    BRACKET_DOUBLE_SEED_LOSER = 5,
    BRACKET_DOUBLE_ALL_WINNER = 6,
    SHOWMATCH = 7,
    GSL = 8,
    PLACEMENT = 9,
}
public enum ELeagueNodeType
{
    INVALID_NODE_TYPE = 0,
    BEST_OF_ONE = 1,
    BEST_OF_THREE = 2,
    BEST_OF_FIVE = 3,
    BEST_OF_TWO = 4,
}
public record CMsgDOTALeagueNode(string name, uint node_id, uint node_group_id, uint winning_node_id, uint losing_node_id, uint incoming_node_id_1, uint incoming_node_id_2, ELeagueNodeType node_type, uint scheduled_time, uint series_id, uint team_id_1, uint team_id_2, List<CMsgDOTALeagueNode.MatchDetails> matches, uint team_1_wins, uint team_2_wins, bool has_started, bool is_completed, List<uint> stream_ids, uint actual_time, List<CMsgDOTALeagueNode.VOD> vods) : DotaPacket
{
    public record MatchDetails(ulong match_id, uint winning_team_id);
    public record VOD(uint series_game, uint stream_id, string url);
}
public record CMsgDOTALeagueNodeGroup(string name, uint node_group_id, uint parent_node_group_id, List<uint> incoming_node_group_ids, uint advancing_node_group_id, uint advancing_team_count, uint team_count, ELeagueNodeGroupType node_group_type, ELeagueNodeType default_node_type, uint round, uint max_rounds, bool is_tiebreaker, bool is_final_group, bool is_completed, List<CMsgDOTALeagueNodeGroup.TeamStanding> team_standings, List<CMsgDOTALeagueNode> nodes, List<CMsgDOTALeagueNodeGroup> node_groups, ELeaguePhase phase, ELeagueRegion region, uint start_time, uint end_time, uint secondary_advancing_node_group_id, uint secondary_advancing_team_count, uint tertiary_advancing_node_group_id, uint tertiary_advancing_team_count, uint elimination_dpc_points) : DotaPacket
{
    public record TeamStanding(uint standing, uint team_id, string team_name, string team_tag, ulong team_logo, string team_logo_url, uint wins, uint losses, long score, string team_abbreviation, long score_tiebreak_group, long score_tiebreak_below, long score_tiebreak_random, bool is_pro);
}
public record CMsgDOTALeague(CMsgDOTALeague.Info info, CMsgDOTALeague.PrizePool prize_pool, List<CMsgDOTALeague.Admin> admins, List<CMsgDOTALeague.Stream> streams, List<CMsgDOTALeagueNodeGroup> node_groups, List<CMsgDOTALeague.SeriesInfo> series_infos, List<CMsgDOTALeague.Player> registered_players) : DotaPacket
{
    public record Info(uint league_id, string name, ELeagueTier tier, ELeagueRegion region, string url, string description, string notes, uint start_timestamp, uint end_timestamp, uint pro_circuit_points, uint image_bits, ELeagueStatus status, uint most_recent_activity, uint registration_period);
    public record Admin(uint account_id, bool is_primary, string email_address);
    public record PrizePoolItem(uint item_def, uint sales_stop_timestamp, uint revenue_pct, uint revenue_cents_per_sale);
    public record PrizePool(uint base_prize_pool, uint total_prize_pool, List<uint> prize_split_pct_x100, List<CMsgDOTALeague.PrizePoolItem> prize_pool_items);
    public record Stream(uint stream_id, uint language, string name, ELeagueBroadcastProvider broadcast_provider, string stream_url, string vod_url);
    public record SeriesInfo(uint series_id, uint series_type, uint start_time, List<ulong> match_ids, uint team_id_1, uint team_id_2);
    public record Player(uint account_id, string name, uint team_id);
}
public record CMsgDOTALeagueList(List<CMsgDOTALeague> leagues) : DotaPacket;
public record CMsgDOTALeagueInfo(uint league_id, string name, ELeagueTier tier, ELeagueRegion region, uint most_recent_activity, uint total_prize_pool, uint start_timestamp, uint end_timestamp, uint status) : DotaPacket;
public record CMsgDOTALeagueInfoList(List<CMsgDOTALeagueInfo> infos) : DotaPacket;
public record CMsgDOTALeagueLiveGames(List<CMsgDOTALeagueLiveGames.LiveGame> games) : DotaPacket
{
    public record LiveGame(uint league_id, ulong server_steam_id, string radiant_name, ulong radiant_logo, string dire_name, ulong dire_logo, uint time, uint spectators, uint radiant_team_id, uint dire_team_id, uint league_node_id, uint series_id, ulong match_id);
}
public record CMsgDOTALeagueMessages(List<CMsgDOTALeagueMessages.Message> messages) : DotaPacket
{
    public record Message(uint author_account_id, uint timestamp, string message);
}
public record CMsgDOTALeaguePrizePool(uint prize_pool, float increment_per_second) : DotaPacket;
public record CMsgDOTALeagueInfoListAdminsRequest : DotaPacket;
public record CMsgDOTALeagueAvailableLobbyNodesRequest(uint league_id) : DotaPacket;
public record CMsgDOTALeagueAvailableLobbyNodes(List<CMsgDOTALeagueAvailableLobbyNodes.NodeInfo> node_infos) : DotaPacket
{
    public record NodeInfo(uint node_id, string node_name, string node_group_name, uint team_id_1, uint team_id_2);
}
public record CMsgDOTALeagueNodeResults(List<CMsgDOTALeagueNodeResults.Result> node_results) : DotaPacket
{
    public record Result(uint node_id, uint winning_node_id, uint losing_node_id, uint incoming_node_id_1, uint incoming_node_id_2, uint team_id_1, uint team_id_2, string team_1_name, string team_2_name, uint team_1_wins, uint team_2_wins, uint winning_team_id, uint losing_team_id, bool has_started, bool is_completed, uint scheduled_time, List<ulong> match_ids);
}
public record CMsgDOTADPCLeagueResults(List<CMsgDOTADPCLeagueResults.Result> results, List<uint> points, List<uint> dollars) : DotaPacket
{
    public record Result(uint standing, uint team_id, string team_name, ulong team_logo, string team_logo_url, uint points, uint earnings, uint timestamp, ELeaguePhase phase, string team_abbreviation);
}
public record CMsgDOTADPCTeamResults(List<CMsgDOTADPCTeamResults.Result> results) : DotaPacket
{
    public record Result(uint league_id, uint standing, uint points, uint earnings, uint timestamp);
}
public record CMsgDOTADPCSeasonResults(List<CMsgDOTADPCSeasonResults.TeamResult> results, List<CMsgDOTADPCSeasonResults.Standing> standings, List<CMsgDOTADPCSeasonResults.StandingEntry> major_wildcard_standings, List<CMsgDOTADPCSeasonResults.StandingEntry> major_group_standings, List<CMsgDOTADPCSeasonResults.StandingEntry> major_playoff_standings) : DotaPacket
{
    public record TeamLeagueResult(uint timestamp, uint league_id, uint standing, uint points, uint earnings, uint audit_action, uint audit_data);
    public record TeamResult(uint team_id, string team_name, ulong team_logo, string team_logo_url, uint total_points, uint total_earnings, List<CMsgDOTADPCSeasonResults.TeamLeagueResult> league_results, string team_abbreviation);
    public record StandingEntry(uint team_id, uint wins, uint losses, string team_url, string team_name, string team_abbreviation);
    public record Standing(ELeagueRegion region, ELeagueDivision division, List<CMsgDOTADPCSeasonResults.StandingEntry> entries);
}
public record CMsgDOTADPCSeasonSpoilerResults(uint time_last_updated, CMsgDOTADPCSeasonResults saved_results) : DotaPacket;
