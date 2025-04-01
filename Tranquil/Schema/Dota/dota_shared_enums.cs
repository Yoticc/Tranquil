using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum DOTA_GameMode
{
    DOTA_GAMEMODE_NONE = 0,
    DOTA_GAMEMODE_AP = 1,
    DOTA_GAMEMODE_CM = 2,
    DOTA_GAMEMODE_RD = 3,
    DOTA_GAMEMODE_SD = 4,
    DOTA_GAMEMODE_AR = 5,
    DOTA_GAMEMODE_INTRO = 6,
    DOTA_GAMEMODE_HW = 7,
    DOTA_GAMEMODE_REVERSE_CM = 8,
    DOTA_GAMEMODE_XMAS = 9,
    DOTA_GAMEMODE_TUTORIAL = 10,
    DOTA_GAMEMODE_MO = 11,
    DOTA_GAMEMODE_LP = 12,
    DOTA_GAMEMODE_POOL1 = 13,
    DOTA_GAMEMODE_FH = 14,
    DOTA_GAMEMODE_CUSTOM = 15,
    DOTA_GAMEMODE_CD = 16,
    DOTA_GAMEMODE_BD = 17,
    DOTA_GAMEMODE_ABILITY_DRAFT = 18,
    DOTA_GAMEMODE_EVENT = 19,
    DOTA_GAMEMODE_ARDM = 20,
    DOTA_GAMEMODE_1V1MID = 21,
    DOTA_GAMEMODE_ALL_DRAFT = 22,
    DOTA_GAMEMODE_TURBO = 23,
    DOTA_GAMEMODE_MUTATION = 24,
    DOTA_GAMEMODE_COACHES_CHALLENGE = 25,
}
public enum DOTA_GameState
{
    DOTA_GAMERULES_STATE_INIT = 0,
    DOTA_GAMERULES_STATE_WAIT_FOR_PLAYERS_TO_LOAD = 1,
    DOTA_GAMERULES_STATE_HERO_SELECTION = 2,
    DOTA_GAMERULES_STATE_STRATEGY_TIME = 3,
    DOTA_GAMERULES_STATE_PRE_GAME = 4,
    DOTA_GAMERULES_STATE_GAME_IN_PROGRESS = 5,
    DOTA_GAMERULES_STATE_POST_GAME = 6,
    DOTA_GAMERULES_STATE_DISCONNECT = 7,
    DOTA_GAMERULES_STATE_TEAM_SHOWCASE = 8,
    DOTA_GAMERULES_STATE_CUSTOM_GAME_SETUP = 9,
    DOTA_GAMERULES_STATE_WAIT_FOR_MAP_TO_LOAD = 10,
    DOTA_GAMERULES_STATE_SCENARIO_SETUP = 11,
    DOTA_GAMERULES_STATE_PLAYER_DRAFT = 12,
    DOTA_GAMERULES_STATE_LAST = 13,
}
public enum DOTA_GC_TEAM
{
    DOTA_GC_TEAM_GOOD_GUYS = 0,
    DOTA_GC_TEAM_BAD_GUYS = 1,
    DOTA_GC_TEAM_BROADCASTER = 2,
    DOTA_GC_TEAM_SPECTATOR = 3,
    DOTA_GC_TEAM_PLAYER_POOL = 4,
    DOTA_GC_TEAM_NOTEAM = 5,
    DOTA_GC_TEAM_CUSTOM_1 = 6,
    DOTA_GC_TEAM_CUSTOM_2 = 7,
    DOTA_GC_TEAM_CUSTOM_3 = 8,
    DOTA_GC_TEAM_CUSTOM_4 = 9,
    DOTA_GC_TEAM_CUSTOM_5 = 10,
    DOTA_GC_TEAM_CUSTOM_6 = 11,
    DOTA_GC_TEAM_CUSTOM_7 = 12,
    DOTA_GC_TEAM_CUSTOM_8 = 13,
    DOTA_GC_TEAM_NEUTRALS = 14,
}
public enum EEvent
{
    EVENT_ID_NONE = 0,
    EVENT_ID_DIRETIDE = 1,
    EVENT_ID_SPRING_FESTIVAL = 2,
    EVENT_ID_FROSTIVUS_2013 = 3,
    EVENT_ID_COMPENDIUM_2014 = 4,
    EVENT_ID_NEXON_PC_BANG = 5,
    EVENT_ID_PWRD_DAC_2015 = 6,
    EVENT_ID_NEW_BLOOM_2015 = 7,
    EVENT_ID_INTERNATIONAL_2015 = 8,
    EVENT_ID_FALL_MAJOR_2015 = 9,
    EVENT_ID_ORACLE_PA = 10,
    EVENT_ID_NEW_BLOOM_2015_PREBEAST = 11,
    EVENT_ID_FROSTIVUS = 12,
    EVENT_ID_WINTER_MAJOR_2016 = 13,
    EVENT_ID_INTERNATIONAL_2016 = 14,
    EVENT_ID_FALL_MAJOR_2016 = 15,
    EVENT_ID_WINTER_MAJOR_2017 = 16,
    EVENT_ID_NEW_BLOOM_2017 = 17,
    EVENT_ID_INTERNATIONAL_2017 = 18,
    EVENT_ID_PLUS_SUBSCRIPTION = 19,
    EVENT_ID_SINGLES_DAY_2017 = 20,
    EVENT_ID_FROSTIVUS_2017 = 21,
    EVENT_ID_INTERNATIONAL_2018 = 22,
    EVENT_ID_FROSTIVUS_2018 = 23,
    EVENT_ID_NEW_BLOOM_2019 = 24,
    EVENT_ID_INTERNATIONAL_2019 = 25,
    EVENT_ID_NEW_PLAYER_EXPERIENCE = 26,
    EVENT_ID_FROSTIVUS_2019 = 27,
    EVENT_ID_NEW_BLOOM_2020 = 28,
    EVENT_ID_INTERNATIONAL_2020 = 29,
    EVENT_ID_TEAM_FANDOM = 30,
    EVENT_ID_DIRETIDE_2020 = 31,
    EVENT_ID_SPRING_2021 = 32,
    EVENT_ID_FALL_2021 = 33,
    EVENT_ID_TEAM_FANDOM_FALL_2021 = 34,
    EVENT_ID_TEAM_2021_2022_TOUR2 = 35,
    EVENT_ID_INTERNATIONAL_2022 = 36,
    EVENT_ID_TEAM_2021_2022_TOUR3 = 37,
    EVENT_ID_TEAM_INTERNATIONAL_2022 = 38,
    EVENT_ID_PERMANENT_GRANTS = 39,
    EVENT_ID_MUERTA_RELEASE_SPRING2023 = 40,
    EVENT_ID_TEAM_2023_TOUR1 = 41,
    EVENT_ID_TEAM_2023_TOUR2 = 42,
    EVENT_ID_TEAM_2023_TOUR3 = 43,
    EVENT_ID_INTERNATIONAL_2023 = 45,
    EVENT_ID_10TH_ANNIVERSARY = 46,
    EVENT_ID_CROWNFALL = 47,
    EVENT_ID_FROSTIVUS_2023 = 48,
    EVENT_ID_INTERNATIONAL_2024 = 49,
    EVENT_ID_FROSTIVUS_2024 = 50,
}
public enum ERankType
{
    k_ERankType_Invalid = 0,
    k_ERankType_Casual = 1,
    k_ERankType_Ranked = 2,
    k_ERankType_CasualLegacy = 3,
    k_ERankType_RankedLegacy = 4,
    k_ERankType_CasualGlicko = 5,
    k_ERankType_RankedGlicko = 6,
    k_ERankType_RankMax = 7,
    k_ERankType_BehaviorPrivate = 100,
    k_ERankType_BehaviorPublic = 101,
    k_ERankType_Max = 102,
}
public enum DOTALeaverStatus_t
{
    DOTA_LEAVER_NONE = 0,
    DOTA_LEAVER_DISCONNECTED = 1,
    DOTA_LEAVER_DISCONNECTED_TOO_LONG = 2,
    DOTA_LEAVER_ABANDONED = 3,
    DOTA_LEAVER_AFK = 4,
    DOTA_LEAVER_NEVER_CONNECTED = 5,
    DOTA_LEAVER_NEVER_CONNECTED_TOO_LONG = 6,
    DOTA_LEAVER_FAILED_TO_READY_UP = 7,
    DOTA_LEAVER_DECLINED = 8,
    DOTA_LEAVER_DECLINED_REQUEUE = 9,
}
public enum DOTAConnectionState_t
{
    DOTA_CONNECTION_STATE_UNKNOWN = 0,
    DOTA_CONNECTION_STATE_NOT_YET_CONNECTED = 1,
    DOTA_CONNECTION_STATE_CONNECTED = 2,
    DOTA_CONNECTION_STATE_DISCONNECTED = 3,
    DOTA_CONNECTION_STATE_ABANDONED = 4,
    DOTA_CONNECTION_STATE_LOADING = 5,
    DOTA_CONNECTION_STATE_FAILED = 6,
}
public enum Fantasy_Roles
{
    FANTASY_ROLE_UNDEFINED = 0,
    FANTASY_ROLE_CORE = 1,
    FANTASY_ROLE_SUPPORT = 2,
    FANTASY_ROLE_OFFLANE = 3,
    FANTASY_ROLE_MID = 4,
}
public enum Fantasy_Scoring
{
    FANTASY_SCORING_KILLS = 0,
    FANTASY_SCORING_DEATHS = 1,
    FANTASY_SCORING_CS = 2,
    FANTASY_SCORING_GPM = 3,
    FANTASY_SCORING_TOWER_KILLS = 4,
    FANTASY_SCORING_ROSHAN_KILLS = 5,
    FANTASY_SCORING_TEAMFIGHT_PARTICIPATION = 6,
    FANTASY_SCORING_WARDS_PLANTED = 7,
    FANTASY_SCORING_CAMPS_STACKED = 8,
    FANTASY_SCORING_RUNES_GRABBED = 9,
    FANTASY_SCORING_FIRST_BLOOD = 10,
    FANTASY_SCORING_STUNS = 11,
    FANTASY_SCORING_SMOKES_USED = 12,
    FANTASY_SCORING_NEUTRAL_TOKENS_FOUND = 13,
    FANTASY_SCORING_WATCHERS_TAKEN = 14,
    FANTASY_SCORING_LOTUSES_GAINED = 15,
    FANTASY_SCORING_TORMENTOR_KILLS = 16,
    FANTASY_SCORING_COURIER_KILLS = 17,
    FANTASY_SCORING_TYPES = 18,
    FANTASY_SCORING_INVALID = 19,
}
public enum Fantasy_Team_Slots
{
    FANTASY_SLOT_NONE = 0,
    FANTASY_SLOT_CORE = 1,
    FANTASY_SLOT_SUPPORT = 2,
    FANTASY_SLOT_ANY = 3,
    FANTASY_SLOT_BENCH = 4,
}
public enum Fantasy_Selection_Mode
{
    FANTASY_SELECTION_INVALID = 0,
    FANTASY_SELECTION_LOCKED = 1,
    FANTASY_SELECTION_SHUFFLE = 2,
    FANTASY_SELECTION_FREE_PICK = 3,
    FANTASY_SELECTION_ENDED = 4,
    FANTASY_SELECTION_PRE_SEASON = 5,
    FANTASY_SELECTION_PRE_DRAFT = 6,
    FANTASY_SELECTION_DRAFTING = 7,
    FANTASY_SELECTION_REGULAR_SEASON = 8,
    FANTASY_SELECTION_CARD_BASED = 9,
}
public enum Fantasy_Gem_Type
{
    FANTASY_GEM_TYPE_RUBY = 0,
    FANTASY_GEM_TYPE_SAPPHIRE = 1,
    FANTASY_GEM_TYPE_EMERALD = 2,
}
public enum DOTAChatChannelType_t
{
    DOTAChannelType_Regional = 0,
    DOTAChannelType_Custom = 1,
    DOTAChannelType_Party = 2,
    DOTAChannelType_Lobby = 3,
    DOTAChannelType_Team = 4,
    DOTAChannelType_Guild = 5,
    DOTAChannelType_Fantasy = 6,
    DOTAChannelType_Whisper = 7,
    DOTAChannelType_Console = 8,
    DOTAChannelType_Tab = 9,
    DOTAChannelType_Invalid = 10,
    DOTAChannelType_GameAll = 11,
    DOTAChannelType_GameAllies = 12,
    DOTAChannelType_GameSpectator = 13,
    DOTAChannelType_GameCoaching = 14,
    DOTAChannelType_Cafe = 15,
    DOTAChannelType_CustomGame = 16,
    DOTAChannelType_Private = 17,
    DOTAChannelType_PostGame = 18,
    DOTAChannelType_BattleCup = 19,
    DOTAChannelType_HLTVSpectator = 20,
    DOTAChannelType_GameEvents = 21,
    DOTAChannelType_Trivia = 22,
    DOTAChannelType_NewPlayer = 23,
    DOTAChannelType_PrivateCoaching = 24,
}
public enum EChatSpecialPrivileges
{
    k_EChatSpecialPrivileges_None = 0,
    k_EChatSpecialPrivileges_Moderator = 1,
    k_EChatSpecialPrivileges_SuperModerator = 2,
}
public enum DOTACommType_t
{
    DOTA_COMM_TYPE_NONE = 0,
    DOTA_COMM_TYPE_PING = 1,
    DOTA_COMM_TYPE_CHATWHEEL = 2,
    DOTA_COMM_TYPE_TIP = 3,
    DOTA_COMM_TYPE_TEXT = 4,
    DOTA_COMM_TYPE_SHOWCASE = 5,
    DOTA_COMM_TYPE_VOICE = 6,
    DOTA_COMM_TYPE_ALLY_ABILITY = 7,
    DOTA_COMM_TYPE_PAUSE = 8,
    DOTA_COMM_TYPE_COACHING = 9,
    DOTA_COMM_TYPE_NOCOOLDOWN = 10,
    DOTA_COMM_TYPE_RANKEDMATCHMAKE = 11,
    DOTA_COMM_TYPE_DROPS = 12,
    DOTA_COMM_TYPE_NEWPLAYER_EXPERT = 13,
    DOTA_COMM_TYPE_COACHED = 14,
    DOTA_COMM_TYPE_MAPDRAWING = 15,
}
public enum DOTACommLevel_t
{
    DOTA_COMM_LEVEL_NONE = 0,
    DOTA_COMM_LEVEL_COOLDOWN = 1,
    DOTA_COMM_LEVEL_PINGS = 2,
    DOTA_COMM_LEVEL_MAPDRAWING = 3,
    DOTA_COMM_LEVEL_CHAT = 4,
    DOTA_COMM_LEVEL_TIPPING = 5,
    DOTA_COMM_LEVEL_VOICE = 6,
    DOTA_COMM_LEVEL_ALLIED_ABILITY = 7,
}
public enum DOTABehaviorLevel_t
{
    DOTA_BEHAVIOR_LEVEL_NONE = 0,
    DOTA_BEHAVIOR_LEVEL_RANKED_ALLOWED = 1,
    DOTA_BEHAVIOR_LEVEL_PAUSING = 2,
    DOTA_BEHAVIOR_LEVEL_DROPS = 3,
    DOTA_BEHAVIOR_LEVEL_COACHING = 4,
}
public enum EProfileCardSlotType
{
    k_EProfileCardSlotType_Empty = 0,
    k_EProfileCardSlotType_Stat = 1,
    k_EProfileCardSlotType_Trophy = 2,
    k_EProfileCardSlotType_Item = 3,
    k_EProfileCardSlotType_Hero = 4,
    k_EProfileCardSlotType_Emoticon = 5,
    k_EProfileCardSlotType_Team = 6,
}
public enum EMatchGroupServerStatus
{
    k_EMatchGroupServerStatus_OK = 0,
    k_EMatchGroupServerStatus_LimitedAvailability = 1,
    k_EMatchGroupServerStatus_Offline = 2,
}
public enum DOTA_CM_PICK
{
    DOTA_CM_RANDOM = 0,
    DOTA_CM_GOOD_GUYS = 1,
    DOTA_CM_BAD_GUYS = 2,
}
public enum DOTALowPriorityBanType
{
    DOTA_LOW_PRIORITY_BAN_ABANDON = 0,
    DOTA_LOW_PRIORITY_BAN_REPORTS = 1,
    DOTA_LOW_PRIORITY_BAN_SECONDARY_ABANDON = 2,
    DOTA_LOW_PRIORITY_BAN_PRE_GAME_ROLE = 3,
}
public enum DOTALobbyReadyState
{
    DOTALobbyReadyState_UNDECLARED = 0,
    DOTALobbyReadyState_ACCEPTED = 1,
    DOTALobbyReadyState_DECLINED = 2,
    DOTALobbyReadyState_DECLINED_REQUEUE = 3,
}
public enum DOTAJoinLobbyResult
{
    DOTA_JOIN_RESULT_SUCCESS = 0,
    DOTA_JOIN_RESULT_ALREADY_IN_GAME = 1,
    DOTA_JOIN_RESULT_INVALID_LOBBY = 2,
    DOTA_JOIN_RESULT_INCORRECT_PASSWORD = 3,
    DOTA_JOIN_RESULT_ACCESS_DENIED = 4,
    DOTA_JOIN_RESULT_GENERIC_ERROR = 5,
    DOTA_JOIN_RESULT_INCORRECT_VERSION = 6,
    DOTA_JOIN_RESULT_IN_TEAM_PARTY = 7,
    DOTA_JOIN_RESULT_NO_LOBBY_FOUND = 8,
    DOTA_JOIN_RESULT_LOBBY_FULL = 9,
    DOTA_JOIN_RESULT_CUSTOM_GAME_INCORRECT_VERSION = 10,
    DOTA_JOIN_RESULT_TIMEOUT = 11,
    DOTA_JOIN_RESULT_CUSTOM_GAME_COOLDOWN = 12,
    DOTA_JOIN_RESULT_BUSY = 13,
    DOTA_JOIN_RESULT_NO_PLAYTIME = 14,
}
public enum DOTASelectionPriorityRules
{
    k_DOTASelectionPriorityRules_Manual = 0,
    k_DOTASelectionPriorityRules_Automatic = 1,
}
public enum DOTASelectionPriorityChoice
{
    k_DOTASelectionPriorityChoice_Invalid = 0,
    k_DOTASelectionPriorityChoice_FirstPick = 1,
    k_DOTASelectionPriorityChoice_SecondPick = 2,
    k_DOTASelectionPriorityChoice_Radiant = 3,
    k_DOTASelectionPriorityChoice_Dire = 4,
}
public enum DOTAMatchVote
{
    DOTAMatchVote_INVALID = 0,
    DOTAMatchVote_POSITIVE = 1,
    DOTAMatchVote_NEGATIVE = 2,
}
public enum DOTALobbyVisibility
{
    DOTALobbyVisibility_Public = 0,
    DOTALobbyVisibility_Friends = 1,
    DOTALobbyVisibility_Unlisted = 2,
}
public enum EDOTAPlayerMMRType
{
    k_EDOTAPlayerMMRType_Invalid = 0,
    k_EDOTAPlayerMMRType_GeneralHidden = 1,
    k_EDOTAPlayerMMRType_GeneralCompetitive = 3,
}
public enum EDOTAMMRBoostType
{
    k_EDOTAMMRBoostType_None = 0,
    k_EDOTAMMRBoostType_Leader = 1,
    k_EDOTAMMRBoostType_Follower = 2,
}
public enum MatchType
{
    MATCH_TYPE_CASUAL = 0,
    MATCH_TYPE_COOP_BOTS = 1,
    MATCH_TYPE_COMPETITIVE = 4,
    MATCH_TYPE_WEEKEND_TOURNEY = 5,
    MATCH_TYPE_EVENT = 7,
    MATCH_TYPE_COACHES_CHALLENGE = 12,
    MATCH_TYPE_NEW_PLAYER_POOL = 14,
}
public enum DOTABotDifficulty
{
    BOT_DIFFICULTY_PASSIVE = 0,
    BOT_DIFFICULTY_EASY = 1,
    BOT_DIFFICULTY_MEDIUM = 2,
    BOT_DIFFICULTY_HARD = 3,
    BOT_DIFFICULTY_UNFAIR = 4,
    BOT_DIFFICULTY_INVALID = 5,
    BOT_DIFFICULTY_EXTRA1 = 6,
    BOT_DIFFICULTY_EXTRA2 = 7,
    BOT_DIFFICULTY_EXTRA3 = 8,
    BOT_DIFFICULTY_NPX = 9,
}
public enum DOTA_BOT_MODE
{
    DOTA_BOT_MODE_NONE = 0,
    DOTA_BOT_MODE_LANING = 1,
    DOTA_BOT_MODE_ATTACK = 2,
    DOTA_BOT_MODE_ROAM = 3,
    DOTA_BOT_MODE_RETREAT = 4,
    DOTA_BOT_MODE_SECRET_SHOP = 5,
    DOTA_BOT_MODE_SIDE_SHOP = 6,
    DOTA_BOT_MODE_RUNE = 7,
    DOTA_BOT_MODE_PUSH_TOWER_TOP = 8,
    DOTA_BOT_MODE_PUSH_TOWER_MID = 9,
    DOTA_BOT_MODE_PUSH_TOWER_BOT = 10,
    DOTA_BOT_MODE_DEFEND_TOWER_TOP = 11,
    DOTA_BOT_MODE_DEFEND_TOWER_MID = 12,
    DOTA_BOT_MODE_DEFEND_TOWER_BOT = 13,
    DOTA_BOT_MODE_ASSEMBLE = 14,
    DOTA_BOT_MODE_ASSEMBLE_WITH_HUMANS = 15,
    DOTA_BOT_MODE_TEAM_ROAM = 16,
    DOTA_BOT_MODE_FARM = 17,
    DOTA_BOT_MODE_DEFEND_ALLY = 18,
    DOTA_BOT_MODE_EVASIVE_MANEUVERS = 19,
    DOTA_BOT_MODE_ROSHAN = 20,
    DOTA_BOT_MODE_ITEM = 21,
    DOTA_BOT_MODE_WARD = 22,
    DOTA_BOT_MODE_COMPANION = 23,
    DOTA_BOT_MODE_TUTORIAL_BOSS = 24,
    DOTA_BOT_MODE_MINION = 25,
    DOTA_BOT_MODE_OUTPOST = 26,
}
public enum MatchLanguages
{
    MATCH_LANGUAGE_INVALID = 0,
    MATCH_LANGUAGE_ENGLISH = 1,
    MATCH_LANGUAGE_RUSSIAN = 2,
    MATCH_LANGUAGE_CHINESE = 3,
    MATCH_LANGUAGE_KOREAN = 4,
    MATCH_LANGUAGE_SPANISH = 5,
    MATCH_LANGUAGE_PORTUGUESE = 6,
    MATCH_LANGUAGE_ENGLISH2 = 7,
}
public enum ETourneyQueueDeadlineState
{
    k_ETourneyQueueDeadlineState_Normal = 0,
    k_ETourneyQueueDeadlineState_Missed = 1,
    k_ETourneyQueueDeadlineState_ExpiredOK = 2,
    k_ETourneyQueueDeadlineState_SeekingBye = 3,
    k_ETourneyQueueDeadlineState_EligibleForRefund = 4,
    k_ETourneyQueueDeadlineState_NA = -1,
    k_ETourneyQueueDeadlineState_ExpiringSoon = 101,
}
public enum EMatchOutcome
{
    k_EMatchOutcome_Unknown = 0,
    k_EMatchOutcome_RadVictory = 2,
    k_EMatchOutcome_DireVictory = 3,
    k_EMatchOutcome_NeutralVictory = 4,
    k_EMatchOutcome_NoTeamWinner = 5,
    k_EMatchOutcome_Custom1Victory = 6,
    k_EMatchOutcome_Custom2Victory = 7,
    k_EMatchOutcome_Custom3Victory = 8,
    k_EMatchOutcome_Custom4Victory = 9,
    k_EMatchOutcome_Custom5Victory = 10,
    k_EMatchOutcome_Custom6Victory = 11,
    k_EMatchOutcome_Custom7Victory = 12,
    k_EMatchOutcome_Custom8Victory = 13,
    k_EMatchOutcome_NotScored_PoorNetworkConditions = 64,
    k_EMatchOutcome_NotScored_Leaver = 65,
    k_EMatchOutcome_NotScored_ServerCrash = 66,
    k_EMatchOutcome_NotScored_NeverStarted = 67,
    k_EMatchOutcome_NotScored_Canceled = 68,
    k_EMatchOutcome_NotScored_Suspicious = 69,
}
public enum ELaneType
{
    LANE_TYPE_UNKNOWN = 0,
    LANE_TYPE_SAFE = 1,
    LANE_TYPE_OFF = 2,
    LANE_TYPE_MID = 3,
    LANE_TYPE_JUNGLE = 4,
    LANE_TYPE_ROAM = 5,
}
public enum EBadgeType
{
    k_EBadgeType_Invalid = 0,
    k_EBadgeType_TI7_Midweek = 1,
    k_EBadgeType_TI7_Finals = 2,
    k_EBadgeType_TI7_AllEvent = 3,
    k_EBadgeType_TI8_Midweek = 4,
    k_EBadgeType_TI8_Finals = 5,
    k_EBadgeType_TI8_AllEvent = 6,
    k_EBadgeType_TI10 = 7,
    k_EBadgeType_TI11_PlayoffsDay1 = 8,
    k_EBadgeType_TI11_PlayoffsDay2 = 9,
    k_EBadgeType_TI11_PlayoffsDay3 = 10,
    k_EBadgeType_TI11_PlayoffsDay4 = 11,
    k_EBadgeType_TI11_FinalsWeekend = 12,
    k_EBadgeType_TI12_PlayoffsDay1 = 13,
    k_EBadgeType_TI12_PlayoffsDay2 = 14,
    k_EBadgeType_TI12_PlayoffsDay3 = 15,
    k_EBadgeType_TI12_FinalsWeekend = 16,
    k_EBadgeType_TI12_Special = 17,
    k_EBadgeType_TI13_FinalsDay1 = 18,
    k_EBadgeType_TI13_FinalsDay2 = 19,
    k_EBadgeType_TI13_FinalsDay3 = 20,
    k_EBadgeType_TI13_Special = 21,
}
public enum ELeagueStatus
{
    LEAGUE_STATUS_UNSET = 0,
    LEAGUE_STATUS_UNSUBMITTED = 1,
    LEAGUE_STATUS_SUBMITTED = 2,
    LEAGUE_STATUS_ACCEPTED = 3,
    LEAGUE_STATUS_REJECTED = 4,
    LEAGUE_STATUS_CONCLUDED = 5,
    LEAGUE_STATUS_DELETED = 6,
}
public enum ELeagueRegion
{
    LEAGUE_REGION_UNSET = 0,
    LEAGUE_REGION_NA = 1,
    LEAGUE_REGION_SA = 2,
    LEAGUE_REGION_WEU = 3,
    LEAGUE_REGION_EEU = 4,
    LEAGUE_REGION_CHINA = 5,
    LEAGUE_REGION_SEA = 6,
}
public enum ELeagueTier
{
    LEAGUE_TIER_UNSET = 0,
    LEAGUE_TIER_AMATEUR = 1,
    LEAGUE_TIER_PROFESSIONAL = 2,
    LEAGUE_TIER_MINOR = 3,
    LEAGUE_TIER_MAJOR = 4,
    LEAGUE_TIER_INTERNATIONAL = 5,
    LEAGUE_TIER_DPC_QUALIFIER = 6,
    LEAGUE_TIER_DPC_LEAGUE_QUALIFIER = 7,
    LEAGUE_TIER_DPC_LEAGUE = 8,
    LEAGUE_TIER_DPC_LEAGUE_FINALS = 9,
}
public enum ELeagueTierCategory
{
    LEAGUE_TIER_CATEGORY_AMATEUR = 1,
    LEAGUE_TIER_CATEGORY_PROFESSIONAL = 2,
    LEAGUE_TIER_CATEGORY_DPC = 3,
}
public enum ELeagueDivision
{
    LEAGUE_DIVISION_UNSET = 0,
    LEAGUE_DIVISION_I = 1,
    LEAGUE_DIVISION_II = 2,
}
public enum ELeagueBroadcastProvider
{
    LEAGUE_BROADCAST_UNKNOWN = 0,
    LEAGUE_BROADCAST_STEAM = 1,
    LEAGUE_BROADCAST_TWITCH = 2,
    LEAGUE_BROADCAST_YOUTUBE = 3,
    LEAGUE_BROADCAST_OTHER = 100,
}
public enum ELeaguePhase
{
    LEAGUE_PHASE_UNSET = 0,
    LEAGUE_PHASE_REGIONAL_QUALIFIER = 1,
    LEAGUE_PHASE_GROUP_STAGE = 2,
    LEAGUE_PHASE_MAIN_EVENT = 3,
}
public enum ELeagueAuditAction
{
    LEAGUE_AUDIT_ACTION_INVALID = 0,
    LEAGUE_AUDIT_ACTION_LEAGUE_CREATE = 1,
    LEAGUE_AUDIT_ACTION_LEAGUE_EDIT = 2,
    LEAGUE_AUDIT_ACTION_LEAGUE_DELETE = 3,
    LEAGUE_AUDIT_ACTION_LEAGUE_ADMIN_ADD = 4,
    LEAGUE_AUDIT_ACTION_LEAGUE_ADMIN_REVOKE = 5,
    LEAGUE_AUDIT_ACTION_LEAGUE_ADMIN_PROMOTE = 6,
    LEAGUE_AUDIT_ACTION_LEAGUE_STREAM_ADD = 7,
    LEAGUE_AUDIT_ACTION_LEAGUE_STREAM_REMOVE = 8,
    LEAGUE_AUDIT_ACTION_LEAGUE_IMAGE_UPDATED = 9,
    LEAGUE_AUDIT_ACTION_LEAGUE_MESSAGE_ADDED = 10,
    LEAGUE_AUDIT_ACTION_LEAGUE_SUBMITTED = 11,
    LEAGUE_AUDIT_ACTION_LEAGUE_SET_PRIZE_POOL = 12,
    LEAGUE_AUDIT_ACTION_LEAGUE_ADD_PRIZE_POOL_ITEM = 13,
    LEAGUE_AUDIT_ACTION_LEAGUE_REMOVE_PRIZE_POOL_ITEM = 14,
    LEAGUE_AUDIT_ACTION_LEAGUE_MATCH_START = 15,
    LEAGUE_AUDIT_ACTION_LEAGUE_MATCH_END = 16,
    LEAGUE_AUDIT_ACTION_LEAGUE_ADD_INVITED_TEAM = 17,
    LEAGUE_AUDIT_ACTION_LEAGUE_REMOVE_INVITED_TEAM = 18,
    LEAGUE_AUDIT_ACTION_LEAGUE_STATUS_CHANGED = 19,
    LEAGUE_AUDIT_ACTION_LEAGUE_STREAM_EDIT = 20,
    LEAGUE_AUDIT_ACTION_LEAGUE_TEAM_SWAP = 21,
    LEAGUE_AUDIT_ACTION_NODEGROUP_CREATE = 100,
    LEAGUE_AUDIT_ACTION_NODEGROUP_DESTROY = 101,
    LEAGUE_AUDIT_ACTION_NODEGROUP_ADD_TEAM = 102,
    LEAGUE_AUDIT_ACTION_NODEGROUP_REMOVE_TEAM = 103,
    LEAGUE_AUDIT_ACTION_NODEGROUP_SET_ADVANCING = 104,
    LEAGUE_AUDIT_ACTION_NODEGROUP_EDIT = 105,
    LEAGUE_AUDIT_ACTION_NODEGROUP_POPULATE = 106,
    LEAGUE_AUDIT_ACTION_NODEGROUP_COMPLETED = 107,
    LEAGUE_AUDIT_ACTION_NODEGROUP_SET_SECONDARY_ADVANCING = 108,
    LEAGUE_AUDIT_ACTION_NODEGROUP_SET_TERTIARY_ADVANCING = 109,
    LEAGUE_AUDIT_ACTION_NODE_CREATE = 200,
    LEAGUE_AUDIT_ACTION_NODE_DESTROY = 201,
    LEAGUE_AUDIT_ACTION_NODE_AUTOCREATE = 202,
    LEAGUE_AUDIT_ACTION_NODE_SET_TEAM = 203,
    LEAGUE_AUDIT_ACTION_NODE_SET_SERIES_ID = 204,
    LEAGUE_AUDIT_ACTION_NODE_SET_ADVANCING = 205,
    LEAGUE_AUDIT_ACTION_NODE_SET_TIME = 206,
    LEAGUE_AUDIT_ACTION_NODE_MATCH_COMPLETED = 207,
    LEAGUE_AUDIT_ACTION_NODE_COMPLETED = 208,
    LEAGUE_AUDIT_ACTION_NODE_EDIT = 209,
}
public enum DOTA_COMBATLOG_TYPES
{
    DOTA_COMBATLOG_INVALID = -1,
    DOTA_COMBATLOG_DAMAGE = 0,
    DOTA_COMBATLOG_HEAL = 1,
    DOTA_COMBATLOG_MODIFIER_ADD = 2,
    DOTA_COMBATLOG_MODIFIER_REMOVE = 3,
    DOTA_COMBATLOG_DEATH = 4,
    DOTA_COMBATLOG_ABILITY = 5,
    DOTA_COMBATLOG_ITEM = 6,
    DOTA_COMBATLOG_LOCATION = 7,
    DOTA_COMBATLOG_GOLD = 8,
    DOTA_COMBATLOG_GAME_STATE = 9,
    DOTA_COMBATLOG_XP = 10,
    DOTA_COMBATLOG_PURCHASE = 11,
    DOTA_COMBATLOG_BUYBACK = 12,
    DOTA_COMBATLOG_ABILITY_TRIGGER = 13,
    DOTA_COMBATLOG_PLAYERSTATS = 14,
    DOTA_COMBATLOG_MULTIKILL = 15,
    DOTA_COMBATLOG_KILLSTREAK = 16,
    DOTA_COMBATLOG_TEAM_BUILDING_KILL = 17,
    DOTA_COMBATLOG_FIRST_BLOOD = 18,
    DOTA_COMBATLOG_MODIFIER_STACK_EVENT = 19,
    DOTA_COMBATLOG_NEUTRAL_CAMP_STACK = 20,
    DOTA_COMBATLOG_PICKUP_RUNE = 21,
    DOTA_COMBATLOG_REVEALED_INVISIBLE = 22,
    DOTA_COMBATLOG_HERO_SAVED = 23,
    DOTA_COMBATLOG_MANA_RESTORED = 24,
    DOTA_COMBATLOG_HERO_LEVELUP = 25,
    DOTA_COMBATLOG_BOTTLE_HEAL_ALLY = 26,
    DOTA_COMBATLOG_ENDGAME_STATS = 27,
    DOTA_COMBATLOG_INTERRUPT_CHANNEL = 28,
    DOTA_COMBATLOG_ALLIED_GOLD = 29,
    DOTA_COMBATLOG_AEGIS_TAKEN = 30,
    DOTA_COMBATLOG_MANA_DAMAGE = 31,
    DOTA_COMBATLOG_PHYSICAL_DAMAGE_PREVENTED = 32,
    DOTA_COMBATLOG_UNIT_SUMMONED = 33,
    DOTA_COMBATLOG_ATTACK_EVADE = 34,
    DOTA_COMBATLOG_TREE_CUT = 35,
    DOTA_COMBATLOG_SUCCESSFUL_SCAN = 36,
    DOTA_COMBATLOG_END_KILLSTREAK = 37,
    DOTA_COMBATLOG_BLOODSTONE_CHARGE = 38,
    DOTA_COMBATLOG_CRITICAL_DAMAGE = 39,
    DOTA_COMBATLOG_SPELL_ABSORB = 40,
    DOTA_COMBATLOG_UNIT_TELEPORTED = 41,
    DOTA_COMBATLOG_KILL_EATER_EVENT = 42,
    DOTA_COMBATLOG_NEUTRAL_ITEM_EARNED = 43,
    DOTA_COMBATLOG_STAT_TRACKER_PLAYER = 44,
}
public enum EDPCFavoriteType
{
    FAVORITE_TYPE_ALL = 0,
    FAVORITE_TYPE_PLAYER = 1,
    FAVORITE_TYPE_TEAM = 2,
    FAVORITE_TYPE_LEAGUE = 3,
}
public enum EDPCPushNotification
{
    DPC_PUSH_NOTIFICATION_MATCH_STARTING = 1,
    DPC_PUSH_NOTIFICATION_PLAYER_LEFT_TEAM = 10,
    DPC_PUSH_NOTIFICATION_PLAYER_JOINED_TEAM = 11,
    DPC_PUSH_NOTIFICATION_PLAYER_JOINED_TEAM_AS_COACH = 12,
    DPC_PUSH_NOTIFICATION_PLAYER_LEFT_TEAM_AS_COACH = 13,
    DPC_PUSH_NOTIFICATION_LEAGUE_RESULT = 20,
    DPC_PUSH_NOTIFICATION_PREDICTION_MATCHES_AVAILABLE = 30,
    DPC_PUSH_NOTIFICATION_PREDICTION_RESULT = 31,
    DPC_PUSH_NOTIFICATION_FANTASY_PLAYER_CLEARED = 40,
    DPC_PUSH_NOTIFICATION_FANTASY_DAILY_SUMMARY = 41,
    DPC_PUSH_NOTIFICATION_FANTASY_FINAL_RESULTS = 42,
}
public enum EEventActionScoreMode
{
    k_eEventActionScoreMode_Add = 0,
    k_eEventActionScoreMode_Min = 1,
}
public enum EPlayerChallengeHistoryType
{
    k_EPlayerChallengeHistoryType_Invalid = 0,
    k_EPlayerChallengeHistoryType_KillEater = 1,
    k_EPlayerChallengeHistoryType_DotaPlusRelic = 2,
    k_EPlayerChallengeHistoryType_DotaPlusHeroPlayerChallenge = 3,
    k_EPlayerChallengeHistoryType_InGameEventChallenge = 4,
    k_EPlayerChallengeHistoryType_GuildContract = 5,
}
public enum EOverwatchReportReason
{
    k_EOverwatchReportReason_Unknown = 0,
    k_EOverwatchReportReason_Cheating = 1,
    k_EOverwatchReportReason_Feeding = 2,
    k_EOverwatchReportReason_Griefing = 3,
    k_EOverwatchReportReason_Suspicious = 4,
    k_EOverwatchReportReason_AbilityAbuse = 5,
}
public enum ECandyShopUpgrade
{
    k_ECandyShopUpgradeInvalid = -1,
    k_ECandyShopUpgrade_InventorySize = 0,
    k_ECandyShopUpgrade_RewardShelf = 1,
    k_ECandyShopUpgrade_ExtraExchangeRecipe = 2,
}
public enum EItemSuggestPreference
{
    k_EItemSuggestPreference_None = 0,
    k_EItemSuggestPreference_Liked = 1,
    k_EItemSuggestPreference_Disliked = 2,
}
public enum ETimerAlertType
{
    k_TimerAlertType_PowerRune = 1,
    k_TimerAlertType_BountyRune = 2,
    k_TimerAlertType_WisdomShrine = 3,
    k_TimerAlertType_JungleCamps = 4,
    k_TimerAlertType_LotusPool = 5,
}
public record CDOTAClientHardwareSpecs(uint logical_processors, long SF2cpu_cycles_per_second, long SF2total_physical_memory, bool is_64_bit_os, ulong upload_measurement, bool prefer_not_host, List<uint> crc) : DotaPacket;
public record CDOTASaveGame(bool unused1, uint save_time, List<CDOTASaveGame.Player> players, List<CDOTASaveGame.SaveInstance> save_instances, ulong match_id) : DotaPacket
{
    public record Player(DOTA_GC_TEAM team, string name, string hero);
    public record SaveInstance(bool unused1, uint game_time, uint team1_score, uint team2_score, List<CDOTASaveGame.SaveInstance.PlayerPositions> player_positions, uint save_id, uint save_time)
    {
        public record PlayerPositions(float x, float y);
    }
}
public record CMsgDOTACombatLogEntry(DOTA_COMBATLOG_TYPES type, uint target_name, uint target_source_name, uint attacker_name, uint damage_source_name, uint inflictor_name, bool is_attacker_illusion, bool is_attacker_hero, bool is_target_illusion, bool is_target_hero, bool is_visible_radiant, bool is_visible_dire, uint value, int health, float timestamp, float stun_duration, float slow_duration, bool is_ability_toggle_on, bool is_ability_toggle_off, uint ability_level, float location_x, float location_y, uint gold_reason, float timestamp_raw, float modifier_duration, uint xp_reason, uint last_hits, uint attacker_team, uint target_team, uint obs_wards_placed, uint assist_player0, uint assist_player1, uint assist_player2, uint assist_player3, uint stack_count, bool hidden_modifier, bool is_target_building, uint neutral_camp_type, uint rune_type, List<int> assist_players, bool is_heal_save, bool is_ultimate_ability, uint attacker_hero_level, uint target_hero_level, uint xpm, uint gpm, uint event_location, bool target_is_self, uint damage_type, bool invisibility_modifier, uint damage_category, uint networth, uint building_type, float modifier_elapsed_duration, bool silence_modifier, bool heal_from_lifesteal, bool modifier_purged, bool spell_evaded, bool motion_controller_modifier, bool long_range_kill, uint modifier_purge_ability, uint modifier_purge_npc, bool root_modifier, uint total_unit_death_count, bool aura_modifier, bool armor_debuff_modifier, bool no_physical_damage_modifier, uint modifier_ability, bool modifier_hidden, bool inflictor_is_stolen_ability, uint kill_eater_event, uint unit_status_label, bool spell_generated_attack, bool at_night_time, bool attacker_has_scepter, uint neutral_camp_team, float regenerated_health, bool will_reincarnate, bool uses_charges, uint tracked_stat_id) : DotaPacket;
public record CMsgPendingEventAward(EEvent event_id, uint action_id, uint num_to_grant, EEventActionScoreMode score_mode, uint audit_action, ulong audit_data) : DotaPacket;
