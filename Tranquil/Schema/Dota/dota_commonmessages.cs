using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EPingSource
{
    k_ePingSource_Default = 0,
    k_ePingSource_Warning = 1,
    k_ePingSource_Wheel = 2,
    k_ePingSource_System = 3,
}
public enum EDOTAStatPopupTypes
{
    k_EDOTA_SPT_Textline = 0,
    k_EDOTA_SPT_Basic = 1,
    k_EDOTA_SPT_Poll = 2,
    k_EDOTA_SPT_Grid = 3,
    k_EDOTA_SPT_DualImage = 4,
    k_EDOTA_SPT_Movie = 5,
}
public enum dotaunitorder_t
{
    DOTA_UNIT_ORDER_NONE = 0,
    DOTA_UNIT_ORDER_MOVE_TO_POSITION = 1,
    DOTA_UNIT_ORDER_MOVE_TO_TARGET = 2,
    DOTA_UNIT_ORDER_ATTACK_MOVE = 3,
    DOTA_UNIT_ORDER_ATTACK_TARGET = 4,
    DOTA_UNIT_ORDER_CAST_POSITION = 5,
    DOTA_UNIT_ORDER_CAST_TARGET = 6,
    DOTA_UNIT_ORDER_CAST_TARGET_TREE = 7,
    DOTA_UNIT_ORDER_CAST_NO_TARGET = 8,
    DOTA_UNIT_ORDER_CAST_TOGGLE = 9,
    DOTA_UNIT_ORDER_HOLD_POSITION = 10,
    DOTA_UNIT_ORDER_TRAIN_ABILITY = 11,
    DOTA_UNIT_ORDER_DROP_ITEM = 12,
    DOTA_UNIT_ORDER_GIVE_ITEM = 13,
    DOTA_UNIT_ORDER_PICKUP_ITEM = 14,
    DOTA_UNIT_ORDER_PICKUP_RUNE = 15,
    DOTA_UNIT_ORDER_PURCHASE_ITEM = 16,
    DOTA_UNIT_ORDER_SELL_ITEM = 17,
    DOTA_UNIT_ORDER_DISASSEMBLE_ITEM = 18,
    DOTA_UNIT_ORDER_MOVE_ITEM = 19,
    DOTA_UNIT_ORDER_CAST_TOGGLE_AUTO = 20,
    DOTA_UNIT_ORDER_STOP = 21,
    DOTA_UNIT_ORDER_TAUNT = 22,
    DOTA_UNIT_ORDER_BUYBACK = 23,
    DOTA_UNIT_ORDER_GLYPH = 24,
    DOTA_UNIT_ORDER_EJECT_ITEM_FROM_STASH = 25,
    DOTA_UNIT_ORDER_CAST_RUNE = 26,
    DOTA_UNIT_ORDER_PING_ABILITY = 27,
    DOTA_UNIT_ORDER_MOVE_TO_DIRECTION = 28,
    DOTA_UNIT_ORDER_PATROL = 29,
    DOTA_UNIT_ORDER_VECTOR_TARGET_POSITION = 30,
    DOTA_UNIT_ORDER_RADAR = 31,
    DOTA_UNIT_ORDER_SET_ITEM_COMBINE_LOCK = 32,
    DOTA_UNIT_ORDER_CONTINUE = 33,
    DOTA_UNIT_ORDER_VECTOR_TARGET_CANCELED = 34,
    DOTA_UNIT_ORDER_CAST_RIVER_PAINT = 35,
    DOTA_UNIT_ORDER_PREGAME_ADJUST_ITEM_ASSIGNMENT = 36,
    DOTA_UNIT_ORDER_DROP_ITEM_AT_FOUNTAIN = 37,
    DOTA_UNIT_ORDER_TAKE_ITEM_FROM_NEUTRAL_ITEM_STASH = 38,
    DOTA_UNIT_ORDER_MOVE_RELATIVE = 39,
    DOTA_UNIT_ORDER_CAST_TOGGLE_ALT = 40,
    DOTA_UNIT_ORDER_CONSUME_ITEM = 41,
    DOTA_UNIT_ORDER_SET_ITEM_MARK_FOR_SELL = 42,
}
public enum EDOTAVersusScenePlayerBehavior
{
    VS_PLAYER_BEHAVIOR_PLAY_ACTIVITY = 1,
    VS_PLAYER_BEHAVIOR_CHAT_WHEEL = 2,
    VS_PLAYER_BEHAVIOR_PLAYBACK_RATE = 3,
}
public record CDOTAMsg_LocationPing(int x, int y, int target, bool direct_ping, uint type, EPingSource ping_source) : DotaPacket;
public record CDOTAMsg_ItemAlert(int x, int y, int item_ability_id) : DotaPacket;
public record CDOTAMsg_MapLine(int x, int y, bool initial) : DotaPacket;
public record CDOTAMsg_WorldLine(int x, int y, int z, bool initial, bool end) : DotaPacket;
public record CDOTAMsg_SendStatPopup(EDOTAStatPopupTypes style, List<string> stat_strings, List<int> stat_images, List<int> stat_image_types, float duration, bool use_html, string movie_name) : DotaPacket;
public record CDOTAMsg_DismissAllStatPopups(float time_delay) : DotaPacket;
public record CDOTAMsg_CoachHUDPing(uint x, uint y, string tgtpath) : DotaPacket;
public record CDOTAMsg_UnitOrder(bool unused1, dotaunitorder_t order_type, List<int> units, int target_index, int ability_index, CMsgVector position, bool unused7, int sequence_number, uint flags) : DotaPacket;
public record VersusScene_PlayActivity(List<VersusScene_PlayActivity.ActivityInfo> activities, float playback_rate) : DotaPacket
{
    public record ActivityInfo(string activity, bool disable_auto_kill, bool force_looping);
}
public record VersusScene_ChatWheel(uint chat_message_id, uint emoticon_id) : DotaPacket;
public record VersusScene_PlaybackRate(float rate) : DotaPacket;
