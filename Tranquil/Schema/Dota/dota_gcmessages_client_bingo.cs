namespace Tranquil.Schema;

public enum EBingoAuditAction
{
    k_eBingoAuditAction_Invalid = 0,
    k_eBingoAuditAction_DevModifyTokens = 1,
    k_eBingoAuditAction_DevClearInventory = 2,
    k_eBingoAuditAction_DevRerollCard = 3,
    k_eBingoAuditAction_ShuffleCard = 4,
    k_eBingoAuditAction_RerollSquare = 5,
    k_eBingoAuditAction_UpgradeSquare = 6,
    k_eBingoAuditAction_ClaimRow = 7,
    k_eBingoAuditAction_EventActionTokenGrant = 8,
    k_eBingoAuditAction_SupportGrantTokens = 9,
    k_eBingoAuditAction_SupportStatThresholdFixup = 10,
}
public record CMsgBingoSquare(uint stat_id, int stat_threshold, uint upgrade_level) : DotaPacket;
public record CMsgBingoTokens(uint token_count) : DotaPacket;
public record CMsgBingoCard(List<CMsgBingoSquare> squares) : DotaPacket;
public record CMsgBingoUserData(List<CMsgBingoUserData.BingoCardsEntry> bingo_cards, List<CMsgBingoUserData.BingoTokensEntry> bingo_tokens) : DotaPacket
{
    public record BingoCardsEntry(uint key, CMsgBingoCard value);
    public record BingoTokensEntry(uint key, CMsgBingoTokens value);
}
public record CMsgClientToGCBingoGetUserData(uint league_id) : DotaPacket;
public record CMsgClientToGCBingoGetUserDataResponse(CMsgClientToGCBingoGetUserDataResponse.EResponse response, CMsgBingoUserData user_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
    }
}
public record CMsgBingoIndividualStatData(uint stat_id, int stat_value) : DotaPacket;
public record CMsgBingoStatsData(List<CMsgBingoIndividualStatData> stats_data) : DotaPacket;
public record CMsgClientToGCBingoGetStatsData(uint league_id, uint league_phase) : DotaPacket;
public record CMsgClientToGCBingoGetStatsDataResponse(CMsgClientToGCBingoGetStatsDataResponse.EResponse response, CMsgBingoStatsData stats_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
    }
}
public record CMsgGCToClientBingoUserDataUpdated(uint league_id, CMsgBingoUserData user_data) : DotaPacket;
public record CMsgClientToGCBingoClaimRow(uint league_id, uint league_phase, uint row_index) : DotaPacket;
public record CMsgClientToGCBingoClaimRowResponse(CMsgClientToGCBingoClaimRowResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidRow = 5,
        k_eExpiredCard = 6,
    }
}
public record CMsgClientToGCBingoShuffleCard(uint league_id, uint league_phase) : DotaPacket;
public record CMsgClientToGCBingoShuffleCardResponse(CMsgClientToGCBingoShuffleCardResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eExpiredCard = 6,
        k_eNotAllowed = 7,
        k_eInsufficientTokens = 8,
    }
}
public record CMsgClientToGCBingoModifySquare(uint league_id, uint league_phase, uint square_index, CMsgClientToGCBingoModifySquare.EModifyAction action) : DotaPacket
{
    public enum EModifyAction
    {
        k_eRerollStat = 0,
        k_eUpgrade = 1,
    }
}
public record CMsgClientToGCBingoModifySquareResponse(CMsgClientToGCBingoModifySquareResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eExpiredCard = 6,
        k_eNotAllowed = 7,
        k_eInsufficientTokens = 8,
        k_eCantUpgrade = 9,
        k_eCantReroll = 10,
        k_eInvalidSquare = 11,
    }
}
public record CMsgClientToGCBingoDevRerollCard(uint league_id, uint league_phase) : DotaPacket;
public record CMsgClientToGCBingoDevRerollCardResponse(CMsgClientToGCBingoDevRerollCardResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eExpiredCard = 6,
        k_eNotAllowed = 7,
    }
}
public record CMsgClientToGCBingoDevAddTokens(uint league_id, uint league_phase, int token_count) : DotaPacket;
public record CMsgClientToGCBingoDevAddTokensResponse(CMsgClientToGCBingoDevAddTokensResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eExpiredCard = 6,
        k_eNotAllowed = 7,
    }
}
public record CMsgClientToGCBingoDevClearInventory(uint league_id) : DotaPacket;
public record CMsgClientToGCBingoDevClearInventoryResponse(CMsgClientToGCBingoDevClearInventoryResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eExpiredCard = 6,
        k_eNotAllowed = 7,
    }
}
