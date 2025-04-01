namespace Tranquil.Schema;

public enum SignonState_t
{
    SIGNONSTATE_NONE = 0,
    SIGNONSTATE_CHALLENGE = 1,
    SIGNONSTATE_CONNECTED = 2,
    SIGNONSTATE_NEW = 3,
    SIGNONSTATE_PRESPAWN = 4,
    SIGNONSTATE_SPAWN = 5,
    SIGNONSTATE_FULL = 6,
    SIGNONSTATE_CHANGELEVEL = 7,
}
public enum NET_Messages
{
    net_NOP = 0,
    net_Disconnect_Legacy = 1,
    net_SplitScreenUser = 3,
    net_Tick = 4,
    net_StringCmd = 5,
    net_SetConVar = 6,
    net_SignonState = 7,
    net_SpawnGroup_Load = 8,
    net_SpawnGroup_ManifestUpdate = 9,
    net_SpawnGroup_SetCreationTick = 11,
    net_SpawnGroup_Unload = 12,
    net_SpawnGroup_LoadCompleted = 13,
    net_DebugOverlay = 15,
}
public enum SpawnGroupFlags_t
{
    SPAWN_GROUP_LOAD_ENTITIES_FROM_SAVE = 1,
    SPAWN_GROUP_DONT_SPAWN_ENTITIES = 2,
    SPAWN_GROUP_SYNCHRONOUS_SPAWN = 4,
    SPAWN_GROUP_IS_INITIAL_SPAWN_GROUP = 8,
    SPAWN_GROUP_CREATE_CLIENT_ONLY_ENTITIES = 16,
    SPAWN_GROUP_BLOCK_UNTIL_LOADED = 64,
    SPAWN_GROUP_LOAD_STREAMING_DATA = 128,
    SPAWN_GROUP_CREATE_NEW_SCENE_WORLD = 256,
}
public record CMsgVector(float x, float y, float z, float w) : DotaPacket;
public record CMsgVector2D(float x, float y) : DotaPacket;
public record CMsgQAngle(float x, float y, float z) : DotaPacket;
public record CMsgQuaternion(float x, float y, float z, float w) : DotaPacket;
public record CMsgTransform(CMsgVector position, float scale, CMsgQuaternion orientation) : DotaPacket;
public record CMsgRGBA(int r, int g, int b, int a) : DotaPacket;
public record CMsgPlayerInfo(string name, long SF2xuid, int userid, long SF2steamid, bool fakeplayer, bool ishltv) : DotaPacket;
public record CEntityMsg(uint target_entity) : DotaPacket;
public record CMsg_CVars(List<CMsg_CVars.CVar> cvars) : DotaPacket
{
    public record CVar(string name, string value);
}
public record CNETMsg_NOP : DotaPacket;
public record CNETMsg_SplitScreenUser(int slot) : DotaPacket;
public record CNETMsg_Tick(uint tick, bool unused2, bool unused3, uint host_computationtime, uint host_computationtime_std_deviation, bool unused6, uint legacy_host_loss, uint host_unfiltered_frametime, uint hltv_replay_flags, uint expected_long_tick, string expected_long_tick_reason, uint host_frame_dropped_pct_x10, uint host_frame_irregular_arrival_pct_x10) : DotaPacket;
public record CNETMsg_StringCmd(string command, uint prediction_sync) : DotaPacket;
public record CNETMsg_SetConVar(CMsg_CVars convars) : DotaPacket;
public record CNETMsg_SignonState(SignonState_t signon_state, uint spawn_count, uint num_server_players, List<string> players_networkids, string map_name, string addons) : DotaPacket;
public record CSVCMsg_GameEvent(string event_name, int eventid, List<CSVCMsg_GameEvent.key_t> keys) : DotaPacket
{
    public record key_t(int type, string val_string, float val_float, int val_long, int val_short, int val_byte, bool val_bool, ulong val_uint64);
}
public record CSVCMsgList_GameEvents(List<CSVCMsgList_GameEvents.event_t> events) : DotaPacket
{
    public record event_t(int tick, CSVCMsg_GameEvent _event);
}
public record CNETMsg_SpawnGroup_Load(string worldname, string entitylumpname, string entityfiltername, uint spawngrouphandle, uint spawngroupownerhandle, CMsgVector world_offset_pos, CMsgQAngle world_offset_angle, byte[] spawngroupmanifest, uint flags, int tickcount, bool manifestincomplete, string localnamefixup, string parentnamefixup, int manifestloadpriority, uint worldgroupid, uint creationsequence, string savegamefilename, uint spawngroupparenthandle, bool leveltransition, string worldgroupname) : DotaPacket;
public record CNETMsg_SpawnGroup_ManifestUpdate(uint spawngrouphandle, byte[] spawngroupmanifest, bool manifestincomplete) : DotaPacket;
public record CNETMsg_SpawnGroup_SetCreationTick(uint spawngrouphandle, int tickcount, uint creationsequence) : DotaPacket;
public record CNETMsg_SpawnGroup_Unload(uint spawngrouphandle, uint flags, int tickcount) : DotaPacket;
public record CNETMsg_SpawnGroup_LoadCompleted(uint spawngrouphandle) : DotaPacket;
public record CSVCMsg_GameSessionConfiguration(bool is_multiplayer, bool is_loadsavegame, bool is_background_map, bool is_headless, uint min_client_limit, uint max_client_limit, uint max_clients, int SF1tick_interval, string hostname, string savegamename, string s1_mapname, string gamemode, string server_ip_address, byte[] data, bool is_localonly, bool is_transition, string previouslevel, string landmarkname, bool no_steam_server) : DotaPacket;
public record CNETMsg_DebugOverlay(int etype, List<CMsgVector> vectors, List<CMsgRGBA> colors, List<float> dimensions, List<float> times, List<bool> bools, List<ulong> uint64s, List<string> strings) : DotaPacket;
