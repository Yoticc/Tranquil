namespace Tranquil.Schema;

public enum CLC_Messages
{
    clc_ClientInfo = 20,
    clc_Move = 21,
    clc_VoiceData = 22,
    clc_BaselineAck = 23,
    clc_RespondCvarValue = 25,
    clc_FileCRCCheck = 26,
    clc_LoadingProgress = 27,
    clc_SplitPlayerConnect = 28,
    clc_SplitPlayerDisconnect = 30,
    clc_ServerStatus = 31,
    clc_RequestPause = 33,
    clc_CmdKeyValues = 34,
    clc_RconServerDetails = 35,
    clc_HltvReplay = 36,
    clc_Diagnostic = 37,
}
public enum SVC_Messages
{
    svc_ServerInfo = 40,
    svc_FlattenedSerializer = 41,
    svc_ClassInfo = 42,
    svc_SetPause = 43,
    svc_CreateStringTable = 44,
    svc_UpdateStringTable = 45,
    svc_VoiceInit = 46,
    svc_VoiceData = 47,
    svc_Print = 48,
    svc_Sounds = 49,
    svc_SetView = 50,
    svc_ClearAllStringTables = 51,
    svc_CmdKeyValues = 52,
    svc_BSPDecal = 53,
    svc_SplitScreen = 54,
    svc_PacketEntities = 55,
    svc_Prefetch = 56,
    svc_Menu = 57,
    svc_GetCvarValue = 58,
    svc_StopSound = 59,
    svc_PeerList = 60,
    svc_PacketReliable = 61,
    svc_HLTVStatus = 62,
    svc_ServerSteamID = 63,
    svc_FullFrameSplit = 70,
    svc_RconServerDetails = 71,
    svc_UserMessage = 72,
    svc_Broadcast_Command = 74,
    svc_HltvFixupOperatorStatus = 75,
    svc_UserCmds = 76,
}
public enum VoiceDataFormat_t
{
    VOICEDATA_FORMAT_STEAM = 0,
    VOICEDATA_FORMAT_ENGINE = 1,
    VOICEDATA_FORMAT_OPUS = 2,
}
public enum RequestPause_t
{
    RP_PAUSE = 0,
    RP_UNPAUSE = 1,
    RP_TOGGLEPAUSE = 2,
}
public enum PrefetchType
{
    PFT_SOUND = 0,
}
public enum ESplitScreenMessageType
{
    MSG_SPLITSCREEN_ADDUSER = 0,
    MSG_SPLITSCREEN_REMOVEUSER = 1,
}
public enum EQueryCvarValueStatus
{
    eQueryCvarValueStatus_ValueIntact = 0,
    eQueryCvarValueStatus_CvarNotFound = 1,
    eQueryCvarValueStatus_NotACvar = 2,
    eQueryCvarValueStatus_CvarProtected = 3,
}
public enum DIALOG_TYPE
{
    DIALOG_MSG = 0,
    DIALOG_MENU = 1,
    DIALOG_TEXT = 2,
    DIALOG_ENTRY = 3,
    DIALOG_ASKCONNECT = 4,
}
public enum SVC_Messages_LowFrequency
{
    svc_dummy = 600,
}
public enum Bidirectional_Messages
{
    bi_RebroadcastGameEvent = 16,
    bi_RebroadcastSource = 17,
    bi_GameEvent = 18,
    bi_PredictionEvent = 19,
}
public enum Bidirectional_Messages_LowFrequency
{
    bi_RelayInfo = 700,
    bi_RelayPacket = 701,
}
public enum ReplayEventType_t
{
    REPLAY_EVENT_CANCEL = 0,
    REPLAY_EVENT_DEATH = 1,
    REPLAY_EVENT_GENERIC = 2,
    REPLAY_EVENT_STUCK_NEED_FULL_UPDATE = 3,
    REPLAY_EVENT_VICTORY = 4,
}
public record CCLCMsg_ClientInfo(int SF1send_table_crc, uint server_count, bool is_hltv, bool unused4, uint friends_id, string friends_name) : DotaPacket;
public record CCLCMsg_Move(bool unused1, bool unused2, byte[] data, uint last_command_number) : DotaPacket;
public record CMsgVoiceAudio(VoiceDataFormat_t format, byte[] voice_data, int sequence_bytes, uint section_number, uint sample_rate, uint uncompressed_sample_offset, uint num_packets, List<uint> packet_offsets, float voice_level) : DotaPacket;
public record CCLCMsg_VoiceData(CMsgVoiceAudio audio, long SF2xuid, uint tick) : DotaPacket;
public record CCLCMsg_BaselineAck(int baseline_tick, int baseline_nr) : DotaPacket;
public record CCLCMsg_ListenEvents(List<int> SF1event_mask) : DotaPacket;
public record CCLCMsg_RespondCvarValue(int cookie, int status_code, string name, string value) : DotaPacket;
public record CCLCMsg_FileCRCCheck(int code_path, string path, int code_filename, string filename, int SF1crc) : DotaPacket;
public record CCLCMsg_LoadingProgress(int progress) : DotaPacket;
public record CCLCMsg_SplitPlayerConnect(string playername) : DotaPacket;
public record CCLCMsg_SplitPlayerDisconnect(int slot) : DotaPacket;
public record CCLCMsg_ServerStatus(bool simplified) : DotaPacket;
public record CCLCMsg_RequestPause(RequestPause_t pause_type, int pause_group) : DotaPacket;
public record CCLCMsg_CmdKeyValues(byte[] data) : DotaPacket;
public record CCLCMsg_RconServerDetails(byte[] token) : DotaPacket;
public record CMsgSource2SystemSpecs(string cpu_id, string cpu_brand, uint cpu_model, uint cpu_num_physical, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, bool unused10, bool unused11, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, bool unused20, uint ram_physical_total_mb, bool unused22, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, string gpu_rendersystem_dll_name, uint gpu_vendor_id, string gpu_driver_name, uint gpu_driver_version_high, uint gpu_driver_version_low, uint gpu_dx_support_level, uint gpu_texture_memory_size_mb) : DotaPacket;
public record CMsgSource2VProfLiteReportItem(string name, uint active_samples, uint usec_max, uint active_samples_1secmax, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, bool unused10, uint usec_avg_active, uint usec_p50_active, uint usec_p99_active, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, bool unused20, uint usec_avg_all, uint usec_p50_all, uint usec_p99_all, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, uint usec_1secmax_avg_active, uint usec_1secmax_p50_active, uint usec_1secmax_p95_active, uint usec_1secmax_p99_active, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, uint usec_1secmax_avg_all, uint usec_1secmax_p50_all, uint usec_1secmax_p95_all, uint usec_1secmax_p99_all) : DotaPacket;
public record CMsgSource2VProfLiteReport(CMsgSource2VProfLiteReportItem total, List<CMsgSource2VProfLiteReportItem> items, uint discarded_frames) : DotaPacket;
public record CMsgSource2NetworkFlowQuality(uint duration, bool unused2, bool unused3, bool unused4, ulong bytes_total, ulong bytes_total_reliable, ulong bytes_total_voice, bool unused8, bool unused9, uint bytes_sec_p95, uint bytes_sec_p99, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, uint enginemsgs_total, uint enginemsgs_sec_p95, uint enginemsgs_sec_p99, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, uint ticks_total, uint ticks_good, uint ticks_good_almost_late, uint ticks_fixed_dropped, uint ticks_fixed_late, uint ticks_bad_dropped, uint ticks_bad_late, uint ticks_bad_other, bool unused48, bool unused49, uint tick_missrate_samples_total, uint tick_missrate_samples_perfect, uint tick_missrate_samples_perfectnet, uint tick_missratenet_p75_x10, uint tick_missratenet_p95_x10, uint tick_missratenet_p99_x10, bool unused56, bool unused57, bool unused58, bool unused59, bool unused60, int SS1recvmargin_p1, int SS1recvmargin_p5, int SS1recvmargin_p25, int SS1recvmargin_p50, int SS1recvmargin_p75, int SS1recvmargin_p95) : DotaPacket;
public record CCLCMsg_Diagnostic(CMsgSource2SystemSpecs system_specs, CMsgSource2VProfLiteReport vprof_report) : DotaPacket;
public record CSource2Metrics_MatchPerfSummary_Notification(uint appid, string game_mode, uint server_build_id, bool unused4, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, CMsgSource2VProfLiteReport server_profile, List<CSource2Metrics_MatchPerfSummary_Notification.Client> clients, bool unused12, bool unused13, bool unused14, bool unused15, bool unused16, bool unused17, bool unused18, bool unused19, string map) : DotaPacket
{
    public record Client(CMsgSource2SystemSpecs system_specs, CMsgSource2VProfLiteReport profile, uint build_id, bool unused4, bool unused5, bool unused6, bool unused7, bool unused8, bool unused9, long SF2steamid);
}
public record CSVCMsg_ServerInfo(int protocol, int server_count, bool is_dedicated, bool is_hltv, bool unused5, int c_os, bool unused7, bool unused8, bool unused9, int max_clients, int max_classes, int player_slot, float tick_interval, string game_dir, string map_name, string sky_name, string host_name, string addon_name, CSVCMsg_GameSessionConfiguration game_session_config, byte[] game_session_manifest) : DotaPacket;
public record CSVCMsg_ClassInfo(bool create_on_client, List<CSVCMsg_ClassInfo.class_t> classes) : DotaPacket
{
    public record class_t(int class_id, bool unused2, string class_name);
}
public record CSVCMsg_SetPause(bool paused) : DotaPacket;
public record CSVCMsg_VoiceInit(int quality, string codec, int version) : DotaPacket;
public record CSVCMsg_Print(string text) : DotaPacket;
public record CSVCMsg_Sounds(bool reliable_sound, List<CSVCMsg_Sounds.sounddata_t> sounds) : DotaPacket
{
    public record sounddata_t(int SS1origin_x, int SS1origin_y, int SS1origin_z, uint volume, float delay_value, int sequence_number, int entity_index, int channel, int pitch, int flags, uint sound_num, int SF1sound_num_handle, int speaker_entity, int random_seed, int sound_level, bool is_sentence, bool is_ambient, uint guid, long SF2sound_resource_id);
}
public record CSVCMsg_Prefetch(int sound_index, PrefetchType resource_type) : DotaPacket;
public record CSVCMsg_SetView(int entity_index, int slot) : DotaPacket;
public record CSVCMsg_FixAngle(bool relative, CMsgQAngle angle) : DotaPacket;
public record CSVCMsg_CrosshairAngle(CMsgQAngle angle) : DotaPacket;
public record CSVCMsg_BSPDecal(CMsgVector pos, int decal_texture_index, int entity_index, int model_index, bool low_priority) : DotaPacket;
public record CSVCMsg_SplitScreen(ESplitScreenMessageType type, int slot, int player_index) : DotaPacket;
public record CSVCMsg_GetCvarValue(int cookie, string cvar_name) : DotaPacket;
public record CSVCMsg_Menu(int dialog_type, byte[] menu_key_values) : DotaPacket;
public record CSVCMsg_UserMessage(int msg_type, byte[] msg_data, int passthrough) : DotaPacket;
public record CSVCMsg_SendTable(bool is_end, string net_table_name, bool needs_decoder, List<CSVCMsg_SendTable.sendprop_t> props) : DotaPacket
{
    public record sendprop_t(int type, string var_name, int flags, int priority, string dt_name, int num_elements, float low_value, float high_value, int num_bits);
}
public record CSVCMsg_GameEventList(List<CSVCMsg_GameEventList.descriptor_t> descriptors) : DotaPacket
{
    public record key_t(int type, string name);
    public record descriptor_t(int eventid, string name, List<CSVCMsg_GameEventList.key_t> keys);
}
public record CSVCMsg_PacketEntities(int max_entries, int updated_entries, bool legacy_is_delta, bool update_baseline, int baseline, int delta_from, byte[] entity_data, bool pending_full_frame, uint active_spawngroup_handle, uint max_spawngroup_creationsequence, uint last_cmd_number_executed, uint server_tick, byte[] serialized_entities, bool unused14, List<CSVCMsg_PacketEntities.alternate_baseline_t> alternate_baselines, uint has_pvs_vis_bits_deprecated, int SS1last_cmd_number_recv_delta, bool unused18, CSVCMsg_PacketEntities.non_transmitted_entities_t non_transmitted_entities, uint cq_starved_command_ticks, uint cq_discarded_command_ticks, List<int> SS1cmd_recv_status, bool unused23, bool unused24, bool unused25, bool unused26, bool unused27, bool unused28, bool unused29, bool unused30, bool unused31, bool unused32, bool unused33, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, bool unused41, bool unused42, bool unused43, bool unused44, bool unused45, bool unused46, bool unused47, bool unused48, bool unused49, bool unused50, bool unused51, bool unused52, bool unused53, bool unused54, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, bool unused60, bool unused61, bool unused62, bool unused63, bool unused64, bool unused65, bool unused66, bool unused67, bool unused68, bool unused69, bool unused70, bool unused71, bool unused72, bool unused73, bool unused74, bool unused75, bool unused76, bool unused77, bool unused78, bool unused79, bool unused80, bool unused81, bool unused82, bool unused83, bool unused84, bool unused85, bool unused86, bool unused87, bool unused88, bool unused89, bool unused90, bool unused91, bool unused92, bool unused93, bool unused94, bool unused95, bool unused96, bool unused97, bool unused98, bool unused99, bool unused100, bool unused101, bool unused102, bool unused103, bool unused104, bool unused105, bool unused106, bool unused107, bool unused108, bool unused109, bool unused110, bool unused111, bool unused112, bool unused113, bool unused114, bool unused115, bool unused116, bool unused117, bool unused118, bool unused119, bool unused120, bool unused121, bool unused122, bool unused123, bool unused124, bool unused125, bool unused126, bool unused127, bool unused128, bool unused129, bool unused130, bool unused131, bool unused132, bool unused133, bool unused134, bool unused135, bool unused136, bool unused137, bool unused138, bool unused139, bool unused140, bool unused141, bool unused142, bool unused143, bool unused144, bool unused145, bool unused146, bool unused147, bool unused148, bool unused149, bool unused150, bool unused151, bool unused152, bool unused153, bool unused154, bool unused155, bool unused156, bool unused157, bool unused158, bool unused159, bool unused160, bool unused161, bool unused162, bool unused163, bool unused164, bool unused165, bool unused166, bool unused167, bool unused168, bool unused169, bool unused170, bool unused171, bool unused172, bool unused173, bool unused174, bool unused175, bool unused176, bool unused177, bool unused178, bool unused179, bool unused180, bool unused181, bool unused182, bool unused183, bool unused184, bool unused185, bool unused186, bool unused187, bool unused188, bool unused189, bool unused190, bool unused191, bool unused192, bool unused193, bool unused194, bool unused195, bool unused196, bool unused197, bool unused198, bool unused199, bool unused200, bool unused201, bool unused202, bool unused203, bool unused204, bool unused205, bool unused206, bool unused207, bool unused208, bool unused209, bool unused210, bool unused211, bool unused212, bool unused213, bool unused214, bool unused215, bool unused216, bool unused217, bool unused218, bool unused219, bool unused220, bool unused221, bool unused222, bool unused223, bool unused224, bool unused225, bool unused226, bool unused227, bool unused228, bool unused229, bool unused230, bool unused231, bool unused232, bool unused233, bool unused234, bool unused235, bool unused236, bool unused237, bool unused238, bool unused239, bool unused240, bool unused241, bool unused242, bool unused243, bool unused244, bool unused245, bool unused246, bool unused247, bool unused248, bool unused249, bool unused250, bool unused251, bool unused252, bool unused253, bool unused254, bool unused255, bool unused256, bool unused257, bool unused258, bool unused259, bool unused260, bool unused261, bool unused262, bool unused263, bool unused264, bool unused265, bool unused266, bool unused267, bool unused268, bool unused269, bool unused270, bool unused271, bool unused272, bool unused273, bool unused274, bool unused275, bool unused276, bool unused277, bool unused278, bool unused279, bool unused280, bool unused281, bool unused282, bool unused283, bool unused284, bool unused285, bool unused286, bool unused287, bool unused288, bool unused289, bool unused290, bool unused291, bool unused292, bool unused293, bool unused294, bool unused295, bool unused296, bool unused297, bool unused298, bool unused299, bool unused300, bool unused301, bool unused302, bool unused303, bool unused304, bool unused305, bool unused306, bool unused307, bool unused308, bool unused309, bool unused310, bool unused311, bool unused312, bool unused313, bool unused314, bool unused315, bool unused316, bool unused317, bool unused318, bool unused319, bool unused320, bool unused321, bool unused322, bool unused323, bool unused324, bool unused325, bool unused326, bool unused327, bool unused328, bool unused329, bool unused330, bool unused331, bool unused332, bool unused333, bool unused334, bool unused335, bool unused336, bool unused337, bool unused338, bool unused339, bool unused340, bool unused341, bool unused342, bool unused343, bool unused344, bool unused345, bool unused346, bool unused347, bool unused348, bool unused349, bool unused350, bool unused351, bool unused352, bool unused353, bool unused354, bool unused355, bool unused356, bool unused357, bool unused358, bool unused359, bool unused360, bool unused361, bool unused362, bool unused363, bool unused364, bool unused365, bool unused366, bool unused367, bool unused368, bool unused369, bool unused370, bool unused371, bool unused372, bool unused373, bool unused374, bool unused375, bool unused376, bool unused377, bool unused378, bool unused379, bool unused380, bool unused381, bool unused382, bool unused383, bool unused384, bool unused385, bool unused386, bool unused387, bool unused388, bool unused389, bool unused390, bool unused391, bool unused392, bool unused393, bool unused394, bool unused395, bool unused396, bool unused397, bool unused398, bool unused399, bool unused400, bool unused401, bool unused402, bool unused403, bool unused404, bool unused405, bool unused406, bool unused407, bool unused408, bool unused409, bool unused410, bool unused411, bool unused412, bool unused413, bool unused414, bool unused415, bool unused416, bool unused417, bool unused418, bool unused419, bool unused420, bool unused421, bool unused422, bool unused423, bool unused424, bool unused425, bool unused426, bool unused427, bool unused428, bool unused429, bool unused430, bool unused431, bool unused432, bool unused433, bool unused434, bool unused435, bool unused436, bool unused437, bool unused438, bool unused439, bool unused440, bool unused441, bool unused442, bool unused443, bool unused444, bool unused445, bool unused446, bool unused447, bool unused448, bool unused449, bool unused450, bool unused451, bool unused452, bool unused453, bool unused454, bool unused455, bool unused456, bool unused457, bool unused458, bool unused459, bool unused460, bool unused461, bool unused462, bool unused463, bool unused464, bool unused465, bool unused466, bool unused467, bool unused468, bool unused469, bool unused470, bool unused471, bool unused472, bool unused473, bool unused474, bool unused475, bool unused476, bool unused477, bool unused478, bool unused479, bool unused480, bool unused481, bool unused482, bool unused483, bool unused484, bool unused485, bool unused486, bool unused487, bool unused488, bool unused489, bool unused490, bool unused491, bool unused492, bool unused493, bool unused494, bool unused495, bool unused496, bool unused497, bool unused498, bool unused499, bool unused500, bool unused501, bool unused502, bool unused503, bool unused504, bool unused505, bool unused506, bool unused507, bool unused508, bool unused509, bool unused510, bool unused511, bool unused512, bool unused513, bool unused514, bool unused515, bool unused516, bool unused517, bool unused518, bool unused519, bool unused520, bool unused521, bool unused522, bool unused523, bool unused524, bool unused525, bool unused526, bool unused527, bool unused528, bool unused529, bool unused530, bool unused531, bool unused532, bool unused533, bool unused534, bool unused535, bool unused536, bool unused537, bool unused538, bool unused539, bool unused540, bool unused541, bool unused542, bool unused543, bool unused544, bool unused545, bool unused546, bool unused547, bool unused548, bool unused549, bool unused550, bool unused551, bool unused552, bool unused553, bool unused554, bool unused555, bool unused556, bool unused557, bool unused558, bool unused559, bool unused560, bool unused561, bool unused562, bool unused563, bool unused564, bool unused565, bool unused566, bool unused567, bool unused568, bool unused569, bool unused570, bool unused571, bool unused572, bool unused573, bool unused574, bool unused575, bool unused576, bool unused577, bool unused578, bool unused579, bool unused580, bool unused581, bool unused582, bool unused583, bool unused584, bool unused585, bool unused586, bool unused587, bool unused588, bool unused589, bool unused590, bool unused591, bool unused592, bool unused593, bool unused594, bool unused595, bool unused596, bool unused597, bool unused598, bool unused599, bool unused600, bool unused601, bool unused602, bool unused603, bool unused604, bool unused605, bool unused606, bool unused607, bool unused608, bool unused609, bool unused610, bool unused611, bool unused612, bool unused613, bool unused614, bool unused615, bool unused616, bool unused617, bool unused618, bool unused619, bool unused620, bool unused621, bool unused622, bool unused623, bool unused624, bool unused625, bool unused626, bool unused627, bool unused628, bool unused629, bool unused630, bool unused631, bool unused632, bool unused633, bool unused634, bool unused635, bool unused636, bool unused637, bool unused638, bool unused639, bool unused640, bool unused641, bool unused642, bool unused643, bool unused644, bool unused645, bool unused646, bool unused647, bool unused648, bool unused649, bool unused650, bool unused651, bool unused652, bool unused653, bool unused654, bool unused655, bool unused656, bool unused657, bool unused658, bool unused659, bool unused660, bool unused661, bool unused662, bool unused663, bool unused664, bool unused665, bool unused666, bool unused667, bool unused668, bool unused669, bool unused670, bool unused671, bool unused672, bool unused673, bool unused674, bool unused675, bool unused676, bool unused677, bool unused678, bool unused679, bool unused680, bool unused681, bool unused682, bool unused683, bool unused684, bool unused685, bool unused686, bool unused687, bool unused688, bool unused689, bool unused690, bool unused691, bool unused692, bool unused693, bool unused694, bool unused695, bool unused696, bool unused697, bool unused698, bool unused699, bool unused700, bool unused701, bool unused702, bool unused703, bool unused704, bool unused705, bool unused706, bool unused707, bool unused708, bool unused709, bool unused710, bool unused711, bool unused712, bool unused713, bool unused714, bool unused715, bool unused716, bool unused717, bool unused718, bool unused719, bool unused720, bool unused721, bool unused722, bool unused723, bool unused724, bool unused725, bool unused726, bool unused727, bool unused728, bool unused729, bool unused730, bool unused731, bool unused732, bool unused733, bool unused734, bool unused735, bool unused736, bool unused737, bool unused738, bool unused739, bool unused740, bool unused741, bool unused742, bool unused743, bool unused744, bool unused745, bool unused746, bool unused747, bool unused748, bool unused749, bool unused750, bool unused751, bool unused752, bool unused753, bool unused754, bool unused755, bool unused756, bool unused757, bool unused758, bool unused759, bool unused760, bool unused761, bool unused762, bool unused763, bool unused764, bool unused765, bool unused766, bool unused767, bool unused768, bool unused769, bool unused770, bool unused771, bool unused772, bool unused773, bool unused774, bool unused775, bool unused776, bool unused777, bool unused778, bool unused779, bool unused780, bool unused781, bool unused782, bool unused783, bool unused784, bool unused785, bool unused786, bool unused787, bool unused788, bool unused789, bool unused790, bool unused791, bool unused792, bool unused793, bool unused794, bool unused795, bool unused796, bool unused797, bool unused798, bool unused799, bool unused800, bool unused801, bool unused802, bool unused803, bool unused804, bool unused805, bool unused806, bool unused807, bool unused808, bool unused809, bool unused810, bool unused811, bool unused812, bool unused813, bool unused814, bool unused815, bool unused816, bool unused817, bool unused818, bool unused819, bool unused820, bool unused821, bool unused822, bool unused823, bool unused824, bool unused825, bool unused826, bool unused827, bool unused828, bool unused829, bool unused830, bool unused831, bool unused832, bool unused833, bool unused834, bool unused835, bool unused836, bool unused837, bool unused838, bool unused839, bool unused840, bool unused841, bool unused842, bool unused843, bool unused844, bool unused845, bool unused846, bool unused847, bool unused848, bool unused849, bool unused850, bool unused851, bool unused852, bool unused853, bool unused854, bool unused855, bool unused856, bool unused857, bool unused858, bool unused859, bool unused860, bool unused861, bool unused862, bool unused863, bool unused864, bool unused865, bool unused866, bool unused867, bool unused868, bool unused869, bool unused870, bool unused871, bool unused872, bool unused873, bool unused874, bool unused875, bool unused876, bool unused877, bool unused878, bool unused879, bool unused880, bool unused881, bool unused882, bool unused883, bool unused884, bool unused885, bool unused886, bool unused887, bool unused888, bool unused889, bool unused890, bool unused891, bool unused892, bool unused893, bool unused894, bool unused895, bool unused896, bool unused897, bool unused898, bool unused899, bool unused900, bool unused901, bool unused902, bool unused903, bool unused904, bool unused905, bool unused906, bool unused907, bool unused908, bool unused909, bool unused910, bool unused911, bool unused912, bool unused913, bool unused914, bool unused915, bool unused916, bool unused917, bool unused918, bool unused919, bool unused920, bool unused921, bool unused922, bool unused923, bool unused924, bool unused925, bool unused926, bool unused927, bool unused928, bool unused929, bool unused930, bool unused931, bool unused932, bool unused933, bool unused934, bool unused935, bool unused936, bool unused937, bool unused938, bool unused939, bool unused940, bool unused941, bool unused942, bool unused943, bool unused944, bool unused945, bool unused946, bool unused947, bool unused948, bool unused949, bool unused950, bool unused951, bool unused952, bool unused953, bool unused954, bool unused955, bool unused956, bool unused957, bool unused958, bool unused959, bool unused960, bool unused961, bool unused962, bool unused963, bool unused964, bool unused965, bool unused966, bool unused967, bool unused968, bool unused969, bool unused970, bool unused971, bool unused972, bool unused973, bool unused974, bool unused975, bool unused976, bool unused977, bool unused978, bool unused979, bool unused980, bool unused981, bool unused982, bool unused983, bool unused984, bool unused985, bool unused986, bool unused987, bool unused988, bool unused989, bool unused990, bool unused991, bool unused992, bool unused993, bool unused994, bool unused995, bool unused996, bool unused997, bool unused998, byte[] dev_padding) : DotaPacket
{
    public record alternate_baseline_t(int entity_index, int baseline_index);
    public record non_transmitted_entities_t(int header_count, byte[] data);
}
public record CSVCMsg_TempEntities(bool reliable, int num_entries, byte[] entity_data) : DotaPacket;
public record CSVCMsg_CreateStringTable(string name, int num_entries, bool user_data_fixed_size, int user_data_size, int user_data_size_bits, int flags, byte[] string_data, int uncompressed_size, bool data_compressed, bool using_varint_bitcounts) : DotaPacket;
public record CSVCMsg_UpdateStringTable(int table_id, int num_changed_entries, byte[] string_data) : DotaPacket;
public record CSVCMsg_VoiceData(CMsgVoiceAudio audio, int client, bool proximity, long SF2xuid, int audible_mask, uint tick, int passthrough) : DotaPacket;
public record CSVCMsg_PacketReliable(int tick, int messagessize, bool state) : DotaPacket;
public record CSVCMsg_FullFrameSplit(int tick, int section, int total, byte[] data) : DotaPacket;
public record CSVCMsg_HLTVStatus(string master, int clients, int slots, int proxies) : DotaPacket;
public record CSVCMsg_ServerSteamID(ulong steam_id) : DotaPacket;
public record CSVCMsg_CmdKeyValues(byte[] data) : DotaPacket;
public record CSVCMsg_RconServerDetails(byte[] token, string details) : DotaPacket;
public record CMsgIPCAddress(long SF2computer_guid, uint process_id) : DotaPacket;
public record CMsgServerPeer(int player_slot, long SF2steamid, CMsgIPCAddress ipc, bool they_hear_you, bool you_hear_them, bool is_listenserver_host) : DotaPacket;
public record CSVCMsg_PeerList(List<CMsgServerPeer> peer) : DotaPacket;
public record CSVCMsg_ClearAllStringTables(string mapname, bool unused2, bool create_tables_skipped) : DotaPacket;
public record ProtoFlattenedSerializerField_t(int var_type_sym, int var_name_sym, int bit_count, float low_value, float high_value, int encode_flags, int field_serializer_name_sym, int field_serializer_version, int send_node_sym, int var_encoder_sym, List<ProtoFlattenedSerializerField_t.polymorphic_field_t> polymorphic_types, int var_serializer_sym) : DotaPacket
{
    public record polymorphic_field_t(int polymorphic_field_serializer_name_sym, int polymorphic_field_serializer_version);
}
public record ProtoFlattenedSerializer_t(int serializer_name_sym, int serializer_version, List<int> fields_index) : DotaPacket;
public record CSVCMsg_FlattenedSerializer(List<ProtoFlattenedSerializer_t> serializers, List<string> symbols, List<ProtoFlattenedSerializerField_t> fields) : DotaPacket;
public record CSVCMsg_StopSound(int SF1guid) : DotaPacket;
public record CBidirMsg_RebroadcastGameEvent(bool posttoserver, int buftype, uint clientbitcount, ulong receivingclients) : DotaPacket;
public record CBidirMsg_RebroadcastSource(int eventsource) : DotaPacket;
public record CBidirMsg_PredictionEvent(uint event_id, byte[] event_data, uint sync_type, uint sync_val_uint32) : DotaPacket
{
    public enum ESyncType
    {
        ST_Tick = 0,
        ST_UserCmdNum = 1,
    }
}
public record CMsgServerNetworkStats(bool dedicated, int cpu_usage, int memory_used_mb, int memory_free_mb, int uptime, int spawn_count, bool unused7, int num_clients, int num_bots, int num_spectators, int num_tv_relays, float fps, bool unused13, bool unused14, bool unused15, bool unused16, List<CMsgServerNetworkStats.Port> ports, float avg_ping_ms, float avg_engine_latency_out, float avg_packets_out, float avg_packets_in, float avg_loss_out, float avg_loss_in, float avg_data_out, float avg_data_in, ulong total_data_in, ulong total_packets_in, ulong total_data_out, ulong total_packets_out, List<CMsgServerNetworkStats.Player> players) : DotaPacket
{
    public record Port(int port, string name);
    public record Player(ulong steamid, string remote_addr, bool unused3, int ping_avg_ms, float packet_loss_pct, bool is_bot, float loss_in, float loss_out, int engine_latency_ms);
}
public record CSVCMsg_HltvReplay(int delay, int primary_target, int replay_stop_at, int replay_start_at, int replay_slowdown_begin, int replay_slowdown_end, float replay_slowdown_rate, int reason) : DotaPacket;
public record CCLCMsg_HltvReplay(int request, float slowdown_length, float slowdown_rate, int primary_target, float event_time) : DotaPacket;
public record CSVCMsg_Broadcast_Command(string cmd) : DotaPacket;
public record CCLCMsg_HltvFixupOperatorTick(int tick, byte[] props_data, CMsgVector origin, CMsgQAngle eye_angles, int observer_mode, bool cameraman_scoreboard, int observer_target, CMsgVector view_offset) : DotaPacket;
public record CSVCMsg_HltvFixupOperatorStatus(uint mode, string override_operator_name) : DotaPacket;
public record CMsgServerUserCmd(byte[] data, int cmd_number, int player_slot, int server_tick_executed, int client_tick) : DotaPacket;
public record CSVCMsg_UserCommands(List<CMsgServerUserCmd> commands) : DotaPacket;
