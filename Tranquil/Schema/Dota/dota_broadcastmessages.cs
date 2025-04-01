namespace Tranquil.Schema;

public enum EDotaBroadcastMessages
{
    DOTA_BM_LANLobbyRequest = 1,
    DOTA_BM_LANLobbyReply = 2,
}
public record CDOTABroadcastMsg(EDotaBroadcastMessages type, byte[] msg) : DotaPacket;
public record CDOTABroadcastMsg_LANLobbyRequest : DotaPacket;
public record CDOTABroadcastMsg_LANLobbyReply(ulong id, uint tournament_id, uint tournament_game_id, List<CDOTABroadcastMsg_LANLobbyReply.CLobbyMember> members, bool requires_pass_key, uint leader_account_id, uint game_mode, string name, uint players) : DotaPacket
{
    public record CLobbyMember(uint account_id, string player_name);
}
