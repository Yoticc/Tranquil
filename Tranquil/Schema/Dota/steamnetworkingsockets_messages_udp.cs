using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum ESteamNetworkingUDPMsgID
{
    k_ESteamNetworkingUDPMsg_ChallengeRequest = 32,
    k_ESteamNetworkingUDPMsg_ChallengeReply = 33,
    k_ESteamNetworkingUDPMsg_ConnectRequest = 34,
    k_ESteamNetworkingUDPMsg_ConnectOK = 35,
    k_ESteamNetworkingUDPMsg_ConnectionClosed = 36,
    k_ESteamNetworkingUDPMsg_NoConnection = 37,
}
public record CMsgSteamSockets_UDP_ChallengeRequest(int SF1connection_id, bool unused2, long SF2my_timestamp, uint protocol_version) : DotaPacket;
public record CMsgSteamSockets_UDP_ChallengeReply(int SF1connection_id, long SF2challenge, long SF2your_timestamp, uint protocol_version) : DotaPacket;
public record CMsgSteamSockets_UDP_ConnectRequest(int SF1client_connection_id, long SF2challenge, long SF2legacy_client_steam_id, CMsgSteamDatagramCertificateSigned cert, long SF2my_timestamp, uint ping_est_ms, CMsgSteamDatagramSessionCryptInfoSigned crypt, uint legacy_protocol_version, CMsgSteamNetworkingIdentityLegacyBinary legacy_identity_binary, string identity_string) : DotaPacket;
public record CMsgSteamSockets_UDP_ConnectOK(int SF1client_connection_id, long SF2legacy_server_steam_id, long SF2your_timestamp, uint delay_time_usec, int SF1server_connection_id, bool unused6, CMsgSteamDatagramSessionCryptInfoSigned crypt, CMsgSteamDatagramCertificateSigned cert, bool unused9, CMsgSteamNetworkingIdentityLegacyBinary legacy_identity_binary, string identity_string) : DotaPacket;
public record CMsgSteamSockets_UDP_ConnectionClosed(bool unused1, string debug, uint reason_code, int SF1to_connection_id, int SF1from_connection_id) : DotaPacket;
public record CMsgSteamSockets_UDP_NoConnection(bool unused1, int SF1from_connection_id, int SF1to_connection_id) : DotaPacket;
public record CMsgSteamSockets_UDP_Stats(CMsgSteamDatagramConnectionQuality stats, bool unused2, uint flags) : DotaPacket
{
    public enum Flags
    {
        ACK_REQUEST_E2E = 2,
        ACK_REQUEST_IMMEDIATE = 4,
        NOT_PRIMARY_TRANSPORT_E2E = 16,
    }
}
