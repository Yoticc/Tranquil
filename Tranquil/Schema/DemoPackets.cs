namespace Tranquil.Schema;
public record CDemoFileHeader
(
    string DemoFileStamp,
    int NetworkProtocol,
    string ServerName,
    string ClientName,
    string MapName,
    string GameDirectory,
    int FullpacketsVersion,
    bool AllowClientsideEntities,
    bool AllowClientsideParticles,
    string Addons,
    string DemoVersionName,
    string DemoVersionGuid,
    int BuildNum,
    string Game,
    int ServerStartTick
);
public record CGameInfo(int unused0, int unused1, int unused3, CGameInfo.CDotaGameInfo Dota)
{
    public record CDotaGameInfo
    (
        int MatchId,
        int GameMode,
        int GameWinner,
        List<CDotaGameInfo.CPlayerInfo> PlayerInfo,
        int LeagueId,
        List<CDotaGameInfo.CHeroSelectEvent> PicksBans,
        int RadiantTeamId,
        int DireTeamId,
        string RadiantTeamTag,
        string DireTeamTag,
        int EndTime
    )
    {
        public record CPlayerInfo(string HeroName, string PlayerName, bool IsFakeClient, long SteamId, int GameTeam);
        public record CHeroSelectEvent(bool IsPick, int Team, int HeroId);
    }
}
public record CDemoFileInfo(float PlaybackTime, int PlaybackTicks, int PlaybackFrames, CGameInfo GameInfo);
public record CDemoPacket(int unused0, int unused1, byte[] Data);
public record CDemoFullPacket(CDemoStringTables StringTable, CDemoPacket Packet);
public record CDemoSaveGame(byte[] Data, long SteamId, long Signature, int Version);
public record CDemoSyncTick;
public record CDemoConsoleCmd(string CmdString);
public record CDemoSendTables(byte[] Data);
public record CDemoClassInfo(List<CDemoClassInfo.Class> Classes)
{
    public record Class(int ClassId, string NetworkName, string TableName);
}
public record CDemoCustomData(int CallbackIndex, byte[] Data);
public record CDemoCustomDataCallbacks(List<string> SaveId);
public record CDemoAnimationHeader(int EntityId, int Tick, byte[] Data);
public record CDemoAnimationData(int EntityId, int StartTick, int EndTick, byte[] Data, long DataChecksum);
public record CDemoStringTables(List<CDemoStringTables.Table> Tables)
{
    public record Items(string String, byte[] Data);
    public record Table(string TableName, List<Items> Items, List<Items> ItemsClientside, int TableFlags);
}
public record CDemoStop;
public record CDemoUserCmd(int CmdNumber, byte[] Data);
public record CDemoSpawnGroups(int unused0, int unused1, List<byte[]> Messages);
public record CDemoRecovery(CDemoRecovery.DemoInitialSpawnGroupEntry InitialSpawnGroup, byte[] SpawnGroupMessage)
{
    public record DemoInitialSpawnGroupEntry(int SpawngroupHandle, bool WasCreated);
}