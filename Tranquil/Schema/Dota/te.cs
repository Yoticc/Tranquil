namespace Tranquil.Schema;

public enum ETEProtobufIds
{
    TE_EffectDispatchId = 400,
    TE_ArmorRicochetId = 401,
    TE_BeamEntPointId = 402,
    TE_BeamEntsId = 403,
    TE_BeamPointsId = 404,
    TE_BeamRingId = 405,
    TE_BSPDecalId = 407,
    TE_BubblesId = 408,
    TE_BubbleTrailId = 409,
    TE_DecalId = 410,
    TE_WorldDecalId = 411,
    TE_EnergySplashId = 412,
    TE_FizzId = 413,
    TE_ShatterSurfaceId = 414,
    TE_GlowSpriteId = 415,
    TE_ImpactId = 416,
    TE_MuzzleFlashId = 417,
    TE_BloodStreamId = 418,
    TE_ExplosionId = 419,
    TE_DustId = 420,
    TE_LargeFunnelId = 421,
    TE_SparksId = 422,
    TE_PhysicsPropId = 423,
    TE_PlayerDecalId = 424,
    TE_ProjectedDecalId = 425,
    TE_SmokeId = 426,
}
public record CMsgTEArmorRicochet(CMsgVector pos, CMsgVector dir) : DotaPacket;
public record CMsgTEBaseBeam(long SF2modelindex, long SF2haloindex, uint startframe, uint framerate, float life, float width, float endwidth, uint fadelength, float amplitude, int SF1color, uint speed, uint flags) : DotaPacket;
public record CMsgTEBeamEntPoint(CMsgTEBaseBeam _base, uint startentity, uint endentity, CMsgVector start, CMsgVector end) : DotaPacket;
public record CMsgTEBeamEnts(CMsgTEBaseBeam _base, uint startentity, uint endentity) : DotaPacket;
public record CMsgTEBeamPoints(CMsgTEBaseBeam _base, CMsgVector start, CMsgVector end) : DotaPacket;
public record CMsgTEBeamRing(CMsgTEBaseBeam _base, uint startentity, uint endentity) : DotaPacket;
public record CMsgTEBSPDecal(CMsgVector origin, CMsgVector normal, CMsgVector saxis, int entity, uint index) : DotaPacket;
public record CMsgTEBubbles(CMsgVector mins, CMsgVector maxs, float height, uint count, float speed) : DotaPacket;
public record CMsgTEBubbleTrail(CMsgVector mins, CMsgVector maxs, float waterz, uint count, float speed) : DotaPacket;
public record CMsgTEDecal(CMsgVector origin, CMsgVector start, int entity, uint hitbox, uint index) : DotaPacket;
public record CMsgEffectData(CMsgVector origin, CMsgVector start, CMsgVector normal, CMsgQAngle angles, int SF1entity, int SF1otherentity, float scale, float magnitude, float radius, int SF1surfaceprop, long SF2effectindex, uint damagetype, uint material, uint hitbox, uint color, uint flags, int attachmentindex, uint effectname, uint attachmentname) : DotaPacket;
public record CMsgTEEffectDispatch(CMsgEffectData effectdata) : DotaPacket;
public record CMsgTEEnergySplash(CMsgVector pos, CMsgVector dir, bool explosive) : DotaPacket;
public record CMsgTEFizz(int entity, uint density, int current) : DotaPacket;
public record CMsgTEShatterSurface(CMsgVector origin, CMsgQAngle angles, CMsgVector force, CMsgVector forcepos, float width, float height, float shardsize, uint surfacetype, int SF1frontcolor, int SF1backcolor) : DotaPacket;
public record CMsgTEGlowSprite(CMsgVector origin, float scale, float life, uint brightness) : DotaPacket;
public record CMsgTEImpact(CMsgVector origin, CMsgVector normal, uint type) : DotaPacket;
public record CMsgTEMuzzleFlash(CMsgVector origin, CMsgQAngle angles, float scale, uint type) : DotaPacket;
public record CMsgTEBloodStream(CMsgVector origin, CMsgVector direction, int SF1color, uint amount) : DotaPacket;
public record CMsgTEExplosion(CMsgVector origin, bool unused2, uint flags, CMsgVector normal, bool unused5, uint radius, uint magnitude, bool unused8, bool affect_ragdolls, string sound_name, uint explosion_type, bool create_debris, CMsgVector debris_origin, int SF1debris_surfaceprop) : DotaPacket;
public record CMsgTEDust(CMsgVector origin, float size, float speed, CMsgVector direction) : DotaPacket;
public record CMsgTELargeFunnel(CMsgVector origin, uint reversed) : DotaPacket;
public record CMsgTESparks(CMsgVector origin, uint magnitude, uint length, CMsgVector direction) : DotaPacket;
public record CMsgTEPhysicsProp(CMsgVector origin, CMsgVector velocity, CMsgQAngle angles, int SF1skin, uint flags, uint effects, int SF1color, long SF2modelindex, uint unused_breakmodelsnottomake, float scale, CMsgVector dmgpos, CMsgVector dmgdir, int dmgtype) : DotaPacket;
public record CMsgTEPlayerDecal(CMsgVector origin, int player, int entity) : DotaPacket;
public record CMsgTEProjectedDecal(CMsgVector origin, CMsgQAngle angles, uint index, float distance) : DotaPacket;
public record CMsgTESmoke(CMsgVector origin, float scale) : DotaPacket;
public record CMsgTEWorldDecal(CMsgVector origin, CMsgVector normal, uint index) : DotaPacket;
