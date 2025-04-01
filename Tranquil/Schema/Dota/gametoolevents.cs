namespace Tranquil.Schema;

public record ChangeMapToolEvent(string mapname) : DotaPacket;
public record TraceRayServerToolEvent(CMsgVector start, CMsgVector end) : DotaPacket;
public record ToolTraceRayResult(bool hit, CMsgVector impact, CMsgVector normal, float distance, float fraction, int ehandle) : DotaPacket;
public record SpawnEntityToolEvent(byte[] entity_keyvalues, bool clientsideentity) : DotaPacket;
public record SpawnEntityToolEventResult(int ehandle) : DotaPacket;
public record DestroyEntityToolEvent(int ehandle) : DotaPacket;
public record DestroyAllEntitiesToolEvent : DotaPacket;
public record RestartMapToolEvent : DotaPacket;
public record ToolEvent_GetEntityInfo(int ehandle, bool clientsideentity) : DotaPacket;
public record ToolEvent_GetEntityInfoResult(string cppclass, string classname, string name, CMsgVector origin, CMsgVector mins, CMsgVector maxs) : DotaPacket;
public record ToolEvent_GetEntityInputs(int ehandle, bool clientsideentity) : DotaPacket;
public record ToolEvent_GetEntityInputsResult(List<string> input_list) : DotaPacket;
public record ToolEvent_FireEntityInput(int ehandle, bool clientsideentity, string input_name, string input_param) : DotaPacket;
public record ToolEvent_SFMRecordingStateChanged(bool isrecording) : DotaPacket;
public record ToolEvent_SFMToolActiveStateChanged(bool isactive) : DotaPacket;
