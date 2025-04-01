using Tranquil.Schema.Dota;

namespace Tranquil.Schema;

public record CEngineGotvSyncPacket(ulong match_id, uint instance_id, uint signupfragment, uint currentfragment, float tickrate, uint tick, bool unused7, float rtdelay, float rcvage, float keyframe_interval, uint cdndelay) : DotaPacket;
