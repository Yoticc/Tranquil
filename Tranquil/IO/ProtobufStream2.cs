using System.Runtime.InteropServices;

namespace Tranquil.IO;
public unsafe class ProtobufStream2 : ProtobufStream, IDisposable
{
    public ProtobufStream2(byte[] bytes) : base((byte*)GCHandle.Alloc(bytes, GCHandleType.Pinned).AddrOfPinnedObject(), bytes.Length)
    => gchandle = GCHandle.FromIntPtr((nint)pointer);

    GCHandle gchandle;

    public void Dispose() => gchandle.Free();
}