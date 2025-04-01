namespace Tranquil.Schema;

public record NetMessageSplitscreenUserChanged(uint slot) : DotaPacket;
public record NetMessageConnectionClosed(uint reason, string message) : DotaPacket;
public record NetMessageConnectionCrashed(uint reason, string message) : DotaPacket;
public record NetMessagePacketStart : DotaPacket;
public record NetMessagePacketEnd : DotaPacket;
