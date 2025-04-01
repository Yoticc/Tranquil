namespace Tranquil.Schema;

public enum EGuildEventAuditAction
{
    k_EGuildEventAuditAction_Invalid = 0,
    k_EGuildEventAuditAction_DevGrant = 1,
    k_EGuildEventAuditAction_CompleteContract = 2,
    k_EGuildEventAuditAction_CompleteChallenge = 3,
    k_EGuildEventAuditAction_CompleteMatch_Winner = 4,
    k_EGuildEventAuditAction_ChallengeProgress = 5,
    k_EGuildEventAuditAction_CompleteMatch_Loser = 6,
    k_EGuildEventAuditAction_WeeklyLeaderboard = 7,
    k_EGuildEventAuditAction_ManualGrant = 8,
}
public record CMsgGuildContract(ulong contract_id, uint challenge_instance_id, uint challenge_parameter, uint challenge_timestamp, uint assigned_account_id, uint contract_flags) : DotaPacket;
public record CMsgGuildContractSlot(CMsgGuildContract contract) : DotaPacket;
public record CMsgAccountGuildEventData(uint guild_points, uint contracts_refreshed_timestamp, List<CMsgGuildContractSlot> contract_slots, uint completed_challenge_count, uint challenges_refresh_timestamp, uint guild_weekly_percentile, uint guild_weekly_last_timestamp, uint last_weekly_claim_time, uint guild_current_percentile) : DotaPacket;
public record CMsgGuildActiveContracts(uint contracts_refreshed_timestamp, List<CMsgGuildContract> contracts) : DotaPacket;
public record CMsgGuildChallenge(uint challenge_instance_id, uint challenge_parameter, uint challenge_timestamp, uint challenge_progress, uint challenge_flags) : DotaPacket;
public record CMsgGuildEventMember(uint account_id, uint guild_points_earned) : DotaPacket;
public record CMsgClientToGCRequestAccountGuildEventData(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCRequestAccountGuildEventDataResponse(CMsgClientToGCRequestAccountGuildEventDataResponse.EResponse result, EEvent event_id, CMsgAccountGuildEventData event_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
    }
}
public record CMsgGCToClientAccountGuildEventDataUpdated(uint guild_id, EEvent event_id, uint update_flags, CMsgAccountGuildEventData guild_event_data, bool contracts_updated) : DotaPacket;
public record CMsgClientToGCRequestActiveGuildContracts(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCRequestActiveGuildContractsResponse(CMsgClientToGCRequestActiveGuildContractsResponse.EResponse result, CMsgGuildActiveContracts active_contracts, CMsgGuildChallenge active_challenges) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
    }
}
public record CMsgGCToClientActiveGuildContractsUpdated(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCSelectGuildContract(uint guild_id, EEvent event_id, ulong contract_id, uint contract_slot) : DotaPacket;
public record CMsgClientToGCSelectGuildContractResponse(CMsgClientToGCSelectGuildContractResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
        k_eInvalidContractID = 9,
        k_eAlreadyAssigned = 10,
        k_eInvalidContractSlot = 11,
        k_eContractSlotLockedGuild = 12,
        k_eContractSlotCooldown = 13,
        k_eContractDuplicate = 14,
        k_eContractSlotTimeError = 15,
        k_eContractSlotLockedDotaPlus = 16,
    }
}
public record CMsgClientToGCRequestActiveGuildChallenge(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCRequestActiveGuildChallengeResponse(CMsgClientToGCRequestActiveGuildChallengeResponse.EResponse result, CMsgGuildChallenge active_challenge) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
    }
}
public record CMsgGCToClientActiveGuildChallengeUpdated(uint guild_id, EEvent event_id, CMsgGuildChallenge active_challenge) : DotaPacket;
public record CMsgClientToGCRequestGuildEventMembers(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCRequestGuildEventMembersResponse(CMsgClientToGCRequestGuildEventMembersResponse.EResponse result, List<CMsgGuildEventMember> members) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
    }
}
public record CMsgGuildLeaderboardCombinedResponse(EEvent event_id, uint region, uint last_updated, List<uint> guild_id, List<uint> rank, List<uint> current_percentile, List<uint> weekly_percentile, List<uint> points) : DotaPacket;
public record CMsgClientToGCClaimLeaderboardRewards(uint guild_id, EEvent event_id) : DotaPacket;
public record CMsgClientToGCClaimLeaderboardRewardsResponse(CMsgClientToGCClaimLeaderboardRewardsResponse.EResponse result, uint event_points) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidEvent = 5,
        k_eInvalidGuild = 6,
        k_eNotMember = 7,
        k_eInvalidGuildEvent = 8,
        k_eDoesNotQualify = 9,
        k_eAlreadyClaimed = 10,
    }
}
