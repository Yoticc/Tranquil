namespace Tranquil.Schema;

public record CSourceTVGameSmall(uint activate_time, uint deactivate_time, ulong server_steam_id, ulong lobby_id, uint league_id, uint lobby_type, int game_time, uint delay, uint spectators, uint game_mode, uint average_mmr, ulong match_id, uint series_id, bool unused14, string team_name_radiant, string team_name_dire, uint sort_score, float last_update_time, int radiant_lead, uint radiant_score, uint dire_score, List<CSourceTVGameSmall.Player> players, int SF1building_state, long SF2team_logo_radiant, long SF2team_logo_dire, uint weekend_tourney_tournament_id, uint weekend_tourney_division, uint weekend_tourney_skill_level, uint weekend_tourney_bracket_round, uint team_id_radiant, uint team_id_dire, uint custom_game_difficulty, bool is_player_draft) : DotaPacket
{
    public record Player(uint account_id, int hero_id, uint team_slot, uint team);
}
public record CMsgClientToGCFindTopSourceTVGames(string search_key, uint league_id, int hero_id, uint start_game, uint game_list_index, List<ulong> lobby_ids) : DotaPacket;
public record CMsgGCToClientFindTopSourceTVGamesResponse(string search_key, uint league_id, int hero_id, uint start_game, uint num_games, uint game_list_index, List<CSourceTVGameSmall> game_list, bool specific_games, CSourceTVGameSmall bot_game) : DotaPacket;
public record CMsgGCToClientTopWeekendTourneyGames(List<CSourceTVGameSmall> live_games) : DotaPacket;
public record CMsgClientToGCTopLeagueMatchesRequest : DotaPacket;
public record CMsgClientToGCTopFriendMatchesRequest : DotaPacket;
public record CMsgClientToGCMatchesMinimalRequest(List<ulong> match_ids) : DotaPacket;
public record CMsgClientToGCMatchesMinimalResponse(List<CMsgDOTAMatchMinimal> matches, bool last_match) : DotaPacket;
public record CMsgGCToClientTopLeagueMatchesResponse(bool unused1, List<CMsgDOTAMatchMinimal> matches) : DotaPacket;
public record CMsgGCToClientTopFriendMatchesResponse(List<CMsgDOTAMatchMinimal> matches) : DotaPacket;
public record CMsgSpectateFriendGame(long SF2steam_id, bool live) : DotaPacket;
public record CMsgSpectateFriendGameResponse(bool unused1, bool unused2, bool unused3, long SF2server_steamid, CMsgSpectateFriendGameResponse.EWatchLiveResult watch_live_result) : DotaPacket
{
    public enum EWatchLiveResult
    {
        SUCCESS = 0,
        ERROR_GENERIC = 1,
        ERROR_NO_PLUS = 2,
        ERROR_NOT_FRIENDS = 3,
        ERROR_LOBBY_NOT_FOUND = 4,
        ERROR_SPECTATOR_IN_A_LOBBY = 5,
        ERROR_LOBBY_IS_LAN = 6,
        ERROR_WRONG_LOBBY_TYPE = 7,
        ERROR_WRONG_LOBBY_STATE = 8,
        ERROR_PLAYER_NOT_PLAYER = 9,
        ERROR_TOO_MANY_SPECTATORS = 10,
        ERROR_SPECTATOR_SWITCHED_TEAMS = 11,
        ERROR_FRIENDS_ON_BOTH_SIDES = 12,
        ERROR_SPECTATOR_IN_THIS_LOBBY = 13,
        ERROR_LOBBY_IS_LEAGUE = 14,
    }
}
public record CDOTAReplayDownloadInfo(CMsgDOTAMatchMinimal match, string title, string description, uint size, List<string> tags, bool exists_on_disk) : DotaPacket
{
    public record Highlight(uint timestamp, string description);
}
public record CMsgWatchGame(long SF2server_steamid, uint client_version, long SF2watch_server_steamid, ulong lobby_id, List<uint> regions) : DotaPacket;
public record CMsgCancelWatchGame : DotaPacket;
public record CMsgWatchGameResponse(CMsgWatchGameResponse.WatchGameResult watch_game_result, uint source_tv_public_addr, uint source_tv_private_addr, uint source_tv_port, long SF2game_server_steamid, long SF2watch_server_steamid, long SF2watch_tv_unique_secret_code) : DotaPacket
{
    public enum WatchGameResult
    {
        PENDING = 0,
        READY = 1,
        GAMESERVERNOTFOUND = 2,
        UNAVAILABLE = 3,
        CANCELLED = 4,
        INCOMPATIBLEVERSION = 5,
        MISSINGLEAGUESUBSCRIPTION = 6,
        LOBBYNOTFOUND = 7,
    }
}
public record CMsgPartyLeaderWatchGamePrompt(bool unused1, bool unused2, bool unused3, bool unused4, long SF2game_server_steamid) : DotaPacket;
public record CDOTABroadcasterInfo(uint account_id, long SF2server_steam_id, bool live, string team_name_radiant, string team_name_dire, bool unused6, uint series_game, bool unused8, uint upcoming_broadcast_timestamp, bool allow_live_video, uint node_type, string node_name) : DotaPacket;
public record CMsgDOTASeries(uint series_id, uint series_type, CMsgDOTASeries.TeamInfo team_1, CMsgDOTASeries.TeamInfo team_2, List<CMsgDOTAMatchMinimal> match_minimal, CMsgDOTASeries.LiveGame live_game) : DotaPacket
{
    public record TeamInfo(uint team_id, string team_name, string team_logo_url, uint wager_count);
    public record LiveGame(long SF2server_steam_id, CMsgDOTASeries.TeamInfo team_radiant, CMsgDOTASeries.TeamInfo team_dire, uint team_radiant_score, uint team_dire_score);
}
