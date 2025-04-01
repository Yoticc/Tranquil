using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EBasePredictionEvents
{
    BPE_StringCommand = 128,
    BPE_Teleport = 130,
    BPE_Diagnostic = 16384,
}
public record CPredictionEvent_Teleport(CMsgVector origin, CMsgQAngle angles, float drop_to_ground_range) : DotaPacket;
public record CPredictionEvent_StringCommand(string command) : DotaPacket;
public record CPredictionEvent_Diagnostic(uint id, uint requested_sync, uint requested_player_index, List<uint> execution_sync) : DotaPacket;
