using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgSurvivorsUserData(List<CMsgSurvivorsUserData.AttributeLevelsEntry> attribute_levels, uint unlocked_difficulty) : DotaPacket
{
    public record AttributeLevelsEntry(int key, uint value);
}
public record CMsgClientToGCSurvivorsPowerUpTelemetryData(uint powerup_id, uint level, uint time_received, uint time_held, ulong total_damage, uint dps, uint has_scepter) : DotaPacket;
public record CMsgClientToGCSurvivorsGameTelemetryData(uint time_survived, uint player_level, uint game_result, uint gold_earned, List<CMsgClientToGCSurvivorsPowerUpTelemetryData> powerups, uint difficulty, uint metaprogression_level) : DotaPacket;
public record CMsgClientToGCSurvivorsGameTelemetryDataResponse(CMsgClientToGCSurvivorsGameTelemetryDataResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidItem = 6,
    }
}
