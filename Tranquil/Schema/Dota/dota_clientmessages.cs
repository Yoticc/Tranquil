using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EDotaClientMessages
{
    DOTA_CM_MapLine = 301,
    DOTA_CM_AspectRatio = 302,
    DOTA_CM_MapPing = 303,
    DOTA_CM_UnitsAutoAttack = 304,
    DOTA_CM_SearchString = 307,
    DOTA_CM_Pause = 308,
    DOTA_CM_ShopViewMode = 309,
    DOTA_CM_SetUnitShareFlag = 310,
    DOTA_CM_SwapRequest = 311,
    DOTA_CM_SwapAccept = 312,
    DOTA_CM_WorldLine = 313,
    DOTA_CM_RequestGraphUpdate = 314,
    DOTA_CM_ItemAlert = 315,
    DOTA_CM_ChatWheel = 316,
    DOTA_CM_SendStatPopup = 317,
    DOTA_CM_BeginLastHitChallenge = 318,
    DOTA_CM_UpdateQuickBuy = 319,
    DOTA_CM_UpdateCoachListen = 320,
    DOTA_CM_CoachHUDPing = 321,
    DOTA_CM_RecordVote = 322,
    DOTA_CM_UnitsAutoAttackAfterSpell = 323,
    DOTA_CM_WillPurchaseAlert = 324,
    DOTA_CM_PlayerShowCase = 325,
    DOTA_CM_TeleportRequiresHalt = 326,
    DOTA_CM_CameraZoomAmount = 327,
    DOTA_CM_BroadcasterUsingCamerman = 328,
    DOTA_CM_BroadcasterUsingAssistedCameraOperator = 329,
    DOTA_CM_EnemyItemAlert = 330,
    DOTA_CM_FreeInventory = 331,
    DOTA_CM_BuyBackStateAlert = 332,
    DOTA_CM_QuickBuyAlert = 333,
    DOTA_CM_HeroStatueLike = 334,
    DOTA_CM_ModifierAlert = 335,
    DOTA_CM_TeamShowcaseEditor = 336,
    DOTA_CM_HPManaAlert = 337,
    DOTA_CM_GlyphAlert = 338,
    DOTA_CM_TeamShowcaseClientData = 339,
    DOTA_CM_PlayTeamShowcase = 340,
    DOTA_CM_EventCNY2015Cmd = 341,
    DOTA_CM_FillEmptySlotsWithBots = 342,
    DOTA_CM_DemoHero = 343,
    DOTA_CM_AbilityLearnModeToggled = 344,
    DOTA_CM_AbilityStartUse = 345,
    DOTA_CM_ChallengeSelect = 346,
    DOTA_CM_ChallengeReroll = 347,
    DOTA_CM_ClickedBuff = 348,
    DOTA_CM_CoinWager = 349,
    DOTA_CM_ExecuteOrders = 350,
    DOTA_CM_XPAlert = 351,
    DOTA_CM_EventPointsTip = 353,
    DOTA_CM_KillMyHero = 355,
    DOTA_CM_QuestStatus = 356,
    DOTA_CM_ToggleAutoattack = 357,
    DOTA_CM_SpecialAbility = 358,
    DOTA_CM_KillcamDamageTaken = 359,
    DOTA_CM_SetEnemyStartingPosition = 360,
    DOTA_CM_SetDesiredWardPlacement = 361,
    DOTA_CM_RollDice = 362,
    DOTA_CM_FlipCoin = 363,
    DOTA_CM_RequestItemSuggestions = 364,
    DOTA_CM_MakeTeamCaptain = 365,
    DOTA_CM_CoinWagerToken = 366,
    DOTA_CM_RankWager = 367,
    DOTA_CM_DismissAllStatPopups = 368,
    DOTA_CM_HelpTipSystemStateChanged = 369,
    DOTA_CM_ChannelRequiresHalt = 370,
    DOTA_CM_RequestBulkCombatLog = 371,
    DOTA_CM_AbilityDraftRequestAbility = 372,
    DOTA_CM_GuideSelectOption = 373,
    DOTA_CM_GuideSelected = 374,
    DOTA_CM_DamageReport = 375,
    DOTA_CM_SalutePlayer = 376,
    DOTA_CM_SprayWheel = 377,
    DOTA_CM_TipAlert = 378,
    DOTA_CM_EmptyTeleportAlert = 379,
    DOTA_CM_RadarAlert = 380,
    DOTA_CM_TalentTreeAlert = 381,
    DOTA_CM_SetCavernMapVariant = 382,
    DOTA_CM_PauseGameOrder = 383,
    DOTA_CM_VersusScene_PlayerBehavior = 384,
    DOTA_CM_PlayerBounty = 385,
    DOTA_CM_PlayerBountyCancel = 386,
    DOTA_CM_EmptyItemSlotAlert = 388,
    DOTA_CM_AddOverwatchReportMarker = 389,
    DOTA_CM_AghsStatusAlert = 390,
    DOTA_CM_PerfReport = 391,
    DOTA_CM_ContextualTips_Subscribe = 393,
    DOTA_CM_ChatMessage = 394,
    DOTA_CM_AddCommunicationsReportMarker = 395,
    DOTA_CM_AddCommunicationsBlockMarker = 396,
    DOTA_CM_NeutralCampAlert = 397,
    DOTA_CM_DuelAccepted = 398,
    DOTA_CM_ChooseNeutralItem = 399,
    DOTA_CM_PlayerDraftPick = 800,
    DOTA_CM_PlayerDraftSuggest = 801,
    DOTA_CM_PlayerDraftPreferRole = 802,
    DOTA_CM_PlayerDraftPreferTeam = 803,
    DOTA_CM_ChatWheelAlert = 804,
    DOTA_CM_AbilityAlert = 805,
    DOTA_CM_AllyAbilityAlert = 806,
    DOTA_CM_GiftPlayer = 807,
    DOTA_CM_GiftEveryone = 808,
    DOTA_CM_SelectOverworldTokenRewards = 809,
    DOTA_CM_FacetAlert = 810,
    DOTA_CM_InnateAlert = 811,
    DOTA_CM_SelectOverworldID = 812,
    DOTA_CM_RerollNeutralItem = 813,
    DOTA_CM_RoshanTimer = 814,
    DOTA_CM_SuggestItemPreference = 815,
    DOTA_CM_CraftNeutralItem = 816,
    DOTA_CM_ChooseCraftedNeutral = 817,
    DOTA_CM_TimerAlert = 818,
    DOTA_CM_MadstoneAlert = 819,
}
public record CDOTAClientMsg_MapPing(CDOTAMsg_LocationPing location_ping) : DotaPacket;
public record CDOTAClientMsg_ItemAlert(CDOTAMsg_ItemAlert item_alert) : DotaPacket;
public record CDOTAClientMsg_EnemyItemAlert(int item_entindex, int rune_type, int item_level, int primary_charges, int secondary_charges, int ability_id, int owner_entindex) : DotaPacket;
public record CDOTAClientMsg_ModifierAlert(int buff_internal_index, int target_entindex) : DotaPacket;
public record CDOTAClientMsg_ClickedBuff(int buff_internal_index, int target_entindex) : DotaPacket;
public record CDOTAClientMsg_HPManaAlert(int target_entindex, bool show_raw_values) : DotaPacket;
public record CDOTAClientMsg_NeutralCampAlert(int spawner_entindex, int unit_entindex, bool stack_request) : DotaPacket;
public record CDOTAClientMsg_GlyphAlert(bool negative) : DotaPacket;
public record CDOTAClientMsg_RadarAlert(bool negative) : DotaPacket;
public record CDOTAClientMsg_MapLine(CDOTAMsg_MapLine mapline) : DotaPacket;
public record CDOTAClientMsg_AspectRatio(float ratio) : DotaPacket;
public record CDOTAClientMsg_UnitsAutoAttackMode(CDOTAClientMsg_UnitsAutoAttackMode.EMode mode, CDOTAClientMsg_UnitsAutoAttackMode.EUnitType unit_type) : DotaPacket
{
    public enum EMode
    {
        INVALID = -1,
        NEVER = 0,
        AFTER_SPELLCAST = 1,
        ALWAYS = 2,
    }
    public enum EUnitType
    {
        NORMAL = 0,
        SUMMONED = 1,
    }
}
public record CDOTAClientMsg_UnitsAutoAttackAfterSpell(bool enabled) : DotaPacket;
public record CDOTAClientMsg_TeleportRequiresHalt(bool enabled) : DotaPacket;
public record CDOTAClientMsg_ChannelRequiresHalt(bool enabled) : DotaPacket;
public record CDOTAClientMsg_SearchString(string search) : DotaPacket;
public record CDOTAClientMsg_Pause : DotaPacket;
public record CDOTAClientMsg_ShopViewMode(uint mode) : DotaPacket;
public record CDOTAClientMsg_SetUnitShareFlag(int player_id, uint flag, bool state) : DotaPacket;
public record CDOTAClientMsg_SwapRequest(int player_id) : DotaPacket;
public record CDOTAClientMsg_SwapAccept(int player_id) : DotaPacket;
public record CDOTAClientMsg_WorldLine(CDOTAMsg_WorldLine worldline) : DotaPacket;
public record CDOTAClientMsg_RequestGraphUpdate : DotaPacket;
public record CDOTAClientMsg_ChatWheel(uint chat_message_id, int param_hero_id, uint emoticon_id) : DotaPacket;
public record CDOTAClientMsg_SendStatPopup(CDOTAMsg_SendStatPopup statpopup) : DotaPacket;
public record CDOTAClientMsg_DismissAllStatPopups(CDOTAMsg_DismissAllStatPopups dismissallmsg) : DotaPacket;
public record CDOTAClientMsg_BeginLastHitChallenge(uint chosen_lane, bool helper_enabled) : DotaPacket;
public record CDOTAClientMsg_UpdateQuickBuyItem(int item_ability_id, bool purchasable) : DotaPacket;
public record CDOTAClientMsg_UpdateQuickBuy(List<CDOTAClientMsg_UpdateQuickBuyItem> items) : DotaPacket;
public record CDOTAClientMsg_RecordVote(int choice_index) : DotaPacket;
public record CDOTAClientMsg_WillPurchaseAlert(int item_ability_id, uint gold_remaining, int suggestion_player_id) : DotaPacket;
public record CDOTAClientMsg_BuyBackStateAlert : DotaPacket;
public record CDOTAClientMsg_QuickBuyAlert(int item_ability_id, int gold_cost, int item_cooldown_seconds, bool show_buyback) : DotaPacket;
public record CDOTAClientMsg_PlayerShowCase(bool showcase) : DotaPacket;
public record CDOTAClientMsg_CameraZoomAmount(float zoom_amount) : DotaPacket;
public record CDOTAClientMsg_BroadcasterUsingCameraman(bool cameraman) : DotaPacket;
public record CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator(bool enabled) : DotaPacket;
public record CDOTAClientMsg_FillEmptySlotsWithBots(bool fillwithbots) : DotaPacket;
public record CDOTAClientMsg_HeroStatueLike(int owner_player_id) : DotaPacket;
public record CDOTAClientMsg_EventCNY2015Cmd(byte[] data) : DotaPacket;
public record CDOTAClientMsg_DemoHero(int hero_id, int hero_id_to_spawn, List<uint> item_defs, List<ulong> item_ids, uint style_index, bool keep_existing_demohero, List<CSOEconItem> item_data, int hero_variant) : DotaPacket;
public record CDOTAClientMsg_ChallengeSelect(uint event_id, uint slot_id, uint sequence_id) : DotaPacket;
public record CDOTAClientMsg_ChallengeReroll(EEvent event_id, uint slot_id, uint sequence_id, int hero_id) : DotaPacket;
public record CDOTAClientMsg_CoinWager(uint wager_amount) : DotaPacket;
public record CDOTAClientMsg_CoinWagerToken(ulong wager_token_item_id) : DotaPacket;
public record CDOTAClientMsg_RankWager(bool announce_wager) : DotaPacket;
public record CDOTAClientMsg_PlayerBounty(int player_id) : DotaPacket;
public record CDOTAClientMsg_EventPointsTip(int recipient_player_id) : DotaPacket;
public record CDOTAClientMsg_ExecuteOrders(List<CDOTAMsg_UnitOrder> orders, uint last_order_latency) : DotaPacket;
public record CDOTAClientMsg_XPAlert(int target_entindex, uint damage_taken) : DotaPacket;
public record CDOTAClientMsg_TalentTreeAlert(int target_entindex, int ability_id, int slot, bool learned) : DotaPacket;
public record CDOTAClientMsg_KillcamDamageTaken(int target_entindex, uint damage_taken, uint item_type, int item_ability_id, string hero_name, string damage_color) : DotaPacket;
public record CDOTAClientMsg_KillMyHero : DotaPacket;
public record CDOTAClientMsg_QuestStatus(uint quest_id, uint challenge_id, uint progress, uint goal, uint query, float fail_gametime, int item_ability_id) : DotaPacket;
public record CDOTAClientMsg_ToggleAutoattack(int mode, bool show_message) : DotaPacket;
public record CDOTAClientMsg_SpecialAbility(uint ability_index, int target_entindex) : DotaPacket;
public record CDOTAClientMsg_SetEnemyStartingPosition(int enemy_player_id, uint enemy_starting_position) : DotaPacket;
public record CDOTAClientMsg_SetDesiredWardPlacement(uint ward_index, float ward_x, float ward_y) : DotaPacket;
public record CDOTAClientMsg_RollDice(uint channel_type, uint roll_min, uint roll_max) : DotaPacket;
public record CDOTAClientMsg_FlipCoin(uint channel_type) : DotaPacket;
public record CDOTAClientMsg_RequestItemSuggestions : DotaPacket;
public record CDOTAClientMsg_SuggestItemPreference(List<CDOTAClientMsg_SuggestItemPreference.ItemPreference> item_preferences) : DotaPacket
{
    public record ItemPreference(int item_id, EItemSuggestPreference preference);
}
public record CDOTAClientMsg_MakeTeamCaptain(int player_id) : DotaPacket;
public record CDOTAClientMsg_HelpTipSystemStateChanged(bool tip_displayed) : DotaPacket;
public record CDOTAClientMsg_RequestBulkCombatLog(float game_time, float duration, bool recent_player_death, int player_id) : DotaPacket;
public record CDOTAClientMsg_AbilityDraftRequestAbility(int requested_ability_id, bool ctrl_is_down, int requested_hero_id) : DotaPacket;
public record CDOTAClientMsg_GuideSelectOption(uint option, bool force_recalculate) : DotaPacket;
public record CDOTAClientMsg_GuideSelected(ulong guide_workshop_id, bool is_plus_guide) : DotaPacket;
public record CDOTAClientMsg_DamageReport(int target_hero_id, int source_hero_id, int damage_amount, bool broadcast) : DotaPacket;
public record CDOTAClientMsg_SalutePlayer(int target_player_id, int event_id) : DotaPacket;
public record CDOTAClientMsg_GiftPlayer(int target_player_id, uint item_def_index) : DotaPacket;
public record CDOTAClientMsg_GiftEveryone(uint item_def_index) : DotaPacket;
public record CDOTAClientMsg_TipAlert(string tip_text) : DotaPacket;
public record CDOTAClientMsg_EmptyTeleportAlert(int target_entindex) : DotaPacket;
public record CDOTAClientMsg_SetCavernMapVariant(uint map_variant) : DotaPacket;
public record CDOTAClientMsg_PauseGameOrder(int order_id, int data) : DotaPacket;
public record CDOTAClientMsg_VersusScene_PlayerBehavior(EDOTAVersusScenePlayerBehavior behavior, VersusScene_PlayActivity play_activity, VersusScene_ChatWheel chat_wheel, VersusScene_PlaybackRate playback_rate) : DotaPacket;
public record CDOTAClientMsg_EmptyItemSlotAlert(int target_entindex, int slot_index) : DotaPacket;
public record CDOTAClientMsg_AddOverwatchReportMarker(int target_player_id, EOverwatchReportReason reason, bool unused3, uint seconds_ago) : DotaPacket;
public record CDOTAClientMsg_AddCommunicationsReportMarker(int target_player_id) : DotaPacket;
public record CDOTAClientMsg_AddCommunicationsBlockMarker(int target_player_id) : DotaPacket;
public record CDOTAClientMsg_AghsStatusAlert(int source_player_id, int target_player_id, int target_entindex, uint alert_type) : DotaPacket;
public record CDOTAClientMsg_PerfReport(float average_frame_time, float max_frame_time, float average_compute_time, float max_compute_time, float average_client_tick_time, float max_client_tick_time, float average_client_simulate_time, float max_client_simulate_time, float average_output_time, float max_output_time, float average_wait_for_rendering_to_complete_time, float max_wait_for_rendering_to_complete_time, float average_swap_time, float max_swap_time, float average_frame_update_time, float max_frame_update_time, float average_idle_time, float max_idle_time, float average_input_processing_time, float max_input_processing_time) : DotaPacket;
public record CDOTAClientMsg_ContextualTips_Subscribe_Entry(bool unsubscribe, int tip_id, int prior_display_count, List<int> variants_seen) : DotaPacket;
public record CDOTAClientMsg_ContextualTips_Subscribe(List<CDOTAClientMsg_ContextualTips_Subscribe_Entry> tips) : DotaPacket;
public record CDOTAClientMsg_ChatMessage(uint channel_type, string message_text) : DotaPacket;
public record CDOTAClientMsg_DuelAccepted(int challenger_player_id, int accepter_player_id) : DotaPacket;
public record CDOTAClientMsg_ChooseNeutralItem(int neutral_item_index, int target_entindex, int slot_index) : DotaPacket;
public record CDOTAClientMsg_RerollNeutralItem(int target_entindex, int slot_index) : DotaPacket;
public record CDOTAClientMsg_PlayerDraftPick(int player_id) : DotaPacket;
public record CDOTAClientMsg_PlayerDraftSuggest(int player_id) : DotaPacket;
public record CDOTAClientMsg_PlayerDraftPreferRole(int role_idx, bool desired) : DotaPacket;
public record CDOTAClientMsg_PlayerDraftPreferTeam(int team) : DotaPacket;
public record CDOTAClientMsg_AbilityAlert(uint ability_entindex, bool ctrl_held, int owner_entindex, int ability_id, uint primary_charges, uint secondary_charges, float reclaim_time) : DotaPacket;
public record CDOTAClientMsg_SelectOverworldTokenRewards(List<uint> token_ids) : DotaPacket;
public record CDOTAClientMsg_FacetAlert(uint facet_strhash, uint hero_entindex, bool ctrl_held) : DotaPacket;
public record CDOTAClientMsg_InnateAlert(uint ability_entindex, bool ctrl_held) : DotaPacket;
public record CDOTAClientMsg_SelectOverworldID(uint overworld_id) : DotaPacket;
public record CDOTAClientMsg_RoshanTimer(bool negative) : DotaPacket;
public record CDOTAClientMsg_CraftNeutralItem : DotaPacket;
public record CDOTAClientMsg_ChooseCraftedNeutralItem(int neutral_item_index, int item_tier, int enhancement_index) : DotaPacket;
public record CDOTAClientMsg_TimerAlert(ETimerAlertType timer_alert_type) : DotaPacket;
public record CDOTAClientMsg_MadstoneAlert(int target_entindex) : DotaPacket;
