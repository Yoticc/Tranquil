namespace Tranquil.Schema;

public record C2S_CONNECT_Message(uint host_version, uint auth_protocol, uint challenge_number, long SF2reservation_cookie, bool low_violence, byte[] encrypted_password, List<CCLCMsg_SplitPlayerConnect> splitplayers, byte[] auth_steam, string challenge_context) : DotaPacket;
public record C2S_CONNECTION_Message(string addon_name) : DotaPacket;
