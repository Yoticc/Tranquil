namespace Tranquil.Schema;

public record CMsgFightingGame_GameData_Fighting(int last_acked_frame, uint player_id, int last_crc_frame, uint last_crc_value, float now, float peer_ack_time, int input_start_frame, List<CMsgFightingGame_GameData_Fighting.InputSample> input_sample) : DotaPacket
{
    public record InputSample(uint button_mask);
}
public record CMsgFightingGame_GameData_CharacterSelect(uint cursor_index, int selected_hero_id, uint selected_style, List<CMsgFightingGame_GameData_CharacterSelect.Item> econ_item_refs, long message_ack, bool confirmed_style) : DotaPacket
{
    public record Item(uint item_def, uint style_index);
}
public record CMsgFightingGame_GameData_Loaded(float now, float peer_ack_time, float proposed_start_time, float accepted_start_time) : DotaPacket;
public record CP2P_FightingGame_GameData(CP2P_FightingGame_GameData.EState state, CMsgFightingGame_GameData_Fighting fight, CMsgFightingGame_GameData_CharacterSelect character_select, CMsgFightingGame_GameData_Loaded loaded) : DotaPacket
{
    public enum EState
    {
        k_ChoosingCharacter = 1,
        k_Loaded = 2,
        k_Fighting = 3,
    }
}
