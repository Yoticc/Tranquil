namespace Tranquil.Schema;

public enum P2P_Messages
{
    p2p_TextMessage = 256,
    p2p_Voice = 257,
    p2p_Ping = 258,
    p2p_VRAvatarPosition = 259,
    p2p_WatchSynchronization = 260,
    p2p_FightingGame_GameData = 261,
    p2p_FightingGame_Connection = 262,
}
public record CP2P_TextMessage(byte[] text) : DotaPacket;
public record CSteam_Voice_Encoding(byte[] voice_data) : DotaPacket;
public record CP2P_Voice(CMsgVoiceAudio audio, uint broadcast_group) : DotaPacket
{
    public enum Handler_Flags
    {
        Played_Audio = 1,
    }
}
public record CP2P_Ping(ulong send_time, bool is_reply) : DotaPacket;
public record CP2P_VRAvatarPosition(List<CP2P_VRAvatarPosition.COrientation> body_parts, int hat_id, int scene_id, int world_scale) : DotaPacket
{
    public record COrientation(CMsgVector pos, CMsgQAngle ang);
}
public record CP2P_WatchSynchronization(int demo_tick, bool paused, ulong tv_listen_voice_indices, int dota_spectator_mode, bool dota_spectator_watching_broadcaster, int dota_spectator_hero_index, int dota_spectator_autospeed, int dota_replay_speed) : DotaPacket;
