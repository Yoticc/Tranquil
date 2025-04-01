using System.Runtime.CompilerServices;
using System.Text;
using static ProtoToRecord.ProtoMessage;
using static ProtoToRecord.ProtoMessage.Field;

namespace ProtoToRecord;
public class Proto
{
    public List<ProtoEnum> Enums = [];
    public List<ProtoMessage> Messages = [];

    public string SerialzieToFile()
    {
        var sb = new StringBuilder();
        int tab = 0;

        Line("using Tranquil.Schema.Dota;");
        Line();
        Line("namespace Tranquil.Schema;");
        Line();

        foreach (var penum in Enums)
            Enum(penum);

        foreach (var message in Messages)
            Message(message, false);

        return sb.ToString();

        void Message(ProtoMessage message, bool isNested)
        {
            var header = $"public record {message.Name}{SerializeFields()}{(isNested ? "" : " : DotaPacket")}";

            if (message.Enums.Count != 0 || message.Messages.Count != 0)
            {
                Line(header);
                Line("{");
                tab++;

                foreach (var nestedEnum in message.Enums)
                    Enum(nestedEnum);

                foreach (var nestedMessage in message.Messages)
                    Message(nestedMessage, true);

                tab--;
                Line("}");
            }
            else Line(header + ';');

            string SerializeFields()
            {
                if (message.Fields.Count == 0)
                    return "";

                var fields = message.Fields.OrderBy(f => f.Tag).ToList();
                var maxTag = message.Fields.Last().Tag;
                for (var i = 1; i < maxTag; i++)
                {
                    var index = i - 1;
                    var existField = fields[index];
                    if (existField.Tag != i)
                    {
                        var field = new Field(Attributes.None, Types.Bool, $"unused{i}", i);
                        fields.Insert(index, field);
                    }
                }

                List<string> stringFields = [];
                foreach (var field in fields)
                {
                    var stringField = SerializeField(field);
                    stringFields.Add(stringField);
                }

                return $"({string.Join(", ", stringFields)})";
            }

            string SerializeField(Field field)
            {
                var type = field.ToCSharpType();
                var name = field.ToCSharpName();

                return $"{type} {name}";
            }
        }

        void Enum(ProtoEnum penum)
        {
            Line($"public enum {penum.Name}");
            Line("{");
            tab++;

            foreach (var entry in penum.Entries)
                Line($"{entry.Name} = {entry.Value},");

            tab--;
            Line("}");
        }

        void Line(string? line = null)
        {
            if (line is null)
            {
                sb.AppendLine();
                return;
            }

            line = new string(' ', tab * 4) + line;
            sb.AppendLine(line);
        }        
    }

    public static Proto Parse(string text)
    {
        var lines =
            text
            .Replace("\r", "")
            .Replace("\t", "")
            .Split('\n')
            .Select(line => line.TrimStart(' '))
            .Where(line => !line.StartsWith("option ") && !line.StartsWith("extensions "))
            .ToArray();
        lines = RemoveOneOf(lines);

        var self = new Proto();

        var index = 0;

        while (index < lines.Length)
        {   
            var line = lines[index++];
            var parts = line.Split(' ');
            var type = parts[0];
            if (type != "enum" && type != "message")
                continue;

            var name = parts[1];
            if (type == "enum")
            {
                var penum = ParseEnum(name, lines, ref index);
                self.Enums.Add(penum);
            }
            else if (type == "message")
            {
                var message = ParseMessage(name, lines, ref index);
                self.Messages.Add(message);
            }
        }
        
        return self;

        string[] RemoveOneOf(string[] input)
        {
            var output = input.ToList();

            for (var i = 0; i < output.Count; i++)
            { 
                if (output[i].StartsWith("oneof"))
                {
                    output.RemoveAt(i--);
                    for (var o = i; o < output.Count; o++)
                    {
                        if (output[o].StartsWith("}"))
                        {
                            output.RemoveAt(o);
                            break;
                        }
                    }
                }
            }

            return output.ToArray();
        }

        ProtoEnum ParseEnum(string enumName, string[] lines, ref int index)
        {
            var entries = new List<ProtoEnum.Entry>();
            var self = new ProtoEnum(enumName, entries);

            while (!lines[index].StartsWith('}'))
            {
                var line = lines[index++];
                var parts = line.Split(' ');
                var entryName = parts[0];
                var entryValue = int.Parse(new string(parts[2].TakeWhile(c => char.IsDigit(c) || c == '-').ToArray()));
                var entry = new ProtoEnum.Entry(entryName, entryValue);
                entries.Add(entry);
            }
            index++;

            return self;
        }

        ProtoMessage ParseMessage(string messageName, string[] lines, ref int index)
        {
            if (messageName == "CUserMsg_ParticleManager")
            {

            }

            var message = new ProtoMessage(messageName);

            while (!lines[index].StartsWith('}'))
            {
                var line = lines[index++];
                var parts = line.Split(' ');
                if (parts.Length > 1)
                {
                    var type = parts[0];
                    if (type == "enum")
                    {
                        var penum = ParseEnum(parts[1], lines, ref index);
                        message.Enums.Add(penum);
                    }
                    else if (type == "message")
                    {
                        if (parts[1] == "UpdateParticleShouldDraw")
                        {

                        }

                        var pmessage = ParseMessage(parts[1], lines, ref index);
                        message.Messages.Add(pmessage);
                    }
                    else
                    {
                        var field = ParseField(line);
                        message.Fields.Add(field);
                    }
                }
            }
            index++;

            return message;
        }

        Field ParseField(string line)
        {
            var parts = line.Split(" [")[0].Split(' ');

            Attributes attribute;
            int offset;
            if (parts.Length == 4)
            {
                attribute = Attributes.None;
                offset = 0;
            }
            else if (parts.Length == 5)
            {
                var attributeValue = parts[0];
                attribute = attributeValue switch
                {
                    "optional" => Attributes.Optional,
                    "repeated" => Attributes.Repeated,
                    "required" => Attributes.Required,
                    _ => throw new Exception("unknown field attribute")
                };
                offset = 1;
            }
            else
            {
                attribute = Attributes.None;
                offset = -1;
            }

            var typeName = parts[offset + 0];
            var type = ParseType(typeName);
            var name = parts[offset + 1];
            var tag = int.Parse(new string(parts[offset + 3].TakeWhile(char.IsDigit).ToArray()));

            var field = new Field(attribute, type, name, tag);
            if (type == Types.Message)
                field.TypeMessage = typeName.TrimStart('.');

            return field;
        }

        Types ParseType(string type)
        {
            foreach (var typeValue in Enum.GetValues<Types>())
                if (string.Equals(typeValue.ToString(), type, StringComparison.OrdinalIgnoreCase))
                    return typeValue;
            return Types.Message;
        }
    }
}

public record ProtoEnum(string Name, List<ProtoEnum.Entry> Entries)
{
    public record Entry(string Name, int Value);
}

public class ProtoMessage
{
    public ProtoMessage(string name) => Name = name;

    public string Name;
    public List<ProtoMessage> Messages = [];
    public List<ProtoEnum> Enums = [];
    public List<Field> Fields = [];

    public record Field(Attributes Attribute, Types Type, string Name, int Tag)
    {
        public string? TypeMessage;

        static string[] types = ["double", "float", "int", "long", "uint", "ulong", "int", "long", "int", "long", "int", "long", "bool", "string", "byte[]"];
        public string ToCSharpType()
        {
            var type = Type == Types.Message ? TypeMessage! : types[(int)Type];
            return Attribute == Attributes.Repeated ? $"List<{type}>" : type;
        }

        static string[] prefixes = ["", "", "", "", "", "", "SS1", "SS2", "SF1", "SF2", "SSF1", "SSF2", "", "", "", ""];
        static string[] blacknames = ["base", "event", "object", "base", "string", "private", "ref"];
        public string ToCSharpName()
        {
            var name = prefixes[(int)Type] + Name;
            if (blacknames.Contains(name))
                name = "_" + name;
            return name;
        }

        public enum Attributes
        {
            None = 0, 
            Optional = 1,
            Repeated = 2,
            Required = 4
        }

        public enum Types
        {
            Double, Float, Int32, Int64, UInt32, UInt64, SInt32, SInt64, Fixed32, Fixed64, SFixed32, SFixed64, Bool, String, Bytes, Message
        }        
    }
}