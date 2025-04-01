using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum MLBot_MessageId
{
    mlbot_MatchMetadata = 1,
    mlbot_TickBoundary = 2,
    mlbot_TeamState_Radiant = 3,
    mlbot_TeamState_Radiant_Delta = 4,
    mlbot_TeamState_Dire = 5,
    mlbot_TeamState_Dire_Delta = 6,
    mlbot_PlayerCommand = 7,
    mlbot_PlayerOrder = 8,
}
public record CMsgMLBotMatchMetadata(ulong match_id, ulong lobby_id, int lobby_type, uint game_mode, List<CMsgMLBotMatchMetadata.Player> players) : DotaPacket
{
    public record Player(int player_id, int team_id, int hero_id, int rank);
}
public record CMsgMLBotTickBoundary(uint tick_number) : DotaPacket;
public record CMsgMLBot_PlayerOrder(int player_id, int team_id, int order_type, List<uint> selected_unit_handles, int target_index, uint target_handle, int ability_index, uint ability_handle, float pos_x, float pos_y, float pos_z, bool queue) : DotaPacket;
public record CMsgMLBot_TeamInference(int team_id, List<int> bot_player_ids, CMsgBotWorldState world_state) : DotaPacket;
public record CMsgMLBot_TeamInferenceResponse(List<CMsgMLBot_PlayerOrder> orders) : DotaPacket;
public record CMsgMLBot_TeamInferenceList(List<CMsgMLBot_TeamInference> messages) : DotaPacket;
