using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CMsgClientToGCFightingGameChallengeFriend(uint friend_account_id) : DotaPacket;
public record CMsgClientToGCFightingGameChallengeFriendResponse(CMsgClientToGCFightingGameChallengeFriendResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidAccountID = 5,
        k_eStillWaitingOnAnotherChallenge = 6,
    }
}
public record CMsgClientToGCFightingGameCancelChallengeFriend(uint friend_account_id) : DotaPacket;
public record CMsgClientToGCFightingGameAnswerChallenge(uint challenger_account_id, bool accept) : DotaPacket;
public record CMsgClientToGCFightingGameAnswerChallengeResponse(CMsgClientToGCFightingGameAnswerChallengeResponse.EResponse response) : DotaPacket
{
    public enum EResponse
    {
        k_eInternalError = 0,
        k_eSuccess = 1,
        k_eTooBusy = 2,
        k_eDisabled = 3,
        k_eTimeout = 4,
        k_eInvalidChallenge = 5,
    }
}
public record CMsgGCToClientFightingGameChallenge(uint challenger_account_id) : DotaPacket;
public record CMsgGCToClientFightingGameChallengeCanceled(uint challenger_account_id, uint responder_account_id) : DotaPacket;
public record CMsgGCToClientFightingGameStartMatch(uint challenger_account_id, uint responder_account_id) : DotaPacket;
