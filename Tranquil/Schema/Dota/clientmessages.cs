using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EBaseClientMessages
{
    CM_CustomGameEvent = 280,
    CM_CustomGameEventBounce = 281,
    CM_ClientUIEvent = 282,
    CM_DevPaletteVisibilityChanged = 283,
    CM_WorldUIControllerHasPanelChanged = 284,
    CM_RotateAnchor = 285,
    CM_ListenForResponseFound = 286,
    CM_MAX_BASE = 300,
}
public enum EClientUIEvent
{
    EClientUIEvent_Invalid = 0,
    EClientUIEvent_DialogFinished = 1,
    EClientUIEvent_FireOutput = 2,
}
public record CClientMsg_CustomGameEvent(string event_name, byte[] data) : DotaPacket;
public record CClientMsg_CustomGameEventBounce(string event_name, byte[] data, int player_slot) : DotaPacket;
public record CClientMsg_ClientUIEvent(EClientUIEvent _event, uint ent_ehandle, uint client_ehandle, string data1, string data2) : DotaPacket;
public record CClientMsg_DevPaletteVisibilityChangedEvent(bool visible) : DotaPacket;
public record CClientMsg_WorldUIControllerHasPanelChangedEvent(bool has_panel, uint client_ehandle, uint literal_hand_type) : DotaPacket;
public record CClientMsg_RotateAnchor(float angle) : DotaPacket;
public record CClientMsg_ListenForResponseFound(int player_slot) : DotaPacket;
