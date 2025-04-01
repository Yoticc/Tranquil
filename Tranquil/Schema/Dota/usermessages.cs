using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EBaseUserMessages
{
    UM_AchievementEvent = 101,
    UM_CloseCaption = 102,
    UM_CloseCaptionDirect = 103,
    UM_CurrentTimescale = 104,
    UM_DesiredTimescale = 105,
    UM_Fade = 106,
    UM_GameTitle = 107,
    UM_HudMsg = 110,
    UM_HudText = 111,
    UM_ColoredText = 113,
    UM_RequestState = 114,
    UM_ResetHUD = 115,
    UM_Rumble = 116,
    UM_SayText = 117,
    UM_SayText2 = 118,
    UM_SayTextChannel = 119,
    UM_Shake = 120,
    UM_ShakeDir = 121,
    UM_WaterShake = 122,
    UM_TextMsg = 124,
    UM_ScreenTilt = 125,
    UM_VoiceMask = 128,
    UM_SendAudio = 130,
    UM_ItemPickup = 131,
    UM_AmmoDenied = 132,
    UM_ShowMenu = 134,
    UM_CreditsMsg = 135,
    UM_CloseCaptionPlaceholder = 142,
    UM_CameraTransition = 143,
    UM_AudioParameter = 144,
    UM_ParticleManager = 145,
    UM_HudError = 146,
    UM_CustomGameEvent = 148,
    UM_AnimGraphUpdate = 149,
    UM_HapticsManagerPulse = 150,
    UM_HapticsManagerEffect = 151,
    UM_UpdateCssClasses = 153,
    UM_ServerFrameTime = 154,
    UM_LagCompensationError = 155,
    UM_RequestDllStatus = 156,
    UM_RequestUtilAction = 157,
    UM_UtilActionResponse = 158,
    UM_DllStatusResponse = 159,
    UM_RequestInventory = 160,
    UM_InventoryResponse = 161,
    UM_RequestDiagnostic = 162,
    UM_DiagnosticResponse = 163,
    UM_ExtraUserData = 164,
    UM_NotifyResponseFound = 165,
    UM_PlayResponseConditional = 166,
    UM_MAX_BASE = 200,
}
public enum EBaseEntityMessages
{
    EM_PlayJingle = 136,
    EM_ScreenOverlay = 137,
    EM_RemoveAllDecals = 138,
    EM_PropagateForce = 139,
    EM_DoSpark = 140,
    EM_FixAngle = 141,
}
public enum eRollType
{
    ROLL_NONE = -1,
    ROLL_STATS = 0,
    ROLL_CREDITS = 1,
    ROLL_LATE_JOIN_LOGO = 2,
    ROLL_OUTTRO = 3,
}
public enum PARTICLE_MESSAGE
{
    GAME_PARTICLE_MANAGER_EVENT_CREATE = 0,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE = 1,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 2,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 3,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 4,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 5,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 6,
    GAME_PARTICLE_MANAGER_EVENT_DESTROY = 7,
    GAME_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 8,
    GAME_PARTICLE_MANAGER_EVENT_RELEASE = 9,
    GAME_PARTICLE_MANAGER_EVENT_LATENCY = 10,
    GAME_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 11,
    GAME_PARTICLE_MANAGER_EVENT_FROZEN = 12,
    GAME_PARTICLE_MANAGER_EVENT_CHANGE_CONTROL_POINT_ATTACHMENT = 13,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENTITY_POSITION = 14,
    GAME_PARTICLE_MANAGER_EVENT_SET_FOW_PROPERTIES = 15,
    GAME_PARTICLE_MANAGER_EVENT_SET_TEXT = 16,
    GAME_PARTICLE_MANAGER_EVENT_SET_SHOULD_CHECK_FOW = 17,
    GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_MODEL = 18,
    GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_SNAPSHOT = 19,
    GAME_PARTICLE_MANAGER_EVENT_SET_TEXTURE_ATTRIBUTE = 20,
    GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_GENERIC_FLAG = 21,
    GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_TINT_AND_DESAT = 22,
    GAME_PARTICLE_MANAGER_EVENT_DESTROY_NAMED = 23,
    GAME_PARTICLE_MANAGER_EVENT_SKIP_TO_TIME = 24,
    GAME_PARTICLE_MANAGER_EVENT_CAN_FREEZE = 25,
    GAME_PARTICLE_MANAGER_EVENT_SET_NAMED_VALUE_CONTEXT = 26,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_TRANSFORM = 27,
    GAME_PARTICLE_MANAGER_EVENT_FREEZE_TRANSITION_OVERRIDE = 28,
    GAME_PARTICLE_MANAGER_EVENT_FREEZE_INVOLVING = 29,
    GAME_PARTICLE_MANAGER_EVENT_ADD_MODELLIST_OVERRIDE_ELEMENT = 30,
    GAME_PARTICLE_MANAGER_EVENT_CLEAR_MODELLIST_OVERRIDE = 31,
    GAME_PARTICLE_MANAGER_EVENT_CREATE_PHYSICS_SIM = 32,
    GAME_PARTICLE_MANAGER_EVENT_DESTROY_PHYSICS_SIM = 33,
    GAME_PARTICLE_MANAGER_EVENT_SET_VDATA = 34,
    GAME_PARTICLE_MANAGER_EVENT_SET_MATERIAL_OVERRIDE = 35,
    GAME_PARTICLE_MANAGER_EVENT_ADD_FAN = 36,
    GAME_PARTICLE_MANAGER_EVENT_UPDATE_FAN = 37,
    GAME_PARTICLE_MANAGER_EVENT_SET_CLUSTER_GROWTH = 38,
}
public enum EHapticPulseType
{
    VR_HAND_HAPTIC_PULSE_LIGHT = 0,
    VR_HAND_HAPTIC_PULSE_MEDIUM = 1,
    VR_HAND_HAPTIC_PULSE_STRONG = 2,
}
public record CUserMessageAchievementEvent(uint achievement) : DotaPacket;
public record CUserMessageCloseCaption(int SF1hash, float duration, bool from_player, int ent_index) : DotaPacket;
public record CUserMessageCloseCaptionDirect(int SF1hash, float duration, bool from_player, int ent_index) : DotaPacket;
public record CUserMessageCloseCaptionPlaceholder(string _string, float duration, bool from_player, int ent_index) : DotaPacket;
public record CUserMessageCurrentTimescale(float current) : DotaPacket;
public record CUserMessageDesiredTimescale(float desired, float acceleration, float minblendrate, float blenddeltamultiplier) : DotaPacket;
public record CUserMessageFade(uint duration, uint hold_time, uint flags, int SF1color) : DotaPacket;
public record CUserMessageShake(uint command, float amplitude, float frequency, float duration) : DotaPacket;
public record CUserMessageShakeDir(CUserMessageShake shake, CMsgVector direction) : DotaPacket;
public record CUserMessageWaterShake(uint command, float amplitude, float frequency, float duration) : DotaPacket;
public record CUserMessageScreenTilt(uint command, bool ease_in_out, CMsgVector angle, float duration, float time) : DotaPacket;
public record CUserMessageSayText(int playerindex, string text, bool chat) : DotaPacket;
public record CUserMessageSayText2(int entityindex, bool chat, string messagename, string param1, string param2, string param3, string param4) : DotaPacket;
public record CUserMessageHudMsg(uint channel, float x, float y, int SF1color1, int SF1color2, uint effect, bool unused7, bool unused8, bool unused9, bool unused10, string message) : DotaPacket;
public record CUserMessageHudText(string message) : DotaPacket;
public record CUserMessageTextMsg(uint dest, List<string> param) : DotaPacket;
public record CUserMessageGameTitle : DotaPacket;
public record CUserMessageResetHUD : DotaPacket;
public record CUserMessageSendAudio(string soundname, bool stop) : DotaPacket;
public record CUserMessageAudioParameter(uint parameter_type, uint name_hash_code, float value, uint int_value) : DotaPacket;
public record CUserMessageVoiceMask(List<uint> gamerules_masks, List<uint> ban_masks, bool mod_enable) : DotaPacket;
public record CUserMessageRequestState : DotaPacket;
public record CUserMessageRumble(int index, int data, int flags) : DotaPacket;
public record CUserMessageSayTextChannel(int player, int channel, string text) : DotaPacket;
public record CUserMessageColoredText(uint color, string text, bool reset, int context_player_slot, int context_value, int context_team_id) : DotaPacket;
public record CUserMessageItemPickup(string itemname) : DotaPacket;
public record CUserMessageAmmoDenied(uint ammo_id) : DotaPacket;
public record CUserMessageShowMenu(uint validslots, uint displaytime, bool needmore, string menustring) : DotaPacket;
public record CUserMessageCreditsMsg(eRollType rolltype, float logo_length) : DotaPacket;
public record CEntityMessagePlayJingle(CEntityMsg entity_msg) : DotaPacket;
public record CEntityMessageScreenOverlay(bool start_effect, CEntityMsg entity_msg) : DotaPacket;
public record CEntityMessageRemoveAllDecals(bool remove_decals, CEntityMsg entity_msg) : DotaPacket;
public record CEntityMessagePropagateForce(CMsgVector impulse, CEntityMsg entity_msg) : DotaPacket;
public record CEntityMessageDoSpark(CMsgVector origin, int entityindex, float radius, int SF1color, uint beams, float thick, float duration, CEntityMsg entity_msg) : DotaPacket;
public record CEntityMessageFixAngle(bool relative, CMsgQAngle angle, CEntityMsg entity_msg) : DotaPacket;
public record CUserMessageCameraTransition(uint camera_type, float duration, CUserMessageCameraTransition.Transition_DataDriven params_data_driven) : DotaPacket
{
    public record Transition_DataDriven(string filename, int attach_ent_index, float duration);
}
public record CUserMsg_ParticleManager(PARTICLE_MESSAGE type, uint index, CUserMsg_ParticleManager.ReleaseParticleIndex release_particle_index, CUserMsg_ParticleManager.CreateParticle create_particle, CUserMsg_ParticleManager.DestroyParticle destroy_particle, CUserMsg_ParticleManager.DestroyParticleInvolving destroy_particle_involving, CUserMsg_ParticleManager.UpdateParticle_OBSOLETE update_particle, CUserMsg_ParticleManager.UpdateParticleFwd_OBSOLETE update_particle_fwd, CUserMsg_ParticleManager.UpdateParticleOrient_OBSOLETE update_particle_orient, CUserMsg_ParticleManager.UpdateParticleFallback update_particle_fallback, CUserMsg_ParticleManager.UpdateParticleOffset update_particle_offset, CUserMsg_ParticleManager.UpdateParticleEnt update_particle_ent, bool unused13, CUserMsg_ParticleManager.UpdateParticleShouldDraw update_particle_should_draw, CUserMsg_ParticleManager.UpdateParticleSetFrozen update_particle_set_frozen, CUserMsg_ParticleManager.ChangeControlPointAttachment change_control_point_attachment, CUserMsg_ParticleManager.UpdateEntityPosition update_entity_position, CUserMsg_ParticleManager.SetParticleFoWProperties set_particle_fow_properties, CUserMsg_ParticleManager.SetParticleText set_particle_text, CUserMsg_ParticleManager.SetParticleShouldCheckFoW set_particle_should_check_fow, CUserMsg_ParticleManager.SetControlPointModel set_control_point_model, CUserMsg_ParticleManager.SetControlPointSnapshot set_control_point_snapshot, CUserMsg_ParticleManager.SetTextureAttribute set_texture_attribute, CUserMsg_ParticleManager.SetSceneObjectGenericFlag set_scene_object_generic_flag, CUserMsg_ParticleManager.SetSceneObjectTintAndDesat set_scene_object_tint_and_desat, CUserMsg_ParticleManager.DestroyParticleNamed destroy_particle_named, CUserMsg_ParticleManager.ParticleSkipToTime particle_skip_to_time, CUserMsg_ParticleManager.ParticleCanFreeze particle_can_freeze, CUserMsg_ParticleManager.SetParticleNamedValueContext set_named_value_context, CUserMsg_ParticleManager.UpdateParticleTransform update_particle_transform, CUserMsg_ParticleManager.ParticleFreezeTransitionOverride particle_freeze_transition_override, CUserMsg_ParticleManager.FreezeParticleInvolving freeze_particle_involving, CUserMsg_ParticleManager.AddModellistOverrideElement add_modellist_override_element, CUserMsg_ParticleManager.ClearModellistOverride clear_modellist_override, CUserMsg_ParticleManager.CreatePhysicsSim create_physics_sim, CUserMsg_ParticleManager.DestroyPhysicsSim destroy_physics_sim, CUserMsg_ParticleManager.SetVData set_vdata, CUserMsg_ParticleManager.SetMaterialOverride set_material_override, CUserMsg_ParticleManager.AddFan add_fan, CUserMsg_ParticleManager.UpdateFan update_fan, CUserMsg_ParticleManager.SetParticleClusterGrowth set_particle_cluster_growth) : DotaPacket
{
    public record ReleaseParticleIndex;
    public record CreateParticle(long SF2particle_name_index, int attach_type, uint entity_handle, uint entity_handle_for_modifiers, bool apply_voice_ban_rules, int team_behavior, string control_point_configuration, bool cluster, float endcap_time, CMsgVector aggregation_position);
    public record DestroyParticle(bool destroy_immediately);
    public record DestroyParticleInvolving(bool destroy_immediately, bool unused2, uint entity_handle);
    public record DestroyParticleNamed(long SF2particle_name_index, uint entity_handle, bool destroy_immediately, bool play_endcap);
    public record UpdateParticle_OBSOLETE(int control_point, CMsgVector position);
    public record UpdateParticleFwd_OBSOLETE(int control_point, CMsgVector forward);
    public record UpdateParticleOrient_OBSOLETE(int control_point, CMsgVector forward, CMsgVector deprecated_right, CMsgVector up, CMsgVector left);
    public record UpdateParticleTransform(int control_point, CMsgVector position, CMsgQuaternion orientation, float interpolation_interval);
    public record UpdateParticleFallback(int control_point, CMsgVector position);
    public record UpdateParticleOffset(int control_point, CMsgVector origin_offset, CMsgQAngle angle_offset);
    public record UpdateParticleEnt(int control_point, uint entity_handle, int attach_type, int attachment, CMsgVector fallback_position, bool include_wearables, CMsgVector offset_position, CMsgQAngle offset_angles);
    public record UpdateParticleSetFrozen(bool set_frozen, float transition_duration);
    public record UpdateParticleShouldDraw(bool should_draw);
    public record ChangeControlPointAttachment(int attachment_old, int attachment_new, uint entity_handle);
    public record UpdateEntityPosition(uint entity_handle, CMsgVector position);
    public record SetParticleFoWProperties(int fow_control_point, int fow_control_point2, float fow_radius);
    public record SetParticleShouldCheckFoW(bool check_fow);
    public record SetControlPointModel(int control_point, string model_name);
    public record SetControlPointSnapshot(int control_point, string snapshot_name);
    public record SetParticleText(string text);
    public record SetTextureAttribute(string attribute_name, string texture_name);
    public record SetSceneObjectGenericFlag(bool flag_value);
    public record SetSceneObjectTintAndDesat(int SF1tint, float desat);
    public record ParticleSkipToTime(float skip_to_time);
    public record ParticleCanFreeze(bool can_freeze);
    public record ParticleFreezeTransitionOverride(float freeze_transition_override);
    public record FreezeParticleInvolving(bool set_frozen, float transition_duration, uint entity_handle);
    public record AddModellistOverrideElement(string model_name, float spawn_probability, uint groupid);
    public record ClearModellistOverride(uint groupid);
    public record SetParticleNamedValueContext(List<CUserMsg_ParticleManager.SetParticleNamedValueContext.FloatContextValue> float_values, List<CUserMsg_ParticleManager.SetParticleNamedValueContext.VectorContextValue> vector_values, List<CUserMsg_ParticleManager.SetParticleNamedValueContext.TransformContextValue> transform_values, List<CUserMsg_ParticleManager.SetParticleNamedValueContext.EHandleContext> ehandle_values)
    {
        public record FloatContextValue(uint value_name_hash, float value);
        public record VectorContextValue(uint value_name_hash, CMsgVector value);
        public record TransformContextValue(uint value_name_hash, CMsgQAngle angles, CMsgVector translation);
        public record EHandleContext(uint value_name_hash, uint ent_index);
    }
    public record CreatePhysicsSim(string prop_group_name, bool use_high_quality_simulation, uint max_particle_count);
    public record DestroyPhysicsSim;
    public record SetVData(string vdata_name);
    public record SetMaterialOverride(string material_name, bool include_children);
    public record AddFan(bool active, CMsgVector bounds_mins, CMsgVector bounds_maxs, CMsgVector fan_origin, CMsgVector fan_origin_offset, CMsgVector fan_direction, float force, string fan_force_curve, bool falloff, bool pull_towards_point, float curve_min_dist, float curve_max_dist);
    public record UpdateFan(bool active, CMsgVector fan_origin, CMsgVector fan_origin_offset, CMsgVector fan_direction, CMsgVector bounds_mins, CMsgVector bounds_maxs, float fan_ramp_ratio);
    public record SetParticleClusterGrowth(float duration, CMsgVector origin);
}
public record CUserMsg_HudError(int order_id) : DotaPacket;
public record CUserMsg_CustomGameEvent(string event_name, byte[] data) : DotaPacket;
public record CUserMessageHapticsManagerPulse(int hand_id, float effect_amplitude, float effect_frequency, float effect_duration) : DotaPacket;
public record CUserMessageHapticsManagerEffect(int hand_id, uint effect_name_hash_code, float effect_scale) : DotaPacket;
public record CUserMessageAnimStateGraphState(int entity_index, byte[] data) : DotaPacket;
public record CUserMessageUpdateCssClasses(int target_world_panel, string css_classes, bool is_add) : DotaPacket;
public record CUserMessageServerFrameTime(float frame_time) : DotaPacket;
public record CUserMessageLagCompensationError(float distance) : DotaPacket;
public record CUserMessageRequestDllStatus(string dll_action, bool full_report) : DotaPacket;
public record CUserMessageRequestUtilAction(bool unused1, int util1, int util2, int util3, int util4, int util5) : DotaPacket;
public record CUserMessage_UtilMsg_Response(int SF1crc, int item_count, int SF1crc2, int item_count2, List<int> crc_part, List<int> crc_part2, int client_timestamp, int platform, List<CUserMessage_UtilMsg_Response.ItemDetail> itemdetails, int itemgroup, int total_count, int total_count2) : DotaPacket
{
    public record ItemDetail(int index, int hash, int crc, string name);
}
public record CUserMessage_DllStatus(string file_report, string command_line, uint total_files, uint process_id, int osversion, ulong client_time, List<CUserMessage_DllStatus.CVDiagnostic> diagnostics, List<CUserMessage_DllStatus.CModule> modules) : DotaPacket
{
    public record CVDiagnostic(uint id, uint extended, ulong value, string string_value);
    public record CModule(ulong base_addr, string name, uint size, uint timestamp);
}
public record CUserMessageRequestInventory(int inventory, int offset, int options) : DotaPacket;
public record CUserMessage_Inventory_Response(int SF1crc, int item_count, bool unused3, bool unused4, int osversion, int perf_time, int client_timestamp, int platform, List<CUserMessage_Inventory_Response.InventoryDetail> inventories, List<CUserMessage_Inventory_Response.InventoryDetail> inventories2, int inv_type, int build_version, int instance, List<CUserMessage_Inventory_Response.InventoryDetail> inventories3, long start_time) : DotaPacket
{
    public record InventoryDetail(int index, long primary, long offset, long first, long _base, string name, string base_name, int base_detail, int base_time, int base_hash);
}
public record CUserMessageRequestDiagnostic(List<CUserMessageRequestDiagnostic.Diagnostic> diagnostics) : DotaPacket
{
    public record Diagnostic(int index, long offset, int param, int length, int type, long _base, long range, long extent, long detail, string name, string alias, byte[] vardetail, int context);
}
public record CUserMessage_Diagnostic_Response(List<CUserMessage_Diagnostic_Response.Diagnostic> diagnostics, int build_version, int instance, long start_time, int osversion, int platform) : DotaPacket
{
    public record Diagnostic(int index, long offset, int param, int length, byte[] detail, long _base, long range, int type, bool unused9, string name, string alias, byte[] backup, int context, long control, long augment, long placebo);
}
public record CUserMessage_ExtraUserData(int item, long value1, long value2, List<byte[]> detail1, List<byte[]> detail2) : DotaPacket;
public record CUserMessage_NotifyResponseFound(int ent_index, string rule_name, string response_value, string response_concept, List<CUserMessage_NotifyResponseFound.Criteria> criteria, List<uint> int_criteria_names, List<int> int_criteria_values, List<uint> float_criteria_names, List<float> float_criteria_values, List<uint> symbol_criteria_names, List<uint> symbol_criteria_values, int speak_result) : DotaPacket
{
    public record Criteria(uint name_symbol, string value);
}
public record CUserMessage_PlayResponseConditional(int ent_index, List<int> player_slots, string response, CMsgVector ent_origin, float pre_delay, int mix_priority) : DotaPacket;
