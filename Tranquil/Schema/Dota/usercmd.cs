using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CInButtonStatePB(ulong buttonstate1, ulong buttonstate2, ulong buttonstate3) : DotaPacket;
public record CSubtickMoveStep(ulong button, bool pressed, float when, float analog_forward_delta, float analog_left_delta, float analog_pitch_delta, float analog_yaw_delta) : DotaPacket;
public record CBaseUserCmdPB(int legacy_command_number, int client_tick, CInButtonStatePB buttons_pb, CMsgQAngle viewangles, float forwardmove, float leftmove, float upmove, int impulse, int weaponselect, int random_seed, int mousedx, int mousedy, bool unused13, uint pawn_entity_handle, bool unused15, bool unused16, bool unused17, List<CSubtickMoveStep> subtick_moves, byte[] move_crc, uint consumed_server_angle_changes, int cmd_flags) : DotaPacket;
public record CUserCmdBasePB(CBaseUserCmdPB _base) : DotaPacket;
