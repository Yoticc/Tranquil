using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum EDotaUserMessages
{
    DOTA_UM_AddUnitToSelection = 464,
    DOTA_UM_AIDebugLine = 465,
    DOTA_UM_ChatEvent = 466,
    DOTA_UM_CombatHeroPositions = 467,
    DOTA_UM_CombatLogData = 468,
    DOTA_UM_CombatLogBulkData = 470,
    DOTA_UM_CreateLinearProjectile = 471,
    DOTA_UM_DestroyLinearProjectile = 472,
    DOTA_UM_DodgeTrackingProjectiles = 473,
    DOTA_UM_GlobalLightColor = 474,
    DOTA_UM_GlobalLightDirection = 475,
    DOTA_UM_InvalidCommand = 476,
    DOTA_UM_LocationPing = 477,
    DOTA_UM_MapLine = 478,
    DOTA_UM_MiniKillCamInfo = 479,
    DOTA_UM_MinimapDebugPoint = 480,
    DOTA_UM_MinimapEvent = 481,
    DOTA_UM_NevermoreRequiem = 482,
    DOTA_UM_OverheadEvent = 483,
    DOTA_UM_SetNextAutobuyItem = 484,
    DOTA_UM_SharedCooldown = 485,
    DOTA_UM_SpectatorPlayerClick = 486,
    DOTA_UM_TutorialTipInfo = 487,
    DOTA_UM_UnitEvent = 488,
    DOTA_UM_ParticleManager = 489,
    DOTA_UM_BotChat = 490,
    DOTA_UM_HudError = 491,
    DOTA_UM_ItemPurchased = 492,
    DOTA_UM_Ping = 493,
    DOTA_UM_ItemFound = 494,
    DOTA_UM_CharacterSpeakConcept = 495,
    DOTA_UM_SwapVerify = 496,
    DOTA_UM_WorldLine = 497,
    DOTA_UM_TournamentDrop = 498,
    DOTA_UM_ItemAlert = 499,
    DOTA_UM_HalloweenDrops = 500,
    DOTA_UM_ChatWheel = 501,
    DOTA_UM_ReceivedXmasGift = 502,
    DOTA_UM_UpdateSharedContent = 503,
    DOTA_UM_TutorialRequestExp = 504,
    DOTA_UM_TutorialPingMinimap = 505,
    DOTA_UM_GamerulesStateChanged = 506,
    DOTA_UM_ShowSurvey = 507,
    DOTA_UM_TutorialFade = 508,
    DOTA_UM_AddQuestLogEntry = 509,
    DOTA_UM_SendStatPopup = 510,
    DOTA_UM_TutorialFinish = 511,
    DOTA_UM_SendRoshanPopup = 512,
    DOTA_UM_SendGenericToolTip = 513,
    DOTA_UM_SendFinalGold = 514,
    DOTA_UM_CustomMsg = 515,
    DOTA_UM_CoachHUDPing = 516,
    DOTA_UM_ClientLoadGridNav = 517,
    DOTA_UM_TE_Projectile = 518,
    DOTA_UM_TE_ProjectileLoc = 519,
    DOTA_UM_TE_DotaBloodImpact = 520,
    DOTA_UM_TE_UnitAnimation = 521,
    DOTA_UM_TE_UnitAnimationEnd = 522,
    DOTA_UM_AbilityPing = 523,
    DOTA_UM_ShowGenericPopup = 524,
    DOTA_UM_VoteStart = 525,
    DOTA_UM_VoteUpdate = 526,
    DOTA_UM_VoteEnd = 527,
    DOTA_UM_BoosterState = 528,
    DOTA_UM_WillPurchaseAlert = 529,
    DOTA_UM_TutorialMinimapPosition = 530,
    DOTA_UM_AbilitySteal = 532,
    DOTA_UM_CourierKilledAlert = 533,
    DOTA_UM_EnemyItemAlert = 534,
    DOTA_UM_StatsMatchDetails = 535,
    DOTA_UM_MiniTaunt = 536,
    DOTA_UM_BuyBackStateAlert = 537,
    DOTA_UM_SpeechBubble = 538,
    DOTA_UM_CustomHeaderMessage = 539,
    DOTA_UM_QuickBuyAlert = 540,
    DOTA_UM_StatsHeroDetails = 541,
    DOTA_UM_PredictionResult = 542,
    DOTA_UM_ModifierAlert = 543,
    DOTA_UM_HPManaAlert = 544,
    DOTA_UM_GlyphAlert = 545,
    DOTA_UM_BeastChat = 546,
    DOTA_UM_SpectatorPlayerUnitOrders = 547,
    DOTA_UM_CustomHudElement_Create = 548,
    DOTA_UM_CustomHudElement_Modify = 549,
    DOTA_UM_CustomHudElement_Destroy = 550,
    DOTA_UM_CompendiumState = 551,
    DOTA_UM_ProjectionAbility = 552,
    DOTA_UM_ProjectionEvent = 553,
    DOTA_UM_CombatLogDataHLTV = 554,
    DOTA_UM_XPAlert = 555,
    DOTA_UM_UpdateQuestProgress = 556,
    DOTA_UM_MatchMetadata = 557,
    DOTA_UM_MatchDetails = 558,
    DOTA_UM_QuestStatus = 559,
    DOTA_UM_SuggestHeroPick = 560,
    DOTA_UM_SuggestHeroRole = 561,
    DOTA_UM_KillcamDamageTaken = 562,
    DOTA_UM_SelectPenaltyGold = 563,
    DOTA_UM_RollDiceResult = 564,
    DOTA_UM_FlipCoinResult = 565,
    DOTA_UM_RequestItemSuggestions = 566,
    DOTA_UM_TeamCaptainChanged = 567,
    DOTA_UM_SendRoshanSpectatorPhase = 568,
    DOTA_UM_ChatWheelCooldown = 569,
    DOTA_UM_DismissAllStatPopups = 570,
    DOTA_UM_TE_DestroyProjectile = 571,
    DOTA_UM_HeroRelicProgress = 572,
    DOTA_UM_AbilityDraftRequestAbility = 573,
    DOTA_UM_ItemSold = 574,
    DOTA_UM_DamageReport = 575,
    DOTA_UM_SalutePlayer = 576,
    DOTA_UM_TipAlert = 577,
    DOTA_UM_ReplaceQueryUnit = 578,
    DOTA_UM_EmptyTeleportAlert = 579,
    DOTA_UM_MarsArenaOfBloodAttack = 580,
    DOTA_UM_ESArcanaCombo = 581,
    DOTA_UM_ESArcanaComboSummary = 582,
    DOTA_UM_HighFiveLeftHanging = 583,
    DOTA_UM_HighFiveCompleted = 584,
    DOTA_UM_ShovelUnearth = 585,
    DOTA_EM_InvokerSpellCast = 586,
    DOTA_UM_RadarAlert = 587,
    DOTA_UM_AllStarEvent = 588,
    DOTA_UM_TalentTreeAlert = 589,
    DOTA_UM_QueuedOrderRemoved = 590,
    DOTA_UM_DebugChallenge = 591,
    DOTA_UM_OMArcanaCombo = 592,
    DOTA_UM_FoundNeutralItem = 593,
    DOTA_UM_OutpostCaptured = 594,
    DOTA_UM_OutpostGrantedXP = 595,
    DOTA_UM_MoveCameraToUnit = 596,
    DOTA_UM_PauseMinigameData = 597,
    DOTA_UM_VersusScene_PlayerBehavior = 598,
    DOTA_UM_QoP_ArcanaSummary = 600,
    DOTA_UM_HotPotato_Created = 601,
    DOTA_UM_HotPotato_Exploded = 602,
    DOTA_UM_WK_Arcana_Progress = 603,
    DOTA_UM_GuildChallenge_Progress = 604,
    DOTA_UM_WRArcanaProgress = 605,
    DOTA_UM_WRArcanaSummary = 606,
    DOTA_UM_EmptyItemSlotAlert = 607,
    DOTA_UM_AghsStatusAlert = 608,
    DOTA_UM_PingConfirmation = 609,
    DOTA_UM_MutedPlayers = 610,
    DOTA_UM_ContextualTip = 611,
    DOTA_UM_ChatMessage = 612,
    DOTA_UM_NeutralCampAlert = 613,
    DOTA_UM_RockPaperScissorsStarted = 614,
    DOTA_UM_RockPaperScissorsFinished = 615,
    DOTA_UM_DuelOpponentKilled = 616,
    DOTA_UM_DuelAccepted = 617,
    DOTA_UM_DuelRequested = 618,
    DOTA_UM_MuertaReleaseEvent_AssignedTargetKilled = 619,
    DOTA_UM_PlayerDraftSuggestPick = 620,
    DOTA_UM_PlayerDraftPick = 621,
    DOTA_UM_UpdateLinearProjectileCPData = 622,
    DOTA_UM_GiftPlayer = 623,
    DOTA_UM_FacetPing = 624,
    DOTA_UM_InnatePing = 625,
    DOTA_UM_RoshanTimer = 626,
    DOTA_UM_NeutralCraftAvailable = 627,
    DOTA_UM_TimerAlert = 628,
    DOTA_UM_MadstoneAlert = 629,
}
public enum DOTA_CHAT_MESSAGE
{
    CHAT_MESSAGE_INVALID = -1,
    CHAT_MESSAGE_HERO_KILL = 0,
    CHAT_MESSAGE_HERO_DENY = 1,
    CHAT_MESSAGE_BARRACKS_KILL = 2,
    CHAT_MESSAGE_TOWER_KILL = 3,
    CHAT_MESSAGE_TOWER_DENY = 4,
    CHAT_MESSAGE_FIRSTBLOOD = 5,
    CHAT_MESSAGE_STREAK_KILL = 6,
    CHAT_MESSAGE_BUYBACK = 7,
    CHAT_MESSAGE_AEGIS = 8,
    CHAT_MESSAGE_ROSHAN_KILL = 9,
    CHAT_MESSAGE_COURIER_LOST = 10,
    CHAT_MESSAGE_COURIER_RESPAWNED = 11,
    CHAT_MESSAGE_GLYPH_USED = 12,
    CHAT_MESSAGE_ITEM_PURCHASE = 13,
    CHAT_MESSAGE_CONNECT = 14,
    CHAT_MESSAGE_DISCONNECT = 15,
    CHAT_MESSAGE_DISCONNECT_WAIT_FOR_RECONNECT = 16,
    CHAT_MESSAGE_DISCONNECT_TIME_REMAINING = 17,
    CHAT_MESSAGE_DISCONNECT_TIME_REMAINING_PLURAL = 18,
    CHAT_MESSAGE_RECONNECT = 19,
    CHAT_MESSAGE_PLAYER_LEFT = 20,
    CHAT_MESSAGE_SAFE_TO_LEAVE = 21,
    CHAT_MESSAGE_RUNE_PICKUP = 22,
    CHAT_MESSAGE_RUNE_BOTTLE = 23,
    CHAT_MESSAGE_RUNE_DENY = 114,
    CHAT_MESSAGE_INTHEBAG = 24,
    CHAT_MESSAGE_SECRETSHOP = 25,
    CHAT_MESSAGE_ITEM_AUTOPURCHASED = 26,
    CHAT_MESSAGE_ITEMS_COMBINED = 27,
    CHAT_MESSAGE_SUPER_CREEPS = 28,
    CHAT_MESSAGE_CANT_USE_ACTION_ITEM = 29,
    CHAT_MESSAGE_CANTPAUSE = 31,
    CHAT_MESSAGE_NOPAUSESLEFT = 32,
    CHAT_MESSAGE_CANTPAUSEYET = 33,
    CHAT_MESSAGE_PAUSED = 34,
    CHAT_MESSAGE_UNPAUSE_COUNTDOWN = 35,
    CHAT_MESSAGE_UNPAUSED = 36,
    CHAT_MESSAGE_AUTO_UNPAUSED = 37,
    CHAT_MESSAGE_YOUPAUSED = 38,
    CHAT_MESSAGE_CANTUNPAUSETEAM = 39,
    CHAT_MESSAGE_VOICE_TEXT_BANNED = 41,
    CHAT_MESSAGE_SPECTATORS_WATCHING_THIS_GAME = 42,
    CHAT_MESSAGE_REPORT_REMINDER = 43,
    CHAT_MESSAGE_ECON_ITEM = 44,
    CHAT_MESSAGE_TAUNT = 45,
    CHAT_MESSAGE_RANDOM = 46,
    CHAT_MESSAGE_RD_TURN = 47,
    CHAT_MESSAGE_DROP_RATE_BONUS = 49,
    CHAT_MESSAGE_NO_BATTLE_POINTS = 50,
    CHAT_MESSAGE_DENIED_AEGIS = 51,
    CHAT_MESSAGE_INFORMATIONAL = 52,
    CHAT_MESSAGE_AEGIS_STOLEN = 53,
    CHAT_MESSAGE_ROSHAN_CANDY = 54,
    CHAT_MESSAGE_ITEM_GIFTED = 55,
    CHAT_MESSAGE_HERO_KILL_WITH_GREEVIL = 56,
    CHAT_MESSAGE_HOLDOUT_TOWER_DESTROYED = 57,
    CHAT_MESSAGE_HOLDOUT_WALL_DESTROYED = 58,
    CHAT_MESSAGE_HOLDOUT_WALL_FINISHED = 59,
    CHAT_MESSAGE_PLAYER_LEFT_LIMITED_HERO = 62,
    CHAT_MESSAGE_ABANDON_LIMITED_HERO_EXPLANATION = 63,
    CHAT_MESSAGE_DISCONNECT_LIMITED_HERO = 64,
    CHAT_MESSAGE_LOW_PRIORITY_COMPLETED_EXPLANATION = 65,
    CHAT_MESSAGE_RECRUITMENT_DROP_RATE_BONUS = 66,
    CHAT_MESSAGE_FROSTIVUS_SHINING_BOOSTER_ACTIVE = 67,
    CHAT_MESSAGE_PLAYER_LEFT_AFK = 73,
    CHAT_MESSAGE_PLAYER_LEFT_DISCONNECTED_TOO_LONG = 74,
    CHAT_MESSAGE_PLAYER_ABANDONED = 75,
    CHAT_MESSAGE_PLAYER_ABANDONED_AFK = 76,
    CHAT_MESSAGE_PLAYER_ABANDONED_DISCONNECTED_TOO_LONG = 77,
    CHAT_MESSAGE_WILL_NOT_BE_SCORED = 78,
    CHAT_MESSAGE_WILL_NOT_BE_SCORED_RANKED = 79,
    CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK = 80,
    CHAT_MESSAGE_WILL_NOT_BE_SCORED_NETWORK_RANKED = 81,
    CHAT_MESSAGE_CAN_QUIT_WITHOUT_ABANDON = 82,
    CHAT_MESSAGE_RANKED_GAME_STILL_SCORED_LEAVERS_GET_LOSS = 83,
    CHAT_MESSAGE_ABANDON_RANKED_BEFORE_FIRST_BLOOD_PARTY = 84,
    CHAT_MESSAGE_COMPENDIUM_LEVEL = 85,
    CHAT_MESSAGE_VICTORY_PREDICTION_STREAK = 86,
    CHAT_MESSAGE_ASSASSIN_ANNOUNCE = 87,
    CHAT_MESSAGE_ASSASSIN_SUCCESS = 88,
    CHAT_MESSAGE_ASSASSIN_DENIED = 89,
    CHAT_MESSAGE_VICTORY_PREDICTION_SINGLE_USER_CONFIRM = 90,
    CHAT_MESSAGE_EFFIGY_KILL = 91,
    CHAT_MESSAGE_VOICE_TEXT_BANNED_OVERFLOW = 92,
    CHAT_MESSAGE_YEAR_BEAST_KILLED = 93,
    CHAT_MESSAGE_PAUSE_COUNTDOWN = 94,
    CHAT_MESSAGE_COINS_WAGERED = 95,
    CHAT_MESSAGE_HERO_NOMINATED_BAN = 96,
    CHAT_MESSAGE_HERO_BANNED = 97,
    CHAT_MESSAGE_HERO_BAN_COUNT = 98,
    CHAT_MESSAGE_RIVER_PAINTED = 99,
    CHAT_MESSAGE_SCAN_USED = 100,
    CHAT_MESSAGE_SHRINE_KILLED = 101,
    CHAT_MESSAGE_WAGER_TOKEN_SPENT = 102,
    CHAT_MESSAGE_RANK_WAGER = 103,
    CHAT_MESSAGE_NEW_PLAYER_REMINDER = 104,
    CHAT_MESSAGE_OBSERVER_WARD_KILLED = 105,
    CHAT_MESSAGE_SENTRY_WARD_KILLED = 106,
    CHAT_MESSAGE_ITEM_PLACED_IN_NEUTRAL_STASH = 107,
    CHAT_MESSAGE_HERO_CHOICE_INVALID = 108,
    CHAT_MESSAGE_BOUNTY = 109,
    CHAT_MESSAGE_ABILITY_DRAFT_START = 110,
    CHAT_MESSAGE_HERO_FOUND_CANDY = 111,
    CHAT_MESSAGE_ABILITY_DRAFT_RANDOMED = 112,
    CHAT_MESSAGE_PRIVATE_COACH_CONNECTED = 113,
    CHAT_MESSAGE_CANT_PAUSE_TOO_EARLY = 115,
    CHAT_MESSAGE_HERO_KILL_WITH_PENGUIN = 116,
    CHAT_MESSAGE_MINIBOSS_KILL = 117,
    CHAT_MESSAGE_PLAYER_IN_GAME_BAN_TEXT = 118,
    CHAT_MESSAGE_BANNER_PLANTED = 119,
    CHAT_MESSAGE_ALCHEMIST_GRANTED_SCEPTER = 120,
    CHAT_MESSAGE_PROTECTOR_SPAWNED = 121,
    CHAT_MESSAGE_CRAFTING_XP = 122,
}
public enum DOTA_NO_BATTLE_POINTS_REASONS
{
    NO_BATTLE_POINTS_WRONG_LOBBY_TYPE = 1,
    NO_BATTLE_POINTS_PRACTICE_BOTS = 2,
    NO_BATTLE_POINTS_CHEATS_ENABLED = 3,
    NO_BATTLE_POINTS_LOW_PRIORITY = 4,
}
public enum DOTA_CHAT_INFORMATIONAL
{
    INFO_COOP_BATTLE_POINTS_RULES = 1,
    INFO_FROSTIVUS_ABANDON_REMINDER = 2,
    INFO_RANKED_REMINDER = 3,
    INFO_COOP_LOW_PRIORITY_PASSIVE_REMINDER = 4,
    INFO_CUSTOM_GAME_PENALTY_REMINDER = 5,
}
public enum DOTA_ABILITY_PING_TYPE
{
    ABILITY_PING_READY = 1,
    ABILITY_PING_MANA = 2,
    ABILITY_PING_COOLDOWN = 3,
    ABILITY_PING_ENEMY = 4,
    ABILITY_PING_UNLEARNED = 5,
    ABILITY_PING_INBACKPACK = 6,
    ABILITY_PING_INSTASH = 7,
    ABILITY_PING_ONCOURIER = 8,
    ABILITY_PING_ALLY = 9,
    ABILITY_PING_LEARN_READY = 10,
    ABILITY_PING_WILL_LEARN = 11,
    ABILITY_PING_FUTURE_LEARN = 12,
    ABILITY_PING_NEUTRAL_OFFER = 13,
    ABILITY_PING_NEUTRAL_REQUEST = 14,
    ABILITY_PING_NEUTRAL_EQUIP = 15,
    ABILITY_PING_INCOURIERBACKPACK = 16,
}
public enum DOTA_REPLAY_STATE_EVENT
{
    DOTA_REPLAY_STATE_EVENT_GAME_START = 1,
    DOTA_REPLAY_STATE_EVENT_STARTING_HORN = 2,
    DOTA_REPLAY_STATE_EVENT_FIRST_BLOOD = 3,
    DOTA_REPLAY_STATE_EVENT_SHOWCASE = 4,
    DOTA_REPLAY_STATE_EVENT_POST_GAME = 5,
    DOTA_REPLAY_STATE_EVENT_WAIT_FOR_MAP = 6,
}
public enum EDotaEntityMessages
{
    DOTA_UNIT_SPEECH = 0,
    DOTA_UNIT_SPEECH_MUTE = 1,
    DOTA_UNIT_ADD_GESTURE = 2,
    DOTA_UNIT_REMOVE_GESTURE = 3,
    DOTA_UNIT_REMOVE_ALL_GESTURES = 4,
    DOTA_UNIT_FADE_GESTURE = 6,
    DOTA_UNIT_SPEECH_CLIENTSIDE_RULES = 7,
}
public enum DOTA_OVERHEAD_ALERT
{
    OVERHEAD_ALERT_GOLD = 0,
    OVERHEAD_ALERT_DENY = 1,
    OVERHEAD_ALERT_CRITICAL = 2,
    OVERHEAD_ALERT_XP = 3,
    OVERHEAD_ALERT_BONUS_SPELL_DAMAGE = 4,
    OVERHEAD_ALERT_MISS = 5,
    OVERHEAD_ALERT_DAMAGE = 6,
    OVERHEAD_ALERT_EVADE = 7,
    OVERHEAD_ALERT_BLOCK = 8,
    OVERHEAD_ALERT_BONUS_POISON_DAMAGE = 9,
    OVERHEAD_ALERT_HEAL = 10,
    OVERHEAD_ALERT_MANA_ADD = 11,
    OVERHEAD_ALERT_MANA_LOSS = 12,
    OVERHEAD_ALERT_LAST_HIT_EARLY = 13,
    OVERHEAD_ALERT_LAST_HIT_CLOSE = 14,
    OVERHEAD_ALERT_LAST_HIT_MISS = 15,
    OVERHEAD_ALERT_MAGICAL_BLOCK = 16,
    OVERHEAD_ALERT_INCOMING_DAMAGE = 17,
    OVERHEAD_ALERT_OUTGOING_DAMAGE = 18,
    OVERHEAD_ALERT_DISABLE_RESIST = 19,
    OVERHEAD_ALERT_DEATH = 20,
    OVERHEAD_ALERT_BLOCKED = 21,
    OVERHEAD_ALERT_ITEM_RECEIVED = 22,
    OVERHEAD_ALERT_SHARD = 23,
    OVERHEAD_ALERT_DEADLY_BLOW = 24,
    OVERHEAD_ALERT_FORCE_MISS = 25,
}
public enum DOTA_ROSHAN_PHASE
{
    k_SRSP_ROSHAN_ALIVE = 0,
    k_SRSP_ROSHAN_BASE_TIMER = 1,
    k_SRSP_ROSHAN_VISIBLE_TIMER = 2,
}
public enum DOTA_POSITION_CATEGORY
{
    DOTA_POSITION_NONE = 0,
    DOTA_POSITION_BOTTOM_LANE = 1,
    DOTA_POSITION_MID_LANE = 2,
    DOTA_POSITION_TOP_LANE = 3,
    DOTA_POSITION_RADIANT_JUNGLE = 4,
    DOTA_POSITION_DIRE_JUNGLE = 5,
    DOTA_POSITION_RADIANT_ANCIENTS = 6,
    DOTA_POSITION_DIRE_ANCIENTS = 7,
    DOTA_POSITION_RADIANT_SECRET_SHOP = 8,
    DOTA_POSITION_DIRE_SECRET_SHOP = 9,
    DOTA_POSITION_RIVER = 10,
    DOTA_POSITION_ROSHAN_PIT = 11,
    DOTA_POSITION_RADIANT_BASE = 12,
    DOTA_POSITION_DIRE_BASE = 13,
    DOTA_POSITION_FOUNTAIN = 14,
    DOTA_POSITION_OTHER = 15,
}
public enum DOTA_ABILITY_TARGET_TYPE
{
    DOTA_ABILITY_TARGET_NONE = 0,
    DOTA_ABILITY_TARGET_SELF = 1,
    DOTA_ABILITY_TARGET_ALLY_HERO = 2,
    DOTA_ABILITY_TARGET_ALLY_CREEP = 3,
    DOTA_ABILITY_TARGET_ENEMY_HERO = 4,
    DOTA_ABILITY_TARGET_ENEMY_CREEP = 5,
}
public enum EHeroStatType
{
    k_EHeroStatType_None = 0,
    k_EHeroStatType_AxeTotalDamage = 2000,
    k_EHeroStatType_BattleHungerDamage = 2001,
    k_EHeroStatType_CounterHelixDamage = 2002,
    k_EHeroStatType_CullingBladeDamage = 2003,
    k_EHeroStatType_BerserkersCallCastCount = 2004,
    k_EHeroStatType_BerserkersCallHeroesHitAverage = 2005,
    k_EHeroStatType_BerserkersCallOtherUnitsHit = 2006,
    k_EHeroStatType_BerserkersCallHeroAttacksTaken = 2007,
    k_EHeroStatType_BerserkersCallOtherAttacksTaken = 2008,
    k_EHeroStatType_BattleHungerCastCount = 2009,
    k_EHeroStatType_BattleHungerPotentialDuration = 2010,
    k_EHeroStatType_BattleHungerAverageDuration = 2011,
    k_EHeroStatType_CounterHelixProcCount = 2012,
    k_EHeroStatType_CounterHelixHeroProcCount = 2013,
    k_EHeroStatType_CounterHelixHeroesHitAverage = 2014,
    k_EHeroStatType_CounterHelixOtherUnitsHitCount = 2015,
    k_EHeroStatType_CullingBladeCastCount = 2016,
    k_EHeroStatType_CullingBladeKillCount = 2017,
    k_EHeroStatType_CullingBladeAverageHealthCulled = 2018,
    k_EHeroStatType_CullingBladeAverageDamageAvailable = 2019,
    k_EHeroStatType_CullingBladeHeroBuffAverage = 2020,
}
public enum EPlayerVoiceListenState
{
    kPVLS_None = 0,
    kPVLS_DeniedChatBanned = 1,
    kPVLS_DeniedPartner = 2,
    kPVLS_DeniedHLTVTalkerNotSpectator = 3,
    kPVLS_DeniedHLTVNoTalkerPlayerID = 4,
    kPVLS_DeniedHLTVTalkerNotBroadcaster = 5,
    kPVLS_DeniedTeamSpectator = 6,
    kPVLS_DeniedStudent = 8,
    kPVLS_DeniedPrivateCoach = 9,
    kPVLS_Denied = 64,
    kPVLS_AllowHLTVTalkerIsBroadcaster = 65,
    kPVLS_AllowCoBroadcaster = 66,
    kPVLS_AllowAllChat = 67,
    kPVLS_AllowStudentToCoach = 68,
    kPVLS_AllowFellowStudent = 69,
    kPVLS_AllowTalkerIsCoach = 70,
    kPVLS_AllowCoachHearTeam = 71,
    kPVLS_AllowSameTeam = 72,
    kPVLS_AllowShowcase = 73,
    kPVLS_AllowPrivateCoach = 74,
}
public enum EProjectionEvent
{
    ePE_FirstBlood = 0,
    ePE_Killstreak_godlike = 1,
}
public record CDOTAUserMsg_AIDebugLine(string message) : DotaPacket;
public record CDOTAUserMsg_Ping(bool unused1, uint ping, uint loss) : DotaPacket;
public record CDOTAUserMsg_SwapVerify(int player_id) : DotaPacket;
public record CDOTAUserMsg_ChatEvent(DOTA_CHAT_MESSAGE type, uint value, int SS1playerid_1, int SS1playerid_2, int SS1playerid_3, int SS1playerid_4, int SS1playerid_5, int SS1playerid_6, uint value2, uint value3) : DotaPacket;
public record CDOTAUserMsg_BotChat(int player_id, bool unused2, string message, string target, bool team_only) : DotaPacket;
public record CDOTAUserMsg_CombatHeroPositions(uint index, int time, CMsgVector2D world_pos, int health) : DotaPacket;
public record CDOTAUserMsg_CombatLogBulkData(List<CMsgDOTACombatLogEntry> combat_entries, float timestamp, float duration, int player_id, float request_time) : DotaPacket;
public record CDOTAUserMsg_ProjectileParticleCPData(int control_point, CMsgVector vector) : DotaPacket;
public record CDOTAUserMsg_UpdateLinearProjectileCPData(int handle, int control_point, CMsgVector vector) : DotaPacket;
public record CDOTAUserMsg_MiniKillCamInfo(List<CDOTAUserMsg_MiniKillCamInfo.Attacker> attackers) : DotaPacket
{
    public record Attacker(uint attacker, int total_damage, List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability> abilities, string attacker_name)
    {
        public record Ability(int ability_id, int damage);
    }
}
public record CDOTAUserMsg_GlobalLightColor(uint color, float duration) : DotaPacket;
public record CDOTAUserMsg_GlobalLightDirection(CMsgVector direction, float duration) : DotaPacket;
public record CDOTAUserMsg_LocationPing(int player_id, CDOTAMsg_LocationPing location_ping) : DotaPacket;
public record CDOTAUserMsg_PingConfirmation(int player_id_of_original_pinger, uint entity_index, uint icon_type, CMsgVector location) : DotaPacket;
public record CDOTAUserMsg_ItemAlert(int player_id, CDOTAMsg_ItemAlert item_alert) : DotaPacket;
public record CDOTAUserMsg_EnemyItemAlert(int player_id, int target_player_id, int item_ability_id, int rune_type, int entity_id, int item_level, int primary_charges, int secondary_charges) : DotaPacket;
public record CDOTAUserMsg_ModifierAlert(int player_id, string class_name, uint stack_count, bool is_debuff, int target_entindex, float seconds_remaining) : DotaPacket;
public record CDOTAUserMsg_HPManaAlert(int player_id, int target_entindex, bool show_raw_values) : DotaPacket;
public record CDOTAUserMsg_NeutralCampAlert(int player_id, int spawner_entindex, int unit_entindex, int stack_count, int camp_type, bool stack_request, bool stack_intention) : DotaPacket;
public record CDOTAUserMsg_GlyphAlert(int player_id, bool negative) : DotaPacket;
public record CDOTAUserMsg_RadarAlert(int player_id, bool negative) : DotaPacket;
public record CDOTAUserMsg_RoshanTimer(int player_id, bool negative) : DotaPacket;
public record CDOTAUserMsg_WillPurchaseAlert(int item_ability_id, int player_id, uint gold_remaining, int suggestion_player_id) : DotaPacket;
public record CDOTAUserMsg_EmptyTeleportAlert(int source_player_id, int target_player_id, int cooldown_seconds) : DotaPacket;
public record CDOTAUserMsg_MarsArenaOfBloodAttack(uint source_ehandle, uint target_ehandle, int warrior_index) : DotaPacket;
public record CDOTAEntityMsg_InvokerSpellCast(CEntityMsg entity_msg, int cast_activity) : DotaPacket;
public record CDOTAUserMsg_BuyBackStateAlert(int player_id) : DotaPacket;
public record CDOTAUserMsg_QuickBuyAlert(int player_id, int item_ability_id, int gold_cost, int item_cooldown_seconds, bool show_buyback) : DotaPacket;
public record CDOTAUserMsg_CourierKilledAlert(uint team, uint gold_value, uint entity_handle, int timestamp, List<CDOTAUserMsg_CourierKilledAlert.LostItem> lost_items, int killer_player_id, int owning_player_id) : DotaPacket
{
    public record LostItem(int item_ability_id, uint quantity);
}
public record CDOTAUserMsg_MinimapEvent(int event_type, uint entity_handle, int x, int y, int duration, uint target_entity_handle) : DotaPacket;
public record CDOTAUserMsg_MapLine(int player_id, CDOTAMsg_MapLine mapline) : DotaPacket;
public record CDOTAUserMsg_MinimapDebugPoint(CMsgVector location, uint color, int size, float duration, int index) : DotaPacket;
public record CDOTAUserMsg_CreateLinearProjectile(CMsgVector origin, CMsgVector2D velocity, bool unused3, int entindex, ulong particle_index, int handle, CMsgVector2D acceleration, float max_speed, float fow_radius, bool sticky_fow_reveal, float distance, int SF1colorgemcolor, List<CDOTAUserMsg_ProjectileParticleCPData> particle_cp_data) : DotaPacket;
public record CDOTAUserMsg_DestroyLinearProjectile(int handle) : DotaPacket;
public record CDOTAUserMsg_DodgeTrackingProjectiles(int entindex, bool attacks_only) : DotaPacket;
public record CDOTAUserMsg_SpectatorPlayerClick(int entindex, int order_type, int target_index) : DotaPacket;
public record CDOTAUserMsg_SpectatorPlayerUnitOrders(int entindex, int order_type, List<int> units, int target_index, int ability_id, CMsgVector position, bool queue, int sequence_number, uint flags, uint last_order_latency, uint ping) : DotaPacket;
public record CDOTAUserMsg_NevermoreRequiem(uint entity_handle, int lines, CMsgVector origin, bool reverse) : DotaPacket;
public record CDOTAUserMsg_InvalidCommand(string message, int sequence_number) : DotaPacket;
public record CDOTAUserMsg_HudError(int order_id, int sequence_number) : DotaPacket;
public record CDOTAUserMsg_SharedCooldown(int entindex, string name, float cooldown, int name_index) : DotaPacket;
public record CDOTAUserMsg_SetNextAutobuyItem(string name) : DotaPacket;
public record CDOTAUserMsg_HalloweenDrops(List<uint> item_defs, List<int> player_ids, uint prize_list) : DotaPacket;
public record CDOTAResponseQuerySerialized(List<CDOTAResponseQuerySerialized.Fact> facts) : DotaPacket
{
    public record Fact(int key, CDOTAResponseQuerySerialized.Fact.ValueType valtype, float val_numeric, string val_string, int val_stringtable_index, int SS1val_int_numeric)
    {
        public enum ValueType
        {
            NUMERIC = 1,
            STRING = 2,
            STRINGTABLE_INDEX = 3,
            INT_NUMERIC = 4,
        }
    }
}
public record CDOTASpeechMatchOnClient(int speech_concept, int recipient_type, CDOTAResponseQuerySerialized responsequery, int SSF1randomseed) : DotaPacket;
public record CDOTAUserMsg_UnitEvent(EDotaEntityMessages msg_type, int entity_index, CDOTAUserMsg_UnitEvent.Speech speech, CDOTAUserMsg_UnitEvent.SpeechMute speech_mute, CDOTAUserMsg_UnitEvent.AddGesture add_gesture, CDOTAUserMsg_UnitEvent.RemoveGesture remove_gesture, CDOTAUserMsg_UnitEvent.BloodImpact blood_impact, CDOTAUserMsg_UnitEvent.FadeGesture fade_gesture, CDOTASpeechMatchOnClient speech_match_on_client) : DotaPacket
{
    public record Interval(float start, float range);
    public record Speech(int speech_concept, string response, int recipient_type, bool unused4, bool muteable, CDOTAUserMsg_UnitEvent.Interval predelay, uint flags, int response_type);
    public record SpeechMute(float delay);
    public record AddGesture(int activity, int slot, float fade_in, float fade_out, float playback_rate, int sequence_variant);
    public record RemoveGesture(int activity);
    public record BloodImpact(int scale, int x_normal, int y_normal);
    public record FadeGesture(int activity);
}
public record CDOTAUserMsg_ItemPurchased(int item_ability_id) : DotaPacket;
public record CDOTAUserMsg_ItemSold(int item_ability_id) : DotaPacket;
public record CDOTAUserMsg_ItemFound(int player, int quality, int rarity, int method, uint itemdef) : DotaPacket;
public record CDOTAUserMsg_OverheadEvent(DOTA_OVERHEAD_ALERT message_type, int value, int target_player_entindex, int target_entindex, int source_player_entindex) : DotaPacket;
public record CDOTAUserMsg_TutorialTipInfo(string name, int progress) : DotaPacket;
public record CDOTAUserMsg_TutorialFinish(string heading, string emblem, string body, bool success) : DotaPacket;
public record CDOTAUserMsg_TutorialMinimapPosition : DotaPacket;
public record CDOTAUserMsg_SendGenericToolTip(string title, string text, int entindex, bool close) : DotaPacket;
public record CDOTAUserMsg_WorldLine(int player_id, CDOTAMsg_WorldLine worldline) : DotaPacket;
public record CDOTAUserMsg_ChatWheel(uint chat_message_id, int player_id, uint account_id, int param_hero_id, uint emoticon_id) : DotaPacket;
public record CDOTAUserMsg_ReceivedXmasGift(int player_id, string item_name, int inventory_slot) : DotaPacket;
public record CDOTAUserMsg_ShowSurvey(int survey_id, ulong match_id, string response_style, int teammate_hero_id, string teammate_name, uint teammate_account_id) : DotaPacket;
public record CDOTAUserMsg_UpdateSharedContent(int slot_type) : DotaPacket;
public record CDOTAUserMsg_TutorialRequestExp : DotaPacket;
public record CDOTAUserMsg_TutorialFade(int tgt_alpha) : DotaPacket;
public record CDOTAUserMsg_TutorialPingMinimap(int player_id, float pos_x, float pos_y, float pos_z, int entity_index) : DotaPacket;
public record CDOTAUserMsg_GamerulesStateChanged(uint state) : DotaPacket;
public record CDOTAUserMsg_AddQuestLogEntry(string npc_name, string npc_dialog) : DotaPacket;
public record CDOTAUserMsg_SendStatPopup(int player_id, CDOTAMsg_SendStatPopup statpopup) : DotaPacket;
public record CDOTAUserMsg_DismissAllStatPopups(CDOTAMsg_DismissAllStatPopups dismissallmsg) : DotaPacket;
public record CDOTAUserMsg_SendRoshanSpectatorPhase(DOTA_ROSHAN_PHASE phase, int phase_start_time, int phase_length) : DotaPacket;
public record CDOTAUserMsg_SendRoshanPopup(bool reclaimed, int gametime) : DotaPacket;
public record CDOTAUserMsg_SendFinalGold(List<uint> reliable_gold, List<uint> unreliable_gold) : DotaPacket;
public record CDOTAUserMsg_CustomMsg(string message, int player_id, int value) : DotaPacket;
public record CDOTAUserMsg_CoachHUDPing(int player_id, CDOTAMsg_CoachHUDPing hud_ping) : DotaPacket;
public record CDOTAUserMsg_ClientLoadGridNav : DotaPacket;
public record CDOTAUserMsg_TE_Projectile(uint source, uint target, int move_speed, int source_attachment, long particle_system_handle, bool dodgeable, bool is_attack, bool unused8, float expire_time, float maximpacttime, int SF1colorgemcolor, int launch_tick, int handle, CMsgVector target_loc, List<CDOTAUserMsg_ProjectileParticleCPData> particle_cp_data, long additional_particle_system_handle, int original_move_speed, uint ability) : DotaPacket;
public record CDOTAUserMsg_TE_ProjectileLoc(CMsgVector source_loc, uint target, int move_speed, long particle_system_handle, bool dodgeable, bool is_attack, bool unused7, bool unused8, float expire_time, CMsgVector target_loc, int SF1colorgemcolor, int launch_tick, int handle, uint source, int source_attachment, List<CDOTAUserMsg_ProjectileParticleCPData> particle_cp_data, long additional_particle_system_handle, int original_move_speed) : DotaPacket;
public record CDOTAUserMsg_TE_DestroyProjectile(int handle) : DotaPacket;
public record CDOTAUserMsg_TE_DotaBloodImpact(uint entity, float scale, float xnormal, float ynormal) : DotaPacket;
public record CDOTAUserMsg_AbilityPing(int player_id, int ability_id, DOTA_ABILITY_PING_TYPE type, uint cooldown_seconds, uint level, bool passive, uint mana_needed, uint entity_id, int primary_charges, int secondary_charges, bool unused11, bool ctrl_held, float reclaim_time, int owner_entity) : DotaPacket;
public record CDOTAUserMsg_TE_UnitAnimation(uint entity, int sequence_variant, float playbackrate, float castpoint, int type, int activity, float lag_compensation_time) : DotaPacket;
public record CDOTAUserMsg_TE_UnitAnimationEnd(uint entity, bool snap) : DotaPacket;
public record CDOTAUserMsg_ShowGenericPopup(string header, string body, string param1, string param2, bool tint_screen, bool show_no_other_dialogs) : DotaPacket;
public record CDOTAUserMsg_VoteStart(string title, float duration, int choice_count, List<string> choices) : DotaPacket;
public record CDOTAUserMsg_VoteUpdate(List<int> choice_counts) : DotaPacket;
public record CDOTAUserMsg_VoteEnd(int selected_choice) : DotaPacket;
public record CDOTAUserMsg_BoosterStatePlayer(int player_id, float bonus, float event_bonus, uint bonus_item_id, uint event_bonus_item_id) : DotaPacket;
public record CDOTAUserMsg_BoosterState(List<CDOTAUserMsg_BoosterStatePlayer> boosted_players) : DotaPacket;
public record CDOTAUserMsg_AbilitySteal(int player_id, int ability_id, uint ability_level) : DotaPacket;
public record CDOTAUserMsg_StatsHeroLookup(int player_id, int hero_id, string hero_name, string persona) : DotaPacket;
public record CDOTAUserMsg_StatsHeroPositionInfo(float average_position, List<CDOTAUserMsg_StatsHeroPositionInfo.PositionPair> position_details) : DotaPacket
{
    public record PositionPair(DOTA_POSITION_CATEGORY position_category, uint position_count);
}
public record CDOTAUserMsg_StatsHeroMinuteDetails(uint last_hits, uint hero_kills, uint hero_damage, uint tower_damage, CDOTAUserMsg_StatsHeroPositionInfo position_info, uint total_xp, uint net_worth, uint harvested_creep_gold, uint claimed_farm, uint wards_placed, uint runes_collected, uint tps_used, List<uint> mana_spent, List<uint> damage_absorbed, List<uint> damage_done) : DotaPacket;
public record CDOTAUserMsg_StatsTeamMinuteDetails(List<CDOTAUserMsg_StatsHeroMinuteDetails> player_stats, uint tower_kills, uint barrack_kills, uint available_lane_creep_gold, uint balance_kill_value, uint balance_tower_value, uint balance_barracks_value, uint balance_gold_value, uint balance_xp_value, List<CDOTAUserMsg_StatsTeamMinuteDetails.LocationPerformance> lane_performance) : DotaPacket
{
    public record LocationPerformance(uint location_category, uint stat_type, uint value);
}
public record CDOTAUserMsg_StatsPlayerKillShare(int player_id, float kill_share_percent, float player_loc_x, float player_loc_y, float health_percent, float mana_percent) : DotaPacket;
public record CDOTAUserMsg_StatsKillDetails(int victim_id, List<CDOTAUserMsg_StatsPlayerKillShare> kill_shares, uint damage_to_kill, uint effective_health, float death_time, int killer_id) : DotaPacket;
public record CDOTAUserMsg_StatsMatchDetails(List<CDOTAUserMsg_StatsHeroLookup> hero_lookup, List<CDOTAUserMsg_StatsTeamMinuteDetails> radiant_stats, List<CDOTAUserMsg_StatsTeamMinuteDetails> dire_stats, List<CDOTAUserMsg_StatsKillDetails> radiant_kills, List<CDOTAUserMsg_StatsKillDetails> dire_kills, List<CDOTAUserMsg_StatsMatchDetails.CDOTAUserMsg_StatsFightDetails> fight_details) : DotaPacket
{
    public record CDOTAUserMsg_StatsFightTeamDetails(List<int> participants, List<int> deaths, uint gold_delta, uint xp_delta);
    public record CDOTAUserMsg_StatsFightDetails(float start_time, float end_time, CDOTAUserMsg_StatsMatchDetails.CDOTAUserMsg_StatsFightTeamDetails radiant_fight_details, CDOTAUserMsg_StatsMatchDetails.CDOTAUserMsg_StatsFightTeamDetails dire_fight_details);
}
public record CDOTAUserMsg_MiniTaunt(int taunting_player_id) : DotaPacket;
public record CDOTAUserMsg_SpeechBubble(bool destroy_all) : DotaPacket;
public record CDOTAUserMsg_CustomHeaderMessage(int player_id, float duration, string message, int value) : DotaPacket;
public record CMsgHeroAbilityStat(EHeroStatType stat_type, int int_value, float float_value) : DotaPacket;
public record CMsgCombatAnalyzerPlayerStat(uint account_id, List<CMsgHeroAbilityStat> hero_ability_stats) : DotaPacket;
public record CMsgCombatAnalyzerStats(ulong match_id, List<CMsgCombatAnalyzerPlayerStat> player_stats) : DotaPacket;
public record CDOTAUserMsg_BeastChat(uint team, string format, string message, string target) : DotaPacket;
public record CDOTAUserMsg_CustomHudElement_Create(string element_id, string layout_filename, byte[] data) : DotaPacket;
public record CDOTAUserMsg_CustomHudElement_Modify(string element_id, bool modify_visible, byte[] data) : DotaPacket;
public record CDOTAUserMsg_CustomHudElement_Destroy(string element_id) : DotaPacket;
public record CDOTAUserMsg_CompendiumStatePlayer(int player_id, uint level) : DotaPacket;
public record CDOTAUserMsg_CompendiumState(List<CDOTAUserMsg_CompendiumStatePlayer> compendium_players) : DotaPacket;
public record CDOTAUserMsg_ProjectionAbility(int ability_id, int caster_ent_index, int caster_team, bool channel_end, CMsgVector origin, bool track_caster_only, float end_time, int victim_ent_index) : DotaPacket;
public record CDOTAUserMsg_ProjectionEvent(EProjectionEvent event_id, uint team) : DotaPacket;
public record CDOTAUserMsg_XPAlert(int player_id, int target_entindex) : DotaPacket;
public record CDOTAUserMsg_TalentTreeAlert(int player_id, int target_entindex, int ability_id, int slot, bool learned) : DotaPacket;
public record CDOTAUserMsg_UpdateQuestProgress : DotaPacket;
public record CDOTAUserMsg_QuestStatus(int player_id, uint quest_id, uint challenge_id, uint progress, uint goal, uint query, float fail_gametime, int item_ability_id) : DotaPacket;
public record CDOTAUserMsg_SuggestHeroPick(int player_id, int hero_id, bool ban, uint facet_id) : DotaPacket;
public record CDOTAUserMsg_SuggestHeroRole(int player_id, string hero_role) : DotaPacket;
public record CDOTAUserMsg_KillcamDamageTaken(int player_id, uint damage_taken, uint item_type, int item_ability_id, string hero_name, string damage_color) : DotaPacket;
public record CDOTAUserMsg_SelectPenaltyGold(int player_id, int SS1cost) : DotaPacket;
public record CDOTAUserMsg_RollDiceResult(int player_id, uint channel_type, uint roll_min, uint roll_max, uint result) : DotaPacket;
public record CDOTAUserMsg_FlipCoinResult(int player_id, uint channel_type, bool result) : DotaPacket;
public record CDOTAUserMessage_RequestItemSuggestions(int player_id) : DotaPacket;
public record CDOTAUserMessage_TeamCaptainChanged(uint team, int captain_player_id) : DotaPacket;
public record CDOTAUserMsg_ChatWheelCooldown(uint message_id, float cooldown_remaining) : DotaPacket;
public record CDOTAUserMsg_HeroRelicProgress(uint hero_relic_type, uint value, uint ehandle, uint event_id, float value_display) : DotaPacket;
public record CDOTAUserMsg_AbilityDraftRequestAbility(int player_id, int requested_ability_id, bool ctrl_is_down, int requested_hero_id) : DotaPacket;
public record CDOTAUserMsg_DamageReport(int player_id, int target_hero_id, int source_hero_id, int damage_amount, bool broadcast) : DotaPacket;
public record CDOTAUserMsg_SalutePlayer(int source_player_id, int target_player_id, uint tip_amount, uint event_id, string custom_tip_style, uint num_recent_tips) : DotaPacket;
public record CDOTAUserMsg_GiftPlayer(int source_player_id, int target_player_id, uint gift_item_def_index) : DotaPacket;
public record CDOTAUserMsg_TipAlert(int player_id, string tip_text) : DotaPacket;
public record CDOTAUserMsg_ReplaceQueryUnit(int player_id, int source_entindex, int target_entindex) : DotaPacket;
public record CDOTAUserMsg_ESArcanaCombo(uint ehandle, uint combo_count, uint arcana_level) : DotaPacket;
public record CDOTAUserMsg_ESArcanaComboSummary(uint ehandle, uint combo_count, uint damage_amount) : DotaPacket;
public record CDOTAUserMsg_OMArcanaCombo(uint ehandle, uint multicast_amount, uint arcana_level, uint multicast_chance) : DotaPacket;
public record CDOTAUserMsg_HighFiveCompleted(int player_id_1, int player_id_2, bool special_high_five, int special_entindex) : DotaPacket;
public record CDOTAUserMsg_HighFiveLeftHanging(int player_id) : DotaPacket;
public record CDOTAUserMsg_ShovelUnearth(int player_id, bool all_chat, string locstring, uint quantity) : DotaPacket;
public record CDOTAUserMsg_AllStarEvent(int source_player_id, int target_player_id, uint point_amount, uint event_id, List<CDOTAUserMsg_AllStarEvent.PlayerScore> player_scores) : DotaPacket
{
    public record PlayerScore(int player_id, uint score_sans_kda);
}
public record CDOTAUserMsg_QueuedOrderRemoved(List<uint> unit_order_sequence) : DotaPacket;
public record CDOTAUserMsg_DebugChallenge(uint challenge_type, uint challenge_query_id, uint event_id, uint instance_id, uint challenge_var_0, uint challenge_var_1, uint challenge_max_rank) : DotaPacket;
public record CDOTAUserMsg_FoundNeutralItem(int player_id, int item_ability_id, uint item_tier, uint tier_item_count, int enhancement_ability_id, int enhancement_level) : DotaPacket;
public record CDOTAUserMsg_OutpostCaptured(int outpost_entindex, uint team_id) : DotaPacket;
public record CDOTAUserMsg_OutpostGrantedXP(uint team_id, uint xp_amount) : DotaPacket;
public record CDOTAUserMsg_MoveCameraToUnit(uint unit_ehandle) : DotaPacket;
public record CDOTAUserMsg_PauseMinigameData(List<CDOTAUserMsg_PauseMinigameData.DataBit> data_bits) : DotaPacket
{
    public record DataBit(uint index, int data, long data_extra);
}
public record CDOTAUserMsg_VersusScene_PlayerBehavior(int player_id, EDOTAVersusScenePlayerBehavior behavior, VersusScene_PlayActivity play_activity, VersusScene_ChatWheel chat_wheel, VersusScene_PlaybackRate playback_rate) : DotaPacket;
public record CDOTAUserMsg_QoP_ArcanaSummary(uint ehandle, uint arcana_level, uint players_hit, uint players_killed) : DotaPacket;
public record CDOTAUserMsg_HotPotato_Created(int player_id_1, int player_id_2) : DotaPacket;
public record CDOTAUserMsg_HotPotato_Exploded(int player_id) : DotaPacket;
public record CDOTAUserMsg_WK_Arcana_Progress(uint ehandle, uint arcana_level, int hero_id) : DotaPacket;
public record CDOTAUserMsg_GuildChallenge_Progress(List<CDOTAUserMsg_GuildChallenge_Progress.PlayerProgress> player_progress, uint guild_id, uint challenge_instance_id, uint challenge_parameter, CDOTAUserMsg_GuildChallenge_Progress.EChallengeType challenge_type, bool unused6, uint challenge_progress_at_start, bool complete) : DotaPacket
{
    public enum EChallengeType
    {
        k_EChallengeType_Invalid = 0,
        k_EChallengeType_Cooperative = 1,
        k_EChallengeType_Contract = 2,
    }
    public record PlayerProgress(int player_id, bool unused2, bool unused3, bool unused4, bool unused5, uint progress);
}
public record CDOTAUserMsg_WRArcanaProgress(uint ehandle, uint target_ehandle, uint arrows_landed, uint damage_dealt, uint target_hp, uint target_max_hp, uint arcana_level) : DotaPacket;
public record CDOTAUserMsg_WRArcanaSummary(uint ehandle, uint target_ehandle, uint arrows_landed, uint damage_dealt, uint target_hp, uint target_max_hp, uint arcana_level, bool success) : DotaPacket;
public record CDOTAUserMsg_EmptyItemSlotAlert(int source_player_id, int target_player_id, int slot_index, int cooldown_seconds) : DotaPacket;
public record CDOTAUserMsg_AghsStatusAlert(int source_player_id, int target_player_id, int target_entindex, uint alert_type, bool has_scepter, bool has_shard) : DotaPacket;
public record CDOTAUserMsg_MutedPlayers(List<int> text_muted_player_ids, List<int> voice_muted_player_ids) : DotaPacket;
public record CDOTAUserMsg_ContextualTip(int tip_id, List<string> referenced_abilities, List<string> referenced_units, List<string> panorama_classes, bool force_annotation, int variant, int int_param, int int_param2, float float_param, float float_param2, string string_param, string string_param2, string tip_text_override, string tip_annotation_override, string panorama_snippet) : DotaPacket;
public record CDOTAUserMsg_ChatMessage(int source_player_id, uint channel_type, string message_text) : DotaPacket;
public record CDOTAUserMsg_RockPaperScissorsStarted(int player_id_source, int player_id_target) : DotaPacket;
public record CDOTAUserMsg_RockPaperScissorsFinished(int player_id_1, int player_id_2, int player_1_choice, int player_2_choice) : DotaPacket;
public record CDOTAUserMsg_DuelOpponentKilled(int player_id_winner, int player_id_loser) : DotaPacket;
public record CDOTAUserMsg_DuelAccepted(int player_id_1, int player_id_2) : DotaPacket;
public record CDOTAUserMsg_DuelRequested(int player_id_requestor) : DotaPacket;
public record CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled(int player_id_killer, int player_id_target, int points, int points_total, bool last_hit) : DotaPacket;
public record CDOTAUserMsg_PlayerDraftSuggestPick(int player_id, int suggestion_player_id) : DotaPacket;
public record CDOTAUserMsg_PlayerDraftPick(int player_id_captain, int player_id_target, int team) : DotaPacket;
public record CDOTAUserMsg_FacetPing(int player_id, uint facet_strhash, uint entity_id, bool all_chat) : DotaPacket;
public record CDOTAUserMsg_InnatePing(int player_id, uint entity_id, bool all_chat) : DotaPacket;
public record CDOTAUserMsg_NeutralCraftAvailable : DotaPacket;
public record CDOTAUserMsg_TimerAlert(int player_id, ETimerAlertType timer_alert_type) : DotaPacket;
public record CDOTAUserMsg_MadstoneAlert(int player_id, int target_entindex, int tier, CDOTAUserMsg_MadstoneAlert.EMadstoneAlertType madstone_alert_type, int value) : DotaPacket
{
    public enum EMadstoneAlertType
    {
        CraftAvailable = 0,
        NeedMadstone = 1,
        WaitingForNextTier = 2,
    }
}
