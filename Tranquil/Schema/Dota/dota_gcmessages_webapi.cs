using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum ETeamFanContentStatus
{
    TEAM_FAN_CONTENT_STATUS_INVALID = 0,
    TEAM_FAN_CONTENT_STATUS_PENDING = 1,
    TEAM_FAN_CONTENT_STATUS_EVALUATED = 2,
}
public enum ETeamFanContentAssetType
{
    k_eFanContentAssetType_LogoPNG = 1,
    k_eFanContentAssetType_LogoSVG = 2,
    k_eFanContentAssetType_Logo3D = 3,
    k_eFanContentAssetType_Players = 4,
    k_eFanContentAssetType_Sprays = 5,
    k_eFanContentAssetType_Wallpapers = 6,
    k_eFanContentAssetType_Emoticons = 7,
    k_eFanContentAssetType_VoiceLines = 8,
    k_eFanContentAssetType_Localization = 9,
}
public enum ETeamFanContentAssetStatus
{
    k_eFanContentAssetStatus_None = 0,
    k_eFanContentAssetStatus_Approved = 1,
    k_eFanContentAssetStatus_Rejected = 2,
}
public enum ETalentContentStatus
{
    TALENT_CONTENT_STATUS_INVALID = 0,
    TALENT_CONTENT_STATUS_PENDING = 1,
    TALENT_CONTENT_STATUS_EVALUATED = 2,
}
public enum ETalentContentAssetType
{
    k_eTalentContentAssetType_Photo = 1,
    k_eTalentContentAssetType_Autograph = 2,
    k_eTalentContentAssetType_Voicelines = 3,
}
public enum ETalentContentAssetStatus
{
    k_eTalentContentAssetStatus_None = 0,
    k_eTalentContentAssetStatus_Approved = 1,
    k_eTalentContentAssetStatus_Rejected = 2,
}
public record CMsgArcanaVotes(List<CMsgArcanaVotes.Match> matches, uint round_time_remaining, uint round_number, uint voting_state, bool is_current_round_calibrating, uint closest_active_match_id, uint event_id, uint voting_start_time) : DotaPacket
{
    public enum VotingState
    {
        FINISHED = 0,
        IN_PROGRESS = 1,
        IN_FUTURE = 2,
    }
    public record Match(uint match_id, int hero_id_0, int hero_id_1, uint hero_seeding_0, uint hero_seeding_1, uint vote_count_0, uint vote_count_1, uint voting_state, uint round_number, bool is_votes_hidden, uint calibration_time_remaining);
}
public record CMsgDOTADPCFeed(List<CMsgDOTADPCFeed.Element> elements) : DotaPacket
{
    public enum EFeedElementType
    {
        FEED_SERIES_RESULT = 1,
        FEED_MATCH_POPULAR = 2,
        FEED_TEAM_UPCOMING_MATCH = 3,
        FEED_TEAM_LEAGUE_RESULT = 4,
        FEED_TEAM_ADD_PLAYER = 5,
        FEED_TEAM_REMOVE_PLAYER = 6,
        FEED_TEAM_DISBAND = 7,
        FEED_LEAGUE_UPCOMING = 8,
        FEED_LEAGUE_CONCLUDED = 9,
        FEED_DPC_STANDINGS = 10,
        FEED_ALERT_PREDICTIONS = 11,
        FEED_ALERT_FANTASY = 12,
        FEED_LEAGUE_LIVE_MATCH = 13,
        FEED_LEAGUE_INPROGRESS_SERIES = 14,
    }
    public record Element(CMsgDOTADPCFeed.EFeedElementType type, uint timestamp, uint series_id, ulong match_id, uint team_id, uint account_id, uint league_id, uint node_id, uint data_1, uint data_2, uint data_3, uint data_4, ulong server_steam_id);
}
public record CMsgDOTADPCUserInfo(bool is_plus_subscriber) : DotaPacket;
public record CMsgDraftTrivia(bool has_valid_match, CMsgDraftTrivia.DraftTriviaMatchInfo match_hero_info, uint match_rank_tier, uint end_time, uint event_id, bool current_match_voted_radiant, CMsgDraftTrivia.PreviousResult previous_result, uint current_streak) : DotaPacket
{
    public record DraftTriviaHeroInfo(int hero_id, uint role);
    public record DraftTriviaMatchInfo(List<CMsgDraftTrivia.DraftTriviaHeroInfo> radiant_heroes, List<CMsgDraftTrivia.DraftTriviaHeroInfo> dire_heroes);
    public record PreviousResult(bool voted_correctly, bool voted_radiant, CMsgDraftTrivia.DraftTriviaMatchInfo match_hero_info, uint match_rank_tier, uint end_time, ulong match_id);
}
public record CMsgTeamFanContentAssetStatus(ETeamFanContentAssetType asset_type, uint asset_index, ETeamFanContentAssetStatus asset_status, uint crc) : DotaPacket;
public record CMsgTeamFanContentAssetStatusResponse(CMsgTeamFanContentAssetStatusResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        k_eSuccess = 0,
        k_eInternalError = 1,
    }
}
public record CMsgTeamFanContentStatus(List<CMsgTeamFanContentStatus.TeamStatus> team_status_list) : DotaPacket
{
    public record TeamStatus(string name, uint team_id, string logo_url, ETeamFanContentStatus status, uint timestamp, bool unused6, ulong ugc_logo, uint workshop_account_id, string abbreviation, uint voiceline_count, uint spray_count, uint emoticon_count, uint wallpaper_count, string comment, uint comment_timestamp, List<CMsgTeamFanContentAssetStatus> asset_status, uint email_timestamp, uint email_tier, string languages);
}
public record CMsgTeamFanContentAutographStatus(List<CMsgTeamFanContentAutographStatus.TeamStatus> team_autographs) : DotaPacket
{
    public record AutographStatus(string pro_name, uint account_id, uint timestamp, string file);
    public record TeamStatus(string name, uint team_id, List<CMsgTeamFanContentAutographStatus.AutographStatus> autographs, uint workshop_account_id);
}
public record CMsgTalentContentAssetStatus(ETalentContentAssetType asset_type, uint asset_index, ETalentContentAssetStatus asset_status) : DotaPacket;
public record CMsgTalentContentStatus(List<CMsgTalentContentStatus.TalentDetails> talent_status) : DotaPacket
{
    public record TalentDetails(uint account_id, string full_name, string nickname, uint workshop_item_id, string zip_file, ETalentContentStatus status, List<CMsgTalentContentAssetStatus> asset_status, uint broadcast_language);
}
public record CMsgSetTalentContentResponse(CMsgSetTalentContentResponse.EResult result) : DotaPacket
{
    public enum EResult
    {
        k_eSuccess = 0,
        k_eInternalError = 1,
    }
}
public record CMsgDPCEvent(CMsgDPCEvent.ELeagueEvent _event, CMsgDPCEvent.ELeagueEventType event_type, List<CMsgDPCEvent.League> leagues, uint registration_period, bool is_event_upcoming, bool is_event_completed, string event_name, uint multicast_league_id, List<uint> multicast_streams, CMsgDPCEvent.ETour tour, bool unused11, uint timestamp_drop_lock, uint timestamp_add_lock, uint timestamp_content_deadline, bool is_fantasy_enabled, uint timestamp_content_review_deadline) : DotaPacket
{
    public enum ELeagueEvent
    {
        EVENT_INVALID = 0,
        SPRING_2021_LEAGUE = 1,
        SPRING_2021_MAJOR = 2,
        INTERNATIONAL_2021_QUALIFIERS = 3,
        INTERNATIONAL_2021 = 4,
        WINTER_2021_LEAGUE = 5,
        WINTER_2021_LEAGUE_FINALS = 6,
        SPRING_2022_LEAGUE = 7,
        SPRING_2022_MAJOR = 8,
        SUMMER_2022_LEAGUE = 9,
        SUMMER_2022_MAJOR = 10,
        INTERNATIONAL_2022 = 11,
        CHINA_REGIONAL_FINALS = 12,
        INTERNATIONAL_2022_REGIONAL_QUALIFIERS = 13,
        INTERNATIONAL_2022_LAST_CHANCE_QUALIFIERS = 14,
        WINTER_2023_LEAGUE = 15,
        WINTER_2023_MAJOR = 16,
        SPRING_2023_LEAGUE = 17,
        SPRING_2023_MAJOR = 18,
        SUMMER_2023_LEAGUE = 19,
        SUMMER_2023_MAJOR = 20,
        INTERNATIONAL_2023 = 21,
        INTERNATIONAL_2024 = 23,
    }
    public enum ELeagueEventPhase
    {
        PHASE_INVALID = 0,
        WILD_CARD = 1,
        GROUP_STAGE = 2,
        GROUP_A = 3,
        GROUP_B = 4,
        OVERALL = 5,
        PLAYOFF = 6,
        RESULTS = 7,
        DPC_POINT_STANDINGS = 8,
        GROUP_C = 9,
        GROUP_D = 10,
        PLACEMENT = 11,
    }
    public enum ELeagueEventType
    {
        UNKNOWN = 0,
        LEAGUE = 1,
        MAJOR = 2,
        INTERNATIONAL_QUALIFIERS = 3,
        INTERNATIONAL = 4,
        LEAGUE_FINALS = 5,
        EXTERNAL = 6,
    }
    public enum ETour
    {
        TOUR_NONE = 0,
        TOUR_1 = 1,
        TOUR_2 = 2,
        TOUR_3 = 3,
    }
    public record PhaseInfo(CMsgDPCEvent.ELeagueEventPhase phase, uint node_group_id);
    public record League(ELeagueRegion region, ELeagueDivision division, uint league_id, List<CMsgDPCEvent.PhaseInfo> phases);
}
public record CMsgDPCEventList(List<CMsgDPCEvent> events) : DotaPacket;
public record CMsgDOTAFantasyCardLineup(List<CMsgDOTAFantasyCardLineup.Period> periods) : DotaPacket
{
    public record CardBonus(uint bonus_stat, uint bonus_value);
    public record Card(uint player_account_id, string player_name, uint team_id, string team_name, uint role, List<CMsgDOTAFantasyCardLineup.CardBonus> bonuses, float score, bool finalized, ulong item_id);
    public record League(uint league_id, List<CMsgDOTAFantasyCardLineup.Card> cards, float score);
    public record Period(uint fantasy_period, uint timestamp_start, uint timestamp_end, List<CMsgDOTAFantasyCardLineup.League> leagues);
}
public record CMsgDOTAFantasyCardList(List<CMsgDOTAFantasyCardList.Card> cards) : DotaPacket
{
    public record CardBonus(uint bonus_stat, uint bonus_value);
    public record Card(uint player_account_id, string player_name, uint team_id, string team_name, uint role, List<CMsgDOTAFantasyCardList.CardBonus> bonuses, bool unused7, ulong item_id);
}
public record CMsgChatToxicityToxicPlayerMatchesReport(List<CMsgChatToxicityToxicPlayerMatchesReport.IndividualRow> rows) : DotaPacket
{
    public record IndividualRow(uint player_account_id, uint num_matches_seen, uint num_messages, uint num_messages_toxic, ulong first_match_seen, ulong last_match_seen);
}
public record CMsgChatToxicityReport(uint num_matches_seen, uint num_messages, bool unused3, uint num_messages_ml_thinks_toxic, string status, uint result, string message) : DotaPacket;
public record CMsgGetTeamAuditInformation(uint team_id, string team_name, List<CMsgGetTeamAuditInformation.Action> actions, uint last_updated) : DotaPacket
{
    public record Action(uint registration_period, uint account_id, uint action, uint timestamp, string player_name, string player_real_name);
}
public record CMsgDOTADPCMatch(CMsgDOTAMatch match, CDOTAMatchMetadata metadata) : DotaPacket;
