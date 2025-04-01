namespace Tranquil.Schema;

public enum ECandyShopAuditAction
{
    k_ECandyShopAuditAction_Invalid = 0,
    k_ECandyShopAuditAction_SupportModify = 1,
    k_ECandyShopAuditAction_PurchaseReward = 2,
    k_ECandyShopAuditAction_OpenBags = 3,
    k_ECandyShopAuditAction_RerollRewards = 4,
    k_ECandyShopAuditAction_DoVariableExchange = 5,
    k_ECandyShopAuditAction_DoExchange = 6,
    k_ECandyShopAuditAction_DEPRECATED_EventActionGrantInventorySizeIncrease = 7,
    k_ECandyShopAuditAction_EventActionGrantRerollChargesIncrease = 8,
    k_ECandyShopAuditAction_EventActionGrantUpgrade_InventorySize = 100,
    k_ECandyShopAuditAction_EventActionGrantUpgrade_RewardShelf = 101,
    k_ECandyShopAuditAction_EventActionGrantUpgrade_ExtraExchangeRecipe = 102,
}
public enum ECandyShopRewardType
{
    k_eCandyShopRewardType_None = 0,
    k_eCandyShopRewardType_Item = 1,
    k_eCandyShopRewardType_EventAction = 2,
    k_eCandyShopRewardType_EventPoints = 3,
}
public record CMsgCandyShopCandyCount(uint candy_type, uint candy_count) : DotaPacket;
public record CMsgCandyShopCandyQuantity(List<CMsgCandyShopCandyCount> candy_counts) : DotaPacket;
public record CMsgCandyShopExchangeRecipe(uint recipe_id, CMsgCandyShopCandyQuantity input, CMsgCandyShopCandyQuantity output) : DotaPacket;
public record CMsgCandyShopRewardData_Item(uint item_def) : DotaPacket;
public record CMsgCandyShopRewardData_EventAction(EEvent event_id, uint action_id) : DotaPacket;
public record CMsgCandyShopRewardData_EventPoints(EEvent event_id, uint points) : DotaPacket;
public record CMsgCandyShopReward(uint reward_id, uint reward_option_id, CMsgCandyShopCandyQuantity price, ECandyShopRewardType reward_type, CMsgCandyShopRewardData_Item item_data, CMsgCandyShopRewardData_EventAction event_action_data, CMsgCandyShopRewardData_EventPoints event_points_data) : DotaPacket;
public record CMsgCandyShopUserData(uint inventory_max, CMsgCandyShopCandyQuantity inventory, uint exchange_recipe_max, int SF1exchange_reset_timestamp, List<CMsgCandyShopExchangeRecipe> exchange_recipes, uint active_reward_max, List<CMsgCandyShopReward> active_rewards, uint reroll_charges_max, uint reroll_charges) : DotaPacket;
public record CMsgClientToGCCandyShopGetUserData(uint candy_shop_id) : DotaPacket;
public record CMsgClientToGCCandyShopGetUserDataResponse(CMsgClientToGCCandyShopGetUserDataResponse.EResponse response, CMsgCandyShopUserData user_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eExpiredShop = 6,
    }
}
public record CMsgGCToClientCandyShopUserDataUpdated(uint candy_shop_id, CMsgCandyShopUserData user_data) : DotaPacket;
public record CMsgClientToGCCandyShopPurchaseReward(uint candy_shop_id, ulong reward_id) : DotaPacket;
public record CMsgClientToGCCandyShopPurchaseRewardResponse(CMsgClientToGCCandyShopPurchaseRewardResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eInvalidReward = 6,
        k_eNotEnoughCandy = 7,
        k_eExpiredShop = 8,
    }
}
public record CMsgClientToGCCandyShopOpenBags(uint candy_shop_id, uint bag_count) : DotaPacket;
public record CMsgClientToGCCandyShopOpenBagsResponse(CMsgClientToGCCandyShopOpenBagsResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eInvalidItem = 6,
        k_eNotEnoughBags = 7,
        k_eNotEnoughSpace = 8,
        k_eExpiredShop = 9,
    }
}
public record CMsgClientToGCCandyShopDoExchange(uint candy_shop_id, uint recipe_id) : DotaPacket;
public record CMsgClientToGCCandyShopDoExchangeResponse(CMsgClientToGCCandyShopDoExchangeResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eNotEnoughCandy = 6,
        k_eInvalidRecipe = 7,
        k_eNotEnoughSpace = 8,
        k_eExpiredShop = 9,
    }
}
public record CMsgClientToGCCandyShopDoVariableExchange(uint candy_shop_id, CMsgCandyShopCandyQuantity input, CMsgCandyShopCandyQuantity output) : DotaPacket;
public record CMsgClientToGCCandyShopDoVariableExchangeResponse(CMsgClientToGCCandyShopDoVariableExchangeResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eNotEnoughCandy = 6,
        k_eInvalidRecipe = 7,
        k_eNotEnoughSpace = 8,
        k_eExpiredShop = 9,
    }
}
public record CMsgClientToGCCandyShopRerollRewards(uint candy_shop_id) : DotaPacket;
public record CMsgClientToGCCandyShopRerollRewardsResponse(CMsgClientToGCCandyShopRerollRewardsResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidShop = 5,
        k_eNoRerollCharges = 6,
        k_eExpiredShop = 7,
        k_eShopNotOpen = 8,
    }
}
public record CCandyShopDev : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNotAllowed = 5,
        k_eInvalidShop = 6,
        k_eNotEnoughSpace = 7,
    }
}
public record CMsgClientToGCCandyShopDevGrantCandy(uint candy_shop_id, CMsgCandyShopCandyQuantity candy_quantity) : DotaPacket;
public record CMsgClientToGCCandyShopDevGrantCandyResponse(CCandyShopDev.EResponse response) : DotaPacket;
public record CMsgClientToGCCandyShopDevClearInventory(uint candy_shop_id) : DotaPacket;
public record CMsgClientToGCCandyShopDevClearInventoryResponse(CCandyShopDev.EResponse response) : DotaPacket;
public record CMsgClientToGCCandyShopDevGrantCandyBags(uint candy_shop_id, uint quantity) : DotaPacket;
public record CMsgClientToGCCandyShopDevGrantCandyBagsResponse(CCandyShopDev.EResponse response) : DotaPacket;
public record CMsgClientToGCCandyShopDevShuffleExchange(uint candy_shop_id) : DotaPacket;
public record CMsgClientToGCCandyShopDevShuffleExchangeResponse(CCandyShopDev.EResponse response) : DotaPacket;
public record CMsgClientToGCCandyShopDevGrantRerollCharges(uint candy_shop_id, uint reroll_charges) : DotaPacket;
public record CMsgClientToGCCandyShopDevGrantRerollChargesResponse(CCandyShopDev.EResponse response) : DotaPacket;
public record CMsgClientToGCCandyShopDevResetShop(uint candy_shop_id) : DotaPacket;
public record CMsgClientToGCCandyShopDevResetShopResponse(CCandyShopDev.EResponse response) : DotaPacket;
