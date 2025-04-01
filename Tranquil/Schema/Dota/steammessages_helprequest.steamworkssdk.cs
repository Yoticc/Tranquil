namespace Tranquil.Schema;

public record CHelpRequestLogs_UploadUserApplicationLog_Request(uint appid, string log_type, string version_string, string log_contents) : DotaPacket;
public record CHelpRequestLogs_UploadUserApplicationLog_Response(ulong id) : DotaPacket;
