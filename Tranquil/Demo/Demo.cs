using Tranquil.IO;
using Tranquil.Schema.Dota;

namespace Tranquil;
public class Demo
{
    public Demo(string path) : this(File.ReadAllBytes(path)) { }
    public Demo(byte[] bytes) : this(new ProtobufStream2(bytes)) { }
    public Demo(ProtobufStream stream) => DemoParser.Parse(this, stream);

    public DemoPacketCollection DemoPackets = new DemoPacketCollection();
    public List<DotaPacket> DotaPackets = new List<DotaPacket>();
}