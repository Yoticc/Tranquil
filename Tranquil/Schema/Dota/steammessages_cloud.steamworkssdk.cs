namespace Tranquil.Schema;

public record CCloud_GetUploadServerInfo_Request(uint appid) : DotaPacket;
public record CCloud_GetUploadServerInfo_Response(string server_url) : DotaPacket;
public record CCloud_GetFileDetails_Request(ulong ugcid, uint appid) : DotaPacket;
public record CCloud_UserFile(uint appid, ulong ugcid, string filename, ulong timestamp, uint file_size, string url, long SF2steamid_creator) : DotaPacket;
public record CCloud_GetFileDetails_Response(CCloud_UserFile details) : DotaPacket;
public record CCloud_EnumerateUserFiles_Request(uint appid, bool extended_details, uint count, uint start_index) : DotaPacket;
public record CCloud_EnumerateUserFiles_Response(List<CCloud_UserFile> files, uint total_files) : DotaPacket;
public record CCloud_Delete_Request(string filename, uint appid) : DotaPacket;
public record CCloud_Delete_Response : DotaPacket;
