using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgBotWorldState(uint team_id, float game_time, float dota_time, uint game_state, uint hero_pick_state, float time_of_day, float glyph_cooldown, float glyph_cooldown_enemy, bool unused9, List<CMsgBotWorldState.Player> players, List<CMsgBotWorldState.Unit> units, List<CMsgBotWorldState.DroppedItem> dropped_items, List<CMsgBotWorldState.RuneInfo> rune_infos, List<CMsgBotWorldState.TeleportInfo> incoming_teleports, List<CMsgBotWorldState.LinearProjectile> linear_projectiles, List<CMsgBotWorldState.AvoidanceZone> avoidance_zones, List<CMsgBotWorldState.Courier> couriers, bool unused18, bool unused19, List<CMsgBotWorldState.EventAbility> ability_events, List<CMsgBotWorldState.EventDamage> damage_events, List<CMsgBotWorldState.EventCourierKilled> courier_killed_events, List<CMsgBotWorldState.EventRoshanKilled> roshan_killed_events, List<CMsgBotWorldState.EventTree> tree_events, List<int> dropped_items_deltas, List<int> rune_infos_deltas) : DotaPacket
{
    public enum UnitType
    {
        INVALID = 0,
        HERO = 1,
        CREEP_HERO = 2,
        LANE_CREEP = 3,
        JUNGLE_CREEP = 4,
        ROSHAN = 5,
        TOWER = 6,
        BARRACKS = 7,
        SHRINE = 8,
        FORT = 9,
        BUILDING = 10,
        COURIER = 11,
        WARD = 12,
    }
    public enum CourierState
    {
        COURIER_STATE_INIT = -1,
        COURIER_STATE_IDLE = 0,
        COURIER_STATE_AT_BASE = 1,
        COURIER_STATE_MOVING = 2,
        COURIER_STATE_DELIVERING_ITEMS = 3,
        COURIER_STATE_RETURNING_TO_BASE = 4,
        COURIER_STATE_DEAD = 5,
    }
    public record Vector(float x, float y, float z);
    public record Player(int player_id, int hero_id, bool is_alive, float respawn_time, uint kills, uint deaths, uint assists, uint team_id, uint primary_unit_handle, int mmr, CMsgBotWorldState.Vector location);
    public record Ability(uint handle, int ability_id, uint slot, bool unused4, uint caster_handle, uint level, bool unused7, bool unused8, bool unused9, uint cast_range, float channel_time, float cooldown_remaining, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, bool is_activated, bool is_toggled, bool is_in_ability_phase, bool is_channeling, bool is_stolen, bool is_fully_castable, bool unused26, bool unused27, bool unused28, bool unused29, uint charges, uint secondary_charges, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool is_combined_locked, bool unused41, bool unused42, bool unused43, bool unused44, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, int power_treads_stat);
    public record DroppedItem(int item_id, CMsgBotWorldState.Vector location);
    public record RuneInfo(int type, CMsgBotWorldState.Vector location, uint status, float time_since_seen);
    public record TeleportInfo(int player_id, CMsgBotWorldState.Vector location, float time_remaining);
    public record Modifier(string name, uint stack_count, uint ability_handle, int ability_id, float remaining_duration, List<uint> auxiliary_units_handles, uint handle);
    public record LinearProjectile(uint handle, uint caster_handle, int caster_player_id, uint ability_handle, int ability_id, CMsgBotWorldState.Vector location, CMsgBotWorldState.Vector velocity, uint radius, CMsgBotWorldState.UnitType caster_unit_type);
    public record TrackingProjectile(uint caster_handle, int caster_player_id, uint ability_handle, int ability_id, CMsgBotWorldState.Vector location, uint velocity, bool is_dodgeable, bool is_attack, CMsgBotWorldState.UnitType caster_unit_type, uint handle);
    public record AvoidanceZone(CMsgBotWorldState.Vector location, uint caster_handle, int caster_player_id, uint ability_handle, int ability_id, uint radius, CMsgBotWorldState.UnitType caster_unit_type);
    public record Courier(uint handle, CMsgBotWorldState.CourierState state, int player_id);
    public record EventAbility(int ability_id, int player_id, uint unit_handle, CMsgBotWorldState.Vector location, bool is_channel_start);
    public record EventDamage(uint damage, int victim_player_id, uint victim_unit_handle, int attacker_player_id, uint attacker_unit_handle, int ability_id);
    public record EventCourierKilled(uint team_id, uint courier_unit_handle, int killer_player_id, uint killer_unit_handle);
    public record EventRoshanKilled(int killer_player_id, uint killer_unit_handle);
    public record EventTree(uint tree_id, bool destroyed, bool respawned, CMsgBotWorldState.Vector location, bool delayed);
    public record Unit(uint handle, CMsgBotWorldState.UnitType unit_type, string name, uint team_id, uint level, CMsgBotWorldState.Vector location, bool is_alive, int player_id, bool unused9, int bounding_radius, int facing, uint ground_height, bool unused13, bool unused14, uint vision_range_daytime, uint vision_range_nighttime, bool unused17, bool unused18, bool unused19, int health, int health_max, float health_regen, bool unused23, bool unused24, int mana, int mana_max, float mana_regen, bool unused28, bool unused29, int base_movement_speed, int current_movement_speed, bool unused32, bool unused33, bool unused34, int anim_activity, float anim_cycle, bool unused37, bool unused38, bool unused39, int base_damage, int base_damage_variance, int bonus_damage, int attack_damage, int attack_range, float attack_speed, float attack_anim_point, int attack_acquisition_range, int attack_projectile_speed, uint attack_target_handle, int attacks_per_second, float last_attack_time, string attack_target_name, bool unused53, bool unused54, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, uint bounty_xp, uint bounty_gold_min, uint bounty_gold_max, bool unused63, bool unused64, bool is_channeling, uint active_ability_handle, bool unused67, bool unused68, bool unused69, bool is_attack_immune, bool is_blind, bool is_block_disabled, bool is_disarmed, bool is_dominated, bool is_evade_disabled, bool is_hexed, bool is_invisible, bool is_invulnerable, bool is_magic_immune, bool is_muted, bool unused81, bool is_nightmared, bool is_rooted, bool is_silenced, bool is_specially_deniable, bool is_stunned, bool is_unable_to_miss, bool has_scepter, bool unused89, List<CMsgBotWorldState.Ability> abilities, List<CMsgBotWorldState.Ability> items, List<CMsgBotWorldState.Modifier> modifiers, List<CMsgBotWorldState.TrackingProjectile> incoming_tracking_projectiles, bool is_specially_undeniable, bool unused95, bool unused96, bool unused97, bool unused98, bool unused99, uint action_type, uint ability_target_handle, bool is_using_ability, string ability_target_name, bool unused104, bool unused105, bool unused106, bool unused107, bool unused108, bool unused109, uint primary_attribute, bool is_illusion, float respawn_time, uint buyback_cost, float buyback_cooldown, float spell_amplification, float armor, float magic_resist, float evasion, bool unused119, uint xp_needed_to_level, uint ability_points, int reliable_gold, int unreliable_gold, uint last_hits, uint denies, uint net_worth, uint strength, uint agility, uint intelligence, float remaining_lifespan, bool unused131, bool unused132, bool unused133, bool unused134, bool unused135, bool unused136, bool unused137, bool unused138, bool unused139, bool flying_courier, bool unused141, bool unused142, bool unused143, bool unused144, bool unused145, bool unused146, bool unused147, bool unused148, bool unused149, float shrine_cooldown, bool is_shrine_healing);
}
