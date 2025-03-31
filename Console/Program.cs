using Tranquil;
using Tranquil.IO;

const string path = @"C:\\Program Files\Steam\steamapps\common\dota 2 beta\game\dota\replays\8234860584.dem";
var demo = new Demo(path);

foreach (var packet in demo.DemoPackets.Packet)
{
    var bytes = packet.Data;
    List<(int id, byte[] buffer)> packets = new List<(int id, byte[] buffer)>();
    var reader = new DotaBitStream(bytes);
    while (reader.position < bytes.Length)
    {
        var packetId = (int)reader.ReadUBitVar();
        var length = reader.ReadVarUint32();

        var buffer = reader.ReadBytes(length);
        packets.Add((packetId, buffer));
        //Console.WriteLine($"{packetId} {length}");
    }

    _ = 3;
}