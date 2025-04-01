namespace Tranquil.Schema;

public enum EOverworldNodeState
{
    k_eOverworldNodeState_Invalid = 0,
    k_eOverworldNodeState_Locked = 1,
    k_eOverworldNodeState_Unlocked = 2,
}
public enum EOverworldPathState
{
    k_eOverworldPathState_Invalid = 0,
    k_eOverworldPathState_Incomplete = 1,
    k_eOverworldPathState_Complete = 2,
}
public enum EOverworldAuditAction
{
    k_eOverworldAuditAction_Invalid = 0,
    k_eOverworldAuditAction_DevModifyTokens = 1,
    k_eOverworldAuditAction_DevClearInventory = 2,
    k_eOverworldAuditAction_DevGrantTokens = 3,
    k_eOverworldAuditAction_CompletePath = 4,
    k_eOverworldAuditAction_ClaimEncounterReward = 5,
    k_eOverworldAuditAction_DevResetNode = 6,
    k_eOverworldAuditAction_DevResetPath = 7,
    k_eOverworldAuditAction_MatchRewardsFull = 8,
    k_eOverworldAuditAction_MatchRewardsHalf = 9,
    k_eOverworldAuditAction_EventActionTokenGrant = 10,
    k_eOverworldAuditAction_TokenTraderLost = 11,
    k_eOverworldAuditAction_TokenTraderGained = 12,
    k_eOverworldAuditAction_EncounterRewardTokenCost = 13,
    k_eOverworldAuditAction_EncounterRewardTokenReward = 14,
    k_eOverworldAuditAction_SupportGrantTokens = 16,
    k_eOverworldAuditAction_TokenGiftSent = 17,
}
public enum EOverworldMinigameAction
{
    k_eOverworldMinigameAction_Invalid = 0,
    k_eOverworldMinigameAction_DevReset = 1,
    k_eOverworldMinigameAction_DevGiveCurrency = 2,
    k_eOverworldMinigameAction_Purchase = 3,
    k_eOverworldMinigameAction_SetOption = 4,
    k_eOverworldMinigameAction_ReportCurrencyGained = 5,
    k_eOverworldMinigameAction_UnlockDifficulty = 6,
}
public record CMsgOverworldTokenCount(uint token_id, uint token_count) : DotaPacket;
public record CMsgOverworldTokenQuantity(List<CMsgOverworldTokenCount> token_counts) : DotaPacket;
public record CMsgOverworldEncounterTokenTreasureData(List<CMsgOverworldEncounterTokenTreasureData.RewardOption> reward_options) : DotaPacket
{
    public record RewardOption(uint reward_data, CMsgOverworldTokenQuantity token_cost, CMsgOverworldTokenQuantity token_reward);
}
public record CMsgOverworldEncounterTokenQuestData(List<CMsgOverworldEncounterTokenQuestData.Quest> quests) : DotaPacket
{
    public record Quest(uint reward_data, CMsgOverworldTokenQuantity token_cost, CMsgOverworldTokenQuantity token_reward);
}
public record CMsgOverworldHeroList(List<int> hero_ids) : DotaPacket;
public record CMsgOverworldEncounterChooseHeroData(CMsgOverworldHeroList hero_list, bool additive) : DotaPacket;
public record CMsgOverworldEncounterProgressData(int choice, int progress, int max_progress, bool visited) : DotaPacket;
public record CMsgOverworldEncounterData(List<CExtraMsgBlock> extra_encounter_data) : DotaPacket;
public record CMsgOverworldNode(uint node_id, EOverworldNodeState node_state, CMsgOverworldEncounterData node_encounter_data) : DotaPacket;
public record CMsgOverworldPath(uint path_id, CMsgOverworldTokenQuantity path_cost, EOverworldPathState path_state) : DotaPacket;
public record CMsgOverworldMinigameCustomData(CMsgSurvivorsUserData survivors_data) : DotaPacket;
public record CMsgOverworldMinigameUserData(uint node_id, uint currency_amount, CMsgOverworldMinigameCustomData custom_data) : DotaPacket;
public record CMsgOverworldUserData(CMsgOverworldTokenQuantity token_inventory, List<CMsgOverworldNode> overworld_nodes, List<CMsgOverworldPath> overworld_paths, uint current_node_id, List<CMsgOverworldUserData.MinigameDataEntry> minigame_data) : DotaPacket
{
    public record MinigameDataEntry(uint key, CMsgOverworldMinigameUserData value);
}
public record CMsgOverworldMatchRewards(List<CMsgOverworldMatchRewards.Player> players) : DotaPacket
{
    public record Player(uint player_slot, CMsgOverworldTokenQuantity tokens, uint overworld_id);
}
public record CMsgClientToGCOverworldGetUserData(uint overworld_id) : DotaPacket;
public record CMsgClientToGCOverworldGetUserDataResponse(CMsgClientToGCOverworldGetUserDataResponse.EResponse response, CMsgOverworldUserData user_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
    }
}
public record CMsgGCToClientOverworldUserDataUpdated(uint overworld_id, CMsgOverworldUserData user_data) : DotaPacket;
public record CMsgClientToGCOverworldCompletePath(uint overworld_id, uint path_id) : DotaPacket;
public record CMsgClientToGCOverworldCompletePathResponse(CMsgClientToGCOverworldCompletePathResponse.EResponse response, CMsgDOTAClaimEventActionResponse claim_response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
        k_eInvalidPath = 6,
        k_eNotEnoughTokens = 7,
        k_ePathIsLocked = 8,
        k_ePathAlreadyUnlocked = 9,
    }
}
public record CMsgOverworldEncounterPitFighterRewardData(uint token_id, uint choice) : DotaPacket;
public record CMsgClientToGCOverworldClaimEncounterReward(uint overworld_id, uint node_id, uint reward_data, uint periodic_resource_id, CMsgOverworldEncounterData extra_reward_data, uint leaderboard_data, uint leaderboard_index, bool should_claim_reward) : DotaPacket;
public record CMsgClientToGCOverworldClaimEncounterRewardResponse(CMsgClientToGCOverworldClaimEncounterRewardResponse.EResponse response, CMsgDOTAClaimEventActionResponse claim_response, CMsgOverworldTokenQuantity tokens_received) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
        k_eInvalidNode = 6,
        k_eNodeLocked = 7,
        k_eRewardAlreadyClaimed = 8,
        k_eNodeNotEncounter = 9,
        k_eEncounterMissingRewards = 10,
        k_eInvalidEncounterRewardStyle = 11,
        k_eInvalidEncounterData = 12,
        k_eNotEnoughTokensForReward = 13,
        k_eNotEnoughResourceForReward = 14,
        k_eInvalidRewardData = 15,
    }
}
public record CMsgClientToGCOverworldVisitEncounter(uint overworld_id, uint node_id) : DotaPacket;
public record CMsgClientToGCOverworldVisitEncounterResponse(CMsgClientToGCOverworldVisitEncounterResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
        k_eInvalidNode = 6,
        k_eNodeLocked = 7,
        k_eNodeNotEncounter = 8,
        k_eAlreadyVisited = 9,
    }
}
public record CMsgClientToGCOverworldMoveToNode(uint overworld_id, uint node_id) : DotaPacket;
public record CMsgClientToGCOverworldMoveToNodeResponse(CMsgClientToGCOverworldMoveToNodeResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
        k_eInvalidNode = 6,
        k_eNodeLocked = 7,
    }
}
public record CMsgClientToGCOverworldTradeTokens(uint overworld_id, CMsgOverworldTokenQuantity token_offer, CMsgOverworldTokenQuantity token_request, uint recipe, uint encounter_id) : DotaPacket;
public record CMsgClientToGCOverworldTradeTokensResponse(CMsgClientToGCOverworldTradeTokensResponse.EResponse response, CMsgOverworldTokenQuantity tokens_received) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eNodeLocked = 6,
        k_eInvalidOverworld = 7,
        k_eInvalidOffer = 8,
        k_eNotEnoughTokens = 9,
        k_eInvalidNode = 10,
        k_eInvalidEncounter = 11,
        k_eRewardDoesNotMatchRecipe = 12,
    }
}
public record CMsgClientToGCOverworldGiftTokens(uint overworld_id, CMsgOverworldTokenCount token_gift, uint recipient_account_id, uint periodic_resource_id) : DotaPacket;
public record CMsgClientToGCOverworldGiftTokensResponse(CMsgClientToGCOverworldGiftTokensResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eNodeLocked = 6,
        k_eInvalidOverworld = 7,
        k_eInvalidGift = 8,
        k_eNotEnoughTokens = 9,
        k_eInvalidRecipient = 10,
        k_eNotEnoughPeriodicResource = 11,
    }
}
public record CMsgClientToGCOverworldRequestTokensNeededByFriend(uint friend_account_id, uint overworld_id) : DotaPacket;
public record CMsgClientToGCOverworldRequestTokensNeededByFriendResponse(CMsgClientToGCOverworldRequestTokensNeededByFriendResponse.EResponse response, CMsgOverworldTokenQuantity token_quantity) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eNodeLocked = 6,
        k_eInvalidOverworld = 7,
        k_eInvalidFriend = 8,
        k_eTooManyRequests = 9,
    }
}
public record CMsgClientToGCOverworldDevResetAll(uint overworld_id) : DotaPacket;
public record CMsgClientToGCOverworldDevResetAllResponse(CMsgClientToGCOverworldDevResetAllResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidOverworld = 6,
    }
}
public record CMsgClientToGCOverworldDevResetNode(uint overworld_id, uint node_id) : DotaPacket;
public record CMsgClientToGCOverworldDevResetNodeResponse(CMsgClientToGCOverworldDevResetNodeResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidOverworld = 6,
        k_eInvalidNode = 7,
    }
}
public record CMsgClientToGCOverworldDevGrantTokens(uint overworld_id, CMsgOverworldTokenQuantity token_quantity) : DotaPacket;
public record CMsgClientToGCOverworldDevGrantTokensResponse(CMsgClientToGCOverworldDevGrantTokensResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidOverworld = 6,
    }
}
public record CMsgClientToGCOverworldDevClearInventory(uint overworld_id) : DotaPacket;
public record CMsgClientToGCOverworldDevClearInventoryResponse(CMsgClientToGCOverworldDevClearInventoryResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidOverworld = 6,
    }
}
public record CMsgClientToGCOverworldFeedback(uint language, uint overworld_id, string feedback) : DotaPacket;
public record CMsgClientToGCOverworldFeedbackResponse(CMsgClientToGCOverworldFeedbackResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidOverworld = 6,
    }
}
public record CMsgClientToGCOverworldGetDynamicImage(uint magic, uint image_id, uint language) : DotaPacket;
public record CMsgClientToGCOverworldGetDynamicImageResponse(uint image_id, List<CMsgClientToGCOverworldGetDynamicImageResponse.Image> images) : DotaPacket
{
    public enum EDynamicImageFormat
    {
        k_eUnknown = 0,
        k_ePNG = 1,
        k_eData = 2,
    }
    public record Image(uint width, uint height, CMsgClientToGCOverworldGetDynamicImageResponse.EDynamicImageFormat format, byte[] image_bytes);
}
public record CMsgClientToGCOverworldMinigameAction(uint overworld_id, uint node_id, EOverworldMinigameAction action, uint selection, uint option_value, uint currency_amount) : DotaPacket;
public record CMsgClientToGCOverworldMinigameActionResponse(CMsgClientToGCOverworldMinigameActionResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidOverworld = 5,
        k_eInvalidNode = 6,
        k_eNodeLocked = 7,
        k_eInvalidSelection = 8,
        k_eNotEnoughTokens = 9,
        k_eNotEnoughMinigameCurrency = 10,
        k_eNotAllowed = 11,
    }
}
