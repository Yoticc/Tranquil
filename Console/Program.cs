using ProtoToRecord;
using System.Net;
using Tranquil;
using Tranquil.IO;
using Tranquil.Schema;
/*
var directory = @"C:\Data\programming\vs projects\repos\Tranquil\Tranquil\Schema\Dota\";
var baseUrl = "https://raw.githubusercontent.com/SteamDatabase/Protobufs/refs/heads/master/dota2/";
string[] entries = 
[
    "base_gcmessages",
    "c_peer2peer_netmessages",
    "clientmessages",
    "connectionless_netmessages",
    "demo",
    "dota_broadcastmessages",
    "dota_client_enums",
    "dota_clientmessages",
    "dota_commonmessages",
    "dota_fighting_game_p2p_messages",
    "dota_gcmessages_client",
    "dota_gcmessages_client_battle_report",
    "dota_gcmessages_client_bingo",
    "dota_gcmessages_client_candy_shop",
    "dota_gcmessages_client_chat",
    "dota_gcmessages_client_coaching",
    "dota_gcmessages_client_craftworks",
    "dota_gcmessages_client_fantasy",
    "dota_gcmessages_client_guild",
    "dota_gcmessages_client_guild_events",
    "dota_gcmessages_client_match_management",
    "dota_gcmessages_client_showcase",
    "dota_gcmessages_client_team",
    "dota_gcmessages_client_tournament",
    "dota_gcmessages_client_watch",
    "dota_gcmessages_common",
    "dota_gcmessages_common_bot_script",
    "dota_gcmessages_common_craftworks",
    "dota_gcmessages_common_fighting_game",
    "dota_gcmessages_common_league",
    "dota_gcmessages_common_lobby",
    "dota_gcmessages_common_match_management",
    "dota_gcmessages_common_overworld",
    "dota_gcmessages_common_survivors",
    "dota_gcmessages_msgid",
    "dota_gcmessages_server",
    "dota_gcmessages_webapi",
    "dota_hud_types",
    "dota_match_metadata",
    "dota_messages_mlbot",
    "dota_modifiers",
    "dota_scenariomessages",
    "dota_shared_enums",
    "dota_usercmd",
    "dota_usermessages",
    "econ_gcmessages",
    "econ_shared_enums",
    "engine_gcmessages",
    "enums_clientserver",
    "gameevents",
    "gametoolevents",
    "gcsdk_gcmessages",
    "gcsystemmsgs",
    "netmessages",
    "network_connection",
    "networkbasetypes",
    "networksystem_protomessages",
    "prediction_events",
    "steamdatagram_messages_auth",
    "steamdatagram_messages_sdr",
    "steammessages",
    "steammessages_base",
    "steammessages_clientserver_login",
    "steammessages_cloud.steamworkssdk",
    "steammessages_gamenetworkingui",
    "steammessages_helprequest.steamworkssdk",
    "steammessages_int",
    "steammessages_oauth.steamworkssdk",
    "steammessages_player.steamworkssdk",
    "steammessages_publishedfile.steamworkssdk",
    "steammessages_steamlearn.steamworkssdk",
    "steammessages_unified_base.steamworkssdk",
    "steamnetworkingsockets_messages",
    "steamnetworkingsockets_messages_certs",
    "steamnetworkingsockets_messages_udp",
    "te",
    "uifontfile_format",
    "usercmd",
    "usermessages",
    "valveextensions",
];

foreach (var entry in entries)
{
    var protoText = new WebClient().DownloadString($"{baseUrl}{entry}.proto");
    var proto = Proto.Parse(protoText);
    var fileText = proto.SerialzieToFile();
    var filePath = Path.Combine(directory, $"{entry}.cs");
    File.WriteAllText(filePath, fileText);
}

_ = 3;
*/


const string path = @"C:\\Program Files\Steam\steamapps\common\dota 2 beta\game\dota\replays\8234860584.dem";
var demo = new Demo(path);

List<DotaPacket> packets = [];
foreach (var packet in demo.DemoPackets.Packet)
{
    var bytes = packet.data;
    var reader = new DotaBitStream(bytes);
    while (reader.position < bytes.Length)
    {
        var packetId = (int)reader.ReadUBitVar();
        var length = reader.ReadVarUint32();

        var buffer = reader.ReadBytes(length);
        var type = DotaPacket.PacketTypes[packetId];
        if (type != null)
        {
            var stream = new ProtobufStream2(buffer);
            var dotaPacket = ProtobufDeserializer.Deserialize(stream, type) as DotaPacket;
            if (dotaPacket == null)
                throw new Exception();
            packets.Add(dotaPacket);
        }
        //else Console.WriteLine($"unknown packet id {packetId}");
    }

    _ = 3;
}

_ = 3;

/*
 
var ee =File.ReadAllText(@"C:\a.txt")
.Split("case ")
.Skip(1)
.Select(
    line => (
        id: int.Parse(new string(line.TakeWhile(c => c != ':').ToArray())),
        name: new string(
            line
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .Skip(1)
            .TakeWhile(c => c != '\n')
            .Skip(9)
            .TakeWhile(c => c != ' ')
            .ToArray()
        )
    )
).ToArray();

for (var i = 0; i < 630; i++)
{
    var start = $"         {i,-3} ";
    if (ee.Any(e => e.id == i))
{
    var name = ee.First(e => e.id == i).name;
    Console.WriteLine($"{start}typeof({name}),");
}
else Console.WriteLine($"{start}null,");
}
*/


/*
 
var ee = File.ReadAllText(@"C:\a.txt")
.Split("case ")
.Skip(1)
.Select(
    line => (
        id: int.Parse(new string(line.TakeWhile(c => c != ':').ToArray())),
        name: new string(
            line
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .SkipWhile(c => c != '\n')
            .Skip(1)
            .TakeWhile(c => c != '\n')
            .Skip(9)
            .TakeWhile(c => c != ' ')
            .ToArray()
        )
    )
).ToArray();

for (var i = 0; i < 630; i++)
{
    var start = $"         {i,-3} ";
    if (ee.Any(e => e.id == i))
    {
        var name = ee.First(e => e.id == i).name;
        Console.WriteLine($"{start}typeof({name}),");
    }
    else Console.WriteLine($"{start}null,");
}

*/