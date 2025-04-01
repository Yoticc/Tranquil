using Tranquil.Schema;

namespace Tranquil.IO;
public unsafe class ProtobufStream
{
    public ProtobufStream(byte* pointer, int length)
    {
        this.pointer = initialPointer = pointer;
        endPointer = pointer + length;
    }

    protected byte* initialPointer, endPointer, pointer;

    public byte* Pointer => pointer;
    public int BytesRead => (int)(pointer - initialPointer);
    public bool IsEnd => pointer == endPointer;

    public void SkipBytes(int count) => pointer += count;

    protected byte* lastTagReadBefore, lastTagRead;
    public int RequestReadTag()
    {
        if (pointer == endPointer)
            return -1;

        if (pointer == lastTagRead)
        {
            pointer = lastTagReadBefore;
            return ReadVarInt() >> 3;
        }

        lastTagReadBefore = pointer;
        var tag = ReadVarInt() >> 3;
        lastTagRead = pointer;
        return tag;
    }

    public int ReadTag()
    {
        var tag = RequestReadTag();
        ApproveReadTag();
        return tag;
    }

    public void ApproveReadTag() => lastTagRead = null;

    public void RejectReadTag()
    {
        if (pointer == lastTagRead)
        {
            pointer = lastTagReadBefore;
            lastTagRead = null;
        }
    }

    public T ReadMessage<T>() => (T)ReadMessage(typeof(T));

    public object ReadMessage(Type type) => ProtobufDeserializer.Deserialize(this, type);

    public T ReadEnum<T>() where T : struct, Enum => (T)(object)ReadVarInt();

    public string ReadString()
    {
        var length = ReadVarInt();
        var result = new string((sbyte*)pointer, 0, length);
        pointer += length;
        return result;
    }

    public byte[] ReadByteArray() => ReadBytes(ReadVarInt());

    public byte[] ReadBytes(int count)
    {
        var array = new Span<byte>(pointer, count).ToArray();
        pointer += count;
        return array;
    }

    public uint ReadVarUInt() => unchecked((uint)ReadVarInt());

    public int ReadVarInt()
    {
        var pointer = this.pointer;

        var single = *pointer++;
        var result = single & 0x7F;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x07;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x0E;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x15;
        if ((single & 0x80) == 0) goto End;
        result |= (*pointer++ & 0x0F) << 0x1C;

    End:
        this.pointer = pointer;
        return result;
    }

    public ulong ReadVarULong() => unchecked((ulong)ReadVarLong());

    public long ReadVarLong()
    {
        var pointer = this.pointer;

        var single = (long)*pointer++;
        var result = single & 0x7F;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x07;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x0E;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x15;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x1C;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x23;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x2A;
        if ((single & 0x80) == 0) goto End;
        result |= ((single = *pointer++) & 0x7F) << 0x31;
        if ((single & 0x80) == 0) goto End;
        result |= (long)*pointer++ << 0x38;

    End:
        this.pointer = pointer;
        return result;
    }

    public T Read<T>() where T : unmanaged
    {
        var result = *(T*)pointer;
        pointer += sizeof(T);
        return result;
    }
}