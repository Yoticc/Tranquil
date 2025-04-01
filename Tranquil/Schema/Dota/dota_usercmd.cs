namespace Tranquil.Schema;

public record CDota2UserCmdPB(CBaseUserCmdPB _base, int spectator_query_unit_entindex, CMsgVector crosshairtrace, int cameraposition_x, int cameraposition_y, uint clickbehavior, uint statspanel, uint shoppanel, uint stats_dropdown, uint stats_dropdown_sort) : DotaPacket;
