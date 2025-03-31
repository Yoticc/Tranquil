using System.Text;

namespace Tranquil.IO;
public class DotaBitStream
{
    public DotaBitStream(byte[] buffer)
    {
        this.buffer = buffer;
        size = buffer.Length;
    }

    byte[] buffer;
    int size;
    public int position;
    ulong bitVal;
    int bitCount;

    public int RemBits() => RemBytes() * 8 + bitCount;

    public int RemBytes() => size - position;

    public byte NextByte()
    {
        position += 1;
        if (position > size)
        {
            throw new InvalidOperationException($"nextByte: insufficient buffer ({position} of {size})");
        }
        return buffer[position - 1];
    }

    public uint ReadBits(uint n)
    {
        while (n > bitCount)
        {
            bitVal |= (ulong)NextByte() << bitCount;
            bitCount += 8;
        }

        ulong x = bitVal & ((1UL << (int)n) - 1);
        bitVal >>= (int)n;
        bitCount -= (int)n;

        return (uint)x;
    }

    public byte ReadByte() => bitCount == 0 ? NextByte() : (byte)ReadBits(8);

    public byte[] ReadBytes(uint n)
    {
        var result = new byte[n];
        if (bitCount == 0)
        {
            position += (int)n;
            if (position > size)
            {
                throw new InvalidOperationException($"readBytes: insufficient buffer ({position} of {size})");
            }
            Array.Copy(buffer, position - (int)n, result, 0, (int)n);
            return result;
        }
        else
        {
            for (int i = 0; i < n; i++)
                result[i] = (byte)ReadBits(8);
            return result;
        }
    }

    public uint ReadLeUint32()
    {
        byte[] bytes = ReadBytes(4);
        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(bytes);
        }
        return BitConverter.ToUInt32(bytes, 0);
    }

    public ulong ReadLeUint64()
    {
        byte[] bytes = ReadBytes(8);
        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(bytes);
        }
        return BitConverter.ToUInt64(bytes, 0);
    }

    public uint ReadVarUint32()
    {
        uint x = 0;
        int s = 0;
        while (true)
        {
            byte b = ReadByte();
            x |= (uint)(b & 0x7F) << s;
            s += 7;
            if ((b & 0x80) == 0 || s == 35)
            {
                break;
            }
        }
        return x;
    }

    public int ReadVarInt32()
    {
        uint ux = ReadVarUint32();
        int x = (int)(ux >> 1);
        if ((ux & 1) != 0)
        {
            x = ~x;
        }
        return x;
    }

    public ulong ReadVarUint64()
    {
        ulong x = 0;
        int s = 0;
        for (int i = 0; ; i++)
        {
            byte b = ReadByte();
            if (b < 0x80)
            {
                if (i > 9 || (i == 9 && b > 1))
                {
                    throw new InvalidOperationException("read overflow: varint overflows uint64");
                }
                return x | ((ulong)b << s);
            }
            x |= (ulong)(b & 0x7F) << s;
            s += 7;
        }
    }

    public long ReadVarInt64()
    {
        ulong ux = ReadVarUint64();
        long x = (long)(ux >> 1);
        if ((ux & 1) != 0)
        {
            x = ~x;
        }
        return x;
    }

    public bool ReadBoolean()
    {
        return ReadBits(1) == 1;
    }

    public float ReadFloat()
    {
        return BitConverter.ToSingle(BitConverter.GetBytes(ReadLeUint32()), 0);
    }

    public uint ReadUBitVar()
    {
        uint ret = ReadBits(6);
        switch (ret & 0x30)
        {
            case 16:
                ret = (ret & 15) | (ReadBits(4) << 4);
                break;
            case 32:
                ret = (ret & 15) | (ReadBits(8) << 4);
                break;
            case 48:
                ret = (ret & 15) | (ReadBits(28) << 4);
                break;
        }
        return ret;
    }

    public uint ReadUBitVarFP()
    {
        if (ReadBoolean())
        {
            return ReadBits(2);
        }
        if (ReadBoolean())
        {
            return ReadBits(4);
        }
        if (ReadBoolean())
        {
            return ReadBits(10);
        }
        if (ReadBoolean())
        {
            return ReadBits(17);
        }
        return ReadBits(31);
    }

    public string ReadStringN(uint n)
    {
        return Encoding.UTF8.GetString(ReadBytes(n));
    }

    public string ReadString()
    {
        var buf = new List<byte>();
        while (true)
        {
            byte b = ReadByte();
            if (b == 0)
            {
                break;
            }
            buf.Add(b);
        }
        return Encoding.UTF8.GetString(buf.ToArray());
    }

    public float ReadCoord()
    {
        float value = 0.0f;
        uint intval = ReadBits(1);
        uint fractval = ReadBits(1);
        bool signbit = false;

        if (intval != 0 || fractval != 0)
        {
            signbit = ReadBoolean();
            if (intval != 0)
            {
                intval = ReadBits(14) + 1;
            }
            if (fractval != 0)
            {
                fractval = ReadBits(5);
            }
            value = intval + fractval * (1.0f / (1 << 5));
            if (signbit)
            {
                value = -value;
            }
        }
        return value;
    }

    public float ReadAngle(uint n)
    {
        return (float)(ReadBits(n) * 360.0 / (1 << (int)n));
    }

    public float ReadNormal()
    {
        bool isNeg = ReadBoolean();
        uint len = ReadBits(11);
        float ret = (float)(len * (1.0 / (1 << 11) - 1.0));

        return isNeg ? -ret : ret;
    }

    public float[] Read3BitNormal()
    {
        float[] ret = new float[3] { 0.0f, 0.0f, 0.0f };
        bool hasX = ReadBoolean();
        bool hasY = ReadBoolean();

        if (hasX)
        {
            ret[0] = ReadNormal();
        }
        if (hasY)
        {
            ret[1] = ReadNormal();
        }

        bool negZ = ReadBoolean();
        float prodsum = ret[0] * ret[0] + ret[1] * ret[1];

        if (prodsum < 1.0f)
        {
            ret[2] = (float)Math.Sqrt(1.0 - prodsum);
        }
        else
        {
            ret[2] = 0.0f;
        }

        if (negZ)
        {
            ret[2] = -ret[2];
        }

        return ret;
    }

    public byte[] ReadBitsAsBytes(uint n)
    {
        var tmp = new List<byte>();
        while (n >= 8)
        {
            tmp.Add(ReadByte());
            n -= 8;
        }
        if (n > 0)
        {
            tmp.Add((byte)ReadBits(n));
        }
        return tmp.ToArray();
    }
}