using Tranquil.Schema.Demo;

namespace Tranquil;
public class DemoPacketCollection
{
    /* 0  */ object? Stop;
    /* 1  */ public List<CDemoFileHeader> FileHeader = [];
    /* 2  */ public List<CDemoFileInfo> FileInfo = [];
    /* 3  */ object? SyncTick;
    /* 4  */ public List<CDemoSendTables> SendTables = [];
    /* 5  */ public List<CDemoClassInfo> ClassInfo = [];
    /* 6  */ public List<CDemoStringTables> StringTables = [];
    /* 7  */ public List<CDemoPacket> Packet = [];
    /* 8  */ object? SignonPacket;
    /* 9  */ public List<CDemoConsoleCmd> ConsoleCmd = [];
    /* 10 */ public List<CDemoCustomData> CustomData = [];
    /* 11 */ public List<CDemoCustomDataCallbacks> CustomDataCallbacks = [];
    /* 12 */ public List<CDemoUserCmd> UserCmd = [];
    /* 13 */ public List<CDemoFullPacket> FullPacket = [];
    /* 14 */ public List<CDemoSaveGame> SaveGame = [];
    /* 15 */ public List<CDemoSpawnGroups> SpawnGroups = [];
    /* 16 */ public List<CDemoAnimationData> AnimationData = [];
    /* 17 */ public List<CDemoAnimationHeader> AnimationHeader = [];
    /* 18 */ public List<CDemoRecovery> Recovery = [];
}