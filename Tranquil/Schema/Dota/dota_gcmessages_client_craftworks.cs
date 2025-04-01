namespace Tranquil.Schema;

public record CMsgCraftworksUserData(CMsgCraftworksComponents component_inventory) : DotaPacket;
public record CMsgClientToGCCraftworksGetUserData(uint craftworks_id) : DotaPacket;
public record CMsgClientToGCCraftworksGetUserDataResponse(CMsgClientToGCCraftworksGetUserDataResponse.EResponse response, CMsgCraftworksUserData user_data) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidCraftworks = 5,
        k_eExpiredCraftworks = 6,
    }
}
public record CMsgGCToClientCraftworksUserDataUpdated(uint craftworks_id, CMsgCraftworksUserData user_data) : DotaPacket;
public record CMsgClientToGCCraftworksCraftRecipe(uint craftworks_id, ulong recipe_id) : DotaPacket;
public record CMsgClientToGCCraftworksCraftRecipeResponse(CMsgClientToGCCraftworksCraftRecipeResponse.EResponse response, CMsgDOTAClaimEventActionResponse claim_response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidCraftworks = 5,
        k_eExpiredCraftworks = 6,
        k_eNotEnoughComponents = 7,
        k_eInvalidRecipe = 8,
        k_eRecipeTierLocked = 9,
        k_eAlreadyCraftedMaxAmount = 10,
    }
}
public record CMsgClientToGCCraftworksDevModifyComponents(uint craftworks_id, CMsgCraftworksComponents components, CMsgClientToGCCraftworksDevModifyComponents.EOperation operation) : DotaPacket
{
    public enum EOperation
    {
        k_eAddComponents = 1,
        k_eSubtractComponents = 2,
    }
}
public record CMsgClientToGCCraftworksDevModifyComponentsResponse(CMsgClientToGCCraftworksDevModifyComponentsResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidCraftworks = 5,
        k_eNotAllowed = 6,
    }
}
