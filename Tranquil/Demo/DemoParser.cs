using Snappier;
using System.Buffers;
using System.Reflection;
using Tranquil.IO;
using Tranquil.Schema;

namespace Tranquil;
public unsafe static class DemoParser
{
    public static void Parse(Demo demo, ProtobufStream stream)
    {
        const int IsCompressedFlag = 0x40;

        int tick = default;
        int size = default;

        var handlers =
            typeof(DemoPackets)
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
            .Select(field => field.FieldType.IsGenericType ? (
                packetType: field.FieldType.GenericTypeArguments[0],
                method: field.FieldType.GetMethod("Add"),
                list: field.GetValue(demo.DemoPackets)!
            ) : default)
            .Select(pair => (Action)(
                pair.list is not null
                ? () => pair.method!.Invoke(pair.list, [stream.ReadMessage(pair.packetType!)])
                : () => stream.SkipBytes(size)
            ))
            .ToArray();

        stream.SkipBytes(0x10);

        while (!stream.IsEnd)
        {
            var command = stream.ReadVarInt();
            var messageId = command & ~IsCompressedFlag;
            var isCompressed = (command & IsCompressedFlag) != 0;

            tick = stream.ReadVarInt();
            size = stream.ReadVarInt();

            var started = stream.Pointer;

            if (isCompressed)
            {
                var mainStream = stream;

                using IMemoryOwner<byte> decompressedMemory = Snappy.DecompressToMemory(new Span<byte>(stream.Pointer, size));

                var memory = decompressedMemory.Memory;
                stream = new ProtobufStream((byte*)memory.Pin().Pointer, memory.Length);

                handlers[messageId]();

                stream = mainStream;
                stream.SkipBytes(size);
            }
            else handlers[messageId]();
        }
    }
}