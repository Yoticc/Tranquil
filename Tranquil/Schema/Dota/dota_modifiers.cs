namespace Tranquil.Schema;

public enum DOTA_MODIFIER_ENTRY_TYPE
{
    DOTA_MODIFIER_ENTRY_TYPE_ACTIVE = 1,
    DOTA_MODIFIER_ENTRY_TYPE_REMOVED = 2,
}
public record CDOTAModifierBuffTableEntry(DOTA_MODIFIER_ENTRY_TYPE entry_type, uint parent, int index, int serial_num, int modifier_class, int ability_level, int stack_count, float creation_time, float duration, uint caster, uint ability, int armor, float fade_time, bool subtle, float channel_time, CMsgVector v_start, CMsgVector v_end, string portal_loop_appear, string portal_loop_disappear, string hero_loop_appear, string hero_loop_disappear, int movement_speed, bool aura, int activity, int damage, int range, int dd_modifier_index, int dd_ability_id, string illusion_label, bool active, string player_ids, string lua_name, int attack_speed, uint aura_owner, int bonus_all_stats, int bonus_health, int bonus_mana, uint custom_entity, bool aura_within_range) : DotaPacket;
public record CDOTALuaModifierEntry(int modifier_type, string modifier_filename) : DotaPacket;
