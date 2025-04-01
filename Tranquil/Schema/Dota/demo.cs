namespace Tranquil.Schema;

public enum EDemoCommands
{
    DEM_Error = -1,
    DEM_Stop = 0,
    DEM_FileHeader = 1,
    DEM_FileInfo = 2,
    DEM_SyncTick = 3,
    DEM_SendTables = 4,
    DEM_ClassInfo = 5,
    DEM_StringTables = 6,
    DEM_Packet = 7,
    DEM_SignonPacket = 8,
    DEM_ConsoleCmd = 9,
    DEM_CustomData = 10,
    DEM_CustomDataCallbacks = 11,
    DEM_UserCmd = 12,
    DEM_FullPacket = 13,
    DEM_SaveGame = 14,
    DEM_SpawnGroups = 15,
    DEM_AnimationData = 16,
    DEM_AnimationHeader = 17,
    DEM_Recovery = 18,
    DEM_Max = 19,
    DEM_IsCompressed = 64,
}
public record CDemoFileHeader(string demo_file_stamp, int network_protocol, string server_name, string client_name, string map_name, string game_directory, int fullpackets_version, bool allow_clientside_entities, bool allow_clientside_particles, string addons, string demo_version_name, string demo_version_guid, int build_num, string game, int server_start_tick) : DotaPacket;
public record CGameInfo(bool unused1, bool unused2, bool unused3, CGameInfo.CDotaGameInfo dota, CGameInfo.CCSGameInfo cs) : DotaPacket
{
    public record CDotaGameInfo(ulong match_id, int game_mode, int game_winner, List<CGameInfo.CDotaGameInfo.CPlayerInfo> player_info, uint leagueid, List<CGameInfo.CDotaGameInfo.CHeroSelectEvent> picks_bans, uint radiant_team_id, uint dire_team_id, string radiant_team_tag, string dire_team_tag, uint end_time)
    {
        public record CPlayerInfo(string hero_name, string player_name, bool is_fake_client, ulong steamid, int game_team);
        public record CHeroSelectEvent(bool is_pick, uint team, int hero_id);
    }
    public record CCSGameInfo(List<int> round_start_ticks);
}
public record CDemoFileInfo(float playback_time, int playback_ticks, int playback_frames, CGameInfo game_info) : DotaPacket;
public record CDemoPacket(bool unused1, bool unused2, byte[] data) : DotaPacket;
public record CDemoFullPacket(CDemoStringTables string_table, CDemoPacket packet) : DotaPacket;
public record CDemoSaveGame(byte[] data, long SF2steam_id, long SF2signature, int version) : DotaPacket;
public record CDemoSyncTick : DotaPacket;
public record CDemoConsoleCmd(string cmdstring) : DotaPacket;
public record CDemoSendTables(byte[] data) : DotaPacket;
public record CDemoClassInfo(List<CDemoClassInfo.class_t> classes) : DotaPacket
{
    public record class_t(int class_id, string network_name, string table_name);
}
public record CDemoCustomData(int callback_index, byte[] data) : DotaPacket;
public record CDemoCustomDataCallbacks(List<string> save_id) : DotaPacket;
public record CDemoAnimationHeader(int SS1entity_id, int tick, byte[] data) : DotaPacket;
public record CDemoAnimationData(int SS1entity_id, int start_tick, int end_tick, byte[] data, long data_checksum) : DotaPacket;
public record CDemoStringTables(List<CDemoStringTables.table_t> tables) : DotaPacket
{
    public record items_t(string str, byte[] data);
    public record table_t(string table_name, List<CDemoStringTables.items_t> items, List<CDemoStringTables.items_t> items_clientside, int table_flags);
}
public record CDemoStop : DotaPacket;
public record CDemoUserCmd(int cmd_number, byte[] data) : DotaPacket;
public record CDemoSpawnGroups(bool unused1, bool unused2, List<byte[]> msgs) : DotaPacket;
public record CDemoRecovery(CDemoRecovery.DemoInitialSpawnGroupEntry initial_spawn_group, byte[] spawn_group_message) : DotaPacket
{
    public record DemoInitialSpawnGroupEntry(uint spawngrouphandle, bool was_created);
}
