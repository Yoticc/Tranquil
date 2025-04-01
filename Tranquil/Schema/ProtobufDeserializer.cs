using System.Reflection;
using Tranquil.IO;

namespace Tranquil.Schema;
public static class ProtobufDeserializer
{
    public static T Deserialize<T>(ProtobufStream stream) => (T)Deserialize(stream, typeof(T));
    public static object Deserialize(ProtobufStream stream, Type type)
    {
        if (type.FullName == "Tranquil.Schema.CMsgSosStartSoundEvent")
        {

        }

        var instance = Instancer.CreateNewInstance(type);
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
        var fieldtag = 0;

        foreach (var field in fields)
        {
            var tag = stream.RequestReadTag();
            if (++fieldtag != tag)
                continue;
            stream.ApproveReadTag();

            var fieldType = field.FieldType;
            if (fieldType == typeof(string)) field.SetValue(instance, stream.ReadString());
            else if (fieldType == typeof(int))
            {
                if (field.Name.StartsWith("<SF1") || field.Name.StartsWith("<SSF1"))
                    field.SetValue(instance, stream.Read<int>());
                else field.SetValue(instance, stream.ReadVarInt());
            }
            else if (fieldType == typeof(uint))
                field.SetValue(instance, stream.ReadVarUInt());
            else if (fieldType == typeof(long))
            {
                if (field.Name.StartsWith("<SF2") || field.Name.StartsWith("<SSF2"))
                    field.SetValue(instance, stream.Read<long>());
                else field.SetValue(instance, stream.ReadVarLong());
            }
            else if (fieldType == typeof(ulong)) field.SetValue(instance, stream.ReadVarULong());
            else if (fieldType == typeof(float)) field.SetValue(instance, stream.Read<float>());
            else if (fieldType == typeof(bool)) field.SetValue(instance, stream.Read<bool>());
            else if (fieldType.IsArray && fieldType.GetElementType() == typeof(byte))
                field.SetValue(instance, stream.ReadByteArray());
            else if (fieldType.IsEnum)
                field.SetValue(instance, stream.ReadVarInt());
            else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
            {
                var value = Instancer.CreateNewInstance(fieldType);
                var elementType = fieldType.GetGenericArguments()[0];
                var addMethod = typeof(List<>).MakeGenericType(elementType).GetMethod("Add")!;

                var lastTag = tag;
                while (lastTag == tag)
                {
                    stream.ApproveReadTag();
                    var len = stream.ReadVarInt();

                    object elementValue;
                    if (fieldType.GenericTypeArguments[0] == typeof(byte[]))
                        elementValue = stream.ReadBytes(len);
                    else if (fieldType.GenericTypeArguments[0] == typeof(int))
                        elementValue = stream.ReadVarInt();
                    else elementValue = Deserialize(stream, elementType);
                    addMethod.Invoke(value, [elementValue]);
                    tag = stream.RequestReadTag();
                }
                field.SetValue(instance, value);
            }
            else
            {
                stream.ReadVarInt();
                var value = Deserialize(stream, fieldType);
                field.SetValue(instance, value);
            }
        }

        stream.RejectReadTag();
        return instance;
    }
}
