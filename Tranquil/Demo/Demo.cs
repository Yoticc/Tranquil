using Tranquil.IO;

namespace Tranquil;
public class Demo
{
    public Demo(string path) : this(File.ReadAllBytes(path)) { }
    public Demo(byte[] bytes) : this(new ProtobufStream2(bytes)) { }
    public Demo(ProtobufStream stream) => DemoParser.Parse(this, stream);

    public DemoPacketCollection DemoPackets = new DemoPacketCollection();
}