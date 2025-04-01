using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgSteamNetworkingIdentityLegacyBinary(bool unused1, byte[] generic_bytes, string generic_string, byte[] ipv6_and_port, long SF2steam_id) : DotaPacket;
public record CMsgSteamDatagramCertificate(CMsgSteamDatagramCertificate.EKeyType key_type, byte[] key_data, bool unused3, long SF2legacy_steam_id, List<int> SF1gameserver_datacenter_ids, bool unused6, bool unused7, int SF1time_created, int SF1time_expiry, List<uint> app_ids, CMsgSteamNetworkingIdentityLegacyBinary legacy_identity_binary, string identity_string, List<string> ip_addresses) : DotaPacket
{
    public enum EKeyType
    {
        INVALID = 0,
        ED25519 = 1,
    }
}
public record CMsgSteamDatagramCertificateSigned(byte[] private_key_data, byte[] cert, long SF2ca_key_id, byte[] ca_signature) : DotaPacket;
public record CMsgSteamDatagramCertificateRequest(CMsgSteamDatagramCertificate cert) : DotaPacket;
