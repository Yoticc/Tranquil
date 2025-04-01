using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public enum ECoachTeammateRating
{
    k_ECoachTeammateRating_None = 0,
    k_ECoachTeammateRating_Positive = 1,
    k_ECoachTeammateRating_Negative = 2,
    k_ECoachTeammateRating_Abusive = 3,
}
public enum EPrivateCoachingSessionState
{
    k_ePrivateCoachingSessionState_Invalid = 0,
    k_ePrivateCoachingSessionState_SearchingForCoach = 1,
    k_ePrivateCoachingSessionState_CoachAssigned = 2,
    k_ePrivateCoachingSessionState_Finished = 3,
    k_ePrivateCoachingSessionState_Expired = 4,
    k_ePrivateCoachingSessionState_Abandoned = 5,
}
public enum EPrivateCoachingSessionMemberFlag
{
    k_EPrivateCoachingSessionMemberFlag_Requester = 1,
    k_EPrivateCoachingSessionMemberFlag_Coach = 2,
    k_EPrivateCoachingSessionMemberFlag_LeftSession = 4,
}
public enum EPlayerCoachMatchFlag
{
    k_EPlayerCoachMatchFlag_EligibleForRewards = 1,
    k_EPlayerCoachMatchFlag_PrivateCoach = 2,
}
public record CMsgPlayerCoachMatch(ulong match_id, EMatchOutcome match_outcome, uint coached_team, int SF1start_time, uint duration, List<ECoachTeammateRating> teammate_ratings, uint coach_flags) : DotaPacket;
public record CMsgPrivateCoachingSessionMember(uint account_id, uint member_flags, ECoachTeammateRating member_session_rating) : DotaPacket;
public record CMsgPrivateCoachingSession(ulong private_coaching_session_id, int SF1requested_timestamp, uint requested_language, EPrivateCoachingSessionState coaching_session_state, List<CMsgPrivateCoachingSessionMember> session_members, ulong current_lobby_id, ulong current_server_steam_id, int SF1accepted_timestamp, int SF1completed_timestamp) : DotaPacket;
public record CMsgPrivateCoachingSessionStatus(uint requester_competitive_rank_tier, uint requester_games_played) : DotaPacket;
public record CMsgAvailablePrivateCoachingSession(CMsgPrivateCoachingSession coaching_session, CMsgPrivateCoachingSessionStatus coaching_session_status) : DotaPacket;
public record CMsgAvailablePrivateCoachingSessionList(List<CMsgAvailablePrivateCoachingSession> available_coaching_sessions) : DotaPacket;
public record CMsgAvailablePrivateCoachingSessionSummary(uint coaching_session_count) : DotaPacket;
public record CMsgClientToGCRequestPlayerCoachMatches : DotaPacket;
public record CMsgClientToGCRequestPlayerCoachMatchesResponse(CMsgClientToGCRequestPlayerCoachMatchesResponse.EResponse result, List<CMsgPlayerCoachMatch> coach_matches) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgClientToGCRequestPlayerCoachMatch(ulong match_id) : DotaPacket;
public record CMsgClientToGCRequestPlayerCoachMatchResponse(CMsgClientToGCRequestPlayerCoachMatchResponse.EResponse result, CMsgPlayerCoachMatch coach_match) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
    }
}
public record CMsgClientToGCSubmitCoachTeammateRating(ulong match_id, uint coach_account_id, ECoachTeammateRating rating, string reason) : DotaPacket;
public record CMsgClientToGCSubmitCoachTeammateRatingResponse(CMsgClientToGCSubmitCoachTeammateRatingResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eInvalidInput = 4,
        k_eAlreadySubmitted = 5,
        k_eVotingFinished = 6,
        k_ePlayerNotInMatch = 7,
        k_eCoachNotInMatch = 8,
        k_ePlayerNotOnCoachTeam = 9,
        k_ePlayerInSamePartyAsCoach = 10,
        k_eMatchNotEligible = 11,
    }
}
public record CMsgGCToClientCoachTeammateRatingsChanged(CMsgPlayerCoachMatch coach_match) : DotaPacket;
public record CMsgClientToGCRequestPrivateCoachingSession(uint language) : DotaPacket;
public record CMsgClientToGCRequestPrivateCoachingSessionResponse(CMsgClientToGCRequestPrivateCoachingSessionResponse.EResponse result, CMsgPrivateCoachingSession coaching_session) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eAlreadyInSession = 5,
        k_eBehaviorScoreTooLow = 6,
        k_eInvalidLobbyType = 7,
        k_eLowPriorityPlayer = 8,
        k_eLowPriorityLobby = 9,
        k_eLowPriorityParty = 10,
        k_eTextChatBan = 11,
        k_eVoiceChatBan = 12,
        k_eMatchBan = 13,
    }
}
public record CMsgClientToGCAcceptPrivateCoachingSession(ulong coaching_session_id) : DotaPacket;
public record CMsgClientToGCAcceptPrivateCoachingSessionResponse(CMsgClientToGCAcceptPrivateCoachingSessionResponse.EResponse result, CMsgPrivateCoachingSession coaching_session) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eUnknownSession = 5,
        k_eAlreadyHasCoach = 6,
        k_eAlreadyHasSession = 7,
        k_eInvalidUser = 8,
        k_eAlreadyFinished = 9,
        k_eInvalidLobbyType = 10,
        k_eAlreadyInLobby = 11,
        k_eLobbyIsLan = 12,
        k_eLobbyIsLeague = 13,
        k_eInvalidLobbyState = 14,
        k_eRequesterIsNotPlayer = 15,
        k_eTooManyCoaches = 16,
        k_eCoachWasPlayer = 17,
        k_eCoachBehaviorScoreTooLow = 18,
        k_eCoachRankNotCalibrated = 19,
        k_eCoachRankNotEligible = 20,
        k_eCoachRankTooLow = 21,
    }
}
public record CMsgClientToGCLeavePrivateCoachingSession : DotaPacket;
public record CMsgClientToGCLeavePrivateCoachingSessionResponse(CMsgClientToGCLeavePrivateCoachingSessionResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoSession = 5,
        k_eAlreadyLeft = 6,
    }
}
public record CMsgClientToGCGetCurrentPrivateCoachingSession : DotaPacket;
public record CMsgClientToGCGetCurrentPrivateCoachingSessionResponse(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.EResponse result, CMsgPrivateCoachingSession current_session) : DotaPacket
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
public record CMsgGCToClientPrivateCoachingSessionUpdated(CMsgPrivateCoachingSession coaching_session) : DotaPacket;
public record CMsgClientToGCSubmitPrivateCoachingSessionRating(ulong coaching_session_id, ECoachTeammateRating session_rating) : DotaPacket;
public record CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eUnknownSession = 5,
        k_eNotMember = 6,
        k_eAlreadySubmitted = 7,
        k_eSessionActive = 8,
        k_eSessionTooShort = 9,
        k_eNoCoach = 10,
        k_eInvalidRating = 11,
    }
}
public record CMsgClientToGCGetAvailablePrivateCoachingSessions(uint language) : DotaPacket;
public record CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.EResponse result, CMsgAvailablePrivateCoachingSessionList available_sessions_list) : DotaPacket
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
public record CMsgClientToGCGetAvailablePrivateCoachingSessionsSummary : DotaPacket;
public record CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.EResponse result, CMsgAvailablePrivateCoachingSessionSummary coaching_session_summary) : DotaPacket
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
public record CMsgClientToGCJoinPrivateCoachingSessionLobby : DotaPacket;
public record CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eNoSession = 5,
        k_eSessionFinished = 6,
        k_eAlreadyLeft = 7,
        k_eNotACoach = 8,
        k_eNoLobby = 9,
        k_eCoachInThisLobby = 10,
        k_eCoachInALobby = 11,
        k_eLobbyIsLan = 12,
        k_eLobbyIsLeague = 13,
        k_eInvalidLobbyType = 14,
        k_eInvalidLobbyState = 15,
        k_eRequesterIsNotPlayer = 16,
        k_eTooManyCoaches = 17,
        k_eCoachWasPlayer = 18,
        k_eJoinFailed = 19,
    }
}
public record CMsgClientToGCCoachFriend(uint target_account_id) : DotaPacket;
public record CMsgClientToGCCoachFriendResponse(CMsgClientToGCCoachFriendResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eCoachNotSubscriber = 5,
        k_eLobbyNotFound = 6,
        k_eFriendsOnBothSides = 7,
        k_eNotFriends = 8,
        k_eCoachInThisLobby = 9,
        k_eCoachInALobby = 10,
        k_eLobbyIsLan = 11,
        k_eInvalidLobbyType = 12,
        k_eInvalidLobbyState = 13,
        k_eFriendIsNotAPlayer = 14,
        k_eTooManyCoaches = 15,
        k_eCoachSwitchedTeams = 16,
        k_eLobbyIsLeague = 17,
        k_eCoachWasPlayer = 18,
        k_eRequestRejected = 19,
    }
}
public record CMsgClientToGCRespondToCoachFriendRequest(uint coach_account_id, ELobbyMemberCoachRequestState response) : DotaPacket;
public record CMsgClientToGCRespondToCoachFriendRequestResponse(CMsgClientToGCRespondToCoachFriendRequestResponse.EResponse result) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eLobbyNotFound = 5,
        k_eInvalidLobbyState = 6,
        k_eCoachNotInLobby = 7,
        k_ePlayerInvalidTeam = 8,
        k_eCoachInvalidTeam = 9,
        k_eNoRequest = 10,
        k_eInvalidResponse = 11,
        k_eAlreadyResponded = 12,
    }
}
