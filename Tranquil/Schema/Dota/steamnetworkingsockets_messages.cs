namespace Tranquil.Schema;

public enum ESteamNetworkingSocketsCipher
{
    k_ESteamNetworkingSocketsCipher_INVALID = 0,
    k_ESteamNetworkingSocketsCipher_NULL = 1,
    k_ESteamNetworkingSocketsCipher_AES_256_GCM = 2,
}
public record CMsgSteamDatagramSessionCryptInfo(CMsgSteamDatagramSessionCryptInfo.EKeyType key_type, byte[] key_data, long SF2nonce, uint protocol_version, List<ESteamNetworkingSocketsCipher> ciphers) : DotaPacket
{
    public enum EKeyType
    {
        INVALID = 0,
        CURVE25519 = 1,
    }
}
public record CMsgSteamDatagramSessionCryptInfoSigned(byte[] info, byte[] signature) : DotaPacket;
public record CMsgSteamDatagramDiagnostic(uint severity, string text) : DotaPacket;
public record CMsgSteamDatagramLinkInstantaneousStats(uint out_packets_per_sec_x10, uint out_bytes_per_sec, uint in_packets_per_sec_x10, uint in_bytes_per_sec, uint ping_ms, uint packets_dropped_pct, uint packets_weird_sequence_pct, uint peak_jitter_usec) : DotaPacket;
public record CMsgSteamDatagramLinkLifetimeStats(bool unused1, uint connected_seconds, ulong packets_sent, ulong kb_sent, ulong packets_recv, ulong kb_recv, ulong packets_recv_sequenced, ulong packets_recv_dropped, ulong packets_recv_out_of_order, ulong packets_recv_duplicate, ulong packets_recv_lurch, List<ulong> multipath_packets_recv_sequenced, List<ulong> multipath_packets_recv_later, uint multipath_send_enabled, ulong packets_recv_out_of_order_corrected, bool unused16, bool unused17, bool unused18, bool unused19, bool unused20, uint quality_histogram_100, uint quality_histogram_99, uint quality_histogram_97, uint quality_histogram_95, uint quality_histogram_90, uint quality_histogram_75, uint quality_histogram_50, uint quality_histogram_1, uint quality_histogram_dead, uint quality_ntile_2nd, uint quality_ntile_5th, uint quality_ntile_25th, uint quality_ntile_50th, bool unused34, bool unused35, bool unused36, bool unused37, bool unused38, bool unused39, bool unused40, uint ping_histogram_25, uint ping_histogram_50, uint ping_histogram_75, uint ping_histogram_100, uint ping_histogram_125, uint ping_histogram_150, uint ping_histogram_200, uint ping_histogram_300, uint ping_histogram_max, uint ping_ntile_5th, uint ping_ntile_50th, uint ping_ntile_75th, uint ping_ntile_95th, uint ping_ntile_98th, bool unused55, bool unused56, bool unused57, bool unused58, bool unused59, bool unused60, uint jitter_histogram_negligible, uint jitter_histogram_1, uint jitter_histogram_2, uint jitter_histogram_5, uint jitter_histogram_10, uint jitter_histogram_20) : DotaPacket;
public record CMsgSteamDatagramConnectionQuality(CMsgSteamDatagramLinkInstantaneousStats instantaneous, CMsgSteamDatagramLinkLifetimeStats lifetime) : DotaPacket;
public record CMsgICECandidate(bool unused1, bool unused2, string candidate) : DotaPacket;
public record CMsgICERendezvous(CMsgICECandidate add_candidate, CMsgICERendezvous.Auth auth) : DotaPacket
{
    public record Auth(string pwd_frag);
}
public record CMsgSteamNetworkingP2PRendezvous(int SF1to_connection_id, byte[] sdr_routes, uint ack_peer_routes_revision, CMsgSteamNetworkingP2PRendezvous.ConnectRequest connect_request, CMsgSteamNetworkingP2PRendezvous.ConnectOK connect_ok, CMsgSteamNetworkingP2PRendezvous.ConnectionClosed connection_closed, bool ice_enabled, string from_identity, int SF1from_connection_id, string to_identity, uint ack_reliable_msg, uint first_reliable_msg, List<CMsgSteamNetworkingP2PRendezvous.ReliableMessage> reliable_messages, byte[] hosted_server_ticket, List<CMsgSteamNetworkingP2PRendezvous.ApplicationMessage> application_messages) : DotaPacket
{
    public record ConnectRequest(bool unused1, bool unused2, bool unused3, bool unused4, bool unused5, CMsgSteamDatagramSessionCryptInfoSigned crypt, CMsgSteamDatagramCertificateSigned cert, bool unused8, uint to_virtual_port, uint from_virtual_port, string from_fakeip);
    public record ConnectOK(bool unused1, bool unused2, bool unused3, bool unused4, CMsgSteamDatagramSessionCryptInfoSigned crypt, CMsgSteamDatagramCertificateSigned cert);
    public record ConnectionClosed(bool unused1, bool unused2, bool unused3, bool unused4, string debug, uint reason_code);
    public record ReliableMessage(CMsgICERendezvous ice);
    public record ApplicationMessage(byte[] data, ulong msg_num, uint flags, uint lane_idx);
}
public record CMsgSteamNetworkingICESessionSummary(uint local_candidate_types, uint remote_candidate_types, uint initial_route_kind, uint initial_ping, uint negotiation_ms, uint initial_score, uint failure_reason_code, bool unused8, bool unused9, bool unused10, bool unused11, uint selected_seconds, uint user_settings, uint ice_enable_var, uint local_candidate_types_allowed, uint best_route_kind, uint best_ping, uint best_score, uint best_time) : DotaPacket;
