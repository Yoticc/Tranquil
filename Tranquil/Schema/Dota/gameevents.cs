using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EBaseGameEvents
{
    GE_VDebugGameSessionIDEvent = 200,
    GE_PlaceDecalEvent = 201,
    GE_ClearWorldDecalsEvent = 202,
    GE_ClearEntityDecalsEvent = 203,
    GE_ClearDecalsForSkeletonInstanceEvent = 204,
    GE_Source1LegacyGameEventList = 205,
    GE_Source1LegacyListenEvents = 206,
    GE_Source1LegacyGameEvent = 207,
    GE_SosStartSoundEvent = 208,
    GE_SosStopSoundEvent = 209,
    GE_SosSetSoundEventParams = 210,
    GE_SosSetLibraryStackFields = 211,
    GE_SosStopSoundEventHash = 212,
}
public record CMsgVDebugGameSessionIDEvent(int clientid, string gamesessionid) : DotaPacket;
public record CMsgPlaceDecalEvent(CMsgVector position, CMsgVector normal, CMsgVector saxis, uint decalmaterialindex, uint flags, int SF1color, float width, float height, float depth, uint entityhandleindex, int SF1skeletoninstancehash, int boneindex, bool translucenthit, bool is_adjacent) : DotaPacket;
public record CMsgClearWorldDecalsEvent(uint flagstoclear) : DotaPacket;
public record CMsgClearEntityDecalsEvent(uint flagstoclear) : DotaPacket;
public record CMsgClearDecalsForSkeletonInstanceEvent(uint flagstoclear, uint entityhandleindex, uint skeletoninstancehash) : DotaPacket;
public record CMsgSource1LegacyGameEventList(List<CMsgSource1LegacyGameEventList.descriptor_t> descriptors) : DotaPacket
{
    public record key_t(int type, string name);
    public record descriptor_t(int eventid, string name, List<CMsgSource1LegacyGameEventList.key_t> keys);
}
public record CMsgSource1LegacyListenEvents(int playerslot, List<uint> eventarraybits) : DotaPacket;
public record CMsgSource1LegacyGameEvent(string event_name, int eventid, List<CMsgSource1LegacyGameEvent.key_t> keys, int server_tick, int passthrough) : DotaPacket
{
    public record key_t(int type, string val_string, float val_float, int val_long, int val_short, int val_byte, bool val_bool, ulong val_uint64);
}
public record CMsgSosStartSoundEvent(int soundevent_guid, int SF1soundevent_hash, int source_entity_index, int seed, byte[] packed_params, float start_time) : DotaPacket;
public record CMsgSosStopSoundEvent(int soundevent_guid) : DotaPacket;
public record CMsgSosStopSoundEventHash(int SF1soundevent_hash, int source_entity_index) : DotaPacket;
public record CMsgSosSetSoundEventParams(int soundevent_guid, bool unused2, bool unused3, bool unused4, byte[] packed_params) : DotaPacket;
public record CMsgSosSetLibraryStackFields(int SF1stack_hash, bool unused2, bool unused3, bool unused4, byte[] packed_fields) : DotaPacket;
