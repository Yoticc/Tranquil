namespace Tranquil.Schema;

public enum EGCItemMsg
{
    k_EMsgGCBase = 1000,
    k_EMsgGCSetItemPosition = 1001,
    k_EMsgClientToGCPackBundle = 1002,
    k_EMsgClientToGCPackBundleResponse = 1003,
    k_EMsgGCDelete = 1004,
    k_EMsgGCVerifyCacheSubscription = 1005,
    k_EMsgClientToGCNameItem = 1006,
    k_EMsgGCPaintItem = 1009,
    k_EMsgGCPaintItemResponse = 1010,
    k_EMsgGCNameBaseItem = 1019,
    k_EMsgGCNameBaseItemResponse = 1020,
    k_EMsgGCUseItemRequest = 1025,
    k_EMsgGCUseItemResponse = 1026,
    k_EMsgGCGiftedItems = 1027,
    k_EMsgGCUnwrapGiftRequest = 1037,
    k_EMsgGCUnwrapGiftResponse = 1038,
    k_EMsgGCSortItems = 1041,
    k_EMsgGCBackpackSortFinished = 1058,
    k_EMsgGCAdjustItemEquippedState = 1059,
    k_EMsgGCItemAcknowledged = 1062,
    k_EMsgClientToGCNameItemResponse = 1068,
    k_EMsgGCApplyStrangePart = 1073,
    k_EMsgGCApplyPennantUpgrade = 1076,
    k_EMsgGCSetItemPositions = 1077,
    k_EMsgGCApplyEggEssence = 1078,
    k_EMsgGCNameEggEssenceResponse = 1079,
    k_EMsgGCExtractGems = 1086,
    k_EMsgGCAddSocket = 1087,
    k_EMsgGCAddItemToSocket = 1088,
    k_EMsgGCAddItemToSocketResponse = 1089,
    k_EMsgGCAddSocketResponse = 1090,
    k_EMsgGCResetStrangeGemCount = 1091,
    k_EMsgGCRequestCrateItems = 1092,
    k_EMsgGCRequestCrateItemsResponse = 1093,
    k_EMsgGCExtractGemsResponse = 1094,
    k_EMsgGCResetStrangeGemCountResponse = 1095,
    k_EMsgGCServerUseItemRequest = 1103,
    k_EMsgGCAddGiftItem = 1104,
    k_EMsgSQLGCToGCRevokeUntrustedGift = 1105,
    k_EMsgClientToGCRemoveItemGifterAttributes = 1109,
    k_EMsgClientToGCRemoveItemName = 1110,
    k_EMsgClientToGCRemoveItemDescription = 1111,
    k_EMsgClientToGCRemoveItemAttributeResponse = 1112,
    k_EMsgGCDev_NewItemRequest = 2001,
    k_EMsgGCDev_NewItemRequestResponse = 2002,
    k_EMsgGCDev_UnlockAllItemStylesRequest = 2003,
    k_EMsgGCDev_UnlockAllItemStylesResponse = 2004,
    k_EMsgGCStorePurchaseFinalize = 2504,
    k_EMsgGCStorePurchaseFinalizeResponse = 2505,
    k_EMsgGCStorePurchaseCancel = 2506,
    k_EMsgGCStorePurchaseCancelResponse = 2507,
    k_EMsgGCStorePurchaseInit = 2510,
    k_EMsgGCStorePurchaseInitResponse = 2511,
    k_EMsgGCToGCBannedWordListUpdated = 2515,
    k_EMsgGCToGCDirtySDOCache = 2516,
    k_EMsgGCToGCUpdateSQLKeyValue = 2518,
    k_EMsgGCToGCBroadcastConsoleCommand = 2521,
    k_EMsgGCServerVersionUpdated = 2522,
    k_EMsgGCApplyAutograph = 2523,
    k_EMsgGCToGCWebAPIAccountChanged = 2524,
    k_EMsgGCClientVersionUpdated = 2528,
    k_EMsgGCToGCUpdateWelcomeMsg = 2529,
    k_EMsgGCToGCPlayerStrangeCountAdjustments = 2535,
    k_EMsgGCRequestStoreSalesData = 2536,
    k_EMsgGCRequestStoreSalesDataResponse = 2537,
    k_EMsgGCRequestStoreSalesDataUpToDateResponse = 2538,
    k_EMsgGCToGCPingRequest = 2539,
    k_EMsgGCToGCPingResponse = 2540,
    k_EMsgGCToGCGetUserSessionServer = 2541,
    k_EMsgGCToGCGetUserSessionServerResponse = 2542,
    k_EMsgGCToGCGetUserServerMembers = 2543,
    k_EMsgGCToGCGetUserServerMembersResponse = 2544,
    k_EMsgGCToGCCanUseDropRateBonus = 2547,
    k_EMsgSQLAddDropRateBonus = 2548,
    k_EMsgGCToGCRefreshSOCache = 2549,
    k_EMsgGCToGCGrantAccountRolledItems = 2554,
    k_EMsgGCToGCGrantSelfMadeItemToAccount = 2555,
    k_EMsgGCStatueCraft = 2561,
    k_EMsgGCRedeemCode = 2562,
    k_EMsgGCRedeemCodeResponse = 2563,
    k_EMsgGCToGCItemConsumptionRollback = 2564,
    k_EMsgClientToGCWrapAndDeliverGift = 2565,
    k_EMsgClientToGCWrapAndDeliverGiftResponse = 2566,
    k_EMsgClientToGCUnpackBundleResponse = 2567,
    k_EMsgGCToClientStoreTransactionCompleted = 2568,
    k_EMsgClientToGCEquipItems = 2569,
    k_EMsgClientToGCEquipItemsResponse = 2570,
    k_EMsgClientToGCUnlockItemStyle = 2571,
    k_EMsgClientToGCUnlockItemStyleResponse = 2572,
    k_EMsgClientToGCSetItemInventoryCategory = 2573,
    k_EMsgClientToGCUnlockCrate = 2574,
    k_EMsgClientToGCUnlockCrateResponse = 2575,
    k_EMsgClientToGCUnpackBundle = 2576,
    k_EMsgClientToGCSetItemStyle = 2577,
    k_EMsgClientToGCSetItemStyleResponse = 2578,
    k_EMsgSQLGCToGCGrantBackpackSlots = 2580,
    k_EMsgClientToGCLookupAccountName = 2581,
    k_EMsgClientToGCLookupAccountNameResponse = 2582,
    k_EMsgClientToGCCreateStaticRecipe = 2584,
    k_EMsgClientToGCCreateStaticRecipeResponse = 2585,
    k_EMsgGCToGCStoreProcessCDKeyTransaction = 2586,
    k_EMsgGCToGCStoreProcessCDKeyTransactionResponse = 2587,
    k_EMsgGCToGCStoreProcessSettlement = 2588,
    k_EMsgGCToGCStoreProcessSettlementResponse = 2589,
    k_EMsgGCToGCConsoleOutput = 2590,
    k_EMsgGCToClientItemAges = 2591,
    k_EMsgGCToGCInternalTestMsg = 2592,
    k_EMsgGCToGCClientServerVersionsUpdated = 2593,
    k_EMsgGCUseMultipleItemsRequest = 2594,
    k_EMsgGCGetAccountSubscriptionItem = 2595,
    k_EMsgGCGetAccountSubscriptionItemResponse = 2596,
    k_EMsgGCToGCBroadcastMessageFromSub = 2598,
    k_EMsgGCToClientCurrencyPricePoints = 2599,
    k_EMsgGCToGCAddSubscriptionTime = 2600,
    k_EMsgGCToGCFlushSteamInventoryCache = 2601,
    k_EMsgGCRequestCrateEscalationLevel = 2602,
    k_EMsgGCRequestCrateEscalationLevelResponse = 2603,
    k_EMsgGCToGCUpdateSubscriptionItems = 2604,
    k_EMsgGCToGCSelfPing = 2605,
    k_EMsgGCToGCGetInfuxIntervalStats = 2606,
    k_EMsgGCToGCGetInfuxIntervalStatsResponse = 2607,
    k_EMsgGCToGCPurchaseSucceeded = 2608,
    k_EMsgClientToGCGetLimitedItemPurchaseQuantity = 2609,
    k_EMsgClientToGCGetLimitedItemPurchaseQuantityResponse = 2610,
    k_EMsgGCToGCBetaDeleteItems = 2611,
    k_EMsgClientToGCGetInFlightItemCharges = 2612,
    k_EMsgClientToGCGetInFlightItemChargesResponse = 2613,
    k_EMsgGCToClientInFlightChargesUpdated = 2614,
    k_EMsgClientToGCPurchaseChargeCostItems = 2615,
    k_EMsgClientToGCPurchaseChargeCostItemsResponse = 2616,
    k_EMsgClientToGCCancelUnfinalizedTransactions = 2617,
    k_EMsgClientToGCCancelUnfinalizedTransactionsResponse = 2618,
}
public enum EGCMsgInitiateTradeResponse
{
    k_EGCMsgInitiateTradeResponse_Accepted = 0,
    k_EGCMsgInitiateTradeResponse_Declined = 1,
    k_EGCMsgInitiateTradeResponse_VAC_Banned_Initiator = 2,
    k_EGCMsgInitiateTradeResponse_VAC_Banned_Target = 3,
    k_EGCMsgInitiateTradeResponse_Target_Already_Trading = 4,
    k_EGCMsgInitiateTradeResponse_Disabled = 5,
    k_EGCMsgInitiateTradeResponse_NotLoggedIn = 6,
    k_EGCMsgInitiateTradeResponse_Cancel = 7,
    k_EGCMsgInitiateTradeResponse_TooSoon = 8,
    k_EGCMsgInitiateTradeResponse_TooSoonPenalty = 9,
    k_EGCMsgInitiateTradeResponse_Trade_Banned_Initiator = 10,
    k_EGCMsgInitiateTradeResponse_Trade_Banned_Target = 11,
    k_EGCMsgInitiateTradeResponse_Free_Account_Initiator_DEPRECATED = 12,
    k_EGCMsgInitiateTradeResponse_Shared_Account_Initiator = 13,
    k_EGCMsgInitiateTradeResponse_Service_Unavailable = 14,
    k_EGCMsgInitiateTradeResponse_Target_Blocked = 15,
    k_EGCMsgInitiateTradeResponse_NeedVerifiedEmail = 16,
    k_EGCMsgInitiateTradeResponse_NeedSteamGuard = 17,
    k_EGCMsgInitiateTradeResponse_SteamGuardDuration = 18,
    k_EGCMsgInitiateTradeResponse_TheyCannotTrade = 19,
    k_EGCMsgInitiateTradeResponse_Recent_Password_Reset = 20,
    k_EGCMsgInitiateTradeResponse_Using_New_Device = 21,
    k_EGCMsgInitiateTradeResponse_Sent_Invalid_Cookie = 22,
    k_EGCMsgInitiateTradeResponse_TooRecentFriend = 23,
    k_EGCMsgInitiateTradeResponse_WalledFundsNotTrusted = 24,
}
public record CMsgApplyAutograph(ulong autograph_item_id, ulong item_item_id) : DotaPacket;
public record CMsgAdjustItemEquippedState(ulong item_id, uint new_class, uint new_slot, uint style_index) : DotaPacket;
public record CMsgEconPlayerStrangeCountAdjustment(uint account_id, List<CMsgEconPlayerStrangeCountAdjustment.CStrangeCountAdjustment> strange_count_adjustments, bool turbo_mode) : DotaPacket
{
    public record CStrangeCountAdjustment(uint event_type, ulong item_id, uint adjustment);
}
public record CMsgCraftingResponse(List<ulong> item_ids) : DotaPacket;
public record CMsgGCRequestStoreSalesData(uint version, uint currency) : DotaPacket;
public record CMsgGCRequestStoreSalesDataResponse(List<CMsgGCRequestStoreSalesDataResponse.Price> sale_price, uint version, uint expiration_time) : DotaPacket
{
    public record Price(uint item_def, uint price);
}
public record CMsgGCRequestStoreSalesDataUpToDateResponse(uint version, uint expiration_time) : DotaPacket;
public record CMsgGCToGCPingRequest : DotaPacket;
public record CMsgGCToGCPingResponse : DotaPacket;
public record CMsgGCToGCGetUserSessionServer(uint account_id) : DotaPacket;
public record CMsgGCToGCGetUserSessionServerResponse(long SF2server_steam_id, bool is_online) : DotaPacket;
public record CMsgGCToGCGetUserServerMembers(uint account_id, uint max_spectators) : DotaPacket;
public record CMsgGCToGCGetUserServerMembersResponse(List<uint> member_account_id) : DotaPacket;
public record CMsgLookupMultipleAccountNames(List<uint> accountids) : DotaPacket;
public record CMsgLookupMultipleAccountNamesResponse(List<CMsgLookupMultipleAccountNamesResponse.Account> accounts) : DotaPacket
{
    public record Account(uint accountid, string persona);
}
public record CMsgRequestCrateItems(uint crate_item_def) : DotaPacket;
public record CMsgRequestCrateItemsResponse(uint response, List<uint> item_defs, List<uint> peek_item_defs, List<CSOEconItem> peek_items) : DotaPacket
{
    public enum EResult
    {
        k_Succeeded = 0,
        k_Failed = 1,
    }
}
public record CMsgRequestCrateEscalationLevel(uint crate_item_def) : DotaPacket;
public record CMsgRequestCrateEscalationLevelResponse(uint response, uint escalation_level0, uint escalation_level1, uint escalation_level2, uint escalation_level3) : DotaPacket
{
    public enum EResult
    {
        k_Succeeded = 0,
        k_Failed = 1,
    }
}
public record CMsgGCToGCCanUseDropRateBonus(uint account_id, float drop_rate_bonus, uint booster_type, uint exclusive_item_def, bool allow_equal_rate) : DotaPacket;
public record CMsgSQLAddDropRateBonus(uint account_id, ulong item_id, uint item_def, float drop_rate_bonus, uint booster_type, uint seconds_duration, uint end_time_stamp) : DotaPacket;
public record CMsgSQLUpgradeBattleBooster(uint account_id, uint item_def, float bonus_to_add, uint booster_type) : DotaPacket;
public record CMsgGCToGCRefreshSOCache(uint account_id, bool reload) : DotaPacket;
public record CMsgGCToGCAddSubscriptionTime(uint account_id, List<uint> matching_subscription_def_indexes, uint additional_seconds) : DotaPacket;
public record CMsgGCToGCGrantAccountRolledItems(uint account_id, List<CMsgGCToGCGrantAccountRolledItems.Item> items, uint audit_action, ulong audit_data) : DotaPacket
{
    public record Item(uint item_def, List<string> loot_lists, bool ignore_limit, uint origin, List<CMsgGCToGCGrantAccountRolledItems.Item.DynamicAttribute> dynamic_attributes, List<CMsgGCToGCGrantAccountRolledItems.Item.AdditionalAuditEntry> additional_audit_entries, uint inventory_token, int quality)
    {
        public record DynamicAttribute(string name, uint value_uint32, float value_float, string value_string);
        public record AdditionalAuditEntry(uint owner_account_id, uint audit_action, ulong audit_data);
    }
}
public record CMsgGCToGCBetaDeleteItems(uint account_id, List<ulong> item_ids, List<uint> item_defs) : DotaPacket;
public record CMsgGCToGCGrantSelfMadeItemToAccount(uint item_def_index, uint accountid) : DotaPacket;
public record CMsgUseItem(ulong item_id, long SF2target_steam_id, List<uint> gift__potential_targets, uint duel__class_lock, ulong initiator_steam_id, bool itempack__ack_immediately) : DotaPacket;
public record CMsgServerUseItem(uint initiator_account_id, CMsgUseItem use_item_msg) : DotaPacket;
public record CMsgUseMultipleItems(List<ulong> item_ids) : DotaPacket;
public record CGCStoreRechargeRedirect_LineItem(uint item_def_id, uint quantity) : DotaPacket;
public record CMsgGCEconSQLWorkItemEmbeddedRollbackData(uint account_id, ulong deleted_item_id, uint old_audit_action, uint new_audit_action, uint expected_audit_action) : DotaPacket;
public record CMsgCraftStatue(uint heroid, string sequencename, float cycle, string description, uint pedestal_itemdef, ulong toolid) : DotaPacket;
public record CMsgRedeemCode(string code) : DotaPacket;
public record CMsgRedeemCodeResponse(uint response, ulong item_id) : DotaPacket
{
    public enum EResultCode
    {
        k_Succeeded = 0,
        k_Failed_CodeNotFound = 1,
        k_Failed_CodeAlreadyUsed = 2,
        k_Failed_OtherError = 3,
    }
}
public record CMsgDevNewItemRequest(bool unused1, bool unused2, string item_def_name, string loot_list_name, List<string> attr_def_name, List<string> attr_value, uint item_quality) : DotaPacket;
public record CMsgDevNewItemRequestResponse(bool success) : DotaPacket;
public record CMsgDevUnlockAllItemStyles(ulong item_id) : DotaPacket;
public record CMsgDevUnlockAllItemStylesResponse(bool success) : DotaPacket;
public record CMsgGCGetAccountSubscriptionItem(uint account_id) : DotaPacket;
public record CMsgGCGetAccountSubscriptionItemResponse(uint def_index) : DotaPacket;
public record CMsgGCAddGiftItem(uint gifter_account_id, uint receiver_account_id, CSOEconItem wrapped_item, string gift_message, bool is_wallet_cash_trusted) : DotaPacket;
public record CMsgClientToGCWrapAndDeliverGift(ulong item_id, uint give_to_account_id, string gift_message) : DotaPacket;
public record CMsgSQLGCToGCRevokeUntrustedGift(uint account_id, bool unused2, bool unused3, ulong sent_item_id) : DotaPacket;
public record CMsgClientToGCWrapAndDeliverGiftResponse(EGCMsgResponse response, uint gifting_charge_uses, int gifting_charge_max, uint gifting_uses, int gifting_max, uint gifting_window_hours, EGCMsgInitiateTradeResponse trade_restriction) : DotaPacket;
public record CMsgClientToGCUnwrapGift(ulong item_id) : DotaPacket;
public record CMsgClientToGCGetGiftPermissions : DotaPacket;
public record CMsgClientToGCGetGiftPermissionsResponse(bool is_unlimited, bool unused2, bool has_two_factor, bool unused4, bool unused5, EGCMsgInitiateTradeResponse sender_permission, uint friendship_age_requirement, uint friendship_age_requirement_two_factor, List<CMsgClientToGCGetGiftPermissionsResponse.FriendPermission> friend_permissions) : DotaPacket
{
    public record FriendPermission(uint account_id, EGCMsgInitiateTradeResponse permission);
}
public record CMsgClientToGCUnpackBundle(ulong item_id) : DotaPacket;
public record CMsgClientToGCUnpackBundleResponse(List<ulong> unpacked_item_ids, CMsgClientToGCUnpackBundleResponse.EUnpackBundle response, List<uint> unpacked_item_def_indexes) : DotaPacket
{
    public enum EUnpackBundle
    {
        k_UnpackBundle_Succeeded = 0,
        k_UnpackBundle_Failed_ItemIsNotBundle = 1,
        k_UnpackBundle_Failed_UnableToCreateContainedItem = 2,
        k_UnpackBundle_Failed_SOCacheError = 3,
        k_UnpackBundle_Failed_ItemIsInvalid = 4,
        k_UnpackBundle_Failed_BadItemQuantity = 5,
        k_UnpackBundle_Failed_UnableToDeleteItem = 6,
    }
}
public record CMsgClientToGCPackBundle(List<ulong> item_ids, uint bundle_item_def_index) : DotaPacket;
public record CMsgClientToGCPackBundleResponse(ulong item_id, CMsgClientToGCPackBundleResponse.EPackBundle response) : DotaPacket
{
    public enum EPackBundle
    {
        k_PackBundle_Succeeded = 0,
        k_PackBundle_Failed_InternalError = 1,
        k_PackBundle_Failed_ItemIsNotBundle = 2,
        k_PackBundle_Failed_SOCacheError = 3,
        k_PackBundle_Failed_ItemIsInvalid = 4,
        k_PackBundle_Failed_BadItemQuantity = 5,
        k_PackBundle_Failed_UnableToDeleteItem = 6,
        k_PackBundle_Failed_BundleCannotBePacked = 7,
        k_PackBundle_Failed_ItemIsUntradeable = 8,
        k_PackBundle_Failed_ItemIsEquipped = 9,
        k_PackBundle_Failed_ItemHasGems = 10,
        k_PackBundle_Failed_ItemMixedQuality = 11,
        k_PackBundle_Failed_ItemInvalidQuality = 12,
        k_PackBundle_Failed_ItemIsNonEconomy = 13,
        k_PackBundle_Failed_Disabled = 14,
    }
}
public record CMsgGCToClientStoreTransactionCompleted(ulong txn_id, List<ulong> item_ids) : DotaPacket;
public record CMsgClientToGCEquipItems(List<CMsgAdjustItemEquippedState> equips) : DotaPacket;
public record CMsgClientToGCEquipItemsResponse(long SF2so_cache_version_id) : DotaPacket;
public record CMsgClientToGCSetItemStyle(ulong item_id, uint style_index) : DotaPacket;
public record CMsgClientToGCSetItemStyleResponse(CMsgClientToGCSetItemStyleResponse.ESetStyle response) : DotaPacket
{
    public enum ESetStyle
    {
        k_SetStyle_Succeeded = 0,
        k_SetStyle_Failed = 1,
        k_SetStyle_Failed_StyleIsLocked = 2,
    }
}
public record CMsgClientToGCUnlockItemStyle(ulong item_to_unlock, uint style_index, List<ulong> consumable_item_ids) : DotaPacket;
public record CMsgClientToGCUnlockItemStyleResponse(CMsgClientToGCUnlockItemStyleResponse.EUnlockStyle response, ulong item_id, uint style_index, uint style_prereq) : DotaPacket
{
    public enum EUnlockStyle
    {
        k_UnlockStyle_Succeeded = 0,
        k_UnlockStyle_Failed_PreReq = 1,
        k_UnlockStyle_Failed_CantAfford = 2,
        k_UnlockStyle_Failed_CantCommit = 3,
        k_UnlockStyle_Failed_CantLockCache = 4,
        k_UnlockStyle_Failed_CantAffordAttrib = 5,
        k_UnlockStyle_Failed_CantAffordGem = 6,
        k_UnlockStyle_Failed_NoCompendiumLevel = 7,
        k_UnlockStyle_Failed_AlreadyUnlocked = 8,
        k_UnlockStyle_Failed_OtherError = 9,
        k_UnlockStyle_Failed_ItemIsInvalid = 10,
        k_UnlockStyle_Failed_ToolIsInvalid = 11,
    }
}
public record CMsgClientToGCSetItemInventoryCategory(List<ulong> item_ids, uint set_to_value, uint remove_categories, uint add_categories) : DotaPacket;
public record CMsgClientToGCUnlockCrate(ulong crate_item_id, ulong key_item_id) : DotaPacket;
public record CMsgClientToGCUnlockCrateResponse(EGCMsgResponse result, List<CMsgClientToGCUnlockCrateResponse.Item> granted_items) : DotaPacket
{
    public record Item(ulong item_id, uint def_index);
}
public record CMsgClientToGCRemoveItemAttribute(ulong item_id) : DotaPacket;
public record CMsgClientToGCRemoveItemAttributeResponse(CMsgClientToGCRemoveItemAttributeResponse.ERemoveItemAttribute response, ulong item_id) : DotaPacket
{
    public enum ERemoveItemAttribute
    {
        k_RemoveItemAttribute_Succeeded = 0,
        k_RemoveItemAttribute_Failed = 1,
        k_RemoveItemAttribute_Failed_ItemIsInvalid = 2,
        k_RemoveItemAttribute_Failed_AttributeCannotBeRemoved = 3,
        k_RemoveItemAttribute_Failed_AttributeDoesntExist = 4,
    }
}
public record CMsgClientToGCNameItem(ulong subject_item_id, ulong tool_item_id, string name) : DotaPacket;
public record CMsgClientToGCNameItemResponse(CMsgClientToGCNameItemResponse.ENameItem response, ulong item_id) : DotaPacket
{
    public enum ENameItem
    {
        k_NameItem_Succeeded = 0,
        k_NameItem_Failed = 1,
        k_NameItem_Failed_ToolIsInvalid = 2,
        k_NameItem_Failed_ItemIsInvalid = 3,
        k_NameItem_Failed_NameIsInvalid = 4,
    }
}
public record CMsgGCSetItemPosition(ulong item_id, uint new_position) : DotaPacket;
public record CAttribute_ItemDynamicRecipeComponent(uint item_def, uint item_quality, uint item_flags, string attributes_string, uint item_count, uint items_fulfilled, uint item_rarity, string lootlist, ulong fulfilled_item_id, uint associated_item_def) : DotaPacket;
public record CProtoItemSocket(ulong item_id, uint attr_def_index, uint required_type, string required_hero, uint gem_def_index, bool not_tradable, string required_item_slot) : DotaPacket;
public record CProtoItemSocket_Empty(CProtoItemSocket socket) : DotaPacket;
public record CProtoItemSocket_Effect(CProtoItemSocket socket, uint effect) : DotaPacket;
public record CProtoItemSocket_Color(CProtoItemSocket socket, uint red, uint green, uint blue) : DotaPacket;
public record CProtoItemSocket_Strange(CProtoItemSocket socket, uint strange_type, uint strange_value) : DotaPacket;
public record CProtoItemSocket_Strange_DESERIALIZE_FROM_STRING_ONLY(CProtoItemSocket socket, uint strange_type, uint strange_value, uint ability_effect) : DotaPacket;
public record CProtoItemSocket_Spectator(CProtoItemSocket socket, uint games_viewed, uint corporation_id, uint league_id, uint team_id) : DotaPacket;
public record CProtoItemSocket_AssetModifier(CProtoItemSocket socket, uint asset_modifier) : DotaPacket;
public record CProtoItemSocket_AssetModifier_DESERIALIZE_FROM_STRING_ONLY(CProtoItemSocket socket, uint asset_modifier, uint anim_modifier, uint ability_effect) : DotaPacket;
public record CProtoItemSocket_Autograph(CProtoItemSocket socket, string autograph, uint autograph_id, uint autograph_score) : DotaPacket;
public record CProtoItemSocket_StaticVisuals(CProtoItemSocket socket) : DotaPacket;
public record CAttribute_String(string value) : DotaPacket;
public record CWorkshop_GetItemDailyRevenue_Request(uint appid, uint item_id, uint date_start, uint date_end) : DotaPacket;
public record CWorkshop_GetItemDailyRevenue_Response(List<CWorkshop_GetItemDailyRevenue_Response.CountryDailyRevenue> country_revenue) : DotaPacket
{
    public record CountryDailyRevenue(string country_code, uint date, long revenue_usd, int units);
}
public record CWorkshop_GetPackageDailyRevenue_Request(uint packageid, uint date_start, uint date_end) : DotaPacket;
public record CWorkshop_GetPackageDailyRevenue_Response(List<CWorkshop_GetPackageDailyRevenue_Response.CountryDailyRevenue> country_revenue) : DotaPacket
{
    public record CountryDailyRevenue(string country_code, uint date, long revenue_usd, int units);
}
public record CMsgSQLGCToGCGrantBackpackSlots(uint account_id, uint add_slots) : DotaPacket;
public record CMsgClientToGCLookupAccountName(uint account_id) : DotaPacket;
public record CMsgClientToGCLookupAccountNameResponse(uint account_id, string account_name) : DotaPacket;
public record CMsgClientToGCCreateStaticRecipe(List<CMsgClientToGCCreateStaticRecipe.Item> items, uint recipe_def_index) : DotaPacket
{
    public record Item(ulong item_id, uint slot_id);
}
public record CMsgClientToGCCreateStaticRecipeResponse(CMsgClientToGCCreateStaticRecipeResponse.EResponse response, List<CMsgClientToGCCreateStaticRecipeResponse.OutputItem> output_items, List<CMsgClientToGCCreateStaticRecipeResponse.InputError> input_errors, List<CMsgClientToGCCreateStaticRecipeResponse.AdditionalOutput> additional_outputs) : DotaPacket
{
    public enum EResponse
    {
        eResponse_Success = 0,
        eResponse_OfferingDisabled = 1,
        eResponse_InvalidItems = 2,
        eResponse_InternalError = 3,
        eResponse_MissingLeague = 4,
        eResponse_MissingEvent = 5,
    }
    public record OutputItem(uint def_index, ulong item_id, uint slot_id);
    public record InputError(uint slot_id, CMsgClientToGCCreateStaticRecipeResponse.EResponse error);
    public record AdditionalOutput(uint slot_id, ulong value);
}
public record CMsgProcessTransactionOrder(ulong txn_id, ulong steam_txn_id, ulong partner_txn_id, long SF2steam_id, uint time_stamp, ulong watermark, int purchase_report_status, uint currency, List<CMsgProcessTransactionOrder.Item> items) : DotaPacket
{
    public record Item(uint item_def_index, uint item_price, uint quantity, string category_desc, uint store_purchase_type, ulong source_reference_id, int parent_stack_index, bool default_price, bool is_user_facing, bool unused10, int price_index);
}
public record CMsgGCToGCStoreProcessCDKeyTransaction(CMsgProcessTransactionOrder order, uint reason_code, uint partner) : DotaPacket;
public record CMsgGCToGCStoreProcessCDKeyTransactionResponse(bool success) : DotaPacket;
public record CMsgGCToGCStoreProcessSettlement(CMsgProcessTransactionOrder order) : DotaPacket;
public record CMsgGCToGCStoreProcessSettlementResponse(bool success) : DotaPacket;
public record CMsgGCToGCBroadcastConsoleCommand(string con_command, bool report_output, int sending_gc, string output_initiator, string sender_source) : DotaPacket;
public record CMsgGCToGCConsoleOutput(string initiator, int sending_gc, List<CMsgGCToGCConsoleOutput.OutputLine> msgs, bool is_last_for_source_job) : DotaPacket
{
    public record OutputLine(string text, uint spew_level);
}
public record CMsgItemAges(List<CMsgItemAges.MaxItemIDTimestamp> max_item_id_timestamps) : DotaPacket
{
    public record MaxItemIDTimestamp(uint timestamp, ulong max_item_id);
}
public record CMsgGCToGCInternalTestMsg(int sending_gc, long SF2sender_id, uint context, uint message_id, byte[] message_body, long SF2job_id_source, long SF2job_id_target) : DotaPacket;
public record CMsgGCToGCClientServerVersionsUpdated(uint client_min_allowed_version, uint client_active_version, uint server_active_version, uint server_deployed_version, uint what_changed) : DotaPacket;
public record CMsgGCToGCBroadcastMessageFromSub(uint msg_id, byte[] serialized_msg, List<uint> account_id_list, List<long> SF2steam_id_list) : DotaPacket;
public record CMsgGCToClientCurrencyPricePoints(List<ulong> price_key, List<CMsgGCToClientCurrencyPricePoints.Currency> currencies) : DotaPacket
{
    public record Currency(uint currency_id, List<ulong> currency_price);
}
public record CMsgBannedWordList(uint version, List<string> banned_words) : DotaPacket;
public record CMsgGCToGCFlushSteamInventoryCache(List<CMsgGCToGCFlushSteamInventoryCache.Key> keys) : DotaPacket
{
    public record Key(ulong steamid, ulong contextid);
}
public record CMsgGCToGCUpdateSubscriptionItems(uint account_id, bool always_notify) : DotaPacket;
public record CMsgGCToGCSelfPing(uint sample_id) : DotaPacket;
public record CMsgGCToGCGetInfuxIntervalStats : DotaPacket;
public record CMsgGCToGCGetInfuxIntervalStatsResponse(List<int> SF1stat_ids, List<ulong> stat_total, List<uint> stat_samples, List<uint> stat_max, uint sample_duration_ms) : DotaPacket;
public record CMsgGCToGCPurchaseSucceeded : DotaPacket;
public record CMsgClientToGCGetLimitedItemPurchaseQuantity(uint item_def) : DotaPacket;
public record CMsgClientToGCGetLimitedItemPurchaseQuantityResponse(CMsgClientToGCGetLimitedItemPurchaseQuantityResponse.EResponse result, uint quantity_purchased) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidItemDef = 5,
        k_eItemDefNotLimited = 6,
    }
}
public record CMsgClientToGCGetInFlightItemCharges(uint item_def) : DotaPacket;
public record CMsgClientToGCGetInFlightItemChargesResponse(CMsgClientToGCGetInFlightItemChargesResponse.EResponse result, uint charges_in_flight) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidItemDef = 5,
    }
}
public record CMsgClientToGCPurchaseChargeCostItems(List<CMsgClientToGCPurchaseChargeCostItems.Item> items, uint currency) : DotaPacket
{
    public record Item(uint item_def_index, uint quantity, ulong source_reference_id, int price_index);
}
public record CMsgClientToGCPurchaseChargeCostItemsResponse(CMsgClientToGCPurchaseChargeCostItemsResponse.EResponse result, List<ulong> item_ids) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidParam = 5,
        k_eInvalidPrice = 6,
        k_eInsufficientCharges = 7,
        k_eLimitedItem = 8,
        k_eMissingPrereq = 10,
    }
}
public record CMsgGCToClientInFlightChargesUpdated(bool unused1, List<CMsgGCToClientInFlightChargesUpdated.ItemCharges> in_flight_charges) : DotaPacket
{
    public record ItemCharges(uint item_def, uint charges_in_flight);
}
public record CMsgClientToGCCancelUnfinalizedTransactions(uint unused) : DotaPacket;
public record CMsgClientToGCCancelUnfinalizedTransactionsResponse(uint result) : DotaPacket;
public record CMsgGCToGCUpdateWelcomeMsg(bool server, CExtraMsgBlock new_msg, bool broadcast) : DotaPacket;
